using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x020030A0 RID: 12448
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultYangyang : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC0A RID: 121866 RVA: 0x00900E9A File Offset: 0x008FF09A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultYangyang.StaticFunctionPtr();
		}

		// Token: 0x0601DC0B RID: 121867 RVA: 0x00900EA6 File Offset: 0x008FF0A6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultYangyang__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultYangyang__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYangyang__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultYangyang__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DC0C RID: 121868 RVA: 0x00900EC9 File Offset: 0x008FF0C9
		public ResultYangyang()
		{
		}

		// Token: 0x0601DC0D RID: 121869 RVA: 0x00900ED1 File Offset: 0x008FF0D1
		[NullableContext(2)]
		public ResultYangyang(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC0E RID: 121870 RVA: 0x00900EDB File Offset: 0x008FF0DB
		public ResultYangyang(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC0F RID: 121871 RVA: 0x00900EE6 File Offset: 0x008FF0E6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC10 RID: 121872 RVA: 0x00900F18 File Offset: 0x008FF118
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultYangyang.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultYangyang.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultYangyang.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultYangyang.OnScriptCallback));
				}
				ResultYangyang.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultYangyang.RegisterId);
		}

		// Token: 0x0601DC11 RID: 121873 RVA: 0x00900F52 File Offset: 0x008FF152
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DC12 RID: 121874 RVA: 0x00900F5B File Offset: 0x008FF15B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DC13 RID: 121875 RVA: 0x00900F68 File Offset: 0x008FF168
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400FB13 RID: 64275
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYangyang__DelegateSignature";

		// Token: 0x0400FB14 RID: 64276
		private static int RegisterId;

		// Token: 0x02008D9A RID: 36250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C951 RID: 182609
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
