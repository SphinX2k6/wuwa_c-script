using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB0 RID: 23728
	public class LevelEventHonamiStoryInteractPickUp : LevelEventBase
	{
		// Token: 0x0603A292 RID: 238226 RVA: 0x01066B25 File Offset: 0x01064D25
		public LevelEventHonamiStoryInteractPickUp(int id) : base(id)
		{
		}

		// Token: 0x0603A293 RID: 238227 RVA: 0x01066B30 File Offset: 0x01064D30
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			EntityContext entityContext = context as EntityContext;
			if (entityContext == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.BB, "[LevelEventHonamiStoryInteractPickUp] 上下文不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.Value);
			if (entity == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.BB, "[LevelEventHonamiStoryInteractPickUp] 实体不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			CreatureDataComponent creatureDataComponent = entity.CheckGetComponent<CreatureDataComponent>();
			if (creatureDataComponent.HonamiStoryItemInfo == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.BB, "[LevelEventHonamiStoryInteractPickUp] 非HonamiStoryItem", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (HonamiStoryModel.Instance.GetBackPackData(2, false) == null)
			{
				return;
			}
			if (HonamiStoryModel.Instance.IsPickUpViewOpened())
			{
				return;
			}
			PawnInteractNewComponent pawnInteractNewComponent = entity.CheckGetComponent<PawnInteractNewComponent>();
			if (pawnInteractNewComponent != null)
			{
				pawnInteractNewComponent.SetInteractionState(false, "HonamiStoryPickUp");
			}
			HonamiStoryItemDataBase itemDataBase = HonamiStoryModel.Instance.CreateHonamiStoryItemData(creatureDataComponent.HonamiStoryItemInfo, null);
			HonamiStoryModel.Instance.TryPickUp(itemDataBase, entity);
		}
	}
}
