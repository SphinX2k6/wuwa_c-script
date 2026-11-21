using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A7E RID: 14974
	public class TrapDefenseTalentTreeRowLineListItem : UiPanelBase
	{
		// Token: 0x0602677F RID: 157567 RVA: 0x00AC6CF0 File Offset: 0x00AC4EF0
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

		// Token: 0x06026780 RID: 157568 RVA: 0x00AC6FFC File Offset: 0x00AC51FC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<UUIItem, UUIItem>? GetDotByIndex(int index)
		{
			if (index < 0 || index >= 6)
			{
				return null;
			}
			UUIItem item = base.GetItem(index);
			return new ValueTuple<UUIItem, UUIItem>?(new ValueTuple<UUIItem, UUIItem>(base.GetItem(6 + index), item));
		}

		// Token: 0x06026781 RID: 157569 RVA: 0x00AC7038 File Offset: 0x00AC5238
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<UUIItem, UUIItem>? GetLinesByIndexInLineId(int index)
		{
			int num = index - 18;
			if (num < 0 || num >= 5)
			{
				return null;
			}
			UUIItem item = base.GetItem(12 + num);
			return new ValueTuple<UUIItem, UUIItem>?(new ValueTuple<UUIItem, UUIItem>(base.GetItem(17 + num), item));
		}

		// Token: 0x06026782 RID: 157570 RVA: 0x00AC707C File Offset: 0x00AC527C
		[NullableContext(1)]
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			for (int i = 0; i < 5; i++)
			{
				UUIItem item = base.GetItem(12 + i);
				UUIItem item2 = base.GetItem(17 + i);
				list.Add(item);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x06026783 RID: 157571 RVA: 0x00AC70C0 File Offset: 0x00AC52C0
		[NullableContext(1)]
		public List<UUIItem> GetAllDots()
		{
			List<UUIItem> list = new List<UUIItem>();
			for (int i = 0; i < 6; i++)
			{
				ValueTuple<UUIItem, UUIItem> value = this.GetDotByIndex(i).Value;
				list.Add(value.Item1);
				list.Add(value.Item2);
			}
			return list;
		}

		// Token: 0x06026784 RID: 157572 RVA: 0x00AC7108 File Offset: 0x00AC5308
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public List<ValueTuple<UUIItem, UUIItem>> GetDotsByIndexInLineId(int index)
		{
			List<ValueTuple<UUIItem, UUIItem>> list = new List<ValueTuple<UUIItem, UUIItem>>();
			int num = TrapDefenseDefine.LineIndex2NodeIndex(index);
			if (num == index)
			{
				return list;
			}
			list.Add(this.GetDotByIndex(num).Value);
			if (index >= 18)
			{
				list.Add(this.GetDotByIndex(num + 1).Value);
			}
			return list;
		}

		// Token: 0x02009671 RID: 38513
		private class EComponentDefine
		{
			// Token: 0x0402EF80 RID: 192384
			public const int ItemDotLock1 = 0;

			// Token: 0x0402EF81 RID: 192385
			public const int ItemDotLock2 = 1;

			// Token: 0x0402EF82 RID: 192386
			public const int ItemDotLock3 = 2;

			// Token: 0x0402EF83 RID: 192387
			public const int ItemDotLock4 = 3;

			// Token: 0x0402EF84 RID: 192388
			public const int ItemDotLock5 = 4;

			// Token: 0x0402EF85 RID: 192389
			public const int ItemDotLock6 = 5;

			// Token: 0x0402EF86 RID: 192390
			public const int ItemDotUnlock1 = 6;

			// Token: 0x0402EF87 RID: 192391
			public const int ItemDotUnlock2 = 7;

			// Token: 0x0402EF88 RID: 192392
			public const int ItemDotUnlock3 = 8;

			// Token: 0x0402EF89 RID: 192393
			public const int ItemDotUnlock4 = 9;

			// Token: 0x0402EF8A RID: 192394
			public const int ItemDotUnlock5 = 10;

			// Token: 0x0402EF8B RID: 192395
			public const int ItemDotUnlock6 = 11;

			// Token: 0x0402EF8C RID: 192396
			public const int ItemDashedLine1 = 12;

			// Token: 0x0402EF8D RID: 192397
			public const int ItemDashedLine2 = 13;

			// Token: 0x0402EF8E RID: 192398
			public const int ItemDashedLine3 = 14;

			// Token: 0x0402EF8F RID: 192399
			public const int ItemDashedLine4 = 15;

			// Token: 0x0402EF90 RID: 192400
			public const int ItemDashedLine5 = 16;

			// Token: 0x0402EF91 RID: 192401
			public const int ItemSolidLine1 = 17;

			// Token: 0x0402EF92 RID: 192402
			public const int ItemSolidLine2 = 18;

			// Token: 0x0402EF93 RID: 192403
			public const int ItemSolidLine3 = 19;

			// Token: 0x0402EF94 RID: 192404
			public const int ItemSolidLine4 = 20;

			// Token: 0x0402EF95 RID: 192405
			public const int ItemSolidLine5 = 21;
		}
	}
}
