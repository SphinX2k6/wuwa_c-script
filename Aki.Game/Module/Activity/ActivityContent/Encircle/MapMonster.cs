using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003011 RID: 12305
	[NullableContext(2)]
	[Nullable(0)]
	internal class MapMonster
	{
		// Token: 0x0601D314 RID: 119572 RVA: 0x008E9A0E File Offset: 0x008E7C0E
		[NullableContext(1)]
		public MapMonster(IHexPos pos, int mapItemId, int priority)
		{
			this.PosInternal = pos;
			this.MapItemIdInternal = new int?(mapItemId);
			this.PriorityInternal = priority;
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0601D315 RID: 119573 RVA: 0x008E9A37 File Offset: 0x008E7C37
		public int Priority
		{
			get
			{
				return this.PriorityInternal;
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0601D316 RID: 119574 RVA: 0x008E9A3F File Offset: 0x008E7C3F
		// (set) Token: 0x0601D317 RID: 119575 RVA: 0x008E9A47 File Offset: 0x008E7C47
		public IHexPos Pos
		{
			get
			{
				return this.PosInternal;
			}
			set
			{
				this.PosInternal = value;
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x0601D318 RID: 119576 RVA: 0x008E9A50 File Offset: 0x008E7C50
		// (set) Token: 0x0601D319 RID: 119577 RVA: 0x008E9A58 File Offset: 0x008E7C58
		public bool BeTrapped
		{
			get
			{
				return this.BeTrappedInternal;
			}
			set
			{
				this.BeTrappedInternal = value;
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0601D31A RID: 119578 RVA: 0x008E9A61 File Offset: 0x008E7C61
		// (set) Token: 0x0601D31B RID: 119579 RVA: 0x008E9A69 File Offset: 0x008E7C69
		public bool BeCaught
		{
			get
			{
				return this.BeCaughtInternal;
			}
			set
			{
				this.BeCaughtInternal = value;
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0601D31C RID: 119580 RVA: 0x008E9A72 File Offset: 0x008E7C72
		// (set) Token: 0x0601D31D RID: 119581 RVA: 0x008E9A7A File Offset: 0x008E7C7A
		public int? MapItemId
		{
			get
			{
				return this.MapItemIdInternal;
			}
			set
			{
				this.MapItemIdInternal = value;
			}
		}

		// Token: 0x0400F5C9 RID: 62921
		private IHexPos PosInternal;

		// Token: 0x0400F5CA RID: 62922
		private int? MapItemIdInternal;

		// Token: 0x0400F5CB RID: 62923
		private bool BeTrappedInternal;

		// Token: 0x0400F5CC RID: 62924
		private bool BeCaughtInternal;

		// Token: 0x0400F5CD RID: 62925
		private readonly int PriorityInternal = 1;
	}
}
