using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x0200051B RID: 1307
	[NullableContext(2)]
	public interface IDeserializationCallback
	{
		// Token: 0x0600487B RID: 18555
		void OnDeserialization(object sender);
	}
}
