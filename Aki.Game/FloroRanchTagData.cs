using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;

// Token: 0x02001B03 RID: 6915
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTagData
{
	// Token: 0x0600CD55 RID: 52565 RVA: 0x002ECE3E File Offset: 0x002EB03E
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

	// Token: 0x0600CD56 RID: 52566 RVA: 0x002ECE6E File Offset: 0x002EB06E
	public void SetDynamicParams(int n, int m, int p)
	{
		this.DynamicParams = new TagDynamicParams
		{
			N = n,
			M = m,
			P = p
		};
	}

	// Token: 0x17001118 RID: 4376
	// (get) Token: 0x0600CD57 RID: 52567 RVA: 0x002ECE90 File Offset: 0x002EB090
	public int TagId
	{
		get
		{
			return this.TagIdInternal;
		}
	}

	// Token: 0x17001119 RID: 4377
	// (get) Token: 0x0600CD58 RID: 52568 RVA: 0x002ECE98 File Offset: 0x002EB098
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

	// Token: 0x04005E2B RID: 24107
	private int TagIdInternal;

	// Token: 0x04005E2C RID: 24108
	private FloroRanchTag? TagConfig;

	// Token: 0x04005E2D RID: 24109
	[Nullable(2)]
	private ITagDynamicParams DynamicParams;
}
