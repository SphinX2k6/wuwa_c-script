using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A0A RID: 14858
	public class IBlackBoardT
	{
		// Token: 0x170065D1 RID: 26065
		// (get) Token: 0x0601412D RID: 82221 RVA: 0x002F066B File Offset: 0x002EE86B
		// (set) Token: 0x0601412E RID: 82222 RVA: 0x002F0673 File Offset: 0x002EE873
		public EBlackBoardType Type { get; set; }

		// Token: 0x170065D2 RID: 26066
		// (get) Token: 0x0601412F RID: 82223 RVA: 0x002F067C File Offset: 0x002EE87C
		// (set) Token: 0x06014130 RID: 82224 RVA: 0x002F0684 File Offset: 0x002EE884
		public string Key { get; set; }

		// Token: 0x06014131 RID: 82225 RVA: 0x002F068D File Offset: 0x002EE88D
		public IBlackBoardT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
		}
	}
}
