using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C94 RID: 15508
	[NullableContext(2)]
	[Nullable(0)]
	internal class OperationParam
	{
		// Token: 0x06027A9C RID: 162460 RVA: 0x00B1B963 File Offset: 0x00B19B63
		public OperationParam(EOperationType operationType, object param = null)
		{
			this.OperationType = operationType;
			this.Param = param;
		}

		// Token: 0x04015A41 RID: 88641
		public EOperationType OperationType;

		// Token: 0x04015A42 RID: 88642
		public object Param;
	}
}
