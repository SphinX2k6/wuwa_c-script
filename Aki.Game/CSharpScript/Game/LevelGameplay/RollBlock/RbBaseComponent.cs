using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02005BFC RID: 23548
	[NullableContext(1)]
	[Nullable(0)]
	public class RbBaseComponent : EntityComponent
	{
		// Token: 0x06039D4C RID: 236876 RVA: 0x0103DA30 File Offset: 0x0103BC30
		public virtual void RegisterToGameplay(int incId)
		{
			this.IncId = new int?(incId);
			this.OriginForward = RollBlockController.Instance.GetForwardVector(this.IncId.Value);
			this.OriginRight = RollBlockController.Instance.GetRightVector(this.IncId.Value);
		}

		// Token: 0x06039D4D RID: 236877 RVA: 0x0103DA7F File Offset: 0x0103BC7F
		public virtual bool IsMoving()
		{
			return false;
		}

		// Token: 0x06039D4E RID: 236878 RVA: 0x0103DA82 File Offset: 0x0103BC82
		public virtual void OnActualShow()
		{
		}

		// Token: 0x06039D4F RID: 236879 RVA: 0x0103DA84 File Offset: 0x0103BC84
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			RbBaseComponent rbBaseComponent = (RbBaseComponent)componentTemplate;
			this.IncId = rbBaseComponent.IncId;
			if (rbBaseComponent.OriginForward == null)
			{
				this.OriginForward = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OriginForward), "OriginForward"))
			{
				return false;
			}
			if (rbBaseComponent.OriginRight == null)
			{
				this.OriginRight = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OriginRight), "OriginRight"))
			{
				return false;
			}
			this.IsMainController = rbBaseComponent.IsMainController;
			if (rbBaseComponent.OccupiedCellIndex == null)
			{
				this.OccupiedCellIndex = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OccupiedCellIndex), "OccupiedCellIndex"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x0401E8C5 RID: 125125
		public int? IncId;

		// Token: 0x0401E8C6 RID: 125126
		[Nullable(2)]
		public Vector OriginForward;

		// Token: 0x0401E8C7 RID: 125127
		[Nullable(2)]
		public Vector OriginRight;

		// Token: 0x0401E8C8 RID: 125128
		public bool IsMainController;

		// Token: 0x0401E8C9 RID: 125129
		public List<JigsawIndex> OccupiedCellIndex = new List<JigsawIndex>();
	}
}
