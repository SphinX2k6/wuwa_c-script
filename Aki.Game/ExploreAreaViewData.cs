using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AB6 RID: 6838
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaViewData
{
	// Token: 0x170010BE RID: 4286
	// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x002E294D File Offset: 0x002E0B4D
	// (set) Token: 0x0600CA9F RID: 51871 RVA: 0x002E2955 File Offset: 0x002E0B55
	public int CountryId { get; private set; }

	// Token: 0x170010BF RID: 4287
	// (get) Token: 0x0600CAA0 RID: 51872 RVA: 0x002E295E File Offset: 0x002E0B5E
	// (set) Token: 0x0600CAA1 RID: 51873 RVA: 0x002E2966 File Offset: 0x002E0B66
	public int AreaId { get; private set; }

	// Token: 0x170010C0 RID: 4288
	// (get) Token: 0x0600CAA2 RID: 51874 RVA: 0x002E296F File Offset: 0x002E0B6F
	// (set) Token: 0x0600CAA3 RID: 51875 RVA: 0x002E2977 File Offset: 0x002E0B77
	public string NameId { get; private set; } = "";

	// Token: 0x170010C1 RID: 4289
	// (get) Token: 0x0600CAA4 RID: 51876 RVA: 0x002E2980 File Offset: 0x002E0B80
	// (set) Token: 0x0600CAA5 RID: 51877 RVA: 0x002E2988 File Offset: 0x002E0B88
	public bool IsCountry { get; private set; }

	// Token: 0x170010C2 RID: 4290
	// (get) Token: 0x0600CAA6 RID: 51878 RVA: 0x002E2991 File Offset: 0x002E0B91
	// (set) Token: 0x0600CAA7 RID: 51879 RVA: 0x002E2999 File Offset: 0x002E0B99
	public bool IsLock { get; private set; } = true;

	// Token: 0x170010C3 RID: 4291
	// (get) Token: 0x0600CAA8 RID: 51880 RVA: 0x002E29A2 File Offset: 0x002E0BA2
	// (set) Token: 0x0600CAA9 RID: 51881 RVA: 0x002E29AA File Offset: 0x002E0BAA
	public float Progress { get; private set; }

	// Token: 0x0600CAAA RID: 51882 RVA: 0x002E29B3 File Offset: 0x002E0BB3
	public void RefreshCountry(int countryId, string nameId, bool isLock)
	{
		this.CountryId = countryId;
		this.AreaId = 0;
		this.NameId = nameId;
		this.IsLock = isLock;
		this.Progress = 0f;
		this.IsCountry = true;
	}

	// Token: 0x0600CAAB RID: 51883 RVA: 0x002E29E3 File Offset: 0x002E0BE3
	public void RefreshArea(int areaId, string nameId, float progress)
	{
		this.CountryId = 0;
		this.AreaId = areaId;
		this.NameId = nameId;
		this.IsLock = false;
		this.Progress = progress;
		this.IsCountry = false;
	}
}
