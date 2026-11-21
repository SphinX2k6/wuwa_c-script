using System;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020006EE RID: 1774
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class ConstructorInvoker
	{
		// Token: 0x0600759F RID: 30111 RVA: 0x00117788 File Offset: 0x00115988
		internal ConstructorInvoker(RuntimeConstructorInfo constructor) : this(constructor, constructor.ArgumentTypes)
		{
			this._invokeFunc_RefArgs = new InvokerEmitUtil.InvokeFunc_RefArgs(this.InterpretedInvoke);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x001177AC File Offset: 0x001159AC
		private unsafe object InterpretedInvoke(object obj, IntPtr* args)
		{
			Exception ex;
			object result = this._method.InternalInvoke(obj, args, out ex);
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

		// Token: 0x060075A1 RID: 30113 RVA: 0x001177D4 File Offset: 0x001159D4
		public static ConstructorInvoker Create(ConstructorInfo constructor)
		{
			ArgumentNullException.ThrowIfNull(constructor, "constructor");
			RuntimeConstructorInfo runtimeConstructorInfo = constructor as RuntimeConstructorInfo;
			if (runtimeConstructorInfo == null)
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeConstructorInfo, "constructor");
			}
			return new ConstructorInvoker(runtimeConstructorInfo);
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00117800 File Offset: 0x00115A00
		private ConstructorInvoker(RuntimeConstructorInfo constructor, RuntimeType[] argumentTypes)
		{
			this._method = constructor;
			this._invocationFlags = constructor.ComputeAndUpdateInvocationFlags();
			this._argTypes = argumentTypes;
			this._argCount = this._argTypes.Length;
			MethodInvokerCommon.Initialize(argumentTypes, out this._strategy, out this._invokerArgFlags, out this._needsByRefStrategy);
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00117853 File Offset: 0x00115A53
		public object Invoke()
		{
			if (this._argCount != 0)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(null, null, null, null);
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x0011786C File Offset: 0x00115A6C
		public object Invoke([Nullable(2)] object arg1)
		{
			if (this._argCount != 1)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(arg1, null, null, null);
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00117886 File Offset: 0x00115A86
		[NullableContext(2)]
		[return: Nullable(1)]
		public object Invoke(object arg1, object arg2)
		{
			if (this._argCount != 2)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(arg1, arg2, null, null);
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x001178A0 File Offset: 0x00115AA0
		[NullableContext(2)]
		[return: Nullable(1)]
		public object Invoke(object arg1, object arg2, object arg3)
		{
			if (this._argCount != 3)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(arg1, arg2, arg3, null);
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x001178BA File Offset: 0x00115ABA
		[NullableContext(2)]
		[return: Nullable(1)]
		public object Invoke(object arg1, object arg2, object arg3, object arg4)
		{
			if (this._argCount != 4)
			{
				MethodBaseInvoker.ThrowTargetParameterCountException();
			}
			return this.InvokeImpl(arg1, arg2, arg3, arg4);
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x001178D8 File Offset: 0x00115AD8
		private object InvokeImpl(object arg1, object arg2, object arg3, object arg4)
		{
			if ((this._invocationFlags & (InvocationFlags.NoInvoke | InvocationFlags.NoConstructorInvoke | InvocationFlags.ContainsStackPointers)) != InvocationFlags.Unknown)
			{
				this._method.ThrowNoInvokeException();
			}
			switch (this._argCount)
			{
			case 1:
				goto IL_58;
			case 2:
				goto IL_4E;
			case 3:
				break;
			case 4:
				this.CheckArgument(ref arg4, 3);
				break;
			default:
				goto IL_62;
			}
			this.CheckArgument(ref arg3, 2);
			IL_4E:
			this.CheckArgument(ref arg2, 1);
			IL_58:
			this.CheckArgument(ref arg1, 0);
			IL_62:
			if (this._invokeFunc_Obj4Args != null)
			{
				return this._invokeFunc_Obj4Args(null, arg1, arg2, arg3, arg4);
			}
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_Obj4Args) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_Obj4Args(ref this._strategy, ref this._invokeFunc_Obj4Args, this._method, this._needsByRefStrategy, false);
				if (this._invokeFunc_Obj4Args != null)
				{
					return this._invokeFunc_Obj4Args(null, arg1, arg2, arg3, arg4);
				}
			}
			return this.InvokeDirectByRef(arg1, arg2, arg3, arg4);
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x001179B0 File Offset: 0x00115BB0
		public unsafe object Invoke([Nullable(new byte[]
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
					return this.InvokeImpl(null, null, null, null);
				case 1:
					return this.InvokeImpl(*arguments[0], null, null, null);
				case 2:
					return this.InvokeImpl(*arguments[0], *arguments[1], null, null);
				case 3:
					return this.InvokeImpl(*arguments[0], *arguments[1], *arguments[2], null);
				case 4:
					return this.InvokeImpl(*arguments[0], *arguments[1], *arguments[2], *arguments[3]);
				}
			}
			if ((this._invocationFlags & (InvocationFlags.NoInvoke | InvocationFlags.ContainsStackPointers)) != InvocationFlags.Unknown)
			{
				this._method.ThrowNoInvokeException();
			}
			if (length > 4)
			{
				return this.InvokeWithManyArgs(arguments);
			}
			return this.InvokeWithFewArgs(arguments);
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00117AB8 File Offset: 0x00115CB8
		internal unsafe object InvokeWithFewArgs(Span<object> arguments)
		{
			MethodBase.StackAllocatedArgumentsWithCopyBack stackAllocatedArgumentsWithCopyBack = default(MethodBase.StackAllocatedArgumentsWithCopyBack);
			Span<object> span = <PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<object>, object>(ref stackAllocatedArgumentsWithCopyBack._args, 4).Slice(0, this._argCount);
			Span<bool> span2 = <PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<bool>, bool>(ref stackAllocatedArgumentsWithCopyBack._shouldCopyBack, 4).Slice(0, this._argCount);
			for (int i = 0; i < this._argCount; i++)
			{
				object obj = *arguments[i];
				*span2[i] = this.CheckArgument(ref obj, i);
				*span[i] = obj;
			}
			if (this._invokeFunc_ObjSpanArgs != null)
			{
				return this._invokeFunc_ObjSpanArgs(null, span);
			}
			if ((this._strategy & MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs) == (MethodBase.InvokerStrategy)0)
			{
				MethodInvokerCommon.DetermineStrategy_ObjSpanArgs(ref this._strategy, ref this._invokeFunc_ObjSpanArgs, this._method, this._needsByRefStrategy, false);
				if (this._invokeFunc_ObjSpanArgs != null)
				{
					return this._invokeFunc_ObjSpanArgs(null, span);
				}
			}
			object result = this.InvokeDirectByRefWithFewArgs(span);
			this.CopyBack(arguments, span, span2);
			return result;
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00117BB8 File Offset: 0x00115DB8
		internal object InvokeDirectByRef(object arg1 = null, object arg2 = null, object arg3 = null, object arg4 = null)
		{
			MethodBase.StackAllocatedArguments stackAllocatedArguments = new MethodBase.StackAllocatedArguments(arg1, arg2, arg3, arg4);
			return this.InvokeDirectByRefWithFewArgs(<PrivateImplementationDetails>.InlineArrayAsSpan<MethodBase.ArgumentData<object>, object>(ref stackAllocatedArguments._args, 4).Slice(0, this._argCount));
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00117BF4 File Offset: 0x00115DF4
		internal unsafe object InvokeDirectByRefWithFewArgs(Span<object> copyOfArgs)
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
			return this._invokeFunc_RefArgs(null, ptr);
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00117C8C File Offset: 0x00115E8C
		internal unsafe object InvokeWithManyArgs(Span<object> arguments)
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
						object obj = *arguments[i];
						this.CheckArgument(ref obj, i);
						*span[i] = obj;
					}
					return this._invokeFunc_ObjSpanArgs(null, span);
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
			Span<bool> span2 = new Span<bool>(stackalloc byte[(UIntPtr)argCount], argCount);
			new GCFrameRegistration((void*)ptr2, (uint)this._argCount, false);
			new GCFrameRegistration((void*)ptr3, (uint)this._argCount, true);
			object result;
			try
			{
				for (int j = 0; j < this._argCount; j++)
				{
					object obj2 = *arguments[j];
					*span2[j] = this.CheckArgument(ref obj2, j);
					*span[j] = obj2;
					*(ByReference*)(ptr3 + (IntPtr)j * 8 / (IntPtr)sizeof(IntPtr)) = (((this._invokerArgFlags[j] & MethodBase.InvokerArgFlags.IsValueType) != (MethodBase.InvokerArgFlags)0) ? ByReference.Create<byte>((*Unsafe.AsRef<object>((void*)(ptr2 + (IntPtr)j * 8 / (IntPtr)sizeof(IntPtr)))).GetRawData()) : ByReference.Create<object>(Unsafe.AsRef<object>((void*)(ptr2 + (IntPtr)j * 8 / (IntPtr)sizeof(IntPtr)))));
				}
				result = this._invokeFunc_RefArgs(null, ptr3);
				this.CopyBack(arguments, span, span2);
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x00117ED8 File Offset: 0x001160D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe void CopyBack(Span<object> dest, ReadOnlySpan<object> copyOfParameters, ReadOnlySpan<bool> shouldCopyBack)
		{
			for (int i = 0; i < dest.Length; i++)
			{
				if (*shouldCopyBack[i] != 0)
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

		// Token: 0x060075AF RID: 30127 RVA: 0x00117F3C File Offset: 0x0011613C
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

		// Token: 0x04001527 RID: 5415
		private InvokerEmitUtil.InvokeFunc_ObjSpanArgs _invokeFunc_ObjSpanArgs;

		// Token: 0x04001528 RID: 5416
		private InvokerEmitUtil.InvokeFunc_Obj4Args _invokeFunc_Obj4Args;

		// Token: 0x04001529 RID: 5417
		private InvokerEmitUtil.InvokeFunc_RefArgs _invokeFunc_RefArgs;

		// Token: 0x0400152A RID: 5418
		private MethodBase.InvokerStrategy _strategy;

		// Token: 0x0400152B RID: 5419
		private readonly int _argCount;

		// Token: 0x0400152C RID: 5420
		private readonly RuntimeType[] _argTypes;

		// Token: 0x0400152D RID: 5421
		private readonly InvocationFlags _invocationFlags;

		// Token: 0x0400152E RID: 5422
		private readonly MethodBase.InvokerArgFlags[] _invokerArgFlags;

		// Token: 0x0400152F RID: 5423
		private readonly RuntimeConstructorInfo _method;

		// Token: 0x04001530 RID: 5424
		private readonly bool _needsByRefStrategy;
	}
}
