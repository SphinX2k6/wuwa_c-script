using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F56 RID: 3926
public class DrinksBubbleItem : UiPanelBase
{
	// Token: 0x06006471 RID: 25713 RVA: 0x0013DAA2 File Offset: 0x0013BCA2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x06006472 RID: 25714 RVA: 0x0013DAC5 File Offset: 0x0013BCC5
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06006473 RID: 25715 RVA: 0x0013DAD8 File Offset: 0x0013BCD8
	public void SetIsVisible(bool value, bool isEnd = false)
	{
		bool flag = base.IsUiActiveInHierarchy();
		if ((value == flag && !value) || isEnd)
		{
			return;
		}
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopSequenceByKey("Start", false, false);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 != null)
		{
			sequencePlayer2.StopSequenceByKey("Close", false, false);
		}
		LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
		if (sequencePlayer3 == null)
		{
			return;
		}
		sequencePlayer3.PlayLevelSequenceByName(value ? "Start" : "Close", false, null, false);
	}

	// Token: 0x06006474 RID: 25716 RVA: 0x0013DB58 File Offset: 0x0013BD58
	public void Update(bool isBatching, int id)
	{
		string path;
		if (isBatching)
		{
			path = DrinksConfig.Instance.GetBatching(id).Value.Icon;
		}
		else
		{
			path = DrinksConfig.Instance.GetDrinkBase(id).Value.DrinkIcon;
		}
		base.SetTextureByPath(path, base.GetTexture(0), null, null);
	}

	// Token: 0x04002D9C RID: 11676
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x020075A1 RID: 30113
	private static class EBubble
	{
		// Token: 0x04026E2A RID: 159274
		public const int Icon = 0;
	}
}
