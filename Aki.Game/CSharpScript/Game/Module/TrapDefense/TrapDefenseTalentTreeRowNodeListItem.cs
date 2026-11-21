using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A7F RID: 14975
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeRowNodeListItem : UiPanelBase
	{
		// Token: 0x06026786 RID: 157574 RVA: 0x00AC7164 File Offset: 0x00AC5364
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

		// Token: 0x06026787 RID: 157575 RVA: 0x00AC7254 File Offset: 0x00AC5454
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseTalentTreeRowNodeListItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseTalentTreeRowNodeListItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026788 RID: 157576 RVA: 0x00AC7297 File Offset: 0x00AC5497
		public TrapDefenseTalentTreeNodeItem GetNodeItem(int index)
		{
			if (index < 0 || index >= this.NodeItemList.Count)
			{
				return null;
			}
			return this.NodeItemList[index];
		}

		// Token: 0x06026789 RID: 157577 RVA: 0x00AC72BC File Offset: 0x00AC54BC
		public List<UUIItem> GetAllLines()
		{
			List<UUIItem> list = new List<UUIItem>();
			foreach (TrapDefenseTalentTreeNodeItem trapDefenseTalentTreeNodeItem in this.NodeItemList)
			{
				foreach (UUIItem item in trapDefenseTalentTreeNodeItem.GetAllLines())
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0602678A RID: 157578 RVA: 0x00AC7330 File Offset: 0x00AC5530
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<UUIItem, UUIItem>? GetLinesByIndexInLineId(int index)
		{
			if (index < 6)
			{
				return new ValueTuple<UUIItem, UUIItem>?(this.NodeItemList[index].GetUpLines());
			}
			if (index >= 12 && index < 18)
			{
				return new ValueTuple<UUIItem, UUIItem>?(this.NodeItemList[index - 12].GetDownLines());
			}
			if (index >= 6 && index < 12)
			{
				return new ValueTuple<UUIItem, UUIItem>?(this.NodeItemList[index - 6].GetMidLines());
			}
			return null;
		}

		// Token: 0x0401516A RID: 86378
		private readonly List<TrapDefenseTalentTreeNodeItem> NodeItemList = new List<TrapDefenseTalentTreeNodeItem>();

		// Token: 0x02009672 RID: 38514
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EF96 RID: 192406
			public const int Node1 = 0;

			// Token: 0x0402EF97 RID: 192407
			public const int Node2 = 1;

			// Token: 0x0402EF98 RID: 192408
			public const int Node3 = 2;

			// Token: 0x0402EF99 RID: 192409
			public const int Node4 = 3;

			// Token: 0x0402EF9A RID: 192410
			public const int Node5 = 4;

			// Token: 0x0402EF9B RID: 192411
			public const int Node6 = 5;
		}
	}
}
