using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B96 RID: 23446
	public class IWorldLevelBonusType_UnionUnion
	{
		// Token: 0x1700B12F RID: 45359
		// (get) Token: 0x06028237 RID: 164407 RVA: 0x005844AD File Offset: 0x005826AD
		// (set) Token: 0x06028238 RID: 164408 RVA: 0x005844B5 File Offset: 0x005826B5
		public IWorldLevelBonusType_Union Type { get; set; }

		// Token: 0x1700B130 RID: 45360
		// (get) Token: 0x06028239 RID: 164409 RVA: 0x005844BE File Offset: 0x005826BE
		// (set) Token: 0x0602823A RID: 164410 RVA: 0x005844C6 File Offset: 0x005826C6
		public object Value { get; set; }

		// Token: 0x0602823B RID: 164411 RVA: 0x005844CF File Offset: 0x005826CF
		public IWorldLevelBonusType_UnionUnion()
		{
			this.Type = IWorldLevelBonusType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602823C RID: 164412 RVA: 0x005844E5 File Offset: 0x005826E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602823D RID: 164413 RVA: 0x005844F7 File Offset: 0x005826F7
		public IWorldLevelBonusTypeT AsIWorldLevelBonusType()
		{
			return this.As<IWorldLevelBonusTypeT>();
		}

		// Token: 0x0602823E RID: 164414 RVA: 0x005844FF File Offset: 0x005826FF
		public static IWorldLevelBonusType_UnionUnion FromIWorldLevelBonusType(IWorldLevelBonusTypeT _iworldlevelbonustype)
		{
			return new IWorldLevelBonusType_UnionUnion
			{
				Type = IWorldLevelBonusType_Union.IWorldLevelBonusType,
				Value = _iworldlevelbonustype
			};
		}

		// Token: 0x0602823F RID: 164415 RVA: 0x00584514 File Offset: 0x00582714
		public IAreaBounsT AsIAreaBouns()
		{
			return this.As<IAreaBounsT>();
		}

		// Token: 0x06028240 RID: 164416 RVA: 0x0058451C File Offset: 0x0058271C
		public static IWorldLevelBonusType_UnionUnion FromIAreaBouns(IAreaBounsT _iareabouns)
		{
			return new IWorldLevelBonusType_UnionUnion
			{
				Type = IWorldLevelBonusType_Union.IAreaBouns,
				Value = _iareabouns
			};
		}

		// Token: 0x06028241 RID: 164417 RVA: 0x00584531 File Offset: 0x00582731
		public IWorldLevelTableT AsIWorldLevelTable()
		{
			return this.As<IWorldLevelTableT>();
		}

		// Token: 0x06028242 RID: 164418 RVA: 0x00584539 File Offset: 0x00582739
		public static IWorldLevelBonusType_UnionUnion FromIWorldLevelTable(IWorldLevelTableT _iworldleveltable)
		{
			return new IWorldLevelBonusType_UnionUnion
			{
				Type = IWorldLevelBonusType_Union.IWorldLevelTable,
				Value = _iworldleveltable
			};
		}

		// Token: 0x06028243 RID: 164419 RVA: 0x00584550 File Offset: 0x00582750
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
