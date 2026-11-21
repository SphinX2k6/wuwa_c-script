using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A72 RID: 27250
	public class IClientSetSeasonStateConfigT
	{
		// Token: 0x1700C82A RID: 51242
		// (get) Token: 0x0602EC19 RID: 191513 RVA: 0x0065F4E6 File Offset: 0x0065D6E6
		// (set) Token: 0x0602EC1A RID: 191514 RVA: 0x0065F4EE File Offset: 0x0065D6EE
		public EClientSetSeasonStateType Type { get; set; }

		// Token: 0x0602EC1B RID: 191515 RVA: 0x0065F4F7 File Offset: 0x0065D6F7
		public IClientSetSeasonStateConfigT()
		{
			this.Type = EClientSetSeasonStateType.SwitchSeason;
		}
	}
}
