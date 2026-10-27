using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FDE RID: 16350
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class UiAnimNotifyEffect : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06029E1A RID: 171546 RVA: 0x009CED3F File Offset: 0x009CCF3F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return UiAnimNotifyEffect.StaticFunctionPtr();
		}

		// Token: 0x06029E1B RID: 171547 RVA: 0x009CED4B File Offset: 0x009CCF4B
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UiActorCallBack_C.__UiAnimNotifyEffect__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UiActorCallBack_C.__UiAnimNotifyEffect__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyEffect__DelegateSignature");
			}
			return BP_UiActorCallBack_C.__UiAnimNotifyEffect__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06029E1C RID: 171548 RVA: 0x009CED6E File Offset: 0x009CCF6E
		public UiAnimNotifyEffect()
		{
		}

		// Token: 0x06029E1D RID: 171549 RVA: 0x009CED76 File Offset: 0x009CCF76
		[NullableContext(2)]
		public UiAnimNotifyEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029E1E RID: 171550 RVA: 0x009CED80 File Offset: 0x009CCF80
		public UiAnimNotifyEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029E1F RID: 171551 RVA: 0x009CED8B File Offset: 0x009CCF8B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<SUiAnimNotifyEffect, USkeletalMeshComponent>) ?? ((Action<SUiAnimNotifyEffect, USkeletalMeshComponent>)Delegate.CreateDelegate(typeof(Action<SUiAnimNotifyEffect, USkeletalMeshComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06029E20 RID: 171552 RVA: 0x009CEDBD File Offset: 0x009CCFBD
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<SUiAnimNotifyEffect, USkeletalMeshComponent> Callback)
		{
			if (UiAnimNotifyEffect.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = UiAnimNotifyEffect.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (UiAnimNotifyEffect.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(UiAnimNotifyEffect.OnScriptCallback));
				}
				UiAnimNotifyEffect.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, UiAnimNotifyEffect.RegisterId);
		}

		// Token: 0x06029E21 RID: 171553 RVA: 0x009CEDF7 File Offset: 0x009CCFF7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<SUiAnimNotifyEffect, USkeletalMeshComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06029E22 RID: 171554 RVA: 0x009CEE00 File Offset: 0x009CD000
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(SUiAnimNotifyEffect uiAnimNotifyEffect, USkeletalMeshComponent mesh)
		{
			UiAnimNotifyEffect.__UiAnimNotifyEffect_DelegateParams* ptr = stackalloc UiAnimNotifyEffect.__UiAnimNotifyEffect_DelegateParams[(UIntPtr)127] + 15L / (long)sizeof(UiAnimNotifyEffect.__UiAnimNotifyEffect_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UiAnimNotifyEffect.StaticFunctionPtr(), (void*)ptr, 1);
			if (uiAnimNotifyEffect != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SUiAnimNotifyEffect.StaticStruct(), &ptr->uiAnimNotifyEffect, uiAnimNotifyEffect.NativePtr, 1, false);
			}
			ptr->mesh = ((mesh != null) ? mesh.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_UiActorCallBack_C.__UiAnimNotifyEffect__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E23 RID: 171555 RVA: 0x009CEE80 File Offset: 0x009CD080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<SUiAnimNotifyEffect, USkeletalMeshComponent> action = target as Action<SUiAnimNotifyEffect, USkeletalMeshComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			SUiAnimNotifyEffect arg = new SUiAnimNotifyEffect(&((UiAnimNotifyEffect.__UiAnimNotifyEffect_DelegateParams*)__Parameters)->uiAnimNotifyEffect, true, true);
			USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((UiAnimNotifyEffect.__UiAnimNotifyEffect_DelegateParams*)__Parameters)->mesh);
			action(arg, orCreateUObjectByNativePointer);
		}

		// Token: 0x04015836 RID: 88118
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyEffect__DelegateSignature";

		// Token: 0x04015837 RID: 88119
		private static int RegisterId;

		// Token: 0x0200A2EC RID: 41708
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __UiAnimNotifyEffect_DelegateParams
		{
			// Token: 0x04032041 RID: 204865
			[FieldOffset(0)]
			public byte uiAnimNotifyEffect;

			// Token: 0x04032042 RID: 204866
			[FieldOffset(96)]
			public IntPtr mesh;
		}

		// Token: 0x0200A2ED RID: 41709
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032043 RID: 204867
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
