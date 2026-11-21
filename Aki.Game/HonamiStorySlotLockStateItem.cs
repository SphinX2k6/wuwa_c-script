using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001362 RID: 4962
public class HonamiStorySlotLockStateItem : UiPanelBase
{
	// Token: 0x0600C4DE RID: 50398 RVA: 0x003A8BC4 File Offset: 0x003A6DC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUINiagara))
		};
	}

	// Token: 0x0600C4DF RID: 50399 RVA: 0x003A8BFD File Offset: 0x003A6DFD
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
	}

	// Token: 0x0600C4E0 RID: 50400 RVA: 0x003A8C28 File Offset: 0x003A6E28
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnLevelSeq));
	}

	// Token: 0x0600C4E1 RID: 50401 RVA: 0x003A8C46 File Offset: 0x003A6E46
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnLevelSeq));
	}

	// Token: 0x0600C4E2 RID: 50402 RVA: 0x003A8C64 File Offset: 0x003A6E64
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

	// Token: 0x0600C4E3 RID: 50403 RVA: 0x003A8D98 File Offset: 0x003A6F98
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

	// Token: 0x0600C4E4 RID: 50404 RVA: 0x003A8E50 File Offset: 0x003A7050
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

	// Token: 0x0600C4E5 RID: 50405 RVA: 0x003A8EB0 File Offset: 0x003A70B0
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

	// Token: 0x0400703A RID: 28730
	private bool? IsLock;

	// Token: 0x0400703B RID: 28731
	private bool? IsFirstLock;

	// Token: 0x0400703C RID: 28732
	private bool? CanUpdate;

	// Token: 0x0400703D RID: 28733
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400703E RID: 28734
	private bool NeedCanUpdateAnim;

	// Token: 0x020075EE RID: 30190
	private enum ESlotLock
	{
		// Token: 0x040264B7 RID: 156855
		Sprite,
		// Token: 0x040264B8 RID: 156856
		Niagara
	}
}
