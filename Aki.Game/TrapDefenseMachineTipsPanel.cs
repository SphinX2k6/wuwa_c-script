using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D38 RID: 7480
public class TrapDefenseMachineTipsPanel : BattleChildViewPanel
{
	// Token: 0x0600E2A3 RID: 58019 RVA: 0x00353F97 File Offset: 0x00352197
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600E2A4 RID: 58020 RVA: 0x00353FD0 File Offset: 0x003521D0
	public override void InitializeTemp()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600E2A5 RID: 58021 RVA: 0x00353FE3 File Offset: 0x003521E3
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600E2A6 RID: 58022 RVA: 0x00353FF0 File Offset: 0x003521F0
	protected override void OnBeforeShow()
	{
		this.Sequence.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600E2A7 RID: 58023 RVA: 0x00354004 File Offset: 0x00352204
	protected override UniTask OnBeforeHideAsync()
	{
		TrapDefenseMachineTipsPanel.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseMachineTipsPanel.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E2A8 RID: 58024 RVA: 0x00354047 File Offset: 0x00352247
	protected override bool OnCheckBattleChildViewPanelShowCondition()
	{
		return this.IsCanShow;
	}

	// Token: 0x0600E2A9 RID: 58025 RVA: 0x0035404F File Offset: 0x0035224F
	private void RefreshMachineTips()
	{
		if (this.IsCanShow)
		{
			base.ShowBattleChildViewPanel();
			return;
		}
		base.HideBattleChildViewPanel();
	}

	// Token: 0x0600E2AA RID: 58026 RVA: 0x00354068 File Offset: 0x00352268
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

	// Token: 0x0600E2AB RID: 58027 RVA: 0x003540FF File Offset: 0x003522FF
	public void RefreshMachineStateByRoulette(bool isVisible)
	{
		this.IsMobileRouletteVisible = isVisible;
		this.RefreshMachineTips();
	}

	// Token: 0x17001223 RID: 4643
	// (get) Token: 0x0600E2AC RID: 58028 RVA: 0x0035410E File Offset: 0x0035230E
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

	// Token: 0x040068C8 RID: 26824
	[Nullable(1)]
	protected UiSequencePlayer Sequence;

	// Token: 0x040068C9 RID: 26825
	[Nullable(2)]
	protected TrapDefenseBuildingDevelopItemData Data;

	// Token: 0x040068CA RID: 26826
	protected bool IsMobileRouletteVisible;

	// Token: 0x02008344 RID: 33604
	private static class EComponentDefine
	{
		// Token: 0x0402ACD3 RID: 175315
		public const int Name = 0;

		// Token: 0x0402ACD4 RID: 175316
		public const int Desc = 1;
	}
}
