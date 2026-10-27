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
	// Token: 0x0200528F RID: 21135
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentFunctionArea : UiPanelBase
	{
		// Token: 0x06036096 RID: 221334 RVA: 0x00CC9AC8 File Offset: 0x00CC7CC8
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

		// Token: 0x06036097 RID: 221335 RVA: 0x00CC9B7C File Offset: 0x00CC7D7C
		protected override UniTask OnBeforeStartAsync()
		{
			OpponentFunctionArea.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<OpponentFunctionArea.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036098 RID: 221336 RVA: 0x00CC9BC0 File Offset: 0x00CC7DC0
		private UniTask InitAreaProxy()
		{
			OpponentFunctionArea.<InitAreaProxy>d__5 <InitAreaProxy>d__;
			<InitAreaProxy>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAreaProxy>d__.<>4__this = this;
			<InitAreaProxy>d__.<>1__state = -1;
			<InitAreaProxy>d__.<>t__builder.Start<OpponentFunctionArea.<InitAreaProxy>d__5>(ref <InitAreaProxy>d__);
			return <InitAreaProxy>d__.<>t__builder.Task;
		}

		// Token: 0x06036099 RID: 221337 RVA: 0x00CC9C03 File Offset: 0x00CC7E03
		public void RegisterBattleArea(OpponentArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x0603609A RID: 221338 RVA: 0x00CC9C0C File Offset: 0x00CC7E0C
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

		// Token: 0x0603609B RID: 221339 RVA: 0x00CC9C60 File Offset: 0x00CC7E60
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

		// Token: 0x0603609C RID: 221340 RVA: 0x00CC9CB4 File Offset: 0x00CC7EB4
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

		// Token: 0x0603609D RID: 221341 RVA: 0x00CC9D08 File Offset: 0x00CC7F08
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

		// Token: 0x0603609E RID: 221342 RVA: 0x00CC9D54 File Offset: 0x00CC7F54
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

		// Token: 0x0603609F RID: 221343 RVA: 0x00CC9DA8 File Offset: 0x00CC7FA8
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

		// Token: 0x060360A0 RID: 221344 RVA: 0x00CC9DF4 File Offset: 0x00CC7FF4
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

		// Token: 0x060360A1 RID: 221345 RVA: 0x00CC9E9C File Offset: 0x00CC809C
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

		// Token: 0x060360A2 RID: 221346 RVA: 0x00CC9EE8 File Offset: 0x00CC80E8
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

		// Token: 0x060360A3 RID: 221347 RVA: 0x00CC9F68 File Offset: 0x00CC8168
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

		// Token: 0x060360A4 RID: 221348 RVA: 0x00CC9FD4 File Offset: 0x00CC81D4
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

		// Token: 0x060360A5 RID: 221349 RVA: 0x00CCA048 File Offset: 0x00CC8248
		public OpponentFunctionAreaProxy GetCardProxyByIndex(int index)
		{
			OpponentFunctionAreaProxy result;
			if (!this.CardProxyMap.TryGetValue(index, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060360A6 RID: 221350 RVA: 0x00CCA068 File Offset: 0x00CC8268
		public UniTask CopyCardListToFight(List<PhantomBattleFighterInfo> cardInfoList)
		{
			OpponentFunctionArea.<CopyCardListToFight>d__19 <CopyCardListToFight>d__;
			<CopyCardListToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CopyCardListToFight>d__.<>4__this = this;
			<CopyCardListToFight>d__.cardInfoList = cardInfoList;
			<CopyCardListToFight>d__.<>1__state = -1;
			<CopyCardListToFight>d__.<>t__builder.Start<OpponentFunctionArea.<CopyCardListToFight>d__19>(ref <CopyCardListToFight>d__);
			return <CopyCardListToFight>d__.<>t__builder.Task;
		}

		// Token: 0x060360A7 RID: 221351 RVA: 0x00CCA0B4 File Offset: 0x00CC82B4
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

		// Token: 0x060360A8 RID: 221352 RVA: 0x00CCA108 File Offset: 0x00CC8308
		public UniTask ReconstructFightCardToRecycle(List<int> cardIdList)
		{
			OpponentFunctionArea.<ReconstructFightCardToRecycle>d__21 <ReconstructFightCardToRecycle>d__;
			<ReconstructFightCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReconstructFightCardToRecycle>d__.<>4__this = this;
			<ReconstructFightCardToRecycle>d__.cardIdList = cardIdList;
			<ReconstructFightCardToRecycle>d__.<>1__state = -1;
			<ReconstructFightCardToRecycle>d__.<>t__builder.Start<OpponentFunctionArea.<ReconstructFightCardToRecycle>d__21>(ref <ReconstructFightCardToRecycle>d__);
			return <ReconstructFightCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x060360A9 RID: 221353 RVA: 0x00CCA154 File Offset: 0x00CC8354
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

		// Token: 0x0401C9DE RID: 117214
		public OpponentArea ParentArea;

		// Token: 0x0401C9DF RID: 117215
		protected Dictionary<int, OpponentFunctionAreaProxy> CardProxyMap = new Dictionary<int, OpponentFunctionAreaProxy>();

		// Token: 0x0200B4AD RID: 46253
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036BD5 RID: 224213
			public const int MonsterOne = 0;

			// Token: 0x04036BD6 RID: 224214
			public const int MonsterTwo = 1;

			// Token: 0x04036BD7 RID: 224215
			public const int MonsterThree = 2;

			// Token: 0x04036BD8 RID: 224216
			public const int MonsterFour = 3;

			// Token: 0x04036BD9 RID: 224217
			public const int MonsterFive = 4;

			// Token: 0x04036BDA RID: 224218
			public const int MonsterSix = 5;

			// Token: 0x04036BDB RID: 224219
			public const int FunctionOne = 6;
		}
	}
}
