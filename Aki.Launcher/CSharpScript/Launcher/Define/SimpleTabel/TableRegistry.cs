using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Define.SimpleTabel
{
	// Token: 0x0200024E RID: 590
	public class TableRegistry : IStaticVariableResetter
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x00056E03 File Offset: 0x00055003
		static TableRegistry()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TableRegistry.CreateStaticDefaultValue), new Action(TableRegistry.ResetStaticDefaultValue));
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00056E24 File Offset: 0x00055024
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

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00056E75 File Offset: 0x00055075
		public static void CreateStaticDefaultValue()
		{
			TableRegistry.TableMap = new Dictionary<string, object>();
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00056E81 File Offset: 0x00055081
		public static void ResetStaticDefaultValue()
		{
			TableRegistry.TableMap = null;
		}

		// Token: 0x04000980 RID: 2432
		[Nullable(1)]
		private static Dictionary<string, object> TableMap;
	}
}
