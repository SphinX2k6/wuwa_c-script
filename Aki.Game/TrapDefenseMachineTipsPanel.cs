using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011FA RID: 4602
public class TrapDefenseMachineTipsPanel : BattleChildViewPanel
{
	// Token: 0x0600B6C0 RID: 46784 RVA: 0x0035F9C7 File Offset: 0x0035DBC7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600B6C1 RID: 46785 RVA: 0x0035FA00 File Offset: 0x0035DC00
	public override void InitializeTemp()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B6C2 RID: 46786 RVA: 0x0035FA13 File Offset: 0x0035DC13
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600B6C3 RID: 46787 RVA: 0x0035FA20 File Offset: 0x0035DC20
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600B6C4 RID: 46788 RVA: 0x0035FA34 File Offset: 0x0035DC34
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefenseMachineTipsPanel.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseMachineTipsPanel.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6C5 RID: 46789 RVA: 0x0035FA77 File Offset: 0x0035DC77
	protected override bool OnCheckBattleChildViewPanelShowCondition()
	{
		return this.IsCanShow;
	}

	// Token: 0x0600B6C6 RID: 46790 RVA: 0x0035FA7F File Offset: 0x0035DC7F
	private void RefreshMachineTips()
	{
		if (this.IsCanShow)
		{
			base.ShowBattleChildViewPanel();
			return;
		}
		base.HideBattleChildViewPanel();
	}

	// Token: 0x0600B6C7 RID: 46791 RVA: 0x0035FA98 File Offset: 0x0035DC98
	[NullableContext(2)]
	public void SetMachineItem(TrapDefenseBuildingDevelopItemData data)
	{
		if (data == this.Data)
		{
			return;
		}
		if (data != null && data.IsBuilding)
		{
			ValueTuple<string, string[]> desc = data.GetDesc();
			string item = desc.Item1;
			string[] item2 = desc.Item2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetName(), Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), item, item2);
			TrapDefenseBuildingDevelopItemData data2 = this.Data;
			if (data2 != null && data2.IsBuilding)
			{
				this.Sequence.PlaySequencePurely("Switch", false, false);
			}
		}
		this.Data = data;
		this.RefreshMachineTips();
	}

	// Token: 0x0600B6C8 RID: 46792 RVA: 0x0035FB2F File Offset: 0x0035DD2F
	public void RefreshMachineStateByRoulette(bool isVisible)
	{
		this.IsMobileRouletteVisible = isVisible;
		this.RefreshMachineTips();
	}

	// Token: 0x1700124D RID: 4685
	// (get) Token: 0x0600B6C9 RID: 46793 RVA: 0x0035FB3E File Offset: 0x0035DD3E
	private bool IsCanShow
	{
		get
		{
			if (!this.IsMobileRouletteVisible)
			{
				TrapDefenseBuildingDevelopItemData data = this.Data;
				return data != null && data.IsBuilding;
			}
			return false;
		}
	}

	// Token: 0x040069A7 RID: 27047
	[Nullable(1)]
	protected UiSequencePlayer Sequence;

	// Token: 0x040069A8 RID: 27048
	[Nullable(2)]
	protected TrapDefenseBuildingDevelopItemData Data;

	// Token: 0x040069A9 RID: 27049
	protected bool IsMobileRouletteVisible;

	// Token: 0x020074CD RID: 29901
	private static class EComponentDefine
	{
		// Token: 0x04025FFB RID: 155643
		public const int Name = 0;

		// Token: 0x04025FFC RID: 155644
		public const int Desc = 1;
	}
}
