using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x0200306C RID: 12396
[NullableContext(2)]
[Nullable(0)]
public class InputContinuously
{
	// Token: 0x0601A6A4 RID: 108196 RVA: 0x0070B281 File Offset: 0x00709481
	[NullableContext(1)]
	public InputContinuously(BaseTagComponent tagComp, BaseBuffComponent buffComp)
	{
		this.TagComp = tagComp;
		this.BuffComp = buffComp;
	}

	// Token: 0x0601A6A5 RID: 108197 RVA: 0x0070B298 File Offset: 0x00709498
	public void InitConfig()
	{
		this.Duration = (float)ConfigCommonParamById.GetIntConfig("ConstantSprintEnterTime").Value;
		this.AutoGlideTime = (float)ConfigCommonParamById.GetIntConfig("ConstantSprintAutoGlideTime").Value;
		this.DelayExitTime = (float)ConfigCommonParamById.GetIntConfig("ConstantSprintSpecialStateOffset").Value;
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("ConstantSprintListeningBuffStopList");
		IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig("ConstantSprintListeningTagStopList");
		if (intArrayConfig != null && intArrayConfig.Count > 0)
		{
			this.BuffList = new int[intArrayConfig.Count];
			for (int i = 0; i < intArrayConfig.Count; i++)
			{
				this.BuffList[i] = intArrayConfig[i];
			}
		}
		if (stringArrayConfig != null && stringArrayConfig.Count > 0)
		{
			this.TagList = new int[stringArrayConfig.Count];
			for (int j = 0; j < stringArrayConfig.Count; j++)
			{
				int tagIdByName = GameplayTagUtils.GetTagIdByName(stringArrayConfig[j]);
				this.TagList[j] = tagIdByName;
			}
		}
	}

	// Token: 0x0601A6A6 RID: 108198 RVA: 0x0070B390 File Offset: 0x00709590
	public bool GetAutoMovingState()
	{
		BattleUiFormationData formationData = BattleUiModel.Instance.FormationData;
		bool flag = formationData != null && formationData.AutoMovingSettingEnable && this.CheckTagAndBuff();
		if (this.LastState && !flag)
		{
			this.ResetAutoMovingState("不满足默认奔跑条件");
		}
		return flag;
	}

	// Token: 0x0601A6A7 RID: 108199 RVA: 0x0070B3D6 File Offset: 0x007095D6
	public bool CheckTagAndBuff()
	{
		BaseTagComponent tagComp = this.TagComp;
		return tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]) && this.CheckForbiddenTagAndBuff();
	}

	// Token: 0x0601A6A8 RID: 108200 RVA: 0x0070B406 File Offset: 0x00709606
	public void SetAutoMovingState(bool value, bool start = false)
	{
		this.StartEnter = start;
		this.LastState = value;
		this.UpdateAutoMovingTag(value);
	}

	// Token: 0x0601A6A9 RID: 108201 RVA: 0x0070B41D File Offset: 0x0070961D
	public void AddTimeAccumulation(float delta)
	{
		if (!this.CheckForbiddenTagAndBuff())
		{
			this.ClearTimeAccumulation();
			return;
		}
		this.CurrentTime += delta;
		this.AccumulationTime += delta;
	}

	// Token: 0x0601A6AA RID: 108202 RVA: 0x0070B44A File Offset: 0x0070964A
	public void ClearTimeAccumulation()
	{
		this.CurrentTime = 0f;
		this.AccumulationTime = 0f;
	}

	// Token: 0x0601A6AB RID: 108203 RVA: 0x0070B462 File Offset: 0x00709662
	public void ResetAutoMovingState(string context = null)
	{
		this.ClearTimeAccumulation();
		this.SetAutoMovingState(false, false);
		string.IsNullOrEmpty(context);
	}

	// Token: 0x0601A6AC RID: 108204 RVA: 0x0070B479 File Offset: 0x00709679
	[NullableContext(1)]
	public void DeepCopy(InputContinuously other)
	{
		this.CurrentTime = other.CurrentTime;
		this.AccumulationTime = other.AccumulationTime;
		this.InAirTime = other.InAirTime;
		this.SetAutoMovingState(other.GetAutoMovingState(), false);
	}

	// Token: 0x0601A6AD RID: 108205 RVA: 0x0070B4AC File Offset: 0x007096AC
	public bool IsStartEnter()
	{
		return this.StartEnter;
	}

	// Token: 0x0601A6AE RID: 108206 RVA: 0x0070B4B4 File Offset: 0x007096B4
	public void ClearStartEnter()
	{
		this.StartEnter = false;
	}

	// Token: 0x0601A6AF RID: 108207 RVA: 0x0070B4BD File Offset: 0x007096BD
	public bool CheckTimeDuration()
	{
		return this.AccumulationTime > this.Duration;
	}

	// Token: 0x0601A6B0 RID: 108208 RVA: 0x0070B4CD File Offset: 0x007096CD
	public float GetCurrentTime()
	{
		return this.CurrentTime;
	}

	// Token: 0x0601A6B1 RID: 108209 RVA: 0x0070B4D5 File Offset: 0x007096D5
	public float GetDuration()
	{
		return this.Duration;
	}

	// Token: 0x0601A6B2 RID: 108210 RVA: 0x0070B4E0 File Offset: 0x007096E0
	private bool CheckForbiddenTagAndBuff()
	{
		if (this.BuffList != null && this.BuffList.Length != 0)
		{
			for (int i = 0; i < this.BuffList.Length; i++)
			{
				int num = this.BuffList[i];
				BaseBuffComponent buffComp = this.BuffComp;
				if (buffComp != null && buffComp.HasBuff((long)num, false))
				{
					return false;
				}
			}
		}
		if (this.TagList != null && this.TagList.Length != 0)
		{
			for (int j = 0; j < this.TagList.Length; j++)
			{
				int tagId = this.TagList[j];
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null && tagComp.HasTag(tagId))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0601A6B3 RID: 108211 RVA: 0x0070B578 File Offset: 0x00709778
	private void UpdateAutoMovingTag(bool value)
	{
		if (value)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]))
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 != null)
				{
					tagComp2.AddTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]));
				}
			}
		}
		if (!value)
		{
			BaseTagComponent tagComp3 = this.TagComp;
			if (tagComp3 != null && tagComp3.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]))
			{
				BaseTagComponent tagComp4 = this.TagComp;
				if (tagComp4 == null)
				{
					return;
				}
				tagComp4.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]));
			}
		}
	}

	// Token: 0x0400CA62 RID: 51810
	private bool LastState;

	// Token: 0x0400CA63 RID: 51811
	private bool StartEnter;

	// Token: 0x0400CA64 RID: 51812
	private float CurrentTime;

	// Token: 0x0400CA65 RID: 51813
	private float AccumulationTime;

	// Token: 0x0400CA66 RID: 51814
	public float InAirTime;

	// Token: 0x0400CA67 RID: 51815
	public float InDelayExitTime;

	// Token: 0x0400CA68 RID: 51816
	private float Duration;

	// Token: 0x0400CA69 RID: 51817
	public float AutoGlideTime;

	// Token: 0x0400CA6A RID: 51818
	public float DelayExitTime;

	// Token: 0x0400CA6B RID: 51819
	private int[] BuffList;

	// Token: 0x0400CA6C RID: 51820
	private int[] TagList;

	// Token: 0x0400CA6D RID: 51821
	private readonly BaseTagComponent TagComp;

	// Token: 0x0400CA6E RID: 51822
	private readonly BaseBuffComponent BuffComp;
}
