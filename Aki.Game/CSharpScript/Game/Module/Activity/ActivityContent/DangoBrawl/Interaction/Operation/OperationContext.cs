using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x020057C1 RID: 22465
	public readonly struct OperationContext
	{
		// Token: 0x06037794 RID: 227220 RVA: 0x00F81301 File Offset: 0x00F7F501
		public OperationContext(int targetUid)
		{
			this.TargetUid = targetUid;
		}

		// Token: 0x0401D46F RID: 119919
		public readonly int TargetUid;
	}
}
