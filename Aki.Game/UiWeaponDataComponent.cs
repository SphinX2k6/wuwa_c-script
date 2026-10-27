using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CC0 RID: 11456
[NullableContext(2)]
[Nullable(0)]
public class UiWeaponDataComponent : UiModelComponentBase
{
	// Token: 0x17002041 RID: 8257
	// (get) Token: 0x06017F12 RID: 98066 RVA: 0x00616ABD File Offset: 0x00614CBD
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

	// Token: 0x17002042 RID: 8258
	// (get) Token: 0x06017F13 RID: 98067 RVA: 0x00616AD0 File Offset: 0x00614CD0
	public WeaponDataBase WeaponData
	{
		get
		{
			return this.WeaponDataInternal;
		}
	}

	// Token: 0x06017F14 RID: 98068 RVA: 0x00616AD8 File Offset: 0x00614CD8
	[NullableContext(1)]
	public void SetWeaponData(WeaponDataBase weaponData)
	{
		this.WeaponDataInternal = weaponData;
	}

	// Token: 0x0400B273 RID: 45683
	private WeaponDataBase WeaponDataInternal;
}
