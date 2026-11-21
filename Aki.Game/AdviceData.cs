using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using CSharpScript.Game.Module.Advice;

// Token: 0x02000B76 RID: 2934
[NullableContext(1)]
[Nullable(0)]
public class AdviceData
{
	// Token: 0x06007A36 RID: 31286 RVA: 0x0025DC70 File Offset: 0x0025BE70
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

	// Token: 0x06007A37 RID: 31287 RVA: 0x0025DD1C File Offset: 0x0025BF1C
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

	// Token: 0x06007A38 RID: 31288 RVA: 0x0025DE00 File Offset: 0x0025C000
	public void PhraseUpDownData(long up)
	{
		this.UpVote = up;
	}

	// Token: 0x06007A39 RID: 31289 RVA: 0x0025DE0C File Offset: 0x0025C00C
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

	// Token: 0x06007A3A RID: 31290 RVA: 0x0025DF58 File Offset: 0x0025C158
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

	// Token: 0x06007A3B RID: 31291 RVA: 0x0025E0ED File Offset: 0x0025C2ED
	public string GetAdviceShowText()
	{
		if (this.CurrentPackageLanguage != LanguageSystem.Instance.PackageLanguage)
		{
			this.PhraseContentInfo(this.AdviceContentData);
		}
		return this.ShowText;
	}

	// Token: 0x06007A3C RID: 31292 RVA: 0x0025E118 File Offset: 0x0025C318
	public long GetAdviceId()
	{
		return MathUtils.Instance.BigIntToLong(this.AdviceId.Value);
	}

	// Token: 0x06007A3D RID: 31293 RVA: 0x0025E12F File Offset: 0x0025C32F
	public long? GetAdviceBigId()
	{
		return this.AdviceId;
	}

	// Token: 0x06007A3E RID: 31294 RVA: 0x0025E137 File Offset: 0x0025C337
	public int GetAreaId()
	{
		return this.AreaId;
	}

	// Token: 0x06007A3F RID: 31295 RVA: 0x0025E140 File Offset: 0x0025C340
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

	// Token: 0x06007A40 RID: 31296 RVA: 0x0025E172 File Offset: 0x0025C372
	public List<AdviceContentData> GetAdviceContentData()
	{
		return this.AdviceContentData;
	}

	// Token: 0x06007A41 RID: 31297 RVA: 0x0025E17A File Offset: 0x0025C37A
	public int GetAdviceExpressionId()
	{
		return this.ExpressionId;
	}

	// Token: 0x06007A42 RID: 31298 RVA: 0x0025E182 File Offset: 0x0025C382
	public long GetAdviceMotionId()
	{
		return this.MotionId;
	}

	// Token: 0x04004BB6 RID: 19382
	private long? AdviceId;

	// Token: 0x04004BB7 RID: 19383
	private int AreaId;

	// Token: 0x04004BB8 RID: 19384
	private long UpVote;

	// Token: 0x04004BB9 RID: 19385
	private List<AdviceContentData> AdviceContentData = new List<AdviceContentData>();

	// Token: 0x04004BBA RID: 19386
	private int ExpressionId;

	// Token: 0x04004BBB RID: 19387
	private long MotionId;

	// Token: 0x04004BBC RID: 19388
	private string ShowText = "";

	// Token: 0x04004BBD RID: 19389
	private string CurrentPackageLanguage = "";
}
