using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200679A RID: 26522
	public class IAddPlayBubbleT
	{
		// Token: 0x1700C0E2 RID: 49378
		// (get) Token: 0x0602CFBE RID: 184254 RVA: 0x00625FEB File Offset: 0x006241EB
		// (set) Token: 0x0602CFBF RID: 184255 RVA: 0x00625FF3 File Offset: 0x006241F3
		public List<int> EntityIds { get; set; }

		// Token: 0x1700C0E3 RID: 49379
		// (get) Token: 0x0602CFC0 RID: 184256 RVA: 0x00625FFC File Offset: 0x006241FC
		// (set) Token: 0x0602CFC1 RID: 184257 RVA: 0x00626004 File Offset: 0x00624204
		public float EnterRadius { get; set; }

		// Token: 0x1700C0E4 RID: 49380
		// (get) Token: 0x0602CFC2 RID: 184258 RVA: 0x0062600D File Offset: 0x0062420D
		// (set) Token: 0x0602CFC3 RID: 184259 RVA: 0x00626015 File Offset: 0x00624215
		public float LeaveRadius { get; set; }

		// Token: 0x1700C0E5 RID: 49381
		// (get) Token: 0x0602CFC4 RID: 184260 RVA: 0x0062601E File Offset: 0x0062421E
		// (set) Token: 0x0602CFC5 RID: 184261 RVA: 0x00626026 File Offset: 0x00624226
		public bool IsRangeFollowEntity { get; set; }

		// Token: 0x1700C0E6 RID: 49382
		// (get) Token: 0x0602CFC6 RID: 184262 RVA: 0x0062602F File Offset: 0x0062422F
		// (set) Token: 0x0602CFC7 RID: 184263 RVA: 0x00626037 File Offset: 0x00624237
		public IBubbleIndexT Flow { get; set; }

		// Token: 0x1700C0E7 RID: 49383
		// (get) Token: 0x0602CFC8 RID: 184264 RVA: 0x00626040 File Offset: 0x00624240
		// (set) Token: 0x0602CFC9 RID: 184265 RVA: 0x00626048 File Offset: 0x00624248
		public int WaitTime { get; set; }

		// Token: 0x1700C0E8 RID: 49384
		// (get) Token: 0x0602CFCA RID: 184266 RVA: 0x00626051 File Offset: 0x00624251
		// (set) Token: 0x0602CFCB RID: 184267 RVA: 0x00626059 File Offset: 0x00624259
		public bool RedDot { get; set; }

		// Token: 0x1700C0E9 RID: 49385
		// (get) Token: 0x0602CFCC RID: 184268 RVA: 0x00626062 File Offset: 0x00624262
		// (set) Token: 0x0602CFCD RID: 184269 RVA: 0x0062606A File Offset: 0x0062426A
		public bool IsAudioOccludedByScene { get; set; }

		// Token: 0x1700C0EA RID: 49386
		// (get) Token: 0x0602CFCE RID: 184270 RVA: 0x00626073 File Offset: 0x00624273
		// (set) Token: 0x0602CFCF RID: 184271 RVA: 0x0062607B File Offset: 0x0062427B
		public IBubbleRangeCylinderConfigT TriggerCylinderConfig { get; set; }

		// Token: 0x1700C0EB RID: 49387
		// (get) Token: 0x0602CFD0 RID: 184272 RVA: 0x00626084 File Offset: 0x00624284
		// (set) Token: 0x0602CFD1 RID: 184273 RVA: 0x0062608C File Offset: 0x0062428C
		public bool IsPlayMouthAnim { get; set; }

		// Token: 0x1700C0EC RID: 49388
		// (get) Token: 0x0602CFD2 RID: 184274 RVA: 0x00626095 File Offset: 0x00624295
		// (set) Token: 0x0602CFD3 RID: 184275 RVA: 0x0062609D File Offset: 0x0062429D
		public byte NullMask { get; set; }

		// Token: 0x0602CFD4 RID: 184276 RVA: 0x006260A8 File Offset: 0x006242A8
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
