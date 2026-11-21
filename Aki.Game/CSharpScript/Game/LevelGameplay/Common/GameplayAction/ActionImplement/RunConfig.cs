using System;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060AA RID: 24746
	public class RunConfig : IRunConfig, IMoveConfig
	{
		// Token: 0x1700704D RID: 28749
		// (get) Token: 0x0603B582 RID: 243074 RVA: 0x010CC0E9 File Offset: 0x010CA2E9
		// (set) Token: 0x0603B583 RID: 243075 RVA: 0x010CC0F1 File Offset: 0x010CA2F1
		public float RotateSpeed { get; set; }

		// Token: 0x1700704E RID: 28750
		// (get) Token: 0x0603B584 RID: 243076 RVA: 0x010CC0FA File Offset: 0x010CA2FA
		// (set) Token: 0x0603B585 RID: 243077 RVA: 0x010CC102 File Offset: 0x010CA302
		public float MoveSpeed { get; set; }
	}
}
