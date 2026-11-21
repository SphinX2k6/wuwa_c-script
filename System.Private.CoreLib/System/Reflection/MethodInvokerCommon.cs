using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200075B RID: 1883
	internal static class MethodInvokerCommon
	{
		// Token: 0x06007958 RID: 31064 RVA: 0x0011FFC0 File Offset: 0x0011E1C0
		internal static void Initialize(RuntimeType[] argumentTypes, out MethodBase.InvokerStrategy strategy, out MethodBase.InvokerArgFlags[] invokerFlags, out bool needsByRefStrategy)
		{
			if (LocalAppContextSwitches.ForceInterpretedInvoke && !LocalAppContextSwitches.ForceEmitInvoke)
			{
				strategy = (MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs | MethodBase.InvokerStrategy.StrategyDetermined_Obj4Args | MethodBase.InvokerStrategy.StrategyDetermined_RefArgs);
			}
			else if (LocalAppContextSwitches.ForceEmitInvoke && !LocalAppContextSwitches.ForceInterpretedInvoke)
			{
				strategy = (MethodBase.InvokerStrategy.HasBeenInvoked_ObjSpanArgs | MethodBase.InvokerStrategy.HasBeenInvoked_Obj4Args | MethodBase.InvokerStrategy.HasBeenInvoked_RefArgs);
			}
			else
			{
				strategy = (MethodBase.InvokerStrategy)0;
			}
			int num = argumentTypes.Length;
			invokerFlags = new MethodBase.InvokerArgFlags[num];
			needsByRefStrategy = false;
			for (int i = 0; i < num; i++)
			{
				RuntimeType runtimeType = argumentTypes[i];
				if (RuntimeTypeHandle.IsByRef(runtimeType))
				{
					runtimeType = (RuntimeType)runtimeType.GetElementType();
					invokerFlags[i] |= MethodBase.InvokerArgFlags.IsValueType_ByRef_Or_Pointer;
					needsByRefStrategy = true;
					if (runtimeType.IsNullableOfT)
					{
						invokerFlags[i] |= MethodBase.InvokerArgFlags.IsNullableOfT;
					}
				}
				if (RuntimeTypeHandle.IsPointer(runtimeType))
				{
					invokerFlags[i] |= (MethodBase.InvokerArgFlags.IsValueType | MethodBase.InvokerArgFlags.IsValueType_ByRef_Or_Pointer);
				}
				else if (RuntimeTypeHandle.IsFunctionPointer(runtimeType))
				{
					invokerFlags[i] |= MethodBase.InvokerArgFlags.IsValueType;
				}
				else if (runtimeType.IsActualValueType)
				{
					invokerFlags[i] |= (MethodBase.InvokerArgFlags.IsValueType | MethodBase.InvokerArgFlags.IsValueType_ByRef_Or_Pointer);
					if (runtimeType.IsNullableOfT)
					{
						invokerFlags[i] |= MethodBase.InvokerArgFlags.IsNullableOfT;
					}
				}
			}
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x001200AE File Offset: 0x0011E2AE
		internal static void ValidateInvokeTarget(object target, MethodBase method)
		{
			if (target == null)
			{
				throw new TargetException(SR.RFLCT_Targ_StatMethReqTarg);
			}
			if (!method.DeclaringType.IsInstanceOfType(target))
			{
				throw new TargetException(SR.Format(SR.RFLCT_Targ_ITargMismatch_WithType, method.DeclaringType, target.GetType()));
			}
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x001200E8 File Offset: 0x0011E2E8
		internal static void DetermineStrategy_ObjSpanArgs(ref MethodBase.InvokerStrategy strategy, ref InvokerEmitUtil.InvokeFunc_ObjSpanArgs invokeFunc_ObjSpanArgs, MethodBase method, bool needsByRefStrategy, bool backwardsCompat)
		{
			if (needsByRefStrategy)
			{
				strategy |= MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs;
				return;
			}
			if ((strategy & MethodBase.InvokerStrategy.HasBeenInvoked_ObjSpanArgs) == (MethodBase.InvokerStrategy)0 && !Debugger.IsAttached)
			{
				strategy |= MethodBase.InvokerStrategy.HasBeenInvoked_ObjSpanArgs;
				return;
			}
			if (RuntimeFeature.IsDynamicCodeSupported)
			{
				invokeFunc_ObjSpanArgs = InvokerEmitUtil.CreateInvokeDelegate_ObjSpanArgs(method, backwardsCompat);
			}
			strategy |= MethodBase.InvokerStrategy.StrategyDetermined_ObjSpanArgs;
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x0012011F File Offset: 0x0011E31F
		internal static void DetermineStrategy_Obj4Args(ref MethodBase.InvokerStrategy strategy, ref InvokerEmitUtil.InvokeFunc_Obj4Args invokeFunc_Obj4Args, MethodBase method, bool needsByRefStrategy, bool backwardsCompat)
		{
			if (needsByRefStrategy)
			{
				strategy |= MethodBase.InvokerStrategy.StrategyDetermined_Obj4Args;
				return;
			}
			if ((strategy & MethodBase.InvokerStrategy.HasBeenInvoked_Obj4Args) == (MethodBase.InvokerStrategy)0 && !Debugger.IsAttached)
			{
				strategy |= MethodBase.InvokerStrategy.HasBeenInvoked_Obj4Args;
				return;
			}
			if (RuntimeFeature.IsDynamicCodeSupported)
			{
				invokeFunc_Obj4Args = InvokerEmitUtil.CreateInvokeDelegate_Obj4Args(method, backwardsCompat);
			}
			strategy |= MethodBase.InvokerStrategy.StrategyDetermined_Obj4Args;
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x00120156 File Offset: 0x0011E356
		internal static void DetermineStrategy_RefArgs(ref MethodBase.InvokerStrategy strategy, ref InvokerEmitUtil.InvokeFunc_RefArgs invokeFunc_RefArgs, MethodBase method, bool backwardsCompat)
		{
			if ((strategy & MethodBase.InvokerStrategy.HasBeenInvoked_RefArgs) == (MethodBase.InvokerStrategy)0 && !Debugger.IsAttached)
			{
				strategy |= MethodBase.InvokerStrategy.HasBeenInvoked_RefArgs;
				return;
			}
			if (RuntimeFeature.IsDynamicCodeSupported)
			{
				invokeFunc_RefArgs = InvokerEmitUtil.CreateInvokeDelegate_RefArgs(method, backwardsCompat);
			}
			strategy |= MethodBase.InvokerStrategy.StrategyDetermined_RefArgs;
		}
	}
}
