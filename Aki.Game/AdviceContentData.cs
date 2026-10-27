using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020016C0 RID: 5824
[NullableContext(1)]
[Nullable(0)]
public class AdviceContentData
{
	// Token: 0x0600A666 RID: 42598 RVA: 0x00253DE5 File Offset: 0x00251FE5
	public void Phrase(PbAdviceContent data)
	{
		this.Id = data.Id;
		this.Word = data.Word;
		this.Type = new PbAdviceContentType?(data.Type);
	}

	// Token: 0x0600A667 RID: 42599 RVA: 0x00253E10 File Offset: 0x00252010
	public void PhraseData(object data)
	{
		AdviceContentData adviceContentData = data as AdviceContentData;
		if (adviceContentData != null)
		{
			this.Id = adviceContentData.Id;
			this.Word = adviceContentData.Word;
			this.Type = adviceContentData.Type;
			return;
		}
		PbAdviceContent pbAdviceContent = data as PbAdviceContent;
		if (pbAdviceContent != null)
		{
			this.Id = pbAdviceContent.Id;
			this.Word = pbAdviceContent.Word;
			this.Type = new PbAdviceContentType?(pbAdviceContent.Type);
		}
	}

	// Token: 0x0600A668 RID: 42600 RVA: 0x00253E7F File Offset: 0x0025207F
	public void SetData(int id, int word, PbAdviceContentType type)
	{
		this.Id = id;
		this.Word = word;
		this.Type = new PbAdviceContentType?(type);
	}

	// Token: 0x0600A669 RID: 42601 RVA: 0x00253E9B File Offset: 0x0025209B
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x0600A66A RID: 42602 RVA: 0x00253EA3 File Offset: 0x002520A3
	public int GetWord()
	{
		return this.Word;
	}

	// Token: 0x0600A66B RID: 42603 RVA: 0x00253EAB File Offset: 0x002520AB
	public new PbAdviceContentType? GetType()
	{
		return this.Type;
	}

	// Token: 0x0600A66C RID: 42604 RVA: 0x00253EB3 File Offset: 0x002520B3
	public PbAdviceContent ConvertToPb()
	{
		return new PbAdviceContent
		{
			Id = this.Id,
			Type = this.Type.Value,
			Word = this.Word
		};
	}

	// Token: 0x04004B1A RID: 19226
	private int Id;

	// Token: 0x04004B1B RID: 19227
	private int Word;

	// Token: 0x04004B1C RID: 19228
	private PbAdviceContentType? Type;
}
