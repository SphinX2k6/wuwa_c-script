using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000ABF RID: 2751
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerScoreItem
{
	// Token: 0x060072BE RID: 29374 RVA: 0x002359CC File Offset: 0x00233BCC
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

	// Token: 0x060072BF RID: 29375 RVA: 0x00235A3C File Offset: 0x00233C3C
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

	// Token: 0x060072C0 RID: 29376 RVA: 0x00235B20 File Offset: 0x00233D20
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

	// Token: 0x060072C1 RID: 29377 RVA: 0x00235B6B File Offset: 0x00233D6B
	private void Unlock()
	{
		this.IsLock = false;
		if (this.RefreshQueue.Size > 0)
		{
			this.Refresh(this.RefreshQueue.Pop());
		}
	}

	// Token: 0x060072C2 RID: 29378 RVA: 0x00235B94 File Offset: 0x00233D94
	[NullableContext(2)]
	private void OnDestroy(AActor _)
	{
		foreach (LevelSequencePlayer levelSequencePlayer in this.SeqPlayerMap.Values)
		{
			levelSequencePlayer.Clear();
		}
		this.SeqPlayerMap.Clear();
	}

	// Token: 0x040047C9 RID: 18377
	private readonly Dictionary<EScoreLevel, UUIItem> CachedScoreItemMap = new Dictionary<EScoreLevel, UUIItem>();

	// Token: 0x040047CA RID: 18378
	private readonly Dictionary<EScoreLevel, LevelSequencePlayer> SeqPlayerMap = new Dictionary<EScoreLevel, LevelSequencePlayer>();

	// Token: 0x040047CB RID: 18379
	private readonly Queue<EScoreLevel> RefreshQueue = new Queue<EScoreLevel>(4);

	// Token: 0x040047CC RID: 18380
	private readonly UiPanelBase ContextObject;

	// Token: 0x040047CD RID: 18381
	private readonly UUIItem ParentItem;

	// Token: 0x040047CE RID: 18382
	private EScoreLevel? CurrentShowLevel;

	// Token: 0x040047CF RID: 18383
	private bool IsLock;
}
