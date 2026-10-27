using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006252 RID: 25170
	public class IBvbPlayerOperationType_UnionUnion
	{
		// Token: 0x1700BB94 RID: 48020
		// (get) Token: 0x0602B67C RID: 177788 RVA: 0x005F9975 File Offset: 0x005F7B75
		// (set) Token: 0x0602B67D RID: 177789 RVA: 0x005F997D File Offset: 0x005F7B7D
		public IBvbPlayerOperationType_Union Type { get; set; }

		// Token: 0x1700BB95 RID: 48021
		// (get) Token: 0x0602B67E RID: 177790 RVA: 0x005F9986 File Offset: 0x005F7B86
		// (set) Token: 0x0602B67F RID: 177791 RVA: 0x005F998E File Offset: 0x005F7B8E
		public object Value { get; set; }

		// Token: 0x0602B680 RID: 177792 RVA: 0x005F9997 File Offset: 0x005F7B97
		public IBvbPlayerOperationType_UnionUnion()
		{
			this.Type = IBvbPlayerOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B681 RID: 177793 RVA: 0x005F99AD File Offset: 0x005F7BAD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B682 RID: 177794 RVA: 0x005F99BF File Offset: 0x005F7BBF
		public IBvbPlayerOperationTypeT AsIBvbPlayerOperationType()
		{
			return this.As<IBvbPlayerOperationTypeT>();
		}

		// Token: 0x0602B683 RID: 177795 RVA: 0x005F99C7 File Offset: 0x005F7BC7
		public static IBvbPlayerOperationType_UnionUnion FromIBvbPlayerOperationType(IBvbPlayerOperationTypeT _ibvbplayeroperationtype)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbPlayerOperationType,
				Value = _ibvbplayeroperationtype
			};
		}

		// Token: 0x0602B684 RID: 177796 RVA: 0x005F99DC File Offset: 0x005F7BDC
		public IBvbDeployT AsIBvbDeploy()
		{
			return this.As<IBvbDeployT>();
		}

		// Token: 0x0602B685 RID: 177797 RVA: 0x005F99E4 File Offset: 0x005F7BE4
		public static IBvbPlayerOperationType_UnionUnion FromIBvbDeploy(IBvbDeployT _ibvbdeploy)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbDeploy,
				Value = _ibvbdeploy
			};
		}

		// Token: 0x0602B686 RID: 177798 RVA: 0x005F99F9 File Offset: 0x005F7BF9
		public IBvbEvolutionT AsIBvbEvolution()
		{
			return this.As<IBvbEvolutionT>();
		}

		// Token: 0x0602B687 RID: 177799 RVA: 0x005F9A01 File Offset: 0x005F7C01
		public static IBvbPlayerOperationType_UnionUnion FromIBvbEvolution(IBvbEvolutionT _ibvbevolution)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbEvolution,
				Value = _ibvbevolution
			};
		}

		// Token: 0x0602B688 RID: 177800 RVA: 0x005F9A16 File Offset: 0x005F7C16
		public IBvbChangeHandCardT AsIBvbChangeHandCard()
		{
			return this.As<IBvbChangeHandCardT>();
		}

		// Token: 0x0602B689 RID: 177801 RVA: 0x005F9A1E File Offset: 0x005F7C1E
		public static IBvbPlayerOperationType_UnionUnion FromIBvbChangeHandCard(IBvbChangeHandCardT _ibvbchangehandcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbChangeHandCard,
				Value = _ibvbchangehandcard
			};
		}

		// Token: 0x0602B68A RID: 177802 RVA: 0x005F9A33 File Offset: 0x005F7C33
		public IBvbChangeBoardCardT AsIBvbChangeBoardCard()
		{
			return this.As<IBvbChangeBoardCardT>();
		}

		// Token: 0x0602B68B RID: 177803 RVA: 0x005F9A3B File Offset: 0x005F7C3B
		public static IBvbPlayerOperationType_UnionUnion FromIBvbChangeBoardCard(IBvbChangeBoardCardT _ibvbchangeboardcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbChangeBoardCard,
				Value = _ibvbchangeboardcard
			};
		}

		// Token: 0x0602B68C RID: 177804 RVA: 0x005F9A50 File Offset: 0x005F7C50
		public IBvbRecycleHandCardT AsIBvbRecycleHandCard()
		{
			return this.As<IBvbRecycleHandCardT>();
		}

		// Token: 0x0602B68D RID: 177805 RVA: 0x005F9A58 File Offset: 0x005F7C58
		public static IBvbPlayerOperationType_UnionUnion FromIBvbRecycleHandCard(IBvbRecycleHandCardT _ibvbrecyclehandcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbRecycleHandCard,
				Value = _ibvbrecyclehandcard
			};
		}

		// Token: 0x0602B68E RID: 177806 RVA: 0x005F9A6D File Offset: 0x005F7C6D
		public IBvbRecycleBoardCardT AsIBvbRecycleBoardCard()
		{
			return this.As<IBvbRecycleBoardCardT>();
		}

		// Token: 0x0602B68F RID: 177807 RVA: 0x005F9A75 File Offset: 0x005F7C75
		public static IBvbPlayerOperationType_UnionUnion FromIBvbRecycleBoardCard(IBvbRecycleBoardCardT _ibvbrecycleboardcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbRecycleBoardCard,
				Value = _ibvbrecycleboardcard
			};
		}

		// Token: 0x0602B690 RID: 177808 RVA: 0x005F9A8A File Offset: 0x005F7C8A
		public IBvbUseItemCardSkillT AsIBvbUseItemCardSkill()
		{
			return this.As<IBvbUseItemCardSkillT>();
		}

		// Token: 0x0602B691 RID: 177809 RVA: 0x005F9A92 File Offset: 0x005F7C92
		public static IBvbPlayerOperationType_UnionUnion FromIBvbUseItemCardSkill(IBvbUseItemCardSkillT _ibvbuseitemcardskill)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbUseItemCardSkill,
				Value = _ibvbuseitemcardskill
			};
		}

		// Token: 0x0602B692 RID: 177810 RVA: 0x005F9AA7 File Offset: 0x005F7CA7
		public IBvbSelectCardT AsIBvbSelectCard()
		{
			return this.As<IBvbSelectCardT>();
		}

		// Token: 0x0602B693 RID: 177811 RVA: 0x005F9AAF File Offset: 0x005F7CAF
		public static IBvbPlayerOperationType_UnionUnion FromIBvbSelectCard(IBvbSelectCardT _ibvbselectcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbSelectCard,
				Value = _ibvbselectcard
			};
		}

		// Token: 0x0602B694 RID: 177812 RVA: 0x005F9AC5 File Offset: 0x005F7CC5
		public IBvbUseFieldCardSkillT AsIBvbUseFieldCardSkill()
		{
			return this.As<IBvbUseFieldCardSkillT>();
		}

		// Token: 0x0602B695 RID: 177813 RVA: 0x005F9ACD File Offset: 0x005F7CCD
		public static IBvbPlayerOperationType_UnionUnion FromIBvbUseFieldCardSkill(IBvbUseFieldCardSkillT _ibvbusefieldcardskill)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbUseFieldCardSkill,
				Value = _ibvbusefieldcardskill
			};
		}

		// Token: 0x0602B696 RID: 177814 RVA: 0x005F9AE3 File Offset: 0x005F7CE3
		public IBvbEndTurnT AsIBvbEndTurn()
		{
			return this.As<IBvbEndTurnT>();
		}

		// Token: 0x0602B697 RID: 177815 RVA: 0x005F9AEB File Offset: 0x005F7CEB
		public static IBvbPlayerOperationType_UnionUnion FromIBvbEndTurn(IBvbEndTurnT _ibvbendturn)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbEndTurn,
				Value = _ibvbendturn
			};
		}

		// Token: 0x0602B698 RID: 177816 RVA: 0x005F9B04 File Offset: 0x005F7D04
		public static int Pack(FlatBufferBuilder builder, IBvbPlayerOperationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBvbPlayerOperationType_Union.IBvbPlayerOperationType:
				return IBvbPlayerOperationType.Pack(builder, _o.AsIBvbPlayerOperationType()).Value;
			case IBvbPlayerOperationType_Union.IBvbDeploy:
				return IBvbDeploy.Pack(builder, _o.AsIBvbDeploy()).Value;
			case IBvbPlayerOperationType_Union.IBvbEvolution:
				return IBvbEvolution.Pack(builder, _o.AsIBvbEvolution()).Value;
			case IBvbPlayerOperationType_Union.IBvbChangeHandCard:
				return IBvbChangeHandCard.Pack(builder, _o.AsIBvbChangeHandCard()).Value;
			case IBvbPlayerOperationType_Union.IBvbChangeBoardCard:
				return IBvbChangeBoardCard.Pack(builder, _o.AsIBvbChangeBoardCard()).Value;
			case IBvbPlayerOperationType_Union.IBvbRecycleHandCard:
				return IBvbRecycleHandCard.Pack(builder, _o.AsIBvbRecycleHandCard()).Value;
			case IBvbPlayerOperationType_Union.IBvbRecycleBoardCard:
				return IBvbRecycleBoardCard.Pack(builder, _o.AsIBvbRecycleBoardCard()).Value;
			case IBvbPlayerOperationType_Union.IBvbUseItemCardSkill:
				return IBvbUseItemCardSkill.Pack(builder, _o.AsIBvbUseItemCardSkill()).Value;
			case IBvbPlayerOperationType_Union.IBvbSelectCard:
				return IBvbSelectCard.Pack(builder, _o.AsIBvbSelectCard()).Value;
			case IBvbPlayerOperationType_Union.IBvbUseFieldCardSkill:
				return IBvbUseFieldCardSkill.Pack(builder, _o.AsIBvbUseFieldCardSkill()).Value;
			case IBvbPlayerOperationType_Union.IBvbEndTurn:
				return IBvbEndTurn.Pack(builder, _o.AsIBvbEndTurn()).Value;
			default:
				return 0;
			}
		}
	}
}
