using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AF RID: 27055
	public class ICharacterLookAtDataT
	{
		// Token: 0x1700C722 RID: 50978
		// (get) Token: 0x0602E698 RID: 190104 RVA: 0x006557EA File Offset: 0x006539EA
		// (set) Token: 0x0602E699 RID: 190105 RVA: 0x006557F2 File Offset: 0x006539F2
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602E69A RID: 190106 RVA: 0x006557FB File Offset: 0x006539FB
		public ICharacterLookAtDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
