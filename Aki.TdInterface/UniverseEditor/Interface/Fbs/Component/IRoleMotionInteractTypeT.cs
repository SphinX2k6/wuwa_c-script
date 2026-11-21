using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E8A RID: 24202
	public class IRoleMotionInteractTypeT
	{
		// Token: 0x1700B29F RID: 45727
		// (get) Token: 0x06028822 RID: 165922 RVA: 0x00589F3E File Offset: 0x0058813E
		// (set) Token: 0x06028823 RID: 165923 RVA: 0x00589F46 File Offset: 0x00588146
		public ERoleMotionInteractType Type { get; set; }

		// Token: 0x06028824 RID: 165924 RVA: 0x00589F4F File Offset: 0x0058814F
		public IRoleMotionInteractTypeT()
		{
			this.Type = ERoleMotionInteractType.PetalGrab;
		}
	}
}
