using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.Module.Scan
{
	// Token: 0x02004C92 RID: 19602
	[NullableContext(1)]
	[Nullable(0)]
	internal class ScanData : IStaticVariableResetter
	{
		// Token: 0x06032A9F RID: 207519 RVA: 0x00BD1491 File Offset: 0x00BCF691
		static ScanData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScanData.CreateStaticDefaultValue), new Action(ScanData.ResetStaticDefaultValue));
		}

		// Token: 0x06032AA0 RID: 207520 RVA: 0x00BD14CA File Offset: 0x00BCF6CA
		public static void CreateStaticDefaultValue()
		{
			ScanData.Uid = 0;
		}

		// Token: 0x06032AA1 RID: 207521 RVA: 0x00BD14D2 File Offset: 0x00BCF6D2
		public static void ResetStaticDefaultValue()
		{
			ScanData.Uid = 0;
		}

		// Token: 0x06032AA2 RID: 207522 RVA: 0x00BD14DC File Offset: 0x00BCF6DC
		public ScanData(float scanMaxDistance, float scanInteractionEffectMaxDistance)
		{
			this.Id = ScanData.Uid++;
			this.MaxScanDistance = Math.Max(scanMaxDistance, scanInteractionEffectMaxDistance);
		}

		// Token: 0x06032AA3 RID: 207523 RVA: 0x00BD1548 File Offset: 0x00BCF748
		public void EndScan()
		{
			foreach (Entity entity in this.NearbyCharacterEntities)
			{
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				if (component != null && component.HasTag(ScanData.scanCharacterTag))
				{
					component.RemoveTag(new int?(ScanData.scanCharacterTag));
				}
			}
			LevelGamePlayController.Instance.HandleClearAllScanEffect();
			ActorSystem.Instance.Put("ScanData.EndScan", this.ScanningEffectActor, null);
			this.ScanningEffectActor = null;
			this.NearbyEntityQueue.Clear();
			this.NearbyEntitiesMap.Clear();
			this.NearbyCharacterEntities.Clear();
		}

		// Token: 0x06032AA4 RID: 207524 RVA: 0x00BD1604 File Offset: 0x00BCF804
		public void FindNearbyEntities()
		{
			List<EntityHandle> list = new List<EntityHandle>();
			CreatureModel.Instance.GetEntitiesInRange(this.MaxScanDistance, EEntityTypeQuery.SceneItemOrCharacter, list, true, false);
			if (list.Count == 0)
			{
				return;
			}
			this.HasTarget = true;
			WorldEntity entity = SceneTeamModel.Instance.GetCurrentEntity.Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.CH, "ScanController.FindNearbyEntities:当前角色组件为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (EntityHandle entityHandle in list)
			{
				if (entityHandle.Valid && entityHandle.Entity != null)
				{
					WorldEntity entity2 = entityHandle.Entity;
					double distance = Vector.Distance(entity2.GetComponent<BaseActorComponent>().ActorLocationProxy, baseActorComponent.ActorLocationProxy);
					this.NearbyEntitiesMap.Add(new NearbyEntityInfo(entity2, distance));
				}
			}
			this.NearbyEntitiesMap.Sort((NearbyEntityInfo a, NearbyEntityInfo b) => a.Distance.CompareTo(b.Distance));
			foreach (NearbyEntityInfo element in this.NearbyEntitiesMap)
			{
				this.NearbyEntityQueue.Push(element);
			}
		}

		// Token: 0x06032AA5 RID: 207525 RVA: 0x00BD1774 File Offset: 0x00BCF974
		public bool IsScanComplete()
		{
			return this.CurScanRadius >= this.MaxScanDistance;
		}

		// Token: 0x06032AA6 RID: 207526 RVA: 0x00BD1788 File Offset: 0x00BCF988
		public bool UpdateScanRadius(float timeDilation)
		{
			this.CurElapsedTime += timeDilation;
			float num = UKismetMathLibrary.FInterpTo(0f, this.MaxScanDistance, this.CurElapsedTime, 1f / this.ScanEndTime);
			if (num == this.MaxScanDistance)
			{
				this.CurScanRadius = num;
				return true;
			}
			if (num < this.CurScanRadius + this.ScanRadiusSpace && this.CurScanRadius < this.MaxScanDistance)
			{
				return false;
			}
			this.CurScanRadius = num;
			return true;
		}

		// Token: 0x06032AA7 RID: 207527 RVA: 0x00BD1800 File Offset: 0x00BCFA00
		[NullableContext(2)]
		private bool IsReadyToProcessEntity(NearbyEntityInfo nearbyEntityInfo)
		{
			return nearbyEntityInfo != null && nearbyEntityInfo.Distance <= (double)this.CurScanRadius;
		}

		// Token: 0x06032AA8 RID: 207528 RVA: 0x00BD181C File Offset: 0x00BCFA1C
		private void AddScanTagToEntity(Entity entity)
		{
			if (entity.GetComponent<CharacterActorComponent>() == null)
			{
				return;
			}
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			ECamp? ecamp = (component != null) ? new ECamp?(component.GetEntityCamp()) : null;
			ECamp ecamp2 = ECamp.Player;
			if (ecamp.GetValueOrDefault() == ecamp2 & ecamp != null)
			{
				return;
			}
			this.NearbyCharacterEntities.Add(entity);
			BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
			if (component2 != null)
			{
				component2.AddTag(new int?(ScanData.scanCharacterTag));
			}
		}

		// Token: 0x06032AA9 RID: 207529 RVA: 0x00BD1890 File Offset: 0x00BCFA90
		public void ProcessNearbyEntities()
		{
			while (this.NearbyEntityQueue.Size > 0)
			{
				NearbyEntityInfo front = this.NearbyEntityQueue.Front;
				if (!this.IsReadyToProcessEntity(front))
				{
					break;
				}
				this.NearbyEntityQueue.Pop();
				Entity entity = (front != null) ? front.Entity : null;
				if (entity != null && entity.Valid)
				{
					LevelGamePlayController.Instance.HandleScanEntityResponse(entity, 0);
					this.AddScanTagToEntity(entity);
				}
			}
		}

		// Token: 0x0401AF81 RID: 110465
		private static int Uid = 0;

		// Token: 0x0401AF82 RID: 110466
		private static readonly int scanCharacterTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.扫描感应中"];

		// Token: 0x0401AF83 RID: 110467
		public int Id;

		// Token: 0x0401AF84 RID: 110468
		public float MaxScanDistance;

		// Token: 0x0401AF85 RID: 110469
		[Nullable(2)]
		public BP_Fx_Scanning_C ScanningEffectActor;

		// Token: 0x0401AF86 RID: 110470
		public float CurElapsedTime;

		// Token: 0x0401AF87 RID: 110471
		public float CurScanRadius;

		// Token: 0x0401AF88 RID: 110472
		public readonly float ScanEndTime = 1.6f;

		// Token: 0x0401AF89 RID: 110473
		public readonly float ScanRadiusSpace = 200f;

		// Token: 0x0401AF8A RID: 110474
		public bool HasTarget;

		// Token: 0x0401AF8B RID: 110475
		public HashSet<Entity> NearbyCharacterEntities = new HashSet<Entity>();

		// Token: 0x0401AF8C RID: 110476
		private readonly List<NearbyEntityInfo> NearbyEntitiesMap = new List<NearbyEntityInfo>();

		// Token: 0x0401AF8D RID: 110477
		public Queue<NearbyEntityInfo> NearbyEntityQueue = new Queue<NearbyEntityInfo>(4);
	}
}
