using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data
{
	// Token: 0x020030B1 RID: 12465
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/EffectScreenPlayData.EffectScreenPlayData_C")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 369)]
	public class EffectScreenPlayData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEF9 RID: 122617 RVA: 0x009067C3 File Offset: 0x009049C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (EffectScreenPlayData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/EffectScreenPlayData.EffectScreenPlayData_C");
			}
			return EffectScreenPlayData_C._ClassPtr;
		}

		// Token: 0x0601DEFA RID: 122618 RVA: 0x009067E8 File Offset: 0x009049E8
		public EffectScreenPlayData_C() : this(BuiltinUtils.AllocNativeUObject(EffectScreenPlayData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DEFB RID: 122619 RVA: 0x00906810 File Offset: 0x00904A10
		public EffectScreenPlayData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectScreenPlayData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0601DEFC RID: 122620 RVA: 0x00906843 File Offset: 0x00904A43
		// (set) Token: 0x0601DEFD RID: 122621 RVA: 0x00906853 File Offset: 0x00904A53
		public unsafe float Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0601DEFE RID: 122622 RVA: 0x00906864 File Offset: 0x00904A64
		// (set) Token: 0x0601DEFF RID: 122623 RVA: 0x00906874 File Offset: 0x00904A74
		public unsafe float Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_Loop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_Loop) = value;
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0601DF00 RID: 122624 RVA: 0x00906885 File Offset: 0x00904A85
		// (set) Token: 0x0601DF01 RID: 122625 RVA: 0x00906895 File Offset: 0x00904A95
		public unsafe float End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0601DF02 RID: 122626 RVA: 0x009068A6 File Offset: 0x00904AA6
		// (set) Token: 0x0601DF03 RID: 122627 RVA: 0x009068BA File Offset: 0x00904ABA
		[Nullable(2)]
		public unsafe UPrefabAsset LGUIPrefab
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrefabAsset>(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_LGUIPrefab);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_LGUIPrefab, value);
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0601DF04 RID: 122628 RVA: 0x009068CF File Offset: 0x00904ACF
		// (set) Token: 0x0601DF05 RID: 122629 RVA: 0x009068DF File Offset: 0x00904ADF
		public unsafe bool bStopByCall
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bStopByCall) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bStopByCall) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0601DF06 RID: 122630 RVA: 0x009068F0 File Offset: 0x00904AF0
		// (set) Token: 0x0601DF07 RID: 122631 RVA: 0x00906900 File Offset: 0x00904B00
		public unsafe bool bNormalizeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bNormalizeTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bNormalizeTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0601DF08 RID: 122632 RVA: 0x00906911 File Offset: 0x00904B11
		// (set) Token: 0x0601DF09 RID: 122633 RVA: 0x00906921 File Offset: 0x00904B21
		public unsafe int Order
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_Order);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_Order) = value;
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0601DF0A RID: 122634 RVA: 0x00906932 File Offset: 0x00904B32
		// (set) Token: 0x0601DF0B RID: 122635 RVA: 0x00906942 File Offset: 0x00904B42
		public unsafe float fadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_fadeSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_fadeSpeed) = value;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0601DF0C RID: 122636 RVA: 0x00906953 File Offset: 0x00904B53
		// (set) Token: 0x0601DF0D RID: 122637 RVA: 0x00906963 File Offset: 0x00904B63
		public unsafe bool OverrideFadeOutSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_OverrideFadeOutSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_OverrideFadeOutSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0601DF0E RID: 122638 RVA: 0x00906974 File Offset: 0x00904B74
		// (set) Token: 0x0601DF0F RID: 122639 RVA: 0x00906984 File Offset: 0x00904B84
		public unsafe float fadeOutSpeedOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_fadeOutSpeedOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_fadeOutSpeedOverride) = value;
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0601DF10 RID: 122640 RVA: 0x00906995 File Offset: 0x00904B95
		// (set) Token: 0x0601DF11 RID: 122641 RVA: 0x009069A5 File Offset: 0x00904BA5
		public unsafe bool bUsedForSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bUsedForSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bUsedForSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0601DF12 RID: 122642 RVA: 0x009069B6 File Offset: 0x00904BB6
		// (set) Token: 0x0601DF13 RID: 122643 RVA: 0x009069CA File Offset: 0x00904BCA
		[Nullable(0)]
		public unsafe TEnumAsByte<E_SE_RootType> RootType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_RootType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_RootType) = value;
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0601DF14 RID: 122644 RVA: 0x009069DF File Offset: 0x00904BDF
		// (set) Token: 0x0601DF15 RID: 122645 RVA: 0x009069EF File Offset: 0x00904BEF
		public unsafe bool bAutoDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bAutoDestroy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bAutoDestroy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0601DF16 RID: 122646 RVA: 0x00906A00 File Offset: 0x00904C00
		// (set) Token: 0x0601DF17 RID: 122647 RVA: 0x00906A10 File Offset: 0x00904C10
		public unsafe bool bUseAudio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bUseAudio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bUseAudio) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0601DF18 RID: 122648 RVA: 0x00906A21 File Offset: 0x00904C21
		// (set) Token: 0x0601DF19 RID: 122649 RVA: 0x00906A35 File Offset: 0x00904C35
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_AudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_AudioEvent, value);
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0601DF1A RID: 122650 RVA: 0x00906A4A File Offset: 0x00904C4A
		// (set) Token: 0x0601DF1B RID: 122651 RVA: 0x00906A5E File Offset: 0x00904C5E
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEventEnd
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_AudioEventEnd);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + EffectScreenPlayData_C.__PropertyOffset_AudioEventEnd, value);
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0601DF1C RID: 122652 RVA: 0x00906A73 File Offset: 0x00904C73
		// (set) Token: 0x0601DF1D RID: 122653 RVA: 0x00906A83 File Offset: 0x00904C83
		public unsafe float AudioEventEndDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_AudioEventEndDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_AudioEventEndDelay) = value;
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0601DF1E RID: 122654 RVA: 0x00906A94 File Offset: 0x00904C94
		// (set) Token: 0x0601DF1F RID: 122655 RVA: 0x00906AA8 File Offset: 0x00904CA8
		public unsafe string ConsoleCommandOnBegin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_ConsoleCommandOnBegin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_ConsoleCommandOnBegin)), value);
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0601DF20 RID: 122656 RVA: 0x00906ABD File Offset: 0x00904CBD
		// (set) Token: 0x0601DF21 RID: 122657 RVA: 0x00906AD1 File Offset: 0x00904CD1
		public unsafe string ConsoleCommandOnEnd
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_ConsoleCommandOnEnd)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)EffectScreenPlayData_C.__PropertyOffset_ConsoleCommandOnEnd)), value);
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0601DF22 RID: 122658 RVA: 0x00906AE8 File Offset: 0x00904CE8
		// (set) Token: 0x0601DF23 RID: 122659 RVA: 0x00906B21 File Offset: 0x00904D21
		public TMap<string, FKuroCurveLinearColor> LinearColorParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroCurveLinearColor> result;
				if ((result = this._LinearColorParameter) == null)
				{
					result = (this._LinearColorParameter = new TMap<string, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_LinearColorParameter, this));
				}
				return result;
			}
			set
			{
				this.LinearColorParameter.CopyAssign(value);
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0601DF24 RID: 122660 RVA: 0x00906B30 File Offset: 0x00904D30
		// (set) Token: 0x0601DF25 RID: 122661 RVA: 0x00906B69 File Offset: 0x00904D69
		public TMap<string, FKuroCurveFloat> FloatParameter
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroCurveFloat> result;
				if ((result = this._FloatParameter) == null)
				{
					result = (this._FloatParameter = new TMap<string, FKuroCurveFloat>(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_FloatParameter, this));
				}
				return result;
			}
			set
			{
				this.FloatParameter.CopyAssign(value);
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0601DF26 RID: 122662 RVA: 0x00906B77 File Offset: 0x00904D77
		// (set) Token: 0x0601DF27 RID: 122663 RVA: 0x00906B87 File Offset: 0x00904D87
		public unsafe float EffectTweenSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_EffectTweenSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_EffectTweenSpeed) = value;
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0601DF28 RID: 122664 RVA: 0x00906B98 File Offset: 0x00904D98
		// (set) Token: 0x0601DF29 RID: 122665 RVA: 0x00906BA8 File Offset: 0x00904DA8
		public unsafe bool bStartLoopEndByCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bStartLoopEndByCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)EffectScreenPlayData_C.__PropertyOffset_bStartLoopEndByCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601DF2A RID: 122666 RVA: 0x00906BB9 File Offset: 0x00904DB9
		protected EffectScreenPlayData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCF8 RID: 64760
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Data/EffectScreenPlayData.EffectScreenPlayData_C";

		// Token: 0x0400FCF9 RID: 64761
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCFA RID: 64762
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCFB RID: 64763
		internal static int __PropertyOffset_Start;

		// Token: 0x0400FCFC RID: 64764
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400FCFD RID: 64765
		internal static int __PropertyOffset_End;

		// Token: 0x0400FCFE RID: 64766
		internal static int __PropertyOffset_LGUIPrefab;

		// Token: 0x0400FCFF RID: 64767
		internal static int __PropertyOffset_bStopByCall;

		// Token: 0x0400FD00 RID: 64768
		internal static int __PropertyOffset_bNormalizeTime;

		// Token: 0x0400FD01 RID: 64769
		internal static int __PropertyOffset_Order;

		// Token: 0x0400FD02 RID: 64770
		internal static int __PropertyOffset_fadeSpeed;

		// Token: 0x0400FD03 RID: 64771
		internal static int __PropertyOffset_OverrideFadeOutSpeed;

		// Token: 0x0400FD04 RID: 64772
		internal static int __PropertyOffset_fadeOutSpeedOverride;

		// Token: 0x0400FD05 RID: 64773
		internal static int __PropertyOffset_bUsedForSequence;

		// Token: 0x0400FD06 RID: 64774
		internal static int __PropertyOffset_RootType;

		// Token: 0x0400FD07 RID: 64775
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x0400FD08 RID: 64776
		internal static int __PropertyOffset_bUseAudio;

		// Token: 0x0400FD09 RID: 64777
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x0400FD0A RID: 64778
		internal static int __PropertyOffset_AudioEventEnd;

		// Token: 0x0400FD0B RID: 64779
		internal static int __PropertyOffset_AudioEventEndDelay;

		// Token: 0x0400FD0C RID: 64780
		internal static int __PropertyOffset_ConsoleCommandOnBegin;

		// Token: 0x0400FD0D RID: 64781
		internal static int __PropertyOffset_ConsoleCommandOnEnd;

		// Token: 0x0400FD0E RID: 64782
		internal static int __PropertyOffset_LinearColorParameter;

		// Token: 0x0400FD0F RID: 64783
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveLinearColor> _LinearColorParameter;

		// Token: 0x0400FD10 RID: 64784
		internal static int __PropertyOffset_FloatParameter;

		// Token: 0x0400FD11 RID: 64785
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroCurveFloat> _FloatParameter;

		// Token: 0x0400FD12 RID: 64786
		internal static int __PropertyOffset_EffectTweenSpeed;

		// Token: 0x0400FD13 RID: 64787
		internal static int __PropertyOffset_bStartLoopEndByCurve;
	}
}
