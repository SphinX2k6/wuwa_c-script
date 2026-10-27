using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F26 RID: 20262
	public class IBubbleComponentT
	{
		// Token: 0x170091FC RID: 37372
		// (get) Token: 0x060200E6 RID: 131302 RVA: 0x00475F3E File Offset: 0x0047413E
		// (set) Token: 0x060200E7 RID: 131303 RVA: 0x00475F46 File Offset: 0x00474146
		public bool Disabled { get; set; }

		// Token: 0x170091FD RID: 37373
		// (get) Token: 0x060200E8 RID: 131304 RVA: 0x00475F4F File Offset: 0x0047414F
		// (set) Token: 0x060200E9 RID: 131305 RVA: 0x00475F57 File Offset: 0x00474157
		public List<int> NpcIds { get; set; }

		// Token: 0x170091FE RID: 37374
		// (get) Token: 0x060200EA RID: 131306 RVA: 0x00475F60 File Offset: 0x00474160
		// (set) Token: 0x060200EB RID: 131307 RVA: 0x00475F68 File Offset: 0x00474168
		public float EnterRange { get; set; }

		// Token: 0x170091FF RID: 37375
		// (get) Token: 0x060200EC RID: 131308 RVA: 0x00475F71 File Offset: 0x00474171
		// (set) Token: 0x060200ED RID: 131309 RVA: 0x00475F79 File Offset: 0x00474179
		public float LeaveRange { get; set; }

		// Token: 0x17009200 RID: 37376
		// (get) Token: 0x060200EE RID: 131310 RVA: 0x00475F82 File Offset: 0x00474182
		// (set) Token: 0x060200EF RID: 131311 RVA: 0x00475F8A File Offset: 0x0047418A
		public bool IsRangeFollowEntity { get; set; }

		// Token: 0x17009201 RID: 37377
		// (get) Token: 0x060200F0 RID: 131312 RVA: 0x00475F93 File Offset: 0x00474193
		// (set) Token: 0x060200F1 RID: 131313 RVA: 0x00475F9B File Offset: 0x0047419B
		public List<IConditionBubbleDataT> Flows { get; set; }

		// Token: 0x17009202 RID: 37378
		// (get) Token: 0x060200F2 RID: 131314 RVA: 0x00475FA4 File Offset: 0x004741A4
		// (set) Token: 0x060200F3 RID: 131315 RVA: 0x00475FAC File Offset: 0x004741AC
		public int TimberId { get; set; }

		// Token: 0x17009203 RID: 37379
		// (get) Token: 0x060200F4 RID: 131316 RVA: 0x00475FB5 File Offset: 0x004741B5
		// (set) Token: 0x060200F5 RID: 131317 RVA: 0x00475FBD File Offset: 0x004741BD
		public float Scale { get; set; }

		// Token: 0x17009204 RID: 37380
		// (get) Token: 0x060200F6 RID: 131318 RVA: 0x00475FC6 File Offset: 0x004741C6
		// (set) Token: 0x060200F7 RID: 131319 RVA: 0x00475FCE File Offset: 0x004741CE
		public bool IsAudioOccludedByScene { get; set; }

		// Token: 0x17009205 RID: 37381
		// (get) Token: 0x060200F8 RID: 131320 RVA: 0x00475FD7 File Offset: 0x004741D7
		// (set) Token: 0x060200F9 RID: 131321 RVA: 0x00475FDF File Offset: 0x004741DF
		public IBubbleRangeCylinderConfigT TriggerCylinderConfig { get; set; }

		// Token: 0x17009206 RID: 37382
		// (get) Token: 0x060200FA RID: 131322 RVA: 0x00475FE8 File Offset: 0x004741E8
		// (set) Token: 0x060200FB RID: 131323 RVA: 0x00475FF0 File Offset: 0x004741F0
		public bool IsPlayMouthAnim { get; set; }

		// Token: 0x17009207 RID: 37383
		// (get) Token: 0x060200FC RID: 131324 RVA: 0x00475FF9 File Offset: 0x004741F9
		// (set) Token: 0x060200FD RID: 131325 RVA: 0x00476001 File Offset: 0x00474201
		public byte NullMask { get; set; }

		// Token: 0x060200FE RID: 131326 RVA: 0x0047600C File Offset: 0x0047420C
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
