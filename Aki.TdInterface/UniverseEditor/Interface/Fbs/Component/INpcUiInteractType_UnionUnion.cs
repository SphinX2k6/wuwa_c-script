using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005690 RID: 22160
	public class INpcUiInteractType_UnionUnion
	{
		// Token: 0x1700A4C9 RID: 42185
		// (get) Token: 0x06024F81 RID: 151425 RVA: 0x0051B155 File Offset: 0x00519355
		// (set) Token: 0x06024F82 RID: 151426 RVA: 0x0051B15D File Offset: 0x0051935D
		public INpcUiInteractType_Union Type { get; set; }

		// Token: 0x1700A4CA RID: 42186
		// (get) Token: 0x06024F83 RID: 151427 RVA: 0x0051B166 File Offset: 0x00519366
		// (set) Token: 0x06024F84 RID: 151428 RVA: 0x0051B16E File Offset: 0x0051936E
		public object Value { get; set; }

		// Token: 0x06024F85 RID: 151429 RVA: 0x0051B177 File Offset: 0x00519377
		public INpcUiInteractType_UnionUnion()
		{
			this.Type = INpcUiInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024F86 RID: 151430 RVA: 0x0051B18D File Offset: 0x0051938D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024F87 RID: 151431 RVA: 0x0051B19F File Offset: 0x0051939F
		public INpcUiInteractTypeT AsINpcUiInteractType()
		{
			return this.As<INpcUiInteractTypeT>();
		}

		// Token: 0x06024F88 RID: 151432 RVA: 0x0051B1A7 File Offset: 0x005193A7
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractType(INpcUiInteractTypeT _inpcuiinteracttype)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractType,
				Value = _inpcuiinteracttype
			};
		}

		// Token: 0x06024F89 RID: 151433 RVA: 0x0051B1BC File Offset: 0x005193BC
		public INpcUiInteractOnHandInItemT AsINpcUiInteractOnHandInItem()
		{
			return this.As<INpcUiInteractOnHandInItemT>();
		}

		// Token: 0x06024F8A RID: 151434 RVA: 0x0051B1C4 File Offset: 0x005193C4
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnHandInItem(INpcUiInteractOnHandInItemT _inpcuiinteractonhandinitem)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnHandInItem,
				Value = _inpcuiinteractonhandinitem
			};
		}

		// Token: 0x06024F8B RID: 151435 RVA: 0x0051B1D9 File Offset: 0x005193D9
		public INpcUiInteractOnShopT AsINpcUiInteractOnShop()
		{
			return this.As<INpcUiInteractOnShopT>();
		}

		// Token: 0x06024F8C RID: 151436 RVA: 0x0051B1E1 File Offset: 0x005193E1
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnShop(INpcUiInteractOnShopT _inpcuiinteractonshop)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnShop,
				Value = _inpcuiinteractonshop
			};
		}

		// Token: 0x06024F8D RID: 151437 RVA: 0x0051B1F6 File Offset: 0x005193F6
		public INpcUiInteractOnAntiqueShopT AsINpcUiInteractOnAntiqueShop()
		{
			return this.As<INpcUiInteractOnAntiqueShopT>();
		}

		// Token: 0x06024F8E RID: 151438 RVA: 0x0051B1FE File Offset: 0x005193FE
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnAntiqueShop(INpcUiInteractOnAntiqueShopT _inpcuiinteractonantiqueshop)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnAntiqueShop,
				Value = _inpcuiinteractonantiqueshop
			};
		}

		// Token: 0x06024F8F RID: 151439 RVA: 0x0051B213 File Offset: 0x00519413
		public INpcUiInteractOnChengXiaoShanShopT AsINpcUiInteractOnChengXiaoShanShop()
		{
			return this.As<INpcUiInteractOnChengXiaoShanShopT>();
		}

		// Token: 0x06024F90 RID: 151440 RVA: 0x0051B21B File Offset: 0x0051941B
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnChengXiaoShanShop(INpcUiInteractOnChengXiaoShanShopT _inpcuiinteractonchengxiaoshanshop)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnChengXiaoShanShop,
				Value = _inpcuiinteractonchengxiaoshanshop
			};
		}

		// Token: 0x06024F91 RID: 151441 RVA: 0x0051B230 File Offset: 0x00519430
		public INpcUiInteractOnGramophoneT AsINpcUiInteractOnGramophone()
		{
			return this.As<INpcUiInteractOnGramophoneT>();
		}

		// Token: 0x06024F92 RID: 151442 RVA: 0x0051B238 File Offset: 0x00519438
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnGramophone(INpcUiInteractOnGramophoneT _inpcuiinteractongramophone)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnGramophone,
				Value = _inpcuiinteractongramophone
			};
		}

		// Token: 0x06024F93 RID: 151443 RVA: 0x0051B24D File Offset: 0x0051944D
		public INpcUiInteractOnSoundBox3T AsINpcUiInteractOnSoundBox3()
		{
			return this.As<INpcUiInteractOnSoundBox3T>();
		}

		// Token: 0x06024F94 RID: 151444 RVA: 0x0051B255 File Offset: 0x00519455
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnSoundBox3(INpcUiInteractOnSoundBox3T _inpcuiinteractonsoundbox3)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnSoundBox3,
				Value = _inpcuiinteractonsoundbox3
			};
		}

		// Token: 0x06024F95 RID: 151445 RVA: 0x0051B26A File Offset: 0x0051946A
		public INpcUiInteractOnSunSpiritT AsINpcUiInteractOnSunSpirit()
		{
			return this.As<INpcUiInteractOnSunSpiritT>();
		}

		// Token: 0x06024F96 RID: 151446 RVA: 0x0051B272 File Offset: 0x00519472
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnSunSpirit(INpcUiInteractOnSunSpiritT _inpcuiinteractonsunspirit)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnSunSpirit,
				Value = _inpcuiinteractonsunspirit
			};
		}

		// Token: 0x06024F97 RID: 151447 RVA: 0x0051B287 File Offset: 0x00519487
		public INpcUiInteractOnShopNewT AsINpcUiInteractOnShopNew()
		{
			return this.As<INpcUiInteractOnShopNewT>();
		}

		// Token: 0x06024F98 RID: 151448 RVA: 0x0051B28F File Offset: 0x0051948F
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnShopNew(INpcUiInteractOnShopNewT _inpcuiinteractonshopnew)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnShopNew,
				Value = _inpcuiinteractonshopnew
			};
		}

		// Token: 0x06024F99 RID: 151449 RVA: 0x0051B2A5 File Offset: 0x005194A5
		public INpcUiInteractOnVillageInfrT AsINpcUiInteractOnVillageInfr()
		{
			return this.As<INpcUiInteractOnVillageInfrT>();
		}

		// Token: 0x06024F9A RID: 151450 RVA: 0x0051B2AD File Offset: 0x005194AD
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnVillageInfr(INpcUiInteractOnVillageInfrT _inpcuiinteractonvillageinfr)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnVillageInfr,
				Value = _inpcuiinteractonvillageinfr
			};
		}

		// Token: 0x06024F9B RID: 151451 RVA: 0x0051B2C3 File Offset: 0x005194C3
		public INpcUiInteractOnSoundBox35T AsINpcUiInteractOnSoundBox35()
		{
			return this.As<INpcUiInteractOnSoundBox35T>();
		}

		// Token: 0x06024F9C RID: 151452 RVA: 0x0051B2CB File Offset: 0x005194CB
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnSoundBox35(INpcUiInteractOnSoundBox35T _inpcuiinteractonsoundbox35)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnSoundBox35,
				Value = _inpcuiinteractonsoundbox35
			};
		}

		// Token: 0x06024F9D RID: 151453 RVA: 0x0051B2E1 File Offset: 0x005194E1
		public INpcUiInteractOnDollGrabDeliveryT AsINpcUiInteractOnDollGrabDelivery()
		{
			return this.As<INpcUiInteractOnDollGrabDeliveryT>();
		}

		// Token: 0x06024F9E RID: 151454 RVA: 0x0051B2E9 File Offset: 0x005194E9
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnDollGrabDelivery(INpcUiInteractOnDollGrabDeliveryT _inpcuiinteractondollgrabdelivery)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnDollGrabDelivery,
				Value = _inpcuiinteractondollgrabdelivery
			};
		}

		// Token: 0x06024F9F RID: 151455 RVA: 0x0051B300 File Offset: 0x00519500
		public static int Pack(FlatBufferBuilder builder, INpcUiInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcUiInteractType_Union.INpcUiInteractType:
				return INpcUiInteractType.Pack(builder, _o.AsINpcUiInteractType()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnHandInItem:
				return INpcUiInteractOnHandInItem.Pack(builder, _o.AsINpcUiInteractOnHandInItem()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnShop:
				return INpcUiInteractOnShop.Pack(builder, _o.AsINpcUiInteractOnShop()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnAntiqueShop:
				return INpcUiInteractOnAntiqueShop.Pack(builder, _o.AsINpcUiInteractOnAntiqueShop()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnChengXiaoShanShop:
				return INpcUiInteractOnChengXiaoShanShop.Pack(builder, _o.AsINpcUiInteractOnChengXiaoShanShop()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnGramophone:
				return INpcUiInteractOnGramophone.Pack(builder, _o.AsINpcUiInteractOnGramophone()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnSoundBox3:
				return INpcUiInteractOnSoundBox3.Pack(builder, _o.AsINpcUiInteractOnSoundBox3()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnSunSpirit:
				return INpcUiInteractOnSunSpirit.Pack(builder, _o.AsINpcUiInteractOnSunSpirit()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnShopNew:
				return INpcUiInteractOnShopNew.Pack(builder, _o.AsINpcUiInteractOnShopNew()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnVillageInfr:
				return INpcUiInteractOnVillageInfr.Pack(builder, _o.AsINpcUiInteractOnVillageInfr()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnSoundBox35:
				return INpcUiInteractOnSoundBox35.Pack(builder, _o.AsINpcUiInteractOnSoundBox35()).Value;
			case INpcUiInteractType_Union.INpcUiInteractOnDollGrabDelivery:
				return INpcUiInteractOnDollGrabDelivery.Pack(builder, _o.AsINpcUiInteractOnDollGrabDelivery()).Value;
			default:
				return 0;
			}
		}
	}
}
