using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001C73 RID: 7283
[NullableContext(2)]
[Nullable(0)]
public class MultiTeamRoleGridData
{
	// Token: 0x06012108 RID: 73992 RVA: 0x0054FB4F File Offset: 0x0054DD4F
	public RoleDataBase GetRole()
	{
		return this.Role;
	}

	// Token: 0x06012109 RID: 73993 RVA: 0x0054FB57 File Offset: 0x0054DD57
	public MediumItemGridCostComponentData GetShowCostData()
	{
		return this.ShowCostData;
	}

	// Token: 0x0601210A RID: 73994 RVA: 0x0054FB5F File Offset: 0x0054DD5F
	public bool GetUseRoleItemAddtion()
	{
		return this.UseRoleItemAddtion;
	}

	// Token: 0x0601210B RID: 73995 RVA: 0x0054FB67 File Offset: 0x0054DD67
	public bool GetIsRecommend()
	{
		return this.IsRecommend;
	}

	// Token: 0x0601210C RID: 73996 RVA: 0x0054FB6F File Offset: 0x0054DD6F
	public bool GetIsHighlight()
	{
		return this.IsHighlight;
	}

	// Token: 0x0601210D RID: 73997 RVA: 0x0054FB77 File Offset: 0x0054DD77
	public bool GetIsLock()
	{
		return this.IsLock;
	}

	// Token: 0x0601210E RID: 73998 RVA: 0x0054FB7F File Offset: 0x0054DD7F
	public bool GetIsDisable()
	{
		return this.IsDisable;
	}

	// Token: 0x0601210F RID: 73999 RVA: 0x0054FB87 File Offset: 0x0054DD87
	public bool GetIsUnRecommend()
	{
		return this.IsUnRecommend;
	}

	// Token: 0x06012110 RID: 74000 RVA: 0x0054FB8F File Offset: 0x0054DD8F
	public bool GetIsWarning()
	{
		return this.IsWarning;
	}

	// Token: 0x06012111 RID: 74001 RVA: 0x0054FB98 File Offset: 0x0054DD98
	[NullableContext(1)]
	public static MultiTeamRoleGridData Phrase(RoleDataBase role, bool isRecommend, bool isHighlight, bool isLock = false, bool isUnRecommend = false, [Nullable(2)] MediumItemGridCostComponentData showCostData = null, bool isDisable = false, bool useRoleItemAddtion = false, bool isWarning = false)
	{
		return new MultiTeamRoleGridData
		{
			Role = role,
			IsRecommend = isRecommend,
			IsHighlight = isHighlight,
			IsLock = isLock,
			IsUnRecommend = isUnRecommend,
			ShowCostData = showCostData,
			IsDisable = isDisable,
			UseRoleItemAddtion = useRoleItemAddtion,
			IsWarning = isWarning
		};
	}

	// Token: 0x04009D78 RID: 40312
	private RoleDataBase Role;

	// Token: 0x04009D79 RID: 40313
	private bool IsRecommend;

	// Token: 0x04009D7A RID: 40314
	private bool IsHighlight;

	// Token: 0x04009D7B RID: 40315
	private bool IsLock;

	// Token: 0x04009D7C RID: 40316
	private bool IsUnRecommend;

	// Token: 0x04009D7D RID: 40317
	private bool IsDisable;

	// Token: 0x04009D7E RID: 40318
	private MediumItemGridCostComponentData ShowCostData;

	// Token: 0x04009D7F RID: 40319
	private bool UseRoleItemAddtion;

	// Token: 0x04009D80 RID: 40320
	private bool IsWarning;
}
