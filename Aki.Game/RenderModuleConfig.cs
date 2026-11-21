using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020029FA RID: 10746
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RenderModuleConfig : ConfigBase
{
	// Token: 0x0601AF5D RID: 110429 RVA: 0x00846A54 File Offset: 0x00844C54
	protected override bool OnInit()
	{
		this.InitLevelCustomPrimitiveData();
		return true;
	}

	// Token: 0x0601AF5E RID: 110430 RVA: 0x00846A5D File Offset: 0x00844C5D
	protected override bool OnClear()
	{
		Dictionary<int, LevelCustomPrimitiveData> levelCustomPrimitiveData = this.LevelCustomPrimitiveData;
		if (levelCustomPrimitiveData != null)
		{
			levelCustomPrimitiveData.Clear();
		}
		this.LevelCustomPrimitiveData = null;
		return true;
	}

	// Token: 0x0601AF5F RID: 110431 RVA: 0x00846A78 File Offset: 0x00844C78
	private void InitLevelCustomPrimitiveData()
	{
		this.LevelCustomPrimitiveData = new Dictionary<int, LevelCustomPrimitiveData>();
		IReadOnlyList<LevelCustomPrimitiveData> configList = ConfigLevelCustomPrimitiveDataAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (LevelCustomPrimitiveData value in configList)
			{
				this.LevelCustomPrimitiveData[value.PbDataId] = value;
			}
		}
	}

	// Token: 0x17002BBA RID: 11194
	// (get) Token: 0x0601AF60 RID: 110432 RVA: 0x00846AE4 File Offset: 0x00844CE4
	public static RenderModuleConfig Instance
	{
		get
		{
			return RenderModuleConfig._Instance;
		}
	}

	// Token: 0x0601AF61 RID: 110433 RVA: 0x00846AEB File Offset: 0x00844CEB
	public static RenderModuleConfig GetOrCreateInstance()
	{
		if (RenderModuleConfig._Instance == null)
		{
			RenderModuleConfig.CreateInstance();
		}
		return RenderModuleConfig._Instance;
	}

	// Token: 0x0601AF62 RID: 110434 RVA: 0x00846AFF File Offset: 0x00844CFF
	public static bool CreateInstance()
	{
		if (RenderModuleConfig._Instance != null)
		{
			return true;
		}
		RenderModuleConfig._Instance = new RenderModuleConfig();
		return true;
	}

	// Token: 0x0601AF63 RID: 110435 RVA: 0x00846B15 File Offset: 0x00844D15
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601AF64 RID: 110436 RVA: 0x00846B17 File Offset: 0x00844D17
	public static void ResetStaticDefaultValue()
	{
		RenderModuleConfig._Instance = null;
	}

	// Token: 0x0601AF65 RID: 110437 RVA: 0x00846B1F File Offset: 0x00844D1F
	static RenderModuleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RenderModuleConfig.CreateStaticDefaultValue), new Action(RenderModuleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400EA63 RID: 60003
	[Nullable(2)]
	public Dictionary<int, LevelCustomPrimitiveData> LevelCustomPrimitiveData;

	// Token: 0x0400EA64 RID: 60004
	[Nullable(2)]
	private static RenderModuleConfig _Instance;
}
