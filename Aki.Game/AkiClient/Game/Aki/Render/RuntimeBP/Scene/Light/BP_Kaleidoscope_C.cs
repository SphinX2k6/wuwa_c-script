using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B07 RID: 15111
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Kaleidoscope.BP_Kaleidoscope_C")]
	[UnrealStructLayout(1976, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1972)]
	public class BP_Kaleidoscope_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020DDD RID: 134621 RVA: 0x008DF224 File Offset: 0x008DD424
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Kaleidoscope_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Kaleidoscope.BP_Kaleidoscope_C");
			}
			return BP_Kaleidoscope_C._ClassPtr;
		}

		// Token: 0x06020DDE RID: 134622 RVA: 0x008DF248 File Offset: 0x008DD448
		public BP_Kaleidoscope_C() : this(BuiltinUtils.AllocNativeUObject(BP_Kaleidoscope_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020DDF RID: 134623 RVA: 0x008DF270 File Offset: 0x008DD470
		[NullableContext(1)]
		public BP_Kaleidoscope_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Kaleidoscope_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x06020DE0 RID: 134624 RVA: 0x008DF2A3 File Offset: 0x008DD4A3
		// (set) Token: 0x06020DE1 RID: 134625 RVA: 0x008DF2B7 File Offset: 0x008DD4B7
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x06020DE2 RID: 134626 RVA: 0x008DF2CC File Offset: 0x008DD4CC
		// (set) Token: 0x06020DE3 RID: 134627 RVA: 0x008DF2E0 File Offset: 0x008DD4E0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x06020DE4 RID: 134628 RVA: 0x008DF2F5 File Offset: 0x008DD4F5
		// (set) Token: 0x06020DE5 RID: 134629 RVA: 0x008DF309 File Offset: 0x008DD509
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x06020DE6 RID: 134630 RVA: 0x008DF320 File Offset: 0x008DD520
		// (set) Token: 0x06020DE7 RID: 134631 RVA: 0x008DF359 File Offset: 0x008DD559
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x06020DE8 RID: 134632 RVA: 0x008DF368 File Offset: 0x008DD568
		// (set) Token: 0x06020DE9 RID: 134633 RVA: 0x008DF3A1 File Offset: 0x008DD5A1
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x06020DEA RID: 134634 RVA: 0x008DF3B0 File Offset: 0x008DD5B0
		// (set) Token: 0x06020DEB RID: 134635 RVA: 0x008DF3E9 File Offset: 0x008DD5E9
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x06020DEC RID: 134636 RVA: 0x008DF3F7 File Offset: 0x008DD5F7
		// (set) Token: 0x06020DED RID: 134637 RVA: 0x008DF407 File Offset: 0x008DD607
		public unsafe float Distance0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x06020DEE RID: 134638 RVA: 0x008DF418 File Offset: 0x008DD618
		// (set) Token: 0x06020DEF RID: 134639 RVA: 0x008DF42C File Offset: 0x008DD62C
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x06020DF0 RID: 134640 RVA: 0x008DF441 File Offset: 0x008DD641
		// (set) Token: 0x06020DF1 RID: 134641 RVA: 0x008DF451 File Offset: 0x008DD651
		public unsafe float HollowRadius0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x06020DF2 RID: 134642 RVA: 0x008DF462 File Offset: 0x008DD662
		// (set) Token: 0x06020DF3 RID: 134643 RVA: 0x008DF472 File Offset: 0x008DD672
		public unsafe float Rotation0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x06020DF4 RID: 134644 RVA: 0x008DF483 File Offset: 0x008DD683
		// (set) Token: 0x06020DF5 RID: 134645 RVA: 0x008DF493 File Offset: 0x008DD693
		public unsafe float Segment0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x06020DF6 RID: 134646 RVA: 0x008DF4A4 File Offset: 0x008DD6A4
		// (set) Token: 0x06020DF7 RID: 134647 RVA: 0x008DF4B8 File Offset: 0x008DD6B8
		public unsafe UTexture2D Texture0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x06020DF8 RID: 134648 RVA: 0x008DF4CD File Offset: 0x008DD6CD
		// (set) Token: 0x06020DF9 RID: 134649 RVA: 0x008DF4DD File Offset: 0x008DD6DD
		public unsafe float Twist0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x06020DFA RID: 134650 RVA: 0x008DF4EE File Offset: 0x008DD6EE
		// (set) Token: 0x06020DFB RID: 134651 RVA: 0x008DF4FE File Offset: 0x008DD6FE
		public unsafe float Distance1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x06020DFC RID: 134652 RVA: 0x008DF50F File Offset: 0x008DD70F
		// (set) Token: 0x06020DFD RID: 134653 RVA: 0x008DF51F File Offset: 0x008DD71F
		public unsafe float HollowRadius1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x06020DFE RID: 134654 RVA: 0x008DF530 File Offset: 0x008DD730
		// (set) Token: 0x06020DFF RID: 134655 RVA: 0x008DF540 File Offset: 0x008DD740
		public unsafe float Rotation1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x06020E00 RID: 134656 RVA: 0x008DF551 File Offset: 0x008DD751
		// (set) Token: 0x06020E01 RID: 134657 RVA: 0x008DF561 File Offset: 0x008DD761
		public unsafe float Segment1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x06020E02 RID: 134658 RVA: 0x008DF572 File Offset: 0x008DD772
		// (set) Token: 0x06020E03 RID: 134659 RVA: 0x008DF586 File Offset: 0x008DD786
		public unsafe UTexture2D Texture1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x06020E04 RID: 134660 RVA: 0x008DF59B File Offset: 0x008DD79B
		// (set) Token: 0x06020E05 RID: 134661 RVA: 0x008DF5AB File Offset: 0x008DD7AB
		public unsafe float Twist1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x06020E06 RID: 134662 RVA: 0x008DF5BC File Offset: 0x008DD7BC
		// (set) Token: 0x06020E07 RID: 134663 RVA: 0x008DF5CC File Offset: 0x008DD7CC
		public unsafe float Distance2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x06020E08 RID: 134664 RVA: 0x008DF5DD File Offset: 0x008DD7DD
		// (set) Token: 0x06020E09 RID: 134665 RVA: 0x008DF5ED File Offset: 0x008DD7ED
		public unsafe float HollowRadius2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x06020E0A RID: 134666 RVA: 0x008DF5FE File Offset: 0x008DD7FE
		// (set) Token: 0x06020E0B RID: 134667 RVA: 0x008DF60E File Offset: 0x008DD80E
		public unsafe float Rotation2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x06020E0C RID: 134668 RVA: 0x008DF61F File Offset: 0x008DD81F
		// (set) Token: 0x06020E0D RID: 134669 RVA: 0x008DF62F File Offset: 0x008DD82F
		public unsafe float Segment2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x06020E0E RID: 134670 RVA: 0x008DF640 File Offset: 0x008DD840
		// (set) Token: 0x06020E0F RID: 134671 RVA: 0x008DF654 File Offset: 0x008DD854
		public unsafe UTexture2D Texture2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x06020E10 RID: 134672 RVA: 0x008DF669 File Offset: 0x008DD869
		// (set) Token: 0x06020E11 RID: 134673 RVA: 0x008DF679 File Offset: 0x008DD879
		public unsafe float Twist2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x06020E12 RID: 134674 RVA: 0x008DF68A File Offset: 0x008DD88A
		// (set) Token: 0x06020E13 RID: 134675 RVA: 0x008DF69A File Offset: 0x008DD89A
		public unsafe float CenterOffsetX0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x06020E14 RID: 134676 RVA: 0x008DF6AB File Offset: 0x008DD8AB
		// (set) Token: 0x06020E15 RID: 134677 RVA: 0x008DF6BB File Offset: 0x008DD8BB
		public unsafe float CenterOffsetY0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x06020E16 RID: 134678 RVA: 0x008DF6CC File Offset: 0x008DD8CC
		// (set) Token: 0x06020E17 RID: 134679 RVA: 0x008DF6DC File Offset: 0x008DD8DC
		public unsafe float CenterOffsetX1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x06020E18 RID: 134680 RVA: 0x008DF6ED File Offset: 0x008DD8ED
		// (set) Token: 0x06020E19 RID: 134681 RVA: 0x008DF6FD File Offset: 0x008DD8FD
		public unsafe float CenterOffsetY1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x06020E1A RID: 134682 RVA: 0x008DF70E File Offset: 0x008DD90E
		// (set) Token: 0x06020E1B RID: 134683 RVA: 0x008DF71E File Offset: 0x008DD91E
		public unsafe float CenterOffsetX2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x06020E1C RID: 134684 RVA: 0x008DF72F File Offset: 0x008DD92F
		// (set) Token: 0x06020E1D RID: 134685 RVA: 0x008DF73F File Offset: 0x008DD93F
		public unsafe float CenterOffsetY2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x06020E1E RID: 134686 RVA: 0x008DF750 File Offset: 0x008DD950
		// (set) Token: 0x06020E1F RID: 134687 RVA: 0x008DF760 File Offset: 0x008DD960
		public unsafe float BlurIntensity0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x06020E20 RID: 134688 RVA: 0x008DF771 File Offset: 0x008DD971
		// (set) Token: 0x06020E21 RID: 134689 RVA: 0x008DF781 File Offset: 0x008DD981
		public unsafe float BlurIntensity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x06020E22 RID: 134690 RVA: 0x008DF792 File Offset: 0x008DD992
		// (set) Token: 0x06020E23 RID: 134691 RVA: 0x008DF7A2 File Offset: 0x008DD9A2
		public unsafe float BlurIntensity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x06020E24 RID: 134692 RVA: 0x008DF7B3 File Offset: 0x008DD9B3
		// (set) Token: 0x06020E25 RID: 134693 RVA: 0x008DF7C3 File Offset: 0x008DD9C3
		public unsafe float Distance3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x06020E26 RID: 134694 RVA: 0x008DF7D4 File Offset: 0x008DD9D4
		// (set) Token: 0x06020E27 RID: 134695 RVA: 0x008DF7E4 File Offset: 0x008DD9E4
		public unsafe float HollowRadius3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x06020E28 RID: 134696 RVA: 0x008DF7F5 File Offset: 0x008DD9F5
		// (set) Token: 0x06020E29 RID: 134697 RVA: 0x008DF805 File Offset: 0x008DDA05
		public unsafe float Rotation3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x06020E2A RID: 134698 RVA: 0x008DF816 File Offset: 0x008DDA16
		// (set) Token: 0x06020E2B RID: 134699 RVA: 0x008DF826 File Offset: 0x008DDA26
		public unsafe float Segment3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x06020E2C RID: 134700 RVA: 0x008DF837 File Offset: 0x008DDA37
		// (set) Token: 0x06020E2D RID: 134701 RVA: 0x008DF84B File Offset: 0x008DDA4B
		public unsafe UTexture2D Texture3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_39);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Kaleidoscope_C.__PropertyOffset_39, value);
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x06020E2E RID: 134702 RVA: 0x008DF860 File Offset: 0x008DDA60
		// (set) Token: 0x06020E2F RID: 134703 RVA: 0x008DF870 File Offset: 0x008DDA70
		public unsafe float Twist3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x06020E30 RID: 134704 RVA: 0x008DF881 File Offset: 0x008DDA81
		// (set) Token: 0x06020E31 RID: 134705 RVA: 0x008DF891 File Offset: 0x008DDA91
		public unsafe float CenterOffsetX3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x06020E32 RID: 134706 RVA: 0x008DF8A2 File Offset: 0x008DDAA2
		// (set) Token: 0x06020E33 RID: 134707 RVA: 0x008DF8B2 File Offset: 0x008DDAB2
		public unsafe float CenterOffsetY3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x06020E34 RID: 134708 RVA: 0x008DF8C3 File Offset: 0x008DDAC3
		// (set) Token: 0x06020E35 RID: 134709 RVA: 0x008DF8D3 File Offset: 0x008DDAD3
		public unsafe float BlurIntensity3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x06020E36 RID: 134710 RVA: 0x008DF8E4 File Offset: 0x008DDAE4
		// (set) Token: 0x06020E37 RID: 134711 RVA: 0x008DF8F8 File Offset: 0x008DDAF8
		public unsafe FLinearColor ColorAdj
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x06020E38 RID: 134712 RVA: 0x008DF90D File Offset: 0x008DDB0D
		// (set) Token: 0x06020E39 RID: 134713 RVA: 0x008DF91D File Offset: 0x008DDB1D
		public unsafe bool BottomModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x06020E3A RID: 134714 RVA: 0x008DF92E File Offset: 0x008DDB2E
		// (set) Token: 0x06020E3B RID: 134715 RVA: 0x008DF93E File Offset: 0x008DDB3E
		public unsafe bool TopModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x06020E3C RID: 134716 RVA: 0x008DF94F File Offset: 0x008DDB4F
		// (set) Token: 0x06020E3D RID: 134717 RVA: 0x008DF963 File Offset: 0x008DDB63
		[Nullable(1)]
		public unsafe string DYName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_Kaleidoscope_C.__PropertyOffset_47)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_Kaleidoscope_C.__PropertyOffset_47)), value);
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x06020E3E RID: 134718 RVA: 0x008DF978 File Offset: 0x008DDB78
		// (set) Token: 0x06020E3F RID: 134719 RVA: 0x008DF988 File Offset: 0x008DDB88
		public unsafe float EdgeSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x06020E40 RID: 134720 RVA: 0x008DF999 File Offset: 0x008DDB99
		// (set) Token: 0x06020E41 RID: 134721 RVA: 0x008DF9A9 File Offset: 0x008DDBA9
		public unsafe float Opacity0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x06020E42 RID: 134722 RVA: 0x008DF9BA File Offset: 0x008DDBBA
		// (set) Token: 0x06020E43 RID: 134723 RVA: 0x008DF9CA File Offset: 0x008DDBCA
		public unsafe float Opacity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x06020E44 RID: 134724 RVA: 0x008DF9DB File Offset: 0x008DDBDB
		// (set) Token: 0x06020E45 RID: 134725 RVA: 0x008DF9EB File Offset: 0x008DDBEB
		public unsafe float Opacity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x06020E46 RID: 134726 RVA: 0x008DF9FC File Offset: 0x008DDBFC
		// (set) Token: 0x06020E47 RID: 134727 RVA: 0x008DFA0C File Offset: 0x008DDC0C
		public unsafe float Opacity3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x06020E48 RID: 134728 RVA: 0x008DFA1D File Offset: 0x008DDC1D
		// (set) Token: 0x06020E49 RID: 134729 RVA: 0x008DFA2D File Offset: 0x008DDC2D
		public unsafe float FadeVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x06020E4A RID: 134730 RVA: 0x008DFA3E File Offset: 0x008DDC3E
		// (set) Token: 0x06020E4B RID: 134731 RVA: 0x008DFA4E File Offset: 0x008DDC4E
		public unsafe float FadeSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Kaleidoscope_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x06020E4C RID: 134732 RVA: 0x008DFA60 File Offset: 0x008DDC60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialToPost(UObject Object)
		{
			BP_Kaleidoscope_C.__SetMaterialToPost_FunctionParams* ptr = stackalloc BP_Kaleidoscope_C.__SetMaterialToPost_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_Kaleidoscope_C.__SetMaterialToPost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_C.__SetMaterialToPost_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_C.__SetMaterialToPost_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E4D RID: 134733 RVA: 0x008DFAB5 File Offset: 0x008DDCB5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Parameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_C.__Set_Parameter_NativeFunctionPtr, null);
		}

		// Token: 0x06020E4E RID: 134734 RVA: 0x008DFAC9 File Offset: 0x008DDCC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020E4F RID: 134735 RVA: 0x008DFADD File Offset: 0x008DDCDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020E50 RID: 134736 RVA: 0x008DFAF2 File Offset: 0x008DDCF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020E51 RID: 134737 RVA: 0x008DFB06 File Offset: 0x008DDD06
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020E52 RID: 134738 RVA: 0x008DFB1C File Offset: 0x008DDD1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Kaleidoscope_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E53 RID: 134739 RVA: 0x008DFB64 File Offset: 0x008DDD64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Kaleidoscope_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020E54 RID: 134740 RVA: 0x008DFBAB File Offset: 0x008DDDAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020E55 RID: 134741 RVA: 0x008DFBBF File Offset: 0x008DDDBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020E56 RID: 134742 RVA: 0x008DFBD4 File Offset: 0x008DDDD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Kaleidoscope_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Kaleidoscope_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E57 RID: 134743 RVA: 0x008DFC1C File Offset: 0x008DDE1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Kaleidoscope_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Kaleidoscope_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Kaleidoscope_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Kaleidoscope_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Kaleidoscope_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020E58 RID: 134744 RVA: 0x008DFC63 File Offset: 0x008DDE63
		protected BP_Kaleidoscope_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF89 RID: 65417
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_Kaleidoscope.BP_Kaleidoscope_C";

		// Token: 0x0400FF8A RID: 65418
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF8B RID: 65419
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF8C RID: 65420
		internal static int __PropertyOffset_1;

		// Token: 0x0400FF8D RID: 65421
		internal static int __PropertyOffset_2;

		// Token: 0x0400FF8E RID: 65422
		internal static int __PropertyOffset_3;

		// Token: 0x0400FF8F RID: 65423
		internal static int __PropertyOffset_4;

		// Token: 0x0400FF90 RID: 65424
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FF91 RID: 65425
		internal static int __PropertyOffset_5;

		// Token: 0x0400FF92 RID: 65426
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FF93 RID: 65427
		internal static int __PropertyOffset_6;

		// Token: 0x0400FF94 RID: 65428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FF95 RID: 65429
		internal static int __PropertyOffset_7;

		// Token: 0x0400FF96 RID: 65430
		internal static int __PropertyOffset_8;

		// Token: 0x0400FF97 RID: 65431
		internal static int __PropertyOffset_9;

		// Token: 0x0400FF98 RID: 65432
		internal static int __PropertyOffset_10;

		// Token: 0x0400FF99 RID: 65433
		internal static int __PropertyOffset_11;

		// Token: 0x0400FF9A RID: 65434
		internal static int __PropertyOffset_12;

		// Token: 0x0400FF9B RID: 65435
		internal static int __PropertyOffset_13;

		// Token: 0x0400FF9C RID: 65436
		internal static int __PropertyOffset_14;

		// Token: 0x0400FF9D RID: 65437
		internal static int __PropertyOffset_15;

		// Token: 0x0400FF9E RID: 65438
		internal static int __PropertyOffset_16;

		// Token: 0x0400FF9F RID: 65439
		internal static int __PropertyOffset_17;

		// Token: 0x0400FFA0 RID: 65440
		internal static int __PropertyOffset_18;

		// Token: 0x0400FFA1 RID: 65441
		internal static int __PropertyOffset_19;

		// Token: 0x0400FFA2 RID: 65442
		internal static int __PropertyOffset_20;

		// Token: 0x0400FFA3 RID: 65443
		internal static int __PropertyOffset_21;

		// Token: 0x0400FFA4 RID: 65444
		internal static int __PropertyOffset_22;

		// Token: 0x0400FFA5 RID: 65445
		internal static int __PropertyOffset_23;

		// Token: 0x0400FFA6 RID: 65446
		internal static int __PropertyOffset_24;

		// Token: 0x0400FFA7 RID: 65447
		internal static int __PropertyOffset_25;

		// Token: 0x0400FFA8 RID: 65448
		internal static int __PropertyOffset_26;

		// Token: 0x0400FFA9 RID: 65449
		internal static int __PropertyOffset_27;

		// Token: 0x0400FFAA RID: 65450
		internal static int __PropertyOffset_28;

		// Token: 0x0400FFAB RID: 65451
		internal static int __PropertyOffset_29;

		// Token: 0x0400FFAC RID: 65452
		internal static int __PropertyOffset_30;

		// Token: 0x0400FFAD RID: 65453
		internal static int __PropertyOffset_31;

		// Token: 0x0400FFAE RID: 65454
		internal static int __PropertyOffset_32;

		// Token: 0x0400FFAF RID: 65455
		internal static int __PropertyOffset_33;

		// Token: 0x0400FFB0 RID: 65456
		internal static int __PropertyOffset_34;

		// Token: 0x0400FFB1 RID: 65457
		internal static int __PropertyOffset_35;

		// Token: 0x0400FFB2 RID: 65458
		internal static int __PropertyOffset_36;

		// Token: 0x0400FFB3 RID: 65459
		internal static int __PropertyOffset_37;

		// Token: 0x0400FFB4 RID: 65460
		internal static int __PropertyOffset_38;

		// Token: 0x0400FFB5 RID: 65461
		internal static int __PropertyOffset_39;

		// Token: 0x0400FFB6 RID: 65462
		internal static int __PropertyOffset_40;

		// Token: 0x0400FFB7 RID: 65463
		internal static int __PropertyOffset_41;

		// Token: 0x0400FFB8 RID: 65464
		internal static int __PropertyOffset_42;

		// Token: 0x0400FFB9 RID: 65465
		internal static int __PropertyOffset_43;

		// Token: 0x0400FFBA RID: 65466
		internal static int __PropertyOffset_44;

		// Token: 0x0400FFBB RID: 65467
		internal static int __PropertyOffset_45;

		// Token: 0x0400FFBC RID: 65468
		internal static int __PropertyOffset_46;

		// Token: 0x0400FFBD RID: 65469
		internal static int __PropertyOffset_47;

		// Token: 0x0400FFBE RID: 65470
		internal static int __PropertyOffset_48;

		// Token: 0x0400FFBF RID: 65471
		internal static int __PropertyOffset_49;

		// Token: 0x0400FFC0 RID: 65472
		internal static int __PropertyOffset_50;

		// Token: 0x0400FFC1 RID: 65473
		internal static int __PropertyOffset_51;

		// Token: 0x0400FFC2 RID: 65474
		internal static int __PropertyOffset_52;

		// Token: 0x0400FFC3 RID: 65475
		internal static int __PropertyOffset_53;

		// Token: 0x0400FFC4 RID: 65476
		internal static int __PropertyOffset_54;

		// Token: 0x0400FFC5 RID: 65477
		private static IntPtr __SetMaterialToPost_NativeFunctionPtr;

		// Token: 0x0400FFC6 RID: 65478
		private static IntPtr __Set_Parameter_NativeFunctionPtr;

		// Token: 0x0400FFC7 RID: 65479
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FFC8 RID: 65480
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FFC9 RID: 65481
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FFCA RID: 65482
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FFCB RID: 65483
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C48 RID: 40008
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetMaterialToPost_FunctionParams
		{
			// Token: 0x040312FC RID: 201468
			[FieldOffset(0)]
			public IntPtr Object;
		}

		// Token: 0x02009C49 RID: 40009
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312FD RID: 201469
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C4A RID: 40010
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312FE RID: 201470
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
