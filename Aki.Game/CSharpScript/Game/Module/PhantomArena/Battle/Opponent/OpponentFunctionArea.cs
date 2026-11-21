using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x0200425F RID: 16991
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentFunctionArea : UiPanelBase
	{
		// Token: 0x0602AF91 RID: 176017 RVA: 0x00C171CC File Offset: 0x00C153CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0602AF92 RID: 176018 RVA: 0x00C17280 File Offset: 0x00C15480
		protected override UniTask OnBeforeStartAsync()
		{
			OpponentFunctionArea.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<OpponentFunctionArea.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF93 RID: 176019 RVA: 0x00C172C4 File Offset: 0x00C154C4
		private UniTask InitAreaProxy()
		{
			OpponentFunctionArea.<InitAreaProxy>d__5 <InitAreaProxy>d__;
			<InitAreaProxy>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaProxy>d__.<>4__this = this;
			<InitAreaProxy>d__.<>1__state = -1;
			<InitAreaProxy>d__.<>t__builder.Start<OpponentFunctionArea.<InitAreaProxy>d__5>(ref <InitAreaProxy>d__);
			return <InitAreaProxy>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF94 RID: 176020 RVA: 0x00C17307 File Offset: 0x00C15507
		public void RegisterBattleArea(OpponentArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x0602AF95 RID: 176021 RVA: 0x00C17310 File Offset: 0x00C15510
		public UniTask TrySettingCard(int cardId, int index)
		{
			OpponentFunctionArea.<TrySettingCard>d__7 <TrySettingCard>d__;
			<TrySettingCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TrySettingCard>d__.<>4__this = this;
			<TrySettingCard>d__.cardId = cardId;
			<TrySettingCard>d__.index = index;
			<TrySettingCard>d__.<>1__state = -1;
			<TrySettingCard>d__.<>t__builder.Start<OpponentFunctionArea.<TrySettingCard>d__7>(ref <TrySettingCard>d__);
			return <TrySettingCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF96 RID: 176022 RVA: 0x00C17364 File Offset: 0x00C15564
		public UniTask TrySettingCardFromLibrary(int cardId, int index)
		{
			OpponentFunctionArea.<TrySettingCardFromLibrary>d__8 <TrySettingCardFromLibrary>d__;
			<TrySettingCardFromLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TrySettingCardFromLibrary>d__.<>4__this = this;
			<TrySettingCardFromLibrary>d__.cardId = cardId;
			<TrySettingCardFromLibrary>d__.index = index;
			<TrySettingCardFromLibrary>d__.<>1__state = -1;
			<TrySettingCardFromLibrary>d__.<>t__builder.Start<OpponentFunctionArea.<TrySettingCardFromLibrary>d__8>(ref <TrySettingCardFromLibrary>d__);
			return <TrySettingCardFromLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF97 RID: 176023 RVA: 0x00C173B8 File Offset: 0x00C155B8
		public UniTask TryEvolveCard(int cardId, int index)
		{
			OpponentFunctionArea.<TryEvolveCard>d__9 <TryEvolveCard>d__;
			<TryEvolveCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryEvolveCard>d__.<>4__this = this;
			<TryEvolveCard>d__.cardId = cardId;
			<TryEvolveCard>d__.index = index;
			<TryEvolveCard>d__.<>1__state = -1;
			<TryEvolveCard>d__.<>t__builder.Start<OpponentFunctionArea.<TryEvolveCard>d__9>(ref <TryEvolveCard>d__);
			return <TryEvolveCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF98 RID: 176024 RVA: 0x00C1740C File Offset: 0x00C1560C
		public UniTask TryUseCardSkill(PhantomCardData cardData)
		{
			OpponentFunctionArea.<TryUseCardSkill>d__10 <TryUseCardSkill>d__;
			<TryUseCardSkill>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryUseCardSkill>d__.<>4__this = this;
			<TryUseCardSkill>d__.cardData = cardData;
			<TryUseCardSkill>d__.<>1__state = -1;
			<TryUseCardSkill>d__.<>t__builder.Start<OpponentFunctionArea.<TryUseCardSkill>d__10>(ref <TryUseCardSkill>d__);
			return <TryUseCardSkill>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF99 RID: 176025 RVA: 0x00C17458 File Offset: 0x00C15658
		public UniTask TryChangeCard(int oneIndex, int twoIndex)
		{
			OpponentFunctionArea.<TryChangeCard>d__11 <TryChangeCard>d__;
			<TryChangeCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryChangeCard>d__.<>4__this = this;
			<TryChangeCard>d__.oneIndex = oneIndex;
			<TryChangeCard>d__.twoIndex = twoIndex;
			<TryChangeCard>d__.<>1__state = -1;
			<TryChangeCard>d__.<>t__builder.Start<OpponentFunctionArea.<TryChangeCard>d__11>(ref <TryChangeCard>d__);
			return <TryChangeCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF9A RID: 176026 RVA: 0x00C174AC File Offset: 0x00C156AC
		public UniTask BackToRecycle(int index)
		{
			OpponentFunctionArea.<BackToRecycle>d__12 <BackToRecycle>d__;
			<BackToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BackToRecycle>d__.<>4__this = this;
			<BackToRecycle>d__.index = index;
			<BackToRecycle>d__.<>1__state = -1;
			<BackToRecycle>d__.<>t__builder.Start<OpponentFunctionArea.<BackToRecycle>d__12>(ref <BackToRecycle>d__);
			return <BackToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF9B RID: 176027 RVA: 0x00C174F8 File Offset: 0x00C156F8
		public void ShowAddBuffEffect(EBuffShowType buffShowType, List<int> fightIdList)
		{
			foreach (OpponentFunctionAreaProxy opponentFunctionAreaProxy in this.CardProxyMap.Values)
			{
				if (opponentFunctionAreaProxy.Card != null && fightIdList.Contains(opponentFunctionAreaProxy.Card.Data.FightId))
				{
					OpponentMonsterProxy opponentMonsterProxy = opponentFunctionAreaProxy as OpponentMonsterProxy;
					if (opponentMonsterProxy != null)
					{
						if (buffShowType == EBuffShowType.UpGrade)
						{
							opponentMonsterProxy.AreaItem.SetBuffUpActive(true).Forget();
						}
						else if (buffShowType == EBuffShowType.DownGrade)
						{
							opponentMonsterProxy.AreaItem.SetBuffDownActive(true).Forget();
						}
					}
				}
			}
		}

		// Token: 0x0602AF9C RID: 176028 RVA: 0x00C175A0 File Offset: 0x00C157A0
		public UniTask DestroyCardByIndex(int index)
		{
			OpponentFunctionArea.<DestroyCardByIndex>d__14 <DestroyCardByIndex>d__;
			<DestroyCardByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyCardByIndex>d__.<>4__this = this;
			<DestroyCardByIndex>d__.index = index;
			<DestroyCardByIndex>d__.<>1__state = -1;
			<DestroyCardByIndex>d__.<>t__builder.Start<OpponentFunctionArea.<DestroyCardByIndex>d__14>(ref <DestroyCardByIndex>d__);
			return <DestroyCardByIndex>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF9D RID: 176029 RVA: 0x00C175EC File Offset: 0x00C157EC
		public void RefreshBattleCard(int cardId)
		{
			foreach (OpponentFunctionAreaProxy opponentFunctionAreaProxy in this.CardProxyMap.Values)
			{
				if (opponentFunctionAreaProxy.Card != null && opponentFunctionAreaProxy.Card.Data.CardId == cardId)
				{
					opponentFunctionAreaProxy.Card.RefreshSelfAsync().Forget();
					break;
				}
			}
		}

		// Token: 0x0602AF9E RID: 176030 RVA: 0x00C1766C File Offset: 0x00C1586C
		public void RefreshAllBattleCard()
		{
			foreach (OpponentFunctionAreaProxy opponentFunctionAreaProxy in this.CardProxyMap.Values)
			{
				if (opponentFunctionAreaProxy.Card != null)
				{
					opponentFunctionAreaProxy.Card.RefreshSelfAsync().Forget();
				}
			}
		}

		// Token: 0x0602AF9F RID: 176031 RVA: 0x00C176D8 File Offset: 0x00C158D8
		public OpponentFunctionAreaProxy GetCardProxyByCardId(int cardId)
		{
			foreach (OpponentFunctionAreaProxy opponentFunctionAreaProxy in this.CardProxyMap.Values)
			{
				if (opponentFunctionAreaProxy.Card != null && opponentFunctionAreaProxy.Card.Data.CardId == cardId)
				{
					return opponentFunctionAreaProxy;
				}
			}
			return null;
		}

		// Token: 0x0602AFA0 RID: 176032 RVA: 0x00C1774C File Offset: 0x00C1594C
		public OpponentFunctionAreaProxy GetCardProxyByIndex(int index)
		{
			OpponentFunctionAreaProxy result;
			if (!this.CardProxyMap.TryGetValue(index, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602AFA1 RID: 176033 RVA: 0x00C1776C File Offset: 0x00C1596C
		public UniTask CopyCardListToFight(IEnumerable<PhantomBattleFighterInfo> cardInfoList)
		{
			OpponentFunctionArea.<CopyCardListToFight>d__19 <CopyCardListToFight>d__;
			<CopyCardListToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CopyCardListToFight>d__.<>4__this = this;
			<CopyCardListToFight>d__.cardInfoList = cardInfoList;
			<CopyCardListToFight>d__.<>1__state = -1;
			<CopyCardListToFight>d__.<>t__builder.Start<OpponentFunctionArea.<CopyCardListToFight>d__19>(ref <CopyCardListToFight>d__);
			return <CopyCardListToFight>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFA2 RID: 176034 RVA: 0x00C177B8 File Offset: 0x00C159B8
		public UniTask PlayDamageHitEffect(int fightId, UUIItem toItem)
		{
			OpponentFunctionArea.<PlayDamageHitEffect>d__20 <PlayDamageHitEffect>d__;
			<PlayDamageHitEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDamageHitEffect>d__.<>4__this = this;
			<PlayDamageHitEffect>d__.fightId = fightId;
			<PlayDamageHitEffect>d__.toItem = toItem;
			<PlayDamageHitEffect>d__.<>1__state = -1;
			<PlayDamageHitEffect>d__.<>t__builder.Start<OpponentFunctionArea.<PlayDamageHitEffect>d__20>(ref <PlayDamageHitEffect>d__);
			return <PlayDamageHitEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFA3 RID: 176035 RVA: 0x00C1780C File Offset: 0x00C15A0C
		public UniTask ReconstructFightCardToRecycle(IEnumerable<int> cardIdList)
		{
			OpponentFunctionArea.<ReconstructFightCardToRecycle>d__21 <ReconstructFightCardToRecycle>d__;
			<ReconstructFightCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReconstructFightCardToRecycle>d__.<>4__this = this;
			<ReconstructFightCardToRecycle>d__.cardIdList = cardIdList;
			<ReconstructFightCardToRecycle>d__.<>1__state = -1;
			<ReconstructFightCardToRecycle>d__.<>t__builder.Start<OpponentFunctionArea.<ReconstructFightCardToRecycle>d__21>(ref <ReconstructFightCardToRecycle>d__);
			return <ReconstructFightCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFA4 RID: 176036 RVA: 0x00C17858 File Offset: 0x00C15A58
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length < 3)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "BattleCard")
			{
				int key = int.Parse(configParams[2]);
				OpponentFunctionAreaProxy opponentFunctionAreaProxy;
				if (this.CardProxyMap.TryGetValue(key, out opponentFunctionAreaProxy))
				{
					PhantomArenaCard card = opponentFunctionAreaProxy.Card;
					if (card == null)
					{
						return null;
					}
					return card.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
			}
			if (a == "BattleCardById" || a == "BattleCardSkillById")
			{
				int num = int.Parse(configParams[2]);
				foreach (OpponentFunctionAreaProxy opponentFunctionAreaProxy2 in this.CardProxyMap.Values)
				{
					PhantomArenaCard card2 = opponentFunctionAreaProxy2.Card;
					bool flag;
					if (card2 == null)
					{
						flag = false;
					}
					else
					{
						PhantomCardData data = card2.Data;
						int? num2 = (data != null) ? new int?(data.ConfigId) : null;
						int num3 = num;
						flag = (num2.GetValueOrDefault() == num3 & num2 != null);
					}
					if (flag)
					{
						return opponentFunctionAreaProxy2.Card.GetGuideUiItemAndUiItemForShowEx(configParams);
					}
				}
			}
			return null;
		}

		// Token: 0x04017413 RID: 95251
		public OpponentArea ParentArea;

		// Token: 0x04017414 RID: 95252
		protected Dictionary<int, OpponentFunctionAreaProxy> CardProxyMap = new Dictionary<int, OpponentFunctionAreaProxy>();

		// Token: 0x02009EE5 RID: 40677
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031628 RID: 202280
			public const int MonsterOne = 0;

			// Token: 0x04031629 RID: 202281
			public const int MonsterTwo = 1;

			// Token: 0x0403162A RID: 202282
			public const int MonsterThree = 2;

			// Token: 0x0403162B RID: 202283
			public const int MonsterFour = 3;

			// Token: 0x0403162C RID: 202284
			public const int MonsterFive = 4;

			// Token: 0x0403162D RID: 202285
			public const int MonsterSix = 5;

			// Token: 0x0403162E RID: 202286
			public const int FunctionOne = 6;
		}
	}
}
