using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001607 RID: 5639
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerScoreItem
{
	// Token: 0x06009EE0 RID: 40672 RVA: 0x0022BBCC File Offset: 0x00229DCC
	public WheelTowerScoreItem(UiPanelBase contextObject, UUIItem parentItem)
	{
		this.ContextObject = contextObject;
		this.ParentItem = parentItem;
		AUIBaseActor auibaseActor = this.ContextObject.GetRootActor() as AUIBaseActor;
		if (auibaseActor == null)
		{
			return;
		}
		auibaseActor.OnPreDestroyed.Add(new Action<AActor>(this.OnDestroy));
	}

	// Token: 0x06009EE1 RID: 40673 RVA: 0x0022BC3C File Offset: 0x00229E3C
	public void Refresh(EScoreLevel scoreLevel)
	{
		if (this.IsLock)
		{
			this.RefreshQueue.Push(scoreLevel);
			return;
		}
		this.IsLock = true;
		EScoreLevel? currentShowLevel = this.CurrentShowLevel;
		if (currentShowLevel.GetValueOrDefault() == scoreLevel & currentShowLevel != null)
		{
			this.Unlock();
			return;
		}
		UUIItem uuiitem;
		if (this.CurrentShowLevel != null && this.CachedScoreItemMap.TryGetValue(this.CurrentShowLevel.Value, out uuiitem))
		{
			uuiitem.SetUIActive(false);
		}
		this.CurrentShowLevel = new EScoreLevel?(scoreLevel);
		if (scoreLevel == EScoreLevel.None)
		{
			this.Unlock();
			return;
		}
		UUIItem uuiitem2;
		if (this.CachedScoreItemMap.TryGetValue(scoreLevel, out uuiitem2))
		{
			uuiitem2.SetUIActive(true);
			LevelSequencePlayer levelSequencePlayer;
			if (this.SeqPlayerMap.TryGetValue(scoreLevel, out levelSequencePlayer))
			{
				levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
			}
			this.Unlock();
			return;
		}
		this.LoadScoreItemAsync(scoreLevel).Forget();
	}

	// Token: 0x06009EE2 RID: 40674 RVA: 0x0022BD20 File Offset: 0x00229F20
	private UniTask LoadScoreItemAsync(EScoreLevel scoreLevel)
	{
		WheelTowerScoreItem.<LoadScoreItemAsync>d__9 <LoadScoreItemAsync>d__;
		<LoadScoreItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadScoreItemAsync>d__.<>4__this = this;
		<LoadScoreItemAsync>d__.scoreLevel = scoreLevel;
		<LoadScoreItemAsync>d__.<>1__state = -1;
		<LoadScoreItemAsync>d__.<>t__builder.Start<WheelTowerScoreItem.<LoadScoreItemAsync>d__9>(ref <LoadScoreItemAsync>d__);
		return <LoadScoreItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009EE3 RID: 40675 RVA: 0x0022BD6B File Offset: 0x00229F6B
	private void Unlock()
	{
		this.IsLock = false;
		if (this.RefreshQueue.Size > 0)
		{
			this.Refresh(this.RefreshQueue.Pop());
		}
	}

	// Token: 0x06009EE4 RID: 40676 RVA: 0x0022BD94 File Offset: 0x00229F94
	[NullableContext(2)]
	private void OnDestroy(AActor _)
	{
		foreach (LevelSequencePlayer levelSequencePlayer in this.SeqPlayerMap.Values)
		{
			levelSequencePlayer.Clear();
		}
		this.SeqPlayerMap.Clear();
	}

	// Token: 0x04004723 RID: 18211
	private readonly Dictionary<EScoreLevel, UUIItem> CachedScoreItemMap = new Dictionary<EScoreLevel, UUIItem>();

	// Token: 0x04004724 RID: 18212
	private readonly Dictionary<EScoreLevel, LevelSequencePlayer> SeqPlayerMap = new Dictionary<EScoreLevel, LevelSequencePlayer>();

	// Token: 0x04004725 RID: 18213
	private readonly Queue<EScoreLevel> RefreshQueue = new Queue<EScoreLevel>(4);

	// Token: 0x04004726 RID: 18214
	private readonly UiPanelBase ContextObject;

	// Token: 0x04004727 RID: 18215
	private readonly UUIItem ParentItem;

	// Token: 0x04004728 RID: 18216
	private EScoreLevel? CurrentShowLevel;

	// Token: 0x04004729 RID: 18217
	private bool IsLock;
}
