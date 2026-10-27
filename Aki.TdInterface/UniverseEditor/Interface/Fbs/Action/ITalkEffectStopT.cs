using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B4 RID: 29364
	public class ITalkEffectStopT
	{
		// Token: 0x1700D9D2 RID: 55762
		// (get) Token: 0x060341BF RID: 213439 RVA: 0x00701055 File Offset: 0x006FF255
		// (set) Token: 0x060341C0 RID: 213440 RVA: 0x0070105D File Offset: 0x006FF25D
		public ETalkEffectActionType Type { get; set; }

		// Token: 0x1700D9D3 RID: 55763
		// (get) Token: 0x060341C1 RID: 213441 RVA: 0x00701066 File Offset: 0x006FF266
		// (set) Token: 0x060341C2 RID: 213442 RVA: 0x0070106E File Offset: 0x006FF26E
		public List<string> EffectKeys { get; set; }

		// Token: 0x1700D9D4 RID: 55764
		// (get) Token: 0x060341C3 RID: 213443 RVA: 0x00701077 File Offset: 0x006FF277
		// (set) Token: 0x060341C4 RID: 213444 RVA: 0x0070107F File Offset: 0x006FF27F
		public float DelayTime { get; set; }

		// Token: 0x1700D9D5 RID: 55765
		// (get) Token: 0x060341C5 RID: 213445 RVA: 0x00701088 File Offset: 0x006FF288
		// (set) Token: 0x060341C6 RID: 213446 RVA: 0x00701090 File Offset: 0x006FF290
		public bool ImmediatelyDestroy { get; set; }

		// Token: 0x1700D9D6 RID: 55766
		// (get) Token: 0x060341C7 RID: 213447 RVA: 0x00701099 File Offset: 0x006FF299
		// (set) Token: 0x060341C8 RID: 213448 RVA: 0x007010A1 File Offset: 0x006FF2A1
		public byte NullMask { get; set; }

		// Token: 0x060341C9 RID: 213449 RVA: 0x007010AA File Offset: 0x006FF2AA
		public ITalkEffectStopT()
		{
			this.Type = ETalkEffectActionType.Play;
			this.EffectKeys = null;
			this.DelayTime = 0f;
			this.ImmediatelyDestroy = false;
			this.NullMask = 0;
		}
	}
}
