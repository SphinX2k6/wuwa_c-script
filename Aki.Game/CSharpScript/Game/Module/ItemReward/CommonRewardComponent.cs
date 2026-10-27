using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057F4 RID: 22516
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonRewardComponent
	{
		// Token: 0x06039397 RID: 234391 RVA: 0x00D91A4E File Offset: 0x00D8FC4E
		public CommonRewardComponent(ICommonRewardComponentUiAccessor uiAccessor, ICommonRewardComponentChildType childType, [Nullable(2)] ICommonRewardComponentCallbacks callbacks = null)
		{
			this.UiAccessor = uiAccessor;
			this.ChildType = childType;
			this.Callbacks = callbacks;
		}

		// Token: 0x06039398 RID: 234392 RVA: 0x00D91A6C File Offset: 0x00D8FC6C
		public UniTask InitializeAsync(EUiViewName? viewName = null)
		{
			CommonRewardComponent.<InitializeAsync>d__13 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.viewName = viewName;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<CommonRewardComponent.<InitializeAsync>d__13>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039399 RID: 234393 RVA: 0x00D91AB7 File Offset: 0x00D8FCB7
		public void AddEventListener()
		{
			this.EventListenStatus = true;
			EventSystem.Instance.Add<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Add<EUiTabViewName, int?>(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
		}

		// Token: 0x0603939A RID: 234394 RVA: 0x00D91AF8 File Offset: 0x00D8FCF8
		public void RemoveEventListener()
		{
			if (!this.EventListenStatus)
			{
				return;
			}
			this.EventListenStatus = false;
			EventSystem.Instance.Remove(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Remove(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
		}

		// Token: 0x0603939B RID: 234395 RVA: 0x00D91B4A File Offset: 0x00D8FD4A
		public void Refresh(RewardData<ICommonRewardInfo> rewardData)
		{
			this.RewardData = rewardData;
			if (this.RefreshTitleVisible())
			{
				this.RefreshTitle();
			}
			if (this.RefreshContinueTextVisible())
			{
				this.RefreshContinueText();
			}
			if (this.RefreshItemListVisible())
			{
				this.RefreshItemList();
			}
			this.RefreshButton(rewardData);
		}

		// Token: 0x0603939C RID: 234396 RVA: 0x00D91B84 File Offset: 0x00D8FD84
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<ICommonRewardInfo> GetRewardData()
		{
			return this.RewardData;
		}

		// Token: 0x0603939D RID: 234397 RVA: 0x00D91B8C File Offset: 0x00D8FD8C
		[NullableContext(2)]
		public ICommonRewardInfo GetRewardInfo()
		{
			RewardData<ICommonRewardInfo> rewardData = this.RewardData;
			if (rewardData == null)
			{
				return null;
			}
			return rewardData.GetRewardInfo();
		}

		// Token: 0x0603939E RID: 234398 RVA: 0x00D91BA0 File Offset: 0x00D8FDA0
		public bool HasButtons()
		{
			RewardData<ICommonRewardInfo> rewardData = this.RewardData;
			ICommonRewardInfo commonRewardInfo = (rewardData != null) ? rewardData.GetRewardInfo() : null;
			return commonRewardInfo != null && commonRewardInfo.LeftBtnTextId != null && commonRewardInfo != null && commonRewardInfo.RightBtnTextId != null;
		}

		// Token: 0x0603939F RID: 234399 RVA: 0x00D91BDC File Offset: 0x00D8FDDC
		public void HandleCloseCallback()
		{
			RewardData<ICommonRewardInfo> rewardData = this.RewardData;
			ICommonRewardInfo commonRewardInfo = (rewardData != null) ? rewardData.GetRewardInfo() : null;
			Action action = (commonRewardInfo != null) ? commonRewardInfo.OnCloseCallback : null;
			if (action != null)
			{
				action();
			}
		}

		// Token: 0x060393A0 RID: 234400 RVA: 0x00D91C11 File Offset: 0x00D8FE11
		public void Destroy()
		{
			this.RemoveEventListener();
			this.RewardItemLoopList = null;
			this.RewardItemList = null;
			this.LeftButton = null;
			this.RightButton = null;
			this.RewardData = null;
			this.ViewName = null;
		}

		// Token: 0x060393A1 RID: 234401 RVA: 0x00D91C48 File Offset: 0x00D8FE48
		private bool RefreshTitleVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().Title);
			this.UiAccessor.GetItemForComponent(this.ChildType.TitlePanelItem).SetUIActive(flag);
			return flag;
		}

		// Token: 0x060393A2 RID: 234402 RVA: 0x00D91C8C File Offset: 0x00D8FE8C
		private void RefreshTitle()
		{
			string title = this.RewardData.GetRewardInfo().Title;
			if (StringUtils.IsEmpty(title))
			{
				return;
			}
			UUIText textForComponent = this.UiAccessor.GetTextForComponent(this.ChildType.TitleText);
			LguiUtil.Instance.SetLocalTextNew(textForComponent, title, Array.Empty<object>());
		}

		// Token: 0x060393A3 RID: 234403 RVA: 0x00D91CDC File Offset: 0x00D8FEDC
		private bool RefreshContinueTextVisible()
		{
			ICommonRewardInfo rewardInfo = this.RewardData.GetRewardInfo();
			bool flag = !StringUtils.IsEmpty(rewardInfo.ContinueText);
			flag = (flag && rewardInfo.LeftBtnTextId == null && rewardInfo.RightBtnTextId == null);
			this.UiAccessor.GetItemForComponent(this.ChildType.ContinueText).SetUIActive(flag);
			return flag;
		}

		// Token: 0x060393A4 RID: 234404 RVA: 0x00D91D3C File Offset: 0x00D8FF3C
		private void RefreshContinueText()
		{
			string continueText = this.RewardData.GetRewardInfo().ContinueText;
			if (StringUtils.IsEmpty(continueText))
			{
				return;
			}
			UUIText textForComponent = this.UiAccessor.GetTextForComponent(this.ChildType.ContinueText);
			LguiUtil.Instance.SetLocalTextNew(textForComponent, continueText, Array.Empty<object>());
		}

		// Token: 0x060393A5 RID: 234405 RVA: 0x00D91D8C File Offset: 0x00D8FF8C
		private bool RefreshItemListVisible()
		{
			bool isItemVisible = this.RewardData.GetRewardInfo().IsItemVisible;
			List<RewardItemData> itemList = this.RewardData.GetItemList();
			bool flag = isItemVisible && itemList != null && itemList != null && itemList.Count > 0;
			if (this.RewardItemList.GetActive() != flag)
			{
				this.RewardItemList.SetActive(flag);
			}
			return flag;
		}

		// Token: 0x060393A6 RID: 234406 RVA: 0x00D91DE8 File Offset: 0x00D8FFE8
		private int CalcMaxCountPerRow()
		{
			float x = this.UiAccessor.GetGridLayoutForComponent(this.ChildType.ListContentItem).GetCellSize().X;
			return (int)Math.Floor((double)(this.UiAccessor.GetGridLayoutForComponent(this.ChildType.ListContentItem).RootUIComp.Get().GetWidth() / x)) * 2;
		}

		// Token: 0x060393A7 RID: 234407 RVA: 0x00D91E4C File Offset: 0x00D9004C
		private void RefreshItemList()
		{
			if (this.RewardData == null || this.RewardItemList == null || this.RewardItemLoopList == null)
			{
				return;
			}
			if (this.RewardData.GetItemList().Count < this.CalcMaxCountPerRow())
			{
				this.RewardItemList.Show(null);
				this.RewardItemLoopList.Hide(null);
				this.RewardItemList.Refresh(this.RewardData.GetItemList(), this.RewardData.GetRewardInfo().TipsCanSkip.GetValueOrDefault(true));
				return;
			}
			this.RewardItemList.Hide(null);
			this.RewardItemLoopList.Show(null);
			this.RewardItemLoopList.Refresh(this.RewardData.GetItemList(), this.RewardData.GetRewardInfo().TipsCanSkip.GetValueOrDefault(true));
		}

		// Token: 0x060393A8 RID: 234408 RVA: 0x00D91F1C File Offset: 0x00D9011C
		private void RefreshButton(RewardData<ICommonRewardInfo> rewardData)
		{
			ICommonRewardInfo rewardInfo = rewardData.GetRewardInfo();
			if (!string.IsNullOrEmpty((rewardInfo != null) ? rewardInfo.LeftBtnTextId : null))
			{
				ButtonItem leftButton = this.LeftButton;
				if (leftButton != null)
				{
					leftButton.SetShowText(rewardInfo.LeftBtnTextId);
				}
				ButtonItem leftButton2 = this.LeftButton;
				if (leftButton2 != null)
				{
					leftButton2.SetUiActive(true);
				}
			}
			else
			{
				ButtonItem leftButton3 = this.LeftButton;
				if (leftButton3 != null)
				{
					leftButton3.SetUiActive(false);
				}
			}
			if (!string.IsNullOrEmpty((rewardInfo != null) ? rewardInfo.RightBtnTextId : null))
			{
				ButtonItem rightButton = this.RightButton;
				if (rightButton != null)
				{
					rightButton.SetShowText(rewardInfo.RightBtnTextId);
				}
				ButtonItem rightButton2 = this.RightButton;
				if (rightButton2 != null)
				{
					rightButton2.SetUiActive(true);
				}
			}
			else
			{
				ButtonItem rightButton3 = this.RightButton;
				if (rightButton3 != null)
				{
					rightButton3.SetUiActive(false);
				}
			}
			if (rewardInfo != null && rewardInfo.DisableMaskClose.GetValueOrDefault())
			{
				UUIButtonComponent maskButton = this.MaskButton;
				if (maskButton == null)
				{
					return;
				}
				maskButton.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				UUIButtonComponent maskButton2 = this.MaskButton;
				if (maskButton2 == null)
				{
					return;
				}
				maskButton2.RootUIComp.Get().SetUIActive(true);
				return;
			}
		}

		// Token: 0x060393A9 RID: 234409 RVA: 0x00D92020 File Offset: 0x00D90220
		private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
		{
			if (this.RefreshItemListVisible())
			{
				this.RefreshItemList();
			}
		}

		// Token: 0x060393AA RID: 234410 RVA: 0x00D92030 File Offset: 0x00D90230
		public void OnRefreshRewardView(IRewardDataInterface rewardData)
		{
			RewardData<ICommonRewardInfo> rewardData2 = rewardData as RewardData<ICommonRewardInfo>;
			if (rewardData2 == null)
			{
				return;
			}
			ICommonRewardInfo rewardInfo = rewardData2.GetRewardInfo();
			if (rewardInfo.Type != ERewardInfoType.Common)
			{
				return;
			}
			if (this.ViewName != null && rewardInfo.ViewName != this.ViewName)
			{
				return;
			}
			if (this.Callbacks != null)
			{
				this.Callbacks.OnRefreshView();
			}
			this.Refresh(rewardData2);
		}

		// Token: 0x060393AB RID: 234411 RVA: 0x00D920AA File Offset: 0x00D902AA
		private void OnChangeChildView(EUiTabViewName eUiTabViewName, int? o)
		{
			this.OnClickMaskButton();
		}

		// Token: 0x060393AC RID: 234412 RVA: 0x00D920B4 File Offset: 0x00D902B4
		public void OnClickMaskButton()
		{
			RewardData<ICommonRewardInfo> rewardData = this.RewardData;
			ICommonRewardInfo commonRewardInfo = (rewardData != null) ? rewardData.GetRewardInfo() : null;
			if (commonRewardInfo != null && commonRewardInfo.DisableMaskClose.GetValueOrDefault())
			{
				return;
			}
			if (this.HasButtons())
			{
				return;
			}
			if (this.Callbacks != null)
			{
				this.Callbacks.OnCloseView();
			}
		}

		// Token: 0x060393AD RID: 234413 RVA: 0x00D92106 File Offset: 0x00D90306
		private void OnClickLeftButton(int _)
		{
			RewardData<ICommonRewardInfo> rewardData = this.RewardData;
			ICommonRewardInfo commonRewardInfo = (rewardData != null) ? rewardData.GetRewardInfo() : null;
			if (commonRewardInfo != null)
			{
				Action leftAction = commonRewardInfo.LeftAction;
				if (leftAction != null)
				{
					leftAction();
				}
			}
			if (this.Callbacks != null)
			{
				this.Callbacks.OnCloseView();
			}
		}

		// Token: 0x060393AE RID: 234414 RVA: 0x00D92143 File Offset: 0x00D90343
		private void OnClickRightButton(int _)
		{
			RewardData<ICommonRewardInfo> rewardData = this.RewardData;
			ICommonRewardInfo commonRewardInfo = (rewardData != null) ? rewardData.GetRewardInfo() : null;
			if (commonRewardInfo != null)
			{
				Action rightAction = commonRewardInfo.RightAction;
				if (rightAction != null)
				{
					rightAction();
				}
			}
			if (this.Callbacks != null)
			{
				this.Callbacks.OnCloseView();
			}
		}

		// Token: 0x0401DF07 RID: 122631
		private const int MAXROWCNT = 2;

		// Token: 0x0401DF08 RID: 122632
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<ICommonRewardInfo> RewardData;

		// Token: 0x0401DF09 RID: 122633
		[Nullable(2)]
		private RewardItemList RewardItemList;

		// Token: 0x0401DF0A RID: 122634
		[Nullable(2)]
		private ButtonItem LeftButton;

		// Token: 0x0401DF0B RID: 122635
		[Nullable(2)]
		private ButtonItem RightButton;

		// Token: 0x0401DF0C RID: 122636
		[Nullable(2)]
		private UUIButtonComponent MaskButton;

		// Token: 0x0401DF0D RID: 122637
		[Nullable(2)]
		private RewardItemLoopList RewardItemLoopList;

		// Token: 0x0401DF0E RID: 122638
		private readonly ICommonRewardComponentUiAccessor UiAccessor;

		// Token: 0x0401DF0F RID: 122639
		private readonly ICommonRewardComponentChildType ChildType;

		// Token: 0x0401DF10 RID: 122640
		private readonly ICommonRewardComponentCallbacks Callbacks;

		// Token: 0x0401DF11 RID: 122641
		private EUiViewName? ViewName;

		// Token: 0x0401DF12 RID: 122642
		private bool EventListenStatus;
	}
}
