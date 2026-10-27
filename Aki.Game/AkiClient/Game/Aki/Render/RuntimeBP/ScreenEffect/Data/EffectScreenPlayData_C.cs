using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x02003AE7 RID: 15079
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/EffectScreenPlayData.EffectScreenPlayData_C")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 369)]
	public class EffectScreenPlayData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A57 RID: 133719 RVA: 0x008D8F68 File Offset: 0x008D7168
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (EffectScreenPlayData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/EffectScreenPlayData.EffectScreenPlayData_C");
			}
			return EffectScreenPlayData_C._ClassPtr;
		}

		// Token: 0x06020A58 RID: 133720 RVA: 0x008D8F8C File Offset: 0x008D718C
		public EffectScreenPlayData_C() : this(BuiltinUtils.AllocNativeUObject(EffectScreenPlayData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A59 RID: 133721 RVA: 0x008D8FB4 File Offset: 0x008D71B4
		public EffectScreenPlayData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScreenPlayData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x06020A5A RID: 133722 RVA: 0x008D8FE7 File Offset: 0x008D71E7
		// (set) Token: 0x06020A5B RID: 133723 RVA: 0x008D8FF7 File Offset: 0x008D71F7
		public unsafe float Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x06020A5C RID: 133724 RVA: 0x008D9008 File Offset: 0x008D7208
		// (set) Token: 0x06020A5D RID: 133725 RVA: 0x008D9018 File Offset: 0x008D7218
		public unsafe float Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x06020A5E RID: 133726 RVA: 0x008D9029 File Offset: 0x008D7229
		// (set) Token: 0x06020A5F RID: 133727 RVA: 0x008D9039 File Offset: 0x008D7239
		public unsafe float End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x06020A60 RID: 133728 RVA: 0x008D904A File Offset: 0x008D724A
		// (set) Token: 0x06020A61 RID: 133729 RVA: 0x008D905E File Offset: 0x008D725E
		[Nullable(0)]
		public unsafe TEnumAsByte<E_SE_PlayOrder> PlayOrderType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x06020A62 RID: 133730 RVA: 0x008D9073 File Offset: 0x008D7273
		// (set) Token: 0x06020A63 RID: 133731 RVA: 0x008D9087 File Offset: 0x008D7287
		[Nullable(2)]
		public unsafe UPrefabAsset LGUIPrefab
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrefabAsset>(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x06020A64 RID: 133732 RVA: 0x008D909C File Offset: 0x008D729C
		// (set) Token: 0x06020A65 RID: 133733 RVA: 0x008D90AC File Offset: 0x008D72AC
		public unsafe bool bStopByCall
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x06020A66 RID: 133734 RVA: 0x008D90BD File Offset: 0x008D72BD
		// (set) Token: 0x06020A67 RID: 133735 RVA: 0x008D90CD File Offset: 0x008D72CD
		public unsafe bool bNormalizeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x06020A68 RID: 133736 RVA: 0x008D90DE File Offset: 0x008D72DE
		// (set) Token: 0x06020A69 RID: 133737 RVA: 0x008D90EE File Offset: 0x008D72EE
		public unsafe int Order
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x06020A6A RID: 133738 RVA: 0x008D90FF File Offset: 0x008D72FF
		// (set) Token: 0x06020A6B RID: 133739 RVA: 0x008D910F File Offset: 0x008D730F
		public unsafe float fadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x06020A6C RID: 133740 RVA: 0x008D9120 File Offset: 0x008D7320
		// (set) Token: 0x06020A6D RID: 133741 RVA: 0x008D9130 File Offset: 0x008D7330
		public unsafe bool OverrideFadeOutSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x06020A6E RID: 133742 RVA: 0x008D9141 File Offset: 0x008D7341
		// (set) Token: 0x06020A6F RID: 133743 RVA: 0x008D9151 File Offset: 0x008D7351
		public unsafe float fadeOutSpeedOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x06020A70 RID: 133744 RVA: 0x008D9162 File Offset: 0x008D7362
		// (set) Token: 0x06020A71 RID: 133745 RVA: 0x008D9172 File Offset: 0x008D7372
		public unsafe bool bUsedForSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x06020A72 RID: 133746 RVA: 0x008D9183 File Offset: 0x008D7383
		// (set) Token: 0x06020A73 RID: 133747 RVA: 0x008D9197 File Offset: 0x008D7397
		[Nullable(0)]
		public unsafe TEnumAsByte<E_SE_RootType> RootType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_12);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x06020A74 RID: 133748 RVA: 0x008D91AC File Offset: 0x008D73AC
		// (set) Token: 0x06020A75 RID: 133749 RVA: 0x008D91BC File Offset: 0x008D73BC
		public unsafe bool bAutoDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x06020A76 RID: 133750 RVA: 0x008D91CD File Offset: 0x008D73CD
		// (set) Token: 0x06020A77 RID: 133751 RVA: 0x008D91DD File Offset: 0x008D73DD
		public unsafe bool bUseAudio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x06020A78 RID: 133752 RVA: 0x008D91EE File Offset: 0x008D73EE
		// (set) Token: 0x06020A79 RID: 133753 RVA: 0x008D9202 File Offset: 0x008D7402
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_15);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x06020A7A RID: 133754 RVA: 0x008D9217 File Offset: 0x008D7417
		// (set) Token: 0x06020A7B RID: 133755 RVA: 0x008D922B File Offset: 0x008D742B
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEventEnd
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x06020A7C RID: 133756 RVA: 0x008D9240 File Offset: 0x008D7440
		// (set) Token: 0x06020A7D RID: 133757 RVA: 0x008D9250 File Offset: 0x008D7450
		public unsafe float AudioEventEndDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x06020A7E RID: 133758 RVA: 0x008D9261 File Offset: 0x008D7461
		// (set) Token: 0x06020A7F RID: 133759 RVA: 0x008D9275 File Offset: 0x008D7475
		public unsafe string ConsoleCommandOnBegin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_18)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_18)), value);
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x06020A80 RID: 133760 RVA: 0x008D928A File Offset: 0x008D748A
		// (set) Token: 0x06020A81 RID: 133761 RVA: 0x008D929E File Offset: 0x008D749E
		public unsafe string ConsoleCommandOnEnd
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_19)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_19)), value);
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x06020A82 RID: 133762 RVA: 0x008D92B4 File Offset: 0x008D74B4
		// (set) Token: 0x06020A83 RID: 133763 RVA: 0x008D92ED File Offset: 0x008D74ED
		public TMap<string, FKuroCurveLinearColor> LinearColorParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroCurveLinearColor> result;
				if ((result = this._LinearColorParameter) == null)
				{
					result = (this._LinearColorParameter = new TMap<string, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.LinearColorParameter.CopyAssign(value);
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x06020A84 RID: 133764 RVA: 0x008D92FC File Offset: 0x008D74FC
		// (set) Token: 0x06020A85 RID: 133765 RVA: 0x008D9335 File Offset: 0x008D7535
		public TMap<string, FKuroCurveFloat> FloatParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroCurveFloat> result;
				if ((result = this._FloatParameter) == null)
				{
					result = (this._FloatParameter = new TMap<string, FKuroCurveFloat>(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				this.FloatParameter.CopyAssign(value);
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x06020A86 RID: 133766 RVA: 0x008D9343 File Offset: 0x008D7543
		// (set) Token: 0x06020A87 RID: 133767 RVA: 0x008D9353 File Offset: 0x008D7553
		public unsafe float EffectTweenSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x06020A88 RID: 133768 RVA: 0x008D9364 File Offset: 0x008D7564
		// (set) Token: 0x06020A89 RID: 133769 RVA: 0x008D939D File Offset: 0x008D759D
		public TArray<SScreenEffectExtraState> ExtraStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SScreenEffectExtraState> result;
				if ((result = this._ExtraStates) == null)
				{
					result = (this._ExtraStates = new TArray<SScreenEffectExtraState>(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				this.ExtraStates.CopyAssign(value);
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x06020A8A RID: 133770 RVA: 0x008D93AB File Offset: 0x008D75AB
		// (set) Token: 0x06020A8B RID: 133771 RVA: 0x008D93BB File Offset: 0x008D75BB
		public unsafe bool bStartLoopEndByCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020A8C RID: 133772 RVA: 0x008D93CC File Offset: 0x008D75CC
		protected EffectScreenPlayData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD64 RID: 64868
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/EffectScreenPlayData.EffectScreenPlayData_C";

		// Token: 0x0400FD65 RID: 64869
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD66 RID: 64870
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD67 RID: 64871
		internal static int __PropertyOffset_0;

		// Token: 0x0400FD68 RID: 64872
		internal static int __PropertyOffset_1;

		// Token: 0x0400FD69 RID: 64873
		internal static int __PropertyOffset_2;

		// Token: 0x0400FD6A RID: 64874
		internal static int __PropertyOffset_3;

		// Token: 0x0400FD6B RID: 64875
		internal static int __PropertyOffset_4;

		// Token: 0x0400FD6C RID: 64876
		internal static int __PropertyOffset_5;

		// Token: 0x0400FD6D RID: 64877
		internal static int __PropertyOffset_6;

		// Token: 0x0400FD6E RID: 64878
		internal static int __PropertyOffset_7;

		// Token: 0x0400FD6F RID: 64879
		internal static int __PropertyOffset_8;

		// Token: 0x0400FD70 RID: 64880
		internal static int __PropertyOffset_9;

		// Token: 0x0400FD71 RID: 64881
		internal static int __PropertyOffset_10;

		// Token: 0x0400FD72 RID: 64882
		internal static int __PropertyOffset_11;

		// Token: 0x0400FD73 RID: 64883
		internal static int __PropertyOffset_12;

		// Token: 0x0400FD74 RID: 64884
		internal static int __PropertyOffset_13;

		// Token: 0x0400FD75 RID: 64885
		internal static int __PropertyOffset_14;

		// Token: 0x0400FD76 RID: 64886
		internal static int __PropertyOffset_15;

		// Token: 0x0400FD77 RID: 64887
		internal static int __PropertyOffset_16;

		// Token: 0x0400FD78 RID: 64888
		internal static int __PropertyOffset_17;

		// Token: 0x0400FD79 RID: 64889
		internal static int __PropertyOffset_18;

		// Token: 0x0400FD7A RID: 64890
		internal static int __PropertyOffset_19;

		// Token: 0x0400FD7B RID: 64891
		internal static int __PropertyOffset_20;

		// Token: 0x0400FD7C RID: 64892
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveLinearColor> _LinearColorParameter;

		// Token: 0x0400FD7D RID: 64893
		internal static int __PropertyOffset_21;

		// Token: 0x0400FD7E RID: 64894
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveFloat> _FloatParameter;

		// Token: 0x0400FD7F RID: 64895
		internal static int __PropertyOffset_22;

		// Token: 0x0400FD80 RID: 64896
		internal static int __PropertyOffset_23;

		// Token: 0x0400FD81 RID: 64897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SScreenEffectExtraState> _ExtraStates;

		// Token: 0x0400FD82 RID: 64898
		internal static int __PropertyOffset_24;
	}
}
