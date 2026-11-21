using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light.Performance
{
	// Token: 0x020030B5 RID: 12469
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_CustomDepthForToon.BP_CustomDepthForToon_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_CustomDepthForToon_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DF57 RID: 122711 RVA: 0x00907147 File Offset: 0x00905347
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CustomDepthForToon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_CustomDepthForToon.BP_CustomDepthForToon_C");
			}
			return BP_CustomDepthForToon_C._ClassPtr;
		}

		// Token: 0x0601DF58 RID: 122712 RVA: 0x0090716C File Offset: 0x0090536C
		public BP_CustomDepthForToon_C() : this(BuiltinUtils.AllocNativeUObject(BP_CustomDepthForToon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DF59 RID: 122713 RVA: 0x00907194 File Offset: 0x00905394
		[NullableContext(1)]
		public BP_CustomDepthForToon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CustomDepthForToon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0601DF5A RID: 122714 RVA: 0x009071C7 File Offset: 0x009053C7
		// (set) Token: 0x0601DF5B RID: 122715 RVA: 0x009071DB File Offset: 0x009053DB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomDepthForToon_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomDepthForToon_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601DF5C RID: 122716 RVA: 0x009071F0 File Offset: 0x009053F0
		[SkipLocalsInit]
		public virtual void DisableCustomDepthForToon()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__DisableCustomDepthForToon_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF5D RID: 122717 RVA: 0x00907204 File Offset: 0x00905404
		[SkipLocalsInit]
		public virtual void EnableCustomDepthForToon()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__EnableCustomDepthForToon_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF5E RID: 122718 RVA: 0x00907218 File Offset: 0x00905418
		[SkipLocalsInit]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF5F RID: 122719 RVA: 0x0090722C File Offset: 0x0090542C
		[SkipLocalsInit]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF60 RID: 122720 RVA: 0x00907240 File Offset: 0x00905440
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF61 RID: 122721 RVA: 0x00907254 File Offset: 0x00905454
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF62 RID: 122722 RVA: 0x00907268 File Offset: 0x00905468
		protected BP_CustomDepthForToon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD3C RID: 64828
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_CustomDepthForToon.BP_CustomDepthForToon_C";

		// Token: 0x0400FD3D RID: 64829
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD3E RID: 64830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD3F RID: 64831
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FD40 RID: 64832
		private static IntPtr __DisableCustomDepthForToon_NativeFunctionPtr;

		// Token: 0x0400FD41 RID: 64833
		private static IntPtr __EnableCustomDepthForToon_NativeFunctionPtr;

		// Token: 0x0400FD42 RID: 64834
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FD43 RID: 64835
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
