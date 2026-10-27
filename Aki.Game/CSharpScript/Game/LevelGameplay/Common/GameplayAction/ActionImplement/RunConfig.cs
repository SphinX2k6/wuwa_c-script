using System;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F29 RID: 28457
	public class RunConfig : IRunConfig, IMoveConfig
	{
		// Token: 0x17009B0E RID: 39694
		// (get) Token: 0x060453D4 RID: 283604 RVA: 0x0112213D File Offset: 0x0112033D
		// (set) Token: 0x060453D5 RID: 283605 RVA: 0x01122145 File Offset: 0x01120345
		public float RotateSpeed { get; set; }

		// Token: 0x17009B0F RID: 39695
		// (get) Token: 0x060453D6 RID: 283606 RVA: 0x0112214E File Offset: 0x0112034E
		// (set) Token: 0x060453D7 RID: 283607 RVA: 0x01122156 File Offset: 0x01120356
		public float MoveSpeed { get; set; }
	}
}
