using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004293 RID: 17043
	public class IWarningPreformFadeInScreenT
	{
		// Token: 0x17007907 RID: 30983
		// (get) Token: 0x06019411 RID: 103441 RVA: 0x003A0B16 File Offset: 0x0039ED16
		// (set) Token: 0x06019412 RID: 103442 RVA: 0x003A0B1E File Offset: 0x0039ED1E
		public EWarningPreformType Type { get; set; }

		// Token: 0x06019413 RID: 103443 RVA: 0x003A0B27 File Offset: 0x0039ED27
		public IWarningPreformFadeInScreenT()
		{
			this.Type = EWarningPreformType.FadeInScreen;
		}
	}
}
