using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001019 RID: 4121
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardGroupSelectView : UiViewBase
{
	// Token: 0x0600A3C4 RID: 41924 RVA: 0x002FFFF7 File Offset: 0x002FE1F7
	public FloroRanchCardGroupSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A3C5 RID: 41925 RVA: 0x00300018 File Offset: 0x002FE218
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnCloseView));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickHideButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A3C6 RID: 41926 RVA: 0x003001CC File Offset: 0x002FE3CC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchCardGroupSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchCardGroupSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A3C7 RID: 41927 RVA: 0x0030020F File Offset: 0x002FE40F
	protected override void OnBeforeShow()
	{
		TsUiBlur uiBlur = this.UiBlur;
		if (uiBlur == null)
		{
			return;
		}
		uiBlur.SetEnableUiBlur(true);
	}

	// Token: 0x0600A3C8 RID: 41928 RVA: 0x00300222 File Offset: 0x002FE422
	protected override void OnBeforeHide()
	{
		TsUiBlur uiBlur = this.UiBlur;
		if (uiBlur == null)
		{
			return;
		}
		uiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600A3C9 RID: 41929 RVA: 0x00300235 File Offset: 0x002FE435
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600A3CA RID: 41930 RVA: 0x00300253 File Offset: 0x002FE453
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600A3CB RID: 41931 RVA: 0x00300274 File Offset: 0x002FE474
	private void RefreshCardList()
	{
		this.CardLayout.RefreshByDataAsync(this.CardIdList, false, null).ContinueWith(delegate()
		{
			this.PlayCardAppearAnim();
			this.SelectedGridIndexSet.Clear();
			for (int i = 0; i < this.CardIdList.Count; i++)
			{
				this.SelectedGridIndexSet.Add(i);
			}
			base.GetButton(3).SetSelfInteractive(this.SelectedGridIndexSet.Count > 0);
			foreach (FloroRanchCardItem floroRanchCardItem in this.CardLayout.GetLayoutItemList())
			{
				floroRanchCardItem.SetToggleState(true);
			}
		});
	}

	// Token: 0x0600A3CC RID: 41932 RVA: 0x003002B0 File Offset: 0x002FE4B0
	private void PlayCardAppearAnim()
	{
		if (this.TimerId != null)
		{
			this.ClearTimerId();
		}
		List<FloroRanchCardItem> itemList = this.CardLayout.GetLayoutItemList();
		int totalCount = itemList.Count;
		if (totalCount == 0)
		{
			return;
		}
		int curIndex = 0;
		this.TimerId = TimerSystem.GameplayTimeInstance.Loop(delegate(float _)
		{
			int curIndex;
			if (curIndex < totalCount)
			{
				itemList[curIndex].PlayAppearAnim();
				curIndex = curIndex;
				curIndex++;
			}
		}, 50f, totalCount, 1f, null, null, true);
	}

	// Token: 0x0600A3CD RID: 41933 RVA: 0x00300332 File Offset: 0x002FE532
	private void ClearTimerId()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}
		this.TimerId = null;
	}

	// Token: 0x0600A3CE RID: 41934 RVA: 0x0030035E File Offset: 0x002FE55E
	protected override void OnBeforeDestroy()
	{
		this.ClearTimerId();
	}

	// Token: 0x0600A3CF RID: 41935 RVA: 0x00300366 File Offset: 0x002FE566
	private void InitUiBlur()
	{
		AUIBaseActor rootActor = this.RootActor;
		this.UiBlur = (((rootActor != null) ? rootActor.GetComponentByClass(TsUiBlur.StaticClass()) : null) as TsUiBlur);
		TsUiBlur uiBlur = this.UiBlur;
		if (uiBlur == null)
		{
			return;
		}
		uiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600A3D0 RID: 41936 RVA: 0x003003A0 File Offset: 0x002FE5A0
	private FloroRanchCardItem CreateCardItem()
	{
		FloroRanchCardItem floroRanchCardItem = new FloroRanchCardItem();
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		floroRanchCardItem.SetActivityDataType((currentActivityData != null) ? currentActivityData.ActivityDataType : EFloroRanchActivityDataType.Normal);
		floroRanchCardItem.SetToggleCallBack(new Action<int, int>(this.CardToggleClick));
		return floroRanchCardItem;
	}

	// Token: 0x0600A3D1 RID: 41937 RVA: 0x003003E4 File Offset: 0x002FE5E4
	public void CardToggleClick(int gridIndex, int cardId)
	{
		if (this.SelectedGridIndexSet.Contains(gridIndex))
		{
			this.SelectedGridIndexSet.Remove(gridIndex);
		}
		else
		{
			this.SelectedGridIndexSet.Add(gridIndex);
		}
		base.GetButton(3).SetSelfInteractive(this.SelectedGridIndexSet.Count > 0);
	}

	// Token: 0x0600A3D2 RID: 41938 RVA: 0x00300438 File Offset: 0x002FE638
	private void OnClickConfirmBtn()
	{
		global::FloroRanchActivityData activityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (activityData == null)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FloroRanchCardGroupSelect);
		Action<FloroRanchPlaySelectCardGroupResponse> <>9__1;
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			List<int> list = new List<int>();
			foreach (int index in this.SelectedGridIndexSet)
			{
				list.Add(this.CardIdList[index]);
			}
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FloroRanchCardInGameRedDot, null) ?? new HashSet<int>();
			foreach (int item in list)
			{
				if (!hashSet.Contains(item))
				{
					hashSet.Add(item);
				}
			}
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FloroRanchCardInGameRedDot, hashSet);
			int id = activityData.Id;
			int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
			FloroRanchController instance = FloroRanchController.Instance;
			int activityId = id;
			int subInstanceId2 = subInstanceId;
			int[] cardIdList = list.ToArray();
			Action<FloroRanchPlaySelectCardGroupResponse> callback;
			if ((callback = <>9__1) == null)
			{
				callback = (<>9__1 = delegate(FloroRanchPlaySelectCardGroupResponse response)
				{
					this.OnCloseView();
				});
			}
			instance.SendFloroRanchPlaySelectCardGroupRequest(activityId, subInstanceId2, cardIdList, callback);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A3D3 RID: 41939 RVA: 0x0030049C File Offset: 0x002FE69C
	private void OnAnimEvent(string param)
	{
		if (param == EFloroRanchAnimEvent.ListShow.ToString())
		{
			this.RefreshCardList();
		}
	}

	// Token: 0x0600A3D4 RID: 41940 RVA: 0x003004C6 File Offset: 0x002FE6C6
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A3D5 RID: 41941 RVA: 0x003004CF File Offset: 0x002FE6CF
	private void OnClickHideButton()
	{
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x04006049 RID: 24649
	private GenericLayout<FloroRanchCardItem, int> CardLayout;

	// Token: 0x0400604A RID: 24650
	private List<int> CardIdList = new List<int>();

	// Token: 0x0400604B RID: 24651
	private readonly HashSet<int> SelectedGridIndexSet = new HashSet<int>();

	// Token: 0x0400604C RID: 24652
	private FloroRanchCurrencyItem ItemCost;

	// Token: 0x0400604D RID: 24653
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x0400604E RID: 24654
	[Nullable(2)]
	private TsUiBlur UiBlur;

	// Token: 0x02007235 RID: 29237
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025297 RID: 152215
		public const int LayoutCard = 0;

		// Token: 0x04025298 RID: 152216
		public const int ItemCard = 1;

		// Token: 0x04025299 RID: 152217
		public const int ButtonRefresh = 2;

		// Token: 0x0402529A RID: 152218
		public const int ButtonConfirm = 3;

		// Token: 0x0402529B RID: 152219
		public const int ButtonSkip = 4;

		// Token: 0x0402529C RID: 152220
		public const int HideButton = 5;

		// Token: 0x0402529D RID: 152221
		public const int ItemCost = 6;

		// Token: 0x0402529E RID: 152222
		public const int ItemHidePanel = 7;
	}
}
