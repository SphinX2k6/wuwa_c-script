using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence.EasyFog
{
	// Token: 0x02003AE4 RID: 15076
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/EasyFog/BP_EasyFog.BP_EasyFog_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class BP_EasyFog_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020988 RID: 133512 RVA: 0x008D7629 File Offset: 0x008D5829
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EasyFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/EasyFog/BP_EasyFog.BP_EasyFog_C");
			}
			return BP_EasyFog_C._ClassPtr;
		}

		// Token: 0x06020989 RID: 133513 RVA: 0x008D7650 File Offset: 0x008D5850
		public BP_EasyFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_EasyFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602098A RID: 133514 RVA: 0x008D7678 File Offset: 0x008D5878
		[NullableContext(1)]
		public BP_EasyFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EasyFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0602098B RID: 133515 RVA: 0x008D76AB File Offset: 0x008D58AB
		// (set) Token: 0x0602098C RID: 133516 RVA: 0x008D76BF File Offset: 0x008D58BF
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0602098D RID: 133517 RVA: 0x008D76D4 File Offset: 0x008D58D4
		// (set) Token: 0x0602098E RID: 133518 RVA: 0x008D76E8 File Offset: 0x008D58E8
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0602098F RID: 133519 RVA: 0x008D76FD File Offset: 0x008D58FD
		// (set) Token: 0x06020990 RID: 133520 RVA: 0x008D7711 File Offset: 0x008D5911
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x06020991 RID: 133521 RVA: 0x008D7726 File Offset: 0x008D5926
		// (set) Token: 0x06020992 RID: 133522 RVA: 0x008D773A File Offset: 0x008D593A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x06020993 RID: 133523 RVA: 0x008D774F File Offset: 0x008D594F
		// (set) Token: 0x06020994 RID: 133524 RVA: 0x008D775F File Offset: 0x008D595F
		public unsafe float FlowmapDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x06020995 RID: 133525 RVA: 0x008D7770 File Offset: 0x008D5970
		// (set) Token: 0x06020996 RID: 133526 RVA: 0x008D7780 File Offset: 0x008D5980
		public unsafe float FlowmapIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x06020997 RID: 133527 RVA: 0x008D7791 File Offset: 0x008D5991
		// (set) Token: 0x06020998 RID: 133528 RVA: 0x008D77A1 File Offset: 0x008D59A1
		public unsafe float FlowmapSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x06020999 RID: 133529 RVA: 0x008D77B2 File Offset: 0x008D59B2
		// (set) Token: 0x0602099A RID: 133530 RVA: 0x008D77C2 File Offset: 0x008D59C2
		public unsafe float FlowmapTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0602099B RID: 133531 RVA: 0x008D77D3 File Offset: 0x008D59D3
		// (set) Token: 0x0602099C RID: 133532 RVA: 0x008D77E3 File Offset: 0x008D59E3
		public unsafe float Wind___Yes_No
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0602099D RID: 133533 RVA: 0x008D77F4 File Offset: 0x008D59F4
		// (set) Token: 0x0602099E RID: 133534 RVA: 0x008D7804 File Offset: 0x008D5A04
		public unsafe float Wind_Speed_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0602099F RID: 133535 RVA: 0x008D7815 File Offset: 0x008D5A15
		// (set) Token: 0x060209A0 RID: 133536 RVA: 0x008D7825 File Offset: 0x008D5A25
		public unsafe float Wind_Speed_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x060209A1 RID: 133537 RVA: 0x008D7836 File Offset: 0x008D5A36
		// (set) Token: 0x060209A2 RID: 133538 RVA: 0x008D7846 File Offset: 0x008D5A46
		public unsafe float Wind_Noise_Tiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x060209A3 RID: 133539 RVA: 0x008D7857 File Offset: 0x008D5A57
		// (set) Token: 0x060209A4 RID: 133540 RVA: 0x008D7867 File Offset: 0x008D5A67
		public unsafe float Wind_Noise_Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x060209A5 RID: 133541 RVA: 0x008D7878 File Offset: 0x008D5A78
		// (set) Token: 0x060209A6 RID: 133542 RVA: 0x008D7888 File Offset: 0x008D5A88
		public unsafe float AddBorderMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x060209A7 RID: 133543 RVA: 0x008D7899 File Offset: 0x008D5A99
		// (set) Token: 0x060209A8 RID: 133544 RVA: 0x008D78AD File Offset: 0x008D5AAD
		public unsafe UTexture Base_Color_Map
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x060209A9 RID: 133545 RVA: 0x008D78C2 File Offset: 0x008D5AC2
		// (set) Token: 0x060209AA RID: 133546 RVA: 0x008D78D6 File Offset: 0x008D5AD6
		public unsafe UTexture Opacity_Map
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x060209AB RID: 133547 RVA: 0x008D78EB File Offset: 0x008D5AEB
		// (set) Token: 0x060209AC RID: 133548 RVA: 0x008D78FF File Offset: 0x008D5AFF
		public unsafe UTexture Normal_Map
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x060209AD RID: 133549 RVA: 0x008D7914 File Offset: 0x008D5B14
		// (set) Token: 0x060209AE RID: 133550 RVA: 0x008D7928 File Offset: 0x008D5B28
		public unsafe UTexture Flowmap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x060209AF RID: 133551 RVA: 0x008D793D File Offset: 0x008D5B3D
		// (set) Token: 0x060209B0 RID: 133552 RVA: 0x008D794D File Offset: 0x008D5B4D
		public unsafe float Use_Atmosphere_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x060209B1 RID: 133553 RVA: 0x008D795E File Offset: 0x008D5B5E
		// (set) Token: 0x060209B2 RID: 133554 RVA: 0x008D7972 File Offset: 0x008D5B72
		public unsafe FLinearColor Base_Color_Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x060209B3 RID: 133555 RVA: 0x008D7987 File Offset: 0x008D5B87
		// (set) Token: 0x060209B4 RID: 133556 RVA: 0x008D7997 File Offset: 0x008D5B97
		public unsafe float BaseColorContrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x060209B5 RID: 133557 RVA: 0x008D79A8 File Offset: 0x008D5BA8
		// (set) Token: 0x060209B6 RID: 133558 RVA: 0x008D79B8 File Offset: 0x008D5BB8
		public unsafe float Base_Color_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x060209B7 RID: 133559 RVA: 0x008D79C9 File Offset: 0x008D5BC9
		// (set) Token: 0x060209B8 RID: 133560 RVA: 0x008D79D9 File Offset: 0x008D5BD9
		public unsafe float Emissive_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x060209B9 RID: 133561 RVA: 0x008D79EA File Offset: 0x008D5BEA
		// (set) Token: 0x060209BA RID: 133562 RVA: 0x008D79FA File Offset: 0x008D5BFA
		public unsafe float Normal_Map_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x060209BB RID: 133563 RVA: 0x008D7A0B File Offset: 0x008D5C0B
		// (set) Token: 0x060209BC RID: 133564 RVA: 0x008D7A1B File Offset: 0x008D5C1B
		public unsafe float Fog_Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x060209BD RID: 133565 RVA: 0x008D7A2C File Offset: 0x008D5C2C
		// (set) Token: 0x060209BE RID: 133566 RVA: 0x008D7A3C File Offset: 0x008D5C3C
		public unsafe float Geometry_Fading_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x060209BF RID: 133567 RVA: 0x008D7A4D File Offset: 0x008D5C4D
		// (set) Token: 0x060209C0 RID: 133568 RVA: 0x008D7A5D File Offset: 0x008D5C5D
		public unsafe float Camera_Fading_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x060209C1 RID: 133569 RVA: 0x008D7A6E File Offset: 0x008D5C6E
		// (set) Token: 0x060209C2 RID: 133570 RVA: 0x008D7A7E File Offset: 0x008D5C7E
		public unsafe float View_Angle_Fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x060209C3 RID: 133571 RVA: 0x008D7A8F File Offset: 0x008D5C8F
		// (set) Token: 0x060209C4 RID: 133572 RVA: 0x008D7A9F File Offset: 0x008D5C9F
		public unsafe float BlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x060209C5 RID: 133573 RVA: 0x008D7AB0 File Offset: 0x008D5CB0
		// (set) Token: 0x060209C6 RID: 133574 RVA: 0x008D7AC4 File Offset: 0x008D5CC4
		public unsafe UMaterialInstanceDynamic DYMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EasyFog_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x060209C7 RID: 133575 RVA: 0x008D7AD9 File Offset: 0x008D5CD9
		// (set) Token: 0x060209C8 RID: 133576 RVA: 0x008D7AE9 File Offset: 0x008D5CE9
		public unsafe bool AfterDof
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x060209C9 RID: 133577 RVA: 0x008D7AFA File Offset: 0x008D5CFA
		// (set) Token: 0x060209CA RID: 133578 RVA: 0x008D7B0A File Offset: 0x008D5D0A
		public unsafe float MobileIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EasyFog_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x060209CB RID: 133579 RVA: 0x008D7B1B File Offset: 0x008D5D1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Raster_Translucency()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EasyFog_C.__Raster_Translucency_NativeFunctionPtr, null);
		}

		// Token: 0x060209CC RID: 133580 RVA: 0x008D7B2F File Offset: 0x008D5D2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EasyFog_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060209CD RID: 133581 RVA: 0x008D7B43 File Offset: 0x008D5D43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EasyFog_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060209CE RID: 133582 RVA: 0x008D7B58 File Offset: 0x008D5D58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_EasyFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_EasyFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EasyFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EasyFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EasyFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060209CF RID: 133583 RVA: 0x008D7BA0 File Offset: 0x008D5DA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_EasyFog_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_EasyFog_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EasyFog_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EasyFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EasyFog_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060209D0 RID: 133584 RVA: 0x008D7BE7 File Offset: 0x008D5DE7
		protected BP_EasyFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCDD RID: 64733
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/EasyFog/BP_EasyFog.BP_EasyFog_C";

		// Token: 0x0400FCDE RID: 64734
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCDF RID: 64735
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCE0 RID: 64736
		internal static int __PropertyOffset_1;

		// Token: 0x0400FCE1 RID: 64737
		internal static int __PropertyOffset_2;

		// Token: 0x0400FCE2 RID: 64738
		internal static int __PropertyOffset_3;

		// Token: 0x0400FCE3 RID: 64739
		internal static int __PropertyOffset_4;

		// Token: 0x0400FCE4 RID: 64740
		internal static int __PropertyOffset_5;

		// Token: 0x0400FCE5 RID: 64741
		internal static int __PropertyOffset_6;

		// Token: 0x0400FCE6 RID: 64742
		internal static int __PropertyOffset_7;

		// Token: 0x0400FCE7 RID: 64743
		internal static int __PropertyOffset_8;

		// Token: 0x0400FCE8 RID: 64744
		internal static int __PropertyOffset_9;

		// Token: 0x0400FCE9 RID: 64745
		internal static int __PropertyOffset_10;

		// Token: 0x0400FCEA RID: 64746
		internal static int __PropertyOffset_11;

		// Token: 0x0400FCEB RID: 64747
		internal static int __PropertyOffset_12;

		// Token: 0x0400FCEC RID: 64748
		internal static int __PropertyOffset_13;

		// Token: 0x0400FCED RID: 64749
		internal static int __PropertyOffset_14;

		// Token: 0x0400FCEE RID: 64750
		internal static int __PropertyOffset_15;

		// Token: 0x0400FCEF RID: 64751
		internal static int __PropertyOffset_16;

		// Token: 0x0400FCF0 RID: 64752
		internal static int __PropertyOffset_17;

		// Token: 0x0400FCF1 RID: 64753
		internal static int __PropertyOffset_18;

		// Token: 0x0400FCF2 RID: 64754
		internal static int __PropertyOffset_19;

		// Token: 0x0400FCF3 RID: 64755
		internal static int __PropertyOffset_20;

		// Token: 0x0400FCF4 RID: 64756
		internal static int __PropertyOffset_21;

		// Token: 0x0400FCF5 RID: 64757
		internal static int __PropertyOffset_22;

		// Token: 0x0400FCF6 RID: 64758
		internal static int __PropertyOffset_23;

		// Token: 0x0400FCF7 RID: 64759
		internal static int __PropertyOffset_24;

		// Token: 0x0400FCF8 RID: 64760
		internal static int __PropertyOffset_25;

		// Token: 0x0400FCF9 RID: 64761
		internal static int __PropertyOffset_26;

		// Token: 0x0400FCFA RID: 64762
		internal static int __PropertyOffset_27;

		// Token: 0x0400FCFB RID: 64763
		internal static int __PropertyOffset_28;

		// Token: 0x0400FCFC RID: 64764
		internal static int __PropertyOffset_29;

		// Token: 0x0400FCFD RID: 64765
		internal static int __PropertyOffset_30;

		// Token: 0x0400FCFE RID: 64766
		internal static int __PropertyOffset_31;

		// Token: 0x0400FCFF RID: 64767
		internal static int __PropertyOffset_32;

		// Token: 0x0400FD00 RID: 64768
		private static IntPtr __Raster_Translucency_NativeFunctionPtr;

		// Token: 0x0400FD01 RID: 64769
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FD02 RID: 64770
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009BE5 RID: 39909
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031279 RID: 201337
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
