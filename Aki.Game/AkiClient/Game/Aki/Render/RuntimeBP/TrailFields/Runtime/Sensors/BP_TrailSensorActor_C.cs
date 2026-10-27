using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Sensors
{
	// Token: 0x02003AAE RID: 15022
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensorActor.BP_TrailSensorActor_C")]
	[UnrealStructLayout(1280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class BP_TrailSensorActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202D9 RID: 131801 RVA: 0x008CBDFF File Offset: 0x008C9FFF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailSensorActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensorActor.BP_TrailSensorActor_C");
			}
			return BP_TrailSensorActor_C._ClassPtr;
		}

		// Token: 0x060202DA RID: 131802 RVA: 0x008CBE24 File Offset: 0x008CA024
		public BP_TrailSensorActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensorActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202DB RID: 131803 RVA: 0x008CBE4C File Offset: 0x008CA04C
		[NullableContext(1)]
		public BP_TrailSensorActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailSensorActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x060202DC RID: 131804 RVA: 0x008CBE7F File Offset: 0x008CA07F
		// (set) Token: 0x060202DD RID: 131805 RVA: 0x008CBE93 File Offset: 0x008CA093
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x060202DE RID: 131806 RVA: 0x008CBEA8 File Offset: 0x008CA0A8
		// (set) Token: 0x060202DF RID: 131807 RVA: 0x008CBEBC File Offset: 0x008CA0BC
		public unsafe UDecalComponent Decal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x060202E0 RID: 131808 RVA: 0x008CBED1 File Offset: 0x008CA0D1
		// (set) Token: 0x060202E1 RID: 131809 RVA: 0x008CBEE5 File Offset: 0x008CA0E5
		public unsafe USceneComponent SceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x060202E2 RID: 131810 RVA: 0x008CBEFA File Offset: 0x008CA0FA
		// (set) Token: 0x060202E3 RID: 131811 RVA: 0x008CBF0E File Offset: 0x008CA10E
		public unsafe FVector2D WorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x060202E4 RID: 131812 RVA: 0x008CBF23 File Offset: 0x008CA123
		// (set) Token: 0x060202E5 RID: 131813 RVA: 0x008CBF37 File Offset: 0x008CA137
		public unsafe UMaterialInstanceDynamic DrawMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x060202E6 RID: 131814 RVA: 0x008CBF4C File Offset: 0x008CA14C
		// (set) Token: 0x060202E7 RID: 131815 RVA: 0x008CBF60 File Offset: 0x008CA160
		public unsafe UMaterialInstanceDynamic CopyMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x060202E8 RID: 131816 RVA: 0x008CBF75 File Offset: 0x008CA175
		// (set) Token: 0x060202E9 RID: 131817 RVA: 0x008CBF89 File Offset: 0x008CA189
		public unsafe UMaterialInstanceDynamic EdgeMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x060202EA RID: 131818 RVA: 0x008CBF9E File Offset: 0x008CA19E
		// (set) Token: 0x060202EB RID: 131819 RVA: 0x008CBFB2 File Offset: 0x008CA1B2
		public unsafe UMaterialInstanceDynamic BlurMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x060202EC RID: 131820 RVA: 0x008CBFC7 File Offset: 0x008CA1C7
		// (set) Token: 0x060202ED RID: 131821 RVA: 0x008CBFD7 File Offset: 0x008CA1D7
		public unsafe float MiddleRTSizeResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x060202EE RID: 131822 RVA: 0x008CBFE8 File Offset: 0x008CA1E8
		// (set) Token: 0x060202EF RID: 131823 RVA: 0x008CBFF8 File Offset: 0x008CA1F8
		public unsafe float PixelWidth_Blured
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x060202F0 RID: 131824 RVA: 0x008CC009 File Offset: 0x008CA209
		// (set) Token: 0x060202F1 RID: 131825 RVA: 0x008CC01D File Offset: 0x008CA21D
		public unsafe UTextureRenderTarget2D Drawn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x060202F2 RID: 131826 RVA: 0x008CC032 File Offset: 0x008CA232
		// (set) Token: 0x060202F3 RID: 131827 RVA: 0x008CC046 File Offset: 0x008CA246
		public unsafe UTextureRenderTarget2D Save
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x060202F4 RID: 131828 RVA: 0x008CC05B File Offset: 0x008CA25B
		// (set) Token: 0x060202F5 RID: 131829 RVA: 0x008CC06F File Offset: 0x008CA26F
		public unsafe UTextureRenderTarget2D Edged
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x060202F6 RID: 131830 RVA: 0x008CC084 File Offset: 0x008CA284
		// (set) Token: 0x060202F7 RID: 131831 RVA: 0x008CC098 File Offset: 0x008CA298
		public unsafe UTextureRenderTarget2D Blured
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x060202F8 RID: 131832 RVA: 0x008CC0AD File Offset: 0x008CA2AD
		// (set) Token: 0x060202F9 RID: 131833 RVA: 0x008CC0C1 File Offset: 0x008CA2C1
		public unsafe UTextureRenderTarget2D CurrentFrame
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x060202FA RID: 131834 RVA: 0x008CC0D6 File Offset: 0x008CA2D6
		// (set) Token: 0x060202FB RID: 131835 RVA: 0x008CC0EA File Offset: 0x008CA2EA
		public unsafe FVector2D Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x060202FC RID: 131836 RVA: 0x008CC0FF File Offset: 0x008CA2FF
		// (set) Token: 0x060202FD RID: 131837 RVA: 0x008CC10F File Offset: 0x008CA30F
		public unsafe float EdgeOffsetWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x060202FE RID: 131838 RVA: 0x008CC120 File Offset: 0x008CA320
		// (set) Token: 0x060202FF RID: 131839 RVA: 0x008CC130 File Offset: 0x008CA330
		public unsafe float BlurWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x06020300 RID: 131840 RVA: 0x008CC144 File Offset: 0x008CA344
		// (set) Token: 0x06020301 RID: 131841 RVA: 0x008CC17D File Offset: 0x008CA37D
		[Nullable(1)]
		public TArray<STrailDrawInfo> Drawers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<STrailDrawInfo> result;
				if ((result = this._Drawers) == null)
				{
					result = (this._Drawers = new TArray<STrailDrawInfo>(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_19, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Drawers.CopyAssign(value);
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x06020302 RID: 131842 RVA: 0x008CC18B File Offset: 0x008CA38B
		// (set) Token: 0x06020303 RID: 131843 RVA: 0x008CC19B File Offset: 0x008CA39B
		public unsafe float Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x06020304 RID: 131844 RVA: 0x008CC1AC File Offset: 0x008CA3AC
		// (set) Token: 0x06020305 RID: 131845 RVA: 0x008CC1BC File Offset: 0x008CA3BC
		public unsafe float HeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x06020306 RID: 131846 RVA: 0x008CC1CD File Offset: 0x008CA3CD
		// (set) Token: 0x06020307 RID: 131847 RVA: 0x008CC1E1 File Offset: 0x008CA3E1
		public unsafe FVector2D LastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x06020308 RID: 131848 RVA: 0x008CC1F6 File Offset: 0x008CA3F6
		// (set) Token: 0x06020309 RID: 131849 RVA: 0x008CC206 File Offset: 0x008CA406
		public unsafe bool ShowGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0602030A RID: 131850 RVA: 0x008CC217 File Offset: 0x008CA417
		// (set) Token: 0x0602030B RID: 131851 RVA: 0x008CC227 File Offset: 0x008CA427
		public unsafe bool IsLandActor_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0602030C RID: 131852 RVA: 0x008CC238 File Offset: 0x008CA438
		// (set) Token: 0x0602030D RID: 131853 RVA: 0x008CC24C File Offset: 0x008CA44C
		public unsafe UMaterialInterface DrawEdge_Inst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0602030E RID: 131854 RVA: 0x008CC261 File Offset: 0x008CA461
		// (set) Token: 0x0602030F RID: 131855 RVA: 0x008CC275 File Offset: 0x008CA475
		public unsafe UMaterialInterface Blur_Inst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x06020310 RID: 131856 RVA: 0x008CC28A File Offset: 0x008CA48A
		// (set) Token: 0x06020311 RID: 131857 RVA: 0x008CC29A File Offset: 0x008CA49A
		public unsafe bool SpecificBluredRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x06020312 RID: 131858 RVA: 0x008CC2AB File Offset: 0x008CA4AB
		// (set) Token: 0x06020313 RID: 131859 RVA: 0x008CC2BF File Offset: 0x008CA4BF
		public unsafe UTextureRenderTarget2D NewBlurdRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x06020314 RID: 131860 RVA: 0x008CC2D4 File Offset: 0x008CA4D4
		// (set) Token: 0x06020315 RID: 131861 RVA: 0x008CC2E4 File Offset: 0x008CA4E4
		public unsafe bool UpdatePositionEveryFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x06020316 RID: 131862 RVA: 0x008CC2F5 File Offset: 0x008CA4F5
		// (set) Token: 0x06020317 RID: 131863 RVA: 0x008CC305 File Offset: 0x008CA505
		public unsafe bool UsePlayPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x06020318 RID: 131864 RVA: 0x008CC316 File Offset: 0x008CA516
		// (set) Token: 0x06020319 RID: 131865 RVA: 0x008CC326 File Offset: 0x008CA526
		public unsafe int DynamicRTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailSensorActor_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0602031A RID: 131866 RVA: 0x008CC337 File Offset: 0x008CA537
		// (set) Token: 0x0602031B RID: 131867 RVA: 0x008CC34B File Offset: 0x008CA54B
		public unsafe UMaterialInterface Draw_Inst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_32);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_32, value);
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0602031C RID: 131868 RVA: 0x008CC360 File Offset: 0x008CA560
		// (set) Token: 0x0602031D RID: 131869 RVA: 0x008CC374 File Offset: 0x008CA574
		public unsafe UMaterialInterface Copy_Inst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailSensorActor_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x0602031E RID: 131870 RVA: 0x008CC38C File Offset: 0x008CA58C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEnable(ref bool Ret)
		{
			BP_TrailSensorActor_C.__IsEnable_FunctionParams* ptr = stackalloc BP_TrailSensorActor_C.__IsEnable_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(BP_TrailSensorActor_C.__IsEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensorActor_C.__IsEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Ret = Ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__IsEnable_NativeFunctionPtr, (void*)ptr);
			Ret = ptr->Ret;
		}

		// Token: 0x0602031F RID: 131871 RVA: 0x008CC3DC File Offset: 0x008CA5DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetPlayerActor(ref AActor PlayerActor)
		{
			BP_TrailSensorActor_C.__GetPlayerActor_FunctionParams* ptr = stackalloc BP_TrailSensorActor_C.__GetPlayerActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_TrailSensorActor_C.__GetPlayerActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensorActor_C.__GetPlayerActor_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_TrailSensorActor_C.__GetPlayerActor_FunctionParams ptr2 = ref *ptr;
			AActor aactor = PlayerActor;
			ptr2.PlayerActor = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__GetPlayerActor_NativeFunctionPtr, (void*)ptr);
			PlayerActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->PlayerActor);
		}

		// Token: 0x06020320 RID: 131872 RVA: 0x008CC440 File Offset: 0x008CA640
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawIntoRenderTargets()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__DrawIntoRenderTargets_NativeFunctionPtr, null);
		}

		// Token: 0x06020321 RID: 131873 RVA: 0x008CC454 File Offset: 0x008CA654
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_Render_Targets()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__Init_Render_Targets_NativeFunctionPtr, null);
		}

		// Token: 0x06020322 RID: 131874 RVA: 0x008CC468 File Offset: 0x008CA668
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector2D UpDatePosition()
		{
			BP_TrailSensorActor_C.__UpDatePosition_FunctionParams* ptr = stackalloc BP_TrailSensorActor_C.__UpDatePosition_FunctionParams[(UIntPtr)463] + 15L / (long)sizeof(BP_TrailSensorActor_C.__UpDatePosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensorActor_C.__UpDatePosition_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__UpDatePosition_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020323 RID: 131875 RVA: 0x008CC4B0 File Offset: 0x008CA6B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreateRTandMat()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__CreateRTandMat_NativeFunctionPtr, null);
		}

		// Token: 0x06020324 RID: 131876 RVA: 0x008CC4C4 File Offset: 0x008CA6C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DrawToCurrentFrame(UCanvas Canvas, STrailDrawInfo DrawInfo)
		{
			BP_TrailSensorActor_C.__DrawToCurrentFrame_FunctionParams* ptr = stackalloc BP_TrailSensorActor_C.__DrawToCurrentFrame_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_TrailSensorActor_C.__DrawToCurrentFrame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensorActor_C.__DrawToCurrentFrame_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Canvas = ((Canvas != null) ? Canvas.NativePtr : IntPtr.Zero);
			if (DrawInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(STrailDrawInfo.StaticStruct(), &ptr->DrawInfo, DrawInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__DrawToCurrentFrame_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020325 RID: 131877 RVA: 0x008CC53E File Offset: 0x008CA73E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020326 RID: 131878 RVA: 0x008CC552 File Offset: 0x008CA752
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSensorActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020327 RID: 131879 RVA: 0x008CC567 File Offset: 0x008CA767
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Draw()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__Draw_NativeFunctionPtr, null);
		}

		// Token: 0x06020328 RID: 131880 RVA: 0x008CC57B File Offset: 0x008CA77B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawFinished()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__DrawFinished_NativeFunctionPtr, null);
		}

		// Token: 0x06020329 RID: 131881 RVA: 0x008CC58F File Offset: 0x008CA78F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602032A RID: 131882 RVA: 0x008CC5A3 File Offset: 0x008CA7A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSensorActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602032B RID: 131883 RVA: 0x008CC5B8 File Offset: 0x008CA7B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TrailSensorActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailSensorActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailSensorActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensorActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailSensorActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602032C RID: 131884 RVA: 0x008CC600 File Offset: 0x008CA800
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TrailSensorActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailSensorActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailSensorActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailSensorActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailSensorActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602032D RID: 131885 RVA: 0x008CC647 File Offset: 0x008CA847
		protected BP_TrailSensorActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8D3 RID: 63699
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Sensors/BP_TrailSensorActor.BP_TrailSensorActor_C";

		// Token: 0x0400F8D4 RID: 63700
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8D5 RID: 63701
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8D6 RID: 63702
		internal static int __PropertyOffset_1;

		// Token: 0x0400F8D7 RID: 63703
		internal static int __PropertyOffset_2;

		// Token: 0x0400F8D8 RID: 63704
		internal static int __PropertyOffset_3;

		// Token: 0x0400F8D9 RID: 63705
		internal static int __PropertyOffset_4;

		// Token: 0x0400F8DA RID: 63706
		internal static int __PropertyOffset_5;

		// Token: 0x0400F8DB RID: 63707
		internal static int __PropertyOffset_6;

		// Token: 0x0400F8DC RID: 63708
		internal static int __PropertyOffset_7;

		// Token: 0x0400F8DD RID: 63709
		internal static int __PropertyOffset_8;

		// Token: 0x0400F8DE RID: 63710
		internal static int __PropertyOffset_9;

		// Token: 0x0400F8DF RID: 63711
		internal static int __PropertyOffset_10;

		// Token: 0x0400F8E0 RID: 63712
		internal static int __PropertyOffset_11;

		// Token: 0x0400F8E1 RID: 63713
		internal static int __PropertyOffset_12;

		// Token: 0x0400F8E2 RID: 63714
		internal static int __PropertyOffset_13;

		// Token: 0x0400F8E3 RID: 63715
		internal static int __PropertyOffset_14;

		// Token: 0x0400F8E4 RID: 63716
		internal static int __PropertyOffset_15;

		// Token: 0x0400F8E5 RID: 63717
		internal static int __PropertyOffset_16;

		// Token: 0x0400F8E6 RID: 63718
		internal static int __PropertyOffset_17;

		// Token: 0x0400F8E7 RID: 63719
		internal static int __PropertyOffset_18;

		// Token: 0x0400F8E8 RID: 63720
		internal static int __PropertyOffset_19;

		// Token: 0x0400F8E9 RID: 63721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<STrailDrawInfo> _Drawers;

		// Token: 0x0400F8EA RID: 63722
		internal static int __PropertyOffset_20;

		// Token: 0x0400F8EB RID: 63723
		internal static int __PropertyOffset_21;

		// Token: 0x0400F8EC RID: 63724
		internal static int __PropertyOffset_22;

		// Token: 0x0400F8ED RID: 63725
		internal static int __PropertyOffset_23;

		// Token: 0x0400F8EE RID: 63726
		internal static int __PropertyOffset_24;

		// Token: 0x0400F8EF RID: 63727
		internal static int __PropertyOffset_25;

		// Token: 0x0400F8F0 RID: 63728
		internal static int __PropertyOffset_26;

		// Token: 0x0400F8F1 RID: 63729
		internal static int __PropertyOffset_27;

		// Token: 0x0400F8F2 RID: 63730
		internal static int __PropertyOffset_28;

		// Token: 0x0400F8F3 RID: 63731
		internal static int __PropertyOffset_29;

		// Token: 0x0400F8F4 RID: 63732
		internal static int __PropertyOffset_30;

		// Token: 0x0400F8F5 RID: 63733
		internal static int __PropertyOffset_31;

		// Token: 0x0400F8F6 RID: 63734
		internal static int __PropertyOffset_32;

		// Token: 0x0400F8F7 RID: 63735
		internal static int __PropertyOffset_33;

		// Token: 0x0400F8F8 RID: 63736
		private static IntPtr __IsEnable_NativeFunctionPtr;

		// Token: 0x0400F8F9 RID: 63737
		private static IntPtr __GetPlayerActor_NativeFunctionPtr;

		// Token: 0x0400F8FA RID: 63738
		private static IntPtr __DrawIntoRenderTargets_NativeFunctionPtr;

		// Token: 0x0400F8FB RID: 63739
		private static IntPtr __Init_Render_Targets_NativeFunctionPtr;

		// Token: 0x0400F8FC RID: 63740
		private static IntPtr __UpDatePosition_NativeFunctionPtr;

		// Token: 0x0400F8FD RID: 63741
		private static IntPtr __CreateRTandMat_NativeFunctionPtr;

		// Token: 0x0400F8FE RID: 63742
		private static IntPtr __DrawToCurrentFrame_NativeFunctionPtr;

		// Token: 0x0400F8FF RID: 63743
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F900 RID: 63744
		private static IntPtr __Draw_NativeFunctionPtr;

		// Token: 0x0400F901 RID: 63745
		private static IntPtr __DrawFinished_NativeFunctionPtr;

		// Token: 0x0400F902 RID: 63746
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F903 RID: 63747
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B8C RID: 39820
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __IsEnable_FunctionParams
		{
			// Token: 0x040311DD RID: 201181
			[FieldOffset(0)]
			public bool Ret;
		}

		// Token: 0x02009B8D RID: 39821
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetPlayerActor_FunctionParams
		{
			// Token: 0x040311DE RID: 201182
			[FieldOffset(0)]
			public IntPtr PlayerActor;
		}

		// Token: 0x02009B8E RID: 39822
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 448)]
		protected ref struct __UpDatePosition_FunctionParams
		{
			// Token: 0x040311DF RID: 201183
			[FieldOffset(0)]
			public FVector2D __Result;
		}

		// Token: 0x02009B8F RID: 39823
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __DrawToCurrentFrame_FunctionParams
		{
			// Token: 0x040311E0 RID: 201184
			[FieldOffset(0)]
			public IntPtr Canvas;

			// Token: 0x040311E1 RID: 201185
			[FieldOffset(8)]
			public byte DrawInfo;
		}

		// Token: 0x02009B90 RID: 39824
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311E2 RID: 201186
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
