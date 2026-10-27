using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x02005407 RID: 21511
	public class MenuViewData
	{
		// Token: 0x06036F63 RID: 225123 RVA: 0x00D050EC File Offset: 0x00D032EC
		public MenuViewData()
		{
			this.MenuViewDataCurMainType = 0;
			this.MenuViewDataLastSubType = 0;
		}

		// Token: 0x1700842C RID: 33836
		// (get) Token: 0x06036F65 RID: 225125 RVA: 0x00D0512E File Offset: 0x00D0332E
		// (set) Token: 0x06036F64 RID: 225124 RVA: 0x00D05115 File Offset: 0x00D03315
		public int MenuViewDataCurMainType
		{
			get
			{
				return this.CurMainType;
			}
			set
			{
				this.CurMainType = value;
				EventSystem.Instance.Emit(EEventName.OnSelectMenuMainType);
			}
		}

		// Token: 0x1700842D RID: 33837
		// (get) Token: 0x06036F67 RID: 225127 RVA: 0x00D0513F File Offset: 0x00D0333F
		// (set) Token: 0x06036F66 RID: 225126 RVA: 0x00D05136 File Offset: 0x00D03336
		public int MenuViewDataLastSubType
		{
			get
			{
				return this.LastSubType;
			}
			set
			{
				this.LastSubType = value;
			}
		}

		// Token: 0x1700842E RID: 33838
		// (get) Token: 0x06036F68 RID: 225128 RVA: 0x00D05147 File Offset: 0x00D03347
		public int MenuViewDataMainInterval
		{
			get
			{
				return this.MainInterval;
			}
		}

		// Token: 0x1700842F RID: 33839
		// (get) Token: 0x06036F69 RID: 225129 RVA: 0x00D0514F File Offset: 0x00D0334F
		public int MenuViewDataSubInterval
		{
			get
			{
				return this.SubInterval;
			}
		}

		// Token: 0x0401D00D RID: 118797
		private readonly int MainInterval = 200;

		// Token: 0x0401D00E RID: 118798
		private readonly int SubInterval = 100;

		// Token: 0x0401D00F RID: 118799
		private int CurMainType;

		// Token: 0x0401D010 RID: 118800
		private int LastSubType;
	}
}
