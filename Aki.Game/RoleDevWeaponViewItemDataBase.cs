using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DB2 RID: 7602
[NullableContext(2)]
[Nullable(0)]
public abstract class RoleDevWeaponViewItemDataBase
{
	// Token: 0x06012D95 RID: 77205 RVA: 0x00587EA8 File Offset: 0x005860A8
	[NullableContext(1)]
	public void InitByRoleId(int roleId, ERoleDevDataType roleType, RoleDevViewModel roleDevViewModel)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitByRoleType(roleId, roleDevViewModel);
	}

	// Token: 0x06012D96 RID: 77206
	[NullableContext(1)]
	protected abstract void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel);

	// Token: 0x06012D97 RID: 77207 RVA: 0x00587EC7 File Offset: 0x005860C7
	protected virtual void CheckTabType()
	{
	}

	// Token: 0x17001C97 RID: 7319
	// (get) Token: 0x06012D98 RID: 77208 RVA: 0x00587EC9 File Offset: 0x005860C9
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C98 RID: 7320
	// (get) Token: 0x06012D99 RID: 77209 RVA: 0x00587ED1 File Offset: 0x005860D1
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x06012D9A RID: 77210
	protected abstract bool GetIsRoleObtained();

	// Token: 0x06012D9B RID: 77211
	protected abstract RoleDevWeaponDevItemDataBase GetDevItemData();

	// Token: 0x06012D9C RID: 77212
	protected abstract RoleDevWeaponRecommendItemDataBase GetRecommendItemData();

	// Token: 0x06012D9D RID: 77213
	protected abstract bool GetIsWeaponHighQuality();

	// Token: 0x17001C99 RID: 7321
	// (get) Token: 0x06012D9E RID: 77214 RVA: 0x00587ED9 File Offset: 0x005860D9
	public bool IsRoleObtained
	{
		get
		{
			return this.GetIsRoleObtained();
		}
	}

	// Token: 0x17001C9A RID: 7322
	// (get) Token: 0x06012D9F RID: 77215 RVA: 0x00587EE1 File Offset: 0x005860E1
	public RoleDevWeaponDevItemDataBase DevItemData
	{
		get
		{
			return this.GetDevItemData();
		}
	}

	// Token: 0x17001C9B RID: 7323
	// (get) Token: 0x06012DA0 RID: 77216 RVA: 0x00587EE9 File Offset: 0x005860E9
	public RoleDevWeaponRecommendItemDataBase RecommendItemData
	{
		get
		{
			return this.GetRecommendItemData();
		}
	}

	// Token: 0x17001C9C RID: 7324
	// (get) Token: 0x06012DA1 RID: 77217 RVA: 0x00587EF1 File Offset: 0x005860F1
	public bool IsWeaponHighQuality
	{
		get
		{
			return this.GetIsWeaponHighQuality();
		}
	}

	// Token: 0x17001C9D RID: 7325
	// (get) Token: 0x06012DA2 RID: 77218 RVA: 0x00587EF9 File Offset: 0x005860F9
	public bool IsRoleObtainedType
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001C9E RID: 7326
	// (get) Token: 0x06012DA3 RID: 77219 RVA: 0x00587F04 File Offset: 0x00586104
	// (set) Token: 0x06012DA4 RID: 77220 RVA: 0x00587F21 File Offset: 0x00586121
	public ERoleDevWeaponTabType TabType
	{
		get
		{
			if (this.RoleDevViewModelInternal == null)
			{
				return ERoleDevWeaponTabType.None;
			}
			return this.RoleDevViewModelInternal.GetRoleWeaponTabType(this.RoleId);
		}
		set
		{
			if (this.RoleDevViewModelInternal != null)
			{
				this.RoleDevViewModelInternal.SetRoleWeaponTabType(this.RoleId, value);
			}
		}
	}

	// Token: 0x0400A28B RID: 41611
	protected int RoleIdInternal;

	// Token: 0x0400A28C RID: 41612
	protected ERoleDevDataType RoleTypeInternal;

	// Token: 0x0400A28D RID: 41613
	protected RoleDevViewModel RoleDevViewModelInternal;
}
