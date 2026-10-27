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
	// Token: 0x02003FE2 RID: 16354
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class UiAnimNotifyStateEffectStop : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06029E42 RID: 171586 RVA: 0x009CF37A File Offset: 0x009CD57A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return UiAnimNotifyStateEffectStop.StaticFunctionPtr();
		}

		// Token: 0x06029E43 RID: 171587 RVA: 0x009CF386 File Offset: 0x009CD586
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UiActorCallBack_C.__UiAnimNotifyStateEffectStop__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UiActorCallBack_C.__UiAnimNotifyStateEffectStop__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyStateEffectStop__DelegateSignature");
			}
			return BP_UiActorCallBack_C.__UiAnimNotifyStateEffectStop__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06029E44 RID: 171588 RVA: 0x009CF3A9 File Offset: 0x009CD5A9
		public UiAnimNotifyStateEffectStop()
		{
		}

		// Token: 0x06029E45 RID: 171589 RVA: 0x009CF3B1 File Offset: 0x009CD5B1
		[NullableContext(2)]
		public UiAnimNotifyStateEffectStop(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029E46 RID: 171590 RVA: 0x009CF3BB File Offset: 0x009CD5BB
		public UiAnimNotifyStateEffectStop(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029E47 RID: 171591 RVA: 0x009CF3C6 File Offset: 0x009CD5C6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent>) ?? ((Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06029E48 RID: 171592 RVA: 0x009CF3F8 File Offset: 0x009CD5F8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] Action<TEnumAsByte<EPerformanceRoleState>, string, USkeletalMeshComponent> Callback)
		{
			if (UiAnimNotifyStateEffectStop.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = UiAnimNotifyStateEffectStop.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (UiAnimNotifyStateEffectStop.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(UiAnimNotifyStateEffectStop.OnScriptCallback));
				}
				UiAnimNotifyStateEffectStop.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, UiAnimNotifyStateEffectStop.RegisterId);
		}

		// Token: 0x06029E49 RID: 171593 RVA: 0x009CF432 File Offset: 0x009CD632
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

		// Token: 0x06029E4A RID: 171594 RVA: 0x009CF43C File Offset: 0x009CD63C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EPerformanceRoleState animState, string socketName, [Nullable(2)] USkeletalMeshComponent mesh)
		{
			UiAnimNotifyStateEffectStop.__UiAnimNotifyStateEffectStop_DelegateParams* ptr = stackalloc UiAnimNotifyStateEffectStop.__UiAnimNotifyStateEffectStop_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(UiAnimNotifyStateEffectStop.__UiAnimNotifyStateEffectStop_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UiAnimNotifyStateEffectStop.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->animState = animState;
			FString.CopyFrom((void*)(&ptr->socketName), socketName);
			ptr->mesh = ((mesh != null) ? mesh.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_UiActorCallBack_C.__UiAnimNotifyStateEffectStop__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E4B RID: 171595 RVA: 0x009CF4B4 File Offset: 0x009CD6B4
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
			string arg = FString.ToString((void*)(&((UiAnimNotifyStateEffectStop.__UiAnimNotifyStateEffectStop_DelegateParams*)__Parameters)->socketName));
			USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((UiAnimNotifyStateEffectStop.__UiAnimNotifyStateEffectStop_DelegateParams*)__Parameters)->mesh);
			action(((UiAnimNotifyStateEffectStop.__UiAnimNotifyStateEffectStop_DelegateParams*)__Parameters)->animState, arg, orCreateUObjectByNativePointer);
		}

		// Token: 0x0401583E RID: 88126
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyStateEffectStop__DelegateSignature";

		// Token: 0x0401583F RID: 88127
		private static int RegisterId;

		// Token: 0x0200A2F4 RID: 41716
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UiAnimNotifyStateEffectStop_DelegateParams
		{
			// Token: 0x0403204D RID: 204877
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> animState;

			// Token: 0x0403204E RID: 204878
			[FieldOffset(8)]
			public FString socketName;

			// Token: 0x0403204F RID: 204879
			[FieldOffset(24)]
			public IntPtr mesh;
		}

		// Token: 0x0200A2F5 RID: 41717
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032050 RID: 204880
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
