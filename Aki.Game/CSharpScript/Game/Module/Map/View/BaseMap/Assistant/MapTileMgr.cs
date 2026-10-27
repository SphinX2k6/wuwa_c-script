using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.PathLine.FogLine;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.LevelConditions;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Misc;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.RegionalTerminal;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x0200549B RID: 21659
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTileMgr
	{
		// Token: 0x06037541 RID: 226625 RVA: 0x00D2277C File Offset: 0x00D2097C
		public MapTileMgr(MapTileMgrParams tileMgrParams)
		{
			this.MapVersion = tileMgrParams.MapVersion;
			if (this.MapVersion == 2)
			{
				this.DtAreaIDToMaskCode = ResourceSystem.Instance.Load<UDataTable>("/Game/Aki/Data/PathLine/FogLine/DT_AreaToMaskCode.DT_AreaToMaskCode", "Ui.MapUi");
				this.DtFogAreaID = ResourceSystem.Instance.Load<UDataTable>("/Game/Aki/Data/PathLine/FogLine/DT_FogToArea.DT_FogToArea", "Ui.MapUi");
			}
			this.MapRootItem = tileMgrParams.MapRootItem;
			this.LineTraceItemList = new TArray<UUIItem>
			{
				this.MapRootItem
			};
			this.TileContainer = tileMgrParams.TileContainer;
			this.TileTexture = tileMgrParams.TileTexture;
			this.SubMapContainer = tileMgrParams.SubMapContainer;
			this.SubMapContainerActive = false;
			this.SubMapTexture = tileMgrParams.SubMapTexture;
			UUIItem subMapContainer = tileMgrParams.SubMapContainer;
			object obj;
			if (subMapContainer == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = subMapContainer.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
			}
			this.SubMapContainerTween = (obj as ULGUIPlayTweenComponent);
			UUIItem subMapContainer2 = tileMgrParams.SubMapContainer;
			object obj2;
			if (subMapContainer2 == null)
			{
				obj2 = null;
			}
			else
			{
				AActor owner2 = subMapContainer2.GetOwner();
				obj2 = ((owner2 != null) ? owner2.GetComponentByClass(UUISprite.StaticClass()) : null);
			}
			UUISprite uuisprite = obj2 as UUISprite;
			this.SubMapContainerOriginalAlpha = ((uuisprite != null) ? uuisprite.GetAlpha() : 0f);
			this.SubMapMask = tileMgrParams.SubMapMask;
			UUIItem subMapMask = this.SubMapMask;
			if (subMapMask != null)
			{
				subMapMask.SetWidth(850f);
			}
			UUIItem subMapMask2 = this.SubMapMask;
			if (subMapMask2 != null)
			{
				subMapMask2.SetHeight(850f);
			}
			this.TileTexture.SetColor(this.FogDefaultColor);
			this.MapType = tileMgrParams.MapType;
			this.MapId = tileMgrParams.MapId;
			this.InstanceDungeonId = tileMgrParams.InstanceDungeonId;
			if (tileMgrParams.PreloadTiles != null)
			{
				this.PreloadMapTiles = tileMgrParams.PreloadTiles;
			}
			this.MapGravity = tileMgrParams.Gravity.GetValueOrDefault(EMapGravityDirection.Down);
			this.MapTileParams = tileMgrParams;
		}

		// Token: 0x06037542 RID: 226626 RVA: 0x00D22A28 File Offset: 0x00D20C28
		private void OnCreate()
		{
			this.MapTiles = new List<UUITextureBase>();
			this.MapTileItems = new List<MapTileItem>();
			this.SubMapTiles = new List<UUITextureBase>();
			this.SubMapFadeInTiles = new List<UUITextureBase>();
			this.TextureAssets = new List<Dictionary<string, string>>();
			this.MapOffset = new Vector4(0f, 0f, 0f, 0f);
			this.FakeOffset = 0f;
			this.CreateMiniMapMultiMapTexToArea();
		}

		// Token: 0x06037543 RID: 226627 RVA: 0x00D22A9C File Offset: 0x00D20C9C
		public void Initialize()
		{
			this.OnCreate();
			this.AddEventListener();
		}

		// Token: 0x06037544 RID: 226628 RVA: 0x00D22AAA File Offset: 0x00D20CAA
		private void CreateMiniMapMultiMapTexToArea()
		{
			this.MiniMapMultiMapTexToArea.Clear();
			MapConfig.Instance.GetAllSubMapConfig().ForEach(delegate(MultiMap config)
			{
				foreach (string key in config.MiniMapTilePathIter())
				{
					int[] value = config.GetAreaArray().Select(delegate(int areaId)
					{
						Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
						return AreaModel.Instance.GetAreaId(areaInfo.Value, new EAreaLevel?(EAreaLevel.FirstLevel));
					}).ToArray<int>();
					this.MiniMapMultiMapTexToArea[key] = value;
				}
			});
		}

		// Token: 0x06037545 RID: 226629 RVA: 0x00D22AD4 File Offset: 0x00D20CD4
		public UniTask OnChangeTilesAsync(int mapId, int instanceId, EMapGravityDirection gravity)
		{
			MapTileMgr.<OnChangeTilesAsync>d__74 <OnChangeTilesAsync>d__;
			<OnChangeTilesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnChangeTilesAsync>d__.<>4__this = this;
			<OnChangeTilesAsync>d__.mapId = mapId;
			<OnChangeTilesAsync>d__.instanceId = instanceId;
			<OnChangeTilesAsync>d__.gravity = gravity;
			<OnChangeTilesAsync>d__.<>1__state = -1;
			<OnChangeTilesAsync>d__.<>t__builder.Start<MapTileMgr.<OnChangeTilesAsync>d__74>(ref <OnChangeTilesAsync>d__);
			return <OnChangeTilesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037546 RID: 226630 RVA: 0x00D22B30 File Offset: 0x00D20D30
		public UniTask RebuildTilesAsync()
		{
			MapTileMgr.<RebuildTilesAsync>d__75 <RebuildTilesAsync>d__;
			<RebuildTilesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RebuildTilesAsync>d__.<>4__this = this;
			<RebuildTilesAsync>d__.<>1__state = -1;
			<RebuildTilesAsync>d__.<>t__builder.Start<MapTileMgr.<RebuildTilesAsync>d__75>(ref <RebuildTilesAsync>d__);
			return <RebuildTilesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037547 RID: 226631 RVA: 0x00D22B73 File Offset: 0x00D20D73
		private void RecycleMapTiles()
		{
			List<UUITextureBase> mapTiles = this.MapTiles;
			if (mapTiles != null)
			{
				mapTiles.ForEach(delegate(UUITextureBase textureCom)
				{
					textureCom.SetTexture(null);
					if (this.MapVersion == 2)
					{
						textureCom.SetCustomMaterialTextureParameter(MapTileMgr.FOG_TEXTURE_1, null);
						textureCom.SetCustomMaterialTextureParameter(MapTileMgr.FOG_TEXTURE_2, null);
						textureCom.SetCustomMaterialTextureParameter(MapTileMgr.HD_TEXTURE_NAME, null);
						textureCom.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_1, new FLinearColor(0f, 0f, 0f, 0f));
						textureCom.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_2, new FLinearColor(0f, 0f, 0f, 0f));
					}
					else
					{
						textureCom.SetCustomMaterialTextureParameter(MapTileMgr.FOG_TEXTURE_NAME, null);
						textureCom.SetCustomMaterialTextureParameter(MapTileMgr.HD_TEXTURE_NAME, null);
					}
					if (this.TileTexture != textureCom)
					{
						this.RecycleMapTile(textureCom);
					}
				});
			}
			this.MapTiles = null;
		}

		// Token: 0x06037548 RID: 226632 RVA: 0x00D22B99 File Offset: 0x00D20D99
		private void RecycleMapTile(UUITextureBase mapTile)
		{
			mapTile.SetUIActive(false);
			this.MapTilePool.Add(mapTile);
		}

		// Token: 0x06037549 RID: 226633 RVA: 0x00D22BB0 File Offset: 0x00D20DB0
		private UUITextureBase GetOrCreateMapTile()
		{
			if (this.MapTilePool.Count > 0)
			{
				UUITextureBase uuitextureBase = this.MapTilePool[0];
				this.MapTilePool.RemoveAt(0);
				uuitextureBase.SetUIActive(true);
				return uuitextureBase;
			}
			return LguiUtil.Instance.CopyItem(this.TileTexture, this.TileContainer) as UUITextureBase;
		}

		// Token: 0x0603754A RID: 226634 RVA: 0x00D22C08 File Offset: 0x00D20E08
		private void ResetRefs()
		{
			if (this.TextureAssets != null)
			{
				this.TextureAssets.Clear();
				this.TextureAssets = null;
			}
			this.UnregisterSubMapEndCb();
			List<MapTileItem> mapTileItems = this.MapTileItems;
			if (mapTileItems != null)
			{
				mapTileItems.ForEach(delegate(MapTileItem mapTileItem)
				{
					mapTileItem.ReleaseLoadHandle();
				});
			}
			List<MapTileItem> mapTileItems2 = this.MapTileItems;
			if (mapTileItems2 != null)
			{
				mapTileItems2.Clear();
			}
			UUIItem subMapContainer = this.SubMapContainer;
			if (subMapContainer != null)
			{
				subMapContainer.SetAlpha(this.SubMapContainerOriginalAlpha);
			}
			UUIItem subMapContainer2 = this.SubMapContainer;
			if (subMapContainer2 != null)
			{
				subMapContainer2.SetUIActive(false);
			}
			this.SubMapContainerActive = false;
			this.BorderItems.ForEach(delegate(UUIItem borderItem)
			{
				AActor owner = borderItem.GetOwner();
				if (owner == null)
				{
					return;
				}
				owner.K2_DestroyActor();
			});
			this.BorderItems.Clear();
			this.ToHandleUnlockFogId = -1;
		}

		// Token: 0x0603754B RID: 226635 RVA: 0x00D22CE4 File Offset: 0x00D20EE4
		public void Dispose()
		{
			this.RemoveEventListener();
			this.ResetRefs();
			this.RecycleMapTiles();
			List<UUITextureBase> mapTilePool = this.MapTilePool;
			if (mapTilePool != null)
			{
				mapTilePool.ForEach(delegate(UUITextureBase textureCom)
				{
					if (this.TileTexture != textureCom)
					{
						AActor owner = textureCom.GetOwner();
						if (owner == null)
						{
							return;
						}
						owner.K2_DestroyActor();
					}
				});
			}
			List<UUITextureBase> subMapTiles = this.SubMapTiles;
			if (subMapTiles != null)
			{
				subMapTiles.ForEach(delegate(UUITextureBase textureCom)
				{
					textureCom.SetTexture(null);
					if (this.SubMapTexture != textureCom)
					{
						AActor owner = textureCom.GetOwner();
						if (owner == null)
						{
							return;
						}
						owner.K2_DestroyActor();
					}
				});
			}
			RegionalTerminalModel.Instance.CurrentAreaMapGroupId = 0;
			List<UUITextureBase> mapTilePool2 = this.MapTilePool;
			if (mapTilePool2 != null)
			{
				mapTilePool2.Clear();
			}
			this.MapTiles = null;
			this.MapTileItems = null;
			this.SubMapTiles = null;
			this.SubMapTileResourceIds.Clear();
			this.SubMapFadeInTiles = null;
			this.Destroy = true;
		}

		// Token: 0x0603754C RID: 226636 RVA: 0x00D22D88 File Offset: 0x00D20F88
		private void AddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.MapOpenFogChange, new Action<int>(this.OnMapOpenFogChange));
			EventSystem.Instance.Add<IReadOnlyDictionary<int, bool>>(EEventName.MapOpenFogFullUpdate, new Action<IReadOnlyDictionary<int, bool>>(this.OnMapFogFullUpdate));
			if (this.MapType == EMapType.MiniMap)
			{
				EventSystem.Instance.Add(EEventName.MiniMapForceUpdate, new Action(this.ForceUpdateMiniMapTiles));
				EventSystem.Instance.Add(EEventName.MultiMapUnlockChanged, new Action(this.OnMultiMapUnlockChanged));
			}
			this.ConditionCallBack = new ConditionPassCallback(new TConditionPassCallback(this.RefreshMapBorder), null);
			IReadOnlyList<MapBorder> mapBorderConfigList = MapConfig.Instance.GetMapBorderConfigList();
			if (mapBorderConfigList != null)
			{
				foreach (MapBorder mapBorder in mapBorderConfigList)
				{
					int conditionId = mapBorder.ConditionId;
					if (conditionId > 0)
					{
						LevelConditionRegistry.Instance.RegisterConditionGroup(conditionId, this.ConditionCallBack);
					}
				}
			}
		}

		// Token: 0x0603754D RID: 226637 RVA: 0x00D22E88 File Offset: 0x00D21088
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MapOpenFogChange, new Action<int>(this.OnMapOpenFogChange));
			EventSystem.Instance.Remove(EEventName.MapOpenFogFullUpdate, new Action<IReadOnlyDictionary<int, bool>>(this.OnMapFogFullUpdate));
			if (this.MapType == EMapType.MiniMap)
			{
				EventSystem.Instance.Remove(EEventName.MiniMapForceUpdate, new Action(this.ForceUpdateMiniMapTiles));
				EventSystem.Instance.Remove(EEventName.MultiMapUnlockChanged, new Action(this.OnMultiMapUnlockChanged));
			}
			IReadOnlyList<MapBorder> mapBorderConfigList = MapConfig.Instance.GetMapBorderConfigList();
			if (mapBorderConfigList != null && this.ConditionCallBack != null)
			{
				foreach (MapBorder mapBorder in mapBorderConfigList)
				{
					int conditionId = mapBorder.ConditionId;
					if (conditionId > 0)
					{
						LevelConditionRegistry.Instance.UnRegisterConditionGroup(conditionId, this.ConditionCallBack);
					}
				}
			}
		}

		// Token: 0x0603754E RID: 226638 RVA: 0x00D22F78 File Offset: 0x00D21178
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UUITextureBase> GetMapTiles()
		{
			return this.MapTiles;
		}

		// Token: 0x0603754F RID: 226639 RVA: 0x00D22F80 File Offset: 0x00D21180
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MapTileItem> GetMapTileItems()
		{
			return this.MapTileItems;
		}

		// Token: 0x06037550 RID: 226640 RVA: 0x00D22F88 File Offset: 0x00D21188
		public unsafe void OnMapSetUp()
		{
			if (this.MapType == EMapType.MiniMap && !WorldMapConfig.Instance.IsMapInWorld(this.MapId))
			{
				this.IsTileShow = false;
				return;
			}
			this.IsTileShow = true;
			this.SetUpFog();
			this.CreateMapTile();
			IReadOnlyList<MultiMapAreaConfig> multiMapAreaConfigList = MapConfig.Instance.GetMultiMapAreaConfigList();
			this.MultiMapAreaConfigCache.Clear();
			if (multiMapAreaConfigList != null)
			{
				foreach (MultiMapAreaConfig value in multiMapAreaConfigList)
				{
					if (value.MapConfigId == this.MapId && value.GravityFlip == (int)this.MapGravity)
					{
						this.MultiMapAreaConfigCache[value.Block] = value;
					}
				}
			}
			List<MultiMap> allSubMapConfig = MapConfig.Instance.GetAllSubMapConfig();
			this.MultiMapAreaCache.Clear();
			foreach (MultiMap multiMap in allSubMapConfig)
			{
				if (multiMap.MapId == this.MapId)
				{
					Span<int> areaBytes = multiMap.GetAreaBytes();
					for (int i = 0; i < areaBytes.Length; i++)
					{
						int key = *areaBytes[i];
						this.MultiMapAreaCache[key] = multiMap.Id;
					}
				}
			}
			this.CurrentFocusRow = int.MaxValue;
			this.CurrentFocusColumn = int.MaxValue;
			AkiMap? akiMapConfig = WorldMapConfig.Instance.GetAkiMapConfig(this.MapId, true);
			if (akiMapConfig != null)
			{
				float num = (float)(150 / akiMapConfig.GetValueOrDefault().LittleMapDefaultScale);
				UUIItem subMapMask = this.SubMapMask;
				if (subMapMask != null)
				{
					subMapMask.SetWidth(850f * num);
				}
				UUIItem subMapMask2 = this.SubMapMask;
				if (subMapMask2 != null)
				{
					subMapMask2.SetHeight(850f * num);
				}
			}
			int? areaMapGroupIdByInstanceId = RegionalTerminalModel.Instance.GetAreaMapGroupIdByInstanceId(this.InstanceDungeonId);
			if (areaMapGroupIdByInstanceId != null)
			{
				RegionalTerminalModel.Instance.CurrentAreaMapGroupId = areaMapGroupIdByInstanceId.Value;
				this.UpdateCurrentAreaMapGroupIdSwitch = false;
				return;
			}
			RegionalTerminalModel.Instance.CurrentAreaMapGroupId = 0;
			this.UpdateCurrentAreaMapGroupIdSwitch = true;
		}

		// Token: 0x06037551 RID: 226641 RVA: 0x00D231AC File Offset: 0x00D213AC
		private string TryTransformTilePath(string inPath, string targetPath)
		{
			if (this.MapType == EMapType.MiniMap)
			{
				return targetPath;
			}
			return inPath;
		}

		// Token: 0x06037552 RID: 226642 RVA: 0x00D231BC File Offset: 0x00D213BC
		private void SetUpFog()
		{
			this.OpenFogSet = new HashSet<int>();
			Dictionary<int, bool> allUnlockedFogs = MapModel.Instance.GetAllUnlockedFogs();
			if (allUnlockedFogs != null)
			{
				foreach (KeyValuePair<int, bool> keyValuePair in allUnlockedFogs)
				{
					int num;
					bool flag;
					keyValuePair.Deconstruct(out num, out flag);
					int item = num;
					this.OpenFogSet.Add(item);
				}
			}
		}

		// Token: 0x06037553 RID: 226643 RVA: 0x00D23238 File Offset: 0x00D21438
		[NullableContext(2)]
		public static bool ShouldLoadTileByFilter(int[] tileAreaList, IReadOnlyList<int> displayAreaList)
		{
			return displayAreaList == null || tileAreaList == null || tileAreaList.Length == 0 || tileAreaList.Any(new Func<int, bool>(displayAreaList.Contains<int>));
		}

		// Token: 0x06037554 RID: 226644 RVA: 0x00D23258 File Offset: 0x00D21458
		private void OnCreateTextureAssets()
		{
			IReadOnlyList<FogTextureConfig> allTileConfigByMapId = MapConfig.Instance.GetAllTileConfigByMapId(this.MapId);
			List<Dictionary<string, string>> textureAssets = this.TextureAssets;
			if (textureAssets != null)
			{
				textureAssets.Clear();
			}
			this.TextureAssets = new List<Dictionary<string, string>>();
			IReadOnlyList<int> displayAreaList = (this.MapType == EMapType.WorldMap) ? WorldMapModel.Instance.GetDisplayAreaList(this.MapId) : null;
			if (allTileConfigByMapId != null)
			{
				foreach (FogTextureConfig fogTextureConfig in allTileConfigByMapId)
				{
					if (!StringUtils.IsEmpty(fogTextureConfig.MapTilePath) && this.MapGravity == (EMapGravityDirection)fogTextureConfig.GravityFlip && MapTileMgr.ShouldLoadTileByFilter(fogTextureConfig.GetTileLoadFilterByAreaArray(), displayAreaList))
					{
						int num = MapModel.Instance.CheckUnlockMapBlockIds(fogTextureConfig.Block, this.MapGravity, this.MapId);
						string[] array = fogTextureConfig.MapTilePath.Split('/', StringSplitOptions.None);
						string value = array[array.Length - 1];
						string inPath = "";
						string targetPath = "";
						if (num != 0)
						{
							BlockSwitch? unlockMapTileConfigById = MapConfig.Instance.GetUnlockMapTileConfigById(num);
							if (unlockMapTileConfigById != null)
							{
								inPath = MapConfig.Instance.GetUiResourcePathById(unlockMapTileConfigById.Value.MapTilePath);
								targetPath = MapConfig.Instance.GetUiResourcePathById(unlockMapTileConfigById.Value.MiniMapTilePath);
							}
						}
						else
						{
							inPath = MapConfig.Instance.GetUiResourcePathById(fogTextureConfig.MapTilePath);
							targetPath = MapConfig.Instance.GetUiResourcePathById(fogTextureConfig.MiniMapTilePath);
						}
						string uiResourcePathById = MapConfig.Instance.GetUiResourcePathById(fogTextureConfig.HdMapTilePath);
						string value2 = this.TryTransformTilePath(inPath, targetPath);
						string uiResourcePathById2 = MapConfig.Instance.GetUiResourcePathById(fogTextureConfig.FogTilePath);
						string uiResourcePathById3 = MapConfig.Instance.GetUiResourcePathById(fogTextureConfig.MiniFogTilePath);
						string value3 = this.TryTransformTilePath(uiResourcePathById2, uiResourcePathById3);
						List<Dictionary<string, string>> textureAssets2 = this.TextureAssets;
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						dictionary["MapTilePath"] = value2;
						dictionary["HdMapTilePath"] = uiResourcePathById;
						dictionary["FogTilePath"] = value3;
						dictionary["MapTileName"] = value;
						textureAssets2.Add(dictionary);
					}
				}
			}
		}

		// Token: 0x06037555 RID: 226645 RVA: 0x00D23484 File Offset: 0x00D21684
		[NullableContext(0)]
		private unsafe ValueTuple<int, int> OnCalculateTileNum()
		{
			this.OnCalTotalTileNum();
			int num = 0;
			int num2;
			int num3;
			Span<UUITextureBase> span;
			int num4;
			if (this.MapType == EMapType.MiniMap)
			{
				num2 = 4;
				List<UUITextureBase> subMapTiles = this.SubMapTiles;
				if (subMapTiles != null)
				{
					subMapTiles.Clear();
				}
				num3 = 1;
				List<UUITextureBase> list = new List<UUITextureBase>(num3);
				CollectionsMarshal.SetCount<UUITextureBase>(list, num3);
				span = CollectionsMarshal.AsSpan<UUITextureBase>(list);
				num4 = 0;
				*span[num4] = this.SubMapTexture;
				this.SubMapTiles = list;
				for (int i = 1; i < num2; i++)
				{
					UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.SubMapTexture, this.SubMapContainer);
					this.SubMapTiles.Add(uuiitem as UUITextureBase);
				}
			}
			else
			{
				num = this.TileNum.MaxX - this.TileNum.MinX + 1 + 6;
				int num5 = this.TileNum.MaxY - this.TileNum.MinY + 1 + 6;
				num2 = num * num5;
			}
			List<UUITextureBase> mapTiles = this.MapTiles;
			if (mapTiles != null)
			{
				mapTiles.Clear();
			}
			this.TileTexture.SetUIActive(true);
			num4 = 1;
			List<UUITextureBase> list2 = new List<UUITextureBase>(num4);
			CollectionsMarshal.SetCount<UUITextureBase>(list2, num4);
			span = CollectionsMarshal.AsSpan<UUITextureBase>(list2);
			num3 = 0;
			*span[num3] = this.TileTexture;
			this.MapTiles = list2;
			List<MapTileItem> mapTileItems = this.MapTileItems;
			if (mapTileItems != null)
			{
				mapTileItems.Clear();
			}
			this.MapTileItems = new List<MapTileItem>();
			for (int j = 1; j < num2; j++)
			{
				UUITextureBase orCreateMapTile = this.GetOrCreateMapTile();
				this.MapTiles.Add(orCreateMapTile);
			}
			return new ValueTuple<int, int>(num2, num);
		}

		// Token: 0x06037556 RID: 226646 RVA: 0x00D235F3 File Offset: 0x00D217F3
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Positive",
			"Negative"
		})]
		private static ValueTuple<int, int> OriginAnchoredCount(int max, int min)
		{
			return new ValueTuple<int, int>(Math.Max(max, -1), 1 - Math.Min(min, 1));
		}

		// Token: 0x06037557 RID: 226647 RVA: 0x00D2360C File Offset: 0x00D2180C
		private void OnSetupDraggableParams(ITileNum tileNum)
		{
			ValueTuple<int, int> valueTuple = MapTileMgr.OriginAnchoredCount(tileNum.MaxX, tileNum.MinX);
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			ValueTuple<int, int> valueTuple2 = MapTileMgr.OriginAnchoredCount(tileNum.MaxY, tileNum.MinY);
			int item3 = valueTuple2.Item1;
			int item4 = valueTuple2.Item2;
			int num = Math.Max(item, item2);
			int num2 = Math.Max(item3, item4);
			this.MapRootItem.SetWidth((float)(num * 2 * 850));
			this.MapRootItem.SetHeight((float)(num2 * 2 * 850));
			this.MapOffset = new Vector4((float)(Math.Max(0, item - item2) * 850 * 2), (float)(Math.Max(0, item2 - item) * 850 * 2), (float)(Math.Max(0, item4 - item3) * 850 * 2), (float)(Math.Max(0, item3 - item4) * 850 * 2));
			this.FakeOffset = 2550f;
			if (this.MapType == EMapType.WorldMap && WorldMapModel.Instance.GetDisplayAreaList(this.MapId) != null)
			{
				this.UpdateDraggableParams(tileNum);
			}
		}

		// Token: 0x06037558 RID: 226648 RVA: 0x00D23714 File Offset: 0x00D21914
		private void CreateMapTile()
		{
			MapTileMgr.<>c__DisplayClass93_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass93_0();
			CS$<>8__locals1.<>4__this = this;
			this.OnCreateTextureAssets();
			int item = this.OnCalculateTileNum().Item2;
			this.CurrentColumnNum = item;
			Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
			CS$<>8__locals1.currentMapId = this.MapId;
			foreach (Dictionary<string, string> dictionary2 in this.TextureAssets)
			{
				ValueTuple<int, int> positionKeyByTileName = this.GetPositionKeyByTileName(dictionary2["MapTileName"]);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (this.MapVersion == 2)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
					defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.currentMapId);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
					string rowName = defaultInterpolatedStringHandler.ToStringAndClear();
					S_FogToAreaIDs dataTableRow = DataTableUtil.GetDataTableRow<S_FogToAreaIDs>(this.DtFogAreaID, rowName);
					string value = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2";
					if (this.MapType == EMapType.MiniMap)
					{
						value = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2Mini";
					}
					if (dataTableRow != null)
					{
						if (dataTableRow.IsFogP1)
						{
							Dictionary<string, string> dictionary3 = dictionary2;
							string key = "FogTilePath";
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 7);
							defaultInterpolatedStringHandler.AppendFormatted(value);
							defaultInterpolatedStringHandler.AppendLiteral("/T_FogTiles_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.currentMapId);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
							defaultInterpolatedStringHandler.AppendLiteral("_UI_p1.T_FogTiles_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.currentMapId);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
							defaultInterpolatedStringHandler.AppendLiteral("_UI_p1");
							dictionary3[key] = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						if (dataTableRow.IsFogP2)
						{
							Dictionary<string, string> dictionary4 = dictionary2;
							string key2 = "FogTilePath2";
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 7);
							defaultInterpolatedStringHandler.AppendFormatted(value);
							defaultInterpolatedStringHandler.AppendLiteral("/T_FogTiles_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.currentMapId);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
							defaultInterpolatedStringHandler.AppendLiteral("_UI_p2.T_FogTiles_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.currentMapId);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
							defaultInterpolatedStringHandler.AppendLiteral("_UI_p2");
							dictionary4[key2] = defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
				}
				Dictionary<string, Dictionary<string, string>> dictionary5 = dictionary;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
				dictionary5[defaultInterpolatedStringHandler.ToStringAndClear()] = dictionary2;
			}
			Vector2D vector2D = Vector2D.Create();
			for (int i = 0; i < this.MapTiles.Count; i++)
			{
				MapTileMgr.<>c__DisplayClass93_1 CS$<>8__locals2 = new MapTileMgr.<>c__DisplayClass93_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.mapTile = this.MapTiles[i];
				CS$<>8__locals2.mapTile.SetWidth(850f);
				CS$<>8__locals2.mapTile.SetHeight(850f);
				if (this.MapVersion == 2)
				{
					CS$<>8__locals2.mapTile.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_1, new FLinearColor(0f, 0f, 0f, 0f));
					CS$<>8__locals2.mapTile.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_2, new FLinearColor(0f, 0f, 0f, 0f));
				}
				if (this.MapType == EMapType.MiniMap)
				{
					this.UpdateSingleTileOpenArea(CS$<>8__locals2.mapTile, null, 0);
				}
				else
				{
					ValueTuple<int, int> tilePositionByIndex = this.GetTilePositionByIndex(i);
					CS$<>8__locals2.x = tilePositionByIndex.Item1;
					CS$<>8__locals2.y = tilePositionByIndex.Item2;
					vector2D.Set((double)(((float)CS$<>8__locals2.x - 0.5f) * 850f), (double)(((float)CS$<>8__locals2.y - 0.5f) * 850f));
					CS$<>8__locals2.mapTile.SetAnchorOffset(vector2D.ToUeVector2D(false));
					Dictionary<string, Dictionary<string, string>> dictionary6 = dictionary;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals2.x);
					defaultInterpolatedStringHandler.AppendLiteral("_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals2.y);
					if (dictionary6.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out CS$<>8__locals2.assetData))
					{
						CS$<>8__locals2.mapTile.SetCustomMaterialScalarParameter(MapTileMgr.HD_SCALAR_NAME, 0f);
						MapTileItem item2 = new MapTileItem(new MapTileCreateParam
						{
							TileX = CS$<>8__locals2.x,
							TileY = CS$<>8__locals2.y,
							AnchorOffset = vector2D,
							LoadMapTileCallBack = new Action<UTexture>(CS$<>8__locals2.<CreateMapTile>g__LoadCallback|0),
							AssetData = CS$<>8__locals2.assetData,
							FogDefaultColor = this.FogDefaultColor,
							MapType = this.MapType,
							MapTile = CS$<>8__locals2.mapTile,
							MapId = CS$<>8__locals2.CS$<>8__locals1.currentMapId
						});
						this.MapTileItems.Add(item2);
					}
				}
			}
			if (this.MapType == EMapType.MiniMap)
			{
				return;
			}
			this.OnSetupDraggableParams(this.TileNum);
		}

		// Token: 0x06037559 RID: 226649 RVA: 0x00D23C98 File Offset: 0x00D21E98
		[NullableContext(0)]
		private ValueTuple<int, int> GetTilePositionByIndex(int index)
		{
			int num = (int)Math.Ceiling((double)(index + 1) / (double)this.CurrentColumnNum);
			int item = index - (num - 1) * this.CurrentColumnNum + this.TileNum.MinX - 3;
			num = -(num - 1) + this.TileNum.MaxY + 3;
			return new ValueTuple<int, int>(item, num);
		}

		// Token: 0x0603755A RID: 226650 RVA: 0x00D23CEC File Offset: 0x00D21EEC
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"X",
			"Y"
		})]
		private ValueTuple<int, int> GetPositionKeyByTileName([Nullable(1)] string textureName)
		{
			string[] array = textureName.Split('_', StringSplitOptions.None);
			int item = UKismetStringLibrary.Conv_StringToInt(array[2]);
			int item2 = UKismetStringLibrary.Conv_StringToInt(array[3]);
			return new ValueTuple<int, int>(item, item2);
		}

		// Token: 0x0603755B RID: 226651 RVA: 0x00D23D1C File Offset: 0x00D21F1C
		private void LoadSingleFogTile(UUITextureBase mapTileItem, string fogTilePath, [Nullable(2)] TSingleTileLoadedCallBack singleTileLoadedCallback = null)
		{
			MapTileMgr.<>c__DisplayClass96_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass96_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.singleTileLoadedCallback = singleTileLoadedCallback;
			CS$<>8__locals1.tileItem = mapTileItem;
			this.LoadAndSetSingleFogTile(fogTilePath, new Action<UTexture, string>(CS$<>8__locals1.<LoadSingleFogTile>g__LoadCallback|0));
		}

		// Token: 0x0603755C RID: 226652 RVA: 0x00D23D58 File Offset: 0x00D21F58
		private void LoadSingleFogTileV2(UUITextureBase mapTileItem, string fogTilePath, int part, [Nullable(2)] TSingleTileLoadedCallBack singleTileLoadedCallback = null)
		{
			MapTileMgr.<>c__DisplayClass97_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass97_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.part = part;
			CS$<>8__locals1.singleTileLoadedCallback = singleTileLoadedCallback;
			CS$<>8__locals1.tileItem = mapTileItem;
			this.LoadAndSetSingleFogTile(fogTilePath, new Action<UTexture, string>(CS$<>8__locals1.<LoadSingleFogTileV2>g__LoadCallback|0));
		}

		// Token: 0x0603755D RID: 226653 RVA: 0x00D23D9C File Offset: 0x00D21F9C
		private void LoadMultiMapSingleFogTile(UUITextureBase mapTileItem, string fogTilePath, [Nullable(2)] TSingleTileLoadedCallBack singleTileLoadedCallback = null, int part = 1)
		{
			MapTileMgr.<>c__DisplayClass98_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass98_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.part = part;
			CS$<>8__locals1.singleTileLoadedCallback = singleTileLoadedCallback;
			CS$<>8__locals1.tileItem = mapTileItem;
			this.LoadAndSetSingleFogTile(fogTilePath, new Action<UTexture, string>(CS$<>8__locals1.<LoadMultiMapSingleFogTile>g__LoadCallback|0));
		}

		// Token: 0x0603755E RID: 226654 RVA: 0x00D23DE0 File Offset: 0x00D21FE0
		private void LoadAndSetSingleFogTile(string fogTilePath, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UTexture, string> loadCallback)
		{
			UTexture arg;
			if (this.PreloadMapTiles.TryGetValue(fogTilePath, out arg))
			{
				loadCallback(arg, fogTilePath);
				return;
			}
			ResourceSystem.Instance.LoadAsync<UTexture>(fogTilePath, loadCallback, 102, "Ui.MapUi");
		}

		// Token: 0x0603755F RID: 226655 RVA: 0x00D23E1C File Offset: 0x00D2201C
		public UniTask LoadMapBorder()
		{
			MapTileMgr.<LoadMapBorder>d__100 <LoadMapBorder>d__;
			<LoadMapBorder>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMapBorder>d__.<>4__this = this;
			<LoadMapBorder>d__.<>1__state = -1;
			<LoadMapBorder>d__.<>t__builder.Start<MapTileMgr.<LoadMapBorder>d__100>(ref <LoadMapBorder>d__);
			return <LoadMapBorder>d__.<>t__builder.Task;
		}

		// Token: 0x06037560 RID: 226656 RVA: 0x00D23E60 File Offset: 0x00D22060
		private void RefreshMapBorder([Nullable(new byte[]
		{
			2,
			1
		})] object[] param)
		{
			foreach (UUIItem uuiitem in this.BorderItems)
			{
				AActor owner = uuiitem.GetOwner();
				if (owner != null)
				{
					owner.K2_DestroyActor();
				}
			}
			this.BorderItems.Clear();
			this.LoadMapBorder().Forget();
		}

		// Token: 0x06037561 RID: 226657 RVA: 0x00D23ED4 File Offset: 0x00D220D4
		public void UpdateMinimapTiles(global::Vector position)
		{
			if (this.MapType != EMapType.MiniMap || !this.IsTileShow)
			{
				return;
			}
			ITilePosition tilePosition = MapUtil.GetTilePosition(position, 0.5f);
			int x = tilePosition.X;
			int y = tilePosition.Y;
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
			int num = this.MultiMapAreaCache.ContainsKey(currentAreaId) ? this.MultiMapAreaCache[currentAreaId] : 0;
			bool flag = this.MiniMapShowMultiMapId != num;
			if (Math.Abs(this.CurrentFocusPosU - position.X) < 2000.0 && Math.Abs(this.CurrentFocusPosV - position.Y) < 2000.0 && this.CurrentFocusRow == x && this.CurrentFocusColumn == y && !flag)
			{
				return;
			}
			this.MiniMapTileIndexes = new List<int>
			{
				x,
				y,
				x - 1,
				y,
				x,
				y - 1,
				x - 1,
				y - 1
			};
			List<FLinearColor> list = this.CalculateTileScaleBiasByPosition(position, x, y);
			this.UpdateTilesTransformAndUv(this.MapTiles, this.MiniMapTileIndexes, list);
			bool flag2 = num != 0 && this.SubMapContainer != null && MapModel.Instance.CheckUnlockMultiMapIds(num);
			if (flag2)
			{
				this.UpdateTilesTransformAndUv(this.SubMapTiles, this.MiniMapTileIndexes, list);
				int i = 0;
				while (i < this.SubMapTiles.Count)
				{
					int num2 = this.MiniMapTileIndexes[i * 2];
					int num3 = this.MiniMapTileIndexes[i * 2 + 1];
					if (list[i].R > 0f)
					{
						float inX = ((float)num2 - 0.5f - 0.5f + list[i].B + list[i].R / 2f) * 850f;
						float inY = ((float)num3 - 0.5f + 0.5f - list[i].A - list[i].G / 2f) * 850f;
						UUIItem subMapMask = this.SubMapMask;
						if (subMapMask == null)
						{
							break;
						}
						subMapMask.SetAnchorOffset(new FVector2D(inX, inY));
						break;
					}
					else
					{
						i++;
					}
				}
			}
			UUIItem subMapContainer = this.SubMapContainer;
			if (subMapContainer != null)
			{
				subMapContainer.SetUIActive(flag2);
			}
			this.SubMapContainerActive = flag2;
			if (this.CurrentFocusRow == x && this.CurrentFocusColumn == y && !flag)
			{
				return;
			}
			this.CurrentFocusRow = x;
			this.CurrentFocusColumn = y;
			for (int j = 0; j < this.MapTiles.Count; j++)
			{
				int x2 = this.MiniMapTileIndexes[j * 2];
				int y2 = this.MiniMapTileIndexes[j * 2 + 1];
				if (flag2)
				{
					this.UpdateMiniMapSingleMultiFloorTile(this.SubMapTiles[j], x2, y2, num, currentAreaId);
				}
				this.UpdateMiniMapSingleBaseTiles(this.MapTiles[j], x2, y2);
			}
			if (flag2)
			{
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChanged, num);
			}
			else
			{
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChanged, 0);
			}
			this.MiniMapShowMultiMapId = num;
		}

		// Token: 0x06037562 RID: 226658 RVA: 0x00D2420C File Offset: 0x00D2240C
		private void ForceUpdateMiniMapTiles()
		{
			int num = (this.MapTiles.Count - 1) * 2 + 1;
			if (this.MiniMapTileIndexes.Count <= num)
			{
				return;
			}
			for (int i = 0; i < this.MapTiles.Count; i++)
			{
				int x = this.MiniMapTileIndexes[i * 2];
				int y = this.MiniMapTileIndexes[i * 2 + 1];
				this.UpdateMiniMapSingleBaseTiles(this.MapTiles[i], x, y);
			}
		}

		// Token: 0x06037563 RID: 226659 RVA: 0x00D24284 File Offset: 0x00D22484
		private void OnMultiMapUnlockChanged()
		{
			this.MiniMapShowMultiMapId = -1;
		}

		// Token: 0x06037564 RID: 226660 RVA: 0x00D24290 File Offset: 0x00D22490
		private unsafe void UpdateMiniMapSingleMultiFloorTile(UUITextureBase tile, int x, int y, int multiMapId, int areaId)
		{
			this.SubMapTileResourceIds.Remove(tile);
			MapConfig instance = MapConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(x);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(y);
			FogTextureConfig? tileConfig = instance.GetTileConfig(defaultInterpolatedStringHandler.ToStringAndClear(), this.MapId, this.MapGravity);
			if (tileConfig == null || StringUtils.IsEmpty(tileConfig.Value.MapTilePath))
			{
				UUITextureBase tile2 = tile;
				if (tile2 == null)
				{
					return;
				}
				tile2.SetColor(this.TransparentColor);
				return;
			}
			else
			{
				MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(multiMapId);
				if (subMapConfigById == null)
				{
					UUITextureBase tile3 = tile;
					if (tile3 == null)
					{
						return;
					}
					tile3.SetColor(this.TransparentColor);
					return;
				}
				else if (!MapModel.Instance.CheckUnlockMultiMapIds(multiMapId))
				{
					UUITextureBase tile4 = tile;
					if (tile4 == null)
					{
						return;
					}
					tile4.SetColor(this.TransparentColor);
					return;
				}
				else
				{
					string text = null;
					for (int i = 0; i < subMapConfigById.Value.MiniMapTilePathLength; i++)
					{
						string text2 = subMapConfigById.Value.MiniMapTilePath(i);
						string text3 = text2;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<int>(x);
						defaultInterpolatedStringHandler.AppendLiteral("_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(y);
						if (text3.Contains(defaultInterpolatedStringHandler.ToStringAndClear()))
						{
							text = text2;
							break;
						}
					}
					if (string.IsNullOrEmpty(text))
					{
						UUITextureBase tile5 = tile;
						if (tile5 == null)
						{
							return;
						}
						tile5.SetColor(this.TransparentColor);
						return;
					}
					else
					{
						this.SubMapTileResourceIds[tile] = text;
						string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
						if (StringUtils.IsEmpty(resourcePath))
						{
							Log instance2 = Log.Instance;
							ELogModule module = ELogModule.Map;
							ELogAuthor author = ELogAuthor.LPH;
							string message = "UpdateMinimapTiles 多层地图小地图获取地图块资源为空";
							<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("x", x);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("y", y);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MultiMapId", multiMapId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AreaId", areaId);
							instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
							UUITextureBase tile6 = tile;
							if (tile6 == null)
							{
								return;
							}
							tile6.SetColor(this.TransparentColor);
							return;
						}
						else
						{
							string fogTilePath;
							if (this.MapVersion == 2)
							{
								defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
								defaultInterpolatedStringHandler.AppendFormatted<int>(this.MapId);
								defaultInterpolatedStringHandler.AppendLiteral("_");
								defaultInterpolatedStringHandler.AppendFormatted<int>(x);
								defaultInterpolatedStringHandler.AppendLiteral("_");
								defaultInterpolatedStringHandler.AppendFormatted<int>(y);
								string rowName = defaultInterpolatedStringHandler.ToStringAndClear();
								S_FogToAreaIDs fogTileData = DataTableUtil.GetDataTableRow<S_FogToAreaIDs>(this.DtFogAreaID, rowName);
								ResourceSystem.Instance.LoadAsync<UTexture>(resourcePath, delegate([Nullable(2)] UTexture textureObject, string assetPath)
								{
									if (textureObject != null)
									{
										tile.SetTexture(textureObject);
										if (fogTileData != null && (fogTileData.IsFogP1 || fogTileData.IsFogP2))
										{
											tile.SetColor(this.FogDefaultColor);
											string value = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2";
											if (this.MapType == EMapType.MiniMap)
											{
												value = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2Mini";
											}
											if (fogTileData.IsFogP1)
											{
												DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(40, 7);
												defaultInterpolatedStringHandler2.AppendFormatted(value);
												defaultInterpolatedStringHandler2.AppendLiteral("/T_FogTiles_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(this.MapId);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(x);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(y);
												defaultInterpolatedStringHandler2.AppendLiteral("_UI_p1.T_FogTiles_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(this.MapId);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(x);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(y);
												defaultInterpolatedStringHandler2.AppendLiteral("_UI_p1");
												string fogTilePath = defaultInterpolatedStringHandler2.ToStringAndClear();
												this.LoadMultiMapSingleFogTile(tile, fogTilePath, null, 1);
											}
											if (fogTileData.IsFogP2)
											{
												DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(40, 7);
												defaultInterpolatedStringHandler2.AppendFormatted(value);
												defaultInterpolatedStringHandler2.AppendLiteral("/T_FogTiles_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(this.MapId);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(x);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(y);
												defaultInterpolatedStringHandler2.AppendLiteral("_UI_p2.T_FogTiles_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(this.MapId);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(x);
												defaultInterpolatedStringHandler2.AppendLiteral("_");
												defaultInterpolatedStringHandler2.AppendFormatted<int>(y);
												defaultInterpolatedStringHandler2.AppendLiteral("_UI_p2");
												string fogTilePath2 = defaultInterpolatedStringHandler2.ToStringAndClear();
												this.LoadMultiMapSingleFogTile(tile, fogTilePath2, null, 2);
												return;
											}
										}
										else
										{
											tile.SetColor(this.FogDefaultColor);
										}
									}
								}, 100, "Ui.MapUi");
								return;
							}
							string uiResourcePathById = MapConfig.Instance.GetUiResourcePathById(tileConfig.Value.MiniFogTilePath);
							string uiResourcePathById2 = MapConfig.Instance.GetUiResourcePathById(tileConfig.Value.FogTilePath);
							fogTilePath = this.TryTransformTilePath(uiResourcePathById2, uiResourcePathById);
							ResourceSystem.Instance.LoadAsync<UTexture>(resourcePath, delegate([Nullable(2)] UTexture textureObject, string assetPath)
							{
								if (textureObject != null)
								{
									tile.SetTexture(textureObject);
									if (!StringUtils.IsEmpty(fogTilePath))
									{
										this.LoadMultiMapSingleFogTile(tile, fogTilePath, null, 1);
										return;
									}
									tile.SetColor(this.FogDefaultColor);
								}
							}, 100, "Ui.MapUi");
							return;
						}
					}
				}
			}
		}

		// Token: 0x06037565 RID: 226661 RVA: 0x00D2464C File Offset: 0x00D2284C
		private void UpdateMiniMapSingleBaseTiles(UUITextureBase tile, int x, int y)
		{
			MapTileMgr.<>c__DisplayClass106_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass106_0();
			CS$<>8__locals1.tile = tile;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.x = x;
			CS$<>8__locals1.y = y;
			MapConfig instance = MapConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.x);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.y);
			FogTextureConfig? tileConfig = instance.GetTileConfig(defaultInterpolatedStringHandler.ToStringAndClear(), this.MapId, this.MapGravity);
			if (tileConfig == null || StringUtils.IsEmpty(tileConfig.Value.MapTilePath))
			{
				return;
			}
			int num = MapModel.Instance.CheckUnlockMapBlockIds(tileConfig.Value.Block, this.MapGravity, this.MapId);
			string inPath = "";
			string targetPath = "";
			if (num != 0)
			{
				BlockSwitch? unlockMapTileConfigById = MapConfig.Instance.GetUnlockMapTileConfigById(num);
				if (unlockMapTileConfigById != null)
				{
					inPath = MapConfig.Instance.GetUiResourcePathById(unlockMapTileConfigById.Value.MapTilePath);
					targetPath = MapConfig.Instance.GetUiResourcePathById(unlockMapTileConfigById.Value.MiniMapTilePath);
				}
			}
			else
			{
				inPath = MapConfig.Instance.GetUiResourcePathById(tileConfig.Value.MapTilePath);
				targetPath = MapConfig.Instance.GetUiResourcePathById(tileConfig.Value.MiniMapTilePath);
			}
			string path = this.TryTransformTilePath(inPath, targetPath);
			string fogTilePath;
			if (this.MapVersion == 2)
			{
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.MapId);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.x);
				defaultInterpolatedStringHandler.AppendLiteral("_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.y);
				string rowName = defaultInterpolatedStringHandler.ToStringAndClear();
				S_FogToAreaIDs fogTileData = DataTableUtil.GetDataTableRow<S_FogToAreaIDs>(this.DtFogAreaID, rowName);
				ResourceSystem.Instance.LoadAsync<UTexture>(path, delegate([Nullable(2)] UTexture textureObject, string assetPath)
				{
					if (textureObject == null || !textureObject.IsValid())
					{
						return;
					}
					CS$<>8__locals1.tile.SetTexture(textureObject);
					if (fogTileData == null)
					{
						return;
					}
					string value = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2";
					if (CS$<>8__locals1.<>4__this.MapType == EMapType.MiniMap)
					{
						value = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2Mini";
					}
					if (fogTileData.IsFogP1)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(40, 7);
						defaultInterpolatedStringHandler2.AppendFormatted(value);
						defaultInterpolatedStringHandler2.AppendLiteral("/T_FogTiles_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.<>4__this.MapId);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.x);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.y);
						defaultInterpolatedStringHandler2.AppendLiteral("_UI_p1.T_FogTiles_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.<>4__this.MapId);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.x);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.y);
						defaultInterpolatedStringHandler2.AppendLiteral("_UI_p1");
						string fogTilePath = defaultInterpolatedStringHandler2.ToStringAndClear();
						CS$<>8__locals1.<>4__this.LoadSingleFogTileV2(CS$<>8__locals1.tile, fogTilePath, 1, null);
					}
					if (fogTileData.IsFogP2)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(40, 7);
						defaultInterpolatedStringHandler2.AppendFormatted(value);
						defaultInterpolatedStringHandler2.AppendLiteral("/T_FogTiles_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.<>4__this.MapId);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.x);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.y);
						defaultInterpolatedStringHandler2.AppendLiteral("_UI_p2.T_FogTiles_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.<>4__this.MapId);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.x);
						defaultInterpolatedStringHandler2.AppendLiteral("_");
						defaultInterpolatedStringHandler2.AppendFormatted<int>(CS$<>8__locals1.y);
						defaultInterpolatedStringHandler2.AppendLiteral("_UI_p2");
						string fogTilePath2 = defaultInterpolatedStringHandler2.ToStringAndClear();
						CS$<>8__locals1.<>4__this.LoadSingleFogTileV2(CS$<>8__locals1.tile, fogTilePath2, 2, null);
					}
				}, 100, "Ui.MapUi");
				return;
			}
			string uiResourcePathById = MapConfig.Instance.GetUiResourcePathById(tileConfig.Value.FogTilePath);
			string uiResourcePathById2 = MapConfig.Instance.GetUiResourcePathById(tileConfig.Value.MiniFogTilePath);
			fogTilePath = this.TryTransformTilePath(uiResourcePathById, uiResourcePathById2);
			ResourceSystem.Instance.LoadAsync<UTexture>(path, delegate([Nullable(2)] UTexture textureObject, string _)
			{
				if (textureObject == null || !textureObject.IsValid())
				{
					return;
				}
				CS$<>8__locals1.tile.SetTexture(textureObject);
				if (!StringUtils.IsEmpty(fogTilePath))
				{
					CS$<>8__locals1.<>4__this.LoadSingleFogTile(CS$<>8__locals1.tile, fogTilePath, null);
					return;
				}
				CS$<>8__locals1.tile.SetColor(CS$<>8__locals1.<>4__this.FogDefaultColor);
			}, ResourceSystem.EResourceLoadPriority.Default, "Ui.MapUi");
		}

		// Token: 0x06037566 RID: 226662 RVA: 0x00D248D8 File Offset: 0x00D22AD8
		private unsafe List<FLinearColor> CalculateTileScaleBiasByPosition(global::Vector position, int row, int column)
		{
			Vector2D vector2D = Vector2D.Create(position);
			vector2D.DivisionEqual(85000.0);
			double num = vector2D.X - (double)row + 1.0;
			double num2 = vector2D.Y + (double)column;
			this.CurrentFocusPosU = position.X;
			this.CurrentFocusPosV = position.Y;
			float num3 = 0.23529412f;
			float num4 = (float)Math.Min(num + (double)num3, 1.0);
			float num5 = (float)Math.Max(num - (double)num3, 0.0);
			float num6 = (float)Math.Min(num2 + (double)num3, 1.0);
			float num7 = (float)Math.Max(num2 - (double)num3, 0.0);
			FLinearColor flinearColor = new FLinearColor(num4 - num5, num6 - num7, num5, num7);
			FLinearColor flinearColor2 = new FLinearColor(num3 * 2f - flinearColor.R, flinearColor.G, (float)Math.Min((double)(1f - num3) + num, 1.0), num7);
			FLinearColor flinearColor3 = new FLinearColor(flinearColor.R, num3 * 2f - flinearColor.G, num5, (float)Math.Max(num2 - (double)num3 - 1.0, 0.0));
			FLinearColor flinearColor4 = new FLinearColor(flinearColor2.R, flinearColor3.G, flinearColor2.B, flinearColor3.A);
			int num8 = 4;
			List<FLinearColor> list = new List<FLinearColor>(num8);
			CollectionsMarshal.SetCount<FLinearColor>(list, num8);
			Span<FLinearColor> span = CollectionsMarshal.AsSpan<FLinearColor>(list);
			int num9 = 0;
			*span[num9] = flinearColor;
			num9++;
			*span[num9] = flinearColor2;
			num9++;
			*span[num9] = flinearColor3;
			num9++;
			*span[num9] = flinearColor4;
			return list;
		}

		// Token: 0x06037567 RID: 226663 RVA: 0x00D24AA4 File Offset: 0x00D22CA4
		private void UpdateTilesTransformAndUv(List<UUITextureBase> tiles, List<int> indexes, List<FLinearColor> scaleBias)
		{
			Vector2D vector2D = Vector2D.Create();
			for (int i = 0; i < tiles.Count; i++)
			{
				UUITextureBase uuitextureBase = tiles[i];
				uuitextureBase.SetWidth(Math.Max(scaleBias[i].R * 850f, 0f));
				uuitextureBase.SetHeight(Math.Max(scaleBias[i].G * 850f, 0f));
				int num = indexes[i * 2];
				int num2 = indexes[i * 2 + 1];
				vector2D.X = (double)(((float)num - 0.5f - 0.5f + scaleBias[i].B + scaleBias[i].R / 2f) * 850f);
				vector2D.Y = (double)(((float)num2 - 0.5f + 0.5f - scaleBias[i].A - scaleBias[i].G / 2f) * 850f);
				uuitextureBase.SetAnchorOffset(vector2D.ToUeVector2D(false));
				uuitextureBase.SetCustomMaterialVectorParameter(new FName("UVCorrect"), scaleBias[i]);
			}
		}

		// Token: 0x06037568 RID: 226664 RVA: 0x00D24BC8 File Offset: 0x00D22DC8
		public void ShowSubMapByPosition(int groupId, int layer, bool fastTween = false)
		{
			if (this.MapType == EMapType.MiniMap)
			{
				return;
			}
			if (groupId == 0)
			{
				return;
			}
			bool subMapContainerActive = this.SubMapContainerActive;
			this.CreateSubMapTile(groupId, -layer, subMapContainerActive);
			UUIItem subMapContainer = this.SubMapContainer;
			if (subMapContainer != null)
			{
				subMapContainer.SetUIActive(true);
			}
			this.SubMapContainerActive = true;
			if (!subMapContainerActive)
			{
				this.PlaySubMapTween(false, null, fastTween);
			}
		}

		// Token: 0x06037569 RID: 226665 RVA: 0x00D24C1C File Offset: 0x00D22E1C
		public void HideSubMap()
		{
			if (this.SubMapContainerActive)
			{
				List<UUITextureBase> subMapFadeInTiles = this.SubMapFadeInTiles;
				if (subMapFadeInTiles != null)
				{
					subMapFadeInTiles.ForEach(delegate(UUITextureBase item)
					{
						this.PlaySubMapItemFadeTween(item, false);
					});
				}
				this.PlaySubMapTween(true, delegate
				{
					UUIItem subMapContainer2 = this.SubMapContainer;
					if (subMapContainer2 == null)
					{
						return;
					}
					subMapContainer2.SetUIActive(false);
				}, false);
				this.SubMapContainerActive = false;
				return;
			}
			UUIItem subMapContainer = this.SubMapContainer;
			if (subMapContainer != null)
			{
				subMapContainer.SetUIActive(false);
			}
			this.SubMapContainerActive = false;
		}

		// Token: 0x0603756A RID: 226666 RVA: 0x00D24C84 File Offset: 0x00D22E84
		[NullableContext(2)]
		private void PlaySubMapTween(bool reverse = false, Action onComplete = null, bool fastTween = false)
		{
			ULGUIPlayTweenComponent subMapContainerTween = this.SubMapContainerTween;
			ULGUIPlayTween_Float ulguiplayTween_Float = ((subMapContainerTween != null) ? subMapContainerTween.GetPlayTween() : null) as ULGUIPlayTween_Float;
			if (ulguiplayTween_Float != null)
			{
				this.UnregisterSubMapEndCb();
				this.SubMapContainerTween.Stop();
				ulguiplayTween_Float.from = ((!reverse) ? 0f : this.SubMapContainerOriginalAlpha);
				ulguiplayTween_Float.to = ((!reverse) ? this.SubMapContainerOriginalAlpha : 0f);
				ulguiplayTween_Float.duration = (fastTween ? 0f : 0.2f);
				if (onComplete != null)
				{
					this.SubMapTweenDelegate = delegate()
					{
						onComplete();
						this.ReleaseSubMapTweenDelegate();
					};
					FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(this.SubMapTweenDelegate);
					this.SubMapContainerPlayEndCbWrapper = ulguiplayTween_Float.RegisterOnComplete(flguiplayTweenCompleteDynamicDelegate);
				}
				this.SubMapContainerTween.Play();
			}
		}

		// Token: 0x0603756B RID: 226667 RVA: 0x00D24D54 File Offset: 0x00D22F54
		private void ReleaseSubMapTweenDelegate()
		{
			if (this.SubMapTweenDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.SubMapTweenDelegate);
				this.SubMapTweenDelegate = null;
			}
		}

		// Token: 0x0603756C RID: 226668 RVA: 0x00D24D70 File Offset: 0x00D22F70
		private void UnregisterSubMapEndCb()
		{
			if (this.SubMapContainerPlayEndCbWrapper != null)
			{
				ULGUIPlayTweenComponent subMapContainerTween = this.SubMapContainerTween;
				ULGUIPlayTween_Float ulguiplayTween_Float = ((subMapContainerTween != null) ? subMapContainerTween.GetPlayTween() : null) as ULGUIPlayTween_Float;
				if (ulguiplayTween_Float != null)
				{
					ulguiplayTween_Float.UnregisterOnComplete(this.SubMapContainerPlayEndCbWrapper);
				}
				this.SubMapContainerPlayEndCbWrapper = null;
			}
			this.ReleaseSubMapTweenDelegate();
		}

		// Token: 0x0603756D RID: 226669 RVA: 0x00D24DC0 File Offset: 0x00D22FC0
		private void PlaySubMapItemFadeTween(UUITextureBase item, bool fadeIn = true)
		{
			ULGUIPlayTweenComponent subMapContainerTween = this.SubMapContainerTween;
			ULGUIPlayTween_Float ulguiplayTween_Float = ((subMapContainerTween != null) ? subMapContainerTween.GetPlayTween() : null) as ULGUIPlayTween_Float;
			if (ulguiplayTween_Float != null)
			{
				AActor owner = item.GetOwner();
				ULGUIPlayTweenComponent ulguiplayTweenComponent = ((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null) as ULGUIPlayTweenComponent;
				ULGUIPlayTween_Float ulguiplayTween_Float2 = ((ulguiplayTweenComponent != null) ? ulguiplayTweenComponent.GetPlayTween() : null) as ULGUIPlayTween_Float;
				if (ulguiplayTweenComponent != null)
				{
					ulguiplayTweenComponent.Stop();
				}
				float num = 0.25f;
				ulguiplayTween_Float2.duration = ulguiplayTween_Float.duration - ulguiplayTween_Float.duration * num;
				ulguiplayTween_Float2.from = (fadeIn ? 0f : item.GetAlpha());
				ulguiplayTween_Float2.to = (fadeIn ? item.GetAlpha() : 0f);
				if (ulguiplayTweenComponent == null)
				{
					return;
				}
				ulguiplayTweenComponent.Play();
			}
		}

		// Token: 0x0603756E RID: 226670 RVA: 0x00D24E7C File Offset: 0x00D2307C
		private void PlaySubMapItemSwitchTween(UUITextureBase item, bool switchShow = true)
		{
			AActor owner = item.GetOwner();
			ULGUIPlayTweenComponent ulguiplayTweenComponent = ((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null) as ULGUIPlayTweenComponent;
			ULGUIPlayTween_Float ulguiplayTween_Float = ((ulguiplayTweenComponent != null) ? ulguiplayTweenComponent.GetPlayTween() : null) as ULGUIPlayTween_Float;
			if (ulguiplayTweenComponent != null)
			{
				ulguiplayTweenComponent.Stop();
			}
			float num = 0.3f;
			float num2 = 0.15f;
			ulguiplayTween_Float.duration = (switchShow ? num : num2);
			if (switchShow)
			{
				ulguiplayTween_Float.from = item.GetAlpha();
				ulguiplayTween_Float.to = 1f;
			}
			else
			{
				ulguiplayTween_Float.to = item.GetAlpha();
			}
			if (ulguiplayTweenComponent == null)
			{
				return;
			}
			ulguiplayTweenComponent.Play();
		}

		// Token: 0x0603756F RID: 226671 RVA: 0x00D24F14 File Offset: 0x00D23114
		public int GetMultiMapAreaIdByPosition(global::Vector position)
		{
			int subMapGroupByPosition = this.GetSubMapGroupByPosition(position);
			List<MultiMap> subMapConfigByGroupId = MapConfig.Instance.GetSubMapConfigByGroupId(subMapGroupByPosition);
			if (subMapConfigByGroupId.Count > 0)
			{
				MultiMap multiMap = subMapConfigByGroupId.Find((MultiMap element) => element.Floor == -1);
				if (multiMap.GetAreaBytes().Length > 0)
				{
					return multiMap.Area(0);
				}
			}
			return 0;
		}

		// Token: 0x06037570 RID: 226672 RVA: 0x00D24F80 File Offset: 0x00D23180
		[NullableContext(2)]
		public global::Vector GetWorldMapCenterPosition()
		{
			ULGUIPointerEventData ulguipointerEventData = ULGUIBPLibrary.SimulationLineTraceOnCenterScreen(GlobalData.World, ref this.LineTraceItemList);
			if (ulguipointerEventData == null)
			{
				return null;
			}
			if (ulguipointerEventData.enterComponent == null)
			{
				return null;
			}
			return global::Vector.Create(ulguipointerEventData.GetLocalPointInPlane());
		}

		// Token: 0x06037571 RID: 226673 RVA: 0x00D24FC0 File Offset: 0x00D231C0
		public unsafe int GetSubMapGroupByPosition(global::Vector position)
		{
			UUIItem mapRootItem = this.MapRootItem;
			float num = (mapRootItem != null) ? mapRootItem.GetWidth() : 0f;
			UUIItem mapRootItem2 = this.MapRootItem;
			float num2 = (mapRootItem2 != null) ? mapRootItem2.GetHeight() : 0f;
			ITilePosition tilePositionByUiPosition = MapUtil.GetTilePositionByUiPosition(position);
			int x = tilePositionByUiPosition.X;
			int y = tilePositionByUiPosition.Y;
			double num3 = (position.X + (double)(num / 2f)) % 850.0;
			double num4 = (position.Y + (double)(num2 / 2f)) % 850.0;
			Dictionary<string, MultiMapAreaConfig> multiMapAreaConfigCache = this.MultiMapAreaConfigCache;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(x);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(y);
			MultiMapAreaConfig multiMapAreaConfig;
			if (!multiMapAreaConfigCache.TryGetValue(defaultInterpolatedStringHandler.ToStringAndClear(), out multiMapAreaConfig))
			{
				return 0;
			}
			for (int i = 0; i < multiMapAreaConfig.MultiMapRangeListLength; i++)
			{
				IntArray? intArray = multiMapAreaConfig.MultiMapRangeList(i);
				for (int j = 0; j < intArray.Value.ArrayIntLength; j += 4)
				{
					int num5 = intArray.Value.ArrayInt(j);
					int num6 = intArray.Value.ArrayInt(j + 1);
					int num7 = intArray.Value.ArrayInt(j + 2);
					int num8 = intArray.Value.ArrayInt(j + 3);
					if (num3 >= (double)num5 && num3 <= (double)num7 && num4 >= (double)num6 && num4 <= (double)num8)
					{
						return *multiMapAreaConfig.GetMultiMapListBytes()[i];
					}
				}
			}
			return 0;
		}

		// Token: 0x06037572 RID: 226674 RVA: 0x00D25154 File Offset: 0x00D23354
		public void CreateSubMapTile(int groupId, int layer, bool switchLayer = false)
		{
			this.SubMapFadeInTiles = new List<UUITextureBase>();
			List<MultiMap> list = ConfigCommon.ToList<MultiMap>(MapConfig.Instance.GetSubMapConfigByGroupId(groupId));
			List<MultiMap> list2;
			if (list == null)
			{
				list2 = null;
			}
			else
			{
				list2 = (from floorData in list
				where MapModel.Instance.CheckUnlockMultiMapIds(floorData.Id)
				select floorData).ToList<MultiMap>();
			}
			List<MultiMap> list3 = list2;
			if (list3 == null)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			list3.Sort(delegate(MultiMap a, MultiMap b)
			{
				if (a.Floor == layer && b.Floor != layer)
				{
					return 1;
				}
				if (a.Floor != layer && b.Floor == layer)
				{
					return -1;
				}
				return a.Floor - b.Floor;
			});
			using (List<MultiMap>.Enumerator enumerator = list3.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MultiMap floorData = enumerator.Current;
					num2++;
					string[] array = floorData.MapTilePath();
					for (int i = 0; i < array.Length; i++)
					{
						string text = array[i];
						if (this.SubMapTiles != null && this.SubMapTiles.Count <= num)
						{
							UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.SubMapTexture, this.SubMapContainer);
							this.SubMapTiles.Add(uuiitem as UUITextureBase);
						}
						num++;
						string[] array2 = text.Split('_', StringSplitOptions.None);
						int num3 = int.Parse(array2[2]);
						int num4 = int.Parse(array2[3]);
						UUITextureBase subItem = this.SubMapTiles[num - 1];
						this.SubMapTileResourceIds[subItem] = text;
						if (switchLayer)
						{
							subItem.SetColor(this.TransparentColor);
						}
						subItem.SetAnchorOffsetX(((float)num3 - 0.5f) * 850f);
						subItem.SetAnchorOffsetY(((float)num4 - 0.5f) * 850f);
						subItem.SetHierarchyIndex(num);
						subItem.SetWidth(850f);
						subItem.SetHeight(850f);
						string path = UiResourceConfig.Instance.GetResourcePath(text) ?? "";
						byte color = (byte)((layer == floorData.Floor) ? 255 : (20 + 20 * num2));
						ResourceSystem.Instance.LoadAsync<UTexture>(path, delegate([Nullable(2)] UTexture textureObject, string _)
						{
							if (textureObject != null)
							{
								subItem.SetTexture(textureObject);
								subItem.SetColor(new FColor(color, color, color, byte.MaxValue));
							}
							else
							{
								subItem.SetColor(this.FogDefaultColor);
							}
							subItem.SetUIActive(true);
							if (switchLayer)
							{
								this.PlaySubMapItemSwitchTween(subItem, layer == floorData.Floor);
							}
							else
							{
								this.PlaySubMapItemFadeTween(subItem, true);
							}
							this.SubMapFadeInTiles.Add(subItem);
						}, ResourceSystem.EResourceLoadPriority.Default, "Ui.MapUi");
					}
				}
			}
			int num5 = num;
			for (;;)
			{
				int num6 = num5;
				List<UUITextureBase> subMapTiles = this.SubMapTiles;
				int? num7 = (subMapTiles != null) ? new int?(subMapTiles.Count) : null;
				if (!(num6 < num7.GetValueOrDefault() & num7 != null))
				{
					break;
				}
				this.SubMapTiles[num5].SetUIActive(false);
				num5++;
			}
		}

		// Token: 0x06037573 RID: 226675 RVA: 0x00D25464 File Offset: 0x00D23664
		public Vector2D ConvertUiPositionToMapTilePosition(global::Vector uiPosition)
		{
			return Vector2D.Create();
		}

		// Token: 0x06037574 RID: 226676 RVA: 0x00D2546C File Offset: 0x00D2366C
		public void UpdateCurrentAreaMapGroupId(global::Vector position)
		{
			if (!this.UpdateCurrentAreaMapGroupIdSwitch)
			{
				return;
			}
			ITilePosition tilePositionByUiPosition = MapUtil.GetTilePositionByUiPosition(position);
			int x = tilePositionByUiPosition.X;
			int y = tilePositionByUiPosition.Y;
			IReadOnlyList<AreaMapGroup> allAreaMapGroup = RegionalTerminalConfig.Instance.GetAllAreaMapGroup();
			if (allAreaMapGroup != null)
			{
				foreach (AreaMapGroup areaMapGroup in allAreaMapGroup)
				{
					if (this.MapId == areaMapGroup.MapId)
					{
						foreach (PosRectangle posRectangle in areaMapGroup.BlockBorder())
						{
							if (x >= posRectangle.XMin && x <= posRectangle.XMax && y >= posRectangle.YMin && y <= posRectangle.YMax)
							{
								RegionalTerminalModel.Instance.CurrentAreaMapGroupId = areaMapGroup.Id;
								return;
							}
						}
					}
				}
			}
			RegionalTerminalModel.Instance.CurrentAreaMapGroupId = 0;
		}

		// Token: 0x06037575 RID: 226677 RVA: 0x00D2555C File Offset: 0x00D2375C
		private void OnMapOpenFogChange(int fogId)
		{
			if (this.OpenFogSet == null)
			{
				return;
			}
			this.OpenFogSet.Add(fogId);
			this.UpdateOpenArea();
		}

		// Token: 0x06037576 RID: 226678 RVA: 0x00D2557C File Offset: 0x00D2377C
		private void OnMapFogFullUpdate(IReadOnlyDictionary<int, bool> unlockFogIds)
		{
			if (this.OpenFogSet == null)
			{
				return;
			}
			this.OpenFogSet.Clear();
			foreach (int item in unlockFogIds.Keys)
			{
				this.OpenFogSet.Add(item);
			}
			this.UpdateOpenArea();
		}

		// Token: 0x06037577 RID: 226679 RVA: 0x00D255EC File Offset: 0x00D237EC
		public void UpdateOpenArea()
		{
			foreach (UUITextureBase mapTile in this.MapTiles)
			{
				this.UpdateSingleTileOpenArea(mapTile, null, 0);
			}
			foreach (UUITextureBase mapTile2 in this.SubMapTiles)
			{
				this.UpdateMultiMapSingleTileOpenArea(mapTile2, null, 1);
			}
		}

		// Token: 0x06037578 RID: 226680 RVA: 0x00D25688 File Offset: 0x00D23888
		public void HandleFogAreaOpen(int fogId)
		{
			this.FogOpenParamList = new List<FogOpenParams>();
			if (this.FogOpenDelegate == null)
			{
				this.FogOpenDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.SetFogTitleColor));
			}
			this.ToHandleUnlockFogId = fogId;
			if (this.MapVersion == 2)
			{
				S_AreaIDToMaskVal? s_AreaIDToMaskVal;
				if (!DataTableUtil.TryGetDataTableRowStruct<S_AreaIDToMaskVal>(this.DtAreaIDToMaskCode, fogId.ToString(), out s_AreaIDToMaskVal))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Map;
					ELogAuthor author = ELogAuthor.LYX;
					string message = "fog data not found";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("fogId", fogId);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				int mask = s_AreaIDToMaskVal.Value.Mask;
				bool flag = false;
				for (int i = 0; i < this.MapTiles.Count; i++)
				{
					if (this.MapTiles[i] != null)
					{
						ValueTuple<int, int> tilePositionByIndex = this.GetTilePositionByIndex(i);
						int item = tilePositionByIndex.Item1;
						int item2 = tilePositionByIndex.Item2;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.MapId);
						defaultInterpolatedStringHandler.AppendLiteral("_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(item);
						defaultInterpolatedStringHandler.AppendLiteral("_");
						defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
						string rowName = defaultInterpolatedStringHandler.ToStringAndClear();
						S_FogToAreaIDs dataTableRow = DataTableUtil.GetDataTableRow<S_FogToAreaIDs>(this.DtFogAreaID, rowName);
						if (!(dataTableRow == null) && dataTableRow.AreaFogIDs.Contains(fogId))
						{
							FogOpenParams fogOpenParams = new FogOpenParams();
							fogOpenParams.MapTileIndex = i;
							this.FogOpenParamList.Add(fogOpenParams);
							fogOpenParams.ChannelV2 = mask;
							if (!flag)
							{
								FVectorDouble unlockFogCenter = this.GetUnlockFogCenter(fogId);
								global::Vector p = global::Vector.Create(unlockFogCenter.X, unlockFogCenter.Y, unlockFogCenter.Z);
								EventSystem.Instance.Emit<global::Vector>(EEventName.MoveWorldMapToPosition, p);
								flag = true;
							}
						}
					}
				}
			}
			else
			{
				for (int j = 0; j < this.MapTiles.Count; j++)
				{
					UUITextureBase mapTile = this.MapTiles[j];
					EChannel? changedChannel = this.GetChangedChannel(mapTile, fogId);
					if (changedChannel != null)
					{
						FogOpenParams fogOpenParams2 = new FogOpenParams();
						fogOpenParams2.MapTileIndex = j;
						fogOpenParams2.Channel = changedChannel.Value;
						this.FogOpenParamList.Add(fogOpenParams2);
					}
				}
			}
			this.SetFogTitleColor(0f);
		}

		// Token: 0x06037579 RID: 226681 RVA: 0x00D258B4 File Offset: 0x00D23AB4
		private EChannel? GetChangedChannel(UUITextureBase mapTile, int fogId)
		{
			if (mapTile.texture == null)
			{
				return null;
			}
			string name = mapTile.texture.GetName();
			if (name == "T_CommonDefault_UI")
			{
				return null;
			}
			ValueTuple<int, int> positionKeyByTileName = this.GetPositionKeyByTileName(name);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
			string blockIndex = defaultInterpolatedStringHandler.ToStringAndClear();
			FogBlock? fogBlockConfig = MapConfig.Instance.GetFogBlockConfig(blockIndex, this.MapId);
			if (fogBlockConfig == null)
			{
				return null;
			}
			if (fogId == fogBlockConfig.Value.R)
			{
				return new EChannel?(EChannel.R);
			}
			if (fogId == fogBlockConfig.Value.G)
			{
				return new EChannel?(EChannel.G);
			}
			if (fogId == fogBlockConfig.Value.B)
			{
				return new EChannel?(EChannel.B);
			}
			if (fogId == fogBlockConfig.Value.Alpha)
			{
				return new EChannel?(EChannel.A);
			}
			return null;
		}

		// Token: 0x0603757A RID: 226682 RVA: 0x00D259D0 File Offset: 0x00D23BD0
		private void ChangeTileChannelColor(UUITextureBase title, EChannel channel, float value)
		{
			FLinearColor flinearColor = title.GetColor().ReinterpretAsLinear();
			switch (channel)
			{
			case EChannel.R:
				flinearColor.R = value;
				break;
			case EChannel.G:
				flinearColor.G = value;
				break;
			case EChannel.B:
				flinearColor.B = value;
				break;
			case EChannel.A:
				flinearColor.A = value;
				break;
			}
			title.SetColor(flinearColor.ToFColor(false));
		}

		// Token: 0x0603757B RID: 226683 RVA: 0x00D25A38 File Offset: 0x00D23C38
		private void ChangeTileChannelColorV2(UUITextureBase tile, int channel, float value)
		{
			if (channel < 4)
			{
				FLinearColor? flinearColor = null;
				if (tile.CustomVectorParameterTMap.Contains(MapTileMgr.FOG_MASK_1))
				{
					flinearColor = new FLinearColor?(tile.CustomVectorParameterTMap.Get(MapTileMgr.FOG_MASK_1));
				}
				FLinearColor value2 = flinearColor ?? new FLinearColor(0f, 0f, 0f, 0f);
				switch (channel)
				{
				case 0:
					value2.R = value;
					break;
				case 1:
					value2.G = value;
					break;
				case 2:
					value2.B = value;
					break;
				case 3:
					value2.A = value;
					break;
				}
				tile.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_1, value2);
				return;
			}
			FLinearColor? flinearColor2 = null;
			if (tile.CustomVectorParameterTMap.Contains(MapTileMgr.FOG_MASK_2))
			{
				flinearColor2 = new FLinearColor?(tile.CustomVectorParameterTMap.Get(MapTileMgr.FOG_MASK_2));
			}
			FLinearColor value3 = flinearColor2 ?? new FLinearColor(0f, 0f, 0f, 0f);
			switch (channel)
			{
			case 4:
				value3.R = value;
				break;
			case 5:
				value3.G = value;
				break;
			case 6:
				value3.B = value;
				break;
			case 7:
				value3.A = value;
				break;
			}
			tile.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_2, value3);
		}

		// Token: 0x0603757C RID: 226684 RVA: 0x00D25BA4 File Offset: 0x00D23DA4
		private void SetFogTitleColor(float value)
		{
			if (this.FogOpenParamList == null || this.FogOpenParamList.Count == 0 || this.MapTiles == null)
			{
				return;
			}
			foreach (FogOpenParams fogOpenParams in this.FogOpenParamList)
			{
				int mapTileIndex = fogOpenParams.MapTileIndex;
				if (mapTileIndex >= 0 && mapTileIndex < this.MapTiles.Count)
				{
					UUITextureBase uuitextureBase = this.MapTiles[mapTileIndex];
					if (this.MapVersion == 2)
					{
						this.ChangeTileChannelColorV2(uuitextureBase, fogOpenParams.ChannelV2, value);
					}
					else
					{
						this.ChangeTileChannelColor(uuitextureBase, fogOpenParams.Channel, value);
					}
				}
			}
		}

		// Token: 0x0603757D RID: 226685 RVA: 0x00D25C5C File Offset: 0x00D23E5C
		private void HandleUnlockFog()
		{
			if (this.MapVersion != 2)
			{
				return;
			}
			if (this.FogOpenParamList == null || this.FogOpenParamList.Count == 0 || this.MapTiles == null)
			{
				return;
			}
			Vector2D vector2D = null;
			foreach (FogOpenParams fogOpenParams in this.FogOpenParamList)
			{
				int mapTileIndex = fogOpenParams.MapTileIndex;
				if (vector2D == null)
				{
					MapTileMgrParams mapTileParams = this.MapTileParams;
					object obj = (mapTileParams != null) ? mapTileParams.FogUnlockItem : null;
					ULGUICanvas renderCanvas = UiLayer.Instance.UiRootItem.GetRenderCanvas();
					object obj2 = obj;
					if (obj2 == null)
					{
						new FVector2D(0f, 0f);
					}
					else
					{
						obj2.GetAnchorOffset();
					}
					FVector2D fvector2D = (obj2 != null) ? obj2.GetPositionInViewPort(true) : new FVector2D(0f, 0f);
					FIntPoint viewportSize = renderCanvas.GetViewportSize();
					vector2D = new Vector2D((double)(fvector2D.X / (float)viewportSize.X), (double)(fvector2D.Y / (float)viewportSize.Y));
				}
				if (mapTileIndex >= 0 && mapTileIndex < this.MapTiles.Count)
				{
					UUITextureBase uuitextureBase = this.MapTiles[mapTileIndex];
					uuitextureBase.SetCustomMaterialScalarParameter(MapTileMgr.FOG_UNLOCK_CENTERX_NAME, (float)((vector2D != null) ? vector2D.X : 0.5));
					uuitextureBase.SetCustomMaterialScalarParameter(MapTileMgr.FOG_UNLOCK_CENTERY_NAME, (float)((vector2D != null) ? vector2D.Y : 0.5));
				}
			}
		}

		// Token: 0x0603757E RID: 226686 RVA: 0x00D25DD8 File Offset: 0x00D23FD8
		private FVectorDouble GetUnlockFogCenter(int fogId)
		{
			MapFog? mapFogConfig = WorldMapConfig.Instance.GetMapFogConfig(fogId);
			if (mapFogConfig == null)
			{
				ELogAuthor author = ELogAuthor.LYX;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(58, 1);
				defaultInterpolatedStringHandler.AppendLiteral("FogId ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(fogId);
				defaultInterpolatedStringHandler.AppendLiteral(" not found in config, can not unlock material effect");
				MapLogger.Error(author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return new FVectorDouble(0.0, 0.0, 0.0);
			}
			int[] array = mapFogConfig.Value.FogUnlockPosition();
			return new FVectorDouble((double)array[0], (double)array[1], (double)array[2]);
		}

		// Token: 0x0603757F RID: 226687 RVA: 0x00D25E80 File Offset: 0x00D24080
		public void HandleDelegate()
		{
			if (this.FogOpenDelegate == null)
			{
				return;
			}
			this.HandleUnlockFog();
			int? mapDissolveTime = MapConfig.Instance.GetMapDissolveTime();
			float duration = (mapDissolveTime != null) ? ((float)mapDissolveTime.GetValueOrDefault()) : 0f;
			ULTweener fogOpenTweener = this.FogOpenTweener;
			if (fogOpenTweener != null && fogOpenTweener.IsValid())
			{
				this.FogOpenTweener.Kill(false);
				this.FogOpenTweener = null;
			}
			this.FogOpenTweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.FogOpenDelegate, 0f, 1f, duration, 0f, LTweenEase.OutCubic);
			this.ToHandleUnlockFogId = -1;
		}

		// Token: 0x06037580 RID: 226688 RVA: 0x00D25F18 File Offset: 0x00D24118
		public void UnBindDelegate()
		{
			if (this.FogOpenDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.SetFogTitleColor));
				this.FogOpenDelegate = null;
			}
			ULTweener fogOpenTweener = this.FogOpenTweener;
			if (fogOpenTweener != null && fogOpenTweener.IsValid())
			{
				this.FogOpenTweener.Kill(false);
				this.FogOpenTweener = null;
			}
		}

		// Token: 0x06037581 RID: 226689 RVA: 0x00D25F6C File Offset: 0x00D2416C
		private void UpdateSingleTileOpenArea(UUITextureBase mapTile, [Nullable(2)] UTexture textureObject = null, int part = 0)
		{
			UTexture texture = mapTile.texture;
			if (texture == null)
			{
				return;
			}
			string name = texture.GetName();
			if (name == "T_CommonDefault_UI")
			{
				mapTile.SetColor(this.FogDefaultColor);
				return;
			}
			ValueTuple<int, int> positionKeyByTileName = this.GetPositionKeyByTileName(name);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
			string blockIndex = defaultInterpolatedStringHandler.ToStringAndClear();
			if (this.MapVersion == 2)
			{
				if (textureObject != null && textureObject.IsValid())
				{
					if (part == 1)
					{
						mapTile.SetCustomMaterialTextureParameter(MapTileMgr.FOG_TEXTURE_1, textureObject);
					}
					else
					{
						mapTile.SetCustomMaterialTextureParameter(MapTileMgr.FOG_TEXTURE_2, textureObject);
					}
				}
				this.SetSingleTileOpenArea(mapTile, blockIndex);
				return;
			}
			FogBlock? fogBlockConfig = MapConfig.Instance.GetFogBlockConfig(blockIndex, this.MapId);
			if (fogBlockConfig == null)
			{
				mapTile.SetColor(this.FogDefaultColor);
				return;
			}
			if (textureObject != null && textureObject.IsValid())
			{
				mapTile.SetCustomMaterialTextureParameter(MapTileMgr.FOG_TEXTURE_NAME, textureObject);
			}
			FColor fogAreaStateColor = this.GetFogAreaStateColor(fogBlockConfig.Value);
			mapTile.SetColor(fogAreaStateColor);
		}

		// Token: 0x06037582 RID: 226690 RVA: 0x00D26078 File Offset: 0x00D24278
		private void UpdateMultiMapSingleTileOpenArea(UUITextureBase mapTile, [Nullable(2)] UTexture textureObject = null, int part = 1)
		{
			UTexture texture = mapTile.texture;
			if (texture == null)
			{
				return;
			}
			string name = texture.GetName();
			if (name == "T_CommonDefault_UI")
			{
				mapTile.SetColor(this.TransparentColor);
				return;
			}
			FogBlock? configForBlockByTexName = this.GetConfigForBlockByTexName(name);
			if (this.MapVersion == 2)
			{
				string key;
				int[] source;
				if (this.SubMapTileResourceIds.TryGetValue(mapTile, out key) && this.MiniMapMultiMapTexToArea.TryGetValue(key, out source) && source.Any((int areaId) => (MapConfig.Instance.GetMapFogByAreaId(areaId) ?? Array.Empty<MapFog>()).Any(delegate(MapFog fog)
				{
					HashSet<int> openFogSet = this.OpenFogSet;
					return openFogSet != null && openFogSet.Contains(fog.Fog);
				})))
				{
					mapTile.SetColor(ColorUtils.ColorWhile);
					return;
				}
			}
			else
			{
				if (configForBlockByTexName == null)
				{
					mapTile.SetColor(this.TransparentColor);
					return;
				}
				if (textureObject != null && textureObject.IsValid())
				{
					mapTile.SetCustomMaterialTextureParameter(MapTileMgr.FOG_TEXTURE_NAME, textureObject);
				}
				FColor multiMapFogAreaStateColor = this.GetMultiMapFogAreaStateColor(configForBlockByTexName.Value);
				mapTile.SetColor(multiMapFogAreaStateColor);
			}
		}

		// Token: 0x06037583 RID: 226691 RVA: 0x00D26148 File Offset: 0x00D24348
		private FogBlock? GetConfigForBlockByTexName(string texName)
		{
			ValueTuple<int, int> positionKeyByTileName = this.GetPositionKeyByTileName(texName);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(positionKeyByTileName.Item2);
			string blockIndex = defaultInterpolatedStringHandler.ToStringAndClear();
			return MapConfig.Instance.GetFogBlockConfig(blockIndex, this.MapId);
		}

		// Token: 0x06037584 RID: 226692 RVA: 0x00D261A8 File Offset: 0x00D243A8
		private void SetSingleTileOpenArea(UUITextureBase mapTile, string blockIndex)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.MapId);
			defaultInterpolatedStringHandler.AppendLiteral("_");
			defaultInterpolatedStringHandler.AppendFormatted(blockIndex);
			string text = defaultInterpolatedStringHandler.ToStringAndClear();
			float[] finalColor = this.GetFinalColor(text);
			FLinearColor value = new FLinearColor(finalColor[0], finalColor[1], finalColor[2], finalColor[3]);
			FLinearColor value2 = new FLinearColor(finalColor[4], finalColor[5], finalColor[6], finalColor[7]);
			S_FogToAreaIDs dataTableRow = DataTableUtil.GetDataTableRow<S_FogToAreaIDs>(this.DtFogAreaID, text);
			if (this.OpenFogSet != null && dataTableRow != null)
			{
				TArray<int> areaFogIDs = dataTableRow.AreaFogIDs;
				for (int i = 0; i < areaFogIDs.Num(); i++)
				{
					int num = areaFogIDs.Get(i);
					S_AreaIDToMaskVal? s_AreaIDToMaskVal;
					if (this.ToHandleUnlockFogId != num && this.OpenFogSet.Contains(num) && DataTableUtil.TryGetDataTableRowStruct<S_AreaIDToMaskVal>(this.DtAreaIDToMaskCode, num.ToString(), out s_AreaIDToMaskVal))
					{
						switch (s_AreaIDToMaskVal.Value.Mask)
						{
						case 0:
							value.R = 1f;
							break;
						case 1:
							value.G = 1f;
							break;
						case 2:
							value.B = 1f;
							break;
						case 3:
							value.A = 1f;
							break;
						case 4:
							value2.R = 1f;
							break;
						case 5:
							value2.G = 1f;
							break;
						case 6:
							value2.B = 1f;
							break;
						case 7:
							value2.A = 1f;
							break;
						}
					}
				}
			}
			mapTile.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_1, value);
			mapTile.SetCustomMaterialVectorParameter(MapTileMgr.FOG_MASK_2, value2);
		}

		// Token: 0x06037585 RID: 226693 RVA: 0x00D26360 File Offset: 0x00D24560
		private float[] GetFinalColor(string v2BlockIndex)
		{
			S_FogToAreaIDs dataTableRow = DataTableUtil.GetDataTableRow<S_FogToAreaIDs>(this.DtFogAreaID, v2BlockIndex);
			float[] array = new float[8];
			if (dataTableRow != null && this.OpenFogSet != null)
			{
				foreach (int num in this.OpenFogSet)
				{
					S_AreaIDToMaskVal? s_AreaIDToMaskVal;
					if (this.ToHandleUnlockFogId != num && dataTableRow.AreaFogIDs.Contains(num) && DataTableUtil.TryGetDataTableRowStruct<S_AreaIDToMaskVal>(this.DtAreaIDToMaskCode, num.ToString(), out s_AreaIDToMaskVal))
					{
						array[s_AreaIDToMaskVal.Value.Mask] = 1f;
					}
				}
			}
			InstanceDungeon? instanceDungeon;
			if (!WorldMapConfig.Instance.IsMapInWorld(this.InstanceDungeonId) && (InstanceDungeonConfig.Instance.GetConfig(this.InstanceDungeonId) != null && instanceDungeon.GetValueOrDefault().IsFogFullUnlock))
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = 1f;
				}
			}
			return array;
		}

		// Token: 0x06037586 RID: 226694 RVA: 0x00D26470 File Offset: 0x00D24670
		private FColor GetFogAreaStateColor(FogBlock configFogBlock)
		{
			HashSet<int> openFogSet = this.OpenFogSet;
			byte r = (byte)((openFogSet != null && openFogSet.Contains(configFogBlock.R)) ? 255f : 0f);
			HashSet<int> openFogSet2 = this.OpenFogSet;
			byte g = (byte)((openFogSet2 != null && openFogSet2.Contains(configFogBlock.G)) ? 255f : 0f);
			HashSet<int> openFogSet3 = this.OpenFogSet;
			byte b = (byte)((openFogSet3 != null && openFogSet3.Contains(configFogBlock.B)) ? 255f : 0f);
			HashSet<int> openFogSet4 = this.OpenFogSet;
			byte a = (byte)((openFogSet4 != null && openFogSet4.Contains(configFogBlock.Alpha)) ? 255f : 0f);
			return new FColor(r, g, b, a);
		}

		// Token: 0x06037587 RID: 226695 RVA: 0x00D2652C File Offset: 0x00D2472C
		private FColor GetMultiMapFogAreaStateColor(FogBlock configFogBlock)
		{
			HashSet<int> openFogSet = this.OpenFogSet;
			byte b = (byte)((openFogSet != null && openFogSet.Contains(configFogBlock.R)) ? 255f : 0f);
			HashSet<int> openFogSet2 = this.OpenFogSet;
			byte b2 = (byte)((openFogSet2 != null && openFogSet2.Contains(configFogBlock.G)) ? 255f : 0f);
			HashSet<int> openFogSet3 = this.OpenFogSet;
			byte b3 = (byte)((openFogSet3 != null && openFogSet3.Contains(configFogBlock.B)) ? 255f : 0f);
			HashSet<int> openFogSet4 = this.OpenFogSet;
			byte b4 = (byte)((openFogSet4 != null && openFogSet4.Contains(configFogBlock.Alpha)) ? 255f : 0f);
			if ((float)Math.Abs((int)(b - 255)) < 1.1754944E-38f || (float)Math.Abs((int)(b2 - 255)) < 1.1754944E-38f || (float)Math.Abs((int)(b3 - 255)) < 1.1754944E-38f || (float)Math.Abs((int)(b4 - 255)) < 1.1754944E-38f)
			{
				return new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			}
			return new FColor(b, b2, b3, b4);
		}

		// Token: 0x06037588 RID: 226696 RVA: 0x00D26650 File Offset: 0x00D24850
		public bool InValidTile(global::Vector worldPosition)
		{
			ITilePosition tilePosition = MapUtil.GetTilePosition(worldPosition, 0f);
			return tilePosition.X >= this.TileNum.MinX && tilePosition.X <= this.TileNum.MaxX && tilePosition.Y >= this.TileNum.MinY && tilePosition.Y <= this.TileNum.MaxY;
		}

		// Token: 0x06037589 RID: 226697 RVA: 0x00D266BA File Offset: 0x00D248BA
		[NullableContext(2)]
		public Vector2D GetMapSizeOverride()
		{
			return this.OverrideMapSize;
		}

		// Token: 0x0603758A RID: 226698 RVA: 0x00D266C2 File Offset: 0x00D248C2
		[NullableContext(2)]
		public Vector2D GetContentCenterOffset()
		{
			return this.ContentCenterOffset;
		}

		// Token: 0x0603758B RID: 226699 RVA: 0x00D266CC File Offset: 0x00D248CC
		public void UpdateDraggableParams(ITileNum tileNum)
		{
			int num = tileNum.MaxX - tileNum.MinX + 1;
			int num2 = tileNum.MaxY - tileNum.MinY + 1;
			this.OverrideMapSize = Vector2D.Create((double)(num * 850), (double)(num2 * 850));
			float num3 = ((float)(tileNum.MaxX + tileNum.MinX) / 2f - 0.5f) * 850f;
			float num4 = ((float)(tileNum.MaxY + tileNum.MinY) / 2f - 0.5f) * 850f;
			this.ContentCenterOffset = Vector2D.Create((double)(-(double)num3), (double)(-(double)num4));
			this.MapOffset = new Vector4(0f, 0f, 0f, 0f);
			this.FakeOffset = 2550f;
		}

		// Token: 0x0603758C RID: 226700 RVA: 0x00D26791 File Offset: 0x00D24991
		public void ResetDraggableParams()
		{
			this.OverrideMapSize = null;
			this.ContentCenterOffset = null;
			this.OnSetupDraggableParams(this.TileNum);
		}

		// Token: 0x0603758D RID: 226701 RVA: 0x00D267B0 File Offset: 0x00D249B0
		public void OnCalTotalTileNum()
		{
			ITileNum tileNum2;
			if (this.TextureAssets.Count <= 0)
			{
				TileNum tileNum = new TileNum();
				tileNum.MaxX = -1;
				tileNum.MinX = 1;
				tileNum.MaxY = -1;
				tileNum2 = tileNum;
				tileNum.MinY = 1;
			}
			else
			{
				TileNum tileNum3 = new TileNum();
				tileNum3.MaxX = int.MinValue;
				tileNum3.MinX = int.MaxValue;
				tileNum3.MaxY = int.MinValue;
				tileNum2 = tileNum3;
				tileNum3.MinY = int.MaxValue;
			}
			this.TileNum = tileNum2;
			foreach (Dictionary<string, string> dictionary in this.TextureAssets)
			{
				ValueTuple<int, int> positionKeyByTileName = this.GetPositionKeyByTileName(dictionary["MapTileName"]);
				int item = positionKeyByTileName.Item1;
				int item2 = positionKeyByTileName.Item2;
				this.TileNum.MaxX = Math.Max(item, this.TileNum.MaxX);
				this.TileNum.MinX = Math.Min(item, this.TileNum.MinX);
				this.TileNum.MaxY = Math.Max(item2, this.TileNum.MaxY);
				this.TileNum.MinY = Math.Min(item2, this.TileNum.MinY);
			}
			ValueTuple<int, int> valueTuple = MapTileMgr.OriginAnchoredCount(this.TileNum.MaxX, this.TileNum.MinX);
			int item3 = valueTuple.Item1;
			int item4 = valueTuple.Item2;
			ValueTuple<int, int> valueTuple2 = MapTileMgr.OriginAnchoredCount(this.TileNum.MaxY, this.TileNum.MinY);
			int item5 = valueTuple2.Item1;
			int item6 = valueTuple2.Item2;
			int num = Math.Max(item3, item4);
			int num2 = Math.Max(item5, item6);
			this.TotalTileSize.Set((double)(num * 2 * 850), (double)(num2 * 2 * 850));
		}

		// Token: 0x0401D254 RID: 119380
		private const int FAKE_TILE_COUNT = 3;

		// Token: 0x0401D255 RID: 119381
		private const string MAP_TILE_COMMON = "T_CommonDefault_UI";

		// Token: 0x0401D256 RID: 119382
		private const int MAX_COLOR = 255;

		// Token: 0x0401D257 RID: 119383
		private static readonly FName FOG_TEXTURE_NAME = new FName("FogTexture");

		// Token: 0x0401D258 RID: 119384
		private static readonly FName HD_TEXTURE_NAME = new FName("HDTexture");

		// Token: 0x0401D259 RID: 119385
		private static readonly FName HD_SCALAR_NAME = new FName("UseHDPicture");

		// Token: 0x0401D25A RID: 119386
		private static readonly FName FOG_MASK_1 = new FName("FogMask");

		// Token: 0x0401D25B RID: 119387
		private static readonly FName FOG_MASK_2 = new FName("FogMask2");

		// Token: 0x0401D25C RID: 119388
		private static readonly FName FOG_TEXTURE_1 = MapTileMgr.FOG_TEXTURE_NAME;

		// Token: 0x0401D25D RID: 119389
		private static readonly FName FOG_TEXTURE_2 = new FName("FogTexture2");

		// Token: 0x0401D25E RID: 119390
		private static readonly FName FOG_UNLOCK_CENTERX_NAME = new FName("CenterX");

		// Token: 0x0401D25F RID: 119391
		private static readonly FName FOG_UNLOCK_CENTERY_NAME = new FName("CenterY");

		// Token: 0x0401D260 RID: 119392
		private const string DTPATH_AREA_ID_TO_MASK_CODE = "/Game/Aki/Data/PathLine/FogLine/DT_AreaToMaskCode.DT_AreaToMaskCode";

		// Token: 0x0401D261 RID: 119393
		private const string DTPATH_FOG_AREA_ID = "/Game/Aki/Data/PathLine/FogLine/DT_FogToArea.DT_FogToArea";

		// Token: 0x0401D262 RID: 119394
		private const string V2FogPath = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2";

		// Token: 0x0401D263 RID: 119395
		private const string V2FogMiniPath = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2Mini";

		// Token: 0x0401D264 RID: 119396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUITextureBase> MapTiles;

		// Token: 0x0401D265 RID: 119397
		private readonly List<UUITextureBase> MapTilePool = new List<UUITextureBase>();

		// Token: 0x0401D266 RID: 119398
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MapTileItem> MapTileItems;

		// Token: 0x0401D267 RID: 119399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUITextureBase> SubMapTiles;

		// Token: 0x0401D268 RID: 119400
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUITextureBase> SubMapFadeInTiles;

		// Token: 0x0401D269 RID: 119401
		private readonly List<UUIItem> BorderItems = new List<UUIItem>();

		// Token: 0x0401D26A RID: 119402
		[Nullable(2)]
		private ConditionPassCallback ConditionCallBack;

		// Token: 0x0401D26B RID: 119403
		private readonly Dictionary<string, UTexture> PreloadMapTiles = new Dictionary<string, UTexture>();

		// Token: 0x0401D26C RID: 119404
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private List<Dictionary<string, string>> TextureAssets;

		// Token: 0x0401D26D RID: 119405
		[Nullable(2)]
		public HashSet<int> OpenFogSet;

		// Token: 0x0401D26E RID: 119406
		private int ToHandleUnlockFogId = -1;

		// Token: 0x0401D26F RID: 119407
		private ITileNum TileNum;

		// Token: 0x0401D270 RID: 119408
		private int CurrentColumnNum;

		// Token: 0x0401D271 RID: 119409
		private readonly UUIItem MapRootItem;

		// Token: 0x0401D272 RID: 119410
		private readonly UUIItem TileContainer;

		// Token: 0x0401D273 RID: 119411
		private readonly UUITexture TileTexture;

		// Token: 0x0401D274 RID: 119412
		[Nullable(2)]
		private readonly UUIItem SubMapContainer;

		// Token: 0x0401D275 RID: 119413
		private bool SubMapContainerActive;

		// Token: 0x0401D276 RID: 119414
		[Nullable(2)]
		private readonly UUITexture SubMapTexture;

		// Token: 0x0401D277 RID: 119415
		[Nullable(2)]
		private readonly UUIItem SubMapMask;

		// Token: 0x0401D278 RID: 119416
		[Nullable(2)]
		private ULGUIPlayTweenComponent SubMapContainerTween;

		// Token: 0x0401D279 RID: 119417
		private readonly float SubMapContainerOriginalAlpha;

		// Token: 0x0401D27A RID: 119418
		private readonly EMapType MapType = EMapType.WorldMap;

		// Token: 0x0401D27B RID: 119419
		private int MapId;

		// Token: 0x0401D27C RID: 119420
		private int InstanceDungeonId;

		// Token: 0x0401D27D RID: 119421
		private readonly FColor FogDefaultColor = new FColor(0, 0, 0, byte.MaxValue);

		// Token: 0x0401D27E RID: 119422
		private readonly FColor TransparentColor = new FColor(0, 0, 0, 0);

		// Token: 0x0401D27F RID: 119423
		private readonly Dictionary<string, MultiMapAreaConfig> MultiMapAreaConfigCache = new Dictionary<string, MultiMapAreaConfig>();

		// Token: 0x0401D280 RID: 119424
		private readonly Dictionary<int, int> MultiMapAreaCache = new Dictionary<int, int>();

		// Token: 0x0401D281 RID: 119425
		private int MiniMapShowMultiMapId = -1;

		// Token: 0x0401D282 RID: 119426
		public Vector4 MapOffset;

		// Token: 0x0401D283 RID: 119427
		public float FakeOffset;

		// Token: 0x0401D284 RID: 119428
		private int CurrentFocusRow = int.MaxValue;

		// Token: 0x0401D285 RID: 119429
		private int CurrentFocusColumn = int.MaxValue;

		// Token: 0x0401D286 RID: 119430
		private double CurrentFocusPosU = double.MaxValue;

		// Token: 0x0401D287 RID: 119431
		private double CurrentFocusPosV = double.MaxValue;

		// Token: 0x0401D288 RID: 119432
		[Nullable(2)]
		private FLTweenFloatSetterDynamic FogOpenDelegate;

		// Token: 0x0401D289 RID: 119433
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<FogOpenParams> FogOpenParamList;

		// Token: 0x0401D28A RID: 119434
		[Nullable(2)]
		private ULTweener FogOpenTweener;

		// Token: 0x0401D28B RID: 119435
		private bool IsTileShow;

		// Token: 0x0401D28C RID: 119436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIItem> LineTraceItemList;

		// Token: 0x0401D28D RID: 119437
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper SubMapContainerPlayEndCbWrapper;

		// Token: 0x0401D28E RID: 119438
		private readonly int MapVersion = 1;

		// Token: 0x0401D28F RID: 119439
		[Nullable(2)]
		private readonly UDataTable DtAreaIDToMaskCode;

		// Token: 0x0401D290 RID: 119440
		[Nullable(2)]
		private readonly UDataTable DtFogAreaID;

		// Token: 0x0401D291 RID: 119441
		private readonly MapTileMgrParams MapTileParams;

		// Token: 0x0401D292 RID: 119442
		private bool Destroy;

		// Token: 0x0401D293 RID: 119443
		private EMapGravityDirection MapGravity = EMapGravityDirection.Down;

		// Token: 0x0401D294 RID: 119444
		private List<int> MiniMapTileIndexes = new List<int>();

		// Token: 0x0401D295 RID: 119445
		[Nullable(2)]
		private TSubMapTweenOnComplete SubMapTweenDelegate;

		// Token: 0x0401D296 RID: 119446
		public Vector2D TotalTileSize = Vector2D.Create();

		// Token: 0x0401D297 RID: 119447
		private bool UpdateCurrentAreaMapGroupIdSwitch = true;

		// Token: 0x0401D298 RID: 119448
		private Dictionary<string, int[]> MiniMapMultiMapTexToArea = new Dictionary<string, int[]>();

		// Token: 0x0401D299 RID: 119449
		private readonly Dictionary<UUITextureBase, string> SubMapTileResourceIds = new Dictionary<UUITextureBase, string>();

		// Token: 0x0401D29A RID: 119450
		[Nullable(2)]
		private Vector2D OverrideMapSize;

		// Token: 0x0401D29B RID: 119451
		[Nullable(2)]
		private Vector2D ContentCenterOffset;
	}
}
