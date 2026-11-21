using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000F7D RID: 3965
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapAreaRewardItem : GridProxyAbstract<DailyActivityDefine.IActivityGoalData>
{
	// Token: 0x170010ED RID: 4333
	// (get) Token: 0x06009EFF RID: 40703 RVA: 0x002EF235 File Offset: 0x002ED435
	// (set) Token: 0x06009F00 RID: 40704 RVA: 0x002EF23D File Offset: 0x002ED43D
	public EDailyActiveState? DailyActiveState { get; set; }

	// Token: 0x06009F01 RID: 40705 RVA: 0x002EF246 File Offset: 0x002ED446
	public MapAreaRewardItem(Action getRewardCallback, Action<RewardPopupData> openRewardCallback)
	{
		this.GetRewardCallback = getRewardCallback;
		this.OpenRewardCallback = openRewardCallback;
	}

	// Token: 0x06009F02 RID: 40706 RVA: 0x002EF25C File Offset: 0x002ED45C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ClickRewardButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009F03 RID: 40707 RVA: 0x002EF3EA File Offset: 0x002ED5EA
	protected override void OnStart()
	{
		base.GetUiNiagara(6).SetAlpha(0f);
		base.GetUiNiagara(7).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06009F04 RID: 40708 RVA: 0x002EF41B File Offset: 0x002ED61B
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06009F05 RID: 40709 RVA: 0x002EF420 File Offset: 0x002ED620
	public override void Refresh(DailyActivityDefine.IActivityGoalData data, bool isSelected, int gridIndex)
	{
		this.RewardData = data;
		this.SetRewardGoalValue(data.Goal);
		EDailyActiveState? dailyActiveState = this.DailyActiveState;
		EDailyActiveState state = data.State;
		if (!(dailyActiveState.GetValueOrDefault() == state & dailyActiveState != null))
		{
			this.RefreshRewardState(data.State, this.DailyActiveState == null);
		}
		else if (this.DailyActiveState.GetValueOrDefault() == EDailyActiveState.FinishedAndTaken)
		{
			base.GetUiNiagara(7).SetUIActive(false);
		}
		bool flag = data.State != EDailyActiveState.Unfinished;
		UUIText text = base.GetText(0);
		UUIItem uuiitem = text;
		bool bUseChangeColor = flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x06009F06 RID: 40710 RVA: 0x002EF4CA File Offset: 0x002ED6CA
	public void RefreshSelf()
	{
		this.Refresh(this.RewardData, false, 0);
	}

	// Token: 0x06009F07 RID: 40711 RVA: 0x002EF4DA File Offset: 0x002ED6DA
	public void SetRewardGoalValue(int value)
	{
		base.GetText(0).SetText(value.ToString(), true);
	}

	// Token: 0x06009F08 RID: 40712 RVA: 0x002EF4F0 File Offset: 0x002ED6F0
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
		if (state == EDailyActiveState.FinishedAndNotTaken && isInit)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Activate", false, null, false);
		}
		FColor color = FColor.FromHex((state == EDailyActiveState.Unfinished) ? "00000033" : "F3EAAB1E");
		base.GetSprite(5).SetColor(color);
		this.DailyActiveState = new EDailyActiveState?(state);
	}

	// Token: 0x06009F09 RID: 40713 RVA: 0x002EF5C0 File Offset: 0x002ED7C0
	private void ClickRewardButton()
	{
		EDailyActiveState? dailyActiveState = this.DailyActiveState;
		if (dailyActiveState != null)
		{
			switch (dailyActiveState.GetValueOrDefault())
			{
			case EDailyActiveState.FinishedAndNotTaken:
			{
				Action getRewardCallback = this.GetRewardCallback;
				if (getRewardCallback == null)
				{
					return;
				}
				getRewardCallback();
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

	// Token: 0x06009F0A RID: 40714 RVA: 0x002EF61C File Offset: 0x002ED81C
	private void RefreshRewardPopup(bool isClaimed)
	{
		List<TItem> rewards = this.RewardData.Rewards;
		List<DailyActivityDefine.RewardTuple> list = new List<DailyActivityDefine.RewardTuple>();
		foreach (TItem titem in rewards)
		{
			DailyActivityDefine.RewardTuple item = new DailyActivityDefine.RewardTuple
			{
				Id = titem.ItemData.ItemId,
				Num = titem.Count,
				Received = isClaimed
			};
			list.Add(item);
		}
		RewardPopupData obj = new RewardPopupData
		{
			RewardLists = list,
			MountItem = base.GetButton(1).RootUIComp,
			PosBias = new FVector?(new FVector(0f, -20f, 0f))
		};
		Action<RewardPopupData> openRewardCallback = this.OpenRewardCallback;
		if (openRewardCallback == null)
		{
			return;
		}
		openRewardCallback(obj);
	}

	// Token: 0x04005E35 RID: 24117
	private DailyActivityDefine.IActivityGoalData RewardData;

	// Token: 0x04005E37 RID: 24119
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04005E38 RID: 24120
	private readonly Action GetRewardCallback;

	// Token: 0x04005E39 RID: 24121
	private readonly Action<RewardPopupData> OpenRewardCallback;

	// Token: 0x020071A5 RID: 29093
	[NullableContext(0)]
	private enum ERewardItemNode
	{
		// Token: 0x04025043 RID: 151619
		TxtValue,
		// Token: 0x04025044 RID: 151620
		BtnReward,
		// Token: 0x04025045 RID: 151621
		SpriteUnfinished,
		// Token: 0x04025046 RID: 151622
		SpriteClaimed,
		// Token: 0x04025047 RID: 151623
		SpriteFinished,
		// Token: 0x04025048 RID: 151624
		SpriteBackground,
		// Token: 0x04025049 RID: 151625
		NiagaraWait,
		// Token: 0x0402504A RID: 151626
		NiagaraGet,
		// Token: 0x0402504B RID: 151627
		RedDot
	}
}
