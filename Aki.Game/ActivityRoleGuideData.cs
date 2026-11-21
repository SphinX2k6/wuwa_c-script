using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000977 RID: 2423
[NullableContext(1)]
[Nullable(0)]
public class ActivityRoleGuideData : ActivityBaseData
{
	// Token: 0x17000D2B RID: 3371
	// (get) Token: 0x06006A52 RID: 27218 RVA: 0x00211E3F File Offset: 0x0021003F
	// (set) Token: 0x06006A53 RID: 27219 RVA: 0x00211E47 File Offset: 0x00210047
	public RoleGuideActivity? RoleGuideConfig { get; set; }

	// Token: 0x06006A54 RID: 27220 RVA: 0x00211E50 File Offset: 0x00210050
	protected override void PhraseEx(ActivityData data)
	{
		this.RoleGuideConfig = ActivityRoleGuideConfig.Instance.GetRoleTrialActivityConfig(base.Id);
		if (this.RoleGuideConfig == null)
		{
			return;
		}
		this.RoleId = this.RoleGuideConfig.Value.RoleId;
		this.RoleQuestId = this.RoleGuideConfig.Value.RoleQuestId;
		this.RoleTrialId = this.RoleGuideConfig.Value.RoleTrialId;
		this.ShowQuestId = this.RoleGuideConfig.Value.ShowQuestId;
	}

	// Token: 0x06006A55 RID: 27221 RVA: 0x00211EF4 File Offset: 0x002100F4
	public string GetRoleResourcePath()
	{
		string roleUi = this.RoleGuideConfig.Value.RoleUi;
		return UiResourceConfig.Instance.GetResourcePath(roleUi) ?? "";
	}

	// Token: 0x06006A56 RID: 27222 RVA: 0x00211F2C File Offset: 0x0021012C
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06006A57 RID: 27223 RVA: 0x00211F2F File Offset: 0x0021012F
	public override bool GetExDataRedPointShowState()
	{
		return false;
	}

	// Token: 0x04004312 RID: 17170
	public int RoleId;

	// Token: 0x04004313 RID: 17171
	public int RoleQuestId;

	// Token: 0x04004314 RID: 17172
	public int RoleTrialId;

	// Token: 0x04004315 RID: 17173
	public int ShowQuestId;
}
