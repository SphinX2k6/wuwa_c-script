using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002756 RID: 10070
[NullableContext(1)]
[Nullable(0)]
public class ReportConfig : Singleton
{
	// Token: 0x06014A81 RID: 84609 RVA: 0x00539DC5 File Offset: 0x00537FC5
	public IReadOnlyList<ReportPlayerInfo> GetReportConfigList()
	{
		return ConfigReportPlayerInfoAll.GetConfigList(true);
	}

	// Token: 0x06014A82 RID: 84610 RVA: 0x00539DCD File Offset: 0x00537FCD
	public BanInfo? GetBanInfoById(int id)
	{
		return ConfigBanInfoById.GetConfig(id, true);
	}

	// Token: 0x06014A83 RID: 84611 RVA: 0x00539DD6 File Offset: 0x00537FD6
	public BanInfo? GetBanInfoByTypeAndReason(int typeId, int reasonId)
	{
		return ConfigBanInfoByTypeAndReason.GetConfig(typeId, reasonId, true);
	}

	// Token: 0x17001B10 RID: 6928
	// (get) Token: 0x06014A84 RID: 84612 RVA: 0x00539DE0 File Offset: 0x00537FE0
	public static ReportConfig Instance
	{
		get
		{
			if (ReportConfig._instance == null)
			{
				ReportConfig._instance = new ReportConfig();
				ReportConfig._instance.OnInit();
			}
			return ReportConfig._instance;
		}
	}

	// Token: 0x06014A85 RID: 84613 RVA: 0x00539E03 File Offset: 0x00538003
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014A86 RID: 84614 RVA: 0x00539E05 File Offset: 0x00538005
	public static void ResetStaticDefaultValue()
	{
		ReportConfig instance = ReportConfig._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ReportConfig._instance = null;
	}

	// Token: 0x06014A87 RID: 84615 RVA: 0x00539E1E File Offset: 0x0053801E
	static ReportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ReportConfig.CreateStaticDefaultValue), new Action(ReportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009B48 RID: 39752
	[Nullable(2)]
	private static ReportConfig _instance;
}
