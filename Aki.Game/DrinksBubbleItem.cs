using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200040B RID: 1035
public class DrinksBubbleItem : UiPanelBase
{
	// Token: 0x06003809 RID: 14345 RVA: 0x0014633E File Offset: 0x0014453E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600380A RID: 14346 RVA: 0x00146361 File Offset: 0x00144561
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600380B RID: 14347 RVA: 0x00146374 File Offset: 0x00144574
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

	// Token: 0x0600380C RID: 14348 RVA: 0x001463F4 File Offset: 0x001445F4
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

	// Token: 0x04002E35 RID: 11829
	[Nullable(2)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02006735 RID: 26421
	private static class EBubble
	{
		// Token: 0x04022175 RID: 139637
		public const int Icon = 0;
	}
}
