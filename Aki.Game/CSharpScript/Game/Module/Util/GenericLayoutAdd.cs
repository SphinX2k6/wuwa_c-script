using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003839 RID: 14393
	[NullableContext(1)]
	[Nullable(0)]
	public class GenericLayoutAdd<[Nullable(0)] T> where T : UiPanelBase
	{
		// Token: 0x06025617 RID: 153111 RVA: 0x00A8930A File Offset: 0x00A8750A
		public GenericLayoutAdd(UUILayoutBase layout, TLayoutRefresh<T> refreshFunction)
		{
			this.ProxyLayout = layout;
			this.RefreshFunction = refreshFunction;
			this.SaveOriginal();
		}

		// Token: 0x06025618 RID: 153112 RVA: 0x00A89348 File Offset: 0x00A87548
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

		// Token: 0x06025619 RID: 153113 RVA: 0x00A8939B File Offset: 0x00A8759B
		private UUIItem GetRootUiItem()
		{
			return this.ProxyLayout.GetRootComponent();
		}

		// Token: 0x0602561A RID: 153114 RVA: 0x00A893A8 File Offset: 0x00A875A8
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

		// Token: 0x0602561B RID: 153115 RVA: 0x00A89474 File Offset: 0x00A87674
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

		// Token: 0x0602561C RID: 153116 RVA: 0x00A894A0 File Offset: 0x00A876A0
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

		// Token: 0x0602561D RID: 153117 RVA: 0x00A894C0 File Offset: 0x00A876C0
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

		// Token: 0x04014B0A RID: 84746
		[Nullable(2)]
		private readonly UUILayoutBase ProxyLayout;

		// Token: 0x04014B0B RID: 84747
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly TLayoutRefresh<T> RefreshFunction;

		// Token: 0x04014B0C RID: 84748
		private readonly Dictionary<int, UUIItem> OriginalItemMap = new Dictionary<int, UUIItem>();

		// Token: 0x04014B0D RID: 84749
		private readonly List<UUIItem> CopyListItem = new List<UUIItem>();

		// Token: 0x04014B0E RID: 84750
		private readonly Dictionary<int, Dictionary<object, UiPanelBase>> ItemMap = new Dictionary<int, Dictionary<object, UiPanelBase>>();
	}
}
