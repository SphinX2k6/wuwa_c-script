using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks
{
	// Token: 0x020044A6 RID: 17574
	[NullableContext(1)]
	[Nullable(0)]
	public static class MarkItemUtil
	{
		// Token: 0x0602C5B6 RID: 181686 RVA: 0x00C788E0 File Offset: 0x00C76AE0
		[return: Nullable(2)]
		public static MarkItem Create([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<ConfigMarkCreateInfo, DynamicMarkCreateInfo, PlayerMarkCreateInfo> config, EMapType mapType, float markScale, UUIItem parent)
		{
			MarkItem markItem = null;
			if (config.IsT1)
			{
				return MarkItemUtil.CreateConfigMark(config.AsT1.MarkId, config.AsT1.MarkConfig, mapType, markScale, parent);
			}
			if (config.IsT2)
			{
				return MarkItemUtil.CreateDynamicMark(config.AsT2, mapType, markScale, parent);
			}
			if (config.IsT3)
			{
				markItem = new PlayerMarkItem(parent, config.AsT3, mapType, markScale, ETrackSource.MapMark);
				MarkItemUtil.InitializeMarkItem(markItem);
				return markItem;
			}
			return markItem;
		}

		// Token: 0x0602C5B7 RID: 181687 RVA: 0x00C7895C File Offset: 0x00C76B5C
		[return: Nullable(2)]
		public static ConfigMarkItem CreateConfigMark(int markId, MapMark markConfig, EMapType mapType, float markScale, UUIItem parent)
		{
			ConfigMarkItem configMarkItem;
			switch (markConfig.ObjectType)
			{
			case 1:
				configMarkItem = new AreaMarkItem(markId, markConfig, parent, mapType, markScale, null);
				goto IL_31C;
			case 5:
			case 6:
				configMarkItem = new TeleportMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 7:
				configMarkItem = new EntityMarkItem(markId, markConfig, parent, global::Vector.Create((double)markConfig.MarkVector.Value.X, (double)markConfig.MarkVector.Value.Y, (double)markConfig.MarkVector.Value.Z), mapType, markScale);
				goto IL_31C;
			case 8:
				configMarkItem = new MingSuNpcMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 9:
				configMarkItem = null;
				goto IL_31C;
			case 10:
				configMarkItem = new SceneGameplayMarkItem(markId, markConfig, parent, mapType, markScale, null);
				goto IL_31C;
			case 13:
				configMarkItem = new ParkourMarkItem(markId, markConfig, parent, mapType, markScale, null);
				goto IL_31C;
			case 19:
				configMarkItem = new FixedSceneGameplayMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 20:
				configMarkItem = new LandscapeMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 24:
				configMarkItem = new CorniceMeetingMarkItem(markId, markConfig, parent, mapType, markScale, null);
				goto IL_31C;
			case 25:
				configMarkItem = new PunishReportMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 26:
				configMarkItem = new CaveHoleMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 27:
				configMarkItem = new DreamLinkRunMarkItem(markId, markConfig, parent, mapType, markScale, null);
				goto IL_31C;
			case 28:
				configMarkItem = new LevelPlayReportMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 39:
				configMarkItem = new HonamiScanMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.Instance);
				goto IL_31C;
			case 42:
				configMarkItem = new GreatSwordChallengeMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 43:
				configMarkItem = new InfrRoadMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 44:
				configMarkItem = new InfrObservatoryMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 45:
				configMarkItem = new PhantomArenaNpcMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 46:
				configMarkItem = new FloatLightForestMarkItem(markId, markConfig, parent, mapType, markScale, null);
				goto IL_31C;
			case 47:
				configMarkItem = new VillageInfrMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 48:
				configMarkItem = new VillageInfrTreeMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 49:
				configMarkItem = new SheriffAnomalyMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 50:
				configMarkItem = new SheriffQuestMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			case 51:
				configMarkItem = new DollGrabMachineMarkItem(markId, markConfig, parent, mapType, markScale, ETrackSource.MapMark);
				goto IL_31C;
			}
			configMarkItem = new ConfigMarkItem(markId, markConfig, parent, mapType, markScale, null);
			IL_31C:
			if (configMarkItem != null)
			{
				MarkItemUtil.InitializeConfigMarkItem(configMarkItem);
			}
			return configMarkItem;
		}

		// Token: 0x0602C5B8 RID: 181688 RVA: 0x00C78C90 File Offset: 0x00C76E90
		[return: Nullable(2)]
		public static MarkItem CreateDynamicMark(DynamicMarkCreateInfo config, EMapType mapType, float markScale, UUIItem parent)
		{
			EMarkType markType = config.MarkType;
			ServerMarkItem serverMarkItem;
			switch (markType)
			{
			case EMarkType.Entity:
				break;
			case EMarkType.NPC:
			case EMarkType.SceneGameplay:
			case EMarkType.OtherPlayers:
			case EMarkType.Parkour:
			case (EMarkType)14:
			case EMarkType.FixedSceneGameplay:
			case EMarkType.LandscapeMark:
				goto IL_154;
			case EMarkType.Custom:
				serverMarkItem = new CustomMarkItem(config, parent, mapType, markScale);
				goto IL_15E;
			case EMarkType.Quest:
				serverMarkItem = new TaskMarkItem((QuestMarkCreateInfo)config, parent, mapType, markScale);
				goto IL_15E;
			case EMarkType.TemporaryTeleport:
				serverMarkItem = new TemporaryTeleportMarkItem(config, parent, mapType, markScale);
				goto IL_15E;
			case EMarkType.SoundBox:
			case EMarkType.CalmingWindBell:
				serverMarkItem = new SoundBoxMarkItem(config, parent, mapType, markScale);
				goto IL_15E;
			case EMarkType.TreasureBoxDetector:
				serverMarkItem = new TreasureBoxDetectorMarkItem(config, parent, mapType, markScale);
				goto IL_15E;
			case EMarkType.TreasureBox:
				serverMarkItem = new TreasureBoxMarkItem(config, parent, mapType, markScale);
				goto IL_15E;
			case EMarkType.EnrichmentArea:
				serverMarkItem = new EnrichmentAreaItem(config, parent, mapType, markScale);
				goto IL_15E;
			case EMarkType.EnrichmentCollectProduct:
				serverMarkItem = new EnrichmentCollectProductItem(config, parent, mapType, markScale);
				goto IL_15E;
			default:
				switch (markType)
				{
				case EMarkType.FishingShip:
					serverMarkItem = new FishingShipMarkItem((FishingShipMarkCreateInfo)config, parent, mapType, markScale);
					goto IL_15E;
				case EMarkType.FishingPoint:
					serverMarkItem = new FishingPointMarkItem((FishingPointMarkCreateInfo)config, parent, mapType, markScale);
					goto IL_15E;
				case EMarkType.FishingCage:
				case EMarkType.FishingDock:
				case EMarkType.HonamiScan:
					goto IL_154;
				case EMarkType.MoraleExploreBox:
					break;
				case EMarkType.SightSpot:
				case EMarkType.FlyingHunter:
				case EMarkType.Frostbite:
					serverMarkItem = new TraceExploreEntityMarkItem(config, parent, mapType, markScale);
					goto IL_15E;
				case EMarkType.HonamiScanItem:
					serverMarkItem = new HonamiScanItemMarkItem(config, parent, mapType, markScale);
					goto IL_15E;
				default:
					goto IL_154;
				}
				break;
			}
			return MarkItemUtil.CreateDynamicEntityMark(config.MarkId.Value, config.MarkConfigId, parent, config.TrackTarget, mapType, markScale);
			IL_154:
			serverMarkItem = new ServerMarkItem(config, parent, mapType, markScale);
			IL_15E:
			MarkItemUtil.InitializeServerMarkItem(serverMarkItem);
			return serverMarkItem;
		}

		// Token: 0x0602C5B9 RID: 181689 RVA: 0x00C78E04 File Offset: 0x00C77004
		[return: Nullable(2)]
		public static EntityMarkItem CreateEntityMark(int markId, int markConfigId, UUIItem parent, TTrackTarget trackTarget, EMapType mapType, float markScale)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markConfigId);
			if (configMark == null)
			{
				return null;
			}
			EntityMarkItem entityMarkItem = new EntityMarkItem(markId, configMark.Value, parent, trackTarget, mapType, markScale);
			MarkItemUtil.InitializeMarkItem(entityMarkItem);
			return entityMarkItem;
		}

		// Token: 0x0602C5BA RID: 181690 RVA: 0x00C78E44 File Offset: 0x00C77044
		[return: Nullable(2)]
		public static DynamicEntityMarkItem CreateDynamicEntityMark(int markId, int markConfigId, UUIItem parent, TTrackTarget trackTarget, EMapType mapType, float markScale)
		{
			DynamicMapMark? dynamicConfigMark = MapConfig.Instance.GetDynamicConfigMark(markConfigId);
			if (dynamicConfigMark == null)
			{
				return null;
			}
			DynamicEntityMarkItem dynamicEntityMarkItem = new DynamicEntityMarkItem(markId, dynamicConfigMark.Value, parent, trackTarget, mapType, markScale);
			DynamicMarkCreateInfo mark = MapModel.Instance.GetMark((EMarkType)dynamicConfigMark.Value.ObjectType, markId);
			if (mark != null)
			{
				dynamicEntityMarkItem.OverrideMapId = new int?(mark.MapId);
			}
			MarkItemUtil.InitializeDynamicMarkItem(dynamicEntityMarkItem, (mark != null) ? mark.MapGravity : EMapGravityDirection.All, trackTarget);
			return dynamicEntityMarkItem;
		}

		// Token: 0x0602C5BB RID: 181691 RVA: 0x00C78EC0 File Offset: 0x00C770C0
		public static bool IsTrackPointedMarkInCurrentDungeon(ITrackData trackData, bool fallbackReturn = false)
		{
			ETrackSource trackSource = trackData.TrackSource;
			if (trackSource != ETrackSource.MapMark)
			{
				return trackSource != ETrackSource.Instance || MarkItemUtil.IsTrackPointedMarkInCurrentDungeonByInstance(trackData);
			}
			return MarkItemUtil.IsTrackPointedMarkInCurrentDungeonByMapMark(trackData, fallbackReturn);
		}

		// Token: 0x0602C5BC RID: 181692 RVA: 0x00C78EF0 File Offset: 0x00C770F0
		private static bool IsTrackPointedMarkInCurrentDungeonByMapMark(ITrackData trackData, bool fallbackReturn)
		{
			InstanceDungeon? instanceDungeon;
			int? num = (GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().MapConfigId) : null;
			if (trackData.Id <= 0)
			{
				DynamicMarkCreateInfo dynamicMarkInfoById = MapModel.Instance.GetDynamicMarkInfoById(trackData.Id);
				if (dynamicMarkInfoById == null || dynamicMarkInfoById.MapId <= 0)
				{
					return fallbackReturn;
				}
				if (dynamicMarkInfoById.MarkType == EMarkType.Quest)
				{
					return true;
				}
				int? num2 = num;
				int mapId = dynamicMarkInfoById.MapId;
				return num2.GetValueOrDefault() == mapId & num2 != null;
			}
			else
			{
				DynamicMarkCreateInfo dynamicMarkInfoById2 = MapModel.Instance.GetDynamicMarkInfoById(trackData.Id);
				if (dynamicMarkInfoById2 != null && dynamicMarkInfoById2.MapId > 0)
				{
					if (dynamicMarkInfoById2.MarkType == EMarkType.Quest)
					{
						return true;
					}
					int? num2 = num;
					int mapId = dynamicMarkInfoById2.MapId;
					return num2.GetValueOrDefault() == mapId & num2 != null;
				}
				else
				{
					MapMark? configMark = MapConfig.Instance.GetConfigMark(trackData.Id);
					if (configMark != null && configMark.Value.MapId > 0)
					{
						int? num2 = num;
						int mapId = configMark.Value.MapId;
						return num2.GetValueOrDefault() == mapId & num2 != null;
					}
					return fallbackReturn;
				}
			}
		}

		// Token: 0x0602C5BD RID: 181693 RVA: 0x00C7902C File Offset: 0x00C7722C
		private static bool IsTrackPointedMarkInCurrentDungeonByInstance(ITrackData trackData)
		{
			InstanceDungeon? instanceDungeon;
			int? num = (GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().Id) : null;
			if (num == null || trackData.TrackInstanceId == null)
			{
				return true;
			}
			DynamicMarkCreateInfo dynamicMarkInfoById = MapModel.Instance.GetDynamicMarkInfoById(trackData.Id);
			if (dynamicMarkInfoById != null && dynamicMarkInfoById.InstanceDungeonId != null && dynamicMarkInfoById.MarkType == EMarkType.Quest)
			{
				return true;
			}
			int? num2 = num;
			int? trackInstanceId = trackData.TrackInstanceId;
			return num2.GetValueOrDefault() == trackInstanceId.GetValueOrDefault() & num2 != null == (trackInstanceId != null);
		}

		// Token: 0x0602C5BE RID: 181694 RVA: 0x00C790E4 File Offset: 0x00C772E4
		public static bool IsHideTrackInView(ITrackData trackData)
		{
			if (trackData.MarkType.GetValueOrDefault() == EMarkType.Quest)
			{
				return false;
			}
			if (trackData.TrackHudEnable != null)
			{
				return !trackData.TrackHudEnable.Value;
			}
			return trackData.TrackSource == ETrackSource.MapMark;
		}

		// Token: 0x0602C5BF RID: 181695 RVA: 0x00C79130 File Offset: 0x00C77330
		[NullableContext(2)]
		public static bool CanShowTrackMark(ITrackData trackData)
		{
			return trackData != null && MarkItemUtil.IsTrackPointedMarkInCurrentDungeon(trackData, true) && !MarkItemUtil.IsHideTrackInView(trackData);
		}

		// Token: 0x0602C5C0 RID: 181696 RVA: 0x00C79149 File Offset: 0x00C77349
		private static void InitializeMarkItem(MarkItem markItem)
		{
			markItem.Initialize();
		}

		// Token: 0x0602C5C1 RID: 181697 RVA: 0x00C79154 File Offset: 0x00C77354
		private static void InitializeConfigMarkItem(ConfigMarkItem markItem)
		{
			markItem.Config = new MapMarkConfig(markItem.MarkConfig.Value);
			markItem.EntityId = new int?(markItem.MarkConfig.Value.EntityConfigId);
			markItem.Initialize();
		}

		// Token: 0x0602C5C2 RID: 181698 RVA: 0x00C791A1 File Offset: 0x00C773A1
		private static void InitializeServerMarkItem(ServerMarkItem markItem)
		{
			markItem.EntityId = new int?(markItem.EntityConfigId);
			markItem.Initialize();
		}

		// Token: 0x0602C5C3 RID: 181699 RVA: 0x00C791BC File Offset: 0x00C773BC
		private static void InitializeDynamicMarkItem(DynamicConfigMarkItem markItem, EMapGravityDirection gravity, TTrackTarget trackTarget)
		{
			markItem.Config = new DynamicMapMarkConfig(markItem.MarkConfig.Value);
			markItem.OverrideGravity = new EMapGravityDirection?(gravity);
			markItem.Initialize();
			TTrackTarget_Int ttrackTarget_Int = trackTarget as TTrackTarget_Int;
			if (ttrackTarget_Int != null)
			{
				markItem.EntityId = new int?(ttrackTarget_Int.Value);
			}
		}
	}
}
