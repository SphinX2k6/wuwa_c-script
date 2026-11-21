using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02003F5C RID: 16220
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSkillPanel
	{
		// Token: 0x0602911E RID: 168222 RVA: 0x00B88E50 File Offset: 0x00B87050
		public UniTask InitSkillItemsAsync(List<UUIItem> items)
		{
			QuickHackSkillPanel.<InitSkillItemsAsync>d__3 <InitSkillItemsAsync>d__;
			<InitSkillItemsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillItemsAsync>d__.<>4__this = this;
			<InitSkillItemsAsync>d__.items = items;
			<InitSkillItemsAsync>d__.<>1__state = -1;
			<InitSkillItemsAsync>d__.<>t__builder.Start<QuickHackSkillPanel.<InitSkillItemsAsync>d__3>(ref <InitSkillItemsAsync>d__);
			return <InitSkillItemsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602911F RID: 168223 RVA: 0x00B88E9B File Offset: 0x00B8709B
		[NullableContext(2)]
		public QuickHackSkillItem GetItem(int index)
		{
			if (index >= this.SkillItemList.Count)
			{
				return null;
			}
			return this.SkillItemList[index];
		}

		// Token: 0x06029120 RID: 168224 RVA: 0x00B88EBC File Offset: 0x00B870BC
		public void RefreshByData(List<QuickHackSkillInstance> dataList)
		{
			int count = this.SkillItemList.Count;
			int count2 = dataList.Count;
			for (int i = 0; i < count; i++)
			{
				QuickHackSkillItem quickHackSkillItem = this.SkillItemList[i];
				if (i >= count2)
				{
					quickHackSkillItem.SetActive(false);
				}
				else
				{
					QuickHackSkillInstance data = dataList[i];
					quickHackSkillItem.Refresh(data, i == this.CurrentIndex, i);
					quickHackSkillItem.SetActive(true);
				}
			}
		}

		// Token: 0x06029121 RID: 168225 RVA: 0x00B88F24 File Offset: 0x00B87124
		public void Select(int index)
		{
			if (index == this.CurrentIndex)
			{
				return;
			}
			if (index >= this.SkillItemList.Count)
			{
				return;
			}
			QuickHackSkillItem currentItem = this.CurrentItem;
			if (currentItem != null)
			{
				currentItem.OnDeselected();
			}
			this.CurrentIndex = index;
			QuickHackSkillItem quickHackSkillItem = this.SkillItemList[index];
			this.CurrentItem = quickHackSkillItem;
			quickHackSkillItem.OnSelected();
		}

		// Token: 0x0401658A RID: 91530
		private readonly List<QuickHackSkillItem> SkillItemList = new List<QuickHackSkillItem>();

		// Token: 0x0401658B RID: 91531
		[Nullable(2)]
		private QuickHackSkillItem CurrentItem;

		// Token: 0x0401658C RID: 91532
		private int CurrentIndex = -1;
	}
}
