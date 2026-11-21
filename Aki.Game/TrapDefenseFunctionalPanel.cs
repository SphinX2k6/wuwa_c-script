using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011F9 RID: 4601
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseFunctionalPanel : BattleChildViewPanel
{
	// Token: 0x0600B6B5 RID: 46773 RVA: 0x0035F760 File Offset: 0x0035D960
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBuffDetailBtnClicked)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnMonsterTipsBtnClicked)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnExitBtnClicked))
		};
	}

	// Token: 0x0600B6B6 RID: 46774 RVA: 0x0035F83C File Offset: 0x0035DA3C
	private void OnBuffDetailBtnClicked()
	{
		TrapDefenseModel.Instance.OpenViewBdSum(null, null, null);
	}

	// Token: 0x0600B6B7 RID: 46775 RVA: 0x0035F870 File Offset: 0x0035DA70
	private void OnMonsterTipsBtnClicked()
	{
		TrapDefenseModel.Instance.OpenViewMonster(null, new ETrapDefenseMonsterTabType?(ETrapDefenseMonsterTabType.MonsterWave), null);
	}

	// Token: 0x0600B6B8 RID: 46776 RVA: 0x0035F89F File Offset: 0x0035DA9F
	private void OnExitBtnClicked()
	{
		TrapDefenseController.Instance.OpenPauseView();
	}

	// Token: 0x0600B6B9 RID: 46777 RVA: 0x0035F8AC File Offset: 0x0035DAAC
	public override void InitializeTemp()
	{
		this.TipsItem = base.GetItem(3);
		this.TipsItem.SetUIActive(false);
		this.Sequence = new UiSequencePlayer(this.TipsItem);
		this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		this.UpdateBdSumState();
	}

	// Token: 0x0600B6BA RID: 46778 RVA: 0x0035F900 File Offset: 0x0035DB00
	private void OnEndSequenceEvent(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			this.TipsItem.SetUIActive(false);
		}
	}

	// Token: 0x0600B6BB RID: 46779 RVA: 0x0035F91B File Offset: 0x0035DB1B
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600B6BC RID: 46780 RVA: 0x0035F928 File Offset: 0x0035DB28
	public void SetTips(string tips)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), tips, Array.Empty<object>());
		this.TipsItem.SetUIActive(true);
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600B6BD RID: 46781 RVA: 0x0035F95F File Offset: 0x0035DB5F
	public void HideTips()
	{
		this.Sequence.StopSequenceByKey("Start", false, true);
		this.Sequence.PlaySequencePurely("Close", false, false);
	}

	// Token: 0x0600B6BE RID: 46782 RVA: 0x0035F988 File Offset: 0x0035DB88
	public void UpdateBdSumState()
	{
		bool curInstIsRogue = TrapDefenseModel.Instance.GetCurInstIsRogue();
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(curInstIsRogue);
	}

	// Token: 0x040069A5 RID: 27045
	protected UiSequencePlayer Sequence;

	// Token: 0x040069A6 RID: 27046
	protected UUIItem TipsItem;

	// Token: 0x020074CC RID: 29900
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025FF6 RID: 155638
		public const int BuffDetailBtn = 0;

		// Token: 0x04025FF7 RID: 155639
		public const int MonsterTipsBtn = 1;

		// Token: 0x04025FF8 RID: 155640
		public const int ExitBtn = 2;

		// Token: 0x04025FF9 RID: 155641
		public const int TipsItem = 3;

		// Token: 0x04025FFA RID: 155642
		public const int Tips = 4;
	}
}
