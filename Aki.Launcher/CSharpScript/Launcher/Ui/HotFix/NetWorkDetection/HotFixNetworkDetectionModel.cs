using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.NetworkDetection;
using CSharpScript.Launcher.Platform.PlatformSdk;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000FC RID: 252
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectionModel : Singleton
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x0003F4DC File Offset: 0x0003D6DC
		public List<ILoginServersData> GetLoginServersByClientRegion()
		{
			if (this.LoginServerData != null)
			{
				return this.LoginServerData;
			}
			List<ILoginServersData> loginServers = BaseConfigController.Instance.GetLoginServers();
			if (PlatformSdkManagerNew.Instance.GetPlatformSdk().BlockServerArea())
			{
				List<ILoginServersData> list = new List<ILoginServersData>();
				string sdkCountry = PlatformSdkManagerNew.Instance.GetPlatformSdk().GetSdkCountry();
				LauncherLog instance = LauncherLog.Instance;
				string message = "锁区";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("currentCountryCode", sdkCountry);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				for (int i = 0; i < loginServers.Count; i++)
				{
					ILoginServersData loginServersData = loginServers[i];
					if (loginServersData.Region != null && loginServersData.Region.Length != 0)
					{
						LauncherServerLimitConfig serverLimitConfig = LauncherConfigLib.Instance.GetServerLimitConfig(loginServersData.Region);
						if (serverLimitConfig != null && sdkCountry != null && sdkCountry.Length > 0)
						{
							string[] array = (serverLimitConfig.CountryCodes ?? "").Split(',', StringSplitOptions.None);
							bool flag = false;
							for (int j = 0; j < array.Length; j++)
							{
								if (array[j].Trim() == sdkCountry)
								{
									flag = true;
									break;
								}
							}
							if (flag)
							{
								list.Add(loginServersData);
							}
						}
					}
				}
				if (list.Count == 0)
				{
					for (int k = 0; k < loginServers.Count; k++)
					{
						ILoginServersData loginServersData2 = loginServers[k];
						if (loginServersData2.Region == "SEA")
						{
							list.Add(loginServersData2);
							break;
						}
					}
				}
				this.LoginServerData = list;
				return this.LoginServerData;
			}
			List<ILoginServersData> list2 = new List<ILoginServersData>();
			for (int l = 0; l < loginServers.Count; l++)
			{
				list2.Add(loginServers[l]);
			}
			this.LoginServerData = list2;
			return this.LoginServerData;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0003F694 File Offset: 0x0003D894
		public List<IHotFixNetworkDetectSelectData> GetLoginServersLayoutItemData()
		{
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			List<IHotFixNetworkDetectSelectData> list = new List<IHotFixNetworkDetectSelectData>();
			for (int i = 0; i < loginServersByClientRegion.Count; i++)
			{
				ILoginServersData loginServersData = loginServersByClientRegion[i];
				HotFixNetworkDetectSelectData item = new HotFixNetworkDetectSelectData
				{
					LoginServersData = loginServersData
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0003F6E0 File Offset: 0x0003D8E0
		public List<IHotFixNetworkDetectionLayoutItemData> GetNetworkDetectionLayoutItemData()
		{
			List<IHotFixNetworkDetectionLayoutItemData> list = new List<IHotFixNetworkDetectionLayoutItemData>();
			List<INetworkDetectionEntry> detectionDataList = LauncherNetworkDetectionModel.GetDetectionDataList();
			for (int i = 0; i < detectionDataList.Count; i++)
			{
				INetworkDetectionEntry entryData = detectionDataList[i];
				HotFixNetworkDetectionLayoutItemData item = new HotFixNetworkDetectionLayoutItemData
				{
					EntryData = entryData,
					Proceed = false
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0003F730 File Offset: 0x0003D930
		public bool NeedInterruptDetectionDoubleCheckTips()
		{
			return (double)((float)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.001f) - this.LastDoubleCheckTime >= 5.0;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0003F768 File Offset: 0x0003D968
		public void ConfirmInterruptDetection()
		{
			float num = (float)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.001f;
			this.LastDoubleCheckTime = (double)num;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0003F792 File Offset: 0x0003D992
		public void ResetInterruptDetectionCheckTime()
		{
			this.LastDoubleCheckTime = 0.0;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0003F7A4 File Offset: 0x0003D9A4
		public string GetFinalErrorCodeString(IReadOnlyList<IHotFixNetworkDetectionLayoutItemData> datas)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < datas.Count; i++)
			{
				IHotFixNetworkDetectionLayoutItemData hotFixNetworkDetectionLayoutItemData = datas[i];
				if (hotFixNetworkDetectionLayoutItemData.ErrorCodeText != null && hotFixNetworkDetectionLayoutItemData.ErrorCodeText != "")
				{
					list.Add(hotFixNetworkDetectionLayoutItemData.ErrorCodeText);
				}
			}
			return string.Join("\n", list);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0003F801 File Offset: 0x0003DA01
		public static HotFixNetworkDetectionModel Instance
		{
			get
			{
				if (HotFixNetworkDetectionModel._instance == null)
				{
					HotFixNetworkDetectionModel._instance = new HotFixNetworkDetectionModel();
					HotFixNetworkDetectionModel._instance.OnInit();
				}
				return HotFixNetworkDetectionModel._instance;
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0003F824 File Offset: 0x0003DA24
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0003F826 File Offset: 0x0003DA26
		public static void ResetStaticDefaultValue()
		{
			HotFixNetworkDetectionModel instance = HotFixNetworkDetectionModel._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotFixNetworkDetectionModel._instance = null;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0003F83F File Offset: 0x0003DA3F
		static HotFixNetworkDetectionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotFixNetworkDetectionModel.CreateStaticDefaultValue), new Action(HotFixNetworkDetectionModel.ResetStaticDefaultValue));
		}

		// Token: 0x040004DC RID: 1244
		private const string SEASERVER = "SEA";

		// Token: 0x040004DD RID: 1245
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ILoginServersData> LoginServerData;

		// Token: 0x040004DE RID: 1246
		[Nullable(2)]
		public ILoginServersData CurrentUiSelectSeverData;

		// Token: 0x040004DF RID: 1247
		[Nullable(2)]
		public ILoginServersData CurrentSelectServerData;

		// Token: 0x040004E0 RID: 1248
		private double LastDoubleCheckTime;

		// Token: 0x040004E1 RID: 1249
		[Nullable(2)]
		private static HotFixNetworkDetectionModel _instance;
	}
}
