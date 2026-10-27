using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F1F RID: 3871
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AchievementDataItem : GridProxyAbstract<AchievementData>
{
	// Token: 0x17000798 RID: 1944
	// (get) Token: 0x060061EC RID: 25068 RVA: 0x00131D35 File Offset: 0x0012FF35
	// (set) Token: 0x060061ED RID: 25069 RVA: 0x00131D3D File Offset: 0x0012FF3D
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public new ScrollViewDelegate<IGridProxy<AchievementData>, AchievementData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17000799 RID: 1945
	// (get) Token: 0x060061EE RID: 25070 RVA: 0x00131D46 File Offset: 0x0012FF46
	// (set) Token: 0x060061EF RID: 25071 RVA: 0x00131D4E File Offset: 0x0012FF4E
	public new int GridIndex { get; set; }

	// Token: 0x1700079A RID: 1946
	// (get) Token: 0x060061F0 RID: 25072 RVA: 0x00131D57 File Offset: 0x0012FF57
	// (set) Token: 0x060061F1 RID: 25073 RVA: 0x00131D5F File Offset: 0x0012FF5F
	public new int DisplayIndex { get; set; }

	// Token: 0x060061F2 RID: 25074 RVA: 0x00131D68 File Offset: 0x0012FF68
	public UniTask Init(UUIItem item)
	{
		AchievementDataItem.<Init>d__17 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<AchievementDataItem.<Init>d__17>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060061F3 RID: 25075 RVA: 0x00131DB4 File Offset: 0x0012FFB4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060061F4 RID: 25076 RVA: 0x00131F43 File Offset: 0x00130143
	protected override void OnStart()
	{
		if (this.AchievementGridItem == null)
		{
			this.AchievementGridItem = new AchievementGridItem();
			this.AchievementGridItem.Initialize(base.GetItem(8).GetOwner());
		}
		this.AchievementGridItem.SetActive(false);
		this.AddEventListener();
	}

	// Token: 0x060061F5 RID: 25077 RVA: 0x00131F81 File Offset: 0x00130181
	public override void Refresh(AchievementData data, bool isSelected, int gridIndex)
	{
		this.RefreshUi(data);
	}

	// Token: 0x060061F6 RID: 25078 RVA: 0x00131F8C File Offset: 0x0013018C
	public void RefreshUi(AchievementData data)
	{
		if (data == null)
		{
			Log.Instance.Error(ELogModule.Achievement, ELogAuthor.BB, "AchievementDataItem Data为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AchievementData = data;
		int? currentProgress = data.GetCurrentProgress();
		int? maxProgress = data.GetMaxProgress();
		EAchievementStateEnum finishState = data.GetFinishState();
		UUIText text = base.GetText(5);
		UUIText text2 = base.GetText(6);
		UUIText text3 = base.GetText(3);
		if (AchievementModel.Instance.AchievementSearchState)
		{
			string currentSearchText = AchievementModel.Instance.CurrentSearchText;
			text.SetText(data.GetReplaceTitle(currentSearchText), true);
			text2.SetText(data.GetReplaceDesc(currentSearchText), true);
		}
		else
		{
			text.SetText(data.GetTitle(), true);
			text2.SetText(data.GetDesc(), true);
		}
		LguiUtil.Instance.SetLocalText(base.GetText(7), "CollectProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			currentProgress,
			maxProgress
		}));
		base.SetButtonUiActive(2, finishState == EAchievementStateEnum.CanGetReward);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(data.RedPoint());
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(finishState == EAchievementStateEnum.HaveGetReward);
		}
		if (finishState == EAchievementStateEnum.UnFinished)
		{
			if (text3 != null)
			{
				text3.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text3, "Text_Doing_Text", Array.Empty<object>());
		}
		else if (finishState == EAchievementStateEnum.CanGetReward)
		{
			if (text3 != null)
			{
				text3.SetUIActive(false);
			}
		}
		else
		{
			if (text3 != null)
			{
				text3.SetUIActive(true);
			}
			DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds(data.GetFinishTime().Value * (long)TimeUtil.Instance.InverseMillisecond).LocalDateTime;
			string newText = TimeUtil.Instance.DateFormat4(localDateTime);
			if (text3 != null)
			{
				text3.SetText(newText, true);
			}
		}
		List<TItem> rewards = data.GetRewards();
		if (rewards.Count > 0)
		{
			this.RefreshRewardItem(rewards[0]);
		}
		this.RefreshStar();
	}

	// Token: 0x060061F7 RID: 25079 RVA: 0x00132165 File Offset: 0x00130365
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x060061F8 RID: 25080 RVA: 0x0013216E File Offset: 0x0013036E
	public AUIBaseActor GetUsingItem(AchievementData data)
	{
		return (AUIBaseActor)base.GetRootItem().GetOwner();
	}

	// Token: 0x060061F9 RID: 25081 RVA: 0x00132180 File Offset: 0x00130380
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x060061FA RID: 25082 RVA: 0x0013219E File Offset: 0x0013039E
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementDataWithIdNotify, new Action<int>(this.OnAchievementDataWithIdNotify));
	}

	// Token: 0x060061FB RID: 25083 RVA: 0x001321BC File Offset: 0x001303BC
	private void OnAchievementDataWithIdNotify(int id)
	{
		if (this.AchievementData != null && id == this.AchievementData.GetId() && (this.AchievementData.IfSingleAchievement() || (!this.AchievementData.IfSingleAchievement() && this.AchievementData.GetNextLink() == 0)))
		{
			this.RefreshUi(this.AchievementData);
		}
	}

	// Token: 0x060061FC RID: 25084 RVA: 0x00132212 File Offset: 0x00130412
	private void OnClickButton()
	{
		AchievementController.Instance.RequestGetAchievementReward(false, this.AchievementData.GetId());
	}

	// Token: 0x060061FD RID: 25085 RVA: 0x0013222C File Offset: 0x0013042C
	private void RefreshStar()
	{
		if (this.StarItem != null)
		{
			this.StarItem.Destroy(null);
			this.StarItem = null;
		}
		int count = this.AchievementData.IfSingleAchievement() ? this.AchievementData.GetAchievementShowStar() : AchievementDataItem.MaxStarCount;
		this.StarItem = new AchievementStarItem(count, this.AchievementData, base.GetItem(9));
	}

	// Token: 0x060061FE RID: 25086 RVA: 0x00132290 File Offset: 0x00130490
	private void RefreshRewardItem(TItem data)
	{
		this.AchievementGridItem.SetActive(true);
		AchievementGridItemData achievementGridItemData = new AchievementGridItemData();
		achievementGridItemData.Data = new TItem?(data);
		achievementGridItemData.GetRewardState = (this.AchievementData.GetFinishState() == EAchievementStateEnum.HaveGetReward);
		this.AchievementGridItem.Refresh(achievementGridItemData, false, 0);
	}

	// Token: 0x060061FF RID: 25087 RVA: 0x001322DD File Offset: 0x001304DD
	protected override void OnBeforeDestroy()
	{
		if (this.StarItem != null)
		{
			this.StarItem.Destroy(null);
		}
		if (this.AchievementGridItem != null)
		{
			this.AchievementGridItem.Destroy(null);
		}
		if (this.AchievementData != null)
		{
			this.AchievementData = null;
		}
		this.RemoveEventListener();
	}

	// Token: 0x04002C81 RID: 11393
	[Nullable(2)]
	private AchievementStarItem StarItem;

	// Token: 0x04002C82 RID: 11394
	[Nullable(2)]
	private AchievementData AchievementData;

	// Token: 0x04002C83 RID: 11395
	[Nullable(2)]
	private AchievementGridItem AchievementGridItem;

	// Token: 0x04002C84 RID: 11396
	private static readonly int MaxStarCount = 3;

	// Token: 0x02007564 RID: 30052
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026CFE RID: 158974
		Toggle,
		// Token: 0x04026CFF RID: 158975
		RedDot,
		// Token: 0x04026D00 RID: 158976
		ReceiveBtn,
		// Token: 0x04026D01 RID: 158977
		AchieveStateText,
		// Token: 0x04026D02 RID: 158978
		CompleteItem,
		// Token: 0x04026D03 RID: 158979
		AchieveTitle,
		// Token: 0x04026D04 RID: 158980
		AchieveDesc,
		// Token: 0x04026D05 RID: 158981
		AchieveProgress,
		// Token: 0x04026D06 RID: 158982
		CommonGridItem,
		// Token: 0x04026D07 RID: 158983
		StarPos
	}
}
