using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200276A RID: 10090
public class RogueBattleStarItem : GridProxyAbstract<bool>
{
	// Token: 0x06014B11 RID: 84753 RVA: 0x0053C710 File Offset: 0x0053A910
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06014B12 RID: 84754 RVA: 0x0053C76A File Offset: 0x0053A96A
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetSprite(0).SetUIActive(true);
	}

	// Token: 0x06014B13 RID: 84755 RVA: 0x0053C78A File Offset: 0x0053A98A
	public override void Refresh(bool isOn, bool isSelected, int gridIndex)
	{
		base.GetSprite(1).SetUIActive(isOn);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x06014B14 RID: 84756 RVA: 0x0053C7A8 File Offset: 0x0053A9A8
	public void SetPreviewAnimOn(bool bOn)
	{
		base.GetSprite(1).SetUIActive(bOn);
		base.GetItem(2).SetUIActive(bOn);
		if (bOn)
		{
			if (this.LevelSequencePlayer.GetCurrentSequence() == "Light")
			{
				this.LevelSequencePlayer.ReplaySequenceByKey("Light");
				return;
			}
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName("Light", false, null, false);
			return;
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.StopSequenceByKey("Light", false, false);
			return;
		}
	}

	// Token: 0x04009B8E RID: 39822
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;
}
