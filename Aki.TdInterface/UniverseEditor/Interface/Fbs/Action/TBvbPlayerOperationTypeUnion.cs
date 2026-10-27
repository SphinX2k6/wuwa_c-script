using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007651 RID: 30289
	public class TBvbPlayerOperationTypeUnion
	{
		// Token: 0x1700E5C9 RID: 58825
		// (get) Token: 0x06037254 RID: 225876 RVA: 0x0077A1C2 File Offset: 0x007783C2
		// (set) Token: 0x06037255 RID: 225877 RVA: 0x0077A1CA File Offset: 0x007783CA
		public TBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700E5CA RID: 58826
		// (get) Token: 0x06037256 RID: 225878 RVA: 0x0077A1D3 File Offset: 0x007783D3
		// (set) Token: 0x06037257 RID: 225879 RVA: 0x0077A1DB File Offset: 0x007783DB
		public object Value { get; set; }

		// Token: 0x06037258 RID: 225880 RVA: 0x0077A1E4 File Offset: 0x007783E4
		public TBvbPlayerOperationTypeUnion()
		{
			this.Type = TBvbPlayerOperationType.NONE;
			this.Value = null;
		}

		// Token: 0x06037259 RID: 225881 RVA: 0x0077A1FA File Offset: 0x007783FA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603725A RID: 225882 RVA: 0x0077A20C File Offset: 0x0077840C
		public IBvbChangeBoardCardT AsIBvbChangeBoardCard()
		{
			return this.As<IBvbChangeBoardCardT>();
		}

		// Token: 0x0603725B RID: 225883 RVA: 0x0077A214 File Offset: 0x00778414
		public static TBvbPlayerOperationTypeUnion FromIBvbChangeBoardCard(IBvbChangeBoardCardT _ibvbchangeboardcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbChangeBoardCard,
				Value = _ibvbchangeboardcard
			};
		}

		// Token: 0x0603725C RID: 225884 RVA: 0x0077A229 File Offset: 0x00778429
		public IBvbChangeHandCardT AsIBvbChangeHandCard()
		{
			return this.As<IBvbChangeHandCardT>();
		}

		// Token: 0x0603725D RID: 225885 RVA: 0x0077A231 File Offset: 0x00778431
		public static TBvbPlayerOperationTypeUnion FromIBvbChangeHandCard(IBvbChangeHandCardT _ibvbchangehandcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbChangeHandCard,
				Value = _ibvbchangehandcard
			};
		}

		// Token: 0x0603725E RID: 225886 RVA: 0x0077A246 File Offset: 0x00778446
		public IBvbDeployT AsIBvbDeploy()
		{
			return this.As<IBvbDeployT>();
		}

		// Token: 0x0603725F RID: 225887 RVA: 0x0077A24E File Offset: 0x0077844E
		public static TBvbPlayerOperationTypeUnion FromIBvbDeploy(IBvbDeployT _ibvbdeploy)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbDeploy,
				Value = _ibvbdeploy
			};
		}

		// Token: 0x06037260 RID: 225888 RVA: 0x0077A263 File Offset: 0x00778463
		public IBvbEndTurnT AsIBvbEndTurn()
		{
			return this.As<IBvbEndTurnT>();
		}

		// Token: 0x06037261 RID: 225889 RVA: 0x0077A26B File Offset: 0x0077846B
		public static TBvbPlayerOperationTypeUnion FromIBvbEndTurn(IBvbEndTurnT _ibvbendturn)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbEndTurn,
				Value = _ibvbendturn
			};
		}

		// Token: 0x06037262 RID: 225890 RVA: 0x0077A280 File Offset: 0x00778480
		public IBvbEvolutionT AsIBvbEvolution()
		{
			return this.As<IBvbEvolutionT>();
		}

		// Token: 0x06037263 RID: 225891 RVA: 0x0077A288 File Offset: 0x00778488
		public static TBvbPlayerOperationTypeUnion FromIBvbEvolution(IBvbEvolutionT _ibvbevolution)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbEvolution,
				Value = _ibvbevolution
			};
		}

		// Token: 0x06037264 RID: 225892 RVA: 0x0077A29D File Offset: 0x0077849D
		public IBvbRecycleBoardCardT AsIBvbRecycleBoardCard()
		{
			return this.As<IBvbRecycleBoardCardT>();
		}

		// Token: 0x06037265 RID: 225893 RVA: 0x0077A2A5 File Offset: 0x007784A5
		public static TBvbPlayerOperationTypeUnion FromIBvbRecycleBoardCard(IBvbRecycleBoardCardT _ibvbrecycleboardcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbRecycleBoardCard,
				Value = _ibvbrecycleboardcard
			};
		}

		// Token: 0x06037266 RID: 225894 RVA: 0x0077A2BA File Offset: 0x007784BA
		public IBvbRecycleHandCardT AsIBvbRecycleHandCard()
		{
			return this.As<IBvbRecycleHandCardT>();
		}

		// Token: 0x06037267 RID: 225895 RVA: 0x0077A2C2 File Offset: 0x007784C2
		public static TBvbPlayerOperationTypeUnion FromIBvbRecycleHandCard(IBvbRecycleHandCardT _ibvbrecyclehandcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbRecycleHandCard,
				Value = _ibvbrecyclehandcard
			};
		}

		// Token: 0x06037268 RID: 225896 RVA: 0x0077A2D7 File Offset: 0x007784D7
		public IBvbSelectCardT AsIBvbSelectCard()
		{
			return this.As<IBvbSelectCardT>();
		}

		// Token: 0x06037269 RID: 225897 RVA: 0x0077A2DF File Offset: 0x007784DF
		public static TBvbPlayerOperationTypeUnion FromIBvbSelectCard(IBvbSelectCardT _ibvbselectcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbSelectCard,
				Value = _ibvbselectcard
			};
		}

		// Token: 0x0603726A RID: 225898 RVA: 0x0077A2F4 File Offset: 0x007784F4
		public IBvbUseFieldCardSkillT AsIBvbUseFieldCardSkill()
		{
			return this.As<IBvbUseFieldCardSkillT>();
		}

		// Token: 0x0603726B RID: 225899 RVA: 0x0077A2FC File Offset: 0x007784FC
		public static TBvbPlayerOperationTypeUnion FromIBvbUseFieldCardSkill(IBvbUseFieldCardSkillT _ibvbusefieldcardskill)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbUseFieldCardSkill,
				Value = _ibvbusefieldcardskill
			};
		}

		// Token: 0x0603726C RID: 225900 RVA: 0x0077A312 File Offset: 0x00778512
		public IBvbUseItemCardSkillT AsIBvbUseItemCardSkill()
		{
			return this.As<IBvbUseItemCardSkillT>();
		}

		// Token: 0x0603726D RID: 225901 RVA: 0x0077A31A File Offset: 0x0077851A
		public static TBvbPlayerOperationTypeUnion FromIBvbUseItemCardSkill(IBvbUseItemCardSkillT _ibvbuseitemcardskill)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbUseItemCardSkill,
				Value = _ibvbuseitemcardskill
			};
		}

		// Token: 0x0603726E RID: 225902 RVA: 0x0077A330 File Offset: 0x00778530
		public static int Pack(FlatBufferBuilder builder, TBvbPlayerOperationTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TBvbPlayerOperationType.IBvbChangeBoardCard:
				return IBvbChangeBoardCard.Pack(builder, _o.AsIBvbChangeBoardCard()).Value;
			case TBvbPlayerOperationType.IBvbChangeHandCard:
				return IBvbChangeHandCard.Pack(builder, _o.AsIBvbChangeHandCard()).Value;
			case TBvbPlayerOperationType.IBvbDeploy:
				return IBvbDeploy.Pack(builder, _o.AsIBvbDeploy()).Value;
			case TBvbPlayerOperationType.IBvbEndTurn:
				return IBvbEndTurn.Pack(builder, _o.AsIBvbEndTurn()).Value;
			case TBvbPlayerOperationType.IBvbEvolution:
				return IBvbEvolution.Pack(builder, _o.AsIBvbEvolution()).Value;
			case TBvbPlayerOperationType.IBvbRecycleBoardCard:
				return IBvbRecycleBoardCard.Pack(builder, _o.AsIBvbRecycleBoardCard()).Value;
			case TBvbPlayerOperationType.IBvbRecycleHandCard:
				return IBvbRecycleHandCard.Pack(builder, _o.AsIBvbRecycleHandCard()).Value;
			case TBvbPlayerOperationType.IBvbSelectCard:
				return IBvbSelectCard.Pack(builder, _o.AsIBvbSelectCard()).Value;
			case TBvbPlayerOperationType.IBvbUseFieldCardSkill:
				return IBvbUseFieldCardSkill.Pack(builder, _o.AsIBvbUseFieldCardSkill()).Value;
			case TBvbPlayerOperationType.IBvbUseItemCardSkill:
				return IBvbUseItemCardSkill.Pack(builder, _o.AsIBvbUseItemCardSkill()).Value;
			default:
				return 0;
			}
		}
	}
}
