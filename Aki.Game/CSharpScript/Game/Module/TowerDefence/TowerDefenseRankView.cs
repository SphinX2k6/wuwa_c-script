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
	// Token: 0x02003ACB RID: 15051
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRankView : UiViewBase
	{
		// Token: 0x06026AAD RID: 158381 RVA: 0x00AD4B4A File Offset: 0x00AD2D4A
		public TowerDefenseRankView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026AAE RID: 158382 RVA: 0x00AD4B54 File Offset: 0x00AD2D54
		protected unsafe override void OnRegisterComponent()
		{
			this.Vm = (this.OpenParam as TowerDefenseRankViewModel);
			this.Vm.RegisterView(this);
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.Vm.ToggleAnonymousClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026AAF RID: 158383 RVA: 0x00AD4CC4 File Offset: 0x00AD2EC4
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRankView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRankView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026AB0 RID: 158384 RVA: 0x00AD4D08 File Offset: 0x00AD2F08
		protected override void OnStart()
		{
			if (TowerDefenseModel.Instance.RankData.IsOwnSingleBestScore(this.Vm.InstanceId))
			{
				RankTabItem layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex(0);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.SetToggleState(true, true);
				return;
			}
			else
			{
				RankTabItem layoutItemByIndex2 = this.TabLayout.GetLayoutItemByIndex(1);
				if (layoutItemByIndex2 == null)
				{
					return;
				}
				layoutItemByIndex2.SetToggleState(true, true);
				return;
			}
		}

		// Token: 0x06026AB1 RID: 158385 RVA: 0x00AD4D64 File Offset: 0x00AD2F64
		private UniTask InitTabLayout()
		{
			TowerDefenseRankView.<InitTabLayout>d__8 <InitTabLayout>d__;
			<InitTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTabLayout>d__.<>4__this = this;
			<InitTabLayout>d__.<>1__state = -1;
			<InitTabLayout>d__.<>t__builder.Start<TowerDefenseRankView.<InitTabLayout>d__8>(ref <InitTabLayout>d__);
			return <InitTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06026AB2 RID: 158386 RVA: 0x00AD4DA7 File Offset: 0x00AD2FA7
		private void InitRankScroll()
		{
			this.RankScroll = new LoopScrollView<TowerDefenseRankItem, TowerDefenseRankItemData>(base.GetLoopScrollViewComponent(2), base.GetItem(3).GetOwner() as AUIBaseActor, new Func<TowerDefenseRankItem>(this.InitRankItem), false);
		}

		// Token: 0x06026AB3 RID: 158387 RVA: 0x00AD4DDC File Offset: 0x00AD2FDC
		private void InitAnonymousToggle()
		{
			EToggleState state = TowerDefenseModel.Instance.RankData.IsOpenAnonymousName ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(5).SetToggleState(state, false, false, false);
		}

		// Token: 0x06026AB4 RID: 158388 RVA: 0x00AD4E10 File Offset: 0x00AD3010
		private UniTask InitOwnRankItem()
		{
			TowerDefenseRankView.<InitOwnRankItem>d__11 <InitOwnRankItem>d__;
			<InitOwnRankItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnRankItem>d__.<>4__this = this;
			<InitOwnRankItem>d__.<>1__state = -1;
			<InitOwnRankItem>d__.<>t__builder.Start<TowerDefenseRankView.<InitOwnRankItem>d__11>(ref <InitOwnRankItem>d__);
			return <InitOwnRankItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026AB5 RID: 158389 RVA: 0x00AD4E53 File Offset: 0x00AD3053
		private RankTabItem InitTabItem()
		{
			return new RankTabItem
			{
				OpenParam = this.Vm
			};
		}

		// Token: 0x06026AB6 RID: 158390 RVA: 0x00AD4E66 File Offset: 0x00AD3066
		private TowerDefenseRankItem InitRankItem()
		{
			return new TowerDefenseRankItem(false)
			{
				OpenParam = this.Vm
			};
		}

		// Token: 0x06026AB7 RID: 158391 RVA: 0x00AD4E7C File Offset: 0x00AD307C
		private UniTask RefreshRankLayout(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenseRankView.<RefreshRankLayout>d__14 <RefreshRankLayout>d__;
			<RefreshRankLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRankLayout>d__.<>4__this = this;
			<RefreshRankLayout>d__.tabType = tabType;
			<RefreshRankLayout>d__.<>1__state = -1;
			<RefreshRankLayout>d__.<>t__builder.Start<TowerDefenseRankView.<RefreshRankLayout>d__14>(ref <RefreshRankLayout>d__);
			return <RefreshRankLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06026AB8 RID: 158392 RVA: 0x00AD4EC8 File Offset: 0x00AD30C8
		private void RefreshAnonymousToggle(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenseRankItemData selfRankDataByTabType = TowerDefenseModel.Instance.RankData.GetSelfRankDataByTabType(tabType);
			base.GetExtendToggle(5).RootUIComp.Get().SetUIActive(selfRankDataByTabType.IsInRank);
		}

		// Token: 0x06026AB9 RID: 158393 RVA: 0x00AD4F08 File Offset: 0x00AD3108
		public void ResetLastTabItemSelected(TowerDefenceDefine.ETabType tabType)
		{
			RankTabItem layoutItemByIndex = this.TabLayout.GetLayoutItemByIndex((int)tabType);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetToggleState(false, false);
			}
		}

		// Token: 0x06026ABA RID: 158394 RVA: 0x00AD4F30 File Offset: 0x00AD3130
		public void RefreshContent(TowerDefenceDefine.ETabType tabType)
		{
			TowerDefenseRankView.<>c__DisplayClass17_0 CS$<>8__locals1 = new TowerDefenseRankView.<>c__DisplayClass17_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.tabType = tabType;
			UiAsyncTask task = new UiAsyncTask("TowerDefenseRankView.RefreshContent", delegate()
			{
				TowerDefenseRankView.<>c__DisplayClass17_0.<<RefreshContent>b__0>d <<RefreshContent>b__0>d;
				<<RefreshContent>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshContent>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshContent>b__0>d.<>1__state = -1;
				<<RefreshContent>b__0>d.<>t__builder.Start<TowerDefenseRankView.<>c__DisplayClass17_0.<<RefreshContent>b__0>d>(ref <<RefreshContent>b__0>d);
				return <<RefreshContent>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
			this.RefreshAnonymousToggle(CS$<>8__locals1.tabType);
		}

		// Token: 0x06026ABB RID: 158395 RVA: 0x00AD4F80 File Offset: 0x00AD3180
		public void RefreshContentShowName()
		{
			int startGridIndex = this.RankScroll.StartGridIndex;
			int endGridIndex = this.RankScroll.EndGridIndex;
			for (int i = startGridIndex; i <= endGridIndex; i++)
			{
				TowerDefenseRankItemData towerDefenseRankItemData = this.RankScroll.TryGetCachedData(i);
				if (towerDefenseRankItemData != null && towerDefenseRankItemData.IsSelfInData)
				{
					TowerDefenseRankItem towerDefenseRankItem = this.RankScroll.UnsafeGetGridProxy(i, false);
					if (towerDefenseRankItem != null)
					{
						towerDefenseRankItem.RefreshPlayerName();
					}
				}
			}
		}

		// Token: 0x040152B9 RID: 86713
		private TowerDefenseRankItem OwnRankItem;

		// Token: 0x040152BA RID: 86714
		private LoopScrollView<TowerDefenseRankItem, TowerDefenseRankItemData> RankScroll;

		// Token: 0x040152BB RID: 86715
		private GenericLayout<RankTabItem, TowerDefenceDefine.ETabType> TabLayout;

		// Token: 0x040152BC RID: 86716
		private TowerDefenseRankViewModel Vm;

		// Token: 0x020096C4 RID: 38596
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402F0FB RID: 192763
			public const int TabLayout = 0;

			// Token: 0x0402F0FC RID: 192764
			public const int TabItem = 1;

			// Token: 0x0402F0FD RID: 192765
			public const int RankScroll = 2;

			// Token: 0x0402F0FE RID: 192766
			public const int RankItem = 3;

			// Token: 0x0402F0FF RID: 192767
			public const int OwnRankItem = 4;

			// Token: 0x0402F100 RID: 192768
			public const int AnonymousToggle = 5;

			// Token: 0x0402F101 RID: 192769
			public const int EmptyItem = 6;
		}
	}
}
