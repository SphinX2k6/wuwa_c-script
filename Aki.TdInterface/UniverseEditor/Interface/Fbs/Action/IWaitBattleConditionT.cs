using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F9 RID: 30201
	public class IWaitBattleConditionT
	{
		// Token: 0x1700E571 RID: 58737
		// (get) Token: 0x06037046 RID: 225350 RVA: 0x00777009 File Offset: 0x00775209
		// (set) Token: 0x06037047 RID: 225351 RVA: 0x00777011 File Offset: 0x00775211
		public IDetectBattleTagT StateOption { get; set; }

		// Token: 0x06037048 RID: 225352 RVA: 0x0077701A File Offset: 0x0077521A
		public IWaitBattleConditionT()
		{
			this.StateOption = null;
		}
	}
}
