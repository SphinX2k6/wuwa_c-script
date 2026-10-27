using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020031B5 RID: 12725
[NullableContext(1)]
[Nullable(0)]
public class WeaponMeshVisibleHelper
{
	// Token: 0x170025EE RID: 9710
	// (get) Token: 0x0601B6E3 RID: 112355 RVA: 0x00780C8A File Offset: 0x0077EE8A
	public Dictionary<EWeaponExtraVisibleType, WeaponVisibleState> WeaponVisibleTable { get; } = new Dictionary<EWeaponExtraVisibleType, WeaponVisibleState>();

	// Token: 0x170025EF RID: 9711
	// (get) Token: 0x0601B6E4 RID: 112356 RVA: 0x00780C92 File Offset: 0x0077EE92
	// (set) Token: 0x0601B6E5 RID: 112357 RVA: 0x00780C9A File Offset: 0x0077EE9A
	public EWeaponBaseVisibleType DefaultVisibleType { get; set; }

	// Token: 0x170025F0 RID: 9712
	// (get) Token: 0x0601B6E6 RID: 112358 RVA: 0x00780CA3 File Offset: 0x0077EEA3
	public WeaponVisibleState DefaultVisibleState { get; } = new WeaponVisibleState(false, true, 0);

	// Token: 0x170025F1 RID: 9713
	// (get) Token: 0x0601B6E7 RID: 112359 RVA: 0x00780CAB File Offset: 0x0077EEAB
	public WeaponVisibleTagHelper WeaponHiddenTag { get; } = new WeaponVisibleTagHelper();

	// Token: 0x170025F2 RID: 9714
	// (get) Token: 0x0601B6E8 RID: 112360 RVA: 0x00780CB3 File Offset: 0x0077EEB3
	public WeaponVisibleTagHelper WeaponVisibleTag { get; } = new WeaponVisibleTagHelper();

	// Token: 0x170025F3 RID: 9715
	// (get) Token: 0x0601B6E9 RID: 112361 RVA: 0x00780CBB File Offset: 0x0077EEBB
	public CharacterWeapon Owner { get; }

	// Token: 0x0601B6EA RID: 112362 RVA: 0x00780CC3 File Offset: 0x0077EEC3
	public WeaponMeshVisibleHelper(CharacterWeapon owner)
	{
		this.Owner = owner;
	}

	// Token: 0x0601B6EB RID: 112363 RVA: 0x00780D04 File Offset: 0x0077EF04
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

	// Token: 0x0601B6EC RID: 112364 RVA: 0x00780D5C File Offset: 0x0077EF5C
	public void InitTagHelper(BaseTagComponent tagComp, string visibleTagNames, Action<bool, CharacterWeapon> visibleCallBack, string hiddenTagNames, Action<bool, CharacterWeapon> hiddenCallBack)
	{
		this.WeaponVisibleTag.Init(this.Owner, tagComp, (visibleTagNames != null) ? visibleTagNames.Split('#', StringSplitOptions.None) : null, visibleCallBack);
		this.WeaponHiddenTag.Init(this.Owner, tagComp, (hiddenTagNames != null) ? hiddenTagNames.Split('#', StringSplitOptions.None) : null, hiddenCallBack);
	}

	// Token: 0x0601B6ED RID: 112365 RVA: 0x00780DB0 File Offset: 0x0077EFB0
	public void ClearTagHelper()
	{
		this.WeaponVisibleTag.Clear();
		this.WeaponHiddenTag.Clear();
	}

	// Token: 0x0601B6EE RID: 112366 RVA: 0x00780DC8 File Offset: 0x0077EFC8
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

	// Token: 0x0601B6EF RID: 112367 RVA: 0x00780E58 File Offset: 0x0077F058
	public void EnableHiddenInGameByExtraVisibleType(EWeaponExtraVisibleType type, bool newEnable)
	{
		WeaponVisibleState weaponVisibleState;
		if (this.WeaponVisibleTable.TryGetValue(type, out weaponVisibleState))
		{
			weaponVisibleState.Active = newEnable;
		}
	}

	// Token: 0x0601B6F0 RID: 112368 RVA: 0x00780E7C File Offset: 0x0077F07C
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
