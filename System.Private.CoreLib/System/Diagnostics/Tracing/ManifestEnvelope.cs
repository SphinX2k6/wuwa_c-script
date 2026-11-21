using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000904 RID: 2308
	internal struct ManifestEnvelope
	{
		// Token: 0x04002051 RID: 8273
		public ManifestEnvelope.ManifestFormats Format;

		// Token: 0x04002052 RID: 8274
		public byte MajorVersion;

		// Token: 0x04002053 RID: 8275
		public byte MinorVersion;

		// Token: 0x04002054 RID: 8276
		public byte Magic;

		// Token: 0x04002055 RID: 8277
		public ushort TotalChunks;

		// Token: 0x04002056 RID: 8278
		public ushort ChunkNumber;

		// Token: 0x02000905 RID: 2309
		public enum ManifestFormats : byte
		{
			// Token: 0x04002058 RID: 8280
			SimpleXmlFormat = 1
		}
	}
}
