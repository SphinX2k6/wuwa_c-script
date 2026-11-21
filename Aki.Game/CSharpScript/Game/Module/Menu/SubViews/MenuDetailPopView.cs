using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200440A RID: 17418
	[NullableContext(2)]
	[Nullable(0)]
	public class MenuDetailPopView : UiViewBase
	{
		// Token: 0x0602BFE2 RID: 180194 RVA: 0x00C5A175 File Offset: 0x00C58375
		[NullableContext(1)]
		public MenuDetailPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BFE3 RID: 180195 RVA: 0x00C5A18C File Offset: 0x00C5838C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUIText))
			};
		}

		// Token: 0x0602BFE4 RID: 180196 RVA: 0x00C5A284 File Offset: 0x00C58484
		protected override UniTask OnBeforeStartAsync()
		{
			MenuDetailPopView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuDetailPopView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BFE5 RID: 180197 RVA: 0x00C5A2C7 File Offset: 0x00C584C7
		protected override void OnStart()
		{
			this.Refresh(this.Data);
		}

		// Token: 0x0602BFE6 RID: 180198 RVA: 0x00C5A2D8 File Offset: 0x00C584D8
		[NullableContext(1)]
		private UniTask CreateItems(MenuDetailPopData viewData)
		{
			MenuDetailPopView.<CreateItems>d__9 <CreateItems>d__;
			<CreateItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItems>d__.<>4__this = this;
			<CreateItems>d__.viewData = viewData;
			<CreateItems>d__.<>1__state = -1;
			<CreateItems>d__.<>t__builder.Start<MenuDetailPopView.<CreateItems>d__9>(ref <CreateItems>d__);
			return <CreateItems>d__.<>t__builder.Task;
		}

		// Token: 0x0602BFE7 RID: 180199 RVA: 0x00C5A324 File Offset: 0x00C58524
		[NullableContext(1)]
		private void Refresh(MenuDetailPopData viewData)
		{
			bool isMulti = viewData.IsMulti;
			bool flag = viewData.ItemList.Count > 0 && viewData.ItemList[0].ShowType == EMenuDetailItemShowType.WideVideo;
			base.GetItem(1).SetUIActive(isMulti);
			base.GetItem(3).SetUIActive(!isMulti && !flag);
			base.GetItem(7).SetUIActive(!isMulti && flag);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), viewData.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), viewData.Description, Array.Empty<object>());
			if (isMulti)
			{
				for (int i = 0; i < viewData.ItemList.Count; i++)
				{
					if (i < this.ItemList.Count)
					{
						MenuDetailPopViewItemPanel menuDetailPopViewItemPanel = this.ItemList[i];
						if (menuDetailPopViewItemPanel != null)
						{
							menuDetailPopViewItemPanel.RefreshByData(viewData.ItemList[i]);
						}
					}
				}
				base.GetItem(1).SetUIActive(true);
				return;
			}
			if (flag)
			{
				MenuDetailPopViewItemView singleWideVideoView = this.SingleWideVideoView;
				if (singleWideVideoView != null)
				{
					singleWideVideoView.RefreshByData(viewData.ItemList[0]);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), viewData.ItemList[0].Title, Array.Empty<object>());
				return;
			}
			MenuDetailPopViewItemView singleGridView = this.SingleGridView;
			if (singleGridView == null)
			{
				return;
			}
			singleGridView.RefreshByData(viewData.ItemList[0]);
		}

		// Token: 0x0602BFE8 RID: 180200 RVA: 0x00C5A488 File Offset: 0x00C58688
		private void Close()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602BFE9 RID: 180201 RVA: 0x00C5A494 File Offset: 0x00C58694
		private MenuDetailPopData LoadDataFromConfig(int popViewId)
		{
			MenuDetailPop? menuDetailPopConfigById = MenuBaseConfig.Instance.GetMenuDetailPopConfigById(popViewId);
			if (menuDetailPopConfigById == null)
			{
				return null;
			}
			MenuDetailPopData menuDetailPopData = new MenuDetailPopData();
			menuDetailPopData.Title = menuDetailPopConfigById.Value.Title;
			menuDetailPopData.Description = menuDetailPopConfigById.Value.Description;
			menuDetailPopData.ItemList = new List<MenuDetailPopItemData>();
			for (int i = 0; i < menuDetailPopConfigById.Value.ItemListLength; i++)
			{
				int configId = menuDetailPopConfigById.Value.ItemList(i);
				MenuDetailPopItemData menuDetailPopItemData = new MenuDetailPopItemData();
				MenuDetailPopItem? menuDetailPopItemConfigById = MenuBaseConfig.Instance.GetMenuDetailPopItemConfigById(configId);
				if (menuDetailPopItemConfigById == null)
				{
					menuDetailPopData.ItemList.Add(menuDetailPopItemData);
				}
				else
				{
					menuDetailPopItemData.Title = menuDetailPopItemConfigById.Value.Title;
					menuDetailPopItemData.ShowType = (EMenuDetailItemShowType)menuDetailPopItemConfigById.Value.ShowType;
					menuDetailPopItemData.ResourcePath = menuDetailPopItemConfigById.Value.ResourcePath;
					menuDetailPopData.ItemList.Add(menuDetailPopItemData);
				}
			}
			menuDetailPopData.IsMulti = (menuDetailPopData.ItemList.Count > 1);
			return menuDetailPopData;
		}

		// Token: 0x0602BFEA RID: 180202 RVA: 0x00C5A5B9 File Offset: 0x00C587B9
		protected override void OnBeforeDestroy()
		{
			MenuDetailPopViewItemView singleGridView = this.SingleGridView;
			if (singleGridView != null)
			{
				singleGridView.Clear();
			}
			this.SingleGridView = null;
			MenuDetailPopViewItemView singleWideVideoView = this.SingleWideVideoView;
			if (singleWideVideoView != null)
			{
				singleWideVideoView.Clear();
			}
			this.SingleWideVideoView = null;
		}

		// Token: 0x04017B48 RID: 97096
		private PopupCaptionItem Caption;

		// Token: 0x04017B49 RID: 97097
		private MenuDetailPopData Data;

		// Token: 0x04017B4A RID: 97098
		private MenuDetailPopViewItemView SingleGridView;

		// Token: 0x04017B4B RID: 97099
		private MenuDetailPopViewItemView SingleWideVideoView;

		// Token: 0x04017B4C RID: 97100
		[Nullable(1)]
		private readonly List<MenuDetailPopViewItemPanel> ItemList = new List<MenuDetailPopViewItemPanel>();
	}
}
