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

// Token: 0x02002894 RID: 10388
[NullableContext(1)]
[Nullable(0)]
public class RoleLevelUpView : UiViewBase
{
	// Token: 0x06015618 RID: 87576 RVA: 0x00563A7D File Offset: 0x00561C7D
	public RoleLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015619 RID: 87577 RVA: 0x00563A94 File Offset: 0x00561C94
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

	// Token: 0x0601561A RID: 87578 RVA: 0x00563B04 File Offset: 0x00561D04
	protected void CloseClick()
	{
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
	}

	// Token: 0x0601561B RID: 87579 RVA: 0x00563B18 File Offset: 0x00561D18
	protected override UniTask OnBeforeStartAsync()
	{
		RoleLevelUpView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleLevelUpView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601561C RID: 87580 RVA: 0x00563B5C File Offset: 0x00561D5C
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RoleLevelUpView.<OnPlayingStartSequenceAsync>d__14 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RoleLevelUpView.<OnPlayingStartSequenceAsync>d__14>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601561D RID: 87581 RVA: 0x00563BA0 File Offset: 0x00561DA0
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		RoleLevelUpView.<OnPlayingCloseSequenceAsync>d__15 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<RoleLevelUpView.<OnPlayingCloseSequenceAsync>d__15>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601561E RID: 87582 RVA: 0x00563BE3 File Offset: 0x00561DE3
	protected override void OnHandleLoadScene()
	{
		this.ViewModel.HandleLoadScene(delegate
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, true, false);
		});
	}

	// Token: 0x0601561F RID: 87583 RVA: 0x00563C0F File Offset: 0x00561E0F
	protected override void OnHandleReleaseScene()
	{
		this.ViewModel.HandleReleaseScene();
	}

	// Token: 0x06015620 RID: 87584 RVA: 0x00563C1C File Offset: 0x00561E1C
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

	// Token: 0x06015621 RID: 87585 RVA: 0x00563CC8 File Offset: 0x00561EC8
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
					ItemController.Instance.OpenItemTipsByItemId(configId, true, null);
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

	// Token: 0x06015622 RID: 87586 RVA: 0x00563D54 File Offset: 0x00561F54
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

	// Token: 0x06015623 RID: 87587 RVA: 0x00563DA8 File Offset: 0x00561FA8
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

	// Token: 0x06015624 RID: 87588 RVA: 0x00563E64 File Offset: 0x00562064
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

	// Token: 0x06015625 RID: 87589 RVA: 0x00563EB8 File Offset: 0x005620B8
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

	// Token: 0x06015626 RID: 87590 RVA: 0x00563EF8 File Offset: 0x005620F8
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

	// Token: 0x06015627 RID: 87591 RVA: 0x00563FFC File Offset: 0x005621FC
	private int GetItemExp(ISelectedData data)
	{
		return RoleModel.Instance.GetRoleExpItemExp(data.ItemId).Value;
	}

	// Token: 0x06015628 RID: 87592 RVA: 0x00564021 File Offset: 0x00562221
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06015629 RID: 87593 RVA: 0x00564028 File Offset: 0x00562228
	private void OnExpTweenComplete(bool _)
	{
		this.InitExp();
		this.ResetDataList();
		this.RefreshItemAndExp();
	}

	// Token: 0x0601562A RID: 87594 RVA: 0x0056403C File Offset: 0x0056223C
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

	// Token: 0x0601562B RID: 87595 RVA: 0x0056412C File Offset: 0x0056232C
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

	// Token: 0x0601562C RID: 87596 RVA: 0x005641B0 File Offset: 0x005623B0
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

	// Token: 0x0601562D RID: 87597 RVA: 0x00564232 File Offset: 0x00562432
	private int MaxExpFunction(int level)
	{
		return RoleModel.Instance.GetRoleLevelUpExp(this.RoleInstance.GetRoleId(), level + 1);
	}

	// Token: 0x0601562E RID: 87598 RVA: 0x0056424C File Offset: 0x0056244C
	private void ReturnRootViewFromReward()
	{
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
	}

	// Token: 0x0601562F RID: 87599 RVA: 0x0056425E File Offset: 0x0056245E
	private void ReturnRootView()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleLevelUp);
		UiManager.Instance.CloseView(EUiViewName.RoleLevelUpView, null);
	}

	// Token: 0x06015630 RID: 87600 RVA: 0x00564278 File Offset: 0x00562478
	private void TurnToBreachViewFromReward()
	{
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
		roleViewViewModel.FadeInCurveId = this.ViewModel.FadeInCurveId;
		roleViewViewModel.NeedHideOnViewPlayingCloseSequence = this.ViewModel.NeedHideOnViewPlayingCloseSequence;
		this.ViewModel.NeedHideOnViewPlayingCloseSequence = false;
		RoleController.Instance.CloseAndOpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, EUiViewName.RoleBreachView, roleViewViewModel);
	}

	// Token: 0x06015631 RID: 87601 RVA: 0x005642DC File Offset: 0x005624DC
	private void TurnToBreachView()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.RoleBreach);
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(this.RoleInstance.GetRoleId(), false, ERoleViewSource.Normal);
		roleViewViewModel.FadeInCurveId = this.ViewModel.FadeInCurveId;
		roleViewViewModel.NeedHideOnViewPlayingCloseSequence = this.ViewModel.NeedHideOnViewPlayingCloseSequence;
		this.ViewModel.NeedHideOnViewPlayingCloseSequence = false;
		RoleController.Instance.CloseAndOpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, EUiViewName.RoleBreachView, roleViewViewModel);
	}

	// Token: 0x06015632 RID: 87602 RVA: 0x00564348 File Offset: 0x00562548
	private UniTask Init()
	{
		RoleLevelUpView.<Init>d__36 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<RoleLevelUpView.<Init>d__36>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06015633 RID: 87603 RVA: 0x0056438C File Offset: 0x0056258C
	private UniTask InitAttribute()
	{
		RoleLevelUpView.<InitAttribute>d__37 <InitAttribute>d__;
		<InitAttribute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAttribute>d__.<>4__this = this;
		<InitAttribute>d__.<>1__state = -1;
		<InitAttribute>d__.<>t__builder.Start<RoleLevelUpView.<InitAttribute>d__37>(ref <InitAttribute>d__);
		return <InitAttribute>d__.<>t__builder.Task;
	}

	// Token: 0x06015634 RID: 87604 RVA: 0x005643CF File Offset: 0x005625CF
	public void InitExp()
	{
		this.UpdateExpData();
		this.ExpComponent.UpdateInitState(this.CurrentExpData);
	}

	// Token: 0x06015635 RID: 87605 RVA: 0x005643E8 File Offset: 0x005625E8
	private void Update()
	{
		this.UpdateAttribute();
		this.UpdateButtonState();
		this.RefreshItemAndExp();
	}

	// Token: 0x06015636 RID: 87606 RVA: 0x005643FC File Offset: 0x005625FC
	public void ResetDataList()
	{
		foreach (ISelectedData selectedData in this.DataList)
		{
			selectedData.SelectedCount = 0;
			selectedData.Count = InventoryModel.Instance.GetItemCountByConfigId(selectedData.ItemId, 0);
		}
	}

	// Token: 0x06015637 RID: 87607 RVA: 0x00564440 File Offset: 0x00562640
	private void UpdateAttribute()
	{
		foreach (AttributeItem attributeItem in this.AttributeLayout.GetLayoutItemList())
		{
			this.UpdateAttributeItemValue(attributeItem);
		}
	}

	// Token: 0x06015638 RID: 87608 RVA: 0x00564498 File Offset: 0x00562698
	protected void UpdateExpData()
	{
		RoleLevelData levelData = this.RoleInstance.GetLevelData();
		int level = levelData.GetLevel();
		int currentMaxLevel = levelData.GetCurrentMaxLevel();
		int exp = levelData.GetExp();
		int roleMaxLevel = levelData.GetRoleMaxLevel();
		this.CurrentExpData.UpdateComponent(level, currentMaxLevel, exp, new int?(roleMaxLevel), false);
	}

	// Token: 0x06015639 RID: 87609 RVA: 0x005644E0 File Offset: 0x005626E0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleInfoUpdate, new Action(this.RoleInfoUpdate));
		EventSystem.Instance.Add<IReadOnlyList<TItem>>(EEventName.RoleLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.RoleLevelUpReceiveItem));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0601563A RID: 87610 RVA: 0x00564544 File Offset: 0x00562744
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleInfoUpdate, new Action(this.RoleInfoUpdate));
		EventSystem.Instance.Remove(EEventName.RoleLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.RoleLevelUpReceiveItem));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0601563B RID: 87611 RVA: 0x005645A5 File Offset: 0x005627A5
	private void RoleInfoUpdate()
	{
		this.OnLevelUpSuccess();
		this.ExpComponent.PlayExpTween(this.CurrentExpData);
	}

	// Token: 0x0601563C RID: 87612 RVA: 0x005645C0 File Offset: 0x005627C0
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

	// Token: 0x0601563D RID: 87613 RVA: 0x005647D0 File Offset: 0x005629D0
	private void RoleLevelUpReceiveItem(IReadOnlyList<TItem> itemList)
	{
		this.ReceiveItemList = itemList.ToArray<TItem>();
	}

	// Token: 0x0601563E RID: 87614 RVA: 0x005647DE File Offset: 0x005629DE
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.Update();
	}

	// Token: 0x0601563F RID: 87615 RVA: 0x005647E8 File Offset: 0x005629E8
	private static List<T> ArrayToList<[Nullable(2)] T>(T[] source)
	{
		List<T> list = new List<T>(source.Length);
		for (int i = 0; i < source.Length; i++)
		{
			list.Add(source[i]);
		}
		return list;
	}

	// Token: 0x06015640 RID: 87616 RVA: 0x0056481C File Offset: 0x00562A1C
	private bool CheckIsMaxLevel()
	{
		int arrivedLevel = this.CurrentExpData.GetArrivedLevel();
		int currentMaxLevel = this.RoleInstance.GetLevelData().GetCurrentMaxLevel();
		return arrivedLevel >= currentMaxLevel;
	}

	// Token: 0x06015641 RID: 87617 RVA: 0x0056484C File Offset: 0x00562A4C
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

	// Token: 0x06015642 RID: 87618 RVA: 0x005649F4 File Offset: 0x00562BF4
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

	// Token: 0x06015643 RID: 87619 RVA: 0x00564A53 File Offset: 0x00562C53
	protected void OnAttributeChangeSequenceFinished(AttributeItem attributeItem)
	{
		this.UpdateAttributeItemValue(attributeItem);
	}

	// Token: 0x06015644 RID: 87620 RVA: 0x00564A5C File Offset: 0x00562C5C
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

	// Token: 0x06015645 RID: 87621 RVA: 0x00564B0C File Offset: 0x00562D0C
	protected void UpdateButtonState()
	{
		bool roleIsMaxLevel = this.RoleInstance.GetLevelData().GetRoleIsMaxLevel();
		this.RoleExpItemGridComponent.SetMaxItemActive(roleIsMaxLevel);
		this.RoleExpItemGridComponent.SetButtonItemActive(!roleIsMaxLevel);
	}

	// Token: 0x04009FBC RID: 40892
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x04009FBD RID: 40893
	[Nullable(2)]
	protected RoleDataBase RoleInstance;

	// Token: 0x04009FBE RID: 40894
	[Nullable(2)]
	private RoleExpItemGridComponent RoleExpItemGridComponent;

	// Token: 0x04009FBF RID: 40895
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ISelectedData[] DataList;

	// Token: 0x04009FC0 RID: 40896
	private readonly SelectableExpData CurrentExpData = new SelectableExpData();

	// Token: 0x04009FC1 RID: 40897
	[Nullable(2)]
	private ExpComponent ExpComponent;

	// Token: 0x04009FC2 RID: 40898
	[Nullable(2)]
	private TItem[] ReceiveItemList;

	// Token: 0x04009FC3 RID: 40899
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009FC4 RID: 40900
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x02008E92 RID: 36498
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E3CE RID: 189390
		ExpItem,
		// Token: 0x0402E3CF RID: 189391
		ConsumeItem,
		// Token: 0x0402E3D0 RID: 189392
		AttributeItem,
		// Token: 0x0402E3D1 RID: 189393
		MaskItem,
		// Token: 0x0402E3D2 RID: 189394
		CaptionItem
	}
}
