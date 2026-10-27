using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C44 RID: 15428
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class custom : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06023B45 RID: 146245 RVA: 0x0092A8E6 File Offset: 0x00928AE6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return custom.StaticFunctionPtr();
		}

		// Token: 0x06023B46 RID: 146246 RVA: 0x0092A8F2 File Offset: 0x00928AF2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_BridgeModels_BrokenMobile_C.__custom__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_BridgeModels_BrokenMobile_C.__custom__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C:custom__DelegateSignature");
			}
			return BP_BridgeModels_BrokenMobile_C.__custom__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06023B47 RID: 146247 RVA: 0x0092A915 File Offset: 0x00928B15
		public custom()
		{
		}

		// Token: 0x06023B48 RID: 146248 RVA: 0x0092A91D File Offset: 0x00928B1D
		[NullableContext(2)]
		public custom(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B49 RID: 146249 RVA: 0x0092A927 File Offset: 0x00928B27
		public custom(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B4A RID: 146250 RVA: 0x0092A932 File Offset: 0x00928B32
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06023B4B RID: 146251 RVA: 0x0092A964 File Offset: 0x00928B64
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06023B4C RID: 146252 RVA: 0x0092A99E File Offset: 0x00928B9E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06023B4D RID: 146253 RVA: 0x0092A9A7 File Offset: 0x00928BA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06023B4E RID: 146254 RVA: 0x0092A9B4 File Offset: 0x00928BB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04011A44 RID: 72260
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BP_BridgeModels_BrokenMobile.BP_BridgeModels_BrokenMobile_C:custom__DelegateSignature";

		// Token: 0x04011A45 RID: 72261
		private static int RegisterId;

		// Token: 0x02009E8C RID: 40588
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403174E RID: 202574
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
