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
	// Token: 0x020047CB RID: 18379
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonRewardComponent
	{
		// Token: 0x0602E2AB RID: 189099 RVA: 0x00CE0897 File Offset: 0x00CDEA97
		public CommonRewardComponent(ICommonRewardComponentUiAccessor uiAccessor, ICommonRewardComponentChildType childType, [Nullable(2)] ICommonRewardComponentCallbacks callbacks = null)
		{
			this.UiAccessor = uiAccessor;
			this.ChildType = childType;
			this.Callbacks = callbacks;
		}

		// Token: 0x0602E2AC RID: 189100 RVA: 0x00CE08B4 File Offset: 0x00CDEAB4
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

		// Token: 0x0602E2AD RID: 189101 RVA: 0x00CE08FF File Offset: 0x00CDEAFF
		public void AddEventListener()
		{
			this.EventListenStatus = true;
			EventSystem.Instance.Add<IReadOnlyList<RewardItemData>>(EEventName.OnRefreshRewardViewItemList, new Action<IReadOnlyList<RewardItemData>>(this.OnRefreshRewardItemList));
			EventSystem.Instance.Add<EUiTabViewName, int?>(EEventName.ChangeChildView, new Action<EUiTabViewName, int?>(this.OnChangeChildView));
		}

		// Token: 0x0602E2AE RID: 189102 RVA: 0x00CE0940 File Offset: 0x00CDEB40
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

		// Token: 0x0602E2AF RID: 189103 RVA: 0x00CE0992 File Offset: 0x00CDEB92
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

		// Token: 0x0602E2B0 RID: 189104 RVA: 0x00CE09CC File Offset: 0x00CDEBCC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public RewardData<ICommonRewardInfo> GetRewardData()
		{
			return this.RewardData;
		}

		// Token: 0x0602E2B1 RID: 189105 RVA: 0x00CE09D4 File Offset: 0x00CDEBD4
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

		// Token: 0x0602E2B2 RID: 189106 RVA: 0x00CE09E8 File Offset: 0x00CDEBE8
		public bool HasButtons()
		{
			RewardData<ICommonRewardInfo> rewardData = this.RewardData;
			ICommonRewardInfo commonRewardInfo = (rewardData != null) ? rewardData.GetRewardInfo() : null;
			return commonRewardInfo != null && commonRewardInfo.LeftBtnTextId != null && commonRewardInfo != null && commonRewardInfo.RightBtnTextId != null;
		}

		// Token: 0x0602E2B3 RID: 189107 RVA: 0x00CE0A24 File Offset: 0x00CDEC24
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

		// Token: 0x0602E2B4 RID: 189108 RVA: 0x00CE0A59 File Offset: 0x00CDEC59
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

		// Token: 0x0602E2B5 RID: 189109 RVA: 0x00CE0A90 File Offset: 0x00CDEC90
		private bool RefreshTitleVisible()
		{
			bool flag = !StringUtils.IsEmpty(this.RewardData.GetRewardInfo().Title);
			this.UiAccessor.GetItemForComponent(this.ChildType.TitlePanelItem).SetUIActive(flag);
			return flag;
		}

		// Token: 0x0602E2B6 RID: 189110 RVA: 0x00CE0AD4 File Offset: 0x00CDECD4
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

		// Token: 0x0602E2B7 RID: 189111 RVA: 0x00CE0B24 File Offset: 0x00CDED24
		private bool RefreshContinueTextVisible()
		{
			ICommonRewardInfo rewardInfo = this.RewardData.GetRewardInfo();
			bool flag = !StringUtils.IsEmpty(rewardInfo.ContinueText);
			flag = (flag && rewardInfo.LeftBtnTextId == null && rewardInfo.RightBtnTextId == null);
			this.UiAccessor.GetItemForComponent(this.ChildType.ContinueText).SetUIActive(flag);
			return flag;
		}

		// Token: 0x0602E2B8 RID: 189112 RVA: 0x00CE0B84 File Offset: 0x00CDED84
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

		// Token: 0x0602E2B9 RID: 189113 RVA: 0x00CE0BD4 File Offset: 0x00CDEDD4
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

		// Token: 0x0602E2BA RID: 189114 RVA: 0x00CE0C30 File Offset: 0x00CDEE30
		private int CalcMaxCountPerRow()
		{
			float x = this.UiAccessor.GetGridLayoutForComponent(this.ChildType.ListContentItem).GetCellSize().X;
			return (int)Math.Floor((double)(this.UiAccessor.GetGridLayoutForComponent(this.ChildType.ListContentItem).RootUIComp.Get().GetWidth() / x)) * 2;
		}

		// Token: 0x0602E2BB RID: 189115 RVA: 0x00CE0C94 File Offset: 0x00CDEE94
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

		// Token: 0x0602E2BC RID: 189116 RVA: 0x00CE0D64 File Offset: 0x00CDEF64
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

		// Token: 0x0602E2BD RID: 189117 RVA: 0x00CE0E68 File Offset: 0x00CDF068
		private void OnRefreshRewardItemList(IReadOnlyList<RewardItemData> itemList)
		{
			if (this.RefreshItemListVisible())
			{
				this.RefreshItemList();
			}
		}

		// Token: 0x0602E2BE RID: 189118 RVA: 0x00CE0E78 File Offset: 0x00CDF078
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

		// Token: 0x0602E2BF RID: 189119 RVA: 0x00CE0EF2 File Offset: 0x00CDF0F2
		private void OnChangeChildView(EUiTabViewName eUiTabViewName, int? o)
		{
			this.OnClickMaskButton();
		}

		// Token: 0x0602E2C0 RID: 189120 RVA: 0x00CE0EFC File Offset: 0x00CDF0FC
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

		// Token: 0x0602E2C1 RID: 189121 RVA: 0x00CE0F4E File Offset: 0x00CDF14E
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

		// Token: 0x0602E2C2 RID: 189122 RVA: 0x00CE0F8B File Offset: 0x00CDF18B
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

		// Token: 0x0401899E RID: 100766
		private const int MAXROWCNT = 2;

		// Token: 0x0401899F RID: 100767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private RewardData<ICommonRewardInfo> RewardData;

		// Token: 0x040189A0 RID: 100768
		[Nullable(2)]
		private RewardItemList RewardItemList;

		// Token: 0x040189A1 RID: 100769
		[Nullable(2)]
		private ButtonItem LeftButton;

		// Token: 0x040189A2 RID: 100770
		[Nullable(2)]
		private ButtonItem RightButton;

		// Token: 0x040189A3 RID: 100771
		[Nullable(2)]
		private UUIButtonComponent MaskButton;

		// Token: 0x040189A4 RID: 100772
		[Nullable(2)]
		private RewardItemLoopList RewardItemLoopList;

		// Token: 0x040189A5 RID: 100773
		private readonly ICommonRewardComponentUiAccessor UiAccessor;

		// Token: 0x040189A6 RID: 100774
		private readonly ICommonRewardComponentChildType ChildType;

		// Token: 0x040189A7 RID: 100775
		private readonly ICommonRewardComponentCallbacks Callbacks;

		// Token: 0x040189A8 RID: 100776
		private EUiViewName? ViewName;

		// Token: 0x040189A9 RID: 100777
		private bool EventListenStatus;
	}
}
