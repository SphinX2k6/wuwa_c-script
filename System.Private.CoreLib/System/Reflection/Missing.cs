using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x0200075C RID: 1884
	public sealed class Missing : ISerializable
	{
		// Token: 0x0600795D RID: 31069 RVA: 0x00005ACC File Offset: 0x00003CCC
		private Missing()
		{
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x0000ACEC File Offset: 0x00008EEC
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x040016C7 RID: 5831
		[Nullable(1)]
		public static readonly Missing Value = new Missing();
	}
}
