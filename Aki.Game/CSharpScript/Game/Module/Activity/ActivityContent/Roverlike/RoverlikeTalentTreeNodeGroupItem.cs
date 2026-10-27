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
	// Token: 0x020061A5 RID: 24997
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeNodeGroupItem : UiPanelBase
	{
		// Token: 0x0603F219 RID: 258585 RVA: 0x00F40160 File Offset: 0x00F3E360
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

		// Token: 0x0603F21A RID: 258586 RVA: 0x00F40250 File Offset: 0x00F3E450
		private static string GetNodeResourceId([Nullable(2)] RoverlikeTalentNodeData node)
		{
			if (node != null && node.HeadConfig.Type == 2)
			{
				return "UiItem_RoverRougeTalentTreeSPNode";
			}
			return "UiItem_RoverRougeTalentTreeNorNode";
		}

		// Token: 0x0603F21B RID: 258587 RVA: 0x00F4027C File Offset: 0x00F3E47C
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

		// Token: 0x0603F21C RID: 258588 RVA: 0x00F402C8 File Offset: 0x00F3E4C8
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

		// Token: 0x0603F21D RID: 258589 RVA: 0x00F4031B File Offset: 0x00F3E51B
		[NullableContext(2)]
		public RoverlikeTalentTreeNodeItem GetNodeItem(int index)
		{
			if (index < 0 || index >= 6)
			{
				return null;
			}
			return this.ActiveItems[index];
		}

		// Token: 0x0603F21E RID: 258590 RVA: 0x00F40330 File Offset: 0x00F3E530
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

		// Token: 0x0603F21F RID: 258591 RVA: 0x00F40368 File Offset: 0x00F3E568
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			foreach (RoverlikeTalentTreeNodeItem roverlikeTalentTreeNodeItem in this.GetAllNodeItems())
			{
				list.AddRange(roverlikeTalentTreeNodeItem.GetAllLines());
			}
			return list;
		}

		// Token: 0x0603F220 RID: 258592 RVA: 0x00F403C8 File Offset: 0x00F3E5C8
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

		// Token: 0x0603F221 RID: 258593 RVA: 0x00F4042C File Offset: 0x00F3E62C
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

		// Token: 0x04020E9D RID: 134813
		private readonly Dictionary<int, Dictionary<string, RoverlikeTalentTreeNodeItem>> NodeItemMap = new Dictionary<int, Dictionary<string, RoverlikeTalentTreeNodeItem>>();

		// Token: 0x04020E9E RID: 134814
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly RoverlikeTalentTreeNodeItem[] ActiveItems = new RoverlikeTalentTreeNodeItem[6];

		// Token: 0x0200C3F1 RID: 50161
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403B221 RID: 242209
			public const int Node1 = 0;

			// Token: 0x0403B222 RID: 242210
			public const int Node2 = 1;

			// Token: 0x0403B223 RID: 242211
			public const int Node3 = 2;

			// Token: 0x0403B224 RID: 242212
			public const int Node4 = 3;

			// Token: 0x0403B225 RID: 242213
			public const int Node5 = 4;

			// Token: 0x0403B226 RID: 242214
			public const int Node6 = 5;
		}
	}
}
