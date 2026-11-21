using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02005BFE RID: 23550
	public class RbFloorComponent : RbBaseComponent
	{
		// Token: 0x06039D68 RID: 236904 RVA: 0x0103E9CC File Offset: 0x0103CBCC
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

		// Token: 0x06039D69 RID: 236905 RVA: 0x0103EA88 File Offset: 0x0103CC88
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			if (((RbFloorComponent)componentTemplate).CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17006E2F RID: 28207
		// (get) Token: 0x06039D6A RID: 236906 RVA: 0x0103EAC6 File Offset: 0x0103CCC6
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401E8D8 RID: 125144
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;
	}
}
