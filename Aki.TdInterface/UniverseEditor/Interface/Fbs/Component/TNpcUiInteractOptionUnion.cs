using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062A4 RID: 25252
	public class TNpcUiInteractOptionUnion
	{
		// Token: 0x1700BB84 RID: 48004
		// (get) Token: 0x0602AF15 RID: 175893 RVA: 0x005DBE9C File Offset: 0x005DA09C
		// (set) Token: 0x0602AF16 RID: 175894 RVA: 0x005DBEA4 File Offset: 0x005DA0A4
		public TNpcUiInteractOption Type { get; set; }

		// Token: 0x1700BB85 RID: 48005
		// (get) Token: 0x0602AF17 RID: 175895 RVA: 0x005DBEAD File Offset: 0x005DA0AD
		// (set) Token: 0x0602AF18 RID: 175896 RVA: 0x005DBEB5 File Offset: 0x005DA0B5
		public object Value { get; set; }

		// Token: 0x0602AF19 RID: 175897 RVA: 0x005DBEBE File Offset: 0x005DA0BE
		public TNpcUiInteractOptionUnion()
		{
			this.Type = TNpcUiInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF1A RID: 175898 RVA: 0x005DBED4 File Offset: 0x005DA0D4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF1B RID: 175899 RVA: 0x005DBEE6 File Offset: 0x005DA0E6
		public INpcUiInteractOnAntiqueShopT AsINpcUiInteractOnAntiqueShop()
		{
			return this.As<INpcUiInteractOnAntiqueShopT>();
		}

		// Token: 0x0602AF1C RID: 175900 RVA: 0x005DBEEE File Offset: 0x005DA0EE
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnAntiqueShop(INpcUiInteractOnAntiqueShopT _inpcuiinteractonantiqueshop)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnAntiqueShop,
				Value = _inpcuiinteractonantiqueshop
			};
		}

		// Token: 0x0602AF1D RID: 175901 RVA: 0x005DBF03 File Offset: 0x005DA103
		public INpcUiInteractOnChengXiaoShanShopT AsINpcUiInteractOnChengXiaoShanShop()
		{
			return this.As<INpcUiInteractOnChengXiaoShanShopT>();
		}

		// Token: 0x0602AF1E RID: 175902 RVA: 0x005DBF0B File Offset: 0x005DA10B
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnChengXiaoShanShop(INpcUiInteractOnChengXiaoShanShopT _inpcuiinteractonchengxiaoshanshop)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnChengXiaoShanShop,
				Value = _inpcuiinteractonchengxiaoshanshop
			};
		}

		// Token: 0x0602AF1F RID: 175903 RVA: 0x005DBF20 File Offset: 0x005DA120
		public INpcUiInteractOnDollGrabDeliveryT AsINpcUiInteractOnDollGrabDelivery()
		{
			return this.As<INpcUiInteractOnDollGrabDeliveryT>();
		}

		// Token: 0x0602AF20 RID: 175904 RVA: 0x005DBF28 File Offset: 0x005DA128
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnDollGrabDelivery(INpcUiInteractOnDollGrabDeliveryT _inpcuiinteractondollgrabdelivery)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnDollGrabDelivery,
				Value = _inpcuiinteractondollgrabdelivery
			};
		}

		// Token: 0x0602AF21 RID: 175905 RVA: 0x005DBF3D File Offset: 0x005DA13D
		public INpcUiInteractOnGramophoneT AsINpcUiInteractOnGramophone()
		{
			return this.As<INpcUiInteractOnGramophoneT>();
		}

		// Token: 0x0602AF22 RID: 175906 RVA: 0x005DBF45 File Offset: 0x005DA145
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnGramophone(INpcUiInteractOnGramophoneT _inpcuiinteractongramophone)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnGramophone,
				Value = _inpcuiinteractongramophone
			};
		}

		// Token: 0x0602AF23 RID: 175907 RVA: 0x005DBF5A File Offset: 0x005DA15A
		public INpcUiInteractOnHandInItemT AsINpcUiInteractOnHandInItem()
		{
			return this.As<INpcUiInteractOnHandInItemT>();
		}

		// Token: 0x0602AF24 RID: 175908 RVA: 0x005DBF62 File Offset: 0x005DA162
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnHandInItem(INpcUiInteractOnHandInItemT _inpcuiinteractonhandinitem)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnHandInItem,
				Value = _inpcuiinteractonhandinitem
			};
		}

		// Token: 0x0602AF25 RID: 175909 RVA: 0x005DBF77 File Offset: 0x005DA177
		public INpcUiInteractOnShopT AsINpcUiInteractOnShop()
		{
			return this.As<INpcUiInteractOnShopT>();
		}

		// Token: 0x0602AF26 RID: 175910 RVA: 0x005DBF7F File Offset: 0x005DA17F
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnShop(INpcUiInteractOnShopT _inpcuiinteractonshop)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnShop,
				Value = _inpcuiinteractonshop
			};
		}

		// Token: 0x0602AF27 RID: 175911 RVA: 0x005DBF94 File Offset: 0x005DA194
		public INpcUiInteractOnShopNewT AsINpcUiInteractOnShopNew()
		{
			return this.As<INpcUiInteractOnShopNewT>();
		}

		// Token: 0x0602AF28 RID: 175912 RVA: 0x005DBF9C File Offset: 0x005DA19C
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnShopNew(INpcUiInteractOnShopNewT _inpcuiinteractonshopnew)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnShopNew,
				Value = _inpcuiinteractonshopnew
			};
		}

		// Token: 0x0602AF29 RID: 175913 RVA: 0x005DBFB1 File Offset: 0x005DA1B1
		public INpcUiInteractOnSoundBox3T AsINpcUiInteractOnSoundBox3()
		{
			return this.As<INpcUiInteractOnSoundBox3T>();
		}

		// Token: 0x0602AF2A RID: 175914 RVA: 0x005DBFB9 File Offset: 0x005DA1B9
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnSoundBox3(INpcUiInteractOnSoundBox3T _inpcuiinteractonsoundbox3)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnSoundBox3,
				Value = _inpcuiinteractonsoundbox3
			};
		}

		// Token: 0x0602AF2B RID: 175915 RVA: 0x005DBFCE File Offset: 0x005DA1CE
		public INpcUiInteractOnSoundBox35T AsINpcUiInteractOnSoundBox35()
		{
			return this.As<INpcUiInteractOnSoundBox35T>();
		}

		// Token: 0x0602AF2C RID: 175916 RVA: 0x005DBFD6 File Offset: 0x005DA1D6
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnSoundBox35(INpcUiInteractOnSoundBox35T _inpcuiinteractonsoundbox35)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnSoundBox35,
				Value = _inpcuiinteractonsoundbox35
			};
		}

		// Token: 0x0602AF2D RID: 175917 RVA: 0x005DBFEC File Offset: 0x005DA1EC
		public INpcUiInteractOnSunSpiritT AsINpcUiInteractOnSunSpirit()
		{
			return this.As<INpcUiInteractOnSunSpiritT>();
		}

		// Token: 0x0602AF2E RID: 175918 RVA: 0x005DBFF4 File Offset: 0x005DA1F4
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnSunSpirit(INpcUiInteractOnSunSpiritT _inpcuiinteractonsunspirit)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnSunSpirit,
				Value = _inpcuiinteractonsunspirit
			};
		}

		// Token: 0x0602AF2F RID: 175919 RVA: 0x005DC00A File Offset: 0x005DA20A
		public INpcUiInteractOnVillageInfrT AsINpcUiInteractOnVillageInfr()
		{
			return this.As<INpcUiInteractOnVillageInfrT>();
		}

		// Token: 0x0602AF30 RID: 175920 RVA: 0x005DC012 File Offset: 0x005DA212
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnVillageInfr(INpcUiInteractOnVillageInfrT _inpcuiinteractonvillageinfr)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnVillageInfr,
				Value = _inpcuiinteractonvillageinfr
			};
		}

		// Token: 0x0602AF31 RID: 175921 RVA: 0x005DC028 File Offset: 0x005DA228
		public static int Pack(FlatBufferBuilder builder, TNpcUiInteractOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TNpcUiInteractOption.INpcUiInteractOnAntiqueShop:
				return INpcUiInteractOnAntiqueShop.Pack(builder, _o.AsINpcUiInteractOnAntiqueShop()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnChengXiaoShanShop:
				return INpcUiInteractOnChengXiaoShanShop.Pack(builder, _o.AsINpcUiInteractOnChengXiaoShanShop()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnDollGrabDelivery:
				return INpcUiInteractOnDollGrabDelivery.Pack(builder, _o.AsINpcUiInteractOnDollGrabDelivery()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnGramophone:
				return INpcUiInteractOnGramophone.Pack(builder, _o.AsINpcUiInteractOnGramophone()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnHandInItem:
				return INpcUiInteractOnHandInItem.Pack(builder, _o.AsINpcUiInteractOnHandInItem()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnShop:
				return INpcUiInteractOnShop.Pack(builder, _o.AsINpcUiInteractOnShop()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnShopNew:
				return INpcUiInteractOnShopNew.Pack(builder, _o.AsINpcUiInteractOnShopNew()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnSoundBox3:
				return INpcUiInteractOnSoundBox3.Pack(builder, _o.AsINpcUiInteractOnSoundBox3()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnSoundBox35:
				return INpcUiInteractOnSoundBox35.Pack(builder, _o.AsINpcUiInteractOnSoundBox35()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnSunSpirit:
				return INpcUiInteractOnSunSpirit.Pack(builder, _o.AsINpcUiInteractOnSunSpirit()).Value;
			case TNpcUiInteractOption.INpcUiInteractOnVillageInfr:
				return INpcUiInteractOnVillageInfr.Pack(builder, _o.AsINpcUiInteractOnVillageInfr()).Value;
			default:
				return 0;
			}
		}
	}
}
