using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E98 RID: 7832
[NullableContext(1)]
[Nullable(0)]
public abstract class RouletteComponentBase : UiPanelBase
{
	// Token: 0x0601355D RID: 79197 RVA: 0x005A4FF4 File Offset: 0x005A31F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x0601355E RID: 79198 RVA: 0x005A5117 File Offset: 0x005A3317
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		this.SelectRingItem = base.GetItem(2);
	}

	// Token: 0x0601355F RID: 79199 RVA: 0x005A5140 File Offset: 0x005A3340
	protected override void OnBeforeDestroy()
	{
		this.SelectRingItem = null;
		this.TempRotator = null;
		this.DestroyGridList();
		if (this.AreaIndexToGridIndex != null)
		{
			this.AreaIndexToGridIndex.Clear();
			this.AreaIndexToGridIndex = null;
		}
		this.ToggleEventList = new List<Action<EToggleState>>();
	}

	// Token: 0x06013560 RID: 79200 RVA: 0x005A5180 File Offset: 0x005A3380
	public void Reset()
	{
		this.AreaIndex = 0;
		this.Angle = -1;
		this.RefreshRouletteComponent();
	}

	// Token: 0x06013561 RID: 79201 RVA: 0x005A5198 File Offset: 0x005A3398
	private void RebuildGridList()
	{
		this.DestroyGridList();
		List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> rouletteInfoMap = this.GetRouletteInfoMap();
		if (rouletteInfoMap == null)
		{
			return;
		}
		int num = 0;
		Dictionary<ERouletteGridType, int> dictionary = new Dictionary<ERouletteGridType, int>
		{
			{
				ERouletteGridType.Explore,
				0
			},
			{
				ERouletteGridType.Function,
				0
			},
			{
				ERouletteGridType.EquipItem,
				0
			}
		};
		foreach (ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType> valueTuple in rouletteInfoMap)
		{
			foreach (int key in valueTuple.Item1)
			{
				if (this.AreaIndexToGridIndex != null)
				{
					this.AreaIndexToGridIndex[key] = num;
				}
			}
			ERouletteComponentNode item = valueTuple.Item2;
			ERouletteGridType item2 = valueTuple.Item3;
			int num2;
			if (!dictionary.TryGetValue(item2, out num2))
			{
				num2 = 0;
			}
			RouletteData rouletteData = new RouletteData();
			rouletteData.Id = this.GetGridId(num2, item2);
			rouletteData.GridIndex = num;
			rouletteData.DataIndex = num2;
			rouletteData.GridType = item2;
			UUIItem item3 = base.GetItem((int)item);
			RouletteGridBase generator = RouletteGridGenerator.GetGenerator(item2);
			generator.SetRootActor(item3.GetOwner(), true);
			this.GridDataDecorator(rouletteData);
			generator.RefreshGrid(rouletteData);
			bool flag = this.IsCurrentEquippedId(rouletteData);
			if (flag)
			{
				this.CurrentEquipGridIndex = rouletteData.GridIndex;
			}
			generator.SetGridEquipped(flag);
			this.InitGridEvent(generator);
			this.RouletteGridList.Add(generator);
			dictionary[item2] = num2 + 1;
			num++;
		}
	}

	// Token: 0x06013562 RID: 79202 RVA: 0x005A5354 File Offset: 0x005A3554
	protected virtual int GetGridId(int index, ERouletteGridType gridType)
	{
		return 0;
	}

	// Token: 0x06013563 RID: 79203 RVA: 0x005A5357 File Offset: 0x005A3557
	[return: Nullable(new byte[]
	{
		2,
		0,
		1
	})]
	protected virtual List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteInfoMap()
	{
		return null;
	}

	// Token: 0x06013564 RID: 79204 RVA: 0x005A535C File Offset: 0x005A355C
	protected virtual void InitGridEvent(RouletteGridBase grid)
	{
		foreach (Action<EToggleState> eventHandler in this.ToggleEventList)
		{
			grid.AddToggleStateChangeEvent(eventHandler);
		}
	}

	// Token: 0x06013565 RID: 79205 RVA: 0x005A53B0 File Offset: 0x005A35B0
	protected virtual RouletteData GridDataDecorator(RouletteData data)
	{
		data.State = this.JudgeGridStateByData(data.Id, data.GridType);
		return data;
	}

	// Token: 0x06013566 RID: 79206 RVA: 0x005A53CC File Offset: 0x005A35CC
	public void AddAllGridToggleCanExecuteChangeEvent(Func<RouletteData, EToggleState, bool> onItemClicked)
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.BindOnCanToggleExecuteChange(onItemClicked);
		}
	}

	// Token: 0x06013567 RID: 79207 RVA: 0x005A5420 File Offset: 0x005A3620
	protected virtual bool IsCurrentEquippedId(RouletteData gridData)
	{
		return false;
	}

	// Token: 0x06013568 RID: 79208 RVA: 0x005A5423 File Offset: 0x005A3623
	protected virtual EGridBehavior JudgeGridStateByData(int id, ERouletteGridType gridType)
	{
		return EGridBehavior.Normal;
	}

	// Token: 0x06013569 RID: 79209 RVA: 0x005A5428 File Offset: 0x005A3628
	private void DestroyGridList()
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.SetGridEquipped(false);
			rouletteGridBase.SetGridToggleState(false, true);
		}
		this.RouletteGridList = new List<RouletteGridBase>();
	}

	// Token: 0x0601356A RID: 79210 RVA: 0x005A548C File Offset: 0x005A368C
	protected virtual void GamepadReturnEmptyGrid()
	{
	}

	// Token: 0x0601356B RID: 79211 RVA: 0x005A5490 File Offset: 0x005A3690
	protected void RefreshCurrentGridIndex(int newAreaIndex)
	{
		this.AreaIndex = newAreaIndex;
		if (this.AreaIndexToGridIndex == null)
		{
			return;
		}
		int currentGridIndex;
		if (this.AreaIndexToGridIndex.TryGetValue(this.AreaIndex, out currentGridIndex))
		{
			this.CurrentGridIndex = currentGridIndex;
			this.IsEmptyChoose = false;
			return;
		}
		if (Info.Instance.IsInGamepad())
		{
			this.GamepadReturnEmptyGrid();
			return;
		}
		this.CurrentGridIndex = -1;
		this.IsEmptyChoose = true;
	}

	// Token: 0x0601356C RID: 79212 RVA: 0x005A54F2 File Offset: 0x005A36F2
	[NullableContext(2)]
	public RouletteGridBase GetCurrentGrid()
	{
		if (this.CurrentGridIndex == -1)
		{
			return null;
		}
		if (this.CurrentGridIndex >= 0 && this.CurrentGridIndex < this.RouletteGridList.Count)
		{
			return this.RouletteGridList[this.CurrentGridIndex];
		}
		return null;
	}

	// Token: 0x0601356D RID: 79213 RVA: 0x005A5530 File Offset: 0x005A3730
	public void SetAllGridToggleSelfInteractive(bool bActive)
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.SetToggleSelfInteractive(bActive);
		}
	}

	// Token: 0x0601356E RID: 79214 RVA: 0x005A5584 File Offset: 0x005A3784
	[NullableContext(0)]
	public ValueTuple<int, int> GetCurrentIndexAndAngle()
	{
		return new ValueTuple<int, int>(this.AreaIndex, this.Angle);
	}

	// Token: 0x0601356F RID: 79215 RVA: 0x005A5597 File Offset: 0x005A3797
	protected void RefreshRouletteComponent()
	{
		this.RefreshCurrentShowName();
		this.RefreshTips();
	}

	// Token: 0x06013570 RID: 79216 RVA: 0x005A55A8 File Offset: 0x005A37A8
	public void Refresh(int? newAreaIndex, int? newAngle)
	{
		if (newAreaIndex != null && this.AreaIndex != newAreaIndex.Value)
		{
			bool flag = this.AreaIndex == 0;
			Dictionary<int, int> areaIndexToGridIndex = this.AreaIndexToGridIndex;
			int num = (areaIndexToGridIndex != null) ? areaIndexToGridIndex.GetValueOrDefault(this.AreaIndex, -1) : -1;
			Dictionary<int, int> areaIndexToGridIndex2 = this.AreaIndexToGridIndex;
			int num2 = (areaIndexToGridIndex2 != null) ? areaIndexToGridIndex2.GetValueOrDefault(newAreaIndex.Value, -1) : -1;
			bool flag2 = num != num2;
			if (!flag && flag2)
			{
				this.SetCurrentToggleState(false);
			}
			this.RefreshCurrentGridIndex(newAreaIndex.Value);
			if (!this.IsEmptyChoose && flag2)
			{
				this.SetCurrentToggleState(true);
			}
			this.RefreshCurrentShowName();
			if (flag || this.IsEmptyChoose)
			{
				this.SetRingVisible(!this.IsEmptyChoose);
			}
			this.RefreshTips();
		}
		if (newAngle != null && this.Angle != newAngle.Value)
		{
			this.Angle = newAngle.Value;
			if (!this.IsEmptyChoose)
			{
				this.SetRingRotate(this.Angle);
			}
		}
	}

	// Token: 0x06013571 RID: 79217 RVA: 0x005A56A5 File Offset: 0x005A38A5
	protected virtual void SetCurrentToggleState(bool bSelect)
	{
	}

	// Token: 0x06013572 RID: 79218 RVA: 0x005A56A8 File Offset: 0x005A38A8
	private void SetRingRotate(int angle)
	{
		if (this.TempRotator == null || this.SelectRingItem == null)
		{
			return;
		}
		this.TempRotator = new FRotator?(new FRotator(this.TempRotator.Value.Pitch, (float)angle, this.TempRotator.Value.Roll));
		UUIItem selectRingItem = this.SelectRingItem;
		FRotator value = this.TempRotator.Value;
		selectRingItem.SetUIRelativeRotation(value);
	}

	// Token: 0x06013573 RID: 79219 RVA: 0x005A5716 File Offset: 0x005A3916
	public void SetRingVisible(bool bVisible)
	{
		UUIItem selectRingItem = this.SelectRingItem;
		if (selectRingItem == null)
		{
			return;
		}
		selectRingItem.SetUIActive(bVisible);
	}

	// Token: 0x06013574 RID: 79220 RVA: 0x005A572C File Offset: 0x005A392C
	protected virtual void RefreshCurrentShowName()
	{
		RouletteGridBase currentGrid = this.GetCurrentGrid();
		string text;
		if (currentGrid == null)
		{
			text = null;
		}
		else
		{
			RouletteData data = currentGrid.Data;
			text = ((data != null) ? data.Name : null);
		}
		string text2 = text;
		text2 = (text2 ?? "Text_ProbeToolFunctionNotice2_Text");
		this.RefreshName(text2);
	}

	// Token: 0x06013575 RID: 79221 RVA: 0x005A576A File Offset: 0x005A396A
	protected void RefreshName(string textId)
	{
		base.GetText(0).ShowTextNew(textId);
	}

	// Token: 0x06013576 RID: 79222 RVA: 0x005A5779 File Offset: 0x005A3979
	public void SetNameVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x06013577 RID: 79223 RVA: 0x005A5788 File Offset: 0x005A3988
	protected virtual void RefreshTips()
	{
	}

	// Token: 0x06013578 RID: 79224 RVA: 0x005A578C File Offset: 0x005A398C
	[NullableContext(2)]
	public void RefreshTipsByText(string tipsText, bool needReplace = false)
	{
		if (tipsText == null)
		{
			return;
		}
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, tipsText, Array.Empty<object>());
	}

	// Token: 0x06013579 RID: 79225 RVA: 0x005A57B6 File Offset: 0x005A39B6
	public void SetTipsActive(bool bActive)
	{
		base.GetText(1).SetUIActive(bActive);
	}

	// Token: 0x0601357A RID: 79226 RVA: 0x005A57C5 File Offset: 0x005A39C5
	public void RefreshRouletteType()
	{
		this.RefreshRouletteItem();
		this.Reset();
		this.RebuildGridList();
	}

	// Token: 0x0601357B RID: 79227 RVA: 0x005A57D9 File Offset: 0x005A39D9
	protected virtual void RefreshRouletteItem()
	{
	}

	// Token: 0x0601357C RID: 79228 RVA: 0x005A57DB File Offset: 0x005A39DB
	public void RefreshRoulettePlatformType()
	{
		this.Reset();
	}

	// Token: 0x0601357D RID: 79229 RVA: 0x005A57E3 File Offset: 0x005A39E3
	public void RefreshRouletteInputType()
	{
		this.Reset();
	}

	// Token: 0x0400A5B2 RID: 42418
	[Nullable(2)]
	private UUIItem SelectRingItem;

	// Token: 0x0400A5B3 RID: 42419
	protected int Angle = -1;

	// Token: 0x0400A5B4 RID: 42420
	protected int AreaIndex;

	// Token: 0x0400A5B5 RID: 42421
	private FRotator? TempRotator = new FRotator?(new FRotator(0f, 0f, 0f));

	// Token: 0x0400A5B6 RID: 42422
	protected int CurrentGridIndex = -1;

	// Token: 0x0400A5B7 RID: 42423
	protected int CurrentEquipGridIndex = -1;

	// Token: 0x0400A5B8 RID: 42424
	protected bool IsEmptyChoose = true;

	// Token: 0x0400A5B9 RID: 42425
	protected List<RouletteGridBase> RouletteGridList = new List<RouletteGridBase>();

	// Token: 0x0400A5BA RID: 42426
	[Nullable(2)]
	protected Dictionary<int, int> AreaIndexToGridIndex = new Dictionary<int, int>();

	// Token: 0x0400A5BB RID: 42427
	protected List<Action<EToggleState>> ToggleEventList = new List<Action<EToggleState>>();
}
