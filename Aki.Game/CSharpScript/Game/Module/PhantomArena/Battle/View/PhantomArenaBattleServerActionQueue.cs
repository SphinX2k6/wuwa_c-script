using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Guide;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x0200524C RID: 21068
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleServerActionQueue
	{
		// Token: 0x06035D32 RID: 220466 RVA: 0x00CBBD14 File Offset: 0x00CB9F14
		public PhantomArenaBattleServerActionQueue(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x06035D33 RID: 220467 RVA: 0x00CBBD30 File Offset: 0x00CB9F30
		public void PushFourTaskAction(PhantomBattleHandCardInfo data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass6_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass6_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送4c任务,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass6_0.<<PushFourTaskAction>b__0>d <<PushFourTaskAction>b__0>d;
				<<PushFourTaskAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushFourTaskAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushFourTaskAction>b__0>d.<>1__state = -1;
				<<PushFourTaskAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass6_0.<<PushFourTaskAction>b__0>d>(ref <<PushFourTaskAction>b__0>d);
				return <<PushFourTaskAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.FourTask
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D34 RID: 220468 RVA: 0x00CBBDA4 File Offset: 0x00CB9FA4
		public void PushChooseCardAction(PhantomBattleCardSelectEffectCtx data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass7_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass7_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送抽卡行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass7_0.<<PushChooseCardAction>b__0>d <<PushChooseCardAction>b__0>d;
				<<PushChooseCardAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushChooseCardAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushChooseCardAction>b__0>d.<>1__state = -1;
				<<PushChooseCardAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass7_0.<<PushChooseCardAction>b__0>d>(ref <<PushChooseCardAction>b__0>d);
				return <<PushChooseCardAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.ChooseCard
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D35 RID: 220469 RVA: 0x00CBBE18 File Offset: 0x00CBA018
		public void PushDiscardCardAction(PhantomBattleDiscardCardNotify data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass8_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass8_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送弃牌行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass8_0.<<PushDiscardCardAction>b__0>d <<PushDiscardCardAction>b__0>d;
				<<PushDiscardCardAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushDiscardCardAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushDiscardCardAction>b__0>d.<>1__state = -1;
				<<PushDiscardCardAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass8_0.<<PushDiscardCardAction>b__0>d>(ref <<PushDiscardCardAction>b__0>d);
				return <<PushDiscardCardAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.DiscardCard
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D36 RID: 220470 RVA: 0x00CBBE8C File Offset: 0x00CBA08C
		public void PushReserveCardAction(PhantomBattleSelectReserveCardNotify data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass9_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass9_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送保留卡行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass9_0.<<PushReserveCardAction>b__0>d <<PushReserveCardAction>b__0>d;
				<<PushReserveCardAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushReserveCardAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushReserveCardAction>b__0>d.<>1__state = -1;
				<<PushReserveCardAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass9_0.<<PushReserveCardAction>b__0>d>(ref <<PushReserveCardAction>b__0>d);
				return <<PushReserveCardAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.ReserveCard
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D37 RID: 220471 RVA: 0x00CBBF00 File Offset: 0x00CBA100
		public void PushBattleCallCardAction(PhantomBattleCallCardNotify data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass10_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass10_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送召唤卡行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass10_0.<<PushBattleCallCardAction>b__0>d <<PushBattleCallCardAction>b__0>d;
				<<PushBattleCallCardAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushBattleCallCardAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushBattleCallCardAction>b__0>d.<>1__state = -1;
				<<PushBattleCallCardAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass10_0.<<PushBattleCallCardAction>b__0>d>(ref <<PushBattleCallCardAction>b__0>d);
				return <<PushBattleCallCardAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.BattleCallCard
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D38 RID: 220472 RVA: 0x00CBBF74 File Offset: 0x00CBA174
		public void PushBattleCallCardShowAction(PhantomBattleSelectedCardFromType type, List<PhantomBattleFighterInfo> resultList)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass11_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass11_0();
			CS$<>8__locals1.type = type;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.resultList = resultList;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送召唤卡展示行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			CS$<>8__locals1.cardIdList = new List<int>();
			foreach (PhantomBattleFighterInfo phantomBattleFighterInfo in CS$<>8__locals1.resultList)
			{
				CS$<>8__locals1.cardIdList.Add(phantomBattleFighterInfo.UId);
			}
			PhantomArenaBattleModel.Instance.AddWaitCallCardIdList(CS$<>8__locals1.cardIdList);
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass11_0.<<PushBattleCallCardShowAction>b__0>d <<PushBattleCallCardShowAction>b__0>d;
				<<PushBattleCallCardShowAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushBattleCallCardShowAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushBattleCallCardShowAction>b__0>d.<>1__state = -1;
				<<PushBattleCallCardShowAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass11_0.<<PushBattleCallCardShowAction>b__0>d>(ref <<PushBattleCallCardShowAction>b__0>d);
				return <<PushBattleCallCardShowAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.BattleCallCardShow
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D39 RID: 220473 RVA: 0x00CBC05C File Offset: 0x00CBA25C
		public void PushReconstructCardAction(PhantomBattleReconstructCardNotify data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass12_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass12_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送重构卡牌行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass12_0.<<PushReconstructCardAction>b__0>d <<PushReconstructCardAction>b__0>d;
				<<PushReconstructCardAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushReconstructCardAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushReconstructCardAction>b__0>d.<>1__state = -1;
				<<PushReconstructCardAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass12_0.<<PushReconstructCardAction>b__0>d>(ref <<PushReconstructCardAction>b__0>d);
				return <<PushReconstructCardAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.ReconstructCard
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D3A RID: 220474 RVA: 0x00CBC0D0 File Offset: 0x00CBA2D0
		public void PushTriggerPassiveSkillInteractAction(PhantomBattleSelectTargetEffectNotify data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass13_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass13_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送被动技能选择行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass13_0.<<PushTriggerPassiveSkillInteractAction>b__0>d <<PushTriggerPassiveSkillInteractAction>b__0>d;
				<<PushTriggerPassiveSkillInteractAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushTriggerPassiveSkillInteractAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushTriggerPassiveSkillInteractAction>b__0>d.<>1__state = -1;
				<<PushTriggerPassiveSkillInteractAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass13_0.<<PushTriggerPassiveSkillInteractAction>b__0>d>(ref <<PushTriggerPassiveSkillInteractAction>b__0>d);
				return <<PushTriggerPassiveSkillInteractAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.TriggerPassiveSkillInteract
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D3B RID: 220475 RVA: 0x00CBC144 File Offset: 0x00CBA344
		public void PushSkillEffectAction()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送技能效果行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<<PushSkillEffectAction>b__14_0>d <<PushSkillEffectAction>b__14_0>d;
				<<PushSkillEffectAction>b__14_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushSkillEffectAction>b__14_0>d.<>4__this = this;
				<<PushSkillEffectAction>b__14_0>d.<>1__state = -1;
				<<PushSkillEffectAction>b__14_0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<<PushSkillEffectAction>b__14_0>d>(ref <<PushSkillEffectAction>b__14_0>d);
				return <<PushSkillEffectAction>b__14_0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.SkillEffect
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D3C RID: 220476 RVA: 0x00CBC1A4 File Offset: 0x00CBA3A4
		public void PushFieldSkillEffectAction()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "推送领域技能效果行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<<PushFieldSkillEffectAction>b__15_0>d <<PushFieldSkillEffectAction>b__15_0>d;
				<<PushFieldSkillEffectAction>b__15_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushFieldSkillEffectAction>b__15_0>d.<>4__this = this;
				<<PushFieldSkillEffectAction>b__15_0>d.<>1__state = -1;
				<<PushFieldSkillEffectAction>b__15_0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<<PushFieldSkillEffectAction>b__15_0>d>(ref <<PushFieldSkillEffectAction>b__15_0>d);
				return <<PushFieldSkillEffectAction>b__15_0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.FieldSkillEffect
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D3D RID: 220477 RVA: 0x00CBC204 File Offset: 0x00CBA404
		public void PushCardDurableEmptyAction(PhantomBattleCardDurableEmptyNotify data)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass16_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass16_0();
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.<>4__this = this;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送卡牌耐久空通知,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			PhantomArenaBattleModel.Instance.AddWaitReconstructCardIdList(new List<int>
			{
				CS$<>8__locals1.data.CardUid
			});
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass16_0.<<PushCardDurableEmptyAction>b__0>d <<PushCardDurableEmptyAction>b__0>d;
				<<PushCardDurableEmptyAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushCardDurableEmptyAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushCardDurableEmptyAction>b__0>d.<>1__state = -1;
				<<PushCardDurableEmptyAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass16_0.<<PushCardDurableEmptyAction>b__0>d>(ref <<PushCardDurableEmptyAction>b__0>d);
				return <<PushCardDurableEmptyAction>b__0>d.<>t__builder.Task;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.CardDurableEmpty
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D3E RID: 220478 RVA: 0x00CBC298 File Offset: 0x00CBA498
		public void PushCountSkillEffectAction(int cardId, int curEffectCount)
		{
			PhantomArenaBattleServerActionQueue.<>c__DisplayClass17_0 CS$<>8__locals1 = new PhantomArenaBattleServerActionQueue.<>c__DisplayClass17_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.cardId = cardId;
			CS$<>8__locals1.curEffectCount = curEffectCount;
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服推送卡牌计数表现,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				PhantomArenaBattleServerActionQueue.<>c__DisplayClass17_0.<<PushCountSkillEffectAction>b__0>d <<PushCountSkillEffectAction>b__0>d;
				<<PushCountSkillEffectAction>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<PushCountSkillEffectAction>b__0>d.<>4__this = CS$<>8__locals1;
				<<PushCountSkillEffectAction>b__0>d.<>1__state = -1;
				<<PushCountSkillEffectAction>b__0>d.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<>c__DisplayClass17_0.<<PushCountSkillEffectAction>b__0>d>(ref <<PushCountSkillEffectAction>b__0>d);
				return <<PushCountSkillEffectAction>b__0>d.<>t__builder.Task;
			};
			if (this.ActionQueue.Size > 0)
			{
				IServerAction serverAction = this.ActionQueue.Get(this.ActionQueue.Size - 1);
				if (serverAction != null && serverAction.Type == EServerActionType.CountSkillEffect)
				{
					CountEffectServerActionList countEffectServerActionList = (CountEffectServerActionList)serverAction;
					if (countEffectServerActionList != null)
					{
						foreach (int num in countEffectServerActionList.CardIdList)
						{
							if (CS$<>8__locals1.cardId == num)
							{
								CountEffectServerActionList serverAction2 = new CountEffectServerActionList
								{
									ActionList = new List<TServerAction>
									{
										item
									},
									Type = EServerActionType.CountSkillEffect,
									CardIdList = new List<int>
									{
										CS$<>8__locals1.cardId
									}
								};
								this.AddActionQueue(serverAction2);
								return;
							}
						}
						countEffectServerActionList.ActionList.Add(item);
						global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器卡牌计数表现插入到最尾部已存在的行为列表中", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
				}
			}
			CountEffectServerActionList serverAction3 = new CountEffectServerActionList
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.CountSkillEffect,
				CardIdList = new List<int>
				{
					CS$<>8__locals1.cardId
				}
			};
			this.AddActionQueue(serverAction3);
		}

		// Token: 0x06035D3F RID: 220479 RVA: 0x00CBC438 File Offset: 0x00CBA638
		public void PushBattleResultAction(PhantomBattleBoardSettleNotify data)
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "服务器推送战斗结果行为,推送到行为队列中", default(ReadOnlySpan<ValueTuple<string, object>>));
			TServerAction item = delegate()
			{
				global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "执行服务器战斗结果行为开始", default(ReadOnlySpan<ValueTuple<string, object>>));
				PhantomArenaBattleController.Instance.TriggerPhantomBattleResultShow(data);
				global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "执行服务器战斗结果行为完成", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.CompletedTask;
			};
			ServerAction serverAction = new ServerAction
			{
				ActionList = new List<TServerAction>
				{
					item
				},
				Type = EServerActionType.BattleResult
			};
			this.AddActionQueue(serverAction);
		}

		// Token: 0x06035D40 RID: 220480 RVA: 0x00CBC4A4 File Offset: 0x00CBA6A4
		public void PauseAction()
		{
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "执行服务器行为暂停", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.IsInPause = true;
		}

		// Token: 0x06035D41 RID: 220481 RVA: 0x00CBC4D8 File Offset: 0x00CBA6D8
		public UniTask ResumeAction()
		{
			PhantomArenaBattleServerActionQueue.<ResumeAction>d__20 <ResumeAction>d__;
			<ResumeAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeAction>d__.<>4__this = this;
			<ResumeAction>d__.<>1__state = -1;
			<ResumeAction>d__.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<ResumeAction>d__20>(ref <ResumeAction>d__);
			return <ResumeAction>d__.<>t__builder.Task;
		}

		// Token: 0x06035D42 RID: 220482 RVA: 0x00CBC51B File Offset: 0x00CBA71B
		public bool InAction()
		{
			return this.IsInAction;
		}

		// Token: 0x06035D43 RID: 220483 RVA: 0x00CBC524 File Offset: 0x00CBA724
		public UniTask WaitHandleFinish()
		{
			PhantomArenaBattleServerActionQueue.<WaitHandleFinish>d__22 <WaitHandleFinish>d__;
			<WaitHandleFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitHandleFinish>d__.<>4__this = this;
			<WaitHandleFinish>d__.<>1__state = -1;
			<WaitHandleFinish>d__.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<WaitHandleFinish>d__22>(ref <WaitHandleFinish>d__);
			return <WaitHandleFinish>d__.<>t__builder.Task;
		}

		// Token: 0x06035D44 RID: 220484 RVA: 0x00CBC568 File Offset: 0x00CBA768
		protected UniTask HandleAction()
		{
			PhantomArenaBattleServerActionQueue.<HandleAction>d__23 <HandleAction>d__;
			<HandleAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleAction>d__.<>4__this = this;
			<HandleAction>d__.<>1__state = -1;
			<HandleAction>d__.<>t__builder.Start<PhantomArenaBattleServerActionQueue.<HandleAction>d__23>(ref <HandleAction>d__);
			return <HandleAction>d__.<>t__builder.Task;
		}

		// Token: 0x06035D45 RID: 220485 RVA: 0x00CBC5AB File Offset: 0x00CBA7AB
		protected void AddActionQueue(IServerAction serverAction)
		{
			if (this.HandleActionPromise == null)
			{
				this.HandleActionPromise = new CustomPromise();
			}
			this.ActionQueue.Push(serverAction);
			this.HandleAction().Forget();
		}

		// Token: 0x06035D46 RID: 220486 RVA: 0x00CBC5D8 File Offset: 0x00CBA7D8
		protected void TryFinishGuide(int cardId, int? skillId = null)
		{
			PhantomArenaGuideCardSkillData phantomArenaGuideCardSkillData = new PhantomArenaGuideCardSkillData
			{
				CardId = cardId
			};
			this.Proxy.GuideManager.TryFinishGuideByType(EBvbPlayerOperationType.BvbUseItemCardSkill, new object[]
			{
				phantomArenaGuideCardSkillData
			});
			this.Proxy.GuideManager.TryFinishGuideByType(EBvbPlayerOperationType.BvbUseFieldCardSkill, new object[]
			{
				phantomArenaGuideCardSkillData
			});
		}

		// Token: 0x0401C897 RID: 116887
		protected Queue<IServerAction> ActionQueue = new Queue<IServerAction>(4);

		// Token: 0x0401C898 RID: 116888
		protected bool IsInAction;

		// Token: 0x0401C899 RID: 116889
		protected bool IsInPause;

		// Token: 0x0401C89A RID: 116890
		[Nullable(2)]
		protected CustomPromise HandleActionPromise;

		// Token: 0x0401C89B RID: 116891
		protected PhantomArenaBattleProxy Proxy;
	}
}
