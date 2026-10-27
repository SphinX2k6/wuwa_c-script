using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020027A4 RID: 10148
public class RoleGenderChangeView : UiViewBase
{
	// Token: 0x06014D89 RID: 85385 RVA: 0x00549FF1 File Offset: 0x005481F1
	[NullableContext(1)]
	public RoleGenderChangeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014D8A RID: 85386 RVA: 0x00549FFC File Offset: 0x005481FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIInteractionGroup))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickCancel)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirm))
		};
	}

	// Token: 0x06014D8B RID: 85387 RVA: 0x0054A100 File Offset: 0x00548300
	protected override void OnStart()
	{
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		int? num = curSelectMainRoleId;
		int num2 = 0;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(curSelectMainRoleId.Value);
		if (roleConfig == null)
		{
			return;
		}
		int sex = WorldLevelModel.Instance.Sex;
		int elementId = roleConfig.Value.ElementId;
		LoginDefine.ELoginSex gender = (sex == 1) ? LoginDefine.ELoginSex.Girl : LoginDefine.ELoginSex.Boy;
		IReadOnlyList<MainRoleConfig> mainRoleByGender = RoleConfig.Instance.GetMainRoleByGender(gender);
		if (mainRoleByGender == null)
		{
			return;
		}
		int count = mainRoleByGender.Count;
		RoleInfo? roleInfo = null;
		int? num3 = null;
		for (int i = 0; i < count; i++)
		{
			MainRoleConfig mainRoleConfig = mainRoleByGender[i];
			RoleInfo? roleConfig2 = RoleConfig.Instance.GetRoleConfig(mainRoleConfig.Id);
			if (roleConfig2 != null && elementId == roleConfig2.Value.ElementId)
			{
				num3 = new int?(mainRoleConfig.Id);
				roleInfo = roleConfig2;
				break;
			}
		}
		if (roleInfo == null)
		{
			return;
		}
		ValueTuple<string, string> roleHeadIcon = this.GetRoleHeadIcon(roleConfig.Value, roleInfo.Value);
		base.SetRoleIcon(roleHeadIcon.Item1, base.GetTexture(0), curSelectMainRoleId.Value, null, null);
		if (num3 != null)
		{
			base.SetRoleIcon(roleHeadIcon.Item2, base.GetTexture(1), num3.Value, null, null);
		}
		bool interactable = MainRoleModel.Instance.CanChangeSex();
		UUIInteractionGroup interactionGroup = base.GetInteractionGroup(7);
		if (interactionGroup != null)
		{
			interactionGroup.SetInteractable(interactable);
		}
		int value = ConfigCommonParamById.GetIntConfig("ChangeSexCd").Value;
		LguiUtil.Instance.SetLocalText(base.GetText(4), "GenderTransfer", new <>z__ReadOnlySingleElementList<object>(Math.Round((double)value / TimeUtil.Instance.Hour)));
		LguiUtil.Instance.SetLocalText(base.GetText(5), "Cancel", Array.Empty<object>());
		LguiUtil.Instance.SetLocalText(base.GetText(6), "Confirm", Array.Empty<object>());
	}

	// Token: 0x06014D8C RID: 85388 RVA: 0x0054A310 File Offset: 0x00548510
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x06014D8D RID: 85389 RVA: 0x0054A32E File Offset: 0x0054852E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x06014D8E RID: 85390 RVA: 0x0054A34C File Offset: 0x0054854C
	private void OnRoleChangeEnd()
	{
		ScrollingTipsController.Instance.ShowTipsById("GenderTransferSuccess", Array.Empty<object>());
		base.CloseMe(null);
	}

	// Token: 0x06014D8F RID: 85391 RVA: 0x0054A369 File Offset: 0x00548569
	protected void OnClickCancel()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014D90 RID: 85392 RVA: 0x0054A374 File Offset: 0x00548574
	protected void OnClickConfirm()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		bool flag;
		if (baseCharacter == null)
		{
			flag = (null != null);
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			flag = (((characterActorComponent != null) ? characterActorComponent.Entity : null) != null);
		}
		if (flag)
		{
			BaseTagComponent component = baseCharacter.CharacterActorComponent.Entity.GetComponent<BaseTagComponent>();
			if (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
			{
				ScrollingTipsController.Instance.ShowTipsByText(TextConfig.Instance.GetTextById("CanNotTransferInFight"));
				base.CloseMe(null);
				return;
			}
		}
		if (RoleModel.Instance.HasAnyTrialRole())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_CanNotChangeSexWhenTrail_Text", Array.Empty<object>());
			base.CloseMe(null);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleGenderChangeConfirmBox);
		confirmBoxDataNew.FunctionMap.Add(2, new Action(this.SendRoleSexChangeRequest));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06014D91 RID: 85393 RVA: 0x0054A444 File Offset: 0x00548644
	private void SendRoleSexChangeRequest()
	{
		int sex = (WorldLevelModel.Instance.Sex != 1) ? 1 : 0;
		MainRoleController.Instance.SendRoleSexChangeRequest(sex);
	}

	// Token: 0x06014D92 RID: 85394 RVA: 0x0054A470 File Offset: 0x00548670
	[return: TupleElementNames(new string[]
	{
		"FromPath",
		"TargetPath"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		2
	})]
	private ValueTuple<string, string> GetRoleHeadIcon(RoleInfo fromConfig, RoleInfo targetConfig)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(fromConfig.Id);
		if (roleInstanceById == null)
		{
			return new ValueTuple<string, string>(fromConfig.RoleHeadIconBig, targetConfig.RoleHeadIconBig);
		}
		int roleSkinId = roleInstanceById.GetRoleSkinId();
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(roleSkinId);
		if (roleSkinData == null)
		{
			return new ValueTuple<string, string>(fromConfig.RoleHeadIconBig, targetConfig.RoleHeadIconBig);
		}
		bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
		IReadOnlyList<RoleSkin> skinGroupList = SkinConfig.Instance.GetSkinGroupList(roleSkinData.GetRoleSkinConfig().GroupId);
		if (skinGroupList == null)
		{
			return new ValueTuple<string, string>(fromConfig.RoleHeadIconBig, targetConfig.RoleHeadIconBig);
		}
		string item = null;
		foreach (RoleSkin roleSkin in skinGroupList)
		{
			if (flag)
			{
				if (roleSkin.RoleId == 1501)
				{
					item = roleSkin.RoleHeadIconBig;
				}
			}
			else if (roleSkin.RoleId == 1502)
			{
				item = roleSkin.RoleHeadIconBig;
			}
		}
		return new ValueTuple<string, string>(roleSkinData.GetRoleSkinConfig().RoleHeadIconBig, item);
	}

	// Token: 0x04009CD5 RID: 40149
	private const int MALE_CONFIGID = 1501;

	// Token: 0x04009CD6 RID: 40150
	private const int FEMALE_CONFIGID = 1502;

	// Token: 0x02008E1E RID: 36382
	public enum ERoleGenderChangeViewDefine
	{
		// Token: 0x0402E1C3 RID: 188867
		LeftIcon,
		// Token: 0x0402E1C4 RID: 188868
		RightIcon,
		// Token: 0x0402E1C5 RID: 188869
		CancelButton,
		// Token: 0x0402E1C6 RID: 188870
		ConfirmButton,
		// Token: 0x0402E1C7 RID: 188871
		TitleText,
		// Token: 0x0402E1C8 RID: 188872
		LeftButtonText,
		// Token: 0x0402E1C9 RID: 188873
		RightButtonText,
		// Token: 0x0402E1CA RID: 188874
		ConfirmButtonInteractionGroup
	}
}
