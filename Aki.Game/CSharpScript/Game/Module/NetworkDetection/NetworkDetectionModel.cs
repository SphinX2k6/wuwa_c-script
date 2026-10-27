using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02005361 RID: 21345
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class NetworkDetectionModel : ModelBase
	{
		// Token: 0x06036879 RID: 223353 RVA: 0x00CE9568 File Offset: 0x00CE7768
		public bool NeedInterruptDetectionDoubleCheckTips()
		{
			return (double)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.0010000000474974513 - this.LastDoubleCheckTime >= 5.0;
		}

		// Token: 0x0603687A RID: 223354 RVA: 0x00CE95A4 File Offset: 0x00CE77A4
		public void ConfirmInterruptDetection()
		{
			double lastDoubleCheckTime = (double)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 0.0010000000474974513;
			this.LastDoubleCheckTime = lastDoubleCheckTime;
		}

		// Token: 0x0603687B RID: 223355 RVA: 0x00CE95D1 File Offset: 0x00CE77D1
		public void ResetInterruptDetectionCheckTime()
		{
			this.LastDoubleCheckTime = 0.0;
		}

		// Token: 0x0603687C RID: 223356 RVA: 0x00CE95E4 File Offset: 0x00CE77E4
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

		// Token: 0x1700834D RID: 33613
		// (get) Token: 0x0603687D RID: 223357 RVA: 0x00CE9650 File Offset: 0x00CE7850
		public static NetworkDetectionModel Instance
		{
			get
			{
				return NetworkDetectionModel._Instance;
			}
		}

		// Token: 0x0603687E RID: 223358 RVA: 0x00CE9657 File Offset: 0x00CE7857
		public static NetworkDetectionModel GetOrCreateInstance()
		{
			if (NetworkDetectionModel._Instance == null)
			{
				NetworkDetectionModel.CreateInstance();
			}
			return NetworkDetectionModel._Instance;
		}

		// Token: 0x0603687F RID: 223359 RVA: 0x00CE966B File Offset: 0x00CE786B
		public static bool CreateInstance()
		{
			if (NetworkDetectionModel._Instance != null)
			{
				return true;
			}
			NetworkDetectionModel._Instance = new NetworkDetectionModel();
			return true;
		}

		// Token: 0x06036880 RID: 223360 RVA: 0x00CE9681 File Offset: 0x00CE7881
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036881 RID: 223361 RVA: 0x00CE9683 File Offset: 0x00CE7883
		public static void ResetStaticDefaultValue()
		{
			NetworkDetectionModel._Instance = null;
		}

		// Token: 0x06036882 RID: 223362 RVA: 0x00CE968B File Offset: 0x00CE788B
		static NetworkDetectionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NetworkDetectionModel.CreateStaticDefaultValue), new Action(NetworkDetectionModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CD59 RID: 118105
		[Nullable(2)]
		public ILoginServersData CurrentSelectServerData;

		// Token: 0x0401CD5A RID: 118106
		[Nullable(2)]
		public ILoginServersData CurrentUiSelectSeverData;

		// Token: 0x0401CD5B RID: 118107
		private double LastDoubleCheckTime;

		// Token: 0x0401CD5C RID: 118108
		[Nullable(2)]
		private static NetworkDetectionModel _Instance;
	}
}
