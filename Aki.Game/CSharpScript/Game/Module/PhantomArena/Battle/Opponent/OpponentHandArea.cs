using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x02004261 RID: 16993
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentHandArea : UiPanelBase
	{
		// Token: 0x0602AFBF RID: 176063 RVA: 0x00C17E98 File Offset: 0x00C16098
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout))
			};
		}

		// Token: 0x0602AFC0 RID: 176064 RVA: 0x00C17EBB File Offset: 0x00C160BB
		protected override void OnStart()
		{
			this.Layout = base.GetHorizontalLayout(0);
			this.OriginalSpace = this.Layout.GetSpacing();
		}

		// Token: 0x0602AFC1 RID: 176065 RVA: 0x00C17EDC File Offset: 0x00C160DC
		private UniTask CreateHandCardItem()
		{
			OpponentHandArea.<CreateHandCardItem>d__11 <CreateHandCardItem>d__;
			<CreateHandCardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateHandCardItem>d__.<>4__this = this;
			<CreateHandCardItem>d__.<>1__state = -1;
			<CreateHandCardItem>d__.<>t__builder.Start<OpponentHandArea.<CreateHandCardItem>d__11>(ref <CreateHandCardItem>d__);
			return <CreateHandCardItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFC2 RID: 176066 RVA: 0x00C17F20 File Offset: 0x00C16120
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

		// Token: 0x0602AFC3 RID: 176067 RVA: 0x00C17FB8 File Offset: 0x00C161B8
		private UniTask InitHandCardNum()
		{
			OpponentHandArea.<InitHandCardNum>d__13 <InitHandCardNum>d__;
			<InitHandCardNum>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHandCardNum>d__.<>4__this = this;
			<InitHandCardNum>d__.<>1__state = -1;
			<InitHandCardNum>d__.<>t__builder.Start<OpponentHandArea.<InitHandCardNum>d__13>(ref <InitHandCardNum>d__);
			return <InitHandCardNum>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFC4 RID: 176068 RVA: 0x00C17FFC File Offset: 0x00C161FC
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

		// Token: 0x0602AFC5 RID: 176069 RVA: 0x00C18048 File Offset: 0x00C16248
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

		// Token: 0x0602AFC6 RID: 176070 RVA: 0x00C18094 File Offset: 0x00C16294
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

		// Token: 0x0602AFC7 RID: 176071 RVA: 0x00C180E8 File Offset: 0x00C162E8
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

		// Token: 0x0602AFC8 RID: 176072 RVA: 0x00C1813C File Offset: 0x00C1633C
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

		// Token: 0x0602AFC9 RID: 176073 RVA: 0x00C18188 File Offset: 0x00C16388
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

		// Token: 0x0602AFCA RID: 176074 RVA: 0x00C181D4 File Offset: 0x00C163D4
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

		// Token: 0x0602AFCB RID: 176075 RVA: 0x00C1821F File Offset: 0x00C1641F
		public void RegisterBattleArea(OpponentArea area)
		{
			this.ParentArea = area;
		}

		// Token: 0x0602AFCC RID: 176076 RVA: 0x00C18228 File Offset: 0x00C16428
		public UUIItem GetLayoutItem()
		{
			return this.Layout.RootUIComp;
		}

		// Token: 0x0602AFCD RID: 176077 RVA: 0x00C1823C File Offset: 0x00C1643C
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

		// Token: 0x0602AFCE RID: 176078 RVA: 0x00C18288 File Offset: 0x00C16488
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

		// Token: 0x0602AFCF RID: 176079 RVA: 0x00C182D4 File Offset: 0x00C164D4
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

		// Token: 0x0602AFD0 RID: 176080 RVA: 0x00C18320 File Offset: 0x00C16520
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

		// Token: 0x0602AFD1 RID: 176081 RVA: 0x00C1836C File Offset: 0x00C1656C
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

		// Token: 0x0401741C RID: 95260
		private const int WAIT_ADD_CARD_TIME = 40;

		// Token: 0x0401741D RID: 95261
		protected float TotalWidth;

		// Token: 0x0401741E RID: 95262
		protected float TotalHeight;

		// Token: 0x0401741F RID: 95263
		protected float OriginalSpace;

		// Token: 0x04017420 RID: 95264
		protected float GridWidth;

		// Token: 0x04017421 RID: 95265
		protected OpponentArea ParentArea;

		// Token: 0x04017422 RID: 95266
		protected UUIHorizontalLayout Layout;

		// Token: 0x04017423 RID: 95267
		protected List<OpponentHandCardItem> HandCardItemList = new List<OpponentHandCardItem>();

		// Token: 0x02009EFF RID: 40703
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040316AB RID: 202411
			public const int Layout = 0;
		}
	}
}
