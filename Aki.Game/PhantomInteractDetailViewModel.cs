using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x0200194D RID: 6477
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractDetailViewModel
{
	// Token: 0x170018B9 RID: 6329
	// (get) Token: 0x06010025 RID: 65573 RVA: 0x004ABAF4 File Offset: 0x004A9CF4
	// (set) Token: 0x06010026 RID: 65574 RVA: 0x004ABAFC File Offset: 0x004A9CFC
	public int MonsterId { get; set; }

	// Token: 0x170018BA RID: 6330
	// (get) Token: 0x06010027 RID: 65575 RVA: 0x004ABB05 File Offset: 0x004A9D05
	// (set) Token: 0x06010028 RID: 65576 RVA: 0x004ABB0D File Offset: 0x004A9D0D
	public string IconPath { get; set; }

	// Token: 0x170018BB RID: 6331
	// (get) Token: 0x06010029 RID: 65577 RVA: 0x004ABB16 File Offset: 0x004A9D16
	// (set) Token: 0x0601002A RID: 65578 RVA: 0x004ABB1E File Offset: 0x004A9D1E
	public string Name { get; set; }

	// Token: 0x170018BC RID: 6332
	// (get) Token: 0x0601002B RID: 65579 RVA: 0x004ABB27 File Offset: 0x004A9D27
	// (set) Token: 0x0601002C RID: 65580 RVA: 0x004ABB2F File Offset: 0x004A9D2F
	public bool IsSpecial { get; set; }

	// Token: 0x170018BD RID: 6333
	// (get) Token: 0x0601002D RID: 65581 RVA: 0x004ABB38 File Offset: 0x004A9D38
	// (set) Token: 0x0601002E RID: 65582 RVA: 0x004ABB40 File Offset: 0x004A9D40
	public bool IsInArea { get; set; }

	// Token: 0x170018BE RID: 6334
	// (get) Token: 0x0601002F RID: 65583 RVA: 0x004ABB49 File Offset: 0x004A9D49
	// (set) Token: 0x06010030 RID: 65584 RVA: 0x004ABB51 File Offset: 0x004A9D51
	public bool IsUnlocked { get; set; }

	// Token: 0x170018BF RID: 6335
	// (get) Token: 0x06010031 RID: 65585 RVA: 0x004ABB5A File Offset: 0x004A9D5A
	// (set) Token: 0x06010032 RID: 65586 RVA: 0x004ABB62 File Offset: 0x004A9D62
	public string SkillPicturePath { get; set; }

	// Token: 0x170018C0 RID: 6336
	// (get) Token: 0x06010033 RID: 65587 RVA: 0x004ABB6B File Offset: 0x004A9D6B
	// (set) Token: 0x06010034 RID: 65588 RVA: 0x004ABB73 File Offset: 0x004A9D73
	public string SkillName { get; set; }

	// Token: 0x170018C1 RID: 6337
	// (get) Token: 0x06010035 RID: 65589 RVA: 0x004ABB7C File Offset: 0x004A9D7C
	// (set) Token: 0x06010036 RID: 65590 RVA: 0x004ABB84 File Offset: 0x004A9D84
	public string SkillDescription { get; set; }

	// Token: 0x170018C2 RID: 6338
	// (get) Token: 0x06010037 RID: 65591 RVA: 0x004ABB8D File Offset: 0x004A9D8D
	// (set) Token: 0x06010038 RID: 65592 RVA: 0x004ABB95 File Offset: 0x004A9D95
	public IGetWayItemData GetWayItemData { get; set; }

	// Token: 0x170018C3 RID: 6339
	// (get) Token: 0x06010039 RID: 65593 RVA: 0x004ABB9E File Offset: 0x004A9D9E
	public bool NeedGetWay
	{
		get
		{
			return this.IsSpecial && !this.IsUnlocked;
		}
	}

	// Token: 0x170018C4 RID: 6340
	// (get) Token: 0x0601003A RID: 65594 RVA: 0x004ABBB3 File Offset: 0x004A9DB3
	// (set) Token: 0x0601003B RID: 65595 RVA: 0x004ABBBB File Offset: 0x004A9DBB
	private int GetWayConfigId { get; set; }

	// Token: 0x0601003C RID: 65596 RVA: 0x004ABBC4 File Offset: 0x004A9DC4
	public void RefreshData(IPhantomInteractGridViewModel gridViewModel)
	{
		if (gridViewModel == null)
		{
			return;
		}
		this.MonsterId = gridViewModel.MonsterId;
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.MonsterId);
		if (calabashDevelopRewardByMonsterId == null)
		{
			return;
		}
		this.Name = gridViewModel.Name;
		this.IconPath = gridViewModel.IconPath;
		this.IsSpecial = gridViewModel.IsSpecial;
		this.IsInArea = gridViewModel.IsInArea;
		this.IsUnlocked = gridViewModel.IsUnlocked;
		this.SkillPicturePath = calabashDevelopRewardByMonsterId.Value.SpecialSkillPicturePath;
		this.SkillName = calabashDevelopRewardByMonsterId.Value.SpecialSkillName;
		this.SkillDescription = calabashDevelopRewardByMonsterId.Value.SpecialSkillDescription;
		if (this.NeedGetWay && this.GetWayConfigId != gridViewModel.GetWayConfigId)
		{
			this.GetWayItemData = null;
			this.GetWayConfigId = gridViewModel.GetWayConfigId;
			if (this.GetWayConfigId > 0)
			{
				AccessPath? getWayConfig = GetWayConfig.Instance.GetConfigById(this.GetWayConfigId);
				if (getWayConfig != null)
				{
					this.GetWayItemData = new GetWayItemData(getWayConfig.Value.Id, EGetWayItemType.CanJump, "PhantomDisplay_AccessTips", 0, delegate()
					{
						SkipTaskManager.RunByConfigId(getWayConfig.Value.Id, null);
					});
				}
			}
		}
	}
}
