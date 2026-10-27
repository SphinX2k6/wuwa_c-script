using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D20 RID: 11552
[NullableContext(1)]
[Nullable(0)]
public class WeatherCentralMainView : UiViewBase
{
	// Token: 0x060184A3 RID: 99491 RVA: 0x0062E7FE File Offset: 0x0062C9FE
	public WeatherCentralMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060184A4 RID: 99492 RVA: 0x0062E810 File Offset: 0x0062CA10
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060184A5 RID: 99493 RVA: 0x0062E940 File Offset: 0x0062CB40
	protected override UniTask OnBeforeStartAsync()
	{
		WeatherCentralMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeatherCentralMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060184A6 RID: 99494 RVA: 0x0062E984 File Offset: 0x0062CB84
	protected override void OnStart()
	{
		PopupCaptionItem caption = this.Caption;
		if (caption != null)
		{
			caption.SetCloseCallBack(delegate
			{
				this.CloseMe(null);
			});
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		}
		WeatherCentralBottomItem bottomItem = this.BottomItem;
		if (bottomItem != null)
		{
			bottomItem.SetClickConfirmCallback(new Action(this.OnClickConfirm));
		}
		this.CircleItem = base.GetItem(5);
		this.LeftItems = new List<UUIItem>();
		foreach (WeatherToggleItem weatherToggleItem in this.ListLeft.GetLayoutItemList())
		{
			this.LeftItems.Add(weatherToggleItem.GetRootItem());
		}
		this.RightItems = new List<UUIItem>();
		foreach (WeatherToggleItem weatherToggleItem2 in this.ListRight.GetLayoutItemList())
		{
			this.RightItems.Add(weatherToggleItem2.GetRootItem());
		}
		int index = 0;
		IEnumerable<WeatherSwitch> weatherSwitchConfigAll = WeatherModuleConfig.Instance.GetWeatherSwitchConfigAll();
		int? configId = this.OpenParam as int?;
		if (configId == null)
		{
			int currentWeatherId = WeatherModel.Instance.CurrentWeatherId;
			configId = new int?(WeatherModel.Instance.GetSwitchConfigIdByWeatherId(currentWeatherId));
		}
		int num = weatherSwitchConfigAll.ToList<WeatherSwitch>().FindIndex(delegate(WeatherSwitch item)
		{
			int id = item.Id;
			int? configId = configId;
			return id == configId.GetValueOrDefault() & configId != null;
		});
		if (num >= 0)
		{
			index = num;
		}
		this.SelectToggle(index);
		this.OnRedDotUpdate();
	}

	// Token: 0x060184A7 RID: 99495 RVA: 0x0062EB44 File Offset: 0x0062CD44
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnWeatherCentralRedDotUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060184A8 RID: 99496 RVA: 0x0062EB62 File Offset: 0x0062CD62
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnWeatherCentralRedDotUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x060184A9 RID: 99497 RVA: 0x0062EB80 File Offset: 0x0062CD80
	private void SelectToggle(int index)
	{
		if (index % 2 == 0)
		{
			int index2 = index / 2;
			WeatherToggleItem layoutItemByIndex = this.ListLeft.GetLayoutItemByIndex(index2);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.SetToggleStateForce(true, true, true);
				return;
			}
		}
		else
		{
			int index3 = (index - 1) / 2;
			WeatherToggleItem layoutItemByIndex2 = this.ListRight.GetLayoutItemByIndex(index3);
			if (layoutItemByIndex2 != null)
			{
				layoutItemByIndex2.SetToggleStateForce(true, true, true);
			}
		}
	}

