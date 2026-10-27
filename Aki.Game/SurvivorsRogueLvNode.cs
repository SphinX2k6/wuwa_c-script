using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B63 RID: 11107
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueLvNode : GridProxyAbstract<ISurvivorsLvNodeData>
{
	// Token: 0x17001EB3 RID: 7859
	// (get) Token: 0x06017054 RID: 94292 RVA: 0x005D8301 File Offset: 0x005D6501
	// (set) Token: 0x06017055 RID: 94293 RVA: 0x005D8309 File Offset: 0x005D6509
	public ISurvivorsLvNodeData Data { get; set; }

	// Token: 0x06017056 RID: 94294 RVA: 0x005D8314 File Offset: 0x005D6514
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
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x06017057 RID: 94295 RVA: 0x005D83DC File Offset: 0x005D65DC
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06017058 RID: 94296 RVA: 0x005D83EF File Offset: 0x005D65EF
	public override void Refresh(ISurvivorsLvNodeData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshType(data.IsImportant);
		this.RefreshState(data.State);
	}

	// Token: 0x06017059 RID: 94297 RVA: 0x005D8410 File Offset: 0x005D6610
	private void RefreshType(bool isImportant)
	{
		base.GetItem(0).SetUIActive(isImportant);
		base.GetItem(4).SetUIActive(!isImportant);
	}

	// Token: 0x0601705A RID: 94298 RVA: 0x005D8430 File Offset: 0x005D6630
	public void RefreshState(ESurvivorsLvState state)
	{
		bool uiactive = state == ESurvivorsLvState.Activated;
		bool flag = state == ESurvivorsLvState.Highlight;
		base.GetItem(2).SetUIActive(flag);
		base.GetItem(3).SetUIActive(uiactive);
		base.GetItem(6).SetUIActive(flag);
		base.GetItem(7).SetUIActive(uiactive);
		this.SetAnimOn(flag);
	}

	// Token: 0x0601705B RID: 94299 RVA: 0x005D8484 File Offset: 0x005D6684
	public void SetAnimOn(bool bOn)
	{
		if (bOn == this.AnimState)
		{
			return;
		}
		this.AnimState = bOn;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null && levelSequencePlayer.IsPlayingSequence("Start"))
		{
			this.LevelSequencePlayer.StopSequenceByKey("Start", false, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null && levelSequencePlayer2.IsPlayingSequence("Close"))
		{
			this.LevelSequencePlayer.StopSequenceByKey("Close", false, true);
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName(bOn ? "Start" : "Close", false, null, false);
	}

	// Token: 0x0601705C RID: 94300 RVA: 0x005D8520 File Offset: 0x005D6720
	public UniTask PlayImportantNodeAnim()
	{
		SurvivorsRogueLvNode.<PlayImportantNodeAnim>d__15 <PlayImportantNodeAnim>d__;
		<PlayImportantNodeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayImportantNodeAnim>d__.<>4__this = this;
		<PlayImportantNodeAnim>d__.<>1__state = -1;
		<PlayImportantNodeAnim>d__.<>t__builder.Start<SurvivorsRogueLvNode.<PlayImportantNodeAnim>d__15>(ref <PlayImportantNodeAnim>d__);
		return <PlayImportantNodeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0601705D RID: 94301 RVA: 0x005D8563 File Offset: 0x005D6763
	public override object GetKey(ISurvivorsLvNodeData data, int displayIndex)
	{
		return data.Lv;
	}

	// Token: 0x0400AC0D RID: 44045
	private const string SEQ_LIGHT = "Start";

	// Token: 0x0400AC0E RID: 44046
	private const string SEQ_CLOSE = "Close";

	// Token: 0x0400AC0F RID: 44047
	private const string SEQ_EVOLVE = "LevelUp";

	// Token: 0x0400AC11 RID: 44049
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AC12 RID: 44050
	private bool AnimState;
}
