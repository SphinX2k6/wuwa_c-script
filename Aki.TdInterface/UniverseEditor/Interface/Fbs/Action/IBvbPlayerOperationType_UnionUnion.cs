using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C3 RID: 26819
	public class IBvbPlayerOperationType_UnionUnion
	{
		// Token: 0x1700C51C RID: 50460
		// (get) Token: 0x0602DDDD RID: 187869 RVA: 0x0064477D File Offset: 0x0064297D
		// (set) Token: 0x0602DDDE RID: 187870 RVA: 0x00644785 File Offset: 0x00642985
		public IBvbPlayerOperationType_Union Type { get; set; }

		// Token: 0x1700C51D RID: 50461
		// (get) Token: 0x0602DDDF RID: 187871 RVA: 0x0064478E File Offset: 0x0064298E
		// (set) Token: 0x0602DDE0 RID: 187872 RVA: 0x00644796 File Offset: 0x00642996
		public object Value { get; set; }

		// Token: 0x0602DDE1 RID: 187873 RVA: 0x0064479F File Offset: 0x0064299F
		public IBvbPlayerOperationType_UnionUnion()
		{
			this.Type = IBvbPlayerOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DDE2 RID: 187874 RVA: 0x006447B5 File Offset: 0x006429B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DDE3 RID: 187875 RVA: 0x006447C7 File Offset: 0x006429C7
		public IBvbPlayerOperationTypeT AsIBvbPlayerOperationType()
		{
			return this.As<IBvbPlayerOperationTypeT>();
		}

		// Token: 0x0602DDE4 RID: 187876 RVA: 0x006447CF File Offset: 0x006429CF
		public static IBvbPlayerOperationType_UnionUnion FromIBvbPlayerOperationType(IBvbPlayerOperationTypeT _ibvbplayeroperationtype)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbPlayerOperationType,
				Value = _ibvbplayeroperationtype
			};
		}

		// Token: 0x0602DDE5 RID: 187877 RVA: 0x006447E4 File Offset: 0x006429E4
		public IBvbDeployT AsIBvbDeploy()
		{
			return this.As<IBvbDeployT>();
		}

		// Token: 0x0602DDE6 RID: 187878 RVA: 0x006447EC File Offset: 0x006429EC
		public static IBvbPlayerOperationType_UnionUnion FromIBvbDeploy(IBvbDeployT _ibvbdeploy)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbDeploy,
				Value = _ibvbdeploy
			};
		}

		// Token: 0x0602DDE7 RID: 187879 RVA: 0x00644801 File Offset: 0x00642A01
		public IBvbEvolutionT AsIBvbEvolution()
		{
			return this.As<IBvbEvolutionT>();
		}

		// Token: 0x0602DDE8 RID: 187880 RVA: 0x00644809 File Offset: 0x00642A09
		public static IBvbPlayerOperationType_UnionUnion FromIBvbEvolution(IBvbEvolutionT _ibvbevolution)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbEvolution,
				Value = _ibvbevolution
			};
		}

		// Token: 0x0602DDE9 RID: 187881 RVA: 0x0064481E File Offset: 0x00642A1E
		public IBvbChangeHandCardT AsIBvbChangeHandCard()
		{
			return this.As<IBvbChangeHandCardT>();
		}

		// Token: 0x0602DDEA RID: 187882 RVA: 0x00644826 File Offset: 0x00642A26
		public static IBvbPlayerOperationType_UnionUnion FromIBvbChangeHandCard(IBvbChangeHandCardT _ibvbchangehandcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbChangeHandCard,
				Value = _ibvbchangehandcard
			};
		}

		// Token: 0x0602DDEB RID: 187883 RVA: 0x0064483B File Offset: 0x00642A3B
		public IBvbChangeBoardCardT AsIBvbChangeBoardCard()
		{
			return this.As<IBvbChangeBoardCardT>();
		}

		// Token: 0x0602DDEC RID: 187884 RVA: 0x00644843 File Offset: 0x00642A43
		public static IBvbPlayerOperationType_UnionUnion FromIBvbChangeBoardCard(IBvbChangeBoardCardT _ibvbchangeboardcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbChangeBoardCard,
				Value = _ibvbchangeboardcard
			};
		}

		// Token: 0x0602DDED RID: 187885 RVA: 0x00644858 File Offset: 0x00642A58
		public IBvbRecycleHandCardT AsIBvbRecycleHandCard()
		{
			return this.As<IBvbRecycleHandCardT>();
		}

		// Token: 0x0602DDEE RID: 187886 RVA: 0x00644860 File Offset: 0x00642A60
		public static IBvbPlayerOperationType_UnionUnion FromIBvbRecycleHandCard(IBvbRecycleHandCardT _ibvbrecyclehandcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbRecycleHandCard,
				Value = _ibvbrecyclehandcard
			};
		}

		// Token: 0x0602DDEF RID: 187887 RVA: 0x00644875 File Offset: 0x00642A75
		public IBvbRecycleBoardCardT AsIBvbRecycleBoardCard()
		{
			return this.As<IBvbRecycleBoardCardT>();
		}

		// Token: 0x0602DDF0 RID: 187888 RVA: 0x0064487D File Offset: 0x00642A7D
		public static IBvbPlayerOperationType_UnionUnion FromIBvbRecycleBoardCard(IBvbRecycleBoardCardT _ibvbrecycleboardcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbRecycleBoardCard,
				Value = _ibvbrecycleboardcard
			};
		}

		// Token: 0x0602DDF1 RID: 187889 RVA: 0x00644892 File Offset: 0x00642A92
		public IBvbUseItemCardSkillT AsIBvbUseItemCardSkill()
		{
			return this.As<IBvbUseItemCardSkillT>();
		}

		// Token: 0x0602DDF2 RID: 187890 RVA: 0x0064489A File Offset: 0x00642A9A
		public static IBvbPlayerOperationType_UnionUnion FromIBvbUseItemCardSkill(IBvbUseItemCardSkillT _ibvbuseitemcardskill)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbUseItemCardSkill,
				Value = _ibvbuseitemcardskill
			};
		}

		// Token: 0x0602DDF3 RID: 187891 RVA: 0x006448AF File Offset: 0x00642AAF
		public IBvbSelectCardT AsIBvbSelectCard()
		{
			return this.As<IBvbSelectCardT>();
		}

		// Token: 0x0602DDF4 RID: 187892 RVA: 0x006448B7 File Offset: 0x00642AB7
		public static IBvbPlayerOperationType_UnionUnion FromIBvbSelectCard(IBvbSelectCardT _ibvbselectcard)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbSelectCard,
				Value = _ibvbselectcard
			};
		}

		// Token: 0x0602DDF5 RID: 187893 RVA: 0x006448CD File Offset: 0x00642ACD
		public IBvbUseFieldCardSkillT AsIBvbUseFieldCardSkill()
		{
			return this.As<IBvbUseFieldCardSkillT>();
		}

		// Token: 0x0602DDF6 RID: 187894 RVA: 0x006448D5 File Offset: 0x00642AD5
		public static IBvbPlayerOperationType_UnionUnion FromIBvbUseFieldCardSkill(IBvbUseFieldCardSkillT _ibvbusefieldcardskill)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbUseFieldCardSkill,
				Value = _ibvbusefieldcardskill
			};
		}

		// Token: 0x0602DDF7 RID: 187895 RVA: 0x006448EB File Offset: 0x00642AEB
		public IBvbEndTurnT AsIBvbEndTurn()
		{
			return this.As<IBvbEndTurnT>();
		}

		// Token: 0x0602DDF8 RID: 187896 RVA: 0x006448F3 File Offset: 0x00642AF3
		public static IBvbPlayerOperationType_UnionUnion FromIBvbEndTurn(IBvbEndTurnT _ibvbendturn)
		{
			return new IBvbPlayerOperationType_UnionUnion
			{
				Type = IBvbPlayerOperationType_Union.IBvbEndTurn,
				Value = _ibvbendturn
			};
		}

		// Token: 0x0602DDF9 RID: 187897 RVA: 0x0064490C File Offset: 0x00642B0C
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
