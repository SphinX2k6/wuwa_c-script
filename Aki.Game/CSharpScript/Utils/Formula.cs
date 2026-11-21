using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace CSharpScript.Utils
{
	// Token: 0x0200342C RID: 13356
	[NullableContext(1)]
	[Nullable(0)]
	public class Formula
	{
		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x06021EB8 RID: 138936 RVA: 0x0096FDB0 File Offset: 0x0096DFB0
		public string FormulaStr
		{
			get
			{
				return this.FormulaRaw;
			}
		}

		// Token: 0x06021EB9 RID: 138937 RVA: 0x0096FDB8 File Offset: 0x0096DFB8
		public Formula(string formula)
		{
			this.FormulaRaw = formula;
			this.Ast = FormulaCacheManager.Acquire(formula);
			this.Params = null;
			this.ParamsCacheKey = null;
		}

		// Token: 0x06021EBA RID: 138938 RVA: 0x0096FE23 File Offset: 0x0096E023
		public void Dispose()
		{
			if (!this.IsDisposed)
			{
				FormulaCacheManager.Release(this.FormulaRaw);
				if (!string.IsNullOrEmpty(this.ParamsCacheKey))
				{
					FormulaParamsCacheManager.Release(this.ParamsCacheKey);
					this.ParamsCacheKey = null;
				}
				this.IsDisposed = true;
			}
		}

		// Token: 0x06021EBB RID: 138939 RVA: 0x0096FE60 File Offset: 0x0096E060
		public Formula SetBuiltinFunctions(Dictionary<string, Func<TFormulaValue[], TFormulaValue>> functions)
		{
			this.BuiltinFuncs.Clear();
			foreach (KeyValuePair<string, Func<TFormulaValue[], TFormulaValue>> keyValuePair in functions)
			{
				this.BuiltinFuncs[keyValuePair.Key] = keyValuePair.Value;
			}
			return this;
		}

		// Token: 0x06021EBC RID: 138940 RVA: 0x0096FECC File Offset: 0x0096E0CC
		public Formula SetContextBuiltinFunctions(Dictionary<string, Func<TFormulaValue[], TFormulaValue>> functions)
		{
			foreach (KeyValuePair<string, Func<TFormulaValue[], TFormulaValue>> keyValuePair in functions)
			{
				this.BuiltinFuncs[keyValuePair.Key] = keyValuePair.Value;
				this.contextDependentFunction.Add(keyValuePair.Key);
			}
			return this;
		}

		// Token: 0x06021EBD RID: 138941 RVA: 0x0096FF40 File Offset: 0x0096E140
		public Formula AddBuiltinFunction(string name, Func<TFormulaValue[], TFormulaValue> func)
		{
			this.BuiltinFuncs[name] = func;
			return this;
		}

		// Token: 0x06021EBE RID: 138942 RVA: 0x0096FF50 File Offset: 0x0096E150
		public Formula SetDefaultParams(Dictionary<string, TFormulaValue> @params)
		{
			this.Params = new Dictionary<string, TFormulaValue>(@params);
			return this;
		}

		// Token: 0x06021EBF RID: 138943 RVA: 0x0096FF60 File Offset: 0x0096E160
		public Formula SetDefaultParams([Nullable(2)] string @params)
		{
			if (this.Params != null || this.ParamsCacheKey != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.ZQR;
				string message = "Formula重复设置默认参数";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("formula", this.FormulaRaw);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return this;
			}
			if (string.IsNullOrEmpty(@params))
			{
				this.Params = new Dictionary<string, TFormulaValue>();
				return this;
			}
			this.ParamsCacheKey = @params;
			this.Params = new Dictionary<string, TFormulaValue>(FormulaParamsCacheManager.Acquire(@params));
			return this;
		}

		// Token: 0x06021EC0 RID: 138944 RVA: 0x0096FFD9 File Offset: 0x0096E1D9
		public Formula SetDefaultParam(string key, TFormulaValue value)
		{
			if (this.Params == null)
			{
				this.Params = new Dictionary<string, TFormulaValue>();
			}
			this.Params[key] = value;
			return this;
		}

		// Token: 0x06021EC1 RID: 138945 RVA: 0x0096FFFC File Offset: 0x0096E1FC
		internal static TFormulaValue FromJsonElement(JsonElement json)
		{
			switch (json.ValueKind)
			{
			case JsonValueKind.Array:
			{
				List<TFormulaValue> list = new List<TFormulaValue>();
				foreach (JsonElement json2 in json.EnumerateArray())
				{
					list.Add(Formula.FromJsonElement(json2));
				}
				double[] array = new double[list.Count];
				bool flag = true;
				for (int i = 0; i < list.Count; i++)
				{
					double num;
					if (!list[i].TryGetDouble(out num))
					{
						flag = false;
						break;
					}
					array[i] = num;
				}
				if (flag)
				{
					return TFormulaValue.FromDoubleArray(array);
				}
				string[] array2 = new string[list.Count];
				for (int j = 0; j < list.Count; j++)
				{
					string text;
					if (!list[j].TryGetString(out text) || text == null)
					{
						return default(TFormulaValue);
					}
					array2[j] = text;
				}
				return TFormulaValue.FromStringArray(array2);
			}
			case JsonValueKind.String:
				return TFormulaValue.FromString(json.GetString() ?? string.Empty);
			case JsonValueKind.Number:
			{
				int value;
				if (json.TryGetInt32(out value))
				{
					return TFormulaValue.FromInt(value);
				}
				long value2;
				if (json.TryGetInt64(out value2))
				{
					return TFormulaValue.FromLong(value2);
				}
				double value3;
				if (json.TryGetDouble(out value3))
				{
					return TFormulaValue.FromDouble(value3);
				}
				break;
			}
			case JsonValueKind.True:
			case JsonValueKind.False:
				return TFormulaValue.FromBool(json.GetBoolean());
			}
			return default(TFormulaValue);
		}

		// Token: 0x06021EC2 RID: 138946 RVA: 0x009701A0 File Offset: 0x0096E3A0
		private TFormulaValue EvaluateNode(IAstNode node)
		{
			NumberNode numberNode = node as NumberNode;
			if (numberNode != null)
			{
				return numberNode.Value;
			}
			BooleanNode booleanNode = node as BooleanNode;
			if (booleanNode != null)
			{
				return TFormulaValue.FromBool(booleanNode.Value);
			}
			StringNode stringNode = node as StringNode;
			if (stringNode != null)
			{
				return TFormulaValue.FromString(stringNode.Value);
			}
			ArrayNode arrayNode = node as ArrayNode;
			if (arrayNode != null)
			{
				TFormulaValue[] array = new TFormulaValue[arrayNode.Value.Length];
				for (int i = 0; i < arrayNode.Value.Length; i++)
				{
					array[i] = this.EvaluateNode(arrayNode.Value[i]);
				}
				return TFormulaValue.FromArrayLiteral(array);
			}
			IdentifierNode identifierNode = node as IdentifierNode;
			if (identifierNode != null)
			{
				TFormulaValue tformulaValue;
				TFormulaValue result;
				if (this.Params != null && this.Params.TryGetValue(identifierNode.Value, out tformulaValue))
				{
					result = tformulaValue;
				}
				else
				{
					TFormulaValue tformulaValue2;
					if (this.ExtraParams == null || !this.ExtraParams.TryGetValue(identifierNode.Value, out tformulaValue2))
					{
						throw new Exception("Undefined variable: " + identifierNode.Value);
					}
					result = tformulaValue2;
				}
				this.IsIdentifierNotRecorded(identifierNode.Value);
				return result;
			}
			IndexNode indexNode = node as IndexNode;
			if (indexNode == null)
			{
				UnaryOperatorNode unaryOperatorNode = node as UnaryOperatorNode;
				if (unaryOperatorNode == null)
				{
					BinaryOperatorNode binaryOperatorNode = node as BinaryOperatorNode;
					FunctionCallNode functionCallNode;
					if (binaryOperatorNode == null)
					{
						functionCallNode = (node as FunctionCallNode);
						if (functionCallNode == null)
						{
							ParenthesizedExpressionNode parenthesizedExpressionNode = node as ParenthesizedExpressionNode;
							if (parenthesizedExpressionNode == null)
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
								defaultInterpolatedStringHandler.AppendLiteral("Invalid node type: ");
								defaultInterpolatedStringHandler.AppendFormatted<Type>(node.GetType());
								throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
							}
							return this.EvaluateNode(parenthesizedExpressionNode.Value);
						}
					}
					else
					{
						TFormulaValue tformulaValue3 = this.EvaluateNode(binaryOperatorNode.Args[0]);
						TFormulaValue tformulaValue4 = this.EvaluateNode(binaryOperatorNode.Args[1]);
						try
						{
							string @operator = binaryOperatorNode.Operator;
							if (@operator != null)
							{
								int length = @operator.Length;
								if (length != 1)
								{
									if (length == 2)
									{
										char c = @operator[0];
										if (c <= '&')
										{
											if (c != '!')
											{
												if (c == '&')
												{
													if (@operator == "&&")
													{
														return tformulaValue3 & tformulaValue4;
													}
												}
											}
											else if (@operator == "!=")
											{
												return TFormulaValue.FromBool(tformulaValue3 != tformulaValue4);
											}
										}
										else
										{
											switch (c)
											{
											case '<':
												if (@operator == "<=")
												{
													return TFormulaValue.FromBool(tformulaValue3 <= tformulaValue4);
												}
												break;
											case '=':
												if (@operator == "==")
												{
													return TFormulaValue.FromBool(tformulaValue3 == tformulaValue4);
												}
												break;
											case '>':
												if (@operator == ">=")
												{
													return TFormulaValue.FromBool(tformulaValue3 >= tformulaValue4);
												}
												break;
											default:
												if (c == '|')
												{
													if (@operator == "||")
													{
														return tformulaValue3 | tformulaValue4;
													}
												}
												break;
											}
										}
									}
								}
								else
								{
									char c = @operator[0];
									if (c <= '/')
									{
										if (c == '%')
										{
											return tformulaValue3 % tformulaValue4;
										}
										switch (c)
										{
										case '*':
											return tformulaValue3 * tformulaValue4;
										case '+':
											return tformulaValue3 + tformulaValue4;
										case '-':
											return tformulaValue3 - tformulaValue4;
										case '/':
											return tformulaValue3 / tformulaValue4;
										}
									}
									else
									{
										if (c == '<')
										{
											return TFormulaValue.FromBool(tformulaValue3 < tformulaValue4);
										}
										if (c == '>')
										{
											return TFormulaValue.FromBool(tformulaValue3 > tformulaValue4);
										}
									}
								}
							}
							throw new Exception("Invalid binary operator: " + binaryOperatorNode.Operator);
						}
						catch (Exception)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 3);
							defaultInterpolatedStringHandler.AppendLiteral("Invalid operation: ");
							defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(tformulaValue3);
							defaultInterpolatedStringHandler.AppendLiteral(" ");
							defaultInterpolatedStringHandler.AppendFormatted(binaryOperatorNode.Operator);
							defaultInterpolatedStringHandler.AppendLiteral(" ");
							defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(tformulaValue4);
							throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
						}
					}
					bool flag = this.contextDependentFunction.Contains(functionCallNode.Value);
					TFormulaValue[] array2 = new TFormulaValue[functionCallNode.Args.Length + ((flag > false) ? 1 : 0)];
					int num = 0;
					if (flag)
					{
						array2[0] = TFormulaValue.FromContext(this.context);
						num = 1;
					}
					for (int j = 0; j < functionCallNode.Args.Length; j++)
					{
						array2[num + j] = this.EvaluateNode(functionCallNode.Args[j]);
					}
					Func<TFormulaValue[], TFormulaValue> valueOrDefault = this.BuiltinFuncs.GetValueOrDefault(functionCallNode.Value);
					if (valueOrDefault != null)
					{
						return valueOrDefault(array2);
					}
					return default(TFormulaValue);
				}
				else
				{
					TFormulaValue operand = this.EvaluateNode(unaryOperatorNode.Args[0]);
					string @operator = unaryOperatorNode.Operator;
					if (@operator == "+")
					{
						return +operand;
					}
					if (@operator == "-")
					{
						return -operand;
					}
					if (!(@operator == "!"))
					{
						throw new Exception("Invalid unary operator: " + unaryOperatorNode.Operator);
					}
					return !operand;
				}
			}
			else
			{
				TFormulaValue tformulaValue5 = this.EvaluateNode(indexNode.Value);
				TFormulaValue value = this.EvaluateNode(indexNode.Index);
				int num2;
				if (!value.TryGetIndex(out num2) || num2 < 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Invalid array index: ");
					defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(value);
					throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				TFormulaValue result2;
				if (tformulaValue5.TryGetArrayElement(num2, out result2))
				{
					return result2;
				}
				if (tformulaValue5.Type == EFormulaValueType.DoubleArray || tformulaValue5.Type == EFormulaValueType.StringArray)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Invalid array index: ");
					defaultInterpolatedStringHandler.AppendFormatted<TFormulaValue>(value);
					throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				throw new Exception("Variable is not a valid array");
			}
		}

		// Token: 0x06021EC3 RID: 138947 RVA: 0x00970800 File Offset: 0x0096EA00
		[NullableContext(2)]
		public unsafe TFormulaValue Evaluate([Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<string, TFormulaValue> args = null, ContextParam context = null)
		{
			this.ExtraParams = args;
			this.context = context;
			TFormulaValue result = default(TFormulaValue);
			try
			{
				result = this.EvaluateNode(this.Ast);
			}
			catch (Exception ex)
			{
				result = default(TFormulaValue);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.ZQR;
				string message = "Trigger条件解析异常";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("formula", this.FormulaRaw);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			finally
			{
				this.ExtraParams = null;
				this.context = null;
			}
			return result;
		}

		// Token: 0x06021EC4 RID: 138948 RVA: 0x009708C8 File Offset: 0x0096EAC8
		[Conditional("DEBUG")]
		public void ResetDebugString()
		{
		}

		// Token: 0x06021EC5 RID: 138949 RVA: 0x009708CA File Offset: 0x0096EACA
		[Conditional("DEBUG")]
		public void AddDebugString(string key, TFormulaValue value)
		{
		}

		// Token: 0x06021EC6 RID: 138950 RVA: 0x009708CC File Offset: 0x0096EACC
		public bool IsIdentifierNotRecorded(string str)
		{
			return false;
		}

		// Token: 0x06021EC7 RID: 138951 RVA: 0x009708CF File Offset: 0x0096EACF
		[Conditional("DEBUG")]
		public void ResetDebugIdentifierMap()
		{
		}

		// Token: 0x06021EC8 RID: 138952 RVA: 0x009708D1 File Offset: 0x0096EAD1
		[Conditional("DEBUG")]
		public void RecordIdentifier(string str)
		{
		}

		// Token: 0x06021EC9 RID: 138953 RVA: 0x009708D3 File Offset: 0x0096EAD3
		public string GetFormulaString(IAstNode node)
		{
			return string.Empty;
		}

		// Token: 0x06021ECA RID: 138954 RVA: 0x009708DA File Offset: 0x0096EADA
		public string GetLastResult()
		{
			return string.Empty;
		}

		// Token: 0x06021ECB RID: 138955 RVA: 0x009708E1 File Offset: 0x0096EAE1
		public IReadOnlyDictionary<string, string> GetLastResultMap()
		{
			return null;
		}

		// Token: 0x06021ECC RID: 138956 RVA: 0x009708E4 File Offset: 0x0096EAE4
		public string GetTotalFormulaString()
		{
			return string.Empty;
		}

		// Token: 0x04012B36 RID: 76598
		private readonly IAstNode Ast;

		// Token: 0x04012B37 RID: 76599
		private readonly string FormulaRaw = "";

		// Token: 0x04012B38 RID: 76600
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<string, TFormulaValue> Params;

		// Token: 0x04012B39 RID: 76601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<string, TFormulaValue> ExtraParams;

		// Token: 0x04012B3A RID: 76602
		private readonly Dictionary<string, Func<TFormulaValue[], TFormulaValue>> BuiltinFuncs = new Dictionary<string, Func<TFormulaValue[], TFormulaValue>>();

		// Token: 0x04012B3B RID: 76603
		private readonly HashSet<string> contextDependentFunction = new HashSet<string>();

		// Token: 0x04012B3C RID: 76604
		[Nullable(2)]
		public ContextParam context;

		// Token: 0x04012B3D RID: 76605
		[Nullable(2)]
		private string ParamsCacheKey;

		// Token: 0x04012B3E RID: 76606
		private bool IsDisposed;

		// Token: 0x04012B3F RID: 76607
		private readonly Dictionary<string, string> DebugValueMap = new Dictionary<string, string>();

		// Token: 0x04012B40 RID: 76608
		private readonly HashSet<string> DebugRecordedIdentifiers = new HashSet<string>();
	}
}
