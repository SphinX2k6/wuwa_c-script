using System;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EB6 RID: 24246
	public class AdventureTaskRecord
	{
		// Token: 0x0603DAEC RID: 252652 RVA: 0x00EE51B6 File Offset: 0x00EE33B6
		public AdventureTaskRecord(AdventureTask adventureBase, AdventreTaskSate status)
		{
			this.AdventureTaskBase = adventureBase;
			this.Status = status;
		}

		// Token: 0x0603DAED RID: 252653 RVA: 0x00EE51CC File Offset: 0x00EE33CC
		public int GetTotalNum()
		{
			return this.AdventureTaskBase.NeedProgress;
		}

		// Token: 0x0402030A RID: 131850
		public AdventureTask AdventureTaskBase;

		// Token: 0x0402030B RID: 131851
		public AdventreTaskSate Status;

		// Token: 0x0402030C RID: 131852
		public int Progress;
	}
}
