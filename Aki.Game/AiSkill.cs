using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020000F7 RID: 247
[NullableContext(1)]
[Nullable(0)]
public class AiSkill
{
	// Token: 0x06000E04 RID: 3588 RVA: 0x00050750 File Offset: 0x0004E950
	public AiSkill(AiController aiController)
	{
		this.AiController = aiController;
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x000507A4 File Offset: 0x0004E9A4
	public void ActivateSkillGroup(int skillGroupIndex, bool activate)
	{
		if (skillGroupIndex >= 0 && skillGroupIndex < this.BaseSkill.Value.RandomSkillsLength)
		{
			if (activate)
			{
				this.ActiveSkillGroup.Add(skillGroupIndex);
				return;
			}
			this.ActiveSkillGroup.Remove(skillGroupIndex);
		}
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x000507E9 File Offset: 0x0004E9E9
	public void AddSkillCd(int skillInfoId, float cdAdd)
	{
		this.AiController.AddCoolDownTime(skillInfoId, (double)cdAdd);
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x000507F9 File Offset: 0x0004E9F9
	public bool CanActivate(int skillInfoId)
	{
		return this.AiController.GetCoolDownReady(skillInfoId);
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00050808 File Offset: 0x0004EA08
	public void SetSkillCdFromNow(int? skillInfoId)
	{
		if (skillInfoId == null)
		{
			return;
		}
		AiSkillInfos aiSkillInfos;
		if (this.SkillInfos.TryGetValue(skillInfoId.Value, out aiSkillInfos))
		{
			this.AiController.AddCoolDownTime(skillInfoId.Value, MathUtils.Instance.GetRandomRange((double)aiSkillInfos.SkillCdRange.Value.Min, (double)aiSkillInfos.SkillCdRange.Value.Max));
		}
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00050884 File Offset: 0x0004EA84
	public float GetSkillWeight(int skillInfoId)
	{
		float result;
		if (this.ChangedSkillWeights.TryGetValue(skillInfoId, out result))
		{
			return result;
		}
		AiSkillInfos aiSkillInfos;
		if (!this.SkillInfos.TryGetValue(skillInfoId, out aiSkillInfos))
		{
			return 0f;
		}
		return (float)aiSkillInfos.SkillWeight;
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x000508C1 File Offset: 0x0004EAC1
	public void ChangeSkillWeight(int skillInfoId, float weight)
	{
		if (weight > 0f)
		{
			this.ChangedSkillWeights[skillInfoId] = weight;
			return;
		}
		this.ChangedSkillWeights.Remove(skillInfoId);
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x000508E8 File Offset: 0x0004EAE8
	public void InitTagMap()
	{
		this.PreconditionTagMap.Clear();
		foreach (KeyValuePair<int, AiSkillPrecondition> keyValuePair in this.SkillPreconditionMap)
		{
			if (!string.IsNullOrEmpty(keyValuePair.Value.NeedTag))
			{
				FGameplayTag? gameplayTagByName = GameplayTagUtils.GetGameplayTagByName(keyValuePair.Value.NeedTag);
				if (gameplayTagByName != null)
				{
					this.PreconditionTagMap[keyValuePair.Key] = gameplayTagByName.Value;
				}
			}
		}
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x0005098C File Offset: 0x0004EB8C
	public string GetCdDebugString()
	{
		string text = "";
		double num = GameModeModel.Instance.IsMulti ? TimeUtil.Instance.GetServerTimeStamp() : Time.Instance.WorldTime;
		foreach (KeyValuePair<int, ValueTuple<double, bool>> keyValuePair in this.AiController.AiCoolDownList)
		{
			int key = keyValuePair.Key;
			double item = keyValuePair.Value.Item1;
			text = string.Concat(new string[]
			{
				text,
				"\n\t\t\t",
				key.ToString(),
				" : ",
				MathF.Max(0f, (float)(item - num)).ToString()
			});
		}
		return text;
	}

	// Token: 0x04000B6D RID: 2925
	private readonly AiController AiController;

	// Token: 0x04000B6E RID: 2926
	public AiBaseSkill? BaseSkill;

	// Token: 0x04000B6F RID: 2927
	public readonly Dictionary<int, AiSkillInfos> SkillInfos = new Dictionary<int, AiSkillInfos>();

	// Token: 0x04000B70 RID: 2928
	public readonly Dictionary<int, AiSkillPrecondition> SkillPreconditionMap = new Dictionary<int, AiSkillPrecondition>();

	// Token: 0x04000B71 RID: 2929
	public readonly Dictionary<int, FGameplayTag> PreconditionTagMap = new Dictionary<int, FGameplayTag>();

	// Token: 0x04000B72 RID: 2930
	private readonly Dictionary<int, float> ChangedSkillWeights = new Dictionary<int, float>();

	// Token: 0x04000B73 RID: 2931
	public readonly HashSet<int> ActiveSkillGroup = new HashSet<int>();
}
