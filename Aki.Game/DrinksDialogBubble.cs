using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F5A RID: 3930
public class DrinksDialogBubble : UiPanelBase
{
	// Token: 0x0600648B RID: 25739 RVA: 0x0013E404 File Offset: 0x0013C604
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600648C RID: 25740 RVA: 0x0013E460 File Offset: 0x0013C660
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(this.RootItem);
		this.LevelSequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceStop), false);
		int roleId = DrinksModel.Instance.GetRoleId();
		base.SetRoleIcon("", base.GetTexture(0), roleId, null, null);
		base.SetUiActive(false);
	}

	// Token: 0x0600648D RID: 25741 RVA: 0x0013E4C8 File Offset: 0x0013C6C8
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

	// Token: 0x0600648E RID: 25742 RVA: 0x0013E5E8 File Offset: 0x0013C7E8
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

	// Token: 0x0600648F RID: 25743 RVA: 0x0013E6A2 File Offset: 0x0013C8A2
	[NullableContext(1)]
	private void OnSequenceStop(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			base.SetUiActive(false);
		}
	}

	// Token: 0x04002DA3 RID: 11683
	protected int EventHandle;

	// Token: 0x04002DA4 RID: 11684
	[Nullable(2)]
	protected TimerHandle TimerDelay;

	// Token: 0x04002DA5 RID: 11685
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x020075A6 RID: 30118
	private static class EItem
	{
		// Token: 0x04026E39 RID: 159289
		public const int TexIcon = 0;

		// Token: 0x04026E3A RID: 159290
		public const int Txt = 1;

		// Token: 0x04026E3B RID: 159291
		public const int PanelGood = 2;
	}
}
