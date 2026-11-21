using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E1F RID: 19999
	public class IAllPlayerTypeT
	{
		// Token: 0x17008E80 RID: 36480
		// (get) Token: 0x0601EEC3 RID: 126659 RVA: 0x00452122 File Offset: 0x00450322
		// (set) Token: 0x0601EEC4 RID: 126660 RVA: 0x0045212A File Offset: 0x0045032A
		public ECheckTargetType Type { get; set; }

		// Token: 0x0601EEC5 RID: 126661 RVA: 0x00452133 File Offset: 0x00450333
		public IAllPlayerTypeT()
		{
			this.Type = ECheckTargetType.AllPlayer;
		}
	}
}
