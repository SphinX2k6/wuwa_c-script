using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E5F RID: 32351
	public class TBvbPlayerOperationTypeUnion
	{
		// Token: 0x1700F207 RID: 61959
		// (get) Token: 0x0603A6F9 RID: 239353 RVA: 0x007DE2BE File Offset: 0x007DC4BE
		// (set) Token: 0x0603A6FA RID: 239354 RVA: 0x007DE2C6 File Offset: 0x007DC4C6
		public TBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700F208 RID: 61960
		// (get) Token: 0x0603A6FB RID: 239355 RVA: 0x007DE2CF File Offset: 0x007DC4CF
		// (set) Token: 0x0603A6FC RID: 239356 RVA: 0x007DE2D7 File Offset: 0x007DC4D7
		public object Value { get; set; }

		// Token: 0x0603A6FD RID: 239357 RVA: 0x007DE2E0 File Offset: 0x007DC4E0
		public TBvbPlayerOperationTypeUnion()
		{
			this.Type = TBvbPlayerOperationType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A6FE RID: 239358 RVA: 0x007DE2F6 File Offset: 0x007DC4F6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A6FF RID: 239359 RVA: 0x007DE308 File Offset: 0x007DC508
		public IBvbChangeBoardCardT AsIBvbChangeBoardCard()
		{
			return this.As<IBvbChangeBoardCardT>();
		}

		// Token: 0x0603A700 RID: 239360 RVA: 0x007DE310 File Offset: 0x007DC510
		public static TBvbPlayerOperationTypeUnion FromIBvbChangeBoardCard(IBvbChangeBoardCardT _ibvbchangeboardcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbChangeBoardCard,
				Value = _ibvbchangeboardcard
			};
		}

		// Token: 0x0603A701 RID: 239361 RVA: 0x007DE325 File Offset: 0x007DC525
		public IBvbChangeHandCardT AsIBvbChangeHandCard()
		{
			return this.As<IBvbChangeHandCardT>();
		}

		// Token: 0x0603A702 RID: 239362 RVA: 0x007DE32D File Offset: 0x007DC52D
		public static TBvbPlayerOperationTypeUnion FromIBvbChangeHandCard(IBvbChangeHandCardT _ibvbchangehandcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbChangeHandCard,
				Value = _ibvbchangehandcard
			};
		}

		// Token: 0x0603A703 RID: 239363 RVA: 0x007DE342 File Offset: 0x007DC542
		public IBvbDeployT AsIBvbDeploy()
		{
			return this.As<IBvbDeployT>();
		}

		// Token: 0x0603A704 RID: 239364 RVA: 0x007DE34A File Offset: 0x007DC54A
		public static TBvbPlayerOperationTypeUnion FromIBvbDeploy(IBvbDeployT _ibvbdeploy)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbDeploy,
				Value = _ibvbdeploy
			};
		}

		// Token: 0x0603A705 RID: 239365 RVA: 0x007DE35F File Offset: 0x007DC55F
		public IBvbEndTurnT AsIBvbEndTurn()
		{
			return this.As<IBvbEndTurnT>();
		}

		// Token: 0x0603A706 RID: 239366 RVA: 0x007DE367 File Offset: 0x007DC567
		public static TBvbPlayerOperationTypeUnion FromIBvbEndTurn(IBvbEndTurnT _ibvbendturn)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbEndTurn,
				Value = _ibvbendturn
			};
		}

		// Token: 0x0603A707 RID: 239367 RVA: 0x007DE37C File Offset: 0x007DC57C
		public IBvbEvolutionT AsIBvbEvolution()
		{
			return this.As<IBvbEvolutionT>();
		}

		// Token: 0x0603A708 RID: 239368 RVA: 0x007DE384 File Offset: 0x007DC584
		public static TBvbPlayerOperationTypeUnion FromIBvbEvolution(IBvbEvolutionT _ibvbevolution)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbEvolution,
				Value = _ibvbevolution
			};
		}

		// Token: 0x0603A709 RID: 239369 RVA: 0x007DE399 File Offset: 0x007DC599
		public IBvbRecycleBoardCardT AsIBvbRecycleBoardCard()
		{
			return this.As<IBvbRecycleBoardCardT>();
		}

		// Token: 0x0603A70A RID: 239370 RVA: 0x007DE3A1 File Offset: 0x007DC5A1
		public static TBvbPlayerOperationTypeUnion FromIBvbRecycleBoardCard(IBvbRecycleBoardCardT _ibvbrecycleboardcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbRecycleBoardCard,
				Value = _ibvbrecycleboardcard
			};
		}

		// Token: 0x0603A70B RID: 239371 RVA: 0x007DE3B6 File Offset: 0x007DC5B6
		public IBvbRecycleHandCardT AsIBvbRecycleHandCard()
		{
			return this.As<IBvbRecycleHandCardT>();
		}

		// Token: 0x0603A70C RID: 239372 RVA: 0x007DE3BE File Offset: 0x007DC5BE
		public static TBvbPlayerOperationTypeUnion FromIBvbRecycleHandCard(IBvbRecycleHandCardT _ibvbrecyclehandcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbRecycleHandCard,
				Value = _ibvbrecyclehandcard
			};
		}

		// Token: 0x0603A70D RID: 239373 RVA: 0x007DE3D3 File Offset: 0x007DC5D3
		public IBvbSelectCardT AsIBvbSelectCard()
		{
			return this.As<IBvbSelectCardT>();
		}

		// Token: 0x0603A70E RID: 239374 RVA: 0x007DE3DB File Offset: 0x007DC5DB
		public static TBvbPlayerOperationTypeUnion FromIBvbSelectCard(IBvbSelectCardT _ibvbselectcard)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbSelectCard,
				Value = _ibvbselectcard
			};
		}

		// Token: 0x0603A70F RID: 239375 RVA: 0x007DE3F0 File Offset: 0x007DC5F0
		public IBvbUseFieldCardSkillT AsIBvbUseFieldCardSkill()
		{
			return this.As<IBvbUseFieldCardSkillT>();
		}

		// Token: 0x0603A710 RID: 239376 RVA: 0x007DE3F8 File Offset: 0x007DC5F8
		public static TBvbPlayerOperationTypeUnion FromIBvbUseFieldCardSkill(IBvbUseFieldCardSkillT _ibvbusefieldcardskill)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbUseFieldCardSkill,
				Value = _ibvbusefieldcardskill
			};
		}

		// Token: 0x0603A711 RID: 239377 RVA: 0x007DE40E File Offset: 0x007DC60E
		public IBvbUseItemCardSkillT AsIBvbUseItemCardSkill()
		{
			return this.As<IBvbUseItemCardSkillT>();
		}

		// Token: 0x0603A712 RID: 239378 RVA: 0x007DE416 File Offset: 0x007DC616
		public static TBvbPlayerOperationTypeUnion FromIBvbUseItemCardSkill(IBvbUseItemCardSkillT _ibvbuseitemcardskill)
		{
			return new TBvbPlayerOperationTypeUnion
			{
				Type = TBvbPlayerOperationType.IBvbUseItemCardSkill,
				Value = _ibvbuseitemcardskill
			};
		}

		// Token: 0x0603A713 RID: 239379 RVA: 0x007DE42C File Offset: 0x007DC62C
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
