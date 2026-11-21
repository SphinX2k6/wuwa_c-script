using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000F49 RID: 3913
[NullableContext(1)]
[Nullable(0)]
public class UiTabSequence : UiTabViewBehavior
{
	// Token: 0x06009C8B RID: 40075 RVA: 0x002E6C99 File Offset: 0x002E4E99
	public void SetRootItem(UiTabViewBase tabView)
	{
		this.TabView = tabView;
	}

	// Token: 0x06009C8C RID: 40076 RVA: 0x002E6CA2 File Offset: 0x002E4EA2
	public override void Init()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.TabView.GetRootItem());
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
	}

	// Token: 0x06009C8D RID: 40077 RVA: 0x002E6CD4 File Offset: 0x002E4ED4
	public override void Begin()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x06009C8E RID: 40078 RVA: 0x002E6CFC File Offset: 0x002E4EFC
	public override void ShowFromToggle()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Sle", false, null, false);
	}

	// Token: 0x06009C8F RID: 40079 RVA: 0x002E6D24 File Offset: 0x002E4F24
	public override void ShowFromView()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("ShowView", false, null, false);
	}

	// Token: 0x06009C90 RID: 40080 RVA: 0x002E6D4C File Offset: 0x002E4F4C
	public override void Hide()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.StopCurrentSequence(false, false);
	}

	// Token: 0x06009C91 RID: 40081 RVA: 0x002E6D60 File Offset: 0x002E4F60
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

	// Token: 0x06009C92 RID: 40082 RVA: 0x002E6D8C File Offset: 0x002E4F8C
	public void PlaySequence(string sequenceName)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x06009C93 RID: 40083 RVA: 0x002E6DB8 File Offset: 0x002E4FB8
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

	// Token: 0x06009C94 RID: 40084 RVA: 0x002E6E0E File Offset: 0x002E500E
	[NullableContext(2)]
	public LevelSequencePlayer GetLevelSequencePlayer()
	{
		return this.LevelSequencePlayer;
	}

	// Token: 0x06009C95 RID: 40085 RVA: 0x002E6E18 File Offset: 0x002E5018
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

	// Token: 0x04005D3B RID: 23867
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04005D3C RID: 23868
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<string, HashSet<Action>> SequenceFinishEvent;

	// Token: 0x04005D3D RID: 23869
	[Nullable(2)]
	private UiTabViewBase TabView;
}
