using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA3 RID: 24483
	public class ISpwanMonsterMode_UnionUnion
	{
		// Token: 0x1700B550 RID: 46416
		// (get) Token: 0x060292DC RID: 168668 RVA: 0x0059F43D File Offset: 0x0059D63D
		// (set) Token: 0x060292DD RID: 168669 RVA: 0x0059F445 File Offset: 0x0059D645
		public ISpwanMonsterMode_Union Type { get; set; }

		// Token: 0x1700B551 RID: 46417
		// (get) Token: 0x060292DE RID: 168670 RVA: 0x0059F44E File Offset: 0x0059D64E
		// (set) Token: 0x060292DF RID: 168671 RVA: 0x0059F456 File Offset: 0x0059D656
		public object Value { get; set; }

		// Token: 0x060292E0 RID: 168672 RVA: 0x0059F45F File Offset: 0x0059D65F
		public ISpwanMonsterMode_UnionUnion()
		{
			this.Type = ISpwanMonsterMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060292E1 RID: 168673 RVA: 0x0059F475 File Offset: 0x0059D675
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060292E2 RID: 168674 RVA: 0x0059F487 File Offset: 0x0059D687
		public ISpwanMonsterModeT AsISpwanMonsterMode()
		{
			return this.As<ISpwanMonsterModeT>();
		}

		// Token: 0x060292E3 RID: 168675 RVA: 0x0059F48F File Offset: 0x0059D68F
		public static ISpwanMonsterMode_UnionUnion FromISpwanMonsterMode(ISpwanMonsterModeT _ispwanmonstermode)
		{
			return new ISpwanMonsterMode_UnionUnion
			{
				Type = ISpwanMonsterMode_Union.ISpwanMonsterMode,
				Value = _ispwanmonstermode
			};
		}

		// Token: 0x060292E4 RID: 168676 RVA: 0x0059F4A4 File Offset: 0x0059D6A4
		public ISpawnMonsterConstraintAnnularSectorT AsISpawnMonsterConstraintAnnularSector()
		{
			return this.As<ISpawnMonsterConstraintAnnularSectorT>();
		}

		// Token: 0x060292E5 RID: 168677 RVA: 0x0059F4AC File Offset: 0x0059D6AC
		public static ISpwanMonsterMode_UnionUnion FromISpawnMonsterConstraintAnnularSector(ISpawnMonsterConstraintAnnularSectorT _ispawnmonsterconstraintannularsector)
		{
			return new ISpwanMonsterMode_UnionUnion
			{
				Type = ISpwanMonsterMode_Union.ISpawnMonsterConstraintAnnularSector,
				Value = _ispawnmonsterconstraintannularsector
			};
		}

		// Token: 0x060292E6 RID: 168678 RVA: 0x0059F4C4 File Offset: 0x0059D6C4
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
