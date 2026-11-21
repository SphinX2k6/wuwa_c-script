using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Collections
{
	// Token: 0x02000979 RID: 2425
	[NullableContext(1)]
	[Guid("496B0ABE-CDEE-11d3-88E8-00902754C43A")]
	[ComVisible(true)]
	public interface IEnumerable
	{
		// Token: 0x0600908C RID: 37004
		IEnumerator GetEnumerator();
	}
}
