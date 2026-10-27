using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;

// Token: 0x02002468 RID: 9320
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractDetailViewModel
{
	// Token: 0x1700187F RID: 6271
	// (get) Token: 0x06012B6D RID: 76653 RVA: 0x0049E388 File Offset: 0x0049C588
	// (set) Token: 0x06012B6E RID: 76654 RVA: 0x0049E390 File Offset: 0x0049C590
	public int MonsterId { get; set; }

	// Token: 0x17001880 RID: 6272
	// (get) Token: 0x06012B6F RID: 76655 RVA: 0x0049E399 File Offset: 0x0049C599
	// (set) Token: 0x06012B70 RID: 76656 RVA: 0x0049E3A1 File Offset: 0x0049C5A1
	public string IconPath { get; set; }

	// Token: 0x17001881 RID: 6273
	// (get) Token: 0x06012B71 RID: 76657 RVA: 0x0049E3AA File Offset: 0x0049C5AA
	// (set) Token: 0x06012B72 RID: 76658 RVA: 0x0049E3B2 File Offset: 0x0049C5B2
	public string Name { get; set; }

	// Token: 0x17001882 RID: 6274
	// (get) Token: 0x06012B73 RID: 76659 RVA: 0x0049E3BB File Offset: 0x0049C5BB
	// (set) Token: 0x06012B74 RID: 76660 RVA: 0x0049E3C3 File Offset: 0x0049C5C3
	public bool IsSpecial { get; set; }

	// Token: 0x17001883 RID: 6275
	// (get) Token: 0x06012B75 RID: 76661 RVA: 0x0049E3CC File Offset: 0x0049C5CC
	// (set) Token: 0x06012B76 RID: 76662 RVA: 0x0049E3D4 File Offset: 0x0049C5D4
	public bool IsInArea { get; set; }

	// Token: 0x17001884 RID: 6276
	// (get) Token: 0x06012B77 RID: 76663 RVA: 0x0049E3DD File Offset: 0x0049C5DD
	// (set) Token: 0x06012B78 RID: 76664 RVA: 0x0049E3E5 File Offset: 0x0049C5E5
	public bool IsUnlocked { get; set; }

	// Token: 0x17001885 RID: 6277
	// (get) Token: 0x06012B79 RID: 76665 RVA: 0x0049E3EE File Offset: 0x0049C5EE
	// (set) Token: 0x06012B7A RID: 76666 RVA: 0x0049E3F6 File Offset: 0x0049C5F6
	public string SkillPicturePath { get; set; }

	// Token: 0x17001886 RID: 6278
	// (get) Token: 0x06012B7B RID: 76667 RVA: 0x0049E3FF File Offset: 0x0049C5FF
	// (set) Token: 0x06012B7C RID: 76668 RVA: 0x0049E407 File Offset: 0x0049C607
	public string SkillName { get; set; }

	// Token: 0x17001887 RID: 6279
	// (get) Token: 0x06012B7D RID: 76669 RVA: 0x0049E410 File Offset: 0x0049C610
	// (set) Token: 0x06012B7E RID: 76670 RVA: 0x0049E418 File Offset: 0x0049C618
	public string SkillDescription { get; set; }

	// Token: 0x17001888 RID: 6280
	// (get) Token: 0x06012B7F RID: 76671 RVA: 0x0049E421 File Offset: 0x0049C621
	// (set) Token: 0x06012B80 RID: 76672 RVA: 0x0049E429 File Offset: 0x0049C629
	public IGetWayItemData GetWayItemData { get; set; }

	// Token: 0x17001889 RID: 6281
	// (get) Token: 0x06012B81 RID: 76673 RVA: 0x0049E432 File Offset: 0x0049C632
	public bool NeedGetWay
	{
		get
		{
			return this.IsSpecial && !this.IsUnlocked;
		}
	}

	// Token: 0x1700188A RID: 6282
	// (get) Token: 0x06012B82 RID: 76674 RVA: 0x0049E447 File Offset: 0x0049C647
	// (set) Token: 0x06012B83 RID: 76675 RVA: 0x0049E44F File Offset: 0x0049C64F
	private int GetWayConfigId { get; set; }

	// Token: 0x06012B84 RID: 76676 RVA: 0x0049E458 File Offset: 0x0049C658
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
