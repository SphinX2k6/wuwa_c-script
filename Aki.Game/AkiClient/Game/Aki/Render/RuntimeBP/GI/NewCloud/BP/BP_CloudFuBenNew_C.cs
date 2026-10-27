using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D56 RID: 15702
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBenNew.BP_CloudFuBenNew_C")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1778)]
	public class BP_CloudFuBenNew_C : AKuroCloudsActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060263F4 RID: 156660 RVA: 0x0096FCF4 File Offset: 0x0096DEF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudFuBenNew_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBenNew.BP_CloudFuBenNew_C");
			}
			return BP_CloudFuBenNew_C._ClassPtr;
		}

		// Token: 0x060263F5 RID: 156661 RVA: 0x0096FD18 File Offset: 0x0096DF18
		public BP_CloudFuBenNew_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudFuBenNew_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263F6 RID: 156662 RVA: 0x0096FD40 File Offset: 0x0096DF40
		[NullableContext(1)]
		public BP_CloudFuBenNew_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudFuBenNew_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005133 RID: 20787
		// (get) Token: 0x060263F7 RID: 156663 RVA: 0x0096FD73 File Offset: 0x0096DF73
		// (set) Token: 0x060263F8 RID: 156664 RVA: 0x0096FD87 File Offset: 0x0096DF87
		public unsafe UChildActorComponent Cloud2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005134 RID: 20788
		// (get) Token: 0x060263F9 RID: 156665 RVA: 0x0096FD9C File Offset: 0x0096DF9C
		// (set) Token: 0x060263FA RID: 156666 RVA: 0x0096FDB0 File Offset: 0x0096DFB0
		public unsafe UChildActorComponent Cloud1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005135 RID: 20789
		// (get) Token: 0x060263FB RID: 156667 RVA: 0x0096FDC5 File Offset: 0x0096DFC5
		// (set) Token: 0x060263FC RID: 156668 RVA: 0x0096FDD9 File Offset: 0x0096DFD9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005136 RID: 20790
		// (get) Token: 0x060263FD RID: 156669 RVA: 0x0096FDEE File Offset: 0x0096DFEE
		// (set) Token: 0x060263FE RID: 156670 RVA: 0x0096FDFE File Offset: 0x0096DFFE
		public unsafe bool EnableSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005137 RID: 20791
		// (get) Token: 0x060263FF RID: 156671 RVA: 0x0096FE0F File Offset: 0x0096E00F
		// (set) Token: 0x06026400 RID: 156672 RVA: 0x0096FE1F File Offset: 0x0096E01F
		public unsafe bool CoverOffsetParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005138 RID: 20792
		// (get) Token: 0x06026401 RID: 156673 RVA: 0x0096FE30 File Offset: 0x0096E030
		// (set) Token: 0x06026402 RID: 156674 RVA: 0x0096FE40 File Offset: 0x0096E040
		public unsafe float Cloud_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005139 RID: 20793
		// (get) Token: 0x06026403 RID: 156675 RVA: 0x0096FE51 File Offset: 0x0096E051
		// (set) Token: 0x06026404 RID: 156676 RVA: 0x0096FE61 File Offset: 0x0096E061
		public unsafe float Cloud_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700513A RID: 20794
		// (get) Token: 0x06026405 RID: 156677 RVA: 0x0096FE72 File Offset: 0x0096E072
		// (set) Token: 0x06026406 RID: 156678 RVA: 0x0096FE86 File Offset: 0x0096E086
		public unsafe PD_CloudPreset_C CloudData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CloudPreset_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700513B RID: 20795
		// (get) Token: 0x06026407 RID: 156679 RVA: 0x0096FE9B File Offset: 0x0096E09B
		// (set) Token: 0x06026408 RID: 156680 RVA: 0x0096FEAB File Offset: 0x0096E0AB
		public unsafe bool Is_Sky_Ocean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700513C RID: 20796
		// (get) Token: 0x06026409 RID: 156681 RVA: 0x0096FEBC File Offset: 0x0096E0BC
		// (set) Token: 0x0602640A RID: 156682 RVA: 0x0096FED1 File Offset: 0x0096E0D1
		[Nullable(1)]
		public TSoftObjectPtr<PD_CloudPrefab_C> CloudAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_10, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700513D RID: 20797
		// (get) Token: 0x0602640B RID: 156683 RVA: 0x0096FEF6 File Offset: 0x0096E0F6
		// (set) Token: 0x0602640C RID: 156684 RVA: 0x0096FF0A File Offset: 0x0096E10A
		public unsafe PD_CloudPrefab_C As_PD_Cloud_Prefab
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CloudPrefab_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700513E RID: 20798
		// (get) Token: 0x0602640D RID: 156685 RVA: 0x0096FF1F File Offset: 0x0096E11F
		// (set) Token: 0x0602640E RID: 156686 RVA: 0x0096FF33 File Offset: 0x0096E133
		public unsafe UAkAudioEvent SkyOceanAudio
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBenNew_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700513F RID: 20799
		// (get) Token: 0x0602640F RID: 156687 RVA: 0x0096FF48 File Offset: 0x0096E148
		// (set) Token: 0x06026410 RID: 156688 RVA: 0x0096FF81 File Offset: 0x0096E181
		[Nullable(1)]
		public TArray<int> SortNumber
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SortNumber) == null)
				{
					result = (this._SortNumber = new TArray<int>(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SortNumber.CopyAssign(value);
			}
		}

		// Token: 0x17005140 RID: 20800
		// (get) Token: 0x06026411 RID: 156689 RVA: 0x0096FF8F File Offset: 0x0096E18F
		// (set) Token: 0x06026412 RID: 156690 RVA: 0x0096FF9F File Offset: 0x0096E19F
		public unsafe bool Counting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005141 RID: 20801
		// (get) Token: 0x06026413 RID: 156691 RVA: 0x0096FFB0 File Offset: 0x0096E1B0
		// (set) Token: 0x06026414 RID: 156692 RVA: 0x0096FFC0 File Offset: 0x0096E1C0
		public unsafe KuroFeatureLevel FeatureLevel
		{
			get
			{
				return (KuroFeatureLevel)(*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_15));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_15) = (byte)value;
			}
		}

		// Token: 0x17005142 RID: 20802
		// (get) Token: 0x06026415 RID: 156693 RVA: 0x0096FFD1 File Offset: 0x0096E1D1
		// (set) Token: 0x06026416 RID: 156694 RVA: 0x0096FFE5 File Offset: 0x0096E1E5
		[Nullable(0)]
		public unsafe TEnumAsByte<E_Cloud_Presents> 当前云
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_16);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005143 RID: 20803
		// (get) Token: 0x06026417 RID: 156695 RVA: 0x0096FFFA File Offset: 0x0096E1FA
		// (set) Token: 0x06026418 RID: 156696 RVA: 0x0097000A File Offset: 0x0096E20A
		public unsafe bool Is_Reversed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005144 RID: 20804
		// (get) Token: 0x06026419 RID: 156697 RVA: 0x0097001B File Offset: 0x0096E21B
		// (set) Token: 0x0602641A RID: 156698 RVA: 0x0097002B File Offset: 0x0096E22B
		public unsafe float Reversed_ZHeight_Bias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005145 RID: 20805
		// (get) Token: 0x0602641B RID: 156699 RVA: 0x0097003C File Offset: 0x0096E23C
		// (set) Token: 0x0602641C RID: 156700 RVA: 0x00970050 File Offset: 0x0096E250
		[Nullable(0)]
		public unsafe TEnumAsByte<E_Cloud_Presents> 待切换云
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_19);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005146 RID: 20806
		// (get) Token: 0x0602641D RID: 156701 RVA: 0x00970065 File Offset: 0x0096E265
		// (set) Token: 0x0602641E RID: 156702 RVA: 0x00970075 File Offset: 0x0096E275
		public unsafe bool CoverNoiseParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005147 RID: 20807
		// (get) Token: 0x0602641F RID: 156703 RVA: 0x00970086 File Offset: 0x0096E286
		// (set) Token: 0x06026420 RID: 156704 RVA: 0x00970096 File Offset: 0x0096E296
		public unsafe bool EnableChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005148 RID: 20808
		// (get) Token: 0x06026421 RID: 156705 RVA: 0x009700A7 File Offset: 0x0096E2A7
		// (set) Token: 0x06026422 RID: 156706 RVA: 0x009700B7 File Offset: 0x0096E2B7
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005149 RID: 20809
		// (get) Token: 0x06026423 RID: 156707 RVA: 0x009700C8 File Offset: 0x0096E2C8
		// (set) Token: 0x06026424 RID: 156708 RVA: 0x009700D8 File Offset: 0x0096E2D8
		public unsafe float Noise_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700514A RID: 20810
		// (get) Token: 0x06026425 RID: 156709 RVA: 0x009700E9 File Offset: 0x0096E2E9
		// (set) Token: 0x06026426 RID: 156710 RVA: 0x009700F9 File Offset: 0x0096E2F9
		public unsafe float Noise_Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x1700514B RID: 20811
		// (get) Token: 0x06026427 RID: 156711 RVA: 0x0097010A File Offset: 0x0096E30A
		// (set) Token: 0x06026428 RID: 156712 RVA: 0x0097011A File Offset: 0x0096E31A
		public unsafe float NoiseTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x1700514C RID: 20812
		// (get) Token: 0x06026429 RID: 156713 RVA: 0x0097012C File Offset: 0x0096E32C
		// (set) Token: 0x0602642A RID: 156714 RVA: 0x00970165 File Offset: 0x0096E365
		[Nullable(1)]
		public FKuroCurveFloat ProgressCurve
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._ProgressCurve) == null)
				{
					result = (this._ProgressCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_26, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_26, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700514D RID: 20813
		// (get) Token: 0x0602642B RID: 156715 RVA: 0x00970186 File Offset: 0x0096E386
		// (set) Token: 0x0602642C RID: 156716 RVA: 0x00970196 File Offset: 0x0096E396
		public unsafe float TotalChangeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x1700514E RID: 20814
		// (get) Token: 0x0602642D RID: 156717 RVA: 0x009701A7 File Offset: 0x0096E3A7
		// (set) Token: 0x0602642E RID: 156718 RVA: 0x009701B7 File Offset: 0x0096E3B7
		public unsafe float CurveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700514F RID: 20815
		// (get) Token: 0x0602642F RID: 156719 RVA: 0x009701C8 File Offset: 0x0096E3C8
		// (set) Token: 0x06026430 RID: 156720 RVA: 0x009701D8 File Offset: 0x0096E3D8
		public unsafe bool CanChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005150 RID: 20816
		// (get) Token: 0x06026431 RID: 156721 RVA: 0x009701E9 File Offset: 0x0096E3E9
		// (set) Token: 0x06026432 RID: 156722 RVA: 0x009701F9 File Offset: 0x0096E3F9
		public unsafe bool First
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBenNew_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026433 RID: 156723 RVA: 0x0097020A File Offset: 0x0096E40A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HiddenOld()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__HiddenOld_NativeFunctionPtr, null);
		}

		// Token: 0x06026434 RID: 156724 RVA: 0x00970220 File Offset: 0x0096E420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(float DeltaTime)
		{
			BP_CloudFuBenNew_C.__Timer_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__Timer_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Timer_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026435 RID: 156725 RVA: 0x00970266 File Offset: 0x0096E466
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Change_Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Change_Start_NativeFunctionPtr, null);
		}

		// Token: 0x06026436 RID: 156726 RVA: 0x0097027A File Offset: 0x0096E47A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 编辑器下切换()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__编辑器下切换_NativeFunctionPtr, null);
		}

		// Token: 0x06026437 RID: 156727 RVA: 0x0097028E File Offset: 0x0096E48E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Cloud_Main_Params_Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Cloud_Main_Params_Update_NativeFunctionPtr, null);
		}

		// Token: 0x06026438 RID: 156728 RVA: 0x009702A4 File Offset: 0x0096E4A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Cloud_Parameters(PD_CloudPrefab_C CloudPrefab, UChildActorComponent CloudActorComponent, float ChangeSpeed, int TransSortNumber)
		{
			BP_CloudFuBenNew_C.__Set_Cloud_Parameters_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__Set_Cloud_Parameters_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__Set_Cloud_Parameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__Set_Cloud_Parameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPrefab = ((CloudPrefab != null) ? CloudPrefab.NativePtr : IntPtr.Zero);
			ptr->CloudActorComponent = ((CloudActorComponent != null) ? CloudActorComponent.NativePtr : IntPtr.Zero);
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->TransSortNumber = TransSortNumber;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Set_Cloud_Parameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026439 RID: 156729 RVA: 0x00970320 File Offset: 0x0096E520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Switch_Clouds_Sub(PD_CloudPrefab_C CloudPresents, float ChangeSpeed)
		{
			BP_CloudFuBenNew_C.__Switch_Clouds_Sub_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__Switch_Clouds_Sub_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__Switch_Clouds_Sub_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__Switch_Clouds_Sub_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPresents = ((CloudPresents != null) ? CloudPresents.NativePtr : IntPtr.Zero);
			ptr->ChangeSpeed = ChangeSpeed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Switch_Clouds_Sub_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602643A RID: 156730 RVA: 0x0097037C File Offset: 0x0096E57C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Hide_BPCloudFuBen_Check(E_Cloud_Presents In_Type)
		{
			BP_CloudFuBenNew_C.__Hide_BPCloudFuBen_Check_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__Hide_BPCloudFuBen_Check_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__Hide_BPCloudFuBen_Check_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__Hide_BPCloudFuBen_Check_NativeFunctionPtr, (void*)ptr, 1);
			ptr->In_Type = In_Type;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Hide_BPCloudFuBen_Check_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602643B RID: 156731 RVA: 0x009703C8 File Offset: 0x0096E5C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_B83844664BD317A13AA3988948C763B1(UObject Loaded)
		{
			BP_CloudFuBenNew_C.__OnLoaded_B83844664BD317A13AA3988948C763B1_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__OnLoaded_B83844664BD317A13AA3988948C763B1_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__OnLoaded_B83844664BD317A13AA3988948C763B1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__OnLoaded_B83844664BD317A13AA3988948C763B1_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__OnLoaded_B83844664BD317A13AA3988948C763B1_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602643C RID: 156732 RVA: 0x0097041D File Offset: 0x0096E61D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602643D RID: 156733 RVA: 0x00970431 File Offset: 0x0096E631
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBenNew_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602643E RID: 156734 RVA: 0x00970448 File Offset: 0x0096E648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CloudFuBenNew_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602643F RID: 156735 RVA: 0x00970490 File Offset: 0x0096E690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CloudFuBenNew_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBenNew_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026440 RID: 156736 RVA: 0x009704D8 File Offset: 0x0096E6D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Switch_Clouds(E_Cloud_Presents CloudPresents, float ChangeSpeed, bool IsInEditor, bool bOverrideCloudRotation)
		{
			BP_CloudFuBenNew_C.__Switch_Clouds_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__Switch_Clouds_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__Switch_Clouds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__Switch_Clouds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPresents = CloudPresents;
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->IsInEditor = IsInEditor;
			ptr->bOverrideCloudRotation = bOverrideCloudRotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Switch_Clouds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026441 RID: 156737 RVA: 0x0097053C File Offset: 0x0096E73C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LoadAndSwitch(TSoftObjectPtr<UObject> Asset, float ChangeSpeed, bool IsInEditor, bool IsAudio)
		{
			BP_CloudFuBenNew_C.__LoadAndSwitch_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__LoadAndSwitch_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__LoadAndSwitch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr, 1);
			if (Asset != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->Asset, Asset.NativePtr, 1);
			}
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->IsInEditor = IsInEditor;
			ptr->IsAudio = IsAudio;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_CloudFuBenNew_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026442 RID: 156738 RVA: 0x009705C0 File Offset: 0x0096E7C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CloudFuBenNew_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026443 RID: 156739 RVA: 0x00970608 File Offset: 0x0096E808
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CloudFuBenNew_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudFuBenNew_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBenNew_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBenNew_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBenNew_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026444 RID: 156740 RVA: 0x0097064F File Offset: 0x0096E84F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Change_Cloud_Editor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Change_Cloud_Editor_NativeFunctionPtr, null);
		}

		// Token: 0x06026445 RID: 156741 RVA: 0x00970663 File Offset: 0x0096E863
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Change_Cloud_Play()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBenNew_C.__Change_Cloud_Play_NativeFunctionPtr, null);
		}

		// Token: 0x06026446 RID: 156742 RVA: 0x00970677 File Offset: 0x0096E877
		protected BP_CloudFuBenNew_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401327F RID: 78463
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBenNew.BP_CloudFuBenNew_C";

		// Token: 0x04013280 RID: 78464
		private static IntPtr _ClassPtr;

		// Token: 0x04013281 RID: 78465
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013282 RID: 78466
		internal static int __PropertyOffset_1;

		// Token: 0x04013283 RID: 78467
		internal static int __PropertyOffset_2;

		// Token: 0x04013284 RID: 78468
		internal static int __PropertyOffset_3;

		// Token: 0x04013285 RID: 78469
		internal static int __PropertyOffset_4;

		// Token: 0x04013286 RID: 78470
		internal static int __PropertyOffset_5;

		// Token: 0x04013287 RID: 78471
		internal static int __PropertyOffset_6;

		// Token: 0x04013288 RID: 78472
		internal static int __PropertyOffset_7;

		// Token: 0x04013289 RID: 78473
		internal static int __PropertyOffset_8;

		// Token: 0x0401328A RID: 78474
		internal static int __PropertyOffset_9;

		// Token: 0x0401328B RID: 78475
		internal static int __PropertyOffset_10;

		// Token: 0x0401328C RID: 78476
		internal static int __PropertyOffset_11;

		// Token: 0x0401328D RID: 78477
		internal static int __PropertyOffset_12;

		// Token: 0x0401328E RID: 78478
		internal static int __PropertyOffset_13;

		// Token: 0x0401328F RID: 78479
		private TArray<int> _SortNumber;

		// Token: 0x04013290 RID: 78480
		internal static int __PropertyOffset_14;

		// Token: 0x04013291 RID: 78481
		internal static int __PropertyOffset_15;

		// Token: 0x04013292 RID: 78482
		internal static int __PropertyOffset_16;

		// Token: 0x04013293 RID: 78483
		internal static int __PropertyOffset_17;

		// Token: 0x04013294 RID: 78484
		internal static int __PropertyOffset_18;

		// Token: 0x04013295 RID: 78485
		internal static int __PropertyOffset_19;

		// Token: 0x04013296 RID: 78486
		internal static int __PropertyOffset_20;

		// Token: 0x04013297 RID: 78487
		internal static int __PropertyOffset_21;

		// Token: 0x04013298 RID: 78488
		internal static int __PropertyOffset_22;

		// Token: 0x04013299 RID: 78489
		internal static int __PropertyOffset_23;

		// Token: 0x0401329A RID: 78490
		internal static int __PropertyOffset_24;

		// Token: 0x0401329B RID: 78491
		internal static int __PropertyOffset_25;

		// Token: 0x0401329C RID: 78492
		internal static int __PropertyOffset_26;

		// Token: 0x0401329D RID: 78493
		private FKuroCurveFloat _ProgressCurve;

		// Token: 0x0401329E RID: 78494
		internal static int __PropertyOffset_27;

		// Token: 0x0401329F RID: 78495
		internal static int __PropertyOffset_28;

		// Token: 0x040132A0 RID: 78496
		internal static int __PropertyOffset_29;

		// Token: 0x040132A1 RID: 78497
		internal static int __PropertyOffset_30;

		// Token: 0x040132A2 RID: 78498
		private static IntPtr __HiddenOld_NativeFunctionPtr;

		// Token: 0x040132A3 RID: 78499
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x040132A4 RID: 78500
		private static IntPtr __Change_Start_NativeFunctionPtr;

		// Token: 0x040132A5 RID: 78501
		private static IntPtr __编辑器下切换_NativeFunctionPtr;

		// Token: 0x040132A6 RID: 78502
		private static IntPtr __Cloud_Main_Params_Update_NativeFunctionPtr;

		// Token: 0x040132A7 RID: 78503
		private static IntPtr __Set_Cloud_Parameters_NativeFunctionPtr;

		// Token: 0x040132A8 RID: 78504
		private static IntPtr __Switch_Clouds_Sub_NativeFunctionPtr;

		// Token: 0x040132A9 RID: 78505
		private static IntPtr __Hide_BPCloudFuBen_Check_NativeFunctionPtr;

		// Token: 0x040132AA RID: 78506
		private static IntPtr __OnLoaded_B83844664BD317A13AA3988948C763B1_NativeFunctionPtr;

		// Token: 0x040132AB RID: 78507
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040132AC RID: 78508
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040132AD RID: 78509
		private static IntPtr __Switch_Clouds_NativeFunctionPtr;

		// Token: 0x040132AE RID: 78510
		private static IntPtr __LoadAndSwitch_NativeFunctionPtr;

		// Token: 0x040132AF RID: 78511
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040132B0 RID: 78512
		private static IntPtr __Change_Cloud_Editor_NativeFunctionPtr;

		// Token: 0x040132B1 RID: 78513
		private static IntPtr __Change_Cloud_Play_NativeFunctionPtr;

		// Token: 0x0200A0D7 RID: 41175
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031BDC RID: 203740
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200A0D8 RID: 41176
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __Set_Cloud_Parameters_FunctionParams
		{
			// Token: 0x04031BDD RID: 203741
			[FieldOffset(0)]
			public IntPtr CloudPrefab;

			// Token: 0x04031BDE RID: 203742
			[FieldOffset(8)]
			public IntPtr CloudActorComponent;

			// Token: 0x04031BDF RID: 203743
			[FieldOffset(16)]
			public float ChangeSpeed;

			// Token: 0x04031BE0 RID: 203744
			[FieldOffset(20)]
			public int TransSortNumber;
		}

		// Token: 0x0200A0D9 RID: 41177
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Switch_Clouds_Sub_FunctionParams
		{
			// Token: 0x04031BE1 RID: 203745
			[FieldOffset(0)]
			public IntPtr CloudPresents;

			// Token: 0x04031BE2 RID: 203746
			[FieldOffset(8)]
			public float ChangeSpeed;
		}

		// Token: 0x0200A0DA RID: 41178
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __Hide_BPCloudFuBen_Check_FunctionParams
		{
			// Token: 0x04031BE3 RID: 203747
			[FieldOffset(0)]
			public TEnumAsByte<E_Cloud_Presents> In_Type;
		}

		// Token: 0x0200A0DB RID: 41179
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_B83844664BD317A13AA3988948C763B1_FunctionParams
		{
			// Token: 0x04031BE4 RID: 203748
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x0200A0DC RID: 41180
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031BE5 RID: 203749
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A0DD RID: 41181
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Switch_Clouds_FunctionParams
		{
			// Token: 0x04031BE6 RID: 203750
			[FieldOffset(0)]
			public TEnumAsByte<E_Cloud_Presents> CloudPresents;

			// Token: 0x04031BE7 RID: 203751
			[FieldOffset(4)]
			public float ChangeSpeed;

			// Token: 0x04031BE8 RID: 203752
			[FieldOffset(8)]
			public bool IsInEditor;

			// Token: 0x04031BE9 RID: 203753
			[FieldOffset(9)]
			public bool bOverrideCloudRotation;
		}

		// Token: 0x0200A0DE RID: 41182
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __LoadAndSwitch_FunctionParams
		{
			// Token: 0x04031BEA RID: 203754
			[FieldOffset(0)]
			public byte Asset;

			// Token: 0x04031BEB RID: 203755
			[FieldOffset(48)]
			public float ChangeSpeed;

			// Token: 0x04031BEC RID: 203756
			[FieldOffset(52)]
			public bool IsInEditor;

			// Token: 0x04031BED RID: 203757
			[FieldOffset(53)]
			public bool IsAudio;
		}

		// Token: 0x0200A0DF RID: 41183
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031BEE RID: 203758
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
