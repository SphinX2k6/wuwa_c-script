using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000234 RID: 564
	[NullableContext(1)]
	[Nullable(0)]
	public class TierLanguageVersionInfo : LanguageVersionInfo
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x00055754 File Offset: 0x00053954
		public TierLanguageVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string languageCode, string tierLabel) : base(packageVersion, remoteVersion, remoteManifestHash, languageCode)
		{
			this.TierLabel = tierLabel;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0005576C File Offset: 0x0005396C
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

		// Token: 0x06000E5E RID: 3678 RVA: 0x000557C8 File Offset: 0x000539C8
		protected override bool ClearUseRecord()
		{
			return true;
		}

		// Token: 0x040008F9 RID: 2297
		private readonly string TierLabel;
	}
}
