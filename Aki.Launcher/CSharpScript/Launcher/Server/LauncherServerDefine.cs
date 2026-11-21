using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Server
{
	// Token: 0x0200010F RID: 271
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherServerDefine : Singleton
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x00041C48 File Offset: 0x0003FE48
		public string[] GetServerLimitConfig(string region)
		{
			if (this.RegionMap.Count == 0)
			{
				this.RegionMap["America"] = this.America;
				this.RegionMap["Asia"] = this.Asia;
				this.RegionMap["Europe"] = this.Europe;
				this.RegionMap["HMT"] = this.HMT;
				this.RegionMap["SEA"] = this.SEA;
			}
			string[] result;
			if (!this.RegionMap.TryGetValue(region, out result))
			{
				return Array.Empty<string>();
			}
			return result;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00041CE7 File Offset: 0x0003FEE7
		public static LauncherServerDefine Instance
		{
			get
			{
				if (LauncherServerDefine._instance == null)
				{
					LauncherServerDefine._instance = new LauncherServerDefine();
					LauncherServerDefine._instance.OnInit();
				}
				return LauncherServerDefine._instance;
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00041D0A File Offset: 0x0003FF0A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00041D0C File Offset: 0x0003FF0C
		public static void ResetStaticDefaultValue()
		{
			LauncherServerDefine instance = LauncherServerDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherServerDefine._instance = null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00041D25 File Offset: 0x0003FF25
		static LauncherServerDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherServerDefine.CreateStaticDefaultValue), new Action(LauncherServerDefine.ResetStaticDefaultValue));
		}

		// Token: 0x04000521 RID: 1313
		public const string DEFAULTSERVERREGION = "America";

		// Token: 0x04000522 RID: 1314
		public const string SEASERVER = "SEA";

		// Token: 0x04000523 RID: 1315
		public const string CNSERVERNAME = "Default";

		// Token: 0x04000524 RID: 1316
		public const int DEFAULTPING = 9999;

		// Token: 0x04000525 RID: 1317
		public const int ICMP_TIME_OUT = 2;

		// Token: 0x04000526 RID: 1318
		private readonly Dictionary<string, string[]> RegionMap = new Dictionary<string, string[]>();

		// Token: 0x04000527 RID: 1319
		private readonly string[] America = new string[]
		{
			"ar",
			"bo",
			"br",
			"ca",
			"cl",
			"co",
			"cr",
			"ec",
			"sv",
			"gt",
			"hn",
			"mx",
			"ni",
			"pa",
			"py",
			"pe",
			"us",
			"uy"
		};

		// Token: 0x04000528 RID: 1320
		private readonly string[] Asia = new string[]
		{
			"jp",
			"kr"
		};

		// Token: 0x04000529 RID: 1321
		private readonly string[] Europe = new string[]
		{
			"at",
			"bh",
			"be",
			"bg",
			"hr",
			"cy",
			"cz",
			"dk",
			"fi",
			"fr",
			"de",
			"gr",
			"hu",
			"is",
			"ie",
			"il",
			"it",
			"kw",
			"lb",
			"lu",
			"mt",
			"nl",
			"no",
			"om",
			"pl",
			"pt",
			"qa",
			"ro",
			"ru",
			"sa",
			"sk",
			"si",
			"za",
			"es",
			"se",
			"ch",
			"tr",
			"ua",
			"ae",
			"gb"
		};

		// Token: 0x0400052A RID: 1322
		private readonly string[] HMT = new string[]
		{
			"tw",
			"hk"
		};

		// Token: 0x0400052B RID: 1323
		private readonly string[] SEA = new string[]
		{
			"au",
			"nz",
			"in",
			"id",
			"my",
			"sg",
			"th"
		};

		// Token: 0x0400052C RID: 1324
		[Nullable(2)]
		private static LauncherServerDefine _instance;
	}
}
