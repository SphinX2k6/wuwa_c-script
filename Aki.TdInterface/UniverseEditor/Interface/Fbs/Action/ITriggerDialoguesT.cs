using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C6C RID: 31852
	public class ITriggerDialoguesT
	{
		// Token: 0x1700EE7C RID: 61052
		// (get) Token: 0x060396E3 RID: 235235 RVA: 0x007C0EC3 File Offset: 0x007BF0C3
		// (set) Token: 0x060396E4 RID: 235236 RVA: 0x007C0ECB File Offset: 0x007BF0CB
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700EE7D RID: 61053
		// (get) Token: 0x060396E5 RID: 235237 RVA: 0x007C0ED4 File Offset: 0x007BF0D4
		// (set) Token: 0x060396E6 RID: 235238 RVA: 0x007C0EDC File Offset: 0x007BF0DC
		public float DelayTime { get; set; }

		// Token: 0x1700EE7E RID: 61054
		// (get) Token: 0x060396E7 RID: 235239 RVA: 0x007C0EE5 File Offset: 0x007BF0E5
		// (set) Token: 0x060396E8 RID: 235240 RVA: 0x007C0EED File Offset: 0x007BF0ED
		public List<string> Talks { get; set; }

		// Token: 0x1700EE7F RID: 61055
		// (get) Token: 0x060396E9 RID: 235241 RVA: 0x007C0EF6 File Offset: 0x007BF0F6
		// (set) Token: 0x060396EA RID: 235242 RVA: 0x007C0EFE File Offset: 0x007BF0FE
		public IFocusObjectT FocusObject { get; set; }

		// Token: 0x1700EE80 RID: 61056
		// (get) Token: 0x060396EB RID: 235243 RVA: 0x007C0F07 File Offset: 0x007BF107
		// (set) Token: 0x060396EC RID: 235244 RVA: 0x007C0F0F File Offset: 0x007BF10F
		public byte NullMask { get; set; }

		// Token: 0x060396ED RID: 235245 RVA: 0x007C0F18 File Offset: 0x007BF118
		public ITriggerDialoguesT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.Talks = null;
			this.FocusObject = null;
			this.NullMask = 0;
		}
	}
}
