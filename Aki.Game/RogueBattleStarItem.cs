using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C55 RID: 7253
public class RogueBattleStarItem : GridProxyAbstract<bool>
{
	// Token: 0x06011FF4 RID: 73716 RVA: 0x0054B520 File Offset: 0x00549720
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06011FF5 RID: 73717 RVA: 0x0054B57A File Offset: 0x0054977A
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetSprite(0).SetUIActive(true);
	}

	// Token: 0x06011FF6 RID: 73718 RVA: 0x0054B59A File Offset: 0x0054979A
	public override void Refresh(bool isOn, bool isSelected, int gridIndex)
	{
		base.GetSprite(1).SetUIActive(isOn);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x06011FF7 RID: 73719 RVA: 0x0054B5B8 File Offset: 0x005497B8
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

	// Token: 0x04009CE6 RID: 40166
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;
}
