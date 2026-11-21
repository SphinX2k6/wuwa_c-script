using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E0A RID: 15882
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeLineGroupItem : UiPanelBase
	{
		// Token: 0x060288BE RID: 166078 RVA: 0x00B5FDD0 File Offset: 0x00B5DFD0
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

		// Token: 0x060288BF RID: 166079 RVA: 0x00B600DC File Offset: 0x00B5E2DC
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

		// Token: 0x060288C0 RID: 166080 RVA: 0x00B60180 File Offset: 0x00B5E380
		[NullableContext(2)]
		public UUIItem GetDotByIndex(int index)
		{
			if (index < 0 || index >= 6)
			{
				return null;
			}
			return base.GetItem(index);
		}

		// Token: 0x060288C1 RID: 166081 RVA: 0x00B60194 File Offset: 0x00B5E394
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

		// Token: 0x060288C2 RID: 166082 RVA: 0x00B601BC File Offset: 0x00B5E3BC
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

		// Token: 0x060288C3 RID: 166083 RVA: 0x00B601F0 File Offset: 0x00B5E3F0
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

		// Token: 0x060288C4 RID: 166084 RVA: 0x00B60220 File Offset: 0x00B5E420
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

		// Token: 0x02009A2F RID: 39471
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04030109 RID: 196873
			public const int ItemDotLock1 = 0;

			// Token: 0x0403010A RID: 196874
			public const int ItemDotLock2 = 1;

			// Token: 0x0403010B RID: 196875
			public const int ItemDotLock3 = 2;

			// Token: 0x0403010C RID: 196876
			public const int ItemDotLock4 = 3;

			// Token: 0x0403010D RID: 196877
			public const int ItemDotLock5 = 4;

			// Token: 0x0403010E RID: 196878
			public const int ItemDotLock6 = 5;

			// Token: 0x0403010F RID: 196879
			public const int ItemDotUnlock1 = 6;

			// Token: 0x04030110 RID: 196880
			public const int ItemDotUnlock2 = 7;

			// Token: 0x04030111 RID: 196881
			public const int ItemDotUnlock3 = 8;

			// Token: 0x04030112 RID: 196882
			public const int ItemDotUnlock4 = 9;

			// Token: 0x04030113 RID: 196883
			public const int ItemDotUnlock5 = 10;

			// Token: 0x04030114 RID: 196884
			public const int ItemDotUnlock6 = 11;

			// Token: 0x04030115 RID: 196885
			public const int ItemDashedLine1 = 12;

			// Token: 0x04030116 RID: 196886
			public const int ItemDashedLine2 = 13;

			// Token: 0x04030117 RID: 196887
			public const int ItemDashedLine3 = 14;

			// Token: 0x04030118 RID: 196888
			public const int ItemDashedLine4 = 15;

			// Token: 0x04030119 RID: 196889
			public const int ItemDashedLine5 = 16;

			// Token: 0x0403011A RID: 196890
			public const int ItemSolidLine1 = 17;

			// Token: 0x0403011B RID: 196891
			public const int ItemSolidLine2 = 18;

			// Token: 0x0403011C RID: 196892
			public const int ItemSolidLine3 = 19;

			// Token: 0x0403011D RID: 196893
			public const int ItemSolidLine4 = 20;

			// Token: 0x0403011E RID: 196894
			public const int ItemSolidLine5 = 21;
		}
	}
}
