using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746A RID: 29802
	public class ITrapDefensePlayerOperationType_UnionUnion
	{
		// Token: 0x1700E231 RID: 57905
		// (get) Token: 0x0603623A RID: 221754 RVA: 0x0075C6D1 File Offset: 0x0075A8D1
		// (set) Token: 0x0603623B RID: 221755 RVA: 0x0075C6D9 File Offset: 0x0075A8D9
		public ITrapDefensePlayerOperationType_Union Type { get; set; }

		// Token: 0x1700E232 RID: 57906
		// (get) Token: 0x0603623C RID: 221756 RVA: 0x0075C6E2 File Offset: 0x0075A8E2
		// (set) Token: 0x0603623D RID: 221757 RVA: 0x0075C6EA File Offset: 0x0075A8EA
		public object Value { get; set; }

		// Token: 0x0603623E RID: 221758 RVA: 0x0075C6F3 File Offset: 0x0075A8F3
		public ITrapDefensePlayerOperationType_UnionUnion()
		{
			this.Type = ITrapDefensePlayerOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603623F RID: 221759 RVA: 0x0075C709 File Offset: 0x0075A909
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036240 RID: 221760 RVA: 0x0075C71B File Offset: 0x0075A91B
		public ITrapDefensePlayerOperationTypeT AsITrapDefensePlayerOperationType()
		{
			return this.As<ITrapDefensePlayerOperationTypeT>();
		}

		// Token: 0x06036241 RID: 221761 RVA: 0x0075C723 File Offset: 0x0075A923
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationType(ITrapDefensePlayerOperationTypeT _itrapdefenseplayeroperationtype)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationType,
				Value = _itrapdefenseplayeroperationtype
			};
		}

		// Token: 0x06036242 RID: 221762 RVA: 0x0075C738 File Offset: 0x0075A938
		public ITrapDefensePlayerOperationRecycleTrapT AsITrapDefensePlayerOperationRecycleTrap()
		{
			return this.As<ITrapDefensePlayerOperationRecycleTrapT>();
		}

		// Token: 0x06036243 RID: 221763 RVA: 0x0075C740 File Offset: 0x0075A940
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationRecycleTrap(ITrapDefensePlayerOperationRecycleTrapT _itrapdefenseplayeroperationrecycletrap)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationRecycleTrap,
				Value = _itrapdefenseplayeroperationrecycletrap
			};
		}

		// Token: 0x06036244 RID: 221764 RVA: 0x0075C755 File Offset: 0x0075A955
		public ITrapDefensePlayerOperationConstructTrapT AsITrapDefensePlayerOperationConstructTrap()
		{
			return this.As<ITrapDefensePlayerOperationConstructTrapT>();
		}

		// Token: 0x06036245 RID: 221765 RVA: 0x0075C75D File Offset: 0x0075A95D
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationConstructTrap(ITrapDefensePlayerOperationConstructTrapT _itrapdefenseplayeroperationconstructtrap)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationConstructTrap,
				Value = _itrapdefenseplayeroperationconstructtrap
			};
		}

		// Token: 0x06036246 RID: 221766 RVA: 0x0075C772 File Offset: 0x0075A972
		public ITrapDefensePlayerOperationSpawnMonsterT AsITrapDefensePlayerOperationSpawnMonster()
		{
			return this.As<ITrapDefensePlayerOperationSpawnMonsterT>();
		}

		// Token: 0x06036247 RID: 221767 RVA: 0x0075C77A File Offset: 0x0075A97A
		public static ITrapDefensePlayerOperationType_UnionUnion FromITrapDefensePlayerOperationSpawnMonster(ITrapDefensePlayerOperationSpawnMonsterT _itrapdefenseplayeroperationspawnmonster)
		{
			return new ITrapDefensePlayerOperationType_UnionUnion
			{
				Type = ITrapDefensePlayerOperationType_Union.ITrapDefensePlayerOperationSpawnMonster,
				Value = _itrapdefenseplayeroperationspawnmonster
			};
		}

		// Token: 0x06036248 RID: 221768 RVA: 0x0075C790 File Offset: 0x0075A990
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
