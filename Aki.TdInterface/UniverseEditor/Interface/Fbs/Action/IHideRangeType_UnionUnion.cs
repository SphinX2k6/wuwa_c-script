using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F8 RID: 26872
	public class IHideRangeType_UnionUnion
	{
		// Token: 0x1700C75C RID: 51036
		// (get) Token: 0x0602EE05 RID: 192005 RVA: 0x00664FB9 File Offset: 0x006631B9
		// (set) Token: 0x0602EE06 RID: 192006 RVA: 0x00664FC1 File Offset: 0x006631C1
		public IHideRangeType_Union Type { get; set; }

		// Token: 0x1700C75D RID: 51037
		// (get) Token: 0x0602EE07 RID: 192007 RVA: 0x00664FCA File Offset: 0x006631CA
		// (set) Token: 0x0602EE08 RID: 192008 RVA: 0x00664FD2 File Offset: 0x006631D2
		public object Value { get; set; }

		// Token: 0x0602EE09 RID: 192009 RVA: 0x00664FDB File Offset: 0x006631DB
		public IHideRangeType_UnionUnion()
		{
			this.Type = IHideRangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EE0A RID: 192010 RVA: 0x00664FF1 File Offset: 0x006631F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EE0B RID: 192011 RVA: 0x00665003 File Offset: 0x00663203
		public IHideRangeTypeT AsIHideRangeType()
		{
			return this.As<IHideRangeTypeT>();
		}

		// Token: 0x0602EE0C RID: 192012 RVA: 0x0066500B File Offset: 0x0066320B
		public static IHideRangeType_UnionUnion FromIHideRangeType(IHideRangeTypeT _ihiderangetype)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideRangeType,
				Value = _ihiderangetype
			};
		}

		// Token: 0x0602EE0D RID: 192013 RVA: 0x00665020 File Offset: 0x00663220
		public IHideWorldMonsterAndMonsterTreasureT AsIHideWorldMonsterAndMonsterTreasure()
		{
			return this.As<IHideWorldMonsterAndMonsterTreasureT>();
		}

		// Token: 0x0602EE0E RID: 192014 RVA: 0x00665028 File Offset: 0x00663228
		public static IHideRangeType_UnionUnion FromIHideWorldMonsterAndMonsterTreasure(IHideWorldMonsterAndMonsterTreasureT _ihideworldmonsterandmonstertreasure)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideWorldMonsterAndMonsterTreasure,
				Value = _ihideworldmonsterandmonstertreasure
			};
		}

		// Token: 0x0602EE0F RID: 192015 RVA: 0x0066503D File Offset: 0x0066323D
		public IHideWorldEntityAndLevelPlayT AsIHideWorldEntityAndLevelPlay()
		{
			return this.As<IHideWorldEntityAndLevelPlayT>();
		}

		// Token: 0x0602EE10 RID: 192016 RVA: 0x00665045 File Offset: 0x00663245
		public static IHideRangeType_UnionUnion FromIHideWorldEntityAndLevelPlay(IHideWorldEntityAndLevelPlayT _ihideworldentityandlevelplay)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideWorldEntityAndLevelPlay,
				Value = _ihideworldentityandlevelplay
			};
		}

		// Token: 0x0602EE11 RID: 192017 RVA: 0x0066505A File Offset: 0x0066325A
		public IHideSpecifyEntityT AsIHideSpecifyEntity()
		{
			return this.As<IHideSpecifyEntityT>();
		}

		// Token: 0x0602EE12 RID: 192018 RVA: 0x00665062 File Offset: 0x00663262
		public static IHideRangeType_UnionUnion FromIHideSpecifyEntity(IHideSpecifyEntityT _ihidespecifyentity)
		{
			return new IHideRangeType_UnionUnion
			{
				Type = IHideRangeType_Union.IHideSpecifyEntity,
				Value = _ihidespecifyentity
			};
		}

		// Token: 0x0602EE13 RID: 192019 RVA: 0x00665078 File Offset: 0x00663278
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
