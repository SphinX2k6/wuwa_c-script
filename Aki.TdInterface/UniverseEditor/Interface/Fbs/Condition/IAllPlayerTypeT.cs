using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004968 RID: 18792
	public class IAllPlayerTypeT
	{
		// Token: 0x170087C5 RID: 34757
		// (get) Token: 0x0601D49E RID: 119966 RVA: 0x00421C6E File Offset: 0x0041FE6E
		// (set) Token: 0x0601D49F RID: 119967 RVA: 0x00421C76 File Offset: 0x0041FE76
		public ECheckTargetType Type { get; set; }

		// Token: 0x0601D4A0 RID: 119968 RVA: 0x00421C7F File Offset: 0x0041FE7F
		public IAllPlayerTypeT()
		{
			this.Type = ECheckTargetType.AllPlayer;
		}
	}
}
