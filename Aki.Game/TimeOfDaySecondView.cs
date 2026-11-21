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

// Token: 0x02002139 RID: 8505
[NullableContext(1)]
[Nullable(0)]
public class TimeOfDaySecondView : UiTickViewBase
{
	// Token: 0x06014D83 RID: 85379 RVA: 0x0060EFD4 File Offset: 0x0060D1D4
	public TimeOfDaySecondView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014D84 RID: 85380 RVA: 0x0060EFE8 File Offset: 0x0060D1E8
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

	// Token: 0x06014D85 RID: 85381 RVA: 0x0060F1BC File Offset: 0x0060D3BC
	protected override UniTask OnBeforeStartAsync()
	{
		TimeOfDaySecondView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TimeOfDaySecondView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014D86 RID: 85382 RVA: 0x0060F200 File Offset: 0x0060D400
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

	// Token: 0x06014D87 RID: 85383 RVA: 0x0060F2D7 File Offset: 0x0060D4D7
	private TimeOfDaySecondToggleItem CreateToggleItem()
	{
		return new TimeOfDaySecondToggleItem();
	}

	// Token: 0x06014D88 RID: 85384 RVA: 0x0060F2DE File Offset: 0x0060D4DE
	private TimeOfDaySecondCircleAttachItem CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		return new TimeOfDaySecondCircleAttachItem(actor);
	}

	// Token: 0x06014D89 RID: 85385 RVA: 0x0060F2E8 File Offset: 0x0060D4E8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<TimeOfDaySecondCircleAttachItem>(EEventName.ClickTimeItem, new Action<TimeOfDaySecondCircleAttachItem>(this.OnClickTimeItem));
		EventSystem.Instance.Add<double, double, Action>(EEventName.AdjustTimeInAnim, new Action<double, double, Action>(this.OnAdjustTimeInAnim));
		EventSystem.Instance.Add(EEventName.OnSelectTimeItem, new Action(this.OnSelectTimeItem));
		EventSystem.Instance.Add<int>(EEventName.OnSelectTimePreset, new Action<int>(this.OnSelectChange));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06014D8A RID: 85386 RVA: 0x0060F380 File Offset: 0x0060D580
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<TimeOfDaySecondCircleAttachItem>(EEventName.ClickTimeItem, new Action<TimeOfDaySecondCircleAttachItem>(this.OnClickTimeItem));
		EventSystem.Instance.Remove<double, double, Action>(EEventName.AdjustTimeInAnim, new Action<double, double, Action>(this.OnAdjustTimeInAnim));
		EventSystem.Instance.Remove(EEventName.OnSelectTimeItem, new Action(this.OnSelectTimeItem));
		EventSystem.Instance.Remove<int>(EEventName.OnSelectTimePreset, new Action<int>(this.OnSelectChange));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06014D8B RID: 85387 RVA: 0x0060F418 File Offset: 0x0060D618
	protected override void OnAfterShow()
	{
		if (this.OpenParam == null)
		{
			return;
		}
		ITimeOfDaySecondViewParam timeOfDaySecondViewParam = (ITimeOfDaySecondViewParam)this.OpenParam;
		this.OnAdjustTimeInAnim(TimeOfDayModel.Instance.GameTime.Second, timeOfDaySecondViewParam.SetTime, null);
	}

	// Token: 0x06014D8C RID: 85388 RVA: 0x0060F456 File Offset: 0x0060D656
	private void OnClickTimeItem(TimeOfDaySecondCircleAttachItem item)
	{
		if (this.NoCircleAttachView.IsVelocityMoveState())
		{
			return;
		}
		this.NoCircleAttachView.AttachToIndex(item.GetCurrentShowItemIndex(), false);
	}

	// Token: 0x06014D8D RID: 85389 RVA: 0x0060F478 File Offset: 0x0060D678
	private void OnSelectTimeItem()
	{
		this.RefreshDropComponent();
	}

	// Token: 0x06014D8E RID: 85390 RVA: 0x0060F480 File Offset: 0x0060D680
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

	// Token: 0x06014D8F RID: 85391 RVA: 0x0060F4E4 File Offset: 0x0060D6E4
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

	// Token: 0x06014D90 RID: 85392 RVA: 0x0060F5D8 File Offset: 0x0060D7D8
	private void RefreshDropComponent()
	{
		TimeOfDaySecondItemSt currentSelectTimeItemSt = TimeOfDayModel.Instance.CurrentSelectTimeItemSt;
		this.GenericLayout.SelectGridProxy(currentSelectTimeItemSt.ChangeDayIndex, false);
	}

