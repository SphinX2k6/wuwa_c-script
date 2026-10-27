using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x0200473D RID: 18237
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class MoveMonsterRollbackCapture : RoleRollbackCapture<WuWaGoMoveMonster>
	{
		// Token: 0x0602FA9D RID: 195229 RVA: 0x00B0C264 File Offset: 0x00B0A464
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

		// Token: 0x0602FA9E RID: 195230 RVA: 0x00B0C2F4 File Offset: 0x00B0A4F4
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

		// Token: 0x04019BC9 RID: 105417
		private readonly List<int> FootprintIds;

		// Token: 0x04019BCA RID: 105418
		private readonly bool IsTracking;

		// Token: 0x04019BCB RID: 105419
		private readonly int LastSeenPlayerGridId;

		// Token: 0x04019BCC RID: 105420
		private readonly bool HasObservedPlayer;
	}
}
