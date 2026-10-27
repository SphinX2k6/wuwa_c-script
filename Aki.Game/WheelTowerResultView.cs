using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001630 RID: 5680
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerResultView : UiViewBase
{
	// Token: 0x06009FC2 RID: 40898 RVA: 0x00231B90 File Offset: 0x0022FD90
	[NullableContext(1)]
	public WheelTowerResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FC3 RID: 40899 RVA: 0x00231B9C File Offset: 0x0022FD9C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009FC4 RID: 40900 RVA: 0x00231CF0 File Offset: 0x0022FEF0
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerResultView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerResultView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009FC5 RID: 40901 RVA: 0x00231D34 File Offset: 0x0022FF34
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.SeqPlayer.PlaySequencePurely("Success", false, false, null, null, false);
		this.RefreshButton();
		this.RefreshEndlessUnlockTipsVisibility();
	}

	// Token: 0x06009FC6 RID: 40902 RVA: 0x00231D7B File Offset: 0x0022FF7B
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x06009FC7 RID: 40903 RVA: 0x00231D8D File Offset: 0x0022FF8D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.Refresh));
	}

	// Token: 0x06009FC8 RID: 40904 RVA: 0x00231DAB File Offset: 0x0022FFAB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.Refresh));
	}

	// Token: 0x06009FC9 RID: 40905 RVA: 0x00231DCC File Offset: 0x0022FFCC
	private void RefreshEndlessUnlockTipsVisibility()
	{
		IWheelTowerResultViewData data = this.Data;
		bool valueOrDefault = ((data != null) ? data.ShowEndlessUnlockTips : null).GetValueOrDefault();
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(valueOrDefault);
	}

	// Token: 0x06009FCA RID: 40906 RVA: 0x00231E10 File Offset: 0x00230010
	private void RefreshButton()
	{
		IWheelTowerResultViewData data = this.Data;
		if (((data != null) ? data.LeftButtonData : null) != null)
		{
			ButtonItem btnLeft = this.BtnLeft;
			if (btnLeft != null)
			{
				btnLeft.SetShowText(this.Data.LeftButtonData.Name);
			}
		}
		IWheelTowerResultViewData data2 = this.Data;
		if (((data2 != null) ? data2.CenterButtonData : null) != null)
		{
			ButtonItem btnCenter = this.BtnCenter;
			if (btnCenter != null)
			{
				btnCenter.SetShowText(this.Data.CenterButtonData.Name);
			}
		}
		IWheelTowerResultViewData data3 = this.Data;
		if (((data3 != null) ? data3.RightButtonData : null) != null)
		{
			ButtonItem btnRight = this.BtnRight;
			if (btnRight != null)
			{
				btnRight.SetShowText(this.Data.RightButtonData.Name);
			}
		}
		ButtonItem btnLeft2 = this.BtnLeft;
		if (btnLeft2 != null)
		{
			IWheelTowerResultViewData data4 = this.Data;
			btnLeft2.SetUiActive(((data4 != null) ? data4.LeftButtonData : null) != null);
		}
		ButtonItem btnCenter2 = this.BtnCenter;
		if (btnCenter2 != null)
		{
			IWheelTowerResultViewData data5 = this.Data;
			btnCenter2.SetUiActive(((data5 != null) ? data5.CenterButtonData : null) != null);
		}
		ButtonItem btnRight2 = this.BtnRight;
		if (btnRight2 != null)
		{
			IWheelTowerResultViewData data6 = this.Data;
			btnRight2.SetUiActive(((data6 != null) ? data6.RightButtonData : null) != null);
		}
		ButtonItem btnLeft3 = this.BtnLeft;
		if (btnLeft3 != null)
		{
			btnLeft3.SetFunction(new Action<int>(this.ClickBackCallback));
		}
		ButtonItem btnCenter3 = this.BtnCenter;
		if (btnCenter3 != null)
		{
			btnCenter3.SetFunction(new Action<int>(this.ClickRetryCallback));
		}
		ButtonItem btnRight3 = this.BtnRight;
		if (btnRight3 == null)
		{
			return;
		}
		btnRight3.SetFunction(new Action<int>(this.ClickContinueCallback));
	}

	// Token: 0x06009FCB RID: 40907 RVA: 0x00231F84 File Offset: 0x00230184
	[NullableContext(1)]
	private void Refresh(string eventName)
	{
		if (eventName != "EnterS" || this.Data == null)
		{
			return;
		}
		WheelTowerResultRoundItem roundItem = this.RoundItem;
		if (roundItem != null)
		{
			roundItem.Refresh(this.Data.EndlessMode, this.Data.CurrentRound, this.Data.TotalRound);
		}
		WheelTowerResultScoreList scoreList = this.ScoreList;
		if (scoreList != null)
		{
			scoreList.Refresh(this.Data.TotalScore, this.Data.CurrentScore);
		}
		WheelTowerResultBossList bossList = this.BossList;
		if (bossList == null)
		{
			return;
		}
		bossList.Refresh(this.Data.BossInfoList);
	}

	// Token: 0x06009FCC RID: 40908 RVA: 0x0023201B File Offset: 0x0023021B
	private void ClickBackCallback(int _)
	{
		IWheelTowerResultViewData data = this.Data;
		this.HandleButtonClick((data != null) ? data.LeftButtonData : null);
	}

	// Token: 0x06009FCD RID: 40909 RVA: 0x00232035 File Offset: 0x00230235
	private void ClickRetryCallback(int _)
	{
		IWheelTowerResultViewData data = this.Data;
		this.HandleButtonClick((data != null) ? data.CenterButtonData : null);
	}

	// Token: 0x06009FCE RID: 40910 RVA: 0x0023204F File Offset: 0x0023024F
	private void ClickContinueCallback(int _)
	{
		IWheelTowerResultViewData data = this.Data;
		this.HandleButtonClick((data != null) ? data.RightButtonData : null);
	}

	// Token: 0x06009FCF RID: 40911 RVA: 0x0023206C File Offset: 0x0023026C
	private void HandleButtonClick(IWheelTowerResultViewButtonData buttonData)
	{
		IWheelTowerResultViewButtonData buttonData2 = buttonData;
		if (buttonData2 != null && buttonData2.ConfirmBoxId != null)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(buttonData.ConfirmBoxId.Value);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				buttonData.OnClick();
				this.CloseMe(null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		IWheelTowerResultViewButtonData buttonData3 = buttonData;
		if (buttonData3 != null)
		{
			buttonData3.OnClick();
		}
		base.CloseMe(null);
	}

	// Token: 0x06009FD0 RID: 40912 RVA: 0x00232104 File Offset: 0x00230304
	private UniTask CreateResultContent()
	{
		WheelTowerResultView.<CreateResultContent>d__23 <CreateResultContent>d__;
		<CreateResultContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateResultContent>d__.<>4__this = this;
		<CreateResultContent>d__.<>1__state = -1;
		<CreateResultContent>d__.<>t__builder.Start<WheelTowerResultView.<CreateResultContent>d__23>(ref <CreateResultContent>d__);
		return <CreateResultContent>d__.<>t__builder.Task;
	}

	// Token: 0x04004879 RID: 18553
	private UUIItem Content;

	// Token: 0x0400487A RID: 18554
	private WheelTowerResultRoundItem RoundItem;

	// Token: 0x0400487B RID: 18555
	private WheelTowerResultScoreList ScoreList;

	// Token: 0x0400487C RID: 18556
	private WheelTowerResultBossList BossList;

	// Token: 0x0400487D RID: 18557
	private IWheelTowerResultViewData Data;

	// Token: 0x0400487E RID: 18558
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400487F RID: 18559
	private ButtonItem BtnLeft;

	// Token: 0x04004880 RID: 18560
	private ButtonItem BtnCenter;

	// Token: 0x04004881 RID: 18561
	private ButtonItem BtnRight;
}
