using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C2 RID: 18626
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericLayoutAdd<[Nullable(0)] T> where T : UiPanelBase
	{
		// Token: 0x06030AEB RID: 199403 RVA: 0x00B4E502 File Offset: 0x00B4C702
		public GenericLayoutAdd(UUILayoutBase layout, TLayoutRefresh<T> refreshFunction)
		{
			this.ProxyLayout = layout;
			this.RefreshFunction = refreshFunction;
			this.SaveOriginal();
		}

		// Token: 0x06030AEC RID: 199404 RVA: 0x00B4E540 File Offset: 0x00B4C740
		private void SaveOriginal()
		{
			if (this.ProxyLayout != null)
			{
				TArray<UUIItem> attachUIChildren = this.GetRootUiItem().GetAttachUIChildren();
				int i = 0;
				int num = attachUIChildren.Num();
				while (i < num)
				{
					UUIItem uuiitem = attachUIChildren.Get(i);
					if (uuiitem != null)
					{
						uuiitem.SetUIActive(false);
					}
					this.OriginalItemMap[i] = uuiitem;
					i++;
				}
			}
		}

		// Token: 0x06030AED RID: 199405 RVA: 0x00B4E593 File Offset: 0x00B4C793
		private UUIItem GetRootUiItem()
		{
			return this.ProxyLayout.GetRootComponent();
		}

		// Token: 0x06030AEE RID: 199406 RVA: 0x00B4E5A0 File Offset: 0x00B4C7A0
		public void AddItemToLayout(object[] dataList, int hierarchyIndex = 0)
		{
			UUIItem uuiitem;
			if (!this.OriginalItemMap.TryGetValue(hierarchyIndex, out uuiitem))
			{
				Log.Instance.Error(ELogModule.ModuleUtil, ELogAuthor.XXJ, "查找不到对应HierarchyIndex的UIItem", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			uuiitem.SetUIActive(true);
			Dictionary<object, UiPanelBase> dictionary;
			if (!this.ItemMap.TryGetValue(hierarchyIndex, out dictionary))
			{
				dictionary = new Dictionary<object, UiPanelBase>();
				this.ItemMap[hierarchyIndex] = dictionary;
			}
			int i = 0;
			int num = dataList.Length;
			while (i < num)
			{
				UUIItem uuiitem2 = LguiUtil.Instance.CopyItem(uuiitem, this.GetRootUiItem());
				ILayoutItem<T> layoutItem = this.RefreshFunction(dataList[i], uuiitem2, i, hierarchyIndex);
				dictionary[layoutItem.Key] = layoutItem.Value;
				this.CopyListItem.Add(uuiitem2);
				i++;
			}
			uuiitem.SetUIActive(false);
		}

		// Token: 0x06030AEF RID: 199407 RVA: 0x00B4E66C File Offset: 0x00B4C86C
		[return: Nullable(2)]
		public UiPanelBase GetLayoutItemByKey(object key, int hierarchyIndex = 0)
		{
			Dictionary<object, UiPanelBase> dictionary;
			if (this.ItemMap.TryGetValue(hierarchyIndex, out dictionary))
			{
				UiPanelBase result;
				dictionary.TryGetValue(key, out result);
				return result;
			}
			return null;
		}

		// Token: 0x06030AF0 RID: 199408 RVA: 0x00B4E698 File Offset: 0x00B4C898
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<object, UiPanelBase> GetLayoutItemMap(int hierarchyIndex = 0)
		{
			Dictionary<object, UiPanelBase> result;
			this.ItemMap.TryGetValue(hierarchyIndex, out result);
			return result;
		}

		// Token: 0x06030AF1 RID: 199409 RVA: 0x00B4E6B8 File Offset: 0x00B4C8B8
		public void ClearChildren()
		{
			foreach (Dictionary<object, UiPanelBase> dictionary in this.ItemMap.Values)
			{
				foreach (UiPanelBase uiPanelBase in dictionary.Values)
				{
					uiPanelBase.Destroy(null);
				}
				dictionary.Clear();
			}
			this.ItemMap.Clear();
			foreach (UUIItem uuiitem in this.CopyListItem)
			{
				ActorSystem.Instance.Put("GenericLayoutAdd.ClearChildren", uuiitem.GetOwner(), null);
			}
			this.CopyListItem.Clear();
		}

		// Token: 0x0401A297 RID: 107159
		[Nullable(2)]
		private readonly UUILayoutBase ProxyLayout;

		// Token: 0x0401A298 RID: 107160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly TLayoutRefresh<T> RefreshFunction;

		// Token: 0x0401A299 RID: 107161
		private readonly Dictionary<int, UUIItem> OriginalItemMap = new Dictionary<int, UUIItem>();

		// Token: 0x0401A29A RID: 107162
		private readonly List<UUIItem> CopyListItem = new List<UUIItem>();

		// Token: 0x0401A29B RID: 107163
		private readonly Dictionary<int, Dictionary<object, UiPanelBase>> ItemMap = new Dictionary<int, Dictionary<object, UiPanelBase>>();
	}
}
