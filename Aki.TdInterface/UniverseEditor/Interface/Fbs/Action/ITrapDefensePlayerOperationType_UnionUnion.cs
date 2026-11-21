using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C5D RID: 31837
	public class ITrapDefensePlayerOperationType_UnionUnion
	{
		// Token: 0x1700EE4E RID: 61006
		// (get) Token: 0x06039623 RID: 235043 RVA: 0x007BF3FD File Offset: 0x007BD5FD
		// (set) Token: 0x06039624 RID: 235044 RVA: 0x007BF405 File Offset: 0x007BD605
		public ITrapDefensePlayerOperationType_Union Type { get; set; }

		// Token: 0x1700EE4F RID: 61007
		// (get) Token: 0x06039625 RID: 235045 RVA: 0x007BF40E File Offset: 0x007BD60E
		// (set) Token: 0x06039626 RID: 235046 RVA: 0x007BF416 File Offset: 0x007BD616
		public object Value { get; set; }

		// Token: 0x06039627 RID: 235047 RVA: 0x007BF41F File Offset: 0x007BD61F
		public ITrapDefensePlayerOperationType_UnionUnion()
		{
			this.Type = ITrapDefensePlayerOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039628 RID: 235048 RVA: 0x007BF435 File Offset: 0x007BD635
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039629 RID: 235049 RVA: 0x007BF447 File Offset: 0x007BD647
		public ITrapDefensePlayerOperationTypeT AsITrapDefensePlayerOperationType()
		{
			return this.As<ITrapDefensePlayerOperationTypeT>();
		}

		// Token: 0x0603962A RID: 235050 RVA: 0x007BF44F File Offset: 0x007BD64F
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationType(ITrapDefensePlayerOperationTypeT _itrapdefenseplayeroperationtype)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationType,
				Value = _itrapdefenseplayeroperationtype
			};
		}

		// Token: 0x0603962B RID: 235051 RVA: 0x007BF464 File Offset: 0x007BD664
		public ITrapDefensePlayerOperationRecycleTrapT AsITrapDefensePlayerOperationRecycleTrap()
		{
			return this.As<ITrapDefensePlayerOperationRecycleTrapT>();
		}

		// Token: 0x0603962C RID: 235052 RVA: 0x007BF46C File Offset: 0x007BD66C
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationRecycleTrap(ITrapDefensePlayerOperationRecycleTrapT _itrapdefenseplayeroperationrecycletrap)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationRecycleTrap,
				Value = _itrapdefenseplayeroperationrecycletrap
			};
		}

		// Token: 0x0603962D RID: 235053 RVA: 0x007BF481 File Offset: 0x007BD681
		public ITrapDefensePlayerOperationConstructTrapT AsITrapDefensePlayerOperationConstructTrap()
		{
			return this.As<ITrapDefensePlayerOperationConstructTrapT>();
		}

		// Token: 0x0603962E RID: 235054 RVA: 0x007BF489 File Offset: 0x007BD689
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationConstructTrap(ITrapDefensePlayerOperationConstructTrapT _itrapdefenseplayeroperationconstructtrap)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationConstructTrap,
				Value = _itrapdefenseplayeroperationconstructtrap
			};
		}

		// Token: 0x0603962F RID: 235055 RVA: 0x007BF49E File Offset: 0x007BD69E
		public ITrapDefensePlayerOperationSpawnMonsterT AsITrapDefensePlayerOperationSpawnMonster()
		{
			return this.As<ITrapDefensePlayerOperationSpawnMonsterT>();
		}

		// Token: 0x06039630 RID: 235056 RVA: 0x007BF4A6 File Offset: 0x007BD6A6
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationSpawnMonster(ITrapDefensePlayerOperationSpawnMonsterT _itrapdefenseplayeroperationspawnmonster)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationSpawnMonster,
				Value = _itrapdefenseplayeroperationspawnmonster
			};
		}

		// Token: 0x06039631 RID: 235057 RVA: 0x007BF4BC File Offset: 0x007BD6BC
		public static int Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationType:
				return ITrapDefensePlayerOperationType.Pack(builder, _o.AsITrapDefensePlayerOperationType()).Value;
			case ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationRecycleTrap:
				return ITrapDefensePlayerOperationRecycleTrap.Pack(builder, _o.AsITrapDefensePlayerOperationRecycleTrap()).Value;
			case ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationConstructTrap:
				return ITrapDefensePlayerOperationConstructTrap.Pack(builder, _o.AsITrapDefensePlayerOperationConstructTrap()).Value;
			case ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationSpawnMonster:
				return ITrapDefensePlayerOperationSpawnMonster.Pack(builder, _o.AsITrapDefensePlayerOperationSpawnMonster()).Value;
			default:
				return 0;
			}
		}
	}
}
