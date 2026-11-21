using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;

// Token: 0x02000FC2 RID: 4034
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTagData
{
	// Token: 0x0600A166 RID: 41318 RVA: 0x002F7F2A File Offset: 0x002F612A
	public void SetTagId(int tagId)
	{
		if (tagId == this.TagIdInternal)
		{
			return;
		}
		this.TagIdInternal = tagId;
		this.TagConfig = FloroRanchConfig.Instance.GetFloroRanchTagConfig(this.TagIdInternal);
		this.DynamicParams = null;
	}

	// Token: 0x0600A167 RID: 41319 RVA: 0x002F7F5A File Offset: 0x002F615A
	public void SetDynamicParams(int n, int m, int p)
	{
		this.DynamicParams = new TagDynamicParams
		{
			N = n,
			M = m,
			P = p
		};
	}

	// Token: 0x1700113D RID: 4413
	// (get) Token: 0x0600A168 RID: 41320 RVA: 0x002F7F7C File Offset: 0x002F617C
	public int TagId
	{
		get
		{
			return this.TagIdInternal;
		}
	}

	// Token: 0x1700113E RID: 4414
	// (get) Token: 0x0600A169 RID: 41321 RVA: 0x002F7F84 File Offset: 0x002F6184
	public string Desc
	{
		get
		{
			if (this.TagConfig == null)
			{
				return "";
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.TagConfig.Value.Name, null);
			if (string.IsNullOrEmpty(localTextNew))
			{
				return "";
			}
			string input = StringUtils.Format(localTextNew, this.TagConfig.Value.NameParam());
			FloroRanchTag config = this.TagConfig.Value;
			ITagDynamicParams parameters = this.DynamicParams;
			return Regex.Replace(input, "\\{[NnMmPp]\\}", delegate(Match match)
			{
				char c = char.ToUpper(match.Value[1]);
				if (c == 'N')
				{
					if (parameters == null)
					{
						return config.N;
					}
					return parameters.N.ToString();
				}
				else if (c == 'M')
				{
					if (parameters == null)
					{
						return config.M;
					}
					return parameters.M.ToString();
				}
				else
				{
					if (parameters == null)
					{
						return config.P;
					}
					return parameters.P.ToString();
				}
			});
		}
	}

	// Token: 0x04005EFA RID: 24314
	private int TagIdInternal;

	// Token: 0x04005EFB RID: 24315
	private FloroRanchTag? TagConfig;

	// Token: 0x04005EFC RID: 24316
	[Nullable(2)]
	private ITagDynamicParams DynamicParams;
}
