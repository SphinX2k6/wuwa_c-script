using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.Module.Scan
{
	// Token: 0x02003C43 RID: 15427
	[NullableContext(1)]
	[Nullable(0)]
	internal class ScanData : IStaticVariableResetter
	{
		// Token: 0x06027852 RID: 161874 RVA: 0x00B160F5 File Offset: 0x00B142F5
		static ScanData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScanData.CreateStaticDefaultValue), new Action(ScanData.ResetStaticDefaultValue));
		}

		// Token: 0x06027853 RID: 161875 RVA: 0x00B1612E File Offset: 0x00B1432E
		public static void CreateStaticDefaultValue()
		{
			ScanData.Uid = 0;
		}

		// Token: 0x06027854 RID: 161876 RVA: 0x00B16136 File Offset: 0x00B14336
		public static void ResetStaticDefaultValue()
		{
			ScanData.Uid = 0;
		}

		// Token: 0x06027855 RID: 161877 RVA: 0x00B16140 File Offset: 0x00B14340
		public ScanData(float scanMaxDistance, float scanInteractionEffectMaxDistance)
		{
			this.Id = ScanData.Uid++;
			this.MaxScanDistance = Math.Max(scanMaxDistance, scanInteractionEffectMaxDistance);
		}

		// Token: 0x06027856 RID: 161878 RVA: 0x00B161AC File Offset: 0x00B143AC
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

		// Token: 0x06027857 RID: 161879 RVA: 0x00B16268 File Offset: 0x00B14468
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

		// Token: 0x06027858 RID: 161880 RVA: 0x00B163D8 File Offset: 0x00B145D8
		public bool IsScanComplete()
		{
			return this.CurScanRadius >= this.MaxScanDistance;
		}

		// Token: 0x06027859 RID: 161881 RVA: 0x00B163EC File Offset: 0x00B145EC
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

		// Token: 0x0602785A RID: 161882 RVA: 0x00B16464 File Offset: 0x00B14664
		[NullableContext(2)]
		private bool IsReadyToProcessEntity(NearbyEntityInfo nearbyEntityInfo)
		{
			return nearbyEntityInfo != null && nearbyEntityInfo.Distance <= (double)this.CurScanRadius;
		}

		// Token: 0x0602785B RID: 161883 RVA: 0x00B16480 File Offset: 0x00B14680
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

		// Token: 0x0602785C RID: 161884 RVA: 0x00B164F4 File Offset: 0x00B146F4
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

		// Token: 0x040158DE RID: 88286
		private static int Uid = 0;

		// Token: 0x040158DF RID: 88287
		private static readonly int scanCharacterTag = GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.扫描感应中"];

		// Token: 0x040158E0 RID: 88288
		public int Id;

		// Token: 0x040158E1 RID: 88289
		public float MaxScanDistance;

		// Token: 0x040158E2 RID: 88290
		[Nullable(2)]
		public BP_Fx_Scanning_C ScanningEffectActor;

		// Token: 0x040158E3 RID: 88291
		public float CurElapsedTime;

		// Token: 0x040158E4 RID: 88292
		public float CurScanRadius;

		// Token: 0x040158E5 RID: 88293
		public readonly float ScanEndTime = 1.6f;

		// Token: 0x040158E6 RID: 88294
		public readonly float ScanRadiusSpace = 200f;

		// Token: 0x040158E7 RID: 88295
		public bool HasTarget;

		// Token: 0x040158E8 RID: 88296
		public HashSet<Entity> NearbyCharacterEntities = new HashSet<Entity>();

		// Token: 0x040158E9 RID: 88297
		private readonly List<NearbyEntityInfo> NearbyEntitiesMap = new List<NearbyEntityInfo>();

		// Token: 0x040158EA RID: 88298
		public Queue<NearbyEntityInfo> NearbyEntityQueue = new Queue<NearbyEntityInfo>(4);
	}
}
