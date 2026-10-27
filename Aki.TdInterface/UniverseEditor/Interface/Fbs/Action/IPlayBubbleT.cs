using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD6 RID: 27862
	public class IPlayBubbleT
	{
		// Token: 0x1700CF72 RID: 53106
		// (get) Token: 0x060311C3 RID: 201155 RVA: 0x006A9FC5 File Offset: 0x006A81C5
		// (set) Token: 0x060311C4 RID: 201156 RVA: 0x006A9FCD File Offset: 0x006A81CD
		public int EntityId { get; set; }

		// Token: 0x1700CF73 RID: 53107
		// (get) Token: 0x060311C5 RID: 201157 RVA: 0x006A9FD6 File Offset: 0x006A81D6
		// (set) Token: 0x060311C6 RID: 201158 RVA: 0x006A9FDE File Offset: 0x006A81DE
		public IBubbleIndexT Flow { get; set; }

		// Token: 0x1700CF74 RID: 53108
		// (get) Token: 0x060311C7 RID: 201159 RVA: 0x006A9FE7 File Offset: 0x006A81E7
		// (set) Token: 0x060311C8 RID: 201160 RVA: 0x006A9FEF File Offset: 0x006A81EF
		public bool IsRangeFollowEntity { get; set; }

		// Token: 0x1700CF75 RID: 53109
		// (get) Token: 0x060311C9 RID: 201161 RVA: 0x006A9FF8 File Offset: 0x006A81F8
		// (set) Token: 0x060311CA RID: 201162 RVA: 0x006AA000 File Offset: 0x006A8200
		public bool IsAudioOccludedByScene { get; set; }

		// Token: 0x1700CF76 RID: 53110
		// (get) Token: 0x060311CB RID: 201163 RVA: 0x006AA009 File Offset: 0x006A8209
		// (set) Token: 0x060311CC RID: 201164 RVA: 0x006AA011 File Offset: 0x006A8211
		public IBubbleRangeCylinderConfigT TriggerCylinderConfig { get; set; }

		// Token: 0x1700CF77 RID: 53111
		// (get) Token: 0x060311CD RID: 201165 RVA: 0x006AA01A File Offset: 0x006A821A
		// (set) Token: 0x060311CE RID: 201166 RVA: 0x006AA022 File Offset: 0x006A8222
		public bool IsPlayMouthAnim { get; set; }

		// Token: 0x1700CF78 RID: 53112
		// (get) Token: 0x060311CF RID: 201167 RVA: 0x006AA02B File Offset: 0x006A822B
		// (set) Token: 0x060311D0 RID: 201168 RVA: 0x006AA033 File Offset: 0x006A8233
		public byte NullMask { get; set; }

		// Token: 0x060311D1 RID: 201169 RVA: 0x006AA03C File Offset: 0x006A823C
		public IPlayBubbleT()
		{
			this.EntityId = 0;
			this.Flow = null;
			this.IsRangeFollowEntity = false;
			this.IsAudioOccludedByScene = false;
			this.TriggerCylinderConfig = null;
			this.IsPlayMouthAnim = false;
			this.NullMask = 0;
		}
	}
}
