using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Ui.WorldMap.View.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E2 RID: 14050
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapMultiFloorComponent : MapComponent
	{
		// Token: 0x060248C4 RID: 149700 RVA: 0x00A5372B File Offset: 0x00A5192B
		public WorldMapMultiFloorComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x060248C5 RID: 149701 RVA: 0x00A53734 File Offset: 0x00A51934
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapMultiFloor;
			}
		}

		// Token: 0x17004B15 RID: 19221
		// (get) Token: 0x060248C6 RID: 149702 RVA: 0x00A53737 File Offset: 0x00A51937
		public int? SelectedMultiMapGroupId
		{
			get
			{
				return this.SelectedMultiMapGroupIdInner;
			}
		}

		// Token: 0x17004B16 RID: 19222
		// (get) Token: 0x060248C7 RID: 149703 RVA: 0x00A5373F File Offset: 0x00A5193F
		public int? SelectedMultiMapFloorId
		{
			get
			{
				return this.SelectedMultiMapFloorIdInner;
			}
		}

		// Token: 0x17004B17 RID: 19223
		// (get) Token: 0x060248C8 RID: 149704 RVA: 0x00A53748 File Offset: 0x00A51948
		private WorldMapUiEntity WorldMapUiComponent
		{
			get
			{
				WorldMapUiEntity worldMapUiEntity = base.Parent.AsT3 as WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					base.LogError(ELogAuthor.LRX, "[地图系统]->二级界面组件没有附加到容器下！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return worldMapUiEntity;
			}
		}

		// Token: 0x060248C9 RID: 149705 RVA: 0x00A53785 File Offset: 0x00A51985
		protected override void OnEnable()
		{
			EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChanged, new Action<int>(this.OnWorldMapSubMapChanged));
			EventSystem.Instance.Add(EEventName.MultiMapUnlockChanged, new Action(this.OnMultiMapUnlockChanged));
		}

		// Token: 0x060248CA RID: 149706 RVA: 0x00A537BF File Offset: 0x00A519BF
		protected override void OnDisable()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapSubMapChanged, new Action<int>(this.OnWorldMapSubMapChanged));
			EventSystem.Instance.Remove(EEventName.MultiMapUnlockChanged, new Action(this.OnMultiMapUnlockChanged));
		}

		// Token: 0x060248CB RID: 149707 RVA: 0x00A537F9 File Offset: 0x00A519F9
		public void Reset()
		{
			this.SelectedMultiMapGroupIdInner = null;
			this.SelectedMultiMapFloorIdInner = null;
			WorldMapModel.Instance.WorldMapCurrentMultiMapId = null;
			this.SetMultiMapMenuActive(false).Forget<bool>();
		}

		// Token: 0x060248CC RID: 149708 RVA: 0x00A53830 File Offset: 0x00A51A30
		public void InitMultiMap()
		{
			this.MultiMapMenuVisible = false;
			UUIItem multiMapFloorContainer = this.MultiMapFloorContainer;
			if (multiMapFloorContainer != null)
			{
				multiMapFloorContainer.SetUIActive(false);
			}
			if (!WorldMapModel.Instance.IsMultiMapVisible)
			{
				return;
			}
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
			MultiMap? subMapConfigByAreaId = MapConfig.Instance.GetSubMapConfigByAreaId(currentAreaId);
			if (subMapConfigByAreaId != null)
			{
				int groupId = subMapConfigByAreaId.Value.GroupId;
				int floor = subMapConfigByAreaId.Value.Floor;
				this.SelectMultiMapFloor(currentAreaId, new int?(groupId), new int?(floor), false);
			}
		}

		// Token: 0x060248CD RID: 149709 RVA: 0x00A538C4 File Offset: 0x00A51AC4
		public void UpdateMultiMap()
		{
			if (!WorldMapModel.Instance.IsMultiMapVisible)
			{
				if (this.SelectedMultiMapGroupId != null || this.SelectedMultiMapFloorId != null)
				{
					this.DeSelectMultiMapFloor(true);
				}
				return;
			}
			global::Vector worldMapCenterPosition = this.WorldMapUiComponent.Map.GetWorldMapCenterPosition();
			int areaId = 0;
			MarkItem clickedItem = this.WorldMapUiComponent.ClickedItem;
			if (clickedItem != null && clickedItem.IsMultiMap())
			{
				int multiMapId = this.WorldMapUiComponent.ClickedItem.GetMultiMapId();
				MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(multiMapId);
				if (subMapConfigById != null)
				{
					if (subMapConfigById.Value.AreaLength > 0)
					{
						areaId = subMapConfigById.Value.Area(0);
					}
					else
					{
						areaId = 0;
					}
				}
			}
			else if (worldMapCenterPosition != null)
			{
				areaId = this.WorldMapUiComponent.Map.GetMultiMapAreaIdByPosition(worldMapCenterPosition);
			}
			int num = (worldMapCenterPosition != null) ? this.WorldMapUiComponent.Map.GetSubMapGroupByPosition(worldMapCenterPosition) : 0;
			if (this.SelectedMultiMapGroupId.GetValueOrDefault() != num)
			{
				bool flag = (this.SelectedMultiMapFloorId ?? 0) == 0;
				if (flag)
				{
					if (num == 0)
					{
						this.SelectMultiMapFloor(areaId, null, null, true);
					}
					else
					{
						this.SelectMultiMapFloor(areaId, new int?(num), new int?(0), true);
					}
				}
			}
			if (worldMapCenterPosition != null)
			{
				this.WorldMapUiComponent.Map.UpdateCurrentAreaMapGroupId(worldMapCenterPosition);
			}
		}

		// Token: 0x060248CE RID: 149710 RVA: 0x00A53A30 File Offset: 0x00A51C30
		private int GetWorldMapFocusMultiMapAreaId()
		{
			MarkItem clickedItem = this.WorldMapUiComponent.ClickedItem;
			if (clickedItem != null && clickedItem.IsMultiMap())
			{
				int multiMapId = this.WorldMapUiComponent.ClickedItem.GetMultiMapId();
				MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(multiMapId);
				if (subMapConfigById != null)
				{
					if (subMapConfigById.Value.AreaLength > 0)
					{
						return subMapConfigById.Value.Area(0);
					}
					return 0;
				}
			}
			global::Vector worldMapCenterPosition = this.WorldMapUiComponent.Map.GetWorldMapCenterPosition();
			if (worldMapCenterPosition == null)
			{
				return 0;
			}
			return this.WorldMapUiComponent.Map.GetMultiMapAreaIdByPosition(worldMapCenterPosition);
		}

		// Token: 0x060248CF RID: 149711 RVA: 0x00A53AC8 File Offset: 0x00A51CC8
		public void SelectMultiMapFloor(int areaId, int? multiMapGroupId = null, int? floor = null, bool playSubMapTween = true)
		{
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
			int areaId2 = (areaInfo != null) ? AreaModel.Instance.GetAreaId(areaInfo.Value, new EAreaLevel?(EAreaLevel.FirstLevel)) : 0;
			bool multiMapMenuActive;
			if (!(multiMapMenuActive = MapModel.Instance.CheckAreasUnlocked(areaId2, true)) || multiMapGroupId == null || floor == null)
			{
				this.SelectedMultiMapGroupIdInner = null;
				this.SelectedMultiMapFloorIdInner = null;
				WorldMapModel.Instance.WorldMapCurrentMultiMapId = null;
				multiMapMenuActive = false;
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSelectMultiMap, 0);
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChangedFromUpdate, 0);
				this.ChangeMultiMapFloor(0, false, new bool?(playSubMapTween));
				this.SetMultiMapMenuActive(multiMapMenuActive).Forget<bool>();
				return;
			}
			List<MultiMap> list = MapConfig.Instance.GetSubMapConfigByGroupId(multiMapGroupId.Value);
			List<MultiMap> list2 = new List<MultiMap>();
			foreach (MultiMap item in list)
			{
				if (MapModel.Instance.CheckUnlockMultiMapIds(item.Id) || item.Floor == 0)
				{
					list2.Add(item);
				}
			}
			list = list2;
			list.Sort((MultiMap a, MultiMap b) => b.Floor.CompareTo(a.Floor));
			if (list.Count == 1)
			{
				return;
			}
			int? selectedMultiMapFloorIdInner = null;
			int num = 0;
			if (floor != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					MultiMap multiMap = list[i];
					if (multiMap.Floor == floor.Value)
					{
						selectedMultiMapFloorIdInner = new int?(i);
						num = multiMap.Id;
						break;
					}
				}
			}
			this.SelectedMultiMapGroupIdInner = multiMapGroupId;
			this.SelectedMultiMapFloorIdInner = selectedMultiMapFloorIdInner;
			if (selectedMultiMapFloorIdInner != null)
			{
				WorldMapModel.Instance.WorldMapCurrentMultiMapId = new int?(num);
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSelectMultiMap, num);
				this.ChangeMultiMapFloor(selectedMultiMapFloorIdInner.Value, false, new bool?(playSubMapTween));
			}
			this.SetMultiMapMenuActive(multiMapMenuActive).Forget<bool>();
			GenericLayout<WorldMapSubMapItem, MultiMap> multiMapFloorLayout = this.MultiMapFloorLayout;
			if (multiMapFloorLayout != null)
			{
				multiMapFloorLayout.RefreshByDataAsync(list, false, null).Forget();
			}
			GenericLayout<WorldMapSubMapItem, MultiMap> multiMapFloorLayout2 = this.MultiMapFloorLayout;
			if (multiMapFloorLayout2 != null)
			{
				multiMapFloorLayout2.SelectGridProxy(selectedMultiMapFloorIdInner.GetValueOrDefault(), false);
			}
			EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChangedFromUpdate, selectedMultiMapFloorIdInner.GetValueOrDefault());
		}

		// Token: 0x060248D0 RID: 149712 RVA: 0x00A53D40 File Offset: 0x00A51F40
		public void DeSelectMultiMapFloor(bool playSubMapTween = true)
		{
			int worldMapFocusMultiMapAreaId = this.GetWorldMapFocusMultiMapAreaId();
			this.SelectMultiMapFloor(worldMapFocusMultiMapAreaId, null, null, playSubMapTween);
		}

		// Token: 0x060248D1 RID: 149713 RVA: 0x00A53D70 File Offset: 0x00A51F70
		[NullableContext(0)]
		public UniTask<bool> SetMultiMapMenuActive(bool active)
		{
			WorldMapMultiFloorComponent.<SetMultiMapMenuActive>d__23 <SetMultiMapMenuActive>d__;
			<SetMultiMapMenuActive>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SetMultiMapMenuActive>d__.<>4__this = this;
			<SetMultiMapMenuActive>d__.active = active;
			<SetMultiMapMenuActive>d__.<>1__state = -1;
			<SetMultiMapMenuActive>d__.<>t__builder.Start<WorldMapMultiFloorComponent.<SetMultiMapMenuActive>d__23>(ref <SetMultiMapMenuActive>d__);
			return <SetMultiMapMenuActive>d__.<>t__builder.Task;
		}

		// Token: 0x060248D2 RID: 149714 RVA: 0x00A53DBC File Offset: 0x00A51FBC
		private void OnWorldMapSubMapChanged(int floor)
		{
			this.OnChangeMultiMapFloor(floor, null);
		}

		// Token: 0x060248D3 RID: 149715 RVA: 0x00A53DDC File Offset: 0x00A51FDC
		private void OnMultiMapUnlockChanged()
		{
			int? selectedMultiMapFloorIdInner = this.SelectedMultiMapFloorIdInner;
			if (this.SelectedMultiMapGroupId != null && selectedMultiMapFloorIdInner != null)
			{
				int? num = selectedMultiMapFloorIdInner;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					this.WorldMapUiComponent.Map.ShowSubMapTile(this.SelectedMultiMapGroupId.Value, selectedMultiMapFloorIdInner.Value, true);
					return;
				}
			}
		}

		// Token: 0x060248D4 RID: 149716 RVA: 0x00A53E48 File Offset: 0x00A52048
		private void OnChangeMultiMapFloor(int floor, bool? playShowSubMapTween = null)
		{
			this.ChangeMultiMapFloor(floor, true, new bool?(playShowSubMapTween.GetValueOrDefault(true)));
			EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChangedFromUpdate, floor);
		}

		// Token: 0x060248D5 RID: 149717 RVA: 0x00A53E70 File Offset: 0x00A52070
		private void ChangeMultiMapFloor(int floor, bool updateMultiMapFloor, bool? playShowSubMapTween = null)
		{
			if (this.MultiMapMenuVisible)
			{
				GenericLayout<WorldMapSubMapItem, MultiMap> multiMapFloorLayout = this.MultiMapFloorLayout;
				if (multiMapFloorLayout != null)
				{
					multiMapFloorLayout.DeselectCurrentGridProxy();
				}
				GenericLayout<WorldMapSubMapItem, MultiMap> multiMapFloorLayout2 = this.MultiMapFloorLayout;
				if (multiMapFloorLayout2 != null)
				{
					multiMapFloorLayout2.SelectGridProxy(floor, false);
				}
			}
			this.SelectedMultiMapFloorIdInner = new int?(floor);
			if (this.SelectedMultiMapGroupId == null || floor == 0)
			{
				this.WorldMapUiComponent.Map.HideSubMapTile();
				if (updateMultiMapFloor)
				{
					this.UpdateMultiMap();
					return;
				}
			}
			else
			{
				this.WorldMapUiComponent.Map.ShowSubMapTile(this.SelectedMultiMapGroupId.Value, floor, !playShowSubMapTween.GetValueOrDefault(true));
			}
		}

		// Token: 0x04014552 RID: 83282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayout<WorldMapSubMapItem, MultiMap> MultiMapFloorLayout;

		// Token: 0x04014553 RID: 83283
		private int? SelectedMultiMapGroupIdInner;

		// Token: 0x04014554 RID: 83284
		private int? SelectedMultiMapFloorIdInner;

		// Token: 0x04014555 RID: 83285
		public UUIItem MultiMapFloorContainer;

		// Token: 0x04014556 RID: 83286
		public TWorldMapPlaySequenceFunction WorldMapViewPlaySequenceFunction;

		// Token: 0x04014557 RID: 83287
		private bool MultiMapMenuVisible;
	}
}
