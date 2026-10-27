using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200315B RID: 12635
[NullableContext(1)]
[Nullable(0)]
public class Parser
{
	// Token: 0x0601B304 RID: 111364 RVA: 0x0076805C File Offset: 0x0076625C
	public Parser(string expression)
	{
		this.Expression = expression;
		this.Tokenize();
	}

	// Token: 0x0601B305 RID: 111365 RVA: 0x0076807C File Offset: 0x0076627C
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

	// Token: 0x0601B306 RID: 111366 RVA: 0x00768246 File Offset: 0x00766446
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

	// Token: 0x0601B307 RID: 111367 RVA: 0x00768284 File Offset: 0x00766484
	private ILogicalStructure ParseExpression()
	{
		return this.ParseOr();
	}

	// Token: 0x0601B308 RID: 111368 RVA: 0x0076828C File Offset: 0x0076648C
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

	// Token: 0x0601B309 RID: 111369 RVA: 0x00768308 File Offset: 0x00766508
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

	// Token: 0x0601B30A RID: 111370 RVA: 0x00768384 File Offset: 0x00766584
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

	// Token: 0x0601B30B RID: 111371 RVA: 0x007683EC File Offset: 0x007665EC
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

	// Token: 0x0400D39F RID: 54175
	private readonly List<IToken> Tokens = new List<IToken>();

	// Token: 0x0400D3A0 RID: 54176
	private int Index;

	// Token: 0x0400D3A1 RID: 54177
	private readonly string Expression;
}
