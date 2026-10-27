using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02006A9F RID: 27295
	[NullableContext(1)]
	[Nullable(0)]
	public class RbBaseComponent : EntityComponent
	{
		// Token: 0x06043CFE RID: 277758 RVA: 0x010991E8 File Offset: 0x010973E8
		public virtual void RegisterToGameplay(int incId)
		{
			this.IncId = new int?(incId);
			this.OriginForward = RollBlockController.Instance.GetForwardVector(this.IncId.Value);
			this.OriginRight = RollBlockController.Instance.GetRightVector(this.IncId.Value);
		}

		// Token: 0x06043CFF RID: 277759 RVA: 0x01099237 File Offset: 0x01097437
		public virtual bool IsMoving()
		{
			return false;
		}

		// Token: 0x06043D00 RID: 277760 RVA: 0x0109923A File Offset: 0x0109743A
		public virtual void OnActualShow()
		{
		}

		// Token: 0x06043D01 RID: 277761 RVA: 0x0109923C File Offset: 0x0109743C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RbBaseComponent rbBaseComponent = (RbBaseComponent)componentTemplate;
			if (base.CanResetComponentProperty("IncId"))
			{
				this.IncId = rbBaseComponent.IncId;
			}
			if (base.CanResetComponentProperty("OriginForward"))
			{
				if (rbBaseComponent.OriginForward == null)
				{
					this.OriginForward = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.OriginForward), "OriginForward"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OriginRight"))
			{
				if (rbBaseComponent.OriginRight == null)
				{
					this.OriginRight = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.OriginRight), "OriginRight"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsMainController"))
			{
				this.IsMainController = rbBaseComponent.IsMainController;
			}
			if (base.CanResetComponentProperty("OccupiedCellIndex"))
			{
				if (rbBaseComponent.OccupiedCellIndex == null)
				{
					this.OccupiedCellIndex = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<JigsawIndex>>(this.OccupiedCellIndex), "OccupiedCellIndex"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040236D3 RID: 145107
		public int? IncId;

		// Token: 0x040236D4 RID: 145108
		[Nullable(2)]
		public Vector OriginForward;

		// Token: 0x040236D5 RID: 145109
		[Nullable(2)]
		public Vector OriginRight;

		// Token: 0x040236D6 RID: 145110
		public bool IsMainController;

		// Token: 0x040236D7 RID: 145111
		public List<JigsawIndex> OccupiedCellIndex = new List<JigsawIndex>();
	}
}
