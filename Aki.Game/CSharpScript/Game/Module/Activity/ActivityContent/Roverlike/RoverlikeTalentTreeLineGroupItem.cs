using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061A4 RID: 24996
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeTalentTreeLineGroupItem : UiPanelBase
	{
		// Token: 0x0603F20F RID: 258575 RVA: 0x00F3FC7C File Offset: 0x00F3DE7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 22;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F210 RID: 258576 RVA: 0x00F3FF88 File Offset: 0x00F3E188
		protected override void OnStart()
		{
			base.GetItem(12).SetUIActive(false);
			base.GetItem(13).SetUIActive(false);
			base.GetItem(14).SetUIActive(false);
			base.GetItem(15).SetUIActive(false);
			base.GetItem(16).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
			base.GetItem(11).SetUIActive(false);
		}

		// Token: 0x0603F211 RID: 258577 RVA: 0x00F4002C File Offset: 0x00F3E22C
		public UUIItem GetLockDotByIndex(int nodeIndex)
		{
			if (nodeIndex < 0 || nodeIndex >= 6)
			{
				return null;
			}
			return base.GetItem(nodeIndex);
		}

		// Token: 0x0603F212 RID: 258578 RVA: 0x00F4003F File Offset: 0x00F3E23F
		public UUIItem GetUnlockDotByIndex(int nodeIndex)
		{
			if (nodeIndex < 0 || nodeIndex >= 6)
			{
				return null;
			}
			return base.GetItem(6 + nodeIndex);
		}

		// Token: 0x0603F213 RID: 258579 RVA: 0x00F40054 File Offset: 0x00F3E254
		public UUIItem GetSolidLineByIndexInLineId(int index)
		{
			int num = index - 18;
			if (num < 0 || num >= 5)
			{
				return null;
			}
			return base.GetItem(17 + num);
		}

		// Token: 0x0603F214 RID: 258580 RVA: 0x00F4007C File Offset: 0x00F3E27C
		public UUIItem GetDashedLineByIndexInLineId(int index)
		{
			int num = index - 18;
			if (num < 0 || num >= 5)
			{
				return null;
			}
			return base.GetItem(12 + num);
		}

		// Token: 0x0603F215 RID: 258581 RVA: 0x00F400A4 File Offset: 0x00F3E2A4
		[NullableContext(1)]
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			for (int i = 0; i < 5; i++)
			{
				list.Add(base.GetItem(17 + i));
				list.Add(base.GetItem(12 + i));
			}
			return list;
		}

		// Token: 0x0603F216 RID: 258582 RVA: 0x00F400E4 File Offset: 0x00F3E2E4
		[NullableContext(1)]
		public List<UUIItem> GetAllDots()
		{
			List<UUIItem> list = new List<UUIItem>();
			for (int i = 0; i < 6; i++)
			{
				list.Add(base.GetItem(i));
				list.Add(base.GetItem(6 + i));
			}
			return list;
		}

		// Token: 0x0603F217 RID: 258583 RVA: 0x00F40120 File Offset: 0x00F3E320
		[NullableContext(1)]
		public List<int> GetDotNodeIndicesByLineId(int index)
		{
			List<int> list = new List<int>();
			int num = RoverlikeTalentTreeDefine.RoverlikeLineIndex2NodeIndex(index);
			if (num == index)
			{
				return list;
			}
			list.Add(num);
			if (index >= 18)
			{
				list.Add(num + 1);
			}
			return list;
		}

		// Token: 0x0200C3F0 RID: 50160
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403B20B RID: 242187
			public const int ItemDotLock1 = 0;

			// Token: 0x0403B20C RID: 242188
			public const int ItemDotLock2 = 1;

			// Token: 0x0403B20D RID: 242189
			public const int ItemDotLock3 = 2;

			// Token: 0x0403B20E RID: 242190
			public const int ItemDotLock4 = 3;

			// Token: 0x0403B20F RID: 242191
			public const int ItemDotLock5 = 4;

			// Token: 0x0403B210 RID: 242192
			public const int ItemDotLock6 = 5;

			// Token: 0x0403B211 RID: 242193
			public const int ItemDotUnlock1 = 6;

			// Token: 0x0403B212 RID: 242194
			public const int ItemDotUnlock2 = 7;

			// Token: 0x0403B213 RID: 242195
			public const int ItemDotUnlock3 = 8;

			// Token: 0x0403B214 RID: 242196
			public const int ItemDotUnlock4 = 9;

			// Token: 0x0403B215 RID: 242197
			public const int ItemDotUnlock5 = 10;

			// Token: 0x0403B216 RID: 242198
			public const int ItemDotUnlock6 = 11;

			// Token: 0x0403B217 RID: 242199
			public const int ItemDashedLine1 = 12;

			// Token: 0x0403B218 RID: 242200
			public const int ItemDashedLine2 = 13;

			// Token: 0x0403B219 RID: 242201
			public const int ItemDashedLine3 = 14;

			// Token: 0x0403B21A RID: 242202
			public const int ItemDashedLine4 = 15;

			// Token: 0x0403B21B RID: 242203
			public const int ItemDashedLine5 = 16;

			// Token: 0x0403B21C RID: 242204
			public const int ItemSolidLine1 = 17;

			// Token: 0x0403B21D RID: 242205
			public const int ItemSolidLine2 = 18;

			// Token: 0x0403B21E RID: 242206
			public const int ItemSolidLine3 = 19;

			// Token: 0x0403B21F RID: 242207
			public const int ItemSolidLine4 = 20;

			// Token: 0x0403B220 RID: 242208
			public const int ItemSolidLine5 = 21;
		}
	}
}
