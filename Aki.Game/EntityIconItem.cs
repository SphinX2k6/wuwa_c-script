using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001ABA RID: 6842
[NullableContext(2)]
[Nullable(0)]
public class EntityIconItem : UiPanelBase
{
	// Token: 0x06010F03 RID: 69379 RVA: 0x004F7B96 File Offset: 0x004F5D96
	public EntityIconItem(UUIItem item)
	{
		this.Item = item;
		this.UiSequencePlayer = new LevelSequencePlayer(item);
	}

	// Token: 0x06010F04 RID: 69380 RVA: 0x004F7BB1 File Offset: 0x004F5DB1
	public UUIItem GetItsItem()
	{
		return this.Item;
	}

	// Token: 0x06010F05 RID: 69381 RVA: 0x004F7BB9 File Offset: 0x004F5DB9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06010F06 RID: 69382 RVA: 0x004F7BF2 File Offset: 0x004F5DF2
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

	// Token: 0x06010F07 RID: 69383 RVA: 0x004F7C1C File Offset: 0x004F5E1C
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

	// Token: 0x0400955F RID: 38239
	protected LevelSequencePlayer UiSequencePlayer;

	// Token: 0x04009560 RID: 38240
	protected UUIItem Item;

	// Token: 0x04009561 RID: 38241
	protected ESprColor ItsColor;

	// Token: 0x02007D66 RID: 32102
	[NullableContext(0)]
	private enum EItemIconType
	{
		// Token: 0x0402898D RID: 166285
		SprGreen,
		// Token: 0x0402898E RID: 166286
		SprYellow
	}
}
