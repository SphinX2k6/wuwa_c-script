using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020031B0 RID: 12720
[NullableContext(1)]
[Nullable(0)]
public class CharacterWeaponMesh
{
	// Token: 0x0601B6CA RID: 112330 RVA: 0x007808F4 File Offset: 0x0077EAF4
	public bool Init(List<USkeletalMeshComponent> components, USkeletalMeshComponent parentComponent, TsBaseCharacter actor, bool bInUsed)
	{
		this.MeshPool = new SkeletalMeshComponentPool();
		this.MeshPool.Init(3, parentComponent, actor, components, bInUsed, false);
		this.Actor = actor;
		if (components.Count == 0)
		{
			return true;
		}
		int num = 0;
		foreach (USkeletalMeshComponent mesh in components)
		{
			this.Weapons.Add(new CharacterWeapon(num, mesh, actor.WeaponHideEffect, new int?(this.Actor.EntityId)));
			num++;
		}
		return true;
	}

	// Token: 0x0601B6CB RID: 112331 RVA: 0x00780998 File Offset: 0x0077EB98
	public void Destroy()
	{
		foreach (CharacterWeapon characterWeapon in this.Weapons)
		{
			characterWeapon.Destroy();
		}
		this.Weapons.Clear();
		this.MeshPool = null;
	}

	// Token: 0x0601B6CC RID: 112332 RVA: 0x007809FC File Offset: 0x0077EBFC
	public CharacterWeapon[] ChangeCharacterWeapons(int num)
	{
		int count = this.Weapons.Count;
		if (num > 3)
		{
			return Array.Empty<CharacterWeapon>();
		}
		SkeletalMeshComponentPool meshPool = this.MeshPool;
		List<USkeletalMeshComponent> list = (meshPool != null) ? meshPool.GetComponents(num, true, false) : null;
		if (list == null)
		{
			return Array.Empty<CharacterWeapon>();
		}
		if (num < count)
		{
			int count2 = count - num;
			this.Weapons.RemoveRange(num, count2);
			for (int i = 0; i < num; i++)
			{
				this.Weapons[i].Mesh = list[i];
			}
		}
		else if (num > count)
		{
			int num2 = num - count;
			for (int j = 0; j < count; j++)
			{
				this.Weapons[j].Mesh = list[j];
			}
			for (int k = 0; k < num2; k++)
			{
				this.Weapons.Add(new CharacterWeapon(k + count, list[k + count], this.Actor.WeaponHideEffect, new int?(this.Actor.EntityId)));
			}
		}
		return this.Weapons.ToArray();
	}

	// Token: 0x170025E9 RID: 9705
	// (get) Token: 0x0601B6CD RID: 112333 RVA: 0x00780B01 File Offset: 0x0077ED01
	public CharacterWeapon[] CharacterWeapons
	{
		get
		{
			return this.Weapons.ToArray();
		}
	}

	// Token: 0x0601B6CE RID: 112334 RVA: 0x00780B0E File Offset: 0x0077ED0E
	public void Clean()
	{
		this.ChangeCharacterWeapons(0);
	}

	// Token: 0x0601B6CF RID: 112335 RVA: 0x00780B18 File Offset: 0x0077ED18
	public void ShrinkPool()
	{
		this.MeshPool.Shrink();
	}

	// Token: 0x0601B6D0 RID: 112336 RVA: 0x00780B25 File Offset: 0x0077ED25
	public int GetUsedLength()
	{
		return this.MeshPool.GetUsedLength();
	}

	// Token: 0x0400D6EA RID: 55018
	public const string WEAPON_HIDDEN_EFFECT = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_WeaponEnd.DA_Fx_Group_WeaponEnd";

	// Token: 0x0400D6EB RID: 55019
	private const int WEAPON_POOL_MAX_SIZE = 3;

	// Token: 0x0400D6EC RID: 55020
	private readonly List<CharacterWeapon> Weapons = new List<CharacterWeapon>();

	// Token: 0x0400D6ED RID: 55021
	[Nullable(2)]
	private SkeletalMeshComponentPool MeshPool;

	// Token: 0x0400D6EE RID: 55022
	[Nullable(2)]
	private TsBaseCharacter Actor;
}
