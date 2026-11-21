using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020DF RID: 8415
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueLvNode : GridProxyAbstract<ISurvivorsLvNodeData>
{
	// Token: 0x17001F0B RID: 7947
	// (get) Token: 0x06014A85 RID: 84613 RVA: 0x00604E69 File Offset: 0x00603069
	// (set) Token: 0x06014A86 RID: 84614 RVA: 0x00604E71 File Offset: 0x00603071
	public ISurvivorsLvNodeData Data { get; set; }

	// Token: 0x06014A87 RID: 84615 RVA: 0x00604E7C File Offset: 0x0060307C
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

	// Token: 0x06014A88 RID: 84616 RVA: 0x00604F44 File Offset: 0x00603144
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06014A89 RID: 84617 RVA: 0x00604F57 File Offset: 0x00603157
	public override void Refresh(ISurvivorsLvNodeData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshType(data.IsImportant);
		this.RefreshState(data.State);
	}

	// Token: 0x06014A8A RID: 84618 RVA: 0x00604F78 File Offset: 0x00603178
	private void RefreshType(bool isImportant)
	{
		base.GetItem(0).SetUIActive(isImportant);
		base.GetItem(4).SetUIActive(!isImportant);
	}

	// Token: 0x06014A8B RID: 84619 RVA: 0x00604F98 File Offset: 0x00603198
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

	// Token: 0x06014A8C RID: 84620 RVA: 0x00604FEC File Offset: 0x006031EC
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

	// Token: 0x06014A8D RID: 84621 RVA: 0x00605088 File Offset: 0x00603288
	public UniTask PlayImportantNodeAnim()
	{
		SurvivorsRogueLvNode.<PlayImportantNodeAnim>d__15 <PlayImportantNodeAnim>d__;
		<PlayImportantNodeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayImportantNodeAnim>d__.<>4__this = this;
		<PlayImportantNodeAnim>d__.<>1__state = -1;
		<PlayImportantNodeAnim>d__.<>t__builder.Start<SurvivorsRogueLvNode.<PlayImportantNodeAnim>d__15>(ref <PlayImportantNodeAnim>d__);
		return <PlayImportantNodeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06014A8E RID: 84622 RVA: 0x006050CB File Offset: 0x006032CB
	public override object GetKey(ISurvivorsLvNodeData data, int displayIndex)
	{
		return data.Lv;
	}

	// Token: 0x0400B013 RID: 45075
	private const string SEQ_LIGHT = "Start";

	// Token: 0x0400B014 RID: 45076
	private const string SEQ_CLOSE = "Close";

	// Token: 0x0400B015 RID: 45077
	private const string SEQ_EVOLVE = "LevelUp";

	// Token: 0x0400B017 RID: 45079
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B018 RID: 45080
	private bool AnimState;
}
