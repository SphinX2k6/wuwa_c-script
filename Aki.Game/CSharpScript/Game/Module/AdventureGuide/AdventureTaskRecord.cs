using System;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004E9B RID: 20123
	public class AdventureTaskRecord
	{
		// Token: 0x06032A7C RID: 207484 RVA: 0x00E36702 File Offset: 0x00E34902
		public AdventureTaskRecord(AdventureTask adventureBase, AdventreTaskSate status)
		{
			this.AdventureTaskBase = adventureBase;
			this.Status = status;
		}

		// Token: 0x06032A7D RID: 207485 RVA: 0x00E36718 File Offset: 0x00E34918
		public int GetTotalNum()
		{
			return this.AdventureTaskBase.NeedProgress;
		}

		// Token: 0x0401ADD1 RID: 110033
		public AdventureTask AdventureTaskBase;

		// Token: 0x0401ADD2 RID: 110034
		public AdventreTaskSate Status;

		// Token: 0x0401ADD3 RID: 110035
		public int Progress;
	}
}
