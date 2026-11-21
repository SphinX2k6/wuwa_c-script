using System;
using System.Collections.Generic;
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
	// Token: 0x0200447E RID: 17534
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTileMgr
	{
		// Token: 0x0602C497 RID: 181399 RVA: 0x00C72338 File Offset: 0x00C70538
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

		// Token: 0x0602C498 RID: 181400 RVA: 0x00C725E4 File Offset: 0x00C707E4
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

		// Token: 0x0602C499 RID: 181401 RVA: 0x00C72658 File Offset: 0x00C70858
		public void Initialize()
		{
			this.OnCreate();
			this.AddEventListener();
		}

		// Token: 0x0602C49A RID: 181402 RVA: 0x00C72666 File Offset: 0x00C70866
		private void CreateMiniMapMultiMapTexToArea()
		{
			this.MiniMapMultiMapTexToArea.Clear();
			MapConfig.Instance.GetAllSubMapConfig().ForEach(delegate(MultiMap config)
			{
				foreach (string key in config.MiniMapTilePathIter())
				{
					this.MiniMapMultiMapTexToArea[key] = NoLinq.SelectToArray<int, int>(config.GetAreaArray(), delegate(int areaId)
					{
						Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
						return AreaModel.Instance.GetAreaId(areaInfo.Value, new EAreaLevel?(EAreaLevel.FirstLevel));
					});
				}
			});
		}

		// Token: 0x0602C49B RID: 181403 RVA: 0x00C72690 File Offset: 0x00C70890
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

		// Token: 0x0602C49C RID: 181404 RVA: 0x00C726EC File Offset: 0x00C708EC
		public UniTask RebuildTilesAsync()
		{
			MapTileMgr.<RebuildTilesAsync>d__75 <RebuildTilesAsync>d__;
			<RebuildTilesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RebuildTilesAsync>d__.<>4__this = this;
			<RebuildTilesAsync>d__.<>1__state = -1;
			<RebuildTilesAsync>d__.<>t__builder.Start<MapTileMgr.<RebuildTilesAsync>d__75>(ref <RebuildTilesAsync>d__);
			return <RebuildTilesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C49D RID: 181405 RVA: 0x00C7272F File Offset: 0x00C7092F
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

		// Token: 0x0602C49E RID: 181406 RVA: 0x00C72755 File Offset: 0x00C70955
		private void RecycleMapTile(UUITextureBase mapTile)
		{
			mapTile.SetUIActive(false);
			this.MapTilePool.Add(mapTile);
		}

		// Token: 0x0602C49F RID: 181407 RVA: 0x00C7276C File Offset: 0x00C7096C
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

		// Token: 0x0602C4A0 RID: 181408 RVA: 0x00C727C4 File Offset: 0x00C709C4
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

		// Token: 0x0602C4A1 RID: 181409 RVA: 0x00C728A0 File Offset: 0x00C70AA0
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

		// Token: 0x0602C4A2 RID: 181410 RVA: 0x00C72944 File Offset: 0x00C70B44
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

		// Token: 0x0602C4A3 RID: 181411 RVA: 0x00C72A44 File Offset: 0x00C70C44
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

		// Token: 0x0602C4A4 RID: 181412 RVA: 0x00C72B34 File Offset: 0x00C70D34
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UUITextureBase> GetMapTiles()
		{
			return this.MapTiles;
		}

		// Token: 0x0602C4A5 RID: 181413 RVA: 0x00C72B3C File Offset: 0x00C70D3C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<MapTileItem> GetMapTileItems()
		{
			return this.MapTileItems;
		}

		// Token: 0x0602C4A6 RID: 181414 RVA: 0x00C72B44 File Offset: 0x00C70D44
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

		// Token: 0x0602C4A7 RID: 181415 RVA: 0x00C72D68 File Offset: 0x00C70F68
		private string TryTransformTilePath(string inPath, string targetPath)
		{
			if (this.MapType == EMapType.MiniMap)
			{
				return targetPath;
			}
			return inPath;
		}

		// Token: 0x0602C4A8 RID: 181416 RVA: 0x00C72D78 File Offset: 0x00C70F78
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

		// Token: 0x0602C4A9 RID: 181417 RVA: 0x00C72DF4 File Offset: 0x00C70FF4
		[NullableContext(2)]
		public static bool ShouldLoadTileByFilter(int[] tileAreaList, IReadOnlyList<int> displayAreaList)
		{
			if (displayAreaList == null || tileAreaList == null || tileAreaList.Length == 0)
			{
				return true;
			}
			for (int i = 0; i < tileAreaList.Length; i++)
			{
				for (int j = 0; j < displayAreaList.Count; j++)
				{
					if (tileAreaList[i] == displayAreaList[j])
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602C4AA RID: 181418 RVA: 0x00C72E3C File Offset: 0x00C7103C
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

		// Token: 0x0602C4AB RID: 181419 RVA: 0x00C73068 File Offset: 0x00C71268
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

		// Token: 0x0602C4AC RID: 181420 RVA: 0x00C731D7 File Offset: 0x00C713D7
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

		// Token: 0x0602C4AD RID: 181421 RVA: 0x00C731F0 File Offset: 0x00C713F0
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

		// Token: 0x0602C4AE RID: 181422 RVA: 0x00C732F8 File Offset: 0x00C714F8
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

		// Token: 0x0602C4AF RID: 181423 RVA: 0x00C7387C File Offset: 0x00C71A7C
		[NullableContext(0)]
		private ValueTuple<int, int> GetTilePositionByIndex(int index)
		{
			int num = (int)Math.Ceiling((double)(index + 1) / (double)this.CurrentColumnNum);
			int item = index - (num - 1) * this.CurrentColumnNum + this.TileNum.MinX - 3;
			num = -(num - 1) + this.TileNum.MaxY + 3;
			return new ValueTuple<int, int>(item, num);
		}

		// Token: 0x0602C4B0 RID: 181424 RVA: 0x00C738D0 File Offset: 0x00C71AD0
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

		// Token: 0x0602C4B1 RID: 181425 RVA: 0x00C73900 File Offset: 0x00C71B00
		private void LoadSingleFogTile(UUITextureBase mapTileItem, string fogTilePath, [Nullable(2)] TSingleTileLoadedCallBack singleTileLoadedCallback = null)
		{
			MapTileMgr.<>c__DisplayClass96_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass96_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.singleTileLoadedCallback = singleTileLoadedCallback;
			CS$<>8__locals1.tileItem = mapTileItem;
			this.LoadAndSetSingleFogTile(fogTilePath, new Action<UTexture, string>(CS$<>8__locals1.<LoadSingleFogTile>g__LoadCallback|0));
		}

		// Token: 0x0602C4B2 RID: 181426 RVA: 0x00C7393C File Offset: 0x00C71B3C
		private void LoadSingleFogTileV2(UUITextureBase mapTileItem, string fogTilePath, int part, [Nullable(2)] TSingleTileLoadedCallBack singleTileLoadedCallback = null)
		{
			MapTileMgr.<>c__DisplayClass97_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass97_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.part = part;
			CS$<>8__locals1.singleTileLoadedCallback = singleTileLoadedCallback;
			CS$<>8__locals1.tileItem = mapTileItem;
			this.LoadAndSetSingleFogTile(fogTilePath, new Action<UTexture, string>(CS$<>8__locals1.<LoadSingleFogTileV2>g__LoadCallback|0));
		}

		// Token: 0x0602C4B3 RID: 181427 RVA: 0x00C73980 File Offset: 0x00C71B80
		private void LoadMultiMapSingleFogTile(UUITextureBase mapTileItem, string fogTilePath, [Nullable(2)] TSingleTileLoadedCallBack singleTileLoadedCallback = null, int part = 1)
		{
			MapTileMgr.<>c__DisplayClass98_0 CS$<>8__locals1 = new MapTileMgr.<>c__DisplayClass98_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.part = part;
			CS$<>8__locals1.singleTileLoadedCallback = singleTileLoadedCallback;
			CS$<>8__locals1.tileItem = mapTileItem;
			this.LoadAndSetSingleFogTile(fogTilePath, new Action<UTexture, string>(CS$<>8__locals1.<LoadMultiMapSingleFogTile>g__LoadCallback|0));
		}

		// Token: 0x0602C4B4 RID: 181428 RVA: 0x00C739C4 File Offset: 0x00C71BC4
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

		// Token: 0x0602C4B5 RID: 181429 RVA: 0x00C73A00 File Offset: 0x00C71C00
		public UniTask LoadMapBorder()
		{
			MapTileMgr.<LoadMapBorder>d__100 <LoadMapBorder>d__;
			<LoadMapBorder>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMapBorder>d__.<>4__this = this;
			<LoadMapBorder>d__.<>1__state = -1;
			<LoadMapBorder>d__.<>t__builder.Start<MapTileMgr.<LoadMapBorder>d__100>(ref <LoadMapBorder>d__);
			return <LoadMapBorder>d__.<>t__builder.Task;
		}

		// Token: 0x0602C4B6 RID: 181430 RVA: 0x00C73A44 File Offset: 0x00C71C44
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

		// Token: 0x0602C4B7 RID: 181431 RVA: 0x00C73AB8 File Offset: 0x00C71CB8
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

		// Token: 0x0602C4B8 RID: 181432 RVA: 0x00C73DF0 File Offset: 0x00C71FF0
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

		// Token: 0x0602C4B9 RID: 181433 RVA: 0x00C73E68 File Offset: 0x00C72068
		private void OnMultiMapUnlockChanged()
		{
			this.MiniMapShowMultiMapId = -1;
		}

		// Token: 0x0602C4BA RID: 181434 RVA: 0x00C73E74 File Offset: 0x00C72074
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

		// Token: 0x0602C4BB RID: 181435 RVA: 0x00C74230 File Offset: 0x00C72430
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

		// Token: 0x0602C4BC RID: 181436 RVA: 0x00C744BC File Offset: 0x00C726BC
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

		// Token: 0x0602C4BD RID: 181437 RVA: 0x00C74688 File Offset: 0x00C72888
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

		// Token: 0x0602C4BE RID: 181438 RVA: 0x00C747AC File Offset: 0x00C729AC
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

		// Token: 0x0602C4BF RID: 181439 RVA: 0x00C74800 File Offset: 0x00C72A00
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

		// Token: 0x0602C4C0 RID: 181440 RVA: 0x00C74868 File Offset: 0x00C72A68
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

		// Token: 0x0602C4C1 RID: 181441 RVA: 0x00C74938 File Offset: 0x00C72B38
		private void ReleaseSubMapTweenDelegate()
		{
			if (this.SubMapTweenDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.SubMapTweenDelegate);
				this.SubMapTweenDelegate = null;
			}
		}

		// Token: 0x0602C4C2 RID: 181442 RVA: 0x00C74954 File Offset: 0x00C72B54
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

		// Token: 0x0602C4C3 RID: 181443 RVA: 0x00C749A4 File Offset: 0x00C72BA4
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

		// Token: 0x0602C4C4 RID: 181444 RVA: 0x00C74A60 File Offset: 0x00C72C60
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

		// Token: 0x0602C4C5 RID: 181445 RVA: 0x00C74AF8 File Offset: 0x00C72CF8
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

		// Token: 0x0602C4C6 RID: 181446 RVA: 0x00C74B64 File Offset: 0x00C72D64
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

		// Token: 0x0602C4C7 RID: 181447 RVA: 0x00C74BA4 File Offset: 0x00C72DA4
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

		// Token: 0x0602C4C8 RID: 181448 RVA: 0x00C74D38 File Offset: 0x00C72F38
		public void CreateSubMapTile(int groupId, int layer, bool switchLayer = false)
		{
			this.SubMapFadeInTiles = new List<UUITextureBase>();
			List<MultiMap> list = ConfigCommon.ToList<MultiMap>(MapConfig.Instance.GetSubMapConfigByGroupId(groupId));
			if (list == null)
			{
				return;
			}
			List<MultiMap> list2 = new List<MultiMap>();
			foreach (MultiMap item in list)
			{
				if (MapModel.Instance.CheckUnlockMultiMapIds(item.Id))
				{
					list2.Add(item);
				}
			}
			int num = 0;
			int num2 = 0;
			list2.Sort(delegate(MultiMap a, MultiMap b)
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
			using (List<MultiMap>.Enumerator enumerator = list2.GetEnumerator())
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

		// Token: 0x0602C4C9 RID: 181449 RVA: 0x00C75080 File Offset: 0x00C73280
		public Vector2D ConvertUiPositionToMapTilePosition(global::Vector uiPosition)
		{
			return Vector2D.Create();
		}

		// Token: 0x0602C4CA RID: 181450 RVA: 0x00C75088 File Offset: 0x00C73288
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

		// Token: 0x0602C4CB RID: 181451 RVA: 0x00C75178 File Offset: 0x00C73378
		private void OnMapOpenFogChange(int fogId)
		{
			if (this.OpenFogSet == null)
			{
				return;
			}
			this.OpenFogSet.Add(fogId);
			this.UpdateOpenArea();
		}

		// Token: 0x0602C4CC RID: 181452 RVA: 0x00C75198 File Offset: 0x00C73398
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

		// Token: 0x0602C4CD RID: 181453 RVA: 0x00C75208 File Offset: 0x00C73408
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

		// Token: 0x0602C4CE RID: 181454 RVA: 0x00C752A4 File Offset: 0x00C734A4
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

		// Token: 0x0602C4CF RID: 181455 RVA: 0x00C754D0 File Offset: 0x00C736D0
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

		// Token: 0x0602C4D0 RID: 181456 RVA: 0x00C755EC File Offset: 0x00C737EC
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

		// Token: 0x0602C4D1 RID: 181457 RVA: 0x00C75654 File Offset: 0x00C73854
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

		// Token: 0x0602C4D2 RID: 181458 RVA: 0x00C757C0 File Offset: 0x00C739C0
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

		// Token: 0x0602C4D3 RID: 181459 RVA: 0x00C75878 File Offset: 0x00C73A78
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

		// Token: 0x0602C4D4 RID: 181460 RVA: 0x00C759F4 File Offset: 0x00C73BF4
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

		// Token: 0x0602C4D5 RID: 181461 RVA: 0x00C75A9C File Offset: 0x00C73C9C
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

		// Token: 0x0602C4D6 RID: 181462 RVA: 0x00C75B34 File Offset: 0x00C73D34
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

		// Token: 0x0602C4D7 RID: 181463 RVA: 0x00C75B88 File Offset: 0x00C73D88
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

		// Token: 0x0602C4D8 RID: 181464 RVA: 0x00C75C94 File Offset: 0x00C73E94
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
				int[] array;
				if (this.SubMapTileResourceIds.TryGetValue(mapTile, out key) && this.MiniMapMultiMapTexToArea.TryGetValue(key, out array))
				{
					bool flag = false;
					int num = 0;
					while (num < array.Length && !flag)
					{
						foreach (MapFog mapFog in (MapConfig.Instance.GetMapFogByAreaId(array[num]) ?? Array.Empty<MapFog>()))
						{
							HashSet<int> openFogSet = this.OpenFogSet;
							if (openFogSet != null && openFogSet.Contains(mapFog.Fog))
							{
								flag = true;
								break;
							}
						}
						num++;
					}
					if (flag)
					{
						mapTile.SetColor(ColorUtils.ColorWhile);
						return;
					}
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

		// Token: 0x0602C4D9 RID: 181465 RVA: 0x00C75DE8 File Offset: 0x00C73FE8
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

		// Token: 0x0602C4DA RID: 181466 RVA: 0x00C75E48 File Offset: 0x00C74048
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

		// Token: 0x0602C4DB RID: 181467 RVA: 0x00C76000 File Offset: 0x00C74200
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

		// Token: 0x0602C4DC RID: 181468 RVA: 0x00C76110 File Offset: 0x00C74310
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

		// Token: 0x0602C4DD RID: 181469 RVA: 0x00C761CC File Offset: 0x00C743CC
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

		// Token: 0x0602C4DE RID: 181470 RVA: 0x00C762F0 File Offset: 0x00C744F0
		public bool InValidTile(global::Vector worldPosition)
		{
			ITilePosition tilePosition = MapUtil.GetTilePosition(worldPosition, 0f);
			return tilePosition.X >= this.TileNum.MinX && tilePosition.X <= this.TileNum.MaxX && tilePosition.Y >= this.TileNum.MinY && tilePosition.Y <= this.TileNum.MaxY;
		}

		// Token: 0x0602C4DF RID: 181471 RVA: 0x00C7635A File Offset: 0x00C7455A
		[NullableContext(2)]
		public Vector2D GetMapSizeOverride()
		{
			return this.OverrideMapSize;
		}

		// Token: 0x0602C4E0 RID: 181472 RVA: 0x00C76362 File Offset: 0x00C74562
		[NullableContext(2)]
		public Vector2D GetContentCenterOffset()
		{
			return this.ContentCenterOffset;
		}

		// Token: 0x0602C4E1 RID: 181473 RVA: 0x00C7636C File Offset: 0x00C7456C
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

		// Token: 0x0602C4E2 RID: 181474 RVA: 0x00C76431 File Offset: 0x00C74631
		public void ResetDraggableParams()
		{
			this.OverrideMapSize = null;
			this.ContentCenterOffset = null;
			this.OnSetupDraggableParams(this.TileNum);
		}

		// Token: 0x0602C4E3 RID: 181475 RVA: 0x00C76450 File Offset: 0x00C74650
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

		// Token: 0x04017CF0 RID: 97520
		private const int FAKE_TILE_COUNT = 3;

		// Token: 0x04017CF1 RID: 97521
		private const string MAP_TILE_COMMON = "T_CommonDefault_UI";

		// Token: 0x04017CF2 RID: 97522
		private const int MAX_COLOR = 255;

		// Token: 0x04017CF3 RID: 97523
		private static readonly FName FOG_TEXTURE_NAME = new FName("FogTexture");

		// Token: 0x04017CF4 RID: 97524
		private static readonly FName HD_TEXTURE_NAME = new FName("HDTexture");

		// Token: 0x04017CF5 RID: 97525
		private static readonly FName HD_SCALAR_NAME = new FName("UseHDPicture");

		// Token: 0x04017CF6 RID: 97526
		private static readonly FName FOG_MASK_1 = new FName("FogMask");

		// Token: 0x04017CF7 RID: 97527
		private static readonly FName FOG_MASK_2 = new FName("FogMask2");

		// Token: 0x04017CF8 RID: 97528
		private static readonly FName FOG_TEXTURE_1 = MapTileMgr.FOG_TEXTURE_NAME;

		// Token: 0x04017CF9 RID: 97529
		private static readonly FName FOG_TEXTURE_2 = new FName("FogTexture2");

		// Token: 0x04017CFA RID: 97530
		private static readonly FName FOG_UNLOCK_CENTERX_NAME = new FName("CenterX");

		// Token: 0x04017CFB RID: 97531
		private static readonly FName FOG_UNLOCK_CENTERY_NAME = new FName("CenterY");

		// Token: 0x04017CFC RID: 97532
		private const string DTPATH_AREA_ID_TO_MASK_CODE = "/Game/Aki/Data/PathLine/FogLine/DT_AreaToMaskCode.DT_AreaToMaskCode";

		// Token: 0x04017CFD RID: 97533
		private const string DTPATH_FOG_AREA_ID = "/Game/Aki/Data/PathLine/FogLine/DT_FogToArea.DT_FogToArea";

		// Token: 0x04017CFE RID: 97534
		private const string V2FogPath = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2";

		// Token: 0x04017CFF RID: 97535
		private const string V2FogMiniPath = "/Game/Aki/UI/UIResources/UIWorldMap/Image/FogTilesV2Mini";

		// Token: 0x04017D00 RID: 97536
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUITextureBase> MapTiles;

		// Token: 0x04017D01 RID: 97537
		private readonly List<UUITextureBase> MapTilePool = new List<UUITextureBase>();

		// Token: 0x04017D02 RID: 97538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<MapTileItem> MapTileItems;

		// Token: 0x04017D03 RID: 97539
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUITextureBase> SubMapTiles;

		// Token: 0x04017D04 RID: 97540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUITextureBase> SubMapFadeInTiles;

		// Token: 0x04017D05 RID: 97541
		private readonly List<UUIItem> BorderItems = new List<UUIItem>();

		// Token: 0x04017D06 RID: 97542
		[Nullable(2)]
		private ConditionPassCallback ConditionCallBack;

		// Token: 0x04017D07 RID: 97543
		private readonly Dictionary<string, UTexture> PreloadMapTiles = new Dictionary<string, UTexture>();

		// Token: 0x04017D08 RID: 97544
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private List<Dictionary<string, string>> TextureAssets;

		// Token: 0x04017D09 RID: 97545
		[Nullable(2)]
		public HashSet<int> OpenFogSet;

		// Token: 0x04017D0A RID: 97546
		private int ToHandleUnlockFogId = -1;

		// Token: 0x04017D0B RID: 97547
		private ITileNum TileNum;

		// Token: 0x04017D0C RID: 97548
		private int CurrentColumnNum;

		// Token: 0x04017D0D RID: 97549
		private readonly UUIItem MapRootItem;

		// Token: 0x04017D0E RID: 97550
		private readonly UUIItem TileContainer;

		// Token: 0x04017D0F RID: 97551
		private readonly UUITexture TileTexture;

		// Token: 0x04017D10 RID: 97552
		[Nullable(2)]
		private readonly UUIItem SubMapContainer;

		// Token: 0x04017D11 RID: 97553
		private bool SubMapContainerActive;

		// Token: 0x04017D12 RID: 97554
		[Nullable(2)]
		private readonly UUITexture SubMapTexture;

		// Token: 0x04017D13 RID: 97555
		[Nullable(2)]
		private readonly UUIItem SubMapMask;

		// Token: 0x04017D14 RID: 97556
		[Nullable(2)]
		private ULGUIPlayTweenComponent SubMapContainerTween;

		// Token: 0x04017D15 RID: 97557
		private readonly float SubMapContainerOriginalAlpha;

		// Token: 0x04017D16 RID: 97558
		private readonly EMapType MapType = EMapType.WorldMap;

		// Token: 0x04017D17 RID: 97559
		private int MapId;

		// Token: 0x04017D18 RID: 97560
		private int InstanceDungeonId;

		// Token: 0x04017D19 RID: 97561
		private readonly FColor FogDefaultColor = new FColor(0, 0, 0, byte.MaxValue);

		// Token: 0x04017D1A RID: 97562
		private readonly FColor TransparentColor = new FColor(0, 0, 0, 0);

		// Token: 0x04017D1B RID: 97563
		private readonly Dictionary<string, MultiMapAreaConfig> MultiMapAreaConfigCache = new Dictionary<string, MultiMapAreaConfig>();

		// Token: 0x04017D1C RID: 97564
		private readonly Dictionary<int, int> MultiMapAreaCache = new Dictionary<int, int>();

		// Token: 0x04017D1D RID: 97565
		private int MiniMapShowMultiMapId = -1;

		// Token: 0x04017D1E RID: 97566
		public Vector4 MapOffset;

		// Token: 0x04017D1F RID: 97567
		public float FakeOffset;

		// Token: 0x04017D20 RID: 97568
		private int CurrentFocusRow = int.MaxValue;

		// Token: 0x04017D21 RID: 97569
		private int CurrentFocusColumn = int.MaxValue;

		// Token: 0x04017D22 RID: 97570
		private double CurrentFocusPosU = double.MaxValue;

		// Token: 0x04017D23 RID: 97571
		private double CurrentFocusPosV = double.MaxValue;

		// Token: 0x04017D24 RID: 97572
		[Nullable(2)]
		private FLTweenFloatSetterDynamic FogOpenDelegate;

		// Token: 0x04017D25 RID: 97573
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<FogOpenParams> FogOpenParamList;

		// Token: 0x04017D26 RID: 97574
		[Nullable(2)]
		private ULTweener FogOpenTweener;

		// Token: 0x04017D27 RID: 97575
		private bool IsTileShow;

		// Token: 0x04017D28 RID: 97576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIItem> LineTraceItemList;

		// Token: 0x04017D29 RID: 97577
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper SubMapContainerPlayEndCbWrapper;

		// Token: 0x04017D2A RID: 97578
		private readonly int MapVersion = 1;

		// Token: 0x04017D2B RID: 97579
		[Nullable(2)]
		private readonly UDataTable DtAreaIDToMaskCode;

		// Token: 0x04017D2C RID: 97580
		[Nullable(2)]
		private readonly UDataTable DtFogAreaID;

		// Token: 0x04017D2D RID: 97581
		private readonly MapTileMgrParams MapTileParams;

		// Token: 0x04017D2E RID: 97582
		private bool Destroy;

		// Token: 0x04017D2F RID: 97583
		private EMapGravityDirection MapGravity = EMapGravityDirection.Down;

		// Token: 0x04017D30 RID: 97584
		private List<int> MiniMapTileIndexes = new List<int>();

		// Token: 0x04017D31 RID: 97585
		[Nullable(2)]
		private TSubMapTweenOnComplete SubMapTweenDelegate;

		// Token: 0x04017D32 RID: 97586
		public Vector2D TotalTileSize = Vector2D.Create();

		// Token: 0x04017D33 RID: 97587
		private bool UpdateCurrentAreaMapGroupIdSwitch = true;

		// Token: 0x04017D34 RID: 97588
		private Dictionary<string, int[]> MiniMapMultiMapTexToArea = new Dictionary<string, int[]>();

		// Token: 0x04017D35 RID: 97589
		private readonly Dictionary<UUITextureBase, string> SubMapTileResourceIds = new Dictionary<UUITextureBase, string>();

		// Token: 0x04017D36 RID: 97590
		[Nullable(2)]
		private Vector2D OverrideMapSize;

		// Token: 0x04017D37 RID: 97591
		[Nullable(2)]
		private Vector2D ContentCenterOffset;
	}
}
