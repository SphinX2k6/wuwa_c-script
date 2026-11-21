using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200271F RID: 10015
[NullableContext(1)]
[Nullable(0)]
public class CharacterWeaponMesh
{
	// Token: 0x060191FD RID: 102909 RVA: 0x007A8C74 File Offset: 0x007A6E74
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

	// Token: 0x060191FE RID: 102910 RVA: 0x007A8D18 File Offset: 0x007A6F18
	public void Destroy()
	{
		foreach (CharacterWeapon characterWeapon in this.Weapons)
		{
			characterWeapon.Destroy();
		}
		this.Weapons.Clear();
		this.MeshPool = null;
	}

	// Token: 0x060191FF RID: 102911 RVA: 0x007A8D7C File Offset: 0x007A6F7C
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

	// Token: 0x170027E6 RID: 10214
	// (get) Token: 0x06019200 RID: 102912 RVA: 0x007A8E81 File Offset: 0x007A7081
	public CharacterWeapon[] CharacterWeapons
	{
		get
		{
			return this.Weapons.ToArray();
		}
	}

	// Token: 0x06019201 RID: 102913 RVA: 0x007A8E8E File Offset: 0x007A708E
	public void Clean()
	{
		this.ChangeCharacterWeapons(0);
	}

	// Token: 0x06019202 RID: 102914 RVA: 0x007A8E98 File Offset: 0x007A7098
	public void ShrinkPool()
	{
		this.MeshPool.Shrink();
	}

	// Token: 0x06019203 RID: 102915 RVA: 0x007A8EA5 File Offset: 0x007A70A5
	public int GetUsedLength()
	{
		return this.MeshPool.GetUsedLength();
	}

	// Token: 0x0400DB71 RID: 56177
	public const string WEAPON_HIDDEN_EFFECT = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_WeaponEnd.DA_Fx_Group_WeaponEnd";

	// Token: 0x0400DB72 RID: 56178
	private const int WEAPON_POOL_MAX_SIZE = 3;

	// Token: 0x0400DB73 RID: 56179
	private readonly List<CharacterWeapon> Weapons = new List<CharacterWeapon>();

	// Token: 0x0400DB74 RID: 56180
	[Nullable(2)]
	private SkeletalMeshComponentPool MeshPool;

	// Token: 0x0400DB75 RID: 56181
	[Nullable(2)]
	private TsBaseCharacter Actor;
}
