using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A8 RID: 22696
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonRightTitleItem : UiPanelBase
	{
		// Token: 0x06039BBC RID: 236476 RVA: 0x00DB8708 File Offset: 0x00DB6908
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039BBD RID: 236477 RVA: 0x00DB8792 File Offset: 0x00DB6992
		public void RefreshItem(string name, string desc, List<int> element)
		{
			this.SetActive(true);
			base.GetText(0).ShowTextNew(name);
			base.GetText(1).ShowTextNew(desc);
			this.UpdateInstanceDungeonRecommendElementItem(element);
		}

		// Token: 0x06039BBE RID: 236478 RVA: 0x00DB87BC File Offset: 0x00DB69BC
		public void RefreshName(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x06039BBF RID: 236479 RVA: 0x00DB87CC File Offset: 0x00DB69CC
		public void RefreshDesc(string desc)
		{
			base.GetText(1).SetText(desc, true);
		}

		// Token: 0x06039BC0 RID: 236480 RVA: 0x00DB87DC File Offset: 0x00DB69DC
		[NullableContext(2)]
		public void UpdateInstanceDungeonRecommendElementItem(List<int> element)
		{
			if (element == null || element.Count <= 0)
			{
				InstanceDungeonRecommendElementItem instanceDungeonRecommendElementItem = this.InstanceDungeonRecommendElementItem;
				if (instanceDungeonRecommendElementItem == null)
				{
					return;
				}
				instanceDungeonRecommendElementItem.SetActive(false);
				return;
			}
			else
			{
				if (this.InstanceDungeonRecommendElementItem == null)
				{
					this.InstanceDungeonRecommendElementItem = new InstanceDungeonRecommendElementItem();
					this.InstanceDungeonRecommendElementItem.CreateThenShowByResourceIdAsync("UiItem_InstanceDungeon_RecommendElement", base.GetItem(2), false).ContinueWith(delegate()
					{
						InstanceDungeonRecommendElementItem instanceDungeonRecommendElementItem4 = this.InstanceDungeonRecommendElementItem;
						if (instanceDungeonRecommendElementItem4 == null)
						{
							return;
						}
						instanceDungeonRecommendElementItem4.RefreshItem(element);
					});
					return;
				}
				InstanceDungeonRecommendElementItem instanceDungeonRecommendElementItem2 = this.InstanceDungeonRecommendElementItem;
				if (instanceDungeonRecommendElementItem2 != null)
				{
					instanceDungeonRecommendElementItem2.SetActive(true);
				}
				InstanceDungeonRecommendElementItem instanceDungeonRecommendElementItem3 = this.InstanceDungeonRecommendElementItem;
				if (instanceDungeonRecommendElementItem3 == null)
				{
					return;
				}
				instanceDungeonRecommendElementItem3.RefreshItem(element);
				return;
			}
		}

		// Token: 0x0401E276 RID: 123510
		[Nullable(2)]
		private InstanceDungeonRecommendElementItem InstanceDungeonRecommendElementItem;

		// Token: 0x0200BB0F RID: 47887
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04038824 RID: 231460
			TextInstanceName,
			// Token: 0x04038825 RID: 231461
			TextInstanceDesc,
			// Token: 0x04038826 RID: 231462
			ElementItem
		}
	}
}
