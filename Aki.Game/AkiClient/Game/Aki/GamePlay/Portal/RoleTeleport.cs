using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.Portal
{
	// Token: 0x0200314C RID: 12620
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class RoleTeleport : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0A2 RID: 127138 RVA: 0x00924E0F File Offset: 0x0092300F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return RoleTeleport.StaticFunctionPtr();
		}

		// Token: 0x0601F0A3 RID: 127139 RVA: 0x00924E1B File Offset: 0x0092301B
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_KuroPortalCapture_C.__RoleTeleport__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_KuroPortalCapture_C.__RoleTeleport__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C:RoleTeleport__DelegateSignature");
			}
			return BP_KuroPortalCapture_C.__RoleTeleport__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0A4 RID: 127140 RVA: 0x00924E3E File Offset: 0x0092303E
		public RoleTeleport()
		{
		}

		// Token: 0x0601F0A5 RID: 127141 RVA: 0x00924E46 File Offset: 0x00923046
		[NullableContext(2)]
		public RoleTeleport(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0A6 RID: 127142 RVA: 0x00924E50 File Offset: 0x00923050
		public RoleTeleport(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0A7 RID: 127143 RVA: 0x00924E5B File Offset: 0x0092305B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0A8 RID: 127144 RVA: 0x00924E8D File Offset: 0x0092308D
		[NullableContext(1)]
		public void Add(Action<FVector> Callback)
		{
			if (RoleTeleport.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = RoleTeleport.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (RoleTeleport.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(RoleTeleport.OnScriptCallback));
				}
				RoleTeleport.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, RoleTeleport.RegisterId);
		}

		// Token: 0x0601F0A9 RID: 127145 RVA: 0x00924EC7 File Offset: 0x009230C7
		[NullableContext(1)]
		public void Remove(Action<FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0AA RID: 127146 RVA: 0x00924ED0 File Offset: 0x009230D0
		[SkipLocalsInit]
		public unsafe void Broadcast(FVector Velocity)
		{
			RoleTeleport.__RoleTeleport_DelegateParams* ptr = stackalloc RoleTeleport.__RoleTeleport_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(RoleTeleport.__RoleTeleport_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(RoleTeleport.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Velocity = Velocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F0AB RID: 127147 RVA: 0x00924F0C File Offset: 0x0092310C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((RoleTeleport.__RoleTeleport_DelegateParams*)__Parameters)->Velocity);
		}

		// Token: 0x04010954 RID: 67924
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C:RoleTeleport__DelegateSignature";

		// Token: 0x04010955 RID: 67925
		private static int RegisterId;

		// Token: 0x02008F1D RID: 36637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __RoleTeleport_DelegateParams
		{
			// Token: 0x0402CC4E RID: 183374
			[FieldOffset(0)]
			public FVector Velocity;
		}

		// Token: 0x02008F1E RID: 36638
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CC4F RID: 183375
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
