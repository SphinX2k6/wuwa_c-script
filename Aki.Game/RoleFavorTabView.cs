using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleFavor;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DE2 RID: 7650
[NullableContext(2)]
[Nullable(0)]
public class RoleFavorTabView : UiTabViewBase
{
	// Token: 0x06012EB6 RID: 77494 RVA: 0x0058B640 File Offset: 0x00589840
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickExperienceButton)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickVoiceButton)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickActionButton)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickPreciousItemButton))
		};
	}

	// Token: 0x06012EB7 RID: 77495 RVA: 0x0058B7CE File Offset: 0x005899CE
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.UpdateRoleFavorData, new Action<int>(this.OnUpdateRoleFavorData));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
	}

	// Token: 0x06012EB8 RID: 77496 RVA: 0x0058B808 File Offset: 0x00589A08
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateRoleFavorData, new Action<int>(this.OnUpdateRoleFavorData));
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleSystemChangeRole));
	}

	// Token: 0x06012EB9 RID: 77497 RVA: 0x0058B844 File Offset: 0x00589A44
	protected override UniTask OnBeforeStartAsync()
	{
		RoleFavorTabView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleFavorTabView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012EBA RID: 77498 RVA: 0x0058B888 File Offset: 0x00589A88
	protected override void OnStart()
	{
		this.RoleViewAgent = (this.ExtraParams as RoleViewAgent);
		if (this.RoleViewAgent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RoleViewAgent为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("界面名称", "RoleFavorTabView");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06012EBB RID: 77499 RVA: 0x0058B8DC File Offset: 0x00589ADC
	protected override void OnBeforeShow()
	{
		this.PlayMontageStart();
		this.RefreshRedDot();
		UAnimInstance animInstance = this.GetAnimInstance();
		if (animInstance != null)
		{
			animInstance.Montage_Stop(0f, null);
		}
		this.Refresh();
	}

	// Token: 0x06012EBC RID: 77500 RVA: 0x0058B914 File Offset: 0x00589B14
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		if (this.PlayAudioHandle != null)
		{
			AudioSystem.Instance.ExecuteAction(this.PlayAudioHandle.Value, EAudioActionType.Stop, null);
			this.PlayAudioHandle = null;
		}
		RoleLangCustomItem roleLangItem = this.RoleLangItem;
		if (roleLangItem == null)
		{
			return;
		}
		roleLangItem.OnTabViewHide();
	}

	// Token: 0x06012EBD RID: 77501 RVA: 0x0058B969 File Offset: 0x00589B69
	private void OnUpdateRoleFavorData(int _)
	{
		this.Refresh();
	}

	// Token: 0x06012EBE RID: 77502 RVA: 0x0058B971 File Offset: 0x00589B71
	private void OnRoleSystemChangeRole(int _)
	{
		this.Refresh();
	}

	// Token: 0x06012EBF RID: 77503 RVA: 0x0058B97C File Offset: 0x00589B7C
	private void Refresh()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(curSelectRoleId, true);
		if (roleDataById == null)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(curSelectRoleId);
		if (roleConfig == null)
		{
			return;
		}
		string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
		UUIText text = base.GetText(1);
		UUIText text2 = base.GetText(2);
		UUIText text3 = base.GetText(0);
		bool flag = roleConfig.Value.PartyId != 9;
		if (text != null)
		{
			text.SetUIActive(flag);
		}
		if (text2 != null)
		{
			text2.SetUIActive(flag);
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag);
		}
		UUIButtonComponent button2 = base.GetButton(3);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(flag);
		}
		if (flag)
		{
			if (text3 != null)
			{
				text3.SetText(roleName, true);
			}
		}
		else if (text3 != null)
		{
			text3.SetText(roleDataById.GetName(null), true);
		}
		RoleFavorData favorData = roleDataById.GetFavorData();
		int favorLevel = favorData.GetFavorLevel();
		LguiUtil.Instance.SetLocalText(text, "FavorLevel", new <>z__ReadOnlySingleElementList<object>(favorLevel));
		FavorLevel? favorLevelConfig = RoleFavorConfig.Instance.GetFavorLevelConfig(favorLevel);
		int favorExp = favorData.GetFavorExp();
		if (favorLevelConfig != null)
		{
			LguiUtil.Instance.SetLocalText(text2, "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
			{
				favorExp,
				favorLevelConfig.Value.LevelUpExp
			}));
		}
		else
		{
			FavorLevel? favorLevelConfig2 = RoleFavorConfig.Instance.GetFavorLevelConfig(favorLevel - 1);
			if (favorLevelConfig2 != null)
			{
				int levelUpExp = favorLevelConfig2.Value.LevelUpExp;
				LguiUtil.Instance.SetLocalText(text2, "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
				{
					levelUpExp,
					levelUpExp
				}));
			}
		}
		this.RefreshRedDot();
		bool? boolConfig = ConfigCommonParamById.GetBoolConfig("NeedShowRoleLangCustom");
		if (boolConfig != null && boolConfig.Value)
		{
			this.RoleLangItem.Refresh(curSelectRoleId);
			return;
		}
		this.RoleLangItem.SetUiActive(false);
	}

	// Token: 0x06012EC0 RID: 77504 RVA: 0x0058BBBC File Offset: 0x00589DBC
	private void RefreshRedDot()
	{
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		if (curSelectRoleData == null)
		{
			return;
		}
		RoleFavorData favorData = curSelectRoleData.GetFavorData();
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(favorData.IsFavorItemCanUnlock(EFavorContentType.ExperienceStory));
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(favorData.IsFavorItemCanUnlock(EFavorContentType.Voice));
		}
		UUIItem item3 = base.GetItem(9);
		if (item3 != null)
		{
			item3.SetUIActive(favorData.IsFavorItemCanUnlock(EFavorContentType.Action));
		}
		UUIItem item4 = base.GetItem(10);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(favorData.IsFavorItemCanUnlock(EFavorContentType.PreciousItem));
	}

	// Token: 0x06012EC1 RID: 77505 RVA: 0x0058BC45 File Offset: 0x00589E45
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Favor, false, false, false);
	}

	// Token: 0x06012EC2 RID: 77506 RVA: 0x0058BC58 File Offset: 0x00589E58
	private USkeletalMeshComponent GetRoleActorMesh()
	{
		TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		if (roleSystemRoleActor == null)
		{
			return null;
		}
		UiModelBase model = roleSystemRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			return null;
		}
		return uskeletalMeshComponent;
	}

	// Token: 0x06012EC3 RID: 77507 RVA: 0x0058BC9C File Offset: 0x00589E9C
	private UAnimInstance GetAnimInstance()
	{
		USkeletalMeshComponent roleActorMesh = this.GetRoleActorMesh();
		if (roleActorMesh == null)
		{
			return null;
		}
		UAnimInstance animInstance = roleActorMesh.GetAnimInstance();
		if (animInstance == null)
		{
			return null;
		}
		return animInstance.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE);
	}

	// Token: 0x06012EC4 RID: 77508 RVA: 0x0058BCD0 File Offset: 0x00589ED0
	protected void OnClickExperienceButton()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		if (RoleFavorConfig.Instance.GetFavorRoleInfoConfig(curSelectRoleId) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "该角色的好感度配置FavorRoleInfo找不到!!!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("角色Id", curSelectRoleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleFavorInfoView, new RoleFavorInfoViewParams
		{
			RoleId = curSelectRoleId,
			FavorTabType = EFavorTabType.Experience
		}, null);
	}

	// Token: 0x06012EC5 RID: 77509 RVA: 0x0058BD50 File Offset: 0x00589F50
	protected void OnClickVoiceButton()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		EFavorVoiceType type = EFavorVoiceType.FavorNatureVoice;
		IReadOnlyList<FavorWord> favorWordConfig = RoleFavorConfig.Instance.GetFavorWordConfig(curSelectRoleId, (int)type);
		if (favorWordConfig == null || favorWordConfig.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "该角色的好感度配置FavorWord找不到!!!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("角色Id", curSelectRoleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleFavorInfoView, new RoleFavorInfoViewParams
		{
			RoleId = curSelectRoleId,
			FavorTabType = EFavorTabType.Voice
		}, null);
	}

	// Token: 0x06012EC6 RID: 77510 RVA: 0x0058BDD4 File Offset: 0x00589FD4
	protected void OnClickActionButton()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		EFavorActionType type = EFavorActionType.IdleAction;
		IReadOnlyList<Motion> roleMotionByType = MotionConfig.Instance.GetRoleMotionByType(curSelectRoleId, (int)type);
		if (roleMotionByType == null || roleMotionByType.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "该角色的好感度配置Motion找不到!!!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("角色Id", curSelectRoleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleFavorInfoView, new RoleFavorInfoViewParams
		{
			RoleId = curSelectRoleId,
			FavorTabType = EFavorTabType.Action
		}, null);
	}

	// Token: 0x06012EC7 RID: 77511 RVA: 0x0058BE58 File Offset: 0x0058A058
	protected void OnClickPreciousItemButton()
	{
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		IReadOnlyList<FavorGoods> favorGoodsConfig = RoleFavorConfig.Instance.GetFavorGoodsConfig(curSelectRoleId);
		if (favorGoodsConfig == null || favorGoodsConfig.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "该角色的好感度配置FavorGoods找不到!!!";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("角色Id", curSelectRoleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RoleFavorInfoView, new RoleFavorInfoViewParams
		{
			RoleId = curSelectRoleId,
			FavorTabType = EFavorTabType.PreciousItem
		}, null);
	}

	// Token: 0x06012EC8 RID: 77512 RVA: 0x0058BED8 File Offset: 0x0058A0D8
	private void OnSetPlayerVoice()
	{
		if (this.PlayAudioHandle != null)
		{
			AudioSystem.Instance.ExecuteAction(this.PlayAudioHandle.Value, EAudioActionType.Stop, null);
		}
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		this.PlayAudioHandle = new int?(RoleLangCustomModel.Instance.PlayVoiceOnSetVoice(curSelectRoleId));
	}

	// Token: 0x0400A304 RID: 41732
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A305 RID: 41733
	private RoleLangCustomItem RoleLangItem;

	// Token: 0x0400A306 RID: 41734
	private int? PlayAudioHandle;
}
