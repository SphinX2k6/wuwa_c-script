using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020005C9 RID: 1481
public class BabelTowerBattleTopPanel : BattleVisibleChildView
{
	// Token: 0x060045F3 RID: 17907 RVA: 0x0017F324 File Offset: 0x0017D524
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

	// Token: 0x060045F4 RID: 17908 RVA: 0x0017F3CA File Offset: 0x0017D5CA
	[NullableContext(1)]
	public override void Initialize(object param = null)
	{
		base.Initialize(param);
		base.InitChildType(EBattleUiChild.MiniMap);
		base.SetVisible(1, false);
	}

	// Token: 0x060045F5 RID: 17909 RVA: 0x0017F3E2 File Offset: 0x0017D5E2
	public override void Reset()
	{
		base.Reset();
	}

	// Token: 0x060045F6 RID: 17910 RVA: 0x0017F3EA File Offset: 0x0017D5EA
	private void AddEventListeners()
	{
		if (this.HasAddEventListener)
		{
			return;
		}
		EventSystem.Instance.Add(EEventName.OnBabelActivityInstInfoUpdate, new Action(this.OnBabelTowerBattleTopPanelUpdate));
		this.HasAddEventListener = true;
	}

	// Token: 0x060045F7 RID: 17911 RVA: 0x0017F418 File Offset: 0x0017D618
	private void RemoveEventListeners()
	{
		if (!this.HasAddEventListener)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.OnBabelActivityInstInfoUpdate, new Action(this.OnBabelTowerBattleTopPanelUpdate));
		this.HasAddEventListener = false;
	}

	// Token: 0x060045F8 RID: 17912 RVA: 0x0017F448 File Offset: 0x0017D648
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

	// Token: 0x060045F9 RID: 17913 RVA: 0x0017F58C File Offset: 0x0017D78C
	private void OnBabelTowerBattleTopPanelUpdate()
	{
		int curStarNum = BabelTowerModel.Instance.GetCurStarNum();
		this.Update(curStarNum);
	}

	// Token: 0x060045FA RID: 17914 RVA: 0x0017F5AB File Offset: 0x0017D7AB
	public void Update(int starNum)
	{
		this.StarNum = starNum;
		this.Refresh();
	}

	// Token: 0x060045FB RID: 17915 RVA: 0x0017F5BA File Offset: 0x0017D7BA
	public void Refresh()
	{
		base.GetText(1).SetText(this.StarNum.ToString(), true);
	}

	// Token: 0x060045FC RID: 17916 RVA: 0x0017F5D4 File Offset: 0x0017D7D4
	public void StartShow()
	{
		BabelTowerInstanceData currentChallengeInstData = BabelTowerModel.Instance.CurrentChallengeInstData;
		int starNum = (currentChallengeInstData != null) ? currentChallengeInstData.CurStarNum : 0;
		this.Update(starNum);
		base.SetVisible(1, true);
	}

	// Token: 0x060045FD RID: 17917 RVA: 0x0017F607 File Offset: 0x0017D807
	public void EndShow()
	{
		base.SetVisible(1, false);
	}

	// Token: 0x060045FE RID: 17918 RVA: 0x0017F611 File Offset: 0x0017D811
	protected override void OnShowBattleChildView()
	{
		this.AddEventListeners();
	}

	// Token: 0x060045FF RID: 17919 RVA: 0x0017F619 File Offset: 0x0017D819
	protected override void OnHideBattleChildView()
	{
		this.RemoveEventListeners();
	}

	// Token: 0x04003591 RID: 13713
	private int StarNum;

	// Token: 0x04003592 RID: 13714
	private bool HasAddEventListener;

	// Token: 0x0200686C RID: 26732
	private enum EVisibleReason
	{
		// Token: 0x040226CA RID: 141002
		Default = 1
	}

	// Token: 0x0200686D RID: 26733
	private class EComponents
	{
		// Token: 0x040226CB RID: 141003
		public const int StarButton = 0;

		// Token: 0x040226CC RID: 141004
		public const int StarNumText = 1;
	}
}
