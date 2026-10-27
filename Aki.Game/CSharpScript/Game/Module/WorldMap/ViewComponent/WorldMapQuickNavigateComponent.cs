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
	// Token: 0x020047B3 RID: 18355
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapQuickNavigateComponent : MapComponent
	{
		// Token: 0x06030112 RID: 196882 RVA: 0x00B2408B File Offset: 0x00B2228B
		public WorldMapQuickNavigateComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17007861 RID: 30817
		// (get) Token: 0x06030113 RID: 196883 RVA: 0x00B24094 File Offset: 0x00B22294
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapQuickNavigate;
			}
		}

		// Token: 0x06030114 RID: 196884 RVA: 0x00B24097 File Offset: 0x00B22297
		protected override void OnEnable()
		{
			EventSystem.Instance.Add(EEventName.WorldMapNavigate, new Action<NavigateMark>(this.EventWorldMapNavigate));
		}

		// Token: 0x06030115 RID: 196885 RVA: 0x00B240B5 File Offset: 0x00B222B5
		protected override void OnDisable()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapNavigate, new Action<NavigateMark>(this.EventWorldMapNavigate));
		}

		// Token: 0x06030116 RID: 196886 RVA: 0x00B240D3 File Offset: 0x00B222D3
		private void EventWorldMapNavigate(NavigateMark navigate)
		{
			this.NavigateTo(navigate.MarkId, navigate.MarkType, navigate.Focal.GetValueOrDefault(), navigate.FocusTween.GetValueOrDefault(true), navigate.NeedTempShow.GetValueOrDefault());
		}

		// Token: 0x06030117 RID: 196887 RVA: 0x00B2410C File Offset: 0x00B2230C
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

		// Token: 0x06030118 RID: 196888 RVA: 0x00B241B4 File Offset: 0x00B223B4
		public WorldMapChangeMapDiffParams GetNavigateMarkIsNeedChangeMap(int markId, EMarkType markType)
		{
			BaseMap map = (base.Parent.AsT3 as WorldMapUiEntity).Map;
			MarkItem markItem = map.GetMarkItem(markType, markId);
			MapModel instance = MapModel.Instance;
			int dungeonMapConfigId = instance.GetDungeonMapConfigId((markItem != null) ? markItem.MapId : instance.GetMarkMapConfigId(markId, markType));
			EMapGravityDirection emapGravityDirection = (markItem != null) ? markItem.MarkItemEntity.GamePlay.Gravity : instance.GetMarkMapGravity(markId, markType);
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
