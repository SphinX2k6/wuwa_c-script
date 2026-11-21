using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02003F07 RID: 16135
	public class QtaActionNames
	{
		// Token: 0x06028E9B RID: 167579 RVA: 0x00B7B674 File Offset: 0x00B79874
		private static void InitQtaActionNames()
		{
			if (QtaActionNames.QtaActionsCache.Count == 0)
			{
				IReadOnlyList<QteInputActionMapping> configList = ConfigQteInputActionMappingAll.GetConfigList(true);
				if (configList != null)
				{
					foreach (QteInputActionMapping qteInputActionMapping in configList)
					{
						while (QtaActionNames.QtaActionsCache.Count <= qteInputActionMapping.QteInputActionId)
						{
							QtaActionNames.QtaActionsCache.Add(null);
						}
						QtaActionNames.QtaActionsCache[qteInputActionMapping.QteInputActionId] = qteInputActionMapping.QteInputActionName;
					}
				}
			}
		}

		// Token: 0x06028E9C RID: 167580 RVA: 0x00B7B704 File Offset: 0x00B79904
		public static bool Has(int index)
		{
			QtaActionNames.InitQtaActionNames();
			return index > 0 && index < QtaActionNames.QtaActionsCache.Count && !string.IsNullOrEmpty(QtaActionNames.QtaActionsCache[index]);
		}

		// Token: 0x06028E9D RID: 167581 RVA: 0x00B7B734 File Offset: 0x00B79934
		[NullableContext(1)]
		public static string Get(int index)
		{
			QtaActionNames.InitQtaActionNames();
			if (index >= QtaActionNames.QtaActionsCache.Count || string.IsNullOrEmpty(QtaActionNames.QtaActionsCache[index]))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.HWR;
				string message = "[qta] 输入行为映射不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return string.Empty;
			}
			return QtaActionNames.QtaActionsCache[index] ?? string.Empty;
		}

		// Token: 0x040163DD RID: 91101
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		private static readonly List<string> QtaActionsCache = new List<string>();
	}
}
