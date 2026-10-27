using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056FF RID: 22271
	[NullableContext(1)]
	public interface IKurotatoAttrDisplay
	{
		// Token: 0x17008828 RID: 34856
		// (get) Token: 0x06038A3A RID: 231994
		// (set) Token: 0x06038A3B RID: 231995
		string Icon { get; set; }

		// Token: 0x17008829 RID: 34857
		// (get) Token: 0x06038A3C RID: 231996
		// (set) Token: 0x06038A3D RID: 231997
		string Text { get; set; }

		// Token: 0x1700882A RID: 34858
		// (get) Token: 0x06038A3E RID: 231998
		// (set) Token: 0x06038A3F RID: 231999
		int PropertyId { get; set; }
	}
}
