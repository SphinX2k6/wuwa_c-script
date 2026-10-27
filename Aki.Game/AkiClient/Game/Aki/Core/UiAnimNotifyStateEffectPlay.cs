using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FE1 RID: 16353
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class UiAnimNotifyStateEffectPlay : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06029E38 RID: 171576 RVA: 0x009CF1DA File Offset: 0x009CD3DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return UiAnimNotifyStateEffectPlay.StaticFunctionPtr();
		}

		// Token: 0x06029E39 RID: 171577 RVA: 0x009CF1E6 File Offset: 0x009CD3E6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UiActorCallBack_C.__UiAnimNotifyStateEffectPlay__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UiActorCallBack_C.__UiAnimNotifyStateEffectPlay__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyStateEffectPlay__DelegateSignature");
			}
			return BP_UiActorCallBack_C.__UiAnimNotifyStateEffectPlay__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06029E3A RID: 171578 RVA: 0x009CF209 File Offset: 0x009CD409
		public UiAnimNotifyStateEffectPlay()
		{
		}

		// Token: 0x06029E3B RID: 171579 RVA: 0x009CF211 File Offset: 0x009CD411
		[NullableContext(2)]
		public UiAnimNotifyStateEffectPlay(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029E3C RID: 171580 RVA: 0x009CF21B File Offset: 0x009CD41B
		public UiAnimNotifyStateEffectPlay(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029E3D RID: 171581 RVA: 0x009CF226 File Offset: 0x009CD426
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent>) ?? ((Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06029E3E RID: 171582 RVA: 0x009CF258 File Offset: 0x009CD458
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent> Callback)
		{
			if (UiAnimNotifyStateEffectPlay.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = UiAnimNotifyStateEffectPlay.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (UiAnimNotifyStateEffectPlay.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(UiAnimNotifyStateEffectPlay.OnScriptCallback));
				}
				UiAnimNotifyStateEffectPlay.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, UiAnimNotifyStateEffectPlay.RegisterId);
		}

		// Token: 0x06029E3F RID: 171583 RVA: 0x009CF292 File Offset: 0x009CD492
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06029E40 RID: 171584 RVA: 0x009CF29C File Offset: 0x009CD49C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EPerformanceRoleState animState, string socketName, [Nullable(2)] USkeletalMeshComponent mesh)
		{
			UiAnimNotifyStateEffectPlay.__UiAnimNotifyStateEffectPlay_DelegateParams* ptr = stackalloc UiAnimNotifyStateEffectPlay.__UiAnimNotifyStateEffectPlay_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(UiAnimNotifyStateEffectPlay.__UiAnimNotifyStateEffectPlay_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UiAnimNotifyStateEffectPlay.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->animState = animState;
			FString.CopyFrom((void*)(&ptr->socketName), socketName);
			ptr->mesh = ((mesh != null) ? mesh.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_UiActorCallBack_C.__UiAnimNotifyStateEffectPlay__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E41 RID: 171585 RVA: 0x009CF314 File Offset: 0x009CD514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent> action = target as Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((UiAnimNotifyStateEffectPlay.__UiAnimNotifyStateEffectPlay_DelegateParams*)__Parameters)->socketName));
			USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((UiAnimNotifyStateEffectPlay.__UiAnimNotifyStateEffectPlay_DelegateParams*)__Parameters)->mesh);
			action(((UiAnimNotifyStateEffectPlay.__UiAnimNotifyStateEffectPlay_DelegateParams*)__Parameters)->animState, arg, orCreateUObjectByNativePointer);
		}

		// Token: 0x0401583C RID: 88124
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyStateEffectPlay__DelegateSignature";

		// Token: 0x0401583D RID: 88125
		private static int RegisterId;

		// Token: 0x0200A2F2 RID: 41714
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UiAnimNotifyStateEffectPlay_DelegateParams
		{
			// Token: 0x04032049 RID: 204873
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> animState;

			// Token: 0x0403204A RID: 204874
			[FieldOffset(8)]
			public FString socketName;

			// Token: 0x0403204B RID: 204875
			[FieldOffset(24)]
			public IntPtr mesh;
		}

		// Token: 0x0200A2F3 RID: 41715
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403204C RID: 204876
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
