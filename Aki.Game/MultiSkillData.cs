using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;

// Token: 0x0200314B RID: 12619
[NullableContext(1)]
[Nullable(0)]
public class MultiSkillData
{
	// Token: 0x0601B26D RID: 111213 RVA: 0x00762D10 File Offset: 0x00760F10
	public void Init(int entityId, int visionEntityId = 0)
	{
		this.EntityId = entityId;
		this.VisionEntityId = visionEntityId;
	}

	// Token: 0x0601B26E RID: 111214 RVA: 0x00762D20 File Offset: 0x00760F20
	public bool IsMultiSkill(SSkillInfo skillInfo)
	{
		return skillInfo.CooldownConfig.SectionCount > 1;
	}

	// Token: 0x0601B26F RID: 111215 RVA: 0x00762D30 File Offset: 0x00760F30
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

	// Token: 0x0601B270 RID: 111216 RVA: 0x00762DE4 File Offset: 0x00760FE4
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

	// Token: 0x0601B271 RID: 111217 RVA: 0x00762F2C File Offset: 0x0076112C
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

	// Token: 0x0601B272 RID: 111218 RVA: 0x00762F7C File Offset: 0x0076117C
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

	// Token: 0x0601B273 RID: 111219 RVA: 0x007630D4 File Offset: 0x007612D4
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

	// Token: 0x0601B274 RID: 111220 RVA: 0x007631A5 File Offset: 0x007613A5
	private void AheadFinishMultiSkill(MultiSkillInfo info, string reason)
	{
		info.NextSkillId = new int?(0);
		info.MultiSkillStartStamp = 0.0;
		info.MultiSkillStopStamp = 0.0;
		this.DispatchMultiSkillIdChangedEvent(info);
		this.RemoveTimers(info);
	}

	// Token: 0x0601B275 RID: 111221 RVA: 0x007631E0 File Offset: 0x007613E0
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

	// Token: 0x0601B276 RID: 111222 RVA: 0x00763230 File Offset: 0x00761430
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

	// Token: 0x0601B277 RID: 111223 RVA: 0x00763290 File Offset: 0x00761490
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

	// Token: 0x0601B278 RID: 111224 RVA: 0x00763308 File Offset: 0x00761508
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

	// Token: 0x0601B279 RID: 111225 RVA: 0x00763357 File Offset: 0x00761557
	[NullableContext(2)]
	public MultiSkillInfo GetMultiSkillInfo(int skillId)
	{
		return this.MultiSkillInfoMap.GetValueOrDefault((long)skillId);
	}

	// Token: 0x0601B27A RID: 111226 RVA: 0x00763366 File Offset: 0x00761566
	private void DispatchMultiSkillIdChangedEvent(MultiSkillInfo info)
	{
		EventSystem.Instance.Emit<int, MultiSkillInfo, int>(EEventName.OnMultiSkillIdChanged, this.EntityId, info, this.VisionEntityId);
	}

	// Token: 0x0601B27B RID: 111227 RVA: 0x00763382 File Offset: 0x00761582
	private void DispatchMultiSkillEnableEvent(MultiSkillInfo info)
	{
		EventSystem.Instance.Emit<int, MultiSkillInfo, int>(EEventName.OnMultiSkillEnable, this.EntityId, info, this.VisionEntityId);
	}

	// Token: 0x0400D33C RID: 54076
	public Dictionary<long, MultiSkillInfo> MultiSkillInfoMap = new Dictionary<long, MultiSkillInfo>();

	// Token: 0x0400D33D RID: 54077
	public List<MultiSkillInfo> MultiSkillInfos = new List<MultiSkillInfo>();

	// Token: 0x0400D33E RID: 54078
	public int EntityId;

	// Token: 0x0400D33F RID: 54079
	public int VisionEntityId;
}
