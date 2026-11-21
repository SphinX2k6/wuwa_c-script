using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003434 RID: 13364
	[NullableContext(1)]
	[Nullable(0)]
	public class ExpressionTree : IStaticVariableResetter
	{
		// Token: 0x06021EED RID: 138989 RVA: 0x00970D62 File Offset: 0x0096EF62
		static ExpressionTree()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ExpressionTree.CreateStaticDefaultValue), new Action(ExpressionTree.ResetStaticDefaultValue));
		}

		// Token: 0x06021EEE RID: 138990 RVA: 0x00970D84 File Offset: 0x0096EF84
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

		// Token: 0x06021EEF RID: 138991 RVA: 0x00970E1E File Offset: 0x0096F01E
		public static void ResetStaticDefaultValue()
		{
			ExpressionTree.OperatorMap = null;
			ExpressionTree.RelationOperatorMap = null;
		}

		// Token: 0x06021EF0 RID: 138992 RVA: 0x00970E2C File Offset: 0x0096F02C
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

		// Token: 0x06021EF1 RID: 138993 RVA: 0x00970E80 File Offset: 0x0096F080
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

		// Token: 0x06021EF2 RID: 138994 RVA: 0x00970F74 File Offset: 0x0096F174
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

		// Token: 0x06021EF3 RID: 138995 RVA: 0x00971070 File Offset: 0x0096F270
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

		// Token: 0x06021EF4 RID: 138996 RVA: 0x00971180 File Offset: 0x0096F380
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

		// Token: 0x06021EF5 RID: 138997 RVA: 0x00971274 File Offset: 0x0096F474
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

		// Token: 0x06021EF6 RID: 138998 RVA: 0x00971334 File Offset: 0x0096F534
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

		// Token: 0x06021EF7 RID: 138999 RVA: 0x009714B2 File Offset: 0x0096F6B2
		private bool IsRelationOperatorStart(char ch)
		{
			return ch == '=' || ch == '!' || ch == '<' || ch == '>';
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x06021EF8 RID: 139000 RVA: 0x009714CA File Offset: 0x0096F6CA
		private bool IsEnd
		{
			get
			{
				return this.Position >= this.Formula.Length;
			}
		}

		// Token: 0x06021EF9 RID: 139001 RVA: 0x009714E4 File Offset: 0x0096F6E4
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

		// Token: 0x06021EFA RID: 139002 RVA: 0x00971533 File Offset: 0x0096F733
		private void ThrowError(string errorInfo)
		{
			throw new Exception(errorInfo);
		}

		// Token: 0x06021EFB RID: 139003 RVA: 0x0097153C File Offset: 0x0096F73C
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

		// Token: 0x06021EFC RID: 139004 RVA: 0x009717F4 File Offset: 0x0096F9F4
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

		// Token: 0x06021EFD RID: 139005 RVA: 0x009718A4 File Offset: 0x0096FAA4
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

		// Token: 0x06021EFE RID: 139006 RVA: 0x00971A6C File Offset: 0x0096FC6C
		[Conditional("DEBUG")]
		private void PrintRunTimeLogInfo()
		{
		}

		// Token: 0x06021EFF RID: 139007 RVA: 0x00971A6E File Offset: 0x0096FC6E
		[Conditional("DEBUG")]
		private void AddRunTimeLogInfo(string info)
		{
		}

		// Token: 0x06021F00 RID: 139008 RVA: 0x00971A70 File Offset: 0x0096FC70
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

		// Token: 0x04012B61 RID: 76641
		private const int RELATION_OPERATOR_MAX_LENGTH = 2;

		// Token: 0x04012B62 RID: 76642
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, ENodeType> OperatorMap;

		// Token: 0x04012B63 RID: 76643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<string, ENodeType> RelationOperatorMap;

		// Token: 0x04012B64 RID: 76644
		private static readonly bool IsDebug;

		// Token: 0x04012B65 RID: 76645
		private string Formula = string.Empty;

		// Token: 0x04012B66 RID: 76646
		[Nullable(2)]
		private CustomVariable CustomVariable;

		// Token: 0x04012B67 RID: 76647
		private readonly List<string> LogInfo = new List<string>();

		// Token: 0x04012B68 RID: 76648
		private int Position;

		// Token: 0x04012B69 RID: 76649
		[Nullable(2)]
		private INode RootNode;

		// Token: 0x04012B6A RID: 76650
		[Nullable(2)]
		private IExpressionContext Context;

		// Token: 0x04012B6B RID: 76651
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, TFormulaValue> ExtraParams;

		// Token: 0x04012B6C RID: 76652
		private bool IsRunning;

		// Token: 0x04012B6D RID: 76653
		private string Reason = string.Empty;
	}
}
