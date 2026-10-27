using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006135 RID: 24885
	public class IAddPlayBubbleT
	{
		// Token: 0x1700B772 RID: 46962
		// (get) Token: 0x0602A8C5 RID: 174277 RVA: 0x005DBE0F File Offset: 0x005DA00F
		// (set) Token: 0x0602A8C6 RID: 174278 RVA: 0x005DBE17 File Offset: 0x005DA017
		public List<int> EntityIds { get; set; }

		// Token: 0x1700B773 RID: 46963
		// (get) Token: 0x0602A8C7 RID: 174279 RVA: 0x005DBE20 File Offset: 0x005DA020
		// (set) Token: 0x0602A8C8 RID: 174280 RVA: 0x005DBE28 File Offset: 0x005DA028
		public float EnterRadius { get; set; }

		// Token: 0x1700B774 RID: 46964
		// (get) Token: 0x0602A8C9 RID: 174281 RVA: 0x005DBE31 File Offset: 0x005DA031
		// (set) Token: 0x0602A8CA RID: 174282 RVA: 0x005DBE39 File Offset: 0x005DA039
		public float LeaveRadius { get; set; }

		// Token: 0x1700B775 RID: 46965
		// (get) Token: 0x0602A8CB RID: 174283 RVA: 0x005DBE42 File Offset: 0x005DA042
		// (set) Token: 0x0602A8CC RID: 174284 RVA: 0x005DBE4A File Offset: 0x005DA04A
		public bool IsRangeFollowEntity { get; set; }

		// Token: 0x1700B776 RID: 46966
		// (get) Token: 0x0602A8CD RID: 174285 RVA: 0x005DBE53 File Offset: 0x005DA053
		// (set) Token: 0x0602A8CE RID: 174286 RVA: 0x005DBE5B File Offset: 0x005DA05B
		public IBubbleIndexT Flow { get; set; }

		// Token: 0x1700B777 RID: 46967
		// (get) Token: 0x0602A8CF RID: 174287 RVA: 0x005DBE64 File Offset: 0x005DA064
		// (set) Token: 0x0602A8D0 RID: 174288 RVA: 0x005DBE6C File Offset: 0x005DA06C
		public int WaitTime { get; set; }

		// Token: 0x1700B778 RID: 46968
		// (get) Token: 0x0602A8D1 RID: 174289 RVA: 0x005DBE75 File Offset: 0x005DA075
		// (set) Token: 0x0602A8D2 RID: 174290 RVA: 0x005DBE7D File Offset: 0x005DA07D
		public bool RedDot { get; set; }

		// Token: 0x1700B779 RID: 46969
		// (get) Token: 0x0602A8D3 RID: 174291 RVA: 0x005DBE86 File Offset: 0x005DA086
		// (set) Token: 0x0602A8D4 RID: 174292 RVA: 0x005DBE8E File Offset: 0x005DA08E
		public bool IsAudioOccludedByScene { get; set; }

		// Token: 0x1700B77A RID: 46970
		// (get) Token: 0x0602A8D5 RID: 174293 RVA: 0x005DBE97 File Offset: 0x005DA097
		// (set) Token: 0x0602A8D6 RID: 174294 RVA: 0x005DBE9F File Offset: 0x005DA09F
		public IBubbleRangeCylinderConfigT TriggerCylinderConfig { get; set; }

		// Token: 0x1700B77B RID: 46971
		// (get) Token: 0x0602A8D7 RID: 174295 RVA: 0x005DBEA8 File Offset: 0x005DA0A8
		// (set) Token: 0x0602A8D8 RID: 174296 RVA: 0x005DBEB0 File Offset: 0x005DA0B0
		public bool IsPlayMouthAnim { get; set; }

		// Token: 0x1700B77C RID: 46972
		// (get) Token: 0x0602A8D9 RID: 174297 RVA: 0x005DBEB9 File Offset: 0x005DA0B9
		// (set) Token: 0x0602A8DA RID: 174298 RVA: 0x005DBEC1 File Offset: 0x005DA0C1
		public byte NullMask { get; set; }

		// Token: 0x0602A8DB RID: 174299 RVA: 0x005DBECC File Offset: 0x005DA0CC
		public IAddPlayBubbleT()
		{
			this.EntityIds = null;
			this.EnterRadius = 0f;
			this.LeaveRadius = 0f;
			this.IsRangeFollowEntity = false;
			this.Flow = null;
			this.WaitTime = 0;
			this.RedDot = false;
			this.IsAudioOccludedByScene = false;
			this.TriggerCylinderConfig = null;
			this.IsPlayMouthAnim = false;
			this.NullMask = 0;
		}
	}
}
