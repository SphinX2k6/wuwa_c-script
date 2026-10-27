using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02004F93 RID: 20371
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackSkillPanel
	{
		// Token: 0x060342B0 RID: 213680 RVA: 0x00C3F6A4 File Offset: 0x00C3D8A4
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

		// Token: 0x060342B1 RID: 213681 RVA: 0x00C3F6EF File Offset: 0x00C3D8EF
		[NullableContext(2)]
		public QuickHackSkillItem GetItem(int index)
		{
			if (index >= this.SkillItemList.Count)
			{
				return null;
			}
			return this.SkillItemList[index];
		}

		// Token: 0x060342B2 RID: 213682 RVA: 0x00C3F710 File Offset: 0x00C3D910
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

		// Token: 0x060342B3 RID: 213683 RVA: 0x00C3F778 File Offset: 0x00C3D978
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

		// Token: 0x0401BBB5 RID: 113589
		private readonly List<QuickHackSkillItem> SkillItemList = new List<QuickHackSkillItem>();

		// Token: 0x0401BBB6 RID: 113590
		[Nullable(2)]
		private QuickHackSkillItem CurrentItem;

		// Token: 0x0401BBB7 RID: 113591
		private int CurrentIndex = -1;
	}
}
