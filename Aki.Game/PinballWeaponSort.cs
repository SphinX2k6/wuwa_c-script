using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D4E RID: 3406
[NullableContext(1)]
[Nullable(0)]
public class PinballWeaponSort : CommonSort<EPinballWeaponSortWayType>
{
	// Token: 0x06008C3F RID: 35903 RVA: 0x002A7698 File Offset: 0x002A5898
	private int SortQuality(object a, object b, bool isAscending, params object[] parameters)
	{
		PinballWeaponData pinballWeaponData = (PinballWeaponData)a;
		PinballWeaponData pinballWeaponData2 = (PinballWeaponData)b;
		int qualityId = PinballConfig.Instance.GetPinballWeaponConfigById(pinballWeaponData.Id).Value.QualityId;
		int qualityId2 = PinballConfig.Instance.GetPinballWeaponConfigById(pinballWeaponData2.Id).Value.QualityId;
		if (qualityId != qualityId2)
		{
			return (qualityId - qualityId2) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x06008C40 RID: 35904 RVA: 0x002A770C File Offset: 0x002A590C
	private int SortEquipLast(object a, object b, bool isAscending, params object[] parameters)
	{
		PinballWeaponData pinballWeaponData = (PinballWeaponData)a;
		PinballWeaponData pinballWeaponData2 = (PinballWeaponData)b;
		if (pinballWeaponData.RoleId > 0 && pinballWeaponData2.RoleId <= 0)
		{
			return 1;
		}
		if (pinballWeaponData.RoleId <= 0 && pinballWeaponData2.RoleId > 0)
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x06008C41 RID: 35905 RVA: 0x002A7750 File Offset: 0x002A5950
	private int SortLockLast(object a, object b, bool isAscending, params object[] parameters)
	{
		PinballWeaponData pinballWeaponData = (PinballWeaponData)a;
		PinballWeaponData pinballWeaponData2 = (PinballWeaponData)b;
		if (pinballWeaponData.GetIsLock() && !pinballWeaponData2.GetIsLock())
		{
			return 1;
		}
		if (!pinballWeaponData.GetIsLock() && pinballWeaponData2.GetIsLock())
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x06008C42 RID: 35906 RVA: 0x002A7790 File Offset: 0x002A5990
	protected override void OnInitSortMap()
	{
		this.SortMap[EPinballWeaponSortWayType.Quality] = new TSortResult(this.SortQuality);
		this.SortMap[EPinballWeaponSortWayType.EquipLast] = new TSortResult(this.SortEquipLast);
		this.SortMap[EPinballWeaponSortWayType.LockLast] = new TSortResult(this.SortLockLast);
	}
}
