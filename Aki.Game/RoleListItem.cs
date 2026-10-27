using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200279D RID: 10141
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleListItem : GridProxyAbstract<RoleListItemData>
{
	// Token: 0x06014D20 RID: 85280 RVA: 0x005484FC File Offset: 0x005466FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleCallBackInternal))
		};
	}

	// Token: 0x06014D21 RID: 85281 RVA: 0x00548614 File Offset: 0x00546814
	protected override UniTask OnBeforeStartAsync()
	{
		RoleListItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleListItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014D22 RID: 85282 RVA: 0x00548658 File Offset: 0x00546858
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChangeInternal));
		}
	}

	// Token: 0x06014D23 RID: 85283 RVA: 0x00548692 File Offset: 0x00546892
	private void ToggleCallBackInternal(EToggleState toggleState)
	{
		if (this.ToggleCallBack != null)
		{
			this.ToggleCallBack(base.GridIndex);
		}
	}

	// Token: 0x06014D24 RID: 85284 RVA: 0x005486AD File Offset: 0x005468AD
	public bool CanToggleExecuteChangeInternal()
	{
		return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(base.GridIndex);
	}

	// Token: 0x06014D25 RID: 85285 RVA: 0x005486CC File Offset: 0x005468CC
	private void UpdateRoleItem(RoleDataBase roleInstance, bool needTrial = true)
	{
		this.RoleIconItem.Refresh(roleInstance);
		UUISprite sprite = base.GetSprite(8);
		base.GetItem(4).SetUIActive(false);
		if (needTrial && roleInstance.IsTrialRole())
		{
			string trailRoleLabelIconById = RoleUtils.GetTrailRoleLabelIconById(this.DataId);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(trailRoleLabelIconById);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
				return;
			}
		}
		else if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
	}

	// Token: 0x06014D26 RID: 85286 RVA: 0x00548748 File Offset: 0x00546948
	private void UpdateRoleTeamItem(RoleListItemData data)
	{
		int dataId = this.DataId;
		ETeamPositionType teamPositionType = data.TeamPositionType;
		if (teamPositionType == ETeamPositionType.EditFormation)
		{
			this.UpdateRoleTeamEditFormation(dataId);
			return;
		}
		if (teamPositionType != ETeamPositionType.RoleSelect)
		{
			this.UpdateRoleTeamNormal(dataId);
			return;
		}
		this.UpdateRoleTeamRoleSelect(dataId);
	}

	// Token: 0x06014D27 RID: 85287 RVA: 0x00548784 File Offset: 0x00546984
	private void UpdateRoleTeamNormal(int roleId)
	{
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(true);
		SceneTeamItem sceneTeamItem = null;
		int val = 1;
		for (int i = 0; i < teamItems.Count; i++)
		{
			SceneTeamItem sceneTeamItem2 = teamItems[i];
			if (sceneTeamItem2.GetConfigId == roleId)
			{
				sceneTeamItem = sceneTeamItem2;
				val = i + 1;
			}
		}
		if (sceneTeamItem == null)
		{
			this.SetRoleTeamItemRes(0, false);
			return;
		}
		int pos = Math.Min(val, 4);
		this.SetRoleTeamItemRes(pos, false);
	}

	// Token: 0x06014D28 RID: 85288 RVA: 0x005487F4 File Offset: 0x005469F4
	private void UpdateRoleTeamEditFormation(int roleId)
	{
		int roleIndex = RoleSelectModel.Instance.GetRoleIndex(roleId);
		if (roleIndex <= 0)
		{
			this.SetRoleTeamItemRes(0, false);
			return;
		}
		int pos = (int)Math.Ceiling((double)roleIndex / 3.0);
		this.SetRoleTeamItemRes(pos, true);
	}

	// Token: 0x06014D29 RID: 85289 RVA: 0x00548838 File Offset: 0x00546A38
	private void UpdateRoleTeamRoleSelect(int roleId)
	{
		int roleIndex = RoleSelectModel.Instance.GetRoleIndex(roleId);
		if (roleIndex <= 0)
		{
			this.SetRoleTeamItemRes(0, false);
			return;
		}
		this.SetRoleTeamItemRes(roleIndex, true);
	}

	// Token: 0x06014D2A RID: 85290 RVA: 0x00548868 File Offset: 0x00546A68
	private void UpdateIsNewRole()
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.DataId, true);
		base.GetItem(7).SetUIActive(roleDataById.GetIsNew());
	}

	// Token: 0x06014D2B RID: 85291 RVA: 0x0054889C File Offset: 0x00546A9C
	private void UpdateWarningItem(RoleListItemData data)
	{
		if (data.Source == ERoleViewSource.WheelTower)
		{
			IConflictInfo conflictInfo = WheelTowerModel.Instance.CheckConflict(data.RoleDataId);
			base.GetItem(9).SetUIActive(conflictInfo != null);
			return;
		}
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x06014D2C RID: 85292 RVA: 0x005488E4 File Offset: 0x00546AE4
	private void SetRoleTeamItemRes(int pos = 0, bool setSize = false)
	{
		bool flag = pos > 0;
		base.GetItem(2).SetUIActive(flag);
		base.GetItem(5).SetUIActive(flag);
		if (!flag)
		{
			return;
		}
		UUIText text = base.GetText(3);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(pos);
		text.text = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06014D2D RID: 85293 RVA: 0x00548944 File Offset: 0x00546B44
	[NullableContext(2)]
	public UUIItem GetRedDotItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x06014D2E RID: 85294 RVA: 0x00548950 File Offset: 0x00546B50
	public void SetToggleState(EToggleState state, bool force = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (force)
		{
			extendToggle.SetToggleStateForce(state, false, false, false);
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x06014D2F RID: 85295 RVA: 0x00548980 File Offset: 0x00546B80
	public override void Refresh(RoleListItemData data, bool isSelected, int gridIndex)
	{
		this.DataId = data.RoleDataId;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.DataId, true);
		this.UpdateRoleItem(roleDataById, data.NeedShowTrial);
		this.UpdateRoleTeamItem(data);
		this.UpdateIsNewRole();
		this.UpdateWarningItem(data);
		if (data.NeedRedDot)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RoleSystemRoleList, this.GetRedDotItem(), null, this.DataId);
		}
		else
		{
			this.GetRedDotItem().SetUIActive(false);
		}
		if (isSelected)
		{
			this.OnSelected(false);
			return;
		}
		this.OnDeselected(false);
	}

	// Token: 0x06014D30 RID: 85296 RVA: 0x00548A0C File Offset: 0x00546C0C
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(EToggleState.ETT_Checked, true);
		this.TryRemoveRoleNewFlag(this.DataId);
		this.UpdateIsNewRole();
		RoleIconItem roleIconItem = this.RoleIconItem;
		if (roleIconItem == null)
		{
			return;
		}
		roleIconItem.PlaySelectSequence();
	}

	// Token: 0x06014D31 RID: 85297 RVA: 0x00548A38 File Offset: 0x00546C38
	private void TryRemoveRoleNewFlag(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			return;
		}
		if (!roleDataById.TryRemoveNewFlag())
		{
			return;
		}
		NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RoleDataItem);
		EventSystem.Instance.Emit(EEventName.RoleSelectionListUpdate);
	}

	// Token: 0x06014D32 RID: 85298 RVA: 0x00548A7C File Offset: 0x00546C7C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(EToggleState.ETT_UnChecked, true);
		RoleIconItem roleIconItem = this.RoleIconItem;
		if (roleIconItem == null)
		{
			return;
		}
		roleIconItem.StopSelectSequence();
	}

	// Token: 0x06014D33 RID: 85299 RVA: 0x00548A96 File Offset: 0x00546C96
	public UUIExtendToggle GetToggleForGuide()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x04009CBC RID: 40124
	private const int ROLE_MAX_POSITION = 4;

	// Token: 0x04009CBD RID: 40125
	protected int DataId;

	// Token: 0x04009CBE RID: 40126
	[Nullable(2)]
	public RoleIconItem RoleIconItem;

	// Token: 0x04009CBF RID: 40127
	[Nullable(2)]
	public Action<int> ToggleCallBack;

	// Token: 0x04009CC0 RID: 40128
	[Nullable(2)]
	public Func<int, bool> CanToggleExecuteChange;

	// Token: 0x02008E12 RID: 36370
	[NullableContext(0)]
	private enum ERoleListItemDefine
	{
		// Token: 0x0402E182 RID: 188802
		Toggle,
		// Token: 0x0402E183 RID: 188803
		RoleIconItem,
		// Token: 0x0402E184 RID: 188804
		PositionItem,
		// Token: 0x0402E185 RID: 188805
		PositionText,
		// Token: 0x0402E186 RID: 188806
		TrialItem,
		// Token: 0x0402E187 RID: 188807
		TeamItem,
		// Token: 0x0402E188 RID: 188808
		RedDotItem,
		// Token: 0x0402E189 RID: 188809
		IsNewItem,
		// Token: 0x0402E18A RID: 188810
		TrialSprite,
		// Token: 0x0402E18B RID: 188811
		ItemWarning
	}
}
