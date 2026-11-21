using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.UiModel.Struct;
using UnrealEngine;

// Token: 0x02002A39 RID: 10809
public static class ModelUtil
{
	// Token: 0x0601B3D9 RID: 111577 RVA: 0x0085D853 File Offset: 0x0085BA53
	[NullableContext(2)]
	public static SModelConfig GetModelConfig(int modelId)
	{
		return DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, modelId.ToString());
	}

	// Token: 0x0601B3DA RID: 111578 RVA: 0x0085D862 File Offset: 0x0085BA62
	[NullableContext(1)]
	[return: Nullable(2)]
	public static SUiModelRotateSetting GetUiModelRotateSettings(string rowName)
	{
		return DataTableUtil.GetDataTableRowFromName<SUiModelRotateSetting>(EDataTable.UiModelRotateSettings, rowName);
	}

	// Token: 0x0601B3DB RID: 111579 RVA: 0x0085D86C File Offset: 0x0085BA6C
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
