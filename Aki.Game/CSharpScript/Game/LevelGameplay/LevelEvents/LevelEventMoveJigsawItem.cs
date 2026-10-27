using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B41 RID: 27457
	public class LevelEventMoveJigsawItem : LevelEventBase
	{
		// Token: 0x0604415F RID: 278879 RVA: 0x010BEAEB File Offset: 0x010BCCEB
		public LevelEventMoveJigsawItem(int id) : base(id)
		{
		}

		// Token: 0x06044160 RID: 278880 RVA: 0x010BEAF4 File Offset: 0x010BCCF4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			SetJigsawItem setJigsawItem = inParams as SetJigsawItem;
			if (setJigsawItem == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			this.Config = setJigsawItem.Config;
			base.CreateWaitEntityTask(new List<int>
			{
				this.Config.ItemEntityId,
				this.Config.FoundationEntityId
			});
		}

		// Token: 0x06044161 RID: 278881 RVA: 0x010BEB50 File Offset: 0x010BCD50
		protected override void ExecuteWhenEntitiesReady()
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.Config.ItemEntityId);
			EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId(this.Config.FoundationEntityId);
			SceneItemActorComponent component = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
			if (component == null)
			{
				return;
			}
			if (entityByPbDataId == null || entityByPbDataId2 == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			SceneItemJigsawItemComponent component2 = entityByPbDataId.Entity.GetComponent<SceneItemJigsawItemComponent>();
			SceneItemJigsawBaseComponent component3 = entityByPbDataId2.Entity.GetComponent<SceneItemJigsawBaseComponent>();
			if (component2 == null || component3 == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			SceneItemJigsawBaseComponent putDownBase = component2.PutDownBase;
			if (putDownBase != null)
			{
				SceneItemOutletComponent component4 = putDownBase.Entity.GetComponent<SceneItemOutletComponent>();
				EItemFoundation type = (component4 != null) ? component4.Config.Config.Type : EItemFoundation.BuildingBlock;
				putDownBase.PickUpItem(component2, component2.PutDownIndex, type, true);
			}
			JigsawIndex jigsawIndex = new JigsawIndex(this.Config.Destination.RowIndex, this.Config.Destination.ColumnIndex);
			SceneItemOutletComponent component5 = entityByPbDataId2.Entity.GetComponent<SceneItemOutletComponent>();
			EItemFoundation type2 = (component5 != null) ? component5.Config.Config.Type : EItemFoundation.BuildingBlock;
			component3.PutDownItem(component2, jigsawIndex, type2, true);
			Vector blockLocationByIndex = component3.GetBlockLocationByIndex(jigsawIndex, true);
			component.SetActorLocation(blockLocationByIndex.ToUeVector(false), "LevelEventMoveJigsawItem", true);
			SceneItemMovementSyncComponent component6 = entityByPbDataId.Entity.GetComponent<SceneItemMovementSyncComponent>();
			if (component6 != null)
			{
				component6.CollectSampleAndSend(true);
			}
			component3.RequestMoveItem(component2, jigsawIndex, null);
			component3.CheckFinish();
			base.FinishExecute(true, false, true);
		}

		// Token: 0x04023914 RID: 145684
		[Nullable(2)]
		private IMoveJigsawItem Config;
	}
}
