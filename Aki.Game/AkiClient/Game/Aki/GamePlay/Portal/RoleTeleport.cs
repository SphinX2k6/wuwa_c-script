using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.Portal
{
	// Token: 0x02003E59 RID: 15961
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class RoleTeleport : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06028203 RID: 164355 RVA: 0x009A4BC8 File Offset: 0x009A2DC8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return RoleTeleport.StaticFunctionPtr();
		}

		// Token: 0x06028204 RID: 164356 RVA: 0x009A4BD4 File Offset: 0x009A2DD4
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_KuroPortalCapture_C.__RoleTeleport__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_KuroPortalCapture_C.__RoleTeleport__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C:RoleTeleport__DelegateSignature");
			}
			return BP_KuroPortalCapture_C.__RoleTeleport__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06028205 RID: 164357 RVA: 0x009A4BF7 File Offset: 0x009A2DF7
		public RoleTeleport()
		{
		}

		// Token: 0x06028206 RID: 164358 RVA: 0x009A4BFF File Offset: 0x009A2DFF
		[NullableContext(2)]
		public RoleTeleport(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028207 RID: 164359 RVA: 0x009A4C09 File Offset: 0x009A2E09
		public RoleTeleport(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028208 RID: 164360 RVA: 0x009A4C14 File Offset: 0x009A2E14
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06028209 RID: 164361 RVA: 0x009A4C46 File Offset: 0x009A2E46
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602820A RID: 164362 RVA: 0x009A4C80 File Offset: 0x009A2E80
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602820B RID: 164363 RVA: 0x009A4C8C File Offset: 0x009A2E8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FVector Velocity)
		{
			RoleTeleport.__RoleTeleport_DelegateParams* ptr = stackalloc RoleTeleport.__RoleTeleport_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(RoleTeleport.__RoleTeleport_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(RoleTeleport.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Velocity = Velocity;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602820C RID: 164364 RVA: 0x009A4CC8 File Offset: 0x009A2EC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((RoleTeleport.__RoleTeleport_DelegateParams*)__Parameters)->Velocity);
		}

		// Token: 0x040146C8 RID: 83656
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/GamePlay/Portal/BP_KuroPortalCapture.BP_KuroPortalCapture_C:RoleTeleport__DelegateSignature";

		// Token: 0x040146C9 RID: 83657
		private static int RegisterId;

		// Token: 0x0200A2CA RID: 41674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RoleTeleport_DelegateParams
		{
			// Token: 0x0403200B RID: 204811
			[FieldOffset(0)]
			public FVector Velocity;
		}

		// Token: 0x0200A2CB RID: 41675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403200C RID: 204812
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
