using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.NetworkDetection;
using CSharpScript.Launcher.Platform.PlatformSdk;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F8 RID: 248
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectionModel : Singleton
	{
		// Token: 0x0600081C RID: 2076 RVA: 0x0003D13C File Offset: 0x0003B33C
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

		// Token: 0x0600081D RID: 2077 RVA: 0x0003D2F4 File Offset: 0x0003B4F4
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

		// Token: 0x0600081E RID: 2078 RVA: 0x0003D340 File Offset: 0x0003B540
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

		// Token: 0x0600081F RID: 2079 RVA: 0x0003D390 File Offset: 0x0003B590
		public bool NeedInterruptDetectionDoubleCheckTips()
		{
			return (double)((float)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.001f) - this.LastDoubleCheckTime >= 5.0;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0003D3C8 File Offset: 0x0003B5C8
		public void ConfirmInterruptDetection()
		{
			float num = (float)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.001f;
			this.LastDoubleCheckTime = (double)num;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0003D3F2 File Offset: 0x0003B5F2
		public void ResetInterruptDetectionCheckTime()
		{
			this.LastDoubleCheckTime = 0.0;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0003D404 File Offset: 0x0003B604
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0003D461 File Offset: 0x0003B661
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

		// Token: 0x06000824 RID: 2084 RVA: 0x0003D484 File Offset: 0x0003B684
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0003D486 File Offset: 0x0003B686
		public static void ResetStaticDefaultValue()
		{
			HotFixNetworkDetectionModel instance = HotFixNetworkDetectionModel._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HotFixNetworkDetectionModel._instance = null;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0003D49F File Offset: 0x0003B69F
		static HotFixNetworkDetectionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotFixNetworkDetectionModel.CreateStaticDefaultValue), new Action(HotFixNetworkDetectionModel.ResetStaticDefaultValue));
		}

		// Token: 0x040004A1 RID: 1185
		private const string SEASERVER = "SEA";

		// Token: 0x040004A2 RID: 1186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ILoginServersData> LoginServerData;

		// Token: 0x040004A3 RID: 1187
		[Nullable(2)]
		public ILoginServersData CurrentUiSelectSeverData;

		// Token: 0x040004A4 RID: 1188
		[Nullable(2)]
		public ILoginServersData CurrentSelectServerData;

		// Token: 0x040004A5 RID: 1189
		private double LastDoubleCheckTime;

		// Token: 0x040004A6 RID: 1190
		[Nullable(2)]
		private static HotFixNetworkDetectionModel _instance;
	}
}
