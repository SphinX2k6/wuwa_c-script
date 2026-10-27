using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006871 RID: 26737
	public readonly struct OperationContext
	{
		// Token: 0x06042C3D RID: 273469 RVA: 0x0103FE21 File Offset: 0x0103E021
		public OperationContext(int targetUid)
		{
			this.TargetUid = targetUid;
		}

		// Token: 0x04022C12 RID: 142354
		public readonly int TargetUid;
	}
}
