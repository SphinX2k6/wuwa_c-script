using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.ClothDynamicPin
{
	// Token: 0x02003C96 RID: 15510
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin_Broken.BP_KuroCSCloth_DynamicPin_Broken_C")]
	[UnrealStructLayout(2144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2132)]
	public class BP_KuroCSCloth_DynamicPin_Broken_C : AKuroCS_Cloth_DynamicPin, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060244BF RID: 148671 RVA: 0x0093A9E6 File Offset: 0x00938BE6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCSCloth_DynamicPin_Broken_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin_Broken.BP_KuroCSCloth_DynamicPin_Broken_C");
			}
			return BP_KuroCSCloth_DynamicPin_Broken_C._ClassPtr;
		}

		// Token: 0x060244C0 RID: 148672 RVA: 0x0093AA0C File Offset: 0x00938C0C
		public BP_KuroCSCloth_DynamicPin_Broken_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_DynamicPin_Broken_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060244C1 RID: 148673 RVA: 0x0093AA34 File Offset: 0x00938C34
		[NullableContext(1)]
		public BP_KuroCSCloth_DynamicPin_Broken_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSCloth_DynamicPin_Broken_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x060244C2 RID: 148674 RVA: 0x0093AA67 File Offset: 0x00938C67
		// (set) Token: 0x060244C3 RID: 148675 RVA: 0x0093AA7B File Offset: 0x00938C7B
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x060244C4 RID: 148676 RVA: 0x0093AA90 File Offset: 0x00938C90
		// (set) Token: 0x060244C5 RID: 148677 RVA: 0x0093AAA4 File Offset: 0x00938CA4
		public unsafe UStaticMeshComponent MobileProxy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x060244C6 RID: 148678 RVA: 0x0093AAB9 File Offset: 0x00938CB9
		// (set) Token: 0x060244C7 RID: 148679 RVA: 0x0093AACD File Offset: 0x00938CCD
		public unsafe UStaticMeshComponent MeshXZ
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x060244C8 RID: 148680 RVA: 0x0093AAE2 File Offset: 0x00938CE2
		// (set) Token: 0x060244C9 RID: 148681 RVA: 0x0093AAF6 File Offset: 0x00938CF6
		public unsafe USceneComponent PinnedLB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x060244CA RID: 148682 RVA: 0x0093AB0B File Offset: 0x00938D0B
		// (set) Token: 0x060244CB RID: 148683 RVA: 0x0093AB1F File Offset: 0x00938D1F
		public unsafe USceneComponent PinnedLT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x060244CC RID: 148684 RVA: 0x0093AB34 File Offset: 0x00938D34
		// (set) Token: 0x060244CD RID: 148685 RVA: 0x0093AB48 File Offset: 0x00938D48
		public unsafe USceneComponent PinnedRB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x060244CE RID: 148686 RVA: 0x0093AB5D File Offset: 0x00938D5D
		// (set) Token: 0x060244CF RID: 148687 RVA: 0x0093AB71 File Offset: 0x00938D71
		public unsafe USceneComponent PinnedRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x060244D0 RID: 148688 RVA: 0x0093AB86 File Offset: 0x00938D86
		// (set) Token: 0x060244D1 RID: 148689 RVA: 0x0093AB9A File Offset: 0x00938D9A
		public unsafe UTextureRenderTarget2D RTPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x060244D2 RID: 148690 RVA: 0x0093ABAF File Offset: 0x00938DAF
		// (set) Token: 0x060244D3 RID: 148691 RVA: 0x0093ABBF File Offset: 0x00938DBF
		public unsafe bool bSyncToBindPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x060244D4 RID: 148692 RVA: 0x0093ABD0 File Offset: 0x00938DD0
		// (set) Token: 0x060244D5 RID: 148693 RVA: 0x0093ABE4 File Offset: 0x00938DE4
		public unsafe BP_BridgeModels_Broken_C bindBrige
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_BridgeModels_Broken_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x060244D6 RID: 148694 RVA: 0x0093ABF9 File Offset: 0x00938DF9
		// (set) Token: 0x060244D7 RID: 148695 RVA: 0x0093AC0D File Offset: 0x00938E0D
		public unsafe BP_CPP_bridge_doubleChain_realModel_Broken_C BindBridgeChain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_CPP_bridge_doubleChain_realModel_Broken_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x060244D8 RID: 148696 RVA: 0x0093AC22 File Offset: 0x00938E22
		// (set) Token: 0x060244D9 RID: 148697 RVA: 0x0093AC32 File Offset: 0x00938E32
		public unsafe int linkIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x060244DA RID: 148698 RVA: 0x0093AC43 File Offset: 0x00938E43
		// (set) Token: 0x060244DB RID: 148699 RVA: 0x0093AC53 File Offset: 0x00938E53
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x060244DC RID: 148700 RVA: 0x0093AC64 File Offset: 0x00938E64
		// (set) Token: 0x060244DD RID: 148701 RVA: 0x0093AC78 File Offset: 0x00938E78
		public unsafe FVector PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x060244DE RID: 148702 RVA: 0x0093AC90 File Offset: 0x00938E90
		// (set) Token: 0x060244DF RID: 148703 RVA: 0x0093ACC9 File Offset: 0x00938EC9
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x060244E0 RID: 148704 RVA: 0x0093ACD7 File Offset: 0x00938ED7
		// (set) Token: 0x060244E1 RID: 148705 RVA: 0x0093ACE7 File Offset: 0x00938EE7
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x060244E2 RID: 148706 RVA: 0x0093ACF8 File Offset: 0x00938EF8
		// (set) Token: 0x060244E3 RID: 148707 RVA: 0x0093AD0C File Offset: 0x00938F0C
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x060244E4 RID: 148708 RVA: 0x0093AD21 File Offset: 0x00938F21
		// (set) Token: 0x060244E5 RID: 148709 RVA: 0x0093AD31 File Offset: 0x00938F31
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x060244E6 RID: 148710 RVA: 0x0093AD42 File Offset: 0x00938F42
		// (set) Token: 0x060244E7 RID: 148711 RVA: 0x0093AD52 File Offset: 0x00938F52
		public unsafe int Substep_Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x060244E8 RID: 148712 RVA: 0x0093AD63 File Offset: 0x00938F63
		// (set) Token: 0x060244E9 RID: 148713 RVA: 0x0093AD73 File Offset: 0x00938F73
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x060244EA RID: 148714 RVA: 0x0093AD84 File Offset: 0x00938F84
		// (set) Token: 0x060244EB RID: 148715 RVA: 0x0093AD94 File Offset: 0x00938F94
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x060244EC RID: 148716 RVA: 0x0093ADA5 File Offset: 0x00938FA5
		// (set) Token: 0x060244ED RID: 148717 RVA: 0x0093ADB5 File Offset: 0x00938FB5
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x060244EE RID: 148718 RVA: 0x0093ADC6 File Offset: 0x00938FC6
		// (set) Token: 0x060244EF RID: 148719 RVA: 0x0093ADD6 File Offset: 0x00938FD6
		public unsafe bool bStopSim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x060244F0 RID: 148720 RVA: 0x0093ADE7 File Offset: 0x00938FE7
		// (set) Token: 0x060244F1 RID: 148721 RVA: 0x0093ADF7 File Offset: 0x00938FF7
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x060244F2 RID: 148722 RVA: 0x0093AE08 File Offset: 0x00939008
		// (set) Token: 0x060244F3 RID: 148723 RVA: 0x0093AE41 File Offset: 0x00939041
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_25, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x060244F4 RID: 148724 RVA: 0x0093AE50 File Offset: 0x00939050
		// (set) Token: 0x060244F5 RID: 148725 RVA: 0x0093AE89 File Offset: 0x00939089
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_26, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x060244F6 RID: 148726 RVA: 0x0093AE98 File Offset: 0x00939098
		// (set) Token: 0x060244F7 RID: 148727 RVA: 0x0093AED1 File Offset: 0x009390D1
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x060244F8 RID: 148728 RVA: 0x0093AEDF File Offset: 0x009390DF
		// (set) Token: 0x060244F9 RID: 148729 RVA: 0x0093AEF3 File Offset: 0x009390F3
		public unsafe FTransformDouble Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x060244FA RID: 148730 RVA: 0x0093AF08 File Offset: 0x00939108
		// (set) Token: 0x060244FB RID: 148731 RVA: 0x0093AF18 File Offset: 0x00939118
		public unsafe int Substep_CountRaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSCloth_DynamicPin_Broken_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x060244FC RID: 148732 RVA: 0x0093AF29 File Offset: 0x00939129
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateMaterialParams()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__UpdateMaterialParams_NativeFunctionPtr, null);
		}

		// Token: 0x060244FD RID: 148733 RVA: 0x0093AF3D File Offset: 0x0093913D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x060244FE RID: 148734 RVA: 0x0093AF51 File Offset: 0x00939151
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x060244FF RID: 148735 RVA: 0x0093AF65 File Offset: 0x00939165
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x06024500 RID: 148736 RVA: 0x0093AF79 File Offset: 0x00939179
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x06024501 RID: 148737 RVA: 0x0093AF8D File Offset: 0x0093918D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FitToBridge()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__FitToBridge_NativeFunctionPtr, null);
		}

		// Token: 0x06024502 RID: 148738 RVA: 0x0093AFA1 File Offset: 0x009391A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawDeformPoints()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__DrawDeformPoints_NativeFunctionPtr, null);
		}

		// Token: 0x06024503 RID: 148739 RVA: 0x0093AFB8 File Offset: 0x009391B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SyncPos(USceneComponent From, USceneComponent To)
		{
			BP_KuroCSCloth_DynamicPin_Broken_C.__SyncPos_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_Broken_C.__SyncPos_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_Broken_C.__SyncPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_Broken_C.__SyncPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->From = ((From != null) ? From.NativePtr : IntPtr.Zero);
			ptr->To = ((To != null) ? To.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__SyncPos_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024504 RID: 148740 RVA: 0x0093B026 File Offset: 0x00939226
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SyncToBindPin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__SyncToBindPin_NativeFunctionPtr, null);
		}

		// Token: 0x06024505 RID: 148741 RVA: 0x0093B03A File Offset: 0x0093923A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawAndSetPin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__DrawAndSetPin_NativeFunctionPtr, null);
		}

		// Token: 0x06024506 RID: 148742 RVA: 0x0093B04E File Offset: 0x0093924E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024507 RID: 148743 RVA: 0x0093B062 File Offset: 0x00939262
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024508 RID: 148744 RVA: 0x0093B077 File Offset: 0x00939277
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024509 RID: 148745 RVA: 0x0093B08C File Offset: 0x0093928C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602450A RID: 148746 RVA: 0x0093B0D4 File Offset: 0x009392D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602450B RID: 148747 RVA: 0x0093B11B File Offset: 0x0093931B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602450C RID: 148748 RVA: 0x0093B12F File Offset: 0x0093932F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602450D RID: 148749 RVA: 0x0093B144 File Offset: 0x00939344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602450E RID: 148750 RVA: 0x0093B190 File Offset: 0x00939390
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602450F RID: 148751 RVA: 0x0093B1DC File Offset: 0x009393DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024510 RID: 148752 RVA: 0x0093B298 File Offset: 0x00939498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024511 RID: 148753 RVA: 0x0093B321 File Offset: 0x00939521
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomBoxCheckTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSCloth_DynamicPin_Broken_C.__CustomBoxCheckTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024512 RID: 148754 RVA: 0x0093B335 File Offset: 0x00939535
		protected BP_KuroCSCloth_DynamicPin_Broken_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FF4 RID: 73716
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothDynamicPin/BP_KuroCSCloth_DynamicPin_Broken.BP_KuroCSCloth_DynamicPin_Broken_C";

		// Token: 0x04011FF5 RID: 73717
		private static IntPtr _ClassPtr;

		// Token: 0x04011FF6 RID: 73718
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FF7 RID: 73719
		internal static int __PropertyOffset_1;

		// Token: 0x04011FF8 RID: 73720
		internal static int __PropertyOffset_2;

		// Token: 0x04011FF9 RID: 73721
		internal static int __PropertyOffset_3;

		// Token: 0x04011FFA RID: 73722
		internal static int __PropertyOffset_4;

		// Token: 0x04011FFB RID: 73723
		internal static int __PropertyOffset_5;

		// Token: 0x04011FFC RID: 73724
		internal static int __PropertyOffset_6;

		// Token: 0x04011FFD RID: 73725
		internal static int __PropertyOffset_7;

		// Token: 0x04011FFE RID: 73726
		internal static int __PropertyOffset_8;

		// Token: 0x04011FFF RID: 73727
		internal static int __PropertyOffset_9;

		// Token: 0x04012000 RID: 73728
		internal static int __PropertyOffset_10;

		// Token: 0x04012001 RID: 73729
		internal static int __PropertyOffset_11;

		// Token: 0x04012002 RID: 73730
		internal static int __PropertyOffset_12;

		// Token: 0x04012003 RID: 73731
		internal static int __PropertyOffset_13;

		// Token: 0x04012004 RID: 73732
		internal static int __PropertyOffset_14;

		// Token: 0x04012005 RID: 73733
		internal static int __PropertyOffset_15;

		// Token: 0x04012006 RID: 73734
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x04012007 RID: 73735
		internal static int __PropertyOffset_16;

		// Token: 0x04012008 RID: 73736
		internal static int __PropertyOffset_17;

		// Token: 0x04012009 RID: 73737
		internal static int __PropertyOffset_18;

		// Token: 0x0401200A RID: 73738
		internal static int __PropertyOffset_19;

		// Token: 0x0401200B RID: 73739
		internal static int __PropertyOffset_20;

		// Token: 0x0401200C RID: 73740
		internal static int __PropertyOffset_21;

		// Token: 0x0401200D RID: 73741
		internal static int __PropertyOffset_22;

		// Token: 0x0401200E RID: 73742
		internal static int __PropertyOffset_23;

		// Token: 0x0401200F RID: 73743
		internal static int __PropertyOffset_24;

		// Token: 0x04012010 RID: 73744
		internal static int __PropertyOffset_25;

		// Token: 0x04012011 RID: 73745
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04012012 RID: 73746
		internal static int __PropertyOffset_26;

		// Token: 0x04012013 RID: 73747
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04012014 RID: 73748
		internal static int __PropertyOffset_27;

		// Token: 0x04012015 RID: 73749
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04012016 RID: 73750
		internal static int __PropertyOffset_28;

		// Token: 0x04012017 RID: 73751
		internal static int __PropertyOffset_29;

		// Token: 0x04012018 RID: 73752
		private static IntPtr __UpdateMaterialParams_NativeFunctionPtr;

		// Token: 0x04012019 RID: 73753
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x0401201A RID: 73754
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x0401201B RID: 73755
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x0401201C RID: 73756
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x0401201D RID: 73757
		private static IntPtr __FitToBridge_NativeFunctionPtr;

		// Token: 0x0401201E RID: 73758
		private static IntPtr __DrawDeformPoints_NativeFunctionPtr;

		// Token: 0x0401201F RID: 73759
		private static IntPtr __SyncPos_NativeFunctionPtr;

		// Token: 0x04012020 RID: 73760
		private static IntPtr __SyncToBindPin_NativeFunctionPtr;

		// Token: 0x04012021 RID: 73761
		private static IntPtr __DrawAndSetPin_NativeFunctionPtr;

		// Token: 0x04012022 RID: 73762
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012023 RID: 73763
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012024 RID: 73764
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012025 RID: 73765
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012026 RID: 73766
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04012027 RID: 73767
		private static IntPtr __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012028 RID: 73768
		private static IntPtr __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012029 RID: 73769
		private static IntPtr __CustomBoxCheckTick_NativeFunctionPtr;

		// Token: 0x02009EFA RID: 40698
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __SyncPos_FunctionParams
		{
			// Token: 0x04031820 RID: 202784
			[FieldOffset(0)]
			public IntPtr From;

			// Token: 0x04031821 RID: 202785
			[FieldOffset(8)]
			public IntPtr To;
		}

		// Token: 0x02009EFB RID: 40699
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031822 RID: 202786
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EFC RID: 40700
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031823 RID: 202787
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009EFD RID: 40701
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031824 RID: 202788
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031825 RID: 202789
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031826 RID: 202790
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031827 RID: 202791
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031828 RID: 202792
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031829 RID: 202793
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EFE RID: 40702
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_KuroCSCloth_DynamicPin_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403182A RID: 202794
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403182B RID: 202795
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403182C RID: 202796
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403182D RID: 202797
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
