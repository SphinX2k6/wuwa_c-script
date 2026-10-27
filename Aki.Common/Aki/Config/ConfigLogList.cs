using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Config
{
	// Token: 0x02000029 RID: 41
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ConfigLogList<[Nullable(2)] T> : LogList<T>
	{
		// Token: 0x06000103 RID: 259 RVA: 0x0000B5B2 File Offset: 0x000097B2
		public void SetHeaders(T[] headers)
		{
			this.Headers = headers;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000B5BB File Offset: 0x000097BB
		public new IEnumerator<T> GetEnumerator()
		{
			ConfigLogList<T>.<GetEnumerator>d__2 <GetEnumerator>d__ = new ConfigLogList<T>.<GetEnumerator>d__2(0);
			<GetEnumerator>d__.<>4__this = this;
			return <GetEnumerator>d__;
		}

		// Token: 0x04000238 RID: 568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private T[] Headers;
	}
}
