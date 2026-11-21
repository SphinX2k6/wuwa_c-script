using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x020013F9 RID: 5113
[NullableContext(1)]
[Nullable(0)]
public class RaceStrengthHandle : HudUnitHandleBase
{
	// Token: 0x0600CAD1 RID: 51921 RVA: 0x003C5424 File Offset: 0x003C3624
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

	// Token: 0x0600CAD2 RID: 51922 RVA: 0x003C5453 File Offset: 0x003C3653
	protected virtual void InitTagAndAttributeId()
	{
		this.FormationAttributeId = EFormationAttributeId.MigrationStrength;
		this.VisibleTagId = GameplayTagDefine.EGameplayTagId["关卡.滑水.专用UI"];
		this.SpeedUpTagId = GameplayTagDefine.EGameplayTagId["关卡.滑水.能量值不衰减"];
	}

	// Token: 0x0600CAD3 RID: 51923 RVA: 0x003C5488 File Offset: 0x003C3688
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

	// Token: 0x0600CAD4 RID: 51924 RVA: 0x003C553E File Offset: 0x003C373E
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

	// Token: 0x0600CAD5 RID: 51925 RVA: 0x003C5564 File Offset: 0x003C3764
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

	// Token: 0x0600CAD6 RID: 51926 RVA: 0x003C55BD File Offset: 0x003C37BD
	protected override void OnDestroyed()
	{
		base.OnDestroyed();
		this.StrengthUnit = null;
		this.RefreshRole(null);
	}

	// Token: 0x0600CAD7 RID: 51927 RVA: 0x003C55D3 File Offset: 0x003C37D3
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
	}

	// Token: 0x0600CAD8 RID: 51928 RVA: 0x003C55F1 File Offset: 0x003C37F1
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.RemoveAllTargetUseKey(this);
	}

	// Token: 0x0600CAD9 RID: 51929 RVA: 0x003C561C File Offset: 0x003C381C
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

	// Token: 0x0600CADA RID: 51930 RVA: 0x003C5698 File Offset: 0x003C3898
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

	// Token: 0x0600CADB RID: 51931 RVA: 0x003C573C File Offset: 0x003C393C
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.RefreshRole(BattleUiModel.Instance.GetCurRoleData());
	}

	// Token: 0x0600CADC RID: 51932 RVA: 0x003C574E File Offset: 0x003C394E
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		BattleUiRoleData roleData = this.RoleData;
		if (((roleData != null) ? roleData.EntityHandle : null) == handle)
		{
			this.RemoveEntityEvents();
		}
	}

	// Token: 0x0600CADD RID: 51933 RVA: 0x003C576B File Offset: 0x003C396B
	private void OnVisibleTagChanged(int tagId, bool tagExist)
	{
		this.IsVisible = tagExist;
		this.RefreshUnit();
	}

	// Token: 0x0600CADE RID: 51934 RVA: 0x003C577A File Offset: 0x003C397A
	private void OnSpeedUpTagChanged(int tagId, bool tagExist)
	{
		this.IsSpeedUp = tagExist;
	}

	// Token: 0x0600CADF RID: 51935 RVA: 0x003C5784 File Offset: 0x003C3984
	private void ListenForTagAddOrRemove(int tagId, Action<int, bool> callback)
	{
		ITagTask tagTask = this.RoleData.GameplayTagComponent.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), null);
		if (tagTask == null)
		{
			return;
		}
		this.TagTaskList.Add(tagTask);
	}

	// Token: 0x0600CAE0 RID: 51936 RVA: 0x003C57C8 File Offset: 0x003C39C8
	private void RefreshStrengthPercent()
	{
		float value = FormationAttributeController.Instance.GetValue(this.FormationAttributeId);
		float max = FormationAttributeController.Instance.GetMax(this.FormationAttributeId);
		this.StrengthUnit.SetStrengthPercent(value, max);
	}

	// Token: 0x0600CAE1 RID: 51937 RVA: 0x003C5804 File Offset: 0x003C3A04
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

	// Token: 0x0400731C RID: 29468
	protected int VisibleTagId;

	// Token: 0x0400731D RID: 29469
	protected int SpeedUpTagId;

	// Token: 0x0400731E RID: 29470
	protected EFormationAttributeId FormationAttributeId = EFormationAttributeId.MigrationStrength;

	// Token: 0x0400731F RID: 29471
	[Nullable(2)]
	protected MigrationStrengthUnit StrengthUnit;

	// Token: 0x04007320 RID: 29472
	[Nullable(2)]
	protected BattleUiRoleData RoleData;

	// Token: 0x04007321 RID: 29473
	protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x04007322 RID: 29474
	protected bool IsVisible;

	// Token: 0x04007323 RID: 29475
	protected bool IsSpeedUp;
}
