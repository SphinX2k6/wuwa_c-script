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
	// Token: 0x02004AD7 RID: 19159
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeRowNodeListItem : UiPanelBase
	{
		// Token: 0x060319F6 RID: 203254 RVA: 0x00B831B0 File Offset: 0x00B813B0
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

		// Token: 0x060319F7 RID: 203255 RVA: 0x00B832A0 File Offset: 0x00B814A0
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseTalentTreeRowNodeListItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseTalentTreeRowNodeListItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319F8 RID: 203256 RVA: 0x00B832E3 File Offset: 0x00B814E3
		public TrapDefenseTalentTreeNodeItem GetNodeItem(int index)
		{
			if (index < 0 || index >= this.NodeItemList.Count)
			{
				return null;
			}
			return this.NodeItemList[index];
		}

		// Token: 0x060319F9 RID: 203257 RVA: 0x00B83308 File Offset: 0x00B81508
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

		// Token: 0x060319FA RID: 203258 RVA: 0x00B8337C File Offset: 0x00B8157C
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

		// Token: 0x0401A818 RID: 108568
		private readonly List<TrapDefenseTalentTreeNodeItem> NodeItemList = new List<TrapDefenseTalentTreeNodeItem>();

		// Token: 0x0200AC52 RID: 44114
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040345E5 RID: 214501
			public const int Node1 = 0;

			// Token: 0x040345E6 RID: 214502
			public const int Node2 = 1;

			// Token: 0x040345E7 RID: 214503
			public const int Node3 = 2;

			// Token: 0x040345E8 RID: 214504
			public const int Node4 = 3;

			// Token: 0x040345E9 RID: 214505
			public const int Node5 = 4;

			// Token: 0x040345EA RID: 214506
			public const int Node6 = 5;
		}
	}
}
