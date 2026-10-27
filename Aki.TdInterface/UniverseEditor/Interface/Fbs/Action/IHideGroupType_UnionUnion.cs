using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068EC RID: 26860
	public class IHideGroupType_UnionUnion
	{
		// Token: 0x1700C74B RID: 51019
		// (get) Token: 0x0602EDAF RID: 191919 RVA: 0x006647A1 File Offset: 0x006629A1
		// (set) Token: 0x0602EDB0 RID: 191920 RVA: 0x006647A9 File Offset: 0x006629A9
		public IHideGroupType_Union Type { get; set; }

		// Token: 0x1700C74C RID: 51020
		// (get) Token: 0x0602EDB1 RID: 191921 RVA: 0x006647B2 File Offset: 0x006629B2
		// (set) Token: 0x0602EDB2 RID: 191922 RVA: 0x006647BA File Offset: 0x006629BA
		public object Value { get; set; }

		// Token: 0x0602EDB3 RID: 191923 RVA: 0x006647C3 File Offset: 0x006629C3
		public IHideGroupType_UnionUnion()
		{
			this.Type = IHideGroupType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EDB4 RID: 191924 RVA: 0x006647D9 File Offset: 0x006629D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EDB5 RID: 191925 RVA: 0x006647EB File Offset: 0x006629EB
		public IHideGroupTypeT AsIHideGroupType()
		{
			return this.As<IHideGroupTypeT>();
		}

		// Token: 0x0602EDB6 RID: 191926 RVA: 0x006647F3 File Offset: 0x006629F3
		public static IHideGroupType_UnionUnion FromIHideGroupType(IHideGroupTypeT _ihidegrouptype)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideGroupType,
				Value = _ihidegrouptype
			};
		}

		// Token: 0x0602EDB7 RID: 191927 RVA: 0x00664808 File Offset: 0x00662A08
		public IHideWorldMonsterAndMonsterTreasureGroupT AsIHideWorldMonsterAndMonsterTreasureGroup()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureGroupT>();
		}

		// Token: 0x0602EDB8 RID: 191928 RVA: 0x00664810 File Offset: 0x00662A10
		public static IHideGroupType_UnionUnion FromIHideWorldMonsterAndMonsterTreasureGroup(IHideWorldMonsterAndMonsterTreasureGroupT _ihideworldmonsterandmonstertreasuregroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideWorldMonsterAndMonsterTreasureGroup,
				Value = _ihideworldmonsterandmonstertreasuregroup
			};
		}

		// Token: 0x0602EDB9 RID: 191929 RVA: 0x00664825 File Offset: 0x00662A25
		public IHideWorldEntityAndLevelPlayGroupT AsIHideWorldEntityAndLevelPlayGroup()
		{
			return this.As<IHideWorldEntityAndLevelPlayGroupT>();
		}

		// Token: 0x0602EDBA RID: 191930 RVA: 0x0066482D File Offset: 0x00662A2D
		public static IHideGroupType_UnionUnion FromIHideWorldEntityAndLevelPlayGroup(IHideWorldEntityAndLevelPlayGroupT _ihideworldentityandlevelplaygroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideWorldEntityAndLevelPlayGroup,
				Value = _ihideworldentityandlevelplaygroup
			};
		}

		// Token: 0x0602EDBB RID: 191931 RVA: 0x00664842 File Offset: 0x00662A42
		public IHideSpecifyEntityGroupT AsIHideSpecifyEntityGroup()
		{
			return this.As<IHideSpecifyEntityGroupT>();
		}

		// Token: 0x0602EDBC RID: 191932 RVA: 0x0066484A File Offset: 0x00662A4A
		public static IHideGroupType_UnionUnion FromIHideSpecifyEntityGroup(IHideSpecifyEntityGroupT _ihidespecifyentitygroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideSpecifyEntityGroup,
				Value = _ihidespecifyentitygroup
			};
		}

		// Token: 0x0602EDBD RID: 191933 RVA: 0x0066485F File Offset: 0x00662A5F
		public IHideSpecifyLevelPlayGroupT AsIHideSpecifyLevelPlayGroup()
		{
			return this.As<IHideSpecifyLevelPlayGroupT>();
		}

		// Token: 0x0602EDBE RID: 191934 RVA: 0x00664867 File Offset: 0x00662A67
		public static IHideGroupType_UnionUnion FromIHideSpecifyLevelPlayGroup(IHideSpecifyLevelPlayGroupT _ihidespecifylevelplaygroup)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideSpecifyLevelPlayGroup,
				Value = _ihidespecifylevelplaygroup
			};
		}

		// Token: 0x0602EDBF RID: 191935 RVA: 0x0066487C File Offset: 0x00662A7C
		public IHideSpecifyDataLayersT AsIHideSpecifyDataLayers()
		{
			return this.As<IHideSpecifyDataLayersT>();
		}

		// Token: 0x0602EDC0 RID: 191936 RVA: 0x00664884 File Offset: 0x00662A84
		public static IHideGroupType_UnionUnion FromIHideSpecifyDataLayers(IHideSpecifyDataLayersT _ihidespecifydatalayers)
		{
			return new IHideGroupType_UnionUnion
			{
				Type = IHideGroupType_Union.IHideSpecifyDataLayers,
				Value = _ihidespecifydatalayers
			};
		}

		// Token: 0x0602EDC1 RID: 191937 RVA: 0x0066489C File Offset: 0x00662A9C
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
