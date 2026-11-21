using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D9 RID: 18137
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrPreviewDelta : IKurotatoAttrPreviewDelta
	{
		// Token: 0x17005BF9 RID: 23545
		// (get) Token: 0x0602D95D RID: 186717 RVA: 0x00CBEE1C File Offset: 0x00CBD01C
		// (set) Token: 0x0602D95E RID: 186718 RVA: 0x00CBEE24 File Offset: 0x00CBD024
		public int PropertyId { get; set; }

		// Token: 0x17005BFA RID: 23546
		// (get) Token: 0x0602D95F RID: 186719 RVA: 0x00CBEE2D File Offset: 0x00CBD02D
		// (set) Token: 0x0602D960 RID: 186720 RVA: 0x00CBEE35 File Offset: 0x00CBD035
		public string ValueStr { get; set; }

		// Token: 0x17005BFB RID: 23547
		// (get) Token: 0x0602D961 RID: 186721 RVA: 0x00CBEE3E File Offset: 0x00CBD03E
		// (set) Token: 0x0602D962 RID: 186722 RVA: 0x00CBEE46 File Offset: 0x00CBD046
		public int? LockValue { get; set; }
	}
}
