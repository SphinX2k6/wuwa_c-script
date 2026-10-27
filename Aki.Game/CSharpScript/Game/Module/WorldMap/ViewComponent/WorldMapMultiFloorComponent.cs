using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020047B1 RID: 18353
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapMultiFloorComponent : MapComponent
	{
		// Token: 0x060300F5 RID: 196853 RVA: 0x00B237DF File Offset: 0x00B219DF
		public WorldMapMultiFloorComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17007858 RID: 30808
		// (get) Token: 0x060300F6 RID: 196854 RVA: 0x00B237E8 File Offset: 0x00B219E8
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapMultiFloor;
			}
		}

		// Token: 0x17007859 RID: 30809
		// (get) Token: 0x060300F7 RID: 196855 RVA: 0x00B237EB File Offset: 0x00B219EB
		public int? SelectedMultiMapGroupId
		{
			get
			{
				return this.SelectedMultiMapGroupIdInner;
			}
		}

		// Token: 0x1700785A RID: 30810
		// (get) Token: 0x060300F8 RID: 196856 RVA: 0x00B237F3 File Offset: 0x00B219F3
		public int? SelectedMultiMapFloorId
		{
			get
			{
				return this.SelectedMultiMapFloorIdInner;
			}
		}

		// Token: 0x1700785B RID: 30811
		// (get) Token: 0x060300F9 RID: 196857 RVA: 0x00B237FC File Offset: 0x00B219FC
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

		// Token: 0x060300FA RID: 196858 RVA: 0x00B23839 File Offset: 0x00B21A39
		protected override void OnEnable()
		{
			EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChanged, new Action<int>(this.OnWorldMapSubMapChanged));
			EventSystem.Instance.Add(EEventName.MultiMapUnlockChanged, new Action(this.OnMultiMapUnlockChanged));
		}

		// Token: 0x060300FB RID: 196859 RVA: 0x00B23873 File Offset: 0x00B21A73
		protected override void OnDisable()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapSubMapChanged, new Action<int>(this.OnWorldMapSubMapChanged));
			EventSystem.Instance.Remove(EEventName.MultiMapUnlockChanged, new Action(this.OnMultiMapUnlockChanged));
		}

		// Token: 0x060300FC RID: 196860 RVA: 0x00B238AD File Offset: 0x00B21AAD
		public void Reset()
		{
			this.SelectedMultiMapGroupIdInner = null;
			this.SelectedMultiMapFloorIdInner = null;
			WorldMapModel.Instance.WorldMapCurrentMultiMapId = null;
			this.SetMultiMapMenuActive(false).Forget<bool>();
		}

		// Token: 0x060300FD RID: 196861 RVA: 0x00B238E4 File Offset: 0x00B21AE4
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

		// Token: 0x060300FE RID: 196862 RVA: 0x00B23978 File Offset: 0x00B21B78
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

		// Token: 0x060300FF RID: 196863 RVA: 0x00B23AE4 File Offset: 0x00B21CE4
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

		// Token: 0x06030100 RID: 196864 RVA: 0x00B23B7C File Offset: 0x00B21D7C
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
			list = (from multiMapFloorData in list
			where MapModel.Instance.CheckUnlockMultiMapIds(multiMapFloorData.Id) || multiMapFloorData.Floor == 0
			select multiMapFloorData).ToList<MultiMap>();
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

		// Token: 0x06030101 RID: 196865 RVA: 0x00B23DB4 File Offset: 0x00B21FB4
		public void DeSelectMultiMapFloor(bool playSubMapTween = true)
		{
			int worldMapFocusMultiMapAreaId = this.GetWorldMapFocusMultiMapAreaId();
			this.SelectMultiMapFloor(worldMapFocusMultiMapAreaId, null, null, playSubMapTween);
		}

		// Token: 0x06030102 RID: 196866 RVA: 0x00B23DE4 File Offset: 0x00B21FE4
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

		// Token: 0x06030103 RID: 196867 RVA: 0x00B23E30 File Offset: 0x00B22030
		private void OnWorldMapSubMapChanged(int floor)
		{
			this.OnChangeMultiMapFloor(floor, null);
		}

		// Token: 0x06030104 RID: 196868 RVA: 0x00B23E50 File Offset: 0x00B22050
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

		// Token: 0x06030105 RID: 196869 RVA: 0x00B23EBC File Offset: 0x00B220BC
		private void OnChangeMultiMapFloor(int floor, bool? playShowSubMapTween = null)
		{
			this.ChangeMultiMapFloor(floor, true, new bool?(playShowSubMapTween.GetValueOrDefault(true)));
			EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChangedFromUpdate, floor);
		}

		// Token: 0x06030106 RID: 196870 RVA: 0x00B23EE4 File Offset: 0x00B220E4
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

		// Token: 0x04019EA2 RID: 106146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericLayout<WorldMapSubMapItem, MultiMap> MultiMapFloorLayout;

		// Token: 0x04019EA3 RID: 106147
		private int? SelectedMultiMapGroupIdInner;

		// Token: 0x04019EA4 RID: 106148
		private int? SelectedMultiMapFloorIdInner;

		// Token: 0x04019EA5 RID: 106149
		public UUIItem MultiMapFloorContainer;

		// Token: 0x04019EA6 RID: 106150
		public TWorldMapPlaySequenceFunction WorldMapViewPlaySequenceFunction;

		// Token: 0x04019EA7 RID: 106151
		private bool MultiMapMenuVisible;
	}
}
