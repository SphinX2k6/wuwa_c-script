using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003096 RID: 12438
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultKakaluo : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBA6 RID: 121766 RVA: 0x009003C2 File Offset: 0x008FE5C2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultKakaluo.StaticFunctionPtr();
		}

		// Token: 0x0601DBA7 RID: 121767 RVA: 0x009003CE File Offset: 0x008FE5CE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultKakaluo__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultKakaluo__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultKakaluo__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultKakaluo__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBA8 RID: 121768 RVA: 0x009003F1 File Offset: 0x008FE5F1
		public ResultKakaluo()
		{
		}

		// Token: 0x0601DBA9 RID: 121769 RVA: 0x009003F9 File Offset: 0x008FE5F9
		[NullableContext(2)]
		public ResultKakaluo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBAA RID: 121770 RVA: 0x00900403 File Offset: 0x008FE603
		public ResultKakaluo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBAB RID: 121771 RVA: 0x0090040E File Offset: 0x008FE60E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBAC RID: 121772 RVA: 0x00900440 File Offset: 0x008FE640
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultKakaluo.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultKakaluo.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultKakaluo.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultKakaluo.OnScriptCallback));
				}
				ResultKakaluo.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultKakaluo.RegisterId);
		}

		// Token: 0x0601DBAD RID: 121773 RVA: 0x0090047A File Offset: 0x008FE67A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBAE RID: 121774 RVA: 0x00900483 File Offset: 0x008FE683
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBAF RID: 121775 RVA: 0x00900490 File Offset: 0x008FE690
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

		// Token: 0x0400FAFF RID: 64255
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultKakaluo__DelegateSignature";

		// Token: 0x0400FB00 RID: 64256
		private static int RegisterId;

		// Token: 0x02008D8F RID: 36239
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C946 RID: 182598
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
