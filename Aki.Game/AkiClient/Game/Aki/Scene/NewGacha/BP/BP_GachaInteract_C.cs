using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A48 RID: 14920
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/BP_GachaInteract.BP_GachaInteract_C")]
	[UnrealStructLayout(1712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1705)]
	public class BP_GachaInteract_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_Gacha_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601F749 RID: 128841 RVA: 0x008B8D5D File Offset: 0x008B6F5D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GachaInteract_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Scene/NewGacha/BP/BP_GachaInteract.BP_GachaInteract_C");
			}
			return BP_GachaInteract_C._ClassPtr;
		}

		// Token: 0x0601F74A RID: 128842 RVA: 0x008B8D84 File Offset: 0x008B6F84
		public BP_GachaInteract_C() : this(BuiltinUtils.AllocNativeUObject(BP_GachaInteract_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F74B RID: 128843 RVA: 0x008B8DAC File Offset: 0x008B6FAC
		[NullableContext(1)]
		public BP_GachaInteract_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GachaInteract_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0601F74C RID: 128844 RVA: 0x008B8DDF File Offset: 0x008B6FDF
		// (set) Token: 0x0601F74D RID: 128845 RVA: 0x008B8DF3 File Offset: 0x008B6FF3
		public unsafe UChildActorComponent Sequence02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x0601F74E RID: 128846 RVA: 0x008B8E08 File Offset: 0x008B7008
		// (set) Token: 0x0601F74F RID: 128847 RVA: 0x008B8E1C File Offset: 0x008B701C
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0601F750 RID: 128848 RVA: 0x008B8E31 File Offset: 0x008B7031
		// (set) Token: 0x0601F751 RID: 128849 RVA: 0x008B8E45 File Offset: 0x008B7045
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x0601F752 RID: 128850 RVA: 0x008B8E5A File Offset: 0x008B705A
		// (set) Token: 0x0601F753 RID: 128851 RVA: 0x008B8E6E File Offset: 0x008B706E
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0601F754 RID: 128852 RVA: 0x008B8E83 File Offset: 0x008B7083
		// (set) Token: 0x0601F755 RID: 128853 RVA: 0x008B8E93 File Offset: 0x008B7093
		public unsafe float Timeline_0_NewTrack_1_10DC02544B28F1F647045DBFB41885D3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0601F756 RID: 128854 RVA: 0x008B8EA4 File Offset: 0x008B70A4
		// (set) Token: 0x0601F757 RID: 128855 RVA: 0x008B8EB4 File Offset: 0x008B70B4
		public unsafe float Timeline_0_NewTrack_0_10DC02544B28F1F647045DBFB41885D3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0601F758 RID: 128856 RVA: 0x008B8EC5 File Offset: 0x008B70C5
		// (set) Token: 0x0601F759 RID: 128857 RVA: 0x008B8ED9 File Offset: 0x008B70D9
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_10DC02544B28F1F647045DBFB41885D3
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0601F75A RID: 128858 RVA: 0x008B8EEE File Offset: 0x008B70EE
		// (set) Token: 0x0601F75B RID: 128859 RVA: 0x008B8F02 File Offset: 0x008B7102
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x0601F75C RID: 128860 RVA: 0x008B8F17 File Offset: 0x008B7117
		// (set) Token: 0x0601F75D RID: 128861 RVA: 0x008B8F2B File Offset: 0x008B712B
		[Nullable(0)]
		public unsafe TEnumAsByte<E_GachaResultNew> Gacha_Result
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_9);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x0601F75E RID: 128862 RVA: 0x008B8F40 File Offset: 0x008B7140
		// (set) Token: 0x0601F75F RID: 128863 RVA: 0x008B8F54 File Offset: 0x008B7154
		public unsafe ASpotLight SpotLightInteract
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASpotLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x0601F760 RID: 128864 RVA: 0x008B8F69 File Offset: 0x008B7169
		// (set) Token: 0x0601F761 RID: 128865 RVA: 0x008B8F7D File Offset: 0x008B717D
		public unsafe ACameraActor CameraShow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x0601F762 RID: 128866 RVA: 0x008B8F92 File Offset: 0x008B7192
		// (set) Token: 0x0601F763 RID: 128867 RVA: 0x008B8FA6 File Offset: 0x008B71A6
		public unsafe FLinearColor Purple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x0601F764 RID: 128868 RVA: 0x008B8FBB File Offset: 0x008B71BB
		// (set) Token: 0x0601F765 RID: 128869 RVA: 0x008B8FCF File Offset: 0x008B71CF
		public unsafe FLinearColor Gold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x0601F766 RID: 128870 RVA: 0x008B8FE4 File Offset: 0x008B71E4
		// (set) Token: 0x0601F767 RID: 128871 RVA: 0x008B8FF8 File Offset: 0x008B71F8
		public unsafe FLinearColor Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x0601F768 RID: 128872 RVA: 0x008B900D File Offset: 0x008B720D
		// (set) Token: 0x0601F769 RID: 128873 RVA: 0x008B9021 File Offset: 0x008B7221
		public unsafe FLinearColor AwardColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x0601F76A RID: 128874 RVA: 0x008B9036 File Offset: 0x008B7236
		// (set) Token: 0x0601F76B RID: 128875 RVA: 0x008B904A File Offset: 0x008B724A
		public unsafe ASpotLight Spot_Light_Seq
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASpotLight>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x0601F76C RID: 128876 RVA: 0x008B905F File Offset: 0x008B725F
		// (set) Token: 0x0601F76D RID: 128877 RVA: 0x008B9073 File Offset: 0x008B7273
		public unsafe BP_UpdateInteract_C UpdateInteract
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_UpdateInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x0601F76E RID: 128878 RVA: 0x008B9088 File Offset: 0x008B7288
		// (set) Token: 0x0601F76F RID: 128879 RVA: 0x008B909C File Offset: 0x008B729C
		public unsafe ACameraActor CameraShowRoom
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x0601F770 RID: 128880 RVA: 0x008B90B1 File Offset: 0x008B72B1
		// (set) Token: 0x0601F771 RID: 128881 RVA: 0x008B90C1 File Offset: 0x008B72C1
		public unsafe float WhiteScreenWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x0601F772 RID: 128882 RVA: 0x008B90D2 File Offset: 0x008B72D2
		// (set) Token: 0x0601F773 RID: 128883 RVA: 0x008B90E2 File Offset: 0x008B72E2
		public unsafe bool WhiteScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x0601F774 RID: 128884 RVA: 0x008B90F3 File Offset: 0x008B72F3
		// (set) Token: 0x0601F775 RID: 128885 RVA: 0x008B9107 File Offset: 0x008B7307
		public unsafe ALevelSequenceActor LevelSequenceShow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x0601F776 RID: 128886 RVA: 0x008B911C File Offset: 0x008B731C
		// (set) Token: 0x0601F777 RID: 128887 RVA: 0x008B9130 File Offset: 0x008B7330
		public unsafe ALevelSequenceActor LevelSequenceInteract
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x0601F778 RID: 128888 RVA: 0x008B9148 File Offset: 0x008B7348
		// (set) Token: 0x0601F779 RID: 128889 RVA: 0x008B9181 File Offset: 0x008B7381
		[Nullable(1)]
		public TArray<ULevelSequence> LevelSeqAll
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelSequence> result;
				if ((result = this._LevelSeqAll) == null)
				{
					result = (this._LevelSeqAll = new TArray<ULevelSequence>(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_23, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LevelSeqAll.CopyAssign(value);
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x0601F77A RID: 128890 RVA: 0x008B918F File Offset: 0x008B738F
		// (set) Token: 0x0601F77B RID: 128891 RVA: 0x008B91A3 File Offset: 0x008B73A3
		public unsafe AActor Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x0601F77C RID: 128892 RVA: 0x008B91B8 File Offset: 0x008B73B8
		// (set) Token: 0x0601F77D RID: 128893 RVA: 0x008B91C8 File Offset: 0x008B73C8
		public unsafe bool FinishedInitGachaResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x0601F77E RID: 128894 RVA: 0x008B91D9 File Offset: 0x008B73D9
		// (set) Token: 0x0601F77F RID: 128895 RVA: 0x008B91E9 File Offset: 0x008B73E9
		public unsafe bool ShowUpdaterOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x0601F780 RID: 128896 RVA: 0x008B91FA File Offset: 0x008B73FA
		// (set) Token: 0x0601F781 RID: 128897 RVA: 0x008B920A File Offset: 0x008B740A
		public unsafe bool IsSkip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x0601F782 RID: 128898 RVA: 0x008B921B File Offset: 0x008B741B
		// (set) Token: 0x0601F783 RID: 128899 RVA: 0x008B922F File Offset: 0x008B742F
		public unsafe AStaticMeshActor SkyBoxShow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GachaInteract_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x0601F784 RID: 128900 RVA: 0x008B9244 File Offset: 0x008B7444
		// (set) Token: 0x0601F785 RID: 128901 RVA: 0x008B9258 File Offset: 0x008B7458
		[Nullable(1)]
		public unsafe string _string
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_GachaInteract_C.__PropertyOffset_29)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_GachaInteract_C.__PropertyOffset_29)), value);
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x0601F786 RID: 128902 RVA: 0x008B926D File Offset: 0x008B746D
		// (set) Token: 0x0601F787 RID: 128903 RVA: 0x008B927D File Offset: 0x008B747D
		public unsafe bool tickable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GachaInteract_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F788 RID: 128904 RVA: 0x008B9290 File Offset: 0x008B7490
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IntroStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__IntroStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__IntroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__IntroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__IntroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__IntroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F789 RID: 128905 RVA: 0x008B92DD File Offset: 0x008B74DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TSGachaShowroomStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__TSGachaShowroomStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601F78A RID: 128906 RVA: 0x008B92F4 File Offset: 0x008B74F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsNewWorkFlow(ref bool IsNew)
		{
			BP_GachaInteract_C.__IsNewWorkFlow_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__IsNewWorkFlow_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__IsNewWorkFlow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsNew = IsNew;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__IsNewWorkFlow_NativeFunctionPtr, (void*)ptr);
			IsNew = ptr->IsNew;
		}

		// Token: 0x0601F78B RID: 128907 RVA: 0x008B9344 File Offset: 0x008B7544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SelectLevelSeq(int Num)
		{
			BP_GachaInteract_C.__SelectLevelSeq_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__SelectLevelSeq_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_GachaInteract_C.__SelectLevelSeq_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__SelectLevelSeq_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Num = Num;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__SelectLevelSeq_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F78C RID: 128908 RVA: 0x008B938A File Offset: 0x008B758A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _5SSTenShotGold()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___5SSTenShotGold_NativeFunctionPtr, null);
		}

		// Token: 0x0601F78D RID: 128909 RVA: 0x008B939E File Offset: 0x008B759E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _4SSTenShotPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___4SSTenShotPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601F78E RID: 128910 RVA: 0x008B93B2 File Offset: 0x008B75B2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _3SSOneShotGold()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___3SSOneShotGold_NativeFunctionPtr, null);
		}

		// Token: 0x0601F78F RID: 128911 RVA: 0x008B93C6 File Offset: 0x008B75C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _2SSOneShotPurple()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___2SSOneShotPurple_NativeFunctionPtr, null);
		}

		// Token: 0x0601F790 RID: 128912 RVA: 0x008B93DA File Offset: 0x008B75DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _1SSOneShotNormal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.___1SSOneShotNormal_NativeFunctionPtr, null);
		}

		// Token: 0x0601F791 RID: 128913 RVA: 0x008B93F0 File Offset: 0x008B75F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TSInitParameters(E_GachaResultNew GachaResult)
		{
			BP_GachaInteract_C.__TSInitParameters_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__TSInitParameters_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__TSInitParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__TSInitParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GachaResult = GachaResult;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__TSInitParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F792 RID: 128914 RVA: 0x008B943B File Offset: 0x008B763B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_Award_Parameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Init_Award_Parameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601F793 RID: 128915 RVA: 0x008B944F File Offset: 0x008B764F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F794 RID: 128916 RVA: 0x008B9463 File Offset: 0x008B7663
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F795 RID: 128917 RVA: 0x008B9478 File Offset: 0x008B7678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601F796 RID: 128918 RVA: 0x008B948C File Offset: 0x008B768C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601F797 RID: 128919 RVA: 0x008B94A0 File Offset: 0x008B76A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InteractStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__InteractStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__InteractStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__InteractStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__InteractStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__InteractStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F798 RID: 128920 RVA: 0x008B94F0 File Offset: 0x008B76F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OutroStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__OutroStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__OutroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__OutroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__OutroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__OutroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F799 RID: 128921 RVA: 0x008B9540 File Offset: 0x008B7740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShowroomStart(int Frame, float Subtime)
		{
			BP_GachaInteract_C.__ShowroomStart_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ShowroomStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_GachaInteract_C.__ShowroomStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ShowroomStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ShowroomStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F79A RID: 128922 RVA: 0x008B958D File Offset: 0x008B778D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F79B RID: 128923 RVA: 0x008B95A1 File Offset: 0x008B77A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F79C RID: 128924 RVA: 0x008B95B8 File Offset: 0x008B77B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GachaInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F79D RID: 128925 RVA: 0x008B9600 File Offset: 0x008B7800
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GachaInteract_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F79E RID: 128926 RVA: 0x008B9647 File Offset: 0x008B7847
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndGachaSequence()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__EndGachaSequence_NativeFunctionPtr, null);
		}

		// Token: 0x0601F79F RID: 128927 RVA: 0x008B965B File Offset: 0x008B785B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitGachaResults()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__InitGachaResults_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A0 RID: 128928 RVA: 0x008B966F File Offset: 0x008B786F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WhiteScreenStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__WhiteScreenStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A1 RID: 128929 RVA: 0x008B9683 File Offset: 0x008B7883
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void WhiteScreenOff()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__WhiteScreenOff_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A2 RID: 128930 RVA: 0x008B9697 File Offset: 0x008B7897
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Sequence_finshed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Sequence_finshed_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A3 RID: 128931 RVA: 0x008B96AB File Offset: 0x008B78AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void New_Outro()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__New_Outro_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A4 RID: 128932 RVA: 0x008B96BF File Offset: 0x008B78BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetGachaShowSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__SetGachaShowSeq_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A5 RID: 128933 RVA: 0x008B96D3 File Offset: 0x008B78D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Updater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Updater_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A6 RID: 128934 RVA: 0x008B96E7 File Offset: 0x008B78E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Finished()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__Finished_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A7 RID: 128935 RVA: 0x008B96FB File Offset: 0x008B78FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601F7A8 RID: 128936 RVA: 0x008B970F File Offset: 0x008B790F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F7A9 RID: 128937 RVA: 0x008B9724 File Offset: 0x008B7924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F7AA RID: 128938 RVA: 0x008B9770 File Offset: 0x008B7970
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_GachaInteract_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GachaInteract_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F7AB RID: 128939 RVA: 0x008B97BC File Offset: 0x008B79BC
		protected BP_GachaInteract_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F1C0 RID: 61888
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_GachaInteract.BP_GachaInteract_C";

		// Token: 0x0400F1C1 RID: 61889
		private static IntPtr _ClassPtr;

		// Token: 0x0400F1C2 RID: 61890
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F1C3 RID: 61891
		internal static int __PropertyOffset_1;

		// Token: 0x0400F1C4 RID: 61892
		internal static int __PropertyOffset_2;

		// Token: 0x0400F1C5 RID: 61893
		internal static int __PropertyOffset_3;

		// Token: 0x0400F1C6 RID: 61894
		internal static int __PropertyOffset_4;

		// Token: 0x0400F1C7 RID: 61895
		internal static int __PropertyOffset_5;

		// Token: 0x0400F1C8 RID: 61896
		internal static int __PropertyOffset_6;

		// Token: 0x0400F1C9 RID: 61897
		internal static int __PropertyOffset_7;

		// Token: 0x0400F1CA RID: 61898
		internal static int __PropertyOffset_8;

		// Token: 0x0400F1CB RID: 61899
		internal static int __PropertyOffset_9;

		// Token: 0x0400F1CC RID: 61900
		internal static int __PropertyOffset_10;

		// Token: 0x0400F1CD RID: 61901
		internal static int __PropertyOffset_11;

		// Token: 0x0400F1CE RID: 61902
		internal static int __PropertyOffset_12;

		// Token: 0x0400F1CF RID: 61903
		internal static int __PropertyOffset_13;

		// Token: 0x0400F1D0 RID: 61904
		internal static int __PropertyOffset_14;

		// Token: 0x0400F1D1 RID: 61905
		internal static int __PropertyOffset_15;

		// Token: 0x0400F1D2 RID: 61906
		internal static int __PropertyOffset_16;

		// Token: 0x0400F1D3 RID: 61907
		internal static int __PropertyOffset_17;

		// Token: 0x0400F1D4 RID: 61908
		internal static int __PropertyOffset_18;

		// Token: 0x0400F1D5 RID: 61909
		internal static int __PropertyOffset_19;

		// Token: 0x0400F1D6 RID: 61910
		internal static int __PropertyOffset_20;

		// Token: 0x0400F1D7 RID: 61911
		internal static int __PropertyOffset_21;

		// Token: 0x0400F1D8 RID: 61912
		internal static int __PropertyOffset_22;

		// Token: 0x0400F1D9 RID: 61913
		internal static int __PropertyOffset_23;

		// Token: 0x0400F1DA RID: 61914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelSequence> _LevelSeqAll;

		// Token: 0x0400F1DB RID: 61915
		internal static int __PropertyOffset_24;

		// Token: 0x0400F1DC RID: 61916
		internal static int __PropertyOffset_25;

		// Token: 0x0400F1DD RID: 61917
		internal static int __PropertyOffset_26;

		// Token: 0x0400F1DE RID: 61918
		internal static int __PropertyOffset_27;

		// Token: 0x0400F1DF RID: 61919
		internal static int __PropertyOffset_28;

		// Token: 0x0400F1E0 RID: 61920
		internal static int __PropertyOffset_29;

		// Token: 0x0400F1E1 RID: 61921
		internal static int __PropertyOffset_30;

		// Token: 0x0400F1E2 RID: 61922
		private static IntPtr __IntroStart_NativeFunctionPtr;

		// Token: 0x0400F1E3 RID: 61923
		private static IntPtr __TSGachaShowroomStart_NativeFunctionPtr;

		// Token: 0x0400F1E4 RID: 61924
		private static IntPtr __IsNewWorkFlow_NativeFunctionPtr;

		// Token: 0x0400F1E5 RID: 61925
		private static IntPtr __SelectLevelSeq_NativeFunctionPtr;

		// Token: 0x0400F1E6 RID: 61926
		private static IntPtr ___5SSTenShotGold_NativeFunctionPtr;

		// Token: 0x0400F1E7 RID: 61927
		private static IntPtr ___4SSTenShotPurple_NativeFunctionPtr;

		// Token: 0x0400F1E8 RID: 61928
		private static IntPtr ___3SSOneShotGold_NativeFunctionPtr;

		// Token: 0x0400F1E9 RID: 61929
		private static IntPtr ___2SSOneShotPurple_NativeFunctionPtr;

		// Token: 0x0400F1EA RID: 61930
		private static IntPtr ___1SSOneShotNormal_NativeFunctionPtr;

		// Token: 0x0400F1EB RID: 61931
		private static IntPtr __TSInitParameters_NativeFunctionPtr;

		// Token: 0x0400F1EC RID: 61932
		private static IntPtr __Init_Award_Parameters_NativeFunctionPtr;

		// Token: 0x0400F1ED RID: 61933
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F1EE RID: 61934
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0400F1EF RID: 61935
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0400F1F0 RID: 61936
		private static IntPtr __InteractStart_NativeFunctionPtr;

		// Token: 0x0400F1F1 RID: 61937
		private static IntPtr __OutroStart_NativeFunctionPtr;

		// Token: 0x0400F1F2 RID: 61938
		private static IntPtr __ShowroomStart_NativeFunctionPtr;

		// Token: 0x0400F1F3 RID: 61939
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F1F4 RID: 61940
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F1F5 RID: 61941
		private static IntPtr __EndGachaSequence_NativeFunctionPtr;

		// Token: 0x0400F1F6 RID: 61942
		private static IntPtr __InitGachaResults_NativeFunctionPtr;

		// Token: 0x0400F1F7 RID: 61943
		private static IntPtr __WhiteScreenStart_NativeFunctionPtr;

		// Token: 0x0400F1F8 RID: 61944
		private static IntPtr __WhiteScreenOff_NativeFunctionPtr;

		// Token: 0x0400F1F9 RID: 61945
		private static IntPtr __Sequence_finshed_NativeFunctionPtr;

		// Token: 0x0400F1FA RID: 61946
		private static IntPtr __New_Outro_NativeFunctionPtr;

		// Token: 0x0400F1FB RID: 61947
		private static IntPtr __SetGachaShowSeq_NativeFunctionPtr;

		// Token: 0x0400F1FC RID: 61948
		private static IntPtr __Updater_NativeFunctionPtr;

		// Token: 0x0400F1FD RID: 61949
		private static IntPtr __Finished_NativeFunctionPtr;

		// Token: 0x0400F1FE RID: 61950
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400F1FF RID: 61951
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009AE3 RID: 39651
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IntroStart_FunctionParams
		{
			// Token: 0x040310AF RID: 200879
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310B0 RID: 200880
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02009AE4 RID: 39652
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsNewWorkFlow_FunctionParams
		{
			// Token: 0x040310B1 RID: 200881
			[FieldOffset(0)]
			public bool IsNew;
		}

		// Token: 0x02009AE5 RID: 39653
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SelectLevelSeq_FunctionParams
		{
			// Token: 0x040310B2 RID: 200882
			[FieldOffset(0)]
			public int Num;
		}

		// Token: 0x02009AE6 RID: 39654
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __TSInitParameters_FunctionParams
		{
			// Token: 0x040310B3 RID: 200883
			[FieldOffset(0)]
			public TEnumAsByte<E_GachaResultNew> GachaResult;
		}

		// Token: 0x02009AE7 RID: 39655
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InteractStart_FunctionParams
		{
			// Token: 0x040310B4 RID: 200884
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310B5 RID: 200885
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02009AE8 RID: 39656
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutroStart_FunctionParams
		{
			// Token: 0x040310B6 RID: 200886
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310B7 RID: 200887
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02009AE9 RID: 39657
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ShowroomStart_FunctionParams
		{
			// Token: 0x040310B8 RID: 200888
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310B9 RID: 200889
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02009AEA RID: 39658
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040310BA RID: 200890
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009AEB RID: 39659
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040310BB RID: 200891
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
