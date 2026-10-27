using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004512 RID: 17682
	[NullableContext(1)]
	[Nullable(0)]
	public class ExpressionTree : IStaticVariableResetter
	{
		// Token: 0x0602D81D RID: 186397 RVA: 0x00A44F52 File Offset: 0x00A43152
		static ExpressionTree()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ExpressionTree.CreateStaticDefaultValue), new Action(ExpressionTree.ResetStaticDefaultValue));
		}

		// Token: 0x0602D81E RID: 186398 RVA: 0x00A44F74 File Offset: 0x00A43174
		public static void CreateStaticDefaultValue()
		{
			Dictionary<string, ENodeType> dictionary = new Dictionary<string, ENodeType>();
			dictionary["OR"] = ENodeType.OR;
			dictionary["AND"] = ENodeType.AND;
			dictionary["NOT"] = ENodeType.NOT;
			dictionary["SequenceTrue"] = ENodeType.SequenceTrue;
			ExpressionTree.OperatorMap = dictionary;
			Dictionary<string, ENodeType> dictionary2 = new Dictionary<string, ENodeType>();
			dictionary2["=="] = ENodeType.Equal;
			dictionary2["!="] = ENodeType.NotEqual;
			dictionary2["<="] = ENodeType.LessEqual;
			dictionary2["<"] = ENodeType.Less;
			dictionary2[">="] = ENodeType.GreaterEqual;
			dictionary2[">"] = ENodeType.Greater;
			ExpressionTree.RelationOperatorMap = dictionary2;
		}

		// Token: 0x0602D81F RID: 186399 RVA: 0x00A4500E File Offset: 0x00A4320E
		public static void ResetStaticDefaultValue()
		{
			ExpressionTree.OperatorMap = null;
			ExpressionTree.RelationOperatorMap = null;
		}

		// Token: 0x0602D820 RID: 186400 RVA: 0x00A4501C File Offset: 0x00A4321C
		public void ResetData()
		{
			this.Formula = string.Empty;
			this.CustomVariable = null;
			this.Position = 0;
			this.Reason = string.Empty;
			this.LogInfo.Clear();
			this.Context = null;
			this.RootNode = null;
			this.IsRunning = false;
		}

		// Token: 0x0602D821 RID: 186401 RVA: 0x00A45070 File Offset: 0x00A43270
		public unsafe bool Parse(string reason, string formula, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> customVariableStr)
		{
			this.ResetData();
			this.Formula = formula;
			this.Reason = reason;
			if (customVariableStr != null)
			{
				this.CustomVariable = CustomVariable.Create(customVariableStr, reason);
			}
			bool result = true;
			try
			{
				this.RootNode = this.ParseStatement();
				this.PassEmpty();
				if (!this.IsEnd)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral("有未解析的字符,position");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.Position);
					throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			catch (Exception ex)
			{
				result = false;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "解析表达式异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("formula", this.Formula);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return result;
		}

		// Token: 0x0602D822 RID: 186402 RVA: 0x00A45164 File Offset: 0x00A43364
		[NullableContext(2)]
		private INode ParseStatement()
		{
			this.PassEmpty();
			if (this.IsEnd)
			{
				return null;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			if (this.Formula[this.Position] != '(')
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
				defaultInterpolatedStringHandler.AppendLiteral("解析表达式格式错误:位置");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Position);
				defaultInterpolatedStringHandler.AppendLiteral("期望一个(");
				this.ThrowError(defaultInterpolatedStringHandler.ToStringAndClear());
				return null;
			}
			this.Position++;
			INode result = this.ParseArguments();
			this.PassEmpty();
			if (!this.IsEnd && this.Formula[this.Position] == ')')
			{
				this.Position++;
				return result;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
			defaultInterpolatedStringHandler.AppendLiteral("解析表达式格式错误:位置");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Position);
			defaultInterpolatedStringHandler.AppendLiteral("期望一个)");
			this.ThrowError(defaultInterpolatedStringHandler.ToStringAndClear());
			return null;
		}

		// Token: 0x0602D823 RID: 186403 RVA: 0x00A45260 File Offset: 0x00A43460
		[NullableContext(2)]
		private INode ParseArguments()
		{
			List<INode> list = new List<INode>();
			INode node = null;
			while (!this.IsEnd)
			{
				this.PassEmpty();
				if (this.IsEnd)
				{
					break;
				}
				char c = this.Formula[this.Position];
				bool flag = false;
				INode node2;
				if (char.IsDigit(c))
				{
					node2 = this.ParseNumber();
				}
				else if (char.IsLetter(c))
				{
					node2 = this.ParseIdentifier();
				}
				else if (this.IsRelationOperatorStart(c))
				{
					node2 = this.ParseRelationOperator();
				}
				else
				{
					if (c != '(')
					{
						break;
					}
					node2 = this.ParseStatement();
					flag = true;
				}
				if (node2 == null)
				{
					break;
				}
				if (!flag && node2.NodeType <= ENodeType.FunctionCall)
				{
					if (node != null)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
						defaultInterpolatedStringHandler.AppendLiteral("解析表达式格式错误:括号内有多个操作符 ");
						defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(node.Value);
						defaultInterpolatedStringHandler.AppendLiteral(" 和 ");
						defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(node2.Value);
						this.ThrowError(defaultInterpolatedStringHandler.ToStringAndClear());
					}
					node = node2;
				}
				else
				{
					list.Add(node2);
				}
			}
			if (node == null)
			{
				this.ThrowError("解析表达式格式错误:括号内没有操作符");
				return null;
			}
			node.Children = list;
			return node;
		}

		// Token: 0x0602D824 RID: 186404 RVA: 0x00A45370 File Offset: 0x00A43570
		private INode ParseNumber()
		{
			int position = this.Position;
			while (this.Position < this.Formula.Length && char.IsDigit(this.Formula[this.Position]))
			{
				this.Position++;
			}
			if (this.Position < this.Formula.Length && this.Formula[this.Position] == '.')
			{
				this.Position++;
				while (this.Position < this.Formula.Length && char.IsDigit(this.Formula[this.Position]))
				{
					this.Position++;
				}
			}
			double value = double.Parse(this.Formula.Substring(position, this.Position - position));
			return new Node
			{
				NodeType = ENodeType.Number,
				Value = TFormulaValue.FromDouble(value)
			};
		}

		// Token: 0x0602D825 RID: 186405 RVA: 0x00A45464 File Offset: 0x00A43664
		private INode ParseRelationOperator()
		{
			int length = Math.Min(2, this.Formula.Length - this.Position);
			string text = this.Formula.Substring(this.Position, length);
			string text2 = (ExpressionTree.RelationOperatorMap != null && ExpressionTree.RelationOperatorMap.ContainsKey(text)) ? text : this.Formula[this.Position].ToString();
			ENodeType nodeType;
			if (ExpressionTree.RelationOperatorMap == null || !ExpressionTree.RelationOperatorMap.TryGetValue(text2, out nodeType))
			{
				this.ThrowError("解析表达式格式错误:关系操作符不合法" + text2);
				nodeType = ENodeType.Equal;
			}
			this.Position += text2.Length;
			return new Node
			{
				NodeType = nodeType,
				Value = text2
			};
		}

		// Token: 0x0602D826 RID: 186406 RVA: 0x00A45524 File Offset: 0x00A43724
		private INode ParseIdentifier()
		{
			int position = this.Position;
			while (this.Position < this.Formula.Length && char.IsLetterOrDigit(this.Formula[this.Position]))
			{
				this.Position++;
			}
			string text = this.Formula.Substring(position, this.Position - position);
			ENodeType nodeType;
			INode node;
			if (ExpressionTree.OperatorMap != null && ExpressionTree.OperatorMap.TryGetValue(text, out nodeType))
			{
				node = new Node
				{
					NodeType = nodeType,
					Name = text
				};
			}
			else if (ExpressionTreeModel.Instance.GetBuiltinFunc(text) != null)
			{
				node = new Node
				{
					NodeType = ENodeType.FunctionCall,
					Name = text
				};
			}
			else
			{
				node = new Node
				{
					NodeType = ENodeType.Variable,
					Name = text
				};
			}
			if (this.Position < this.Formula.Length && this.Formula[this.Position] == '.')
			{
				this.Position++;
				List<INode> children = new List<INode>
				{
					node
				};
				node = this.ParseIdentifier();
				if (node.NodeType != ENodeType.FunctionCall)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
					defaultInterpolatedStringHandler.AppendLiteral("解析表达式格式错误:.号操作符后接符号不合法");
					defaultInterpolatedStringHandler.AppendFormatted(node.Name);
					defaultInterpolatedStringHandler.AppendLiteral("节点类型");
					defaultInterpolatedStringHandler.AppendFormatted<ENodeType>(node.NodeType);
					this.ThrowError(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				node.NodeType = ENodeType.MemberAccess;
				node.Children = children;
			}
			return node;
		}

		// Token: 0x0602D827 RID: 186407 RVA: 0x00A456A2 File Offset: 0x00A438A2
		private bool IsRelationOperatorStart(char ch)
		{
			return ch == '=' || ch == '!' || ch == '<' || ch == '>';
		}

		// Token: 0x170073EF RID: 29679
		// (get) Token: 0x0602D828 RID: 186408 RVA: 0x00A456BA File Offset: 0x00A438BA
		private bool IsEnd
		{
			get
			{
				return this.Position >= this.Formula.Length;
			}
		}

		// Token: 0x0602D829 RID: 186409 RVA: 0x00A456D4 File Offset: 0x00A438D4
		private void PassEmpty()
		{
			while (this.Position < this.Formula.Length)
			{
				char c = this.Formula[this.Position];
				if (!char.IsWhiteSpace(c) && c != ',')
				{
					break;
				}
				this.Position++;
			}
		}

		// Token: 0x0602D82A RID: 186410 RVA: 0x00A45723 File Offset: 0x00A43923
		private void ThrowError(string errorInfo)
		{
			throw new Exception(errorInfo);
		}

		// Token: 0x0602D82B RID: 186411 RVA: 0x00A4572C File Offset: 0x00A4392C
		private TFormulaValue EvaluateNode(INode node)
		{
			TFormulaValue tformulaValue;
			switch (node.NodeType)
			{
			case ENodeType.OR:
				if (node.Children != null)
				{
					foreach (INode node2 in node.Children)
					{
						if (ExpressionTree.ToBool(this.EvaluateNode(node2)))
						{
							return TFormulaValue.FromBool(true);
						}
					}
				}
				return TFormulaValue.FromBool(false);
			case ENodeType.AND:
				if (node.Children != null)
				{
					foreach (INode node3 in node.Children)
					{
						if (!ExpressionTree.ToBool(this.EvaluateNode(node3)))
						{
							return TFormulaValue.FromBool(false);
						}
					}
				}
				return TFormulaValue.FromBool(true);
			case ENodeType.NOT:
				if (node.Children == null || node.Children.Count == 0)
				{
					return TFormulaValue.FromBool(false);
				}
				return TFormulaValue.FromBool(!ExpressionTree.ToBool(this.EvaluateNode(node.Children[0])));
			case ENodeType.SequenceTrue:
				if (node.Children != null)
				{
					foreach (INode node4 in node.Children)
					{
						this.EvaluateNode(node4);
					}
				}
				return TFormulaValue.FromBool(true);
			case ENodeType.Equal:
			case ENodeType.NotEqual:
			case ENodeType.LessEqual:
			case ENodeType.Less:
			case ENodeType.GreaterEqual:
			case ENodeType.Greater:
				return this.EvaluateRelationNode(node);
			case ENodeType.FunctionCall:
			case ENodeType.MemberAccess:
			{
				List<TFormulaValue> list = new List<TFormulaValue>();
				if (node.Children != null)
				{
					foreach (INode node5 in node.Children)
					{
						list.Add(this.EvaluateNode(node5));
					}
				}
				string name = node.Name;
				Func<IExpressionContext, TFormulaValue[], TFormulaValue> builtinFunc = ExpressionTreeModel.Instance.GetBuiltinFunc(name);
				TFormulaValue result = default(TFormulaValue);
				if (builtinFunc != null)
				{
					result = builtinFunc(this.Context, list.ToArray());
				}
				return result;
			}
			case ENodeType.Variable:
			{
				string name2 = node.Name;
				CustomVariable customVariable = this.CustomVariable;
				TFormulaValue tformulaValue2;
				if (customVariable == null)
				{
					tformulaValue = default(TFormulaValue);
					tformulaValue2 = tformulaValue;
				}
				else
				{
					tformulaValue2 = customVariable.GetVariable(name2);
				}
				TFormulaValue result2 = tformulaValue2;
				if (result2.IsNull && this.ExtraParams != null)
				{
					this.ExtraParams.TryGetValue(name2, out result2);
				}
				return result2;
			}
			case ENodeType.Bool:
			case ENodeType.String:
			case ENodeType.Number:
				return node.Value;
			default:
				return default(TFormulaValue);
			}
			return tformulaValue;
		}

		// Token: 0x0602D82C RID: 186412 RVA: 0x00A459E4 File Offset: 0x00A43BE4
		private TFormulaValue EvaluateRelationNode(INode node)
		{
			TFormulaValue left = this.EvaluateNode(node.Children[0]);
			TFormulaValue right = this.EvaluateNode(node.Children[1]);
			switch (node.NodeType)
			{
			case ENodeType.Equal:
				return TFormulaValue.FromBool(left == right);
			case ENodeType.NotEqual:
				return TFormulaValue.FromBool(left != right);
			case ENodeType.LessEqual:
				return TFormulaValue.FromBool(left <= right);
			case ENodeType.Less:
				return TFormulaValue.FromBool(left < right);
			case ENodeType.GreaterEqual:
				return TFormulaValue.FromBool(left >= right);
			case ENodeType.Greater:
				return TFormulaValue.FromBool(left > right);
			default:
				return TFormulaValue.FromBool(false);
			}
		}

		// Token: 0x0602D82D RID: 186413 RVA: 0x00A45A94 File Offset: 0x00A43C94
		public unsafe TFormulaValue Evaluate(IExpressionContext context, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<string, TFormulaValue> args = null)
		{
			TFormulaValue result = default(TFormulaValue);
			if (this.RootNode == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "解析表达式节点为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("formula", this.Formula);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", this.Reason);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return result;
			}
			if (this.IsRunning)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.TZQ;
				string message2 = "解析表达式重复进入";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("formula", this.Formula);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("reason", this.Reason);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return result;
			}
			this.Context = context;
			this.ExtraParams = args;
			this.IsRunning = true;
			try
			{
				result = this.EvaluateNode(this.RootNode);
			}
			catch (Exception ex)
			{
				result = default(TFormulaValue);
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Event;
				ELogAuthor author3 = ELogAuthor.TZQ;
				string message3 = "解析表达式异常";
				Exception error = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("formula", this.Formula);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("reason", this.Reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("error", ex.Message);
				instance3.ErrorWithStack(module3, author3, message3, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			}
			finally
			{
				this.Context = null;
				this.ExtraParams = null;
				this.IsRunning = false;
			}
			return result;
		}

		// Token: 0x0602D82E RID: 186414 RVA: 0x00A45C5C File Offset: 0x00A43E5C
		[Conditional("DEBUG")]
		private void PrintRunTimeLogInfo()
		{
		}

		// Token: 0x0602D82F RID: 186415 RVA: 0x00A45C5E File Offset: 0x00A43E5E
		[Conditional("DEBUG")]
		private void AddRunTimeLogInfo(string info)
		{
		}

		// Token: 0x0602D830 RID: 186416 RVA: 0x00A45C60 File Offset: 0x00A43E60
		private static bool ToBool(TFormulaValue value)
		{
			bool result;
			if (value.TryGetBool(out result))
			{
				return result;
			}
			double value2;
			if (value.TryGetDouble(out value2))
			{
				return Math.Abs(value2) > double.Epsilon;
			}
			string value3;
			if (value.TryGetString(out value3))
			{
				return !string.IsNullOrEmpty(value3);
			}
			Entity entity;
			if (value.TryGetEntity(out entity))
			{
				return entity != null;
			}
			TagContainer tagContainer;
			if (value.TryGetTagContainer(out tagContainer))
			{
				return tagContainer != null;
			}
			return !value.IsNull;
		}

		// Token: 0x04018539 RID: 99641
		private const int RELATION_OPERATOR_MAX_LENGTH = 2;

		// Token: 0x0401853A RID: 99642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, ENodeType> OperatorMap;

		// Token: 0x0401853B RID: 99643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, ENodeType> RelationOperatorMap;

		// Token: 0x0401853C RID: 99644
		private static readonly bool IsDebug;

		// Token: 0x0401853D RID: 99645
		private string Formula = string.Empty;

		// Token: 0x0401853E RID: 99646
		[Nullable(2)]
		private CustomVariable CustomVariable;

		// Token: 0x0401853F RID: 99647
		private readonly List<string> LogInfo = new List<string>();

		// Token: 0x04018540 RID: 99648
		private int Position;

		// Token: 0x04018541 RID: 99649
		[Nullable(2)]
		private INode RootNode;

		// Token: 0x04018542 RID: 99650
		[Nullable(2)]
		private IExpressionContext Context;

		// Token: 0x04018543 RID: 99651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, TFormulaValue> ExtraParams;

		// Token: 0x04018544 RID: 99652
		private bool IsRunning;

		// Token: 0x04018545 RID: 99653
		private string Reason = string.Empty;
	}
}
