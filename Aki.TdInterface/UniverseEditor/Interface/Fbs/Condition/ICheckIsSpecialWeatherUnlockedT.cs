using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F69 RID: 20329
	public class ICheckIsSpecialWeatherUnlockedT
	{
		// Token: 0x1700914E RID: 37198
		// (get) Token: 0x0601FA45 RID: 129605 RVA: 0x00466696 File Offset: 0x00464896
		// (set) Token: 0x0601FA46 RID: 129606 RVA: 0x0046669E File Offset: 0x0046489E
		public ECondition Type { get; set; }

		// Token: 0x1700914F RID: 37199
		// (get) Token: 0x0601FA47 RID: 129607 RVA: 0x004666A7 File Offset: 0x004648A7
		// (set) Token: 0x0601FA48 RID: 129608 RVA: 0x004666AF File Offset: 0x004648AF
		public bool IsUnlocked { get; set; }

		// Token: 0x17009150 RID: 37200
		// (get) Token: 0x0601FA49 RID: 129609 RVA: 0x004666B8 File Offset: 0x004648B8
		// (set) Token: 0x0601FA4A RID: 129610 RVA: 0x004666C0 File Offset: 0x004648C0
		public int SpecialWeather { get; set; }

		// Token: 0x0601FA4B RID: 129611 RVA: 0x004666C9 File Offset: 0x004648C9
		public ICheckIsSpecialWeatherUnlockedT()
		{
			this.Type = ECondition.CompareVar;
			this.IsUnlocked = false;
			this.SpecialWeather = 0;
		}
	}
}
