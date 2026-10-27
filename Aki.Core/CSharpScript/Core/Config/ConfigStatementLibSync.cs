using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000163 RID: 355
	public static class ConfigStatementLibSync
	{
		// Token: 0x06000C38 RID: 3128 RVA: 0x0003A254 File Offset: 0x00038454
		[NullableContext(1)]
		public static int CreateStatement(string dbPath, string command)
		{
			FName fname = new FName(dbPath);
			return UKuroPrepareStatementLib.GetOrCreateStatement(fname, command);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003A270 File Offset: 0x00038470
		public static void CloseAllConnection()
		{
			UKuroPrepareStatementLib.CloseAllConnection();
		}

		// Token: 0x0400071F RID: 1823
		private const bool USE_CROSS_LANGUAGE_DB_CONNECT = true;
	}
}
