using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043EA RID: 17386
	public class MenuViewData
	{
		// Token: 0x0602BEAB RID: 179883 RVA: 0x00C54530 File Offset: 0x00C52730
		public MenuViewData()
		{
			this.MenuViewDataCurMainType = 0;
			this.MenuViewDataLastSubType = 0;
		}

		// Token: 0x170057F8 RID: 22520
		// (get) Token: 0x0602BEAD RID: 179885 RVA: 0x00C54572 File Offset: 0x00C52772
		// (set) Token: 0x0602BEAC RID: 179884 RVA: 0x00C54559 File Offset: 0x00C52759
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

		// Token: 0x170057F9 RID: 22521
		// (get) Token: 0x0602BEAF RID: 179887 RVA: 0x00C54583 File Offset: 0x00C52783
		// (set) Token: 0x0602BEAE RID: 179886 RVA: 0x00C5457A File Offset: 0x00C5277A
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

		// Token: 0x170057FA RID: 22522
		// (get) Token: 0x0602BEB0 RID: 179888 RVA: 0x00C5458B File Offset: 0x00C5278B
		public int MenuViewDataMainInterval
		{
			get
			{
				return this.MainInterval;
			}
		}

		// Token: 0x170057FB RID: 22523
		// (get) Token: 0x0602BEB1 RID: 179889 RVA: 0x00C54593 File Offset: 0x00C52793
		public int MenuViewDataSubInterval
		{
			get
			{
				return this.SubInterval;
			}
		}

		// Token: 0x04017AA6 RID: 96934
		private readonly int MainInterval = 200;

		// Token: 0x04017AA7 RID: 96935
		private readonly int SubInterval = 100;

		// Token: 0x04017AA8 RID: 96936
		private int CurMainType;

		// Token: 0x04017AA9 RID: 96937
		private int LastSubType;
	}
}
