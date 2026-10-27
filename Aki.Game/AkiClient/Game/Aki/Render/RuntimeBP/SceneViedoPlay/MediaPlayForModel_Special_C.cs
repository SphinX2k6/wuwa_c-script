using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneViedoPlay
{
	// Token: 0x02003BAB RID: 15275
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Special.MediaPlayForModel_Special_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class MediaPlayForModel_Special_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface, IKuroMp4PlayerPreviewable, IUnrealNativeInterface
	{
		// Token: 0x0602210E RID: 139534 RVA: 0x008FE37D File Offset: 0x008FC57D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MediaPlayForModel_Special_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Special.MediaPlayForModel_Special_C");
			}
			return MediaPlayForModel_Special_C._ClassPtr;
		}

		// Token: 0x0602210F RID: 139535 RVA: 0x008FE3A1 File Offset: 0x008FC5A1
		int IKuroMp4PlayerPreviewable.InterfaceOffset()
		{
			return MediaPlayForModel_Special_C.__InterfaceOffset_IKuroMp4PlayerPreviewable;
		}

		// Token: 0x06022110 RID: 139536 RVA: 0x008FE3A8 File Offset: 0x008FC5A8
		public MediaPlayForModel_Special_C() : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Special_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022111 RID: 139537 RVA: 0x008FE3D0 File Offset: 0x008FC5D0
		[NullableContext(1)]
		public MediaPlayForModel_Special_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Special_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x06022112 RID: 139538 RVA: 0x008FE403 File Offset: 0x008FC603
		// (set) Token: 0x06022113 RID: 139539 RVA: 0x008FE417 File Offset: 0x008FC617
		public unsafe USceneComponent VolumeLightSoucePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x06022114 RID: 139540 RVA: 0x008FE42C File Offset: 0x008FC62C
		// (set) Token: 0x06022115 RID: 139541 RVA: 0x008FE440 File Offset: 0x008FC640
		public unsafe UStaticMeshComponent VolumeMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x06022116 RID: 139542 RVA: 0x008FE455 File Offset: 0x008FC655
		// (set) Token: 0x06022117 RID: 139543 RVA: 0x008FE469 File Offset: 0x008FC669
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x06022118 RID: 139544 RVA: 0x008FE47E File Offset: 0x008FC67E
		// (set) Token: 0x06022119 RID: 139545 RVA: 0x008FE492 File Offset: 0x008FC692
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0602211A RID: 139546 RVA: 0x008FE4A7 File Offset: 0x008FC6A7
		// (set) Token: 0x0602211B RID: 139547 RVA: 0x008FE4BB File Offset: 0x008FC6BB
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0602211C RID: 139548 RVA: 0x008FE4D0 File Offset: 0x008FC6D0
		// (set) Token: 0x0602211D RID: 139549 RVA: 0x008FE4E4 File Offset: 0x008FC6E4
		public unsafe UMaterial ViedoMaterialTranSlucentTwoSide
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0602211E RID: 139550 RVA: 0x008FE4F9 File Offset: 0x008FC6F9
		// (set) Token: 0x0602211F RID: 139551 RVA: 0x008FE50D File Offset: 0x008FC70D
		public unsafe UMaterial ViedoMaterialTranSlucent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x06022120 RID: 139552 RVA: 0x008FE522 File Offset: 0x008FC722
		// (set) Token: 0x06022121 RID: 139553 RVA: 0x008FE536 File Offset: 0x008FC736
		public unsafe UMaterial ViedoMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x06022122 RID: 139554 RVA: 0x008FE54B File Offset: 0x008FC74B
		// (set) Token: 0x06022123 RID: 139555 RVA: 0x008FE55B File Offset: 0x008FC75B
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x06022124 RID: 139556 RVA: 0x008FE56C File Offset: 0x008FC76C
		// (set) Token: 0x06022125 RID: 139557 RVA: 0x008FE57C File Offset: 0x008FC77C
		public unsafe float DarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x06022126 RID: 139558 RVA: 0x008FE58D File Offset: 0x008FC78D
		// (set) Token: 0x06022127 RID: 139559 RVA: 0x008FE59D File Offset: 0x008FC79D
		public unsafe int AoiDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x06022128 RID: 139560 RVA: 0x008FE5AE File Offset: 0x008FC7AE
		// (set) Token: 0x06022129 RID: 139561 RVA: 0x008FE5BE File Offset: 0x008FC7BE
		public unsafe bool Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0602212A RID: 139562 RVA: 0x008FE5CF File Offset: 0x008FC7CF
		// (set) Token: 0x0602212B RID: 139563 RVA: 0x008FE5DF File Offset: 0x008FC7DF
		public unsafe bool TwoSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0602212C RID: 139564 RVA: 0x008FE5F0 File Offset: 0x008FC7F0
		// (set) Token: 0x0602212D RID: 139565 RVA: 0x008FE600 File Offset: 0x008FC800
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0602212E RID: 139566 RVA: 0x008FE611 File Offset: 0x008FC811
		// (set) Token: 0x0602212F RID: 139567 RVA: 0x008FE625 File Offset: 0x008FC825
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x06022130 RID: 139568 RVA: 0x008FE63A File Offset: 0x008FC83A
		// (set) Token: 0x06022131 RID: 139569 RVA: 0x008FE64E File Offset: 0x008FC84E
		public unsafe UMediaPlayer ShareMediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x06022132 RID: 139570 RVA: 0x008FE663 File Offset: 0x008FC863
		// (set) Token: 0x06022133 RID: 139571 RVA: 0x008FE677 File Offset: 0x008FC877
		public unsafe UMediaTexture ShareMediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x06022134 RID: 139572 RVA: 0x008FE68C File Offset: 0x008FC88C
		// (set) Token: 0x06022135 RID: 139573 RVA: 0x008FE69C File Offset: 0x008FC89C
		public unsafe bool IsMainPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x06022136 RID: 139574 RVA: 0x008FE6AD File Offset: 0x008FC8AD
		// (set) Token: 0x06022137 RID: 139575 RVA: 0x008FE6BD File Offset: 0x008FC8BD
		public unsafe bool isPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x06022138 RID: 139576 RVA: 0x008FE6CE File Offset: 0x008FC8CE
		// (set) Token: 0x06022139 RID: 139577 RVA: 0x008FE6DE File Offset: 0x008FC8DE
		public unsafe bool DrawDebugAoi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0602213A RID: 139578 RVA: 0x008FE6EF File Offset: 0x008FC8EF
		// (set) Token: 0x0602213B RID: 139579 RVA: 0x008FE6FF File Offset: 0x008FC8FF
		public unsafe bool isStopOnHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039B4 RID: 14772
		// (get) Token: 0x0602213C RID: 139580 RVA: 0x008FE710 File Offset: 0x008FC910
		// (set) Token: 0x0602213D RID: 139581 RVA: 0x008FE720 File Offset: 0x008FC920
		public unsafe bool enableQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039B5 RID: 14773
		// (get) Token: 0x0602213E RID: 139582 RVA: 0x008FE734 File Offset: 0x008FC934
		// (set) Token: 0x0602213F RID: 139583 RVA: 0x008FE76D File Offset: 0x008FC96D
		[Nullable(1)]
		public TArray<int> QualityDistanceList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._QualityDistanceList) == null)
				{
					result = (this._QualityDistanceList = new TArray<int>(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_23, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QualityDistanceList.CopyAssign(value);
			}
		}

		// Token: 0x170039B6 RID: 14774
		// (get) Token: 0x06022140 RID: 139584 RVA: 0x008FE77B File Offset: 0x008FC97B
		// (set) Token: 0x06022141 RID: 139585 RVA: 0x008FE78F File Offset: 0x008FC98F
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x06022142 RID: 139586 RVA: 0x008FE7A4 File Offset: 0x008FC9A4
		// (set) Token: 0x06022143 RID: 139587 RVA: 0x008FE7B4 File Offset: 0x008FC9B4
		public unsafe float MP4编辑器最大预览距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x06022144 RID: 139588 RVA: 0x008FE7C5 File Offset: 0x008FC9C5
		// (set) Token: 0x06022145 RID: 139589 RVA: 0x008FE7D5 File Offset: 0x008FC9D5
		public unsafe bool bPostProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x06022146 RID: 139590 RVA: 0x008FE7E6 File Offset: 0x008FC9E6
		// (set) Token: 0x06022147 RID: 139591 RVA: 0x008FE7FA File Offset: 0x008FC9FA
		public unsafe UMaterialInstance VolumeLightMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x06022148 RID: 139592 RVA: 0x008FE80F File Offset: 0x008FCA0F
		// (set) Token: 0x06022149 RID: 139593 RVA: 0x008FE823 File Offset: 0x008FCA23
		public unsafe UMaterialInstanceDynamic VolumeLightMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0602214A RID: 139594 RVA: 0x008FE838 File Offset: 0x008FCA38
		// (set) Token: 0x0602214B RID: 139595 RVA: 0x008FE84C File Offset: 0x008FCA4C
		public unsafe UMaterialInstanceDynamic MediaTexPostProcessDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_29);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0602214C RID: 139596 RVA: 0x008FE861 File Offset: 0x008FCA61
		// (set) Token: 0x0602214D RID: 139597 RVA: 0x008FE875 File Offset: 0x008FCA75
		public unsafe UMaterialInterface MediaTexPostProcessMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0602214E RID: 139598 RVA: 0x008FE88A File Offset: 0x008FCA8A
		// (set) Token: 0x0602214F RID: 139599 RVA: 0x008FE89A File Offset: 0x008FCA9A
		public unsafe int PostTexHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x06022150 RID: 139600 RVA: 0x008FE8AB File Offset: 0x008FCAAB
		// (set) Token: 0x06022151 RID: 139601 RVA: 0x008FE8BB File Offset: 0x008FCABB
		public unsafe int PostTexWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x06022152 RID: 139602 RVA: 0x008FE8CC File Offset: 0x008FCACC
		// (set) Token: 0x06022153 RID: 139603 RVA: 0x008FE8E0 File Offset: 0x008FCAE0
		public unsafe UTextureRenderTarget2D MediaTexPostProcessRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x06022154 RID: 139604 RVA: 0x008FE8F5 File Offset: 0x008FCAF5
		// (set) Token: 0x06022155 RID: 139605 RVA: 0x008FE905 File Offset: 0x008FCB05
		public unsafe bool bEnableVolumeLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x06022156 RID: 139606 RVA: 0x008FE916 File Offset: 0x008FCB16
		// (set) Token: 0x06022157 RID: 139607 RVA: 0x008FE92A File Offset: 0x008FCB2A
		public unsafe UMediaPlayer ShareMediaPlayer_EditorPreview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x06022158 RID: 139608 RVA: 0x008FE93F File Offset: 0x008FCB3F
		// (set) Token: 0x06022159 RID: 139609 RVA: 0x008FE953 File Offset: 0x008FCB53
		public unsafe UMediaTexture ShareMediaTexture_EditorPreview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x0602215A RID: 139610 RVA: 0x008FE968 File Offset: 0x008FCB68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			MediaPlayForModel_Special_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0602215B RID: 139611 RVA: 0x008FE9B8 File Offset: 0x008FCBB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			MediaPlayForModel_Special_C.__GetAoiRange_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__GetAoiRange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0602215C RID: 139612 RVA: 0x008FEA07 File Offset: 0x008FCC07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DownSampleMediaTex()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__DownSampleMediaTex_NativeFunctionPtr, null);
		}

		// Token: 0x0602215D RID: 139613 RVA: 0x008FEA1B File Offset: 0x008FCC1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 编辑器强制停止()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器强制停止_NativeFunctionPtr, null);
		}

		// Token: 0x0602215E RID: 139614 RVA: 0x008FEA2F File Offset: 0x008FCC2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 编辑器强制播放()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器强制播放_NativeFunctionPtr, null);
		}

		// Token: 0x0602215F RID: 139615 RVA: 0x008FEA43 File Offset: 0x008FCC43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 编辑器_MP4播放器初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器_MP4播放器初始化_NativeFunctionPtr, null);
		}

		// Token: 0x06022160 RID: 139616 RVA: 0x008FEA57 File Offset: 0x008FCC57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 编辑器MP4播放器停止预览()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器MP4播放器停止预览_NativeFunctionPtr, null);
		}

		// Token: 0x06022161 RID: 139617 RVA: 0x008FEA6B File Offset: 0x008FCC6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 编辑器MP4播放器开始预览()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器MP4播放器开始预览_NativeFunctionPtr, null);
		}

		// Token: 0x06022162 RID: 139618 RVA: 0x008FEA80 File Offset: 0x008FCC80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetSource(ref UMediaSource MediaSource)
		{
			MediaPlayForModel_Special_C.__GetSource_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__GetSource_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__GetSource_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__GetSource_NativeFunctionPtr, (void*)ptr, 1);
			ref MediaPlayForModel_Special_C.__GetSource_FunctionParams ptr2 = ref *ptr;
			UMediaSource umediaSource = MediaSource;
			ptr2.MediaSource = ((umediaSource != null) ? umediaSource.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__GetSource_NativeFunctionPtr, (void*)ptr);
			MediaSource = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaSource>(ptr->MediaSource);
		}

		// Token: 0x06022163 RID: 139619 RVA: 0x008FEAE4 File Offset: 0x008FCCE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06022164 RID: 139620 RVA: 0x008FEAF8 File Offset: 0x008FCCF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HideVolumeLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__HideVolumeLight_NativeFunctionPtr, null);
		}

		// Token: 0x06022165 RID: 139621 RVA: 0x008FEB0C File Offset: 0x008FCD0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ShowVolumeLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ShowVolumeLight_NativeFunctionPtr, null);
		}

		// Token: 0x06022166 RID: 139622 RVA: 0x008FEB20 File Offset: 0x008FCD20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Release_Player_Asset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Release_Player_Asset_NativeFunctionPtr, null);
		}

		// Token: 0x06022167 RID: 139623 RVA: 0x008FEB34 File Offset: 0x008FCD34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AllocatePlayerAsset(UMediaPlayer player, UMediaTexture texture)
		{
			MediaPlayForModel_Special_C.__AllocatePlayerAsset_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__AllocatePlayerAsset_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__AllocatePlayerAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__AllocatePlayerAsset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->player = ((player != null) ? player.NativePtr : IntPtr.Zero);
			ptr->texture = ((texture != null) ? texture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__AllocatePlayerAsset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022168 RID: 139624 RVA: 0x008FEBA0 File Offset: 0x008FCDA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OpenSource(ref bool Successs)
		{
			MediaPlayForModel_Special_C.__OpenSource_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__OpenSource_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__OpenSource_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__OpenSource_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Successs = Successs;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OpenSource_NativeFunctionPtr, (void*)ptr);
			Successs = ptr->Successs;
		}

		// Token: 0x06022169 RID: 139625 RVA: 0x008FEBEF File Offset: 0x008FCDEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x0602216A RID: 139626 RVA: 0x008FEC03 File Offset: 0x008FCE03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602216B RID: 139627 RVA: 0x008FEC17 File Offset: 0x008FCE17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602216C RID: 139628 RVA: 0x008FEC2C File Offset: 0x008FCE2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0602216D RID: 139629 RVA: 0x008FEC40 File Offset: 0x008FCE40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x0602216E RID: 139630 RVA: 0x008FEC54 File Offset: 0x008FCE54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0602216F RID: 139631 RVA: 0x008FEC68 File Offset: 0x008FCE68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022170 RID: 139632 RVA: 0x008FEC7C File Offset: 0x008FCE7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022171 RID: 139633 RVA: 0x008FEC94 File Offset: 0x008FCE94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022172 RID: 139634 RVA: 0x008FECDC File Offset: 0x008FCEDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022173 RID: 139635 RVA: 0x008FED23 File Offset: 0x008FCF23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x06022174 RID: 139636 RVA: 0x008FED37 File Offset: 0x008FCF37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x06022175 RID: 139637 RVA: 0x008FED4C File Offset: 0x008FCF4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022176 RID: 139638 RVA: 0x008FED98 File Offset: 0x008FCF98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022177 RID: 139639 RVA: 0x008FEDE4 File Offset: 0x008FCFE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlaySound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__PlaySound_NativeFunctionPtr, null);
		}

		// Token: 0x06022178 RID: 139640 RVA: 0x008FEDF8 File Offset: 0x008FCFF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x06022179 RID: 139641 RVA: 0x008FEE0C File Offset: 0x008FD00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnMp4PlayRequested(UMediaPlayer InPlayer, UMediaTexture InTexture)
		{
			MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPlayer = ((InPlayer != null) ? InPlayer.NativePtr : IntPtr.Zero);
			ptr->InTexture = ((InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602217A RID: 139642 RVA: 0x008FEE78 File Offset: 0x008FD078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnMp4PlayRequested_Implementation(UMediaPlayer InPlayer, UMediaTexture InTexture)
		{
			MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPlayer = ((InPlayer != null) ? InPlayer.NativePtr : IntPtr.Zero);
			ptr->InTexture = ((InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602217B RID: 139643 RVA: 0x008FEEE4 File Offset: 0x008FD0E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnMp4StopRequested()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4StopRequested_NativeFunctionPtr, null);
		}

		// Token: 0x0602217C RID: 139644 RVA: 0x008FEEF8 File Offset: 0x008FD0F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnMp4StopRequested_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4StopRequested_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602217D RID: 139645 RVA: 0x008FEF0D File Offset: 0x008FD10D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0602217E RID: 139646 RVA: 0x008FEF21 File Offset: 0x008FD121
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602217F RID: 139647 RVA: 0x008FEF38 File Offset: 0x008FD138
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022180 RID: 139648 RVA: 0x008FEF80 File Offset: 0x008FD180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022181 RID: 139649 RVA: 0x008FEFC7 File Offset: 0x008FD1C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnMediaAsyncClosed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMediaAsyncClosed_NativeFunctionPtr, null);
		}

		// Token: 0x06022182 RID: 139650 RVA: 0x008FEFDB File Offset: 0x008FD1DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x06022183 RID: 139651 RVA: 0x008FEFEF File Offset: 0x008FD1EF
		protected MediaPlayForModel_Special_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010AD0 RID: 68304
		internal static int __InterfaceOffset_IKuroMp4PlayerPreviewable;

		// Token: 0x04010AD1 RID: 68305
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Special.MediaPlayForModel_Special_C";

		// Token: 0x04010AD2 RID: 68306
		private static IntPtr _ClassPtr;

		// Token: 0x04010AD3 RID: 68307
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010AD4 RID: 68308
		internal static int __PropertyOffset_1;

		// Token: 0x04010AD5 RID: 68309
		internal static int __PropertyOffset_2;

		// Token: 0x04010AD6 RID: 68310
		internal static int __PropertyOffset_3;

		// Token: 0x04010AD7 RID: 68311
		internal static int __PropertyOffset_4;

		// Token: 0x04010AD8 RID: 68312
		internal static int __PropertyOffset_5;

		// Token: 0x04010AD9 RID: 68313
		internal static int __PropertyOffset_6;

		// Token: 0x04010ADA RID: 68314
		internal static int __PropertyOffset_7;

		// Token: 0x04010ADB RID: 68315
		internal static int __PropertyOffset_8;

		// Token: 0x04010ADC RID: 68316
		internal static int __PropertyOffset_9;

		// Token: 0x04010ADD RID: 68317
		internal static int __PropertyOffset_10;

		// Token: 0x04010ADE RID: 68318
		internal static int __PropertyOffset_11;

		// Token: 0x04010ADF RID: 68319
		internal static int __PropertyOffset_12;

		// Token: 0x04010AE0 RID: 68320
		internal static int __PropertyOffset_13;

		// Token: 0x04010AE1 RID: 68321
		internal static int __PropertyOffset_14;

		// Token: 0x04010AE2 RID: 68322
		internal static int __PropertyOffset_15;

		// Token: 0x04010AE3 RID: 68323
		internal static int __PropertyOffset_16;

		// Token: 0x04010AE4 RID: 68324
		internal static int __PropertyOffset_17;

		// Token: 0x04010AE5 RID: 68325
		internal static int __PropertyOffset_18;

		// Token: 0x04010AE6 RID: 68326
		internal static int __PropertyOffset_19;

		// Token: 0x04010AE7 RID: 68327
		internal static int __PropertyOffset_20;

		// Token: 0x04010AE8 RID: 68328
		internal static int __PropertyOffset_21;

		// Token: 0x04010AE9 RID: 68329
		internal static int __PropertyOffset_22;

		// Token: 0x04010AEA RID: 68330
		internal static int __PropertyOffset_23;

		// Token: 0x04010AEB RID: 68331
		private TArray<int> _QualityDistanceList;

		// Token: 0x04010AEC RID: 68332
		internal static int __PropertyOffset_24;

		// Token: 0x04010AED RID: 68333
		internal static int __PropertyOffset_25;

		// Token: 0x04010AEE RID: 68334
		internal static int __PropertyOffset_26;

		// Token: 0x04010AEF RID: 68335
		internal static int __PropertyOffset_27;

		// Token: 0x04010AF0 RID: 68336
		internal static int __PropertyOffset_28;

		// Token: 0x04010AF1 RID: 68337
		internal static int __PropertyOffset_29;

		// Token: 0x04010AF2 RID: 68338
		internal static int __PropertyOffset_30;

		// Token: 0x04010AF3 RID: 68339
		internal static int __PropertyOffset_31;

		// Token: 0x04010AF4 RID: 68340
		internal static int __PropertyOffset_32;

		// Token: 0x04010AF5 RID: 68341
		internal static int __PropertyOffset_33;

		// Token: 0x04010AF6 RID: 68342
		internal static int __PropertyOffset_34;

		// Token: 0x04010AF7 RID: 68343
		internal static int __PropertyOffset_35;

		// Token: 0x04010AF8 RID: 68344
		internal static int __PropertyOffset_36;

		// Token: 0x04010AF9 RID: 68345
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x04010AFA RID: 68346
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x04010AFB RID: 68347
		private static IntPtr __DownSampleMediaTex_NativeFunctionPtr;

		// Token: 0x04010AFC RID: 68348
		private static IntPtr __编辑器强制停止_NativeFunctionPtr;

		// Token: 0x04010AFD RID: 68349
		private static IntPtr __编辑器强制播放_NativeFunctionPtr;

		// Token: 0x04010AFE RID: 68350
		private static IntPtr __编辑器_MP4播放器初始化_NativeFunctionPtr;

		// Token: 0x04010AFF RID: 68351
		private static IntPtr __编辑器MP4播放器停止预览_NativeFunctionPtr;

		// Token: 0x04010B00 RID: 68352
		private static IntPtr __编辑器MP4播放器开始预览_NativeFunctionPtr;

		// Token: 0x04010B01 RID: 68353
		private static IntPtr __GetSource_NativeFunctionPtr;

		// Token: 0x04010B02 RID: 68354
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04010B03 RID: 68355
		private static IntPtr __HideVolumeLight_NativeFunctionPtr;

		// Token: 0x04010B04 RID: 68356
		private static IntPtr __ShowVolumeLight_NativeFunctionPtr;

		// Token: 0x04010B05 RID: 68357
		private static IntPtr __Release_Player_Asset_NativeFunctionPtr;

		// Token: 0x04010B06 RID: 68358
		private static IntPtr __AllocatePlayerAsset_NativeFunctionPtr;

		// Token: 0x04010B07 RID: 68359
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x04010B08 RID: 68360
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x04010B09 RID: 68361
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010B0A RID: 68362
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x04010B0B RID: 68363
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x04010B0C RID: 68364
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x04010B0D RID: 68365
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010B0E RID: 68366
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010B0F RID: 68367
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04010B10 RID: 68368
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04010B11 RID: 68369
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010B12 RID: 68370
		private static IntPtr __PlaySound_NativeFunctionPtr;

		// Token: 0x04010B13 RID: 68371
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x04010B14 RID: 68372
		private static IntPtr __OnMp4PlayRequested_NativeFunctionPtr;

		// Token: 0x04010B15 RID: 68373
		private static IntPtr __OnMp4StopRequested_NativeFunctionPtr;

		// Token: 0x04010B16 RID: 68374
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x04010B17 RID: 68375
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010B18 RID: 68376
		private static IntPtr __OnMediaAsyncClosed_NativeFunctionPtr;

		// Token: 0x04010B19 RID: 68377
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x02009D24 RID: 40228
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0403145E RID: 201822
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02009D25 RID: 40229
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0403145F RID: 201823
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02009D26 RID: 40230
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSource_FunctionParams
		{
			// Token: 0x04031460 RID: 201824
			[FieldOffset(0)]
			public IntPtr MediaSource;
		}

		// Token: 0x02009D27 RID: 40231
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AllocatePlayerAsset_FunctionParams
		{
			// Token: 0x04031461 RID: 201825
			[FieldOffset(0)]
			public IntPtr player;

			// Token: 0x04031462 RID: 201826
			[FieldOffset(8)]
			public IntPtr texture;
		}

		// Token: 0x02009D28 RID: 40232
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __OpenSource_FunctionParams
		{
			// Token: 0x04031463 RID: 201827
			[FieldOffset(0)]
			public bool Successs;
		}

		// Token: 0x02009D29 RID: 40233
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031464 RID: 201828
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D2A RID: 40234
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031465 RID: 201829
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009D2B RID: 40235
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMp4PlayRequested_FunctionParams
		{
			// Token: 0x04031466 RID: 201830
			[FieldOffset(0)]
			public IntPtr InPlayer;

			// Token: 0x04031467 RID: 201831
			[FieldOffset(8)]
			public IntPtr InTexture;
		}

		// Token: 0x02009D2C RID: 40236
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031468 RID: 201832
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
