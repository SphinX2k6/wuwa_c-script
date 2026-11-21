using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020005AA RID: 1450
public class ArtemisQteClickTipsItem : UiPanelBase
{
	// Token: 0x060044DD RID: 17629 RVA: 0x0017ACC9 File Offset: 0x00178EC9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x0017ACEC File Offset: 0x00178EEC
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x060044DF RID: 17631 RVA: 0x0017AD17 File Offset: 0x00178F17
	protected override void OnBeforeHide()
	{
		this.InProgressType = EArtemisTipsType.None;
	}

	// Token: 0x060044E0 RID: 17632 RVA: 0x0017AD20 File Offset: 0x00178F20
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
	}

	// Token: 0x060044E1 RID: 17633 RVA: 0x0017AD3C File Offset: 0x00178F3C
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

	// Token: 0x060044E2 RID: 17634 RVA: 0x0017AD90 File Offset: 0x00178F90
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

	// Token: 0x060044E3 RID: 17635 RVA: 0x0017ADEC File Offset: 0x00178FEC
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

	// Token: 0x060044E4 RID: 17636 RVA: 0x0017AE3C File Offset: 0x0017903C
	private void SetTipMiss()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Activity_ArtemisChatFixTips_Miss", Array.Empty<object>());
	}

	// Token: 0x060044E5 RID: 17637 RVA: 0x0017AE59 File Offset: 0x00179059
	private void SetTipSuccess()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Activity_ArtemisChatFixTips_Perfect", Array.Empty<object>());
	}

	// Token: 0x0400350A RID: 13578
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400350B RID: 13579
	protected EArtemisTipsType InProgressType;

	// Token: 0x02006852 RID: 26706
	private class EComponents
	{
		// Token: 0x04022655 RID: 140885
		public const int Tips = 0;
	}
}
