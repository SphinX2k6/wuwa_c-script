using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012E4 RID: 4836
[NullableContext(1)]
[Nullable(0)]
public class MapTravelMainView : UiViewBase
{
	// Token: 0x06008559 RID: 34137 RVA: 0x001C5B7C File Offset: 0x001C3D7C
	public MapTravelMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600855A RID: 34138 RVA: 0x001C5C00 File Offset: 0x001C3E00
	protected unsafe override void OnRegisterComponent()
	{
		int num = 28;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIMultiTemplateLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedPreLevelButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedNextLevelButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600855B RID: 34139 RVA: 0x001C6038 File Offset: 0x001C4238
	protected override UniTask OnBeforeStartAsync()
	{
		MapTravelMainView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelMainView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600855C RID: 34140 RVA: 0x001C607C File Offset: 0x001C427C
	private UniTask CreateSubViewButton()
	{
		MapTravelMainView.<CreateSubViewButton>d__26 <CreateSubViewButton>d__;
		<CreateSubViewButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSubViewButton>d__.<>4__this = this;
		<CreateSubViewButton>d__.<>1__state = -1;
		<CreateSubViewButton>d__.<>t__builder.Start<MapTravelMainView.<CreateSubViewButton>d__26>(ref <CreateSubViewButton>d__);
		return <CreateSubViewButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600855D RID: 34141 RVA: 0x001C60C0 File Offset: 0x001C42C0
	protected override void OnStart()
	{
		this.LevelUpButton.SetRedDotVisible(true);
		this.SelectedLevel = this.ActivityBaseData.TravelLevel;
		MapTravelConfig activityConfig = this.ActivityBaseData.GetActivityConfig();
		this.CaptionComponent.SetTitleByTextIdAndArgNew(activityConfig.GetTabName(0), Array.Empty<object>());
		base.GetSpine(22).SetTimeScale(1.5f);
		UUIItem item = base.GetItem(25);
		UUIItem item2 = base.GetItem(27);
		FVector fvector = item2.K2_GetComponentLocation();
		this.BgOffset = Math.Abs(item.K2_GetComponentLocation().X - fvector.X);
		int num = 2520;
		this.BgScale = (this.BgOffset + (float)num) / (float)num * item2.K2_GetComponentScale().X;
		this.BgLocation = new FVector?(base.GetItem(27).K2_GetComponentLocation());
		this.BgLocation = new FVector?(new FVector(item.K2_GetComponentLocation().X, fvector.Y, item.K2_GetComponentLocation().Z));
	}

	// Token: 0x0600855E RID: 34142 RVA: 0x001C61C1 File Offset: 0x001C43C1
	protected override void OnBeforeShow()
	{
		this.RefreshMainView();
	}

	// Token: 0x0600855F RID: 34143 RVA: 0x001C61C9 File Offset: 0x001C43C9
	protected override void OnBeforeDestroy()
	{
		this.BgLocation = null;
	}

	// Token: 0x06008560 RID: 34144 RVA: 0x001C61D7 File Offset: 0x001C43D7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x06008561 RID: 34145 RVA: 0x001C620E File Offset: 0x001C440E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x06008562 RID: 34146 RVA: 0x001C6245 File Offset: 0x001C4445
	private void RefreshMainView()
	{
		this.RefreshExpComponent(this.SelectedLevel);
		this.RefreshSubViewButton();
	}

	// Token: 0x06008563 RID: 34147 RVA: 0x001C6259 File Offset: 0x001C4459
	private void CloseButtonClicked()
	{
		if (this.SelectedViewType == EMapTravelSubType.Main)
		{
			base.CloseMe(null);
			return;
		}
		this.CloseSubView();
	}

	// Token: 0x06008564 RID: 34148 RVA: 0x001C6272 File Offset: 0x001C4472
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "LevelChange")
		{
			this.RefreshExpComponent(this.SelectedLevel);
		}
	}

	// Token: 0x06008565 RID: 34149 RVA: 0x001C6290 File Offset: 0x001C4490
	private void RefreshExpComponent(int level)
	{
		bool flag = level < this.ActivityBaseData.TravelLevel;
		if (level < this.ActivityBaseData.TravelLevel)
		{
			this.SetPerformanceFinishedLevel(level);
		}
		else if (level == this.ActivityBaseData.TravelLevel)
		{
			this.SetPerformanceCurrentLevel(level);
		}
		else
		{
			this.SetPerformanceUnFinishedLevel(level);
		}
		IMapTravelLevelData mapTravelLevelData = this.ActivityBaseData.TravelLevelData[level];
		MapLevelExp value = ActivityMapTravelConfig.Instance.GetLevelExpConfig(mapTravelLevelData.Id).Value;
		base.GetText(1).SetText(level.ToString(), true);
		this.CurrentRewardSoarStrengthCount = 0;
		int? intConfig = ConfigCommonParamById.GetIntConfig("FlyStrengthItemId");
		List<TItem> list = (value.RewardDropId > 0) ? CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.RewardDropId) : new List<TItem>();
		List<IItemGridData> list2 = new List<IItemGridData>();
		foreach (TItem titem in list)
		{
			ItemGridData item = new ItemGridData
			{
				Item = titem,
				HasClaimed = flag
			};
			list2.Add(item);
			int itemId = titem.ItemData.ItemId;
			int? num = intConfig;
			if (itemId == num.GetValueOrDefault() & num != null)
			{
				this.CurrentRewardSoarStrengthCount++;
			}
		}
		this.LevelRewardLayout.RefreshByData(list2, null, false);
		base.GetItem(6).SetUIActive(list2.Count > 0);
		base.GetItem(9).SetUIActive(!StringUtils.IsEmpty(value.TipsLock));
		if (!StringUtils.IsEmpty(value.TipsLock))
		{
			string textStringId = flag ? value.TipsDone : value.TipsLock;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), textStringId, Array.Empty<object>());
		}
		base.GetButton(4).RootUIComp.Get().SetUIActive(level > 0);
		base.GetButton(5).RootUIComp.Get().SetUIActive(level < this.ActivityBaseData.MaxTravelLevel);
	}

	// Token: 0x06008566 RID: 34150 RVA: 0x001C64AC File Offset: 0x001C46AC
	private void SetLevelProgress(int current, int target)
	{
		this.SetBarProgress((float)current / (float)target);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "MapTravelExpYellow_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			current,
			target
		}));
		base.GetText(3).SetUIActive(true);
	}

	// Token: 0x06008567 RID: 34151 RVA: 0x001C6504 File Offset: 0x001C4704
	private void SetBarProgress(float percent)
	{
		float num = MathUtils.Instance.Clamp(percent, 0f, 1f);
		base.GetTexture(2).SetFillAmount(num);
		float yaw = (1f - num) * 360f;
		this.EffectRotator.Yaw = yaw;
		base.GetItem(24).SetUIActive(num > 0.5f);
		base.GetItem(23).SetUIRelativeRotation(this.EffectRotator);
		base.GetItem(24).SetUIRelativeRotation(this.EffectRotator);
	}

	// Token: 0x06008568 RID: 34152 RVA: 0x001C658C File Offset: 0x001C478C
	private void SetPerformanceFinishedLevel(int level)
	{
		IMapTravelLevelData mapTravelLevelData = this.ActivityBaseData.TravelLevelData[level];
		int targetExp = mapTravelLevelData.TargetExp;
		int targetExp2 = mapTravelLevelData.TargetExp;
		this.SetLevelProgress(targetExp, targetExp2);
		this.PanelLock.SetUiActive(false);
		this.PanelActivate.SetUiActive(true);
		this.LevelUpButton.SetUiActive(false);
		this.PanelActivate.SetTextByTextId("MapTravelReward_Get", Array.Empty<string>());
	}

	// Token: 0x06008569 RID: 34153 RVA: 0x001C65F8 File Offset: 0x001C47F8
	private void SetPerformanceCurrentLevel(int level)
	{
		bool flag = this.ActivityBaseData.MaxTravelLevel == level;
		bool flag2 = !flag && this.ActivityBaseData.CanTravelLevelUp();
		int currentExp = this.ActivityBaseData.GetCurrentExp();
		int currentTargetExp = this.ActivityBaseData.GetCurrentTargetExp();
		if (flag)
		{
			this.SetBarProgress(1f);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "MapTravelLevelMaxYellow_Text", Array.Empty<object>());
			base.GetText(3).SetUIActive(true);
		}
		else
		{
			this.SetLevelProgress(currentExp, currentTargetExp);
		}
		this.PanelLock.SetUiActive(!flag && !flag2);
		this.PanelLock.SetTextByTextId("PrefabTextItem_2462272635_Text", Array.Empty<string>());
		this.PanelActivate.SetUiActive(flag);
		this.LevelUpButton.SetUiActive(flag2);
		if (flag)
		{
			this.PanelActivate.SetTextByTextId("MapTravelLv_Max", Array.Empty<string>());
		}
		if (flag2)
		{
			this.UiViewSequence.PlaySequence("PreLevelUp", false, null);
		}
	}

	// Token: 0x0600856A RID: 34154 RVA: 0x001C66F8 File Offset: 0x001C48F8
	private void SetPerformanceUnFinishedLevel(int level)
	{
		IMapTravelLevelData mapTravelLevelData = this.ActivityBaseData.TravelLevelData[level];
		bool flag = this.ActivityBaseData.MaxTravelLevel == level;
		int current = 0;
		int target = flag ? mapTravelLevelData.AccumulateExp : mapTravelLevelData.TargetExp;
		if (flag)
		{
			this.SetBarProgress(0f);
			base.GetText(3).SetUIActive(false);
		}
		else
		{
			this.SetLevelProgress(current, target);
		}
		this.PanelLock.SetUiActive(true);
		this.PanelLock.SetTextByTextId("MapTravelLevelOverUp_Text", Array.Empty<string>());
		this.PanelActivate.SetUiActive(false);
		this.LevelUpButton.SetUiActive(false);
	}

	// Token: 0x0600856B RID: 34155 RVA: 0x001C6798 File Offset: 0x001C4998
	private void OnClickedPreLevelButton()
	{
		this.SelectedLevel--;
		this.UiViewSequence.PlaySequence("SwitchLeft", true, null);
	}

	// Token: 0x0600856C RID: 34156 RVA: 0x001C67D0 File Offset: 0x001C49D0
	private void OnClickedNextLevelButton()
	{
		this.SelectedLevel++;
		this.UiViewSequence.PlaySequence("SwitchRight", true, null);
	}

	// Token: 0x0600856D RID: 34157 RVA: 0x001C6805 File Offset: 0x001C4A05
	private void OnClickedLevelUpButton()
	{
		ActivityMapTravelController.Instance.RequestMapTravelLevelUp(delegate(bool success)
		{
			this.NeedLevelUp = success;
		});
	}

	// Token: 0x0600856E RID: 34158 RVA: 0x001C6820 File Offset: 0x001C4A20
	private void LevelUp()
	{
		if (this.NeedLevelUp)
		{
			this.UiViewSequence.PlaySequence("LevelUp", false, null);
			this.SelectedLevel++;
			this.RefreshExpComponent(this.SelectedLevel);
			this.RefreshSubViewButton();
		}
	}

	// Token: 0x0600856F RID: 34159 RVA: 0x001C6870 File Offset: 0x001C4A70
	private void OnRewardViewClose(EUiViewName viewName, int ViewId)
	{
		if (this.SelectedViewType != EMapTravelSubType.Main)
		{
			return;
		}
		if (viewName == EUiViewName.CommonRewardView)
		{
			if (this.CurrentRewardSoarStrengthCount > 0)
			{
				this.OpenSoarStrengthView();
			}
			else
			{
				this.LevelUp();
			}
		}
		if (viewName == EUiViewName.RoleLevelUpSuccessAttributeView)
		{
			this.LevelUp();
		}
	}

	// Token: 0x06008570 RID: 34160 RVA: 0x001C68C0 File Offset: 0x001C4AC0
	private void OpenSoarStrengthView()
	{
		int value = ConfigCommonParamById.GetIntConfig("FlyStrengthItemId").Value;
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(value);
		if (itemConfig == null || itemConfig.Value.ParametersLength == 0)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		if (num2 < itemConfig.Value.ParametersLength)
		{
			num = itemConfig.Value.Parameters(num2).Value.Value;
		}
		if (num == 0)
		{
			return;
		}
		PropRewardConf? config = ConfigPropRewardConfById.GetConfig(num, true);
		if (config == null)
		{
			return;
		}
		float num3 = 0f;
		for (int i = 0; i < config.Value.PropsLength; i++)
		{
			ConfigPropValue value2 = config.Value.Props(i).Value;
			if (value2.Id == 10)
			{
				num3 = value2.Value;
				break;
			}
		}
		if (num3 == 0f)
		{
			return;
		}
		num3 *= (float)this.CurrentRewardSoarStrengthCount;
		ActivityMapTravelController.Instance.OpenSoarStrengthView(num3);
	}

	// Token: 0x06008571 RID: 34161 RVA: 0x001C69DC File Offset: 0x001C4BDC
	private void RefreshSubViewButton()
	{
		MapTravelConfig activityConfig = this.ActivityBaseData.GetActivityConfig();
		foreach (KeyValuePair<EMapTravelSubType, MapTravelSubViewButton> keyValuePair in this.SubViewButtonMap)
		{
			EMapTravelSubType emapTravelSubType;
			MapTravelSubViewButton mapTravelSubViewButton;
			keyValuePair.Deconstruct(out emapTravelSubType, out mapTravelSubViewButton);
			EMapTravelSubType emapTravelSubType2 = emapTravelSubType;
			MapTravelSubViewButton mapTravelSubViewButton2 = mapTravelSubViewButton;
			ValueTuple<int, int> typeProgress = this.ActivityBaseData.GetTypeProgress(emapTravelSubType2);
			int item = typeProgress.Item1;
			int item2 = typeProgress.Item2;
			double value = Math.Ceiling((double)((float)item / (float)item2 * 100f));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(value);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			mapTravelSubViewButton2.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
			mapTravelSubViewButton2.SetProgressTextChangeColor(item != item2);
			mapTravelSubViewButton2.SetNameTextId(activityConfig.GetTabName((int)emapTravelSubType2));
			bool typeRedDotState = this.ActivityBaseData.GetTypeRedDotState(emapTravelSubType2);
			bool typeNewState = this.ActivityBaseData.GetTypeNewState(emapTravelSubType2);
			mapTravelSubViewButton2.SetItemNew(!typeRedDotState && typeNewState);
			mapTravelSubViewButton2.RefreshRedDot(typeRedDotState);
			mapTravelSubViewButton2.SetItemDone(item == item2);
		}
	}

	// Token: 0x06008572 RID: 34162 RVA: 0x001C6B00 File Offset: 0x001C4D00
	protected void OnOpenSubView(EMapTravelSubType type)
	{
		this.StartSubView(type);
	}

	// Token: 0x06008573 RID: 34163 RVA: 0x001C6B0C File Offset: 0x001C4D0C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<IMapTravelViewProxy> GetSubViewProxy(EMapTravelSubType type)
	{
		MapTravelMainView.<GetSubViewProxy>d__49 <GetSubViewProxy>d__;
		<GetSubViewProxy>d__.<>t__builder = AsyncUniTaskMethodBuilder<IMapTravelViewProxy>.Create();
		<GetSubViewProxy>d__.<>4__this = this;
		<GetSubViewProxy>d__.type = type;
		<GetSubViewProxy>d__.<>1__state = -1;
		<GetSubViewProxy>d__.<>t__builder.Start<MapTravelMainView.<GetSubViewProxy>d__49>(ref <GetSubViewProxy>d__);
		return <GetSubViewProxy>d__.<>t__builder.Task;
	}

	// Token: 0x06008574 RID: 34164 RVA: 0x001C6B58 File Offset: 0x001C4D58
	private UniTask StartSubView(EMapTravelSubType type)
	{
		MapTravelMainView.<StartSubView>d__50 <StartSubView>d__;
		<StartSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartSubView>d__.<>4__this = this;
		<StartSubView>d__.type = type;
		<StartSubView>d__.<>1__state = -1;
		<StartSubView>d__.<>t__builder.Start<MapTravelMainView.<StartSubView>d__50>(ref <StartSubView>d__);
		return <StartSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06008575 RID: 34165 RVA: 0x001C6BA4 File Offset: 0x001C4DA4
	private UniTask CloseSubView()
	{
		MapTravelMainView.<CloseSubView>d__51 <CloseSubView>d__;
		<CloseSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseSubView>d__.<>4__this = this;
		<CloseSubView>d__.<>1__state = -1;
		<CloseSubView>d__.<>t__builder.Start<MapTravelMainView.<CloseSubView>d__51>(ref <CloseSubView>d__);
		return <CloseSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06008576 RID: 34166 RVA: 0x001C6BE8 File Offset: 0x001C4DE8
	private void PlayTween(EMapTravelSubType type, bool isOpen)
	{
		List<ULGUIPlayTweenComponent> list = (from component in (isOpen ? base.GetItem(20) : base.GetItem(21)).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass())
		select component as ULGUIPlayTweenComponent).ToList<ULGUIPlayTweenComponent>();
		int[] array = isOpen ? this.openTweenGroupDefine : this.closeTweenGroupDefine;
		for (int i = 0; i < list.Count; i++)
		{
			ULGUIPlayTweenComponent ulguiplayTweenComponent = list[i];
			int num = array[i];
			if (num != 0)
			{
				if (num == 1)
				{
					ULGUIPlayTween_Vector3 tween = ulguiplayTweenComponent.GetPlayTween() as ULGUIPlayTween_Vector3;
					FVector location = this.SubViewButtonMap[type].GetIconItem().K2_GetComponentLocation();
					if (isOpen)
					{
						this.SetTweenLocation(tween, location, true);
						this.SetTweenLocation(tween, this.BgLocation.Value, false);
					}
					else
					{
						this.SetTweenLocation(tween, this.BgLocation.Value, true);
						this.SetTweenLocation(tween, location, false);
					}
				}
			}
			else
			{
				ULGUIPlayTween_Vector3 tween2 = ulguiplayTweenComponent.GetPlayTween() as ULGUIPlayTween_Vector3;
				this.SetTweenLocation(tween2, new FVector(this.BgScale, this.BgScale, this.BgScale), !isOpen);
			}
			ulguiplayTweenComponent.Stop();
			ulguiplayTweenComponent.Play();
		}
	}

	// Token: 0x06008577 RID: 34167 RVA: 0x001C6D30 File Offset: 0x001C4F30
	private void SetTweenLocation(ULGUIPlayTween_Vector3 tween, FVector location, bool isFrom)
	{
		if (isFrom)
		{
			tween.from = location;
			return;
		}
		tween.to = location;
	}

	// Token: 0x04003BCE RID: 15310
	private const float SPINE_PLAY_TIME_SCALE = 1.5f;

	// Token: 0x04003BCF RID: 15311
	private readonly int[] openTweenGroupDefine = new int[]
	{
		0,
		-1,
		-1,
		1
	};

	// Token: 0x04003BD0 RID: 15312
	private readonly int[] closeTweenGroupDefine = new int[]
	{
		1,
		-1,
		0,
		-1
	};

	// Token: 0x04003BD1 RID: 15313
	private const int SPINE_LAYER_WIDTH = 2520;

	// Token: 0x04003BD2 RID: 15314
	[Nullable(2)]
	private PopupCaptionItem CaptionComponent;

	// Token: 0x04003BD3 RID: 15315
	[Nullable(2)]
	private LevelSequencePlayer CaptionSequencePlayer;

	// Token: 0x04003BD4 RID: 15316
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivitySmallItemGrid, IItemGridData> LevelRewardLayout;

	// Token: 0x04003BD5 RID: 15317
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04003BD6 RID: 15318
	[Nullable(2)]
	private FunctionalPanelConditionActivate PanelActivate;

	// Token: 0x04003BD7 RID: 15319
	[Nullable(2)]
	private ActivityButtonItem LevelUpButton;

	// Token: 0x04003BD8 RID: 15320
	private readonly Dictionary<EMapTravelSubType, MapTravelSubViewButton> SubViewButtonMap = new Dictionary<EMapTravelSubType, MapTravelSubViewButton>();

	// Token: 0x04003BD9 RID: 15321
	protected readonly Dictionary<EMapTravelSubType, IMapTravelViewProxy> SubViewProxyMap = new Dictionary<EMapTravelSubType, IMapTravelViewProxy>();

	// Token: 0x04003BDA RID: 15322
	protected ActivityMapTravelData ActivityBaseData;

	// Token: 0x04003BDB RID: 15323
	private EMapTravelSubType SelectedViewType;

	// Token: 0x04003BDC RID: 15324
	private int SelectedLevel = -1;

	// Token: 0x04003BDD RID: 15325
	private bool NeedLevelUp;

	// Token: 0x04003BDE RID: 15326
	private int CurrentRewardSoarStrengthCount;

	// Token: 0x04003BDF RID: 15327
	private FRotator EffectRotator = new FRotator(0f, 0f, 0f);

	// Token: 0x04003BE0 RID: 15328
	protected float BgOffset;

	// Token: 0x04003BE1 RID: 15329
	protected float BgScale = 1f;

	// Token: 0x04003BE2 RID: 15330
	protected FVector? BgLocation;

	// Token: 0x020078F9 RID: 30969
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027DA0 RID: 163232
		public const int CaptionItem = 0;

		// Token: 0x04027DA1 RID: 163233
		public const int TxtLevel = 1;

		// Token: 0x04027DA2 RID: 163234
		public const int TexExpProgress = 2;

		// Token: 0x04027DA3 RID: 163235
		public const int TxtExpProgress = 3;

		// Token: 0x04027DA4 RID: 163236
		public const int BtnLevelLeft = 4;

		// Token: 0x04027DA5 RID: 163237
		public const int BtnLevelRight = 5;

		// Token: 0x04027DA6 RID: 163238
		public const int LevelRewardItem = 6;

		// Token: 0x04027DA7 RID: 163239
		public const int LevelRewardLayout = 7;

		// Token: 0x04027DA8 RID: 163240
		public const int LevelRewardGrid = 8;

		// Token: 0x04027DA9 RID: 163241
		public const int LevelTipsItem = 9;

		// Token: 0x04027DAA RID: 163242
		public const int TxtLevelTips = 10;

		// Token: 0x04027DAB RID: 163243
		public const int BtnLevelUp = 11;

		// Token: 0x04027DAC RID: 163244
		public const int PanelActive = 12;

		// Token: 0x04027DAD RID: 163245
		public const int PanelLock = 13;

		// Token: 0x04027DAE RID: 163246
		public const int SubView1 = 14;

		// Token: 0x04027DAF RID: 163247
		public const int SubView2 = 15;

		// Token: 0x04027DB0 RID: 163248
		public const int SubView3 = 16;

		// Token: 0x04027DB1 RID: 163249
		public const int SubView4 = 17;

		// Token: 0x04027DB2 RID: 163250
		public const int SubViewContent = 18;

		// Token: 0x04027DB3 RID: 163251
		public const int TexIcon = 19;

		// Token: 0x04027DB4 RID: 163252
		public const int AniOpen = 20;

		// Token: 0x04027DB5 RID: 163253
		public const int AniClose = 21;

		// Token: 0x04027DB6 RID: 163254
		public const int SpineBook = 22;

		// Token: 0x04027DB7 RID: 163255
		public const int BarEffectRight = 23;

		// Token: 0x04027DB8 RID: 163256
		public const int BarEffectLeft = 24;

		// Token: 0x04027DB9 RID: 163257
		public const int AnchorLeft = 25;

		// Token: 0x04027DBA RID: 163258
		public const int BgItem = 26;

		// Token: 0x04027DBB RID: 163259
		public const int SpineItem = 27;
	}

	// Token: 0x020078FA RID: 30970
	[NullableContext(0)]
	private class ETweenType
	{
		// Token: 0x04027DBC RID: 163260
		public const int None = -1;

		// Token: 0x04027DBD RID: 163261
		public const int SpineScale = 0;

		// Token: 0x04027DBE RID: 163262
		public const int SpineLocation = 1;
	}
}
