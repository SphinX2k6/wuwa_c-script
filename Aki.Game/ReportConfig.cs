using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001C41 RID: 7233
[NullableContext(1)]
[Nullable(0)]
public class ReportConfig : Singleton
{
	// Token: 0x06011F64 RID: 73572 RVA: 0x00548C59 File Offset: 0x00546E59
	public IReadOnlyList<ReportPlayerInfo> GetReportConfigList()
	{
		return ConfigReportPlayerInfoAll.GetConfigList(true);
	}

	// Token: 0x06011F65 RID: 73573 RVA: 0x00548C61 File Offset: 0x00546E61
	public BanInfo? GetBanInfoById(int id)
	{
		return ConfigBanInfoById.GetConfig(id, true);
	}

	// Token: 0x06011F66 RID: 73574 RVA: 0x00548C6A File Offset: 0x00546E6A
	public BanInfo? GetBanInfoByTypeAndReason(int typeId, int reasonId)
	{
		return ConfigBanInfoByTypeAndReason.GetConfig(typeId, reasonId, true);
	}

	// Token: 0x17001B49 RID: 6985
	// (get) Token: 0x06011F67 RID: 73575 RVA: 0x00548C74 File Offset: 0x00546E74
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

	// Token: 0x06011F68 RID: 73576 RVA: 0x00548C97 File Offset: 0x00546E97
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011F69 RID: 73577 RVA: 0x00548C99 File Offset: 0x00546E99
	public static void ResetStaticDefaultValue()
	{
		ReportConfig instance = ReportConfig._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ReportConfig._instance = null;
	}

	// Token: 0x06011F6A RID: 73578 RVA: 0x00548CB2 File Offset: 0x00546EB2
	static ReportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ReportConfig.CreateStaticDefaultValue), new Action(ReportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009CA1 RID: 40097
	[Nullable(2)]
	private static ReportConfig _instance;
}
