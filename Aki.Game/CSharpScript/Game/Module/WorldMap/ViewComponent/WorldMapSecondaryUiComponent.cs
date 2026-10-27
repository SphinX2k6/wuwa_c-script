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
	// Token: 0x020047B8 RID: 18360
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapSecondaryUiComponent : MapComponent
	{
		// Token: 0x0603015E RID: 196958 RVA: 0x00B2501A File Offset: 0x00B2321A
		public WorldMapSecondaryUiComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17007874 RID: 30836
		// (get) Token: 0x0603015F RID: 196959 RVA: 0x00B2502E File Offset: 0x00B2322E
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapSecondaryUi;
			}
		}

		// Token: 0x17007875 RID: 30837
		// (get) Token: 0x06030160 RID: 196960 RVA: 0x00B25034 File Offset: 0x00B23234
		// (set) Token: 0x06030161 RID: 196961 RVA: 0x00B25061 File Offset: 0x00B23261
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

		// Token: 0x17007876 RID: 30838
		// (get) Token: 0x06030162 RID: 196962 RVA: 0x00B2507B File Offset: 0x00B2327B
		public bool IsSecondaryUiOpening
		{
			get
			{
				return this.ExtraSecondaryUiOpen || this.IsInternalSecondaryUiOpen();
			}
		}

		// Token: 0x17007877 RID: 30839
		// (get) Token: 0x06030163 RID: 196963 RVA: 0x00B25090 File Offset: 0x00B23290
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

		// Token: 0x06030164 RID: 196964 RVA: 0x00B250D0 File Offset: 0x00B232D0
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

		// Token: 0x06030165 RID: 196965 RVA: 0x00B25130 File Offset: 0x00B23330
		protected override void OnRemove()
		{
			this.SecondaryPanels.Clear();
		}

		// Token: 0x06030166 RID: 196966 RVA: 0x00B25140 File Offset: 0x00B23340
		public void ShowPanel(MarkItem clickedItem, UUIItem parent, int customPanelMode = 1)
		{
			ESecondaryPanel secondaryUiType = clickedItem.GetSecondaryUiType();
			this.OpenUi(secondaryUiType, parent, new object[]
			{
				clickedItem,
				customPanelMode
			});
		}

		// Token: 0x06030167 RID: 196967 RVA: 0x00B25170 File Offset: 0x00B23370
		public void ShowMarkMenu(UUIItem parent, List<MarkItem> markItems)
		{
			this.OpenUi(ESecondaryPanel.MarkMenuPanel, parent, new object[]
			{
				markItems
			});
		}

		// Token: 0x06030168 RID: 196968 RVA: 0x00B25185 File Offset: 0x00B23385
		public void ShowTrackMenu(UUIItem parent, List<ITrackMenuItemData> markItems)
		{
			this.OpenUi(ESecondaryPanel.TrackMenuPanel, parent, new object[]
			{
				markItems
			});
		}

		// Token: 0x06030169 RID: 196969 RVA: 0x00B2519B File Offset: 0x00B2339B
		public void ShowWorldMapNotePanel(UUIItem parent, List<IMapNoteParams> mapNoteParamList)
		{
			this.OpenUi(ESecondaryPanel.WorldMapNotePanel, parent, new object[]
			{
				mapNoteParamList
			});
		}

		// Token: 0x0603016A RID: 196970 RVA: 0x00B251B1 File Offset: 0x00B233B1
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

		// Token: 0x0603016B RID: 196971 RVA: 0x00B251CB File Offset: 0x00B233CB
		public void ShowMapPeriodicActivityPanel(UUIItem parent)
		{
			this.OpenUi(ESecondaryPanel.ActivityListPanel, parent, Array.Empty<object>());
		}

		// Token: 0x0603016C RID: 196972 RVA: 0x00B251DC File Offset: 0x00B233DC
		public void ShowQuickNavigate(UUIItem parent, List<MarkItem> navigateMarkItems)
		{
			this.OpenUi(ESecondaryPanel.QuickNavigatePanel, parent, new object[]
			{
				navigateMarkItems
			}).Forget();
		}

		// Token: 0x0603016D RID: 196973 RVA: 0x00B251F8 File Offset: 0x00B233F8
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

		// Token: 0x0603016E RID: 196974 RVA: 0x00B25254 File Offset: 0x00B23454
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

		// Token: 0x0603016F RID: 196975 RVA: 0x00B252C4 File Offset: 0x00B234C4
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

		// Token: 0x06030170 RID: 196976 RVA: 0x00B252EC File Offset: 0x00B234EC
		public void AllSecondaryPanelsUpdateMap()
		{
			BaseMap map = this.WorldMapUiComponent.Map;
			foreach (WorldMapSecondaryUi worldMapSecondaryUi in this.SecondaryPanels.Values)
			{
				worldMapSecondaryUi.UpdateMap(map);
			}
		}

		// Token: 0x06030171 RID: 196977 RVA: 0x00B25350 File Offset: 0x00B23550
		public bool CheckSecondaryUiIsOpen(ESecondaryPanel type)
		{
			WorldMapSecondaryUi worldMapSecondaryUi;
			return this.SecondaryPanels.TryGetValue(type, out worldMapSecondaryUi) && worldMapSecondaryUi.IsUiOpen;
		}

		// Token: 0x04019EC1 RID: 106177
		private readonly OrderedDictionary<ESecondaryPanel, WorldMapSecondaryUi> SecondaryPanels = new OrderedDictionary<ESecondaryPanel, WorldMapSecondaryUi>();

		// Token: 0x0200AA71 RID: 43633
		[NullableContext(0)]
		public static class EPropertyType
		{
			// Token: 0x04033DC2 RID: 212418
			public const int ExtraSecondaryUiOpen = 0;
		}
	}
}
