using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000247 RID: 583
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherServerLimitConfig
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0005905A File Offset: 0x0005725A
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00059062 File Offset: 0x00057262
		public string CountryCodes { get; private set; }

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0005906B File Offset: 0x0005726B
		public LauncherServerLimitConfig(string countryCodes)
		{
			this.CountryCodes = countryCodes;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0005907A File Offset: 0x0005727A
		public static string GetTableName()
		{
			return "ServerLimit";
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00059084 File Offset: 0x00057284
		public static LauncherServerLimitConfig Parse(UKuroSqliteResultSet rs)
		{
			string countryCodes = null;
			if (!rs.GetString("CountryCodes", ref countryCodes))
			{
				return null;
			}
			return new LauncherServerLimitConfig(countryCodes);
		}

		// Token: 0x040009B1 RID: 2481
		private const string TableName = "ServerLimit";
	}
}
