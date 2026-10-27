using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Server
{
	// Token: 0x0200010B RID: 267
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherServerDefine : Singleton
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0003F8A8 File Offset: 0x0003DAA8
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0003F947 File Offset: 0x0003DB47
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

		// Token: 0x06000899 RID: 2201 RVA: 0x0003F96A File Offset: 0x0003DB6A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0003F96C File Offset: 0x0003DB6C
		public static void ResetStaticDefaultValue()
		{
			LauncherServerDefine instance = LauncherServerDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherServerDefine._instance = null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0003F985 File Offset: 0x0003DB85
		static LauncherServerDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherServerDefine.CreateStaticDefaultValue), new Action(LauncherServerDefine.ResetStaticDefaultValue));
		}

		// Token: 0x040004E6 RID: 1254
		public const string DEFAULTSERVERREGION = "America";

		// Token: 0x040004E7 RID: 1255
		public const string SEASERVER = "SEA";

		// Token: 0x040004E8 RID: 1256
		public const string CNSERVERNAME = "Default";

		// Token: 0x040004E9 RID: 1257
		public const int DEFAULTPING = 9999;

		// Token: 0x040004EA RID: 1258
		public const int ICMP_TIME_OUT = 2;

		// Token: 0x040004EB RID: 1259
		private readonly Dictionary<string, string[]> RegionMap = new Dictionary<string, string[]>();

		// Token: 0x040004EC RID: 1260
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

		// Token: 0x040004ED RID: 1261
		private readonly string[] Asia = new string[]
		{
			"jp",
			"kr"
		};

		// Token: 0x040004EE RID: 1262
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

		// Token: 0x040004EF RID: 1263
		private readonly string[] HMT = new string[]
		{
			"tw",
			"hk"
		};

		// Token: 0x040004F0 RID: 1264
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

		// Token: 0x040004F1 RID: 1265
		[Nullable(2)]
		private static LauncherServerDefine _instance;
	}
}
