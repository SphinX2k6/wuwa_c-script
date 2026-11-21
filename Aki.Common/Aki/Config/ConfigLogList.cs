using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Config
{
	// Token: 0x0200002A RID: 42
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ConfigLogList<[Nullable(2)] T> : LogList<T>
	{
		// Token: 0x06000170 RID: 368 RVA: 0x0000ED7E File Offset: 0x0000CF7E
		public void SetHeaders(T[] headers)
		{
			this.Headers = headers;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000ED87 File Offset: 0x0000CF87
		public new IEnumerator<T> GetEnumerator()
		{
			ConfigLogList<T>.<GetEnumerator>d__2 <GetEnumerator>d__ = new ConfigLogList<T>.<GetEnumerator>d__2(0);
			<GetEnumerator>d__.<>4__this = this;
			return <GetEnumerator>d__;
		}

		// Token: 0x0400023D RID: 573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private T[] Headers;
	}
}
