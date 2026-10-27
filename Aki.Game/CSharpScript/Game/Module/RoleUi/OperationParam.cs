using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CE2 RID: 19682
	[NullableContext(2)]
	[Nullable(0)]
	internal class OperationParam
	{
		// Token: 0x06032CC7 RID: 208071 RVA: 0x00BD625B File Offset: 0x00BD445B
		public OperationParam(EOperationType operationType, object param = null)
		{
			this.OperationType = operationType;
			this.Param = param;
		}

		// Token: 0x0401B0BD RID: 110781
		public EOperationType OperationType;

		// Token: 0x0401B0BE RID: 110782
		public object Param;
	}
}
