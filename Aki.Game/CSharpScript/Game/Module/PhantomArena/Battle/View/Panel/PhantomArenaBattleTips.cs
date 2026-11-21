using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02004226 RID: 16934
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleTips : UiPanelBase
	{
		// Token: 0x0602ACDB RID: 175323 RVA: 0x00C0CC03 File Offset: 0x00C0AE03
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602ACDC RID: 175324 RVA: 0x00C0CC3C File Offset: 0x00C0AE3C
		protected UniTask InitCardItem()
		{
			PhantomArenaBattleTips.<InitCardItem>d__6 <InitCardItem>d__;
			<InitCardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardItem>d__.<>4__this = this;
			<InitCardItem>d__.<>1__state = -1;
			<InitCardItem>d__.<>t__builder.Start<PhantomArenaBattleTips.<InitCardItem>d__6>(ref <InitCardItem>d__);
			return <InitCardItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACDD RID: 175325 RVA: 0x00C0CC80 File Offset: 0x00C0AE80
		protected UniTask InitDetailsTipsItem()
		{
			PhantomArenaBattleTips.<InitDetailsTipsItem>d__7 <InitDetailsTipsItem>d__;
			<InitDetailsTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsTipsItem>d__.<>4__this = this;
			<InitDetailsTipsItem>d__.<>1__state = -1;
			<InitDetailsTipsItem>d__.<>t__builder.Start<PhantomArenaBattleTips.<InitDetailsTipsItem>d__7>(ref <InitDetailsTipsItem>d__);
			return <InitDetailsTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACDE RID: 175326 RVA: 0x00C0CCC4 File Offset: 0x00C0AEC4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleTips.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleTips.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ACDF RID: 175327 RVA: 0x00C0CD07 File Offset: 0x00C0AF07
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0602ACE0 RID: 175328 RVA: 0x00C0CD31 File Offset: 0x00C0AF31
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602ACE1 RID: 175329 RVA: 0x00C0CD3E File Offset: 0x00C0AF3E
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602ACE2 RID: 175330 RVA: 0x00C0CD54 File Offset: 0x00C0AF54
		public void RefreshTips(PhantomCardData cardData, bool isCardItemShow)
		{
			this.CardItem.SetUiActive(isCardItemShow);
			this.CardItem.Refresh(cardData);
			this.DetailsTipsItem.RefreshByCardData(cardData);
		}

		// Token: 0x0602ACE3 RID: 175331 RVA: 0x00C0CD7C File Offset: 0x00C0AF7C
		public void SetTipsActive(bool isActive)
		{
			if (this.IsInActive == isActive)
			{
				return;
			}
			this.IsInActive = isActive;
			if (this.IsInActive)
			{
				this.SetActive(true);
				this.Sequence.StopPrevSequence(false, true);
				this.Sequence.PlaySequence("Start", false, null);
				return;
			}
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Close", false, null);
		}

		// Token: 0x0602ACE4 RID: 175332 RVA: 0x00C0CDF8 File Offset: 0x00C0AFF8
		public int GetCardId()
		{
			return this.CardItem.Data.CardId;
		}

		// Token: 0x0602ACE5 RID: 175333 RVA: 0x00C0CE0A File Offset: 0x00C0B00A
		public void RefreshContent()
		{
			this.DetailsTipsItem.RefreshByCardData(this.CardItem.Data);
		}

		// Token: 0x0602ACE6 RID: 175334 RVA: 0x00C0CE24 File Offset: 0x00C0B024
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "CardEffect" || a == "CardAttr" || a == "CardFullInfo")
			{
				PhantomArenaBattleDetailsTips detailsTipsItem = this.DetailsTipsItem;
				if (detailsTipsItem == null)
				{
					return null;
				}
				return detailsTipsItem.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (!(a == "DetailCard"))
				{
					return null;
				}
				PhantomArenaCard cardItem = this.CardItem;
				if (cardItem == null)
				{
					return null;
				}
				return cardItem.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x040172F1 RID: 94961
		protected UiSequencePlayer Sequence;

		// Token: 0x040172F2 RID: 94962
		protected PhantomArenaCard CardItem;

		// Token: 0x040172F3 RID: 94963
		protected PhantomArenaBattleDetailsTips DetailsTipsItem;

		// Token: 0x040172F4 RID: 94964
		public bool IsInActive;

		// Token: 0x02009E47 RID: 40519
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031347 RID: 201543
			public const int CardItem = 0;

			// Token: 0x04031348 RID: 201544
			public const int ContentItem = 1;
		}
	}
}
