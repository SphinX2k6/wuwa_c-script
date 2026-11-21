using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003854 RID: 14420
	[NullableContext(2)]
	[Nullable(0)]
	public class OperationParam<T>
	{
		// Token: 0x0602574D RID: 153421 RVA: 0x00A8D342 File Offset: 0x00A8B542
		public OperationParam([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<T> data = null, bool keepContentPosition = false, Action callBack = null, bool playGridAnim = false)
		{
		}

		// Token: 0x04014B63 RID: 84835
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<T> Data = data;

		// Token: 0x04014B64 RID: 84836
		public bool KeepContentPosition = keepContentPosition;

		// Token: 0x04014B65 RID: 84837
		public Action CallBack = callBack;

		// Token: 0x04014B66 RID: 84838
		public bool PlayGridAnim = playGridAnim;
	}
}
