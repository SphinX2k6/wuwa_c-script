using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200450E RID: 17678
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomVariable
	{
		// Token: 0x0602D806 RID: 186374 RVA: 0x00A44B08 File Offset: 0x00A42D08
		private CustomVariable(Dictionary<string, string> customVariableStr)
		{
			foreach (KeyValuePair<string, string> keyValuePair in customVariableStr)
			{
				this._customVariableStr[keyValuePair.Key] = keyValuePair.Value;
			}
			this._logInfo.Clear();
			this.VariableMap.Clear();
		}

		// Token: 0x0602D807 RID: 186375 RVA: 0x00A44BA8 File Offset: 0x00A42DA8
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

		// Token: 0x0602D808 RID: 186376 RVA: 0x00A44C9C File Offset: 0x00A42E9C
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

		// Token: 0x0602D809 RID: 186377 RVA: 0x00A44EAF File Offset: 0x00A430AF
		public bool HasVariable(string variableName)
		{
			return this.VariableMap.ContainsKey(variableName);
		}

		// Token: 0x0602D80A RID: 186378 RVA: 0x00A44EC0 File Offset: 0x00A430C0
		public TFormulaValue GetVariable(string variableName)
		{
			IVariable variable;
			if (this.VariableMap.TryGetValue(variableName, out variable))
			{
				return variable.Value;
			}
			return default(TFormulaValue);
		}

		// Token: 0x0602D80B RID: 186379 RVA: 0x00A44EED File Offset: 0x00A430ED
		private void AddDebugInfo(string debugStr)
		{
			this._logInfo.Add(debugStr);
		}

		// Token: 0x04018521 RID: 99617
		private readonly Dictionary<string, string> _customVariableStr = new Dictionary<string, string>();

		// Token: 0x04018522 RID: 99618
		public readonly Dictionary<string, IVariable> VariableMap = new Dictionary<string, IVariable>();

		// Token: 0x04018523 RID: 99619
		private readonly List<string> _logInfo = new List<string>();
	}
}
