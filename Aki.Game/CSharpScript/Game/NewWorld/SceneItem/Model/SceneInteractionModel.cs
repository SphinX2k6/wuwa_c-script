using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Item;
using AkiClient.Game.Aki.CreatureTools;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x0200628C RID: 25228
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneInteractionModel : ModelBase
	{
		// Token: 0x0603CE38 RID: 249400 RVA: 0x0117D0EC File Offset: 0x0117B2EC
		[return: Nullable(2)]
		public EntityHandle GetEntityByBaseItem(AActor actor)
		{
			if (!this.IsInitBaseItemInfo)
			{
				this.IsInitBaseItemInfo = true;
				UKuroLevelPlayLibrary.RegisterBaseItemInfo(BP_BaseItem_C.StaticClass(), "EntityId");
			}
			int entityIdByBaseItem = UKuroLevelPlayLibrary.GetEntityIdByBaseItem(actor);
			CreatureModel instance = CreatureModel.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetEntityById(entityIdByBaseItem);
		}

		// Token: 0x0603CE39 RID: 249401 RVA: 0x0117D130 File Offset: 0x0117B330
		[return: Nullable(2)]
		public EntityHandle GetEntityByActor(AActor actor, bool isAccurate = false)
		{
			AActor baseItemByActor = this.GetBaseItemByActor(actor, isAccurate);
			if (baseItemByActor == null)
			{
				return null;
			}
			return ActorUtils.GetEntityByActor(baseItemByActor, true);
		}

		// Token: 0x0603CE3A RID: 249402 RVA: 0x0117D154 File Offset: 0x0117B354
		[return: Nullable(2)]
		public AActor GetBaseItemByActor(AActor actor, bool isAccurate = false)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			AActor aactor = actor.GetOwner();
			if (aactor == null)
			{
				if (isAccurate)
				{
					return null;
				}
				aactor = this.GetEntityActorByChildActor(actor);
				if (aactor == null)
				{
					return null;
				}
			}
			if (UKuroStaticLibrary.IsObjectClassByName(aactor, CharacterNameDefines.Instance.BP_BASEITEM))
			{
				return aactor;
			}
			if (isAccurate)
			{
				return null;
			}
			return this.GetEntityActorByChildActor(actor);
		}

		// Token: 0x0603CE3B RID: 249403 RVA: 0x0117D1B0 File Offset: 0x0117B3B0
		[return: Nullable(2)]
		private AActor GetEntityActorByChildActor(AActor childActor)
		{
			AActor aactor = childActor;
			while (aactor != null && !(aactor is IBPI_CreatureInterface_C))
			{
				aactor = aactor.GetAttachParentActor();
			}
			if (aactor == null)
			{
				return null;
			}
			IBPI_CreatureInterface_C ibpi_CreatureInterface_C = aactor as IBPI_CreatureInterface_C;
			Entity entity = EntitySystem.Instance.Get(ibpi_CreatureInterface_C.GetEntityId());
			if (entity == null || !entity.Valid)
			{
				return null;
			}
			return aactor;
		}

		// Token: 0x17007348 RID: 29512
		// (get) Token: 0x0603CE3C RID: 249404 RVA: 0x0117D203 File Offset: 0x0117B403
		public static SceneInteractionModel Instance
		{
			get
			{
				return SceneInteractionModel._Instance;
			}
		}

		// Token: 0x0603CE3D RID: 249405 RVA: 0x0117D20A File Offset: 0x0117B40A
		public static SceneInteractionModel GetOrCreateInstance()
		{
			if (SceneInteractionModel._Instance == null)
			{
				SceneInteractionModel.CreateInstance();
			}
			return SceneInteractionModel._Instance;
		}

		// Token: 0x0603CE3E RID: 249406 RVA: 0x0117D21E File Offset: 0x0117B41E
		public static bool CreateInstance()
		{
			if (SceneInteractionModel._Instance != null)
			{
				return true;
			}
			SceneInteractionModel._Instance = new SceneInteractionModel();
			return true;
		}

		// Token: 0x0603CE3F RID: 249407 RVA: 0x0117D234 File Offset: 0x0117B434
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CE40 RID: 249408 RVA: 0x0117D236 File Offset: 0x0117B436
		public static void ResetStaticDefaultValue()
		{
			SceneInteractionModel._Instance = null;
		}

		// Token: 0x0603CE41 RID: 249409 RVA: 0x0117D23E File Offset: 0x0117B43E
		static SceneInteractionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractionModel.CreateStaticDefaultValue), new Action(SceneInteractionModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402047C RID: 132220
		private bool IsInitBaseItemInfo;

		// Token: 0x0402047D RID: 132221
		private readonly Stat StatGetEntityByActor = Stat.Create("SceneInteractionModel.GetEntityByActor", "", "");

		// Token: 0x0402047E RID: 132222
		[Nullable(2)]
		private static SceneInteractionModel _Instance;
	}
}
