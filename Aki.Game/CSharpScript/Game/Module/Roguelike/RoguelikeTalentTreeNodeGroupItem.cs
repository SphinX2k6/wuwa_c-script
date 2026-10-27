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
	// Token: 0x02004E42 RID: 20034
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeNodeGroupItem : UiPanelBase
	{
		// Token: 0x06033A5B RID: 211547 RVA: 0x00C16D44 File Offset: 0x00C14F44
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

		// Token: 0x06033A5C RID: 211548 RVA: 0x00C16E34 File Offset: 0x00C15034
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeTalentTreeNodeGroupItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeTalentTreeNodeGroupItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A5D RID: 211549 RVA: 0x00C16E77 File Offset: 0x00C15077
		[NullableContext(2)]
		public RoguelikeTalentTreeNodeItem GetNodeItem(int index)
		{
			if (index < 0 || index >= this.NodeItemList.Count)
			{
				return null;
			}
			return this.NodeItemList[index];
		}

		// Token: 0x06033A5E RID: 211550 RVA: 0x00C16E99 File Offset: 0x00C15099
		public List<RoguelikeTalentTreeNodeItem> GetAllNodeItems()
		{
			return this.NodeItemList;
		}

		// Token: 0x06033A5F RID: 211551 RVA: 0x00C16EA4 File Offset: 0x00C150A4
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			foreach (RoguelikeTalentTreeNodeItem roguelikeTalentTreeNodeItem in this.NodeItemList)
			{
				list.AddRange(roguelikeTalentTreeNodeItem.GetAllLines());
			}
			return list;
		}

		// Token: 0x06033A60 RID: 211552 RVA: 0x00C16F04 File Offset: 0x00C15104
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

		// Token: 0x0401B62D RID: 112173
		private readonly List<RoguelikeTalentTreeNodeItem> NodeItemList = new List<RoguelikeTalentTreeNodeItem>();

		// Token: 0x0200AFFE RID: 45054
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040356EF RID: 218863
			public const int Node1 = 0;

			// Token: 0x040356F0 RID: 218864
			public const int Node2 = 1;

			// Token: 0x040356F1 RID: 218865
			public const int Node3 = 2;

			// Token: 0x040356F2 RID: 218866
			public const int Node4 = 3;

			// Token: 0x040356F3 RID: 218867
			public const int Node5 = 4;

			// Token: 0x040356F4 RID: 218868
			public const int Node6 = 5;
		}
	}
}
