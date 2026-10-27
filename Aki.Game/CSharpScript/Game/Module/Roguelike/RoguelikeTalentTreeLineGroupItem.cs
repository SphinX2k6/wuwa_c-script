using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E41 RID: 20033
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeLineGroupItem : UiPanelBase
	{
		// Token: 0x06033A53 RID: 211539 RVA: 0x00C168A8 File Offset: 0x00C14AA8
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

		// Token: 0x06033A54 RID: 211540 RVA: 0x00C16BB4 File Offset: 0x00C14DB4
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

		// Token: 0x06033A55 RID: 211541 RVA: 0x00C16C58 File Offset: 0x00C14E58
		[NullableContext(2)]
		public UUIItem GetDotByIndex(int index)
		{
			if (index < 0 || index >= 6)
			{
				return null;
			}
			return base.GetItem(index);
		}

		// Token: 0x06033A56 RID: 211542 RVA: 0x00C16C6C File Offset: 0x00C14E6C
		[NullableContext(2)]
		public UUIItem GetLinesByIndexInLineId(int index)
		{
			int num = index - 18;
			if (num < 0 || num >= 5)
			{
				return null;
			}
			return base.GetItem(17 + num);
		}

		// Token: 0x06033A57 RID: 211543 RVA: 0x00C16C94 File Offset: 0x00C14E94
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			for (int i = 0; i < 5; i++)
			{
				UUIItem item = base.GetItem(17 + i);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06033A58 RID: 211544 RVA: 0x00C16CC8 File Offset: 0x00C14EC8
		public List<UUIItem> GetAllDots()
		{
			List<UUIItem> list = new List<UUIItem>();
			for (int i = 0; i < 6; i++)
			{
				UUIItem dotByIndex = this.GetDotByIndex(i);
				list.Add(dotByIndex);
			}
			return list;
		}

		// Token: 0x06033A59 RID: 211545 RVA: 0x00C16CF8 File Offset: 0x00C14EF8
		public List<UUIItem> GetDotsByIndexInLineId(int index)
		{
			List<UUIItem> list = new List<UUIItem>();
			int num = RogueTalentTreeDefine.rogueLineIndex2NodeIndex(index);
			if (num == index)
			{
				return list;
			}
			list.Add(this.GetDotByIndex(num));
			if (index >= 18)
			{
				list.Add(this.GetDotByIndex(num + 1));
			}
			return list;
		}

		// Token: 0x0200AFFD RID: 45053
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040356D9 RID: 218841
			public const int ItemDotLock1 = 0;

			// Token: 0x040356DA RID: 218842
			public const int ItemDotLock2 = 1;

			// Token: 0x040356DB RID: 218843
			public const int ItemDotLock3 = 2;

			// Token: 0x040356DC RID: 218844
			public const int ItemDotLock4 = 3;

			// Token: 0x040356DD RID: 218845
			public const int ItemDotLock5 = 4;

			// Token: 0x040356DE RID: 218846
			public const int ItemDotLock6 = 5;

			// Token: 0x040356DF RID: 218847
			public const int ItemDotUnlock1 = 6;

			// Token: 0x040356E0 RID: 218848
			public const int ItemDotUnlock2 = 7;

			// Token: 0x040356E1 RID: 218849
			public const int ItemDotUnlock3 = 8;

			// Token: 0x040356E2 RID: 218850
			public const int ItemDotUnlock4 = 9;

			// Token: 0x040356E3 RID: 218851
			public const int ItemDotUnlock5 = 10;

			// Token: 0x040356E4 RID: 218852
			public const int ItemDotUnlock6 = 11;

			// Token: 0x040356E5 RID: 218853
			public const int ItemDashedLine1 = 12;

			// Token: 0x040356E6 RID: 218854
			public const int ItemDashedLine2 = 13;

			// Token: 0x040356E7 RID: 218855
			public const int ItemDashedLine3 = 14;

			// Token: 0x040356E8 RID: 218856
			public const int ItemDashedLine4 = 15;

			// Token: 0x040356E9 RID: 218857
			public const int ItemDashedLine5 = 16;

			// Token: 0x040356EA RID: 218858
			public const int ItemSolidLine1 = 17;

			// Token: 0x040356EB RID: 218859
			public const int ItemSolidLine2 = 18;

			// Token: 0x040356EC RID: 218860
			public const int ItemSolidLine3 = 19;

			// Token: 0x040356ED RID: 218861
			public const int ItemSolidLine4 = 20;

			// Token: 0x040356EE RID: 218862
			public const int ItemSolidLine5 = 21;
		}
	}
}
