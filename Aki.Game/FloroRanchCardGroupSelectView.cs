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

// Token: 0x02001B5A RID: 7002
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCardGroupSelectView : UiViewBase
{
	// Token: 0x0600CFB3 RID: 53171 RVA: 0x002F4F1F File Offset: 0x002F311F
	public FloroRanchCardGroupSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600CFB4 RID: 53172 RVA: 0x002F4F40 File Offset: 0x002F3140
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

	// Token: 0x0600CFB5 RID: 53173 RVA: 0x002F50F4 File Offset: 0x002F32F4
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchCardGroupSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchCardGroupSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFB6 RID: 53174 RVA: 0x002F5137 File Offset: 0x002F3337
	protected override void OnBeforeShow()
	{
		TsUiBlur uiBlur = this.UiBlur;
		if (uiBlur == null)
		{
			return;
		}
		uiBlur.SetEnableUiBlur(true);
	}

	// Token: 0x0600CFB7 RID: 53175 RVA: 0x002F514A File Offset: 0x002F334A
	protected override void OnBeforeHide()
	{
		TsUiBlur uiBlur = this.UiBlur;
		if (uiBlur == null)
		{
			return;
		}
		uiBlur.SetEnableUiBlur(false);
	}

	// Token: 0x0600CFB8 RID: 53176 RVA: 0x002F515D File Offset: 0x002F335D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600CFB9 RID: 53177 RVA: 0x002F517B File Offset: 0x002F337B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
	}

	// Token: 0x0600CFBA RID: 53178 RVA: 0x002F519C File Offset: 0x002F339C
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

	// Token: 0x0600CFBB RID: 53179 RVA: 0x002F51D8 File Offset: 0x002F33D8
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

	// Token: 0x0600CFBC RID: 53180 RVA: 0x002F525A File Offset: 0x002F345A
	private void ClearTimerId()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}
		this.TimerId = null;
	}

	// Token: 0x0600CFBD RID: 53181 RVA: 0x002F5286 File Offset: 0x002F3486
	protected override void OnBeforeDestroy()
	{
		this.ClearTimerId();
	}

	// Token: 0x0600CFBE RID: 53182 RVA: 0x002F528E File Offset: 0x002F348E
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

	// Token: 0x0600CFBF RID: 53183 RVA: 0x002F52C8 File Offset: 0x002F34C8
	private FloroRanchCardItem CreateCardItem()
	{
		FloroRanchCardItem floroRanchCardItem = new FloroRanchCardItem();
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		floroRanchCardItem.SetActivityDataType((currentActivityData != null) ? currentActivityData.ActivityDataType : EFloroRanchActivityDataType.Normal);
		floroRanchCardItem.SetToggleCallBack(new Action<int, int>(this.CardToggleClick));
		return floroRanchCardItem;
	}

	// Token: 0x0600CFC0 RID: 53184 RVA: 0x002F530C File Offset: 0x002F350C
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

	// Token: 0x0600CFC1 RID: 53185 RVA: 0x002F5360 File Offset: 0x002F3560
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

	// Token: 0x0600CFC2 RID: 53186 RVA: 0x002F53C4 File Offset: 0x002F35C4
	private void OnAnimEvent(string param)
	{
		if (param == EFloroRanchAnimEvent.ListShow.ToString())
		{
			this.RefreshCardList();
		}
	}

	// Token: 0x0600CFC3 RID: 53187 RVA: 0x002F53EE File Offset: 0x002F35EE
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CFC4 RID: 53188 RVA: 0x002F53F7 File Offset: 0x002F35F7
	private void OnClickHideButton()
	{
		FloroRanchGamePlayModel.Instance.HideRecordView();
	}

	// Token: 0x04005F7A RID: 24442
	private GenericLayout<FloroRanchCardItem, int> CardLayout;

	// Token: 0x04005F7B RID: 24443
	private List<int> CardIdList = new List<int>();

	// Token: 0x04005F7C RID: 24444
	private readonly HashSet<int> SelectedGridIndexSet = new HashSet<int>();

	// Token: 0x04005F7D RID: 24445
	private FloroRanchCurrencyItem ItemCost;

	// Token: 0x04005F7E RID: 24446
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x04005F7F RID: 24447
	[Nullable(2)]
	private TsUiBlur UiBlur;

	// Token: 0x020080A7 RID: 32935
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04029F63 RID: 171875
		public const int LayoutCard = 0;

		// Token: 0x04029F64 RID: 171876
		public const int ItemCard = 1;

		// Token: 0x04029F65 RID: 171877
		public const int ButtonRefresh = 2;

		// Token: 0x04029F66 RID: 171878
		public const int ButtonConfirm = 3;

		// Token: 0x04029F67 RID: 171879
		public const int ButtonSkip = 4;

		// Token: 0x04029F68 RID: 171880
		public const int HideButton = 5;

		// Token: 0x04029F69 RID: 171881
		public const int ItemCost = 6;

		// Token: 0x04029F6A RID: 171882
		public const int ItemHidePanel = 7;
	}
}
