using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E5C RID: 7772
[NullableContext(2)]
[Nullable(0)]
public class RoleWeaponTabView : UiTabViewBase
{
	// Token: 0x060133A6 RID: 78758 RVA: 0x0059E9C4 File Offset: 0x0059CBC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnSkinClick))
		};
	}

	// Token: 0x060133A7 RID: 78759 RVA: 0x0059EA70 File Offset: 0x0059CC70
	private UniTask InitWeaponDetailTips()
	{
		RoleWeaponTabView.<InitWeaponDetailTips>d__6 <InitWeaponDetailTips>d__;
		<InitWeaponDetailTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWeaponDetailTips>d__.<>4__this = this;
		<InitWeaponDetailTips>d__.<>1__state = -1;
		<InitWeaponDetailTips>d__.<>t__builder.Start<RoleWeaponTabView.<InitWeaponDetailTips>d__6>(ref <InitWeaponDetailTips>d__);
		return <InitWeaponDetailTips>d__.<>t__builder.Task;
	}

	// Token: 0x060133A8 RID: 78760 RVA: 0x0059EAB4 File Offset: 0x0059CCB4
	private UniTask InitEquipItem()
	{
		RoleWeaponTabView.<InitEquipItem>d__7 <InitEquipItem>d__;
		<InitEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEquipItem>d__.<>4__this = this;
		<InitEquipItem>d__.<>1__state = -1;
		<InitEquipItem>d__.<>t__builder.Start<RoleWeaponTabView.<InitEquipItem>d__7>(ref <InitEquipItem>d__);
		return <InitEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x060133A9 RID: 78761 RVA: 0x0059EAF8 File Offset: 0x0059CCF8
	private UniTask InitWarningItem()
	{
		RoleWeaponTabView.<InitWarningItem>d__8 <InitWarningItem>d__;
		<InitWarningItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWarningItem>d__.<>4__this = this;
		<InitWarningItem>d__.<>1__state = -1;
		<InitWarningItem>d__.<>t__builder.Start<RoleWeaponTabView.<InitWarningItem>d__8>(ref <InitWarningItem>d__);
		return <InitWarningItem>d__.<>t__builder.Task;
	}

	// Token: 0x060133AA RID: 78762 RVA: 0x0059EB3C File Offset: 0x0059CD3C
	protected override UniTask OnBeforeStartAsync()
	{
		RoleWeaponTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleWeaponTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060133AB RID: 78763 RVA: 0x0059EB7F File Offset: 0x0059CD7F
	protected override void OnStart()
	{
		this.WeaponDetailTipsComponent.SetCanShowEquip(false);
		this.WeaponDetailTipsComponent.SetReplaceFunction(new TWeaponDetailsTipsFunctionWithNumber(this.ReplaceClick));
		this.WeaponDetailTipsComponent.SetCultureFunction(new TWeaponDetailsTipsFunctionWithNumber(this.CultureClick));
	}

	// Token: 0x060133AC RID: 78764 RVA: 0x0059EBBC File Offset: 0x0059CDBC
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int, bool>(EEventName.OnItemLock, new Action<int, bool>(this.ItemLockEvent));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.UpdateWeaponEvent));
		EventSystem.Instance.Add(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
	}

	// Token: 0x060133AD RID: 78765 RVA: 0x0059EC20 File Offset: 0x0059CE20
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnItemLock, new Action<int, bool>(this.ItemLockEvent));
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.UpdateWeaponEvent));
		EventSystem.Instance.Remove(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
	}

	// Token: 0x060133AE RID: 78766 RVA: 0x0059EC81 File Offset: 0x0059CE81
	private void ResetRoleFlag()
	{
		this.HasUpdateRole = false;
	}

	// Token: 0x060133AF RID: 78767 RVA: 0x0059EC8A File Offset: 0x0059CE8A
	protected override void OnBeforeShow()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.RoleWeaponTabView);
		if (this.HasUpdateRole)
		{
			this.PlayMontageStart(true);
			this.HasUpdateRole = false;
		}
		else
		{
			this.PlayMontageStart(false);
		}
		this.RefreshWeaponDetailTipsComponent();
	}

	// Token: 0x060133B0 RID: 78768 RVA: 0x0059ECBC File Offset: 0x0059CEBC
	protected override void OnBeforeDestroy()
	{
		if (this.WeaponDetailTipsComponent != null)
		{
			this.WeaponDetailTipsComponent.Destroy(null);
			this.WeaponDetailTipsComponent = null;
		}
	}

	// Token: 0x060133B1 RID: 78769 RVA: 0x0059ECDC File Offset: 0x0059CEDC
	private void ReplaceClick(int incId)
	{
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(this.RoleViewAgent.GetCurSelectRoleId(), false, this.RoleViewAgent.Source);
		roleViewViewModel.WeaponIncId = incId;
		RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.WeaponReplaceView, roleViewViewModel);
	}

	// Token: 0x060133B2 RID: 78770 RVA: 0x0059ED20 File Offset: 0x0059CF20
	private void CultureClick(int incId)
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		if (weaponDataByIncId == null)
		{
			return;
		}
		int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(weaponDataByIncId.GetRoleId());
		WeaponRootViewParam param = new WeaponRootViewParam
		{
			WeaponIncId = incId,
			WeaponSkinId = skinIdByRoleId,
			IsFromRoleRootView = true
		};
		WeaponController.Instance.RoleFadeIn(UiSceneManager.Instance.GetRoleSystemRoleActor(), "RoleFadeInCurve");
		UiManager.Instance.OpenView(EUiViewName.WeaponRootView, param, null);
	}

	// Token: 0x060133B3 RID: 78771 RVA: 0x0059ED93 File Offset: 0x0059CF93
	private void ItemLockEvent(int uniqueId, bool bLock)
	{
		this.WeaponDetailTipsComponent.UpdateWeaponLock(bLock);
	}

	// Token: 0x060133B4 RID: 78772 RVA: 0x0059EDA1 File Offset: 0x0059CFA1
	private void UpdateWeaponEvent(int i)
	{
		this.HasUpdateRole = true;
		this.PlayMontageStart(true);
		this.RefreshWeaponDetailTipsComponent();
	}

	// Token: 0x060133B5 RID: 78773 RVA: 0x0059EDB7 File Offset: 0x0059CFB7
	protected void PlayMontageStart(bool reLoop = false)
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Weapon, reLoop, false, false);
	}

	// Token: 0x060133B6 RID: 78774 RVA: 0x0059EDC8 File Offset: 0x0059CFC8
	private void RefreshWeaponDetailTipsComponent()
	{
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		if (curSelectRoleData == null)
		{
			return;
		}
		WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(curSelectRoleData.GetDataId(), true);
		if (weaponDataByRoleDataId == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RoleWeaponTabView获取不到武器数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", curSelectRoleData.GetDataId());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.WeaponDetailTipsComponent.UpdateComponent(weaponDataByRoleDataId);
		bool flag = WeaponModel.Instance.RedDotWeaponBreachCondition(curSelectRoleData.GetDataId());
		bool flag2 = WeaponModel.Instance.RedDotWeaponResonanceConditionByRole(curSelectRoleData.GetDataId());
		this.WeaponDetailTipsComponent.UpdateWeaponBreachRedDot(flag || flag2);
		this.RefreshEquipItem();
		this.RefreshSkinBtn();
		this.RefreshRedDot();
		this.RefreshWarningItem();
	}

	// Token: 0x060133B7 RID: 78775 RVA: 0x0059EE80 File Offset: 0x0059D080
	private void RefreshEquipItem()
	{
		if (!this.RoleViewAgent.GetRoleSystemUiParams().SwitchSkin)
		{
			CommonEquippedItem equipItem = this.EquipItem;
			if (equipItem == null)
			{
				return;
			}
			equipItem.SetIconRootItemState(false);
			return;
		}
		else
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			if (curSelectRoleData == null)
			{
				return;
			}
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(curSelectRoleData.GetDataId());
			if (skinIdByRoleId == -1)
			{
				CommonEquippedItem equipItem2 = this.EquipItem;
				if (equipItem2 == null)
				{
					return;
				}
				equipItem2.SetIconRootItemState(false);
				return;
			}
			else
			{
				WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(skinIdByRoleId);
				CommonEquippedItem equipItem3 = this.EquipItem;
				if (equipItem3 != null)
				{
					equipItem3.SetEquipIcon(weaponSkinConfig.IconSmall);
				}
				this.EquipItem.SetEquipText("WeaponTipsRoleText", new object[]
				{
					new TableTextArgNew(weaponSkinConfig.Name, Array.Empty<object>())
				});
				CommonEquippedItem equipItem4 = this.EquipItem;
				if (equipItem4 == null)
				{
					return;
				}
				equipItem4.SetIconRootItemState(true);
				return;
			}
		}
	}

	// Token: 0x060133B8 RID: 78776 RVA: 0x0059EF48 File Offset: 0x0059D148
	private void RefreshSkinBtn()
	{
		if (!this.RoleViewAgent.GetRoleSystemUiParams().SwitchSkin)
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
			return;
		}
		else
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			if (curSelectRoleData == null || curSelectRoleData.IsTrialRole())
			{
				UUIButtonComponent button2 = base.GetButton(2);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				UUIButtonComponent button3 = base.GetButton(2);
				if (button3 == null)
				{
					return;
				}
				button3.RootUIComp.Get().SetUIActive(true);
				return;
			}
		}
	}

	// Token: 0x060133B9 RID: 78777 RVA: 0x0059EFE0 File Offset: 0x0059D1E0
	private void RefreshRedDot()
	{
		if (this.RoleViewAgent.GetRoleSystemUiParams().SwitchSkin)
		{
			RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
			if (curSelectRoleData == null)
			{
				return;
			}
			WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(curSelectRoleData.GetDataId(), true);
			if (weaponDataByRoleDataId == null)
			{
				return;
			}
			int weaponType = weaponDataByRoleDataId.GetWeaponConfig().Value.WeaponType;
			bool uiactive = WeaponSkinModel.Instance.HasWeaponSkinRedDot(weaponType);
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x060133BA RID: 78778 RVA: 0x0059F070 File Offset: 0x0059D270
	private void RefreshWarningItem()
	{
		if (this.RoleViewAgent.Source == ERoleViewSource.WheelTower)
		{
			int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
			IConflictInfo conflictInfo = WheelTowerModel.Instance.CheckConflict(curSelectRoleId);
			if (conflictInfo != null && conflictInfo.WeaponConflict)
			{
				CommonWarningItem warningItem = this.WarningItem;
				if (warningItem != null)
				{
					warningItem.SetUiActive(true);
				}
				int conflictWeaponRoleId = WheelTowerModel.Instance.GetConflictWeaponRoleId(curSelectRoleId);
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(conflictWeaponRoleId);
				CommonWarningItem warningItem2 = this.WarningItem;
				if (warningItem2 != null)
				{
					warningItem2.SetWarningIcon(roleConfig.Value.Card);
				}
				string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(roleConfig.Value.Name);
				CommonWarningItem warningItem3 = this.WarningItem;
				if (warningItem3 == null)
				{
					return;
				}
				warningItem3.SetLocalTextNew("WheelTower_Conflict_Warning_Tip", new object[]
				{
					multiTextByKey
				});
				return;
			}
		}
		CommonWarningItem warningItem4 = this.WarningItem;
		if (warningItem4 == null)
		{
			return;
		}
		warningItem4.SetUiActive(false);
	}

	// Token: 0x060133BB RID: 78779 RVA: 0x0059F150 File Offset: 0x0059D350
	private void OnSkinClick()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		SkinController.Instance.SkipToSkinView(curSelectRoleId, EUiTabViewName.WeaponSkinTabView, false, -1, null, null, null);
	}

	// Token: 0x060133BC RID: 78780 RVA: 0x0059F18E File Offset: 0x0059D38E
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		return this.WeaponDetailTipsComponent.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x0400A4A9 RID: 42153
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A4AA RID: 42154
	private WeaponDetailTipsComponent WeaponDetailTipsComponent;

	// Token: 0x0400A4AB RID: 42155
	private CommonEquippedItem EquipItem;

	// Token: 0x0400A4AC RID: 42156
	private CommonWarningItem WarningItem;

	// Token: 0x0400A4AD RID: 42157
	private bool HasUpdateRole;

	// Token: 0x02008137 RID: 33079
	[NullableContext(0)]
	private enum ERoleWeaponTabViewDefine
	{
		// Token: 0x04029C90 RID: 171152
		WeaponDetailTipsItem,
		// Token: 0x04029C91 RID: 171153
		EquipRootItem,
		// Token: 0x04029C92 RID: 171154
		SkinBtn,
		// Token: 0x04029C93 RID: 171155
		SkinRedDot,
		// Token: 0x04029C94 RID: 171156
		ItemWarning
	}
}
