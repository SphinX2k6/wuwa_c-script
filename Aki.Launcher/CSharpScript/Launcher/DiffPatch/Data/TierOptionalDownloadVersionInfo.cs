using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200023A RID: 570
	[NullableContext(1)]
	[Nullable(0)]
	public class TierOptionalDownloadVersionInfo : OptionalDownloadVersionInfo
	{
		// Token: 0x06000EA0 RID: 3744 RVA: 0x000582D3 File Offset: 0x000564D3
		public TierOptionalDownloadVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string packKey, string tierLabel) : base(packageVersion, remoteVersion, remoteManifestHash, packKey)
		{
			this.TierLabel = tierLabel;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000582E8 File Offset: 0x000564E8
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

		// Token: 0x0400093C RID: 2364
		private readonly string TierLabel;
	}
}
