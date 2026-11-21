using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005620 RID: 22048
	public class IDragActorPlayKeyPointConfigT
	{
		// Token: 0x17009E47 RID: 40519
		// (get) Token: 0x06023313 RID: 144147 RVA: 0x004D821E File Offset: 0x004D641E
		// (set) Token: 0x06023314 RID: 144148 RVA: 0x004D8226 File Offset: 0x004D6426
		public IVectorInfoT Position { get; set; }

		// Token: 0x17009E48 RID: 40520
		// (get) Token: 0x06023315 RID: 144149 RVA: 0x004D822F File Offset: 0x004D642F
		// (set) Token: 0x06023316 RID: 144150 RVA: 0x004D8237 File Offset: 0x004D6437
		public float Radius { get; set; }

		// Token: 0x17009E49 RID: 40521
		// (get) Token: 0x06023317 RID: 144151 RVA: 0x004D8240 File Offset: 0x004D6440
		// (set) Token: 0x06023318 RID: 144152 RVA: 0x004D8248 File Offset: 0x004D6448
		public bool IsSnapping { get; set; }

		// Token: 0x17009E4A RID: 40522
		// (get) Token: 0x06023319 RID: 144153 RVA: 0x004D8251 File Offset: 0x004D6451
		// (set) Token: 0x0602331A RID: 144154 RVA: 0x004D8259 File Offset: 0x004D6459
		public float SnapTime { get; set; }

		// Token: 0x17009E4B RID: 40523
		// (get) Token: 0x0602331B RID: 144155 RVA: 0x004D8262 File Offset: 0x004D6462
		// (set) Token: 0x0602331C RID: 144156 RVA: 0x004D826A File Offset: 0x004D646A
		public string EnterSendSelfEvent { get; set; }

		// Token: 0x17009E4C RID: 40524
		// (get) Token: 0x0602331D RID: 144157 RVA: 0x004D8273 File Offset: 0x004D6473
		// (set) Token: 0x0602331E RID: 144158 RVA: 0x004D827B File Offset: 0x004D647B
		public string ExitSendSelfEvent { get; set; }

		// Token: 0x17009E4D RID: 40525
		// (get) Token: 0x0602331F RID: 144159 RVA: 0x004D8284 File Offset: 0x004D6484
		// (set) Token: 0x06023320 RID: 144160 RVA: 0x004D828C File Offset: 0x004D648C
		public string ReleaseSendSelfEvent { get; set; }

		// Token: 0x17009E4E RID: 40526
		// (get) Token: 0x06023321 RID: 144161 RVA: 0x004D8295 File Offset: 0x004D6495
		// (set) Token: 0x06023322 RID: 144162 RVA: 0x004D829D File Offset: 0x004D649D
		public List<IActionInfoT> ReleaseClientActions { get; set; }

		// Token: 0x17009E4F RID: 40527
		// (get) Token: 0x06023323 RID: 144163 RVA: 0x004D82A6 File Offset: 0x004D64A6
		// (set) Token: 0x06023324 RID: 144164 RVA: 0x004D82AE File Offset: 0x004D64AE
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009E50 RID: 40528
		// (get) Token: 0x06023325 RID: 144165 RVA: 0x004D82B7 File Offset: 0x004D64B7
		// (set) Token: 0x06023326 RID: 144166 RVA: 0x004D82BF File Offset: 0x004D64BF
		public byte NullMask { get; set; }

		// Token: 0x06023327 RID: 144167 RVA: 0x004D82C8 File Offset: 0x004D64C8
		public IDragActorPlayKeyPointConfigT()
		{
			this.Position = null;
			this.Radius = 0f;
			this.IsSnapping = false;
			this.SnapTime = 0f;
			this.EnterSendSelfEvent = null;
			this.ExitSendSelfEvent = null;
			this.ReleaseSendSelfEvent = null;
			this.ReleaseClientActions = null;
			this.Condition = null;
			this.NullMask = 0;
		}
	}
}
