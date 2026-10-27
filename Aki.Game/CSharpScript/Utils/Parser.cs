using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044FC RID: 17660
	[NullableContext(1)]
	[Nullable(0)]
	public class Parser
	{
		// Token: 0x0602D78A RID: 186250 RVA: 0x00A433CB File Offset: 0x00A415CB
		public Parser(List<IToken> tokens)
		{
			this.Tokens = tokens;
		}

		// Token: 0x0602D78B RID: 186251 RVA: 0x00A433E5 File Offset: 0x00A415E5
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

		// Token: 0x0602D78C RID: 186252 RVA: 0x00A4341A File Offset: 0x00A4161A
		private IAstNode ParseExpression()
		{
			return this.ParseLogicalOr();
		}

		// Token: 0x0602D78D RID: 186253 RVA: 0x00A43424 File Offset: 0x00A41624
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

		// Token: 0x0602D78E RID: 186254 RVA: 0x00A43490 File Offset: 0x00A41690
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

		// Token: 0x0602D78F RID: 186255 RVA: 0x00A434FC File Offset: 0x00A416FC
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

		// Token: 0x0602D790 RID: 186256 RVA: 0x00A43570 File Offset: 0x00A41770
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

		// Token: 0x0602D791 RID: 186257 RVA: 0x00A435F4 File Offset: 0x00A417F4
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

		// Token: 0x0602D792 RID: 186258 RVA: 0x00A43668 File Offset: 0x00A41868
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

		// Token: 0x0602D793 RID: 186259 RVA: 0x00A436E4 File Offset: 0x00A418E4
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

		// Token: 0x0602D794 RID: 186260 RVA: 0x00A43758 File Offset: 0x00A41958
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

		// Token: 0x0602D795 RID: 186261 RVA: 0x00A43910 File Offset: 0x00A41B10
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

		// Token: 0x0602D796 RID: 186262 RVA: 0x00A43980 File Offset: 0x00A41B80
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

		// Token: 0x0602D797 RID: 186263 RVA: 0x00A43A3C File Offset: 0x00A41C3C
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

		// Token: 0x0602D798 RID: 186264 RVA: 0x00A43A70 File Offset: 0x00A41C70
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

		// Token: 0x0602D799 RID: 186265 RVA: 0x00A43AB7 File Offset: 0x00A41CB7
		private void Consume(ETokenType type, string message)
		{
			if (this.Check(type))
			{
				this.Advance();
				return;
			}
			throw new Exception(message);
		}

		// Token: 0x0602D79A RID: 186266 RVA: 0x00A43AD0 File Offset: 0x00A41CD0
		private bool Check(ETokenType type)
		{
			return !this.IsAtEnd() && this.CurrentToken().TokenType == type;
		}

		// Token: 0x0602D79B RID: 186267 RVA: 0x00A43AEA File Offset: 0x00A41CEA
		private IToken Advance()
		{
			if (!this.IsAtEnd())
			{
				this.Position++;
			}
			return this.PreviousToken();
		}

		// Token: 0x0602D79C RID: 186268 RVA: 0x00A43B08 File Offset: 0x00A41D08
		private bool IsAtEnd()
		{
			return this.CurrentToken().TokenType == ETokenType.EndOfInput;
		}

		// Token: 0x0602D79D RID: 186269 RVA: 0x00A43B19 File Offset: 0x00A41D19
		private IToken CurrentToken()
		{
			return this.Tokens[this.Position];
		}

		// Token: 0x0602D79E RID: 186270 RVA: 0x00A43B2C File Offset: 0x00A41D2C
		private IToken PreviousToken()
		{
			return this.Tokens[this.Position - 1];
		}

		// Token: 0x040184EF RID: 99567
		private string Formula = "";

		// Token: 0x040184F0 RID: 99568
		private int Position;

		// Token: 0x040184F1 RID: 99569
		private readonly List<IToken> Tokens;
	}
}
