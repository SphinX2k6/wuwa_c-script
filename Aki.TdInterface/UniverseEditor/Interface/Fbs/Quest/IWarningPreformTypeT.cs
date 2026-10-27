using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004296 RID: 17046
	public class IWarningPreformTypeT
	{
		// Token: 0x1700790A RID: 30986
		// (get) Token: 0x06019423 RID: 103459 RVA: 0x003A0C8E File Offset: 0x0039EE8E
		// (set) Token: 0x06019424 RID: 103460 RVA: 0x003A0C96 File Offset: 0x0039EE96
		public EWarningPreformType Type { get; set; }

		// Token: 0x06019425 RID: 103461 RVA: 0x003A0C9F File Offset: 0x0039EE9F
		public IWarningPreformTypeT()
		{
			this.Type = EWarningPreformType.FadeInScreen;
		}
	}
}
