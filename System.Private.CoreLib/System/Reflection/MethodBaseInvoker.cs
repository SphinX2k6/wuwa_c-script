using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020006FC RID: 1788
	internal sealed class MethodBaseInvoker
	{
		// Token: 0x06007638 RID: 30264 RVA: 0x00119635 File Offset: 0x00117835
		internal MethodBaseInvoker(RuntimeMethodInfo method) : this(method, method.ArgumentTypes)
		{
			this._invocationFlags = method.ComputeAndUpdateInvocationFlags();
			this._invokeFunc_RefArgs = new InvokerEmitUtil.InvokeFunc_RefArgs(this.InterpretedInvoke_Method);
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00119662 File Offset: 0x00117862
		internal MethodBaseInvoker(RuntimeConstructorInfo constructor) : this(constructor, constructor.ArgumentTypes)
		{
			this._invocationFlags = constructor.ComputeAndUpdateInvocationFlags();
			this._invokeFunc_RefArgs = new InvokerEmitUtil.InvokeFunc_RefArgs(this.InterpretedInvoke_Constructor);
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00119690 File Offset: 0x00117890
		private unsafe object InterpretedInvoke_Method(object obj, IntPtr* args)
		{
			Exception ex;
			object result = ((RuntimeMethodInfo)this._method).InternalInvoke(obj, args, out ex);
			if (ex != null)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x001196B8 File Offset: 0x001178B8
		internal unsafe object InterpretedInvoke_Constructor(object obj, IntPtr* args)
		{
			Exception ex;
			object result = ((RuntimeConstructorInfo)this._method).InternalInvoke(obj, args, out ex);
			if (ex != null)
			{
				throw ex;
			}
			if (obj != null)
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x001196E5 File Offset: 0x001178E5
		private MethodBaseInvoker(MethodBase method, RuntimeType[] argumentTypes)
		{
			this._method = method;
			this._argTypes = argumentTypes;
			this._argCount = this._argTypes.Length;
			MethodInvokerCommon.Initialize(argumentTypes, out this._strategy, out this._invokerArgFlags, out this._needsByRefStrategy);
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00119721 File Offset: 0x00117921
		[DoesNotReturn]
		internal static void ThrowTargetParameterCountException()
		{
			throw new TargetParameterCountException(SR.Arg_ParmCnt);
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00119730 File Offset: 0x00117930
		internal object InvokeWithNoArgs(object obj, BindingFlags invokeAttr)
		{
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_RefArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_RefArgs(ref this._strategy, ref this._invokeFunc_RefArgs, this._method, true);
			}
			object result;
			try
			{
				result = this._invokeFunc_RefArgs(obj, null);
			}
			catch (Exception inner) when ((invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default)
			{
				throw new TargetInvocationException(inner);
			}
			return result;
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x001197A8 File Offset: 0x001179A8
		internal object InvokeWithOneArg(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			object obj2 = parameters[0];
			ReadOnlySpan<object> parameters2 = new ReadOnlySpan<object>(ref obj2);
			object obj3 = null;
			Span<object> span = new Span<object>(ref obj3);
			bool flag = false;
			Span<bool> shouldCopyBack = new Span<bool>(ref flag);
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(ref this._strategy, ref this._invokeFunc_ObjSpanArgs, this._method, this._needsByRefStrategy, true);
			}
			this.CheckArguments(parameters2, span, shouldCopyBack, binder, culture, invokeAttr);
			object result;
			if (this._invokeFunc_ObjSpanArgs != null)
			{
				try
				{
					result = this._invokeFunc_ObjSpanArgs(obj, span);
					goto IL_A3;
				}
				catch (Exception inner) when ((invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default)
				{
					throw new TargetInvocationException(inner);
				}
			}
			result = this.InvokeDirectByRefWithFewArgs(obj, span, invokeAttr);
			IL_A3:
			this.CopyBack(parameters, span, shouldCopyBack);
			return result;
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00119878 File Offset: 0x00117A78
		internal object InvokeWithFewArgs(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			MethodBase.StackAllocatedArgumentsWithCopyBack stackAllocatedArgumentsWithCopyBack = default(MethodBase.StackAllocatedArgumentsWithCopyBack);
			Span<object> span = <PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<object>, object>(ref stackAllocatedArgumentsWithCopyBack._args, 4).Slice(0, this._argCount);
			Span<bool> shouldCopyBack = <PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<bool>, bool>(ref stackAllocatedArgumentsWithCopyBack._shouldCopyBack, 4).Slice(0, this._argCount);
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(ref this._strategy, ref this._invokeFunc_ObjSpanArgs, this._method, this._needsByRefStrategy, true);
			}
			this.CheckArguments(parameters, span, shouldCopyBack, binder, culture, invokeAttr);
			object result;
			if (this._invokeFunc_ObjSpanArgs != null)
			{
				try
				{
					result = this._invokeFunc_ObjSpanArgs(obj, span);
					goto IL_C7;
				}
				catch (Exception inner) when ((invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default)
				{
					throw new TargetInvocationException(inner);
				}
			}
			result = this.InvokeDirectByRefWithFewArgs(obj, span, invokeAttr);
			IL_C7:
			this.CopyBack(parameters, span, shouldCopyBack);
			return result;
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00119968 File Offset: 0x00117B68
		internal unsafe object InvokeDirectByRefWithFewArgs(object obj, Span<object> copyOfArgs, BindingFlags invokeAttr)
		{
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_RefArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_RefArgs(ref this._strategy, ref this._invokeFunc_RefArgs, this._method, true);
			}
			MethodBase.StackAllocatedByRefs stackAllocatedByRefs = default(MethodBase.StackAllocatedByRefs);
			IntPtr* ptr = (IntPtr*)(&stackAllocatedByRefs);
			for (int i = 0; i < this._argCount; i++)
			{
				*(ByReference*)(ptr + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)) = (((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsValueType) != (MethodBase.InvokerArgFlags)0) ? ByReference.Create<byte>((*copyOfArgs[i]).GetRawData()) : ByReference.Create<object>(copyOfArgs[i]));
			}
			object result;
			try
			{
				result = this._invokeFunc_RefArgs(obj, ptr);
			}
			catch (Exception inner) when ((invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default)
			{
				throw new TargetInvocationException(inner);
			}
			return result;
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00119A3C File Offset: 0x00117C3C
		internal unsafe object InvokeWithManyArgs(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(ref this._strategy, ref this._invokeFunc_ObjSpanArgs, this._method, this._needsByRefStrategy, true);
			}
			Span<object> span;
			Span<bool> shouldCopyBack;
			object result;
			if (this._invokeFunc_ObjSpanArgs != null)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)(this._argCount * 2)) * 8)];
				NativeMemory.Clear((void*)ptr, (UIntPtr)((IntPtr)this._argCount * (IntPtr)8 * (IntPtr)2));
				span = new Span<object>(Unsafe.AsRef<object>((void*)ptr), this._argCount);
				new GCFrameRegistration((void*)ptr, (uint)this._argCount, false);
				shouldCopyBack = new Span<bool>((void*)(ptr + (IntPtr)this._argCount * 8 / (IntPtr)sizeof(IntPtr)), this._argCount);
				try
				{
					this.CheckArguments(parameters, span, shouldCopyBack, binder, culture, invokeAttr);
					try
					{
						result = this._invokeFunc_ObjSpanArgs(obj, span);
					}
					catch (Exception inner) when ((invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default)
					{
						throw new TargetInvocationException(inner);
					}
					this.CopyBack(parameters, span, shouldCopyBack);
					return result;
				}
				finally
				{
				}
			}
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_RefArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_RefArgs(ref this._strategy, ref this._invokeFunc_RefArgs, this._method, true);
			}
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)(3 * this._argCount)) * 8)];
			NativeMemory.Clear((void*)ptr2, (UIntPtr)((IntPtr)(3 * this._argCount) * (IntPtr)8));
			span = new Span<object>(Unsafe.AsRef<object>((void*)ptr2), this._argCount);
			new GCFrameRegistration((void*)ptr2, (uint)this._argCount, false);
			IntPtr* ptr3 = ptr2 + (IntPtr)this._argCount * 8 / (IntPtr)sizeof(IntPtr);
			new GCFrameRegistration((void*)ptr3, (uint)this._argCount, true);
			shouldCopyBack = new Span<bool>((void*)(ptr2 + (IntPtr)(this._argCount * 2) * 8 / (IntPtr)sizeof(IntPtr)), this._argCount);
			try
			{
				this.CheckArguments(parameters, span, shouldCopyBack, binder, culture, invokeAttr);
				for (int i = 0; i < this._argCount; i++)
				{
					*(ByReference*)(ptr3 + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)) = (((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsValueType) != (MethodBase.InvokerArgFlags)0) ? ByReference.Create<byte>((*Unsafe.AsRef<object>((void*)(ptr2 + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)))).GetRawData()) : ByReference.Create<object>(Unsafe.AsRef<object>((void*)(ptr2 + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)))));
				}
				try
				{
					result = this._invokeFunc_RefArgs(obj, ptr3);
				}
				catch (Exception inner2) when ((invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default)
				{
					throw new TargetInvocationException(inner2);
				}
				this.CopyBack(parameters, span, shouldCopyBack);
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00119CE0 File Offset: 0x00117EE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe void CopyBack(object[] dest, Span<object> copyOfParameters, Span<bool> shouldCopyBack)
		{
			for (int i = 0; i < dest.Length; i++)
			{
				if (*shouldCopyBack[i])
				{
					if ((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsNullableOfT) != (MethodBase.InvokerArgFlags)0)
					{
						dest[i] = RuntimeMethodHandle.ReboxFromNullable(*copyOfParameters[i]);
					}
					else
					{
						dest[i] = *copyOfParameters[i];
					}
				}
			}
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00119D34 File Offset: 0x00117F34
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe void CheckArguments(ReadOnlySpan<object> parameters, Span<object> copyOfParameters, Span<bool> shouldCopyBack, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
		{
			for (int i = 0; i < parameters.Length; i++)
			{
				object obj = *parameters[i];
				RuntimeType runtimeType = this._argTypes[i];
				if (obj == Type.Missing)
				{
					obj = MethodBase.HandleTypeMissing(*this._method.GetParametersAsSpan()[i], runtimeType);
					*shouldCopyBack[i] = true;
				}
				if (obj == null)
				{
					if ((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsValueType_ByRef_Or_Pointer) != (MethodBase.InvokerArgFlags)0)
					{
						*shouldCopyBack[i] = runtimeType.CheckValue(ref obj, binder, culture, invokeAttr);
					}
				}
				else if (obj.GetType() != runtimeType)
				{
					if (MethodBaseInvoker.TryByRefFastPath(runtimeType, ref obj))
					{
						*shouldCopyBack[i] = true;
					}
					else
					{
						*shouldCopyBack[i] = runtimeType.CheckValue(ref obj, binder, culture, invokeAttr);
					}
				}
				*copyOfParameters[i] = obj;
			}
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00119E04 File Offset: 0x00118004
		private static bool TryByRefFastPath(RuntimeType type, ref object arg)
		{
			RuntimeType runtimeType;
			if (RuntimeType.TryGetByRefElementType(type, out runtimeType) && runtimeType == arg.GetType())
			{
				if (runtimeType.IsValueType)
				{
					arg = RuntimeType.AllocateValueType(runtimeType, arg);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00119E3C File Offset: 0x0011803C
		internal unsafe object InvokeConstructorWithoutAlloc(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			bool flag = (invokeAttr & BindingFlags.DoNotWrapExceptions) == BindingFlags.Default;
			int argCount = this._argCount;
			int num = argCount;
			Span<bool> shouldCopyBack = new Span<bool>(stackalloc byte[(UIntPtr)num], num);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)(2 * argCount)) * 8)];
			NativeMemory.Clear((void*)ptr, (UIntPtr)((IntPtr)(2 * argCount) * (IntPtr)8));
			Span<object> copyOfParameters = new Span<object>(Unsafe.AsRef<object>((void*)ptr), argCount);
			new GCFrameRegistration((void*)ptr, (uint)argCount, false);
			IntPtr* ptr2 = ptr + (IntPtr)argCount * 8 / (IntPtr)sizeof(IntPtr);
			new GCFrameRegistration((void*)ptr2, (uint)argCount, true);
			object result;
			try
			{
				this.CheckArguments(parameters, copyOfParameters, shouldCopyBack, binder, culture, invokeAttr);
				for (int i = 0; i < argCount; i++)
				{
					*(ByReference*)(ptr2 + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)) = (((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsValueType) != (MethodBase.InvokerArgFlags)0) ? ByReference.Create<byte>((*Unsafe.AsRef<object>((void*)(ptr + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)))).GetRawData()) : ByReference.Create<object>(Unsafe.AsRef<object>((void*)(ptr + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)))));
				}
				object obj2;
				try
				{
					obj2 = this.InterpretedInvoke_Constructor(obj, ptr2);
				}
				catch (Exception inner) when (flag)
				{
					throw new TargetInvocationException(inner);
				}
				this.CopyBack(parameters, copyOfParameters, shouldCopyBack);
				result = obj2;
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00119F8C File Offset: 0x0011818C
		internal object InvokeConstructorWithoutAlloc(object obj, bool wrapInTargetInvocationException)
		{
			object result;
			try
			{
				result = this.InterpretedInvoke_Constructor(obj, null);
			}
			catch (Exception inner) when (wrapInTargetInvocationException)
			{
				throw new TargetInvocationException(inner);
			}
			return result;
		}

		// Token: 0x0400154B RID: 5451
		private InvokerEmitUtil.InvokeFunc_ObjSpanArgs _invokeFunc_ObjSpanArgs;

		// Token: 0x0400154C RID: 5452
		private InvokerEmitUtil.InvokeFunc_RefArgs _invokeFunc_RefArgs;

		// Token: 0x0400154D RID: 5453
		private MethodBase.InvokerStrategy _strategy;

		// Token: 0x0400154E RID: 5454
		internal readonly InvocationFlags _invocationFlags;

		// Token: 0x0400154F RID: 5455
		private readonly MethodBase.InvokerArgFlags[] _invokerArgFlags;

		// Token: 0x04001550 RID: 5456
		private readonly RuntimeType[] _argTypes;

		// Token: 0x04001551 RID: 5457
		private readonly MethodBase _method;

		// Token: 0x04001552 RID: 5458
		private readonly int _argCount;

		// Token: 0x04001553 RID: 5459
		private readonly bool _needsByRefStrategy;
	}
}
