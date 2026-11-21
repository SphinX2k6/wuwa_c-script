using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011FC RID: 4604
public class TrapDefenseMissionPanel : BattleChildViewPanel
{
	// Token: 0x0600B6E6 RID: 46822 RVA: 0x003608EB File Offset: 0x0035EAEB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B6E7 RID: 46823 RVA: 0x00360910 File Offset: 0x0035EB10
	public override UniTask InitializeAsync()
	{
		TrapDefenseMissionPanel.<InitializeAsync>d__3 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseMissionPanel.<InitializeAsync>d__3>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6E8 RID: 46824 RVA: 0x00360953 File Offset: 0x0035EB53
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.MissionPanel.ShowBattleChildViewPanel();
	}

	// Token: 0x0600B6E9 RID: 46825 RVA: 0x00360960 File Offset: 0x0035EB60
	protected override void OnHideBattleChildViewPanel()
	{
		this.MissionPanel.HideBattleChildViewPanel();
	}

	// Token: 0x0600B6EA RID: 46826 RVA: 0x0036096D File Offset: 0x0035EB6D
	public override void OnTickBattleChildViewPanel(float delta)
	{
		this.MissionPanel.OnTickBattleChildViewPanel(delta);
	}

	// Token: 0x0600B6EB RID: 46827 RVA: 0x0036097B File Offset: 0x0035EB7B
	public override void Reset()
	{
		this.MissionPanel.Reset();
	}

	// Token: 0x040069B3 RID: 27059
	[Nullable(1)]
	protected MissionPanel MissionPanel;

	// Token: 0x020074D4 RID: 29908
	private static class EComponentDefine
	{
		// Token: 0x04026017 RID: 155671
		public const int MissionItem = 0;
	}
}
