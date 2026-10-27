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

// Token: 0x02001D34 RID: 7476
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseCampsiteHpPanel : BattleChildViewPanel
{
	// Token: 0x0600E277 RID: 57975 RVA: 0x00353560 File Offset: 0x00351760
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

	// Token: 0x0600E278 RID: 57976 RVA: 0x00353655 File Offset: 0x00351855
	public override void InitializeTemp()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		this.RefreshStateByType(ECampsiteHpState.Normal);
		this.SetWarningItemActiveInner(this.IsInWarning);
	}

	// Token: 0x0600E279 RID: 57977 RVA: 0x00353694 File Offset: 0x00351894
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

	// Token: 0x0600E27A RID: 57978 RVA: 0x003536EC File Offset: 0x003518EC
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		long health = TrapDefenseModel.Instance.BattleData.GetHealth();
		base.GetArtText(6).SetText(health.ToString());
		base.GetArtText(7).SetUIActive(false);
		TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Health, new TTreeVarUpdateDelegate(this.OnCampsiteHpUpdate));
	}

	// Token: 0x0600E27B RID: 57979 RVA: 0x00353745 File Offset: 0x00351945
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600E27C RID: 57980 RVA: 0x0035375C File Offset: 0x0035195C
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefenseCampsiteHpPanel.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseCampsiteHpPanel.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E27D RID: 57981 RVA: 0x0035379F File Offset: 0x0035199F
	protected override void OnHideBattleChildViewPanel()
	{
		TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Health, new TTreeVarUpdateDelegate(this.OnCampsiteHpUpdate));
	}

	// Token: 0x0600E27E RID: 57982 RVA: 0x003537BD File Offset: 0x003519BD
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600E27F RID: 57983 RVA: 0x003537CC File Offset: 0x003519CC
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

	// Token: 0x0600E280 RID: 57984 RVA: 0x00353840 File Offset: 0x00351A40
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

	// Token: 0x0600E281 RID: 57985 RVA: 0x0035391E File Offset: 0x00351B1E
	public void SetWarningItemActive(bool isInWarning)
	{
		if (this.IsInWarning == isInWarning)
		{
			return;
		}
		this.IsInWarning = isInWarning;
		this.SetWarningItemActiveInner(isInWarning);
	}

	// Token: 0x0600E282 RID: 57986 RVA: 0x00353938 File Offset: 0x00351B38
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

	// Token: 0x0600E283 RID: 57987 RVA: 0x003539A4 File Offset: 0x00351BA4
	public void SetLightItemActive(bool isActive)
	{
		base.GetTexture(9).SetUIActive(isActive);
	}

	// Token: 0x040068BE RID: 26814
	private bool IsInWarning;

	// Token: 0x040068BF RID: 26815
	protected UiSequencePlayer Sequence;

	// Token: 0x0200833C RID: 33596
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402ACAF RID: 175279
		public const int NormalBgSprite = 0;

		// Token: 0x0402ACB0 RID: 175280
		public const int AddBgSprite = 1;

		// Token: 0x0402ACB1 RID: 175281
		public const int ReduceBgSprite = 2;

		// Token: 0x0402ACB2 RID: 175282
		public const int NormalLightItem = 3;

		// Token: 0x0402ACB3 RID: 175283
		public const int AddLightItem = 4;

		// Token: 0x0402ACB4 RID: 175284
		public const int ReduceLightItem = 5;

		// Token: 0x0402ACB5 RID: 175285
		public const int HpNum = 6;

		// Token: 0x0402ACB6 RID: 175286
		public const int ChangeHpNum = 7;

		// Token: 0x0402ACB7 RID: 175287
		public const int WarningItem = 8;

		// Token: 0x0402ACB8 RID: 175288
		public const int TextureLight = 9;
	}
}
