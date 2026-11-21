using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x02000712 RID: 1810
[NullableContext(1)]
[Nullable(0)]
public class ActivityDoubleRewardData : ActivityBaseData
{
	// Token: 0x06005367 RID: 21351 RVA: 0x001B977B File Offset: 0x001B797B
	protected override void PhraseEx(ActivityData data)
	{
		int leftUpCount = this.LeftUpCount;
		this.ConsumeUpCountInternal = data.DoubleInstActivityReward.GetDoubleInstRwdCount;
		if (leftUpCount != this.LeftUpCount && this.LeftUpCount == 0)
		{
			AdventureGuideController.Instance.UpdateAdventureNewSoundAreaTabRedDot();
		}
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x001B97B0 File Offset: 0x001B79B0
	public override bool GetExDataRedPointShowState()
	{
		if (this.LeftUpCount == 0)
		{
			return false;
		}
		int currentCrossDayIndex = TimeUtil.Instance.GetCurrentCrossDayIndex();
		return ActivityModel.Instance.GetActivityCacheDataByKey(base.Id, 0, currentCrossDayIndex) != 1;
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x001B97EA File Offset: 0x001B79EA
	protected override bool GetExDataFinishShowState()
	{
		return this.LeftUpCount == 0;
	}

	// Token: 0x0600536A RID: 21354 RVA: 0x001B97F5 File Offset: 0x001B79F5
	public override bool NeedSelfControlFirstRedPoint()
	{
		return false;
	}

	// Token: 0x0600536B RID: 21355 RVA: 0x001B97F8 File Offset: 0x001B79F8
	public void ReadDailyRedDot()
	{
		int currentCrossDayIndex = TimeUtil.Instance.GetCurrentCrossDayIndex();
		ActivityModel.Instance.SaveActivityDataByKey(base.Id, currentCrossDayIndex, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x17000B01 RID: 2817
	// (get) Token: 0x0600536C RID: 21356 RVA: 0x001B9838 File Offset: 0x001B7A38
	public int LeftUpCount
	{
		get
		{
			return this.TotalUpCount - this.ConsumeUpCountInternal;
		}
	}

	// Token: 0x17000B02 RID: 2818
	// (get) Token: 0x0600536D RID: 21357 RVA: 0x001B9848 File Offset: 0x001B7A48
	private int TotalUpCount
	{
		get
		{
			return ConfigDoubleRewardActivityById.GetConfig(base.Id, true).Value.Count;
		}
	}

	// Token: 0x17000B03 RID: 2819
	// (get) Token: 0x0600536E RID: 21358 RVA: 0x001B9874 File Offset: 0x001B7A74
	public EActivityDoubleRewardType SubType
	{
		get
		{
			return (EActivityDoubleRewardType)ConfigDoubleRewardActivityById.GetConfig(base.Id, true).Value.Type;
		}
	}

	// Token: 0x17000B04 RID: 2820
	// (get) Token: 0x0600536F RID: 21359 RVA: 0x001B98A0 File Offset: 0x001B7AA0
	public string Prefab
	{
		get
		{
			return ConfigDoubleRewardActivityById.GetConfig(base.Id, true).Value.Prefab;
		}
	}

	// Token: 0x17000B05 RID: 2821
	// (get) Token: 0x06005370 RID: 21360 RVA: 0x001B98CC File Offset: 0x001B7ACC
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

	// Token: 0x06005371 RID: 21361 RVA: 0x001B9954 File Offset: 0x001B7B54
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

	// Token: 0x06005372 RID: 21362 RVA: 0x001B99B7 File Offset: 0x001B7BB7
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<string, int, int> GetNumTxtAndParam()
	{
		return new ValueTuple<string, int, int>((this.LeftUpCount > 0) ? "Reward_doubling_time" : "Reward_doubling_end", this.LeftUpCount, this.TotalUpCount);
	}

	// Token: 0x06005373 RID: 21363 RVA: 0x001B99DF File Offset: 0x001B7BDF
	public Tuple<string, int, int> GetFullTipNumTxtAndParam()
	{
		return new Tuple<string, int, int>((this.LeftUpCount > 0) ? "Reward_doubling_tips" : "Reward_doubling_end_tips", this.LeftUpCount, this.TotalUpCount);
	}

	// Token: 0x06005374 RID: 21364 RVA: 0x001B9A08 File Offset: 0x001B7C08
	public string GetFullTip()
	{
		Tuple<string, int, int> fullTipNumTxtAndParam = this.GetFullTipNumTxtAndParam();
		return StringUtils.FormatStaticBuilder(ConfigMultiTextLang.GetLocalTextNew(fullTipNumTxtAndParam.Item1, null), new object[]
		{
			fullTipNumTxtAndParam.Item2,
			fullTipNumTxtAndParam.Item3
		});
	}

	// Token: 0x06005375 RID: 21365 RVA: 0x001B9A50 File Offset: 0x001B7C50
	public void JumpToDungeon()
	{
		AdventureGuideController.Instance.OpenGuideView(new EUiTabViewName?(EUiTabViewName.NewSoundAreaView), new int?((int)this.AdventureGuideUpList[0]), null, null);
	}

	// Token: 0x04003AB5 RID: 15029
	private int ConsumeUpCountInternal;

	// Token: 0x04003AB6 RID: 15030
	[Nullable(2)]
	private EDungeonType[] UpDungeonTypeList;
}
