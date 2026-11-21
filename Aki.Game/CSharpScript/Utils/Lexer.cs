using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Utils
{
	// Token: 0x02003411 RID: 13329
	[NullableContext(1)]
	[Nullable(0)]
	public class Lexer
	{
		// Token: 0x06021E24 RID: 138788 RVA: 0x0096EBB3 File Offset: 0x0096CDB3
		public Lexer(string inputString)
		{
			this.InputString = inputString;
		}

		// Token: 0x06021E25 RID: 138789 RVA: 0x0096EBC4 File Offset: 0x0096CDC4
		public List<IToken> Tokenize()
		{
			List<IToken> list = new List<IToken>();
			while (this.Position < this.InputString.Length)
			{
				char c = this.InputString[this.Position];
				if (Regex.IsMatch(c.ToString(), "\\d"))
				{
					list.Add(this.ReadNumber());
				}
				else if (Regex.IsMatch(c.ToString(), "[a-zA-Z]"))
				{
					list.Add(this.ReadIdentifier());
				}
				else if (Regex.IsMatch(c.ToString(), "['`\"]"))
				{
					list.Add(this.ReadString());
				}
				else if (Regex.IsMatch(c.ToString(), "[\\+\\-\\*\\/\\%\\>\\<\\=\\!\\&\\|]"))
				{
					list.Add(this.ReadOperator());
				}
				else if (c == ',')
				{
					list.Add(new Token
					{
						TokenType = ETokenType.Comma,
						TokenString = ","
					});
					this.Position++;
				}
				else if (c == '(')
				{
					list.Add(new Token
					{
						TokenType = ETokenType.LParen,
						TokenString = "("
					});
					this.Position++;
				}
				else if (c == ')')
				{
					list.Add(new Token
					{
						TokenType = ETokenType.RParen,
						TokenString = ")"
					});
					this.Position++;
				}
				else if (c == '[')
				{
					list.Add(new Token
					{
						TokenType = ETokenType.LBracket,
						TokenString = "["
					});
					this.Position++;
				}
				else if (c == ']')
				{
					list.Add(new Token
					{
						TokenType = ETokenType.RBracket,
						TokenString = "]"
					});
					this.Position++;
				}
				else
				{
					if (!Regex.IsMatch(c.ToString(), "\\s"))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Invalid character: ");
						defaultInterpolatedStringHandler.AppendFormatted<char>(c);
						throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					this.Position++;
				}
			}
			list.Add(new Token
			{
				TokenType = ETokenType.EndOfInput,
				TokenString = ""
			});
			return list;
		}

		// Token: 0x06021E26 RID: 138790 RVA: 0x0096EE08 File Offset: 0x0096D008
		private IToken ReadNumber()
		{
			string text = "";
			while (this.Position < this.InputString.Length)
			{
				char c = this.InputString[this.Position];
				if (!Regex.IsMatch(c.ToString(), "\\d"))
				{
					break;
				}
				ReadOnlySpan<char> str = text;
				c = this.InputString[this.Position];
				text = str + new ReadOnlySpan<char>(ref c);
				this.Position++;
			}
			if (this.Position < this.InputString.Length && this.InputString[this.Position] == '.')
			{
				text += ".";
				this.Position++;
				while (this.Position < this.InputString.Length)
				{
					char c = this.InputString[this.Position];
					if (!Regex.IsMatch(c.ToString(), "\\d"))
					{
						break;
					}
					ReadOnlySpan<char> str2 = text;
					c = this.InputString[this.Position];
					text = str2 + new ReadOnlySpan<char>(ref c);
					this.Position++;
				}
			}
			return new Token
			{
				TokenType = ETokenType.Number,
				TokenString = text
			};
		}

		// Token: 0x06021E27 RID: 138791 RVA: 0x0096EF50 File Offset: 0x0096D150
		private IToken ReadIdentifier()
		{
			string text = "";
			while (this.Position < this.InputString.Length)
			{
				char c = this.InputString[this.Position];
				if (!Regex.IsMatch(c.ToString(), "[a-zA-Z0-9]"))
				{
					break;
				}
				ReadOnlySpan<char> str = text;
				string inputString = this.InputString;
				int position = this.Position;
				this.Position = position + 1;
				c = inputString[position];
				text = str + new ReadOnlySpan<char>(ref c);
			}
			if (text == "TRUE" || text == "FALSE")
			{
				return new Token
				{
					TokenType = ETokenType.Boolean,
					TokenString = text.ToLower()
				};
			}
			if (text == "AND")
			{
				return new Token
				{
					TokenType = ETokenType.Operator,
					TokenString = "&&"
				};
			}
			if (text == "OR")
			{
				return new Token
				{
					TokenType = ETokenType.Operator,
					TokenString = "||"
				};
			}
			if (text == "XOR")
			{
				return new Token
				{
					TokenType = ETokenType.Operator,
					TokenString = "!="
				};
			}
			if (text == "NOT")
			{
				return new Token
				{
					TokenType = ETokenType.Operator,
					TokenString = "!"
				};
			}
			return new Token
			{
				TokenType = ETokenType.Identifier,
				TokenString = text
			};
		}

		// Token: 0x06021E28 RID: 138792 RVA: 0x0096F0A8 File Offset: 0x0096D2A8
		private IToken ReadString()
		{
			string inputString = this.InputString;
			int position = this.Position;
			this.Position = position + 1;
			char c = inputString[position];
			string text = "";
			while (this.Position < this.InputString.Length)
			{
				string inputString2 = this.InputString;
				position = this.Position;
				this.Position = position + 1;
				char c2 = inputString2[position];
				if (c2 == c)
				{
					return new Token
					{
						TokenType = ETokenType.String,
						TokenString = text
					};
				}
				ReadOnlySpan<char> str = text;
				char c3 = c2;
				text = str + new ReadOnlySpan<char>(ref c3);
			}
			throw new Exception("Invalid string: " + text);
		}

		// Token: 0x06021E29 RID: 138793 RVA: 0x0096F148 File Offset: 0x0096D348
		private IToken ReadOperator()
		{
			string text = "";
			while (this.Position < this.InputString.Length)
			{
				char c = this.InputString[this.Position];
				if (!Regex.IsMatch(c.ToString(), "[\\+\\-\\*\\/\\%\\>\\<\\=\\!\\&\\|]"))
				{
					break;
				}
				ReadOnlySpan<char> str = text;
				c = this.InputString[this.Position];
				text = str + new ReadOnlySpan<char>(ref c);
				this.Position++;
			}
			return new Token
			{
				TokenType = ETokenType.Operator,
				TokenString = text
			};
		}

		// Token: 0x04012B0A RID: 76554
		private int Position;

		// Token: 0x04012B0B RID: 76555
		private readonly string InputString;
	}
}
