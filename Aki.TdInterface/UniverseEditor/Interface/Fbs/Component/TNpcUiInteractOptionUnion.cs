using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7C RID: 23676
	public class TNpcUiInteractOptionUnion
	{
		// Token: 0x1700B230 RID: 45616
		// (get) Token: 0x060288F3 RID: 166131 RVA: 0x00593A58 File Offset: 0x00591C58
		// (set) Token: 0x060288F4 RID: 166132 RVA: 0x00593A60 File Offset: 0x00591C60
		public TNpcUiInteractOption Type { get; set; }

		// Token: 0x1700B231 RID: 45617
		// (get) Token: 0x060288F5 RID: 166133 RVA: 0x00593A69 File Offset: 0x00591C69
		// (set) Token: 0x060288F6 RID: 166134 RVA: 0x00593A71 File Offset: 0x00591C71
		public object Value { get; set; }

		// Token: 0x060288F7 RID: 166135 RVA: 0x00593A7A File Offset: 0x00591C7A
		public TNpcUiInteractOptionUnion()
		{
			this.Type = TNpcUiInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x060288F8 RID: 166136 RVA: 0x00593A90 File Offset: 0x00591C90
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060288F9 RID: 166137 RVA: 0x00593AA2 File Offset: 0x00591CA2
		public INpcUiInteractOnAntiqueShopT AsINpcUiInteractOnAntiqueShop()
		{
			return this.As<INpcUiInteractOnAntiqueShopT>();
		}

		// Token: 0x060288FA RID: 166138 RVA: 0x00593AAA File Offset: 0x00591CAA
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnAntiqueShop(INpcUiInteractOnAntiqueShopT _inpcuiinteractonantiqueshop)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnAntiqueShop,
				Value = _inpcuiinteractonantiqueshop
			};
		}

		// Token: 0x060288FB RID: 166139 RVA: 0x00593ABF File Offset: 0x00591CBF
		public INpcUiInteractOnChengXiaoShanShopT AsINpcUiInteractOnChengXiaoShanShop()
		{
			return this.As<INpcUiInteractOnChengXiaoShanShopT>();
		}

		// Token: 0x060288FC RID: 166140 RVA: 0x00593AC7 File Offset: 0x00591CC7
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnChengXiaoShanShop(INpcUiInteractOnChengXiaoShanShopT _inpcuiinteractonchengxiaoshanshop)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnChengXiaoShanShop,
				Value = _inpcuiinteractonchengxiaoshanshop
			};
		}

		// Token: 0x060288FD RID: 166141 RVA: 0x00593ADC File Offset: 0x00591CDC
		public INpcUiInteractOnDollGrabDeliveryT AsINpcUiInteractOnDollGrabDelivery()
		{
			return this.As<INpcUiInteractOnDollGrabDeliveryT>();
		}

		// Token: 0x060288FE RID: 166142 RVA: 0x00593AE4 File Offset: 0x00591CE4
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnDollGrabDelivery(INpcUiInteractOnDollGrabDeliveryT _inpcuiinteractondollgrabdelivery)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnDollGrabDelivery,
				Value = _inpcuiinteractondollgrabdelivery
			};
		}

		// Token: 0x060288FF RID: 166143 RVA: 0x00593AF9 File Offset: 0x00591CF9
		public INpcUiInteractOnGramophoneT AsINpcUiInteractOnGramophone()
		{
			return this.As<INpcUiInteractOnGramophoneT>();
		}

		// Token: 0x06028900 RID: 166144 RVA: 0x00593B01 File Offset: 0x00591D01
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnGramophone(INpcUiInteractOnGramophoneT _inpcuiinteractongramophone)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnGramophone,
				Value = _inpcuiinteractongramophone
			};
		}

		// Token: 0x06028901 RID: 166145 RVA: 0x00593B16 File Offset: 0x00591D16
		public INpcUiInteractOnHandInItemT AsINpcUiInteractOnHandInItem()
		{
			return this.As<INpcUiInteractOnHandInItemT>();
		}

		// Token: 0x06028902 RID: 166146 RVA: 0x00593B1E File Offset: 0x00591D1E
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnHandInItem(INpcUiInteractOnHandInItemT _inpcuiinteractonhandinitem)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnHandInItem,
				Value = _inpcuiinteractonhandinitem
			};
		}

		// Token: 0x06028903 RID: 166147 RVA: 0x00593B33 File Offset: 0x00591D33
		public INpcUiInteractOnShopT AsINpcUiInteractOnShop()
		{
			return this.As<INpcUiInteractOnShopT>();
		}

		// Token: 0x06028904 RID: 166148 RVA: 0x00593B3B File Offset: 0x00591D3B
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnShop(INpcUiInteractOnShopT _inpcuiinteractonshop)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnShop,
				Value = _inpcuiinteractonshop
			};
		}

		// Token: 0x06028905 RID: 166149 RVA: 0x00593B50 File Offset: 0x00591D50
		public INpcUiInteractOnShopNewT AsINpcUiInteractOnShopNew()
		{
			return this.As<INpcUiInteractOnShopNewT>();
		}

		// Token: 0x06028906 RID: 166150 RVA: 0x00593B58 File Offset: 0x00591D58
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnShopNew(INpcUiInteractOnShopNewT _inpcuiinteractonshopnew)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnShopNew,
				Value = _inpcuiinteractonshopnew
			};
		}

		// Token: 0x06028907 RID: 166151 RVA: 0x00593B6D File Offset: 0x00591D6D
		public INpcUiInteractOnSoundBox3T AsINpcUiInteractOnSoundBox3()
		{
			return this.As<INpcUiInteractOnSoundBox3T>();
		}

		// Token: 0x06028908 RID: 166152 RVA: 0x00593B75 File Offset: 0x00591D75
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnSoundBox3(INpcUiInteractOnSoundBox3T _inpcuiinteractonsoundbox3)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnSoundBox3,
				Value = _inpcuiinteractonsoundbox3
			};
		}

		// Token: 0x06028909 RID: 166153 RVA: 0x00593B8A File Offset: 0x00591D8A
		public INpcUiInteractOnSoundBox35T AsINpcUiInteractOnSoundBox35()
		{
			return this.As<INpcUiInteractOnSoundBox35T>();
		}

		// Token: 0x0602890A RID: 166154 RVA: 0x00593B92 File Offset: 0x00591D92
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnSoundBox35(INpcUiInteractOnSoundBox35T _inpcuiinteractonsoundbox35)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnSoundBox35,
				Value = _inpcuiinteractonsoundbox35
			};
		}

		// Token: 0x0602890B RID: 166155 RVA: 0x00593BA8 File Offset: 0x00591DA8
		public INpcUiInteractOnSunSpiritT AsINpcUiInteractOnSunSpirit()
		{
			return this.As<INpcUiInteractOnSunSpiritT>();
		}

		// Token: 0x0602890C RID: 166156 RVA: 0x00593BB0 File Offset: 0x00591DB0
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnSunSpirit(INpcUiInteractOnSunSpiritT _inpcuiinteractonsunspirit)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnSunSpirit,
				Value = _inpcuiinteractonsunspirit
			};
		}

		// Token: 0x0602890D RID: 166157 RVA: 0x00593BC6 File Offset: 0x00591DC6
		public INpcUiInteractOnVillageInfrT AsINpcUiInteractOnVillageInfr()
		{
			return this.As<INpcUiInteractOnVillageInfrT>();
		}

		// Token: 0x0602890E RID: 166158 RVA: 0x00593BCE File Offset: 0x00591DCE
		public static TNpcUiInteractOptionUnion FromINpcUiInteractOnVillageInfr(INpcUiInteractOnVillageInfrT _inpcuiinteractonvillageinfr)
		{
			return new TNpcUiInteractOptionUnion
			{
				Type = TNpcUiInteractOption.INpcUiInteractOnVillageInfr,
				Value = _inpcuiinteractonvillageinfr
			};
		}

		// Token: 0x0602890F RID: 166159 RVA: 0x00593BE4 File Offset: 0x00591DE4
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
