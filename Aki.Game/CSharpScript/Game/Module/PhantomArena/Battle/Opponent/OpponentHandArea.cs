using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x02005291 RID: 21137
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentHandArea : UiPanelBase
	{
		// Token: 0x060360C4 RID: 221380 RVA: 0x00CCA794 File Offset: 0x00CC8994
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout))
			};
		}

		// Token: 0x060360C5 RID: 221381 RVA: 0x00CCA7B7 File Offset: 0x00CC89B7
		protected override void OnStart()
		{
			this.Layout = base.GetHorizontalLayout(0);
			this.OriginalSpace = this.Layout.GetSpacing();
		}

		// Token: 0x060360C6 RID: 221382 RVA: 0x00CCA7D8 File Offset: 0x00CC89D8
		private UniTask CreateHandCardItem()
		{
			OpponentHandArea.<CreateHandCardItem>d__11 <CreateHandCardItem>d__;
			<CreateHandCardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateHandCardItem>d__.<>4__this = this;
			<CreateHandCardItem>d__.<>1__state = -1;
			<CreateHandCardItem>d__.<>t__builder.Start<OpponentHandArea.<CreateHandCardItem>d__11>(ref <CreateHandCardItem>d__);
			return <CreateHandCardItem>d__.<>t__builder.Task;
		}

		// Token: 0x060360C7 RID: 221383 RVA: 0x00CCA81C File Offset: 0x00CC8A1C
		private void CalculateLayoutSpace()
		{
			this.TotalWidth = 6f * this.GridWidth + 5f * this.OriginalSpace;
			this.TotalHeight = this.Layout.RootUIComp.Get().GetHeight();
			float spacing = this.OriginalSpace;
			if (this.HandCardItemList.Count > 6)
			{
				spacing = (this.TotalWidth - (float)this.HandCardItemList.Count * this.GridWidth) / (float)(this.HandCardItemList.Count - 1);
			}
			this.Layout.SetSpacing(spacing);
		}

		// Token: 0x060360C8 RID: 221384 RVA: 0x00CCA8B4 File Offset: 0x00CC8AB4
		private UniTask InitHandCardNum()
		{
			OpponentHandArea.<InitHandCardNum>d__13 <InitHandCardNum>d__;
			<InitHandCardNum>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHandCardNum>d__.<>4__this = this;
			<InitHandCardNum>d__.<>1__state = -1;
			<InitHandCardNum>d__.<>t__builder.Start<OpponentHandArea.<InitHandCardNum>d__13>(ref <InitHandCardNum>d__);
			return <InitHandCardNum>d__.<>t__builder.Task;
		}

		// Token: 0x060360C9 RID: 221385 RVA: 0x00CCA8F8 File Offset: 0x00CC8AF8
		protected UniTask PlayStartTimeDrawCardTween(UUIItem fromItem)
		{
			OpponentHandArea.<PlayStartTimeDrawCardTween>d__14 <PlayStartTimeDrawCardTween>d__;
			<PlayStartTimeDrawCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartTimeDrawCardTween>d__.<>4__this = this;
			<PlayStartTimeDrawCardTween>d__.fromItem = fromItem;
			<PlayStartTimeDrawCardTween>d__.<>1__state = -1;
			<PlayStartTimeDrawCardTween>d__.<>t__builder.Start<OpponentHandArea.<PlayStartTimeDrawCardTween>d__14>(ref <PlayStartTimeDrawCardTween>d__);
			return <PlayStartTimeDrawCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360CA RID: 221386 RVA: 0x00CCA944 File Offset: 0x00CC8B44
		protected UniTask PlayEndTimeDiscardTween(UUIItem toItem)
		{
			OpponentHandArea.<PlayEndTimeDiscardTween>d__15 <PlayEndTimeDiscardTween>d__;
			<PlayEndTimeDiscardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEndTimeDiscardTween>d__.<>4__this = this;
			<PlayEndTimeDiscardTween>d__.toItem = toItem;
			<PlayEndTimeDiscardTween>d__.<>1__state = -1;
			<PlayEndTimeDiscardTween>d__.<>t__builder.Start<OpponentHandArea.<PlayEndTimeDiscardTween>d__15>(ref <PlayEndTimeDiscardTween>d__);
			return <PlayEndTimeDiscardTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360CB RID: 221387 RVA: 0x00CCA990 File Offset: 0x00CC8B90
		protected UniTask PlayBackToRecycleTween(UUIItem toItem, int count)
		{
			OpponentHandArea.<PlayBackToRecycleTween>d__16 <PlayBackToRecycleTween>d__;
			<PlayBackToRecycleTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBackToRecycleTween>d__.<>4__this = this;
			<PlayBackToRecycleTween>d__.toItem = toItem;
			<PlayBackToRecycleTween>d__.count = count;
			<PlayBackToRecycleTween>d__.<>1__state = -1;
			<PlayBackToRecycleTween>d__.<>t__builder.Start<OpponentHandArea.<PlayBackToRecycleTween>d__16>(ref <PlayBackToRecycleTween>d__);
			return <PlayBackToRecycleTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360CC RID: 221388 RVA: 0x00CCA9E4 File Offset: 0x00CC8BE4
		protected UniTask PlayDiscardCardTween(UUIItem toItem, int count)
		{
			OpponentHandArea.<PlayDiscardCardTween>d__17 <PlayDiscardCardTween>d__;
			<PlayDiscardCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDiscardCardTween>d__.<>4__this = this;
			<PlayDiscardCardTween>d__.toItem = toItem;
			<PlayDiscardCardTween>d__.count = count;
			<PlayDiscardCardTween>d__.<>1__state = -1;
			<PlayDiscardCardTween>d__.<>t__builder.Start<OpponentHandArea.<PlayDiscardCardTween>d__17>(ref <PlayDiscardCardTween>d__);
			return <PlayDiscardCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360CD RID: 221389 RVA: 0x00CCAA38 File Offset: 0x00CC8C38
		protected UniTask PlayAddCardTween(int count)
		{
			OpponentHandArea.<PlayAddCardTween>d__18 <PlayAddCardTween>d__;
			<PlayAddCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAddCardTween>d__.<>4__this = this;
			<PlayAddCardTween>d__.count = count;
			<PlayAddCardTween>d__.<>1__state = -1;
			<PlayAddCardTween>d__.<>t__builder.Start<OpponentHandArea.<PlayAddCardTween>d__18>(ref <PlayAddCardTween>d__);
			return <PlayAddCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360CE RID: 221390 RVA: 0x00CCAA84 File Offset: 0x00CC8C84
		protected UniTask AddCardList(int count)
		{
			OpponentHandArea.<AddCardList>d__19 <AddCardList>d__;
			<AddCardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddCardList>d__.<>4__this = this;
			<AddCardList>d__.count = count;
			<AddCardList>d__.<>1__state = -1;
			<AddCardList>d__.<>t__builder.Start<OpponentHandArea.<AddCardList>d__19>(ref <AddCardList>d__);
			return <AddCardList>d__.<>t__builder.Task;
		}

		// Token: 0x060360CF RID: 221391 RVA: 0x00CCAAD0 File Offset: 0x00CC8CD0
		protected UniTask DestroyCardList(int count)
		{
			OpponentHandArea.<DestroyCardList>d__20 <DestroyCardList>d__;
			<DestroyCardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyCardList>d__.<>4__this = this;
			<DestroyCardList>d__.count = count;
			<DestroyCardList>d__.<>1__state = -1;
			<DestroyCardList>d__.<>t__builder.Start<OpponentHandArea.<DestroyCardList>d__20>(ref <DestroyCardList>d__);
			return <DestroyCardList>d__.<>t__builder.Task;
		}

		// Token: 0x060360D0 RID: 221392 RVA: 0x00CCAB1B File Offset: 0x00CC8D1B
		public void RegisterBattleArea(OpponentArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x060360D1 RID: 221393 RVA: 0x00CCAB24 File Offset: 0x00CC8D24
		public UUIItem GetLayoutItem()
		{
			return this.Layout.RootUIComp;
		}

		// Token: 0x060360D2 RID: 221394 RVA: 0x00CCAB38 File Offset: 0x00CC8D38
		public UniTask RefreshHandCardNum(int handCardNum)
		{
			OpponentHandArea.<RefreshHandCardNum>d__23 <RefreshHandCardNum>d__;
			<RefreshHandCardNum>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshHandCardNum>d__.<>4__this = this;
			<RefreshHandCardNum>d__.handCardNum = handCardNum;
			<RefreshHandCardNum>d__.<>1__state = -1;
			<RefreshHandCardNum>d__.<>t__builder.Start<OpponentHandArea.<RefreshHandCardNum>d__23>(ref <RefreshHandCardNum>d__);
			return <RefreshHandCardNum>d__.<>t__builder.Task;
		}

		// Token: 0x060360D3 RID: 221395 RVA: 0x00CCAB84 File Offset: 0x00CC8D84
		public UniTask StartTimeDrawCard(UUIItem fromItem)
		{
			OpponentHandArea.<StartTimeDrawCard>d__24 <StartTimeDrawCard>d__;
			<StartTimeDrawCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartTimeDrawCard>d__.<>4__this = this;
			<StartTimeDrawCard>d__.fromItem = fromItem;
			<StartTimeDrawCard>d__.<>1__state = -1;
			<StartTimeDrawCard>d__.<>t__builder.Start<OpponentHandArea.<StartTimeDrawCard>d__24>(ref <StartTimeDrawCard>d__);
			return <StartTimeDrawCard>d__.<>t__builder.Task;
		}

		// Token: 0x060360D4 RID: 221396 RVA: 0x00CCABD0 File Offset: 0x00CC8DD0
		public UniTask EndTimeDiscardCard(UUIItem toItem)
		{
			OpponentHandArea.<EndTimeDiscardCard>d__25 <EndTimeDiscardCard>d__;
			<EndTimeDiscardCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndTimeDiscardCard>d__.<>4__this = this;
			<EndTimeDiscardCard>d__.toItem = toItem;
			<EndTimeDiscardCard>d__.<>1__state = -1;
			<EndTimeDiscardCard>d__.<>t__builder.Start<OpponentHandArea.<EndTimeDiscardCard>d__25>(ref <EndTimeDiscardCard>d__);
			return <EndTimeDiscardCard>d__.<>t__builder.Task;
		}

		// Token: 0x060360D5 RID: 221397 RVA: 0x00CCAC1C File Offset: 0x00CC8E1C
		public UniTask BackToRecycle(int count)
		{
			OpponentHandArea.<BackToRecycle>d__26 <BackToRecycle>d__;
			<BackToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BackToRecycle>d__.<>4__this = this;
			<BackToRecycle>d__.count = count;
			<BackToRecycle>d__.<>1__state = -1;
			<BackToRecycle>d__.<>t__builder.Start<OpponentHandArea.<BackToRecycle>d__26>(ref <BackToRecycle>d__);
			return <BackToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x060360D6 RID: 221398 RVA: 0x00CCAC68 File Offset: 0x00CC8E68
		public UniTask DiscardCard(int count)
		{
			OpponentHandArea.<DiscardCard>d__27 <DiscardCard>d__;
			<DiscardCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DiscardCard>d__.<>4__this = this;
			<DiscardCard>d__.count = count;
			<DiscardCard>d__.<>1__state = -1;
			<DiscardCard>d__.<>t__builder.Start<OpponentHandArea.<DiscardCard>d__27>(ref <DiscardCard>d__);
			return <DiscardCard>d__.<>t__builder.Task;
		}

		// Token: 0x0401C9E7 RID: 117223
		private const int WAIT_ADD_CARD_TIME = 40;

		// Token: 0x0401C9E8 RID: 117224
		protected float TotalWidth;

		// Token: 0x0401C9E9 RID: 117225
		protected float TotalHeight;

		// Token: 0x0401C9EA RID: 117226
		protected float OriginalSpace;

		// Token: 0x0401C9EB RID: 117227
		protected float GridWidth;

		// Token: 0x0401C9EC RID: 117228
		protected OpponentArea ParentArea;

		// Token: 0x0401C9ED RID: 117229
		protected UUIHorizontalLayout Layout;

		// Token: 0x0401C9EE RID: 117230
		protected List<OpponentHandCardItem> HandCardItemList = new List<OpponentHandCardItem>();

		// Token: 0x0200B4C7 RID: 46279
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036C58 RID: 224344
			public const int Layout = 0;
		}
	}
}
