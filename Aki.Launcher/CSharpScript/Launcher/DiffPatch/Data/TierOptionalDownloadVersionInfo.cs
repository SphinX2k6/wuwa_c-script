using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000235 RID: 565
	[NullableContext(1)]
	[Nullable(0)]
	public class TierOptionalDownloadVersionInfo : OptionalDownloadVersionInfo
	{
		// Token: 0x06000E5F RID: 3679 RVA: 0x000557CB File Offset: 0x000539CB
		public TierOptionalDownloadVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string packKey, string tierLabel) : base(packageVersion, remoteVersion, remoteManifestHash, packKey)
		{
			this.TierLabel = tierLabel;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000557E0 File Offset: 0x000539E0
		public override string GetResType()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(EResType.Optional.ToEnumString());
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(this.PackKey);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(this.TierLabel);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040008FA RID: 2298
		private readonly string TierLabel;
	}
}
