using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004880 RID: 18560
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonRightTitleItem : UiPanelBase
	{
		// Token: 0x0602EADF RID: 191199 RVA: 0x00D07620 File Offset: 0x00D05820
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

		// Token: 0x0602EAE0 RID: 191200 RVA: 0x00D076AA File Offset: 0x00D058AA
		public void RefreshItem(string name, string desc, List<int> element)
		{
			this.SetActive(true);
			base.GetText(0).ShowTextNew(name);
			base.GetText(1).ShowTextNew(desc);
			this.UpdateInstanceDungeonRecommendElementItem(element);
		}

		// Token: 0x0602EAE1 RID: 191201 RVA: 0x00D076D4 File Offset: 0x00D058D4
		public void RefreshName(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x0602EAE2 RID: 191202 RVA: 0x00D076E4 File Offset: 0x00D058E4
		public void RefreshDesc(string desc)
		{
			base.GetText(1).SetText(desc, true);
		}

		// Token: 0x0602EAE3 RID: 191203 RVA: 0x00D076F4 File Offset: 0x00D058F4
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

		// Token: 0x04018D13 RID: 101651
		[Nullable(2)]
		private InstanceDungeonRecommendElementItem InstanceDungeonRecommendElementItem;

		// Token: 0x0200A528 RID: 42280
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04033225 RID: 209445
			TextInstanceName,
			// Token: 0x04033226 RID: 209446
			TextInstanceDesc,
			// Token: 0x04033227 RID: 209447
			ElementItem
		}
	}
}
