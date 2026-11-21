using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200618E RID: 24974
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTouchUiEditContainer : ITouchUiEditContainer
	{
		// Token: 0x0603BE8B RID: 245387 RVA: 0x01105C2C File Offset: 0x01103E2C
		public UniTask LoadPanel(UUIItem parent, string[] resIdList, CommonTouchUiEditGroup groupConfig)
		{
			CommonTouchUiEditContainer.<LoadPanel>d__2 <LoadPanel>d__;
			<LoadPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadPanel>d__.<>4__this = this;
			<LoadPanel>d__.parent = parent;
			<LoadPanel>d__.resIdList = resIdList;
			<LoadPanel>d__.groupConfig = groupConfig;
			<LoadPanel>d__.<>1__state = -1;
			<LoadPanel>d__.<>t__builder.Start<CommonTouchUiEditContainer.<LoadPanel>d__2>(ref <LoadPanel>d__);
			return <LoadPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603BE8C RID: 245388 RVA: 0x01105C88 File Offset: 0x01103E88
		[return: Nullable(2)]
		public UUIItem GetItem(string resId, int index, int subPanelIndex)
		{
			UiPanelBase uiPanelBase;
			if (!this.PanelMap.TryGetValue(resId, out uiPanelBase))
			{
				return null;
			}
			AActor aactor = uiPanelBase.GetRootActor();
			ULGUIComponentsRegistry ulguicomponentsRegistry = this.GetLguiComponentsRegistry(uiPanelBase);
			if (ulguicomponentsRegistry == null)
			{
				return null;
			}
			if (subPanelIndex > -1)
			{
				AActor aactor2 = ulguicomponentsRegistry.Components.Get(subPanelIndex);
				if (aactor2 == null)
				{
					return null;
				}
				ULGUIComponentsRegistry ulguicomponentsRegistry2 = aactor2.GetComponentByClass(ULGUIComponentsRegistry.StaticClass()) as ULGUIComponentsRegistry;
				if (ulguicomponentsRegistry2 == null)
				{
					return null;
				}
				ulguicomponentsRegistry = ulguicomponentsRegistry2;
				aactor = aactor2;
			}
			if (index == -1)
			{
				return ((aactor != null) ? aactor.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
			}
			AActor aactor3 = ulguicomponentsRegistry.Components.Get(index);
			if (aactor3 == null)
			{
				return null;
			}
			return aactor3.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
		}

		// Token: 0x0603BE8D RID: 245389 RVA: 0x01105D40 File Offset: 0x01103F40
		public UUIItem[] GetRegistryItemList(string resId)
		{
			UiPanelBase panel;
			if (!this.PanelMap.TryGetValue(resId, out panel))
			{
				return new UUIItem[0];
			}
			ULGUIComponentsRegistry lguiComponentsRegistry = this.GetLguiComponentsRegistry(panel);
			if (lguiComponentsRegistry == null)
			{
				return new UUIItem[0];
			}
			List<UUIItem> list = new List<UUIItem>();
			for (int i = 0; i < lguiComponentsRegistry.Components.Num(); i++)
			{
				AActor aactor = lguiComponentsRegistry.Components.Get(i);
				if (aactor != null)
				{
					UUIItem uuiitem = aactor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
					if (uuiitem != null)
					{
						list.Add(uuiitem);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x0603BE8E RID: 245390 RVA: 0x01105DCE File Offset: 0x01103FCE
		public UUIItem GetRootItem()
		{
			return this.RootPanel.GetRootItem();
		}

		// Token: 0x0603BE8F RID: 245391 RVA: 0x01105DDC File Offset: 0x01103FDC
		public void OnViewDestroy()
		{
			foreach (UiPanelBase uiPanelBase in this.PanelMap.Values)
			{
				uiPanelBase.Destroy(null);
			}
			this.PanelMap.Clear();
			if (this.RootPanel != null)
			{
				this.RootPanel.Destroy(null);
			}
		}

		// Token: 0x0603BE90 RID: 245392 RVA: 0x01105E54 File Offset: 0x01104054
		[return: Nullable(2)]
		private ULGUIComponentsRegistry GetLguiComponentsRegistry(UiPanelBase panel)
		{
			AActor rootActor = panel.GetRootActor();
			if (rootActor == null)
			{
				return null;
			}
			return rootActor.GetComponentByClass(ULGUIComponentsRegistry.StaticClass()) as ULGUIComponentsRegistry;
		}

		// Token: 0x0401FABA RID: 129722
		[Nullable(2)]
		private CommonTouchUiEditRootPanel RootPanel;

		// Token: 0x0401FABB RID: 129723
		private readonly Dictionary<string, UiPanelBase> PanelMap = new Dictionary<string, UiPanelBase>();
	}
}
