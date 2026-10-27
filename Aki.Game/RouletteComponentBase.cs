using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200291D RID: 10525
[NullableContext(1)]
[Nullable(0)]
public abstract class RouletteComponentBase : UiPanelBase
{
	// Token: 0x06015B59 RID: 88921 RVA: 0x0057A078 File Offset: 0x00578278
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

	// Token: 0x06015B5A RID: 88922 RVA: 0x0057A19B File Offset: 0x0057839B
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		this.SelectRingItem = base.GetItem(2);
	}

	// Token: 0x06015B5B RID: 88923 RVA: 0x0057A1C4 File Offset: 0x005783C4
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

	// Token: 0x06015B5C RID: 88924 RVA: 0x0057A204 File Offset: 0x00578404
	public void Reset()
	{
		this.AreaIndex = 0;
		this.Angle = -1;
		this.RefreshRouletteComponent();
	}

	// Token: 0x06015B5D RID: 88925 RVA: 0x0057A21C File Offset: 0x0057841C
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

	// Token: 0x06015B5E RID: 88926 RVA: 0x0057A3D8 File Offset: 0x005785D8
	protected virtual int GetGridId(int index, ERouletteGridType gridType)
	{
		return 0;
	}

	// Token: 0x06015B5F RID: 88927 RVA: 0x0057A3DB File Offset: 0x005785DB
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

	// Token: 0x06015B60 RID: 88928 RVA: 0x0057A3E0 File Offset: 0x005785E0
	protected virtual void InitGridEvent(RouletteGridBase grid)
	{
		foreach (Action<EToggleState> eventHandler in this.ToggleEventList)
		{
			grid.AddToggleStateChangeEvent(eventHandler);
		}
	}

	// Token: 0x06015B61 RID: 88929 RVA: 0x0057A434 File Offset: 0x00578634
	protected virtual RouletteData GridDataDecorator(RouletteData data)
	{
		data.State = this.JudgeGridStateByData(data.Id, data.GridType);
		return data;
	}

	// Token: 0x06015B62 RID: 88930 RVA: 0x0057A450 File Offset: 0x00578650
	public void AddAllGridToggleCanExecuteChangeEvent(Func<RouletteData, EToggleState, bool> onItemClicked)
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.BindOnCanToggleExecuteChange(onItemClicked);
		}
	}

	// Token: 0x06015B63 RID: 88931 RVA: 0x0057A4A4 File Offset: 0x005786A4
	protected virtual bool IsCurrentEquippedId(RouletteData gridData)
	{
		return false;
	}

	// Token: 0x06015B64 RID: 88932 RVA: 0x0057A4A7 File Offset: 0x005786A7
	protected virtual EGridBehavior JudgeGridStateByData(int id, ERouletteGridType gridType)
	{
		return EGridBehavior.Normal;
	}

	// Token: 0x06015B65 RID: 88933 RVA: 0x0057A4AC File Offset: 0x005786AC
	private void DestroyGridList()
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.SetGridEquipped(false);
			rouletteGridBase.SetGridToggleState(false, true);
		}
		this.RouletteGridList = new List<RouletteGridBase>();
	}

	// Token: 0x06015B66 RID: 88934 RVA: 0x0057A510 File Offset: 0x00578710
	protected virtual void GamepadReturnEmptyGrid()
	{
	}

	// Token: 0x06015B67 RID: 88935 RVA: 0x0057A514 File Offset: 0x00578714
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

	// Token: 0x06015B68 RID: 88936 RVA: 0x0057A576 File Offset: 0x00578776
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

	// Token: 0x06015B69 RID: 88937 RVA: 0x0057A5B4 File Offset: 0x005787B4
	public void SetAllGridToggleSelfInteractive(bool bActive)
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.SetToggleSelfInteractive(bActive);
		}
	}

	// Token: 0x06015B6A RID: 88938 RVA: 0x0057A608 File Offset: 0x00578808
	[NullableContext(0)]
	public ValueTuple<int, int> GetCurrentIndexAndAngle()
	{
		return new ValueTuple<int, int>(this.AreaIndex, this.Angle);
	}

	// Token: 0x06015B6B RID: 88939 RVA: 0x0057A61B File Offset: 0x0057881B
	protected void RefreshRouletteComponent()
	{
		this.RefreshCurrentShowName();
		this.RefreshTips();
	}

	// Token: 0x06015B6C RID: 88940 RVA: 0x0057A62C File Offset: 0x0057882C
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

	// Token: 0x06015B6D RID: 88941 RVA: 0x0057A729 File Offset: 0x00578929
	protected virtual void SetCurrentToggleState(bool bSelect)
	{
	}

	// Token: 0x06015B6E RID: 88942 RVA: 0x0057A72C File Offset: 0x0057892C
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

	// Token: 0x06015B6F RID: 88943 RVA: 0x0057A79A File Offset: 0x0057899A
	public void SetRingVisible(bool bVisible)
	{
		UUIItem selectRingItem = this.SelectRingItem;
		if (selectRingItem == null)
		{
			return;
		}
		selectRingItem.SetUIActive(bVisible);
	}

	// Token: 0x06015B70 RID: 88944 RVA: 0x0057A7B0 File Offset: 0x005789B0
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

	// Token: 0x06015B71 RID: 88945 RVA: 0x0057A7EE File Offset: 0x005789EE
	protected void RefreshName(string textId)
	{
		base.GetText(0).ShowTextNew(textId);
	}

	// Token: 0x06015B72 RID: 88946 RVA: 0x0057A7FD File Offset: 0x005789FD
	public void SetNameVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x06015B73 RID: 88947 RVA: 0x0057A80C File Offset: 0x00578A0C
	protected virtual void RefreshTips()
	{
	}

	// Token: 0x06015B74 RID: 88948 RVA: 0x0057A810 File Offset: 0x00578A10
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

	// Token: 0x06015B75 RID: 88949 RVA: 0x0057A83A File Offset: 0x00578A3A
	public void SetTipsActive(bool bActive)
	{
		base.GetText(1).SetUIActive(bActive);
	}

	// Token: 0x06015B76 RID: 88950 RVA: 0x0057A849 File Offset: 0x00578A49
	public void RefreshRouletteType()
	{
		this.RefreshRouletteItem();
		this.Reset();
		this.RebuildGridList();
	}

	// Token: 0x06015B77 RID: 88951 RVA: 0x0057A85D File Offset: 0x00578A5D
	protected virtual void RefreshRouletteItem()
	{
	}

	// Token: 0x06015B78 RID: 88952 RVA: 0x0057A85F File Offset: 0x00578A5F
	public void RefreshRoulettePlatformType()
	{
		this.Reset();
	}

	// Token: 0x06015B79 RID: 88953 RVA: 0x0057A867 File Offset: 0x00578A67
	public void RefreshRouletteInputType()
	{
		this.Reset();
	}

	// Token: 0x0400A1C7 RID: 41415
	[Nullable(2)]
	private UUIItem SelectRingItem;

	// Token: 0x0400A1C8 RID: 41416
	protected int Angle = -1;

	// Token: 0x0400A1C9 RID: 41417
	protected int AreaIndex;

	// Token: 0x0400A1CA RID: 41418
	private FRotator? TempRotator = new FRotator?(new FRotator(0f, 0f, 0f));

	// Token: 0x0400A1CB RID: 41419
	protected int CurrentGridIndex = -1;

	// Token: 0x0400A1CC RID: 41420
	protected int CurrentEquipGridIndex = -1;

	// Token: 0x0400A1CD RID: 41421
	protected bool IsEmptyChoose = true;

	// Token: 0x0400A1CE RID: 41422
	protected List<RouletteGridBase> RouletteGridList = new List<RouletteGridBase>();

	// Token: 0x0400A1CF RID: 41423
	[Nullable(2)]
	protected Dictionary<int, int> AreaIndexToGridIndex = new Dictionary<int, int>();

	// Token: 0x0400A1D0 RID: 41424
	protected List<Action<EToggleState>> ToggleEventList = new List<Action<EToggleState>>();
}
