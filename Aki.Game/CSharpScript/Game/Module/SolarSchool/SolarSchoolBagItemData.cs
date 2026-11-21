using System;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A4D RID: 23117
	public readonly struct SolarSchoolBagItemData
	{
		// Token: 0x06038F84 RID: 233348 RVA: 0x00FF60AE File Offset: 0x00FF42AE
		public SolarSchoolBagItemData(SolarSchoolItem config, int count)
		{
			this.Config = config;
			this.Count = count;
		}

		// Token: 0x17006C8E RID: 27790
		// (get) Token: 0x06038F85 RID: 233349 RVA: 0x00FF60C0 File Offset: 0x00FF42C0
		public int ItemId
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17006C8F RID: 27791
		// (get) Token: 0x06038F86 RID: 233350 RVA: 0x00FF60DC File Offset: 0x00FF42DC
		public ESolarSchoolItemType ItemType
		{
			get
			{
				return (ESolarSchoolItemType)this.Config.ItemType;
			}
		}

		// Token: 0x0401DFC7 RID: 122823
		public readonly SolarSchoolItem Config;

		// Token: 0x0401DFC8 RID: 122824
		public readonly int Count;
	}
}
