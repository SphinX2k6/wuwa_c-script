using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000239 RID: 569
	[NullableContext(1)]
	[Nullable(0)]
	public class TierLanguageVersionInfo : LanguageVersionInfo
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x0005825C File Offset: 0x0005645C
		public TierLanguageVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string languageCode, string tierLabel) : base(packageVersion, remoteVersion, remoteManifestHash, languageCode)
		{
			this.TierLabel = tierLabel;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00058274 File Offset: 0x00056474
		public override string GetResType()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(EResType.Lang.ToEnumString());
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(this.LanguageCode);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(this.TierLabel);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000582D0 File Offset: 0x000564D0
		protected override bool ClearUseRecord()
		{
			return true;
		}

		// Token: 0x0400093B RID: 2363
		private readonly string TierLabel;
	}
}
