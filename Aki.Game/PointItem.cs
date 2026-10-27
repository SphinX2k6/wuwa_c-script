using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B86 RID: 7046
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PointItem : GridProxyAbstract<IProgressItem>
{
	// Token: 0x0600D1C5 RID: 53701 RVA: 0x00301E0C File Offset: 0x0030000C
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

	// Token: 0x0600D1C6 RID: 53702 RVA: 0x00301E54 File Offset: 0x00300054
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

	// Token: 0x0600D1C7 RID: 53703 RVA: 0x00301E94 File Offset: 0x00300094
	public void ShowPassAnim()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("DayGone", false, null, false);
	}

	// Token: 0x04006038 RID: 24632
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006039 RID: 24633
	private bool LastIsPassed;

	// Token: 0x0200810A RID: 33034
	[NullableContext(0)]
	private class EPointItemComponentDefine
	{
		// Token: 0x0402A1E8 RID: 172520
		public const int ShowSprite = 0;
	}
}
