using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200040F RID: 1039
public class DrinksDialogBubble : UiPanelBase
{
	// Token: 0x06003823 RID: 14371 RVA: 0x00146CA0 File Offset: 0x00144EA0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06003824 RID: 14372 RVA: 0x00146CFC File Offset: 0x00144EFC
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(this.RootItem);
		this.LevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceStop), false);
		int roleId = DrinksModel.Instance.GetRoleId();
		base.SetRoleIcon("", base.GetTexture(0), roleId, null, null);
		base.SetUiActive(false);
	}

	// Token: 0x06003825 RID: 14373 RVA: 0x00146D64 File Offset: 0x00144F64
	[NullableContext(1)]
	public void ActivateBubble(string configId, bool isLike)
	{
		base.SetUiActive(true);
		if (this.LevelSequence.IsPlayingSequence("Close"))
		{
			LevelSequencePlayer levelSequence = this.LevelSequence;
			if (levelSequence != null)
			{
				levelSequence.StopSequenceByKey("Close", false, false);
			}
		}
		LevelSequencePlayer levelSequence2 = this.LevelSequence;
		if (levelSequence2 != null)
		{
			levelSequence2.PlayOrReplaySequenceByName("Start", false, null);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(isLike);
		}
		DrinksDialog? dialog = DrinksConfig.Instance.GetDialog(configId);
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(configId);
		}
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
		}
		this.EventHandle = AudioSystem.Instance.PostEvent(dialog.Value.AudioEvent);
		if (this.TimerDelay != null)
		{
			TimerSystem.Instance.Remove(this.TimerDelay);
		}
		this.TimerDelay = TimerSystem.Instance.Delay(delegate(float _)
		{
			if (this.LevelSequence.IsPlayingSequence("Start"))
			{
				LevelSequencePlayer levelSequence3 = this.LevelSequence;
				if (levelSequence3 != null)
				{
					levelSequence3.StopSequenceByKey("Start", false, false);
				}
			}
			LevelSequencePlayer levelSequence4 = this.LevelSequence;
			if (levelSequence4 != null)
			{
				levelSequence4.PlayOrReplaySequenceByName("Close", false, null);
			}
			this.TimerDelay = null;
		}, (float)dialog.Value.Delay, null, null, true, 1f);
	}

	// Token: 0x06003826 RID: 14374 RVA: 0x00146E84 File Offset: 0x00145084
	public void DeactivateBubble(bool force = false)
	{
		if (this.EventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.EventHandle, EAudioActionType.Stop, null);
		}
		this.EventHandle = 0;
		if (this.TimerDelay != null)
		{
			TimerSystem.Instance.Remove(this.TimerDelay);
			this.TimerDelay = null;
		}
		if (!base.IsUiActiveInHierarchy())
		{
			return;
		}
		if (this.LevelSequence.IsPlayingSequence("Start"))
		{
			LevelSequencePlayer levelSequence = this.LevelSequence;
			if (levelSequence != null)
			{
				levelSequence.StopSequenceByKey("Start", false, false);
			}
		}
		if (this.LevelSequence.IsPlayingSequence("Close"))
		{
			LevelSequencePlayer levelSequence2 = this.LevelSequence;
			if (levelSequence2 != null)
			{
				levelSequence2.StopSequenceByKey("Close", false, false);
			}
		}
		base.SetUiActive(false);
	}

	// Token: 0x06003827 RID: 14375 RVA: 0x00146F3E File Offset: 0x0014513E
	[NullableContext(1)]
	private void OnSequenceStop(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			base.SetUiActive(false);
		}
	}

	// Token: 0x04002E3C RID: 11836
	protected int EventHandle;

	// Token: 0x04002E3D RID: 11837
	[Nullable(2)]
	protected TimerHandle TimerDelay;

	// Token: 0x04002E3E RID: 11838
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x0200673A RID: 26426
	private static class EItem
	{
		// Token: 0x04022184 RID: 139652
		public const int TexIcon = 0;

		// Token: 0x04022185 RID: 139653
		public const int Txt = 1;

		// Token: 0x04022186 RID: 139654
		public const int PanelGood = 2;
	}
}
