using System;
using CSharpScript.Core.Model;
using CSharpScript.Typing;
using UnrealEngine;

namespace CSharpScript.Game.Common
{
	// Token: 0x02006402 RID: 25602
	public class AsyncUtil
	{
		// Token: 0x0603E16A RID: 254314 RVA: 0x01203570 File Offset: 0x01201770
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

		// Token: 0x0603E16B RID: 254315 RVA: 0x012035F6 File Offset: 0x012017F6
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
