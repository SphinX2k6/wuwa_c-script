using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BF1 RID: 23537
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaEndingViewParam : ICiacconaEndingViewParam
	{
		// Token: 0x17008D6C RID: 36204
		// (get) Token: 0x0603B7C4 RID: 243652 RVA: 0x00E2FD6B File Offset: 0x00E2DF6B
		// (set) Token: 0x0603B7C5 RID: 243653 RVA: 0x00E2FD73 File Offset: 0x00E2DF73
		public CiacconaGalEndingData EndingData { get; set; }

		// Token: 0x17008D6D RID: 36205
		// (get) Token: 0x0603B7C6 RID: 243654 RVA: 0x00E2FD7C File Offset: 0x00E2DF7C
		// (set) Token: 0x0603B7C7 RID: 243655 RVA: 0x00E2FD84 File Offset: 0x00E2DF84
		[Nullable(2)]
		public string LabelTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
