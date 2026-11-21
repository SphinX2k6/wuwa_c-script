using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005458 RID: 21592
	public class IBubbleComponentT
	{
		// Token: 0x1700997E RID: 39294
		// (get) Token: 0x06021E56 RID: 138838 RVA: 0x004AC2D2 File Offset: 0x004AA4D2
		// (set) Token: 0x06021E57 RID: 138839 RVA: 0x004AC2DA File Offset: 0x004AA4DA
		public bool Disabled { get; set; }

		// Token: 0x1700997F RID: 39295
		// (get) Token: 0x06021E58 RID: 138840 RVA: 0x004AC2E3 File Offset: 0x004AA4E3
		// (set) Token: 0x06021E59 RID: 138841 RVA: 0x004AC2EB File Offset: 0x004AA4EB
		public List<int> NpcIds { get; set; }

		// Token: 0x17009980 RID: 39296
		// (get) Token: 0x06021E5A RID: 138842 RVA: 0x004AC2F4 File Offset: 0x004AA4F4
		// (set) Token: 0x06021E5B RID: 138843 RVA: 0x004AC2FC File Offset: 0x004AA4FC
		public float EnterRange { get; set; }

		// Token: 0x17009981 RID: 39297
		// (get) Token: 0x06021E5C RID: 138844 RVA: 0x004AC305 File Offset: 0x004AA505
		// (set) Token: 0x06021E5D RID: 138845 RVA: 0x004AC30D File Offset: 0x004AA50D
		public float LeaveRange { get; set; }

		// Token: 0x17009982 RID: 39298
		// (get) Token: 0x06021E5E RID: 138846 RVA: 0x004AC316 File Offset: 0x004AA516
		// (set) Token: 0x06021E5F RID: 138847 RVA: 0x004AC31E File Offset: 0x004AA51E
		public bool IsRangeFollowEntity { get; set; }

		// Token: 0x17009983 RID: 39299
		// (get) Token: 0x06021E60 RID: 138848 RVA: 0x004AC327 File Offset: 0x004AA527
		// (set) Token: 0x06021E61 RID: 138849 RVA: 0x004AC32F File Offset: 0x004AA52F
		public List<IConditionBubbleDataT> Flows { get; set; }

		// Token: 0x17009984 RID: 39300
		// (get) Token: 0x06021E62 RID: 138850 RVA: 0x004AC338 File Offset: 0x004AA538
		// (set) Token: 0x06021E63 RID: 138851 RVA: 0x004AC340 File Offset: 0x004AA540
		public int TimberId { get; set; }

		// Token: 0x17009985 RID: 39301
		// (get) Token: 0x06021E64 RID: 138852 RVA: 0x004AC349 File Offset: 0x004AA549
		// (set) Token: 0x06021E65 RID: 138853 RVA: 0x004AC351 File Offset: 0x004AA551
		public float Scale { get; set; }

		// Token: 0x17009986 RID: 39302
		// (get) Token: 0x06021E66 RID: 138854 RVA: 0x004AC35A File Offset: 0x004AA55A
		// (set) Token: 0x06021E67 RID: 138855 RVA: 0x004AC362 File Offset: 0x004AA562
		public bool IsAudioOccludedByScene { get; set; }

		// Token: 0x17009987 RID: 39303
		// (get) Token: 0x06021E68 RID: 138856 RVA: 0x004AC36B File Offset: 0x004AA56B
		// (set) Token: 0x06021E69 RID: 138857 RVA: 0x004AC373 File Offset: 0x004AA573
		public IBubbleRangeCylinderConfigT TriggerCylinderConfig { get; set; }

		// Token: 0x17009988 RID: 39304
		// (get) Token: 0x06021E6A RID: 138858 RVA: 0x004AC37C File Offset: 0x004AA57C
		// (set) Token: 0x06021E6B RID: 138859 RVA: 0x004AC384 File Offset: 0x004AA584
		public bool IsPlayMouthAnim { get; set; }

		// Token: 0x17009989 RID: 39305
		// (get) Token: 0x06021E6C RID: 138860 RVA: 0x004AC38D File Offset: 0x004AA58D
		// (set) Token: 0x06021E6D RID: 138861 RVA: 0x004AC395 File Offset: 0x004AA595
		public byte NullMask { get; set; }

		// Token: 0x06021E6E RID: 138862 RVA: 0x004AC3A0 File Offset: 0x004AA5A0
		public IBubbleComponentT()
		{
			this.Disabled = false;
			this.NpcIds = null;
			this.EnterRange = 0f;
			this.LeaveRange = 0f;
			this.IsRangeFollowEntity = false;
			this.Flows = null;
			this.TimberId = 0;
			this.Scale = 0f;
			this.IsAudioOccludedByScene = false;
			this.TriggerCylinderConfig = null;
			this.IsPlayMouthAnim = false;
			this.NullMask = 0;
		}
	}
}
