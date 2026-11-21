using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;

// Token: 0x020026B8 RID: 9912
[NullableContext(1)]
[Nullable(0)]
public class MultiSkillData
{
	// Token: 0x06018D70 RID: 101744 RVA: 0x0078A70A File Offset: 0x0078890A
	public void Init(int entityId, int visionEntityId = 0)
	{
		this.EntityId = entityId;
		this.VisionEntityId = visionEntityId;
	}

	// Token: 0x06018D71 RID: 101745 RVA: 0x0078A71A File Offset: 0x0078891A
	public bool IsMultiSkill(SSkillInfo skillInfo)
	{
		return skillInfo.CooldownConfig.SectionCount > 1;
	}

	// Token: 0x06018D72 RID: 101746 RVA: 0x0078A72C File Offset: 0x0078892C
	public bool CanStartMultiSkill(Skill skill)
	{
		int skillId = skill.SkillId;
		MultiSkillInfo valueOrDefault = this.MultiSkillInfoMap.GetValueOrDefault((long)skillId);
		SSkillCooldownInfo cooldownConfig = skill.SkillInfo.CooldownConfig;
		if (valueOrDefault == null)
		{
			return cooldownConfig.SectionCount - cooldownConfig.SectionRemaining == 1;
		}
		if (valueOrDefault.NextSkillId != null)
		{
			int? nextSkillId = valueOrDefault.NextSkillId;
			int num = 0;
			if (!(nextSkillId.GetValueOrDefault() == num & nextSkillId != null))
			{
				nextSkillId = valueOrDefault.NextSkillId;
				num = skillId;
				return (nextSkillId.GetValueOrDefault() == num & nextSkillId != null) && valueOrDefault.RemainingStartTime <= 0.0;
			}
		}
		return valueOrDefault.FirstSkillId == skillId;
	}

	// Token: 0x06018D73 RID: 101747 RVA: 0x0078A7E0 File Offset: 0x007889E0
	public bool StartMultiSkill(Skill skill, bool bCheck = true)
	{
		if (bCheck && !this.CanStartMultiSkill(skill))
		{
			return false;
		}
		int skillId = skill.SkillId;
		SSkillCooldownInfo cooldownConfig = skill.SkillInfo.CooldownConfig;
		MultiSkillInfo multiSkillInfo;
		if (!this.MultiSkillInfoMap.TryGetValue((long)skillId, out multiSkillInfo))
		{
			multiSkillInfo = new MultiSkillInfo();
			multiSkillInfo.FirstSkillId = skillId;
			this.MultiSkillInfoMap[(long)skillId] = multiSkillInfo;
			this.MultiSkillInfos.Add(multiSkillInfo);
		}
		multiSkillInfo.CurSkillId = skillId;
		multiSkillInfo.NextSkillId = new int?((int)cooldownConfig.NextSkillId);
		multiSkillInfo.IsReset = cooldownConfig.IsReset;
		multiSkillInfo.IsResetOnChangeRole = cooldownConfig.IsResetOnChangeRole;
		int? nextSkillId = multiSkillInfo.NextSkillId;
		int num = 0;
		if (nextSkillId.GetValueOrDefault() == num & nextSkillId != null)
		{
			this.DispatchMultiSkillIdChangedEvent(multiSkillInfo);
			return true;
		}
		multiSkillInfo.StartTime = cooldownConfig.StartTime;
		multiSkillInfo.MultiSkillStartStamp = Time.Instance.FlowTime + (double)(cooldownConfig.StartTime * (float)TimeUtil.Instance.InverseMillisecond);
		multiSkillInfo.StopTime = cooldownConfig.StopTime;
		multiSkillInfo.MultiSkillStopStamp = Time.Instance.FlowTime + (double)(cooldownConfig.StopTime * (float)TimeUtil.Instance.InverseMillisecond);
		this.MultiSkillInfoMap[(long)multiSkillInfo.NextSkillId.Value] = multiSkillInfo;
		this.StartNextSkillTimer(multiSkillInfo);
		this.DispatchMultiSkillIdChangedEvent(multiSkillInfo);
		return true;
	}

