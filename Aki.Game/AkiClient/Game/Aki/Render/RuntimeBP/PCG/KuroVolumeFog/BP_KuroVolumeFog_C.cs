using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroVolumeFog
{
	// Token: 0x02003C75 RID: 15477
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroVolumeFog/BP_KuroVolumeFog.BP_KuroVolumeFog_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class BP_KuroVolumeFog_C : AActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06023EE8 RID: 147176 RVA: 0x00930EA4 File Offset: 0x0092F0A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroVolumeFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroVolumeFog/BP_KuroVolumeFog.BP_KuroVolumeFog_C");
			}
			return BP_KuroVolumeFog_C._ClassPtr;
		}

		// Token: 0x06023EE9 RID: 147177 RVA: 0x00930EC8 File Offset: 0x0092F0C8
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_KuroVolumeFog_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06023EEA RID: 147178 RVA: 0x00930ED0 File Offset: 0x0092F0D0
		public BP_KuroVolumeFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023EEB RID: 147179 RVA: 0x00930EF8 File Offset: 0x0092F0F8
		[NullableContext(1)]
		public BP_KuroVolumeFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x06023EEC RID: 147180 RVA: 0x00930F2B File Offset: 0x0092F12B
		// (set) Token: 0x06023EED RID: 147181 RVA: 0x00930F3F File Offset: 0x0092F13F
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x06023EEE RID: 147182 RVA: 0x00930F54 File Offset: 0x0092F154
		// (set) Token: 0x06023EEF RID: 147183 RVA: 0x00930F68 File Offset: 0x0092F168
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x06023EF0 RID: 147184 RVA: 0x00930F7D File Offset: 0x0092F17D
		// (set) Token: 0x06023EF1 RID: 147185 RVA: 0x00930F91 File Offset: 0x0092F191
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x06023EF2 RID: 147186 RVA: 0x00930FA6 File Offset: 0x0092F1A6
		// (set) Token: 0x06023EF3 RID: 147187 RVA: 0x00930FBA File Offset: 0x0092F1BA
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x06023EF4 RID: 147188 RVA: 0x00930FCF File Offset: 0x0092F1CF
		// (set) Token: 0x06023EF5 RID: 147189 RVA: 0x00930FE3 File Offset: 0x0092F1E3
		public unsafe UTextureRenderTarget2D OriginRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x06023EF6 RID: 147190 RVA: 0x00930FF8 File Offset: 0x0092F1F8
		// (set) Token: 0x06023EF7 RID: 147191 RVA: 0x0093100C File Offset: 0x0092F20C
		public unsafe UTexture HeightTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x06023EF8 RID: 147192 RVA: 0x00931021 File Offset: 0x0092F221
		// (set) Token: 0x06023EF9 RID: 147193 RVA: 0x00931035 File Offset: 0x0092F235
		public unsafe UTextureRenderTarget2D NewRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x06023EFA RID: 147194 RVA: 0x0093104A File Offset: 0x0092F24A
		// (set) Token: 0x06023EFB RID: 147195 RVA: 0x0093105A File Offset: 0x0092F25A
		public unsafe float 颜色强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x06023EFC RID: 147196 RVA: 0x0093106B File Offset: 0x0092F26B
		// (set) Token: 0x06023EFD RID: 147197 RVA: 0x0093107B File Offset: 0x0092F27B
		public unsafe float 阴影强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x06023EFE RID: 147198 RVA: 0x0093108C File Offset: 0x0092F28C
		// (set) Token: 0x06023EFF RID: 147199 RVA: 0x0093109C File Offset: 0x0092F29C
		public unsafe float 偏移距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x06023F00 RID: 147200 RVA: 0x009310AD File Offset: 0x0092F2AD
		// (set) Token: 0x06023F01 RID: 147201 RVA: 0x009310C1 File Offset: 0x0092F2C1
		public unsafe FLinearColor 偏色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x06023F02 RID: 147202 RVA: 0x009310D6 File Offset: 0x0092F2D6
		// (set) Token: 0x06023F03 RID: 147203 RVA: 0x009310E6 File Offset: 0x0092F2E6
		public unsafe float 最大坡度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x06023F04 RID: 147204 RVA: 0x009310F7 File Offset: 0x0092F2F7
		// (set) Token: 0x06023F05 RID: 147205 RVA: 0x00931107 File Offset: 0x0092F307
		public unsafe float 基础浓度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x06023F06 RID: 147206 RVA: 0x00931118 File Offset: 0x0092F318
		// (set) Token: 0x06023F07 RID: 147207 RVA: 0x00931128 File Offset: 0x0092F328
		public unsafe float 浓度强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x06023F08 RID: 147208 RVA: 0x00931139 File Offset: 0x0092F339
		// (set) Token: 0x06023F09 RID: 147209 RVA: 0x00931149 File Offset: 0x0092F349
		public unsafe float 流动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x06023F0A RID: 147210 RVA: 0x0093115A File Offset: 0x0092F35A
		// (set) Token: 0x06023F0B RID: 147211 RVA: 0x0093116E File Offset: 0x0092F36E
		public unsafe FVector 流动方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x06023F0C RID: 147212 RVA: 0x00931183 File Offset: 0x0092F383
		// (set) Token: 0x06023F0D RID: 147213 RVA: 0x00931193 File Offset: 0x0092F393
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x06023F0E RID: 147214 RVA: 0x009311A4 File Offset: 0x0092F3A4
		// (set) Token: 0x06023F0F RID: 147215 RVA: 0x009311B4 File Offset: 0x0092F3B4
		public unsafe float 底部暗度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x06023F10 RID: 147216 RVA: 0x009311C5 File Offset: 0x0092F3C5
		// (set) Token: 0x06023F11 RID: 147217 RVA: 0x009311D5 File Offset: 0x0092F3D5
		public unsafe float 雾气统一厚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x06023F12 RID: 147218 RVA: 0x009311E6 File Offset: 0x0092F3E6
		// (set) Token: 0x06023F13 RID: 147219 RVA: 0x009311F6 File Offset: 0x0092F3F6
		public unsafe float 雾气噪波厚度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x06023F14 RID: 147220 RVA: 0x00931207 File Offset: 0x0092F407
		// (set) Token: 0x06023F15 RID: 147221 RVA: 0x00931217 File Offset: 0x0092F417
		public unsafe bool 双采样噪声
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x06023F16 RID: 147222 RVA: 0x00931228 File Offset: 0x0092F428
		// (set) Token: 0x06023F17 RID: 147223 RVA: 0x00931238 File Offset: 0x0092F438
		public unsafe float 噪波UV平铺
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x06023F18 RID: 147224 RVA: 0x00931249 File Offset: 0x0092F449
		// (set) Token: 0x06023F19 RID: 147225 RVA: 0x0093125D File Offset: 0x0092F45D
		public unsafe FLinearColor 噪波强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x06023F1A RID: 147226 RVA: 0x00931272 File Offset: 0x0092F472
		// (set) Token: 0x06023F1B RID: 147227 RVA: 0x00931286 File Offset: 0x0092F486
		public unsafe UVolumeTexture 噪波贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeFog_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x06023F1C RID: 147228 RVA: 0x0093129B File Offset: 0x0092F49B
		// (set) Token: 0x06023F1D RID: 147229 RVA: 0x009312AB File Offset: 0x0092F4AB
		public unsafe float 开始消隐的距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x06023F1E RID: 147230 RVA: 0x009312BC File Offset: 0x0092F4BC
		// (set) Token: 0x06023F1F RID: 147231 RVA: 0x009312CC File Offset: 0x0092F4CC
		public unsafe float 消隐的距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x06023F20 RID: 147232 RVA: 0x009312DD File Offset: 0x0092F4DD
		// (set) Token: 0x06023F21 RID: 147233 RVA: 0x009312ED File Offset: 0x0092F4ED
		public unsafe bool 技能交互
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x06023F22 RID: 147234 RVA: 0x009312FE File Offset: 0x0092F4FE
		// (set) Token: 0x06023F23 RID: 147235 RVA: 0x0093130E File Offset: 0x0092F50E
		public unsafe float 技能交互强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeFog_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x06023F24 RID: 147236 RVA: 0x00931320 File Offset: 0x0092F520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_KuroVolumeFog_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroVolumeFog_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeFog_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeFog_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeFog_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06023F25 RID: 147237 RVA: 0x00931368 File Offset: 0x0092F568
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_KuroVolumeFog_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_KuroVolumeFog_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeFog_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeFog_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeFog_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06023F26 RID: 147238 RVA: 0x009313AE File Offset: 0x0092F5AE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CaptureHeight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeFog_C.__CaptureHeight_NativeFunctionPtr, null);
		}

		// Token: 0x06023F27 RID: 147239 RVA: 0x009313C2 File Offset: 0x0092F5C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeFog_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023F28 RID: 147240 RVA: 0x009313D6 File Offset: 0x0092F5D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeFog_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023F29 RID: 147241 RVA: 0x009313EB File Offset: 0x0092F5EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023F2A RID: 147242 RVA: 0x009313FF File Offset: 0x0092F5FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023F2B RID: 147243 RVA: 0x00931414 File Offset: 0x0092F614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroVolumeFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023F2C RID: 147244 RVA: 0x0093145C File Offset: 0x0092F65C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023F2D RID: 147245 RVA: 0x009314A3 File Offset: 0x0092F6A3
		protected BP_KuroVolumeFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C6F RID: 72815
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04011C70 RID: 72816
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroVolumeFog/BP_KuroVolumeFog.BP_KuroVolumeFog_C";

		// Token: 0x04011C71 RID: 72817
		private static IntPtr _ClassPtr;

		// Token: 0x04011C72 RID: 72818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C73 RID: 72819
		internal static int __PropertyOffset_1;

		// Token: 0x04011C74 RID: 72820
		internal static int __PropertyOffset_2;

		// Token: 0x04011C75 RID: 72821
		internal static int __PropertyOffset_3;

		// Token: 0x04011C76 RID: 72822
		internal static int __PropertyOffset_4;

		// Token: 0x04011C77 RID: 72823
		internal static int __PropertyOffset_5;

		// Token: 0x04011C78 RID: 72824
		internal static int __PropertyOffset_6;

		// Token: 0x04011C79 RID: 72825
		internal static int __PropertyOffset_7;

		// Token: 0x04011C7A RID: 72826
		internal static int __PropertyOffset_8;

		// Token: 0x04011C7B RID: 72827
		internal static int __PropertyOffset_9;

		// Token: 0x04011C7C RID: 72828
		internal static int __PropertyOffset_10;

		// Token: 0x04011C7D RID: 72829
		internal static int __PropertyOffset_11;

		// Token: 0x04011C7E RID: 72830
		internal static int __PropertyOffset_12;

		// Token: 0x04011C7F RID: 72831
		internal static int __PropertyOffset_13;

		// Token: 0x04011C80 RID: 72832
		internal static int __PropertyOffset_14;

		// Token: 0x04011C81 RID: 72833
		internal static int __PropertyOffset_15;

		// Token: 0x04011C82 RID: 72834
		internal static int __PropertyOffset_16;

		// Token: 0x04011C83 RID: 72835
		internal static int __PropertyOffset_17;

		// Token: 0x04011C84 RID: 72836
		internal static int __PropertyOffset_18;

		// Token: 0x04011C85 RID: 72837
		internal static int __PropertyOffset_19;

		// Token: 0x04011C86 RID: 72838
		internal static int __PropertyOffset_20;

		// Token: 0x04011C87 RID: 72839
		internal static int __PropertyOffset_21;

		// Token: 0x04011C88 RID: 72840
		internal static int __PropertyOffset_22;

		// Token: 0x04011C89 RID: 72841
		internal static int __PropertyOffset_23;

		// Token: 0x04011C8A RID: 72842
		internal static int __PropertyOffset_24;

		// Token: 0x04011C8B RID: 72843
		internal static int __PropertyOffset_25;

		// Token: 0x04011C8C RID: 72844
		internal static int __PropertyOffset_26;

		// Token: 0x04011C8D RID: 72845
		internal static int __PropertyOffset_27;

		// Token: 0x04011C8E RID: 72846
		internal static int __PropertyOffset_28;

		// Token: 0x04011C8F RID: 72847
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04011C90 RID: 72848
		private static IntPtr __CaptureHeight_NativeFunctionPtr;

		// Token: 0x04011C91 RID: 72849
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011C92 RID: 72850
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011C93 RID: 72851
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009EB8 RID: 40632
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031799 RID: 202649
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009EB9 RID: 40633
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403179A RID: 202650
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
