using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E1F RID: 24095
	public class IOutAreaBorderTimerConfigT
	{
		// Token: 0x1700B445 RID: 46149
		// (get) Token: 0x06029412 RID: 168978 RVA: 0x005A8A19 File Offset: 0x005A6C19
		// (set) Token: 0x06029413 RID: 168979 RVA: 0x005A8A21 File Offset: 0x005A6C21
		public EOutAreaBorderType Type { get; set; }

		// Token: 0x1700B446 RID: 46150
		// (get) Token: 0x06029414 RID: 168980 RVA: 0x005A8A2A File Offset: 0x005A6C2A
		// (set) Token: 0x06029415 RID: 168981 RVA: 0x005A8A32 File Offset: 0x005A6C32
		public float OutAreaBorderTime { get; set; }

		// Token: 0x1700B447 RID: 46151
		// (get) Token: 0x06029416 RID: 168982 RVA: 0x005A8A3B File Offset: 0x005A6C3B
		// (set) Token: 0x06029417 RID: 168983 RVA: 0x005A8A43 File Offset: 0x005A6C43
		public int TeleportTransitionConfigId { get; set; }

		// Token: 0x1700B448 RID: 46152
		// (get) Token: 0x06029418 RID: 168984 RVA: 0x005A8A4C File Offset: 0x005A6C4C
		// (set) Token: 0x06029419 RID: 168985 RVA: 0x005A8A54 File Offset: 0x005A6C54
		public IOutAreaBorderDownTimeTextTipT OutAreaBorderTipOption { get; set; }

		// Token: 0x1700B449 RID: 46153
		// (get) Token: 0x0602941A RID: 168986 RVA: 0x005A8A5D File Offset: 0x005A6C5D
		// (set) Token: 0x0602941B RID: 168987 RVA: 0x005A8A65 File Offset: 0x005A6C65
		public IOutAreaBorderBuffEffectT OutAreaBorderEffectOption { get; set; }

		// Token: 0x0602941C RID: 168988 RVA: 0x005A8A6E File Offset: 0x005A6C6E
		public IOutAreaBorderTimerConfigT()
		{
			this.Type = EOutAreaBorderType.TeleportTimer;
			this.OutAreaBorderTime = 0f;
			this.TeleportTransitionConfigId = 0;
			this.OutAreaBorderTipOption = null;
			this.OutAreaBorderEffectOption = null;
		}
	}
}