	// Token: 0x06018D74 RID: 101748 RVA: 0x0078A928 File Offset: 0x00788B28
	private void RemoveTimers(MultiSkillInfo info)
	{
		if (info.MultiSkillStartTimer != null)
		{
			TimerSystem.FlowTimeInstance.Remove(info.MultiSkillStartTimer);
			info.MultiSkillStartTimer = null;
		}
		if (info.MultiSkillStopTimer != null)
		{
			TimerSystem.FlowTimeInstance.Remove(info.MultiSkillStopTimer);
			info.MultiSkillStopTimer = null;
		}
	}

	// Token: 0x06018D75 RID: 101749 RVA: 0x0078A978 File Offset: 0x00788B78
	public void InitMultiSkillInfo(Dictionary<int, Skill> skills)
	{
		foreach (KeyValuePair<int, Skill> keyValuePair in skills)
		{
			int key = keyValuePair.Key;
			SSkillInfo skillInfo = keyValuePair.Value.SkillInfo;
			if (!(skillInfo == null) && skillInfo.CooldownConfig.SectionCount != 0)
			{
				SSkillCooldownInfo cooldownConfig = skillInfo.CooldownConfig;
				if (cooldownConfig.SectionCount - cooldownConfig.SectionRemaining == 1)
				{
					MultiSkillInfo multiSkillInfo = new MultiSkillInfo();
					multiSkillInfo.FirstSkillId = key;
					this.MultiSkillInfoMap[(long)key] = multiSkillInfo;
					this.MultiSkillInfos.Add(multiSkillInfo);
					int num = (int)cooldownConfig.NextSkillId;
					int i = cooldownConfig.SectionCount - 1;
					while (i > 0)
					{
						i--;
						Skill skill;
						if (!skills.TryGetValue(num, out skill))
						{
							break;
						}
						this.MultiSkillInfoMap[(long)num] = multiSkillInfo;
						long? num2;
						if (skill == null)
						{
							num2 = null;
						}
						else
						{
							SSkillInfo skillInfo2 = skill.SkillInfo;
							num2 = ((skillInfo2 != null) ? new long?(skillInfo2.CooldownConfig.NextSkillId) : null);
						}
						long? num3 = num2;
						num = (int)num3.GetValueOrDefault();
						if (num == 0)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06018D76 RID: 101750 RVA: 0x0078AAD0 File Offset: 0x00788CD0
	private void StartNextSkillTimer(MultiSkillInfo info)
	{
		this.RemoveTimers(info);
		if (info.StartTime > 0f)
		{
			info.MultiSkillStartTimer = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				info.MultiSkillStartStamp = 0.0;
				this.DispatchMultiSkillEnableEvent(info);
				info.MultiSkillStartTimer = null;
			}, info.StartTime * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}
		if (info.StopTime > 0f)
		{
			info.MultiSkillStopTimer = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				info.MultiSkillStopStamp = 0.0;
				info.NextSkillId = new int?(0);
				this.DispatchMultiSkillIdChangedEvent(info);
				info.MultiSkillStopTimer = null;
			}, info.StopTime * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}
	}

	// Token: 0x06018D77 RID: 101751 RVA: 0x0078ABA1 File Offset: 0x00788DA1
	private void AheadFinishMultiSkill(MultiSkillInfo info, string reason)
	{
		info.NextSkillId = new int?(0);
		info.MultiSkillStartStamp = 0.0;
		info.MultiSkillStopStamp = 0.0;
		this.DispatchMultiSkillIdChangedEvent(info);
		this.RemoveTimers(info);
	}

	// Token: 0x06018D78 RID: 101752 RVA: 0x0078ABDC File Offset: 0x00788DDC
	public void ResetMultiSkills(int skillId, bool ignoreIsReset = false)
	{
		MultiSkillInfo multiSkillInfo;
		if (!this.MultiSkillInfoMap.TryGetValue((long)skillId, out multiSkillInfo))
		{
			return;
		}
		if (!multiSkillInfo.IsReset && !ignoreIsReset)
		{
			return;
		}
		if (multiSkillInfo.NextSkillId == null)
		{
			return;
		}
		if (multiSkillInfo.CurSkillId != skillId)
		{
			return;
		}
		this.AheadFinishMultiSkill(multiSkillInfo, "多段技能被打断");
	}

	// Token: 0x06018D79 RID: 101753 RVA: 0x0078AC2C File Offset: 0x00788E2C
	public void ResetOnChangeRole()
	{
		foreach (MultiSkillInfo multiSkillInfo in this.MultiSkillInfos)
		{
			if (multiSkillInfo.IsResetOnChangeRole)
			{
				this.AheadFinishMultiSkill(multiSkillInfo, "换人时清理所有多段技能");
			}
		}
	}

	// Token: 0x06018D7A RID: 101754 RVA: 0x0078AC8C File Offset: 0x00788E8C
	public void ClearAllSkill()
	{
		foreach (MultiSkillInfo multiSkillInfo in this.MultiSkillInfos)
		{
			int? nextSkillId = multiSkillInfo.NextSkillId;
			int num = 0;
			if (!(nextSkillId.GetValueOrDefault() == num & nextSkillId != null))
			{
				this.AheadFinishMultiSkill(multiSkillInfo, "清理所有多段技能");
			}
		}
	}

	// Token: 0x06018D7B RID: 101755 RVA: 0x0078AD04 File Offset: 0x00788F04
	public long GetNextMultiSkillId(int skillId)
	{
		MultiSkillInfo multiSkillInfo;
		if (!this.MultiSkillInfoMap.TryGetValue((long)skillId, out multiSkillInfo))
		{
			return (long)skillId;
		}
		if (multiSkillInfo.NextSkillId == null || multiSkillInfo.NextSkillId.Value == 0)
		{
			return (long)multiSkillInfo.FirstSkillId;
		}
		return (long)multiSkillInfo.NextSkillId.Value;
	}

	// Token: 0x06018D7C RID: 101756 RVA: 0x0078AD53 File Offset: 0x00788F53
	[NullableContext(2)]
	public MultiSkillInfo GetMultiSkillInfo(int skillId)
	{
		return this.MultiSkillInfoMap.GetValueOrDefault((long)skillId);
	}

	// Token: 0x06018D7D RID: 101757 RVA: 0x0078AD62 File Offset: 0x00788F62
	private void DispatchMultiSkillIdChangedEvent(MultiSkillInfo info)
	{
		EventSystem.Instance.Emit<int, MultiSkillInfo, int>(EEventName.OnMultiSkillIdChanged, this.EntityId, info, this.VisionEntityId);
	}

	// Token: 0x06018D7E RID: 101758 RVA: 0x0078AD7E File Offset: 0x00788F7E
	private void DispatchMultiSkillEnableEvent(MultiSkillInfo info)
	{
		EventSystem.Instance.Emit<int, MultiSkillInfo, int>(EEventName.OnMultiSkillEnable, this.EntityId, info, this.VisionEntityId);
	}

	// Token: 0x0400D79F RID: 55199
	public Dictionary<long, MultiSkillInfo> MultiSkillInfoMap = new Dictionary<long, MultiSkillInfo>();

	// Token: 0x0400D7A0 RID: 55200
	public List<MultiSkillInfo> MultiSkillInfos = new List<MultiSkillInfo>();

	// Token: 0x0400D7A1 RID: 55201
	public int EntityId;

	// Token: 0x0400D7A2 RID: 55202
	public int VisionEntityId;
}
