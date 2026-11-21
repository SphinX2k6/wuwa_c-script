using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F9C RID: 28572
	public class IHideGroupType_UnionUnion
	{
		// Token: 0x1700D145 RID: 53573
		// (get) Token: 0x06031761 RID: 202593 RVA: 0x006B48E9 File Offset: 0x006B2AE9
		// (set) Token: 0x06031762 RID: 202594 RVA: 0x006B48F1 File Offset: 0x006B2AF1
		public IHideGroupType_Union Type { get; set; }

		// Token: 0x1700D146 RID: 53574
		// (get) Token: 0x06031763 RID: 202595 RVA: 0x006B48FA File Offset: 0x006B2AFA
		// (set) Token: 0x06031764 RID: 202596 RVA: 0x006B4902 File Offset: 0x006B2B02
		public object Value { get; set; }

		// Token: 0x06031765 RID: 202597 RVA: 0x006B490B File Offset: 0x006B2B0B
		public IHideGroupType_UnionUnion()
		{
			this.Type = IHideGroupType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031766 RID: 202598 RVA: 0x006B4921 File Offset: 0x006B2B21
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031767 RID: 202599 RVA: 0x006B4933 File Offset: 0x006B2B33
		public IHideGroupTypeT AsIHideGroupType()
		{
			return this.As<IHideGroupTypeT>();
		}

		// Token: 0x06031768 RID: 202600 RVA: 0x006B493B File Offset: 0x006B2B3B
		public static IHideGroupType_UnionUnion FromIHideGroupType(IHideGroupTypeT _ihidegrouptype)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideGroupType,
				Value = _ihidegrouptype
			};
		}

		// Token: 0x06031769 RID: 202601 RVA: 0x006B4950 File Offset: 0x006B2B50
		public IHideWorldMonsterAndMonsterTreasureGroupT AsIHideWorldMonsterAndMonsterTreasureGroup()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureGroupT>();
		}

		// Token: 0x0603176A RID: 202602 RVA: 0x006B4958 File Offset: 0x006B2B58
		public static IHideGroupType_UnionUnion FromIHideWorldMonsterAndMonsterTreasureGroup(IHideWorldMonsterAndMonsterTreasureGroupT _ihideworldmonsterandmonstertreasuregroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideWorldMonsterAndMonsterTreasureGroup,
				Value = _ihideworldmonsterandmonstertreasuregroup
			};
		}

		// Token: 0x0603176B RID: 202603 RVA: 0x006B496D File Offset: 0x006B2B6D
		public IHideWorldEntityAndLevelPlayGroupT AsIHideWorldEntityAndLevelPlayGroup()
		{
			return this.As<IHideWorldEntityAndLevelPlayGroupT>();
		}

		// Token: 0x0603176C RID: 202604 RVA: 0x006B4975 File Offset: 0x006B2B75
		public static IHideGroupType_UnionUnion FromIHideWorldEntityAndLevelPlayGroup(IHideWorldEntityAndLevelPlayGroupT _ihideworldentityandlevelplaygroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideWorldEntityAndLevelPlayGroup,
				Value = _ihideworldentityandlevelplaygroup
			};
		}

		// Token: 0x0603176D RID: 202605 RVA: 0x006B498A File Offset: 0x006B2B8A
		public IHideSpecifyEntityGroupT AsIHideSpecifyEntityGroup()
		{
			return this.As<IHideSpecifyEntityGroupT>();
		}

		// Token: 0x0603176E RID: 202606 RVA: 0x006B4992 File Offset: 0x006B2B92
		public static IHideGroupType_UnionUnion FromIHideSpecifyEntityGroup(IHideSpecifyEntityGroupT _ihidespecifyentitygroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideSpecifyEntityGroup,
				Value = _ihidespecifyentitygroup
			};
		}

		// Token: 0x0603176F RID: 202607 RVA: 0x006B49A7 File Offset: 0x006B2BA7
		public IHideSpecifyLevelPlayGroupT AsIHideSpecifyLevelPlayGroup()
		{
			return this.As<IHideSpecifyLevelPlayGroupT>();
		}

		// Token: 0x06031770 RID: 202608 RVA: 0x006B49AF File Offset: 0x006B2BAF
		public static IHideGroupType_UnionUnion FromIHideSpecifyLevelPlayGroup(IHideSpecifyLevelPlayGroupT _ihidespecifylevelplaygroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideSpecifyLevelPlayGroup,
				Value = _ihidespecifylevelplaygroup
			};
		}

		// Token: 0x06031771 RID: 202609 RVA: 0x006B49C4 File Offset: 0x006B2BC4
		public IHideSpecifyDataLayersT AsIHideSpecifyDataLayers()
		{
			return this.As<IHideSpecifyDataLayersT>();
		}

		// Token: 0x06031772 RID: 202610 RVA: 0x006B49CC File Offset: 0x006B2BCC
		public static IHideGroupType_UnionUnion FromIHideSpecifyDataLayers(IHideSpecifyDataLayersT _ihidespecifydatalayers)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideSpecifyDataLayers,
				Value = _ihidespecifydatalayers
			};
		}

		// Token: 0x06031773 RID: 202611 RVA: 0x006B49E4 File Offset: 0x006B2BE4
		public static int Pack(FlatBufferBuilder builder, IHideGroupType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHideGroupType_Union.IHideGroupType:
				return IHideGroupType.Pack(builder, _o.AsIHideGroupType()).Value;
			case IHideGroupType_Union.IHideWorldMonsterAndMonsterTreasureGroup:
				return IHideWorldMonsterAndMonsterTreasureGroup.Pack(builder, _o.AsIHideWorldMonsterAndMonsterTreasureGroup()).Value;
			case IHideGroupType_Union.IHideWorldEntityAndLevelPlayGroup:
				return IHideWorldEntityAndLevelPlayGroup.Pack(builder, _o.AsIHideWorldEntityAndLevelPlayGroup()).Value;
			case IHideGroupType_Union.IHideSpecifyEntityGroup:
				return IHideSpecifyEntityGroup.Pack(builder, _o.AsIHideSpecifyEntityGroup()).Value;
			case IHideGroupType_Union.IHideSpecifyLevelPlayGroup:
				return IHideSpecifyLevelPlayGroup.Pack(builder, _o.AsIHideSpecifyLevelPlayGroup()).Value;
			case IHideGroupType_Union.IHideSpecifyDataLayers:
				return IHideSpecifyDataLayers.Pack(builder, _o.AsIHideSpecifyDataLayers()).Value;
			default:
				return 0;
			}
		}
	}
}
