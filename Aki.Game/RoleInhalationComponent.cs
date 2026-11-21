using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x020027B4 RID: 10164
[NullableContext(1)]
[Nullable(0)]
public class RoleInhalationComponent : EntityComponent
{
	// Token: 0x06019816 RID: 104470 RVA: 0x007D0BA0 File Offset: 0x007CEDA0
	protected override void OnActivate()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.DisableHandle = new int?(base.Disable("RoleInhalationComponent 默认关闭Tick"));
	}

	// Token: 0x06019817 RID: 104471 RVA: 0x007D0BCC File Offset: 0x007CEDCC
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

	// Token: 0x06019818 RID: 104472 RVA: 0x007D0DA0 File Offset: 0x007CEFA0
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

	// Token: 0x06019819 RID: 104473 RVA: 0x007D0F80 File Offset: 0x007CF180
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

	// Token: 0x0601981A RID: 104474 RVA: 0x007D1034 File Offset: 0x007CF234
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

	// Token: 0x0601981B RID: 104475 RVA: 0x007D10C0 File Offset: 0x007CF2C0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleInhalationComponent roleInhalationComponent = (RoleInhalationComponent)componentTemplate;
		this.DisableHandle = roleInhalationComponent.DisableHandle;
		if (roleInhalationComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		this.InhalationStrength = roleInhalationComponent.InhalationStrength;
		this.PowerfulMode = roleInhalationComponent.PowerfulMode;
		this.InhalationDistance = roleInhalationComponent.InhalationDistance;
		if (roleInhalationComponent.TagIds == null)
		{
			this.TagIds = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagIds), "TagIds"))
		{
			return false;
		}
		if (roleInhalationComponent.QueryEntityResultCache != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.QueryEntityResultCache), "QueryEntityResultCache"))
		{
			return false;
		}
		if (roleInhalationComponent.InhalingEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemInhaledItemComponent>(this.InhalingEntity), "InhalingEntity"))
		{
			return false;
		}
		this.CheckAngle = roleInhalationComponent.CheckAngle;
		return roleInhalationComponent.TempCameraDir == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempCameraDir), "TempCameraDir");
	}

	// Token: 0x170028B1 RID: 10417
	// (get) Token: 0x0601981C RID: 104476 RVA: 0x007D11D8 File Offset: 0x007CF3D8
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028B2 RID: 10418
	// (get) Token: 0x0601981D RID: 104477 RVA: 0x007D11DB File Offset: 0x007CF3DB
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF6C RID: 57196
	private int? DisableHandle;

	// Token: 0x0400DF6D RID: 57197
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DF6E RID: 57198
	private int InhalationStrength = -1;

	// Token: 0x0400DF6F RID: 57199
	private bool PowerfulMode;

	// Token: 0x0400DF70 RID: 57200
	private float InhalationDistance;

	// Token: 0x0400DF71 RID: 57201
	[Nullable(2)]
	private int[] TagIds;

	// Token: 0x0400DF72 RID: 57202
	private readonly List<EntityHandle> QueryEntityResultCache = new List<EntityHandle>();

	// Token: 0x0400DF73 RID: 57203
	private readonly HashSet<SceneItemInhaledItemComponent> InhalingEntity = new HashSet<SceneItemInhaledItemComponent>();

	// Token: 0x0400DF74 RID: 57204
	private float CheckAngle = -1f;

	// Token: 0x0400DF75 RID: 57205
	private readonly Vector TempCameraDir = Vector.Create();
}
