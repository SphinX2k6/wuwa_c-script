using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E0F RID: 7695
[NullableContext(1)]
[Nullable(0)]
public class RoleLevelUpView : UiViewBase
{
	// Token: 0x06013016 RID: 77846 RVA: 0x0058E7D9 File Offset: 0x0058C9D9
	public RoleLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013017 RID: 77847 RVA: 0x0058E7F0 File Offset: 0x0058C9F0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06013018 RID: 77848 RVA: 0x0058E860 File Offset: 0x0058CA60
	protected void CloseClick()
	{
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
	}

	// Token: 0x06013019 RID: 77849 RVA: 0x0058E874 File Offset: 0x0058CA74
	protected override UniTask OnBeforeStartAsync()
	{
		RoleLevelUpView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleLevelUpView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601301A RID: 77850 RVA: 0x0058E8B8 File Offset: 0x0058CAB8
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleLevelUpView.<OnPlayingStartSequenceAsync>d__14 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleLevelUpView.<OnPlayingStartSequenceAsync>d__14>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601301B RID: 77851 RVA: 0x0058E8FC File Offset: 0x0058CAFC
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleLevelUpView.<OnPlayingCloseSequenceAsync>d__15 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleLevelUpView.<OnPlayingCloseSequenceAsync>d__15>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601301C RID: 77852 RVA: 0x0058E93F File Offset: 0x0058CB3F
	protected override void OnHandleLoadScene()
	{
		this.ViewModel.HandleLoadScene(delegate
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
		});
	}

	// Token: 0x0601301D RID: 77853 RVA: 0x0058E96B File Offset: 0x0058CB6B
	protected override void OnHandleReleaseScene()
	{
		this.ViewModel.HandleReleaseScene();
	}

	// Token: 0x0601301E RID: 77854 RVA: 0x0058E978 File Offset: 0x0058CB78
	private void InitDataList()
	{
		this.DataList = new List<ISelectedData>().ToArray();
		ItemInfo[] roleCostExpList = RoleModel.Instance.GetRoleCostExpList();
		List<ISelectedData> list = new List<ISelectedData>();
		foreach (ItemInfo itemInfo in roleCostExpList)
		{
			SelectedData item = new SelectedData
			{
				IncId = 0,
				ItemId = itemInfo.Id,
				Count = InventoryModel.Instance.GetCommonItemCount(itemInfo.Id, 0),
				SelectedCount = 0
			};
			list.Add(item);
		}
		this.DataList = list.ToArray();
		this.RoleExpItemGridComponent.Update(RoleLevelUpView.ArrayToList<ISelectedData>(this.DataList), 2, 0);
	}

	// Token: 0x0601301F RID: 77855 RVA: 0x0058EA24 File Offset: 0x0058CC24
	protected void OnClickItemAdd(int configId)
	{
		ISelectedData[] dataList = this.DataList;
		int i = dataList.Length - 1;
		while (i >= 0)
		{
			ISelectedData selectedData = dataList[i];
			if (selectedData.ItemId == configId)
			{
				if (selectedData.Count == 0)
				{
					ItemController.Instance.OpenItemTipsByItemId(configId, true, null, false);
					return;
				}
				if (this.CheckIsMaxLevel())
				{
					ScrollingTipsController.Instance.ShowTipsById("WeaponAddExpTipsText", Array.Empty<object>());
					return;
				}
				if (selectedData.Count > selectedData.SelectedCount)
				{
					ISelectedData selectedData2 = selectedData;
					int selectedCount = selectedData2.SelectedCount;
					selectedData2.SelectedCount = selectedCount + 1;
					this.RefreshItemAndExp();
					return;
				}
				break;
			}
			else
			{
				i--;
			}
		}
	}

