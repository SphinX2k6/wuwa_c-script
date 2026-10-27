using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002805 RID: 10245
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevPhantomViewItemDataBase
{
	// Token: 0x06015056 RID: 86102 RVA: 0x00552C8B File Offset: 0x00550E8B
	public void InitByRoleId(int roleId, ERoleDevDataType roleType, RoleDevViewModel roleDevViewModel)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitByRoleType(roleId);
	}

	// Token: 0x06015057 RID: 86103
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001BBB RID: 7099
	// (get) Token: 0x06015058 RID: 86104 RVA: 0x00552CA9 File Offset: 0x00550EA9
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001BBC RID: 7100
	// (get) Token: 0x06015059 RID: 86105 RVA: 0x00552CB1 File Offset: 0x00550EB1
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x0601505A RID: 86106
	protected abstract List<RoleDevPhantomSuitItemData> GetSuitDataList();

	// Token: 0x17001BBD RID: 7101
	// (get) Token: 0x0601505B RID: 86107 RVA: 0x00552CB9 File Offset: 0x00550EB9
	public List<RoleDevPhantomSuitItemData> SuitDataList
	{
		get
		{
			return this.GetSuitDataList();
		}
	}

	// Token: 0x17001BBE RID: 7102
	// (get) Token: 0x0601505C RID: 86108 RVA: 0x00552CC1 File Offset: 0x00550EC1
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001BBF RID: 7103
	// (get) Token: 0x0601505D RID: 86109 RVA: 0x00552CCC File Offset: 0x00550ECC
	public bool IsForecast
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Forecast;
		}
	}

	// Token: 0x17001BC0 RID: 7104
	// (get) Token: 0x0601505E RID: 86110 RVA: 0x00552CD7 File Offset: 0x00550ED7
	public bool IsNotObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.NotObtained;
		}
	}

	// Token: 0x17001BC1 RID: 7105
	// (get) Token: 0x0601505F RID: 86111 RVA: 0x00552CE2 File Offset: 0x00550EE2
	[Nullable(2)]
	public RoleDevViewModel RoleDevViewModel
	{
		[NullableContext(2)]
		get
		{
			return this.RoleDevViewModelInternal;
		}
	}

	// Token: 0x06015060 RID: 86112
	public abstract void RefreshSuitDataList();

	// Token: 0x04009E04 RID: 40452
	protected int RoleIdInternal;

	// Token: 0x04009E05 RID: 40453
	protected ERoleDevDataType RoleTypeInternal;

	// Token: 0x04009E06 RID: 40454
	[Nullable(2)]
	protected RoleDevViewModel RoleDevViewModelInternal;
}
