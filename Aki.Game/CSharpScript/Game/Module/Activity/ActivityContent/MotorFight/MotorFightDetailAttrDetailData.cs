using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200640D RID: 25613
	public class MotorFightDetailAttrDetailData : IMotorFightDetailAttrDetailData
	{
		// Token: 0x17009472 RID: 38002
		// (get) Token: 0x060406D6 RID: 263894 RVA: 0x00F95C1B File Offset: 0x00F93E1B
		// (set) Token: 0x060406D7 RID: 263895 RVA: 0x00F95C23 File Offset: 0x00F93E23
		public MotorFightAttrShow Config { get; set; }

		// Token: 0x17009473 RID: 38003
		// (get) Token: 0x060406D8 RID: 263896 RVA: 0x00F95C2C File Offset: 0x00F93E2C
		// (set) Token: 0x060406D9 RID: 263897 RVA: 0x00F95C34 File Offset: 0x00F93E34
		public EMotorFightAttrShowType Type { get; set; }
	}
}
