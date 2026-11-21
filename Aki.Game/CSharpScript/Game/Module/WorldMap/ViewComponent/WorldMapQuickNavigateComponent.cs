using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.View.BaseMap;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E4 RID: 14052
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapQuickNavigateComponent : MapComponent
	{
		// Token: 0x060248E1 RID: 149729 RVA: 0x00A54017 File Offset: 0x00A52217
		public WorldMapQuickNavigateComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x060248E2 RID: 149730 RVA: 0x00A54020 File Offset: 0x00A52220
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapQuickNavigate;
			}
		}

		// Token: 0x060248E3 RID: 149731 RVA: 0x00A54023 File Offset: 0x00A52223
		protected override void OnEnable()
		{
			EventSystem.Instance.Add(EEventName.WorldMapNavigate, new Action<NavigateMark>(this.EventWorldMapNavigate));
		}

		// Token: 0x060248E4 RID: 149732 RVA: 0x00A54041 File Offset: 0x00A52241
		protected override void OnDisable()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapNavigate, new Action<NavigateMark>(this.EventWorldMapNavigate));
		}

		// Token: 0x060248E5 RID: 149733 RVA: 0x00A5405F File Offset: 0x00A5225F
		private void EventWorldMapNavigate(NavigateMark navigate)
		{
			this.NavigateTo(navigate.MarkId, navigate.MarkType, navigate.Focal.GetValueOrDefault(), navigate.FocusTween.GetValueOrDefault(true), navigate.NeedTempShow.GetValueOrDefault());
		}

		// Token: 0x060248E6 RID: 149734 RVA: 0x00A54098 File Offset: 0x00A52298
		public bool NavigateTo(int markId, EMarkType markType, bool focal = false, bool focusTween = true, bool needTempShow = false)
		{
			WorldMapChangeMapDiffParams navigateMarkIsNeedChangeMap = this.GetNavigateMarkIsNeedChangeMap(markId, markType);
			if (navigateMarkIsNeedChangeMap.MapId != null)
			{
				EventSystem.Instance.Emit<WorldMapChangeMapParams>(EEventName.ChangeWorldMap, new WorldMapChangeMapParams
				{
					MarkId = markId,
					MarkType = markType,
					MapId = navigateMarkIsNeedChangeMap.MapId.Value,
					Focal = new bool?(focal),
					FocusTween = new bool?(focusTween),
					Gravity = navigateMarkIsNeedChangeMap.Gravity,
					NeedTempShow = new bool?(needTempShow)
				});
				return true;
			}
			EventSystem.Instance.Emit<int, EMarkType, bool, bool, bool?>(EEventName.WorldMapFocalMarkItem, markId, markType, focal, focusTween, new bool?(needTempShow));
			return false;
		}

		// Token: 0x060248E7 RID: 149735 RVA: 0x00A54140 File Offset: 0x00A52340
		public WorldMapChangeMapDiffParams GetNavigateMarkIsNeedChangeMap(int markId, EMarkType markType)
		{
			BaseMap map = (base.Parent.AsT3 as WorldMapUiEntity).Map;
			MarkItem markItem = map.GetMarkItem(markType, markId);
			MapModel instance = MapModel.Instance;
			int dungeonMapConfigId = instance.GetDungeonMapConfigId((markItem != null) ? markItem.MapId : instance.GetMarkMapConfigId(markId, markType));
			EMapGravityDirection emapGravityDirection = (markItem != null) ? markItem.Gravity : instance.GetMarkMapGravity(markId, markType);
			int? num = (dungeonMapConfigId != map.MapId) ? new int?(dungeonMapConfigId) : null;
			emapGravityDirection = WorldMapModel.Instance.GetFinalWorldMapGravity(num ?? map.MapId, new EMapGravityDirection?(emapGravityDirection));
			EMapGravityDirection? emapGravityDirection2 = (emapGravityDirection != map.MapGravity) ? new EMapGravityDirection?(emapGravityDirection) : null;
			if (emapGravityDirection2 != null)
			{
				return new WorldMapChangeMapDiffParams
				{
					MapId = new int?(num ?? map.MapId),
					Gravity = new EMapGravityDirection?(emapGravityDirection2.Value)
				};
			}
			return new WorldMapChangeMapDiffParams
			{
				MapId = num
			};
		}
	}
}
