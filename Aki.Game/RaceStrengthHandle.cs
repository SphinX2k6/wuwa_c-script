using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02001F37 RID: 7991
[NullableContext(1)]
[Nullable(0)]
public class RaceStrengthHandle : HudUnitHandleBase
{
	// Token: 0x0600F6B2 RID: 63154 RVA: 0x003B9938 File Offset: 0x003B7B38
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.InitTagAndAttributeId();
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (curRoleData == null)
		{
			return;
		}
		this.RefreshRole(curRoleData);
	}

	// Token: 0x0600F6B3 RID: 63155 RVA: 0x003B9967 File Offset: 0x003B7B67
	protected virtual void InitTagAndAttributeId()
	{
		this.FormationAttributeId = EFormationAttributeId.MigrationStrength;
		this.VisibleTagId = GameplayTagDefine.EGameplayTagId["关卡.滑水.专用UI"];
		this.SpeedUpTagId = GameplayTagDefine.EGameplayTagId["关卡.滑水.能量值不衰减"];
	}

	// Token: 0x0600F6B4 RID: 63156 RVA: 0x003B999C File Offset: 0x003B7B9C
	[NullableContext(2)]
	private void RefreshRole(BattleUiRoleData roleData)
	{
		this.RemoveEntityEvents();
		if (roleData != null)
		{
			EntityHandle entityHandle = roleData.EntityHandle;
			if (entityHandle != null && entityHandle.Valid)
			{
				this.RoleData = roleData;
				MigrationStrengthUnit strengthUnit = this.StrengthUnit;
				if (strengthUnit != null)
				{
					strengthUnit.RefreshEntity(roleData);
				}
				this.AddEntityEvents();
				this.IsVisible = this.RoleData.GameplayTagComponent.HasTag(this.VisibleTagId);
				this.IsSpeedUp = this.RoleData.GameplayTagComponent.HasTag(this.SpeedUpTagId);
				this.RefreshUnit();
				return;
			}
		}
		this.RoleData = null;
		MigrationStrengthUnit strengthUnit2 = this.StrengthUnit;
		if (strengthUnit2 != null)
		{
			strengthUnit2.RefreshEntity(null);
		}
		MigrationStrengthUnit strengthUnit3 = this.StrengthUnit;
		if (strengthUnit3 == null)
		{
			return;
		}
		strengthUnit3.SetVisible(false, 0);
	}

	// Token: 0x0600F6B5 RID: 63157 RVA: 0x003B9A52 File Offset: 0x003B7C52
	private void RefreshUnit()
	{
		if (this.IsVisible)
		{
			this.TryCreateUnit();
			return;
		}
		MigrationStrengthUnit strengthUnit = this.StrengthUnit;
		if (strengthUnit == null)
		{
			return;
		}
		strengthUnit.SetVisible(false, 0);
	}

	// Token: 0x0600F6B6 RID: 63158 RVA: 0x003B9A78 File Offset: 0x003B7C78
	private void TryCreateUnit()
	{
		if (this.StrengthUnit != null)
		{
			this.StrengthUnit.SetVisible(true, 0);
			return;
		}
		base.NewHudUnitWithReturn<MigrationStrengthUnit>(typeof(MigrationStrengthUnit), "UiItem_EnduranceB", out this.StrengthUnit, false, delegate(MigrationStrengthUnit _)
		{
			if (this.StrengthUnit != null)
			{
				this.StrengthUnit.InitData(4);
				this.StrengthUnit.RefreshEntity(this.RoleData);
				this.RefreshStrengthPercent();
			}
		}, false);
		this.StrengthUnit.SetVisible(true, 0);
	}

	// Token: 0x0600F6B7 RID: 63159 RVA: 0x003B9AD1 File Offset: 0x003B7CD1
	protected override void OnDestroyed()
	{
		base.OnDestroyed();
		this.StrengthUnit = null;
		this.RefreshRole(null);
	}

	// Token: 0x0600F6B8 RID: 63160 RVA: 0x003B9AE7 File Offset: 0x003B7CE7
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
	}

	// Token: 0x0600F6B9 RID: 63161 RVA: 0x003B9B05 File Offset: 0x003B7D05
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.RemoveAllTargetUseKey(this);
	}

	// Token: 0x0600F6BA RID: 63162 RVA: 0x003B9B30 File Offset: 0x003B7D30
	private void AddEntityEvents()
	{
		this.ListenForTagAddOrRemove(this.VisibleTagId, new Action<int, bool>(this.OnVisibleTagChanged));
		this.ListenForTagAddOrRemove(this.SpeedUpTagId, new Action<int, bool>(this.OnSpeedUpTagChanged));
		BattleUiRoleData roleData = this.RoleData;
		if (((roleData != null) ? roleData.EntityHandle : null) != null)
		{
			EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, this.RoleData.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x0600F6BB RID: 63163 RVA: 0x003B9BAC File Offset: 0x003B7DAC
	private void RemoveEntityEvents()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			if (tagTask != null)
			{
				tagTask.EndTask();
			}
		}
		this.TagTaskList.Clear();
		BattleUiRoleData roleData = this.RoleData;
		if (((roleData != null) ? roleData.EntityHandle : null) != null)
		{
			EventSystem instance = EventSystem.Instance;
			BattleUiRoleData roleData2 = this.RoleData;
			instance.RemoveWithTargetUseKey<ERemoveEntityType, EntityHandle>(this, (roleData2 != null) ? roleData2.EntityHandle : null, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x0600F6BC RID: 63164 RVA: 0x003B9C50 File Offset: 0x003B7E50
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.RefreshRole(BattleUiModel.Instance.GetCurRoleData());
	}

	// Token: 0x0600F6BD RID: 63165 RVA: 0x003B9C62 File Offset: 0x003B7E62
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		BattleUiRoleData roleData = this.RoleData;
		if (((roleData != null) ? roleData.EntityHandle : null) == handle)
		{
			this.RemoveEntityEvents();
		}
	}

	// Token: 0x0600F6BE RID: 63166 RVA: 0x003B9C7F File Offset: 0x003B7E7F
	private void OnVisibleTagChanged(int tagId, bool tagExist)
	{
		this.IsVisible = tagExist;
		this.RefreshUnit();
	}

	// Token: 0x0600F6BF RID: 63167 RVA: 0x003B9C8E File Offset: 0x003B7E8E
	private void OnSpeedUpTagChanged(int tagId, bool tagExist)
	{
		this.IsSpeedUp = tagExist;
	}

	// Token: 0x0600F6C0 RID: 63168 RVA: 0x003B9C98 File Offset: 0x003B7E98
	private void ListenForTagAddOrRemove(int tagId, Action<int, bool> callback)
	{
		ITagTask tagTask = this.RoleData.GameplayTagComponent.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), null);
		if (tagTask == null)
		{
			return;
		}
		this.TagTaskList.Add(tagTask);
	}

	// Token: 0x0600F6C1 RID: 63169 RVA: 0x003B9CDC File Offset: 0x003B7EDC
	private void RefreshStrengthPercent()
	{
		float value = FormationAttributeController.Instance.GetValue(this.FormationAttributeId);
		float max = FormationAttributeController.Instance.GetMax(this.FormationAttributeId);
		this.StrengthUnit.SetStrengthPercent(value, max);
	}

	// Token: 0x0600F6C2 RID: 63170 RVA: 0x003B9D18 File Offset: 0x003B7F18
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (!this.IsVisible || this.StrengthUnit == null || !this.StrengthUnit.IsShowOrShowing)
		{
			return;
		}
		this.StrengthUnit.RefreshTargetPosition(delta);
		this.StrengthUnit.SetRecoverState(this.IsSpeedUp);
		this.RefreshStrengthPercent();
		this.StrengthUnit.TickRecoverAnim(delta);
	}

	// Token: 0x0400723B RID: 29243
	protected int VisibleTagId;

	// Token: 0x0400723C RID: 29244
	protected int SpeedUpTagId;

	// Token: 0x0400723D RID: 29245
	protected EFormationAttributeId FormationAttributeId = EFormationAttributeId.MigrationStrength;

	// Token: 0x0400723E RID: 29246
	[Nullable(2)]
	protected MigrationStrengthUnit StrengthUnit;

	// Token: 0x0400723F RID: 29247
	[Nullable(2)]
	protected BattleUiRoleData RoleData;

	// Token: 0x04007240 RID: 29248
	protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x04007241 RID: 29249
	protected bool IsVisible;

	// Token: 0x04007242 RID: 29250
	protected bool IsSpeedUp;
}
