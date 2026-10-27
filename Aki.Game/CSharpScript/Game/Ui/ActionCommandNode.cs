using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004619 RID: 17945
	internal class ActionCommandNode : IActionCommandNode
	{
		// Token: 0x170075C3 RID: 30147
		// (get) Token: 0x0602E3D4 RID: 189396 RVA: 0x00AB15F4 File Offset: 0x00AAF7F4
		// (set) Token: 0x0602E3D5 RID: 189397 RVA: 0x00AB15FC File Offset: 0x00AAF7FC
		public EActionCommandType ActionCommand { get; set; }

		// Token: 0x170075C4 RID: 30148
		// (get) Token: 0x0602E3D6 RID: 189398 RVA: 0x00AB1605 File Offset: 0x00AAF805
		// (set) Token: 0x0602E3D7 RID: 189399 RVA: 0x00AB160D File Offset: 0x00AAF80D
		public bool Processed { get; set; }
	}
}
