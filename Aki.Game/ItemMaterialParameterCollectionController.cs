using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.RenderData;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002A01 RID: 10753
public class ItemMaterialParameterCollectionController
{
	// Token: 0x0601B042 RID: 110658 RVA: 0x00848C04 File Offset: 0x00846E04
	[NullableContext(1)]
	public static void UpdateMaterialParameterCollection(ItemMaterialControllerMPCData_C Data, UMaterialParameterCollection Collection)
	{
		if (!Collection.IsValid())
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.LJY, "缺失交互物着色器参数文件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (KeyValuePair<string, FLinearColor> keyValuePair in Data.Vector)
		{
			string text;
			FLinearColor flinearColor;
			keyValuePair.Deconstruct(out text, out flinearColor);
			string key = text;
			FLinearColor flinearColor2 = flinearColor;
			FName? dynamicFName = FNameUtil.GetDynamicFName(key);
			if (dynamicFName != null)
			{
				UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.GameInstance.GetWorld(), Collection, dynamicFName.Value, flinearColor2);
			}
		}
		foreach (KeyValuePair<string, float> keyValuePair2 in Data.Scalar)
		{
			string text;
			float num;
			keyValuePair2.Deconstruct(out text, out num);
			string key2 = text;
			float parameterValue = num;
			FName? dynamicFName2 = FNameUtil.GetDynamicFName(key2);
			if (dynamicFName2 != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), Collection, dynamicFName2.Value, parameterValue);
			}
		}
	}
}
