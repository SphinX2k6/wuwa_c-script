using System;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D28 RID: 19752
	public class HeadStateCommonParam
	{
		// Token: 0x060318C7 RID: 202951 RVA: 0x00DDAA94 File Offset: 0x00DD8C94
		public void Init()
		{
			this.OutMonsterHalfHeight = ConfigCommonParamById.GetFloatConfig("HeadStateOutMonsterHeight").Value / 2f;
			this.OutTopMargin = ConfigCommonParamById.GetFloatConfig("HeadStateOutTopMargin").Value;
			this.OutHorizontalMargin = ConfigCommonParamById.GetFloatConfig("HeadStateOutHorizontalMargin").Value;
		}

		// Token: 0x0401A396 RID: 107414
		public float OutMonsterHalfHeight;

		// Token: 0x0401A397 RID: 107415
		public float OutTopMargin;

		// Token: 0x0401A398 RID: 107416
		public float OutHorizontalMargin;

		// Token: 0x0401A399 RID: 107417
		public bool DrawHeadStateSocket;
	}
}
