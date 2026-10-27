using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.PostVolumeGlobal.HeightMaskBake.BlackWave
{
	// Token: 0x02003C7F RID: 15487
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_VolumeBlackWave_Mobile.BP_VolumeBlackWave_Mobile_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class BP_VolumeBlackWave_Mobile_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060240FA RID: 147706 RVA: 0x0093416C File Offset: 0x0093236C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumeBlackWave_Mobile_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_VolumeBlackWave_Mobile.BP_VolumeBlackWave_Mobile_C");
			}
			return BP_VolumeBlackWave_Mobile_C._ClassPtr;
		}

		// Token: 0x060240FB RID: 147707 RVA: 0x00934190 File Offset: 0x00932390
		public BP_VolumeBlackWave_Mobile_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumeBlackWave_Mobile_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060240FC RID: 147708 RVA: 0x009341B8 File Offset: 0x009323B8
		[NullableContext(1)]
		public BP_VolumeBlackWave_Mobile_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumeBlackWave_Mobile_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044FC RID: 17660
		// (get) Token: 0x060240FD RID: 147709 RVA: 0x009341EB File Offset: 0x009323EB
		// (set) Token: 0x060240FE RID: 147710 RVA: 0x009341FF File Offset: 0x009323FF
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170044FD RID: 17661
		// (get) Token: 0x060240FF RID: 147711 RVA: 0x00934214 File Offset: 0x00932414
		// (set) Token: 0x06024100 RID: 147712 RVA: 0x00934228 File Offset: 0x00932428
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170044FE RID: 17662
		// (get) Token: 0x06024101 RID: 147713 RVA: 0x0093423D File Offset: 0x0093243D
		// (set) Token: 0x06024102 RID: 147714 RVA: 0x00934251 File Offset: 0x00932451
		public unsafe UTexture2D HeightMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170044FF RID: 17663
		// (get) Token: 0x06024103 RID: 147715 RVA: 0x00934266 File Offset: 0x00932466
		// (set) Token: 0x06024104 RID: 147716 RVA: 0x0093427A File Offset: 0x0093247A
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_Mobile_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x06024105 RID: 147717 RVA: 0x0093428F File Offset: 0x0093248F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeBlackWave_Mobile_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024106 RID: 147718 RVA: 0x009342A3 File Offset: 0x009324A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumeBlackWave_Mobile_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024107 RID: 147719 RVA: 0x009342B8 File Offset: 0x009324B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeBlackWave_Mobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024108 RID: 147720 RVA: 0x009342CC File Offset: 0x009324CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumeBlackWave_Mobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024109 RID: 147721 RVA: 0x009342E1 File Offset: 0x009324E1
		protected BP_VolumeBlackWave_Mobile_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D9B RID: 73115
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_VolumeBlackWave_Mobile.BP_VolumeBlackWave_Mobile_C";

		// Token: 0x04011D9C RID: 73116
		private static IntPtr _ClassPtr;

		// Token: 0x04011D9D RID: 73117
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D9E RID: 73118
		internal static int __PropertyOffset_1;

		// Token: 0x04011D9F RID: 73119
		internal static int __PropertyOffset_2;

		// Token: 0x04011DA0 RID: 73120
		internal static int __PropertyOffset_3;

		// Token: 0x04011DA1 RID: 73121
		internal static int __PropertyOffset_4;

		// Token: 0x04011DA2 RID: 73122
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011DA3 RID: 73123
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
