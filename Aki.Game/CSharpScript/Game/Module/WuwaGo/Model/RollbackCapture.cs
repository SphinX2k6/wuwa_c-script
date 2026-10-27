using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo.Model
{
	// Token: 0x02004732 RID: 18226
	[RequiredMember]
	public class RollbackCapture : IRollbackCapture
	{
		// Token: 0x0602F9F7 RID: 195063 RVA: 0x00B08B03 File Offset: 0x00B06D03
		public void Restore()
		{
			this.RestoreAction();
		}

		// Token: 0x0602F9F8 RID: 195064 RVA: 0x00B08B10 File Offset: 0x00B06D10
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RollbackCapture()
		{
		}

		// Token: 0x04019B7F RID: 105343
		[Nullable(1)]
		[RequiredMember]
		public Action RestoreAction;
	}
}
