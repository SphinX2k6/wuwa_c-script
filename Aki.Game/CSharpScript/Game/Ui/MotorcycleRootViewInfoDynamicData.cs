using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004643 RID: 17987
	public class MotorcycleRootViewInfoDynamicData : ViewInfoDynamicData, IViewInfoDynamicSceneData
	{
		// Token: 0x0602E699 RID: 190105 RVA: 0x00AB987C File Offset: 0x00AB7A7C
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
