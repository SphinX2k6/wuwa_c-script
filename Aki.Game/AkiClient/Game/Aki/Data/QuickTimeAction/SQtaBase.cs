using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x02003EAF RID: 16047
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaBase.SQtaBase")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class SQtaBase : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602892E RID: 166190 RVA: 0x009AF8EC File Offset: 0x009ADAEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaBase._ScriptStructPtr != 0) ? SQtaBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaBase.SQtaBase", ref SQtaBase._ScriptStructPtr);
		}

		// Token: 0x17005E8E RID: 24206
		// (get) Token: 0x0602892F RID: 166191 RVA: 0x009AF910 File Offset: 0x009ADB10
		// (set) Token: 0x06028930 RID: 166192 RVA: 0x009AF920 File Offset: 0x009ADB20
		public unsafe bool IsBlockFightInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E8F RID: 24207
		// (get) Token: 0x06028931 RID: 166193 RVA: 0x009AF931 File Offset: 0x009ADB31
		// (set) Token: 0x06028932 RID: 166194 RVA: 0x009AF941 File Offset: 0x009ADB41
		public unsafe bool EnableInputDistributeFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E90 RID: 24208
		// (get) Token: 0x06028933 RID: 166195 RVA: 0x009AF954 File Offset: 0x009ADB54
		// (set) Token: 0x06028934 RID: 166196 RVA: 0x009AF997 File Offset: 0x009ADB97
		public SQtaInputDistribute InputDistributeFilterConfig
		{
			get
			{
				base.FastCheckIsValid();
				SQtaInputDistribute result;
				if ((result = this._InputDistributeFilterConfig) == null)
				{
					result = (this._InputDistributeFilterConfig = new SQtaInputDistribute(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaInputDistribute.StaticStruct(), base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E91 RID: 24209
		// (get) Token: 0x06028935 RID: 166197 RVA: 0x009AF9B8 File Offset: 0x009ADBB8
		// (set) Token: 0x06028936 RID: 166198 RVA: 0x009AF9C8 File Offset: 0x009ADBC8
		public unsafe bool HideAllBattleUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E92 RID: 24210
		// (get) Token: 0x06028937 RID: 166199 RVA: 0x009AF9D9 File Offset: 0x009ADBD9
		// (set) Token: 0x06028938 RID: 166200 RVA: 0x009AF9E9 File Offset: 0x009ADBE9
		public unsafe bool HideAllBattleUiInMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E93 RID: 24211
		// (get) Token: 0x06028939 RID: 166201 RVA: 0x009AF9FC File Offset: 0x009ADBFC
		// (set) Token: 0x0602893A RID: 166202 RVA: 0x009AFA3F File Offset: 0x009ADC3F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EBattleUIChild>> HideUiElement
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EBattleUIChild>> result;
				if ((result = this._HideUiElement) == null)
				{
					result = (this._HideUiElement = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.HideUiElement.CopyAssign(value);
			}
		}

		// Token: 0x17005E94 RID: 24212
		// (get) Token: 0x0602893B RID: 166203 RVA: 0x009AFA50 File Offset: 0x009ADC50
		// (set) Token: 0x0602893C RID: 166204 RVA: 0x009AFA93 File Offset: 0x009ADC93
		public TArray<SCommonQteButton> InputConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCommonQteButton> result;
				if ((result = this._InputConfig) == null)
				{
					result = (this._InputConfig = new TArray<SCommonQteButton>(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputConfig.CopyAssign(value);
			}
		}

		// Token: 0x17005E95 RID: 24213
		// (get) Token: 0x0602893D RID: 166205 RVA: 0x009AFAA1 File Offset: 0x009ADCA1
		// (set) Token: 0x0602893E RID: 166206 RVA: 0x009AFAB1 File Offset: 0x009ADCB1
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005E96 RID: 24214
		// (get) Token: 0x0602893F RID: 166207 RVA: 0x009AFAC2 File Offset: 0x009ADCC2
		// (set) Token: 0x06028940 RID: 166208 RVA: 0x009AFAD2 File Offset: 0x009ADCD2
		public unsafe float LeastDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005E97 RID: 24215
		// (get) Token: 0x06028941 RID: 166209 RVA: 0x009AFAE3 File Offset: 0x009ADCE3
		// (set) Token: 0x06028942 RID: 166210 RVA: 0x009AFAF3 File Offset: 0x009ADCF3
		public unsafe float TimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005E98 RID: 24216
		// (get) Token: 0x06028943 RID: 166211 RVA: 0x009AFB04 File Offset: 0x009ADD04
		// (set) Token: 0x06028944 RID: 166212 RVA: 0x009AFB47 File Offset: 0x009ADD47
		public FGameplayTagContainer ActiveTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ActiveTags) == null)
				{
					result = (this._ActiveTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E99 RID: 24217
		// (get) Token: 0x06028945 RID: 166213 RVA: 0x009AFB68 File Offset: 0x009ADD68
		// (set) Token: 0x06028946 RID: 166214 RVA: 0x009AFB7C File Offset: 0x009ADD7C
		[Nullable(0)]
		public unsafe TEnumAsByte<EQtaType> QtaType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17005E9A RID: 24218
		// (get) Token: 0x06028947 RID: 166215 RVA: 0x009AFB94 File Offset: 0x009ADD94
		// (set) Token: 0x06028948 RID: 166216 RVA: 0x009AFBD7 File Offset: 0x009ADDD7
		public SQtaCustomization CustomizationConfig
		{
			get
			{
				base.FastCheckIsValid();
				SQtaCustomization result;
				if ((result = this._CustomizationConfig) == null)
				{
					result = (this._CustomizationConfig = new SQtaCustomization(base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQtaCustomization.StaticStruct(), base.NativePtr + (IntPtr)SQtaBase.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06028949 RID: 166217 RVA: 0x009AFBF8 File Offset: 0x009ADDF8
		public SQtaBase()
		{
		}

		// Token: 0x0602894A RID: 166218 RVA: 0x009AFC00 File Offset: 0x009ADE00
		public SQtaBase(bool IsBlockFightInput, bool EnableInputDistributeFilter, SQtaInputDistribute InputDistributeFilterConfig, bool HideAllBattleUi, bool HideAllBattleUiInMobile, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EBattleUIChild>> HideUiElement, TArray<SCommonQteButton> InputConfig, float Duration, float LeastDuration, float TimeDilation, FGameplayTagContainer ActiveTags, [Nullable(0)] TEnumAsByte<EQtaType> QtaType, SQtaCustomization CustomizationConfig)
		{
			this.IsBlockFightInput = IsBlockFightInput;
			this.EnableInputDistributeFilter = EnableInputDistributeFilter;
			this.InputDistributeFilterConfig = InputDistributeFilterConfig;
			this.HideAllBattleUi = HideAllBattleUi;
			this.HideAllBattleUiInMobile = HideAllBattleUiInMobile;
			this.HideUiElement = HideUiElement;
			this.InputConfig = InputConfig;
			this.Duration = Duration;
			this.LeastDuration = LeastDuration;
			this.TimeDilation = TimeDilation;
			this.ActiveTags = ActiveTags;
			this.QtaType = QtaType;
			this.CustomizationConfig = CustomizationConfig;
		}

		// Token: 0x0602894B RID: 166219 RVA: 0x009AFC78 File Offset: 0x009ADE78
		protected override IntPtr GetUStructPtr()
		{
			return SQtaBase.StaticStruct();
		}

		// Token: 0x0602894C RID: 166220 RVA: 0x009AFC84 File Offset: 0x009ADE84
		[NullableContext(2)]
		public SQtaBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602894D RID: 166221 RVA: 0x009AFC8E File Offset: 0x009ADE8E
		public SQtaBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602894E RID: 166222 RVA: 0x009AFC99 File Offset: 0x009ADE99
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaBase(Pointer, false, true);
		}

		// Token: 0x0602894F RID: 166223 RVA: 0x009AFCA3 File Offset: 0x009ADEA3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaBase(Pointer, MemoryOwner);
		}

		// Token: 0x04014B54 RID: 84820
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaBase.SQtaBase";

		// Token: 0x04014B55 RID: 84821
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B56 RID: 84822
		internal static int __PropertyOffset_0;

		// Token: 0x04014B57 RID: 84823
		internal static int __PropertyOffset_1;

		// Token: 0x04014B58 RID: 84824
		internal static int __PropertyOffset_2;

		// Token: 0x04014B59 RID: 84825
		[Nullable(2)]
		private SQtaInputDistribute _InputDistributeFilterConfig;

		// Token: 0x04014B5A RID: 84826
		internal static int __PropertyOffset_3;

		// Token: 0x04014B5B RID: 84827
		internal static int __PropertyOffset_4;

		// Token: 0x04014B5C RID: 84828
		internal static int __PropertyOffset_5;

		// Token: 0x04014B5D RID: 84829
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _HideUiElement;

		// Token: 0x04014B5E RID: 84830
		internal static int __PropertyOffset_6;

		// Token: 0x04014B5F RID: 84831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCommonQteButton> _InputConfig;

		// Token: 0x04014B60 RID: 84832
		internal static int __PropertyOffset_7;

		// Token: 0x04014B61 RID: 84833
		internal static int __PropertyOffset_8;

		// Token: 0x04014B62 RID: 84834
		internal static int __PropertyOffset_9;

		// Token: 0x04014B63 RID: 84835
		internal static int __PropertyOffset_10;

		// Token: 0x04014B64 RID: 84836
		[Nullable(2)]
		private FGameplayTagContainer _ActiveTags;

		// Token: 0x04014B65 RID: 84837
		internal static int __PropertyOffset_11;

		// Token: 0x04014B66 RID: 84838
		internal static int __PropertyOffset_12;

		// Token: 0x04014B67 RID: 84839
		[Nullable(2)]
		private SQtaCustomization _CustomizationConfig;
	}
}
