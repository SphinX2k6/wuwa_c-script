using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D4D RID: 7501
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDisplayModelBase
{
	// Token: 0x17001B9C RID: 7068
	// (get) Token: 0x06012922 RID: 76066 RVA: 0x0057BAA9 File Offset: 0x00579CA9
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x17001B9D RID: 7069
	// (get) Token: 0x06012923 RID: 76067 RVA: 0x0057BAB1 File Offset: 0x00579CB1
	public string Name
	{
		get
		{
			return this.NameInternal;
		}
	}

	// Token: 0x17001B9E RID: 7070
	// (get) Token: 0x06012924 RID: 76068 RVA: 0x0057BAB9 File Offset: 0x00579CB9
	public int SkinId
	{
		get
		{
			return this.SkinIdInternal;
		}
	}

	// Token: 0x17001B9F RID: 7071
	// (get) Token: 0x06012925 RID: 76069 RVA: 0x0057BAC1 File Offset: 0x00579CC1
	public int ElementId
	{
		get
		{
			return this.ElementIdInternal;
		}
	}

	// Token: 0x17001BA0 RID: 7072
	// (get) Token: 0x06012926 RID: 76070 RVA: 0x0057BAC9 File Offset: 0x00579CC9
	public int Level
	{
		get
		{
			return this.LevelInternal;
		}
	}

	// Token: 0x17001BA1 RID: 7073
	// (get) Token: 0x06012927 RID: 76071 RVA: 0x0057BAD1 File Offset: 0x00579CD1
	public bool IsInTeam
	{
		get
		{
			return this.IsInTeamInternal;
		}
	}

	// Token: 0x17001BA2 RID: 7074
	// (get) Token: 0x06012928 RID: 76072 RVA: 0x0057BAD9 File Offset: 0x00579CD9
	public bool IsTrial
	{
		get
		{
			return this.IsTrialInternal;
		}
	}

	// Token: 0x17001BA3 RID: 7075
	// (get) Token: 0x06012929 RID: 76073 RVA: 0x0057BAE1 File Offset: 0x00579CE1
	public bool IsNew
	{
		get
		{
			return this.IsNewInternal;
		}
	}

	// Token: 0x17001BA4 RID: 7076
	// (get) Token: 0x0601292A RID: 76074 RVA: 0x0057BAE9 File Offset: 0x00579CE9
	public ERoleTypeTag TypeTag
	{
		get
		{
			return this.TypeTagInternal;
		}
	}

	// Token: 0x17001BA5 RID: 7077
	// (get) Token: 0x0601292B RID: 76075
	public abstract ERoleDisplaySourceType SourceType { get; }

	// Token: 0x17001BA6 RID: 7078
	// (get) Token: 0x0601292C RID: 76076
	[Nullable(2)]
	public abstract RoleDataBase OriginRoleData { [NullableContext(2)] get; }

	// Token: 0x0601292D RID: 76077 RVA: 0x0057BAF4 File Offset: 0x00579CF4
	protected void InitBase(RoleDisplayModelBaseInitParams param)
	{
		this.IdInternal = param.Id;
		this.NameInternal = param.Name;
		this.SkinIdInternal = param.SkinId;
		this.ElementIdInternal = param.ElementId;
		this.LevelInternal = param.Level;
		this.IsInTeamInternal = param.IsInTeam;
		this.IsTrialInternal = param.IsTrial;
		this.IsNewInternal = param.IsNew;
		this.TypeTagInternal = param.TypeTag;
	}

	// Token: 0x0400A173 RID: 41331
	private int IdInternal;

	// Token: 0x0400A174 RID: 41332
	private string NameInternal;

	// Token: 0x0400A175 RID: 41333
	private int SkinIdInternal;

	// Token: 0x0400A176 RID: 41334
	private int ElementIdInternal;

	// Token: 0x0400A177 RID: 41335
	private int LevelInternal;

	// Token: 0x0400A178 RID: 41336
	private bool IsInTeamInternal;

	// Token: 0x0400A179 RID: 41337
	private bool IsTrialInternal;

	// Token: 0x0400A17A RID: 41338
	private bool IsNewInternal;

	// Token: 0x0400A17B RID: 41339
	private ERoleTypeTag TypeTagInternal;
}
