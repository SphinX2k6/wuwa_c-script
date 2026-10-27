using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.PostVolumeGlobal.HeightMaskBake.BlackWave
{
	// Token: 0x02003C7E RID: 15486
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_VolumeBlackWave.BP_VolumeBlackWave_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1100)]
	public class BP_VolumeBlackWave_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060240E6 RID: 147686 RVA: 0x00933FA4 File Offset: 0x009321A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumeBlackWave_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_VolumeBlackWave.BP_VolumeBlackWave_C");
			}
			return BP_VolumeBlackWave_C._ClassPtr;
		}

		// Token: 0x060240E7 RID: 147687 RVA: 0x00933FC8 File Offset: 0x009321C8
		public BP_VolumeBlackWave_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumeBlackWave_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060240E8 RID: 147688 RVA: 0x00933FF0 File Offset: 0x009321F0
		[NullableContext(1)]
		public BP_VolumeBlackWave_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumeBlackWave_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x060240E9 RID: 147689 RVA: 0x00934023 File Offset: 0x00932223
		// (set) Token: 0x060240EA RID: 147690 RVA: 0x00934037 File Offset: 0x00932237
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x060240EB RID: 147691 RVA: 0x0093404C File Offset: 0x0093224C
		// (set) Token: 0x060240EC RID: 147692 RVA: 0x00934060 File Offset: 0x00932260
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x060240ED RID: 147693 RVA: 0x00934075 File Offset: 0x00932275
		// (set) Token: 0x060240EE RID: 147694 RVA: 0x00934089 File Offset: 0x00932289
		public unsafe UTexture2D HeightMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x060240EF RID: 147695 RVA: 0x0093409E File Offset: 0x0093229E
		// (set) Token: 0x060240F0 RID: 147696 RVA: 0x009340B2 File Offset: 0x009322B2
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x060240F1 RID: 147697 RVA: 0x009340C7 File Offset: 0x009322C7
		// (set) Token: 0x060240F2 RID: 147698 RVA: 0x009340DB File Offset: 0x009322DB
		public unsafe UTextureRenderTarget2D CombineRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumeBlackWave_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170044FB RID: 17659
		// (get) Token: 0x060240F3 RID: 147699 RVA: 0x009340F0 File Offset: 0x009322F0
		// (set) Token: 0x060240F4 RID: 147700 RVA: 0x00934100 File Offset: 0x00932300
		public unsafe float HeightScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VolumeBlackWave_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VolumeBlackWave_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x060240F5 RID: 147701 RVA: 0x00934111 File Offset: 0x00932311
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeBlackWave_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060240F6 RID: 147702 RVA: 0x00934125 File Offset: 0x00932325
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumeBlackWave_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240F7 RID: 147703 RVA: 0x0093413A File Offset: 0x0093233A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VolumeBlackWave_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060240F8 RID: 147704 RVA: 0x0093414E File Offset: 0x0093234E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VolumeBlackWave_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060240F9 RID: 147705 RVA: 0x00934163 File Offset: 0x00932363
		protected BP_VolumeBlackWave_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D90 RID: 73104
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/HeightMaskBake/BlackWave/BP_VolumeBlackWave.BP_VolumeBlackWave_C";

		// Token: 0x04011D91 RID: 73105
		private static IntPtr _ClassPtr;

		// Token: 0x04011D92 RID: 73106
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D93 RID: 73107
		internal static int __PropertyOffset_1;

		// Token: 0x04011D94 RID: 73108
		internal static int __PropertyOffset_2;

		// Token: 0x04011D95 RID: 73109
		internal static int __PropertyOffset_3;

		// Token: 0x04011D96 RID: 73110
		internal static int __PropertyOffset_4;

		// Token: 0x04011D97 RID: 73111
		internal static int __PropertyOffset_5;

		// Token: 0x04011D98 RID: 73112
		internal static int __PropertyOffset_6;

		// Token: 0x04011D99 RID: 73113
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011D9A RID: 73114
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
