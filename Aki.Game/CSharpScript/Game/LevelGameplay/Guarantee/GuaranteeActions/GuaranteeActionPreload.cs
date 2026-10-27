using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E14 RID: 28180
	public class GuaranteeActionPreload : GuaranteeActionBase
	{
		// Token: 0x06044B6E RID: 281454 RVA: 0x010F5B2C File Offset: 0x010F3D2C
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params = null)
		{
			IGuaranteePreloadParams guaranteePreloadParams = @params as IGuaranteePreloadParams;
			if (guaranteePreloadParams == null)
			{
				return;
			}
			if (guaranteePreloadParams.Mp4Names != null)
			{
				VideoBpController.Instance.RemovePreload();
			}
		}
	}
}
