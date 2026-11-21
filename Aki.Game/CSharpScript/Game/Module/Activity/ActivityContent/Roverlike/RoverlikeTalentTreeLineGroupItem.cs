using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005122 RID: 20770
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeTalentTreeLineGroupItem : UiPanelBase
	{
		// Token: 0x06033ECF RID: 212687 RVA: 0x00E86B44 File Offset: 0x00E84D44
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

		// Token: 0x06033ED0 RID: 212688 RVA: 0x00E86E50 File Offset: 0x00E85050
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

		// Token: 0x06033ED1 RID: 212689 RVA: 0x00E86EF4 File Offset: 0x00E850F4
		public UUIItem GetLockDotByIndex(int nodeIndex)
		{
			if (nodeIndex < 0 || nodeIndex >= 6)
			{
				return null;
			}
			return base.GetItem(nodeIndex);
		}

		// Token: 0x06033ED2 RID: 212690 RVA: 0x00E86F07 File Offset: 0x00E85107
		public UUIItem GetUnlockDotByIndex(int nodeIndex)
		{
			if (nodeIndex < 0 || nodeIndex >= 6)
			{
				return null;
			}
			return base.GetItem(6 + nodeIndex);
		}

		// Token: 0x06033ED3 RID: 212691 RVA: 0x00E86F1C File Offset: 0x00E8511C
		public UUIItem GetSolidLineByIndexInLineId(int index)
		{
			int num = index - 18;
			if (num < 0 || num >= 5)
			{
				return null;
			}
			return base.GetItem(17 + num);
		}

		// Token: 0x06033ED4 RID: 212692 RVA: 0x00E86F44 File Offset: 0x00E85144
		public UUIItem GetDashedLineByIndexInLineId(int index)
		{
			int num = index - 18;
			if (num < 0 || num >= 5)
			{
				return null;
			}
			return base.GetItem(12 + num);
		}

		// Token: 0x06033ED5 RID: 212693 RVA: 0x00E86F6C File Offset: 0x00E8516C
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

		// Token: 0x06033ED6 RID: 212694 RVA: 0x00E86FAC File Offset: 0x00E851AC
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

		// Token: 0x06033ED7 RID: 212695 RVA: 0x00E86FE8 File Offset: 0x00E851E8
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

		// Token: 0x0200ADD7 RID: 44503
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04035B6C RID: 220012
			public const int ItemDotLock1 = 0;

			// Token: 0x04035B6D RID: 220013
			public const int ItemDotLock2 = 1;

			// Token: 0x04035B6E RID: 220014
			public const int ItemDotLock3 = 2;

			// Token: 0x04035B6F RID: 220015
			public const int ItemDotLock4 = 3;

			// Token: 0x04035B70 RID: 220016
			public const int ItemDotLock5 = 4;

			// Token: 0x04035B71 RID: 220017
			public const int ItemDotLock6 = 5;

			// Token: 0x04035B72 RID: 220018
			public const int ItemDotUnlock1 = 6;

			// Token: 0x04035B73 RID: 220019
			public const int ItemDotUnlock2 = 7;

			// Token: 0x04035B74 RID: 220020
			public const int ItemDotUnlock3 = 8;

			// Token: 0x04035B75 RID: 220021
			public const int ItemDotUnlock4 = 9;

			// Token: 0x04035B76 RID: 220022
			public const int ItemDotUnlock5 = 10;

			// Token: 0x04035B77 RID: 220023
			public const int ItemDotUnlock6 = 11;

			// Token: 0x04035B78 RID: 220024
			public const int ItemDashedLine1 = 12;

			// Token: 0x04035B79 RID: 220025
			public const int ItemDashedLine2 = 13;

			// Token: 0x04035B7A RID: 220026
			public const int ItemDashedLine3 = 14;

			// Token: 0x04035B7B RID: 220027
			public const int ItemDashedLine4 = 15;

			// Token: 0x04035B7C RID: 220028
			public const int ItemDashedLine5 = 16;

			// Token: 0x04035B7D RID: 220029
			public const int ItemSolidLine1 = 17;

			// Token: 0x04035B7E RID: 220030
			public const int ItemSolidLine2 = 18;

			// Token: 0x04035B7F RID: 220031
			public const int ItemSolidLine3 = 19;

			// Token: 0x04035B80 RID: 220032
			public const int ItemSolidLine4 = 20;

			// Token: 0x04035B81 RID: 220033
			public const int ItemSolidLine5 = 21;
		}
	}
}
