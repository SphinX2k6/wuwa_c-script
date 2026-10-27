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
	// Token: 0x02004B26 RID: 19238
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankViewV2 : UiViewBase
	{
		// Token: 0x06031D38 RID: 204088 RVA: 0x00B911B5 File Offset: 0x00B8F3B5
		public TowerDefenseRankViewV2(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031D39 RID: 204089 RVA: 0x00B911C0 File Offset: 0x00B8F3C0
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

		// Token: 0x06031D3A RID: 204090 RVA: 0x00B912EC File Offset: 0x00B8F4EC
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRankViewV2.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRankViewV2.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031D3B RID: 204091 RVA: 0x00B91330 File Offset: 0x00B8F530
		private UniTask InitCaption()
		{
			TowerDefenseRankViewV2.<InitCaption>d__11 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitCaption>d__11>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06031D3C RID: 204092 RVA: 0x00B91374 File Offset: 0x00B8F574
		private UniTask InitAnonymousToggle()
		{
			TowerDefenseRankViewV2.<InitAnonymousToggle>d__12 <InitAnonymousToggle>d__;
			<InitAnonymousToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAnonymousToggle>d__.<>4__this = this;
			<InitAnonymousToggle>d__.<>1__state = -1;
			<InitAnonymousToggle>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitAnonymousToggle>d__12>(ref <InitAnonymousToggle>d__);
			return <InitAnonymousToggle>d__.<>t__builder.Task;
		}

		// Token: 0x06031D3D RID: 204093 RVA: 0x00B913B8 File Offset: 0x00B8F5B8
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

		// Token: 0x06031D3E RID: 204094 RVA: 0x00B913EC File Offset: 0x00B8F5EC
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031D3F RID: 204095 RVA: 0x00B913F8 File Offset: 0x00B8F5F8
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

		// Token: 0x06031D40 RID: 204096 RVA: 0x00B91440 File Offset: 0x00B8F640
		private UniTask InitTabLayout()
		{
			TowerDefenseRankViewV2.<InitTabLayout>d__16 <InitTabLayout>d__;
			<InitTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabLayout>d__.<>4__this = this;
			<InitTabLayout>d__.<>1__state = -1;
			<InitTabLayout>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitTabLayout>d__16>(ref <InitTabLayout>d__);
			return <InitTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06031D41 RID: 204097 RVA: 0x00B91483 File Offset: 0x00B8F683
		private void InitRankScroll()
		{
			this.RankScroll = new LoopScrollView<TowerDefenseRankItemV2, TowerDefenseRankItemData>(base.GetLoopScrollViewComponent(1), base.GetItem(2).GetOwner() as AUIBaseActor, new Func<TowerDefenseRankItemV2>(this.InitRankItem), false);
		}

		// Token: 0x06031D42 RID: 204098 RVA: 0x00B914B8 File Offset: 0x00B8F6B8
		private UniTask InitOwnRankItem()
		{
			TowerDefenseRankViewV2.<InitOwnRankItem>d__18 <InitOwnRankItem>d__;
			<InitOwnRankItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnRankItem>d__.<>4__this = this;
			<InitOwnRankItem>d__.<>1__state = -1;
			<InitOwnRankItem>d__.<>t__builder.Start<TowerDefenseRankViewV2.<InitOwnRankItem>d__18>(ref <InitOwnRankItem>d__);
			return <InitOwnRankItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031D43 RID: 204099 RVA: 0x00B914FB File Offset: 0x00B8F6FB
		private TowerDefenseRankTabItemV2 InitTabItem()
		{
			return new TowerDefenseRankTabItemV2
			{
				OpenParam = this.Vm
			};
		}

		// Token: 0x06031D44 RID: 204100 RVA: 0x00B9150E File Offset: 0x00B8F70E
		private TowerDefenseRankItemV2 InitRankItem()
		{
			return new TowerDefenseRankItemV2
			{
				OpenParam = this.Vm
			};
		}

		// Token: 0x06031D45 RID: 204101 RVA: 0x00B91524 File Offset: 0x00B8F724
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

		// Token: 0x06031D46 RID: 204102 RVA: 0x00B91577 File Offset: 0x00B8F777
		public void ResetLastTabItemSelected(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenseRankTabItemV2 layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex((int)tabType);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.SetToggleState(false, false);
		}

		// Token: 0x06031D47 RID: 204103 RVA: 0x00B91594 File Offset: 0x00B8F794
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

		// Token: 0x06031D48 RID: 204104 RVA: 0x00B91638 File Offset: 0x00B8F838
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

		// Token: 0x06031D49 RID: 204105 RVA: 0x00B9166C File Offset: 0x00B8F86C
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

		// Token: 0x06031D4A RID: 204106 RVA: 0x00B916CB File Offset: 0x00B8F8CB
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x0401A971 RID: 108913
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401A972 RID: 108914
		[Nullable(2)]
		private PopupCaptionToggleItem AnonymousToggle;

		// Token: 0x0401A973 RID: 108915
		private GenericLayout<TowerDefenseRankTabItemV2, TowerDefenceDefine.ETabType> TabLayout;

		// Token: 0x0401A974 RID: 108916
		private LoopScrollView<TowerDefenseRankItemV2, TowerDefenseRankItemData> RankScroll;

		// Token: 0x0401A975 RID: 108917
		private TowerDefenseRankItemV2 OwnRankItem;

		// Token: 0x0401A976 RID: 108918
		private TowerDefenseRankViewModelV2 Vm;

		// Token: 0x0401A977 RID: 108919
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401A978 RID: 108920
		private bool HasPlayedListAnim;

		// Token: 0x0200ACAE RID: 44206
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04034770 RID: 214896
			public const int CaptionItem = 0;

			// Token: 0x04034771 RID: 214897
			public const int LoopScrollView = 1;

			// Token: 0x04034772 RID: 214898
			public const int RankItem = 2;

			// Token: 0x04034773 RID: 214899
			public const int EmptyItem = 3;

			// Token: 0x04034774 RID: 214900
			public const int OwnerItem = 4;

			// Token: 0x04034775 RID: 214901
			public const int TabLayout = 5;

			// Token: 0x04034776 RID: 214902
			public const int TabItem = 6;
		}
	}
}
