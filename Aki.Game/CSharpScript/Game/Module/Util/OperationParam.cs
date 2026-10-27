using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048DD RID: 18653
	[NullableContext(2)]
	[Nullable(0)]
	public class OperationParam<T>
	{
		// Token: 0x06030C20 RID: 199712 RVA: 0x00B524D2 File Offset: 0x00B506D2
		public OperationParam([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<T> data = null, bool keepContentPosition = false, Action callBack = null, bool playGridAnim = false)
		{
		}

		// Token: 0x0401A2F0 RID: 107248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<T> Data = data;

		// Token: 0x0401A2F1 RID: 107249
		public bool KeepContentPosition = keepContentPosition;

		// Token: 0x0401A2F2 RID: 107250
		public Action CallBack = callBack;

		// Token: 0x0401A2F3 RID: 107251
		public bool PlayGridAnim = playGridAnim;
	}
}
