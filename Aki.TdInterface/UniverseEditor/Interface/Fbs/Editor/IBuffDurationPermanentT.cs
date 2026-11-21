using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C9B RID: 19611
	public class IBuffDurationPermanentT
	{
		// Token: 0x17008AEF RID: 35567
		// (get) Token: 0x0601E120 RID: 123168 RVA: 0x00436CB6 File Offset: 0x00434EB6
		// (set) Token: 0x0601E121 RID: 123169 RVA: 0x00436CBE File Offset: 0x00434EBE
		public EBuffDurationType Type { get; set; }

		// Token: 0x0601E122 RID: 123170 RVA: 0x00436CC7 File Offset: 0x00434EC7
		public IBuffDurationPermanentT()
		{
			this.Type = EBuffDurationType.Instant;
		}
	}
}
