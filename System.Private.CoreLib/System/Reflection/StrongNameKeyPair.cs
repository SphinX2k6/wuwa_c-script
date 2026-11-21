using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	// Token: 0x02000781 RID: 1921
	[NullableContext(1)]
	[Nullable(0)]
	[Obsolete("Strong name signing is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0017", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public class StrongNameKeyPair : IDeserializationCallback, ISerializable
	{
		// Token: 0x06007B06 RID: 31494 RVA: 0x001220D0 File Offset: 0x001202D0
		public StrongNameKeyPair(FileStream keyPairFile)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_StrongNameSigning);
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x001220D0 File Offset: 0x001202D0
		public StrongNameKeyPair(byte[] keyPairArray)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_StrongNameSigning);
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x001220E2 File Offset: 0x001202E2
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected StrongNameKeyPair(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x001220D0 File Offset: 0x001202D0
		public StrongNameKeyPair(string keyPairContainer)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_StrongNameSigning);
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06007B0A RID: 31498 RVA: 0x00117350 File Offset: 0x00115550
		public byte[] PublicKey
		{
			get
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_StrongNameSigning);
			}
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x0000ACEC File Offset: 0x00008EEC
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x0000ACEC File Offset: 0x00008EEC
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			throw new PlatformNotSupportedException();
		}
	}
}
