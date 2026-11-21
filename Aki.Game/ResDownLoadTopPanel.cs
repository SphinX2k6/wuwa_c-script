using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C4A RID: 7242
public class ResDownLoadTopPanel : BattleVisibleChildView
{
	// Token: 0x06011FA9 RID: 73641 RVA: 0x00549AC8 File Offset: 0x00547CC8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnDownLoadBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011FAA RID: 73642 RVA: 0x00549B8F File Offset: 0x00547D8F
	[NullableContext(1)]
	public override void Initialize(object param = null)
	{
		base.Initialize(param);
		base.InitChildType(EBattleUiChild.MiniMap);
		base.SetVisible(1, false);
	}

	// Token: 0x06011FAB RID: 73643 RVA: 0x00549BA7 File Offset: 0x00547DA7
	public override void Reset()
	{
		base.Reset();
	}

	// Token: 0x06011FAC RID: 73644 RVA: 0x00549BAF File Offset: 0x00547DAF
	private void AddEventListeners()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06011FAD RID: 73645 RVA: 0x00549BE9 File Offset: 0x00547DE9
	private void RemoveEventListeners()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06011FAE RID: 73646 RVA: 0x00549C24 File Offset: 0x00547E24
	private void OnDownLoadBtnClick()
	{
		if (RecallQuestModel.Instance.IsInRecallInstance())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Download_BanDownloadSystem", Array.Empty<object>());
			return;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.SubPackageDownLoadView))
		{
			UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadView, null, null);
		}
	}

	// Token: 0x06011FAF RID: 73647 RVA: 0x00549C74 File Offset: 0x00547E74
	private void ResDownLoadStateRefresh()
	{
		if (!SubPackageDownLoadModel.Instance.NeedShowBattleViewButton())
		{
			this.EndShow();
			return;
		}
		this.Update();
	}

	// Token: 0x06011FB0 RID: 73648 RVA: 0x00549C8F File Offset: 0x00547E8F
	public void Update()
	{
		this.Refresh();
	}

	// Token: 0x06011FB1 RID: 73649 RVA: 0x00549C98 File Offset: 0x00547E98
	public void Refresh()
	{
		if (SubPackageDownLoadModel.Instance.DownLoadingSubPackageId == 0 && SubPackageDownLoadModel.Instance.PauseSubPackageId == 0)
		{
			base.GetText(2).SetUIActive(false);
			base.GetTexture(0).SetFillAmount(0f);
			return;
		}
		base.GetText(2).SetUIActive(true);
		UUITexture texture = base.GetTexture(0);
		ValueTuple<float, ESubPackageDownLoadState> valueTuple = SubPackageDownLoadModel.Instance.DownLoadPercentage();
		texture.SetFillAmount(valueTuple.Item1);
		FColor? fcolor;
		if (valueTuple.Item2 == ESubPackageDownLoadState.DownLoading)
		{
			UUIItem texture2 = base.GetTexture(0);
			bool bUseChangeColor = false;
			fcolor = new FColor?(texture.changeColor);
			texture2.SetChangeColor(bUseChangeColor, fcolor);
			base.GetText(2).SetText(SubPackageDownLoadModel.Instance.ByteConverter(SubPackageDownLoadModel.Instance.GetSubPackageDownLoadSpeed()) + "/s", true);
			return;
		}
		UUIItem texture3 = base.GetTexture(0);
		bool bUseChangeColor2 = true;
		fcolor = new FColor?(texture.changeColor);
		texture3.SetChangeColor(bUseChangeColor2, fcolor);
		base.GetText(2).SetText(Math.Floor((double)valueTuple.Item1 * 100.0).ToString() + "%", true);
	}

	// Token: 0x06011FB2 RID: 73650 RVA: 0x00549DA8 File Offset: 0x00547FA8
	public void StartShow()
	{
		this.Update();
		base.SetVisible(1, true);
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.Update();
		}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x06011FB3 RID: 73651 RVA: 0x00549E12 File Offset: 0x00548012
	public void EndShow()
	{
		base.SetVisible(1, false);
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06011FB4 RID: 73652 RVA: 0x00549E3C File Offset: 0x0054803C
	public void SetOtherHide(bool isHide)
	{
		base.SetVisible(2, !isHide);
	}

	// Token: 0x06011FB5 RID: 73653 RVA: 0x00549E49 File Offset: 0x00548049
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06011FB6 RID: 73654 RVA: 0x00549E6B File Offset: 0x0054806B
	protected override void OnBeforeShow()
	{
		this.AddEventListeners();
	}

	// Token: 0x06011FB7 RID: 73655 RVA: 0x00549E73 File Offset: 0x00548073
	protected override void OnBeforeHide()
	{
		this.RemoveEventListeners();
	}

	// Token: 0x04009CB5 RID: 40117
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x02007F4D RID: 32589
	private enum EVisibleReason
	{
		// Token: 0x0402933E RID: 168766
		Default = 1,
		// Token: 0x0402933F RID: 168767
		Other
	}

	// Token: 0x02007F4E RID: 32590
	private enum EComponentDefine
	{
		// Token: 0x04029341 RID: 168769
		DownLoadBarTexture,
		// Token: 0x04029342 RID: 168770
		DownLoadBtn,
		// Token: 0x04029343 RID: 168771
		Text
	}
}
