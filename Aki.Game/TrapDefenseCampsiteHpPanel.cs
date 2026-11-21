using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011F6 RID: 4598
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseCampsiteHpPanel : BattleChildViewPanel
{
	// Token: 0x0600B694 RID: 46740 RVA: 0x0035EF90 File Offset: 0x0035D190
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIArtText)),
			new ValueTuple<int, Type>(7, typeof(UUIArtText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUITexture))
		};
	}

	// Token: 0x0600B695 RID: 46741 RVA: 0x0035F085 File Offset: 0x0035D285
	public override void InitializeTemp()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		this.RefreshStateByType(ECampsiteHpState.Normal);
		this.SetWarningItemActiveInner(this.IsInWarning);
	}

	// Token: 0x0600B696 RID: 46742 RVA: 0x0035F0C4 File Offset: 0x0035D2C4
	private void OnEndSequenceEvent(string sequenceName)
	{
		if (sequenceName == "WarnOut")
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			if (sequenceName == "Hit")
			{
				this.RefreshStateByType(ECampsiteHpState.Normal);
				return;
			}
			if (sequenceName == "Treatment")
			{
				this.RefreshStateByType(ECampsiteHpState.Normal);
			}
			return;
		}
	}

	// Token: 0x0600B697 RID: 46743 RVA: 0x0035F11C File Offset: 0x0035D31C
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		long health = TrapDefenseModel.Instance.BattleData.GetHealth();
		base.GetArtText(6).SetText(health.ToString());
		base.GetArtText(7).SetUIActive(false);
		TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Health, new TTreeVarUpdateDelegate(this.OnCampsiteHpUpdate));
	}

	// Token: 0x0600B698 RID: 46744 RVA: 0x0035F175 File Offset: 0x0035D375
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600B699 RID: 46745 RVA: 0x0035F18C File Offset: 0x0035D38C
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefenseCampsiteHpPanel.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseCampsiteHpPanel.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B69A RID: 46746 RVA: 0x0035F1CF File Offset: 0x0035D3CF
	protected override void OnHideBattleChildViewPanel()
	{
		TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Health, new TTreeVarUpdateDelegate(this.OnCampsiteHpUpdate));
	}

	// Token: 0x0600B69B RID: 46747 RVA: 0x0035F1ED File Offset: 0x0035D3ED
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600B69C RID: 46748 RVA: 0x0035F1FC File Offset: 0x0035D3FC
	private void RefreshStateByType(ECampsiteHpState type)
	{
		if (type == ECampsiteHpState.Reduce)
		{
			this.Sequence.StopSequenceByKey("Treatment", false, true);
			this.Sequence.PlaySequencePurely("Hit", false, false);
			return;
		}
		if (type == ECampsiteHpState.Add)
		{
			this.Sequence.StopSequenceByKey("Hit", false, true);
			this.Sequence.PlaySequencePurely("Treatment", false, false);
			return;
		}
		UUIArtText artText = base.GetArtText(7);
		if (artText == null)
		{
			return;
		}
		artText.SetUIActive(false);
	}

	// Token: 0x0600B69D RID: 46749 RVA: 0x0035F270 File Offset: 0x0035D470
	private void OnCampsiteHpUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		UUIArtText artText = base.GetArtText(6);
		if (lastVarDefine == null && newVarDefine != null)
		{
			artText.SetText(MathUtils.Instance.LongToNumber(newVarDefine.Int).ToString());
			this.RefreshStateByType(ECampsiteHpState.Normal);
			return;
		}
		if (lastVarDefine != null && newVarDefine != null)
		{
			long num = MathUtils.Instance.LongToNumber(lastVarDefine.Int);
			long num2 = MathUtils.Instance.LongToNumber(newVarDefine.Int);
			UUIArtText artText2 = base.GetArtText(7);
			artText2.SetUIActive(true);
			artText.SetText(MathUtils.Instance.LongToNumber(num2).ToString());
			if (num < num2)
			{
				artText2.SetText("+" + (num2 - num).ToString());
				this.RefreshStateByType(ECampsiteHpState.Add);
				return;
			}
			if (num > num2)
			{
				artText2.SetText((num2 - num).ToString());
				this.RefreshStateByType(ECampsiteHpState.Reduce);
			}
		}
	}

	// Token: 0x0600B69E RID: 46750 RVA: 0x0035F34E File Offset: 0x0035D54E
	public void SetWarningItemActive(bool isInWarning)
	{
		if (this.IsInWarning == isInWarning)
		{
			return;
		}
		this.IsInWarning = isInWarning;
		this.SetWarningItemActiveInner(isInWarning);
	}

	// Token: 0x0600B69F RID: 46751 RVA: 0x0035F368 File Offset: 0x0035D568
	private void SetWarningItemActiveInner(bool isInWarning)
	{
		if (isInWarning)
		{
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.Sequence.StopSequenceByKey("WarnOut", false, true);
			this.Sequence.PlaySequencePurely("Warn", false, false);
			return;
		}
		this.Sequence.StopSequenceByKey("Warn", false, true);
		this.Sequence.PlaySequencePurely("WarnOut", false, false);
	}

	// Token: 0x0600B6A0 RID: 46752 RVA: 0x0035F3D4 File Offset: 0x0035D5D4
	public void SetLightItemActive(bool isActive)
	{
		base.GetTexture(9).SetUIActive(isActive);
	}

	// Token: 0x0400699D RID: 27037
	private bool IsInWarning;

	// Token: 0x0400699E RID: 27038
	protected UiSequencePlayer Sequence;

	// Token: 0x020074C5 RID: 29893
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025FD7 RID: 155607
		public const int NormalBgSprite = 0;

		// Token: 0x04025FD8 RID: 155608
		public const int AddBgSprite = 1;

		// Token: 0x04025FD9 RID: 155609
		public const int ReduceBgSprite = 2;

		// Token: 0x04025FDA RID: 155610
		public const int NormalLightItem = 3;

		// Token: 0x04025FDB RID: 155611
		public const int AddLightItem = 4;

		// Token: 0x04025FDC RID: 155612
		public const int ReduceLightItem = 5;

		// Token: 0x04025FDD RID: 155613
		public const int HpNum = 6;

		// Token: 0x04025FDE RID: 155614
		public const int ChangeHpNum = 7;

		// Token: 0x04025FDF RID: 155615
		public const int WarningItem = 8;

		// Token: 0x04025FE0 RID: 155616
		public const int TextureLight = 9;
	}
}
