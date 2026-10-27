using System;
using System.Runtime.CompilerServices;

// Token: 0x02001895 RID: 6293
[NullableContext(1)]
[Nullable(0)]
public class PinballWeaponSort : CommonSort<EPinballWeaponSortWayType>
{
	// Token: 0x0600B856 RID: 47190 RVA: 0x0029CF80 File Offset: 0x0029B180
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

	// Token: 0x0600B857 RID: 47191 RVA: 0x0029CFF4 File Offset: 0x0029B1F4
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

	// Token: 0x0600B858 RID: 47192 RVA: 0x0029D038 File Offset: 0x0029B238
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

	// Token: 0x0600B859 RID: 47193 RVA: 0x0029D078 File Offset: 0x0029B278
	protected override void OnInitSortMap()
	{
		this.SortMap[EPinballWeaponSortWayType.Quality] = new TSortResult(this.SortQuality);
		this.SortMap[EPinballWeaponSortWayType.EquipLast] = new TSortResult(this.SortEquipLast);
		this.SortMap[EPinballWeaponSortWayType.LockLast] = new TSortResult(this.SortLockLast);
	}
}
