using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.RollBlock.ItemLogic;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02006AA2 RID: 27298
	[NullableContext(1)]
	[Nullable(0)]
	public class RbItemComponent : RbBaseComponent
	{
		// Token: 0x06043D1A RID: 277786 RVA: 0x0109A390 File Offset: 0x01098590
		protected override bool OnStart()
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			if (this.CreatureDataComp == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[RbItemComp] CreatureDataComp is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.ActorCompInternal = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorCompInternal == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[RbItemComp] ActorCompInternal is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			RepeatedField<RbGridPosition> repeatedField;
			if (creatureDataComp == null)
			{
				repeatedField = null;
			}
			else
			{
				RbItemComponentPb rbItemInfo = creatureDataComp.RbItemInfo;
				repeatedField = ((rbItemInfo != null) ? rbItemInfo.OccupiedCellPositions : null);
			}
			RepeatedField<RbGridPosition> repeatedField2 = repeatedField;
			if (repeatedField2 != null)
			{
				foreach (RbGridPosition rbGridPosition in repeatedField2)
				{
					this.OccupiedCellIndex.Add(new JigsawIndex(rbGridPosition.X, rbGridPosition.Y));
				}
			}
			return true;
		}

		// Token: 0x06043D1B RID: 277787 RVA: 0x0109A484 File Offset: 0x01098684
		public override void OnActualShow()
		{
			this.InitItemLogic();
		}

		// Token: 0x06043D1C RID: 277788 RVA: 0x0109A48C File Offset: 0x0109868C
		private void InitItemLogic()
		{
			RbItemComponentPb rbItemInfo = this.CreatureDataComp.RbItemInfo;
			if (rbItemInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[RbItemComp] rbItemInfo is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataComp.GetCreatureDataId());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (rbItemInfo.BreakableObstacleType != null)
			{
				this.ItemLogic = new RbBreakableObstacleItemLogic(this);
				this.ItemLogic.Start(rbItemInfo.BreakableObstacleType);
			}
			if (rbItemInfo.RbLaserEmitterType != null)
			{
				this.ItemLogic = new RbLightBeamItemLogic(this);
				this.ItemLogic.Start(rbItemInfo.RbLaserEmitterType);
			}
		}

		// Token: 0x06043D1D RID: 277789 RVA: 0x0109A538 File Offset: 0x01098738
		protected override void OnEnable()
		{
			if (!EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange)))
			{
				EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			}
			if (!EventSystem.Instance.HasWithTarget<int>(base.Entity, EEventName.OnSceneItemStatePreChange, new Action<int>(this.OnStateChange)))
			{
				EventSystem.Instance.AddWithTarget<int>(base.Entity, EEventName.OnSceneItemStatePreChange, new Action<int>(this.OnStateChange));
			}
			if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnStateChange)))
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnStateChange));
			}
		}

		// Token: 0x06043D1E RID: 277790 RVA: 0x0109A614 File Offset: 0x01098814
		protected override void OnDisable(string reason)
		{
			if (this.ItemLogic != null)
			{
				this.ItemLogic.End();
				this.ItemLogic = null;
			}
			if (EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnSceneItemStateChange));
			}
			if (EventSystem.Instance.HasWithTarget<int>(base.Entity, EEventName.OnSceneItemStatePreChange, new Action<int>(this.OnStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget<int>(base.Entity, EEventName.OnSceneItemStatePreChange, new Action<int>(this.OnStateChange));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnStateChange)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnSceneItemStatePreChangeInSequence, new Action<int>(this.OnStateChange));
			}
		}

		// Token: 0x06043D1F RID: 277791 RVA: 0x0109A70C File Offset: 0x0109890C
		public void UpdateRollBlockItem(RbItemComponentPb rbItemInfo)
		{
			if (rbItemInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[UpdateRollBlockItem] rbItemInfo is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataComp.GetCreatureDataId());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.CreatureDataComp.RbItemInfo = rbItemInfo;
			if (this.ItemLogic != null)
			{
				if (rbItemInfo.BreakableObstacleType != null)
				{
					this.ItemLogic.OnRbItemUpdate(rbItemInfo.BreakableObstacleType);
				}
				if (rbItemInfo.RbLaserEmitterType != null)
				{
					this.ItemLogic.OnRbItemUpdate(rbItemInfo.RbLaserEmitterType);
				}
			}
		}

		// Token: 0x17009947 RID: 39239
		// (get) Token: 0x06043D20 RID: 277792 RVA: 0x0109A7A6 File Offset: 0x010989A6
		public FTransformDouble ActorTransform
		{
			get
			{
				return this.ActorCompInternal.ActorTransform;
			}
		}

		// Token: 0x17009948 RID: 39240
		// (get) Token: 0x06043D21 RID: 277793 RVA: 0x0109A7B3 File Offset: 0x010989B3
		public long CreatureDataId
		{
			get
			{
				return this.CreatureDataComp.GetCreatureDataId();
			}
		}

		// Token: 0x17009949 RID: 39241
		// (get) Token: 0x06043D22 RID: 277794 RVA: 0x0109A7C0 File Offset: 0x010989C0
		public SceneItemActorComponent ActorComp
		{
			get
			{
				return this.ActorCompInternal;
			}
		}

		// Token: 0x06043D23 RID: 277795 RVA: 0x0109A7C8 File Offset: 0x010989C8
		private void OnSceneItemStateChange(int stateId, bool _)
		{
			this.OnStateChange(stateId);
		}

		// Token: 0x06043D24 RID: 277796 RVA: 0x0109A7D1 File Offset: 0x010989D1
		public void OnStateChange(int stateId)
		{
			if (this.ItemLogic != null)
			{
				this.ItemLogic.OnStateChange(stateId);
			}
		}

		// Token: 0x06043D25 RID: 277797 RVA: 0x0109A7E8 File Offset: 0x010989E8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RbItemComponent rbItemComponent = (RbItemComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (rbItemComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorCompInternal"))
			{
				if (rbItemComponent.ActorCompInternal == null)
				{
					this.ActorCompInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorCompInternal), "ActorCompInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ItemLogic"))
			{
				if (rbItemComponent.ItemLogic == null)
				{
					this.ItemLogic = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RbItemLogicBase>(this.ItemLogic), "ItemLogic"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040236E7 RID: 145127
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040236E8 RID: 145128
		[Nullable(2)]
		private SceneItemActorComponent ActorCompInternal;

		// Token: 0x040236E9 RID: 145129
		[Nullable(2)]
		private RbItemLogicBase ItemLogic;
	}
}
