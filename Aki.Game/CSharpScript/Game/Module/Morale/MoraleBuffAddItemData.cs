using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200438A RID: 17290
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffAddItemData : IMoraleBuffAddItemData
	{
		// Token: 0x1700577B RID: 22395
		// (get) Token: 0x0602BADA RID: 178906 RVA: 0x00C429EE File Offset: 0x00C40BEE
		// (set) Token: 0x0602BADB RID: 178907 RVA: 0x00C429F6 File Offset: 0x00C40BF6
		public string IconPath { get; set; } = "";

		// Token: 0x1700577C RID: 22396
		// (get) Token: 0x0602BADC RID: 178908 RVA: 0x00C429FF File Offset: 0x00C40BFF
		// (set) Token: 0x0602BADD RID: 178909 RVA: 0x00C42A07 File Offset: 0x00C40C07
		public string NameKey { get; set; } = "";

		// Token: 0x1700577D RID: 22397
		// (get) Token: 0x0602BADE RID: 178910 RVA: 0x00C42A10 File Offset: 0x00C40C10
		// (set) Token: 0x0602BADF RID: 178911 RVA: 0x00C42A18 File Offset: 0x00C40C18
		public string Value { get; set; } = "";
	}
}
