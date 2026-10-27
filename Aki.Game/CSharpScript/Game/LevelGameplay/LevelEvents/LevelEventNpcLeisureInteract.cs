using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B44 RID: 27460
	public class LevelEventNpcLeisureInteract : LevelEventBase
	{
		// Token: 0x06044174 RID: 278900 RVA: 0x010BFC03 File Offset: 0x010BDE03
		public LevelEventNpcLeisureInteract(int id) : base(id)
		{
		}

		// Token: 0x06044175 RID: 278901 RVA: 0x010BFC0C File Offset: 0x010BDE0C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			NpcLeisureInteract npcLeisureInteract = inParams as NpcLeisureInteract;
			if (npcLeisureInteract == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CWZ, " LevelEventNpcLeisureInteract, 坐下参数为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			INpcLeisureInteractType option = npcLeisureInteract.Option;
			INpcSitDown npcSitDown = option as INpcSitDown;
			if (npcSitDown != null)
			{
				ENpcLeisureInteract type = npcSitDown.Type;
				return;
			}
			INpcSwingGetUp npcSwingGetUp = option as INpcSwingGetUp;
			if (npcSwingGetUp == null)
			{
				INpcSwing npcSwing = option as INpcSwing;
				if (npcSwing != null)
				{
					if (npcSwing.Type != ENpcLeisureInteract.Swing)
					{
						return;
					}
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(npcSwing.TargetNpcId);
					WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
					if (worldEntity == null)
					{
						return;
					}
					CharacterSwingComponent component = worldEntity.GetComponent<CharacterSwingComponent>();
					if (component == null)
					{
						return;
					}
					component.StartSwing(npcSwing.SwingDa, npcSwing.EntityId, npcSwing.SkipSitDown);
				}
				return;
			}
			if (npcSwingGetUp.Type != ENpcLeisureInteract.SwingGetUp)
			{
				return;
			}
			EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId(npcSwingGetUp.TargetNpcId);
			WorldEntity worldEntity2 = (entityByPbDataId2 != null) ? entityByPbDataId2.Entity : null;
			if (worldEntity2 == null)
			{
				return;
			}
			CharacterSwingComponent component2 = worldEntity2.GetComponent<CharacterSwingComponent>();
			if (component2 == null)
			{
				return;
			}
			component2.ExitLoopSwing();
		}
	}
}
