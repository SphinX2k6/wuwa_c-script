using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065BF RID: 26047
	public class IDetectBattleTagType_UnionUnion
	{
		// Token: 0x1700C15A RID: 49498
		// (get) Token: 0x0602D2D3 RID: 185043 RVA: 0x00631A99 File Offset: 0x0062FC99
		// (set) Token: 0x0602D2D4 RID: 185044 RVA: 0x00631AA1 File Offset: 0x0062FCA1
		public IDetectBattleTagType_Union Type { get; set; }

		// Token: 0x1700C15B RID: 49499
		// (get) Token: 0x0602D2D5 RID: 185045 RVA: 0x00631AAA File Offset: 0x0062FCAA
		// (set) Token: 0x0602D2D6 RID: 185046 RVA: 0x00631AB2 File Offset: 0x0062FCB2
		public object Value { get; set; }

		// Token: 0x0602D2D7 RID: 185047 RVA: 0x00631ABB File Offset: 0x0062FCBB
		public IDetectBattleTagType_UnionUnion()
		{
			this.Type = IDetectBattleTagType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D2D8 RID: 185048 RVA: 0x00631AD1 File Offset: 0x0062FCD1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D2D9 RID: 185049 RVA: 0x00631AE3 File Offset: 0x0062FCE3
		public IDetectBattleTagTypeT AsIDetectBattleTagType()
		{
			return this.As<IDetectBattleTagTypeT>();
		}

		// Token: 0x0602D2DA RID: 185050 RVA: 0x00631AEB File Offset: 0x0062FCEB
		public static IDetectBattleTagType_UnionUnion FromIDetectBattleTagType(IDetectBattleTagTypeT _idetectbattletagtype)
		{
			return new IDetectBattleTagType_UnionUnion
			{
				Type = IDetectBattleTagType_Union.IDetectBattleTagType,
				Value = _idetectbattletagtype
			};
		}

		// Token: 0x0602D2DB RID: 185051 RVA: 0x00631B00 File Offset: 0x0062FD00
		public IDetectBattleMonsterOnGroundT AsIDetectBattleMonsterOnGround()
		{
			return this.As<IDetectBattleMonsterOnGroundT>();
		}

		// Token: 0x0602D2DC RID: 185052 RVA: 0x00631B08 File Offset: 0x0062FD08
		public static IDetectBattleTagType_UnionUnion FromIDetectBattleMonsterOnGround(IDetectBattleMonsterOnGroundT _idetectbattlemonsteronground)
		{
			return new IDetectBattleTagType_UnionUnion
			{
				Type = IDetectBattleTagType_Union.IDetectBattleMonsterOnGround,
				Value = _idetectbattlemonsteronground
			};
		}

		// Token: 0x0602D2DD RID: 185053 RVA: 0x00631B20 File Offset: 0x0062FD20
		public static int Pack(FlatBufferBuilder builder, IDetectBattleTagType_UnionUnion _o)
		{
			IDetectBattleTagType_Union type = _o.Type;
			if (type == IDetectBattleTagType_Union.IDetectBattleTagType)
			{
				return IDetectBattleTagType.Pack(builder, _o.AsIDetectBattleTagType()).Value;
			}
			if (type != IDetectBattleTagType_Union.IDetectBattleMonsterOnGround)
			{
				return 0;
			}
			return IDetectBattleMonsterOnGround.Pack(builder, _o.AsIDetectBattleMonsterOnGround()).Value;
		}
	}
}
