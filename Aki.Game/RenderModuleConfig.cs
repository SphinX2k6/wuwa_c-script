using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02003486 RID: 13446
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RenderModuleConfig : ConfigBase
{
	// Token: 0x0601D255 RID: 119381 RVA: 0x0081F724 File Offset: 0x0081D924
	protected override bool OnInit()
	{
		this.InitLevelCustomPrimitiveData();
		return true;
	}

	// Token: 0x0601D256 RID: 119382 RVA: 0x0081F72D File Offset: 0x0081D92D
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

	// Token: 0x0601D257 RID: 119383 RVA: 0x0081F748 File Offset: 0x0081D948
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

	// Token: 0x1700281B RID: 10267
	// (get) Token: 0x0601D258 RID: 119384 RVA: 0x0081F7B4 File Offset: 0x0081D9B4
	public static RenderModuleConfig Instance
	{
		get
		{
			return RenderModuleConfig._Instance;
		}
	}

	// Token: 0x0601D259 RID: 119385 RVA: 0x0081F7BB File Offset: 0x0081D9BB
	public static RenderModuleConfig GetOrCreateInstance()
	{
		if (RenderModuleConfig._Instance == null)
		{
			RenderModuleConfig.CreateInstance();
		}
		return RenderModuleConfig._Instance;
	}

	// Token: 0x0601D25A RID: 119386 RVA: 0x0081F7CF File Offset: 0x0081D9CF
	public static bool CreateInstance()
	{
		if (RenderModuleConfig._Instance != null)
		{
			return true;
		}
		RenderModuleConfig._Instance = new RenderModuleConfig();
		return true;
	}

	// Token: 0x0601D25B RID: 119387 RVA: 0x0081F7E5 File Offset: 0x0081D9E5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D25C RID: 119388 RVA: 0x0081F7E7 File Offset: 0x0081D9E7
	public static void ResetStaticDefaultValue()
	{
		RenderModuleConfig._Instance = null;
	}

	// Token: 0x0601D25D RID: 119389 RVA: 0x0081F7EF File Offset: 0x0081D9EF
	static RenderModuleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RenderModuleConfig.CreateStaticDefaultValue), new Action(RenderModuleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E5AB RID: 58795
	[Nullable(2)]
	public Dictionary<int, LevelCustomPrimitiveData> LevelCustomPrimitiveData;

	// Token: 0x0400E5AC RID: 58796
	[Nullable(2)]
	private static RenderModuleConfig _Instance;
}
