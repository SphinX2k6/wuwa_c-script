using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.Config
{
	// Token: 0x02000168 RID: 360
	public static class ConfigStatementLibSync
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x0003AF98 File Offset: 0x00039198
		[NullableContext(1)]
		public static int CreateStatement(string dbPath, string command)
		{
			FName fname = new FName(dbPath);
			return UKuroPrepareStatementLib.GetOrCreateStatement(fname, command);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0003AFB4 File Offset: 0x000391B4
		public static void CloseAllConnection()
		{
			UKuroPrepareStatementLib.CloseAllConnection();
		}

		// Token: 0x0400072E RID: 1838
		private const bool USE_CROSS_LANGUAGE_DB_CONNECT = true;
	}
}
