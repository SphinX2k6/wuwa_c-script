using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Item;
using AkiClient.Game.Aki.CreatureTools;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Model
{
	// Token: 0x020071D7 RID: 29143
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SceneInteractionModel : ModelBase
	{
		// Token: 0x06047536 RID: 292150 RVA: 0x012232B8 File Offset: 0x012214B8
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

		// Token: 0x06047537 RID: 292151 RVA: 0x012232FC File Offset: 0x012214FC
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

		// Token: 0x06047538 RID: 292152 RVA: 0x01223320 File Offset: 0x01221520
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

		// Token: 0x06047539 RID: 292153 RVA: 0x0122337C File Offset: 0x0122157C
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

		// Token: 0x17009DF1 RID: 40433
		// (get) Token: 0x0604753A RID: 292154 RVA: 0x012233CF File Offset: 0x012215CF
		public static SceneInteractionModel Instance
		{
			get
			{
				return SceneInteractionModel._Instance;
			}
		}

		// Token: 0x0604753B RID: 292155 RVA: 0x012233D6 File Offset: 0x012215D6
		public static SceneInteractionModel GetOrCreateInstance()
		{
			if (SceneInteractionModel._Instance == null)
			{
				SceneInteractionModel.CreateInstance();
			}
			return SceneInteractionModel._Instance;
		}

		// Token: 0x0604753C RID: 292156 RVA: 0x012233EA File Offset: 0x012215EA
		public static bool CreateInstance()
		{
			if (SceneInteractionModel._Instance != null)
			{
				return true;
			}
			SceneInteractionModel._Instance = new SceneInteractionModel();
			return true;
		}

		// Token: 0x0604753D RID: 292157 RVA: 0x01223400 File Offset: 0x01221600
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604753E RID: 292158 RVA: 0x01223402 File Offset: 0x01221602
		public static void ResetStaticDefaultValue()
		{
			SceneInteractionModel._Instance = null;
		}

		// Token: 0x0604753F RID: 292159 RVA: 0x0122340A File Offset: 0x0122160A
		static SceneInteractionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneInteractionModel.CreateStaticDefaultValue), new Action(SceneInteractionModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402580D RID: 153613
		private bool IsInitBaseItemInfo;

		// Token: 0x0402580E RID: 153614
		private readonly Stat StatGetEntityByActor = Stat.Create("SceneInteractionModel.GetEntityByActor", "", "");

		// Token: 0x0402580F RID: 153615
		[Nullable(2)]
		private static SceneInteractionModel _Instance;
	}
}
