using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005711 RID: 22289
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrChangeData : IKurotatoAttrChangeData
	{
		// Token: 0x1700884E RID: 34894
		// (get) Token: 0x06038A8A RID: 232074 RVA: 0x00D7094B File Offset: 0x00D6EB4B
		// (set) Token: 0x06038A8B RID: 232075 RVA: 0x00D70953 File Offset: 0x00D6EB53
		public string Text { get; set; }

		// Token: 0x1700884F RID: 34895
		// (get) Token: 0x06038A8C RID: 232076 RVA: 0x00D7095C File Offset: 0x00D6EB5C
		// (set) Token: 0x06038A8D RID: 232077 RVA: 0x00D70964 File Offset: 0x00D6EB64
		public string IconPath { get; set; }
	}
}
