using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001F39 RID: 7993
[NullableContext(1)]
[Nullable(0)]
public class RoleSideEnergyHandle : HudUnitHandleBase
{
	// Token: 0x0600F6C6 RID: 63174 RVA: 0x003B9DC8 File Offset: 0x003B7FC8
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.Refresh();
	}

	// Token: 0x0600F6C7 RID: 63175 RVA: 0x003B9DD8 File Offset: 0x003B7FD8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddRoleSideEnergyBar, new Action<int, GameplayCue, bool, int>(this.OnAddRoleSideEnergy));
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.SeamlessTravelUIRefresh, new Action(this.RefreshShow));
		EventSystem.Instance.Add<Entity>(EEventName.BattleUiRemoveRoleData, new Action<Entity>(this.OnRemoveEntity));
	}

	// Token: 0x0600F6C8 RID: 63176 RVA: 0x003B9E58 File Offset: 0x003B8058
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, GameplayCue, bool, int>(EEventName.CharOnBuffAddRoleSideEnergyBar, new Action<int, GameplayCue, bool, int>(this.OnAddRoleSideEnergy));
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.SeamlessTravelUIRefresh, new Action(this.RefreshShow));
		EventSystem.Instance.Remove<Entity>(EEventName.BattleUiRemoveRoleData, new Action<Entity>(this.OnRemoveEntity));
	}

	// Token: 0x0600F6C9 RID: 63177 RVA: 0x003B9ED5 File Offset: 0x003B80D5
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

	// Token: 0x0600F6CA RID: 63178 RVA: 0x003B9EF6 File Offset: 0x003B80F6
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		this.Refresh();
		this.RefreshAllUnitVisible();
	}

	// Token: 0x0600F6CB RID: 63179 RVA: 0x003B9F04 File Offset: 0x003B8104
	private void RefreshShow()
	{
		this.Refresh();
		this.RefreshAllUnitVisible();
	}

	// Token: 0x0600F6CC RID: 63180 RVA: 0x003B9F14 File Offset: 0x003B8114
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

	// Token: 0x0600F6CD RID: 63181 RVA: 0x003B9F80 File Offset: 0x003B8180
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

	// Token: 0x0600F6CE RID: 63182 RVA: 0x003B9FF4 File Offset: 0x003B81F4
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

	// Token: 0x0600F6CF RID: 63183 RVA: 0x003BA07C File Offset: 0x003B827C
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

	// Token: 0x0600F6D0 RID: 63184 RVA: 0x003BA100 File Offset: 0x003B8300
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

	// Token: 0x0600F6D1 RID: 63185 RVA: 0x003BA1B8 File Offset: 0x003B83B8
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

	// Token: 0x0600F6D2 RID: 63186 RVA: 0x003BA20C File Offset: 0x003B840C
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

	// Token: 0x0600F6D3 RID: 63187 RVA: 0x003BA2AC File Offset: 0x003B84AC
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

	// Token: 0x04007246 RID: 29254
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<string, Type> _roleSideEnergyUnitClassMap = new Dictionary<string, Type>
	{
		{
			"UiItem_LupaEmerge",
			typeof(RoleSideEnergyUnit)
		}
	};

	// Token: 0x04007247 RID: 29255
	[Nullable(2)]
	private BattleUiRoleData RoleData;

	// Token: 0x04007248 RID: 29256
	private int EntityId;

	// Token: 0x04007249 RID: 29257
	private readonly Dictionary<int, RoleSideEnergyBarInfo> BarInfoMap = new Dictionary<int, RoleSideEnergyBarInfo>();

	// Token: 0x0400724A RID: 29258
	private bool IsCalcScreenPos;

	// Token: 0x0400724B RID: 29259
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x0400724C RID: 29260
	private bool InScreen;
}
