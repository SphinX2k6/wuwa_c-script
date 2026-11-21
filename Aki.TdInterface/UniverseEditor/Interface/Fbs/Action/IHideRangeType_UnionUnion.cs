using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAB RID: 28587
	public class IHideRangeType_UnionUnion
	{
		// Token: 0x1700D15F RID: 53599
		// (get) Token: 0x060317D5 RID: 202709 RVA: 0x006B54A1 File Offset: 0x006B36A1
		// (set) Token: 0x060317D6 RID: 202710 RVA: 0x006B54A9 File Offset: 0x006B36A9
		public IHideRangeType_Union Type { get; set; }

		// Token: 0x1700D160 RID: 53600
		// (get) Token: 0x060317D7 RID: 202711 RVA: 0x006B54B2 File Offset: 0x006B36B2
		// (set) Token: 0x060317D8 RID: 202712 RVA: 0x006B54BA File Offset: 0x006B36BA
		public object Value { get; set; }

		// Token: 0x060317D9 RID: 202713 RVA: 0x006B54C3 File Offset: 0x006B36C3
		public IHideRangeType_UnionUnion()
		{
			this.Type = IHideRangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060317DA RID: 202714 RVA: 0x006B54D9 File Offset: 0x006B36D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060317DB RID: 202715 RVA: 0x006B54EB File Offset: 0x006B36EB
		public IHideRangeTypeT AsIHideRangeType()
		{
			return this.As<IHideRangeTypeT>();
		}

		// Token: 0x060317DC RID: 202716 RVA: 0x006B54F3 File Offset: 0x006B36F3
		public static IHideRangeType_UnionUnion FromIHideRangeType(IHideRangeTypeT _ihiderangetype)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideRangeType,
				Value = _ihiderangetype
			};
		}

		// Token: 0x060317DD RID: 202717 RVA: 0x006B5508 File Offset: 0x006B3708
		public IHideWorldMonsterAndMonsterTreasureT AsIHideWorldMonsterAndMonsterTreasure()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureT>();
		}

		// Token: 0x060317DE RID: 202718 RVA: 0x006B5510 File Offset: 0x006B3710
		public static IHideRangeType_UnionUnion FromIHideWorldMonsterAndMonsterTreasure(IHideWorldMonsterAndMonsterTreasureT _ihideworldmonsterandmonstertreasure)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideWorldMonsterAndMonsterTreasure,
				Value = _ihideworldmonsterandmonstertreasure
			};
		}

		// Token: 0x060317DF RID: 202719 RVA: 0x006B5525 File Offset: 0x006B3725
		public IHideWorldEntityAndLevelPlayT AsIHideWorldEntityAndLevelPlay()
		{
			return this.As<IHideWorldEntityAndLevelPlayT>();
		}

		// Token: 0x060317E0 RID: 202720 RVA: 0x006B552D File Offset: 0x006B372D
		public static IHideRangeType_UnionUnion FromIHideWorldEntityAndLevelPlay(IHideWorldEntityAndLevelPlayT _ihideworldentityandlevelplay)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideWorldEntityAndLevelPlay,
				Value = _ihideworldentityandlevelplay
			};
		}

		// Token: 0x060317E1 RID: 202721 RVA: 0x006B5542 File Offset: 0x006B3742
		public IHideSpecifyEntityT AsIHideSpecifyEntity()
		{
			return this.As<IHideSpecifyEntityT>();
		}

		// Token: 0x060317E2 RID: 202722 RVA: 0x006B554A File Offset: 0x006B374A
		public static IHideRangeType_UnionUnion FromIHideSpecifyEntity(IHideSpecifyEntityT _ihidespecifyentity)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideSpecifyEntity,
				Value = _ihidespecifyentity
			};
		}

		// Token: 0x060317E3 RID: 202723 RVA: 0x006B5560 File Offset: 0x006B3760
		public static int Pack(FlatBufferBuilder builder, IHideRangeType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHideRangeType_Union.IHideRangeType:
				return IHideRangeType.Pack(builder, _o.AsIHideRangeType()).Value;
			case IHideRangeType_Union.IHideWorldMonsterAndMonsterTreasure:
				return IHideWorldMonsterAndMonsterTreasure.Pack(builder, _o.AsIHideWorldMonsterAndMonsterTreasure()).Value;
			case IHideRangeType_Union.IHideWorldEntityAndLevelPlay:
				return IHideWorldEntityAndLevelPlay.Pack(builder, _o.AsIHideWorldEntityAndLevelPlay()).Value;
			case IHideRangeType_Union.IHideSpecifyEntity:
				return IHideSpecifyEntity.Pack(builder, _o.AsIHideSpecifyEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
