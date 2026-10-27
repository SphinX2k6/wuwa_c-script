using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001ABE RID: 6846
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapAreaRewardItem : GridProxyAbstract<DailyActivityDefine.IActivityGoalData>
{
	// Token: 0x170010C8 RID: 4296
	// (get) Token: 0x0600CAEE RID: 51950 RVA: 0x002E40B1 File Offset: 0x002E22B1
	// (set) Token: 0x0600CAEF RID: 51951 RVA: 0x002E40B9 File Offset: 0x002E22B9
	public EDailyActiveState? DailyActiveState { get; set; }

	// Token: 0x0600CAF0 RID: 51952 RVA: 0x002E40C2 File Offset: 0x002E22C2
	public MapAreaRewardItem(Action getRewardCallback, Action<RewardPopupData> openRewardCallback)
	{
		this.GetRewardCallback = getRewardCallback;
		this.OpenRewardCallback = openRewardCallback;
	}

	// Token: 0x0600CAF1 RID: 51953 RVA: 0x002E40D8 File Offset: 0x002E22D8
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

	// Token: 0x0600CAF2 RID: 51954 RVA: 0x002E4266 File Offset: 0x002E2466
	protected override void OnStart()
	{
		base.GetUiNiagara(6).SetAlpha(0f);
		base.GetUiNiagara(7).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600CAF3 RID: 51955 RVA: 0x002E4297 File Offset: 0x002E2497
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600CAF4 RID: 51956 RVA: 0x002E429C File Offset: 0x002E249C
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

	// Token: 0x0600CAF5 RID: 51957 RVA: 0x002E4346 File Offset: 0x002E2546
	public void RefreshSelf()
	{
		this.Refresh(this.RewardData, false, 0);
	}

	// Token: 0x0600CAF6 RID: 51958 RVA: 0x002E4356 File Offset: 0x002E2556
	public void SetRewardGoalValue(int value)
	{
		base.GetText(0).SetText(value.ToString(), true);
	}

	// Token: 0x0600CAF7 RID: 51959 RVA: 0x002E436C File Offset: 0x002E256C
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

	// Token: 0x0600CAF8 RID: 51960 RVA: 0x002E443C File Offset: 0x002E263C
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

	// Token: 0x0600CAF9 RID: 51961 RVA: 0x002E4498 File Offset: 0x002E2698
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

	// Token: 0x04005D66 RID: 23910
	private DailyActivityDefine.IActivityGoalData RewardData;

	// Token: 0x04005D68 RID: 23912
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04005D69 RID: 23913
	private readonly Action GetRewardCallback;

	// Token: 0x04005D6A RID: 23914
	private readonly Action<RewardPopupData> OpenRewardCallback;

	// Token: 0x02008016 RID: 32790
	[NullableContext(0)]
	private enum ERewardItemNode
	{
		// Token: 0x04029D0A RID: 171274
		TxtValue,
		// Token: 0x04029D0B RID: 171275
		BtnReward,
		// Token: 0x04029D0C RID: 171276
		SpriteUnfinished,
		// Token: 0x04029D0D RID: 171277
		SpriteClaimed,
		// Token: 0x04029D0E RID: 171278
		SpriteFinished,
		// Token: 0x04029D0F RID: 171279
		SpriteBackground,
		// Token: 0x04029D10 RID: 171280
		NiagaraWait,
		// Token: 0x04029D11 RID: 171281
		NiagaraGet,
		// Token: 0x04029D12 RID: 171282
		RedDot
	}
}
