using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000B77 RID: 2935
public class LogAdviceData
{
	// Token: 0x06007A44 RID: 31300 RVA: 0x0025E1B4 File Offset: 0x0025C3B4
	[NullableContext(1)]
	public void Phrase(AdviceContentData source)
	{
		this.id = source.GetId();
		this.word = source.GetWord();
		this.type = source.GetType().Value;
	}

	// Token: 0x04004BBE RID: 19390
	public int id;

	// Token: 0x04004BBF RID: 19391
	public int word;

	// Token: 0x04004BC0 RID: 19392
	public PbAdviceContentType type;
}
