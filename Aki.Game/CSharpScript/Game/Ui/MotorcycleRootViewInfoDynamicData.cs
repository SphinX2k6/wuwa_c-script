using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003574 RID: 13684
	public class MotorcycleRootViewInfoDynamicData : ViewInfoDynamicData, IViewInfoDynamicSceneData
	{
		// Token: 0x06022DE3 RID: 142819 RVA: 0x009E6EAC File Offset: 0x009E50AC
		[NullableContext(2)]
		public string GetSceneId()
		{
			int currentSceneId = MotorcycleDiyModel.Instance.GetCurrentSceneId();
			MotorScene? motorSceneConfig = MotorDiyConfig.Instance.GetMotorSceneConfig(currentSceneId);
			if (motorSceneConfig != null)
			{
				return motorSceneConfig.Value.SceneId;
			}
			return null;
		}
	}
}
