using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D37 RID: 7479
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseFunctionalPanel : BattleChildViewPanel
{
	// Token: 0x0600E298 RID: 58008 RVA: 0x00353D30 File Offset: 0x00351F30
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

	// Token: 0x0600E299 RID: 58009 RVA: 0x00353E0C File Offset: 0x0035200C
	private void OnBuffDetailBtnClicked()
	{
		TrapDefenseModel.Instance.OpenViewBdSum(null, null, null);
	}

	// Token: 0x0600E29A RID: 58010 RVA: 0x00353E40 File Offset: 0x00352040
	private void OnMonsterTipsBtnClicked()
	{
		TrapDefenseModel.Instance.OpenViewMonster(null, new ETrapDefenseMonsterTabType?(ETrapDefenseMonsterTabType.MonsterWave), null);
	}

	// Token: 0x0600E29B RID: 58011 RVA: 0x00353E6F File Offset: 0x0035206F
	private void OnExitBtnClicked()
	{
		TrapDefenseController.Instance.OpenPauseView();
	}

	// Token: 0x0600E29C RID: 58012 RVA: 0x00353E7C File Offset: 0x0035207C
	public override void InitializeTemp()
	{
		this.TipsItem = base.GetItem(3);
		this.TipsItem.SetUIActive(false);
		this.Sequence = new UiSequencePlayer(this.TipsItem);
		this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		this.UpdateBdSumState();
	}

	// Token: 0x0600E29D RID: 58013 RVA: 0x00353ED0 File Offset: 0x003520D0
	private void OnEndSequenceEvent(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			this.TipsItem.SetUIActive(false);
		}
	}

	// Token: 0x0600E29E RID: 58014 RVA: 0x00353EEB File Offset: 0x003520EB
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600E29F RID: 58015 RVA: 0x00353EF8 File Offset: 0x003520F8
	public void SetTips(string tips)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), tips, Array.Empty<object>());
		this.TipsItem.SetUIActive(true);
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600E2A0 RID: 58016 RVA: 0x00353F2F File Offset: 0x0035212F
	public void HideTips()
	{
		this.Sequence.StopSequenceByKey("Start", false, true);
		this.Sequence.PlaySequencePurely("Close", false, false);
	}

	// Token: 0x0600E2A1 RID: 58017 RVA: 0x00353F58 File Offset: 0x00352158
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

	// Token: 0x040068C6 RID: 26822
	protected UiSequencePlayer Sequence;

	// Token: 0x040068C7 RID: 26823
	protected UUIItem TipsItem;

	// Token: 0x02008343 RID: 33603
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402ACCE RID: 175310
		public const int BuffDetailBtn = 0;

		// Token: 0x0402ACCF RID: 175311
		public const int MonsterTipsBtn = 1;

		// Token: 0x0402ACD0 RID: 175312
		public const int ExitBtn = 2;

		// Token: 0x0402ACD1 RID: 175313
		public const int TipsItem = 3;

		// Token: 0x0402ACD2 RID: 175314
		public const int Tips = 4;
	}
}
