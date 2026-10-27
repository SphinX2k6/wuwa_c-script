using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D90 RID: 15760
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_PresetManager.NinjaLive_PresetManager_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1537)]
	public class NinjaLive_PresetManager_C : AActor, IUnrealUObject, IUnrealObject, IWriteDataTableInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06026FB0 RID: 159664 RVA: 0x00983330 File Offset: 0x00981530
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLive_PresetManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_PresetManager.NinjaLive_PresetManager_C");
			}
			return NinjaLive_PresetManager_C._ClassPtr;
		}

		// Token: 0x06026FB1 RID: 159665 RVA: 0x00983354 File Offset: 0x00981554
		public NinjaLive_PresetManager_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLive_PresetManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026FB2 RID: 159666 RVA: 0x0098337C File Offset: 0x0098157C
		public NinjaLive_PresetManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLive_PresetManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170055A3 RID: 21923
		// (get) Token: 0x06026FB3 RID: 159667 RVA: 0x009833AF File Offset: 0x009815AF
		// (set) Token: 0x06026FB4 RID: 159668 RVA: 0x009833C3 File Offset: 0x009815C3
		[Nullable(2)]
		public unsafe UChildActorComponent WriteDataTableUtility
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170055A4 RID: 21924
		// (get) Token: 0x06026FB5 RID: 159669 RVA: 0x009833D8 File Offset: 0x009815D8
		// (set) Token: 0x06026FB6 RID: 159670 RVA: 0x009833EC File Offset: 0x009815EC
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170055A5 RID: 21925
		// (get) Token: 0x06026FB7 RID: 159671 RVA: 0x00983401 File Offset: 0x00981601
		// (set) Token: 0x06026FB8 RID: 159672 RVA: 0x00983415 File Offset: 0x00981615
		[Nullable(2)]
		public unsafe UMaterialBillboardComponent EditorIcon
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170055A6 RID: 21926
		// (get) Token: 0x06026FB9 RID: 159673 RVA: 0x0098342A File Offset: 0x0098162A
		// (set) Token: 0x06026FBA RID: 159674 RVA: 0x0098343E File Offset: 0x0098163E
		public unsafe FName AssetTrimmedName_Global
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170055A7 RID: 21927
		// (get) Token: 0x06026FBB RID: 159675 RVA: 0x00983453 File Offset: 0x00981653
		// (set) Token: 0x06026FBC RID: 159676 RVA: 0x00983467 File Offset: 0x00981667
		public unsafe FName AssetPath_Global
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170055A8 RID: 21928
		// (get) Token: 0x06026FBD RID: 159677 RVA: 0x0098347C File Offset: 0x0098167C
		// (set) Token: 0x06026FBE RID: 159678 RVA: 0x00983490 File Offset: 0x00981690
		[Nullable(2)]
		public unsafe NinjaLiveGUI_C BP_Widget_GUI1_Var
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLiveGUI_C>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_6);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170055A9 RID: 21929
		// (get) Token: 0x06026FBF RID: 159679 RVA: 0x009834A5 File Offset: 0x009816A5
		// (set) Token: 0x06026FC0 RID: 159680 RVA: 0x009834B9 File Offset: 0x009816B9
		[Nullable(2)]
		public unsafe AActor DefaultActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_7);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170055AA RID: 21930
		// (get) Token: 0x06026FC1 RID: 159681 RVA: 0x009834CE File Offset: 0x009816CE
		// (set) Token: 0x06026FC2 RID: 159682 RVA: 0x009834DE File Offset: 0x009816DE
		public unsafe int DefaultLiveActorIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170055AB RID: 21931
		// (get) Token: 0x06026FC3 RID: 159683 RVA: 0x009834F0 File Offset: 0x009816F0
		// (set) Token: 0x06026FC4 RID: 159684 RVA: 0x00983529 File Offset: 0x00981729
		public TArray<AActor> ArrayOfLevelActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ArrayOfLevelActors) == null)
				{
					result = (this._ArrayOfLevelActors = new TArray<AActor>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.ArrayOfLevelActors.CopyAssign(value);
			}
		}

		// Token: 0x170055AC RID: 21932
		// (get) Token: 0x06026FC5 RID: 159685 RVA: 0x00983537 File Offset: 0x00981737
		// (set) Token: 0x06026FC6 RID: 159686 RVA: 0x0098354B File Offset: 0x0098174B
		public unsafe string NinjaLiveAssetTrimmedName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_10)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x170055AD RID: 21933
		// (get) Token: 0x06026FC7 RID: 159687 RVA: 0x00983560 File Offset: 0x00981760
		// (set) Token: 0x06026FC8 RID: 159688 RVA: 0x00983574 File Offset: 0x00981774
		public unsafe FName NinjaLivePath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170055AE RID: 21934
		// (get) Token: 0x06026FC9 RID: 159689 RVA: 0x0098358C File Offset: 0x0098178C
		// (set) Token: 0x06026FCA RID: 159690 RVA: 0x009835C5 File Offset: 0x009817C5
		public TArray<UNamedSlot> ArrayOfLevelActorNamedSlots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNamedSlot> result;
				if ((result = this._ArrayOfLevelActorNamedSlots) == null)
				{
					result = (this._ArrayOfLevelActorNamedSlots = new TArray<UNamedSlot>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.ArrayOfLevelActorNamedSlots.CopyAssign(value);
			}
		}

		// Token: 0x170055AF RID: 21935
		// (get) Token: 0x06026FCB RID: 159691 RVA: 0x009835D3 File Offset: 0x009817D3
		// (set) Token: 0x06026FCC RID: 159692 RVA: 0x009835E3 File Offset: 0x009817E3
		public unsafe int RT_counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170055B0 RID: 21936
		// (get) Token: 0x06026FCD RID: 159693 RVA: 0x009835F4 File Offset: 0x009817F4
		// (set) Token: 0x06026FCE RID: 159694 RVA: 0x00983608 File Offset: 0x00981808
		public unsafe string RT_RenderPathDynamic
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_14)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_14)), value);
			}
		}

		// Token: 0x170055B1 RID: 21937
		// (get) Token: 0x06026FCF RID: 159695 RVA: 0x0098361D File Offset: 0x0098181D
		// (set) Token: 0x06026FD0 RID: 159696 RVA: 0x00983631 File Offset: 0x00981831
		public unsafe string RT_RenderPathStatic
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_15)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_15)), value);
			}
		}

		// Token: 0x170055B2 RID: 21938
		// (get) Token: 0x06026FD1 RID: 159697 RVA: 0x00983646 File Offset: 0x00981846
		// (set) Token: 0x06026FD2 RID: 159698 RVA: 0x00983656 File Offset: 0x00981856
		public unsafe bool GUIWidgetInitDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055B3 RID: 21939
		// (get) Token: 0x06026FD3 RID: 159699 RVA: 0x00983668 File Offset: 0x00981868
		// (set) Token: 0x06026FD4 RID: 159700 RVA: 0x009836A1 File Offset: 0x009818A1
		public TArray<UNamedSlot> NamedSlots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNamedSlot> result;
				if ((result = this._NamedSlots) == null)
				{
					result = (this._NamedSlots = new TArray<UNamedSlot>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.NamedSlots.CopyAssign(value);
			}
		}

		// Token: 0x170055B4 RID: 21940
		// (get) Token: 0x06026FD5 RID: 159701 RVA: 0x009836AF File Offset: 0x009818AF
		// (set) Token: 0x06026FD6 RID: 159702 RVA: 0x009836C3 File Offset: 0x009818C3
		[Nullable(2)]
		public unsafe UDataTable LoadedDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170055B5 RID: 21941
		// (get) Token: 0x06026FD7 RID: 159703 RVA: 0x009836D8 File Offset: 0x009818D8
		// (set) Token: 0x06026FD8 RID: 159704 RVA: 0x009836EC File Offset: 0x009818EC
		public unsafe string LoadedDataTablePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_19)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_19)), value);
			}
		}

		// Token: 0x170055B6 RID: 21942
		// (get) Token: 0x06026FD9 RID: 159705 RVA: 0x00983701 File Offset: 0x00981901
		// (set) Token: 0x06026FDA RID: 159706 RVA: 0x00983711 File Offset: 0x00981911
		public unsafe byte TextureCompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170055B7 RID: 21943
		// (get) Token: 0x06026FDB RID: 159707 RVA: 0x00983722 File Offset: 0x00981922
		// (set) Token: 0x06026FDC RID: 159708 RVA: 0x00983732 File Offset: 0x00981932
		public unsafe float PNGExportGamma
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170055B8 RID: 21944
		// (get) Token: 0x06026FDD RID: 159709 RVA: 0x00983743 File Offset: 0x00981943
		// (set) Token: 0x06026FDE RID: 159710 RVA: 0x00983753 File Offset: 0x00981953
		public unsafe bool SaveTexturesWithsRGB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055B9 RID: 21945
		// (get) Token: 0x06026FDF RID: 159711 RVA: 0x00983764 File Offset: 0x00981964
		// (set) Token: 0x06026FE0 RID: 159712 RVA: 0x00983774 File Offset: 0x00981974
		public unsafe float VelocityMapDownscaleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170055BA RID: 21946
		// (get) Token: 0x06026FE1 RID: 159713 RVA: 0x00983785 File Offset: 0x00981985
		// (set) Token: 0x06026FE2 RID: 159714 RVA: 0x00983795 File Offset: 0x00981995
		public unsafe bool CompensateUEGammaCorrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055BB RID: 21947
		// (get) Token: 0x06026FE3 RID: 159715 RVA: 0x009837A6 File Offset: 0x009819A6
		// (set) Token: 0x06026FE4 RID: 159716 RVA: 0x009837B6 File Offset: 0x009819B6
		public unsafe int DensityMapTextureCompressionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170055BC RID: 21948
		// (get) Token: 0x06026FE5 RID: 159717 RVA: 0x009837C7 File Offset: 0x009819C7
		// (set) Token: 0x06026FE6 RID: 159718 RVA: 0x009837D7 File Offset: 0x009819D7
		public unsafe int VelocityMapTextureCompressionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170055BD RID: 21949
		// (get) Token: 0x06026FE7 RID: 159719 RVA: 0x009837E8 File Offset: 0x009819E8
		// (set) Token: 0x06026FE8 RID: 159720 RVA: 0x009837F8 File Offset: 0x009819F8
		public unsafe bool CustomTickRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055BE RID: 21950
		// (get) Token: 0x06026FE9 RID: 159721 RVA: 0x00983809 File Offset: 0x00981A09
		// (set) Token: 0x06026FEA RID: 159722 RVA: 0x00983819 File Offset: 0x00981A19
		public unsafe bool UsePluginForFGAExport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055BF RID: 21951
		// (get) Token: 0x06026FEB RID: 159723 RVA: 0x0098382A File Offset: 0x00981A2A
		// (set) Token: 0x06026FEC RID: 159724 RVA: 0x0098383A File Offset: 0x00981A3A
		public unsafe bool DisablePresetManager
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055C0 RID: 21952
		// (get) Token: 0x06026FED RID: 159725 RVA: 0x0098384B File Offset: 0x00981A4B
		// (set) Token: 0x06026FEE RID: 159726 RVA: 0x0098385F File Offset: 0x00981A5F
		[Nullable(2)]
		public unsafe AActor DefaultLiveStageActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_30);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170055C1 RID: 21953
		// (get) Token: 0x06026FEF RID: 159727 RVA: 0x00983874 File Offset: 0x00981A74
		// (set) Token: 0x06026FF0 RID: 159728 RVA: 0x00983884 File Offset: 0x00981A84
		public unsafe bool HighlightSelectedActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055C2 RID: 21954
		// (get) Token: 0x06026FF1 RID: 159729 RVA: 0x00983895 File Offset: 0x00981A95
		// (set) Token: 0x06026FF2 RID: 159730 RVA: 0x009838A9 File Offset: 0x00981AA9
		public unsafe string InternalSavePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_32)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_32)), value);
			}
		}

		// Token: 0x170055C3 RID: 21955
		// (get) Token: 0x06026FF3 RID: 159731 RVA: 0x009838BE File Offset: 0x00981ABE
		// (set) Token: 0x06026FF4 RID: 159732 RVA: 0x009838D2 File Offset: 0x00981AD2
		public unsafe string ExternalSavePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_33)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_33)), value);
			}
		}

		// Token: 0x170055C4 RID: 21956
		// (get) Token: 0x06026FF5 RID: 159733 RVA: 0x009838E7 File Offset: 0x00981AE7
		// (set) Token: 0x06026FF6 RID: 159734 RVA: 0x009838FB File Offset: 0x00981AFB
		public unsafe string DefaultPreset
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_34)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_34)), value);
			}
		}

		// Token: 0x170055C5 RID: 21957
		// (get) Token: 0x06026FF7 RID: 159735 RVA: 0x00983910 File Offset: 0x00981B10
		// (set) Token: 0x06026FF8 RID: 159736 RVA: 0x00983924 File Offset: 0x00981B24
		public unsafe string NinjaRootFolder
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_35)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_35)), value);
			}
		}

		// Token: 0x170055C6 RID: 21958
		// (get) Token: 0x06026FF9 RID: 159737 RVA: 0x00983939 File Offset: 0x00981B39
		// (set) Token: 0x06026FFA RID: 159738 RVA: 0x0098394D File Offset: 0x00981B4D
		public unsafe string DefaultLiveActor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_36)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_36)), value);
			}
		}

		// Token: 0x170055C7 RID: 21959
		// (get) Token: 0x06026FFB RID: 159739 RVA: 0x00983962 File Offset: 0x00981B62
		// (set) Token: 0x06026FFC RID: 159740 RVA: 0x00983972 File Offset: 0x00981B72
		public unsafe bool FirstStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055C8 RID: 21960
		// (get) Token: 0x06026FFD RID: 159741 RVA: 0x00983984 File Offset: 0x00981B84
		// (set) Token: 0x06026FFE RID: 159742 RVA: 0x009839BD File Offset: 0x00981BBD
		public TArray<FAssetData> AvailableImagesData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAssetData> result;
				if ((result = this._AvailableImagesData) == null)
				{
					result = (this._AvailableImagesData = new TArray<FAssetData>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_38, this));
				}
				return result;
			}
			set
			{
				this.AvailableImagesData.CopyAssign(value);
			}
		}

		// Token: 0x170055C9 RID: 21961
		// (get) Token: 0x06026FFF RID: 159743 RVA: 0x009839CC File Offset: 0x00981BCC
		// (set) Token: 0x06027000 RID: 159744 RVA: 0x00983A05 File Offset: 0x00981C05
		public TArray<FName> AvailableImagesNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AvailableImagesNames) == null)
				{
					result = (this._AvailableImagesNames = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_39, this));
				}
				return result;
			}
			set
			{
				this.AvailableImagesNames.CopyAssign(value);
			}
		}

		// Token: 0x170055CA RID: 21962
		// (get) Token: 0x06027001 RID: 159745 RVA: 0x00983A14 File Offset: 0x00981C14
		// (set) Token: 0x06027002 RID: 159746 RVA: 0x00983A4D File Offset: 0x00981C4D
		public TArray<FAssetData> AvailableParticlesData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAssetData> result;
				if ((result = this._AvailableParticlesData) == null)
				{
					result = (this._AvailableParticlesData = new TArray<FAssetData>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_40, this));
				}
				return result;
			}
			set
			{
				this.AvailableParticlesData.CopyAssign(value);
			}
		}

		// Token: 0x170055CB RID: 21963
		// (get) Token: 0x06027003 RID: 159747 RVA: 0x00983A5C File Offset: 0x00981C5C
		// (set) Token: 0x06027004 RID: 159748 RVA: 0x00983A95 File Offset: 0x00981C95
		public TArray<FName> AvailableParticleNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AvailableParticleNames) == null)
				{
					result = (this._AvailableParticleNames = new TArray<FName>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_41, this));
				}
				return result;
			}
			set
			{
				this.AvailableParticleNames.CopyAssign(value);
			}
		}

		// Token: 0x170055CC RID: 21964
		// (get) Token: 0x06027005 RID: 159749 RVA: 0x00983AA3 File Offset: 0x00981CA3
		// (set) Token: 0x06027006 RID: 159750 RVA: 0x00983AB3 File Offset: 0x00981CB3
		public unsafe bool ArraysConstructed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055CD RID: 21965
		// (get) Token: 0x06027007 RID: 159751 RVA: 0x00983AC4 File Offset: 0x00981CC4
		// (set) Token: 0x06027008 RID: 159752 RVA: 0x00983AD4 File Offset: 0x00981CD4
		public unsafe bool PMInitFinished
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055CE RID: 21966
		// (get) Token: 0x06027009 RID: 159753 RVA: 0x00983AE5 File Offset: 0x00981CE5
		// (set) Token: 0x0602700A RID: 159754 RVA: 0x00983AF5 File Offset: 0x00981CF5
		public unsafe bool DebugPerformance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055CF RID: 21967
		// (get) Token: 0x0602700B RID: 159755 RVA: 0x00983B06 File Offset: 0x00981D06
		// (set) Token: 0x0602700C RID: 159756 RVA: 0x00983B16 File Offset: 0x00981D16
		public unsafe bool PoolManagerDetected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055D0 RID: 21968
		// (get) Token: 0x0602700D RID: 159757 RVA: 0x00983B27 File Offset: 0x00981D27
		// (set) Token: 0x0602700E RID: 159758 RVA: 0x00983B37 File Offset: 0x00981D37
		public unsafe bool AutoConnectToMemoryPool_IF_Found
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055D1 RID: 21969
		// (get) Token: 0x0602700F RID: 159759 RVA: 0x00983B48 File Offset: 0x00981D48
		// (set) Token: 0x06027010 RID: 159760 RVA: 0x00983B58 File Offset: 0x00981D58
		public unsafe bool PresetManagerDebugPrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055D2 RID: 21970
		// (get) Token: 0x06027011 RID: 159761 RVA: 0x00983B69 File Offset: 0x00981D69
		// (set) Token: 0x06027012 RID: 159762 RVA: 0x00983B79 File Offset: 0x00981D79
		public unsafe bool SaveDebugTextToDefaultLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055D3 RID: 21971
		// (get) Token: 0x06027013 RID: 159763 RVA: 0x00983B8A File Offset: 0x00981D8A
		// (set) Token: 0x06027014 RID: 159764 RVA: 0x00983B9A File Offset: 0x00981D9A
		public unsafe float DebugTextLifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x170055D4 RID: 21972
		// (get) Token: 0x06027015 RID: 159765 RVA: 0x00983BAB File Offset: 0x00981DAB
		// (set) Token: 0x06027016 RID: 159766 RVA: 0x00983BBF File Offset: 0x00981DBF
		public unsafe FColor HighlightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x170055D5 RID: 21973
		// (get) Token: 0x06027017 RID: 159767 RVA: 0x00983BD4 File Offset: 0x00981DD4
		// (set) Token: 0x06027018 RID: 159768 RVA: 0x00983BE4 File Offset: 0x00981DE4
		public unsafe float HighlightThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x170055D6 RID: 21974
		// (get) Token: 0x06027019 RID: 159769 RVA: 0x00983BF5 File Offset: 0x00981DF5
		// (set) Token: 0x0602701A RID: 159770 RVA: 0x00983C05 File Offset: 0x00981E05
		public unsafe float HighlightDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x170055D7 RID: 21975
		// (get) Token: 0x0602701B RID: 159771 RVA: 0x00983C16 File Offset: 0x00981E16
		// (set) Token: 0x0602701C RID: 159772 RVA: 0x00983C26 File Offset: 0x00981E26
		public unsafe float HighlightRefreshRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x170055D8 RID: 21976
		// (get) Token: 0x0602701D RID: 159773 RVA: 0x00983C37 File Offset: 0x00981E37
		// (set) Token: 0x0602701E RID: 159774 RVA: 0x00983C47 File Offset: 0x00981E47
		public unsafe bool ShowMouseCursor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055D9 RID: 21977
		// (get) Token: 0x0602701F RID: 159775 RVA: 0x00983C58 File Offset: 0x00981E58
		// (set) Token: 0x06027020 RID: 159776 RVA: 0x00983C6C File Offset: 0x00981E6C
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic RenderBufferSaver
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_55);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_PresetManager_C.__PropertyOffset_55, value);
			}
		}

		// Token: 0x170055DA RID: 21978
		// (get) Token: 0x06027021 RID: 159777 RVA: 0x00983C84 File Offset: 0x00981E84
		// (set) Token: 0x06027022 RID: 159778 RVA: 0x00983CBD File Offset: 0x00981EBD
		public TArray<string> PresetSavingBugWorkaroundUEversions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PresetSavingBugWorkaroundUEversions) == null)
				{
					result = (this._PresetSavingBugWorkaroundUEversions = new TArray<string>(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_56, this));
				}
				return result;
			}
			set
			{
				this.PresetSavingBugWorkaroundUEversions.CopyAssign(value);
			}
		}

		// Token: 0x170055DB RID: 21979
		// (get) Token: 0x06027023 RID: 159779 RVA: 0x00983CCB File Offset: 0x00981ECB
		// (set) Token: 0x06027024 RID: 159780 RVA: 0x00983CDB File Offset: 0x00981EDB
		public unsafe bool DisableGUIWarningOnPresetSaving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_57) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_PresetManager_C.__PropertyOffset_57) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027025 RID: 159781 RVA: 0x00983CEC File Offset: 0x00981EEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MarkForSave_UE426_BugWorkaround(UObject CurrentAsset)
		{
			NinjaLive_PresetManager_C.__MarkForSave_UE426_BugWorkaround_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__MarkForSave_UE426_BugWorkaround_FunctionParams[(UIntPtr)335] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__MarkForSave_UE426_BugWorkaround_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__MarkForSave_UE426_BugWorkaround_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CurrentAsset = ((CurrentAsset != null) ? CurrentAsset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__MarkForSave_UE426_BugWorkaround_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027026 RID: 159782 RVA: 0x00983D44 File Offset: 0x00981F44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ConvertToPowerOfTwo(int In, ref int Out)
		{
			NinjaLive_PresetManager_C.__ConvertToPowerOfTwo_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__ConvertToPowerOfTwo_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__ConvertToPowerOfTwo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__ConvertToPowerOfTwo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->In = In;
			ptr->Out = Out;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__ConvertToPowerOfTwo_NativeFunctionPtr, (void*)ptr);
			Out = ptr->Out;
		}

		// Token: 0x06027027 RID: 159783 RVA: 0x00983D9C File Offset: 0x00981F9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetCurrentLevelInfo(ref FName LevelName, ref FName LevelPath)
		{
			NinjaLive_PresetManager_C.__GetCurrentLevelInfo_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__GetCurrentLevelInfo_FunctionParams[(UIntPtr)255] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__GetCurrentLevelInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__GetCurrentLevelInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LevelName = LevelName;
			ptr->LevelPath = LevelPath;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__GetCurrentLevelInfo_NativeFunctionPtr, (void*)ptr);
			LevelName = ptr->LevelName;
			LevelPath = ptr->LevelPath;
		}

		// Token: 0x06027028 RID: 159784 RVA: 0x00983E10 File Offset: 0x00982010
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MarkNewFilesAsUnsaved([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FAssetData> ArrayOfUnsaveAssetData)
		{
			NinjaLive_PresetManager_C.__MarkNewFilesAsUnsaved_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__MarkNewFilesAsUnsaved_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__MarkNewFilesAsUnsaved_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__MarkNewFilesAsUnsaved_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FAssetData> tarray = ArrayOfUnsaveAssetData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ArrayOfUnsaveAssetData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__MarkNewFilesAsUnsaved_NativeFunctionPtr, (void*)ptr);
			TArray<FAssetData> tarray2 = ArrayOfUnsaveAssetData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ArrayOfUnsaveAssetData);
			}
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__MarkNewFilesAsUnsaved_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027029 RID: 159785 RVA: 0x00983E8C File Offset: 0x0098208C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DataTable_SingleKeyPicker_DT([Nullable(2)] UDataTable DataTableIn, string KeyToPick, ref string PickedKeyValue, ref bool NotFound)
		{
			NinjaLive_PresetManager_C.__DataTable_SingleKeyPicker_DT_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__DataTable_SingleKeyPicker_DT_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__DataTable_SingleKeyPicker_DT_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__DataTable_SingleKeyPicker_DT_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DataTableIn = ((DataTableIn != null) ? DataTableIn.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->KeyToPick), KeyToPick);
			FString.CopyFrom((void*)(&ptr->PickedKeyValue), PickedKeyValue);
			ptr->NotFound = NotFound;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__DataTable_SingleKeyPicker_DT_NativeFunctionPtr, (void*)ptr);
			PickedKeyValue = FString.ToString((void*)(&ptr->PickedKeyValue));
			NotFound = ptr->NotFound;
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__DataTable_SingleKeyPicker_DT_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602702A RID: 159786 RVA: 0x00983F30 File Offset: 0x00982130
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Preset_SingleKeyPicker_DT(string PresetName, string KeyToPick, [Nullable(2)] ref UDataTable DataTable, ref string PickedKeyValue)
		{
			NinjaLive_PresetManager_C.__Preset_SingleKeyPicker_DT_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__Preset_SingleKeyPicker_DT_FunctionParams[(UIntPtr)567] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__Preset_SingleKeyPicker_DT_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__Preset_SingleKeyPicker_DT_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PresetName), PresetName);
			FString.CopyFrom((void*)(&ptr->KeyToPick), KeyToPick);
			ref NinjaLive_PresetManager_C.__Preset_SingleKeyPicker_DT_FunctionParams ptr2 = ref *ptr;
			UDataTable udataTable = DataTable;
			ptr2.DataTable = ((udataTable != null) ? udataTable.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->PickedKeyValue), PickedKeyValue);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__Preset_SingleKeyPicker_DT_NativeFunctionPtr, (void*)ptr);
			DataTable = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDataTable>(ptr->DataTable);
			PickedKeyValue = FString.ToString((void*)(&ptr->PickedKeyValue));
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__Preset_SingleKeyPicker_DT_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602702B RID: 159787 RVA: 0x00983FE0 File Offset: 0x009821E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AssetDataFromObject(UObject InputObject, ref FAssetData ComboAssetData, ref FName Object_Path, ref FName Package_Name, ref FName Package_Path, ref FName Asset_Name, ref FName Asset_Class)
		{
			NinjaLive_PresetManager_C.__AssetDataFromObject_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__AssetDataFromObject_FunctionParams[(UIntPtr)559] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__AssetDataFromObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__AssetDataFromObject_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputObject = ((InputObject != null) ? InputObject.NativePtr : IntPtr.Zero);
			if (ComboAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->ComboAssetData, ComboAssetData.NativePtr, 1, false);
			}
			ptr->Object_Path = Object_Path;
			ptr->Package_Name = Package_Name;
			ptr->Package_Path = Package_Path;
			ptr->Asset_Name = Asset_Name;
			ptr->Asset_Class = Asset_Class;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__AssetDataFromObject_NativeFunctionPtr, (void*)ptr);
			if (ComboAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), ComboAssetData.NativePtr, &ptr->ComboAssetData, 1, false);
			}
			Object_Path = ptr->Object_Path;
			Package_Name = ptr->Package_Name;
			Package_Path = ptr->Package_Path;
			Asset_Name = ptr->Asset_Name;
			Asset_Class = ptr->Asset_Class;
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__AssetDataFromObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602702C RID: 159788 RVA: 0x00984114 File Offset: 0x00982314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Preset_to_InternalCSV_to_DT_Saver(bool OverWriteFlag, string VarAsString, string SelectedItem, [Nullable(2)] ref TArray<FName> AssetPaths, FName AssetName)
		{
			NinjaLive_PresetManager_C.__Preset_to_InternalCSV_to_DT_Saver_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__Preset_to_InternalCSV_to_DT_Saver_FunctionParams[(UIntPtr)1271] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__Preset_to_InternalCSV_to_DT_Saver_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__Preset_to_InternalCSV_to_DT_Saver_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverWriteFlag = OverWriteFlag;
			FString.CopyFrom((void*)(&ptr->VarAsString), VarAsString);
			FString.CopyFrom((void*)(&ptr->SelectedItem), SelectedItem);
			TArray<FName> tarray = AssetPaths;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->AssetPaths);
			}
			ptr->AssetName = AssetName;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__Preset_to_InternalCSV_to_DT_Saver_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = AssetPaths;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->AssetPaths);
			}
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__Preset_to_InternalCSV_to_DT_Saver_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602702D RID: 159789 RVA: 0x009841BC File Offset: 0x009823BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RenderTargetExportSingle([Nullable(2)] UTextureRenderTarget2D TextureRenderTarget, bool InternalSave, bool sRGB, bool NoAlpha, bool SaveWithDialog, FName InternalFilePath, FName ExternalFilePath, string FileName, string Extension, ref FName SavedAssetPath, [Nullable(2)] ref FAssetData SavedAssetData)
		{
			NinjaLive_PresetManager_C.__RenderTargetExportSingle_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__RenderTargetExportSingle_FunctionParams[(UIntPtr)895] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__RenderTargetExportSingle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__RenderTargetExportSingle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TextureRenderTarget = ((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero);
			ptr->InternalSave = InternalSave;
			ptr->sRGB = sRGB;
			ptr->NoAlpha = NoAlpha;
			ptr->SaveWithDialog = SaveWithDialog;
			ptr->InternalFilePath = InternalFilePath;
			ptr->ExternalFilePath = ExternalFilePath;
			FString.CopyFrom((void*)(&ptr->FileName), FileName);
			FString.CopyFrom((void*)(&ptr->Extension), Extension);
			ptr->SavedAssetPath = SavedAssetPath;
			if (SavedAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->SavedAssetData, SavedAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__RenderTargetExportSingle_NativeFunctionPtr, (void*)ptr);
			SavedAssetPath = ptr->SavedAssetPath;
			if (SavedAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), SavedAssetData.NativePtr, &ptr->SavedAssetData, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__RenderTargetExportSingle_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602702E RID: 159790 RVA: 0x009842D8 File Offset: 0x009824D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetAssetNameAndPath(UObject Object, ref FName AssetTrimmedName, ref FName AssetPath)
		{
			NinjaLive_PresetManager_C.__SetAssetNameAndPath_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__SetAssetNameAndPath_FunctionParams[(UIntPtr)367] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__SetAssetNameAndPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__SetAssetNameAndPath_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->AssetTrimmedName = AssetTrimmedName;
			ptr->AssetPath = AssetPath;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__SetAssetNameAndPath_NativeFunctionPtr, (void*)ptr);
			AssetTrimmedName = ptr->AssetTrimmedName;
			AssetPath = ptr->AssetPath;
		}

		// Token: 0x0602702F RID: 159791 RVA: 0x00984360 File Offset: 0x00982560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027030 RID: 159792 RVA: 0x00984374 File Offset: 0x00982574
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_PresetManager_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027031 RID: 159793 RVA: 0x0098438C File Offset: 0x0098258C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5(FKey Key)
		{
			NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027032 RID: 159794 RVA: 0x00984400 File Offset: 0x00982600
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4(FKey Key)
		{
			NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027033 RID: 159795 RVA: 0x00984474 File Offset: 0x00982674
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3(FKey Key)
		{
			NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027034 RID: 159796 RVA: 0x009844E8 File Offset: 0x009826E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2(FKey Key)
		{
			NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027035 RID: 159797 RVA: 0x0098455C File Offset: 0x0098275C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1(FKey Key)
		{
			NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027036 RID: 159798 RVA: 0x009845D0 File Offset: 0x009827D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0(FKey Key)
		{
			NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027037 RID: 159799 RVA: 0x00984644 File Offset: 0x00982844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void WriteDataTableFunction([Nullable(2)] UDataTable InputTable, string InputData)
		{
			NinjaLive_PresetManager_C.__WriteDataTableFunction_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__WriteDataTableFunction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__WriteDataTableFunction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__WriteDataTableFunction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputTable = ((InputTable != null) ? InputTable.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->InputData), InputData);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__WriteDataTableFunction_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_PresetManager_C.__WriteDataTableFunction_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027038 RID: 159800 RVA: 0x009846B7 File Offset: 0x009828B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027039 RID: 159801 RVA: 0x009846CB File Offset: 0x009828CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_PresetManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602703A RID: 159802 RVA: 0x009846E0 File Offset: 0x009828E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			NinjaLive_PresetManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602703B RID: 159803 RVA: 0x00984728 File Offset: 0x00982928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			NinjaLive_PresetManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_PresetManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602703C RID: 159804 RVA: 0x00984770 File Offset: 0x00982970
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnDensityMapSave(bool SavePaintBuffer)
		{
			NinjaLive_PresetManager_C.__OnDensityMapSave_FunctionParams* ptr = stackalloc NinjaLive_PresetManager_C.__OnDensityMapSave_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(NinjaLive_PresetManager_C.__OnDensityMapSave_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_PresetManager_C.__OnDensityMapSave_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SavePaintBuffer = SavePaintBuffer;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_PresetManager_C.__OnDensityMapSave_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602703D RID: 159805 RVA: 0x009847B6 File Offset: 0x009829B6
		protected NinjaLive_PresetManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A0E RID: 80398
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_PresetManager.NinjaLive_PresetManager_C";

		// Token: 0x04013A0F RID: 80399
		private static IntPtr _ClassPtr;

		// Token: 0x04013A10 RID: 80400
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A11 RID: 80401
		internal static int __PropertyOffset_1;

		// Token: 0x04013A12 RID: 80402
		internal static int __PropertyOffset_2;

		// Token: 0x04013A13 RID: 80403
		internal static int __PropertyOffset_3;

		// Token: 0x04013A14 RID: 80404
		internal static int __PropertyOffset_4;

		// Token: 0x04013A15 RID: 80405
		internal static int __PropertyOffset_5;

		// Token: 0x04013A16 RID: 80406
		internal static int __PropertyOffset_6;

		// Token: 0x04013A17 RID: 80407
		internal static int __PropertyOffset_7;

		// Token: 0x04013A18 RID: 80408
		internal static int __PropertyOffset_8;

		// Token: 0x04013A19 RID: 80409
		internal static int __PropertyOffset_9;

		// Token: 0x04013A1A RID: 80410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ArrayOfLevelActors;

		// Token: 0x04013A1B RID: 80411
		internal static int __PropertyOffset_10;

		// Token: 0x04013A1C RID: 80412
		internal static int __PropertyOffset_11;

		// Token: 0x04013A1D RID: 80413
		internal static int __PropertyOffset_12;

		// Token: 0x04013A1E RID: 80414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNamedSlot> _ArrayOfLevelActorNamedSlots;

		// Token: 0x04013A1F RID: 80415
		internal static int __PropertyOffset_13;

		// Token: 0x04013A20 RID: 80416
		internal static int __PropertyOffset_14;

		// Token: 0x04013A21 RID: 80417
		internal static int __PropertyOffset_15;

		// Token: 0x04013A22 RID: 80418
		internal static int __PropertyOffset_16;

		// Token: 0x04013A23 RID: 80419
		internal static int __PropertyOffset_17;

		// Token: 0x04013A24 RID: 80420
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNamedSlot> _NamedSlots;

		// Token: 0x04013A25 RID: 80421
		internal static int __PropertyOffset_18;

		// Token: 0x04013A26 RID: 80422
		internal static int __PropertyOffset_19;

		// Token: 0x04013A27 RID: 80423
		internal static int __PropertyOffset_20;

		// Token: 0x04013A28 RID: 80424
		internal static int __PropertyOffset_21;

		// Token: 0x04013A29 RID: 80425
		internal static int __PropertyOffset_22;

		// Token: 0x04013A2A RID: 80426
		internal static int __PropertyOffset_23;

		// Token: 0x04013A2B RID: 80427
		internal static int __PropertyOffset_24;

		// Token: 0x04013A2C RID: 80428
		internal static int __PropertyOffset_25;

		// Token: 0x04013A2D RID: 80429
		internal static int __PropertyOffset_26;

		// Token: 0x04013A2E RID: 80430
		internal static int __PropertyOffset_27;

		// Token: 0x04013A2F RID: 80431
		internal static int __PropertyOffset_28;

		// Token: 0x04013A30 RID: 80432
		internal static int __PropertyOffset_29;

		// Token: 0x04013A31 RID: 80433
		internal static int __PropertyOffset_30;

		// Token: 0x04013A32 RID: 80434
		internal static int __PropertyOffset_31;

		// Token: 0x04013A33 RID: 80435
		internal static int __PropertyOffset_32;

		// Token: 0x04013A34 RID: 80436
		internal static int __PropertyOffset_33;

		// Token: 0x04013A35 RID: 80437
		internal static int __PropertyOffset_34;

		// Token: 0x04013A36 RID: 80438
		internal static int __PropertyOffset_35;

		// Token: 0x04013A37 RID: 80439
		internal static int __PropertyOffset_36;

		// Token: 0x04013A38 RID: 80440
		internal static int __PropertyOffset_37;

		// Token: 0x04013A39 RID: 80441
		internal static int __PropertyOffset_38;

		// Token: 0x04013A3A RID: 80442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetData> _AvailableImagesData;

		// Token: 0x04013A3B RID: 80443
		internal static int __PropertyOffset_39;

		// Token: 0x04013A3C RID: 80444
		[Nullable(2)]
		private TArray<FName> _AvailableImagesNames;

		// Token: 0x04013A3D RID: 80445
		internal static int __PropertyOffset_40;

		// Token: 0x04013A3E RID: 80446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetData> _AvailableParticlesData;

		// Token: 0x04013A3F RID: 80447
		internal static int __PropertyOffset_41;

		// Token: 0x04013A40 RID: 80448
		[Nullable(2)]
		private TArray<FName> _AvailableParticleNames;

		// Token: 0x04013A41 RID: 80449
		internal static int __PropertyOffset_42;

		// Token: 0x04013A42 RID: 80450
		internal static int __PropertyOffset_43;

		// Token: 0x04013A43 RID: 80451
		internal static int __PropertyOffset_44;

		// Token: 0x04013A44 RID: 80452
		internal static int __PropertyOffset_45;

		// Token: 0x04013A45 RID: 80453
		internal static int __PropertyOffset_46;

		// Token: 0x04013A46 RID: 80454
		internal static int __PropertyOffset_47;

		// Token: 0x04013A47 RID: 80455
		internal static int __PropertyOffset_48;

		// Token: 0x04013A48 RID: 80456
		internal static int __PropertyOffset_49;

		// Token: 0x04013A49 RID: 80457
		internal static int __PropertyOffset_50;

		// Token: 0x04013A4A RID: 80458
		internal static int __PropertyOffset_51;

		// Token: 0x04013A4B RID: 80459
		internal static int __PropertyOffset_52;

		// Token: 0x04013A4C RID: 80460
		internal static int __PropertyOffset_53;

		// Token: 0x04013A4D RID: 80461
		internal static int __PropertyOffset_54;

		// Token: 0x04013A4E RID: 80462
		internal static int __PropertyOffset_55;

		// Token: 0x04013A4F RID: 80463
		internal static int __PropertyOffset_56;

		// Token: 0x04013A50 RID: 80464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PresetSavingBugWorkaroundUEversions;

		// Token: 0x04013A51 RID: 80465
		internal static int __PropertyOffset_57;

		// Token: 0x04013A52 RID: 80466
		private static IntPtr __MarkForSave_UE426_BugWorkaround_NativeFunctionPtr;

		// Token: 0x04013A53 RID: 80467
		private static IntPtr __ConvertToPowerOfTwo_NativeFunctionPtr;

		// Token: 0x04013A54 RID: 80468
		private static IntPtr __GetCurrentLevelInfo_NativeFunctionPtr;

		// Token: 0x04013A55 RID: 80469
		private static IntPtr __MarkNewFilesAsUnsaved_NativeFunctionPtr;

		// Token: 0x04013A56 RID: 80470
		private static IntPtr __DataTable_SingleKeyPicker_DT_NativeFunctionPtr;

		// Token: 0x04013A57 RID: 80471
		private static IntPtr __Preset_SingleKeyPicker_DT_NativeFunctionPtr;

		// Token: 0x04013A58 RID: 80472
		private static IntPtr __AssetDataFromObject_NativeFunctionPtr;

		// Token: 0x04013A59 RID: 80473
		private static IntPtr __Preset_to_InternalCSV_to_DT_Saver_NativeFunctionPtr;

		// Token: 0x04013A5A RID: 80474
		private static IntPtr __RenderTargetExportSingle_NativeFunctionPtr;

		// Token: 0x04013A5B RID: 80475
		private static IntPtr __SetAssetNameAndPath_NativeFunctionPtr;

		// Token: 0x04013A5C RID: 80476
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013A5D RID: 80477
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr;

		// Token: 0x04013A5E RID: 80478
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr;

		// Token: 0x04013A5F RID: 80479
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr;

		// Token: 0x04013A60 RID: 80480
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr;

		// Token: 0x04013A61 RID: 80481
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_NativeFunctionPtr;

		// Token: 0x04013A62 RID: 80482
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x04013A63 RID: 80483
		private static IntPtr __WriteDataTableFunction_NativeFunctionPtr;

		// Token: 0x04013A64 RID: 80484
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013A65 RID: 80485
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013A66 RID: 80486
		private static IntPtr __OnDensityMapSave_NativeFunctionPtr;

		// Token: 0x0200A16E RID: 41326
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __MarkForSave_UE426_BugWorkaround_FunctionParams
		{
			// Token: 0x04031D32 RID: 204082
			[FieldOffset(0)]
			public IntPtr CurrentAsset;
		}

		// Token: 0x0200A16F RID: 41327
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ConvertToPowerOfTwo_FunctionParams
		{
			// Token: 0x04031D33 RID: 204083
			[FieldOffset(0)]
			public int In;

			// Token: 0x04031D34 RID: 204084
			[FieldOffset(4)]
			public int Out;
		}

		// Token: 0x0200A170 RID: 41328
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 240)]
		protected ref struct __GetCurrentLevelInfo_FunctionParams
		{
			// Token: 0x04031D35 RID: 204085
			[FieldOffset(0)]
			public FName LevelName;

			// Token: 0x04031D36 RID: 204086
			[FieldOffset(12)]
			public FName LevelPath;
		}

		// Token: 0x0200A171 RID: 41329
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __MarkNewFilesAsUnsaved_FunctionParams
		{
			// Token: 0x04031D37 RID: 204087
			[FieldOffset(0)]
			public byte ArrayOfUnsaveAssetData;
		}

		// Token: 0x0200A172 RID: 41330
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __DataTable_SingleKeyPicker_DT_FunctionParams
		{
			// Token: 0x04031D38 RID: 204088
			[FieldOffset(0)]
			public IntPtr DataTableIn;

			// Token: 0x04031D39 RID: 204089
			[FieldOffset(8)]
			public FString KeyToPick;

			// Token: 0x04031D3A RID: 204090
			[FieldOffset(24)]
			public FString PickedKeyValue;

			// Token: 0x04031D3B RID: 204091
			[FieldOffset(40)]
			public bool NotFound;
		}

		// Token: 0x0200A173 RID: 41331
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 552)]
		protected ref struct __Preset_SingleKeyPicker_DT_FunctionParams
		{
			// Token: 0x04031D3C RID: 204092
			[FieldOffset(0)]
			public FString PresetName;

			// Token: 0x04031D3D RID: 204093
			[FieldOffset(16)]
			public FString KeyToPick;

			// Token: 0x04031D3E RID: 204094
			[FieldOffset(32)]
			public IntPtr DataTable;

			// Token: 0x04031D3F RID: 204095
			[FieldOffset(40)]
			public FString PickedKeyValue;
		}

		// Token: 0x0200A174 RID: 41332
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 544)]
		protected ref struct __AssetDataFromObject_FunctionParams
		{
			// Token: 0x04031D40 RID: 204096
			[FieldOffset(0)]
			public IntPtr InputObject;

			// Token: 0x04031D41 RID: 204097
			[FieldOffset(8)]
			public byte ComboAssetData;

			// Token: 0x04031D42 RID: 204098
			[FieldOffset(120)]
			public FName Object_Path;

			// Token: 0x04031D43 RID: 204099
			[FieldOffset(132)]
			public FName Package_Name;

			// Token: 0x04031D44 RID: 204100
			[FieldOffset(144)]
			public FName Package_Path;

			// Token: 0x04031D45 RID: 204101
			[FieldOffset(156)]
			public FName Asset_Name;

			// Token: 0x04031D46 RID: 204102
			[FieldOffset(168)]
			public FName Asset_Class;
		}

		// Token: 0x0200A175 RID: 41333
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1256)]
		protected ref struct __Preset_to_InternalCSV_to_DT_Saver_FunctionParams
		{
			// Token: 0x04031D47 RID: 204103
			[FieldOffset(0)]
			public bool OverWriteFlag;

			// Token: 0x04031D48 RID: 204104
			[FieldOffset(8)]
			public FString VarAsString;

			// Token: 0x04031D49 RID: 204105
			[FieldOffset(24)]
			public FString SelectedItem;

			// Token: 0x04031D4A RID: 204106
			[FieldOffset(40)]
			public byte AssetPaths;

			// Token: 0x04031D4B RID: 204107
			[FieldOffset(56)]
			public FName AssetName;
		}

		// Token: 0x0200A176 RID: 41334
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 880)]
		protected ref struct __RenderTargetExportSingle_FunctionParams
		{
			// Token: 0x04031D4C RID: 204108
			[FieldOffset(0)]
			public IntPtr TextureRenderTarget;

			// Token: 0x04031D4D RID: 204109
			[FieldOffset(8)]
			public bool InternalSave;

			// Token: 0x04031D4E RID: 204110
			[FieldOffset(9)]
			public bool sRGB;

			// Token: 0x04031D4F RID: 204111
			[FieldOffset(10)]
			public bool NoAlpha;

			// Token: 0x04031D50 RID: 204112
			[FieldOffset(11)]
			public bool SaveWithDialog;

			// Token: 0x04031D51 RID: 204113
			[FieldOffset(12)]
			public FName InternalFilePath;

			// Token: 0x04031D52 RID: 204114
			[FieldOffset(24)]
			public FName ExternalFilePath;

			// Token: 0x04031D53 RID: 204115
			[FieldOffset(40)]
			public FString FileName;

			// Token: 0x04031D54 RID: 204116
			[FieldOffset(56)]
			public FString Extension;

			// Token: 0x04031D55 RID: 204117
			[FieldOffset(72)]
			public FName SavedAssetPath;

			// Token: 0x04031D56 RID: 204118
			[FieldOffset(88)]
			public byte SavedAssetData;
		}

		// Token: 0x0200A177 RID: 41335
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __SetAssetNameAndPath_FunctionParams
		{
			// Token: 0x04031D57 RID: 204119
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04031D58 RID: 204120
			[FieldOffset(8)]
			public FName AssetTrimmedName;

			// Token: 0x04031D59 RID: 204121
			[FieldOffset(20)]
			public FName AssetPath;
		}

		// Token: 0x0200A178 RID: 41336
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_5_FunctionParams
		{
			// Token: 0x04031D5A RID: 204122
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A179 RID: 41337
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_4_FunctionParams
		{
			// Token: 0x04031D5B RID: 204123
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A17A RID: 41338
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_3_FunctionParams
		{
			// Token: 0x04031D5C RID: 204124
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A17B RID: 41339
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_2_FunctionParams
		{
			// Token: 0x04031D5D RID: 204125
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A17C RID: 41340
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_1_FunctionParams
		{
			// Token: 0x04031D5E RID: 204126
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A17D RID: 41341
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x04031D5F RID: 204127
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A17E RID: 41342
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __WriteDataTableFunction_FunctionParams
		{
			// Token: 0x04031D60 RID: 204128
			[FieldOffset(0)]
			public IntPtr InputTable;

			// Token: 0x04031D61 RID: 204129
			[FieldOffset(8)]
			public FString InputData;
		}

		// Token: 0x0200A17F RID: 41343
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D62 RID: 204130
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A180 RID: 41344
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnDensityMapSave_FunctionParams
		{
			// Token: 0x04031D63 RID: 204131
			[FieldOffset(0)]
			public bool SavePaintBuffer;
		}
	}
}
