using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060DE RID: 24798
	public class BigStuffedRingSubItem<T> : UiPanelBase where T : Enum
	{
		// Token: 0x0603B751 RID: 243537 RVA: 0x010D43B5 File Offset: 0x010D25B5
		public BigStuffedRingSubItem(int RingId, [Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockRing, BrokenRockRingConfig> RingConfig)
		{
			this.RingId = RingId;
			this.RingConfig = RingConfig;
		}

		// Token: 0x0603B752 RID: 243538 RVA: 0x010D43CC File Offset: 0x010D25CC
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

		// Token: 0x0603B753 RID: 243539 RVA: 0x010D4435 File Offset: 0x010D2635
		protected override void OnStart()
		{
			this.TextureRing = base.GetTexture(1);
		}

		// Token: 0x0603B754 RID: 243540 RVA: 0x010D4444 File Offset: 0x010D2644
		protected override void OnBeforeDestroy()
		{
			this.TextureRing = null;
		}

		// Token: 0x0401F590 RID: 128400
		[Nullable(2)]
		protected T Type;

		// Token: 0x0401F591 RID: 128401
		[Nullable(2)]
		protected UUITexture TextureRing;

		// Token: 0x0401F592 RID: 128402
		protected int RingId;

		// Token: 0x0401F593 RID: 128403
		[Nullable(new byte[]
		{
			0,
			1
		})]
		protected OneOf<BrokenRockRing, BrokenRockRingConfig> RingConfig;
	}
}
