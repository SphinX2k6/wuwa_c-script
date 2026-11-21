using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002882 RID: 10370
public class CommonAssetElement : AssetElement
{
	// Token: 0x0601A4A2 RID: 107682 RVA: 0x0082399B File Offset: 0x00821B9B
	[NullableContext(2)]
	public CommonAssetElement(EntityAssetElement entityAssetElement) : base(entityAssetElement)
	{
	}

	// Token: 0x0601A4A3 RID: 107683 RVA: 0x008239A4 File Offset: 0x00821BA4
	[NullableContext(1)]
	public override bool AddObject(string path, UObject @object)
	{
		if (!base.AddObject(path, @object))
		{
			return false;
		}
		this.AssetForIndexMap[path] = PreloadModelNew.Instance.HoldPreloadObject.CommonAssets.Num();
		PreloadModelNew.Instance.HoldPreloadObject.AddCommonAsset(@object);
		return true;
	}

	// Token: 0x0601A4A4 RID: 107684 RVA: 0x008239E4 File Offset: 0x00821BE4
	public override void PrintDebugInfo()
	{
		TArray<UObject> commonAssets = PreloadModelNew.Instance.HoldPreloadObject.CommonAssets;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral("\n预加载的公共资源列表如下(数量:");
		defaultInterpolatedStringHandler.AppendFormatted<int>(commonAssets.Num());
		defaultInterpolatedStringHandler.AppendLiteral("):\n");
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		foreach (KeyValuePair<string, int> keyValuePair in this.AssetForIndexMap)
		{
			dictionary[keyValuePair.Value] = keyValuePair.Key;
		}
		for (int i = 0; i < commonAssets.Num(); i++)
		{
			UObject uobject = commonAssets.Get(i);
			string valueOrDefault = dictionary.GetValueOrDefault(i);
			string str = text;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 4);
			defaultInterpolatedStringHandler.AppendLiteral("    索引:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			defaultInterpolatedStringHandler.AppendLiteral(", Path:");
			defaultInterpolatedStringHandler.AppendFormatted(valueOrDefault);
			defaultInterpolatedStringHandler.AppendLiteral(", IsValid:");
			defaultInterpolatedStringHandler.AppendFormatted<bool?>((uobject != null) ? new bool?(uobject.IsValid()) : null);
			defaultInterpolatedStringHandler.AppendLiteral(", Name:");
			defaultInterpolatedStringHandler.AppendFormatted((uobject != null && uobject.IsValid()) ? uobject.GetName() : null);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	// Token: 0x0601A4A5 RID: 107685 RVA: 0x00823B6C File Offset: 0x00821D6C
	public override void Clear()
	{
		PreloadModelNew.Instance.HoldPreloadObject.ClearCommonAsset();
		base.Clear();
	}
}
