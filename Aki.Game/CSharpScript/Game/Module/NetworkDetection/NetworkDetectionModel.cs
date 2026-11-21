using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02004344 RID: 17220
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class NetworkDetectionModel : ModelBase
	{
		// Token: 0x0602B7BF RID: 178111 RVA: 0x00C383F0 File Offset: 0x00C365F0
		public bool NeedInterruptDetectionDoubleCheckTips()
		{
			return (double)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.0010000000474974513 - this.LastDoubleCheckTime >= 5.0;
		}

		// Token: 0x0602B7C0 RID: 178112 RVA: 0x00C3842C File Offset: 0x00C3662C
		public void ConfirmInterruptDetection()
		{
			double lastDoubleCheckTime = (double)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.0010000000474974513;
			this.LastDoubleCheckTime = lastDoubleCheckTime;
		}

		// Token: 0x0602B7C1 RID: 178113 RVA: 0x00C38459 File Offset: 0x00C36659
		public void ResetInterruptDetectionCheckTime()
		{
			this.LastDoubleCheckTime = 0.0;
		}

		// Token: 0x0602B7C2 RID: 178114 RVA: 0x00C3846C File Offset: 0x00C3666C
		public string GetFinalErrorCodeString(IReadOnlyList<INetworkDetectionItemData> datas)
		{
			List<string> list = new List<string>();
			foreach (INetworkDetectionItemData networkDetectionItemData in datas)
			{
				if (!string.IsNullOrEmpty(networkDetectionItemData.ErrorCodeText))
				{
					list.Add(networkDetectionItemData.ErrorCodeText);
				}
			}
			return string.Join("\n", list);
		}

		// Token: 0x17005719 RID: 22297
		// (get) Token: 0x0602B7C3 RID: 178115 RVA: 0x00C384D8 File Offset: 0x00C366D8
		public static NetworkDetectionModel Instance
		{
			get
			{
				return NetworkDetectionModel._Instance;
			}
		}

		// Token: 0x0602B7C4 RID: 178116 RVA: 0x00C384DF File Offset: 0x00C366DF
		public static NetworkDetectionModel GetOrCreateInstance()
		{
			if (NetworkDetectionModel._Instance == null)
			{
				NetworkDetectionModel.CreateInstance();
			}
			return NetworkDetectionModel._Instance;
		}

		// Token: 0x0602B7C5 RID: 178117 RVA: 0x00C384F3 File Offset: 0x00C366F3
		public static bool CreateInstance()
		{
			if (NetworkDetectionModel._Instance != null)
			{
				return true;
			}
			NetworkDetectionModel._Instance = new NetworkDetectionModel();
			return true;
		}

		// Token: 0x0602B7C6 RID: 178118 RVA: 0x00C38509 File Offset: 0x00C36709
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B7C7 RID: 178119 RVA: 0x00C3850B File Offset: 0x00C3670B
		public static void ResetStaticDefaultValue()
		{
			NetworkDetectionModel._Instance = null;
		}

		// Token: 0x0602B7C8 RID: 178120 RVA: 0x00C38513 File Offset: 0x00C36713
		static NetworkDetectionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NetworkDetectionModel.CreateStaticDefaultValue), new Action(NetworkDetectionModel.ResetStaticDefaultValue));
		}

		// Token: 0x040177ED RID: 96237
		[Nullable(2)]
		public ILoginServersData CurrentSelectServerData;

		// Token: 0x040177EE RID: 96238
		[Nullable(2)]
		public ILoginServersData CurrentUiSelectSeverData;

		// Token: 0x040177EF RID: 96239
		private double LastDoubleCheckTime;

		// Token: 0x040177F0 RID: 96240
		[Nullable(2)]
		private static NetworkDetectionModel _Instance;
	}
}
