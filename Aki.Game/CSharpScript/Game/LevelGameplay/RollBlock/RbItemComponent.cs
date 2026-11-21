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
	// Token: 0x02005BFF RID: 23551
	[NullableContext(1)]
	[Nullable(0)]
	public class RbItemComponent : RbBaseComponent
	{
		// Token: 0x06039D6C RID: 236908 RVA: 0x0103EAD4 File Offset: 0x0103CCD4
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

		// Token: 0x06039D6D RID: 236909 RVA: 0x0103EBC8 File Offset: 0x0103CDC8
		public override void OnActualShow()
		{
			this.InitItemLogic();
		}

		// Token: 0x06039D6E RID: 236910 RVA: 0x0103EBD0 File Offset: 0x0103CDD0
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

		// Token: 0x06039D6F RID: 236911 RVA: 0x0103EC7C File Offset: 0x0103CE7C
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

		// Token: 0x06039D70 RID: 236912 RVA: 0x0103ED58 File Offset: 0x0103CF58
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

		// Token: 0x06039D71 RID: 236913 RVA: 0x0103EE50 File Offset: 0x0103D050
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

		// Token: 0x17006E30 RID: 28208
		// (get) Token: 0x06039D72 RID: 236914 RVA: 0x0103EEEA File Offset: 0x0103D0EA
		public FTransformDouble ActorTransform
		{
			get
			{
				return this.ActorCompInternal.ActorTransform;
			}
		}

		// Token: 0x17006E31 RID: 28209
		// (get) Token: 0x06039D73 RID: 236915 RVA: 0x0103EEF7 File Offset: 0x0103D0F7
		public long CreatureDataId
		{
			get
			{
				return this.CreatureDataComp.GetCreatureDataId();
			}
		}

		// Token: 0x17006E32 RID: 28210
		// (get) Token: 0x06039D74 RID: 236916 RVA: 0x0103EF04 File Offset: 0x0103D104
		public SceneItemActorComponent ActorComp
		{
			get
			{
				return this.ActorCompInternal;
			}
		}

		// Token: 0x06039D75 RID: 236917 RVA: 0x0103EF0C File Offset: 0x0103D10C
		private void OnSceneItemStateChange(int stateId, bool _)
		{
			this.OnStateChange(stateId);
		}

		// Token: 0x06039D76 RID: 236918 RVA: 0x0103EF15 File Offset: 0x0103D115
		public void OnStateChange(int stateId)
		{
			if (this.ItemLogic != null)
			{
				this.ItemLogic.OnStateChange(stateId);
			}
		}

		// Token: 0x06039D77 RID: 236919 RVA: 0x0103EF2C File Offset: 0x0103D12C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RbItemComponent rbItemComponent = (RbItemComponent)componentTemplate;
			if (rbItemComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (rbItemComponent.ActorCompInternal == null)
			{
				this.ActorCompInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorCompInternal), "ActorCompInternal"))
			{
				return false;
			}
			if (rbItemComponent.ItemLogic == null)
			{
				this.ItemLogic = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ItemLogic), "ItemLogic"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17006E33 RID: 28211
		// (get) Token: 0x06039D78 RID: 236920 RVA: 0x0103EFCD File Offset: 0x0103D1CD
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17006E34 RID: 28212
		// (get) Token: 0x06039D79 RID: 236921 RVA: 0x0103EFD0 File Offset: 0x0103D1D0
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17006E35 RID: 28213
		// (get) Token: 0x06039D7A RID: 236922 RVA: 0x0103EFD3 File Offset: 0x0103D1D3
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401E8D9 RID: 125145
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401E8DA RID: 125146
		[Nullable(2)]
		private SceneItemActorComponent ActorCompInternal;

		// Token: 0x0401E8DB RID: 125147
		[Nullable(2)]
		private RbItemLogicBase ItemLogic;
	}
}
