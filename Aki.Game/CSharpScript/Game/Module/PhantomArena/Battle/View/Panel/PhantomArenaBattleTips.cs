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
	// Token: 0x02005256 RID: 21078
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleTips : UiPanelBase
	{
		// Token: 0x06035DE0 RID: 220640 RVA: 0x00CBF573 File Offset: 0x00CBD773
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06035DE1 RID: 220641 RVA: 0x00CBF5AC File Offset: 0x00CBD7AC
		protected UniTask InitCardItem()
		{
			PhantomArenaBattleTips.<InitCardItem>d__6 <InitCardItem>d__;
			<InitCardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardItem>d__.<>4__this = this;
			<InitCardItem>d__.<>1__state = -1;
			<InitCardItem>d__.<>t__builder.Start<PhantomArenaBattleTips.<InitCardItem>d__6>(ref <InitCardItem>d__);
			return <InitCardItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035DE2 RID: 220642 RVA: 0x00CBF5F0 File Offset: 0x00CBD7F0
		protected UniTask InitDetailsTipsItem()
		{
			PhantomArenaBattleTips.<InitDetailsTipsItem>d__7 <InitDetailsTipsItem>d__;
			<InitDetailsTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsTipsItem>d__.<>4__this = this;
			<InitDetailsTipsItem>d__.<>1__state = -1;
			<InitDetailsTipsItem>d__.<>t__builder.Start<PhantomArenaBattleTips.<InitDetailsTipsItem>d__7>(ref <InitDetailsTipsItem>d__);
			return <InitDetailsTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035DE3 RID: 220643 RVA: 0x00CBF634 File Offset: 0x00CBD834
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleTips.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleTips.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035DE4 RID: 220644 RVA: 0x00CBF677 File Offset: 0x00CBD877
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06035DE5 RID: 220645 RVA: 0x00CBF6A1 File Offset: 0x00CBD8A1
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035DE6 RID: 220646 RVA: 0x00CBF6AE File Offset: 0x00CBD8AE
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035DE7 RID: 220647 RVA: 0x00CBF6C4 File Offset: 0x00CBD8C4
		public void RefreshTips(PhantomCardData cardData, bool isCardItemShow)
		{
			this.CardItem.SetUiActive(isCardItemShow);
			this.CardItem.Refresh(cardData);
			this.DetailsTipsItem.RefreshByCardData(cardData);
		}

		// Token: 0x06035DE8 RID: 220648 RVA: 0x00CBF6EC File Offset: 0x00CBD8EC
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

		// Token: 0x06035DE9 RID: 220649 RVA: 0x00CBF768 File Offset: 0x00CBD968
		public int GetCardId()
		{
			return this.CardItem.Data.CardId;
		}

		// Token: 0x06035DEA RID: 220650 RVA: 0x00CBF77A File Offset: 0x00CBD97A
		public void RefreshContent()
		{
			this.DetailsTipsItem.RefreshByCardData(this.CardItem.Data);
		}

		// Token: 0x06035DEB RID: 220651 RVA: 0x00CBF794 File Offset: 0x00CBD994
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

		// Token: 0x0401C8BC RID: 116924
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C8BD RID: 116925
		protected PhantomArenaCard CardItem;

		// Token: 0x0401C8BE RID: 116926
		protected PhantomArenaBattleDetailsTips DetailsTipsItem;

		// Token: 0x0401C8BF RID: 116927
		public bool IsInActive;

		// Token: 0x0200B40F RID: 46095
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040368F4 RID: 223476
			public const int CardItem = 0;

			// Token: 0x040368F5 RID: 223477
			public const int ContentItem = 1;
		}
	}
}
