using System;
using System.Reflection.Emit;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020006FD RID: 1789
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class MethodInvoker
	{
		// Token: 0x06007648 RID: 30280 RVA: 0x00119FD4 File Offset: 0x001181D4
		private MethodInvoker(RuntimeMethodInfo method) : this(method, method.ArgumentTypes)
		{
			this._invokeFunc_RefArgs = new InvokerEmitUtil.InvokeFunc_RefArgs(this.InterpretedInvoke_Method);
			this._invocationFlags = method.ComputeAndUpdateInvocationFlags();
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x0011A001 File Offset: 0x00118201
		private MethodInvoker(DynamicMethod method) : this(method.GetRuntimeMethodInfo(), method.ArgumentTypes)
		{
			this._invokeFunc_RefArgs = new InvokerEmitUtil.InvokeFunc_RefArgs(this.InterpretedInvoke_Method);
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x0011A027 File Offset: 0x00118227
		private MethodInvoker(RuntimeConstructorInfo constructor) : this(constructor, constructor.ArgumentTypes)
		{
			this._invokeFunc_RefArgs = new InvokerEmitUtil.InvokeFunc_RefArgs(this.InterpretedInvoke_Constructor);
			this._invocationFlags = constructor.ComputeAndUpdateInvocationFlags();
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x0011A054 File Offset: 0x00118254
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

		// Token: 0x0600764C RID: 30284 RVA: 0x0011A07C File Offset: 0x0011827C
		private unsafe object InterpretedInvoke_Constructor(object obj, IntPtr* args)
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

		// Token: 0x0600764D RID: 30285 RVA: 0x0011A0AC File Offset: 0x001182AC
		[NullableContext(1)]
		public static MethodInvoker Create(MethodBase method)
		{
			ArgumentNullException.ThrowIfNull(method, "method");
			RuntimeMethodInfo runtimeMethodInfo = method as RuntimeMethodInfo;
			if (runtimeMethodInfo != null)
			{
				return new MethodInvoker(runtimeMethodInfo);
			}
			DynamicMethod dynamicMethod = method as DynamicMethod;
			if (dynamicMethod != null)
			{
				return new MethodInvoker(dynamicMethod);
			}
			RuntimeConstructorInfo runtimeConstructorInfo = method as RuntimeConstructorInfo;
			if (runtimeConstructorInfo != null)
			{
				return new MethodInvoker(runtimeConstructorInfo)
				{
					_strategy = (MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs | MethodBase.InvokerStrategy.StrategyDetermined_Obj4Args | MethodBase.InvokerStrategy.StrategyDetermined_RefArgs)
				};
			}
			throw new ArgumentException(SR.Argument_MustBeRuntimeMethod, "method");
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x0011A110 File Offset: 0x00118310
		private MethodInvoker(MethodBase method, RuntimeType[] argumentTypes)
		{
			this._method = method;
			this._argTypes = argumentTypes;
			this._argCount = this._argTypes.Length;
			this._isStatic = this._method.IsStatic;
			MethodInvokerCommon.Initialize(argumentTypes, out this._strategy, out this._invokerArgFlags, out this._needsByRefStrategy);
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x0011A168 File Offset: 0x00118368
		public object Invoke(object obj)
		{
			if (this._argCount != 0)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(obj, null, null, null, null);
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x0011A182 File Offset: 0x00118382
		public object Invoke(object obj, object arg1)
		{
			if (this._argCount != 1)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(obj, arg1, null, null, null);
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x0011A19D File Offset: 0x0011839D
		public object Invoke(object obj, object arg1, object arg2)
		{
			if (this._argCount != 2)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(obj, arg1, arg2, null, null);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x0011A1B8 File Offset: 0x001183B8
		public object Invoke(object obj, object arg1, object arg2, object arg3)
		{
			if (this._argCount != 3)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(obj, arg1, arg2, arg3, null);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x0011A1D4 File Offset: 0x001183D4
		public object Invoke(object obj, object arg1, object arg2, object arg3, object arg4)
		{
			if (this._argCount != 4)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(obj, arg1, arg2, arg3, arg4);
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x0011A1F4 File Offset: 0x001183F4
		private object InvokeImpl(object obj, object arg1, object arg2, object arg3, object arg4)
		{
			if ((this._invocationFlags & (InvocationFlags.NoInvoke | InvocationFlags.NoConstructorInvoke | InvocationFlags.ContainsStackPointers)) != InvocationFlags.Unknown)
			{
				this.ThrowForBadInvocationFlags();
			}
			if (!this._isStatic)
			{
				MethodInvokerCommon.ValidateInvokeTarget(obj, this._method);
			}
			switch (this._argCount)
			{
			case 1:
				goto IL_67;
			case 2:
				goto IL_5D;
			case 3:
				break;
			case 4:
				this.CheckArgument(ref arg4, 3);
				break;
			default:
				goto IL_71;
			}
			this.CheckArgument(ref arg3, 2);
			IL_5D:
			this.CheckArgument(ref arg2, 1);
			IL_67:
			this.CheckArgument(ref arg1, 0);
			IL_71:
			if (this._invokeFunc_Obj4Args != null)
			{
				return this._invokeFunc_Obj4Args(obj, arg1, arg2, arg3, arg4);
			}
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_Obj4Args) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_Obj4Args(ref this._strategy, ref this._invokeFunc_Obj4Args, this._method, this._needsByRefStrategy, false);
				if (this._invokeFunc_Obj4Args != null)
				{
					return this._invokeFunc_Obj4Args(obj, arg1, arg2, arg3, arg4);
				}
			}
			return this.InvokeDirectByRef(obj, arg1, arg2, arg3, arg4);
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x0011A2E0 File Offset: 0x001184E0
		public unsafe object Invoke(object obj, [Nullable(new byte[]
		{
			0,
			2
		})] Span<object> arguments)
		{
			int length = arguments.Length;
			if (length != this._argCount)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			if (!this._needsByRefStrategy)
			{
				switch (this._argCount)
				{
				case 0:
					return this.InvokeImpl(obj, null, null, null, null);
				case 1:
					return this.InvokeImpl(obj, *arguments[0], null, null, null);
				case 2:
					return this.InvokeImpl(obj, *arguments[0], *arguments[1], null, null);
				case 3:
					return this.InvokeImpl(obj, *arguments[0], *arguments[1], *arguments[2], null);
				case 4:
					return this.InvokeImpl(obj, *arguments[0], *arguments[1], *arguments[2], *arguments[3]);
				}
			}
			if ((this._invocationFlags & (InvocationFlags.NoInvoke | InvocationFlags.ContainsStackPointers)) != InvocationFlags.Unknown)
			{
				this.ThrowForBadInvocationFlags();
			}
			if (!this._isStatic)
			{
				MethodInvokerCommon.ValidateInvokeTarget(obj, this._method);
			}
			if (length > 4)
			{
				return this.InvokeWithManyArgs(obj, arguments);
			}
			return this.InvokeWithFewArgs(obj, arguments);
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x0011A400 File Offset: 0x00118600
		private void ThrowForBadInvocationFlags()
		{
			RuntimeMethodInfo runtimeMethodInfo = this._method as RuntimeMethodInfo;
			if (runtimeMethodInfo != null)
			{
				runtimeMethodInfo.ThrowNoInvokeException();
			}
			((RuntimeConstructorInfo)this._method).ThrowNoInvokeException();
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x0011A434 File Offset: 0x00118634
		internal unsafe object InvokeWithFewArgs(object obj, Span<object> arguments)
		{
			MethodBase.StackAllocatedArgumentsWithCopyBack stackAllocatedArgumentsWithCopyBack = default(MethodBase.StackAllocatedArgumentsWithCopyBack);
			Span<object> span = <PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<object>, object>(ref stackAllocatedArgumentsWithCopyBack._args, 4).Slice(0, this._argCount);
			Span<bool> shouldCopyBack = <PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<bool>, bool>(ref stackAllocatedArgumentsWithCopyBack._shouldCopyBack, 4).Slice(0, this._argCount);
			for (int i = 0; i < this._argCount; i++)
			{
				object obj2 = *arguments[i];
				*shouldCopyBack[i] = this.CheckArgument(ref obj2, i);
				*span[i] = obj2;
			}
			if (this._invokeFunc_ObjSpanArgs != null)
			{
				return this._invokeFunc_ObjSpanArgs(obj, span);
			}
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(ref this._strategy, ref this._invokeFunc_ObjSpanArgs, this._method, this._needsByRefStrategy, false);
				if (this._invokeFunc_ObjSpanArgs != null)
				{
					return this._invokeFunc_ObjSpanArgs(obj, span);
				}
			}
			object result = this.InvokeDirectByRefWithFewArgs(obj, span);
			this.CopyBack(arguments, span, shouldCopyBack);
			return result;
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x0011A52C File Offset: 0x0011872C
		internal object InvokeDirectByRef(object obj, object arg1 = null, object arg2 = null, object arg3 = null, object arg4 = null)
		{
			MethodBase.StackAllocatedArguments stackAllocatedArguments = new MethodBase.StackAllocatedArguments(arg1, arg2, arg3, arg4);
			return this.InvokeDirectByRefWithFewArgs(obj, <PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<object>, object>(ref stackAllocatedArguments._args, 4).Slice(0, this._argCount));
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x0011A56C File Offset: 0x0011876C
		internal unsafe object InvokeDirectByRefWithFewArgs(object obj, Span<object> copyOfArgs)
		{
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_RefArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_RefArgs(ref this._strategy, ref this._invokeFunc_RefArgs, this._method, false);
			}
			MethodBase.StackAllocatedByRefs stackAllocatedByRefs = default(MethodBase.StackAllocatedByRefs);
			IntPtr* ptr = (IntPtr*)(&stackAllocatedByRefs);
			for (int i = 0; i < this._argCount; i++)
			{
				*(ByReference*)(ptr + (IntPtr)i * 8 / (IntPtr)sizeof(IntPtr)) = (((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsValueType) != (MethodBase.InvokerArgFlags)0) ? ByReference.Create<byte>((*copyOfArgs[i]).GetRawData()) : ByReference.Create<object>(copyOfArgs[i]));
			}
			return this._invokeFunc_RefArgs(obj, ptr);
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x0011A604 File Offset: 0x00118804
		internal unsafe object InvokeWithManyArgs(object obj, Span<object> arguments)
		{
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(ref this._strategy, ref this._invokeFunc_ObjSpanArgs, this._method, this._needsByRefStrategy, false);
			}
			Span<object> span;
			if (this._invokeFunc_ObjSpanArgs != null)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)this._argCount) * 8)];
				NativeMemory.Clear((void*)ptr, (UIntPtr)((IntPtr)this._argCount * (IntPtr)8));
				span = new Span<object>(Unsafe.AsRef<object>((void*)ptr), this._argCount);
				new GCFrameRegistration((void*)ptr, (uint)this._argCount, false);
				try
				{
					for (int i = 0; i < this._argCount; i++)
					{
						object obj2 = *arguments[i];
						this.CheckArgument(ref obj2, i);
						*span[i] = obj2;
					}
					return this._invokeFunc_ObjSpanArgs(obj, span);
				}
				finally
				{
				}
			}
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_RefArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_RefArgs(ref this._strategy, ref this._invokeFunc_RefArgs, this._method, false);
			}
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)(2 * this._argCount)) * 8)];
			NativeMemory.Clear((void*)ptr2, (UIntPtr)((IntPtr)(2 * this._argCount) * (IntPtr)8));
			span = new Span<object>(Unsafe.AsRef<object>((void*)ptr2), this._argCount);
			IntPtr* ptr3 = ptr2 + (IntPtr)this._argCount * 8 / (IntPtr)sizeof(IntPtr);
			int argCount = this._argCount;
			Span<bool> shouldCopyBack = new Span<bool>(stackalloc byte[(UIntPtr)argCount], argCount);
			new GCFrameRegistration((void*)ptr2, (uint)this._argCount, false);
			new GCFrameRegistration((void*)ptr3, (uint)this._argCount, true);
			object result;
			try
			{
				for (int j = 0; j < this._argCount; j++)
				{
					object obj3 = *arguments[j];
					*shouldCopyBack[j] = this.CheckArgument(ref obj3, j);
					*span[j] = obj3;
					*(ByReference*)(ptr3 + (IntPtr)j * 8 / (IntPtr)sizeof(IntPtr)) = (((this._invokerArgFlags[j] & MethodBase.InvokerArgFlags.IsValueType) != (MethodBase.InvokerArgFlags)0) ? ByReference.Create<byte>((*Unsafe.AsRef<object>((void*)(ptr2 + (IntPtr)j * 8 / (IntPtr)sizeof(IntPtr)))).GetRawData()) : ByReference.Create<object>(Unsafe.AsRef<object>((void*)(ptr2 + (IntPtr)j * 8 / (IntPtr)sizeof(IntPtr)))));
				}
				result = this._invokeFunc_RefArgs(obj, ptr3);
				this.CopyBack(arguments, span, shouldCopyBack);
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x0011A848 File Offset: 0x00118A48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe void CopyBack(Span<object> dest, Span<object> copyOfParameters, Span<bool> shouldCopyBack)
		{
			for (int i = 0; i < dest.Length; i++)
			{
				if (*shouldCopyBack[i])
				{
					if ((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsNullableOfT) != (MethodBase.InvokerArgFlags)0)
					{
						*dest[i] = RuntimeMethodHandle.ReboxFromNullable(*copyOfParameters[i]);
					}
					else
					{
						*dest[i] = *copyOfParameters[i];
					}
				}
			}
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x0011A8AC File Offset: 0x00118AAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool CheckArgument(ref object arg, int i)
		{
			RuntimeType runtimeType = this._argTypes[i];
			if (arg == null)
			{
				if ((this._invokerArgFlags[i] & MethodBase.InvokerArgFlags.IsValueType_ByRef_Or_Pointer) != (MethodBase.InvokerArgFlags)0)
				{
					return runtimeType.CheckValue(ref arg);
				}
			}
			else if (arg.GetType() != runtimeType)
			{
				return runtimeType.CheckValue(ref arg);
			}
			return false;
		}

		// Token: 0x04001554 RID: 5460
		private InvokerEmitUtil.InvokeFunc_ObjSpanArgs _invokeFunc_ObjSpanArgs;

		// Token: 0x04001555 RID: 5461
		private InvokerEmitUtil.InvokeFunc_Obj4Args _invokeFunc_Obj4Args;

		// Token: 0x04001556 RID: 5462
		private InvokerEmitUtil.InvokeFunc_RefArgs _invokeFunc_RefArgs;

		// Token: 0x04001557 RID: 5463
		private MethodBase.InvokerStrategy _strategy;

		// Token: 0x04001558 RID: 5464
		private readonly int _argCount;

		// Token: 0x04001559 RID: 5465
		private readonly RuntimeType[] _argTypes;

		// Token: 0x0400155A RID: 5466
		private readonly InvocationFlags _invocationFlags;

		// Token: 0x0400155B RID: 5467
		private readonly MethodBase.InvokerArgFlags[] _invokerArgFlags;

		// Token: 0x0400155C RID: 5468
		private readonly MethodBase _method;

		// Token: 0x0400155D RID: 5469
		private readonly bool _needsByRefStrategy;

		// Token: 0x0400155E RID: 5470
		private readonly bool _isStatic;
	}
}
