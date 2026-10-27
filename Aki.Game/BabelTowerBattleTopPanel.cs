using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001115 RID: 4373
public class BabelTowerBattleTopPanel : BattleVisibleChildView
{
	// Token: 0x0600725D RID: 29277 RVA: 0x00176968 File Offset: 0x00174B68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnStarButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600725E RID: 29278 RVA: 0x00176A0E File Offset: 0x00174C0E
	[NullableContext(1)]
	public override void Initialize(object param = null)
	{
		base.Initialize(param);
		base.InitChildType(EBattleUiChild.MiniMap);
		base.SetVisible(1, false);
	}

	// Token: 0x0600725F RID: 29279 RVA: 0x00176A26 File Offset: 0x00174C26
	public override void Reset()
	{
		base.Reset();
	}

	// Token: 0x06007260 RID: 29280 RVA: 0x00176A2E File Offset: 0x00174C2E
	private void AddEventListeners()
	{
		if (this.HasAddEventListener)
		{
			return;
		}
		EventSystem.Instance.Add(EEventName.OnBabelActivityInstInfoUpdate, new Action(this.OnBabelTowerBattleTopPanelUpdate));
		this.HasAddEventListener = true;
	}

	// Token: 0x06007261 RID: 29281 RVA: 0x00176A5C File Offset: 0x00174C5C
	private void RemoveEventListeners()
	{
		if (!this.HasAddEventListener)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.OnBabelActivityInstInfoUpdate, new Action(this.OnBabelTowerBattleTopPanelUpdate));
		this.HasAddEventListener = false;
	}

	// Token: 0x06007262 RID: 29282 RVA: 0x00176A8C File Offset: 0x00174C8C
	private void OnStarButtonClick()
	{
		List<IBabelTowerBuffItemData> list = new List<IBabelTowerBuffItemData>();
		List<IBabelTowerBuffItemData> list2 = new List<IBabelTowerBuffItemData>();
		BabelTowerInstanceData currentChallengeInstData = BabelTowerModel.Instance.CurrentChallengeInstData;
		List<int> list3 = (currentChallengeInstData != null) ? currentChallengeInstData.BuffSelection : null;
		if (list3 != null)
		{
			foreach (int id in list3)
			{
				BabelTowerBuffItemData item = new BabelTowerBuffItemData
				{
					Id = id,
					IsDeTerm = false,
					CanClick = true,
					ShowStar = new bool?(false)
				};
				list.Add(item);
			}
		}
		List<int> list4 = (currentChallengeInstData != null) ? currentChallengeInstData.DeTermIdList : null;
		if (list4 != null)
		{
			foreach (int id2 in list4)
			{
				BabelTowerBuffItemData item2 = new BabelTowerBuffItemData
				{
					Id = id2,
					IsDeTerm = true,
					CanClick = true,
					ShowStar = new bool?(true)
				};
				list2.Add(item2);
			}
		}
		BabelTowerBuffViewData param = new BabelTowerBuffViewData
		{
			BuffDataList = list,
			DeTermDataList = list2
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerBuffView, param, null);
	}

	// Token: 0x06007263 RID: 29283 RVA: 0x00176BD0 File Offset: 0x00174DD0
	private void OnBabelTowerBattleTopPanelUpdate()
	{
		int curStarNum = BabelTowerModel.Instance.GetCurStarNum();
		this.Update(curStarNum);
	}

	// Token: 0x06007264 RID: 29284 RVA: 0x00176BEF File Offset: 0x00174DEF
	public void Update(int starNum)
	{
		this.StarNum = starNum;
		this.Refresh();
	}

	// Token: 0x06007265 RID: 29285 RVA: 0x00176BFE File Offset: 0x00174DFE
	public void Refresh()
	{
		base.GetText(1).SetText(this.StarNum.ToString(), true);
	}

	// Token: 0x06007266 RID: 29286 RVA: 0x00176C18 File Offset: 0x00174E18
	public void StartShow()
	{
		BabelTowerInstanceData currentChallengeInstData = BabelTowerModel.Instance.CurrentChallengeInstData;
		int starNum = (currentChallengeInstData != null) ? currentChallengeInstData.CurStarNum : 0;
		this.Update(starNum);
		base.SetVisible(1, true);
	}

	// Token: 0x06007267 RID: 29287 RVA: 0x00176C4B File Offset: 0x00174E4B
	public void EndShow()
	{
		base.SetVisible(1, false);
	}

	// Token: 0x06007268 RID: 29288 RVA: 0x00176C55 File Offset: 0x00174E55
	protected override void OnShowBattleChildView()
	{
		this.AddEventListeners();
	}

	// Token: 0x06007269 RID: 29289 RVA: 0x00176C5D File Offset: 0x00174E5D
	protected override void OnHideBattleChildView()
	{
		this.RemoveEventListeners();
	}

	// Token: 0x040034F8 RID: 13560
	private int StarNum;

	// Token: 0x040034F9 RID: 13561
	private bool HasAddEventListener;

	// Token: 0x020076D8 RID: 30424
	private enum EVisibleReason
	{
		// Token: 0x04027381 RID: 160641
		Default = 1
	}

	// Token: 0x020076D9 RID: 30425
	private class EComponents
	{
		// Token: 0x04027382 RID: 160642
		public const int StarButton = 0;

		// Token: 0x04027383 RID: 160643
		public const int StarNumText = 1;
	}
}
