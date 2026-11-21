using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C31 RID: 23601
	public class INpcUiInteractType_UnionUnion
	{
		// Token: 0x1700AD58 RID: 44376
		// (get) Token: 0x060271BA RID: 160186 RVA: 0x0055BCF1 File Offset: 0x00559EF1
		// (set) Token: 0x060271BB RID: 160187 RVA: 0x0055BCF9 File Offset: 0x00559EF9
		public INpcUiInteractType_Union Type { get; set; }

		// Token: 0x1700AD59 RID: 44377
		// (get) Token: 0x060271BC RID: 160188 RVA: 0x0055BD02 File Offset: 0x00559F02
		// (set) Token: 0x060271BD RID: 160189 RVA: 0x0055BD0A File Offset: 0x00559F0A
		public object Value { get; set; }

		// Token: 0x060271BE RID: 160190 RVA: 0x0055BD13 File Offset: 0x00559F13
		public INpcUiInteractType_UnionUnion()
		{
			this.Type = INpcUiInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060271BF RID: 160191 RVA: 0x0055BD29 File Offset: 0x00559F29
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060271C0 RID: 160192 RVA: 0x0055BD3B File Offset: 0x00559F3B
		public INpcUiInteractTypeT AsINpcUiInteractType()
		{
			return this.As<INpcUiInteractTypeT>();
		}

		// Token: 0x060271C1 RID: 160193 RVA: 0x0055BD43 File Offset: 0x00559F43
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractType(INpcUiInteractTypeT _inpcuiinteracttype)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractType,
				Value = _inpcuiinteracttype
			};
		}

		// Token: 0x060271C2 RID: 160194 RVA: 0x0055BD58 File Offset: 0x00559F58
		public INpcUiInteractOnHandInItemT AsINpcUiInteractOnHandInItem()
		{
			return this.As<INpcUiInteractOnHandInItemT>();
		}

		// Token: 0x060271C3 RID: 160195 RVA: 0x0055BD60 File Offset: 0x00559F60
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnHandInItem(INpcUiInteractOnHandInItemT _inpcuiinteractonhandinitem)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnHandInItem,
				Value = _inpcuiinteractonhandinitem
			};
		}

		// Token: 0x060271C4 RID: 160196 RVA: 0x0055BD75 File Offset: 0x00559F75
		public INpcUiInteractOnShopT AsINpcUiInteractOnShop()
		{
			return this.As<INpcUiInteractOnShopT>();
		}

		// Token: 0x060271C5 RID: 160197 RVA: 0x0055BD7D File Offset: 0x00559F7D
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnShop(INpcUiInteractOnShopT _inpcuiinteractonshop)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnShop,
				Value = _inpcuiinteractonshop
			};
		}

		// Token: 0x060271C6 RID: 160198 RVA: 0x0055BD92 File Offset: 0x00559F92
		public INpcUiInteractOnAntiqueShopT AsINpcUiInteractOnAntiqueShop()
		{
			return this.As<INpcUiInteractOnAntiqueShopT>();
		}

		// Token: 0x060271C7 RID: 160199 RVA: 0x0055BD9A File Offset: 0x00559F9A
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnAntiqueShop(INpcUiInteractOnAntiqueShopT _inpcuiinteractonantiqueshop)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnAntiqueShop,
				Value = _inpcuiinteractonantiqueshop
			};
		}

		// Token: 0x060271C8 RID: 160200 RVA: 0x0055BDAF File Offset: 0x00559FAF
		public INpcUiInteractOnChengXiaoShanShopT AsINpcUiInteractOnChengXiaoShanShop()
		{
			return this.As<INpcUiInteractOnChengXiaoShanShopT>();
		}

		// Token: 0x060271C9 RID: 160201 RVA: 0x0055BDB7 File Offset: 0x00559FB7
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnChengXiaoShanShop(INpcUiInteractOnChengXiaoShanShopT _inpcuiinteractonchengxiaoshanshop)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnChengXiaoShanShop,
				Value = _inpcuiinteractonchengxiaoshanshop
			};
		}

		// Token: 0x060271CA RID: 160202 RVA: 0x0055BDCC File Offset: 0x00559FCC
		public INpcUiInteractOnGramophoneT AsINpcUiInteractOnGramophone()
		{
			return this.As<INpcUiInteractOnGramophoneT>();
		}

		// Token: 0x060271CB RID: 160203 RVA: 0x0055BDD4 File Offset: 0x00559FD4
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnGramophone(INpcUiInteractOnGramophoneT _inpcuiinteractongramophone)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnGramophone,
				Value = _inpcuiinteractongramophone
			};
		}

		// Token: 0x060271CC RID: 160204 RVA: 0x0055BDE9 File Offset: 0x00559FE9
		public INpcUiInteractOnSoundBox3T AsINpcUiInteractOnSoundBox3()
		{
			return this.As<INpcUiInteractOnSoundBox3T>();
		}

		// Token: 0x060271CD RID: 160205 RVA: 0x0055BDF1 File Offset: 0x00559FF1
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnSoundBox3(INpcUiInteractOnSoundBox3T _inpcuiinteractonsoundbox3)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnSoundBox3,
				Value = _inpcuiinteractonsoundbox3
			};
		}

		// Token: 0x060271CE RID: 160206 RVA: 0x0055BE06 File Offset: 0x0055A006
		public INpcUiInteractOnSunSpiritT AsINpcUiInteractOnSunSpirit()
		{
			return this.As<INpcUiInteractOnSunSpiritT>();
		}

		// Token: 0x060271CF RID: 160207 RVA: 0x0055BE0E File Offset: 0x0055A00E
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnSunSpirit(INpcUiInteractOnSunSpiritT _inpcuiinteractonsunspirit)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnSunSpirit,
				Value = _inpcuiinteractonsunspirit
			};
		}

		// Token: 0x060271D0 RID: 160208 RVA: 0x0055BE23 File Offset: 0x0055A023
		public INpcUiInteractOnShopNewT AsINpcUiInteractOnShopNew()
		{
			return this.As<INpcUiInteractOnShopNewT>();
		}

		// Token: 0x060271D1 RID: 160209 RVA: 0x0055BE2B File Offset: 0x0055A02B
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnShopNew(INpcUiInteractOnShopNewT _inpcuiinteractonshopnew)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnShopNew,
				Value = _inpcuiinteractonshopnew
			};
		}

		// Token: 0x060271D2 RID: 160210 RVA: 0x0055BE41 File Offset: 0x0055A041
		public INpcUiInteractOnVillageInfrT AsINpcUiInteractOnVillageInfr()
		{
			return this.As<INpcUiInteractOnVillageInfrT>();
		}

		// Token: 0x060271D3 RID: 160211 RVA: 0x0055BE49 File Offset: 0x0055A049
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnVillageInfr(INpcUiInteractOnVillageInfrT _inpcuiinteractonvillageinfr)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnVillageInfr,
				Value = _inpcuiinteractonvillageinfr
			};
		}

		// Token: 0x060271D4 RID: 160212 RVA: 0x0055BE5F File Offset: 0x0055A05F
		public INpcUiInteractOnSoundBox35T AsINpcUiInteractOnSoundBox35()
		{
			return this.As<INpcUiInteractOnSoundBox35T>();
		}

		// Token: 0x060271D5 RID: 160213 RVA: 0x0055BE67 File Offset: 0x0055A067
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnSoundBox35(INpcUiInteractOnSoundBox35T _inpcuiinteractonsoundbox35)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnSoundBox35,
				Value = _inpcuiinteractonsoundbox35
			};
		}

		// Token: 0x060271D6 RID: 160214 RVA: 0x0055BE7D File Offset: 0x0055A07D
		public INpcUiInteractOnDollGrabDeliveryT AsINpcUiInteractOnDollGrabDelivery()
		{
			return this.As<INpcUiInteractOnDollGrabDeliveryT>();
		}

		// Token: 0x060271D7 RID: 160215 RVA: 0x0055BE85 File Offset: 0x0055A085
		public static INpcUiInteractType_UnionUnion FromINpcUiInteractOnDollGrabDelivery(INpcUiInteractOnDollGrabDeliveryT _inpcuiinteractondollgrabdelivery)
		{
			return new INpcUiInteractType_UnionUnion
			{
				Type = INpcUiInteractType_Union.INpcUiInteractOnDollGrabDelivery,
				Value = _inpcuiinteractondollgrabdelivery
			};
		}

		// Token: 0x060271D8 RID: 160216 RVA: 0x0055BE9C File Offset: 0x0055A09C
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
