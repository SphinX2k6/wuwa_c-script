using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	// Token: 0x020003E2 RID: 994
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class CompressedStack : ISerializable
	{
		// Token: 0x06003FF3 RID: 16371 RVA: 0x00005ACC File Offset: 0x00003CCC
		private CompressedStack()
		{
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x000D5C81 File Offset: 0x000D3E81
		public static CompressedStack Capture()
		{
			return CompressedStack.GetCompressedStack();
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00007B62 File Offset: 0x00005D62
		public CompressedStack CreateCopy()
		{
			return this;
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x000D5C88 File Offset: 0x000D3E88
		public static CompressedStack GetCompressedStack()
		{
			return new CompressedStack();
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x000D5C8F File Offset: 0x000D3E8F
		public static void Run(CompressedStack compressedStack, ContextCallback callback, [Nullable(2)] object state)
		{
			ArgumentNullException.ThrowIfNull(compressedStack, "compressedStack");
			callback(state);
		}
	}
}
