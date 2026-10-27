using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020014C3 RID: 5315
[NullableContext(1)]
[Nullable(0)]
public class ActivityRoleGuideData : ActivityBaseData
{
	// Token: 0x17000D0B RID: 3339
	// (get) Token: 0x060096BD RID: 38589 RVA: 0x00208ED3 File Offset: 0x002070D3
	// (set) Token: 0x060096BE RID: 38590 RVA: 0x00208EDB File Offset: 0x002070DB
	public RoleGuideActivity? RoleGuideConfig { get; set; }

	// Token: 0x060096BF RID: 38591 RVA: 0x00208EE4 File Offset: 0x002070E4
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

	// Token: 0x060096C0 RID: 38592 RVA: 0x00208F88 File Offset: 0x00207188
	public string GetRoleResourcePath()
	{
		string roleUi = this.RoleGuideConfig.Value.RoleUi;
		return UiResourceConfig.Instance.GetResourcePath(roleUi) ?? "";
	}

	// Token: 0x060096C1 RID: 38593 RVA: 0x00208FC0 File Offset: 0x002071C0
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x060096C2 RID: 38594 RVA: 0x00208FC3 File Offset: 0x002071C3
	public override bool GetExDataRedPointShowState()
	{
		return false;
	}

	// Token: 0x0400427A RID: 17018
	public int RoleId;

	// Token: 0x0400427B RID: 17019
	public int RoleQuestId;

	// Token: 0x0400427C RID: 17020
	public int RoleTrialId;

	// Token: 0x0400427D RID: 17021
	public int ShowQuestId;
}
