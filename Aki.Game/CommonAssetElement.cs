using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003310 RID: 13072
public class CommonAssetElement : AssetElement
{
	// Token: 0x0601C7A9 RID: 116649 RVA: 0x007FD42F File Offset: 0x007FB62F
	[NullableContext(2)]
	public CommonAssetElement(EntityAssetElement entityAssetElement) : base(entityAssetElement)
	{
	}

	// Token: 0x0601C7AA RID: 116650 RVA: 0x007FD438 File Offset: 0x007FB638
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

	// Token: 0x0601C7AB RID: 116651 RVA: 0x007FD478 File Offset: 0x007FB678
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

	// Token: 0x0601C7AC RID: 116652 RVA: 0x007FD600 File Offset: 0x007FB800
	public override void Clear()
	{
		PreloadModelNew.Instance.HoldPreloadObject.ClearCommonAsset();
		base.Clear();
	}
}
