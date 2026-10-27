using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02004F3E RID: 20286
	public class QtaActionNames
	{
		// Token: 0x0603402D RID: 213037 RVA: 0x00C31ED4 File Offset: 0x00C300D4
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

		// Token: 0x0603402E RID: 213038 RVA: 0x00C31F64 File Offset: 0x00C30164
		public static bool Has(int index)
		{
			QtaActionNames.InitQtaActionNames();
			return index > 0 && index < QtaActionNames.QtaActionsCache.Count && !string.IsNullOrEmpty(QtaActionNames.QtaActionsCache[index]);
		}

		// Token: 0x0603402F RID: 213039 RVA: 0x00C31F94 File Offset: 0x00C30194
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

		// Token: 0x0401BA08 RID: 113160
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[StaticVariableRuleIgnore]
		private static readonly List<string> QtaActionsCache = new List<string>();
	}
}
