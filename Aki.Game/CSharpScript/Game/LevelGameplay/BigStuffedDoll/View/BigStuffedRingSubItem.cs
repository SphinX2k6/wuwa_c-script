using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F5D RID: 28509
	public class BigStuffedRingSubItem<T> : UiPanelBase where T : Enum
	{
		// Token: 0x060455A3 RID: 284067 RVA: 0x0112A5D5 File Offset: 0x011287D5
		public BigStuffedRingSubItem(int RingId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockRing, BrokenRockRingConfig> RingConfig)
		{
			this.RingId = RingId;
			this.RingConfig = RingConfig;
		}

		// Token: 0x060455A4 RID: 284068 RVA: 0x0112A5EC File Offset: 0x011287EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060455A5 RID: 284069 RVA: 0x0112A655 File Offset: 0x01128855
		protected override void OnStart()
		{
			this.TextureRing = base.GetTexture(1);
		}

		// Token: 0x060455A6 RID: 284070 RVA: 0x0112A664 File Offset: 0x01128864
		protected override void OnBeforeDestroy()
		{
			this.TextureRing = null;
		}

		// Token: 0x040242DB RID: 148187
		[Nullable(2)]
		protected T Type;

		// Token: 0x040242DC RID: 148188
		[Nullable(2)]
		protected UUITexture TextureRing;

		// Token: 0x040242DD RID: 148189
		protected int RingId;

		// Token: 0x040242DE RID: 148190
		[Nullable(new byte[]
		{
			0,
			1
		})]
		protected OneOf<BrokenRockRing, BrokenRockRingConfig> RingConfig;
	}
}
