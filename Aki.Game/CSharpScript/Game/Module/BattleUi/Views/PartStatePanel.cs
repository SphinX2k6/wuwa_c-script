using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DA8 RID: 23976
	[NullableContext(1)]
	[Nullable(0)]
	public class PartStatePanel
	{
		// Token: 0x0603CE1B RID: 249371 RVA: 0x00E9FFDA File Offset: 0x00E9E1DA
		public void InitializePartStatePanel()
		{
			this.AddEvents();
			this.InitializeExistingEntities();
		}

		// Token: 0x0603CE1C RID: 249372 RVA: 0x00E9FFE8 File Offset: 0x00E9E1E8
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

		// Token: 0x0603CE1D RID: 249373 RVA: 0x00EA004C File Offset: 0x00E9E24C
		public void ResetPartStatePanel()
		{
			this.DestroyAllParStates();
			this.RemoveEvents();
		}

		// Token: 0x0603CE1E RID: 249374 RVA: 0x00EA005A File Offset: 0x00E9E25A
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnSetPartStateVisible, new Action<int, FName?, bool>(this.OnSetPartStateVisible));
		}

		// Token: 0x0603CE1F RID: 249375 RVA: 0x00EA0078 File Offset: 0x00E9E278
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnSetPartStateVisible, new Action<int, FName?, bool>(this.OnSetPartStateVisible));
		}

		// Token: 0x0603CE20 RID: 249376 RVA: 0x00EA0098 File Offset: 0x00E9E298
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

		// Token: 0x0603CE21 RID: 249377 RVA: 0x00EA0148 File Offset: 0x00E9E348
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

		// Token: 0x0603CE22 RID: 249378 RVA: 0x00EA0200 File Offset: 0x00E9E400
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

		// Token: 0x0603CE23 RID: 249379 RVA: 0x00EA0240 File Offset: 0x00E9E440
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

		// Token: 0x0603CE24 RID: 249380 RVA: 0x00EA0278 File Offset: 0x00E9E478
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

		// Token: 0x0603CE25 RID: 249381 RVA: 0x00EA0314 File Offset: 0x00E9E514
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

		// Token: 0x0603CE26 RID: 249382 RVA: 0x00EA0384 File Offset: 0x00E9E584
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

		// Token: 0x0603CE27 RID: 249383 RVA: 0x00EA03C0 File Offset: 0x00E9E5C0
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

		// Token: 0x0603CE28 RID: 249384 RVA: 0x00EA0450 File Offset: 0x00E9E650
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

		// Token: 0x0603CE29 RID: 249385 RVA: 0x00EA04A0 File Offset: 0x00E9E6A0
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

		// Token: 0x0603CE2A RID: 249386 RVA: 0x00EA04C6 File Offset: 0x00E9E6C6
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyDictionary<int, PartState> GetAllPartStates(int entityId)
		{
			return this.PartStateGroupMap.GetValueOrDefault(entityId);
		}

		// Token: 0x0401FB6E RID: 129902
		private readonly Dictionary<int, Dictionary<int, PartState>> PartStateGroupMap = new Dictionary<int, Dictionary<int, PartState>>();

		// Token: 0x0401FB6F RID: 129903
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject = Stat.Create("[BattleView]PartStatePanelTick", "", "");
	}
}
