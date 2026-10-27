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
	// Token: 0x02005427 RID: 21543
	[NullableContext(2)]
	[Nullable(0)]
	public class MenuDetailPopView : UiViewBase
	{
		// Token: 0x06037099 RID: 225433 RVA: 0x00D0AD55 File Offset: 0x00D08F55
		[NullableContext(1)]
		public MenuDetailPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603709A RID: 225434 RVA: 0x00D0AD6C File Offset: 0x00D08F6C
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

		// Token: 0x0603709B RID: 225435 RVA: 0x00D0AE64 File Offset: 0x00D09064
		protected override UniTask OnBeforeStartAsync()
		{
			MenuDetailPopView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MenuDetailPopView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603709C RID: 225436 RVA: 0x00D0AEA7 File Offset: 0x00D090A7
		protected override void OnStart()
		{
			this.Refresh(this.Data);
		}

		// Token: 0x0603709D RID: 225437 RVA: 0x00D0AEB8 File Offset: 0x00D090B8
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

		// Token: 0x0603709E RID: 225438 RVA: 0x00D0AF04 File Offset: 0x00D09104
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

		// Token: 0x0603709F RID: 225439 RVA: 0x00D0B068 File Offset: 0x00D09268
		private void Close()
		{
			base.CloseMe(null);
		}

		// Token: 0x060370A0 RID: 225440 RVA: 0x00D0B074 File Offset: 0x00D09274
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

		// Token: 0x060370A1 RID: 225441 RVA: 0x00D0B199 File Offset: 0x00D09399
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

		// Token: 0x0401D0AF RID: 118959
		private PopupCaptionItem Caption;

		// Token: 0x0401D0B0 RID: 118960
		private MenuDetailPopData Data;

		// Token: 0x0401D0B1 RID: 118961
		private MenuDetailPopViewItemView SingleGridView;

		// Token: 0x0401D0B2 RID: 118962
		private MenuDetailPopViewItemView SingleWideVideoView;

		// Token: 0x0401D0B3 RID: 118963
		[Nullable(1)]
		private readonly List<MenuDetailPopViewItemPanel> ItemList = new List<MenuDetailPopViewItemPanel>();
	}
}
