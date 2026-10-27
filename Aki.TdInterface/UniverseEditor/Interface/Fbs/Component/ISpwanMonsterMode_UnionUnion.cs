using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005996 RID: 22934
	public class ISpwanMonsterMode_UnionUnion
	{
		// Token: 0x1700AC1C RID: 44060
		// (get) Token: 0x06026D72 RID: 159090 RVA: 0x005587D1 File Offset: 0x005569D1
		// (set) Token: 0x06026D73 RID: 159091 RVA: 0x005587D9 File Offset: 0x005569D9
		public ISpwanMonsterMode_Union Type { get; set; }

		// Token: 0x1700AC1D RID: 44061
		// (get) Token: 0x06026D74 RID: 159092 RVA: 0x005587E2 File Offset: 0x005569E2
		// (set) Token: 0x06026D75 RID: 159093 RVA: 0x005587EA File Offset: 0x005569EA
		public object Value { get; set; }

		// Token: 0x06026D76 RID: 159094 RVA: 0x005587F3 File Offset: 0x005569F3
		public ISpwanMonsterMode_UnionUnion()
		{
			this.Type = ISpwanMonsterMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026D77 RID: 159095 RVA: 0x00558809 File Offset: 0x00556A09
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026D78 RID: 159096 RVA: 0x0055881B File Offset: 0x00556A1B
		public ISpwanMonsterModeT AsISpwanMonsterMode()
		{
			return this.As<ISpwanMonsterModeT>();
		}

		// Token: 0x06026D79 RID: 159097 RVA: 0x00558823 File Offset: 0x00556A23
		public static ISpwanMonsterMode_UnionUnion FromISpwanMonsterMode(ISpwanMonsterModeT _ispwanmonstermode)
		{
			return new ISpwanMonsterMode_UnionUnion
			{
				Type = ISpwanMonsterMode_Union.ISpwanMonsterMode,
				Value = _ispwanmonstermode
			};
		}

		// Token: 0x06026D7A RID: 159098 RVA: 0x00558838 File Offset: 0x00556A38
		public ISpawnMonsterConstraintAnnularSectorT AsISpawnMonsterConstraintAnnularSector()
		{
			return this.As<ISpawnMonsterConstraintAnnularSectorT>();
		}

		// Token: 0x06026D7B RID: 159099 RVA: 0x00558840 File Offset: 0x00556A40
		public static ISpwanMonsterMode_UnionUnion FromISpawnMonsterConstraintAnnularSector(ISpawnMonsterConstraintAnnularSectorT _ispawnmonsterconstraintannularsector)
		{
			return new ISpwanMonsterMode_UnionUnion
			{
				Type = ISpwanMonsterMode_Union.ISpawnMonsterConstraintAnnularSector,
				Value = _ispawnmonsterconstraintannularsector
			};
		}

		// Token: 0x06026D7C RID: 159100 RVA: 0x00558858 File Offset: 0x00556A58
		public static int Pack(FlatBufferBuilder builder, ISpwanMonsterMode_UnionUnion _o)
		{
			ISpwanMonsterMode_Union type = _o.Type;
			if (type == ISpwanMonsterMode_Union.ISpwanMonsterMode)
			{
				return ISpwanMonsterMode.Pack(builder, _o.AsISpwanMonsterMode()).Value;
			}
			if (type != ISpwanMonsterMode_Union.ISpawnMonsterConstraintAnnularSector)
			{
				return 0;
			}
			return ISpawnMonsterConstraintAnnularSector.Pack(builder, _o.AsISpawnMonsterConstraintAnnularSector()).Value;
		}
	}
}
