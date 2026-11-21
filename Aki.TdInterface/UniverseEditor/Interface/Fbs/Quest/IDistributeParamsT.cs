using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004218 RID: 16920
	public class IDistributeParamsT
	{
		// Token: 0x1700733E RID: 29502
		// (get) Token: 0x0601780E RID: 96270 RVA: 0x0035B0D9 File Offset: 0x003592D9
		// (set) Token: 0x0601780F RID: 96271 RVA: 0x0035B0E1 File Offset: 0x003592E1
		public int InformationViewCheck { get; set; }

		// Token: 0x1700733F RID: 29503
		// (get) Token: 0x06017810 RID: 96272 RVA: 0x0035B0EA File Offset: 0x003592EA
		// (set) Token: 0x06017811 RID: 96273 RVA: 0x0035B0F2 File Offset: 0x003592F2
		public IItemConfigT UseItem { get; set; }

		// Token: 0x17007340 RID: 29504
		// (get) Token: 0x06017812 RID: 96274 RVA: 0x0035B0FB File Offset: 0x003592FB
		// (set) Token: 0x06017813 RID: 96275 RVA: 0x0035B103 File Offset: 0x00359303
		public byte NullMask { get; set; }

		// Token: 0x06017814 RID: 96276 RVA: 0x0035B10C File Offset: 0x0035930C
		public IDistributeParamsT()
		{
			this.InformationViewCheck = 0;
			this.UseItem = null;
			this.NullMask = 0;
		}
	}
}
