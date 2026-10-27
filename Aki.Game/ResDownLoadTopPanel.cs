using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200275F RID: 10079
public class ResDownLoadTopPanel : BattleVisibleChildView
{
	// Token: 0x06014AC6 RID: 84678 RVA: 0x0053AC34 File Offset: 0x00538E34
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

	// Token: 0x06014AC7 RID: 84679 RVA: 0x0053ACFB File Offset: 0x00538EFB
	[NullableContext(1)]
	public override void Initialize(object param = null)
	{
		base.Initialize(param);
		base.InitChildType(EBattleUiChild.MiniMap);
		base.SetVisible(1, false);
	}

	// Token: 0x06014AC8 RID: 84680 RVA: 0x0053AD13 File Offset: 0x00538F13
	public override void Reset()
	{
		base.Reset();
	}

	// Token: 0x06014AC9 RID: 84681 RVA: 0x0053AD1B File Offset: 0x00538F1B
	private void AddEventListeners()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		EventSystem.Instance.Add(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06014ACA RID: 84682 RVA: 0x0053AD55 File Offset: 0x00538F55
	private void RemoveEventListeners()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		EventSystem.Instance.Remove(EEventName.OnRefreshSubPackageDownLoadByPriority, new Action(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06014ACB RID: 84683 RVA: 0x0053AD90 File Offset: 0x00538F90
	private void OnDownLoadBtnClick()
	{
		if (Info.Instance.IsPcPlatform())
		{
			string text = ((double)SubPackageDownLoadModel.Instance.GetDynamicRecallTotalSize() / 1073741824.0).ToString("F2");
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RecallResourceDownLoadingTips);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			});
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				text
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
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

	// Token: 0x06014ACC RID: 84684 RVA: 0x0053AE62 File Offset: 0x00539062
	private void ResDownLoadStateRefresh()
	{
		if (!SubPackageDownLoadModel.Instance.NeedShowBattleViewButton())
		{
			this.EndShow();
			return;
		}
		this.Update();
	}

	// Token: 0x06014ACD RID: 84685 RVA: 0x0053AE7D File Offset: 0x0053907D
	public void Update()
	{
		this.Refresh();
	}

	// Token: 0x06014ACE RID: 84686 RVA: 0x0053AE88 File Offset: 0x00539088
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

	// Token: 0x06014ACF RID: 84687 RVA: 0x0053AF98 File Offset: 0x00539198
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

	// Token: 0x06014AD0 RID: 84688 RVA: 0x0053B002 File Offset: 0x00539202
	public void EndShow()
	{
		base.SetVisible(1, false);
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06014AD1 RID: 84689 RVA: 0x0053B02C File Offset: 0x0053922C
	public void SetOtherHide(bool isHide)
	{
		base.SetVisible(2, !isHide);
	}

	// Token: 0x06014AD2 RID: 84690 RVA: 0x0053B039 File Offset: 0x00539239
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06014AD3 RID: 84691 RVA: 0x0053B05B File Offset: 0x0053925B
	protected override void OnBeforeShow()
	{
		this.AddEventListeners();
	}

	// Token: 0x06014AD4 RID: 84692 RVA: 0x0053B063 File Offset: 0x00539263
	protected override void OnBeforeHide()
	{
		this.RemoveEventListeners();
	}

	// Token: 0x04009B5C RID: 39772
	private const long GB_BYTES = 1073741824L;

	// Token: 0x04009B5D RID: 39773
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x02008DC4 RID: 36292
	private enum EVisibleReason
	{
		// Token: 0x0402E027 RID: 188455
		Default = 1,
		// Token: 0x0402E028 RID: 188456
		Other
	}

	// Token: 0x02008DC5 RID: 36293
	private enum EComponentDefine
	{
		// Token: 0x0402E02A RID: 188458
		DownLoadBarTexture,
		// Token: 0x0402E02B RID: 188459
		DownLoadBtn,
		// Token: 0x0402E02C RID: 188460
		Text
	}
}
