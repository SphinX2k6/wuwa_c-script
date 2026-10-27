using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005702 RID: 22274
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoAttrPreviewDelta : IKurotatoAttrPreviewDelta
	{
		// Token: 0x17008831 RID: 34865
		// (get) Token: 0x06038A4D RID: 232013 RVA: 0x00D70834 File Offset: 0x00D6EA34
		// (set) Token: 0x06038A4E RID: 232014 RVA: 0x00D7083C File Offset: 0x00D6EA3C
		public int PropertyId { get; set; }

		// Token: 0x17008832 RID: 34866
		// (get) Token: 0x06038A4F RID: 232015 RVA: 0x00D70845 File Offset: 0x00D6EA45
		// (set) Token: 0x06038A50 RID: 232016 RVA: 0x00D7084D File Offset: 0x00D6EA4D
		public string ValueStr { get; set; }

		// Token: 0x17008833 RID: 34867
		// (get) Token: 0x06038A51 RID: 232017 RVA: 0x00D70856 File Offset: 0x00D6EA56
		// (set) Token: 0x06038A52 RID: 232018 RVA: 0x00D7085E File Offset: 0x00D6EA5E
		public int? LockValue { get; set; }
	}
}
