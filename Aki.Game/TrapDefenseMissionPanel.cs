using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D3A RID: 7482
public class TrapDefenseMissionPanel : BattleChildViewPanel
{
	// Token: 0x0600E2C9 RID: 58057 RVA: 0x00354EBB File Offset: 0x003530BB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600E2CA RID: 58058 RVA: 0x00354EE0 File Offset: 0x003530E0
	public override UniTask InitializeAsync()
	{
		TrapDefenseMissionPanel.<InitializeAsync>d__3 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseMissionPanel.<InitializeAsync>d__3>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E2CB RID: 58059 RVA: 0x00354F23 File Offset: 0x00353123
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.MissionPanel.ShowBattleChildViewPanel();
	}

	// Token: 0x0600E2CC RID: 58060 RVA: 0x00354F30 File Offset: 0x00353130
	protected override void OnHideBattleChildViewPanel()
	{
		this.MissionPanel.HideBattleChildViewPanel();
	}

	// Token: 0x0600E2CD RID: 58061 RVA: 0x00354F3D File Offset: 0x0035313D
	public override void OnTickBattleChildViewPanel(float delta)
	{
		this.MissionPanel.OnTickBattleChildViewPanel(delta);
	}

	// Token: 0x0600E2CE RID: 58062 RVA: 0x00354F4B File Offset: 0x0035314B
	public override void Reset()
	{
		this.MissionPanel.Reset();
	}

	// Token: 0x040068D4 RID: 26836
	[Nullable(1)]
	protected MissionPanel MissionPanel;

	// Token: 0x0200834B RID: 33611
	private static class EComponentDefine
	{
		// Token: 0x0402ACEF RID: 175343
		public const int MissionItem = 0;
	}
}
