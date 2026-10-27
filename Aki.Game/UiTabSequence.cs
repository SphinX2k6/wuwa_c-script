using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001A8A RID: 6794
[NullableContext(1)]
[Nullable(0)]
public class UiTabSequence : UiTabViewBehavior
{
	// Token: 0x0600C87A RID: 51322 RVA: 0x002DBAF1 File Offset: 0x002D9CF1
	public void SetRootItem(UiTabViewBase tabView)
	{
		this.TabView = tabView;
	}

	// Token: 0x0600C87B RID: 51323 RVA: 0x002DBAFA File Offset: 0x002D9CFA
	public override void Init()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.TabView.GetRootItem());
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
	}

	// Token: 0x0600C87C RID: 51324 RVA: 0x002DBB2C File Offset: 0x002D9D2C
	public override void Begin()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600C87D RID: 51325 RVA: 0x002DBB54 File Offset: 0x002D9D54
	public override void ShowFromToggle()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Sle", false, null, false);
	}

	// Token: 0x0600C87E RID: 51326 RVA: 0x002DBB7C File Offset: 0x002D9D7C
	public override void ShowFromView()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("ShowView", false, null, false);
	}

	// Token: 0x0600C87F RID: 51327 RVA: 0x002DBBA4 File Offset: 0x002D9DA4
	public override void Hide()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.StopCurrentSequence(false, false);
	}

	// Token: 0x0600C880 RID: 51328 RVA: 0x002DBBB8 File Offset: 0x002D9DB8
	public override void Destroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		Dictionary<string, HashSet<Action>> sequenceFinishEvent = this.SequenceFinishEvent;
		if (sequenceFinishEvent == null)
		{
			return;
		}
		sequenceFinishEvent.Clear();
	}

	// Token: 0x0600C881 RID: 51329 RVA: 0x002DBBE4 File Offset: 0x002D9DE4
	public void PlaySequence(string sequenceName)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x0600C882 RID: 51330 RVA: 0x002DBC10 File Offset: 0x002D9E10
	public void AddSequenceFinishEvent(string sequenceName, Action finishEvent, bool clear = false)
	{
		if (this.SequenceFinishEvent == null)
		{
			this.SequenceFinishEvent = new Dictionary<string, HashSet<Action>>();
		}
		HashSet<Action> hashSet;
		if (!this.SequenceFinishEvent.TryGetValue(sequenceName, out hashSet))
		{
			hashSet = new HashSet<Action>();
			this.SequenceFinishEvent[sequenceName] = hashSet;
		}
		else if (clear)
		{
			hashSet.Clear();
		}
		hashSet.Add(finishEvent);
	}

	// Token: 0x0600C883 RID: 51331 RVA: 0x002DBC66 File Offset: 0x002D9E66
	[NullableContext(2)]
	public LevelSequencePlayer GetLevelSequencePlayer()
	{
		return this.LevelSequencePlayer;
	}

	// Token: 0x0600C884 RID: 51332 RVA: 0x002DBC70 File Offset: 0x002D9E70
	private void FinishSequenceEvent(string sequenceName)
	{
		Dictionary<string, HashSet<Action>> sequenceFinishEvent = this.SequenceFinishEvent;
		HashSet<Action> hashSet;
		if (sequenceFinishEvent == null || !sequenceFinishEvent.TryGetValue(sequenceName, out hashSet))
		{
			return;
		}
		foreach (Action action in hashSet)
		{
			if (action != null)
			{
				action();
			}
		}
	}

	// Token: 0x04005C6C RID: 23660
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04005C6D RID: 23661
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, HashSet<Action>> SequenceFinishEvent;

	// Token: 0x04005C6E RID: 23662
	[Nullable(2)]
	private UiTabViewBase TabView;
}
