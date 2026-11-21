using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC3 RID: 15811
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueInfoView : UiViewBase
	{
		// Token: 0x06028696 RID: 165526 RVA: 0x00B529DE File Offset: 0x00B50BDE
		[NullableContext(1)]
		public RogueInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028697 RID: 165527 RVA: 0x00B529E8 File Offset: 0x00B50BE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnToggleOverview));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggleToken));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnToggleSpecial));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028698 RID: 165528 RVA: 0x00B52C23 File Offset: 0x00B50E23
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RogueGainEntry, int>(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnRoguelikeDataUpdate));
		}

		// Token: 0x06028699 RID: 165529 RVA: 0x00B52C5D File Offset: 0x00B50E5D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<RogueGainEntry, int>(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnRoguelikeDataUpdate));
		}

		// Token: 0x0602869A RID: 165530 RVA: 0x00B52C98 File Offset: 0x00B50E98
		private void OnRoguelikeDataUpdate()
		{
			RogueInfoOverview overviewPage = this.OverviewPage;
			if (overviewPage != null)
			{
				overviewPage.SetViewModel(this.Vm);
			}
			RogueInfoViewTokenDetail tokenDetailPage = this.TokenDetailPage;
			if (tokenDetailPage != null)
			{
				tokenDetailPage.SetViewModel(this.Vm);
			}
			RogueInfoViewTokenDetail tokenDetailPage2 = this.TokenDetailPage;
			if (tokenDetailPage2 != null)
			{
				tokenDetailPage2.RefreshSelectedDetail();
			}
			RogueInfoSpecialView specialPage = this.SpecialPage;
			if (specialPage == null)
			{
				return;
			}
			specialPage.Refresh(this.Vm.SpecialEntryList);
		}

		// Token: 0x0602869B RID: 165531 RVA: 0x00B52CFF File Offset: 0x00B50EFF
		[NullableContext(1)]
		private void OnSelectedToken(RogueGainEntry token, int index)
		{
			this.TokenDetailPage.OnSelected(token, index);
		}

		// Token: 0x0602869C RID: 165532 RVA: 0x00B52D0E File Offset: 0x00B50F0E
		private void OnToggleOverview(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.ChangePage(0);
		}

		// Token: 0x0602869D RID: 165533 RVA: 0x00B52D1C File Offset: 0x00B50F1C
		private void OnToggleToken(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.ChangePage(1);
		}

		// Token: 0x0602869E RID: 165534 RVA: 0x00B52D2A File Offset: 0x00B50F2A
		private void OnToggleSpecial(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.ChangePage(2);
		}

		// Token: 0x0602869F RID: 165535 RVA: 0x00B52D38 File Offset: 0x00B50F38
		protected override UniTask OnBeforeStartAsync()
		{
			RogueInfoView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueInfoView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060286A0 RID: 165536 RVA: 0x00B52D7C File Offset: 0x00B50F7C
		protected override void OnStart()
		{
			this.TopPanel.CloseCallback = delegate()
			{
				base.CloseMe(null);
			};
			this.ElementPanel.Refresh(this.Vm.GetElementInfoList());
			this.OverviewPage.SetViewModel(this.Vm);
			this.TokenDetailPage.SetViewModel(this.Vm);
			this.SpecialPage.Refresh(this.Vm.SpecialEntryList);
			ERogueInfoViewPage defaultPage = this.Vm.DefaultPage;
			int toggleIdByPage = this.GetToggleIdByPage(defaultPage);
			base.GetExtendToggle(toggleIdByPage).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.ChangePage((int)defaultPage);
		}

		// Token: 0x060286A1 RID: 165537 RVA: 0x00B52E1A File Offset: 0x00B5101A
		private int GetToggleIdByPage(ERogueInfoViewPage page)
		{
			if (page == ERogueInfoViewPage.Token)
			{
				return 5;
			}
			if (page != ERogueInfoViewPage.Special)
			{
				return 4;
			}
			return 9;
		}

		// Token: 0x060286A2 RID: 165538 RVA: 0x00B52E2C File Offset: 0x00B5102C
		public void ChangePage(int page)
		{
			if (this.CurSelectPageType != null)
			{
				int? curSelectPageType = this.CurSelectPageType;
				int num = 0;
				if (curSelectPageType.GetValueOrDefault() == num & curSelectPageType != null)
				{
					this.OverviewPage.UiViewSequence.PlaySequence("Close", false, null);
				}
				else if (this.CurSelectPageType.GetValueOrDefault() == 1)
				{
					this.TokenDetailPage.UiViewSequence.PlaySequence("Close", false, null);
				}
				else
				{
					this.SpecialPage.UiViewSequence.PlaySequence("Close", false, null);
				}
			}
			this.TokenDetailPage.SetActive(page == 1);
			this.OverviewPage.SetActive(page == 0);
			this.SpecialPage.SetActive(page == 2);
			this.TokenDetailPage.Update(this.Vm.BuffEntryList);
			if (page == 0)
			{
				base.GetItem(8).SetUIActive(false);
				this.OverviewPage.UiViewSequence.PlaySequence("Start", false, null);
				return;
			}
			if (page == 1)
			{
				this.TokenDetailPage.UiViewSequence.PlaySequence("Start", false, null);
				bool flag = this.Vm.IsBuffEntryEmpty();
				base.GetItem(8).SetUIActive(flag);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "RogueNoTokenTips", Array.Empty<object>());
				if (!flag)
				{
					this.TokenDetailPage.SelectFirstGrid();
					return;
				}
			}
			else
			{
				this.SpecialPage.UiViewSequence.PlaySequence("Start", false, null);
				base.GetItem(8).SetUIActive(this.Vm.IsSpecialEntryEmpty());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "RogueNoSpecialTips", Array.Empty<object>());
			}
		}

		// Token: 0x060286A3 RID: 165539 RVA: 0x00B53004 File Offset: 0x00B51204
		private void RefreshViewModel()
		{
			RogueInfoViewModel rogueInfoViewModel = this.OpenParam as RogueInfoViewModel;
			if (rogueInfoViewModel == null)
			{
				return;
			}
			this.Vm = rogueInfoViewModel;
		}

		// Token: 0x04015F23 RID: 89891
		public TopPanel TopPanel;

		// Token: 0x04015F24 RID: 89892
		public ElementPanel ElementPanel;

		// Token: 0x04015F25 RID: 89893
		public RogueInfoViewTokenDetail TokenDetailPage;

		// Token: 0x04015F26 RID: 89894
		public RogueInfoOverview OverviewPage;

		// Token: 0x04015F27 RID: 89895
		private RogueInfoSpecialView SpecialPage;

		// Token: 0x04015F28 RID: 89896
		[Nullable(1)]
		private RogueInfoViewModel Vm;

		// Token: 0x04015F29 RID: 89897
		private int? CurSelectPageType;

		// Token: 0x020099BC RID: 39356
		[NullableContext(0)]
		private class ERogueInfoViewDefine
		{
			// Token: 0x0402FEE8 RID: 196328
			public const int TitleItem = 0;

			// Token: 0x0402FEE9 RID: 196329
			public const int ItemContentItem = 1;

			// Token: 0x0402FEEA RID: 196330
			public const int ElementInfoItem = 2;

			// Token: 0x0402FEEB RID: 196331
			public const int TabItem = 3;

			// Token: 0x0402FEEC RID: 196332
			public const int ToggleOverview = 4;

			// Token: 0x0402FEED RID: 196333
			public const int ToggleToken = 5;

			// Token: 0x0402FEEE RID: 196334
			public const int TokenItem = 6;

			// Token: 0x0402FEEF RID: 196335
			public const int OverviewItem = 7;

			// Token: 0x0402FEF0 RID: 196336
			public const int EmptyItem = 8;

			// Token: 0x0402FEF1 RID: 196337
			public const int ToggleSpecial = 9;

			// Token: 0x0402FEF2 RID: 196338
			public const int SpecialItem = 10;

			// Token: 0x0402FEF3 RID: 196339
			public const int EmptyText = 11;
		}
	}
}
