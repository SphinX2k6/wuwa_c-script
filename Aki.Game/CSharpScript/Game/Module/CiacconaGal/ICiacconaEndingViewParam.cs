using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BF0 RID: 23536
	[NullableContext(1)]
	public interface ICiacconaEndingViewParam
	{
		// Token: 0x17008D6A RID: 36202
		// (get) Token: 0x0603B7C0 RID: 243648
		// (set) Token: 0x0603B7C1 RID: 243649
		CiacconaGalEndingData EndingData { get; set; }

		// Token: 0x17008D6B RID: 36203
		// (get) Token: 0x0603B7C2 RID: 243650
		// (set) Token: 0x0603B7C3 RID: 243651
		[Nullable(2)]
		string LabelTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
