using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B0 RID: 22704
	public class SolarSchoolAvgParamAction : SolarSchoolActionBase
	{
		// Token: 0x06037ED0 RID: 229072 RVA: 0x00FA1BB4 File Offset: 0x00F9FDB4
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.Assignments.Clear();
			string paramString = ActivityActionBase.GetParamString(parameters, "Params", "");
			if (string.IsNullOrEmpty(paramString))
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] AvgParamAction 缺少 Params 参数", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			foreach (string text in paramString.Split('|', StringSplitOptions.None))
			{
				string[] array2 = text.Split('=', StringSplitOptions.None);
				if (array2.Length != 2)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] AvgParamAction 参数格式错误，应为 Key=true|Key2=false";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("part", text);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					string text2 = array2[0].Trim();
					bool item;
					if (string.IsNullOrEmpty(text2) || !bool.TryParse(array2[1].Trim(), out item))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.SolarSchool;
						ELogAuthor author2 = ELogAuthor.LRC;
						string message2 = "[SolarSchool] AvgParamAction 参数键或布尔值非法";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("part", text);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
					else
					{
						this.Assignments.Add(new ValueTuple<string, bool>(text2, item));
					}
				}
			}
		}

		// Token: 0x06037ED1 RID: 229073 RVA: 0x00FA1CD8 File Offset: 0x00F9FED8
		protected override void OnStart()
		{
			if (this.Assignments.Count == 0)
			{
				base.MarkFailed();
				return;
			}
			foreach (ValueTuple<string, bool> valueTuple in this.Assignments)
			{
				string item = valueTuple.Item1;
				bool item2 = valueTuple.Item2;
				SolarSchoolGamePlayModel.Instance.AvgParamData.SetParam(item, item2);
			}
			base.MarkDone();
		}

		// Token: 0x0401D805 RID: 120837
		[TupleElementNames(new string[]
		{
			"Key",
			"Value"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<ValueTuple<string, bool>> Assignments = new List<ValueTuple<string, bool>>();
	}
}
