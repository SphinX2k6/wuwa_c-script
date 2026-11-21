using System;
using System.Diagnostics;

namespace System.Buffers
{
	// Token: 0x02000378 RID: 888
	internal sealed class SearchValuesDebugView<T> where T : IEquatable<T>
	{
		// Token: 0x06003BDA RID: 15322 RVA: 0x000C72DE File Offset: 0x000C54DE
		public SearchValuesDebugView(SearchValues<T> values)
		{
			ArgumentNullException.ThrowIfNull(values, "values");
			this._values = values;
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x000C72F8 File Offset: 0x000C54F8
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Values
		{
			get
			{
				return this._values.GetValues();
			}
		}

		// Token: 0x04000C98 RID: 3224
		private readonly SearchValues<T> _values;
	}
}
