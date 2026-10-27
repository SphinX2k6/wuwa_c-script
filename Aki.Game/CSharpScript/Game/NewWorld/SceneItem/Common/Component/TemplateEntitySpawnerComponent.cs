using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.SceneItem.Controller;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x0200722A RID: 29226
	[NullableContext(1)]
	[Nullable(0)]
	public class TemplateEntitySpawnerComponent : EntityComponent
	{
		// Token: 0x06047A2D RID: 293421 RVA: 0x01253808 File Offset: 0x01251A08
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TemplateEntitySpawnerComponent templateEntitySpawnerComponent = args.GetP1<CreateEntityData>().GetParam<TemplateEntitySpawnerComponent>() as TemplateEntitySpawnerComponent;
			ITemplateMatrix spawnConfig = templateEntitySpawnerComponent.SpawnConfig;
			this.IsInitHide = ((spawnConfig != null) ? spawnConfig.IsInitHide : null).GetValueOrDefault();
			return true;
		}

		// Token: 0x06047A2E RID: 293422 RVA: 0x01253850 File Offset: 0x01251A50
		protected override bool OnStart()
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			List<long> list = new List<long>();
			foreach (SpawnerEntityInfo spawnerEntityInfo in this.CreatureDataComp.SpawnedEntityInfos)
			{
				list.Add(spawnerEntityInfo.IncId);
			}
			this.CacheSpawnedEntityInfos = this.CreatureDataComp.SpawnedEntityInfos;
			this.AllEntity.Clear();
			if (list.Count > 0)
			{
				this.WaitEntityTask = WaitEntityTask.Create("TemplateEntitySpawnerComponent", list, new Action<bool?>(this.OnAllEntityCreated), -1, false, true);
			}
			return true;
		}

		// Token: 0x06047A2F RID: 293423 RVA: 0x0125390C File Offset: 0x01251B0C
		protected override bool OnEnd()
		{
			if (this.WaitEntityTask != null)
			{
				this.WaitEntityTask.Cancel();
			}
			foreach (KeyValuePair<int, HashSet<Entity>> keyValuePair in this.GroupTypeMap)
			{
				HashSet<Entity> value = keyValuePair.Value;
				SlashGameplayController.Instance.RemoveGroupEntities(value);
			}
			return true;
		}

		// Token: 0x06047A30 RID: 293424 RVA: 0x01253980 File Offset: 0x01251B80
		public void OnNotifyUpdateContent(List<SpawnerEntityInfo> infos)
		{
			List<long> list = new List<long>();
			foreach (SpawnerEntityInfo spawnerEntityInfo in infos)
			{
				list.Add(spawnerEntityInfo.IncId);
			}
			this.CacheSpawnedEntityInfos = infos;
			if (list.Count > 0)
			{
				this.WaitEntityTask = WaitEntityTask.Create("TemplateEntitySpawnerComponent", list, new Action<bool?>(this.OnAllEntityCreated), -1, false, true);
			}
		}

		// Token: 0x06047A31 RID: 293425 RVA: 0x01253A0C File Offset: 0x01251C0C
		private void OnAllEntityCreated(bool? result)
		{
			this.WaitEntityTask = null;
			if (!result.GetValueOrDefault())
			{
				Log.Instance.Error(ELogModule.TemplateEntitySpawner, ELogAuthor.CH, "[TemplateEntitySpawner] 生成实体失败或者等待超时", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (SpawnerEntityInfo spawnerEntityInfo in this.CacheSpawnedEntityInfos)
			{
				List<int> list = new List<int>();
				GroupTypesWrapper groupTypes = spawnerEntityInfo.GroupTypes;
				RepeatedField<int> repeatedField = (groupTypes != null) ? groupTypes.GroupTypes : null;
				if (repeatedField != null)
				{
					foreach (int item in repeatedField)
					{
						list.Add(item);
					}
				}
				EntityHandle entity = CreatureModel.Instance.GetEntity(spawnerEntityInfo.IncId);
				if (((entity != null) ? entity.Entity : null) != null)
				{
					this.AllEntity.Add(entity.Entity);
					using (List<int>.Enumerator enumerator3 = list.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							int key = enumerator3.Current;
							if (!this.GroupTypeMap.ContainsKey(key))
							{
								this.GroupTypeMap.Add(key, new HashSet<Entity>());
							}
							this.GroupTypeMap[key].Add(entity.Entity);
						}
						continue;
					}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TemplateEntitySpawner;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[TemplateEntitySpawner] 未找到实体";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", spawnerEntityInfo.IncId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			foreach (KeyValuePair<int, HashSet<Entity>> keyValuePair in this.GroupTypeMap)
			{
				HashSet<Entity> value = keyValuePair.Value;
				SlashGameplayController.Instance.AddGroupEntities(value);
			}
			if (this.IsInitHide)
			{
				this.WaitAllSceneItemLoadCompleted();
			}
		}

		// Token: 0x06047A32 RID: 293426 RVA: 0x01253C5C File Offset: 0x01251E5C
		private void WaitAllSceneItemLoadCompleted()
		{
			using (HashSet<Entity>.Enumerator enumerator = this.AllEntity.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Entity entity = enumerator.Current;
					SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
					if (component != null)
					{
						BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
						if (component2 != null)
						{
							component2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.隐藏"]));
							if (!component.GetIsSceneInteractionLoadCompleted())
							{
								this.NotLoadCompletedEntity.Add(entity);
								Action handle = null;
								handle = delegate()
								{
									EventSystem.Instance.RemoveWithTarget(entity, EEventName.OnSceneInteractionShowCompleted, handle);
									this.NotLoadCompletedEntity.Remove(entity);
									if (this.NotLoadCompletedEntity.Count == 0)
									{
										this.OnAllSceneItemLoadCompleted();
									}
								};
								EventSystem.Instance.AddWithTarget(entity, EEventName.OnSceneInteractionShowCompleted, handle);
							}
							TimerSystem.Instance.Next(delegate(float _)
							{
								CreatureController.Instance.SetEntityEnable(entity, true, "TemplateEntitySpawnerComponent", false);
							}, null, null);
						}
					}
				}
			}
		}

		// Token: 0x06047A33 RID: 293427 RVA: 0x01253D88 File Offset: 0x01251F88
		private void OnAllSceneItemLoadCompleted()
		{
			foreach (Entity entity in this.AllEntity)
			{
				BaseTagComponent tagComp = entity.GetComponent<BaseTagComponent>();
				if (tagComp != null)
				{
					TimerSystem.Instance.Next(delegate(float _)
					{
						tagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.隐藏"]));
					}, null, null);
				}
			}
		}

		// Token: 0x06047A34 RID: 293428 RVA: 0x01253E08 File Offset: 0x01252008
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			TemplateEntitySpawnerComponent templateEntitySpawnerComponent = (TemplateEntitySpawnerComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (templateEntitySpawnerComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("WaitEntityTask"))
			{
				if (templateEntitySpawnerComponent.WaitEntityTask == null)
				{
					this.WaitEntityTask = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<WaitEntityTask>(this.WaitEntityTask), "WaitEntityTask"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CacheSpawnedEntityInfos"))
			{
				if (templateEntitySpawnerComponent.CacheSpawnedEntityInfos == null)
				{
					this.CacheSpawnedEntityInfos = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<SpawnerEntityInfo>>(this.CacheSpawnedEntityInfos), "CacheSpawnedEntityInfos"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInitHide"))
			{
				this.IsInitHide = templateEntitySpawnerComponent.IsInitHide;
			}
			return (!base.CanResetComponentProperty("AllEntity") || templateEntitySpawnerComponent.AllEntity == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.AllEntity), "AllEntity")) && (!base.CanResetComponentProperty("GroupTypeMap") || templateEntitySpawnerComponent.GroupTypeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, HashSet<Entity>>>(this.GroupTypeMap), "GroupTypeMap")) && (!base.CanResetComponentProperty("NotLoadCompletedEntity") || templateEntitySpawnerComponent.NotLoadCompletedEntity == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.NotLoadCompletedEntity), "NotLoadCompletedEntity"));
		}

		// Token: 0x04025B06 RID: 154374
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04025B07 RID: 154375
		[Nullable(2)]
		private WaitEntityTask WaitEntityTask;

		// Token: 0x04025B08 RID: 154376
		private List<SpawnerEntityInfo> CacheSpawnedEntityInfos = new List<SpawnerEntityInfo>();

		// Token: 0x04025B09 RID: 154377
		private bool IsInitHide;

		// Token: 0x04025B0A RID: 154378
		private readonly HashSet<Entity> AllEntity = new HashSet<Entity>();

		// Token: 0x04025B0B RID: 154379
		private readonly Dictionary<int, HashSet<Entity>> GroupTypeMap = new Dictionary<int, HashSet<Entity>>();

		// Token: 0x04025B0C RID: 154380
		private readonly HashSet<Entity> NotLoadCompletedEntity = new HashSet<Entity>();
	}
}
