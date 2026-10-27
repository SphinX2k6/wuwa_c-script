using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x0200723F RID: 29247
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SlashGameplayController : ControllerBase
	{
		// Token: 0x06047AE3 RID: 293603 RVA: 0x01258AFB File Offset: 0x01256CFB
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<Entity, bool>(EEventName.OnEntityBeSlashAim, new Action<Entity, bool>(this.OnEntityBeSlashAim));
			return true;
		}

		// Token: 0x06047AE4 RID: 293604 RVA: 0x01258B1A File Offset: 0x01256D1A
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<Entity, bool>(EEventName.OnEntityBeSlashAim, new Action<Entity, bool>(this.OnEntityBeSlashAim));
			this.SameGroupEntitiesArray.Clear();
			this.BeAimEntities.Clear();
			this.PendingAimEntities.Clear();
			return true;
		}

		// Token: 0x06047AE5 RID: 293605 RVA: 0x01258B5C File Offset: 0x01256D5C
		private void OnEntityBeSlashAim(Entity entity, bool isExist)
		{
			bool flag = false;
			using (HashSet<HashSet<Entity>>.Enumerator enumerator = this.SameGroupEntitiesArray.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Contains(entity))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				if (component == null || !component.GetRemoveState())
				{
					this.PendingAimEntities.Add(entity);
					return;
				}
			}
			if (isExist)
			{
				this.BeAimEntities.Add(entity);
				return;
			}
			this.BeAimEntities.Remove(entity);
		}

		// Token: 0x06047AE6 RID: 293606 RVA: 0x01258BFC File Offset: 0x01256DFC
		public bool CheckGroups()
		{
			if (this.BeAimEntities.Count == 0)
			{
				return true;
			}
			foreach (HashSet<Entity> hashSet in this.SameGroupEntitiesArray)
			{
				bool flag = true;
				foreach (Entity item in hashSet)
				{
					if (!this.BeAimEntities.Contains(item))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06047AE7 RID: 293607 RVA: 0x01258CAC File Offset: 0x01256EAC
		public void AddGroupEntities(HashSet<Entity> entities)
		{
			this.SameGroupEntitiesArray.Add(entities);
			HashSet<Entity> hashSet = new HashSet<Entity>();
			foreach (Entity item in this.PendingAimEntities)
			{
				if (entities.Contains(item))
				{
					this.BeAimEntities.Add(item);
					hashSet.Add(item);
				}
			}
			foreach (Entity item2 in hashSet)
			{
				this.PendingAimEntities.Remove(item2);
			}
		}

		// Token: 0x06047AE8 RID: 293608 RVA: 0x01258D6C File Offset: 0x01256F6C
		public void RemoveGroupEntities(HashSet<Entity> entities)
		{
			this.SameGroupEntitiesArray.Remove(entities);
		}

		// Token: 0x17009E46 RID: 40518
		// (get) Token: 0x06047AE9 RID: 293609 RVA: 0x01258D7B File Offset: 0x01256F7B
		public static SlashGameplayController Instance
		{
			get
			{
				return SlashGameplayController._Instance;
			}
		}

		// Token: 0x06047AEA RID: 293610 RVA: 0x01258D82 File Offset: 0x01256F82
		public static SlashGameplayController GetOrCreateInstance()
		{
			if (SlashGameplayController._Instance == null)
			{
				SlashGameplayController.CreateInstance();
			}
			return SlashGameplayController._Instance;
		}

		// Token: 0x06047AEB RID: 293611 RVA: 0x01258D96 File Offset: 0x01256F96
		public static bool CreateInstance()
		{
			if (SlashGameplayController._Instance != null)
			{
				return true;
			}
			SlashGameplayController._Instance = new SlashGameplayController();
			return true;
		}

		// Token: 0x06047AEC RID: 293612 RVA: 0x01258DAC File Offset: 0x01256FAC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047AED RID: 293613 RVA: 0x01258DAE File Offset: 0x01256FAE
		public static void ResetStaticDefaultValue()
		{
			SlashGameplayController._Instance = null;
		}

		// Token: 0x06047AEE RID: 293614 RVA: 0x01258DB6 File Offset: 0x01256FB6
		static SlashGameplayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlashGameplayController.CreateStaticDefaultValue), new Action(SlashGameplayController.ResetStaticDefaultValue));
		}

		// Token: 0x04025B61 RID: 154465
		private readonly HashSet<HashSet<Entity>> SameGroupEntitiesArray = new HashSet<HashSet<Entity>>();

		// Token: 0x04025B62 RID: 154466
		private readonly HashSet<Entity> BeAimEntities = new HashSet<Entity>();

		// Token: 0x04025B63 RID: 154467
		private readonly HashSet<Entity> PendingAimEntities = new HashSet<Entity>();

		// Token: 0x04025B64 RID: 154468
		[Nullable(2)]
		private static SlashGameplayController _Instance;
	}
}
