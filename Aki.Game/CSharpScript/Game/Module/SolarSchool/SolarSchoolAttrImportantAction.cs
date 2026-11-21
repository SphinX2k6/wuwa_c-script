using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058AD RID: 22701
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolAttrImportantAction : SolarSchoolActionBase
	{
		// Token: 0x06037EC4 RID: 229060 RVA: 0x00FA1748 File Offset: 0x00F9F948
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			foreach (string text in ActivityActionBase.GetParamString(parameters, "AttrType", "").Split('|', StringSplitOptions.RemoveEmptyEntries))
			{
				int num;
				if (!int.TryParse(text.Trim(), out num) || num == 0 || !Enum.IsDefined(typeof(ESolarSchoolSecondAttr), num))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 属性重要性 Action 的 AttrType 非法，已跳过";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("attrType", text);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.Attrs.Add((ESolarSchoolSecondAttr)num);
				}
			}
		}

		// Token: 0x06037EC5 RID: 229061 RVA: 0x00FA17E4 File Offset: 0x00F9F9E4
		protected override void OnStart()
		{
			SolarSchoolGamePlayModel.Instance.PlayerData.ReplaceImportantAttrs(this.Attrs);
			base.MarkDone();
		}

		// Token: 0x0401D802 RID: 120834
		private readonly List<ESolarSchoolSecondAttr> Attrs = new List<ESolarSchoolSecondAttr>();
	}
}
