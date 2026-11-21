using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D17 RID: 7447
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleListItem : GridProxyAbstract<RoleListItemData>
{
	// Token: 0x060126F3 RID: 75507 RVA: 0x005725F0 File Offset: 0x005707F0
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
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleCallBackInternal))
		};
	}

	// Token: 0x060126F4 RID: 75508 RVA: 0x00572720 File Offset: 0x00570920
	protected override UniTask OnBeforeStartAsync()
	{
		RoleListItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleListItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060126F5 RID: 75509 RVA: 0x00572764 File Offset: 0x00570964
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChangeInternal));
		}
	}

	// Token: 0x060126F6 RID: 75510 RVA: 0x0057279E File Offset: 0x0057099E
	private void ToggleCallBackInternal(EToggleState toggleState)
	{
		if (this.ToggleCallBack != null)
		{
			this.ToggleCallBack(base.GridIndex);
		}
	}

	// Token: 0x060126F7 RID: 75511 RVA: 0x005727B9 File Offset: 0x005709B9
	public bool CanToggleExecuteChangeInternal()
	{
		return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(base.GridIndex);
	}

	// Token: 0x060126F8 RID: 75512 RVA: 0x005727D8 File Offset: 0x005709D8
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

	// Token: 0x060126F9 RID: 75513 RVA: 0x00572854 File Offset: 0x00570A54
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

	// Token: 0x060126FA RID: 75514 RVA: 0x00572890 File Offset: 0x00570A90
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

	// Token: 0x060126FB RID: 75515 RVA: 0x00572900 File Offset: 0x00570B00
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

	// Token: 0x060126FC RID: 75516 RVA: 0x00572944 File Offset: 0x00570B44
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

	// Token: 0x060126FD RID: 75517 RVA: 0x00572974 File Offset: 0x00570B74
	private void UpdateIsNewRole()
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.DataId, true);
		base.GetItem(7).SetUIActive(roleDataById.GetIsNew() && !this.IsDevelopTarget());
	}

	// Token: 0x060126FE RID: 75518 RVA: 0x005729B4 File Offset: 0x00570BB4
	private bool IsDevelopTarget()
	{
		int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
		return devTargetRoleId > 0 && this.DataId == devTargetRoleId;
	}

	// Token: 0x060126FF RID: 75519 RVA: 0x005729DB File Offset: 0x00570BDB
	private void UpdateDevelopItem()
	{
		base.GetItem(10).SetUIActive(this.IsDevelopTarget());
	}

	// Token: 0x06012700 RID: 75520 RVA: 0x005729F0 File Offset: 0x00570BF0
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

	// Token: 0x06012701 RID: 75521 RVA: 0x00572A38 File Offset: 0x00570C38
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

	// Token: 0x06012702 RID: 75522 RVA: 0x00572A98 File Offset: 0x00570C98
	[NullableContext(2)]
	public UUIItem GetRedDotItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x06012703 RID: 75523 RVA: 0x00572AA4 File Offset: 0x00570CA4
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

	// Token: 0x06012704 RID: 75524 RVA: 0x00572AD4 File Offset: 0x00570CD4
	public override void Refresh(RoleListItemData data, bool isSelected, int gridIndex)
	{
		this.DataId = data.RoleDataId;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.DataId, true);
		this.UpdateRoleItem(roleDataById, data.NeedShowTrial);
		this.UpdateRoleTeamItem(data);
		this.UpdateIsNewRole();
		this.UpdateDevelopItem();
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

	// Token: 0x06012705 RID: 75525 RVA: 0x00572B66 File Offset: 0x00570D66
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

	// Token: 0x06012706 RID: 75526 RVA: 0x00572B94 File Offset: 0x00570D94
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

	// Token: 0x06012707 RID: 75527 RVA: 0x00572BD8 File Offset: 0x00570DD8
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

	// Token: 0x06012708 RID: 75528 RVA: 0x00572BF2 File Offset: 0x00570DF2
	public UUIExtendToggle GetToggleForGuide()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0400A08A RID: 41098
	private const int ROLE_MAX_POSITION = 4;

	// Token: 0x0400A08B RID: 41099
	protected int DataId;

	// Token: 0x0400A08C RID: 41100
	[Nullable(2)]
	public RoleIconItem RoleIconItem;

	// Token: 0x0400A08D RID: 41101
	[Nullable(2)]
	public Action<int> ToggleCallBack;

	// Token: 0x0400A08E RID: 41102
	[Nullable(2)]
	public Func<int, bool> CanToggleExecuteChange;

	// Token: 0x02008057 RID: 32855
	[NullableContext(0)]
	private enum ERoleListItemDefine
	{
		// Token: 0x0402985D RID: 170077
		Toggle,
		// Token: 0x0402985E RID: 170078
		RoleIconItem,
		// Token: 0x0402985F RID: 170079
		PositionItem,
		// Token: 0x04029860 RID: 170080
		PositionText,
		// Token: 0x04029861 RID: 170081
		TrialItem,
		// Token: 0x04029862 RID: 170082
		TeamItem,
		// Token: 0x04029863 RID: 170083
		RedDotItem,
		// Token: 0x04029864 RID: 170084
		IsNewItem,
		// Token: 0x04029865 RID: 170085
		TrialSprite,
		// Token: 0x04029866 RID: 170086
		ItemWarning,
		// Token: 0x04029867 RID: 170087
		DevelopItem
	}
}
