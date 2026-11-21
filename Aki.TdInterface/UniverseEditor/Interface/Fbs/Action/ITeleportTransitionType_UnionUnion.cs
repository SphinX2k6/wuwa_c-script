using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B8E RID: 31630
	public class ITeleportTransitionType_UnionUnion
	{
		// Token: 0x1700ECD2 RID: 60626
		// (get) Token: 0x06038F80 RID: 233344 RVA: 0x007B3291 File Offset: 0x007B1491
		// (set) Token: 0x06038F81 RID: 233345 RVA: 0x007B3299 File Offset: 0x007B1499
		public ITeleportTransitionType_Union Type { get; set; }

		// Token: 0x1700ECD3 RID: 60627
		// (get) Token: 0x06038F82 RID: 233346 RVA: 0x007B32A2 File Offset: 0x007B14A2
		// (set) Token: 0x06038F83 RID: 233347 RVA: 0x007B32AA File Offset: 0x007B14AA
		public object Value { get; set; }

		// Token: 0x06038F84 RID: 233348 RVA: 0x007B32B3 File Offset: 0x007B14B3
		public ITeleportTransitionType_UnionUnion()
		{
			this.Type = ITeleportTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038F85 RID: 233349 RVA: 0x007B32C9 File Offset: 0x007B14C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038F86 RID: 233350 RVA: 0x007B32DB File Offset: 0x007B14DB
		public ITeleportTransitionTypeT AsITeleportTransitionType()
		{
			return this.As<ITeleportTransitionTypeT>();
		}

		// Token: 0x06038F87 RID: 233351 RVA: 0x007B32E3 File Offset: 0x007B14E3
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionType(ITeleportTransitionTypeT _iteleporttransitiontype)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionType,
				Value = _iteleporttransitiontype
			};
		}

		// Token: 0x06038F88 RID: 233352 RVA: 0x007B32F8 File Offset: 0x007B14F8
		public ITeleportTransitionWithMp4T AsITeleportTransitionWithMp4()
		{
			return this.As<ITeleportTransitionWithMp4T>();
		}

		// Token: 0x06038F89 RID: 233353 RVA: 0x007B3300 File Offset: 0x007B1500
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithMp4(ITeleportTransitionWithMp4T _iteleporttransitionwithmp4)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithMp4,
				Value = _iteleporttransitionwithmp4
			};
		}

		// Token: 0x06038F8A RID: 233354 RVA: 0x007B3315 File Offset: 0x007B1515
		public ITeleportTransitionWithEffectT AsITeleportTransitionWithEffect()
		{
			return this.As<ITeleportTransitionWithEffectT>();
		}

		// Token: 0x06038F8B RID: 233355 RVA: 0x007B331D File Offset: 0x007B151D
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithEffect(ITeleportTransitionWithEffectT _iteleporttransitionwitheffect)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithEffect,
				Value = _iteleporttransitionwitheffect
			};
		}

		// Token: 0x06038F8C RID: 233356 RVA: 0x007B3332 File Offset: 0x007B1532
		public ITeleportTransitionWithCenterTextT AsITeleportTransitionWithCenterText()
		{
			return this.As<ITeleportTransitionWithCenterTextT>();
		}

		// Token: 0x06038F8D RID: 233357 RVA: 0x007B333A File Offset: 0x007B153A
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCenterText(ITeleportTransitionWithCenterTextT _iteleporttransitionwithcentertext)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCenterText,
				Value = _iteleporttransitionwithcentertext
			};
		}

		// Token: 0x06038F8E RID: 233358 RVA: 0x007B334F File Offset: 0x007B154F
		public ITeleportTransitionWithFadeInScreenT AsITeleportTransitionWithFadeInScreen()
		{
			return this.As<ITeleportTransitionWithFadeInScreenT>();
		}

		// Token: 0x06038F8F RID: 233359 RVA: 0x007B3357 File Offset: 0x007B1557
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithFadeInScreen(ITeleportTransitionWithFadeInScreenT _iteleporttransitionwithfadeinscreen)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithFadeInScreen,
				Value = _iteleporttransitionwithfadeinscreen
			};
		}

		// Token: 0x06038F90 RID: 233360 RVA: 0x007B336C File Offset: 0x007B156C
		public ITeleportTransitionInDigitalScreenT AsITeleportTransitionInDigitalScreen()
		{
			return this.As<ITeleportTransitionInDigitalScreenT>();
		}

		// Token: 0x06038F91 RID: 233361 RVA: 0x007B3374 File Offset: 0x007B1574
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionInDigitalScreen(ITeleportTransitionInDigitalScreenT _iteleporttransitionindigitalscreen)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionInDigitalScreen,
				Value = _iteleporttransitionindigitalscreen
			};
		}

		// Token: 0x06038F92 RID: 233362 RVA: 0x007B3389 File Offset: 0x007B1589
		public ITeleportTransitionWithCustomLoadingT AsITeleportTransitionWithCustomLoading()
		{
			return this.As<ITeleportTransitionWithCustomLoadingT>();
		}

		// Token: 0x06038F93 RID: 233363 RVA: 0x007B3391 File Offset: 0x007B1591
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCustomLoading(ITeleportTransitionWithCustomLoadingT _iteleporttransitionwithcustomloading)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCustomLoading,
				Value = _iteleporttransitionwithcustomloading
			};
		}

		// Token: 0x06038F94 RID: 233364 RVA: 0x007B33A6 File Offset: 0x007B15A6
		public ITeleportTransitionWithSpecialCustomLoadingT AsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.As<ITeleportTransitionWithSpecialCustomLoadingT>();
		}

		// Token: 0x06038F95 RID: 233365 RVA: 0x007B33AE File Offset: 0x007B15AE
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithSpecialCustomLoading(ITeleportTransitionWithSpecialCustomLoadingT _iteleporttransitionwithspecialcustomloading)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithSpecialCustomLoading,
				Value = _iteleporttransitionwithspecialcustomloading
			};
		}

		// Token: 0x06038F96 RID: 233366 RVA: 0x007B33C3 File Offset: 0x007B15C3
		public ITeleportTransitionWithPlayFlowT AsITeleportTransitionWithPlayFlow()
		{
			return this.As<ITeleportTransitionWithPlayFlowT>();
		}

		// Token: 0x06038F97 RID: 233367 RVA: 0x007B33CB File Offset: 0x007B15CB
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithPlayFlow(ITeleportTransitionWithPlayFlowT _iteleporttransitionwithplayflow)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithPlayFlow,
				Value = _iteleporttransitionwithplayflow
			};
		}

		// Token: 0x06038F98 RID: 233368 RVA: 0x007B33E1 File Offset: 0x007B15E1
		public ITeleportTransitionWithCustomScreenT AsITeleportTransitionWithCustomScreen()
		{
			return this.As<ITeleportTransitionWithCustomScreenT>();
		}

		// Token: 0x06038F99 RID: 233369 RVA: 0x007B33E9 File Offset: 0x007B15E9
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCustomScreen(ITeleportTransitionWithCustomScreenT _iteleporttransitionwithcustomscreen)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCustomScreen,
				Value = _iteleporttransitionwithcustomscreen
			};
		}

		// Token: 0x06038F9A RID: 233370 RVA: 0x007B33FF File Offset: 0x007B15FF
		public ITeleportTransitionInSeamlessTypeT AsITeleportTransitionInSeamlessType()
		{
			return this.As<ITeleportTransitionInSeamlessTypeT>();
		}

		// Token: 0x06038F9B RID: 233371 RVA: 0x007B3407 File Offset: 0x007B1607
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionInSeamlessType(ITeleportTransitionInSeamlessTypeT _iteleporttransitioninseamlesstype)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionInSeamlessType,
				Value = _iteleporttransitioninseamlesstype
			};
		}

		// Token: 0x06038F9C RID: 233372 RVA: 0x007B341D File Offset: 0x007B161D
		public ITeleportTransitionWithCharacterDisplayT AsITeleportTransitionWithCharacterDisplay()
		{
			return this.As<ITeleportTransitionWithCharacterDisplayT>();
		}

		// Token: 0x06038F9D RID: 233373 RVA: 0x007B3425 File Offset: 0x007B1625
		public static ITeleportTransitionType_UnionUnion FromITeleportTransitionWithCharacterDisplay(ITeleportTransitionWithCharacterDisplayT _iteleporttransitionwithcharacterdisplay)
		{
			return new ITeleportTransitionType_UnionUnion
			{
				Type = ITeleportTransitionType_Union.ITeleportTransitionWithCharacterDisplay,
				Value = _iteleporttransitionwithcharacterdisplay
			};
		}

		// Token: 0x06038F9E RID: 233374 RVA: 0x007B343C File Offset: 0x007B163C
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
