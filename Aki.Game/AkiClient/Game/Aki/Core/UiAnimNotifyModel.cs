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
	// Token: 0x02003FE0 RID: 16352
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class UiAnimNotifyModel : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06029E2E RID: 171566 RVA: 0x009CF032 File Offset: 0x009CD232
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return UiAnimNotifyModel.StaticFunctionPtr();
		}

		// Token: 0x06029E2F RID: 171567 RVA: 0x009CF03E File Offset: 0x009CD23E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UiActorCallBack_C.__UiAnimNotifyModel__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UiActorCallBack_C.__UiAnimNotifyModel__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyModel__DelegateSignature");
			}
			return BP_UiActorCallBack_C.__UiAnimNotifyModel__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06029E30 RID: 171568 RVA: 0x009CF061 File Offset: 0x009CD261
		public UiAnimNotifyModel()
		{
		}

		// Token: 0x06029E31 RID: 171569 RVA: 0x009CF069 File Offset: 0x009CD269
		[NullableContext(2)]
		public UiAnimNotifyModel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029E32 RID: 171570 RVA: 0x009CF073 File Offset: 0x009CD273
		public UiAnimNotifyModel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029E33 RID: 171571 RVA: 0x009CF07E File Offset: 0x009CD27E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<SUiAnimNotifyModel, USkeletalMeshComponent>) ?? ((Action<SUiAnimNotifyModel, USkeletalMeshComponent>)Delegate.CreateDelegate(typeof(Action<SUiAnimNotifyModel, USkeletalMeshComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06029E34 RID: 171572 RVA: 0x009CF0B0 File Offset: 0x009CD2B0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<SUiAnimNotifyModel, USkeletalMeshComponent> Callback)
		{
			if (UiAnimNotifyModel.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = UiAnimNotifyModel.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (UiAnimNotifyModel.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(UiAnimNotifyModel.OnScriptCallback));
				}
				UiAnimNotifyModel.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, UiAnimNotifyModel.RegisterId);
		}

		// Token: 0x06029E35 RID: 171573 RVA: 0x009CF0EA File Offset: 0x009CD2EA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<SUiAnimNotifyModel, USkeletalMeshComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06029E36 RID: 171574 RVA: 0x009CF0F4 File Offset: 0x009CD2F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(SUiAnimNotifyModel uiAnimNotifyModel, USkeletalMeshComponent mesh)
		{
			UiAnimNotifyModel.__UiAnimNotifyModel_DelegateParams* ptr = stackalloc UiAnimNotifyModel.__UiAnimNotifyModel_DelegateParams[(UIntPtr)223] + 15L / (long)sizeof(UiAnimNotifyModel.__UiAnimNotifyModel_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UiAnimNotifyModel.StaticFunctionPtr(), (void*)ptr, 1);
			if (uiAnimNotifyModel != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SUiAnimNotifyModel.StaticStruct(), &ptr->uiAnimNotifyModel, uiAnimNotifyModel.NativePtr, 1, false);
			}
			ptr->mesh = ((mesh != null) ? mesh.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_UiActorCallBack_C.__UiAnimNotifyModel__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06029E37 RID: 171575 RVA: 0x009CF178 File Offset: 0x009CD378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<SUiAnimNotifyModel, USkeletalMeshComponent> action = target as Action<SUiAnimNotifyModel, USkeletalMeshComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			SUiAnimNotifyModel arg = new SUiAnimNotifyModel(&((UiAnimNotifyModel.__UiAnimNotifyModel_DelegateParams*)__Parameters)->uiAnimNotifyModel, true, true);
			USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(((UiAnimNotifyModel.__UiAnimNotifyModel_DelegateParams*)__Parameters)->mesh);
			action(arg, orCreateUObjectByNativePointer);
		}

		// Token: 0x0401583A RID: 88122
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyModel__DelegateSignature";

		// Token: 0x0401583B RID: 88123
		private static int RegisterId;

		// Token: 0x0200A2F0 RID: 41712
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __UiAnimNotifyModel_DelegateParams
		{
			// Token: 0x04032046 RID: 204870
			[FieldOffset(0)]
			public byte uiAnimNotifyModel;

			// Token: 0x04032047 RID: 204871
			[FieldOffset(192)]
			public IntPtr mesh;
		}

		// Token: 0x0200A2F1 RID: 41713
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032048 RID: 204872
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
