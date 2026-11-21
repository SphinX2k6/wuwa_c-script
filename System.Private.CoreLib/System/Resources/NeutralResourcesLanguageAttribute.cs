using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x0200027E RID: 638
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		// Token: 0x06002E44 RID: 11844 RVA: 0x00094AC6 File Offset: 0x00092CC6
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
			ArgumentNullException.ThrowIfNull(cultureName, "cultureName");
			this.CultureName = cultureName;
			this.Location = 0;
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00094AE7 File Offset: 0x00092CE7
		public NeutralResourcesLanguageAttribute(string cultureName, UltimateResourceFallbackLocation location)
		{
			ArgumentNullException.ThrowIfNull(cultureName, "cultureName");
			if (!Enum.IsDefined<UltimateResourceFallbackLocation>(location))
			{
				throw new ArgumentException(SR.Format(SR.Arg_InvalidNeutralResourcesLanguage_FallbackLoc, location));
			}
			this.CultureName = cultureName;
			this.Location = location;
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x00094B26 File Offset: 0x00092D26
		public string CultureName { get; }

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x00094B2E File Offset: 0x00092D2E
		public UltimateResourceFallbackLocation Location { get; }
	}
}
