using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x020025C3 RID: 9667
[NullableContext(2)]
[Nullable(0)]
public class InputContinuously
{
	// Token: 0x0601805F RID: 98399 RVA: 0x00731A77 File Offset: 0x0072FC77
	[NullableContext(1)]
	public InputContinuously(BaseTagComponent tagComp, BaseBuffComponent buffComp)
	{
		this.TagComp = tagComp;
		this.BuffComp = buffComp;
	}

	// Token: 0x06018060 RID: 98400 RVA: 0x00731A90 File Offset: 0x0072FC90
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

	// Token: 0x06018061 RID: 98401 RVA: 0x00731B88 File Offset: 0x0072FD88
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

	// Token: 0x06018062 RID: 98402 RVA: 0x00731BCE File Offset: 0x0072FDCE
	public bool CheckTagAndBuff()
	{
		BaseTagComponent tagComp = this.TagComp;
		return tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.保持持续奔跑"]) && this.CheckForbiddenTagAndBuff();
	}

	// Token: 0x06018063 RID: 98403 RVA: 0x00731BFE File Offset: 0x0072FDFE
	public void SetAutoMovingState(bool value, bool start = false)
	{
		this.StartEnter = start;
		this.LastState = value;
		this.UpdateAutoMovingTag(value);
	}

	// Token: 0x06018064 RID: 98404 RVA: 0x00731C15 File Offset: 0x0072FE15
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

	// Token: 0x06018065 RID: 98405 RVA: 0x00731C42 File Offset: 0x0072FE42
	public void ClearTimeAccumulation()
	{
		this.CurrentTime = 0f;
		this.AccumulationTime = 0f;
	}

	// Token: 0x06018066 RID: 98406 RVA: 0x00731C5A File Offset: 0x0072FE5A
	public void ResetAutoMovingState(string context = null)
	{
		this.ClearTimeAccumulation();
		this.SetAutoMovingState(false, false);
		string.IsNullOrEmpty(context);
	}

	// Token: 0x06018067 RID: 98407 RVA: 0x00731C71 File Offset: 0x0072FE71
	[NullableContext(1)]
	public void DeepCopy(InputContinuously other)
	{
		this.CurrentTime = other.CurrentTime;
		this.AccumulationTime = other.AccumulationTime;
		this.InAirTime = other.InAirTime;
		this.SetAutoMovingState(other.GetAutoMovingState(), false);
	}

	// Token: 0x06018068 RID: 98408 RVA: 0x00731CA4 File Offset: 0x0072FEA4
	public bool IsStartEnter()
	{
		return this.StartEnter;
	}

	// Token: 0x06018069 RID: 98409 RVA: 0x00731CAC File Offset: 0x0072FEAC
	public void ClearStartEnter()
	{
		this.StartEnter = false;
	}

	// Token: 0x0601806A RID: 98410 RVA: 0x00731CB5 File Offset: 0x0072FEB5
	public bool CheckTimeDuration()
	{
		return this.AccumulationTime > this.Duration;
	}

	// Token: 0x0601806B RID: 98411 RVA: 0x00731CC5 File Offset: 0x0072FEC5
	public float GetCurrentTime()
	{
		return this.CurrentTime;
	}

	// Token: 0x0601806C RID: 98412 RVA: 0x00731CCD File Offset: 0x0072FECD
	public float GetDuration()
	{
		return this.Duration;
	}

	// Token: 0x0601806D RID: 98413 RVA: 0x00731CD8 File Offset: 0x0072FED8
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

	// Token: 0x0601806E RID: 98414 RVA: 0x00731D70 File Offset: 0x0072FF70
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

	// Token: 0x0400CE3C RID: 52796
	private bool LastState;

	// Token: 0x0400CE3D RID: 52797
	private bool StartEnter;

	// Token: 0x0400CE3E RID: 52798
	private float CurrentTime;

	// Token: 0x0400CE3F RID: 52799
	private float AccumulationTime;

	// Token: 0x0400CE40 RID: 52800
	public float InAirTime;

	// Token: 0x0400CE41 RID: 52801
	public float InDelayExitTime;

	// Token: 0x0400CE42 RID: 52802
	private float Duration;

	// Token: 0x0400CE43 RID: 52803
	public float AutoGlideTime;

	// Token: 0x0400CE44 RID: 52804
	public float DelayExitTime;

	// Token: 0x0400CE45 RID: 52805
	private int[] BuffList;

	// Token: 0x0400CE46 RID: 52806
	private int[] TagList;

	// Token: 0x0400CE47 RID: 52807
	private readonly BaseTagComponent TagComp;

	// Token: 0x0400CE48 RID: 52808
	private readonly BaseBuffComponent BuffComp;
}
