using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BBE RID: 11198
[NullableContext(1)]
[Nullable(0)]
public class TimeOfDaySecondView : UiTickViewBase
{
	// Token: 0x06017352 RID: 95058 RVA: 0x005E2400 File Offset: 0x005E0600
	public TimeOfDaySecondView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017353 RID: 95059 RVA: 0x005E2414 File Offset: 0x005E0614
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBackBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017354 RID: 95060 RVA: 0x005E25E8 File Offset: 0x005E07E8
	protected override UniTask OnBeforeStartAsync()
	{
		TimeOfDaySecondView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TimeOfDaySecondView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017355 RID: 95061 RVA: 0x005E262C File Offset: 0x005E082C
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(6);
		UUIItem item2 = base.GetItem(7);
		base.GetUiNiagara(4).SetUIActive(false);
		this.NoCircleAttachView = new NoCircleAttachView<TimeOfDaySecondItemSt, TimeOfDaySecondCircleAttachItem>(item.GetOwner() as AUIBaseActor, false);
		NoCircleAttachView<TimeOfDaySecondItemSt, TimeOfDaySecondCircleAttachItem> noCircleAttachView = this.NoCircleAttachView;
		if (noCircleAttachView != null)
		{
			noCircleAttachView.SetControllerItem(item2);
		}
		NoCircleAttachView<TimeOfDaySecondItemSt, TimeOfDaySecondCircleAttachItem> noCircleAttachView2 = this.NoCircleAttachView;
		if (noCircleAttachView2 != null)
		{
			noCircleAttachView2.SetIfNeedFakeItem(true);
		}
		this.NoCircleAttachView.CreateItems(base.GetItem(5).GetOwner() as AUIBaseActor, 0f, new Func<AActor, int, int, TimeOfDaySecondCircleAttachItem>(this.CreateNoCircleAttachItem), EAttachDirection.Horizontal);
		base.GetItem(5).SetUIActive(false);
		this.RefreshTimerText();
		this.ReloadScrollView();
		this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimer), (float)this.TIMEGAP, 1f, null, null, true);
	}

	// Token: 0x06017356 RID: 95062 RVA: 0x005E2703 File Offset: 0x005E0903
	private TimeOfDaySecondToggleItem CreateToggleItem()
	{
		return new TimeOfDaySecondToggleItem();
	}

	// Token: 0x06017357 RID: 95063 RVA: 0x005E270A File Offset: 0x005E090A
	private TimeOfDaySecondCircleAttachItem CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		return new TimeOfDaySecondCircleAttachItem(actor);
	}

	// Token: 0x06017358 RID: 95064 RVA: 0x005E2714 File Offset: 0x005E0914
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<TimeOfDaySecondCircleAttachItem>(EEventName.ClickTimeItem, new Action<TimeOfDaySecondCircleAttachItem>(this.OnClickTimeItem));
		EventSystem.Instance.Add<double, double, Action>(EEventName.AdjustTimeInAnim, new Action<double, double, Action>(this.OnAdjustTimeInAnim));
		EventSystem.Instance.Add(EEventName.OnSelectTimeItem, new Action(this.OnSelectTimeItem));
		EventSystem.Instance.Add<int>(EEventName.OnSelectTimePreset, new Action<int>(this.OnSelectChange));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06017359 RID: 95065 RVA: 0x005E27AC File Offset: 0x005E09AC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<TimeOfDaySecondCircleAttachItem>(EEventName.ClickTimeItem, new Action<TimeOfDaySecondCircleAttachItem>(this.OnClickTimeItem));
		EventSystem.Instance.Remove<double, double, Action>(EEventName.AdjustTimeInAnim, new Action<double, double, Action>(this.OnAdjustTimeInAnim));
		EventSystem.Instance.Remove(EEventName.OnSelectTimeItem, new Action(this.OnSelectTimeItem));
		EventSystem.Instance.Remove<int>(EEventName.OnSelectTimePreset, new Action<int>(this.OnSelectChange));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0601735A RID: 95066 RVA: 0x005E2844 File Offset: 0x005E0A44
	protected override void OnAfterShow()
	{
		if (this.OpenParam == null)
		{
			return;
		}
		ITimeOfDaySecondViewParam timeOfDaySecondViewParam = (ITimeOfDaySecondViewParam)this.OpenParam;
		this.OnAdjustTimeInAnim(TimeOfDayModel.Instance.GameTime.Second, timeOfDaySecondViewParam.SetTime, null);
	}

	// Token: 0x0601735B RID: 95067 RVA: 0x005E2882 File Offset: 0x005E0A82
	private void OnClickTimeItem(TimeOfDaySecondCircleAttachItem item)
	{
		if (this.NoCircleAttachView.IsVelocityMoveState())
		{
			return;
		}
		this.NoCircleAttachView.AttachToIndex(item.GetCurrentShowItemIndex(), false);
	}

	// Token: 0x0601735C RID: 95068 RVA: 0x005E28A4 File Offset: 0x005E0AA4
	private void OnSelectTimeItem()
	{
		this.RefreshDropComponent();
	}

	// Token: 0x0601735D RID: 95069 RVA: 0x005E28AC File Offset: 0x005E0AAC
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.TimeOfDayLoadingView)
		{
			TimeOfDayController.Instance.SetUiAnimFlag(false);
			UUINiagara uiNiagara = base.GetUiNiagara(4);
			if (uiNiagara != null)
			{
				uiNiagara.ActivateSystem(true);
			}
			EventSystem.Instance.Emit(EEventName.DestroyAllUiCameraAnimationHandles);
			if (this.CurrentAdjustFinishCallback != null)
			{
				this.CurrentAdjustFinishCallback();
				this.CurrentAdjustFinishCallback = null;
			}
		}
	}

	// Token: 0x0601735E RID: 95070 RVA: 0x005E2910 File Offset: 0x005E0B10
	private void OnSelectChange(int inSelectIndex)
	{
		if (inSelectIndex >= 0)
		{
			TimeOfDaySecondItemSt currentSelectTimeItemSt = TimeOfDayModel.Instance.CurrentSelectTimeItemSt;
			if (currentSelectTimeItemSt == null || currentSelectTimeItemSt.ChangeDayIndex != inSelectIndex)
			{
				this.GenericLayout.SelectGridProxy(inSelectIndex, false);
				int num = 43200;
				for (int i = 0; i < this.CurrentShowItem.Length; i++)
				{
					TimeOfDaySecondItemSt timeOfDaySecondItemSt = this.CurrentShowItem[i];
					if (timeOfDaySecondItemSt.ChangeDayIndex == inSelectIndex && (inSelectIndex == 0 || timeOfDaySecondItemSt.SetTime == num))
					{
						TimeOfDayModel.Instance.CurrentSelectTimeItemSt = timeOfDaySecondItemSt;
						break;
					}
				}
				this.NoCircleAttachView.AttachToIndex(TimeOfDayModel.Instance.CurrentSelectTimeItemSt.Id, true);
				for (int j = -3; j < 3; j++)
				{
					TimeOfDaySecondCircleAttachItem itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(j);
					if (itemByShowIndex != null)
					{
						itemByShowIndex.GetRootItem().SetHierarchyIndex(j + 3);
					}
				}
				(base.GetItem(7).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController).Play("", -1, false);
				return;
			}
		}
	}

	// Token: 0x0601735F RID: 95071 RVA: 0x005E2A04 File Offset: 0x005E0C04
	private void RefreshDropComponent()
	{
		TimeOfDaySecondItemSt currentSelectTimeItemSt = TimeOfDayModel.Instance.CurrentSelectTimeItemSt;
		this.GenericLayout.SelectGridProxy(currentSelectTimeItemSt.ChangeDayIndex, false);
	}

	// Token: 0x06017360 RID: 95072 RVA: 0x005E2A30 File Offset: 0x005E0C30
	private void ReloadScrollView()
	{
		this.CurrentShowItem = TimeOfDayModel.Instance.GetTimeOfDayShowData();
		TimeOfDaySecondItemSt[] currentShowItem = this.CurrentShowItem;
		this.NoCircleAttachView.ReloadView(currentShowItem.Length, currentShowItem, 0);
		for (int i = -3; i < 3; i++)
		{
			TimeOfDaySecondCircleAttachItem itemByShowIndex = this.NoCircleAttachView.GetItemByShowIndex(i);
			if (itemByShowIndex != null)
			{
				itemByShowIndex.GetRootItem().SetHierarchyIndex(i + 3);
			}
		}
	}

	// Token: 0x06017361 RID: 95073 RVA: 0x005E2A90 File Offset: 0x005E0C90
	private void OnTimer(float deltaTime)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06017362 RID: 95074 RVA: 0x005E2A98 File Offset: 0x005E0C98
	protected override void OnTick(float deltaTime)
	{
		this.ShowEffectByExhibitionViewMoveState();
	}

	// Token: 0x06017363 RID: 95075 RVA: 0x005E2AA0 File Offset: 0x005E0CA0
	private void ShowEffectByExhibitionViewMoveState()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(4);
		if (this.NoCircleAttachView != null)
		{
			if (!this.NoCircleAttachView.MovingState())
			{
				if (!uiNiagara.IsUIActiveSelf())
				{
					base.GetUiNiagara(4).SetUIActive(true);
					return;
				}
			}
			else if (uiNiagara.IsUIActiveSelf())
			{
				base.GetUiNiagara(4).SetUIActive(false);
				return;
			}
		}
		else if (uiNiagara.IsUIActiveSelf())
		{
			base.GetUiNiagara(4).SetUIActive(false);
		}
	}

	// Token: 0x06017364 RID: 95076 RVA: 0x005E2B0C File Offset: 0x005E0D0C
	private void RefreshTimerText()
	{
		string hourMinuteString = TimeOfDayModel.Instance.GameTime.HourMinuteString;
		base.GetText(1).SetText(hourMinuteString, true);
	}

	// Token: 0x06017365 RID: 95077 RVA: 0x005E2B38 File Offset: 0x005E0D38
	protected override void OnBeforeDestroy()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}
		if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimeHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimeHandle);
		}
		TimeOfDayAnimController.CallBack = delegate()
		{
		};
		TimeOfDayController.Instance.SetUiAnimFlag(false);
		UiLayer.Instance.SetShowNormalMaskLayer(false, "");
		TimeOfDayController.Instance.ResumeTimeScale(true);
		if (this.CurrentAdjustFinishCallback != null)
		{
			this.CurrentAdjustFinishCallback();
			this.CurrentAdjustFinishCallback = null;
		}
		TimeOfDaySecondCircleAttachItem.MiddleOffsetCurve = null;
		this.NoCircleAttachView.Clear();
		GenericLayout<TimeOfDaySecondToggleItem, DaySelectPreset> genericLayout = this.GenericLayout;
		if (genericLayout == null)
		{
			return;
		}
		genericLayout.ClearChildren();
	}

	// Token: 0x06017366 RID: 95078 RVA: 0x005E2C10 File Offset: 0x005E0E10
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06017367 RID: 95079 RVA: 0x005E2C19 File Offset: 0x005E0E19
	private void OnClickConfirmBtn()
	{
		this.OnAdjustTimeInAnim(TimeOfDayModel.Instance.GameTime.Second, (double)TimeOfDayModel.Instance.CurrentSelectTimeItemSt.SetTime, null);
	}

	// Token: 0x06017368 RID: 95080 RVA: 0x005E2C44 File Offset: 0x005E0E44
	[NullableContext(2)]
	private void OnAdjustTimeInAnim(double startSecond, double setSecond, Action callback = null)
	{
		double setSecond2 = (setSecond - startSecond < 1800.0) ? (setSecond + 86400.0) : setSecond;
		this.CurrentAdjustFinishCallback = callback;
		uint changeDayNum = this.GetChangeDayNum();
		TimeOfDayController.Instance.SetUiAnimFlag(true);
		TimeOfDayController.Instance.AdjustTime(setSecond, SceneDateUpdateReason.PlayerOperate, changeDayNum, true);
		this.RefreshTimeHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.ReloadScrollView();
			this.RefreshTimeHandle = null;
		}, 1000f, null, null, true, 1f);
		this.PlayAnimation(startSecond, setSecond2, delegate
		{
		});
	}

	// Token: 0x06017369 RID: 95081 RVA: 0x005E2CE5 File Offset: 0x005E0EE5
	private uint GetChangeDayNum()
	{
		return (uint)TimeOfDayModel.Instance.CurrentSelectTimeItemSt.ChangeDayIndex;
	}

	// Token: 0x0601736A RID: 95082 RVA: 0x005E2CF6 File Offset: 0x005E0EF6
	private void PlayAnimation(double startSecond, double setSecond, Action callback)
	{
		TimeOfDayAnimController.PlayTimeAnimation(startSecond, setSecond, callback);
	}

	// Token: 0x0601736B RID: 95083 RVA: 0x005E2D00 File Offset: 0x005E0F00
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		double num = Convert.ToDouble(configParams[0]);
		if (num != 0.0)
		{
			int? num2 = null;
			int num3 = 0;
			for (;;)
			{
				int num4 = num3;
				TimeOfDaySecondItemSt[] currentShowItem = this.CurrentShowItem;
				if (num4 >= ((currentShowItem != null) ? currentShowItem.Length : 0))
				{
					goto IL_55;
				}
				if ((double)this.CurrentShowItem[num3].SetTime == num)
				{
					break;
				}
				num3++;
			}
			num2 = new int?(num3);
			IL_55:
			if (num2 != null && num2.Value >= 0)
			{
				NoCircleAttachView<TimeOfDaySecondItemSt, TimeOfDaySecondCircleAttachItem> noCircleAttachView = this.NoCircleAttachView;
				if (noCircleAttachView != null)
				{
					noCircleAttachView.AttachToIndex(num2.Value, true);
				}
				NoCircleAttachView<TimeOfDaySecondItemSt, TimeOfDaySecondCircleAttachItem> noCircleAttachView2 = this.NoCircleAttachView;
				UUIItem uuiitem;
				if (noCircleAttachView2 == null)
				{
					uuiitem = null;
				}
				else
				{
					TimeOfDaySecondCircleAttachItem itemByShowIndex = noCircleAttachView2.GetItemByShowIndex(num2.Value);
					uuiitem = ((itemByShowIndex != null) ? itemByShowIndex.GetRootItem() : null);
				}
				UUIItem uuiitem2 = uuiitem;
				if (uuiitem2 != null)
				{
					return new UUIItem[]
					{
						uuiitem2,
						uuiitem2
					};
				}
			}
		}
		return null;
	}

	// Token: 0x0400ADDB RID: 44507
	private int TIMEGAP = 1000;

	// Token: 0x0400ADDC RID: 44508
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x0400ADDD RID: 44509
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<TimeOfDaySecondItemSt, TimeOfDaySecondCircleAttachItem> NoCircleAttachView;

	// Token: 0x0400ADDE RID: 44510
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TimeOfDaySecondItemSt[] CurrentShowItem;

	// Token: 0x0400ADDF RID: 44511
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TimeOfDaySecondToggleItem, DaySelectPreset> GenericLayout;

	// Token: 0x0400ADE0 RID: 44512
	[Nullable(2)]
	private TimerHandle RefreshTimeHandle;

	// Token: 0x0400ADE1 RID: 44513
	[Nullable(2)]
	private Action CurrentAdjustFinishCallback;

	// Token: 0x02009172 RID: 37234
	[NullableContext(0)]
	public enum ETimeOfDayComponent
	{
		// Token: 0x0402F144 RID: 192836
		TimeImg,
		// Token: 0x0402F145 RID: 192837
		CurrentTimeText,
		// Token: 0x0402F146 RID: 192838
		BackBtn,
		// Token: 0x0402F147 RID: 192839
		ConfirmBtn,
		// Token: 0x0402F148 RID: 192840
		Effect,
		// Token: 0x0402F149 RID: 192841
		ScrollerItem,
		// Token: 0x0402F14A RID: 192842
		DragView,
		// Token: 0x0402F14B RID: 192843
		DragViewContent,
		// Token: 0x0402F14C RID: 192844
		HorizontalLayout,
		// Token: 0x0402F14D RID: 192845
		ToggleItem
	}
}
