using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle;
using CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E9 RID: 14057
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapSecondaryUiComponent : MapComponent
	{
		// Token: 0x0602492D RID: 149805 RVA: 0x00A54F9E File Offset: 0x00A5319E
		public WorldMapSecondaryUiComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x0602492E RID: 149806 RVA: 0x00A54FB2 File Offset: 0x00A531B2
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapSecondaryUi;
			}
		}

		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x0602492F RID: 149807 RVA: 0x00A54FB8 File Offset: 0x00A531B8
		// (set) Token: 0x06024930 RID: 149808 RVA: 0x00A54FE5 File Offset: 0x00A531E5
		public bool ExtraSecondaryUiOpen
		{
			get
			{
				return base.PropertyMap.TryGet(0, false, true).AsT2;
			}
			set
			{
				base.PropertyMap.Set(0, value);
			}
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x06024931 RID: 149809 RVA: 0x00A54FFF File Offset: 0x00A531FF
		public bool IsSecondaryUiOpening
		{
			get
			{
				return this.ExtraSecondaryUiOpen || this.IsInternalSecondaryUiOpen();
			}
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x06024932 RID: 149810 RVA: 0x00A55014 File Offset: 0x00A53214
		[Nullable(2)]
		private WorldMapUiEntity WorldMapUiComponent
		{
			[NullableContext(2)]
			get
			{
				WorldMapUiEntity worldMapUiEntity = base.Parent.AsT3 as WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					base.LogError(ELogAuthor.LYX, "[地图系统]->二级界面组件没有附加到容器下！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return worldMapUiEntity;
			}
		}

		// Token: 0x06024933 RID: 149811 RVA: 0x00A55054 File Offset: 0x00A53254
		public bool IsInternalSecondaryUiOpen()
		{
			using (OrderedDictionary<ESecondaryPanel, WorldMapSecondaryUi>.ValueCollection.Enumerator enumerator = this.SecondaryPanels.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsUiCloseComplete)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06024934 RID: 149812 RVA: 0x00A550B4 File Offset: 0x00A532B4
		protected override void OnRemove()
		{
			this.SecondaryPanels.Clear();
		}

		// Token: 0x06024935 RID: 149813 RVA: 0x00A550C4 File Offset: 0x00A532C4
		public void ShowPanel(MarkItem clickedItem, UUIItem parent, int customPanelMode = 1)
		{
			ESecondaryPanel secondaryUiType = clickedItem.GetSecondaryUiType();
			this.OpenUi(secondaryUiType, parent, new object[]
			{
				clickedItem,
				customPanelMode
			});
		}

		// Token: 0x06024936 RID: 149814 RVA: 0x00A550F4 File Offset: 0x00A532F4
		public void ShowMarkMenu(UUIItem parent, List<MarkItem> markItems)
		{
			this.OpenUi(ESecondaryPanel.MarkMenuPanel, parent, new object[]
			{
				markItems
			});
		}

		// Token: 0x06024937 RID: 149815 RVA: 0x00A55109 File Offset: 0x00A53309
		public void ShowTrackMenu(UUIItem parent, List<ITrackMenuItemData> markItems)
		{
			this.OpenUi(ESecondaryPanel.TrackMenuPanel, parent, new object[]
			{
				markItems
			});
		}

		// Token: 0x06024938 RID: 149816 RVA: 0x00A5511F File Offset: 0x00A5331F
		public void ShowWorldMapNotePanel(UUIItem parent, List<IMapNoteParams> mapNoteParamList)
		{
			this.OpenUi(ESecondaryPanel.WorldMapNotePanel, parent, new object[]
			{
				mapNoteParamList
			});
		}

		// Token: 0x06024939 RID: 149817 RVA: 0x00A55135 File Offset: 0x00A53335
		public void ShowMapMarkTogglePanel(UUIItem parent, [Nullable(new byte[]
		{
			2,
			1
		})] List<IMapMarkToggleItemData> markToggleDataList = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<IMapMarkProgressItemData> markProgressDataList = null)
		{
			this.OpenUi(ESecondaryPanel.MapMarkTogglePanel, parent, new object[]
			{
				markToggleDataList,
				markProgressDataList
			});
		}

		// Token: 0x0602493A RID: 149818 RVA: 0x00A5514F File Offset: 0x00A5334F
		public void ShowMapPeriodicActivityPanel(UUIItem parent)
		{
			this.OpenUi(ESecondaryPanel.ActivityListPanel, parent, Array.Empty<object>());
		}

		// Token: 0x0602493B RID: 149819 RVA: 0x00A55160 File Offset: 0x00A53360
		public void ShowQuickNavigate(UUIItem parent, List<MarkItem> navigateMarkItems)
		{
			this.OpenUi(ESecondaryPanel.QuickNavigatePanel, parent, new object[]
			{
				navigateMarkItems
			}).Forget();
		}

		// Token: 0x0602493C RID: 149820 RVA: 0x00A5517C File Offset: 0x00A5337C
		public UniTask OpenUi(ESecondaryPanel type, UUIItem parent, params object[] parameters)
		{
			WorldMapSecondaryUiComponent.<OpenUi>d__21 <OpenUi>d__;
			<OpenUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenUi>d__.<>4__this = this;
			<OpenUi>d__.type = type;
			<OpenUi>d__.parent = parent;
			<OpenUi>d__.parameters = parameters;
			<OpenUi>d__.<>1__state = -1;
			<OpenUi>d__.<>t__builder.Start<WorldMapSecondaryUiComponent.<OpenUi>d__21>(ref <OpenUi>d__);
			return <OpenUi>d__.<>t__builder.Task;
		}

		// Token: 0x0602493D RID: 149821 RVA: 0x00A551D8 File Offset: 0x00A533D8
		public void CloseUi(Action callback, bool playSequence = true)
		{
			foreach (WorldMapSecondaryUi worldMapSecondaryUi in this.SecondaryPanels.Values)
			{
				UUIItem rootItem = worldMapSecondaryUi.GetRootItem();
				if (worldMapSecondaryUi.IsUiOpen && rootItem != null)
				{
					worldMapSecondaryUi.CloseWithCallBack(callback, playSequence);
					break;
				}
			}
		}

		// Token: 0x0602493E RID: 149822 RVA: 0x00A55248 File Offset: 0x00A53448
		[NullableContext(2)]
		public UUIItem GetSecondaryPanelGuideFocusUiItem(ESecondaryPanel panelIndex)
		{
			WorldMapSecondaryUi worldMapSecondaryUi;
			if (this.SecondaryPanels.TryGetValue(panelIndex, out worldMapSecondaryUi))
			{
				return worldMapSecondaryUi.GetGuideFocusUiItem();
			}
			return null;
		}

		// Token: 0x0602493F RID: 149823 RVA: 0x00A55270 File Offset: 0x00A53470
		public void AllSecondaryPanelsUpdateMap()
		{
			BaseMap map = this.WorldMapUiComponent.Map;
			foreach (WorldMapSecondaryUi worldMapSecondaryUi in this.SecondaryPanels.Values)
			{
				worldMapSecondaryUi.UpdateMap(map);
			}
		}

		// Token: 0x06024940 RID: 149824 RVA: 0x00A552D4 File Offset: 0x00A534D4
		public bool CheckSecondaryUiIsOpen(ESecondaryPanel type)
		{
			WorldMapSecondaryUi worldMapSecondaryUi;
			return this.SecondaryPanels.TryGetValue(type, out worldMapSecondaryUi) && worldMapSecondaryUi.IsUiOpen;
		}

		// Token: 0x04014571 RID: 83313
		private readonly OrderedDictionary<ESecondaryPanel, WorldMapSecondaryUi> SecondaryPanels = new OrderedDictionary<ESecondaryPanel, WorldMapSecondaryUi>();

		// Token: 0x02009425 RID: 37925
		[NullableContext(0)]
		public static class EPropertyType
		{
			// Token: 0x0402E54E RID: 189774
			public const int ExtraSecondaryUiOpen = 0;
		}
	}
}
