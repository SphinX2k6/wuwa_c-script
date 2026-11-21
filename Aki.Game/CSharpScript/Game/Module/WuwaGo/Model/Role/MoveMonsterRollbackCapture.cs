using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x0200366E RID: 13934
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class MoveMonsterRollbackCapture : RoleRollbackCapture<WuWaGoMoveMonster>
	{
		// Token: 0x06024267 RID: 148071 RVA: 0x00A3C230 File Offset: 0x00A3A430
		public MoveMonsterRollbackCapture(WuWaGoMoveMonster monster) : base(monster)
		{
			this.FootprintIds = new List<int>();
			foreach (WuWaGoGrid wuWaGoGrid in monster.Footprints)
			{
				this.FootprintIds.Add(wuWaGoGrid.Id);
			}
			this.IsTracking = monster.IsTracking;
			this.LastSeenPlayerGridId = monster.LastSeenPlayerGridId;
			this.HasObservedPlayer = monster.HasObservedPlayer;
		}

		// Token: 0x06024268 RID: 148072 RVA: 0x00A3C2C0 File Offset: 0x00A3A4C0
		public override void Restore()
		{
			base.Restore();
			base.Role.ClearFootprints();
			WuWaGoModel instance = WuWaGoModel.Instance;
			foreach (int gridId in this.FootprintIds)
			{
				WuWaGoGrid wuWaGoGrid = (instance != null) ? instance.GetGridById(gridId) : null;
				if (wuWaGoGrid != null)
				{
					base.Role.PushFootprint(wuWaGoGrid);
				}
			}
			base.Role.SetIsTracking(this.IsTracking);
			base.Role.SetLastSeenPlayerGridId(this.LastSeenPlayerGridId);
			base.Role.SetHasObservedPlayer(this.HasObservedPlayer);
		}

		// Token: 0x04014279 RID: 82553
		private readonly List<int> FootprintIds;

		// Token: 0x0401427A RID: 82554
		private readonly bool IsTracking;

		// Token: 0x0401427B RID: 82555
		private readonly int LastSeenPlayerGridId;

		// Token: 0x0401427C RID: 82556
		private readonly bool HasObservedPlayer;
	}
}
