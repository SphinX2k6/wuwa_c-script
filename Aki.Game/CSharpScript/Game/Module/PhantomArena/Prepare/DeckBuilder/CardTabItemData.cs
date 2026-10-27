using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200519C RID: 20892
	[NullableContext(1)]
	[Nullable(0)]
	public class CardTabItemData : ICardTabItemData
	{
		// Token: 0x17008196 RID: 33174
		// (get) Token: 0x0603574A RID: 218954 RVA: 0x00CA7B6F File Offset: 0x00CA5D6F
		// (set) Token: 0x0603574B RID: 218955 RVA: 0x00CA7B77 File Offset: 0x00CA5D77
		public ECardTabType TabType { get; set; }

		// Token: 0x17008197 RID: 33175
		// (get) Token: 0x0603574C RID: 218956 RVA: 0x00CA7B80 File Offset: 0x00CA5D80
		// (set) Token: 0x0603574D RID: 218957 RVA: 0x00CA7B88 File Offset: 0x00CA5D88
		public ECardElement? ElementConfigId { get; set; }

		// Token: 0x17008198 RID: 33176
		// (get) Token: 0x0603574E RID: 218958 RVA: 0x00CA7B91 File Offset: 0x00CA5D91
		// (set) Token: 0x0603574F RID: 218959 RVA: 0x00CA7B99 File Offset: 0x00CA5D99
		public string TabTexturePath { get; set; }

		// Token: 0x17008199 RID: 33177
		// (get) Token: 0x06035750 RID: 218960 RVA: 0x00CA7BA2 File Offset: 0x00CA5DA2
		// (set) Token: 0x06035751 RID: 218961 RVA: 0x00CA7BAA File Offset: 0x00CA5DAA
		public string TabElementColor { get; set; }

		// Token: 0x1700819A RID: 33178
		// (get) Token: 0x06035752 RID: 218962 RVA: 0x00CA7BB3 File Offset: 0x00CA5DB3
		// (set) Token: 0x06035753 RID: 218963 RVA: 0x00CA7BBB File Offset: 0x00CA5DBB
		public bool ShowRedDot { get; set; }

		// Token: 0x1700819B RID: 33179
		// (get) Token: 0x06035754 RID: 218964 RVA: 0x00CA7BC4 File Offset: 0x00CA5DC4
		// (set) Token: 0x06035755 RID: 218965 RVA: 0x00CA7BCC File Offset: 0x00CA5DCC
		public bool IsDisable { get; set; }

		// Token: 0x1700819C RID: 33180
		// (get) Token: 0x06035756 RID: 218966 RVA: 0x00CA7BD5 File Offset: 0x00CA5DD5
		// (set) Token: 0x06035757 RID: 218967 RVA: 0x00CA7BDD File Offset: 0x00CA5DDD
		public bool IsArrivedMax { get; set; }
	}
}
