using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020016BF RID: 5823
public class LogAdviceData
{
	// Token: 0x0600A664 RID: 42596 RVA: 0x00253DA4 File Offset: 0x00251FA4
	[NullableContext(1)]
	public void Phrase(AdviceContentData source)
	{
		this.id = source.GetId();
		this.word = source.GetWord();
		this.type = source.GetType().Value;
	}

	// Token: 0x04004B17 RID: 19223
	public int id;

	// Token: 0x04004B18 RID: 19224
	public int word;

	// Token: 0x04004B19 RID: 19225
	public PbAdviceContentType type;
}
