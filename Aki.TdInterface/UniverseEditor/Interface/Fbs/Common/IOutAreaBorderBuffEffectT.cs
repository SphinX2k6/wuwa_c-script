using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E13 RID: 24083
	public class IOutAreaBorderBuffEffectT
	{
		// Token: 0x1700B435 RID: 46133
		// (get) Token: 0x060293C6 RID: 168902 RVA: 0x005A822B File Offset: 0x005A642B
		// (set) Token: 0x060293C7 RID: 168903 RVA: 0x005A8233 File Offset: 0x005A6433
		public EOutAreaBorderEffectType Type { get; set; }

		// Token: 0x1700B436 RID: 46134
		// (get) Token: 0x060293C8 RID: 168904 RVA: 0x005A823C File Offset: 0x005A643C
		// (set) Token: 0x060293C9 RID: 168905 RVA: 0x005A8244 File Offset: 0x005A6444
		public List<int> BuffIdList { get; set; }

		// Token: 0x060293CA RID: 168906 RVA: 0x005A824D File Offset: 0x005A644D
		public IOutAreaBorderBuffEffectT()
		{
			this.Type = EOutAreaBorderEffectType.BuffId;
			this.BuffIdList = null;
		}
	}
}
