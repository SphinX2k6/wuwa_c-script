using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001D80 RID: 7552
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDevPhantomViewItemDataBase
{
	// Token: 0x06012A56 RID: 76374 RVA: 0x0057DA5F File Offset: 0x0057BC5F
	public void InitByRoleId(int roleId, ERoleDevDataType roleType, RoleDevViewModel roleDevViewModel)
	{
		this.RoleIdInternal = roleId;
		this.RoleTypeInternal = roleType;
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitByRoleType(roleId);
	}

	// Token: 0x06012A57 RID: 76375
	protected abstract void InitByRoleType(int roleId);

	// Token: 0x17001C13 RID: 7187
	// (get) Token: 0x06012A58 RID: 76376 RVA: 0x0057DA7D File Offset: 0x0057BC7D
	public int RoleId
	{
		get
		{
			return this.RoleIdInternal;
		}
	}

	// Token: 0x17001C14 RID: 7188
	// (get) Token: 0x06012A59 RID: 76377 RVA: 0x0057DA85 File Offset: 0x0057BC85
	public ERoleDevDataType RoleType
	{
		get
		{
			return this.RoleTypeInternal;
		}
	}

	// Token: 0x06012A5A RID: 76378
	protected abstract List<RoleDevPhantomSuitItemData> GetSuitDataList();

	// Token: 0x17001C15 RID: 7189
	// (get) Token: 0x06012A5B RID: 76379 RVA: 0x0057DA8D File Offset: 0x0057BC8D
	public List<RoleDevPhantomSuitItemData> SuitDataList
	{
		get
		{
			return this.GetSuitDataList();
		}
	}

	// Token: 0x17001C16 RID: 7190
	// (get) Token: 0x06012A5C RID: 76380 RVA: 0x0057DA95 File Offset: 0x0057BC95
	public bool IsRoleObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Obtained;
		}
	}

	// Token: 0x17001C17 RID: 7191
	// (get) Token: 0x06012A5D RID: 76381 RVA: 0x0057DAA0 File Offset: 0x0057BCA0
	public bool IsForecast
	{
		get
		{
			return this.RoleType == ERoleDevDataType.Forecast;
		}
	}

	// Token: 0x17001C18 RID: 7192
	// (get) Token: 0x06012A5E RID: 76382 RVA: 0x0057DAAB File Offset: 0x0057BCAB
	public bool IsNotObtained
	{
		get
		{
			return this.RoleType == ERoleDevDataType.NotObtained;
		}
	}

	// Token: 0x17001C19 RID: 7193
	// (get) Token: 0x06012A5F RID: 76383 RVA: 0x0057DAB6 File Offset: 0x0057BCB6
	[Nullable(2)]
	public RoleDevViewModel RoleDevViewModel
	{
		[NullableContext(2)]
		get
		{
			return this.RoleDevViewModelInternal;
		}
	}

	// Token: 0x06012A60 RID: 76384
	public abstract void RefreshSuitDataList();

	// Token: 0x0400A1ED RID: 41453
	protected int RoleIdInternal;

	// Token: 0x0400A1EE RID: 41454
	protected ERoleDevDataType RoleTypeInternal;

	// Token: 0x0400A1EF RID: 41455
	[Nullable(2)]
	protected RoleDevViewModel RoleDevViewModelInternal;
}
