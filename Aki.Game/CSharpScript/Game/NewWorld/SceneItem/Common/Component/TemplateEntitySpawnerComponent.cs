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
	// Token: 0x020062DF RID: 25311
	[NullableContext(1)]
	[Nullable(0)]
	public class TemplateEntitySpawnerComponent : EntityComponent
	{
		// Token: 0x0603D387 RID: 250759 RVA: 0x011AC428 File Offset: 0x011AA628
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			TemplateEntitySpawnerComponent templateEntitySpawnerComponent = args.GetP1<CreateEntityData>().GetParam<TemplateEntitySpawnerComponent>() as TemplateEntitySpawnerComponent;
			ITemplateMatrix spawnConfig = templateEntitySpawnerComponent.SpawnConfig;
			this.IsInitHide = ((spawnConfig != null) ? spawnConfig.IsInitHide : null).GetValueOrDefault();
			return true;
		}

		// Token: 0x0603D388 RID: 250760 RVA: 0x011AC470 File Offset: 0x011AA670
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

		// Token: 0x0603D389 RID: 250761 RVA: 0x011AC52C File Offset: 0x011AA72C
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

		// Token: 0x0603D38A RID: 250762 RVA: 0x011AC5A0 File Offset: 0x011AA7A0
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

		// Token: 0x0603D38B RID: 250763 RVA: 0x011AC62C File Offset: 0x011AA82C
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

		// Token: 0x0603D38C RID: 250764 RVA: 0x011AC87C File Offset: 0x011AAA7C
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

		// Token: 0x0603D38D RID: 250765 RVA: 0x011AC9A8 File Offset: 0x011AABA8
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

		// Token: 0x0603D38E RID: 250766 RVA: 0x011ACA28 File Offset: 0x011AAC28
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			TemplateEntitySpawnerComponent templateEntitySpawnerComponent = (TemplateEntitySpawnerComponent)componentTemplate;
			if (templateEntitySpawnerComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (templateEntitySpawnerComponent.WaitEntityTask == null)
			{
				this.WaitEntityTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaitEntityTask), "WaitEntityTask"))
			{
				return false;
			}
			if (templateEntitySpawnerComponent.CacheSpawnedEntityInfos == null)
			{
				this.CacheSpawnedEntityInfos = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheSpawnedEntityInfos), "CacheSpawnedEntityInfos"))
			{
				return false;
			}
			this.IsInitHide = templateEntitySpawnerComponent.IsInitHide;
			return (templateEntitySpawnerComponent.AllEntity == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.AllEntity), "AllEntity")) && (templateEntitySpawnerComponent.GroupTypeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.GroupTypeMap), "GroupTypeMap")) && (templateEntitySpawnerComponent.NotLoadCompletedEntity == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.NotLoadCompletedEntity), "NotLoadCompletedEntity"));
		}

		// Token: 0x170073EC RID: 29676
		// (get) Token: 0x0603D38F RID: 250767 RVA: 0x011ACB3B File Offset: 0x011AAD3B
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170073ED RID: 29677
		// (get) Token: 0x0603D390 RID: 250768 RVA: 0x011ACB3E File Offset: 0x011AAD3E
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020775 RID: 132981
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04020776 RID: 132982
		[Nullable(2)]
		private WaitEntityTask WaitEntityTask;

		// Token: 0x04020777 RID: 132983
		private List<SpawnerEntityInfo> CacheSpawnedEntityInfos = new List<SpawnerEntityInfo>();

		// Token: 0x04020778 RID: 132984
		private bool IsInitHide;

		// Token: 0x04020779 RID: 132985
		private readonly HashSet<Entity> AllEntity = new HashSet<Entity>();

		// Token: 0x0402077A RID: 132986
		private readonly Dictionary<int, HashSet<Entity>> GroupTypeMap = new Dictionary<int, HashSet<Entity>>();

		// Token: 0x0402077B RID: 132987
		private readonly HashSet<Entity> NotLoadCompletedEntity = new HashSet<Entity>();
	}
}
