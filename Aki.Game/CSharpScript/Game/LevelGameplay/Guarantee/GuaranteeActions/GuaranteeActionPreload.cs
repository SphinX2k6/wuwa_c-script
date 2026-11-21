using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F94 RID: 24468
	public class GuaranteeActionPreload : GuaranteeActionBase
	{
		// Token: 0x0603ACD5 RID: 240853 RVA: 0x0109FF60 File Offset: 0x0109E160
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
