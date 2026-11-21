using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define.SimpleTabel
{
	// Token: 0x02000253 RID: 595
	public class TableRegistry : IStaticVariableResetter
	{
		// Token: 0x06000F14 RID: 3860 RVA: 0x00059947 File Offset: 0x00057B47
		static TableRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TableRegistry.CreateStaticDefaultValue), new Action(TableRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00059968 File Offset: 0x00057B68
		[NullableContext(1)]
		public static void Register<[Nullable(0)] TRow>(string name, Func<TableReader<TRow>> tableClass) where TRow : TableBaseRow
		{
			if (TableRegistry.TableMap.ContainsKey(name))
			{
				LauncherLog.Instance.Warn("TableRegistry: 表 " + name + " 已经注册过了", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TableReader<TRow> value = tableClass();
			TableRegistry.TableMap[name] = value;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x000599B9 File Offset: 0x00057BB9
		public static void CreateStaticDefaultValue()
		{
			TableRegistry.TableMap = new Dictionary<string, object>();
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000599C5 File Offset: 0x00057BC5
		public static void ResetStaticDefaultValue()
		{
			TableRegistry.TableMap = null;
		}

		// Token: 0x040009C8 RID: 2504
		[Nullable(1)]
		private static Dictionary<string, object> TableMap;
	}
}
