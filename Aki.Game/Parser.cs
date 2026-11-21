using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020026C8 RID: 9928
[NullableContext(1)]
[Nullable(0)]
public class Parser
{
	// Token: 0x06018E09 RID: 101897 RVA: 0x0078FA28 File Offset: 0x0078DC28
	public Parser(string expression)
	{
		this.Expression = expression;
		this.Tokenize();
	}

	// Token: 0x06018E0A RID: 101898 RVA: 0x0078FA48 File Offset: 0x0078DC48
	public void Tokenize()
	{
		string text = "";
		for (int i = 0; i < this.Expression.Length; i++)
		{
			char c = this.Expression[i];
			if (c != ' ')
			{
				if ("|&!".Contains(c))
				{
					if (text != "")
					{
						this.Tokens.Add(new IToken
						{
							Type = "number",
							Value = text
						});
						text = "";
					}
					if (i + 1 < this.Expression.Length && this.Expression[i + 1] == c)
					{
						List<IToken> tokens = this.Tokens;
						IToken token = new IToken();
						token.Type = "operator";
						char c2 = c;
						ReadOnlySpan<char> str = new ReadOnlySpan<char>(ref c2);
						char c3 = c;
						token.Value = str + new ReadOnlySpan<char>(ref c3);
						tokens.Add(token);
						i++;
					}
					else
					{
						this.Tokens.Add(new IToken
						{
							Type = "operator",
							Value = c.ToString()
						});
					}
				}
				else if ("()".Contains(c))
				{
					if (text != "")
					{
						this.Tokens.Add(new IToken
						{
							Type = "number",
							Value = text
						});
						text = "";
					}
					this.Tokens.Add(new IToken
					{
						Type = "parenthesis",
						Value = c.ToString()
					});
				}
				else
				{
					ReadOnlySpan<char> str2 = text;
					char c3 = c;
					text = str2 + new ReadOnlySpan<char>(ref c3);
				}
			}
		}
		if (text != "")
		{
			this.Tokens.Add(new IToken
			{
				Type = "number",
				Value = text
			});
		}
	}

	// Token: 0x06018E0B RID: 101899 RVA: 0x0078FC12 File Offset: 0x0078DE12
	public ILogicalStructure Parse()
	{
		if (this.Tokens.Count == 0)
		{
			throw new Exception("No tokens to parse");
		}
		ILogicalStructure result = this.ParseExpression();
		if (this.Index != this.Tokens.Count)
		{
			throw new Exception("Unexpected tokens after parsing");
		}
		return result;
	}

	// Token: 0x06018E0C RID: 101900 RVA: 0x0078FC50 File Offset: 0x0078DE50
	private ILogicalStructure ParseExpression()
	{
		return this.ParseOr();
	}

	// Token: 0x06018E0D RID: 101901 RVA: 0x0078FC58 File Offset: 0x0078DE58
	private ILogicalStructure ParseOr()
	{
		ILogicalStructure logicalStructure = this.ParseAnd();
		while (this.Index < this.Tokens.Count && this.Tokens[this.Index].Value == "||")
		{
			this.Index++;
			logicalStructure = new ILogicalStructure
			{
				Or = new ILogicalStructure[]
				{
					logicalStructure,
					this.ParseAnd()
				}
			};
		}
		return logicalStructure;
	}

	// Token: 0x06018E0E RID: 101902 RVA: 0x0078FCD4 File Offset: 0x0078DED4
	private ILogicalStructure ParseAnd()
	{
		ILogicalStructure logicalStructure = this.ParseNot();
		while (this.Index < this.Tokens.Count && this.Tokens[this.Index].Value == "&&")
		{
			this.Index++;
			logicalStructure = new ILogicalStructure
			{
				And = new ILogicalStructure[]
				{
					logicalStructure,
					this.ParseNot()
				}
			};
		}
		return logicalStructure;
	}

	// Token: 0x06018E0F RID: 101903 RVA: 0x0078FD50 File Offset: 0x0078DF50
	private ILogicalStructure ParseNot()
	{
		if (this.Index < this.Tokens.Count && this.Tokens[this.Index].Value == "!")
		{
			this.Index++;
			return new ILogicalStructure
			{
				Not = this.ParseNot()
			};
		}
		return this.ParseFactor();
	}

	// Token: 0x06018E10 RID: 101904 RVA: 0x0078FDB8 File Offset: 0x0078DFB8
	private ILogicalStructure ParseFactor()
	{
		if (this.Index >= this.Tokens.Count)
		{
			throw new Exception("Unexpected end of input");
		}
		if (this.Tokens[this.Index].Value == "(")
		{
			this.Index++;
			ILogicalStructure result = this.ParseExpression();
			if (this.Index >= this.Tokens.Count || this.Tokens[this.Index].Value != ")")
			{
				throw new Exception("Missing closing parenthesis");
			}
			this.Index++;
			return result;
		}
		else
		{
			IToken token = this.Tokens[this.Index];
			if (token.Type == "number")
			{
				this.Index++;
				return new ILogicalStructure
				{
					Index = new int?(int.Parse(token.Value))
				};
			}
			throw new Exception("Unexpected token type");
		}
	}

	// Token: 0x0400D802 RID: 55298
	private readonly List<IToken> Tokens = new List<IToken>();

	// Token: 0x0400D803 RID: 55299
	private int Index;

	// Token: 0x0400D804 RID: 55300
	private readonly string Expression;
}
