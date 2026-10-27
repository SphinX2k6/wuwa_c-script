using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02006AA1 RID: 27297
	public class RbFloorComponent : RbBaseComponent
	{
		// Token: 0x06043D17 RID: 277783 RVA: 0x0109A274 File Offset: 0x01098474
		protected override bool OnStart()
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			if (this.CreatureDataComp == null)
			{
				Log.Instance.Error(ELogModule.RollBlock, ELogAuthor.CH, "[RbItemComp] CreatureDataComp is null", default(ReadOnlySpan<ValueTuple<string, object>>));
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
				RbFloorComponentPb rbFloorInfo = creatureDataComp.RbFloorInfo;
				repeatedField = ((rbFloorInfo != null) ? rbFloorInfo.OccupiedCellPositions : null);
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

		// Token: 0x06043D18 RID: 277784 RVA: 0x0109A330 File Offset: 0x01098530
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RbFloorComponent rbFloorComponent = (RbFloorComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (rbFloorComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040236E6 RID: 145126
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;
	}
}
