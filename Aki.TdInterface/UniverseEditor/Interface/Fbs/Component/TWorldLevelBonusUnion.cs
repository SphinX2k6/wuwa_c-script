using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD9 RID: 23769
	public class TWorldLevelBonusUnion
	{
		// Token: 0x1700B26E RID: 45678
		// (get) Token: 0x06028ABF RID: 166591 RVA: 0x005964CA File Offset: 0x005946CA
		// (set) Token: 0x06028AC0 RID: 166592 RVA: 0x005964D2 File Offset: 0x005946D2
		public TWorldLevelBonus Type { get; set; }

		// Token: 0x1700B26F RID: 45679
		// (get) Token: 0x06028AC1 RID: 166593 RVA: 0x005964DB File Offset: 0x005946DB
		// (set) Token: 0x06028AC2 RID: 166594 RVA: 0x005964E3 File Offset: 0x005946E3
		public object Value { get; set; }

		// Token: 0x06028AC3 RID: 166595 RVA: 0x005964EC File Offset: 0x005946EC
		public TWorldLevelBonusUnion()
		{
			this.Type = TWorldLevelBonus.NONE;
			this.Value = null;
		}

		// Token: 0x06028AC4 RID: 166596 RVA: 0x00596502 File Offset: 0x00594702
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028AC5 RID: 166597 RVA: 0x00596514 File Offset: 0x00594714
		public IAreaBounsT AsIAreaBouns()
		{
			return this.As<IAreaBounsT>();
		}

		// Token: 0x06028AC6 RID: 166598 RVA: 0x0059651C File Offset: 0x0059471C
		public static TWorldLevelBonusUnion FromIAreaBouns(IAreaBounsT _iareabouns)
		{
			return new TWorldLevelBonusUnion
			{
				Type = TWorldLevelBonus.IAreaBouns,
				Value = _iareabouns
			};
		}

		// Token: 0x06028AC7 RID: 166599 RVA: 0x00596531 File Offset: 0x00594731
		public IWorldLevelTableT AsIWorldLevelTable()
		{
			return this.As<IWorldLevelTableT>();
		}

		// Token: 0x06028AC8 RID: 166600 RVA: 0x00596539 File Offset: 0x00594739
		public static TWorldLevelBonusUnion FromIWorldLevelTable(IWorldLevelTableT _iworldleveltable)
		{
			return new TWorldLevelBonusUnion
			{
				Type = TWorldLevelBonus.IWorldLevelTable,
				Value = _iworldleveltable
			};
		}

		// Token: 0x06028AC9 RID: 166601 RVA: 0x00596550 File Offset: 0x00594750
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
