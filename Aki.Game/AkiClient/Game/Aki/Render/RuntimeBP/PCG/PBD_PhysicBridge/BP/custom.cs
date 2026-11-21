using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x020030E3 RID: 12515
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class custom : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E409 RID: 123913 RVA: 0x0090F48A File Offset: 0x0090D68A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return custom.StaticFunctionPtr();
		}

		// Token: 0x0601E40A RID: 123914 RVA: 0x0090F496 File Offset: 0x0090D696
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_BridgeModels_BrokenMobile_C.__custom__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_BridgeModels_BrokenMobile_C.__custom__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C:custom__DelegateSignature");
			}
			return BP_BridgeModels_BrokenMobile_C.__custom__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601E40B RID: 123915 RVA: 0x0090F4B9 File Offset: 0x0090D6B9
		public custom()
		{
		}

		// Token: 0x0601E40C RID: 123916 RVA: 0x0090F4C1 File Offset: 0x0090D6C1
		[NullableContext(2)]
		public custom(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E40D RID: 123917 RVA: 0x0090F4CB File Offset: 0x0090D6CB
		public custom(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E40E RID: 123918 RVA: 0x0090F4D6 File Offset: 0x0090D6D6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E40F RID: 123919 RVA: 0x0090F508 File Offset: 0x0090D708
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (custom.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = custom.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (custom.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(custom.OnScriptCallback));
				}
				custom.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, custom.RegisterId);
		}

		// Token: 0x0601E410 RID: 123920 RVA: 0x0090F542 File Offset: 0x0090D742
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E411 RID: 123921 RVA: 0x0090F54B File Offset: 0x0090D74B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601E412 RID: 123922 RVA: 0x0090F558 File Offset: 0x0090D758
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

		// Token: 0x0401002D RID: 65581
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C:custom__DelegateSignature";

		// Token: 0x0401002E RID: 65582
		private static int RegisterId;

		// Token: 0x02008E53 RID: 36435
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CA9D RID: 182941
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
