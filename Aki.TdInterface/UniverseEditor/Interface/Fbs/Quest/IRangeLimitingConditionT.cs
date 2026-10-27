using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004068 RID: 16488
	public class IRangeLimitingConditionT
	{
		// Token: 0x17007438 RID: 29752
		// (get) Token: 0x06017F13 RID: 98067 RVA: 0x003749D6 File Offset: 0x00372BD6
		// (set) Token: 0x06017F14 RID: 98068 RVA: 0x003749DE File Offset: 0x00372BDE
		public ERangeLimitingPriority Priority { get; set; }

		// Token: 0x17007439 RID: 29753
		// (get) Token: 0x06017F15 RID: 98069 RVA: 0x003749E7 File Offset: 0x00372BE7
		// (set) Token: 0x06017F16 RID: 98070 RVA: 0x003749EF File Offset: 0x00372BEF
		public IVectorInfoT Point { get; set; }

		// Token: 0x1700743A RID: 29754
		// (get) Token: 0x06017F17 RID: 98071 RVA: 0x003749F8 File Offset: 0x00372BF8
		// (set) Token: 0x06017F18 RID: 98072 RVA: 0x00374A00 File Offset: 0x00372C00
		public int Range { get; set; }

		// Token: 0x1700743B RID: 29755
		// (get) Token: 0x06017F19 RID: 98073 RVA: 0x00374A09 File Offset: 0x00372C09
		// (set) Token: 0x06017F1A RID: 98074 RVA: 0x00374A11 File Offset: 0x00372C11
		public string RangeEffectPath { get; set; }

		// Token: 0x1700743C RID: 29756
		// (get) Token: 0x06017F1B RID: 98075 RVA: 0x00374A1A File Offset: 0x00372C1A
		// (set) Token: 0x06017F1C RID: 98076 RVA: 0x00374A22 File Offset: 0x00372C22
		public float OverRangeCountdown { get; set; }

		// Token: 0x1700743D RID: 29757
		// (get) Token: 0x06017F1D RID: 98077 RVA: 0x00374A2B File Offset: 0x00372C2B
		// (set) Token: 0x06017F1E RID: 98078 RVA: 0x00374A33 File Offset: 0x00372C33
		public int WarningRange { get; set; }

		// Token: 0x1700743E RID: 29758
		// (get) Token: 0x06017F1F RID: 98079 RVA: 0x00374A3C File Offset: 0x00372C3C
		// (set) Token: 0x06017F20 RID: 98080 RVA: 0x00374A44 File Offset: 0x00372C44
		public bool RequiresSecondConfirmation { get; set; }

		// Token: 0x1700743F RID: 29759
		// (get) Token: 0x06017F21 RID: 98081 RVA: 0x00374A4D File Offset: 0x00372C4D
		// (set) Token: 0x06017F22 RID: 98082 RVA: 0x00374A55 File Offset: 0x00372C55
		public List<int> RangeEntities { get; set; }

		// Token: 0x17007440 RID: 29760
		// (get) Token: 0x06017F23 RID: 98083 RVA: 0x00374A5E File Offset: 0x00372C5E
		// (set) Token: 0x06017F24 RID: 98084 RVA: 0x00374A66 File Offset: 0x00372C66
		public List<int> WarningRangeEntities { get; set; }

		// Token: 0x17007441 RID: 29761
		// (get) Token: 0x06017F25 RID: 98085 RVA: 0x00374A6F File Offset: 0x00372C6F
		// (set) Token: 0x06017F26 RID: 98086 RVA: 0x00374A77 File Offset: 0x00372C77
		public IWarningPreformT WarningPreform { get; set; }

		// Token: 0x17007442 RID: 29762
		// (get) Token: 0x06017F27 RID: 98087 RVA: 0x00374A80 File Offset: 0x00372C80
		// (set) Token: 0x06017F28 RID: 98088 RVA: 0x00374A88 File Offset: 0x00372C88
		public List<int> AcceptableDungeonIds { get; set; }

		// Token: 0x17007443 RID: 29763
		// (get) Token: 0x06017F29 RID: 98089 RVA: 0x00374A91 File Offset: 0x00372C91
		// (set) Token: 0x06017F2A RID: 98090 RVA: 0x00374A99 File Offset: 0x00372C99
		public bool OnlyFailOnceOutsideDungeon { get; set; }

		// Token: 0x17007444 RID: 29764
		// (get) Token: 0x06017F2B RID: 98091 RVA: 0x00374AA2 File Offset: 0x00372CA2
		// (set) Token: 0x06017F2C RID: 98092 RVA: 0x00374AAA File Offset: 0x00372CAA
		public byte NullMask { get; set; }

		// Token: 0x06017F2D RID: 98093 RVA: 0x00374AB4 File Offset: 0x00372CB4
		public IRangeLimitingConditionT()
		{
			this.Priority = ERangeLimitingPriority.Low;
			this.Point = null;
			this.Range = 0;
			this.RangeEffectPath = null;
			this.OverRangeCountdown = 0f;
			this.WarningRange = 0;
			this.RequiresSecondConfirmation = false;
			this.RangeEntities = null;
			this.WarningRangeEntities = null;
			this.WarningPreform = null;
			this.AcceptableDungeonIds = null;
			this.OnlyFailOnceOutsideDungeon = false;
			this.NullMask = 0;
		}
	}
}
