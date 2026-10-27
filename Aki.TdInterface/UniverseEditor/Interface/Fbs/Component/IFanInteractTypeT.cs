using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005238 RID: 21048
	public class IFanInteractTypeT
	{
		// Token: 0x17009A38 RID: 39480
		// (get) Token: 0x060223C5 RID: 140229 RVA: 0x004BFB5E File Offset: 0x004BDD5E
		// (set) Token: 0x060223C6 RID: 140230 RVA: 0x004BFB66 File Offset: 0x004BDD66
		public EFanInteractType Type { get; set; }

		// Token: 0x060223C7 RID: 140231 RVA: 0x004BFB6F File Offset: 0x004BDD6F
		public IFanInteractTypeT()
		{
			this.Type = EFanInteractType.Hit;
		}
	}
}
