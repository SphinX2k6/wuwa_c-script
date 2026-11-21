using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003ACE RID: 15054
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankViewV2 : UiViewBase
	{
		// Token: 0x06026AC8 RID: 158408 RVA: 0x00AD5219 File Offset: 0x00AD3419
		public TowerDefenseRankViewV2(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026AC9 RID: 158409 RVA: 0x00AD5224 File Offset: 0x00AD3424
		protected unsafe override void OnRegisterComponent()
		{
			this.Vm = (this.OpenParam as TowerDefenseRankViewModelV2);
			this.Vm.RegisterView(this);
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026ACA RID: 158410 RVA: 0x00AD5350 File Offset: 0x00AD3550
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRankViewV2.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRankViewV2.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026ACB RID: 158411 RVA: 0x00AD5394 File Offset: 0x00AD3594
		private UniTask InitCaption()
		{
			TowerDefenseRankViewV2.<InitCaption>d__11 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitCaption>d__11>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06026ACC RID: 158412 RVA: 0x00AD53D8 File Offset: 0x00AD35D8
		private UniTask InitAnonymousToggle()
		{
			TowerDefenseRankViewV2.<InitAnonymousToggle>d__12 <InitAnonymousToggle>d__;
			<InitAnonymousToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAnonymousToggle>d__.<>4__this = this;
			<InitAnonymousToggle>d__.<>1__state = -1;
			<InitAnonymousToggle>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitAnonymousToggle>d__12>(ref <InitAnonymousToggle>d__);
			return <InitAnonymousToggle>d__.<>t__builder.Task;
		}

		// Token: 0x06026ACD RID: 158413 RVA: 0x00AD541C File Offset: 0x00AD361C
		private void InitAnonymousToggleState()
		{
			EToggleState toggleState = TowerDefenseModel.Instance.RankData.IsOpenAnonymousName ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			PopupCaptionToggleItem anonymousToggle = this.AnonymousToggle;
			if (anonymousToggle == null)
			{
				return;
			}
			anonymousToggle.InitToggleState(toggleState);
		}

		// Token: 0x06026ACE RID: 158414 RVA: 0x00AD5450 File Offset: 0x00AD3650
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026ACF RID: 158415 RVA: 0x00AD545C File Offset: 0x00AD365C
		protected override void OnStart()
		{
			bool flag = TowerDefenseModel.Instance.RankData.IsOwnSingleBestRecord(this.Vm.InstanceId);
			TowerDefenseRankTabItemV2 layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex(flag ? 0 : 1);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.SetToggleState(true, true);
		}

		// Token: 0x06026AD0 RID: 158416 RVA: 0x00AD54A4 File Offset: 0x00AD36A4
		private UniTask InitTabLayout()
		{
			TowerDefenseRankViewV2.<InitTabLayout>d__16 <InitTabLayout>d__;
			<InitTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabLayout>d__.<>4__this = this;
			<InitTabLayout>d__.<>1__state = -1;
			<InitTabLayout>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitTabLayout>d__16>(ref <InitTabLayout>d__);
			return <InitTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06026AD1 RID: 158417 RVA: 0x00AD54E7 File Offset: 0x00AD36E7
		private void InitRankScroll()
		{
			this.RankScroll = new LoopScrollView<TowerDefenseRankItemV2, TowerDefenseRankItemData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<TowerDefenseRankItemV2>(this.InitRankItem), false);
		}

		// Token: 0x06026AD2 RID: 158418 RVA: 0x00AD551C File Offset: 0x00AD371C
		private UniTask InitOwnRankItem()
		{
			TowerDefenseRankViewV2.<InitOwnRankItem>d__18 <InitOwnRankItem>d__;
			<InitOwnRankItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnRankItem>d__.<>4__this = this;
			<InitOwnRankItem>d__.<>1__state = -1;
			<InitOwnRankItem>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitOwnRankItem>d__18>(ref <InitOwnRankItem>d__);
			return <InitOwnRankItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026AD3 RID: 158419 RVA: 0x00AD555F File Offset: 0x00AD375F
		private TowerDefenseRankTabItemV2 InitTabItem()
		{
			return new TowerDefenseRankTabItemV2
			{
				OpenParam = this.Vm
			};
		}

		// Token: 0x06026AD4 RID: 158420 RVA: 0x00AD5572 File Offset: 0x00AD3772
		private TowerDefenseRankItemV2 InitRankItem()
		{
			return new TowerDefenseRankItemV2
			{
				OpenParam = this.Vm
			};
		}

		// Token: 0x06026AD5 RID: 158421 RVA: 0x00AD5588 File Offset: 0x00AD3788
		private UniTask RefreshRankLayout(TowerDefenceDefine.ETabType tabType, bool playGridAnim)
		{
			TowerDefenseRankViewV2.<RefreshRankLayout>d__21 <RefreshRankLayout>d__;
			<RefreshRankLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRankLayout>d__.<>4__this = this;
			<RefreshRankLayout>d__.tabType = tabType;
			<RefreshRankLayout>d__.playGridAnim = playGridAnim;
			<RefreshRankLayout>d__.<>1__state = -1;
			<RefreshRankLayout>d__.<>t__builder.Start<TowerDefenseRankViewV2.<RefreshRankLayout>d__21>(ref <RefreshRankLayout>d__);
			return <RefreshRankLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06026AD6 RID: 158422 RVA: 0x00AD55DB File Offset: 0x00AD37DB
		public void ResetLastTabItemSelected(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenseRankTabItemV2 layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex((int)tabType);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.SetToggleState(false, false);
		}

		// Token: 0x06026AD7 RID: 158423 RVA: 0x00AD55F8 File Offset: 0x00AD37F8
		public void RefreshContent(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenseRankViewV2.<>c__DisplayClass23_0 CS$<>8__locals1 = new TowerDefenseRankViewV2.<>c__DisplayClass23_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.tabType = tabType;
			CS$<>8__locals1.isFirst = !this.HasPlayedListAnim;
			this.HasPlayedListAnim = true;
			if (!CS$<>8__locals1.isFirst)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.StopSequenceByKey("Switch", false, false);
				}
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
				}
			}
			UiAsyncTask task = new UiAsyncTask("TowerDefenseRankViewV2.RefreshContent", delegate()
			{
				TowerDefenseRankViewV2.<>c__DisplayClass23_0.<<RefreshContent>b__0>d <<RefreshContent>b__0>d;
				<<RefreshContent>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshContent>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshContent>b__0>d.<>1__state = -1;
				<<RefreshContent>b__0>d.<>t__builder.Start<TowerDefenseRankViewV2.<>c__DisplayClass23_0.<<RefreshContent>b__0>d>(ref <<RefreshContent>b__0>d);
				return <<RefreshContent>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
			this.RefreshAnonymousToggle(CS$<>8__locals1.tabType);
		}

		// Token: 0x06026AD8 RID: 158424 RVA: 0x00AD569C File Offset: 0x00AD389C
		private void RefreshAnonymousToggle(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenseRankItemData selfRankDataByTabType = TowerDefenseModel.Instance.RankData.GetSelfRankDataByTabType(tabType);
			PopupCaptionToggleItem anonymousToggle = this.AnonymousToggle;
			if (anonymousToggle == null)
			{
				return;
			}
			anonymousToggle.SetUiActive(selfRankDataByTabType.IsInRank);
		}

		// Token: 0x06026AD9 RID: 158425 RVA: 0x00AD56D0 File Offset: 0x00AD38D0
		public void RefreshContentShowName()
		{
			this.OwnRankItem.RefreshPlayerName();
			int startGridIndex = this.RankScroll.StartGridIndex;
			int endGridIndex = this.RankScroll.EndGridIndex;
			for (int i = startGridIndex; i <= endGridIndex; i++)
			{
				TowerDefenseRankItemData towerDefenseRankItemData = this.RankScroll.TryGetCachedData(i);
				if (towerDefenseRankItemData != null && towerDefenseRankItemData.IsSelfInData)
				{
					this.RankScroll.RefreshGridProxy(i);
				}
			}
		}

		// Token: 0x06026ADA RID: 158426 RVA: 0x00AD572F File Offset: 0x00AD392F
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x040152C3 RID: 86723
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x040152C4 RID: 86724
		[Nullable(2)]
		private PopupCaptionToggleItem AnonymousToggle;

		// Token: 0x040152C5 RID: 86725
		private GenericLayout<TowerDefenseRankTabItemV2, TowerDefenceDefine.ETabType> TabLayout;

		// Token: 0x040152C6 RID: 86726
		private LoopScrollView<TowerDefenseRankItemV2, TowerDefenseRankItemData> RankScroll;

		// Token: 0x040152C7 RID: 86727
		private TowerDefenseRankItemV2 OwnRankItem;

		// Token: 0x040152C8 RID: 86728
		private TowerDefenseRankViewModelV2 Vm;

		// Token: 0x040152C9 RID: 86729
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x040152CA RID: 86730
		private bool HasPlayedListAnim;

		// Token: 0x020096CE RID: 38606
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402F121 RID: 192801
			public const int CaptionItem = 0;

			// Token: 0x0402F122 RID: 192802
			public const int LoopScrollView = 1;

			// Token: 0x0402F123 RID: 192803
			public const int RankItem = 2;

			// Token: 0x0402F124 RID: 192804
			public const int EmptyItem = 3;

			// Token: 0x0402F125 RID: 192805
			public const int OwnerItem = 4;

			// Token: 0x0402F126 RID: 192806
			public const int TabLayout = 5;

			// Token: 0x0402F127 RID: 192807
			public const int TabItem = 6;
		}
	}
}
