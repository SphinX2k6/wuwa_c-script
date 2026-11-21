using System;
using System.Runtime.CompilerServices;

// Token: 0x02002219 RID: 8729
[NullableContext(2)]
[Nullable(0)]
public class UiWeaponDataComponent : UiModelComponentBase
{
	// Token: 0x17002092 RID: 8338
	// (get) Token: 0x0601578B RID: 87947 RVA: 0x0063C77D File Offset: 0x0063A97D
	public int WeaponConfigId
	{
		get
		{
			WeaponDataBase weaponDataInternal = this.WeaponDataInternal;
			if (weaponDataInternal == null)
			{
				return 0;
			}
			return weaponDataInternal.GetItemId();
		}
	}

	// Token: 0x17002093 RID: 8339
	// (get) Token: 0x0601578C RID: 87948 RVA: 0x0063C790 File Offset: 0x0063A990
	public WeaponDataBase WeaponData
	{
		get
		{
			return this.WeaponDataInternal;
		}
	}

	// Token: 0x0601578D RID: 87949 RVA: 0x0063C798 File Offset: 0x0063A998
	[NullableContext(1)]
	public void SetWeaponData(WeaponDataBase weaponData)
	{
		this.WeaponDataInternal = weaponData;
	}

	// Token: 0x0400B5DE RID: 46558
	private WeaponDataBase WeaponDataInternal;
}
