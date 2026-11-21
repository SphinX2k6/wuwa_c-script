using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02003663 RID: 13923
	[RequiredMember]
	public class RollbackCapture : IRollbackCapture
	{
		// Token: 0x060241C1 RID: 147905 RVA: 0x00A389BF File Offset: 0x00A36BBF
		public void Restore()
		{
			this.RestoreAction();
		}

		// Token: 0x060241C2 RID: 147906 RVA: 0x00A389CC File Offset: 0x00A36BCC
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RollbackCapture()
		{
		}

		// Token: 0x0401422F RID: 82479
		[Nullable(1)]
		[RequiredMember]
		public Action RestoreAction;
	}
}
