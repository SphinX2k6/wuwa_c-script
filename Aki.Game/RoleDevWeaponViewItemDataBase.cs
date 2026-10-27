using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002837 RID: 10295
[NullableContext(2)]
[Nullable(0)]
public abstract class RoleDevWeaponViewItemDataBase
{
	// Token: 0x06015397 RID: 86935 RVA: 0x0055D14C File Offset: 0x0055B34C
	[NullableContext(1)]
	public void InitByRoleId(int roleId, ERoleDevDataType roleType, RoleDevViewModel roleDevViewModel)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitByRoleType(roleId, roleDevViewModel);
	}

	// Token: 0x06015398 RID: 86936
	[NullableContext(1)]
	protected abstract void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel);

	// Token: 0x06015399 RID: 86937 RVA: 0x0055D16B File Offset: 0x0055B36B
	protected virtual void CheckTabType()
	{
	}

	// Token: 0x17001C3F RID: 7231
	// (get) Token: 0x0601539A RID: 86938 RVA: 0x0055D16D File Offset: 0x0055B36D
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C40 RID: 7232
	// (get) Token: 0x0601539B RID: 86939 RVA: 0x0055D175 File Offset: 0x0055B375
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x0601539C RID: 86940
	protected abstract bool GetIsRoleObtained();

	// Token: 0x0601539D RID: 86941
	protected abstract RoleDevWeaponDevItemDataBase GetDevItemData();

	// Token: 0x0601539E RID: 86942
	protected abstract RoleDevWeaponRecommendItemDataBase GetRecommendItemData();

	// Token: 0x0601539F RID: 86943
	protected abstract bool GetIsWeaponHighQuality();

	// Token: 0x17001C41 RID: 7233
	// (get) Token: 0x060153A0 RID: 86944 RVA: 0x0055D17D File Offset: 0x0055B37D
	public bool IsRoleObtained
	{
		get
		{
			return this.GetIsRoleObtained();
		}
	}

	// Token: 0x17001C42 RID: 7234
	// (get) Token: 0x060153A1 RID: 86945 RVA: 0x0055D185 File Offset: 0x0055B385
	public RoleDevWeaponDevItemDataBase DevItemData
	{
		get
		{
			return this.GetDevItemData();
		}
	}

	// Token: 0x17001C43 RID: 7235
	// (get) Token: 0x060153A2 RID: 86946 RVA: 0x0055D18D File Offset: 0x0055B38D
	public RoleDevWeaponRecommendItemDataBase RecommendItemData
	{
		get
		{
			return this.GetRecommendItemData();
		}
	}

	// Token: 0x17001C44 RID: 7236
	// (get) Token: 0x060153A3 RID: 86947 RVA: 0x0055D195 File Offset: 0x0055B395
	public bool IsWeaponHighQuality
	{
		get
		{
			return this.GetIsWeaponHighQuality();
		}
	}

	// Token: 0x17001C45 RID: 7237
	// (get) Token: 0x060153A4 RID: 86948 RVA: 0x0055D19D File Offset: 0x0055B39D
	public bool IsRoleObtainedType
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001C46 RID: 7238
	// (get) Token: 0x060153A5 RID: 86949 RVA: 0x0055D1A8 File Offset: 0x0055B3A8
	// (set) Token: 0x060153A6 RID: 86950 RVA: 0x0055D1C5 File Offset: 0x0055B3C5
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

	// Token: 0x04009EA2 RID: 40610
	protected int RoleIdInternal;

	// Token: 0x04009EA3 RID: 40611
	protected ERoleDevDataType RoleTypeInternal;

	// Token: 0x04009EA4 RID: 40612
	protected RoleDevViewModel RoleDevViewModelInternal;
}
