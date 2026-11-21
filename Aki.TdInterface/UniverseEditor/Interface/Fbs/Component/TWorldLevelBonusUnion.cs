using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200630D RID: 25357
	public class TWorldLevelBonusUnion
	{
		// Token: 0x1700BBCA RID: 48074
		// (get) Token: 0x0602B113 RID: 176403 RVA: 0x005DED3A File Offset: 0x005DCF3A
		// (set) Token: 0x0602B114 RID: 176404 RVA: 0x005DED42 File Offset: 0x005DCF42
		public TWorldLevelBonus Type { get; set; }

		// Token: 0x1700BBCB RID: 48075
		// (get) Token: 0x0602B115 RID: 176405 RVA: 0x005DED4B File Offset: 0x005DCF4B
		// (set) Token: 0x0602B116 RID: 176406 RVA: 0x005DED53 File Offset: 0x005DCF53
		public object Value { get; set; }

		// Token: 0x0602B117 RID: 176407 RVA: 0x005DED5C File Offset: 0x005DCF5C
		public TWorldLevelBonusUnion()
		{
			this.Type = TWorldLevelBonus.NONE;
			this.Value = null;
		}

		// Token: 0x0602B118 RID: 176408 RVA: 0x005DED72 File Offset: 0x005DCF72
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B119 RID: 176409 RVA: 0x005DED84 File Offset: 0x005DCF84
		public IAreaBounsT AsIAreaBouns()
		{
			return this.As<IAreaBounsT>();
		}

		// Token: 0x0602B11A RID: 176410 RVA: 0x005DED8C File Offset: 0x005DCF8C
		public static TWorldLevelBonusUnion FromIAreaBouns(IAreaBounsT _iareabouns)
		{
			return new TWorldLevelBonusUnion
			{
				Type = TWorldLevelBonus.IAreaBouns,
				Value = _iareabouns
			};
		}

		// Token: 0x0602B11B RID: 176411 RVA: 0x005DEDA1 File Offset: 0x005DCFA1
		public IWorldLevelTableT AsIWorldLevelTable()
		{
			return this.As<IWorldLevelTableT>();
		}

		// Token: 0x0602B11C RID: 176412 RVA: 0x005DEDA9 File Offset: 0x005DCFA9
		public static TWorldLevelBonusUnion FromIWorldLevelTable(IWorldLevelTableT _iworldleveltable)
		{
			return new TWorldLevelBonusUnion
			{
				Type = TWorldLevelBonus.IWorldLevelTable,
				Value = _iworldleveltable
			};
		}

		// Token: 0x0602B11D RID: 176413 RVA: 0x005DEDC0 File Offset: 0x005DCFC0
		public static int Pack(FlatBufferBuilder builder, TWorldLevelBonusUnion _o)
		{
			TWorldLevelBonus type = _o.Type;
			if (type == TWorldLevelBonus.IAreaBouns)
			{
				return IAreaBouns.Pack(builder, _o.AsIAreaBouns()).Value;
			}
			if (type != TWorldLevelBonus.IWorldLevelTable)
			{
				return 0;
			}
			return IWorldLevelTable.Pack(builder, _o.AsIWorldLevelTable()).Value;
		}
	}
}
