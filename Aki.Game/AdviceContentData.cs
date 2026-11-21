using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000B78 RID: 2936
[NullableContext(1)]
[Nullable(0)]
public class AdviceContentData
{
	// Token: 0x06007A46 RID: 31302 RVA: 0x0025E1F5 File Offset: 0x0025C3F5
	public void Phrase(PbAdviceContent data)
	{
		this.Id = data.Id;
		this.Word = data.Word;
		this.Type = new PbAdviceContentType?(data.Type);
	}

	// Token: 0x06007A47 RID: 31303 RVA: 0x0025E220 File Offset: 0x0025C420
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

	// Token: 0x06007A48 RID: 31304 RVA: 0x0025E28F File Offset: 0x0025C48F
	public void SetData(int id, int word, PbAdviceContentType type)
	{
		this.Id = id;
		this.Word = word;
		this.Type = new PbAdviceContentType?(type);
	}

	// Token: 0x06007A49 RID: 31305 RVA: 0x0025E2AB File Offset: 0x0025C4AB
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06007A4A RID: 31306 RVA: 0x0025E2B3 File Offset: 0x0025C4B3
	public int GetWord()
	{
		return this.Word;
	}

	// Token: 0x06007A4B RID: 31307 RVA: 0x0025E2BB File Offset: 0x0025C4BB
	public new PbAdviceContentType? GetType()
	{
		return this.Type;
	}

	// Token: 0x06007A4C RID: 31308 RVA: 0x0025E2C3 File Offset: 0x0025C4C3
	public PbAdviceContent ConvertToPb()
	{
		return new PbAdviceContent
		{
			Id = this.Id,
			Type = this.Type.Value,
			Word = this.Word
		};
	}

	// Token: 0x04004BC1 RID: 19393
	private int Id;

	// Token: 0x04004BC2 RID: 19394
	private int Word;

	// Token: 0x04004BC3 RID: 19395
	private PbAdviceContentType? Type;
}
