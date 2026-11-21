using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D8A RID: 19850
	[NullableContext(1)]
	[Nullable(0)]
	public class PartStatePanel
	{
		// Token: 0x06031D78 RID: 204152 RVA: 0x00DF0892 File Offset: 0x00DEEA92
		public void InitializePartStatePanel()
		{
			this.AddEvents();
			this.InitializeExistingEntities();
		}

		// Token: 0x06031D79 RID: 204153 RVA: 0x00DF08A0 File Offset: 0x00DEEAA0
		private void InitializeExistingEntities()
		{
			IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
			if (allEntities == null)
			{
				return;
			}
			foreach (EntityHandle entityHandle in allEntities)
			{
				if (entityHandle.IsInit)
				{
					this.OnCreateEntity(entityHandle.Entity);
				}
			}
		}

		// Token: 0x06031D7A RID: 204154 RVA: 0x00DF0904 File Offset: 0x00DEEB04
		public void ResetPartStatePanel()
		{
			this.DestroyAllParStates();
			this.RemoveEvents();
		}

		// Token: 0x06031D7B RID: 204155 RVA: 0x00DF0912 File Offset: 0x00DEEB12
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnSetPartStateVisible, new Action<int, FName?, bool>(this.OnSetPartStateVisible));
		}

		// Token: 0x06031D7C RID: 204156 RVA: 0x00DF0930 File Offset: 0x00DEEB30
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnSetPartStateVisible, new Action<int, FName?, bool>(this.OnSetPartStateVisible));
		}

		// Token: 0x06031D7D RID: 204157 RVA: 0x00DF0950 File Offset: 0x00DEEB50
		private void OnSetPartStateVisible(int entityId, FName? boneName, bool bVisible)
		{
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (FNameUtil.IsNothing(boneName))
			{
				if (entity == null)
				{
					return;
				}
				if (bVisible)
				{
					this.ActivatePartStateByRole(entity);
					return;
				}
				this.DestroyPartStateFromRole(entity);
				return;
			}
			else
			{
				if (entity == null)
				{
					return;
				}
				CharacterPart[] parts = entity.GetComponent<CharacterPartComponent>().Parts;
				if (parts.Length == 0)
				{
					return;
				}
				foreach (CharacterPart characterPart in parts)
				{
					if (!(characterPart.BoneName.Value != boneName))
					{
						if (bVisible)
						{
							this.ActivatePartState(entity, characterPart);
						}
						else
						{
							int index = characterPart.Index;
							this.DestroyPartState(entityId, index);
						}
					}
				}
				return;
			}
		}

		// Token: 0x06031D7E RID: 204158 RVA: 0x00DF0A00 File Offset: 0x00DEEC00
		public void OnCreateEntity(Entity entity)
		{
			if (entity == null)
			{
				return;
			}
			CharacterPartComponent component = entity.GetComponent<CharacterPartComponent>();
			if (component == null)
			{
				return;
			}
			CharacterPart[] parts = component.Parts;
			if (parts == null)
			{
				return;
			}
			if (parts.Length == 0)
			{
				return;
			}
			USkeletalMeshComponent mesh = (entity.GetComponent<BaseActorComponent>().Owner as TsBaseCharacter).Mesh;
			foreach (CharacterPart characterPart in parts)
			{
				if (characterPart.IsPartStateVisible)
				{
					FName value = characterPart.PartSocketName.Value;
					if (!mesh.DoesSocketExist(value))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.CFT;
						string message = "[BattleView]激活部位血条时找不到部位插槽:";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SocketName", value);
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						this.ActivatePartState(entity, characterPart);
					}
				}
			}
		}

		// Token: 0x06031D7F RID: 204159 RVA: 0x00DF0AB8 File Offset: 0x00DEECB8
		[NullableContext(2)]
		public void ActivatePartStateByRole(Entity entity)
		{
			if (entity == null)
			{
				return;
			}
			CharacterPart[] parts = entity.GetComponent<CharacterPartComponent>().Parts;
			if (parts.Length == 0)
			{
				return;
			}
			foreach (CharacterPart partInfo in parts)
			{
				this.ActivatePartState(entity, partInfo);
			}
		}

		// Token: 0x06031D80 RID: 204160 RVA: 0x00DF0AF8 File Offset: 0x00DEECF8
		public void ActivatePartState(Entity entity, CharacterPart partInfo)
		{
			PartState partState = this.GetPartState(entity.Id, partInfo.Index);
			if (partState != null)
			{
				partState.InitializePartState(entity, partInfo);
				return;
			}
			this.NewPartState(entity, partInfo);
		}

		// Token: 0x06031D81 RID: 204161 RVA: 0x00DF0B30 File Offset: 0x00DEED30
		public void DestroyAllParStates()
		{
			foreach (Dictionary<int, PartState> dictionary in this.PartStateGroupMap.Values)
			{
				foreach (PartState partState in dictionary.Values)
				{
					partState.Destroy(null);
				}
			}
			this.PartStateGroupMap.Clear();
		}

		// Token: 0x06031D82 RID: 204162 RVA: 0x00DF0BCC File Offset: 0x00DEEDCC
		public void DestroyPartStateFromRole(Entity entity)
		{
			int id = entity.Id;
			IReadOnlyDictionary<int, PartState> allPartStates = this.GetAllPartStates(id);
			if (allPartStates == null)
			{
				return;
			}
			foreach (PartState partState in allPartStates.Values)
			{
				partState.Destroy(null);
			}
			this.PartStateGroupMap[id].Clear();
		}

		// Token: 0x06031D83 RID: 204163 RVA: 0x00DF0C3C File Offset: 0x00DEEE3C
		public void DestroyPartState(int entityId, int partIndex)
		{
			PartState partState = this.GetPartState(entityId, partIndex);
			if (partState == null)
			{
				return;
			}
			partState.Destroy(null);
			Dictionary<int, PartState> dictionary;
			if (this.PartStateGroupMap.TryGetValue(entityId, out dictionary))
			{
				dictionary.Remove(partIndex);
			}
		}

		// Token: 0x06031D84 RID: 204164 RVA: 0x00DF0C78 File Offset: 0x00DEEE78
		public void Tick(float delta)
		{
			foreach (Dictionary<int, PartState> dictionary in this.PartStateGroupMap.Values)
			{
				foreach (PartState partState in dictionary.Values)
				{
					partState.Tick(delta);
				}
			}
		}

		// Token: 0x06031D85 RID: 204165 RVA: 0x00DF0D08 File Offset: 0x00DEEF08
		private PartState NewPartState(Entity entity, CharacterPart partInfo)
		{
			int id = entity.Id;
			PartState partState = new PartState(entity, partInfo);
			Dictionary<int, PartState> dictionary;
			if (!this.PartStateGroupMap.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<int, PartState>();
				this.PartStateGroupMap.Add(id, dictionary);
			}
			dictionary[partInfo.Index] = partState;
			return partState;
		}

		// Token: 0x06031D86 RID: 204166 RVA: 0x00DF0D58 File Offset: 0x00DEEF58
		[NullableContext(2)]
		public PartState GetPartState(int entityId, int partIndex)
		{
			Dictionary<int, PartState> dictionary;
			if (!this.PartStateGroupMap.TryGetValue(entityId, out dictionary))
			{
				return null;
			}
			return dictionary.GetValueOrDefault(partIndex);
		}

		// Token: 0x06031D87 RID: 204167 RVA: 0x00DF0D7E File Offset: 0x00DEEF7E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyDictionary<int, PartState> GetAllPartStates(int entityId)
		{
			return this.PartStateGroupMap.GetValueOrDefault(entityId);
		}

		// Token: 0x0401A626 RID: 108070
		private readonly Dictionary<int, Dictionary<int, PartState>> PartStateGroupMap = new Dictionary<int, Dictionary<int, PartState>>();

		// Token: 0x0401A627 RID: 108071
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]PartStatePanelTick", "", "");
	}
}
