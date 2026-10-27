using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x02003245 RID: 12869
[NullableContext(1)]
[Nullable(0)]
public class RoleInhalationComponent : EntityComponent
{
	// Token: 0x0601BC64 RID: 113764 RVA: 0x007A8441 File Offset: 0x007A6641
	protected override void OnActivate()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.DisableHandle = new int?(base.Disable("RoleInhalationComponent 默认关闭Tick"));
	}

	// Token: 0x0601BC65 RID: 113765 RVA: 0x007A846C File Offset: 0x007A666C
	protected override void OnTick(float delta)
	{
		CreatureModel.Instance.GetEntitiesInRange(this.InhalationDistance, EEntityTypeQuery.SceneItem, this.QueryEntityResultCache, true, false);
		foreach (EntityHandle entityHandle in this.QueryEntityResultCache)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && entity.Valid && this.CheckCanInhalation(entity, false))
			{
				SceneItemInhaledItemComponent component = entity.GetComponent<SceneItemInhaledItemComponent>();
				component.StartInhalation(base.Entity);
				this.InhalingEntity.Add(component);
				CreatureDataComponent component2 = entity.GetComponent<CreatureDataComponent>();
				if (component2 != null)
				{
					GlobalData.BpEventManager.开始吸取污染物.Broadcast(component2.GetPbDataId());
				}
			}
		}
		List<SceneItemInhaledItemComponent> list = new List<SceneItemInhaledItemComponent>();
		foreach (SceneItemInhaledItemComponent sceneItemInhaledItemComponent in this.InhalingEntity)
		{
			if (sceneItemInhaledItemComponent != null && sceneItemInhaledItemComponent.Valid)
			{
				Entity entity2 = sceneItemInhaledItemComponent.Entity;
				if (entity2 != null && entity2.Valid)
				{
					if (this.CheckCanInhalation(sceneItemInhaledItemComponent.Entity, true))
					{
						continue;
					}
					sceneItemInhaledItemComponent.StopInhalation(true);
					list.Add(sceneItemInhaledItemComponent);
					CreatureDataComponent component3 = sceneItemInhaledItemComponent.Entity.GetComponent<CreatureDataComponent>();
					if (component3 != null)
					{
						GlobalData.BpEventManager.停止吸取污染物.Broadcast(component3.GetPbDataId());
						continue;
					}
					continue;
				}
			}
			list.Add(sceneItemInhaledItemComponent);
		}
		foreach (SceneItemInhaledItemComponent item in list)
		{
			this.InhalingEntity.Remove(item);
		}
	}

	// Token: 0x0601BC66 RID: 113766 RVA: 0x007A8640 File Offset: 0x007A6840
	private bool CheckCanInhalation(Entity entity, bool isInhalation)
	{
		SceneItemInhaledItemComponent component = entity.GetComponent<SceneItemInhaledItemComponent>();
		SceneItemActorComponent component2 = entity.GetComponent<SceneItemActorComponent>();
		LevelTagComponent component3 = entity.GetComponent<LevelTagComponent>();
		if (component == null || component2 == null || component3 == null)
		{
			return false;
		}
		if (component3.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.出生"]))
		{
			return false;
		}
		if (this.InhalingEntity.Contains(component) && !isInhalation)
		{
			return false;
		}
		if (component.IsInCooldown)
		{
			return false;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		Vector v = Vector.Create((actorComp != null) ? actorComp.ActorLocationProxy : null);
		Vector vector = Vector.Create(component2.ActorLocation);
		if (Vector.Dist(v, vector) > (double)this.InhalationDistance)
		{
			return false;
		}
		if (component.IsHaling && !isInhalation)
		{
			return false;
		}
		if (this.CheckAngle != -1f && !this.PowerfulMode)
		{
			CameraController.Instance.MainModel.CameraRotator.Vector(this.TempCameraDir);
			this.TempCameraDir.Normalize(9.99999993922529E-09);
			Vector vector2 = Vector.Create(0.0, 0.0, 0.0);
			vector.Subtraction(CameraController.Instance.MainModel.CameraLocation, vector2);
			vector2.Normalize(9.99999993922529E-09);
			double num = MathUtils.Instance.DotProduct(vector2, this.TempCameraDir);
			double num2 = Math.Cos((double)this.CheckAngle * 3.141592653589793 / 180.0);
			if (num < num2)
			{
				return false;
			}
		}
		if (this.TagIds != null && this.TagIds.Length != 0)
		{
			foreach (int tagId in this.TagIds)
			{
				if (!component3.HasTag(tagId))
				{
					return false;
				}
			}
		}
		int? inhaledStrength = component.InhaledStrength;
		int i = this.InhalationStrength;
		return !(inhaledStrength.GetValueOrDefault() > i & inhaledStrength != null);
	}

	// Token: 0x0601BC67 RID: 113767 RVA: 0x007A8820 File Offset: 0x007A6A20
	[NullableContext(2)]
	public void StartInhalation(float strength, float distance, bool isPowerfulMode, float checkAngle, FGameplayTag[] tags)
	{
		if (this.DisableHandle == null)
		{
			return;
		}
		base.Enable(new int?(this.DisableHandle.Value), "RoleInhalationComponent 开始吸取");
		this.DisableHandle = null;
		this.InhalationStrength = (int)strength;
		this.InhalationDistance = distance;
		this.PowerfulMode = isPowerfulMode;
		this.CheckAngle = checkAngle;
		this.TagIds = Array.Empty<int>();
		if (tags != null)
		{
			this.TagIds = new int[tags.Length];
			for (int i = 0; i < tags.Length; i++)
			{
				this.TagIds[i] = GameplayTagUtils.GetTagIdByName(tags[i].TagName.ToString());
			}
		}
	}

	// Token: 0x0601BC68 RID: 113768 RVA: 0x007A88D4 File Offset: 0x007A6AD4
	public void StopInhalation()
	{
		if (this.DisableHandle != null)
		{
			return;
		}
		this.CheckAngle = -1f;
		this.DisableHandle = new int?(base.Disable("RoleInhalationComponent 停止吸取"));
		foreach (SceneItemInhaledItemComponent sceneItemInhaledItemComponent in this.InhalingEntity)
		{
			sceneItemInhaledItemComponent.StopInhalation(true);
		}
		this.InhalingEntity.Clear();
	}

	// Token: 0x0601BC69 RID: 113769 RVA: 0x007A8960 File Offset: 0x007A6B60
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleInhalationComponent roleInhalationComponent = (RoleInhalationComponent)componentTemplate;
		if (base.CanResetComponentProperty("DisableHandle"))
		{
			this.DisableHandle = roleInhalationComponent.DisableHandle;
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (roleInhalationComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InhalationStrength"))
		{
			this.InhalationStrength = roleInhalationComponent.InhalationStrength;
		}
		if (base.CanResetComponentProperty("PowerfulMode"))
		{
			this.PowerfulMode = roleInhalationComponent.PowerfulMode;
		}
		if (base.CanResetComponentProperty("InhalationDistance"))
		{
			this.InhalationDistance = roleInhalationComponent.InhalationDistance;
		}
		if (base.CanResetComponentProperty("TagIds"))
		{
			if (roleInhalationComponent.TagIds == null)
			{
				this.TagIds = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int[]>(this.TagIds), "TagIds"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("QueryEntityResultCache") && roleInhalationComponent.QueryEntityResultCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<EntityHandle>>(this.QueryEntityResultCache), "QueryEntityResultCache"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InhalingEntity") && roleInhalationComponent.InhalingEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemInhaledItemComponent>(this.InhalingEntity), "InhalingEntity"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CheckAngle"))
		{
			this.CheckAngle = roleInhalationComponent.CheckAngle;
		}
		return !base.CanResetComponentProperty("TempCameraDir") || roleInhalationComponent.TempCameraDir == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempCameraDir), "TempCameraDir");
	}

	// Token: 0x0400DACD RID: 56013
	private int? DisableHandle;

	// Token: 0x0400DACE RID: 56014
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DACF RID: 56015
	private int InhalationStrength = -1;

	// Token: 0x0400DAD0 RID: 56016
	private bool PowerfulMode;

	// Token: 0x0400DAD1 RID: 56017
	private float InhalationDistance;

	// Token: 0x0400DAD2 RID: 56018
	[Nullable(2)]
	private int[] TagIds;

	// Token: 0x0400DAD3 RID: 56019
	private readonly List<EntityHandle> QueryEntityResultCache = new List<EntityHandle>();

	// Token: 0x0400DAD4 RID: 56020
	private readonly HashSet<SceneItemInhaledItemComponent> InhalingEntity = new HashSet<SceneItemInhaledItemComponent>();

	// Token: 0x0400DAD5 RID: 56021
	private float CheckAngle = -1f;

	// Token: 0x0400DAD6 RID: 56022
	private readonly Vector TempCameraDir = Vector.Create();
}
