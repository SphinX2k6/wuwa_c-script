using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003C8 RID: 968
[NullableContext(1)]
[Nullable(0)]
public class AchievementCategoryData
{
	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x06003504 RID: 13572 RVA: 0x00138816 File Offset: 0x00136A16
	// (set) Token: 0x06003505 RID: 13573 RVA: 0x0013881E File Offset: 0x00136A1E
	public long UUID { get; set; }

	// Token: 0x06003506 RID: 13574 RVA: 0x00138827 File Offset: 0x00136A27
	public void OnSetUUID(long uuid)
	{
		this.Id = (int)this.UUID;
	}

	// Token: 0x06003507 RID: 13575 RVA: 0x00138836 File Offset: 0x00136A36
	public AchievementCategoryData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06003508 RID: 13576 RVA: 0x00138845 File Offset: 0x00136A45
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06003509 RID: 13577 RVA: 0x0013884D File Offset: 0x00136A4D
	public EAchievementFunctionType GetFunctionType()
	{
		return (EAchievementFunctionType)AchievementConfig.Instance.GetCategoryFunctionType(this.Id);
	}

	// Token: 0x0600350A RID: 13578 RVA: 0x0013885F File Offset: 0x00136A5F
	public string GetOrignalTitle()
	{
		return AchievementConfig.Instance.GetCategoryOriginalTitle(this.Id);
	}

	// Token: 0x0600350B RID: 13579 RVA: 0x00138871 File Offset: 0x00136A71
	public string GetTitle()
	{
		return AchievementConfig.Instance.GetCategoryTitle(this.Id);
	}

	// Token: 0x0600350C RID: 13580 RVA: 0x00138883 File Offset: 0x00136A83
	public string GetTexture()
	{
		return AchievementConfig.Instance.GetCategoryTexture(this.Id);
	}

	// Token: 0x0600350D RID: 13581 RVA: 0x00138895 File Offset: 0x00136A95
	public string GetSprite()
	{
		return AchievementConfig.Instance.GetCategorySprite(this.Id);
	}

	// Token: 0x0600350E RID: 13582 RVA: 0x001388A8 File Offset: 0x00136AA8
	public string GetAchievementCategoryProgress()
	{
		List<AchievementGroupData> achievementCategoryGroups = AchievementModel.Instance.GetAchievementCategoryGroups(this.Id, true);
		int num = 0;
		int num2 = 0;
		foreach (AchievementGroupData achievementGroupData in achievementCategoryGroups)
		{
			foreach (AchievementData achievementData in AchievementModel.Instance.GetGroupAchievements(achievementGroupData.GetId(), false))
			{
				EAchievementStateEnum finishState = achievementData.GetFinishState();
				if ((!achievementData.GetHiddenState() || finishState != EAchievementStateEnum.UnFinished) && achievementData.GetMaxProgress() != null)
				{
					num++;
					if (finishState != EAchievementStateEnum.UnFinished)
					{
						num2++;
					}
				}
			}
		}
		int value = (int)Math.Round((double)num2 * 100.0 / (double)num);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x04002CE8 RID: 11496
	private int Id;
}
