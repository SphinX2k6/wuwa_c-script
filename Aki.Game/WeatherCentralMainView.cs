using System;
using System.Collections.Generic;
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

// Token: 0x0200227A RID: 8826
[NullableContext(1)]
[Nullable(0)]
public class WeatherCentralMainView : UiViewBase
{
	// Token: 0x06015D44 RID: 89412 RVA: 0x006547F2 File Offset: 0x006529F2
	public WeatherCentralMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015D45 RID: 89413 RVA: 0x00654804 File Offset: 0x00652A04
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

	// Token: 0x06015D46 RID: 89414 RVA: 0x00654934 File Offset: 0x00652B34
	protected override UniTask OnBeforeStartAsync()
	{
		WeatherCentralMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeatherCentralMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015D47 RID: 89415 RVA: 0x00654978 File Offset: 0x00652B78
	protected override void OnStart()
	{
		PopupCaptionItem caption = this.Caption;
		if (caption != null)
		{
			caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
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
		IReadOnlyList<WeatherSwitch> weatherSwitchConfigAll = WeatherModuleConfig.Instance.GetWeatherSwitchConfigAll();
		int? num = this.OpenParam as int?;
		if (num == null)
		{
			int currentWeatherId = WeatherModel.Instance.CurrentWeatherId;
			num = new int?(WeatherModel.Instance.GetSwitchConfigIdByWeatherId(currentWeatherId));
		}
		int num2 = -1;
		for (int i = 0; i < weatherSwitchConfigAll.Count; i++)
		{
			int id = weatherSwitchConfigAll[i].Id;
			int? num3 = num;
			if (id == num3.GetValueOrDefault() & num3 != null)
			{
				num2 = i;
				break;
			}
		}
		if (num2 >= 0)
		{
			index = num2;
		}
		this.SelectToggle(index);
		this.OnRedDotUpdate();
	}

	// Token: 0x06015D48 RID: 89416 RVA: 0x00654B50 File Offset: 0x00652D50
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnWeatherCentralRedDotUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x06015D49 RID: 89417 RVA: 0x00654B6E File Offset: 0x00652D6E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnWeatherCentralRedDotUpdate, new Action(this.OnRedDotUpdate));
	}

	// Token: 0x06015D4A RID: 89418 RVA: 0x00654B8C File Offset: 0x00652D8C
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

	// Token: 0x06015D4B RID: 89419 RVA: 0x00654BDC File Offset: 0x00652DDC
	private void OnRedDotUpdate()
	{
		GenericLayout<WeatherToggleItem, IWeatherToggleData> listLeft = this.ListLeft;
		IEnumerable<WeatherToggleItem> enumerable = (listLeft != null) ? listLeft.GetLayoutItemList() : null;
		foreach (WeatherToggleItem weatherToggleItem in (enumerable ?? Array.Empty<WeatherToggleItem>()))
		{
			weatherToggleItem.RefreshRedDot();
		}
		GenericLayout<WeatherToggleItem, IWeatherToggleData> listRight = this.ListRight;
		enumerable = ((listRight != null) ? listRight.GetLayoutItemList() : null);
		foreach (WeatherToggleItem weatherToggleItem2 in (enumerable ?? Array.Empty<WeatherToggleItem>()))
		{
			weatherToggleItem2.RefreshRedDot();
		}
	}

	// Token: 0x06015D4C RID: 89420 RVA: 0x00654C90 File Offset: 0x00652E90
	private UniTask InitializeWeatherToggleList()
	{
		WeatherCentralMainView.<InitializeWeatherToggleList>d__17 <InitializeWeatherToggleList>d__;
		<InitializeWeatherToggleList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeWeatherToggleList>d__.<>4__this = this;
		<InitializeWeatherToggleList>d__.<>1__state = -1;
		<InitializeWeatherToggleList>d__.<>t__builder.Start<WeatherCentralMainView.<InitializeWeatherToggleList>d__17>(ref <InitializeWeatherToggleList>d__);
		return <InitializeWeatherToggleList>d__.<>t__builder.Task;
	}

	// Token: 0x06015D4D RID: 89421 RVA: 0x00654CD4 File Offset: 0x00652ED4
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

	// Token: 0x06015D4E RID: 89422 RVA: 0x00654D30 File Offset: 0x00652F30
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

	// Token: 0x06015D4F RID: 89423 RVA: 0x00654D8C File Offset: 0x00652F8C
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

	// Token: 0x06015D50 RID: 89424 RVA: 0x00654F60 File Offset: 0x00653160
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

	// Token: 0x06015D51 RID: 89425 RVA: 0x00655010 File Offset: 0x00653210
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

	// Token: 0x06015D52 RID: 89426 RVA: 0x0065504B File Offset: 0x0065324B
	private void OnAllSequencePlayCompleted()
	{
		WeatherController.Instance.RequestSwitchWeather(this.SelectedConfigId).Forget();
	}

	// Token: 0x06015D53 RID: 89427 RVA: 0x00655064 File Offset: 0x00653264
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

	// Token: 0x06015D54 RID: 89428 RVA: 0x0065510D File Offset: 0x0065330D
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

	// Token: 0x06015D55 RID: 89429 RVA: 0x00655144 File Offset: 0x00653344
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

	// Token: 0x06015D56 RID: 89430 RVA: 0x00655250 File Offset: 0x00653450
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

	// Token: 0x06015D57 RID: 89431 RVA: 0x006552D8 File Offset: 0x006534D8
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

	// Token: 0x0400B7D5 RID: 47061
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400B7D6 RID: 47062
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeatherToggleItem, IWeatherToggleData> ListLeft;

	// Token: 0x0400B7D7 RID: 47063
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeatherToggleItem, IWeatherToggleData> ListRight;

	// Token: 0x0400B7D8 RID: 47064
	[Nullable(2)]
	private WeatherCentralBottomItem BottomItem;

	// Token: 0x0400B7D9 RID: 47065
	[Nullable(2)]
	private UUIItem CircleItem;

	// Token: 0x0400B7DA RID: 47066
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> LeftItems;

	// Token: 0x0400B7DB RID: 47067
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<UUIItem> RightItems;

	// Token: 0x0400B7DC RID: 47068
	private int SelectedConfigId = -1;

	// Token: 0x0400B7DD RID: 47069
	private const int MAX_TOGGLE_COUNT = 8;
}
