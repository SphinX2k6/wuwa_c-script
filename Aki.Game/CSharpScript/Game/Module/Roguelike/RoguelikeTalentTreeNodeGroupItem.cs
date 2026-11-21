using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E0B RID: 15883
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeNodeGroupItem : UiPanelBase
	{
		// Token: 0x060288C6 RID: 166086 RVA: 0x00B6026C File Offset: 0x00B5E46C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060288C7 RID: 166087 RVA: 0x00B6035C File Offset: 0x00B5E55C
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeTalentTreeNodeGroupItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeTalentTreeNodeGroupItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060288C8 RID: 166088 RVA: 0x00B6039F File Offset: 0x00B5E59F
		[NullableContext(2)]
		public RoguelikeTalentTreeNodeItem GetNodeItem(int index)
		{
			if (index < 0 || index >= this.NodeItemList.Count)
			{
				return null;
			}
			return this.NodeItemList[index];
		}

		// Token: 0x060288C9 RID: 166089 RVA: 0x00B603C1 File Offset: 0x00B5E5C1
		public List<RoguelikeTalentTreeNodeItem> GetAllNodeItems()
		{
			return this.NodeItemList;
		}

		// Token: 0x060288CA RID: 166090 RVA: 0x00B603CC File Offset: 0x00B5E5CC
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			foreach (RoguelikeTalentTreeNodeItem roguelikeTalentTreeNodeItem in this.NodeItemList)
			{
				list.AddRange(roguelikeTalentTreeNodeItem.GetAllLines());
			}
			return list;
		}

		// Token: 0x060288CB RID: 166091 RVA: 0x00B6042C File Offset: 0x00B5E62C
		[NullableContext(2)]
		public UUIItem GetLineByIndexInLineId(int index)
		{
			if (index < 6)
			{
				return this.NodeItemList[index].GetUpLine();
			}
			if (index >= 12 && index < 18)
			{
				return this.NodeItemList[index - 12].GetDownLine();
			}
			if (index >= 6 && index < 12)
			{
				return this.NodeItemList[index - 6].GetMidLine();
			}
			return null;
		}

		// Token: 0x04016000 RID: 90112
		private readonly List<RoguelikeTalentTreeNodeItem> NodeItemList = new List<RoguelikeTalentTreeNodeItem>();

		// Token: 0x02009A30 RID: 39472
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403011F RID: 196895
			public const int Node1 = 0;

			// Token: 0x04030120 RID: 196896
			public const int Node2 = 1;

			// Token: 0x04030121 RID: 196897
			public const int Node3 = 2;

			// Token: 0x04030122 RID: 196898
			public const int Node4 = 3;

			// Token: 0x04030123 RID: 196899
			public const int Node5 = 4;

			// Token: 0x04030124 RID: 196900
			public const int Node6 = 5;
		}
	}
}
