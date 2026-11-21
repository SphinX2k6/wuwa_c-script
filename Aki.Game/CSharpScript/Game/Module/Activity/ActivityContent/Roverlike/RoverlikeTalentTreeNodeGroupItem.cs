using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005123 RID: 20771
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeNodeGroupItem : UiPanelBase
	{
		// Token: 0x06033ED9 RID: 212697 RVA: 0x00E87028 File Offset: 0x00E85228
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

		// Token: 0x06033EDA RID: 212698 RVA: 0x00E87118 File Offset: 0x00E85318
		private static string GetNodeResourceId([Nullable(2)] RoverlikeTalentNodeData node)
		{
			if (node != null && node.HeadConfig.Type == 2)
			{
				return "UiItem_RoverRougeTalentTreeSPNode";
			}
			return "UiItem_RoverRougeTalentTreeNorNode";
		}

		// Token: 0x06033EDB RID: 212699 RVA: 0x00E87144 File Offset: 0x00E85344
		public UniTask EnsureNodeItemsAsync(IReadOnlyList<RoverlikeTalentNodeData> nodes)
		{
			RoverlikeTalentTreeNodeGroupItem.<EnsureNodeItemsAsync>d__5 <EnsureNodeItemsAsync>d__;
			<EnsureNodeItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureNodeItemsAsync>d__.<>4__this = this;
			<EnsureNodeItemsAsync>d__.nodes = nodes;
			<EnsureNodeItemsAsync>d__.<>1__state = -1;
			<EnsureNodeItemsAsync>d__.<>t__builder.Start<RoverlikeTalentTreeNodeGroupItem.<EnsureNodeItemsAsync>d__5>(ref <EnsureNodeItemsAsync>d__);
			return <EnsureNodeItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033EDC RID: 212700 RVA: 0x00E87190 File Offset: 0x00E85390
		private UniTask EnsureSlotItemAsync(int slotIndex, string resourceId)
		{
			RoverlikeTalentTreeNodeGroupItem.<EnsureSlotItemAsync>d__6 <EnsureSlotItemAsync>d__;
			<EnsureSlotItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureSlotItemAsync>d__.<>4__this = this;
			<EnsureSlotItemAsync>d__.slotIndex = slotIndex;
			<EnsureSlotItemAsync>d__.resourceId = resourceId;
			<EnsureSlotItemAsync>d__.<>1__state = -1;
			<EnsureSlotItemAsync>d__.<>t__builder.Start<RoverlikeTalentTreeNodeGroupItem.<EnsureSlotItemAsync>d__6>(ref <EnsureSlotItemAsync>d__);
			return <EnsureSlotItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033EDD RID: 212701 RVA: 0x00E871E3 File Offset: 0x00E853E3
		[NullableContext(2)]
		public RoverlikeTalentTreeNodeItem GetNodeItem(int index)
		{
			if (index < 0 || index >= 6)
			{
				return null;
			}
			return this.ActiveItems[index];
		}

		// Token: 0x06033EDE RID: 212702 RVA: 0x00E871F8 File Offset: 0x00E853F8
		public List<RoverlikeTalentTreeNodeItem> GetAllNodeItems()
		{
			List<RoverlikeTalentTreeNodeItem> list = new List<RoverlikeTalentTreeNodeItem>();
			foreach (RoverlikeTalentTreeNodeItem roverlikeTalentTreeNodeItem in this.ActiveItems)
			{
				if (roverlikeTalentTreeNodeItem != null)
				{
					list.Add(roverlikeTalentTreeNodeItem);
				}
			}
			return list;
		}

		// Token: 0x06033EDF RID: 212703 RVA: 0x00E87230 File Offset: 0x00E85430
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			foreach (RoverlikeTalentTreeNodeItem roverlikeTalentTreeNodeItem in this.GetAllNodeItems())
			{
				list.AddRange(roverlikeTalentTreeNodeItem.GetAllLines());
			}
			return list;
		}

		// Token: 0x06033EE0 RID: 212704 RVA: 0x00E87290 File Offset: 0x00E85490
		[NullableContext(2)]
		public UUIItem GetSolidLineByIndexInLineId(int index)
		{
			if (index < 6)
			{
				RoverlikeTalentTreeNodeItem nodeItem = this.GetNodeItem(index);
				if (nodeItem == null)
				{
					return null;
				}
				return nodeItem.GetUpSolidLine();
			}
			else if (index >= 12 && index < 18)
			{
				RoverlikeTalentTreeNodeItem nodeItem2 = this.GetNodeItem(index - 12);
				if (nodeItem2 == null)
				{
					return null;
				}
				return nodeItem2.GetDownSolidLine();
			}
			else
			{
				if (index < 6 || index >= 12)
				{
					return null;
				}
				RoverlikeTalentTreeNodeItem nodeItem3 = this.GetNodeItem(index - 6);
				if (nodeItem3 == null)
				{
					return null;
				}
				return nodeItem3.GetMidSolidLine();
			}
		}

		// Token: 0x06033EE1 RID: 212705 RVA: 0x00E872F4 File Offset: 0x00E854F4
		[NullableContext(2)]
		public UUIItem GetDashedLineByIndexInLineId(int index)
		{
			if (index < 6)
			{
				RoverlikeTalentTreeNodeItem nodeItem = this.GetNodeItem(index);
				if (nodeItem == null)
				{
					return null;
				}
				return nodeItem.GetUpDashedLine();
			}
			else if (index >= 12 && index < 18)
			{
				RoverlikeTalentTreeNodeItem nodeItem2 = this.GetNodeItem(index - 12);
				if (nodeItem2 == null)
				{
					return null;
				}
				return nodeItem2.GetDownDashedLine();
			}
			else
			{
				if (index < 6 || index >= 12)
				{
					return null;
				}
				RoverlikeTalentTreeNodeItem nodeItem3 = this.GetNodeItem(index - 6);
				if (nodeItem3 == null)
				{
					return null;
				}
				return nodeItem3.GetMidDashedLine();
			}
		}

		// Token: 0x0401B7CA RID: 112586
		private readonly Dictionary<int, Dictionary<string, RoverlikeTalentTreeNodeItem>> NodeItemMap = new Dictionary<int, Dictionary<string, RoverlikeTalentTreeNodeItem>>();

		// Token: 0x0401B7CB RID: 112587
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly RoverlikeTalentTreeNodeItem[] ActiveItems = new RoverlikeTalentTreeNodeItem[6];

		// Token: 0x0200ADD8 RID: 44504
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04035B82 RID: 220034
			public const int Node1 = 0;

			// Token: 0x04035B83 RID: 220035
			public const int Node2 = 1;

			// Token: 0x04035B84 RID: 220036
			public const int Node3 = 2;

			// Token: 0x04035B85 RID: 220037
			public const int Node4 = 3;

			// Token: 0x04035B86 RID: 220038
			public const int Node5 = 4;

			// Token: 0x04035B87 RID: 220039
			public const int Node6 = 5;
		}
	}
}
