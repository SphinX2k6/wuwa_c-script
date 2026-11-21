using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061AC RID: 25004
	public class IWorldLevelBonusType_UnionUnion
	{
		// Token: 0x1700BA77 RID: 47735
		// (get) Token: 0x0602A7FB RID: 174075 RVA: 0x005CBF3D File Offset: 0x005CA13D
		// (set) Token: 0x0602A7FC RID: 174076 RVA: 0x005CBF45 File Offset: 0x005CA145
		public IWorldLevelBonusType_Union Type { get; set; }

		// Token: 0x1700BA78 RID: 47736
		// (get) Token: 0x0602A7FD RID: 174077 RVA: 0x005CBF4E File Offset: 0x005CA14E
		// (set) Token: 0x0602A7FE RID: 174078 RVA: 0x005CBF56 File Offset: 0x005CA156
		public object Value { get; set; }

		// Token: 0x0602A7FF RID: 174079 RVA: 0x005CBF5F File Offset: 0x005CA15F
		public IWorldLevelBonusType_UnionUnion()
		{
			this.Type = IWorldLevelBonusType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A800 RID: 174080 RVA: 0x005CBF75 File Offset: 0x005CA175
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A801 RID: 174081 RVA: 0x005CBF87 File Offset: 0x005CA187
		public IWorldLevelBonusTypeT AsIWorldLevelBonusType()
		{
			return this.As<IWorldLevelBonusTypeT>();
		}

		// Token: 0x0602A802 RID: 174082 RVA: 0x005CBF8F File Offset: 0x005CA18F
		public static IWorldLevelBonusType_UnionUnion FromIWorldLevelBonusType(IWorldLevelBonusTypeT _iworldlevelbonustype)
		{
			return new IWorldLevelBonusType_UnionUnion
			{
				Type = IWorldLevelBonusType_Union.IWorldLevelBonusType,
				Value = _iworldlevelbonustype
			};
		}

		// Token: 0x0602A803 RID: 174083 RVA: 0x005CBFA4 File Offset: 0x005CA1A4
		public IAreaBounsT AsIAreaBouns()
		{
			return this.As<IAreaBounsT>();
		}

		// Token: 0x0602A804 RID: 174084 RVA: 0x005CBFAC File Offset: 0x005CA1AC
		public static IWorldLevelBonusType_UnionUnion FromIAreaBouns(IAreaBounsT _iareabouns)
		{
			return new IWorldLevelBonusType_UnionUnion
			{
				Type = IWorldLevelBonusType_Union.IAreaBouns,
				Value = _iareabouns
			};
		}

		// Token: 0x0602A805 RID: 174085 RVA: 0x005CBFC1 File Offset: 0x005CA1C1
		public IWorldLevelTableT AsIWorldLevelTable()
		{
			return this.As<IWorldLevelTableT>();
		}

		// Token: 0x0602A806 RID: 174086 RVA: 0x005CBFC9 File Offset: 0x005CA1C9
		public static IWorldLevelBonusType_UnionUnion FromIWorldLevelTable(IWorldLevelTableT _iworldleveltable)
		{
			return new IWorldLevelBonusType_UnionUnion
			{
				Type = IWorldLevelBonusType_Union.IWorldLevelTable,
				Value = _iworldleveltable
			};
		}

		// Token: 0x0602A807 RID: 174087 RVA: 0x005CBFE0 File Offset: 0x005CA1E0
		public static int Pack(FlatBufferBuilder builder, IWorldLevelBonusType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IWorldLevelBonusType_Union.IWorldLevelBonusType:
				return IWorldLevelBonusType.Pack(builder, _o.AsIWorldLevelBonusType()).Value;
			case IWorldLevelBonusType_Union.IAreaBouns:
				return IAreaBouns.Pack(builder, _o.AsIAreaBouns()).Value;
			case IWorldLevelBonusType_Union.IWorldLevelTable:
				return IWorldLevelTable.Pack(builder, _o.AsIWorldLevelTable()).Value;
			default:
				return 0;
			}
		}
	}
}
