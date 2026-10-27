using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005519 RID: 21785
	public class ILookAtTargetPlayerT
	{
		// Token: 0x1700A0D3 RID: 41171
		// (get) Token: 0x06023FB9 RID: 147385 RVA: 0x004F912A File Offset: 0x004F732A
		// (set) Token: 0x06023FBA RID: 147386 RVA: 0x004F9132 File Offset: 0x004F7332
		public ELookAtTargetType Type { get; set; }

		// Token: 0x06023FBB RID: 147387 RVA: 0x004F913B File Offset: 0x004F733B
		public ILookAtTargetPlayerT()
		{
			this.Type = ELookAtTargetType.Entity;
		}
	}
}
