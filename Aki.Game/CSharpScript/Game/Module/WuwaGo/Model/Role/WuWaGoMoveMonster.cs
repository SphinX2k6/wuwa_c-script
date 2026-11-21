using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x0200366F RID: 13935
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoMoveMonster : WuWaGoRole
	{
		// Token: 0x06024269 RID: 148073 RVA: 0x00A3C374 File Offset: 0x00A3A574
		public WuWaGoMoveMonster(Vector coordinate, Rotator rotator) : base(EWuWaGoRoleType.DiffractionEnemy, coordinate, rotator)
		{
		}

		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x0602426A RID: 148074 RVA: 0x00A3C38A File Offset: 0x00A3A58A
		public override bool Actionable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x0602426B RID: 148075 RVA: 0x00A3C38D File Offset: 0x00A3A58D
		public override bool MoveAbility
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x0602426C RID: 148076 RVA: 0x00A3C390 File Offset: 0x00A3A590
		public IReadOnlyList<WuWaGoGrid> Footprints
		{
			get
			{
				return this.FootprintsInner;
			}
		}

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x0602426D RID: 148077 RVA: 0x00A3C398 File Offset: 0x00A3A598
		// (set) Token: 0x0602426E RID: 148078 RVA: 0x00A3C3A0 File Offset: 0x00A3A5A0
		public bool IsTracking { get; private set; }

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x0602426F RID: 148079 RVA: 0x00A3C3A9 File Offset: 0x00A3A5A9
		// (set) Token: 0x06024270 RID: 148080 RVA: 0x00A3C3B1 File Offset: 0x00A3A5B1
		public int LastSeenPlayerGridId { get; private set; }

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x06024271 RID: 148081 RVA: 0x00A3C3BA File Offset: 0x00A3A5BA
		// (set) Token: 0x06024272 RID: 148082 RVA: 0x00A3C3C2 File Offset: 0x00A3A5C2
		public bool HasObservedPlayer { get; private set; }

		// Token: 0x06024273 RID: 148083 RVA: 0x00A3C3CB File Offset: 0x00A3A5CB
		public void PushFootprint(WuWaGoGrid grid)
		{
			base.MarkRollbackDirty();
			this.FootprintsInner.Add(grid);
		}

		// Token: 0x06024274 RID: 148084 RVA: 0x00A3C3DF File Offset: 0x00A3A5DF
		public void ClearFootprints()
		{
			if (this.FootprintsInner.Count == 0)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.FootprintsInner.Clear();
		}

		// Token: 0x06024275 RID: 148085 RVA: 0x00A3C400 File Offset: 0x00A3A600
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

		// Token: 0x06024276 RID: 148086 RVA: 0x00A3C42F File Offset: 0x00A3A62F
		public void SetIsTracking(bool value)
		{
			if (this.IsTracking == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.IsTracking = value;
		}

		// Token: 0x06024277 RID: 148087 RVA: 0x00A3C448 File Offset: 0x00A3A648
		public void SetLastSeenPlayerGridId(int value)
		{
			if (this.LastSeenPlayerGridId == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.LastSeenPlayerGridId = value;
		}

		// Token: 0x06024278 RID: 148088 RVA: 0x00A3C461 File Offset: 0x00A3A661
		public void SetHasObservedPlayer(bool value)
		{
			if (this.HasObservedPlayer == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.HasObservedPlayer = value;
		}

		// Token: 0x06024279 RID: 148089 RVA: 0x00A3C47A File Offset: 0x00A3A67A
		public override IRollbackCapture CaptureRollback()
		{
			return new MoveMonsterRollbackCapture(this);
		}

		// Token: 0x0401427D RID: 82557
		private readonly List<WuWaGoGrid> FootprintsInner = new List<WuWaGoGrid>();
	}
}
