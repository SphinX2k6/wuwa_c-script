using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x0200125E RID: 4702
[NullableContext(1)]
[Nullable(0)]
public class ActivityDoubleRewardData : ActivityBaseData
{
	// Token: 0x06007FD0 RID: 32720 RVA: 0x001B0ABF File Offset: 0x001AECBF
	protected override void PhraseEx(ActivityData data)
	{
		int leftUpCount = this.LeftUpCount;
		this.ConsumeUpCountInternal = data.DoubleInstActivityReward.GetDoubleInstRwdCount;
		if (leftUpCount != this.LeftUpCount && this.LeftUpCount == 0)
		{
			AdventureGuideController.Instance.UpdateAdventureNewSoundAreaTabRedDot();
		}
	}

	// Token: 0x06007FD1 RID: 32721 RVA: 0x001B0AF4 File Offset: 0x001AECF4
	public override bool GetExDataRedPointShowState()
	{
		if (this.LeftUpCount == 0)
		{
			return false;
		}
		int currentCrossDayIndex = TimeUtil.Instance.GetCurrentCrossDayIndex();
		return ActivityModel.Instance.GetActivityCacheDataByKey(base.Id, 0, currentCrossDayIndex) != 1;
	}

	// Token: 0x06007FD2 RID: 32722 RVA: 0x001B0B2E File Offset: 0x001AED2E
	protected override bool GetExDataFinishShowState()
	{
		return this.LeftUpCount == 0;
	}

	// Token: 0x06007FD3 RID: 32723 RVA: 0x001B0B39 File Offset: 0x001AED39
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x06007FD4 RID: 32724 RVA: 0x001B0B3C File Offset: 0x001AED3C
	public void ReadDailyRedDot()
	{
		int currentCrossDayIndex = TimeUtil.Instance.GetCurrentCrossDayIndex();
		ActivityModel.Instance.SaveActivityDataByKey(base.Id, currentCrossDayIndex, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x17000AE1 RID: 2785
	// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x001B0B7C File Offset: 0x001AED7C
	public int LeftUpCount
	{
		get
		{
			return this.TotalUpCount - this.ConsumeUpCountInternal;
		}
	}

	// Token: 0x17000AE2 RID: 2786
	// (get) Token: 0x06007FD6 RID: 32726 RVA: 0x001B0B8C File Offset: 0x001AED8C
	private int TotalUpCount
	{
		get
		{
			return ConfigDoubleRewardActivityById.GetConfig(base.Id, true).Value.Count;
		}
	}

	// Token: 0x17000AE3 RID: 2787
	// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x001B0BB8 File Offset: 0x001AEDB8
	public EActivityDoubleRewardType SubType
	{
		get
		{
			return (EActivityDoubleRewardType)ConfigDoubleRewardActivityById.GetConfig(base.Id, true).Value.Type;
		}
	}

	// Token: 0x17000AE4 RID: 2788
	// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x001B0BE4 File Offset: 0x001AEDE4
	public string Prefab
	{
		get
		{
			return ConfigDoubleRewardActivityById.GetConfig(base.Id, true).Value.Prefab;
		}
	}

	// Token: 0x17000AE5 RID: 2789
	// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x001B0C10 File Offset: 0x001AEE10
	public EDungeonType[] AdventureGuideUpList
	{
		get
		{
			if (this.UpDungeonTypeList == null)
			{
				switch (this.SubType)
				{
				case EActivityDoubleRewardType.Exp:
					this.UpDungeonTypeList = new EDungeonType[]
					{
						EDungeonType.Simulation
					};
					break;
				case EActivityDoubleRewardType.Growth:
					this.UpDungeonTypeList = new EDungeonType[]
					{
						EDungeonType.Mat,
						EDungeonType.Simulation
					};
					break;
				case EActivityDoubleRewardType.Sound:
					this.UpDungeonTypeList = new EDungeonType[]
					{
						EDungeonType.NoSoundArea
					};
					break;
				default:
					this.UpDungeonTypeList = new EDungeonType[]
					{
						EDungeonType.Simulation
					};
					break;
				}
			}
			return this.UpDungeonTypeList;
		}
	}

	// Token: 0x06007FDA RID: 32730 RVA: 0x001B0C98 File Offset: 0x001AEE98
	public int[] GetDungeonUpList(bool isInstance)
	{
		switch (this.SubType)
		{
		case EActivityDoubleRewardType.Exp:
			return new int[]
			{
				1
			};
		case EActivityDoubleRewardType.Growth:
			return new int[]
			{
				1,
				2
			};
		case EActivityDoubleRewardType.Sound:
			if (!isInstance)
			{
				return new int[]
				{
					3
				};
			}
			return new int[]
			{
				6
			};
		default:
			return new int[0];
		}
	}

	// Token: 0x06007FDB RID: 32731 RVA: 0x001B0CFB File Offset: 0x001AEEFB
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, int, int> GetNumTxtAndParam()
	{
		return new ValueTuple<string, int, int>((this.LeftUpCount > 0) ? "Reward_doubling_time" : "Reward_doubling_end", this.LeftUpCount, this.TotalUpCount);
	}

	// Token: 0x06007FDC RID: 32732 RVA: 0x001B0D23 File Offset: 0x001AEF23
	public Tuple<string, int, int> GetFullTipNumTxtAndParam()
	{
		return new Tuple<string, int, int>((this.LeftUpCount > 0) ? "Reward_doubling_tips" : "Reward_doubling_end_tips", this.LeftUpCount, this.TotalUpCount);
	}

	// Token: 0x06007FDD RID: 32733 RVA: 0x001B0D4C File Offset: 0x001AEF4C
	public string GetFullTip()
	{
		Tuple<string, int, int> fullTipNumTxtAndParam = this.GetFullTipNumTxtAndParam();
		return StringUtils.FormatStaticBuilder(ConfigMultiTextLang.GetLocalTextNew(fullTipNumTxtAndParam.Item1, null), new object[]
		{
			fullTipNumTxtAndParam.Item2,
			fullTipNumTxtAndParam.Item3
		});
	}

	// Token: 0x06007FDE RID: 32734 RVA: 0x001B0D93 File Offset: 0x001AEF93
	public void JumpToDungeon()
	{
		AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.NewSoundAreaView), new int?((int)this.AdventureGuideUpList[0]), null);
	}

	// Token: 0x04003A1D RID: 14877
	private int ConsumeUpCountInternal;

	// Token: 0x04003A1E RID: 14878
	[Nullable(2)]
	private EDungeonType[] UpDungeonTypeList;
}
