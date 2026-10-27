using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA3 RID: 28579
	public class ISetAreaTimeBaseT
	{
		// Token: 0x1700D440 RID: 54336
		// (get) Token: 0x06032827 RID: 206887 RVA: 0x006D1246 File Offset: 0x006CF446
		// (set) Token: 0x06032828 RID: 206888 RVA: 0x006D124E File Offset: 0x006CF44E
		public ESetAreaTime Type { get; set; }

		// Token: 0x06032829 RID: 206889 RVA: 0x006D1257 File Offset: 0x006CF457
		public ISetAreaTimeBaseT()
		{
			this.Type = ESetAreaTime.Lock;
		}
	}
}
