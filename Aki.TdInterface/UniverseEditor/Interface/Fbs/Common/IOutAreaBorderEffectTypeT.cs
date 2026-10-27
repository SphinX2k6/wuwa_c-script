using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E19 RID: 24089
	public class IOutAreaBorderEffectTypeT
	{
		// Token: 0x1700B43C RID: 46140
		// (get) Token: 0x060293EC RID: 168940 RVA: 0x005A853E File Offset: 0x005A673E
		// (set) Token: 0x060293ED RID: 168941 RVA: 0x005A8546 File Offset: 0x005A6746
		public EOutAreaBorderEffectType Type { get; set; }

		// Token: 0x060293EE RID: 168942 RVA: 0x005A854F File Offset: 0x005A674F
		public IOutAreaBorderEffectTypeT()
		{
			this.Type = EOutAreaBorderEffectType.BuffId;
		}
	}
}
