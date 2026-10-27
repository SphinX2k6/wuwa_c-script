using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000242 RID: 578
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherServerLimitConfig
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00056516 File Offset: 0x00054716
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x0005651E File Offset: 0x0005471E
		public string CountryCodes { get; private set; }

		// Token: 0x06000E93 RID: 3731 RVA: 0x00056527 File Offset: 0x00054727
		public LauncherServerLimitConfig(string countryCodes)
		{
			this.CountryCodes = countryCodes;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00056536 File Offset: 0x00054736
		public static string GetTableName()
		{
			return "ServerLimit";
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00056540 File Offset: 0x00054740
		public static LauncherServerLimitConfig Parse(UKuroSqliteResultSet rs)
		{
			string countryCodes = null;
			if (!rs.GetString("CountryCodes", ref countryCodes))
			{
				return null;
			}
			return new LauncherServerLimitConfig(countryCodes);
		}

		// Token: 0x04000969 RID: 2409
		private const string TableName = "ServerLimit";
	}
}
