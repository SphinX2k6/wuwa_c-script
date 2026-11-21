using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008013 RID: 32787
	public class TTeleportTransitionOptionUnion
	{
		// Token: 0x1700F32F RID: 62255
		// (get) Token: 0x0603AFF7 RID: 241655 RVA: 0x007EC156 File Offset: 0x007EA356
		// (set) Token: 0x0603AFF8 RID: 241656 RVA: 0x007EC15E File Offset: 0x007EA35E
		public TTeleportTransitionOption Type { get; set; }

		// Token: 0x1700F330 RID: 62256
		// (get) Token: 0x0603AFF9 RID: 241657 RVA: 0x007EC167 File Offset: 0x007EA367
		// (set) Token: 0x0603AFFA RID: 241658 RVA: 0x007EC16F File Offset: 0x007EA36F
		public object Value { get; set; }

		// Token: 0x0603AFFB RID: 241659 RVA: 0x007EC178 File Offset: 0x007EA378
		public TTeleportTransitionOptionUnion()
		{
			this.Type = TTeleportTransitionOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AFFC RID: 241660 RVA: 0x007EC18E File Offset: 0x007EA38E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AFFD RID: 241661 RVA: 0x007EC1A0 File Offset: 0x007EA3A0
		public ITeleportTransitionInDigitalScreenT AsITeleportTransitionInDigitalScreen()
		{
			return this.As<ITeleportTransitionInDigitalScreenT>();
		}

		// Token: 0x0603AFFE RID: 241662 RVA: 0x007EC1A8 File Offset: 0x007EA3A8
		public static TTeleportTransitionOptionUnion FromITeleportTransitionInDigitalScreen(ITeleportTransitionInDigitalScreenT _iteleporttransitionindigitalscreen)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionInDigitalScreen,
				Value = _iteleporttransitionindigitalscreen
			};
		}

		// Token: 0x0603AFFF RID: 241663 RVA: 0x007EC1BD File Offset: 0x007EA3BD
		public ITeleportTransitionInSeamlessTypeT AsITeleportTransitionInSeamlessType()
		{
			return this.As<ITeleportTransitionInSeamlessTypeT>();
		}

		// Token: 0x0603B000 RID: 241664 RVA: 0x007EC1C5 File Offset: 0x007EA3C5
		public static TTeleportTransitionOptionUnion FromITeleportTransitionInSeamlessType(ITeleportTransitionInSeamlessTypeT _iteleporttransitioninseamlesstype)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionInSeamlessType,
				Value = _iteleporttransitioninseamlesstype
			};
		}

		// Token: 0x0603B001 RID: 241665 RVA: 0x007EC1DA File Offset: 0x007EA3DA
		public ITeleportTransitionWithCenterTextT AsITeleportTransitionWithCenterText()
		{
			return this.As<ITeleportTransitionWithCenterTextT>();
		}

		// Token: 0x0603B002 RID: 241666 RVA: 0x007EC1E2 File Offset: 0x007EA3E2
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCenterText(ITeleportTransitionWithCenterTextT _iteleporttransitionwithcentertext)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCenterText,
				Value = _iteleporttransitionwithcentertext
			};
		}

		// Token: 0x0603B003 RID: 241667 RVA: 0x007EC1F7 File Offset: 0x007EA3F7
		public ITeleportTransitionWithCharacterDisplayT AsITeleportTransitionWithCharacterDisplay()
		{
			return this.As<ITeleportTransitionWithCharacterDisplayT>();
		}

		// Token: 0x0603B004 RID: 241668 RVA: 0x007EC1FF File Offset: 0x007EA3FF
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCharacterDisplay(ITeleportTransitionWithCharacterDisplayT _iteleporttransitionwithcharacterdisplay)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay,
				Value = _iteleporttransitionwithcharacterdisplay
			};
		}

		// Token: 0x0603B005 RID: 241669 RVA: 0x007EC214 File Offset: 0x007EA414
		public ITeleportTransitionWithCustomLoadingT AsITeleportTransitionWithCustomLoading()
		{
			return this.As<ITeleportTransitionWithCustomLoadingT>();
		}

		// Token: 0x0603B006 RID: 241670 RVA: 0x007EC21C File Offset: 0x007EA41C
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCustomLoading(ITeleportTransitionWithCustomLoadingT _iteleporttransitionwithcustomloading)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCustomLoading,
				Value = _iteleporttransitionwithcustomloading
			};
		}

		// Token: 0x0603B007 RID: 241671 RVA: 0x007EC231 File Offset: 0x007EA431
		public ITeleportTransitionWithCustomScreenT AsITeleportTransitionWithCustomScreen()
		{
			return this.As<ITeleportTransitionWithCustomScreenT>();
		}

		// Token: 0x0603B008 RID: 241672 RVA: 0x007EC239 File Offset: 0x007EA439
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithCustomScreen(ITeleportTransitionWithCustomScreenT _iteleporttransitionwithcustomscreen)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithCustomScreen,
				Value = _iteleporttransitionwithcustomscreen
			};
		}

		// Token: 0x0603B009 RID: 241673 RVA: 0x007EC24E File Offset: 0x007EA44E
		public ITeleportTransitionWithEffectT AsITeleportTransitionWithEffect()
		{
			return this.As<ITeleportTransitionWithEffectT>();
		}

		// Token: 0x0603B00A RID: 241674 RVA: 0x007EC256 File Offset: 0x007EA456
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithEffect(ITeleportTransitionWithEffectT _iteleporttransitionwitheffect)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithEffect,
				Value = _iteleporttransitionwitheffect
			};
		}

		// Token: 0x0603B00B RID: 241675 RVA: 0x007EC26B File Offset: 0x007EA46B
		public ITeleportTransitionWithFadeInScreenT AsITeleportTransitionWithFadeInScreen()
		{
			return this.As<ITeleportTransitionWithFadeInScreenT>();
		}

		// Token: 0x0603B00C RID: 241676 RVA: 0x007EC273 File Offset: 0x007EA473
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithFadeInScreen(ITeleportTransitionWithFadeInScreenT _iteleporttransitionwithfadeinscreen)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen,
				Value = _iteleporttransitionwithfadeinscreen
			};
		}

		// Token: 0x0603B00D RID: 241677 RVA: 0x007EC288 File Offset: 0x007EA488
		public ITeleportTransitionWithMp4T AsITeleportTransitionWithMp4()
		{
			return this.As<ITeleportTransitionWithMp4T>();
		}

		// Token: 0x0603B00E RID: 241678 RVA: 0x007EC290 File Offset: 0x007EA490
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithMp4(ITeleportTransitionWithMp4T _iteleporttransitionwithmp4)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithMp4,
				Value = _iteleporttransitionwithmp4
			};
		}

		// Token: 0x0603B00F RID: 241679 RVA: 0x007EC2A6 File Offset: 0x007EA4A6
		public ITeleportTransitionWithPlayFlowT AsITeleportTransitionWithPlayFlow()
		{
			return this.As<ITeleportTransitionWithPlayFlowT>();
		}

		// Token: 0x0603B010 RID: 241680 RVA: 0x007EC2AE File Offset: 0x007EA4AE
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithPlayFlow(ITeleportTransitionWithPlayFlowT _iteleporttransitionwithplayflow)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithPlayFlow,
				Value = _iteleporttransitionwithplayflow
			};
		}

		// Token: 0x0603B011 RID: 241681 RVA: 0x007EC2C4 File Offset: 0x007EA4C4
		public ITeleportTransitionWithSpecialCustomLoadingT AsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.As<ITeleportTransitionWithSpecialCustomLoadingT>();
		}

		// Token: 0x0603B012 RID: 241682 RVA: 0x007EC2CC File Offset: 0x007EA4CC
		public static TTeleportTransitionOptionUnion FromITeleportTransitionWithSpecialCustomLoading(ITeleportTransitionWithSpecialCustomLoadingT _iteleporttransitionwithspecialcustomloading)
		{
			return new TTeleportTransitionOptionUnion
			{
				Type = TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading,
				Value = _iteleporttransitionwithspecialcustomloading
			};
		}

		// Token: 0x0603B013 RID: 241683 RVA: 0x007EC2E4 File Offset: 0x007EA4E4
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
