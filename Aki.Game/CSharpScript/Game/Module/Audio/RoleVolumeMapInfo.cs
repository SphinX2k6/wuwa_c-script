using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E93 RID: 24211
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVolumeMapInfo
	{
		// Token: 0x0603D978 RID: 252280 RVA: 0x00EDE852 File Offset: 0x00EDCA52
		public void OnUpdateTeam()
		{
			this.MaintainCurrentList();
			this.MaintainMapData();
			this.LastPlayEntityId = -1;
		}

		// Token: 0x0603D979 RID: 252281 RVA: 0x00EDE868 File Offset: 0x00EDCA68
		public void UpdateVolume()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (this.Empty() || characterActorComponent == null)
			{
				return;
			}
			EEventVolumePriority eeventVolumePriority = EEventVolumePriority.Mute;
			List<int> list = new List<int>();
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(false))
			{
				WorldEntity entity = entityHandle.Entity;
				CharacterActorComponent characterActorComponent2 = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
				int id = entityHandle.Id;
				if (characterActorComponent2 != null && this.RoleVolumeMap.ContainsKey(id))
				{
					RoleVolumeInfo roleVolumeInfo = this.RoleVolumeMap[id];
					RoleModel instance = RoleModel.Instance;
					double value = (instance != null && instance.GetRoleBackgroundMusicEnabled(roleVolumeInfo.RoleId)) ? ((id == characterActorComponent.Entity.Id) ? 0.0 : Vector.DistSquared(characterActorComponent.ActorLocationProxy, characterActorComponent2.ActorLocationProxy)) : RoleAudioVolumeInfo.MaxDistanceSquared;
					roleVolumeInfo.UpdateDistSquared(value);
					if (eeventVolumePriority < roleVolumeInfo.Priority)
					{
						eeventVolumePriority = roleVolumeInfo.Priority;
						list.Clear();
						list.Add(id);
					}
					else if (eeventVolumePriority == roleVolumeInfo.Priority)
					{
						list.Add(id);
					}
				}
			}
			if (list.Count == 0 || eeventVolumePriority == EEventVolumePriority.Mute)
			{
				this.CurrentPlayEntityId = 0;
			}
			else if (list.Count == 1)
			{
				this.CurrentPlayEntityId = list[0];
			}
			else if (list.Count > 1)
			{
				this.TempQueue.Clear();
				foreach (int key in list)
				{
					this.TempQueue.Push(this.RoleVolumeMap[key]);
				}
				RoleVolumeInfo top = this.TempQueue.Top;
				this.CurrentPlayEntityId = ((top != null) ? top.EntityId : 0);
			}
			if (this.LastPlayEntityId == this.CurrentPlayEntityId)
			{
				return;
			}
			foreach (KeyValuePair<int, RoleVolumeInfo> keyValuePair in this.RoleVolumeMap)
			{
				keyValuePair.Value.SetPlayEvent(keyValuePair.Key == this.CurrentPlayEntityId);
			}
			this.LastPlayEntityId = this.CurrentPlayEntityId;
		}

		// Token: 0x0603D97A RID: 252282 RVA: 0x00EDEAD8 File Offset: 0x00EDCCD8
		public void MaintainCurrentList()
		{
			this.TeamEntityIdList.Clear();
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(false))
			{
				WorldEntity entity = entityHandle.Entity;
				CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
				if (characterActorComponent != null)
				{
					this.TeamEntityIdList.Add(characterActorComponent.Entity.Id);
				}
			}
		}

		// Token: 0x0603D97B RID: 252283 RVA: 0x00EDEB60 File Offset: 0x00EDCD60
		public void MaintainMapData()
		{
			if (this.RoleVolumeMap.Count == 0)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (int item in this.RoleVolumeMap.Keys)
			{
				if (!this.TeamEntityIdList.Contains(item))
				{
					list.Add(item);
				}
			}
			foreach (int key in list)
			{
				this.RoleVolumeMap.Remove(key);
			}
		}

		// Token: 0x0603D97C RID: 252284 RVA: 0x00EDEC20 File Offset: 0x00EDCE20
		public void AddEvent(int entityId, int roleId, int handle, string eventName, AActor owner)
		{
			EventVolumeInfo info = new EventVolumeInfo(handle, eventName, owner);
			this.GetRoleVolumeInfo(entityId, roleId).AddEvent(handle, info);
			this.UpdateVolume();
		}

		// Token: 0x0603D97D RID: 252285 RVA: 0x00EDEC50 File Offset: 0x00EDCE50
		public void RemoveEvent(int entityId, int handle)
		{
			if (this.RoleVolumeMap.ContainsKey(entityId))
			{
				this.RoleVolumeMap[entityId].RemoveEvent(handle);
			}
			if (this.RoleVolumeMap.ContainsKey(entityId) && this.RoleVolumeMap[entityId].Empty())
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					if (!this.RoleVolumeMap.ContainsKey(entityId))
					{
						return;
					}
					if (this.RoleVolumeMap[entityId].Empty())
					{
						this.RoleVolumeMap.Remove(entityId);
						if (this.CurrentPlayEntityId == entityId)
						{
							this.LastPlayEntityId = -1;
						}
					}
				}, (float)RoleAudioVolumeInfo.DelayTime, null, null, true, 1f);
			}
		}

		// Token: 0x0603D97E RID: 252286 RVA: 0x00EDECEB File Offset: 0x00EDCEEB
		private RoleVolumeInfo GetRoleVolumeInfo(int entityId, int roleId)
		{
			if (!this.RoleVolumeMap.ContainsKey(entityId))
			{
				this.RoleVolumeMap[entityId] = new RoleVolumeInfo(roleId, entityId);
			}
			return this.RoleVolumeMap[entityId];
		}

		// Token: 0x0603D97F RID: 252287 RVA: 0x00EDED1C File Offset: 0x00EDCF1C
		public bool Empty()
		{
			if (this.RoleVolumeMap.Count == 0)
			{
				return true;
			}
			foreach (KeyValuePair<int, RoleVolumeInfo> keyValuePair in this.RoleVolumeMap)
			{
				if (!keyValuePair.Value.Empty())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603D980 RID: 252288 RVA: 0x00EDED8C File Offset: 0x00EDCF8C
		public RoleVolumeMapInfo()
		{
			Comparison<RoleVolumeInfo> compare;
			if ((compare = RoleVolumeMapInfo.<>O.<0>__Compare) == null)
			{
				compare = (RoleVolumeMapInfo.<>O.<0>__Compare = new Comparison<RoleVolumeInfo>(RoleVolumeInfo.Compare));
			}
			this.TempQueue = new PriorityQueue<RoleVolumeInfo>(compare);
			base..ctor();
		}

		// Token: 0x0402024A RID: 131658
		public List<int> TeamEntityIdList = new List<int>();

		// Token: 0x0402024B RID: 131659
		public Dictionary<int, RoleVolumeInfo> RoleVolumeMap = new Dictionary<int, RoleVolumeInfo>();

		// Token: 0x0402024C RID: 131660
		public int CurrentPlayEntityId;

		// Token: 0x0402024D RID: 131661
		public int LastPlayEntityId = -1;

		// Token: 0x0402024E RID: 131662
		private readonly PriorityQueue<RoleVolumeInfo> TempQueue;

		// Token: 0x0200C209 RID: 49673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403AA2E RID: 240174
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<RoleVolumeInfo> <0>__Compare;
		}
	}
}
