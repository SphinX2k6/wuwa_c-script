using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003430 RID: 13360
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomVariable
	{
		// Token: 0x06021ED6 RID: 138966 RVA: 0x00970918 File Offset: 0x0096EB18
		private CustomVariable(Dictionary<string, string> customVariableStr)
		{
			foreach (KeyValuePair<string, string> keyValuePair in customVariableStr)
			{
				this._customVariableStr[keyValuePair.Key] = keyValuePair.Value;
			}
			this._logInfo.Clear();
			this.VariableMap.Clear();
		}

		// Token: 0x06021ED7 RID: 138967 RVA: 0x009709B8 File Offset: 0x0096EBB8
		public unsafe static CustomVariable Create(Dictionary<string, string> customVariable, string reason)
		{
			CustomVariable customVariable2 = new CustomVariable(customVariable);
			foreach (KeyValuePair<string, string> keyValuePair in customVariable)
			{
				customVariable2.ParseCustomVariables(keyValuePair.Key, keyValuePair.Value);
			}
			if (customVariable2._logInfo.Count > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.TZQ;
				string message = "解析表达式自定义变量异常";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ErrorInfo", customVariable2._logInfo);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CustomVariableStr", customVariable2._customVariableStr);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				customVariable2._logInfo.Clear();
			}
			return customVariable2;
		}

		// Token: 0x06021ED8 RID: 138968 RVA: 0x00970AAC File Offset: 0x0096ECAC
		private void ParseCustomVariables(string variableName, string variableStr)
		{
			string[] array = variableStr.Replace(" ", string.Empty).Split('#', StringSplitOptions.None);
			if (array.Length < 2)
			{
				this.AddDebugInfo(variableStr + "解析自定义变量格式错误:字符串数量小于2");
				return;
			}
			string a = array[0];
			if (!(a == "Long"))
			{
				if (a == "LongArray")
				{
					List<double> list = new List<double>();
					for (int i = 1; i < array.Length; i++)
					{
						double item;
						if (!double.TryParse(array[i], out item))
						{
							this.AddDebugInfo(variableStr + "解析自定义变量格式错误: 数组不合法");
							return;
						}
						list.Add(item);
					}
					this.VariableMap[variableName] = new Variable
					{
						Type = EVariableType.NumberArray,
						Value = list.ToArray()
					};
					return;
				}
				if (!(a == "Tag"))
				{
					if (a == "TagContainer")
					{
						TagContainer tagContainer = new TagContainer();
						for (int j = 1; j < array.Length; j++)
						{
							int tagIdByName = GameplayTagUtils.GetTagIdByName(array[j]);
							if (tagIdByName == 0)
							{
								this.AddDebugInfo(variableStr + "解析自定义变量格式错误: Tag不合法, 异常tagName" + array[j]);
								return;
							}
							tagContainer.AddExactTag(ETagChannel.Common, tagIdByName);
						}
						this.VariableMap[variableName] = new Variable
						{
							Type = EVariableType.TagContainer,
							Value = tagContainer
						};
						return;
					}
					if (!(a == "String"))
					{
						return;
					}
					this.VariableMap[variableName] = new Variable
					{
						Type = EVariableType.String,
						Value = array[1]
					};
					return;
				}
				else
				{
					int tagIdByName2 = GameplayTagUtils.GetTagIdByName(array[1]);
					if (tagIdByName2 == 0)
					{
						this.AddDebugInfo(variableStr + "解析自定义变量格式错误: Tag不合法");
						return;
					}
					this.VariableMap[variableName] = new Variable
					{
						Type = EVariableType.Tag,
						Value = tagIdByName2
					};
					return;
				}
			}
			else
			{
				double value;
				if (!double.TryParse(array[1], out value))
				{
					this.AddDebugInfo(variableStr + "解析自定义变量格式错误: 数字不合法");
					return;
				}
				this.VariableMap[variableName] = new Variable
				{
					Type = EVariableType.Number,
					Value = value
				};
				return;
			}
		}

		// Token: 0x06021ED9 RID: 138969 RVA: 0x00970CBF File Offset: 0x0096EEBF
		public bool HasVariable(string variableName)
		{
			return this.VariableMap.ContainsKey(variableName);
		}

		// Token: 0x06021EDA RID: 138970 RVA: 0x00970CD0 File Offset: 0x0096EED0
		public TFormulaValue GetVariable(string variableName)
		{
			IVariable variable;
			if (this.VariableMap.TryGetValue(variableName, out variable))
			{
				return variable.Value;
			}
			return default(TFormulaValue);
		}

		// Token: 0x06021EDB RID: 138971 RVA: 0x00970CFD File Offset: 0x0096EEFD
		private void AddDebugInfo(string debugStr)
		{
			this._logInfo.Add(debugStr);
		}

		// Token: 0x04012B49 RID: 76617
		private readonly Dictionary<string, string> _customVariableStr = new Dictionary<string, string>();

		// Token: 0x04012B4A RID: 76618
		public readonly Dictionary<string, IVariable> VariableMap = new Dictionary<string, IVariable>();

		// Token: 0x04012B4B RID: 76619
		private readonly List<string> _logInfo = new List<string>();
	}
}
