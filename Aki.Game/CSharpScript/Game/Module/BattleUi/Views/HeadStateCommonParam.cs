using System;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D46 RID: 23878
	public class HeadStateCommonParam
	{
		// Token: 0x0603C96E RID: 248174 RVA: 0x00E8A2E4 File Offset: 0x00E884E4
		public void Init()
		{
			this.OutMonsterHalfHeight = ConfigCommonParamById.GetFloatConfig("HeadStateOutMonsterHeight").Value / 2f;
			this.OutTopMargin = ConfigCommonParamById.GetFloatConfig("HeadStateOutTopMargin").Value;
			this.OutHorizontalMargin = ConfigCommonParamById.GetFloatConfig("HeadStateOutHorizontalMargin").Value;
		}

		// Token: 0x0401F8DD RID: 129245
		public float OutMonsterHalfHeight;

		// Token: 0x0401F8DE RID: 129246
		public float OutTopMargin;

		// Token: 0x0401F8DF RID: 129247
		public float OutHorizontalMargin;

		// Token: 0x0401F8E0 RID: 129248
		public bool DrawHeadStateSocket;
	}
}
