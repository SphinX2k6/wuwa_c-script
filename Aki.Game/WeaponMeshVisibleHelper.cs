using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002724 RID: 10020
[NullableContext(1)]
[Nullable(0)]
public class WeaponMeshVisibleHelper
{
	// Token: 0x170027EB RID: 10219
	// (get) Token: 0x06019216 RID: 102934 RVA: 0x007A900A File Offset: 0x007A720A
	public Dictionary<EWeaponExtraVisibleType, WeaponVisibleState> WeaponVisibleTable { get; } = new Dictionary<EWeaponExtraVisibleType, WeaponVisibleState>();

	// Token: 0x170027EC RID: 10220
	// (get) Token: 0x06019217 RID: 102935 RVA: 0x007A9012 File Offset: 0x007A7212
	// (set) Token: 0x06019218 RID: 102936 RVA: 0x007A901A File Offset: 0x007A721A
	public EWeaponBaseVisibleType DefaultVisibleType { get; set; }

	// Token: 0x170027ED RID: 10221
	// (get) Token: 0x06019219 RID: 102937 RVA: 0x007A9023 File Offset: 0x007A7223
	public WeaponVisibleState DefaultVisibleState { get; } = new WeaponVisibleState(false, true, 0);

	// Token: 0x170027EE RID: 10222
	// (get) Token: 0x0601921A RID: 102938 RVA: 0x007A902B File Offset: 0x007A722B
	public WeaponVisibleTagHelper WeaponHiddenTag { get; } = new WeaponVisibleTagHelper();

	// Token: 0x170027EF RID: 10223
	// (get) Token: 0x0601921B RID: 102939 RVA: 0x007A9033 File Offset: 0x007A7233
	public WeaponVisibleTagHelper WeaponVisibleTag { get; } = new WeaponVisibleTagHelper();

	// Token: 0x170027F0 RID: 10224
	// (get) Token: 0x0601921C RID: 102940 RVA: 0x007A903B File Offset: 0x007A723B
	public CharacterWeapon Owner { get; }

	// Token: 0x0601921D RID: 102941 RVA: 0x007A9043 File Offset: 0x007A7243
	public WeaponMeshVisibleHelper(CharacterWeapon owner)
	{
		this.Owner = owner;
	}

	// Token: 0x0601921E RID: 102942 RVA: 0x007A9084 File Offset: 0x007A7284
	public void InitBaseTable(EWeaponBaseVisibleType normalType)
	{
		this.DefaultVisibleType = normalType;
		WeaponVisibleState value = new WeaponVisibleState(false, false, 0);
		this.WeaponVisibleTable[EWeaponExtraVisibleType.LowCustom] = value;
		WeaponVisibleState value2 = new WeaponVisibleState(false, false, 1);
		this.WeaponVisibleTable[EWeaponExtraVisibleType.HighCustom] = value2;
		WeaponVisibleState value3 = new WeaponVisibleState(false, false, 2);
		this.WeaponVisibleTable[EWeaponExtraVisibleType.ExtraTag] = value3;
	}

	// Token: 0x0601921F RID: 102943 RVA: 0x007A90DC File Offset: 0x007A72DC
	public void InitTagHelper(BaseTagComponent tagComp, string visibleTagNames, Action<bool, CharacterWeapon> visibleCallBack, string hiddenTagNames, Action<bool, CharacterWeapon> hiddenCallBack)
	{
		this.WeaponVisibleTag.Init(this.Owner, tagComp, (visibleTagNames != null) ? visibleTagNames.Split('#', StringSplitOptions.None) : null, visibleCallBack);
		this.WeaponHiddenTag.Init(this.Owner, tagComp, (hiddenTagNames != null) ? hiddenTagNames.Split('#', StringSplitOptions.None) : null, hiddenCallBack);
	}

	// Token: 0x06019220 RID: 102944 RVA: 0x007A9130 File Offset: 0x007A7330
	public void ClearTagHelper()
	{
		this.WeaponVisibleTag.Clear();
		this.WeaponHiddenTag.Clear();
	}

	// Token: 0x06019221 RID: 102945 RVA: 0x007A9148 File Offset: 0x007A7348
	public bool RequestAndUpdateHiddenInGame(bool bHidden, bool isNormal = true, EWeaponExtraVisibleType type = EWeaponExtraVisibleType.LowCustom)
	{
		bool result = false;
		EWeaponBaseVisibleType defaultVisibleType = this.DefaultVisibleType;
		if (defaultVisibleType != EWeaponBaseVisibleType.Normal)
		{
			if (defaultVisibleType == EWeaponBaseVisibleType.AlwaysHidden)
			{
				result = true;
				if (isNormal)
				{
					this.DefaultVisibleState.IsHidden = true;
				}
			}
		}
		else
		{
			result = bHidden;
			if (isNormal)
			{
				this.DefaultVisibleState.IsHidden = bHidden;
			}
		}
		WeaponVisibleState weaponVisibleState;
		if (!isNormal && this.WeaponVisibleTable.TryGetValue(type, out weaponVisibleState))
		{
			weaponVisibleState.IsHidden = bHidden;
		}
		WeaponVisibleState hiddenInGameByExtraVisibleType = this.GetHiddenInGameByExtraVisibleType();
		if (hiddenInGameByExtraVisibleType != null)
		{
			if (hiddenInGameByExtraVisibleType.Priority == 0 && isNormal && hiddenInGameByExtraVisibleType.Active)
			{
				hiddenInGameByExtraVisibleType.Active = false;
			}
			else
			{
				result = hiddenInGameByExtraVisibleType.IsHidden;
			}
		}
		return result;
	}

	// Token: 0x06019222 RID: 102946 RVA: 0x007A91D8 File Offset: 0x007A73D8
	public void EnableHiddenInGameByExtraVisibleType(EWeaponExtraVisibleType type, bool newEnable)
	{
		WeaponVisibleState weaponVisibleState;
		if (this.WeaponVisibleTable.TryGetValue(type, out weaponVisibleState))
		{
			weaponVisibleState.Active = newEnable;
		}
	}

	// Token: 0x06019223 RID: 102947 RVA: 0x007A91FC File Offset: 0x007A73FC
	[NullableContext(2)]
	private WeaponVisibleState GetHiddenInGameByExtraVisibleType()
	{
		int num = -1;
		WeaponVisibleState result = null;
		foreach (WeaponVisibleState weaponVisibleState in this.WeaponVisibleTable.Values)
		{
			if (weaponVisibleState.Active && weaponVisibleState.Priority > num)
			{
				num = weaponVisibleState.Priority;
				result = weaponVisibleState;
			}
		}
		return result;
	}
}
