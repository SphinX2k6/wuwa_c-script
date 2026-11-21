using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200802B RID: 32811
	public class TTrapDefensePlayerOperationTypeUnion
	{
		// Token: 0x1700F33F RID: 62271
		// (get) Token: 0x0603B06D RID: 241773 RVA: 0x007ECC28 File Offset: 0x007EAE28
		// (set) Token: 0x0603B06E RID: 241774 RVA: 0x007ECC30 File Offset: 0x007EAE30
		public TTrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x1700F340 RID: 62272
		// (get) Token: 0x0603B06F RID: 241775 RVA: 0x007ECC39 File Offset: 0x007EAE39
		// (set) Token: 0x0603B070 RID: 241776 RVA: 0x007ECC41 File Offset: 0x007EAE41
		public object Value { get; set; }

		// Token: 0x0603B071 RID: 241777 RVA: 0x007ECC4A File Offset: 0x007EAE4A
		public TTrapDefensePlayerOperationTypeUnion()
		{
			this.Type = TTrapDefensePlayerOperationType.NONE;
			this.Value = null;
		}

		// Token: 0x0603B072 RID: 241778 RVA: 0x007ECC60 File Offset: 0x007EAE60
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B073 RID: 241779 RVA: 0x007ECC72 File Offset: 0x007EAE72
		public ITrapDefensePlayerOperationConstructTrapT AsITrapDefensePlayerOperationConstructTrap()
		{
			return this.As<ITrapDefensePlayerOperationConstructTrapT>();
		}

		// Token: 0x0603B074 RID: 241780 RVA: 0x007ECC7A File Offset: 0x007EAE7A
		public static TTrapDefensePlayerOperationTypeUnion FromITrapDefensePlayerOperationConstructTrap(ITrapDefensePlayerOperationConstructTrapT _itrapdefenseplayeroperationconstructtrap)
		{
			return new TTrapDefensePlayerOperationTypeUnion
			{
				Type = TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationConstructTrap,
				Value = _itrapdefenseplayeroperationconstructtrap
			};
		}

		// Token: 0x0603B075 RID: 241781 RVA: 0x007ECC8F File Offset: 0x007EAE8F
		public ITrapDefensePlayerOperationRecycleTrapT AsITrapDefensePlayerOperationRecycleTrap()
		{
			return this.As<ITrapDefensePlayerOperationRecycleTrapT>();
		}

		// Token: 0x0603B076 RID: 241782 RVA: 0x007ECC97 File Offset: 0x007EAE97
		public static TTrapDefensePlayerOperationTypeUnion FromITrapDefensePlayerOperationRecycleTrap(ITrapDefensePlayerOperationRecycleTrapT _itrapdefenseplayeroperationrecycletrap)
		{
			return new TTrapDefensePlayerOperationTypeUnion
			{
				Type = TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationRecycleTrap,
				Value = _itrapdefenseplayeroperationrecycletrap
			};
		}

		// Token: 0x0603B077 RID: 241783 RVA: 0x007ECCAC File Offset: 0x007EAEAC
		public ITrapDefensePlayerOperationSpawnMonsterT AsITrapDefensePlayerOperationSpawnMonster()
		{
			return this.As<ITrapDefensePlayerOperationSpawnMonsterT>();
		}

		// Token: 0x0603B078 RID: 241784 RVA: 0x007ECCB4 File Offset: 0x007EAEB4
		public static TTrapDefensePlayerOperationTypeUnion FromITrapDefensePlayerOperationSpawnMonster(ITrapDefensePlayerOperationSpawnMonsterT _itrapdefenseplayeroperationspawnmonster)
		{
			return new TTrapDefensePlayerOperationTypeUnion
			{
				Type = TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationSpawnMonster,
				Value = _itrapdefenseplayeroperationspawnmonster
			};
		}

		// Token: 0x0603B079 RID: 241785 RVA: 0x007ECCCC File Offset: 0x007EAECC
		public static int Pack(FlatBufferBuilder builder, TTrapDefensePlayerOperationTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationConstructTrap:
				return ITrapDefensePlayerOperationConstructTrap.Pack(builder, _o.AsITrapDefensePlayerOperationConstructTrap()).Value;
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationRecycleTrap:
				return ITrapDefensePlayerOperationRecycleTrap.Pack(builder, _o.AsITrapDefensePlayerOperationRecycleTrap()).Value;
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationSpawnMonster:
				return ITrapDefensePlayerOperationSpawnMonster.Pack(builder, _o.AsITrapDefensePlayerOperationSpawnMonster()).Value;
			default:
				return 0;
			}
		}
	}
}
