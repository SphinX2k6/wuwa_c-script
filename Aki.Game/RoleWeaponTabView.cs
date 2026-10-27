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

// Token: 0x020028E1 RID: 10465
[NullableContext(2)]
[Nullable(0)]
public class RoleWeaponTabView : UiTabViewBase
{
	// Token: 0x060159A2 RID: 88482 RVA: 0x00573AFC File Offset: 0x00571CFC
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

	// Token: 0x060159A3 RID: 88483 RVA: 0x00573BA8 File Offset: 0x00571DA8
	private UniTask InitWeaponDetailTips()
	{
		RoleWeaponTabView.<InitWeaponDetailTips>d__6 <InitWeaponDetailTips>d__;
		<InitWeaponDetailTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWeaponDetailTips>d__.<>4__this = this;
		<InitWeaponDetailTips>d__.<>1__state = -1;
		<InitWeaponDetailTips>d__.<>t__builder.Start<RoleWeaponTabView.<InitWeaponDetailTips>d__6>(ref <InitWeaponDetailTips>d__);
		return <InitWeaponDetailTips>d__.<>t__builder.Task;
	}

	// Token: 0x060159A4 RID: 88484 RVA: 0x00573BEC File Offset: 0x00571DEC
	private UniTask InitEquipItem()
	{
		RoleWeaponTabView.<InitEquipItem>d__7 <InitEquipItem>d__;
		<InitEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitEquipItem>d__.<>4__this = this;
		<InitEquipItem>d__.<>1__state = -1;
		<InitEquipItem>d__.<>t__builder.Start<RoleWeaponTabView.<InitEquipItem>d__7>(ref <InitEquipItem>d__);
		return <InitEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x060159A5 RID: 88485 RVA: 0x00573C30 File Offset: 0x00571E30
	private UniTask InitWarningItem()
	{
		RoleWeaponTabView.<InitWarningItem>d__8 <InitWarningItem>d__;
		<InitWarningItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWarningItem>d__.<>4__this = this;
		<InitWarningItem>d__.<>1__state = -1;
		<InitWarningItem>d__.<>t__builder.Start<RoleWeaponTabView.<InitWarningItem>d__8>(ref <InitWarningItem>d__);
		return <InitWarningItem>d__.<>t__builder.Task;
	}

	// Token: 0x060159A6 RID: 88486 RVA: 0x00573C74 File Offset: 0x00571E74
	protected override UniTask OnBeforeStartAsync()
	{
		RoleWeaponTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleWeaponTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060159A7 RID: 88487 RVA: 0x00573CB7 File Offset: 0x00571EB7
	protected override void OnStart()
	{
		this.WeaponDetailTipsComponent.SetCanShowEquip(false);
		this.WeaponDetailTipsComponent.SetReplaceFunction(new TWeaponDetailsTipsFunctionWithNumber(this.ReplaceClick));
		this.WeaponDetailTipsComponent.SetCultureFunction(new TWeaponDetailsTipsFunctionWithNumber(this.CultureClick));
	}

	// Token: 0x060159A8 RID: 88488 RVA: 0x00573CF4 File Offset: 0x00571EF4
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int, bool>(EEventName.OnItemLock, new Action<int, bool>(this.ItemLockEvent));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.UpdateWeaponEvent));
		EventSystem.Instance.Add(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
	}

	// Token: 0x060159A9 RID: 88489 RVA: 0x00573D58 File Offset: 0x00571F58
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnItemLock, new Action<int, bool>(this.ItemLockEvent));
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.UpdateWeaponEvent));
		EventSystem.Instance.Remove(EEventName.ResetRoleFlag, new Action(this.ResetRoleFlag));
	}

	// Token: 0x060159AA RID: 88490 RVA: 0x00573DB9 File Offset: 0x00571FB9
	private void ResetRoleFlag()
	{
		this.HasUpdateRole = false;
	}

	// Token: 0x060159AB RID: 88491 RVA: 0x00573DC2 File Offset: 0x00571FC2
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

	// Token: 0x060159AC RID: 88492 RVA: 0x00573DF4 File Offset: 0x00571FF4
	protected override void OnBeforeDestroy()
	{
		if (this.WeaponDetailTipsComponent != null)
		{
			this.WeaponDetailTipsComponent.Destroy(null);
			this.WeaponDetailTipsComponent = null;
		}
	}

	// Token: 0x060159AD RID: 88493 RVA: 0x00573E14 File Offset: 0x00572014
	private void ReplaceClick(int incId)
	{
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(this.RoleViewAgent.GetCurSelectRoleId(), false, this.RoleViewAgent.Source);
		roleViewViewModel.WeaponIncId = incId;
		RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.WeaponReplaceView, roleViewViewModel);
	}

	// Token: 0x060159AE RID: 88494 RVA: 0x00573E58 File Offset: 0x00572058
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

	// Token: 0x060159AF RID: 88495 RVA: 0x00573ECB File Offset: 0x005720CB
	private void ItemLockEvent(int uniqueId, bool bLock)
	{
		this.WeaponDetailTipsComponent.UpdateWeaponLock(bLock);
	}

	// Token: 0x060159B0 RID: 88496 RVA: 0x00573ED9 File Offset: 0x005720D9
	private void UpdateWeaponEvent(int i)
	{
		this.HasUpdateRole = true;
		this.PlayMontageStart(true);
		this.RefreshWeaponDetailTipsComponent();
	}

	// Token: 0x060159B1 RID: 88497 RVA: 0x00573EEF File Offset: 0x005720EF
	protected void PlayMontageStart(bool reLoop = false)
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Weapon, reLoop, false, false);
	}

	// Token: 0x060159B2 RID: 88498 RVA: 0x00573F00 File Offset: 0x00572100
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

	// Token: 0x060159B3 RID: 88499 RVA: 0x00573FB8 File Offset: 0x005721B8
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

	// Token: 0x060159B4 RID: 88500 RVA: 0x00574080 File Offset: 0x00572280
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

	// Token: 0x060159B5 RID: 88501 RVA: 0x00574118 File Offset: 0x00572318
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

	// Token: 0x060159B6 RID: 88502 RVA: 0x005741A8 File Offset: 0x005723A8
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

	// Token: 0x060159B7 RID: 88503 RVA: 0x00574288 File Offset: 0x00572488
	private void OnSkinClick()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		SkinController.Instance.SkipToSkinView(curSelectRoleId, EUiTabViewName.WeaponSkinTabView, false, -1, null, null, null);
	}

	// Token: 0x060159B8 RID: 88504 RVA: 0x005742C6 File Offset: 0x005724C6
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

	// Token: 0x0400A0BF RID: 41151
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A0C0 RID: 41152
	private WeaponDetailTipsComponent WeaponDetailTipsComponent;

	// Token: 0x0400A0C1 RID: 41153
	private CommonEquippedItem EquipItem;

	// Token: 0x0400A0C2 RID: 41154
	private CommonWarningItem WarningItem;

	// Token: 0x0400A0C3 RID: 41155
	private bool HasUpdateRole;

	// Token: 0x02008EEF RID: 36591
	[NullableContext(0)]
	private enum ERoleWeaponTabViewDefine
	{
		// Token: 0x0402E595 RID: 189845
		WeaponDetailTipsItem,
		// Token: 0x0402E596 RID: 189846
		EquipRootItem,
		// Token: 0x0402E597 RID: 189847
		SkinBtn,
		// Token: 0x0402E598 RID: 189848
		SkinRedDot,
		// Token: 0x0402E599 RID: 189849
		ItemWarning
	}
}
