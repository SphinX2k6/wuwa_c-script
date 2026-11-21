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

// Token: 0x02000AE8 RID: 2792
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerResultView : UiViewBase
{
	// Token: 0x060073A0 RID: 29600 RVA: 0x0023B9DC File Offset: 0x00239BDC
	[NullableContext(1)]
	public WheelTowerResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060073A1 RID: 29601 RVA: 0x0023B9E8 File Offset: 0x00239BE8
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

	// Token: 0x060073A2 RID: 29602 RVA: 0x0023BB3C File Offset: 0x00239D3C
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerResultView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerResultView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060073A3 RID: 29603 RVA: 0x0023BB80 File Offset: 0x00239D80
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		this.SeqPlayer.PlaySequencePurely("Success", false, false, null, null, false);
		this.RefreshButton();
		this.RefreshEndlessUnlockTipsVisibility();
	}

	// Token: 0x060073A4 RID: 29604 RVA: 0x0023BBC7 File Offset: 0x00239DC7
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer == null)
		{
			return;
		}
		seqPlayer.Clear();
	}

	// Token: 0x060073A5 RID: 29605 RVA: 0x0023BBD9 File Offset: 0x00239DD9
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.Refresh));
	}

	// Token: 0x060073A6 RID: 29606 RVA: 0x0023BBF7 File Offset: 0x00239DF7
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.Refresh));
	}

	// Token: 0x060073A7 RID: 29607 RVA: 0x0023BC18 File Offset: 0x00239E18
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

	// Token: 0x060073A8 RID: 29608 RVA: 0x0023BC5C File Offset: 0x00239E5C
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

	// Token: 0x060073A9 RID: 29609 RVA: 0x0023BDD0 File Offset: 0x00239FD0
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

	// Token: 0x060073AA RID: 29610 RVA: 0x0023BE67 File Offset: 0x0023A067
	private void ClickBackCallback(int _)
	{
		IWheelTowerResultViewData data = this.Data;
		this.HandleButtonClick((data != null) ? data.LeftButtonData : null);
	}

	// Token: 0x060073AB RID: 29611 RVA: 0x0023BE81 File Offset: 0x0023A081
	private void ClickRetryCallback(int _)
	{
		IWheelTowerResultViewData data = this.Data;
		this.HandleButtonClick((data != null) ? data.CenterButtonData : null);
	}

	// Token: 0x060073AC RID: 29612 RVA: 0x0023BE9B File Offset: 0x0023A09B
	private void ClickContinueCallback(int _)
	{
		IWheelTowerResultViewData data = this.Data;
		this.HandleButtonClick((data != null) ? data.RightButtonData : null);
	}

	// Token: 0x060073AD RID: 29613 RVA: 0x0023BEB8 File Offset: 0x0023A0B8
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

	// Token: 0x060073AE RID: 29614 RVA: 0x0023BF50 File Offset: 0x0023A150
	private UniTask CreateResultContent()
	{
		WheelTowerResultView.<CreateResultContent>d__23 <CreateResultContent>d__;
		<CreateResultContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateResultContent>d__.<>4__this = this;
		<CreateResultContent>d__.<>1__state = -1;
		<CreateResultContent>d__.<>t__builder.Start<WheelTowerResultView.<CreateResultContent>d__23>(ref <CreateResultContent>d__);
		return <CreateResultContent>d__.<>t__builder.Task;
	}

	// Token: 0x0400491F RID: 18719
	private UUIItem Content;

	// Token: 0x04004920 RID: 18720
	private WheelTowerResultRoundItem RoundItem;

	// Token: 0x04004921 RID: 18721
	private WheelTowerResultScoreList ScoreList;

	// Token: 0x04004922 RID: 18722
	private WheelTowerResultBossList BossList;

	// Token: 0x04004923 RID: 18723
	private IWheelTowerResultViewData Data;

	// Token: 0x04004924 RID: 18724
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04004925 RID: 18725
	private ButtonItem BtnLeft;

	// Token: 0x04004926 RID: 18726
	private ButtonItem BtnCenter;

	// Token: 0x04004927 RID: 18727
	private ButtonItem BtnRight;
}
