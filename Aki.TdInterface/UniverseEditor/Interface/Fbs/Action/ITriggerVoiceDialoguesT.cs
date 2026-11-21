using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C84 RID: 31876
	public class ITriggerVoiceDialoguesT
	{
		// Token: 0x1700EEA8 RID: 61096
		// (get) Token: 0x060397A7 RID: 235431 RVA: 0x007C246D File Offset: 0x007C066D
		// (set) Token: 0x060397A8 RID: 235432 RVA: 0x007C2475 File Offset: 0x007C0675
		public EInteractEffectType Type { get; set; }

		// Token: 0x1700EEA9 RID: 61097
		// (get) Token: 0x060397A9 RID: 235433 RVA: 0x007C247E File Offset: 0x007C067E
		// (set) Token: 0x060397AA RID: 235434 RVA: 0x007C2486 File Offset: 0x007C0686
		public float DelayTime { get; set; }

		// Token: 0x1700EEAA RID: 61098
		// (get) Token: 0x060397AB RID: 235435 RVA: 0x007C248F File Offset: 0x007C068F
		// (set) Token: 0x060397AC RID: 235436 RVA: 0x007C2497 File Offset: 0x007C0697
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700EEAB RID: 61099
		// (get) Token: 0x060397AD RID: 235437 RVA: 0x007C24A0 File Offset: 0x007C06A0
		// (set) Token: 0x060397AE RID: 235438 RVA: 0x007C24A8 File Offset: 0x007C06A8
		public bool ShowTalker { get; set; }

		// Token: 0x1700EEAC RID: 61100
		// (get) Token: 0x060397AF RID: 235439 RVA: 0x007C24B1 File Offset: 0x007C06B1
		// (set) Token: 0x060397B0 RID: 235440 RVA: 0x007C24B9 File Offset: 0x007C06B9
		public byte NullMask { get; set; }

		// Token: 0x060397B1 RID: 235441 RVA: 0x007C24C2 File Offset: 0x007C06C2
		public ITriggerVoiceDialoguesT()
		{
			this.Type = EInteractEffectType.ModifyTipText;
			this.DelayTime = 0f;
			this.Flow = null;
			this.ShowTalker = false;
			this.NullMask = 0;
		}
	}
}
