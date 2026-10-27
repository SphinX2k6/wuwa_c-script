using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.UiModel.Struct;
using UnrealEngine;

// Token: 0x020034C5 RID: 13509
public static class ModelUtil
{
	// Token: 0x0601D6DA RID: 120538 RVA: 0x008363AB File Offset: 0x008345AB
	[NullableContext(2)]
	public static SModelConfig GetModelConfig(int modelId)
	{
		return DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, modelId.ToString());
	}

	// Token: 0x0601D6DB RID: 120539 RVA: 0x008363BA File Offset: 0x008345BA
	[NullableContext(1)]
	[return: Nullable(2)]
	public static SUiModelRotateSetting GetUiModelRotateSettings(string rowName)
	{
		return DataTableUtil.GetDataTableRowFromName<SUiModelRotateSetting>(EDataTable.UiModelRotateSettings, rowName);
	}

	// Token: 0x0601D6DC RID: 120540 RVA: 0x008363C4 File Offset: 0x008345C4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static TSoftObjectPtr<USkeletalMesh> GetSoftSkeletalMesh(int modelId)
	{
		SModelConfig modelConfig = ModelUtil.GetModelConfig(modelId);
		if (modelConfig != null)
		{
			return modelConfig.网格体;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.ModelUtil;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "加载模型配置数据失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ModelId", modelId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}
}