	// Token: 0x060184AA RID: 99498 RVA: 0x0062EBD0 File Offset: 0x0062CDD0
	private void OnRedDotUpdate()
	{
		GenericLayout<WeatherToggleItem, IWeatherToggleData> listLeft = this.ListLeft;
		IEnumerable<WeatherToggleItem> enumerable = (listLeft != null) ? listLeft.GetLayoutItemList() : null;
		foreach (WeatherToggleItem weatherToggleItem in (enumerable ?? Enumerable.Empty<WeatherToggleItem>()))
		{
			weatherToggleItem.RefreshRedDot();
		}
		GenericLayout<WeatherToggleItem, IWeatherToggleData> listRight = this.ListRight;
		enumerable = ((listRight != null) ? listRight.GetLayoutItemList() : null);
		foreach (WeatherToggleItem weatherToggleItem2 in (enumerable ?? Enumerable.Empty<WeatherToggleItem>()))
		{
			weatherToggleItem2.RefreshRedDot();
		}
	}

	// Token: 0x060184AB RID: 99499 RVA: 0x0062EC84 File Offset: 0x0062CE84
	private UniTask InitializeWeatherToggleList()
	{
		WeatherCentralMainView.<InitializeWeatherToggleList>d__17 <InitializeWeatherToggleList>d__;
		<InitializeWeatherToggleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeWeatherToggleList>d__.<>4__this = this;
		<InitializeWeatherToggleList>d__.<>1__state = -1;
		<InitializeWeatherToggleList>d__.<>t__builder.Start<WeatherCentralMainView.<InitializeWeatherToggleList>d__17>(ref <InitializeWeatherToggleList>d__);
		return <InitializeWeatherToggleList>d__.<>t__builder.Task;
	}

	// Token: 0x060184AC RID: 99500 RVA: 0x0062ECC8 File Offset: 0x0062CEC8
	private WeatherToggleItem CreateLeftWeatherToggleItem()
	{
		WeatherToggleItem item = new WeatherToggleItem();
		item.SetToggleClickCallback(delegate
		{
			this.OnToggleClick(true, item);
		});
		item.SetCanExecuteChange((int index) => this.CanExecuteChange(true, index));
		return item;
	}

	// Token: 0x060184AD RID: 99501 RVA: 0x0062ED24 File Offset: 0x0062CF24
	private WeatherToggleItem CreateRightWeatherToggleItem()
	{
		WeatherToggleItem item = new WeatherToggleItem();
		item.SetToggleClickCallback(delegate
		{
			this.OnToggleClick(false, item);
		});
		item.SetCanExecuteChange((int index) => this.CanExecuteChange(false, index));
		return item;
	}

