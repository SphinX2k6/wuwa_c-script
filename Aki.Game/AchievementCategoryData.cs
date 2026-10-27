using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F13 RID: 3859
[NullableContext(1)]
[Nullable(0)]
public class AchievementCategoryData
{
	// Token: 0x17000795 RID: 1941
	// (get) Token: 0x0600616C RID: 24940 RVA: 0x0012FEF2 File Offset: 0x0012E0F2
	// (set) Token: 0x0600616D RID: 24941 RVA: 0x0012FEFA File Offset: 0x0012E0FA
	public long UUID { get; set; }

	// Token: 0x0600616E RID: 24942 RVA: 0x0012FF03 File Offset: 0x0012E103
	public void OnSetUUID(long uuid)
	{
		this.Id = (int)this.UUID;
	}

	// Token: 0x0600616F RID: 24943 RVA: 0x0012FF12 File Offset: 0x0012E112
	public AchievementCategoryData(int id)
	{
		this.Id = id;
	}

	// Token: 0x06006170 RID: 24944 RVA: 0x0012FF21 File Offset: 0x0012E121
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06006171 RID: 24945 RVA: 0x0012FF29 File Offset: 0x0012E129
	public EAchievementFunctionType GetFunctionType()
	{
		return (EAchievementFunctionType)AchievementConfig.Instance.GetCategoryFunctionType(this.Id);
	}

	// Token: 0x06006172 RID: 24946 RVA: 0x0012FF3B File Offset: 0x0012E13B
	public string GetOrignalTitle()
	{
		return AchievementConfig.Instance.GetCategoryOriginalTitle(this.Id);
	}

	// Token: 0x06006173 RID: 24947 RVA: 0x0012FF4D File Offset: 0x0012E14D
	public string GetTitle()
	{
		return AchievementConfig.Instance.GetCategoryTitle(this.Id);
	}

	// Token: 0x06006174 RID: 24948 RVA: 0x0012FF5F File Offset: 0x0012E15F
	public string GetTexture()
	{
		return AchievementConfig.Instance.GetCategoryTexture(this.Id);
	}

	// Token: 0x06006175 RID: 24949 RVA: 0x0012FF71 File Offset: 0x0012E171
	public string GetSprite()
	{
		return AchievementConfig.Instance.GetCategorySprite(this.Id);
	}

	// Token: 0x06006176 RID: 24950 RVA: 0x0012FF84 File Offset: 0x0012E184
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

	// Token: 0x04002C4F RID: 11343
	private int Id;
}
