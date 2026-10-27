using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Module.Advice;

// Token: 0x020016BE RID: 5822
[NullableContext(1)]
[Nullable(0)]
public class AdviceData
{
	// Token: 0x0600A656 RID: 42582 RVA: 0x00253860 File Offset: 0x00251A60
	public void Phrase(PbAdvice data)
	{
		this.AdviceId = new long?(MathUtils.Instance.LongToBigInt(data.Id));
		this.AreaId = data.AreaId;
		this.PhraseUpDownData((long)data.UpVote);
		this.AdviceContentData = new List<AdviceContentData>();
		foreach (PbAdviceContent data2 in data.Contents)
		{
			AdviceContentData adviceContentData = new AdviceContentData();
			adviceContentData.Phrase(data2);
			this.AdviceContentData.Add(adviceContentData);
		}
		this.PhraseContentInfo(this.AdviceContentData);
	}

	// Token: 0x0600A657 RID: 42583 RVA: 0x0025390C File Offset: 0x00251B0C
	public void PhraseData(object adviceContent)
	{
		this.AdviceContentData = new List<AdviceContentData>();
		List<AdviceContentData> list = adviceContent as List<AdviceContentData>;
		if (list != null)
		{
			using (List<AdviceContentData>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					AdviceContentData data = enumerator.Current;
					AdviceContentData adviceContentData = new AdviceContentData();
					adviceContentData.PhraseData(data);
					this.AdviceContentData.Add(adviceContentData);
				}
				goto IL_AE;
			}
		}
		List<PbAdviceContent> list2 = adviceContent as List<PbAdviceContent>;
		if (list2 != null)
		{
			foreach (PbAdviceContent data2 in list2)
			{
				AdviceContentData adviceContentData2 = new AdviceContentData();
				adviceContentData2.PhraseData(data2);
				this.AdviceContentData.Add(adviceContentData2);
			}
		}
		IL_AE:
		this.PhraseContentInfo(this.AdviceContentData);
	}

	// Token: 0x0600A658 RID: 42584 RVA: 0x002539F0 File Offset: 0x00251BF0
	public void PhraseUpDownData(long up)
	{
		this.UpVote = up;
	}

	// Token: 0x0600A659 RID: 42585 RVA: 0x002539FC File Offset: 0x00251BFC
	public void PhraseContentInfo(List<AdviceContentData> adviceContent)
	{
		this.CurrentPackageLanguage = LanguageSystem.Instance.PackageLanguage;
		StringBuilder stringBuilder = new StringBuilder();
		foreach (AdviceContentData adviceContentData in adviceContent)
		{
			PbAdviceContentType? type = adviceContentData.GetType();
			if (type != null)
			{
				switch (type.GetValueOrDefault())
				{
				case PbAdviceContentType.Sentence:
				{
					string[] array = AdviceConfig.Instance.GetAdviceSentenceText(adviceContentData.GetId()).Split("{}", StringSplitOptions.None);
					int num = 0;
					foreach (string value in array)
					{
						stringBuilder.Append(value);
						if (num == 0)
						{
							string adviceWordText = AdviceConfig.Instance.GetAdviceWordText(adviceContentData.GetWord());
							stringBuilder.Append(adviceWordText);
						}
						num++;
					}
					break;
				}
				case PbAdviceContentType.Conjunction:
				{
					string adviceConjunctionText = AdviceConfig.Instance.GetAdviceConjunctionText(adviceContentData.GetId());
					stringBuilder.Append(adviceConjunctionText);
					break;
				}
				case PbAdviceContentType.Expression:
					this.ExpressionId = adviceContentData.GetId();
					break;
				case PbAdviceContentType.Motion:
					this.MotionId = (long)adviceContentData.GetId();
					break;
				}
			}
		}
		this.ShowText = stringBuilder.ToString();
	}

	// Token: 0x0600A65A RID: 42586 RVA: 0x00253B48 File Offset: 0x00251D48
	public void PhraseShowText(List<AdviceContentData> adviceContent, long lineIndex = 0L)
	{
		this.CurrentPackageLanguage = LanguageSystem.Instance.PackageLanguage;
		StringBuilder stringBuilder = new StringBuilder();
		int count = adviceContent.Count;
		for (int i = 0; i < count; i++)
		{
			AdviceContentData adviceContentData = adviceContent[i];
			PbAdviceContentType? type = adviceContentData.GetType();
			PbAdviceContentType? pbAdviceContentType = type;
			PbAdviceContentType pbAdviceContentType2 = PbAdviceContentType.Sentence;
			if (pbAdviceContentType.GetValueOrDefault() == pbAdviceContentType2 & pbAdviceContentType != null)
			{
				string[] array = AdviceConfig.Instance.GetAdviceSentenceText(adviceContentData.GetId()).Split("{}", StringSplitOptions.None);
				int num = array.Length;
				for (int j = 0; j < num; j++)
				{
					stringBuilder.Append(array[j]);
					if (j == 0)
					{
						if (adviceContentData.GetWord() > 0)
						{
							string adviceTemplateText = AdviceConfig.Instance.GetAdviceTemplateText();
							string text = AdviceConfig.Instance.GetAdviceWordText(adviceContentData.GetWord());
							string value = adviceTemplateText.Replace("{0}", text);
							stringBuilder.Append(value);
						}
						else
						{
							string text;
							if (lineIndex == 0L)
							{
								text = AdviceConfig.Instance.GetAdviceCreateText(0);
							}
							else
							{
								text = AdviceConfig.Instance.GetAdviceCreateText(2);
							}
							stringBuilder.Append(text);
						}
					}
				}
			}
			else if (type.GetValueOrDefault() == PbAdviceContentType.Conjunction)
			{
				if (adviceContentData.GetId() > 0)
				{
					string adviceTemplateText2 = AdviceConfig.Instance.GetAdviceTemplateText();
					string text2 = AdviceConfig.Instance.GetAdviceConjunctionText(adviceContentData.GetId());
					string value2 = adviceTemplateText2.Replace("{0}", text2);
					stringBuilder.Append(value2);
				}
				else
				{
					string text2 = AdviceConfig.Instance.GetAdviceCreateText(1);
					stringBuilder.Append(text2);
				}
			}
		}
		this.ShowText = stringBuilder.ToString();
	}

	// Token: 0x0600A65B RID: 42587 RVA: 0x00253CDD File Offset: 0x00251EDD
	public string GetAdviceShowText()
	{
		if (this.CurrentPackageLanguage != LanguageSystem.Instance.PackageLanguage)
		{
			this.PhraseContentInfo(this.AdviceContentData);
		}
		return this.ShowText;
	}

	// Token: 0x0600A65C RID: 42588 RVA: 0x00253D08 File Offset: 0x00251F08
	public long GetAdviceId()
	{
		return MathUtils.Instance.BigIntToLong(this.AdviceId.Value);
	}

	// Token: 0x0600A65D RID: 42589 RVA: 0x00253D1F File Offset: 0x00251F1F
	public long? GetAdviceBigId()
	{
		return this.AdviceId;
	}

	// Token: 0x0600A65E RID: 42590 RVA: 0x00253D27 File Offset: 0x00251F27
	public int GetAreaId()
	{
		return this.AreaId;
	}

	// Token: 0x0600A65F RID: 42591 RVA: 0x00253D30 File Offset: 0x00251F30
	public long GetVote()
	{
		long num = this.UpVote;
		if (num <= 0L)
		{
			num = 0L;
		}
		else
		{
			int adviceLikeShowMax = AdviceConfig.Instance.GetAdviceLikeShowMax();
			if (num >= (long)adviceLikeShowMax)
			{
				num = (long)adviceLikeShowMax;
			}
		}
		return num;
	}

	// Token: 0x0600A660 RID: 42592 RVA: 0x00253D62 File Offset: 0x00251F62
	public List<AdviceContentData> GetAdviceContentData()
	{
		return this.AdviceContentData;
	}

	// Token: 0x0600A661 RID: 42593 RVA: 0x00253D6A File Offset: 0x00251F6A
	public int GetAdviceExpressionId()
	{
		return this.ExpressionId;
	}

	// Token: 0x0600A662 RID: 42594 RVA: 0x00253D72 File Offset: 0x00251F72
	public long GetAdviceMotionId()
	{
		return this.MotionId;
	}

	// Token: 0x04004B0F RID: 19215
	private long? AdviceId;

	// Token: 0x04004B10 RID: 19216
	private int AreaId;

	// Token: 0x04004B11 RID: 19217
	private long UpVote;

	// Token: 0x04004B12 RID: 19218
	private List<AdviceContentData> AdviceContentData = new List<AdviceContentData>();

	// Token: 0x04004B13 RID: 19219
	private int ExpressionId;

	// Token: 0x04004B14 RID: 19220
	private long MotionId;

	// Token: 0x04004B15 RID: 19221
	private string ShowText = "";

	// Token: 0x04004B16 RID: 19222
	private string CurrentPackageLanguage = "";
}