	// Token: 0x060184AE RID: 99502 RVA: 0x0062ED80 File Offset: 0x0062CF80
	private void OnClickConfirm()
	{
		if (this.SelectedConfigId < 0)
		{
			Log.Instance.Error(ELogModule.Weather, ELogAuthor.LJ, "选择的天气非法或没有选择天气！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
		int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(currentAreaId);
		int num = WeatherModel.Instance.IsInValidArea(levelOneAreaId) ? 1 : 0;
		bool flag = WeatherModel.Instance.IsWeatherBanArea(this.SelectedConfigId, levelOneAreaId);
		if (num == 0 || flag)
		{
			int markId = WeatherModuleConfig.Instance.GetWeatherSwitchConfig(this.SelectedConfigId).Value.MarkConfigId;
			if (!MapModel.Instance.IsConfigMarkIdUnlock(markId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("WeatherControl_InvalidAreaTips", Array.Empty<object>());
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeatherCentralTeleportConfirm);
			TOnTelSuccessCallBack <>9__1;
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				WorldMapController instance = WorldMapController.Instance;
				int markId = markId;
				TOnTelSuccessCallBack successAction;
				if ((successAction = <>9__1) == null)
				{
					successAction = (<>9__1 = delegate()
					{
						WeatherModel instance2 = WeatherModel.Instance;
						if (instance2 == null)
						{
							return;
						}
						instance2.SetTargetWeatherSwitchConfigId(this.SelectedConfigId);
					});
				}
				instance.TryTeleport(markId, successAction);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		else
		{
			if (!WeatherModel.Instance.IsCurrentTimeInValidTime(this.SelectedConfigId) && WeatherModel.Instance.TimeSwitchConfirmNeedShow)
			{
				ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeatherCentralTimeSwitchConfirm);
				confirmBoxDataNew2.HasToggle = true;
				confirmBoxDataNew2.ToggleText = TextConfig.Instance.GetTextById("PlotSkipConfirmToggle");
				confirmBoxDataNew2.SetToggleFunction(delegate(bool isSelectOn)
				{
					WeatherModel.Instance.TimeSwitchConfirmNeedShow = !isSelectOn;
				});
				confirmBoxDataNew2.FunctionMap.Add(2, delegate
				{
					this.ClickConfirm(levelOneAreaId);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
				return;
			}
			this.ClickConfirm(levelOneAreaId);
			return;
		}
	}

	// Token: 0x060184AF RID: 99503 RVA: 0x0062EF54 File Offset: 0x0062D154
	private void ClickConfirm(int levelOneAreaId)
	{
		UiManager.Instance.ResetToBattleView(null);
		AutoPilotController.Instance.ExitAutoPilot("WeatherSwitch", false).Forget();
		int accelerateWeatherTime = WeatherModel.Instance.GetAccelerateWeatherTime(this.SelectedConfigId);
		if (accelerateWeatherTime <= 0)
		{
			Log.Instance.Info(ELogModule.Weather, ELogAuthor.LJ, "无需时间加速", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.OnAccelerateTimeFinished();
			WeatherModel.Instance.ObservatoryModule.PlayWeatherControlSequence(new Action(this.OnAllSequencePlayCompleted));
			return;
		}
		WeatherModel.Instance.ObservatoryModule.AccelerateTime(levelOneAreaId, accelerateWeatherTime, new Action(this.OnAllSequencePlayCompleted), new Action(this.OnAccelerateTimeFinished));
	}

	// Token: 0x060184B0 RID: 99504 RVA: 0x0062F004 File Offset: 0x0062D204
	private void OnAccelerateTimeFinished()
	{
		WeatherModel instance = WeatherModel.Instance;
		if (instance != null)
		{
			instance.RecordSwitchTime();
		}
		double second = TimeOfDayModel.Instance.GameTime.Second;
		TimeOfDayController.Instance.AdjustTime(second, SceneDateUpdateReason.PlayerOperate, 0U, true);
	}

	// Token: 0x060184B1 RID: 99505 RVA: 0x0062F03F File Offset: 0x0062D23F
	private void OnAllSequencePlayCompleted()
	{
		WeatherController.Instance.RequestSwitchWeather(this.SelectedConfigId).Forget();
	}

	// Token: 0x060184B2 RID: 99506 RVA: 0x0062F058 File Offset: 0x0062D258
	private void OnToggleClick(bool isLeftSide, WeatherToggleItem item)
	{
		if (isLeftSide)
		{
			GenericLayout<WeatherToggleItem, IWeatherToggleData> listRight = this.ListRight;
			if (listRight != null)
			{
				listRight.DeselectCurrentGridProxy();
			}
			GenericLayout<WeatherToggleItem, IWeatherToggleData> listLeft = this.ListLeft;
			if (listLeft != null)
			{
				listLeft.SelectGridProxy(item.GridIndex, false);
			}
		}
		else
		{
			GenericLayout<WeatherToggleItem, IWeatherToggleData> listLeft2 = this.ListLeft;
			if (listLeft2 != null)
			{
				listLeft2.DeselectCurrentGridProxy();
			}
			GenericLayout<WeatherToggleItem, IWeatherToggleData> listRight2 = this.ListRight;
			if (listRight2 != null)
			{
				listRight2.SelectGridProxy(item.GridIndex, false);
			}
		}
		WeatherCentralBottomItem bottomItem = this.BottomItem;
		if (bottomItem != null)
		{
			bottomItem.RefreshByConfigId(item.ConfigId);
		}
		this.SelectedConfigId = item.ConfigId;
		if (WeatherModel.Instance.IsWeatherSwitchConfigUnlocked(item.ConfigId))
		{
			WeatherModel.Instance.RecordWeatherClicked(item.ConfigId);
		}
	}

	// Token: 0x060184B3 RID: 99507 RVA: 0x0062F101 File Offset: 0x0062D301
	private bool CanExecuteChange(bool isLeftSide, int index)
	{
		if (isLeftSide)
		{
			GenericLayout<WeatherToggleItem, IWeatherToggleData> listLeft = this.ListLeft;
			return listLeft == null || listLeft.GetSelectedGridIndex() != index;
		}
		GenericLayout<WeatherToggleItem, IWeatherToggleData> listRight = this.ListRight;
		return listRight == null || listRight.GetSelectedGridIndex() != index;
	}

	// Token: 0x060184B4 RID: 99508 RVA: 0x0062F138 File Offset: 0x0062D338
	private void OnScrollValueChange(FVector2D inVector)
	{
		float num = 0.1f;
		float num2 = 0.35f;
		float y = this.CircleItem.GetLGUISpaceAbsolutePosition().Y;
		float radius = this.CircleItem.Width / 2f;
		float[] array = this.CalculateCircularOffsets(this.LeftItems, y, radius);
		for (int i = 0; i < this.LeftItems.Count; i++)
		{
			float alpha = array[i];
			this.LeftItems[i].SetPivot(new FVector2D(MathUtils.Instance.Lerp(0.5f + num, 0f - num2, alpha), 0.5f));
		}
		float[] array2 = this.CalculateCircularOffsets(this.RightItems, y, radius);
		for (int j = 0; j < this.RightItems.Count; j++)
		{
			float alpha2 = array2[j];
			this.RightItems[j].SetPivot(new FVector2D(MathUtils.Instance.Lerp(0.5f - num, 1f + num2, alpha2), 0.5f));
		}
	}

	// Token: 0x060184B5 RID: 99509 RVA: 0x0062F244 File Offset: 0x0062D444
	private float[] CalculateCircularOffsets(List<UUIItem> items, float centerY, float radius)
	{
		List<float> list = new List<float>();
		foreach (UUIItem uuiitem in items)
		{
			float num = Math.Min(Math.Abs(uuiitem.GetLGUISpaceAbsolutePosition().Y - centerY) / radius, 1f);
			float item = (float)Math.Sqrt((double)(1f - num * num));
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060184B6 RID: 99510 RVA: 0x0062F2CC File Offset: 0x0062D4CC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (configParams[0] == "WeatherNotSelected")
		{
			foreach (WeatherToggleItem weatherToggleItem in this.ListLeft.GetLayoutItemList())
			{
				if (weatherToggleItem.GetToggleState() == EToggleState.ETT_UnChecked)
				{
					UUIItem toggleItem = weatherToggleItem.GetToggleItem();
					if (toggleItem != null)
					{
						return new UUIItem[]
						{
							toggleItem,
							toggleItem
						};
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0400B460 RID: 46176
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400B461 RID: 46177
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeatherToggleItem, IWeatherToggleData> ListLeft;

	// Token: 0x0400B462 RID: 46178
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeatherToggleItem, IWeatherToggleData> ListRight;

	// Token: 0x0400B463 RID: 46179
	[Nullable(2)]
	private WeatherCentralBottomItem BottomItem;

	// Token: 0x0400B464 RID: 46180
	[Nullable(2)]
	private UUIItem CircleItem;

	// Token: 0x0400B465 RID: 46181
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> LeftItems;

	// Token: 0x0400B466 RID: 46182
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> RightItems;

	// Token: 0x0400B467 RID: 46183
	private int SelectedConfigId = -1;

	// Token: 0x0400B468 RID: 46184
	private const int MAX_TOGGLE_COUNT = 8;
}
