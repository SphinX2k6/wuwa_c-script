using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x0200473E RID: 18238
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoMoveMonster : WuWaGoRole
	{
		// Token: 0x0602FA9F RID: 195231 RVA: 0x00B0C3A8 File Offset: 0x00B0A5A8
		public WuWaGoMoveMonster(Vector coordinate, Rotator rotator) : base(EWuWaGoRoleType.DiffractionEnemy, coordinate, rotator)
		{
		}

		// Token: 0x17007716 RID: 30486
		// (get) Token: 0x0602FAA0 RID: 195232 RVA: 0x00B0C3BE File Offset: 0x00B0A5BE
		public override bool Actionable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007717 RID: 30487
		// (get) Token: 0x0602FAA1 RID: 195233 RVA: 0x00B0C3C1 File Offset: 0x00B0A5C1
		public override bool MoveAbility
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007718 RID: 30488
		// (get) Token: 0x0602FAA2 RID: 195234 RVA: 0x00B0C3C4 File Offset: 0x00B0A5C4
		public IReadOnlyList<WuWaGoGrid> Footprints
		{
			get
			{
				return this.FootprintsInner;
			}
		}

		// Token: 0x17007719 RID: 30489
		// (get) Token: 0x0602FAA3 RID: 195235 RVA: 0x00B0C3CC File Offset: 0x00B0A5CC
		// (set) Token: 0x0602FAA4 RID: 195236 RVA: 0x00B0C3D4 File Offset: 0x00B0A5D4
		public bool IsTracking { get; private set; }

		// Token: 0x1700771A RID: 30490
		// (get) Token: 0x0602FAA5 RID: 195237 RVA: 0x00B0C3DD File Offset: 0x00B0A5DD
		// (set) Token: 0x0602FAA6 RID: 195238 RVA: 0x00B0C3E5 File Offset: 0x00B0A5E5
		public int LastSeenPlayerGridId { get; private set; }

		// Token: 0x1700771B RID: 30491
		// (get) Token: 0x0602FAA7 RID: 195239 RVA: 0x00B0C3EE File Offset: 0x00B0A5EE
		// (set) Token: 0x0602FAA8 RID: 195240 RVA: 0x00B0C3F6 File Offset: 0x00B0A5F6
		public bool HasObservedPlayer { get; private set; }

		// Token: 0x0602FAA9 RID: 195241 RVA: 0x00B0C3FF File Offset: 0x00B0A5FF
		public void PushFootprint(WuWaGoGrid grid)
		{
			base.MarkRollbackDirty();
			this.FootprintsInner.Add(grid);
		}

		// Token: 0x0602FAAA RID: 195242 RVA: 0x00B0C413 File Offset: 0x00B0A613
		public void ClearFootprints()
		{
			if (this.FootprintsInner.Count == 0)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.FootprintsInner.Clear();
		}

		// Token: 0x0602FAAB RID: 195243 RVA: 0x00B0C434 File Offset: 0x00B0A634
		[NullableContext(2)]
		public WuWaGoGrid ShiftFootprint()
		{
			if (this.FootprintsInner.Count == 0)
			{
				return null;
			}
			base.MarkRollbackDirty();
			WuWaGoGrid result = this.FootprintsInner[0];
			this.FootprintsInner.RemoveAt(0);
			return result;
		}

		// Token: 0x0602FAAC RID: 195244 RVA: 0x00B0C463 File Offset: 0x00B0A663
		public void SetIsTracking(bool value)
		{
			if (this.IsTracking == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.IsTracking = value;
		}

		// Token: 0x0602FAAD RID: 195245 RVA: 0x00B0C47C File Offset: 0x00B0A67C
		public void SetLastSeenPlayerGridId(int value)
		{
			if (this.LastSeenPlayerGridId == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.LastSeenPlayerGridId = value;
		}

		// Token: 0x0602FAAE RID: 195246 RVA: 0x00B0C495 File Offset: 0x00B0A695
		public void SetHasObservedPlayer(bool value)
		{
			if (this.HasObservedPlayer == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.HasObservedPlayer = value;
		}

		// Token: 0x0602FAAF RID: 195247 RVA: 0x00B0C4AE File Offset: 0x00B0A6AE
		public override IRollbackCapture CaptureRollback()
		{
			return new MoveMonsterRollbackCapture(this);
		}

		// Token: 0x04019BCD RID: 105421
		private readonly List<WuWaGoGrid> FootprintsInner = new List<WuWaGoGrid>();
	}
}
