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
	// Token: 0x02004DFA RID: 19962
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueInfoView : UiViewBase
	{
		// Token: 0x0603382B RID: 210987 RVA: 0x00C094CE File Offset: 0x00C076CE
		[NullableContext(1)]
		public RogueInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603382C RID: 210988 RVA: 0x00C094D8 File Offset: 0x00C076D8
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

		// Token: 0x0603382D RID: 210989 RVA: 0x00C09713 File Offset: 0x00C07913
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<RogueGainEntry, int>(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(this.OnRoguelikeDataUpdate));
		}

		// Token: 0x0603382E RID: 210990 RVA: 0x00C0974D File Offset: 0x00C0794D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<RogueGainEntry, int>(EEventName.RoguelikeInfoSelectedToken, new Action<RogueGainEntry, int>(this.OnSelectedToken));
			EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(this.OnRoguelikeDataUpdate));
		}

		// Token: 0x0603382F RID: 210991 RVA: 0x00C09788 File Offset: 0x00C07988
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

		// Token: 0x06033830 RID: 210992 RVA: 0x00C097EF File Offset: 0x00C079EF
		[NullableContext(1)]
		private void OnSelectedToken(RogueGainEntry token, int index)
		{
			this.TokenDetailPage.OnSelected(token, index);
		}

		// Token: 0x06033831 RID: 210993 RVA: 0x00C097FE File Offset: 0x00C079FE
		private void OnToggleOverview(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.ChangePage(0);
		}

		// Token: 0x06033832 RID: 210994 RVA: 0x00C0980C File Offset: 0x00C07A0C
		private void OnToggleToken(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.ChangePage(1);
		}

		// Token: 0x06033833 RID: 210995 RVA: 0x00C0981A File Offset: 0x00C07A1A
		private void OnToggleSpecial(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			this.ChangePage(2);
		}

		// Token: 0x06033834 RID: 210996 RVA: 0x00C09828 File Offset: 0x00C07A28
		protected override UniTask OnBeforeStartAsync()
		{
			RogueInfoView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueInfoView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033835 RID: 210997 RVA: 0x00C0986C File Offset: 0x00C07A6C
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

		// Token: 0x06033836 RID: 210998 RVA: 0x00C0990A File Offset: 0x00C07B0A
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

		// Token: 0x06033837 RID: 210999 RVA: 0x00C0991C File Offset: 0x00C07B1C
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

		// Token: 0x06033838 RID: 211000 RVA: 0x00C09AF4 File Offset: 0x00C07CF4
		private void RefreshViewModel()
		{
			RogueInfoViewModel rogueInfoViewModel = this.OpenParam as RogueInfoViewModel;
			if (rogueInfoViewModel == null)
			{
				return;
			}
			this.Vm = rogueInfoViewModel;
		}

		// Token: 0x0401B550 RID: 111952
		public TopPanel TopPanel;

		// Token: 0x0401B551 RID: 111953
		public ElementPanel ElementPanel;

		// Token: 0x0401B552 RID: 111954
		public RogueInfoViewTokenDetail TokenDetailPage;

		// Token: 0x0401B553 RID: 111955
		public RogueInfoOverview OverviewPage;

		// Token: 0x0401B554 RID: 111956
		private RogueInfoSpecialView SpecialPage;

		// Token: 0x0401B555 RID: 111957
		[Nullable(1)]
		private RogueInfoViewModel Vm;

		// Token: 0x0401B556 RID: 111958
		private int? CurSelectPageType;

		// Token: 0x0200AF87 RID: 44935
		[NullableContext(0)]
		private class ERogueInfoViewDefine
		{
			// Token: 0x040354B5 RID: 218293
			public const int TitleItem = 0;

			// Token: 0x040354B6 RID: 218294
			public const int ItemContentItem = 1;

			// Token: 0x040354B7 RID: 218295
			public const int ElementInfoItem = 2;

			// Token: 0x040354B8 RID: 218296
			public const int TabItem = 3;

			// Token: 0x040354B9 RID: 218297
			public const int ToggleOverview = 4;

			// Token: 0x040354BA RID: 218298
			public const int ToggleToken = 5;

			// Token: 0x040354BB RID: 218299
			public const int TokenItem = 6;

			// Token: 0x040354BC RID: 218300
			public const int OverviewItem = 7;

			// Token: 0x040354BD RID: 218301
			public const int EmptyItem = 8;

			// Token: 0x040354BE RID: 218302
			public const int ToggleSpecial = 9;

			// Token: 0x040354BF RID: 218303
			public const int SpecialItem = 10;

			// Token: 0x040354C0 RID: 218304
			public const int EmptyText = 11;
		}
	}
}
