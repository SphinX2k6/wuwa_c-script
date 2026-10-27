using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010F6 RID: 4342
public class ArtemisQteClickTipsItem : UiPanelBase
{
	// Token: 0x06007147 RID: 28999 RVA: 0x0017230D File Offset: 0x0017050D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06007148 RID: 29000 RVA: 0x00172330 File Offset: 0x00170530
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x06007149 RID: 29001 RVA: 0x0017235B File Offset: 0x0017055B
	protected override void OnBeforeHide()
	{
		this.InProgressType = EArtemisTipsType.None;
	}

	// Token: 0x0600714A RID: 29002 RVA: 0x00172364 File Offset: 0x00170564
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x0600714B RID: 29003 RVA: 0x00172380 File Offset: 0x00170580
	[NullableContext(1)]
	private void OnSequenceClose(string sequenceName)
	{
		EArtemisTipsType eartemisTipsType = EArtemisTipsType.None;
		if (!(sequenceName == "Fail"))
		{
			if (!(sequenceName == "QteSuccess"))
			{
				if (sequenceName == "Success")
				{
					eartemisTipsType = EArtemisTipsType.None;
				}
			}
			else
			{
				eartemisTipsType = EArtemisTipsType.Perfect;
			}
		}
		else
		{
			eartemisTipsType = EArtemisTipsType.Miss;
		}
		if (eartemisTipsType == this.InProgressType)
		{
			this.SetActive(false);
		}
	}

	// Token: 0x0600714C RID: 29004 RVA: 0x001723D4 File Offset: 0x001705D4
	[NullableContext(1)]
	private void PlayAnim(string sequenceName)
	{
		if (this.LevelSequencePlayer.GetCurrentSequence() == sequenceName)
		{
			this.LevelSequencePlayer.ReplaySequenceByKey(sequenceName);
		}
		else
		{
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}
		this.SetActive(true);
	}

	// Token: 0x0600714D RID: 29005 RVA: 0x00172430 File Offset: 0x00170630
	public void ShowTip(EArtemisTipsType tipsType)
	{
		string sequenceName = "Success";
		switch (tipsType)
		{
		case EArtemisTipsType.None:
			return;
		case EArtemisTipsType.Miss:
			this.SetTipMiss();
			sequenceName = "Fail";
			break;
		case EArtemisTipsType.Perfect:
			this.SetTipSuccess();
			sequenceName = "QteSuccess";
			break;
		}
		this.InProgressType = tipsType;
		this.PlayAnim(sequenceName);
	}

	// Token: 0x0600714E RID: 29006 RVA: 0x00172480 File Offset: 0x00170680
	private void SetTipMiss()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Activity_ArtemisChatFixTips_Miss", Array.Empty<object>());
	}

	// Token: 0x0600714F RID: 29007 RVA: 0x0017249D File Offset: 0x0017069D
	private void SetTipSuccess()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Activity_ArtemisChatFixTips_Perfect", Array.Empty<object>());
	}

	// Token: 0x04003471 RID: 13425
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003472 RID: 13426
	protected EArtemisTipsType InProgressType;

	// Token: 0x020076BE RID: 30398
	private class EComponents
	{
		// Token: 0x0402730C RID: 160524
		public const int Tips = 0;
	}
}
