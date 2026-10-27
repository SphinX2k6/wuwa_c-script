using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D8 RID: 30680
	public class TTeleportTransitionOptionUnion
	{
		// Token: 0x1700E6D3 RID: 59091
		// (get) Token: 0x06037A64 RID: 227940 RVA: 0x007869A6 File Offset: 0x00784BA6
		// (set) Token: 0x06037A65 RID: 227941 RVA: 0x007869AE File Offset: 0x00784BAE
		public TTeleportTransitionOption Type { get; set; }

		// Token: 0x1700E6D4 RID: 59092
		// (get) Token: 0x06037A66 RID: 227942 RVA: 0x007869B7 File Offset: 0x00784BB7
		// (set) Token: 0x06037A67 RID: 227943 RVA: 0x007869BF File Offset: 0x00784BBF
		public object Value { get; set; }

		// Token: 0x06037A68 RID: 227944 RVA: 0x007869C8 File Offset: 0x00784BC8
		public TTeleportTransitionOptionUnion()
		{
			this.Type = TTeleportTransitionOption.NONE;
			this.Value = null;
		}

		// Token: 0x06037A69 RID: 227945 RVA: 0x007869DE File Offset: 0x00784BDE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A6A RID: 227946 RVA: 0x007869F0 File Offset: 0x00784BF0
		public ITeleportTransitionInDigitalScreenT AsITeleportTransitionInDigitalScreen()
		{
			return this.As<ITeleportTransitionInDigitalScreenT>();
		}

		// Token: 0x06037A6B RID: 227947 RVA: 0x007869F8 File Offset: 0x00784BF8
		public static TTeleportTransitionOptionUnion FromITeleportTransitionInDigitalScreen(ITeleportTransitionInDigitalScreenT _iteleporttransitionindigitalscreen)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionInDigitalScreen,
				Value = _iteleporttransitionindigitalscreen
			};
		}

		// Token: 0x06037A6C RID: 227948 RVA: 0x00786A0D File Offset: 0x00784C0D
		public ITeleportTransitionInSeamlessTypeT AsITeleportTransitionInSeamlessType()
		{
			return this.As<ITeleportTransitionInSeamlessTypeT>();
		}

		// Token: 0x06037A6D RID: 227949 RVA: 0x00786A15 File Offset: 0x00784C15
		public static TTeleportTransitionOptionUnion FromITeleportTransitionInSeamlessType(ITeleportTransitionInSeamlessTypeT _iteleporttransitioninseamlesstype)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionInSeamlessType,
				Value = _iteleporttransitioninseamlesstype
			};
		}

		// Token: 0x06037A6E RID: 227950 RVA: 0x00786A2A File Offset: 0x00784C2A
		public ITeleportTransitionWithCenterTextT AsITeleportTransitionWithCenterText()
		{
			return this.As<ITeleportTransitionWithCenterTextT>();
		}

		// Token: 0x06037A6F RID: 227951 RVA: 0x00786A32 File Offset: 0x00784C32
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCenterText(ITeleportTransitionWithCenterTextT _iteleporttransitionwithcentertext)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCenterText,
				Value = _iteleporttransitionwithcentertext
			};
		}

		// Token: 0x06037A70 RID: 227952 RVA: 0x00786A47 File Offset: 0x00784C47
		public ITeleportTransitionWithCharacterDisplayT AsITeleportTransitionWithCharacterDisplay()
		{
			return this.As<ITeleportTransitionWithCharacterDisplayT>();
		}

		// Token: 0x06037A71 RID: 227953 RVA: 0x00786A4F File Offset: 0x00784C4F
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCharacterDisplay(ITeleportTransitionWithCharacterDisplayT _iteleporttransitionwithcharacterdisplay)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay,
				Value = _iteleporttransitionwithcharacterdisplay
			};
		}

		// Token: 0x06037A72 RID: 227954 RVA: 0x00786A64 File Offset: 0x00784C64
		public ITeleportTransitionWithCustomLoadingT AsITeleportTransitionWithCustomLoading()
		{
			return this.As<ITeleportTransitionWithCustomLoadingT>();
		}

		// Token: 0x06037A73 RID: 227955 RVA: 0x00786A6C File Offset: 0x00784C6C
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCustomLoading(ITeleportTransitionWithCustomLoadingT _iteleporttransitionwithcustomloading)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCustomLoading,
				Value = _iteleporttransitionwithcustomloading
			};
		}

		// Token: 0x06037A74 RID: 227956 RVA: 0x00786A81 File Offset: 0x00784C81
		public ITeleportTransitionWithCustomScreenT AsITeleportTransitionWithCustomScreen()
		{
			return this.As<ITeleportTransitionWithCustomScreenT>();
		}

		// Token: 0x06037A75 RID: 227957 RVA: 0x00786A89 File Offset: 0x00784C89
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCustomScreen(ITeleportTransitionWithCustomScreenT _iteleporttransitionwithcustomscreen)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCustomScreen,
				Value = _iteleporttransitionwithcustomscreen
			};
		}

		// Token: 0x06037A76 RID: 227958 RVA: 0x00786A9E File Offset: 0x00784C9E
		public ITeleportTransitionWithEffectT AsITeleportTransitionWithEffect()
		{
			return this.As<ITeleportTransitionWithEffectT>();
		}

		// Token: 0x06037A77 RID: 227959 RVA: 0x00786AA6 File Offset: 0x00784CA6
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithEffect(ITeleportTransitionWithEffectT _iteleporttransitionwitheffect)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithEffect,
				Value = _iteleporttransitionwitheffect
			};
		}

		// Token: 0x06037A78 RID: 227960 RVA: 0x00786ABB File Offset: 0x00784CBB
		public ITeleportTransitionWithFadeInScreenT AsITeleportTransitionWithFadeInScreen()
		{
			return this.As<ITeleportTransitionWithFadeInScreenT>();
		}

		// Token: 0x06037A79 RID: 227961 RVA: 0x00786AC3 File Offset: 0x00784CC3
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithFadeInScreen(ITeleportTransitionWithFadeInScreenT _iteleporttransitionwithfadeinscreen)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen,
				Value = _iteleporttransitionwithfadeinscreen
			};
		}

		// Token: 0x06037A7A RID: 227962 RVA: 0x00786AD8 File Offset: 0x00784CD8
		public ITeleportTransitionWithMp4T AsITeleportTransitionWithMp4()
		{
			return this.As<ITeleportTransitionWithMp4T>();
		}

		// Token: 0x06037A7B RID: 227963 RVA: 0x00786AE0 File Offset: 0x00784CE0
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithMp4(ITeleportTransitionWithMp4T _iteleporttransitionwithmp4)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithMp4,
				Value = _iteleporttransitionwithmp4
			};
		}

		// Token: 0x06037A7C RID: 227964 RVA: 0x00786AF6 File Offset: 0x00784CF6
		public ITeleportTransitionWithPlayFlowT AsITeleportTransitionWithPlayFlow()
		{
			return this.As<ITeleportTransitionWithPlayFlowT>();
		}

		// Token: 0x06037A7D RID: 227965 RVA: 0x00786AFE File Offset: 0x00784CFE
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithPlayFlow(ITeleportTransitionWithPlayFlowT _iteleporttransitionwithplayflow)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithPlayFlow,
				Value = _iteleporttransitionwithplayflow
			};
		}

		// Token: 0x06037A7E RID: 227966 RVA: 0x00786B14 File Offset: 0x00784D14
		public ITeleportTransitionWithSpecialCustomLoadingT AsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.As<ITeleportTransitionWithSpecialCustomLoadingT>();
		}

		// Token: 0x06037A7F RID: 227967 RVA: 0x00786B1C File Offset: 0x00784D1C
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithSpecialCustomLoading(ITeleportTransitionWithSpecialCustomLoadingT _iteleporttransitionwithspecialcustomloading)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading,
				Value = _iteleporttransitionwithspecialcustomloading
			};
		}

		// Token: 0x06037A80 RID: 227968 RVA: 0x00786B34 File Offset: 0x00784D34
		public static int Pack(FlatBufferBuilder builder, TTeleportTransitionOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				return ITeleportTransitionInDigitalScreen.Pack(builder, _o.AsITeleportTransitionInDigitalScreen()).Value;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				return ITeleportTransitionInSeamlessType.Pack(builder, _o.AsITeleportTransitionInSeamlessType()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				return ITeleportTransitionWithCenterText.Pack(builder, _o.AsITeleportTransitionWithCenterText()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				return ITeleportTransitionWithCharacterDisplay.Pack(builder, _o.AsITeleportTransitionWithCharacterDisplay()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				return ITeleportTransitionWithCustomLoading.Pack(builder, _o.AsITeleportTransitionWithCustomLoading()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				return ITeleportTransitionWithCustomScreen.Pack(builder, _o.AsITeleportTransitionWithCustomScreen()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				return ITeleportTransitionWithEffect.Pack(builder, _o.AsITeleportTransitionWithEffect()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				return ITeleportTransitionWithFadeInScreen.Pack(builder, _o.AsITeleportTransitionWithFadeInScreen()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				return ITeleportTransitionWithMp4.Pack(builder, _o.AsITeleportTransitionWithMp4()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				return ITeleportTransitionWithPlayFlow.Pack(builder, _o.AsITeleportTransitionWithPlayFlow()).Value;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				return ITeleportTransitionWithSpecialCustomLoading.Pack(builder, _o.AsITeleportTransitionWithSpecialCustomLoading()).Value;
			default:
				return 0;
			}
		}
	}
}
