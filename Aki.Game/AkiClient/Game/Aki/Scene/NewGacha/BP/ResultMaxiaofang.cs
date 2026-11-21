using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003098 RID: 12440
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultMaxiaofang : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBBA RID: 121786 RVA: 0x0090061A File Offset: 0x008FE81A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultMaxiaofang.StaticFunctionPtr();
		}

		// Token: 0x0601DBBB RID: 121787 RVA: 0x00900626 File Offset: 0x008FE826
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultMaxiaofang__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultMaxiaofang__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMaxiaofang__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultMaxiaofang__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBBC RID: 121788 RVA: 0x00900649 File Offset: 0x008FE849
		public ResultMaxiaofang()
		{
		}

		// Token: 0x0601DBBD RID: 121789 RVA: 0x00900651 File Offset: 0x008FE851
		[NullableContext(2)]
		public ResultMaxiaofang(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBBE RID: 121790 RVA: 0x0090065B File Offset: 0x008FE85B
		public ResultMaxiaofang(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBBF RID: 121791 RVA: 0x00900666 File Offset: 0x008FE866
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBC0 RID: 121792 RVA: 0x00900698 File Offset: 0x008FE898
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultMaxiaofang.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultMaxiaofang.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultMaxiaofang.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultMaxiaofang.OnScriptCallback));
				}
				ResultMaxiaofang.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultMaxiaofang.RegisterId);
		}

		// Token: 0x0601DBC1 RID: 121793 RVA: 0x009006D2 File Offset: 0x008FE8D2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBC2 RID: 121794 RVA: 0x009006DB File Offset: 0x008FE8DB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBC3 RID: 121795 RVA: 0x009006E8 File Offset: 0x008FE8E8
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

		// Token: 0x0400FB03 RID: 64259
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMaxiaofang__DelegateSignature";

		// Token: 0x0400FB04 RID: 64260
		private static int RegisterId;

		// Token: 0x02008D92 RID: 36242
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C949 RID: 182601
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