	// Token: 0x06013020 RID: 77856 RVA: 0x0058EAB0 File Offset: 0x0058CCB0
	protected void OnClickItemReduce(int configId)
	{
		ISelectedData[] dataList = this.DataList;
		int i = dataList.Length - 1;
		while (i >= 0)
		{
			ISelectedData selectedData = dataList[i];
			if (selectedData.ItemId == configId)
			{
				if (selectedData.SelectedCount > 0)
				{
					ISelectedData selectedData2 = selectedData;
					int selectedCount = selectedData2.SelectedCount;
					selectedData2.SelectedCount = selectedCount - 1;
					break;
				}
				break;
			}
			else
			{
				i--;
			}
		}
		this.RefreshItemAndExp();
	}

	// Token: 0x06013021 RID: 77857 RVA: 0x0058EB04 File Offset: 0x0058CD04
	private void OnClickAutoFunction()
	{
		EAutoButtonState autoButtonState = this.RoleExpItemGridComponent.GetAutoButtonState();
		ISelectedData[] dataList = this.DataList;
		if (autoButtonState == EAutoButtonState.AutoAdd)
		{
			bool flag = false;
			ISelectedData[] array = dataList;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Count > 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsById("RoleNoMaterial", Array.Empty<object>());
				return;
			}
			int expDistanceToMax = this.CurrentExpData.GetExpDistanceToMax();
			WeaponModel.Instance.AutoAddExpItemEx(expDistanceToMax, dataList, new Func<ISelectedData, int>(this.GetItemExp));
			this.RefreshItemAndExp();
		}
		else if (autoButtonState == EAutoButtonState.Clear)
		{
			ISelectedData[] array = dataList;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SelectedCount = 0;
			}
		}
		this.RefreshItemAndExp();
	}

	// Token: 0x06013022 RID: 77858 RVA: 0x0058EBC0 File Offset: 0x0058CDC0
	private bool CanItemLongPress(int configId)
	{
		ISelectedData[] dataList = this.DataList;
		for (int i = dataList.Length - 1; i >= 0; i--)
		{
			ISelectedData selectedData = dataList[i];
			if (selectedData.ItemId == configId && selectedData.Count > 0 && selectedData.SelectedCount < selectedData.Count && !this.CheckIsMaxLevel())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06013023 RID: 77859 RVA: 0x0058EC14 File Offset: 0x0058CE14
	private bool CanItemReduceLongPress(int configId)
	{
		ISelectedData[] dataList = this.DataList;
		for (int i = dataList.Length - 1; i >= 0; i--)
		{
			ISelectedData selectedData = dataList[i];
			if (selectedData.ItemId == configId && selectedData.SelectedCount <= 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06013024 RID: 77860 RVA: 0x0058EC54 File Offset: 0x0058CE54
	private void RefreshItemAndExp()
	{
		int num = 0;
		ISelectedData[] dataList = this.DataList;
		foreach (ISelectedData selectedData in dataList)
		{
			selectedData.Count = InventoryModel.Instance.GetCommonItemCount(selectedData.ItemId, 0);
		}
		this.RoleExpItemGridComponent.UpdateByDataList(RoleLevelUpView.ArrayToList<ISelectedData>(dataList));
		foreach (ISelectedData selectedData2 in dataList)
		{
			num += this.GetItemExp(selectedData2) * selectedData2.SelectedCount;
		}
		this.CurrentExpData.UpdateExp(num);
		this.ExpComponent.Update(this.CurrentExpData, true);
		int expDistanceToMax = this.CurrentExpData.GetExpDistanceToMax();
		int moneyToLevelUp = RoleModel.Instance.GetMoneyToLevelUp(Math.Min(expDistanceToMax, num));
		this.RoleExpItemGridComponent.UpdateMoney(2, moneyToLevelUp);
		if (num > 0)
		{
			this.RoleExpItemGridComponent.SetAutoButtonText("PrefabTextItem_3035508725_Text");
		}
		else
		{
			this.RoleExpItemGridComponent.SetAutoButtonText("PrefabTextItem_744293929_Text");
		}
		this.UpdateAttribute();
	}

	// Token: 0x06013025 RID: 77861 RVA: 0x0058ED58 File Offset: 0x0058CF58
	private int GetItemExp(ISelectedData data)
	{
		return RoleModel.Instance.GetRoleExpItemExp(data.ItemId).Value;
	}

	// Token: 0x06013026 RID: 77862 RVA: 0x0058ED7D File Offset: 0x0058CF7D
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06013027 RID: 77863 RVA: 0x0058ED84 File Offset: 0x0058CF84
	private void OnExpTweenComplete(bool _)
	{
		this.InitExp();
		this.ResetDataList();
		this.RefreshItemAndExp();
	}

	// Token: 0x06013028 RID: 77864 RVA: 0x0058ED98 File Offset: 0x0058CF98
	private IAttributeInfo[] GetLevelUpAttributeDataList(int currentLevel, int arrivedLevel)
	{
		List<AttributeItem> layoutItemList = this.AttributeLayout.GetLayoutItemList();
		List<IAttributeInfo> list = new List<IAttributeInfo>();
		RoleLevelData levelData = this.RoleInstance.GetLevelData();
		int roleId = this.RoleInstance.GetRoleId();
		int breachLevel = levelData.GetBreachLevel();
		foreach (AttributeItem attributeItem in layoutItemList)
		{
			int attributeId = attributeItem.GetAttributeId();
			int attributeByLevel = RoleModel.Instance.GetAttributeByLevel(roleId, (EAttributeType)attributeId, currentLevel, breachLevel);
			int attributeByLevel2 = RoleModel.Instance.GetAttributeByLevel(roleId, (EAttributeType)attributeId, arrivedLevel, breachLevel);
			if (attributeByLevel != attributeByLevel2)
			{
				IAttributeInfo attributeInfo = RoleLevelUpSuccessController.ConvertsAttrListScrollDataToAttributeInfo(new AttrListScrollData(attributeId, (double)attributeByLevel, (double)attributeByLevel2, 0, false, CommonComponentDefine.EAttributeType.NormalType));
				attributeInfo.Name = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attributeId).Value.AnotherName;
				list.Add(attributeInfo);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06013029 RID: 77865 RVA: 0x0058EE88 File Offset: 0x0058D088
	private void ShowReturnRootReward()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleLevelUp);
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (TItem titem in this.ReceiveItemList)
		{
			InventoryDefine.IGetItemData itemData = titem.ItemData;
			int count = titem.Count;
			RewardItemData item = new RewardItemData(itemData.ItemId, count, new int?(itemData.IncId), EDropItemType.Normal);
			list.Add(item);
		}
		ItemRewardController.Instance.OpenCommonRewardView(1010, list, new Action(this.ReturnRootViewFromReward));
	}

	// Token: 0x0601302A RID: 77866 RVA: 0x0058EF0C File Offset: 0x0058D10C
	private void ShowToBreachReward()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleBreach);
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (TItem titem in this.ReceiveItemList)
		{
			InventoryDefine.IGetItemData itemData = titem.ItemData;
			int count = titem.Count;
			RewardItemData item = new RewardItemData(itemData.ItemId, count, new int?(itemData.IncId), EDropItemType.Normal);
			list.Add(item);
		}
		ItemRewardController.Instance.OpenCommonRewardView(1010, list, new Action(this.TurnToBreachViewFromReward));
	}

	// Token: 0x0601302B RID: 77867 RVA: 0x0058EF8E File Offset: 0x0058D18E
	private int MaxExpFunction(int level)
	{
		return RoleModel.Instance.GetRoleLevelUpExp(this.RoleInstance.GetRoleId(), level + 1);
	}

	// Token: 0x0601302C RID: 77868 RVA: 0x0058EFA8 File Offset: 0x0058D1A8
	private void ReturnRootViewFromReward()
	{
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
	}

	// Token: 0x0601302D RID: 77869 RVA: 0x0058EFBA File Offset: 0x0058D1BA
	private void ReturnRootView()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleLevelUp);
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
	}

	// Token: 0x0601302E RID: 77870 RVA: 0x0058EFD4 File Offset: 0x0058D1D4
	private void TurnToBreachViewFromReward()
	{
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
		roleViewViewModel.FadeInCurveId = this.ViewModel.FadeInCurveId;
		roleViewViewModel.NeedHideOnViewPlayingCloseSequence = this.ViewModel.NeedHideOnViewPlayingCloseSequence;
		this.ViewModel.NeedHideOnViewPlayingCloseSequence = false;
		RoleController.Instance.CloseAndOpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, EUiViewName.RoleBreachView, roleViewViewModel);
	}

	// Token: 0x0601302F RID: 77871 RVA: 0x0058F038 File Offset: 0x0058D238
	private void TurnToBreachView()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleBreach);
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
		roleViewViewModel.FadeInCurveId = this.ViewModel.FadeInCurveId;
		roleViewViewModel.NeedHideOnViewPlayingCloseSequence = this.ViewModel.NeedHideOnViewPlayingCloseSequence;
		this.ViewModel.NeedHideOnViewPlayingCloseSequence = false;
		RoleController.Instance.CloseAndOpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, EUiViewName.RoleBreachView, roleViewViewModel);
	}

	// Token: 0x06013030 RID: 77872 RVA: 0x0058F0A4 File Offset: 0x0058D2A4
	private UniTask Init()
	{
		RoleLevelUpView.<Init>d__36 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<RoleLevelUpView.<Init>d__36>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06013031 RID: 77873 RVA: 0x0058F0E8 File Offset: 0x0058D2E8
	private UniTask InitAttribute()
	{
		RoleLevelUpView.<InitAttribute>d__37 <InitAttribute>d__;
		<InitAttribute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAttribute>d__.<>4__this = this;
		<InitAttribute>d__.<>1__state = -1;
		<InitAttribute>d__.<>t__builder.Start<RoleLevelUpView.<InitAttribute>d__37>(ref <InitAttribute>d__);
		return <InitAttribute>d__.<>t__builder.Task;
	}

	// Token: 0x06013032 RID: 77874 RVA: 0x0058F12B File Offset: 0x0058D32B
	public void InitExp()
	{
		this.UpdateExpData();
		this.ExpComponent.UpdateInitState(this.CurrentExpData);
	}

	// Token: 0x06013033 RID: 77875 RVA: 0x0058F144 File Offset: 0x0058D344
	private void Update()
	{
		this.UpdateAttribute();
		this.UpdateButtonState();
		this.RefreshItemAndExp();
	}

	// Token: 0x06013034 RID: 77876 RVA: 0x0058F158 File Offset: 0x0058D358
	public void ResetDataList()
	{
		foreach (ISelectedData selectedData in this.DataList)
		{
			selectedData.SelectedCount = 0;
			selectedData.Count = InventoryModel.Instance.GetItemCountByConfigId(selectedData.ItemId, 0);
		}
	}

	// Token: 0x06013035 RID: 77877 RVA: 0x0058F19C File Offset: 0x0058D39C
	private void UpdateAttribute()
	{
		foreach (AttributeItem attributeItem in this.AttributeLayout.GetLayoutItemList())
		{
			this.UpdateAttributeItemValue(attributeItem);
		}
	}

	// Token: 0x06013036 RID: 77878 RVA: 0x0058F1F4 File Offset: 0x0058D3F4
	protected void UpdateExpData()
	{
		RoleLevelData levelData = this.RoleInstance.GetLevelData();
		int level = levelData.GetLevel();
		int currentMaxLevel = levelData.GetCurrentMaxLevel();
		int exp = levelData.GetExp();
		int roleMaxLevel = levelData.GetRoleMaxLevel();
		this.CurrentExpData.UpdateComponent(level, currentMaxLevel, exp, new int?(roleMaxLevel), false);
	}

	// Token: 0x06013037 RID: 77879 RVA: 0x0058F23C File Offset: 0x0058D43C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleInfoUpdate, new Action<int>(this.RoleInfoUpdate));
		EventSystem.Instance.Add<IReadOnlyList<TItem>>(EEventName.RoleLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.RoleLevelUpReceiveItem));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06013038 RID: 77880 RVA: 0x0058F2A0 File Offset: 0x0058D4A0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleInfoUpdate, new Action<int>(this.RoleInfoUpdate));
		EventSystem.Instance.Remove(EEventName.RoleLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.RoleLevelUpReceiveItem));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06013039 RID: 77881 RVA: 0x0058F301 File Offset: 0x0058D501
	private void RoleInfoUpdate(int roleId)
	{
		this.OnLevelUpSuccess();
		this.ExpComponent.PlayExpTween(this.CurrentExpData);
	}

	// Token: 0x0601303A RID: 77882 RVA: 0x0058F31C File Offset: 0x0058D51C
	private void OnLevelUpSuccess()
	{
		int currentLevel = this.CurrentExpData.GetCurrentLevel();
		RoleLevelData levelData = this.RoleInstance.GetLevelData();
		int level = levelData.GetLevel();
		if (level == currentLevel)
		{
			return;
		}
		this.UpdateAttribute();
		bool flag = this.ReceiveItemList != null && this.ReceiveItemList.Length != 0;
		IAttributeInfo[] levelUpAttributeDataList = this.GetLevelUpAttributeDataList(currentLevel, level);
		ILevelUpSuccessAttributeData data = null;
		if (levelData.GetRoleIsMaxLevel())
		{
			data = new LevelUpSuccessAttributeData
			{
				LevelInfo = new LevelInfo
				{
					PreUpgradeLv = currentLevel,
					UpgradeLv = level,
					FormatStringId = "Text_LevelShow_Text",
					IsMaxLevel = new bool?(true)
				},
				AttributeInfo = RoleLevelUpView.ArrayToList<IAttributeInfo>(levelUpAttributeDataList)
			};
			if (!flag)
			{
				data.ClickFunction = new Action(this.ReturnRootView);
			}
			else
			{
				data.ClickFunction = new Action(this.ShowReturnRootReward);
			}
		}
		else if (levelData.GetRoleNeedBreakUp())
		{
			data = new LevelUpSuccessAttributeData
			{
				LevelInfo = new LevelInfo
				{
					PreUpgradeLv = currentLevel,
					UpgradeLv = level,
					FormatStringId = "Text_LevelShow_Text",
					IsMaxLevel = new bool?(true)
				},
				ClickText = "Text_TurnToRoleBreach_Text",
				AttributeInfo = RoleLevelUpView.ArrayToList<IAttributeInfo>(levelUpAttributeDataList)
			};
			if (!flag)
			{
				data.ClickFunction = new Action(this.TurnToBreachView);
			}
			else
			{
				data.ClickFunction = new Action(this.ShowToBreachReward);
			}
		}
		else
		{
			data = new LevelUpSuccessAttributeData
			{
				LevelInfo = new LevelInfo
				{
					PreUpgradeLv = currentLevel,
					UpgradeLv = level,
					FormatStringId = "Text_LevelShow_Text"
				},
				AttributeInfo = RoleLevelUpView.ArrayToList<IAttributeInfo>(levelUpAttributeDataList)
			};
		}
		if (data == null)
		{
			return;
		}
		int? roleLevelUpSuccessDelayTime = RoleConfig.Instance.GetRoleLevelUpSuccessDelayTime();
		UiLayer.Instance.SetShowMaskLayer("OpenLevelUpSuccessView", true);
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(data, null);
			UiLayer.Instance.SetShowMaskLayer("OpenLevelUpSuccessView", false);
		}, (float)roleLevelUpSuccessDelayTime.Value, null, null, true, 1f);
	}

	// Token: 0x0601303B RID: 77883 RVA: 0x0058F52C File Offset: 0x0058D72C
	private void RoleLevelUpReceiveItem(IReadOnlyList<TItem> itemList)
	{
		this.ReceiveItemList = itemList.ToArray<TItem>();
	}

	// Token: 0x0601303C RID: 77884 RVA: 0x0058F53A File Offset: 0x0058D73A
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.Update();
	}

	// Token: 0x0601303D RID: 77885 RVA: 0x0058F544 File Offset: 0x0058D744
	private static List<T> ArrayToList<[Nullable(2)] T>(T[] source)
	{
		List<T> list = new List<T>(source.Length);
		for (int i = 0; i < source.Length; i++)
		{
			list.Add(source[i]);
		}
		return list;
	}

	// Token: 0x0601303E RID: 77886 RVA: 0x0058F578 File Offset: 0x0058D778
	private bool CheckIsMaxLevel()
	{
		int arrivedLevel = this.CurrentExpData.GetArrivedLevel();
		int currentMaxLevel = this.RoleInstance.GetLevelData().GetCurrentMaxLevel();
		return arrivedLevel >= currentMaxLevel;
	}

	// Token: 0x0601303F RID: 77887 RVA: 0x0058F5A8 File Offset: 0x0058D7A8
	private void LevelUpClick()
	{
		ISelectedData[] dataList = this.DataList;
		bool flag = false;
		ISelectedData[] array = dataList;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].SelectedCount > 0)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponSelectMaterialTipsText", Array.Empty<object>());
			return;
		}
		if (!this.RoleExpItemGridComponent.GetIsMoneyEnough())
		{
			ScrollingTipsController.Instance.ShowTipsById("RoleNoMoney", Array.Empty<object>());
			return;
		}
		List<ArrayIntInt> itemList = new List<ArrayIntInt>();
		foreach (ISelectedData selectedData in dataList)
		{
			if (selectedData.SelectedCount > 0)
			{
				ArrayIntInt arrayIntInt = ArrayIntInt.Create();
				arrayIntInt.Key = selectedData.ItemId;
				arrayIntInt.Value = selectedData.SelectedCount;
				itemList.Add(arrayIntInt);
			}
		}
		int overExp = this.CurrentExpData.GetOverExp();
		if (overExp <= 0)
		{
			RoleController.Instance.SendPbUpLevelRoleRequest(this.RoleInstance.GetRoleId(), itemList.ToArray(), delegate
			{
				UiRoleUtils.PlayRoleLevelUpEffect(this.ViewModel.TsUiSceneRoleActor);
			});
			return;
		}
		Dictionary<int, int> dictionary = RoleModel.Instance.CalculateExpBackItem(overExp);
		if (dictionary.Count > 0)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeaponOverflowExpTip);
			confirmBoxDataNew.ItemIdMap = dictionary;
			Action <>9__3;
			Action value = delegate()
			{
				RoleController instance = RoleController.Instance;
				int roleId = this.RoleInstance.GetRoleId();
				ArrayIntInt[] itemList = itemList.ToArray();
				Action successCallback;
				if ((successCallback = <>9__3) == null)
				{
					successCallback = (<>9__3 = delegate()
					{
						UiRoleUtils.PlayRoleLevelUpEffect(this.ViewModel.TsUiSceneRoleActor);
					});
				}
				instance.SendPbUpLevelRoleRequest(roleId, itemList, successCallback);
			};
			confirmBoxDataNew.FunctionMap.Add(2, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		RoleController.Instance.SendPbUpLevelRoleRequest(this.RoleInstance.GetRoleId(), itemList.ToArray(), delegate
		{
			UiRoleUtils.PlayRoleLevelUpEffect(this.ViewModel.TsUiSceneRoleActor);
		});
	}

	// Token: 0x06013040 RID: 77888 RVA: 0x0058F750 File Offset: 0x0058D950
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		RoleExpItemGridComponent roleExpItemGridComponent = this.RoleExpItemGridComponent;
		GenericLayout<RoleLevelUpCostMediumItemGrid, ISelectedData> genericLayout;
		if (roleExpItemGridComponent == null)
		{
			genericLayout = null;
		}
		else
		{
			GenericScrollViewNew<RoleLevelUpCostMediumItemGrid, ISelectedData> genericScrollView = roleExpItemGridComponent.GetGenericScrollView();
			genericLayout = ((genericScrollView != null) ? genericScrollView.GetGenericLayout() : null);
		}
		GenericLayout<RoleLevelUpCostMediumItemGrid, ISelectedData> genericLayout2 = genericLayout;
		if (genericLayout2 == null)
		{
			return null;
		}
		RoleLevelUpCostMediumItemGrid layoutItemByIndex = genericLayout2.GetLayoutItemByIndex(int.Parse(configParams[1]));
		if (layoutItemByIndex == null)
		{
			return null;
		}
		UUIItem uiItemForGuide = layoutItemByIndex.GetUiItemForGuide();
		if (uiItemForGuide == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uiItemForGuide,
			uiItemForGuide
		};
	}

	// Token: 0x06013041 RID: 77889 RVA: 0x0058F7AF File Offset: 0x0058D9AF
	protected void OnAttributeChangeSequenceFinished(AttributeItem attributeItem)
	{
		this.UpdateAttributeItemValue(attributeItem);
	}

	// Token: 0x06013042 RID: 77890 RVA: 0x0058F7B8 File Offset: 0x0058D9B8
	protected void UpdateAttributeItemValue(AttributeItem attributeItem)
	{
		int attributeId = attributeItem.GetAttributeId();
		int arrivedLevel = this.CurrentExpData.GetArrivedLevel();
		int currentLevel = this.CurrentExpData.GetCurrentLevel();
		int breachLevel = this.RoleInstance.GetLevelData().GetBreachLevel();
		int attributeByLevel = RoleModel.Instance.GetAttributeByLevel(this.RoleInstance.GetRoleId(), (EAttributeType)attributeId, currentLevel, breachLevel);
		attributeItem.SetCurrentValue((float)attributeByLevel);
		bool flag = false;
		int num = 0;
		if (arrivedLevel > currentLevel)
		{
			int addAttrLevelUp = RoleModel.Instance.GetAddAttrLevelUp(this.RoleInstance.GetRoleId(), currentLevel, breachLevel, arrivedLevel, breachLevel, attributeId);
			if (addAttrLevelUp > 0)
			{
				num = attributeByLevel + addAttrLevelUp;
				flag = true;
			}
		}
		else
		{
			flag = false;
		}
		attributeItem.SetNextItemActive(flag);
		if (flag)
		{
			attributeItem.SetNextValue((float)num);
		}
	}

	// Token: 0x06013043 RID: 77891 RVA: 0x0058F868 File Offset: 0x0058DA68
	protected void UpdateButtonState()
	{
		bool roleIsMaxLevel = this.RoleInstance.GetLevelData().GetRoleIsMaxLevel();
		this.RoleExpItemGridComponent.SetMaxItemActive(roleIsMaxLevel);
		this.RoleExpItemGridComponent.SetButtonItemActive(!roleIsMaxLevel);
	}

	// Token: 0x0400A3A5 RID: 41893
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x0400A3A6 RID: 41894
	[Nullable(2)]
	protected RoleDataBase RoleInstance;

	// Token: 0x0400A3A7 RID: 41895
	[Nullable(2)]
	private RoleExpItemGridComponent RoleExpItemGridComponent;

	// Token: 0x0400A3A8 RID: 41896
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ISelectedData[] DataList;

	// Token: 0x0400A3A9 RID: 41897
	private readonly SelectableExpData CurrentExpData = new SelectableExpData();

	// Token: 0x0400A3AA RID: 41898
	[Nullable(2)]
	private ExpComponent ExpComponent;

	// Token: 0x0400A3AB RID: 41899
	[Nullable(2)]
	private TItem[] ReceiveItemList;

	// Token: 0x0400A3AC RID: 41900
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A3AD RID: 41901
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x020080D8 RID: 32984
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029AC8 RID: 170696
		ExpItem,
		// Token: 0x04029AC9 RID: 170697
		ConsumeItem,
		// Token: 0x04029ACA RID: 170698
		AttributeItem,
		// Token: 0x04029ACB RID: 170699
		MaskItem,
		// Token: 0x04029ACC RID: 170700
		CaptionItem
	}
}
