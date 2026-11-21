using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020013FB RID: 5115
[NullableContext(1)]
[Nullable(0)]
public class RoleSideEnergyHandle : HudUnitHandleBase
{
	// Token: 0x0600CAE5 RID: 51941 RVA: 0x003C58B4 File Offset: 0x003C3AB4
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.Refresh();
	}

	// Token: 0x0600CAE6 RID: 51942 RVA: 0x003C58C4 File Offset: 0x003C3AC4
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddRoleSideEnergyBar, new Action<int, GameplayCue, bool, int>(this.OnAddRoleSideEnergy));
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.SeamlessTravelUIRefresh, new Action(this.RefreshShow));
		EventSystem.Instance.Add<Entity>(EEventName.BattleUiRemoveRoleData, new Action<Entity>(this.OnRemoveEntity));
	}

	// Token: 0x0600CAE7 RID: 51943 RVA: 0x003C5944 File Offset: 0x003C3B44
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddRoleSideEnergyBar, new Action<int, GameplayCue, bool, int>(this.OnAddRoleSideEnergy));
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.SeamlessTravelUIRefresh, new Action(this.RefreshShow));
		EventSystem.Instance.Remove<Entity>(EEventName.BattleUiRemoveRoleData, new Action<Entity>(this.OnRemoveEntity));
	}

	// Token: 0x0600CAE8 RID: 51944 RVA: 0x003C59C1 File Offset: 0x003C3BC1
	private void OnAddRoleSideEnergy(int entityId, GameplayCue cue, bool isAdd, int handleId)
	{
		if (this.EntityId != entityId)
		{
			return;
		}
		if (isAdd)
		{
			this.AddEnergyBar(cue, handleId);
			return;
		}
		this.RemoveEnergyBar(handleId);
	}

	// Token: 0x0600CAE9 RID: 51945 RVA: 0x003C59E2 File Offset: 0x003C3BE2
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.Refresh();
		this.RefreshAllUnitVisible();
	}

	// Token: 0x0600CAEA RID: 51946 RVA: 0x003C59F0 File Offset: 0x003C3BF0
	private void RefreshShow()
	{
		this.Refresh();
		this.RefreshAllUnitVisible();
	}

	// Token: 0x0600CAEB RID: 51947 RVA: 0x003C5A00 File Offset: 0x003C3C00
	private void OnRemoveEntity(Entity entity)
	{
		foreach (KeyValuePair<int, RoleSideEnergyBarInfo> keyValuePair in this.BarInfoMap)
		{
			int num;
			RoleSideEnergyBarInfo roleSideEnergyBarInfo;
			keyValuePair.Deconstruct(out num, out roleSideEnergyBarInfo);
			int handleId = num;
			if (roleSideEnergyBarInfo.RoleSideEnergyUnit != null)
			{
				this.RemoveEnergyBar(handleId);
			}
		}
	}

	// Token: 0x0600CAEC RID: 51948 RVA: 0x003C5A6C File Offset: 0x003C3C6C
	private void RefreshAllUnitVisible()
	{
		foreach (RoleSideEnergyBarInfo roleSideEnergyBarInfo in this.BarInfoMap.Values)
		{
			if (roleSideEnergyBarInfo.RoleSideEnergyUnit != null)
			{
				roleSideEnergyBarInfo.RoleSideEnergyUnit.SetVisible(roleSideEnergyBarInfo.EntityId == this.EntityId, 0);
			}
		}
	}

	// Token: 0x0600CAED RID: 51949 RVA: 0x003C5AE0 File Offset: 0x003C3CE0
	private void Refresh()
	{
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (curRoleData == this.RoleData)
		{
			return;
		}
		if (curRoleData != null)
		{
			EntityHandle entityHandle = curRoleData.EntityHandle;
			if (((entityHandle != null) ? new bool?(entityHandle.Valid) : null).GetValueOrDefault())
			{
				this.RoleData = curRoleData;
				WorldEntity entity = curRoleData.EntityHandle.Entity;
				this.EntityId = ((entity != null) ? entity.Id : 0);
				goto IL_75;
			}
		}
		this.RoleData = null;
		this.EntityId = 0;
		IL_75:
		this.RefreshEnergyBar();
	}

	// Token: 0x0600CAEE RID: 51950 RVA: 0x003C5B68 File Offset: 0x003C3D68
	private void RefreshEnergyBar()
	{
		if (this.RoleData == null)
		{
			return;
		}
		foreach (GameplayCueBase gameplayCueBase in this.RoleData.EntityHandle.Entity.GetComponent<CharacterGameplayCueComponent>().GetAllCurrentCueRef())
		{
			GameplayCue cueConfig = gameplayCueBase.CueConfig;
			if (cueConfig.CueType == 20)
			{
				this.AddEnergyBar(cueConfig, gameplayCueBase.BuffHandleId);
			}
		}
	}

	// Token: 0x0600CAEF RID: 51951 RVA: 0x003C5BEC File Offset: 0x003C3DEC
	private void AddEnergyBar(GameplayCue cueConfig, int handleId)
	{
		if (this.BarInfoMap.ContainsKey(handleId))
		{
			return;
		}
		RoleSideEnergyBarInfo barInfo = new RoleSideEnergyBarInfo();
		barInfo.EntityId = this.EntityId;
		barInfo.BuffCueConfig = new GameplayCue?(cueConfig);
		this.BarInfoMap[handleId] = barInfo;
		Type type2;
		Type type = RoleSideEnergyHandle._roleSideEnergyUnitClassMap.TryGetValue(cueConfig.Path, out type2) ? type2 : null;
		if (type == null)
		{
			type = typeof(RoleSideEnergyUnit);
		}
		base.NewHudUnit<RoleSideEnergyUnit>(type, cueConfig.Path, true, false).ContinueWith(delegate(RoleSideEnergyUnit unit)
		{
			if (unit == null)
			{
				return;
			}
			if (barInfo.BuffCueConfig == null)
			{
				this.DestroyHudUnit(unit);
				return;
			}
			BattleUiRoleData roleData = BattleUiModel.Instance.GetRoleData(barInfo.EntityId);
			if (roleData == null)
			{
				this.DestroyHudUnit(unit);
				return;
			}
			barInfo.RoleSideEnergyUnit = unit;
			unit.InitInfo(barInfo.BuffCueConfig.Value, roleData);
			unit.SetVisible(barInfo.EntityId == this.EntityId, 0);
		});
	}

	// Token: 0x0600CAF0 RID: 51952 RVA: 0x003C5CA4 File Offset: 0x003C3EA4
	private void RemoveEnergyBar(int handleId)
	{
		RoleSideEnergyBarInfo roleSideEnergyBarInfo;
		if (!this.BarInfoMap.TryGetValue(handleId, out roleSideEnergyBarInfo))
		{
			return;
		}
		this.BarInfoMap.Remove(handleId);
		roleSideEnergyBarInfo.BuffCueConfig = null;
		if (roleSideEnergyBarInfo.RoleSideEnergyUnit != null)
		{
			base.DestroyHudUnit(roleSideEnergyBarInfo.RoleSideEnergyUnit);
			roleSideEnergyBarInfo.RoleSideEnergyUnit = null;
		}
	}

	// Token: 0x0600CAF1 RID: 51953 RVA: 0x003C5CF8 File Offset: 0x003C3EF8
	protected override void OnTick(float delta)
	{
		this.IsCalcScreenPos = false;
		foreach (RoleSideEnergyBarInfo roleSideEnergyBarInfo in this.BarInfoMap.Values)
		{
			if (roleSideEnergyBarInfo.RoleSideEnergyUnit != null && roleSideEnergyBarInfo.EntityId == this.EntityId)
			{
				if (!this.IsCalcScreenPos)
				{
					this.CalcScreenPos();
					this.IsCalcScreenPos = true;
				}
				if (this.InScreen)
				{
					roleSideEnergyBarInfo.RoleSideEnergyUnit.RefreshTargetPosition(delta, this.ScreenPos);
				}
			}
		}
	}

	// Token: 0x0600CAF2 RID: 51954 RVA: 0x003C5D98 File Offset: 0x003C3F98
	private void CalcScreenPos()
	{
		this.InScreen = false;
		BattleUiRoleData roleData = this.RoleData;
		CharacterActorComponent characterActorComponent;
		if (roleData == null)
		{
			characterActorComponent = null;
		}
		else
		{
			EntityHandle entityHandle = roleData.EntityHandle;
			if (entityHandle == null)
			{
				characterActorComponent = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
			}
		}
		CharacterActorComponent characterActorComponent2 = characterActorComponent;
		if (characterActorComponent2 == null)
		{
			return;
		}
		TsBaseCharacter actor = characterActorComponent2.Actor;
		if (actor == null || !actor.IsValid())
		{
			return;
		}
		FVectorDouble actorLocation = characterActorComponent2.ActorLocation;
		this.InScreen = HudUnitUtils.PositionUtil.ProjectWorldToScreen(actorLocation, this.ScreenPos);
	}

	// Token: 0x04007327 RID: 29479
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<string, Type> _roleSideEnergyUnitClassMap = new Dictionary<string, Type>
	{
		{
			"UiItem_LupaEmerge",
			typeof(RoleSideEnergyUnit)
		}
	};

	// Token: 0x04007328 RID: 29480
	[Nullable(2)]
	private BattleUiRoleData RoleData;

	// Token: 0x04007329 RID: 29481
	private int EntityId;

	// Token: 0x0400732A RID: 29482
	private readonly Dictionary<int, RoleSideEnergyBarInfo> BarInfoMap = new Dictionary<int, RoleSideEnergyBarInfo>();

	// Token: 0x0400732B RID: 29483
	private bool IsCalcScreenPos;

	// Token: 0x0400732C RID: 29484
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x0400732D RID: 29485
	private bool InScreen;
}
