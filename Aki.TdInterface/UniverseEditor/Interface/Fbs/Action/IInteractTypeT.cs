using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705C RID: 28764
	public class IInteractTypeT
	{
		// Token: 0x1700D2AC RID: 53932
		// (get) Token: 0x06031E03 RID: 204291 RVA: 0x006C05C2 File Offset: 0x006BE7C2
		// (set) Token: 0x06031E04 RID: 204292 RVA: 0x006C05CA File Offset: 0x006BE7CA
		public EInteractOption Type { get; set; }

		// Token: 0x06031E05 RID: 204293 RVA: 0x006C05D3 File Offset: 0x006BE7D3
		public IInteractTypeT()
		{
			this.Type = EInteractOption.Flow;
		}
	}
}
