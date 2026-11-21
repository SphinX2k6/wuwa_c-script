using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020003F5 RID: 1013
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class LockRecursionException : Exception
	{
		// Token: 0x06004086 RID: 16518 RVA: 0x00045F72 File Offset: 0x00044172
		public LockRecursionException()
		{
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00045F7A File Offset: 0x0004417A
		public LockRecursionException(string message) : base(message)
		{
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00045F83 File Offset: 0x00044183
		public LockRecursionException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x0001E17C File Offset: 0x0001C37C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected LockRecursionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
