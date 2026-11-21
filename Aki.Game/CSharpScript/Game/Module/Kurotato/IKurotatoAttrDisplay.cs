using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D6 RID: 18134
	[NullableContext(1)]
	public interface IKurotatoAttrDisplay
	{
		// Token: 0x17005BF0 RID: 23536
		// (get) Token: 0x0602D94A RID: 186698
		// (set) Token: 0x0602D94B RID: 186699
		string Icon { get; set; }

		// Token: 0x17005BF1 RID: 23537
		// (get) Token: 0x0602D94C RID: 186700
		// (set) Token: 0x0602D94D RID: 186701
		string Text { get; set; }

		// Token: 0x17005BF2 RID: 23538
		// (get) Token: 0x0602D94E RID: 186702
		// (set) Token: 0x0602D94F RID: 186703
		int PropertyId { get; set; }
	}
}
