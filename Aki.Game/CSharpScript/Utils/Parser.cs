using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200341E RID: 13342
	[NullableContext(1)]
	[Nullable(0)]
	public class Parser
	{
		// Token: 0x06021E5A RID: 138842 RVA: 0x0096F1DB File Offset: 0x0096D3DB
		public Parser(List<IToken> tokens)
		{
			this.Tokens = tokens;
		}

		// Token: 0x06021E5B RID: 138843 RVA: 0x0096F1F5 File Offset: 0x0096D3F5
		public IAstNode Parse(string formula)
		{
			this.Formula = formula;
			IAstNode result = this.ParseExpression();
			if (this.Position != this.Tokens.Count - 1)
			{
				throw new Exception("Unexpected token when parsing expression " + formula);
			}
			return result;
		}

		// Token: 0x06021E5C RID: 138844 RVA: 0x0096F22A File Offset: 0x0096D42A
		private IAstNode ParseExpression()
		{
			return this.ParseLogicalOr();
		}

		// Token: 0x06021E5D RID: 138845 RVA: 0x0096F234 File Offset: 0x0096D434
		private IAstNode ParseLogicalOr()
		{
			IAstNode astNode = this.ParseLogicalAnd();
			while (this.MatchOperator(new string[]
			{
				"||"
			}))
			{
				string tokenString = this.PreviousToken().TokenString;
				IAstNode astNode2 = this.ParseLogicalAnd();
				astNode = new BinaryOperatorNode
				{
					NodeType = EAstNodeType.BinaryOperator,
					Operator = tokenString,
					Args = new IAstNode[]
					{
						astNode,
						astNode2
					}
				};
			}
			return astNode;
		}

		// Token: 0x06021E5E RID: 138846 RVA: 0x0096F2A0 File Offset: 0x0096D4A0
		private IAstNode ParseLogicalAnd()
		{
			IAstNode astNode = this.ParseEquality();
			while (this.MatchOperator(new string[]
			{
				"&&"
			}))
			{
				string tokenString = this.PreviousToken().TokenString;
				IAstNode astNode2 = this.ParseEquality();
				astNode = new BinaryOperatorNode
				{
					NodeType = EAstNodeType.BinaryOperator,
					Operator = tokenString,
					Args = new IAstNode[]
					{
						astNode,
						astNode2
					}
				};
			}
			return astNode;
		}

		// Token: 0x06021E5F RID: 138847 RVA: 0x0096F30C File Offset: 0x0096D50C
		private IAstNode ParseEquality()
		{
			IAstNode astNode = this.ParseComparison();
			while (this.MatchOperator(new string[]
			{
				"==",
				"!="
			}))
			{
				string tokenString = this.PreviousToken().TokenString;
				IAstNode astNode2 = this.ParseComparison();
				astNode = new BinaryOperatorNode
				{
					NodeType = EAstNodeType.BinaryOperator,
					Operator = tokenString,
					Args = new IAstNode[]
					{
						astNode,
						astNode2
					}
				};
			}
			return astNode;
		}

		// Token: 0x06021E60 RID: 138848 RVA: 0x0096F380 File Offset: 0x0096D580
		private IAstNode ParseComparison()
		{
			IAstNode astNode = this.ParseAddition();
			while (this.MatchOperator(new string[]
			{
				">",
				">=",
				"<",
				"<="
			}))
			{
				string tokenString = this.PreviousToken().TokenString;
				IAstNode astNode2 = this.ParseAddition();
				astNode = new BinaryOperatorNode
				{
					NodeType = EAstNodeType.BinaryOperator,
					Operator = tokenString,
					Args = new IAstNode[]
					{
						astNode,
						astNode2
					}
				};
			}
			return astNode;
		}

		// Token: 0x06021E61 RID: 138849 RVA: 0x0096F404 File Offset: 0x0096D604
		private IAstNode ParseAddition()
		{
			IAstNode astNode = this.ParseMultiplication();
			while (this.MatchOperator(new string[]
			{
				"+",
				"-"
			}))
			{
				string tokenString = this.PreviousToken().TokenString;
				IAstNode astNode2 = this.ParseMultiplication();
				astNode = new BinaryOperatorNode
				{
					NodeType = EAstNodeType.BinaryOperator,
					Operator = tokenString,
					Args = new IAstNode[]
					{
						astNode,
						astNode2
					}
				};
			}
			return astNode;
		}

		// Token: 0x06021E62 RID: 138850 RVA: 0x0096F478 File Offset: 0x0096D678
		private IAstNode ParseMultiplication()
		{
			IAstNode astNode = this.ParseUnary();
			while (this.MatchOperator(new string[]
			{
				"*",
				"/",
				"%"
			}))
			{
				string tokenString = this.PreviousToken().TokenString;
				IAstNode astNode2 = this.ParseUnary();
				astNode = new BinaryOperatorNode
				{
					NodeType = EAstNodeType.BinaryOperator,
					Operator = tokenString,
					Args = new IAstNode[]
					{
						astNode,
						astNode2
					}
				};
			}
			return astNode;
		}

		// Token: 0x06021E63 RID: 138851 RVA: 0x0096F4F4 File Offset: 0x0096D6F4
		private IAstNode ParseUnary()
		{
			if (this.MatchOperator(new string[]
			{
				"+",
				"-",
				"!"
			}))
			{
				string tokenString = this.PreviousToken().TokenString;
				IAstNode astNode = this.ParseUnary();
				return new UnaryOperatorNode
				{
					NodeType = EAstNodeType.UnaryOperator,
					Operator = tokenString,
					Args = new IAstNode[]
					{
						astNode
					}
				};
			}
			return this.ParsePrimary();
		}

		// Token: 0x06021E64 RID: 138852 RVA: 0x0096F568 File Offset: 0x0096D768
		private IAstNode ParsePrimary()
		{
			IToken token = this.CurrentToken();
			if (token.TokenType == ETokenType.Number)
			{
				this.Advance();
				return new NumberNode
				{
					NodeType = EAstNodeType.Number,
					Value = TFormulaValue.FromDouble(double.Parse(token.TokenString))
				};
			}
			if (token.TokenType == ETokenType.Boolean)
			{
				this.Advance();
				return new BooleanNode
				{
					NodeType = EAstNodeType.Boolean,
					Value = (token.TokenString == "true")
				};
			}
			if (token.TokenType == ETokenType.String)
			{
				this.Advance();
				return new StringNode
				{
					NodeType = EAstNodeType.String,
					Value = token.TokenString
				};
			}
			if (token.TokenType == ETokenType.Identifier)
			{
				string tokenString = token.TokenString;
				this.Advance();
				if (this.Match(new ETokenType[]
				{
					ETokenType.LParen
				}))
				{
					return this.ParseFunctionCall(tokenString);
				}
				IAstNode astNode = new IdentifierNode
				{
					NodeType = EAstNodeType.Identifier,
					Value = tokenString
				};
				while (this.Match(new ETokenType[]
				{
					ETokenType.LBracket
				}))
				{
					IAstNode index = this.ParseExpression();
					this.Consume(ETokenType.RBracket, "Expected ']' after array when parsing expression " + this.Formula);
					astNode = new IndexNode
					{
						NodeType = EAstNodeType.Index,
						Value = astNode,
						Index = index
					};
				}
				return astNode;
			}
			else
			{
				if (this.Match(new ETokenType[]
				{
					ETokenType.LParen
				}))
				{
					IAstNode value = this.ParseExpression();
					this.Consume(ETokenType.RParen, "Expected ')' after expression when parsing " + this.Formula);
					return new ParenthesizedExpressionNode
					{
						NodeType = EAstNodeType.ParenthesizedExpression,
						Value = value
					};
				}
				if (this.Match(new ETokenType[]
				{
					ETokenType.LBracket
				}))
				{
					return this.ParseArray();
				}
				throw new Exception(token.TokenString + " when parsing expression " + this.Formula);
			}
		}

		// Token: 0x06021E65 RID: 138853 RVA: 0x0096F720 File Offset: 0x0096D920
		private IAstNode ParseFunctionCall(string name)
		{
			List<IAstNode> list = new List<IAstNode>();
			if (!this.Check(ETokenType.RParen))
			{
				do
				{
					list.Add(this.ParseExpression());
				}
				while (this.Match(new ETokenType[]
				{
					ETokenType.Comma
				}));
			}
			this.Consume(ETokenType.RParen, "Expected ')' after arguments when parsing expression " + this.Formula);
			return new FunctionCallNode
			{
				NodeType = EAstNodeType.FunctionCall,
				Value = name,
				Args = list.ToArray()
			};
		}

		// Token: 0x06021E66 RID: 138854 RVA: 0x0096F790 File Offset: 0x0096D990
		private IAstNode ParseArray()
		{
			List<IAstNode> list = new List<IAstNode>();
			if (!this.Check(ETokenType.RBracket))
			{
				do
				{
					list.Add(this.ParseExpression());
				}
				while (this.Match(new ETokenType[]
				{
					ETokenType.Comma
				}));
			}
			this.Consume(ETokenType.RBracket, "Expected ']' after array when parsing expression " + this.Formula);
			IAstNode astNode = new ArrayNode
			{
				NodeType = EAstNodeType.Array,
				Value = list.ToArray()
			};
			while (this.Match(new ETokenType[]
			{
				ETokenType.LBracket
			}))
			{
				IAstNode index = this.ParseExpression();
				this.Consume(ETokenType.RBracket, "Expected ']' after array when parsing expression " + this.Formula);
				astNode = new IndexNode
				{
					NodeType = EAstNodeType.Index,
					Value = astNode,
					Index = index
				};
			}
			return astNode;
		}

		// Token: 0x06021E67 RID: 138855 RVA: 0x0096F84C File Offset: 0x0096DA4C
		private bool Match(params ETokenType[] types)
		{
			foreach (ETokenType type in types)
			{
				if (this.Check(type))
				{
					this.Advance();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06021E68 RID: 138856 RVA: 0x0096F880 File Offset: 0x0096DA80
		private bool MatchOperator(params string[] operators)
		{
			foreach (string b in operators)
			{
				if (this.Check(ETokenType.Operator) && this.CurrentToken().TokenString == b)
				{
					this.Advance();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06021E69 RID: 138857 RVA: 0x0096F8C7 File Offset: 0x0096DAC7
		private void Consume(ETokenType type, string message)
		{
			if (this.Check(type))
			{
				this.Advance();
				return;
			}
			throw new Exception(message);
		}

		// Token: 0x06021E6A RID: 138858 RVA: 0x0096F8E0 File Offset: 0x0096DAE0
		private bool Check(ETokenType type)
		{
			return !this.IsAtEnd() && this.CurrentToken().TokenType == type;
		}

		// Token: 0x06021E6B RID: 138859 RVA: 0x0096F8FA File Offset: 0x0096DAFA
		private IToken Advance()
		{
			if (!this.IsAtEnd())
			{
				this.Position++;
			}
			return this.PreviousToken();
		}

		// Token: 0x06021E6C RID: 138860 RVA: 0x0096F918 File Offset: 0x0096DB18
		private bool IsAtEnd()
		{
			return this.CurrentToken().TokenType == ETokenType.EndOfInput;
		}

		// Token: 0x06021E6D RID: 138861 RVA: 0x0096F929 File Offset: 0x0096DB29
		private IToken CurrentToken()
		{
			return this.Tokens[this.Position];
		}

		// Token: 0x06021E6E RID: 138862 RVA: 0x0096F93C File Offset: 0x0096DB3C
		private IToken PreviousToken()
		{
			return this.Tokens[this.Position - 1];
		}

		// Token: 0x04012B17 RID: 76567
		private string Formula = "";

		// Token: 0x04012B18 RID: 76568
		private int Position;

		// Token: 0x04012B19 RID: 76569
		private readonly List<IToken> Tokens;
	}
}
