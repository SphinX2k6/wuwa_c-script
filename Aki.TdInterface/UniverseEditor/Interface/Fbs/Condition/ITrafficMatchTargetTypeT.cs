using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D01 RID: 19713
	public class ITrafficMatchTargetTypeT
	{
		// Token: 0x17008F08 RID: 36616
		// (get) Token: 0x0601F4B0 RID: 128176 RVA: 0x0045D8BE File Offset: 0x0045BABE
		// (set) Token: 0x0601F4B1 RID: 128177 RVA: 0x0045D8C6 File Offset: 0x0045BAC6
		public ETrafficMatchTargetType Type { get; set; }

		// Token: 0x0601F4B2 RID: 128178 RVA: 0x0045D8CF File Offset: 0x0045BACF
		public ITrafficMatchTargetTypeT()
		{
			this.Type = ETrafficMatchTargetType.MatchByEntityLogic;
		}
	}
}
