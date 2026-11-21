using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200538B RID: 21387
	public class MotorFightDetailAttrDetailData : IMotorFightDetailAttrDetailData
	{
		// Token: 0x170067D4 RID: 26580
		// (get) Token: 0x06035397 RID: 218007 RVA: 0x00EDCBBB File Offset: 0x00EDADBB
		// (set) Token: 0x06035398 RID: 218008 RVA: 0x00EDCBC3 File Offset: 0x00EDADC3
		public MotorFightAttrShow Config { get; set; }

		// Token: 0x170067D5 RID: 26581
		// (get) Token: 0x06035399 RID: 218009 RVA: 0x00EDCBCC File Offset: 0x00EDADCC
		// (set) Token: 0x0603539A RID: 218010 RVA: 0x00EDCBD4 File Offset: 0x00EDADD4
		public EMotorFightAttrShowType Type { get; set; }
	}
}
