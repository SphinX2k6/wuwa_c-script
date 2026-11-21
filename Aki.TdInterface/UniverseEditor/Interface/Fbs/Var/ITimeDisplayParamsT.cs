using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF3 RID: 16115
	public class ITimeDisplayParamsT
	{
		// Token: 0x17006D17 RID: 27927
		// (get) Token: 0x06015DA6 RID: 89510 RVA: 0x00324926 File Offset: 0x00322B26
		// (set) Token: 0x06015DA7 RID: 89511 RVA: 0x0032492E File Offset: 0x00322B2E
		public ETimeDisplayDataSource Type { get; set; }

		// Token: 0x06015DA8 RID: 89512 RVA: 0x00324937 File Offset: 0x00322B37
		public ITimeDisplayParamsT()
		{
			this.Type = ETimeDisplayDataSource.Constant;
		}
	}
}
