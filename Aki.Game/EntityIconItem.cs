using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020025CF RID: 9679
[NullableContext(2)]
[Nullable(0)]
public class EntityIconItem : UiPanelBase
{
	// Token: 0x06013A23 RID: 80419 RVA: 0x004E8F96 File Offset: 0x004E7196
	public EntityIconItem(UUIItem item)
	{
		this.Item = item;
		this.UiSequencePlayer = new LevelSequencePlayer(item);
	}

	// Token: 0x06013A24 RID: 80420 RVA: 0x004E8FB1 File Offset: 0x004E71B1
	public UUIItem GetItsItem()
	{
		return this.Item;
	}

	// Token: 0x06013A25 RID: 80421 RVA: 0x004E8FB9 File Offset: 0x004E71B9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06013A26 RID: 80422 RVA: 0x004E8FF2 File Offset: 0x004E71F2
	public void InitSpr()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x06013A27 RID: 80423 RVA: 0x004E901C File Offset: 0x004E721C
	public void UpdateNowIcon(ESprColor toColor)
	{
		switch (toColor)
		{
		case ESprColor.None:
			if (this.ItsColor == ESprColor.Green)
			{
				this.UiSequencePlayer.StopCurrentSequence(false, true);
				this.UiSequencePlayer.PlayLevelSequenceByName("GtoN", false, null, false);
				this.ItsColor = ESprColor.None;
				return;
			}
			if (this.ItsColor == ESprColor.Yellow)
			{
				this.UiSequencePlayer.StopCurrentSequence(false, true);
				this.UiSequencePlayer.PlayLevelSequenceByName("YtoN", false, null, false);
				this.ItsColor = ESprColor.None;
			}
			break;
		case ESprColor.Yellow:
			if (this.ItsColor == ESprColor.None)
			{
				this.UiSequencePlayer.StopCurrentSequence(false, true);
				this.UiSequencePlayer.PlayLevelSequenceByName("NtoY", false, null, false);
				this.ItsColor = ESprColor.Yellow;
				return;
			}
			if (this.ItsColor == ESprColor.Green)
			{
				this.UiSequencePlayer.StopCurrentSequence(false, true);
				this.UiSequencePlayer.PlayLevelSequenceByName("GtoY", false, null, false);
				this.ItsColor = ESprColor.Yellow;
				return;
			}
			break;
		case ESprColor.Green:
			if (this.ItsColor == ESprColor.None)
			{
				this.UiSequencePlayer.StopCurrentSequence(false, true);
				this.UiSequencePlayer.PlayLevelSequenceByName("NtoG", false, null, false);
				this.ItsColor = ESprColor.Green;
				return;
			}
			if (this.ItsColor == ESprColor.Yellow)
			{
				this.UiSequencePlayer.StopCurrentSequence(false, true);
				this.UiSequencePlayer.PlayLevelSequenceByName("YtoG", false, null, false);
				this.ItsColor = ESprColor.Green;
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x04009409 RID: 37897
	protected LevelSequencePlayer UiSequencePlayer;

	// Token: 0x0400940A RID: 37898
	protected UUIItem Item;

	// Token: 0x0400940B RID: 37899
	protected ESprColor ItsColor;

	// Token: 0x02008BDE RID: 35806
	[NullableContext(0)]
	private enum EItemIconType
	{
		// Token: 0x0402D678 RID: 185976
		SprGreen,
		// Token: 0x0402D679 RID: 185977
		SprYellow
	}
}
