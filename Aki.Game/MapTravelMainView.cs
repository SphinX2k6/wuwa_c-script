using System;
using System.Collections.Generic;
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

// Token: 0x02000798 RID: 1944
[NullableContext(1)]
[Nullable(0)]
public class MapTravelMainView : UiViewBase
{
	// Token: 0x060058F4 RID: 22772 RVA: 0x001CE9D8 File Offset: 0x001CCBD8
	public MapTravelMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x001CEA5C File Offset: 0x001CCC5C
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

	// Token: 0x060058F6 RID: 22774 RVA: 0x001CEE94 File Offset: 0x001CD094
	protected override UniTask OnBeforeStartAsync()
	{
		MapTravelMainView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelMainView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060058F7 RID: 22775 RVA: 0x001CEED8 File Offset: 0x001CD0D8
	private UniTask CreateSubViewButton()
	{
		MapTravelMainView.<CreateSubViewButton>d__26 <CreateSubViewButton>d__;
		<CreateSubViewButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateSubViewButton>d__.<>4__this = this;
		<CreateSubViewButton>d__.<>1__state = -1;
		<CreateSubViewButton>d__.<>t__builder.Start<MapTravelMainView.<CreateSubViewButton>d__26>(ref <CreateSubViewButton>d__);
		return <CreateSubViewButton>d__.<>t__builder.Task;
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x001CEF1C File Offset: 0x001CD11C
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

	// Token: 0x060058F9 RID: 22777 RVA: 0x001CF01D File Offset: 0x001CD21D
	protected override void OnBeforeShow()
	{
		this.RefreshMainView();
	}

	// Token: 0x060058FA RID: 22778 RVA: 0x001CF025 File Offset: 0x001CD225
	protected override void OnBeforeDestroy()
	{
		this.BgLocation = null;
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x001CF033 File Offset: 0x001CD233
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x001CF06A File Offset: 0x001CD26A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x001CF0A1 File Offset: 0x001CD2A1
	private void RefreshMainView()
	{
		this.RefreshExpComponent(this.SelectedLevel);
		this.RefreshSubViewButton();
	}

	// Token: 0x060058FE RID: 22782 RVA: 0x001CF0B5 File Offset: 0x001CD2B5
	private void CloseButtonClicked()
	{
		if (this.SelectedViewType == EMapTravelSubType.Main)
		{
			base.CloseMe(null);
			return;
		}
		this.CloseSubView();
	}

	// Token: 0x060058FF RID: 22783 RVA: 0x001CF0CE File Offset: 0x001CD2CE
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "LevelChange")
		{
			this.RefreshExpComponent(this.SelectedLevel);
		}
	}

	// Token: 0x06005900 RID: 22784 RVA: 0x001CF0EC File Offset: 0x001CD2EC
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

	// Token: 0x06005901 RID: 22785 RVA: 0x001CF308 File Offset: 0x001CD508
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

	// Token: 0x06005902 RID: 22786 RVA: 0x001CF360 File Offset: 0x001CD560
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

	// Token: 0x06005903 RID: 22787 RVA: 0x001CF3E8 File Offset: 0x001CD5E8
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

	// Token: 0x06005904 RID: 22788 RVA: 0x001CF454 File Offset: 0x001CD654
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

	// Token: 0x06005905 RID: 22789 RVA: 0x001CF554 File Offset: 0x001CD754
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

	// Token: 0x06005906 RID: 22790 RVA: 0x001CF5F4 File Offset: 0x001CD7F4
	private void OnClickedPreLevelButton()
	{
		this.SelectedLevel--;
		this.UiViewSequence.PlaySequence("SwitchLeft", true, null);
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x001CF62C File Offset: 0x001CD82C
	private void OnClickedNextLevelButton()
	{
		this.SelectedLevel++;
		this.UiViewSequence.PlaySequence("SwitchRight", true, null);
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x001CF661 File Offset: 0x001CD861
	private void OnClickedLevelUpButton()
	{
		ActivityMapTravelController.Instance.RequestMapTravelLevelUp(delegate(bool success)
		{
			this.NeedLevelUp = success;
		});
	}

	// Token: 0x06005909 RID: 22793 RVA: 0x001CF67C File Offset: 0x001CD87C
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

	// Token: 0x0600590A RID: 22794 RVA: 0x001CF6CC File Offset: 0x001CD8CC
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

	// Token: 0x0600590B RID: 22795 RVA: 0x001CF71C File Offset: 0x001CD91C
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

	// Token: 0x0600590C RID: 22796 RVA: 0x001CF838 File Offset: 0x001CDA38
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

	// Token: 0x0600590D RID: 22797 RVA: 0x001CF95C File Offset: 0x001CDB5C
	protected void OnOpenSubView(EMapTravelSubType type)
	{
		this.StartSubView(type);
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x001CF968 File Offset: 0x001CDB68
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

	// Token: 0x0600590F RID: 22799 RVA: 0x001CF9B4 File Offset: 0x001CDBB4
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

	// Token: 0x06005910 RID: 22800 RVA: 0x001CFA00 File Offset: 0x001CDC00
	private UniTask CloseSubView()
	{
		MapTravelMainView.<CloseSubView>d__51 <CloseSubView>d__;
		<CloseSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseSubView>d__.<>4__this = this;
		<CloseSubView>d__.<>1__state = -1;
		<CloseSubView>d__.<>t__builder.Start<MapTravelMainView.<CloseSubView>d__51>(ref <CloseSubView>d__);
		return <CloseSubView>d__.<>t__builder.Task;
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x001CFA44 File Offset: 0x001CDC44
	private void PlayTween(EMapTravelSubType type, bool isOpen)
	{
		TArray<UActorComponent> tarray = (isOpen ? base.GetItem(20) : base.GetItem(21)).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
		List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(tarray.Num());
		for (int i = 0; i < tarray.Num(); i++)
		{
			list.Add(tarray.Get(i) as ULGUIPlayTweenComponent);
		}
		int[] array = isOpen ? this.openTweenGroupDefine : this.closeTweenGroupDefine;
		for (int j = 0; j < list.Count; j++)
		{
			ULGUIPlayTweenComponent ulguiplayTweenComponent = list[j];
			int num = array[j];
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

	// Token: 0x06005912 RID: 22802 RVA: 0x001CFB9D File Offset: 0x001CDD9D
	private void SetTweenLocation(ULGUIPlayTween_Vector3 tween, FVector location, bool isFrom)
	{
		if (isFrom)
		{
			tween.from = location;
			return;
		}
		tween.to = location;
	}

	// Token: 0x04003C66 RID: 15462
	private const float SPINE_PLAY_TIME_SCALE = 1.5f;

	// Token: 0x04003C67 RID: 15463
	private readonly int[] openTweenGroupDefine = new int[]
	{
		0,
		-1,
		-1,
		1
	};

	// Token: 0x04003C68 RID: 15464
	private readonly int[] closeTweenGroupDefine = new int[]
	{
		1,
		-1,
		0,
		-1
	};

	// Token: 0x04003C69 RID: 15465
	private const int SPINE_LAYER_WIDTH = 2520;

	// Token: 0x04003C6A RID: 15466
	[Nullable(2)]
	private PopupCaptionItem CaptionComponent;

	// Token: 0x04003C6B RID: 15467
	[Nullable(2)]
	private LevelSequencePlayer CaptionSequencePlayer;

	// Token: 0x04003C6C RID: 15468
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivitySmallItemGrid, IItemGridData> LevelRewardLayout;

	// Token: 0x04003C6D RID: 15469
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04003C6E RID: 15470
	[Nullable(2)]
	private FunctionalPanelConditionActivate PanelActivate;

	// Token: 0x04003C6F RID: 15471
	[Nullable(2)]
	private ActivityButtonItem LevelUpButton;

	// Token: 0x04003C70 RID: 15472
	private readonly Dictionary<EMapTravelSubType, MapTravelSubViewButton> SubViewButtonMap = new Dictionary<EMapTravelSubType, MapTravelSubViewButton>();

	// Token: 0x04003C71 RID: 15473
	protected readonly Dictionary<EMapTravelSubType, IMapTravelViewProxy> SubViewProxyMap = new Dictionary<EMapTravelSubType, IMapTravelViewProxy>();

	// Token: 0x04003C72 RID: 15474
	protected ActivityMapTravelData ActivityBaseData;

	// Token: 0x04003C73 RID: 15475
	private EMapTravelSubType SelectedViewType;

	// Token: 0x04003C74 RID: 15476
	private int SelectedLevel = -1;

	// Token: 0x04003C75 RID: 15477
	private bool NeedLevelUp;

	// Token: 0x04003C76 RID: 15478
	private int CurrentRewardSoarStrengthCount;

	// Token: 0x04003C77 RID: 15479
	private FRotator EffectRotator = new FRotator(0f, 0f, 0f);

	// Token: 0x04003C78 RID: 15480
	protected float BgOffset;

	// Token: 0x04003C79 RID: 15481
	protected float BgScale = 1f;

	// Token: 0x04003C7A RID: 15482
	protected FVector? BgLocation;

	// Token: 0x02006A83 RID: 27267
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040230CE RID: 143566
		public const int CaptionItem = 0;

		// Token: 0x040230CF RID: 143567
		public const int TxtLevel = 1;

		// Token: 0x040230D0 RID: 143568
		public const int TexExpProgress = 2;

		// Token: 0x040230D1 RID: 143569
		public const int TxtExpProgress = 3;

		// Token: 0x040230D2 RID: 143570
		public const int BtnLevelLeft = 4;

		// Token: 0x040230D3 RID: 143571
		public const int BtnLevelRight = 5;

		// Token: 0x040230D4 RID: 143572
		public const int LevelRewardItem = 6;

		// Token: 0x040230D5 RID: 143573
		public const int LevelRewardLayout = 7;

		// Token: 0x040230D6 RID: 143574
		public const int LevelRewardGrid = 8;

		// Token: 0x040230D7 RID: 143575
		public const int LevelTipsItem = 9;

		// Token: 0x040230D8 RID: 143576
		public const int TxtLevelTips = 10;

		// Token: 0x040230D9 RID: 143577
		public const int BtnLevelUp = 11;

		// Token: 0x040230DA RID: 143578
		public const int PanelActive = 12;

		// Token: 0x040230DB RID: 143579
		public const int PanelLock = 13;

		// Token: 0x040230DC RID: 143580
		public const int SubView1 = 14;

		// Token: 0x040230DD RID: 143581
		public const int SubView2 = 15;

		// Token: 0x040230DE RID: 143582
		public const int SubView3 = 16;

		// Token: 0x040230DF RID: 143583
		public const int SubView4 = 17;

		// Token: 0x040230E0 RID: 143584
		public const int SubViewContent = 18;

		// Token: 0x040230E1 RID: 143585
		public const int TexIcon = 19;

		// Token: 0x040230E2 RID: 143586
		public const int AniOpen = 20;

		// Token: 0x040230E3 RID: 143587
		public const int AniClose = 21;

		// Token: 0x040230E4 RID: 143588
		public const int SpineBook = 22;

		// Token: 0x040230E5 RID: 143589
		public const int BarEffectRight = 23;

		// Token: 0x040230E6 RID: 143590
		public const int BarEffectLeft = 24;

		// Token: 0x040230E7 RID: 143591
		public const int AnchorLeft = 25;

		// Token: 0x040230E8 RID: 143592
		public const int BgItem = 26;

		// Token: 0x040230E9 RID: 143593
		public const int SpineItem = 27;
	}

	// Token: 0x02006A84 RID: 27268
	[NullableContext(0)]
	private class ETweenType
	{
		// Token: 0x040230EA RID: 143594
		public const int None = -1;

		// Token: 0x040230EB RID: 143595
		public const int SpineScale = 0;

		// Token: 0x040230EC RID: 143596
		public const int SpineLocation = 1;
	}
}
