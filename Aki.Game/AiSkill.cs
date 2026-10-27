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
	// Token: 0x06000DFE RID: 3582 RVA: 0x0004FBC0 File Offset: 0x0004DDC0
	public AiSkill(AiController aiController)
	{
		this.AiController = aiController;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x0004FC14 File Offset: 0x0004DE14
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

	// Token: 0x06000E00 RID: 3584 RVA: 0x0004FC59 File Offset: 0x0004DE59
	public void AddSkillCd(int skillInfoId, float cdAdd)
	{
		this.AiController.AddCoolDownTime(skillInfoId, (double)cdAdd);
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x0004FC69 File Offset: 0x0004DE69
	public bool CanActivate(int skillInfoId)
	{
		return this.AiController.GetCoolDownReady(skillInfoId);
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x0004FC78 File Offset: 0x0004DE78
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

	// Token: 0x06000E03 RID: 3587 RVA: 0x0004FCF4 File Offset: 0x0004DEF4
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

	// Token: 0x06000E04 RID: 3588 RVA: 0x0004FD31 File Offset: 0x0004DF31
	public void ChangeSkillWeight(int skillInfoId, float weight)
	{
		if (weight > 0f)
		{
			this.ChangedSkillWeights[skillInfoId] = weight;
			return;
		}
		this.ChangedSkillWeights.Remove(skillInfoId);
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x0004FD58 File Offset: 0x0004DF58
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

	// Token: 0x06000E06 RID: 3590 RVA: 0x0004FDFC File Offset: 0x0004DFFC
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

	// Token: 0x04000B65 RID: 2917
	private readonly AiController AiController;

	// Token: 0x04000B66 RID: 2918
	public AiBaseSkill? BaseSkill;

	// Token: 0x04000B67 RID: 2919
	public readonly Dictionary<int, AiSkillInfos> SkillInfos = new Dictionary<int, AiSkillInfos>();

	// Token: 0x04000B68 RID: 2920
	public readonly Dictionary<int, AiSkillPrecondition> SkillPreconditionMap = new Dictionary<int, AiSkillPrecondition>();

	// Token: 0x04000B69 RID: 2921
	public readonly Dictionary<int, FGameplayTag> PreconditionTagMap = new Dictionary<int, FGameplayTag>();

	// Token: 0x04000B6A RID: 2922
	private readonly Dictionary<int, float> ChangedSkillWeights = new Dictionary<int, float>();

	// Token: 0x04000B6B RID: 2923
	public readonly HashSet<int> ActiveSkillGroup = new HashSet<int>();
}
