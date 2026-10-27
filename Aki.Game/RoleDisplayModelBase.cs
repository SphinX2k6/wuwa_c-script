using System;
using System.Runtime.CompilerServices;

// Token: 0x020027D2 RID: 10194
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleDisplayModelBase
{
	// Token: 0x17001B44 RID: 6980
	// (get) Token: 0x06014F22 RID: 85794 RVA: 0x00550D39 File Offset: 0x0054EF39
	public int Id
	{
		get
		{
			return this.IdInternal;
		}
	}

	// Token: 0x17001B45 RID: 6981
	// (get) Token: 0x06014F23 RID: 85795 RVA: 0x00550D41 File Offset: 0x0054EF41
	public string Name
	{
		get
		{
			return this.NameInternal;
		}
	}

	// Token: 0x17001B46 RID: 6982
	// (get) Token: 0x06014F24 RID: 85796 RVA: 0x00550D49 File Offset: 0x0054EF49
	public int SkinId
	{
		get
		{
			return this.SkinIdInternal;
		}
	}

	// Token: 0x17001B47 RID: 6983
	// (get) Token: 0x06014F25 RID: 85797 RVA: 0x00550D51 File Offset: 0x0054EF51
	public int ElementId
	{
		get
		{
			return this.ElementIdInternal;
		}
	}

	// Token: 0x17001B48 RID: 6984
	// (get) Token: 0x06014F26 RID: 85798 RVA: 0x00550D59 File Offset: 0x0054EF59
	public int Level
	{
		get
		{
			return this.LevelInternal;
		}
	}

	// Token: 0x17001B49 RID: 6985
	// (get) Token: 0x06014F27 RID: 85799 RVA: 0x00550D61 File Offset: 0x0054EF61
	public bool IsInTeam
	{
		get
		{
			return this.IsInTeamInternal;
		}
	}

	// Token: 0x17001B4A RID: 6986
	// (get) Token: 0x06014F28 RID: 85800 RVA: 0x00550D69 File Offset: 0x0054EF69
	public bool IsTrial
	{
		get
		{
			return this.IsTrialInternal;
		}
	}

	// Token: 0x17001B4B RID: 6987
	// (get) Token: 0x06014F29 RID: 85801 RVA: 0x00550D71 File Offset: 0x0054EF71
	public bool IsNew
	{
		get
		{
			return this.IsNewInternal;
		}
	}

	// Token: 0x17001B4C RID: 6988
	// (get) Token: 0x06014F2A RID: 85802 RVA: 0x00550D79 File Offset: 0x0054EF79
	public ERoleTypeTag TypeTag
	{
		get
		{
			return this.TypeTagInternal;
		}
	}

	// Token: 0x17001B4D RID: 6989
	// (get) Token: 0x06014F2B RID: 85803
	public abstract ERoleDisplaySourceType SourceType { get; }

	// Token: 0x17001B4E RID: 6990
	// (get) Token: 0x06014F2C RID: 85804
	[Nullable(2)]
	public abstract RoleDataBase OriginRoleData { [NullableContext(2)] get; }

	// Token: 0x06014F2D RID: 85805 RVA: 0x00550D84 File Offset: 0x0054EF84
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

	// Token: 0x04009D8A RID: 40330
	private int IdInternal;

	// Token: 0x04009D8B RID: 40331
	private string NameInternal;

	// Token: 0x04009D8C RID: 40332
	private int SkinIdInternal;

	// Token: 0x04009D8D RID: 40333
	private int ElementIdInternal;

	// Token: 0x04009D8E RID: 40334
	private int LevelInternal;

	// Token: 0x04009D8F RID: 40335
	private bool IsInTeamInternal;

	// Token: 0x04009D90 RID: 40336
	private bool IsTrialInternal;

	// Token: 0x04009D91 RID: 40337
	private bool IsNewInternal;

	// Token: 0x04009D92 RID: 40338
	private ERoleTypeTag TypeTagInternal;
}
