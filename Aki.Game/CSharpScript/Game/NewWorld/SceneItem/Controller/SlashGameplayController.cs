using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.SceneItem.Controller
{
	// Token: 0x020062F4 RID: 25332
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SlashGameplayController : ControllerBase
	{
		// Token: 0x0603D445 RID: 250949 RVA: 0x011B17AB File Offset: 0x011AF9AB
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<Entity, bool>(EEventName.OnEntityBeSlashAim, new Action<Entity, bool>(this.OnEntityBeSlashAim));
			return true;
		}

		// Token: 0x0603D446 RID: 250950 RVA: 0x011B17CA File Offset: 0x011AF9CA
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<Entity, bool>(EEventName.OnEntityBeSlashAim, new Action<Entity, bool>(this.OnEntityBeSlashAim));
			this.SameGroupEntitiesArray.Clear();
			this.BeAimEntities.Clear();
			this.PendingAimEntities.Clear();
			return true;
		}

		// Token: 0x0603D447 RID: 250951 RVA: 0x011B180C File Offset: 0x011AFA0C
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

		// Token: 0x0603D448 RID: 250952 RVA: 0x011B18AC File Offset: 0x011AFAAC
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

		// Token: 0x0603D449 RID: 250953 RVA: 0x011B195C File Offset: 0x011AFB5C
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

		// Token: 0x0603D44A RID: 250954 RVA: 0x011B1A1C File Offset: 0x011AFC1C
		public void RemoveGroupEntities(HashSet<Entity> entities)
		{
			this.SameGroupEntitiesArray.Remove(entities);
		}

		// Token: 0x170073FD RID: 29693
		// (get) Token: 0x0603D44B RID: 250955 RVA: 0x011B1A2B File Offset: 0x011AFC2B
		public static SlashGameplayController Instance
		{
			get
			{
				return SlashGameplayController._Instance;
			}
		}

		// Token: 0x0603D44C RID: 250956 RVA: 0x011B1A32 File Offset: 0x011AFC32
		public static SlashGameplayController GetOrCreateInstance()
		{
			if (SlashGameplayController._Instance == null)
			{
				SlashGameplayController.CreateInstance();
			}
			return SlashGameplayController._Instance;
		}

		// Token: 0x0603D44D RID: 250957 RVA: 0x011B1A46 File Offset: 0x011AFC46
		public static bool CreateInstance()
		{
			if (SlashGameplayController._Instance != null)
			{
				return true;
			}
			SlashGameplayController._Instance = new SlashGameplayController();
			return true;
		}

		// Token: 0x0603D44E RID: 250958 RVA: 0x011B1A5C File Offset: 0x011AFC5C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D44F RID: 250959 RVA: 0x011B1A5E File Offset: 0x011AFC5E
		public static void ResetStaticDefaultValue()
		{
			SlashGameplayController._Instance = null;
		}

		// Token: 0x0603D450 RID: 250960 RVA: 0x011B1A66 File Offset: 0x011AFC66
		static SlashGameplayController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlashGameplayController.CreateStaticDefaultValue), new Action(SlashGameplayController.ResetStaticDefaultValue));
		}

		// Token: 0x040207D0 RID: 133072
		private readonly HashSet<HashSet<Entity>> SameGroupEntitiesArray = new HashSet<HashSet<Entity>>();

		// Token: 0x040207D1 RID: 133073
		private readonly HashSet<Entity> BeAimEntities = new HashSet<Entity>();

		// Token: 0x040207D2 RID: 133074
		private readonly HashSet<Entity> PendingAimEntities = new HashSet<Entity>();

		// Token: 0x040207D3 RID: 133075
		[Nullable(2)]
		private static SlashGameplayController _Instance;
	}
}