	// Token: 0x06014D91 RID: 85393 RVA: 0x0060F604 File Offset: 0x0060D804
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

	// Token: 0x06014D92 RID: 85394 RVA: 0x0060F664 File Offset: 0x0060D864
	private void OnTimer(float deltaTime)
	{
		this.RefreshTimerText();
	}

	// Token: 0x06014D93 RID: 85395 RVA: 0x0060F66C File Offset: 0x0060D86C
	protected override void OnTick(float deltaTime)
	{
		this.ShowEffectByExhibitionViewMoveState();
	}

	// Token: 0x06014D94 RID: 85396 RVA: 0x0060F674 File Offset: 0x0060D874
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

	// Token: 0x06014D95 RID: 85397 RVA: 0x0060F6E0 File Offset: 0x0060D8E0
	private void RefreshTimerText()
	{
		string hourMinuteString = TimeOfDayModel.Instance.GameTime.HourMinuteString;
		base.GetText(1).SetText(hourMinuteString, true);
	}

	// Token: 0x06014D96 RID: 85398 RVA: 0x0060F70C File Offset: 0x0060D90C
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

	// Token: 0x06014D97 RID: 85399 RVA: 0x0060F7E4 File Offset: 0x0060D9E4
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014D98 RID: 85400 RVA: 0x0060F7ED File Offset: 0x0060D9ED
	private void OnClickConfirmBtn()
	{
		this.OnAdjustTimeInAnim(TimeOfDayModel.Instance.GameTime.Second, (double)TimeOfDayModel.Instance.CurrentSelectTimeItemSt.SetTime, null);
	}

	// Token: 0x06014D99 RID: 85401 RVA: 0x0060F818 File Offset: 0x0060DA18
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

	// Token: 0x06014D9A RID: 85402 RVA: 0x0060F8B9 File Offset: 0x0060DAB9
	private uint GetChangeDayNum()
	{
		return (uint)TimeOfDayModel.Instance.CurrentSelectTimeItemSt.ChangeDayIndex;
	}

	// Token: 0x06014D9B RID: 85403 RVA: 0x0060F8CA File Offset: 0x0060DACA
	private void PlayAnimation(double startSecond, double setSecond, Action callback)
	{
		TimeOfDayAnimController.PlayTimeAnimation(startSecond, setSecond, callback);
	}

	// Token: 0x06014D9C RID: 85404 RVA: 0x0060F8D4 File Offset: 0x0060DAD4
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

	// Token: 0x0400B1E0 RID: 45536
	private int TIMEGAP = 1000;

	// Token: 0x0400B1E1 RID: 45537
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x0400B1E2 RID: 45538
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<TimeOfDaySecondItemSt, TimeOfDaySecondCircleAttachItem> NoCircleAttachView;

	// Token: 0x0400B1E3 RID: 45539
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TimeOfDaySecondItemSt[] CurrentShowItem;

	// Token: 0x0400B1E4 RID: 45540
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TimeOfDaySecondToggleItem, DaySelectPreset> GenericLayout;

	// Token: 0x0400B1E5 RID: 45541
	[Nullable(2)]
	private TimerHandle RefreshTimeHandle;

	// Token: 0x0400B1E6 RID: 45542
	[Nullable(2)]
	private Action CurrentAdjustFinishCallback;

	// Token: 0x020083B6 RID: 33718
	[NullableContext(0)]
	public enum ETimeOfDayComponent
	{
		// Token: 0x0402A84A RID: 174154
		TimeImg,
		// Token: 0x0402A84B RID: 174155
		CurrentTimeText,
		// Token: 0x0402A84C RID: 174156
		BackBtn,
		// Token: 0x0402A84D RID: 174157
		ConfirmBtn,
		// Token: 0x0402A84E RID: 174158
		Effect,
		// Token: 0x0402A84F RID: 174159
		ScrollerItem,
		// Token: 0x0402A850 RID: 174160
		DragView,
		// Token: 0x0402A851 RID: 174161
		DragViewContent,
		// Token: 0x0402A852 RID: 174162
		HorizontalLayout,
		// Token: 0x0402A853 RID: 174163
		ToggleItem
	}
}
