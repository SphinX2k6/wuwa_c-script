using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001045 RID: 4165
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PointItem : GridProxyAbstract<IProgressItem>
{
	// Token: 0x0600A5D6 RID: 42454 RVA: 0x0030CEE4 File Offset: 0x0030B0E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A5D7 RID: 42455 RVA: 0x0030CF2C File Offset: 0x0030B12C
	public override void Refresh(IProgressItem data, bool isSelected, int gridIndex)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(!data.IsPassed);
		}
		if (!this.LastIsPassed && data.IsPassed)
		{
			this.ShowPassAnim();
		}
		this.LastIsPassed = data.IsPassed;
	}

	// Token: 0x0600A5D8 RID: 42456 RVA: 0x0030CF6C File Offset: 0x0030B16C
	public void ShowPassAnim()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("DayGone", false, null, false);
	}

	// Token: 0x04006107 RID: 24839
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006108 RID: 24840
	private bool LastIsPassed;

	// Token: 0x02007298 RID: 29336
	[NullableContext(0)]
	private class EPointItemComponentDefine
	{
		// Token: 0x0402551C RID: 152860
		public const int ShowSprite = 0;
	}
}
