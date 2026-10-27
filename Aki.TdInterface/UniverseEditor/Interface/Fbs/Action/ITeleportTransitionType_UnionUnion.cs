using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A7 RID: 29607
	public class ITeleportTransitionType_UnionUnion
	{
		// Token: 0x1700E0C2 RID: 57538
		// (get) Token: 0x06035BE5 RID: 220133 RVA: 0x00750D51 File Offset: 0x0074EF51
		// (set) Token: 0x06035BE6 RID: 220134 RVA: 0x00750D59 File Offset: 0x0074EF59
		public ITeleportTransitionType_Union Type { get; set; }

		// Token: 0x1700E0C3 RID: 57539
		// (get) Token: 0x06035BE7 RID: 220135 RVA: 0x00750D62 File Offset: 0x0074EF62
		// (set) Token: 0x06035BE8 RID: 220136 RVA: 0x00750D6A File Offset: 0x0074EF6A
		public object Value { get; set; }

		// Token: 0x06035BE9 RID: 220137 RVA: 0x00750D73 File Offset: 0x0074EF73
		public ITeleportTransitionType_UnionUnion()
		{
			this.Type = ITeleportTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035BEA RID: 220138 RVA: 0x00750D89 File Offset: 0x0074EF89
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035BEB RID: 220139 RVA: 0x00750D9B File Offset: 0x0074EF9B
		public ITeleportTransitionTypeT AsITeleportTransitionType()
		{
			return this.As<ITeleportTransitionTypeT>();
		}

		// Token: 0x06035BEC RID: 220140 RVA: 0x00750DA3 File Offset: 0x0074EFA3
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionType(ITeleportTransitionTypeT _iteleporttransitiontype)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionType,
				Value = _iteleporttransitiontype
			};
		}

		// Token: 0x06035BED RID: 220141 RVA: 0x00750DB8 File Offset: 0x0074EFB8
		public ITeleportTransitionWithMp4T AsITeleportTransitionWithMp4()
		{
			return this.As<ITeleportTransitionWithMp4T>();
		}

		// Token: 0x06035BEE RID: 220142 RVA: 0x00750DC0 File Offset: 0x0074EFC0
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithMp4(ITeleportTransitionWithMp4T _iteleporttransitionwithmp4)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithMp4,
				Value = _iteleporttransitionwithmp4
			};
		}

		// Token: 0x06035BEF RID: 220143 RVA: 0x00750DD5 File Offset: 0x0074EFD5
		public ITeleportTransitionWithEffectT AsITeleportTransitionWithEffect()
		{
			return this.As<ITeleportTransitionWithEffectT>();
		}

		// Token: 0x06035BF0 RID: 220144 RVA: 0x00750DDD File Offset: 0x0074EFDD
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithEffect(ITeleportTransitionWithEffectT _iteleporttransitionwitheffect)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithEffect,
				Value = _iteleporttransitionwitheffect
			};
		}

		// Token: 0x06035BF1 RID: 220145 RVA: 0x00750DF2 File Offset: 0x0074EFF2
		public ITeleportTransitionWithCenterTextT AsITeleportTransitionWithCenterText()
		{
			return this.As<ITeleportTransitionWithCenterTextT>();
		}

		// Token: 0x06035BF2 RID: 220146 RVA: 0x00750DFA File Offset: 0x0074EFFA
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCenterText(ITeleportTransitionWithCenterTextT _iteleporttransitionwithcentertext)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCenterText,
				Value = _iteleporttransitionwithcentertext
			};
		}

		// Token: 0x06035BF3 RID: 220147 RVA: 0x00750E0F File Offset: 0x0074F00F
		public ITeleportTransitionWithFadeInScreenT AsITeleportTransitionWithFadeInScreen()
		{
			return this.As<ITeleportTransitionWithFadeInScreenT>();
		}

		// Token: 0x06035BF4 RID: 220148 RVA: 0x00750E17 File Offset: 0x0074F017
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithFadeInScreen(ITeleportTransitionWithFadeInScreenT _iteleporttransitionwithfadeinscreen)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithFadeInScreen,
				Value = _iteleporttransitionwithfadeinscreen
			};
		}

		// Token: 0x06035BF5 RID: 220149 RVA: 0x00750E2C File Offset: 0x0074F02C
		public ITeleportTransitionInDigitalScreenT AsITeleportTransitionInDigitalScreen()
		{
			return this.As<ITeleportTransitionInDigitalScreenT>();
		}

		// Token: 0x06035BF6 RID: 220150 RVA: 0x00750E34 File Offset: 0x0074F034
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionInDigitalScreen(ITeleportTransitionInDigitalScreenT _iteleporttransitionindigitalscreen)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionInDigitalScreen,
				Value = _iteleporttransitionindigitalscreen
			};
		}

		// Token: 0x06035BF7 RID: 220151 RVA: 0x00750E49 File Offset: 0x0074F049
		public ITeleportTransitionWithCustomLoadingT AsITeleportTransitionWithCustomLoading()
		{
			return this.As<ITeleportTransitionWithCustomLoadingT>();
		}

		// Token: 0x06035BF8 RID: 220152 RVA: 0x00750E51 File Offset: 0x0074F051
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCustomLoading(ITeleportTransitionWithCustomLoadingT _iteleporttransitionwithcustomloading)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCustomLoading,
				Value = _iteleporttransitionwithcustomloading
			};
		}

		// Token: 0x06035BF9 RID: 220153 RVA: 0x00750E66 File Offset: 0x0074F066
		public ITeleportTransitionWithSpecialCustomLoadingT AsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.As<ITeleportTransitionWithSpecialCustomLoadingT>();
		}

		// Token: 0x06035BFA RID: 220154 RVA: 0x00750E6E File Offset: 0x0074F06E
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithSpecialCustomLoading(ITeleportTransitionWithSpecialCustomLoadingT _iteleporttransitionwithspecialcustomloading)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithSpecialCustomLoading,
				Value = _iteleporttransitionwithspecialcustomloading
			};
		}

		// Token: 0x06035BFB RID: 220155 RVA: 0x00750E83 File Offset: 0x0074F083
		public ITeleportTransitionWithPlayFlowT AsITeleportTransitionWithPlayFlow()
		{
			return this.As<ITeleportTransitionWithPlayFlowT>();
		}

		// Token: 0x06035BFC RID: 220156 RVA: 0x00750E8B File Offset: 0x0074F08B
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithPlayFlow(ITeleportTransitionWithPlayFlowT _iteleporttransitionwithplayflow)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithPlayFlow,
				Value = _iteleporttransitionwithplayflow
			};
		}

		// Token: 0x06035BFD RID: 220157 RVA: 0x00750EA1 File Offset: 0x0074F0A1
		public ITeleportTransitionWithCustomScreenT AsITeleportTransitionWithCustomScreen()
		{
			return this.As<ITeleportTransitionWithCustomScreenT>();
		}

		// Token: 0x06035BFE RID: 220158 RVA: 0x00750EA9 File Offset: 0x0074F0A9
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCustomScreen(ITeleportTransitionWithCustomScreenT _iteleporttransitionwithcustomscreen)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCustomScreen,
				Value = _iteleporttransitionwithcustomscreen
			};
		}

		// Token: 0x06035BFF RID: 220159 RVA: 0x00750EBF File Offset: 0x0074F0BF
		public ITeleportTransitionInSeamlessTypeT AsITeleportTransitionInSeamlessType()
		{
			return this.As<ITeleportTransitionInSeamlessTypeT>();
		}

		// Token: 0x06035C00 RID: 220160 RVA: 0x00750EC7 File Offset: 0x0074F0C7
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionInSeamlessType(ITeleportTransitionInSeamlessTypeT _iteleporttransitioninseamlesstype)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionInSeamlessType,
				Value = _iteleporttransitioninseamlesstype
			};
		}

		// Token: 0x06035C01 RID: 220161 RVA: 0x00750EDD File Offset: 0x0074F0DD
		public ITeleportTransitionWithCharacterDisplayT AsITeleportTransitionWithCharacterDisplay()
		{
			return this.As<ITeleportTransitionWithCharacterDisplayT>();
		}

		// Token: 0x06035C02 RID: 220162 RVA: 0x00750EE5 File Offset: 0x0074F0E5
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCharacterDisplay(ITeleportTransitionWithCharacterDisplayT _iteleporttransitionwithcharacterdisplay)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCharacterDisplay,
				Value = _iteleporttransitionwithcharacterdisplay
			};
		}

		// Token: 0x06035C03 RID: 220163 RVA: 0x00750EFC File Offset: 0x0074F0FC
		public static int Pack(FlatBufferBuilder builder, ITeleportTransitionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITeleportTransitionType_Union.ITeleportTransitionType:
				return ITeleportTransitionType.Pack(builder, _o.AsITeleportTransitionType()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithMp4:
				return ITeleportTransitionWithMp4.Pack(builder, _o.AsITeleportTransitionWithMp4()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithEffect:
				return ITeleportTransitionWithEffect.Pack(builder, _o.AsITeleportTransitionWithEffect()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCenterText:
				return ITeleportTransitionWithCenterText.Pack(builder, _o.AsITeleportTransitionWithCenterText()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithFadeInScreen:
				return ITeleportTransitionWithFadeInScreen.Pack(builder, _o.AsITeleportTransitionWithFadeInScreen()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionInDigitalScreen:
				return ITeleportTransitionInDigitalScreen.Pack(builder, _o.AsITeleportTransitionInDigitalScreen()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCustomLoading:
				return ITeleportTransitionWithCustomLoading.Pack(builder, _o.AsITeleportTransitionWithCustomLoading()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithSpecialCustomLoading:
				return ITeleportTransitionWithSpecialCustomLoading.Pack(builder, _o.AsITeleportTransitionWithSpecialCustomLoading()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithPlayFlow:
				return ITeleportTransitionWithPlayFlow.Pack(builder, _o.AsITeleportTransitionWithPlayFlow()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCustomScreen:
				return ITeleportTransitionWithCustomScreen.Pack(builder, _o.AsITeleportTransitionWithCustomScreen()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionInSeamlessType:
				return ITeleportTransitionInSeamlessType.Pack(builder, _o.AsITeleportTransitionInSeamlessType()).Value;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCharacterDisplay:
				return ITeleportTransitionWithCharacterDisplay.Pack(builder, _o.AsITeleportTransitionWithCharacterDisplay()).Value;
			default:
				return 0;
			}
		}
	}
}
