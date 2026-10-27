using System;
using CSharpScript.Core.Model;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Common
{
	// Token: 0x02007283 RID: 29315
	public class AsyncUtil
	{
		// Token: 0x06047DAA RID: 294314 RVA: 0x01262B60 File Offset: 0x01260D60
		public static void InitializeEnvironment()
		{
			if (!JsModelManager.Instance.HasInitialized)
			{
				JsModelManager.Instance.InitializeEnvironment();
				AiConfig.Instance.AsyncAiPerception = true;
				AiConfig.Instance.CppAsyncAiPerception = true;
				if (AiConfig.Instance.CppAsyncAiPerception)
				{
					TArray<FName> tarray = new TArray<FName>();
					foreach (FName value in EntityHelperConstants.GlobalEntityTypeQueryName)
					{
						tarray.Add(value);
					}
					FKuroAIPerceptionUtils.Initialize(tarray, 496, 15, 9, 0, 1, 2, 3, 16, 0, 0);
				}
			}
		}

		// Token: 0x06047DAB RID: 294315 RVA: 0x01262BE6 File Offset: 0x01260DE6
		public static void DestroyEnvironment()
		{
			if (JsModelManager.Instance.HasInitialized)
			{
				FKuroAIPerceptionUtils.Clear();
				JsModelManager.Instance.DestroyEnvironment();
			}
		}
	}
}
