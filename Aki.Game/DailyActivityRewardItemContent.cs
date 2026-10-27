using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019F9 RID: 6649
[NullableContext(2)]
[Nullable(0)]
internal class DailyActivityRewardItemContent : GridProxyAbstract<int>
{
	// Token: 0x0600C286 RID: 49798 RVA: 0x002BE678 File Offset: 0x002BC878
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUINiagara)),
			new ValueTuple<int, Type>(7, typeof(UUINiagara)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.ClickRewardButton))
		};
	}

	// Token: 0x0600C287 RID: 49799 RVA: 0x002BE7A7 File Offset: 0x002BC9A7
	protected override void OnStart()
	{
		base.GetUiNiagara(6).SetAlpha(0f);
		base.GetUiNiagara(7).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C288 RID: 49800 RVA: 0x002BE7D8 File Offset: 0x002BC9D8
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600C289 RID: 49801 RVA: 0x002BE7DC File Offset: 0x002BC9DC
	public override void Refresh(int rewardId, bool isSelected, int gridIndex)
	{
		this.RewardId = rewardId;
		DailyActivityDefine.IActivityGoalData activityGoalData;
		(this.DataAdapter ?? new DailyActivityRewardAdapter()).GoalMap.TryGetValue(this.RewardId, out activityGoalData);
		if (activityGoalData == null)
		{
			return;
		}
		this.SetRewardGoalValue(activityGoalData.Goal);
		EDailyActiveState? dailyActiveState = this.DailyActiveState;
		EDailyActiveState state = activityGoalData.State;
		if (!(dailyActiveState.GetValueOrDefault() == state & dailyActiveState != null))
		{
			this.RefreshRewardState(activityGoalData.State, this.DailyActiveState == null);
		}
		else if (this.DailyActiveState.GetValueOrDefault() == EDailyActiveState.FinishedAndTaken)
		{
			base.GetUiNiagara(7).SetUIActive(false);
		}
		this.RefreshShowItem(gridIndex);
	}

	// Token: 0x0600C28A RID: 49802 RVA: 0x002BE884 File Offset: 0x002BCA84
	private void RefreshShowItem(int gridIndex)
	{
		IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> goalMap = (this.DataAdapter ?? new DailyActivityRewardAdapter()).GoalMap;
		bool flag = gridIndex == goalMap.Count - 1;
		UUIItem item = base.GetItem(9);
		UUIItem item2 = base.GetItem(10);
		item.SetUIActive(!flag);
		item2.SetUIActive(flag);
	}

	// Token: 0x0600C28B RID: 49803 RVA: 0x002BE8D3 File Offset: 0x002BCAD3
	public void RefreshSelf()
	{
		this.Refresh(this.RewardId, false, 0);
	}

	// Token: 0x0600C28C RID: 49804 RVA: 0x002BE8E4 File Offset: 0x002BCAE4
	public UniTask PlayRewardAnimAsync()
	{
		DailyActivityRewardItemContent.<PlayRewardAnimAsync>d__11 <PlayRewardAnimAsync>d__;
		<PlayRewardAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRewardAnimAsync>d__.<>4__this = this;
		<PlayRewardAnimAsync>d__.<>1__state = -1;
		<PlayRewardAnimAsync>d__.<>t__builder.Start<DailyActivityRewardItemContent.<PlayRewardAnimAsync>d__11>(ref <PlayRewardAnimAsync>d__);
		return <PlayRewardAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C28D RID: 49805 RVA: 0x002BE927 File Offset: 0x002BCB27
	public void SetRewardGoalValue(int value)
	{
		base.GetText(0).SetText(value.ToString(), true);
	}

	// Token: 0x0600C28E RID: 49806 RVA: 0x002BE940 File Offset: 0x002BCB40
	public void RefreshRewardState(EDailyActiveState state, bool isInit)
	{
		List<UUISprite> list = new List<UUISprite>
		{
			base.GetSprite(4),
			base.GetSprite(2),
			base.GetSprite(3)
		};
		for (int i = 0; i < list.Count; i++)
		{
			list[i].SetUIActive(i + EDailyActiveState.FinishedAndNotTaken == state);
		}
		base.GetItem(8).SetUIActive(state == EDailyActiveState.FinishedAndNotTaken);
		base.GetUiNiagara(6).SetAlpha(state == EDailyActiveState.FinishedAndNotTaken);
		UUINiagara uiNiagara = base.GetUiNiagara(7);
		if (state == EDailyActiveState.FinishedAndTaken && !isInit)
		{
			uiNiagara.SetUIActive(true);
			uiNiagara.ActivateSystem(true);
		}
		else
		{
			uiNiagara.SetUIActive(false);
			uiNiagara.Deactivate();
		}
		if (state == EDailyActiveState.FinishedAndNotTaken && !isInit)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Activate", false, null, false);
		}
		FColor color = FColor.FromHex((state == EDailyActiveState.Unfinished) ? "00000033" : "F3EAAB1E");
		base.GetSprite(5).SetColor(color);
		UUIItem text = base.GetText(0);
		bool bUseChangeColor = state != EDailyActiveState.Unfinished;
		FColor? fcolor = new FColor?(base.GetText(0).changeColor);
		text.SetChangeColor(bUseChangeColor, fcolor);
		this.DailyActiveState = new EDailyActiveState?(state);
	}

	// Token: 0x0600C28F RID: 49807 RVA: 0x002BEA64 File Offset: 0x002BCC64
	private void ClickRewardButton()
	{
		EDailyActiveState? dailyActiveState = this.DailyActiveState;
		if (dailyActiveState != null)
		{
			switch (dailyActiveState.GetValueOrDefault())
			{
			case EDailyActiveState.FinishedAndNotTaken:
			{
				Action rewardRequestDelegate = this.RewardRequestDelegate;
				if (rewardRequestDelegate == null)
				{
					return;
				}
				rewardRequestDelegate();
				return;
			}
			case EDailyActiveState.Unfinished:
				this.RefreshRewardPopup(false);
				return;
			case EDailyActiveState.FinishedAndTaken:
				this.RefreshRewardPopup(true);
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0600C290 RID: 49808 RVA: 0x002BEAC0 File Offset: 0x002BCCC0
	private void RefreshRewardPopup(bool isClaimed)
	{
		List<TItem> rewardById = (this.DataAdapter ?? new DailyActivityRewardAdapter()).GetRewardById(this.RewardId);
		List<DailyActivityDefine.RewardTuple> list = new List<DailyActivityDefine.RewardTuple>();
		foreach (TItem titem in rewardById)
		{
			DailyActivityDefine.RewardTuple item = new DailyActivityDefine.RewardTuple
			{
				Id = titem.ItemData.ItemId,
				Num = titem.Count,
				Received = isClaimed,
				IsDoubleRewardVisible = DailyActivityModel.Instance.ShouldShowLivenessRewardDoubleTag(titem.ItemData.ItemId)
			};
			list.Add(item);
		}
		RewardPopupData rewardData = new RewardPopupData
		{
			RewardLists = list,
			MountItem = base.GetButton(1).RootUIComp.Get(),
			PosBias = new FVector?(new FVector(0f, 30f, 0f))
		};
		DailyActivityModel.Instance.RewardData = rewardData;
		EventSystem.Instance.Emit(EEventName.RefreshActivityRewardPopUp);
	}

	// Token: 0x0400599D RID: 22941
	private int RewardId;

	// Token: 0x0400599E RID: 22942
	public EDailyActiveState? DailyActiveState;

	// Token: 0x0400599F RID: 22943
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040059A0 RID: 22944
	public Action RewardRequestDelegate;

	// Token: 0x040059A1 RID: 22945
	public DailyActivityDefine.IActivityRewardPanelDataAdapter DataAdapter;
}
