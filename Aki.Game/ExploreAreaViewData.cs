using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F75 RID: 3957
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaViewData
{
	// Token: 0x170010E3 RID: 4323
	// (get) Token: 0x06009EAF RID: 40623 RVA: 0x002EDA9D File Offset: 0x002EBC9D
	// (set) Token: 0x06009EB0 RID: 40624 RVA: 0x002EDAA5 File Offset: 0x002EBCA5
	public int CountryId { get; private set; }

	// Token: 0x170010E4 RID: 4324
	// (get) Token: 0x06009EB1 RID: 40625 RVA: 0x002EDAAE File Offset: 0x002EBCAE
	// (set) Token: 0x06009EB2 RID: 40626 RVA: 0x002EDAB6 File Offset: 0x002EBCB6
	public int AreaId { get; private set; }

	// Token: 0x170010E5 RID: 4325
	// (get) Token: 0x06009EB3 RID: 40627 RVA: 0x002EDABF File Offset: 0x002EBCBF
	// (set) Token: 0x06009EB4 RID: 40628 RVA: 0x002EDAC7 File Offset: 0x002EBCC7
	public string NameId { get; private set; } = "";

	// Token: 0x170010E6 RID: 4326
	// (get) Token: 0x06009EB5 RID: 40629 RVA: 0x002EDAD0 File Offset: 0x002EBCD0
	// (set) Token: 0x06009EB6 RID: 40630 RVA: 0x002EDAD8 File Offset: 0x002EBCD8
	public bool IsCountry { get; private set; }

	// Token: 0x170010E7 RID: 4327
	// (get) Token: 0x06009EB7 RID: 40631 RVA: 0x002EDAE1 File Offset: 0x002EBCE1
	// (set) Token: 0x06009EB8 RID: 40632 RVA: 0x002EDAE9 File Offset: 0x002EBCE9
	public bool IsLock { get; private set; } = true;

	// Token: 0x170010E8 RID: 4328
	// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x002EDAF2 File Offset: 0x002EBCF2
	// (set) Token: 0x06009EBA RID: 40634 RVA: 0x002EDAFA File Offset: 0x002EBCFA
	public float Progress { get; private set; }

	// Token: 0x06009EBB RID: 40635 RVA: 0x002EDB03 File Offset: 0x002EBD03
	public void RefreshCountry(int countryId, string nameId, bool isLock)
	{
		this.CountryId = countryId;
		this.AreaId = 0;
		this.NameId = nameId;
		this.IsLock = isLock;
		this.Progress = 0f;
		this.IsCountry = true;
	}

	// Token: 0x06009EBC RID: 40636 RVA: 0x002EDB33 File Offset: 0x002EBD33
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
