using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EA0 RID: 7840
public class HonamiStorySlotLockStateItem : UiPanelBase
{
	// Token: 0x0600F0BF RID: 61631 RVA: 0x0039D008 File Offset: 0x0039B208
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUINiagara))
		};
	}

	// Token: 0x0600F0C0 RID: 61632 RVA: 0x0039D041 File Offset: 0x0039B241
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
	}

	// Token: 0x0600F0C1 RID: 61633 RVA: 0x0039D06C File Offset: 0x0039B26C
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnLevelSeq));
	}

	// Token: 0x0600F0C2 RID: 61634 RVA: 0x0039D08A File Offset: 0x0039B28A
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnLevelSeq));
	}

	// Token: 0x0600F0C3 RID: 61635 RVA: 0x0039D0A8 File Offset: 0x0039B2A8
	public void RefreshState(bool isLock, bool isFirstLock, bool canUpdate)
	{
		if (isLock)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(isLock);
			}
			bool flag;
			if (canUpdate)
			{
				bool? canUpdate2 = this.CanUpdate;
				flag = !(canUpdate == canUpdate2.GetValueOrDefault() & canUpdate2 != null);
			}
			else
			{
				flag = false;
			}
			if (flag && isFirstLock)
			{
				if (this.IsFirstLock != null && !this.IsFirstLock.Value)
				{
					this.NeedCanUpdateAnim = true;
				}
				else if (!this.LevelSequencePlayer.IsPlayingSequence("Tips_Square"))
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.PlayLevelSequenceByName("Tips_Square", false, null, false);
					}
				}
			}
			else if (!canUpdate)
			{
				UUINiagara uiNiagara = base.GetUiNiagara(1);
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(false);
				}
			}
			this.CanUpdate = new bool?(canUpdate && isFirstLock);
		}
		if (!isLock && this.IsLock.GetValueOrDefault())
		{
			UUINiagara uiNiagara2 = base.GetUiNiagara(1);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(false);
			}
			if (!this.LevelSequencePlayer.IsPlayingSequence("Hide"))
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlayLevelSequenceByName("Hide", false, null, false);
				}
			}
		}
		else
		{
			this.RefreshUnlockState(isFirstLock);
		}
		this.IsLock = new bool?(isLock);
	}

	// Token: 0x0600F0C4 RID: 61636 RVA: 0x0039D1DC File Offset: 0x0039B3DC
	public void RefreshUnlockState(bool isFirstLock = false)
	{
		if (this.IsFirstLock != null && !this.IsFirstLock.Value && isFirstLock)
		{
			if (!this.LevelSequencePlayer.IsPlayingSequence("Show"))
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
				}
			}
		}
		else
		{
			string resourceId = isFirstLock ? "SP_GridIconAdd" : "SP_GridIconLock";
			UiResourceConfig instance = UiResourceConfig.Instance;
			string text = (instance != null) ? instance.GetResourcePath(resourceId) : null;
			this.SetSpriteByPath(text ?? string.Empty, base.GetSprite(0), false, null, null);
		}
		this.IsFirstLock = new bool?(isFirstLock);
	}

	// Token: 0x0600F0C5 RID: 61637 RVA: 0x0039D294 File Offset: 0x0039B494
	[NullableContext(1)]
	private void OnSeqEnd(string seqName)
	{
		if (seqName == "Hide")
		{
			base.SetUiActive(false);
			return;
		}
		if (seqName == "Show" && this.NeedCanUpdateAnim)
		{
			this.NeedCanUpdateAnim = false;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Tips_Square", false, null, false);
		}
	}

	// Token: 0x0600F0C6 RID: 61638 RVA: 0x0039D2F4 File Offset: 0x0039B4F4
	[NullableContext(1)]
	private void OnLevelSeq(string param)
	{
		if (param != "EmptyGridUnlock" || !this.LevelSequencePlayer.IsPlayingSequence("Show"))
		{
			return;
		}
		UiResourceConfig instance = UiResourceConfig.Instance;
		string text = (instance != null) ? instance.GetResourcePath("SP_GridIconAdd") : null;
		this.SetSpriteByPath(text ?? string.Empty, base.GetSprite(0), false, null, null);
	}

	// Token: 0x04006F59 RID: 28505
	private bool? IsLock;

	// Token: 0x04006F5A RID: 28506
	private bool? IsFirstLock;

	// Token: 0x04006F5B RID: 28507
	private bool? CanUpdate;

	// Token: 0x04006F5C RID: 28508
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006F5D RID: 28509
	private bool NeedCanUpdateAnim;

	// Token: 0x02008469 RID: 33897
	private enum ESlotLock
	{
		// Token: 0x0402B193 RID: 176531
		Sprite,
		// Token: 0x0402B194 RID: 176532
		Niagara
	}
}
