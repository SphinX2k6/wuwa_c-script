using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055AE RID: 21934
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGameInfo
	{
		// Token: 0x170086B2 RID: 34482
		// (get) Token: 0x06037E68 RID: 228968 RVA: 0x00D3DDC6 File Offset: 0x00D3BFC6
		public int TeamLv
		{
			get
			{
				return this.TeamLvInternal;
			}
		}

		// Token: 0x06037E69 RID: 228969 RVA: 0x00D3DDD0 File Offset: 0x00D3BFD0
		public void SetTeamLv(int lv, int? eventType = null)
		{
			int changeCount = lv - this.TeamLvInternal;
			this.TeamLvInternal = lv;
			MapRogueMainView view = this.View;
			if (view != null)
			{
				view.RefreshTeamLv();
			}
			MapRogueMainView view2 = this.View;
			if (view2 != null)
			{
				MapRogueMapModule mapModule = view2.MapModule;
				if (mapModule != null)
				{
					mapModule.RefreshAllEventLv();
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RogueResTeamLvChange, lv);
			if (eventType == null)
			{
				return;
			}
			foreach (int num in MapRogueConfig.Instance.GetGlobalParamConfig().Value.GetShowLvChangeEventTypeArray())
			{
				int? num2 = eventType;
				if (num == num2.GetValueOrDefault() & num2 != null)
				{
					this.PushGetItemData(this.LvItemId, changeCount);
					return;
				}
			}
		}

		// Token: 0x170086B3 RID: 34483
		// (get) Token: 0x06037E6A RID: 228970 RVA: 0x00D3DE86 File Offset: 0x00D3C086
		public int TeamLvAnim
		{
			get
			{
				int teamLvAnimInterval = this.TeamLvAnimInterval;
				this.TeamLvAnimInterval = this.TeamLvInternal;
				return teamLvAnimInterval;
			}
		}

		// Token: 0x170086B4 RID: 34484
		// (get) Token: 0x06037E6B RID: 228971 RVA: 0x00D3DE9A File Offset: 0x00D3C09A
		// (set) Token: 0x06037E6C RID: 228972 RVA: 0x00D3DEA2 File Offset: 0x00D3C0A2
		public bool InBattle
		{
			get
			{
				return this.InBattleInternal;
			}
			set
			{
				this.InBattleInternal = value;
			}
		}

		// Token: 0x170086B5 RID: 34485
		// (get) Token: 0x06037E6D RID: 228973 RVA: 0x00D3DEAB File Offset: 0x00D3C0AB
		// (set) Token: 0x06037E6E RID: 228974 RVA: 0x00D3DEB3 File Offset: 0x00D3C0B3
		public int PlayerGridIndex
		{
			get
			{
				return this.PlayerGridIndexInternal;
			}
			set
			{
				this.PlayerGridIndexInternal = value;
				MapRogueMainView view = this.View;
				if (view != null)
				{
					MapRogueMapModule mapModule = view.MapModule;
					if (mapModule != null)
					{
						mapModule.SetRolePos(this.PlayerGridIndex);
					}
				}
				this.RefreshPerspectiveModeGrid(this.PlayerGridIndex);
			}
		}

		// Token: 0x170086B6 RID: 34486
		// (get) Token: 0x06037E6F RID: 228975 RVA: 0x00D3DEEA File Offset: 0x00D3C0EA
		public int CenterIndex
		{
			get
			{
				return MapRogueDefine.GridLocationToIndex(this.Center.X, this.Center.Y, this.MapWidth);
			}
		}

		// Token: 0x06037E70 RID: 228976 RVA: 0x00D3DF0D File Offset: 0x00D3C10D
		public MapRogueMapPoint GetGridPos(int gridId)
		{
			return MapRogueDefine.IndexToGridLocation(gridId, this.MapWidth);
		}

		// Token: 0x06037E71 RID: 228977 RVA: 0x00D3DF1B File Offset: 0x00D3C11B
		public int GetGridIndex(int x, int y)
		{
			return MapRogueDefine.GridLocationToIndex(x, y, this.MapWidth);
		}

		// Token: 0x06037E72 RID: 228978 RVA: 0x00D3DF2C File Offset: 0x00D3C12C
		public void Refresh(IGameInfoInitData gameInfo)
		{
			this.InstanceId = gameInfo.InstanceId;
			this.RandomSeed = gameInfo.RandomSeed;
			this.MapGrids = gameInfo.MapGrids;
			this.MapWidth = gameInfo.MapWidth;
			this.MapHeight = gameInfo.MapHeight;
			this.Center.X = (int)Math.Floor((double)this.MapWidth / 2.0);
			this.Center.Y = (int)Math.Floor((double)this.MapHeight / 2.0);
			this.PlayerGridIndexInternal = gameInfo.PlayerGridIndex;
			this.TeamLvInternal = gameInfo.TeamLv;
			this.TeamLvAnimInterval = gameInfo.TeamLv;
			this.InBattleInternal = gameInfo.InBattle;
			this.MoodRuleIdInternal = gameInfo.MoodRuleId;
			this.MoodMin = gameInfo.MoodMin;
			this.MoodMax = gameInfo.MoodMax;
			this.MoodInternal = gameInfo.InitMood;
			GridsConstructor gridConstructor = new GridsConstructor
			{
				Matrix = new List<IPathNode>(this.MapGrids),
				Width = this.MapWidth,
				Height = this.MapHeight
			};
			this.PathFinder = new GridPathFinder(gridConstructor, true, true, EHeuristicFunction.Manhattan);
			this.ActorPool = new MapRogueActorPool();
			this.IsEnd = false;
			this.ActivateTimer();
			this.ResetViewPromise();
			this.MapScale = (double)this.GetCacheMapScale();
		}

		// Token: 0x06037E73 RID: 228979 RVA: 0x00D3E084 File Offset: 0x00D3C284
		private float GetCacheMapScale()
		{
			RogueResInstGrid? insGridConfigByInstId = MapRogueConfig.Instance.GetInsGridConfigByInstId(this.InstanceId);
			if (insGridConfigByInstId == null)
			{
				return 1f;
			}
			int num = insGridConfigByInstId.Value.MapInitScale / 1000;
			Dictionary<int, float> player = LocalStorage.GetPlayer<Dictionary<int, float>>(ELocalStoragePlayerKey.RogueResMapScale, null);
			if (player == null)
			{
				return (float)num;
			}
			float result;
			if (player.TryGetValue(this.InstanceId, out result))
			{
				return result;
			}
			return (float)num;
		}

		// Token: 0x06037E74 RID: 228980 RVA: 0x00D3E0F0 File Offset: 0x00D3C2F0
		private void SetCacheMapScale()
		{
			Dictionary<int, float> dictionary = LocalStorage.GetPlayer<Dictionary<int, float>>(ELocalStoragePlayerKey.RogueResMapScale, null) ?? new Dictionary<int, float>();
			dictionary[this.InstanceId] = (float)this.MapScale;
			LocalStorage.SetPlayer<Dictionary<int, float>>(ELocalStoragePlayerKey.RogueResMapScale, dictionary);
		}

		// Token: 0x06037E75 RID: 228981 RVA: 0x00D3E134 File Offset: 0x00D3C334
		public void Clear()
		{
			this.SetCacheMapScale();
			this.CurHoverIndex = -1;
			this.CurSelectedIndex = -1;
			this.MoodInternal = 0;
			this.MapGrids.Clear();
			this.Path.Clear();
			this.PathFinder = null;
			this.GetItemDataList.Clear();
			this.DeactivateTimer();
			if (this.ActorPool != null)
			{
				this.ActorPool.Clear();
				this.ActorPool = null;
			}
		}

		// Token: 0x06037E76 RID: 228982 RVA: 0x00D3E1A4 File Offset: 0x00D3C3A4
		[NullableContext(2)]
		public void BindView(MapRogueMainView view)
		{
			this.View = view;
			if (this.View != null)
			{
				this.RefreshPerspectiveModeGrid(this.PlayerGridIndex);
				return;
			}
			this.ResetViewPromise();
			this.SurroundingsGrids.Clear();
			this.HoverSurroundingsGrids.Clear();
		}

		// Token: 0x170086B7 RID: 34487
		// (get) Token: 0x06037E77 RID: 228983 RVA: 0x00D3E1DE File Offset: 0x00D3C3DE
		public bool HasBindView
		{
			get
			{
				return this.View != null;
			}
		}

		// Token: 0x170086B8 RID: 34488
		// (get) Token: 0x06037E78 RID: 228984 RVA: 0x00D3E1E9 File Offset: 0x00D3C3E9
		// (set) Token: 0x06037E79 RID: 228985 RVA: 0x00D3E1F4 File Offset: 0x00D3C3F4
		public EMapRogueGameStage GameStage
		{
			get
			{
				return this.GameStageInternal;
			}
			set
			{
				if (this.GameStage == value)
				{
					return;
				}
				EMapRogueGameStage gameStage = this.GameStage;
				this.GameStageInternal = value;
				switch (value)
				{
				case EMapRogueGameStage.Norm:
				{
					MapRogueMainView view = this.View;
					if (view != null)
					{
						MapRogueMapModule mapModule = view.MapModule;
						if (mapModule != null)
						{
							mapModule.ResetAllPath();
						}
					}
					MapRogueMainView view2 = this.View;
					if (view2 != null)
					{
						MapRogueMapModule mapModule2 = view2.MapModule;
						if (mapModule2 != null)
						{
							mapModule2.SetMapGridBgState(this.CurSelectedIndex, false, null);
						}
					}
					this.CurSelectedIndex = -1;
					this.CurHoverIndex = -1;
					this.ResetHoverPerspectiveModeGrid();
					this.SetInteractAvailable(EMapForbiddenTag.StageLock, true);
					break;
				}
				case EMapRogueGameStage.Wait:
					this.SetInteractAvailable(EMapForbiddenTag.StageLock, false);
					break;
				case EMapRogueGameStage.Move:
				{
					MapRogueMainView view3 = this.View;
					if (view3 != null)
					{
						MapRogueMapModule mapModule3 = view3.MapModule;
						if (mapModule3 != null)
						{
							mapModule3.RolePanel.SetRoleAnim(EMapRogueSpineAnim.Move, true);
						}
					}
					MapRogueMainView view4 = this.View;
					if (view4 != null)
					{
						MapRogueMapModule mapModule4 = view4.MapModule;
						if (mapModule4 != null)
						{
							mapModule4.RolePanel.SetRolePosItemVisible(false);
						}
					}
					break;
				}
				}
				MapRogueMainView view5 = this.View;
				if (view5 == null)
				{
					return;
				}
				view5.ChangeGameStagePerformance(gameStage, this.GameStageInternal);
			}
		}

		// Token: 0x170086B9 RID: 34489
		// (get) Token: 0x06037E7A RID: 228986 RVA: 0x00D3E2FE File Offset: 0x00D3C4FE
		public bool IsStageAvailable
		{
			get
			{
				return this.GameStage == EMapRogueGameStage.Norm;
			}
		}

		// Token: 0x06037E7B RID: 228987 RVA: 0x00D3E309 File Offset: 0x00D3C509
		public void SetInteractAvailable(EMapForbiddenTag tag, bool bAvailable)
		{
			if (bAvailable)
			{
				this.MaskTagSet.Remove(tag);
			}
			else
			{
				this.MaskTagSet.Add(tag);
			}
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			view.SetInteractAvailable(this.MaskTagSet.Count == 0);
		}

		// Token: 0x170086BA RID: 34490
		// (get) Token: 0x06037E7C RID: 228988 RVA: 0x00D3E348 File Offset: 0x00D3C548
		public bool CanInteract
		{
			get
			{
				return this.MaskTagSet.Count == 0;
			}
		}

		// Token: 0x06037E7D RID: 228989 RVA: 0x00D3E358 File Offset: 0x00D3C558
		[NullableContext(2)]
		public void SetTipsItemProxy(bool bVisible, string textId = null)
		{
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			view.SetTipsItem(bVisible, textId);
		}

		// Token: 0x06037E7E RID: 228990 RVA: 0x00D3E36C File Offset: 0x00D3C56C
		private void ActivateTimer()
		{
			this.DeactivateTimer();
			this.ActorPoolTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				MapRogueActorPool actorPool = this.ActorPool;
				if (actorPool == null)
				{
					return;
				}
				actorPool.Tick(100f);
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x06037E7F RID: 228991 RVA: 0x00D3E39D File Offset: 0x00D3C59D
		private void DeactivateTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.ActorPoolTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ActorPoolTimer);
				this.ActorPoolTimer = null;
			}
		}

		// Token: 0x06037E80 RID: 228992 RVA: 0x00D3E3CC File Offset: 0x00D3C5CC
		public void RefreshGrid(int index, bool exploreStateRefresh)
		{
			MapGridData mapGridData = this.MapGrids[index];
			GridPathFinder pathFinder = this.PathFinder;
			if (pathFinder != null)
			{
				pathFinder.UpdateGrid(mapGridData);
			}
			MapRogueMainView view = this.View;
			if (view != null)
			{
				MapRogueMapModule mapModule = view.MapModule;
				if (mapModule != null)
				{
					mapModule.RefreshMapGrid(mapGridData);
				}
			}
			if (!exploreStateRefresh)
			{
				return;
			}
			MapRogueMainView view2 = this.View;
			if (view2 != null)
			{
				view2.RefreshProgress();
			}
			if (!mapGridData.IsExplore)
			{
				return;
			}
			RogueResGlobalParam value = MapRogueConfig.Instance.GetGlobalParamConfig().Value;
			int[] array = value.GetGridTakeTipsEventTypeArray() ?? Array.Empty<int>();
			int i;
			for (i = 0; i < array.Length; i++)
			{
				if (array[i] == mapGridData.EventType)
				{
					MapRogueController.Instance.OpenRogueTipsView(ERogueTipsType.Normal, "RogueRes_Event_Rewards_1", null, null);
					break;
				}
			}
			array = (value.GetGridTakeSpineEventTypeArray() ?? Array.Empty<int>());
			i = 0;
			while (i < array.Length)
			{
				if (array[i] == mapGridData.EventType)
				{
					MapRogueMainView view3 = this.View;
					if (view3 == null)
					{
						return;
					}
					MapRogueMapModule mapModule2 = view3.MapModule;
					if (mapModule2 == null)
					{
						return;
					}
					mapModule2.RolePanel.SetRoleAnim(EMapRogueSpineAnim.Cheer, false);
					return;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06037E81 RID: 228993 RVA: 0x00D3E4DC File Offset: 0x00D3C6DC
		public void SetGridData(int gridIndex, RogueResGridData gridInfo)
		{
			MapGridData mapGridData = new MapGridData();
			mapGridData.RefreshByServer(gridInfo);
			mapGridData.GridIndex = gridIndex;
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			MapRogueMapModule mapModule = view.MapModule;
			if (mapModule == null)
			{
				return;
			}
			mapModule.RefreshMapGrid(mapGridData);
		}

		// Token: 0x06037E82 RID: 228994 RVA: 0x00D3E518 File Offset: 0x00D3C718
		public void SetGridVisionProxy(int index, bool bHasVision)
		{
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			MapRogueMapModule mapModule = view.MapModule;
			if (mapModule == null)
			{
				return;
			}
			mapModule.SetMapGridBgVision(index, bHasVision);
		}

		// Token: 0x06037E83 RID: 228995 RVA: 0x00D3E536 File Offset: 0x00D3C736
		public void SetMapGridBgStateProxy(int gridIndex, bool bSelectOn, bool? bFireEvent = null)
		{
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			MapRogueMapModule mapModule = view.MapModule;
			if (mapModule == null)
			{
				return;
			}
			mapModule.SetMapGridBgState(gridIndex, bSelectOn, bFireEvent);
		}

		// Token: 0x06037E84 RID: 228996 RVA: 0x00D3E555 File Offset: 0x00D3C755
		public bool CanGridCheck(int gridIndex)
		{
			return this.MapGrids[gridIndex].Walkable && gridIndex != this.PlayerGridIndex;
		}

		// Token: 0x06037E85 RID: 228997 RVA: 0x00D3E578 File Offset: 0x00D3C778
		private bool IsOnTheGrid(MapRogueMapPoint position)
		{
			return position.X >= 0 && position.X < this.MapWidth && position.Y >= 0 && position.Y < this.MapHeight;
		}

		// Token: 0x06037E86 RID: 228998 RVA: 0x00D3E5AC File Offset: 0x00D3C7AC
		private HashSet<int> GetPerspectiveModeGridIdList(int centerGridId)
		{
			HashSet<int> hashSet = new HashSet<int>();
			MapRogueMapPoint gridPos = this.GetGridPos(centerGridId);
			MapRogueMapPoint mapRogueMapPoint = new MapRogueMapPoint
			{
				X = gridPos.X - 1,
				Y = gridPos.Y
			};
			MapRogueMapPoint mapRogueMapPoint2 = new MapRogueMapPoint
			{
				X = gridPos.X - 1,
				Y = gridPos.Y + 1
			};
			MapRogueMapPoint mapRogueMapPoint3 = new MapRogueMapPoint
			{
				X = gridPos.X,
				Y = gridPos.Y + 1
			};
			foreach (MapRogueMapPoint mapRogueMapPoint4 in new MapRogueMapPoint[]
			{
				mapRogueMapPoint,
				mapRogueMapPoint2,
				mapRogueMapPoint3
			})
			{
				if (this.IsOnTheGrid(mapRogueMapPoint4))
				{
					hashSet.Add(this.GetGridIndex(mapRogueMapPoint4.X, mapRogueMapPoint4.Y));
				}
			}
			return hashSet;
		}

		// Token: 0x06037E87 RID: 228999 RVA: 0x00D3E680 File Offset: 0x00D3C880
		private void ResetHoverPerspectiveModeGrid()
		{
			foreach (int gridIndex in this.HoverSurroundingsGrids)
			{
				MapRogueMainView view = this.View;
				if (view != null)
				{
					MapRogueMapModule mapModule = view.MapModule;
					if (mapModule != null)
					{
						mapModule.SetPerspectiveMode(gridIndex, false);
					}
				}
			}
			this.HoverSurroundingsGrids.Clear();
		}

		// Token: 0x06037E88 RID: 229000 RVA: 0x00D3E6F8 File Offset: 0x00D3C8F8
		private void RefreshHoverPerspectiveModeGrid(int centerGridId)
		{
			HashSet<int> perspectiveModeGridIdList = this.GetPerspectiveModeGridIdList(centerGridId);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in perspectiveModeGridIdList)
			{
				if (this.HoverSurroundingsGrids.Contains(item))
				{
					hashSet.Add(item);
				}
			}
			foreach (int num in this.HoverSurroundingsGrids)
			{
				if (!hashSet.Contains(num))
				{
					MapRogueMainView view = this.View;
					if (view != null)
					{
						MapRogueMapModule mapModule = view.MapModule;
						if (mapModule != null)
						{
							mapModule.SetPerspectiveMode(num, false);
						}
					}
				}
			}
			foreach (int num2 in perspectiveModeGridIdList)
			{
				if (!hashSet.Contains(num2))
				{
					MapRogueMainView view2 = this.View;
					if (view2 != null)
					{
						MapRogueMapModule mapModule2 = view2.MapModule;
						if (mapModule2 != null)
						{
							mapModule2.SetPerspectiveMode(num2, true);
						}
					}
				}
			}
			this.HoverSurroundingsGrids = perspectiveModeGridIdList;
		}

		// Token: 0x06037E89 RID: 229001 RVA: 0x00D3E830 File Offset: 0x00D3CA30
		private void RefreshPerspectiveModeGrid(int centerGridId)
		{
			HashSet<int> perspectiveModeGridIdList = this.GetPerspectiveModeGridIdList(centerGridId);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in perspectiveModeGridIdList)
			{
				if (this.SurroundingsGrids.Contains(item))
				{
					hashSet.Add(item);
				}
			}
			foreach (int num in this.SurroundingsGrids)
			{
				if (!hashSet.Contains(num))
				{
					MapRogueMainView view = this.View;
					if (view != null)
					{
						MapRogueMapModule mapModule = view.MapModule;
						if (mapModule != null)
						{
							mapModule.SetPerspectiveMode(num, false);
						}
					}
				}
			}
			foreach (int num2 in perspectiveModeGridIdList)
			{
				if (!hashSet.Contains(num2))
				{
					MapRogueMainView view2 = this.View;
					if (view2 != null)
					{
						MapRogueMapModule mapModule2 = view2.MapModule;
						if (mapModule2 != null)
						{
							mapModule2.SetPerspectiveMode(num2, true);
						}
					}
				}
			}
			this.SurroundingsGrids = perspectiveModeGridIdList;
		}

		// Token: 0x06037E8A RID: 229002 RVA: 0x00D3E968 File Offset: 0x00D3CB68
		public bool IsPosInGridRange(int screenPosX, int screenPosY, int gridIndex)
		{
			MapRogueMainView view = this.View;
			IGridRangeInfo gridRangeInfo;
			if (view == null)
			{
				gridRangeInfo = null;
			}
			else
			{
				MapRogueMapModule mapModule = view.MapModule;
				gridRangeInfo = ((mapModule != null) ? mapModule.GetGridRangeInfo(gridIndex) : null);
			}
			IGridRangeInfo gridRangeInfo2 = gridRangeInfo;
			return gridRangeInfo2 != null && MapRogueDefine.InAxisAlignedDiamond(screenPosX, screenPosY, gridRangeInfo2);
		}

		// Token: 0x06037E8B RID: 229003 RVA: 0x00D3E9A2 File Offset: 0x00D3CBA2
		[NullableContext(2)]
		public void FocusOnGrid(int gridId, bool needTween = true, Action callback = null, float? focusTweenTime = null)
		{
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			MapRogueMapModule mapModule = view.MapModule;
			if (mapModule == null)
			{
				return;
			}
			mapModule.FocusOnGrid(gridId, needTween, callback, focusTweenTime);
		}

		// Token: 0x06037E8C RID: 229004 RVA: 0x00D3E9C4 File Offset: 0x00D3CBC4
		public bool IsOverEventRecommendLv(int gridIndex)
		{
			if (!this.MapGrids[gridIndex].HasEvent(new bool?(true)))
			{
				return true;
			}
			int lv = this.MapGrids[gridIndex].Lv;
			int toleranceLv = this.MapGrids[gridIndex].ToleranceLv;
			return this.TeamLv >= lv - toleranceLv;
		}

		// Token: 0x06037E8D RID: 229005 RVA: 0x00D3EA20 File Offset: 0x00D3CC20
		public bool IsGridCanSkipBattle(int gridIndex)
		{
			MapGridData mapGridData = this.MapGrids[gridIndex];
			if (!mapGridData.HasEvent(new bool?(true)))
			{
				return false;
			}
			if (!mapGridData.CanSkipBattle)
			{
				return false;
			}
			int lv = this.MapGrids[gridIndex].Lv;
			int skipBattleLv = this.MapGrids[gridIndex].SkipBattleLv;
			return this.TeamLv >= lv + skipBattleLv;
		}

		// Token: 0x170086BB RID: 34491
		// (get) Token: 0x06037E8E RID: 229006 RVA: 0x00D3EA88 File Offset: 0x00D3CC88
		public EMovePathType MoveState
		{
			get
			{
				if (this.CurSelectedIndex < 0)
				{
					return EMovePathType.UnSelect;
				}
				if (!this.MapGrids[this.CurSelectedIndex].Walkable)
				{
					return EMovePathType.CannotWalk;
				}
				if (!this.MapGrids[this.CurSelectedIndex].IsUnlock())
				{
					return EMovePathType.EventLock;
				}
				if (this.Path.Count == 0)
				{
					return EMovePathType.CannotAchieve;
				}
				if (this.InterruptPathCheck(this.Path))
				{
					return EMovePathType.EventInterrupt;
				}
				return EMovePathType.CanMove;
			}
		}

		// Token: 0x06037E8F RID: 229007 RVA: 0x00D3EAF4 File Offset: 0x00D3CCF4
		private bool InterruptPathCheck(List<int> path)
		{
			for (int i = 0; i < path.Count - 1; i++)
			{
				if (this.MapGrids[path[i]].NeedTriggerEvent())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06037E90 RID: 229008 RVA: 0x00D3EB30 File Offset: 0x00D3CD30
		public void HoverOnTarget(int targetGridId, bool updatePath = true)
		{
			if (!this.HasBindView)
			{
				return;
			}
			if (!this.CanGridCheck(targetGridId))
			{
				this.CurHoverIndex = -1;
				MapRogueMainView view = this.View;
				if (view != null)
				{
					MapRogueMapModule mapModule = view.MapModule;
					if (mapModule != null)
					{
						mapModule.SetInteractState(false, false, null);
					}
				}
				this.ResetAllPath();
				this.ResetHoverPerspectiveModeGrid();
				return;
			}
			if (updatePath)
			{
				this.CurHoverIndex = targetGridId;
				this.RefreshHoverPerspectiveModeGrid(this.CurHoverIndex);
			}
			this.GeneratePathToTarget(targetGridId, updatePath, null);
		}

		// Token: 0x06037E91 RID: 229009 RVA: 0x00D3EBB1 File Offset: 0x00D3CDB1
		public void UnHoverOnTarget(int targetGridId)
		{
			if (!this.IsStageAvailable)
			{
				return;
			}
			if (this.CurHoverIndex != targetGridId)
			{
				return;
			}
			this.CurHoverIndex = -1;
		}

		// Token: 0x06037E92 RID: 229010 RVA: 0x00D3EBD0 File Offset: 0x00D3CDD0
		public void BlankPlaneEnter()
		{
			MapRogueMainView view = this.View;
			if (view != null)
			{
				MapRogueMapModule mapModule = view.MapModule;
				if (mapModule != null)
				{
					mapModule.SetInteractState(false, false, null);
				}
			}
			this.CurHoverIndex = -1;
			this.ResetAllPath();
			this.ResetHoverPerspectiveModeGrid();
		}

		// Token: 0x06037E93 RID: 229011 RVA: 0x00D3EC18 File Offset: 0x00D3CE18
		private void GeneratePathToTarget(int targetGridId, bool updatePath, int? startGridId = null)
		{
			int gridId = startGridId ?? this.PlayerGridIndex;
			if (!this.MapGrids[targetGridId].IsUnlock())
			{
				this.ResetAllPath();
				MapRogueMainView view = this.View;
				if (view != null)
				{
					MapRogueMapModule mapModule = view.MapModule;
					if (mapModule != null)
					{
						mapModule.SetInteractState(false, true, new int?(targetGridId));
					}
				}
				MapRogueMainView view2 = this.View;
				if (view2 == null)
				{
					return;
				}
				MapRogueMapModule mapModule2 = view2.MapModule;
				if (mapModule2 == null)
				{
					return;
				}
				mapModule2.SetMapGridMoveEnable(targetGridId, false);
				return;
			}
			else
			{
				MapRogueMapPoint gridPos = this.GetGridPos(gridId);
				MapRogueMapPoint gridPos2 = this.GetGridPos(targetGridId);
				List<int> list = this.PathFinder.FindPath(gridPos, gridPos2);
				if (list.Count == 0)
				{
					this.ResetAllPath();
					MapRogueMainView view3 = this.View;
					if (view3 != null)
					{
						MapRogueMapModule mapModule3 = view3.MapModule;
						if (mapModule3 != null)
						{
							mapModule3.SetInteractState(false, true, new int?(targetGridId));
						}
					}
					MapRogueMainView view4 = this.View;
					if (view4 == null)
					{
						return;
					}
					MapRogueMapModule mapModule4 = view4.MapModule;
					if (mapModule4 == null)
					{
						return;
					}
					mapModule4.SetMapGridMoveEnable(targetGridId, false);
					return;
				}
				else if (this.InterruptPathCheck(list))
				{
					this.ResetAllPath();
					this.Path = list;
					MapRogueMainView view5 = this.View;
					if (view5 != null)
					{
						MapRogueMapModule mapModule5 = view5.MapModule;
						if (mapModule5 != null)
						{
							mapModule5.SetInteractState(false, true, new int?(targetGridId));
						}
					}
					MapRogueMainView view6 = this.View;
					if (view6 == null)
					{
						return;
					}
					MapRogueMapModule mapModule6 = view6.MapModule;
					if (mapModule6 == null)
					{
						return;
					}
					mapModule6.SetMapGridMoveEnable(targetGridId, false);
					return;
				}
				else
				{
					MapRogueMainView view7 = this.View;
					if (view7 != null)
					{
						MapRogueMapModule mapModule7 = view7.MapModule;
						if (mapModule7 != null)
						{
							mapModule7.SetInteractState(true, true, new int?(targetGridId));
						}
					}
					MapRogueMainView view8 = this.View;
					if (view8 != null)
					{
						MapRogueMapModule mapModule8 = view8.MapModule;
						if (mapModule8 != null)
						{
							mapModule8.SetMapGridMoveEnable(targetGridId, true);
						}
					}
					if (!updatePath)
					{
						return;
					}
					this.CurSelectedIndex = list[list.Count - 1];
					MapRogueMainView view9 = this.View;
					if (view9 != null)
					{
						MapRogueMapModule mapModule9 = view9.MapModule;
						if (mapModule9 != null)
						{
							mapModule9.CreateAllMapGridPath(this.Path, list);
						}
					}
					this.Path = list;
					return;
				}
			}
		}

		// Token: 0x06037E94 RID: 229012 RVA: 0x00D3EDE4 File Offset: 0x00D3CFE4
		public UniTask CreateGridPathAsync(List<int> path)
		{
			MapRogueGameInfo.<CreateGridPathAsync>d__85 <CreateGridPathAsync>d__;
			<CreateGridPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGridPathAsync>d__.<>4__this = this;
			<CreateGridPathAsync>d__.path = path;
			<CreateGridPathAsync>d__.<>1__state = -1;
			<CreateGridPathAsync>d__.<>t__builder.Start<MapRogueGameInfo.<CreateGridPathAsync>d__85>(ref <CreateGridPathAsync>d__);
			return <CreateGridPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037E95 RID: 229013 RVA: 0x00D3EE30 File Offset: 0x00D3D030
		public void ResetAllPath()
		{
			foreach (int gridId in this.Path)
			{
				this.ResetPath(gridId);
			}
			this.Path.Clear();
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			MapRogueMoodBar moodBar = view.MoodBar;
			if (moodBar == null)
			{
				return;
			}
			moodBar.ClosePreviewValue();
		}

		// Token: 0x06037E96 RID: 229014 RVA: 0x00D3EEA8 File Offset: 0x00D3D0A8
		private void ResetPath(int gridId)
		{
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			MapRogueMapModule mapModule = view.MapModule;
			if (mapModule == null)
			{
				return;
			}
			mapModule.ResetPath(gridId);
		}

		// Token: 0x06037E97 RID: 229015 RVA: 0x00D3EEC8 File Offset: 0x00D3D0C8
		public void SetMood(int mood, int? eventType = null, int? moodMin = null, int? moodMax = null, bool ignoreEvent = false)
		{
			int changeCount = mood - this.MoodInternal;
			this.MoodInternal = mood;
			if (moodMin != null && moodMax != null)
			{
				this.MoodMin = moodMin.Value;
				this.MoodMax = moodMax.Value;
				MapRogueMainView view = this.View;
				if (view != null)
				{
					MapRogueMoodBar moodBar = view.MoodBar;
					if (moodBar != null)
					{
						moodBar.SetLimit(this.MoodMin, this.MoodMax);
					}
				}
			}
			MapRogueMainView view2 = this.View;
			if (view2 != null)
			{
				MapRogueMoodBar moodBar2 = view2.MoodBar;
				if (moodBar2 != null)
				{
					moodBar2.SetCurrentValue(mood);
				}
			}
			if (!ignoreEvent)
			{
				EventSystem.Instance.Emit<int, int, int>(EEventName.RogueResMoodChange, mood, this.MoodMin, this.MoodMax);
			}
			if (eventType == null)
			{
				return;
			}
			foreach (int num in MapRogueConfig.Instance.GetGlobalParamConfig().Value.GetShowMoodChangeEventTypeArray())
			{
				int? num2 = eventType;
				if (num == num2.GetValueOrDefault() & num2 != null)
				{
					this.PushGetItemData(this.MoodItemId, changeCount);
					return;
				}
			}
		}

		// Token: 0x170086BC RID: 34492
		// (get) Token: 0x06037E98 RID: 229016 RVA: 0x00D3EFD6 File Offset: 0x00D3D1D6
		public int Mood
		{
			get
			{
				return this.MoodInternal;
			}
		}

		// Token: 0x170086BD RID: 34493
		// (get) Token: 0x06037E99 RID: 229017 RVA: 0x00D3EFDE File Offset: 0x00D3D1DE
		// (set) Token: 0x06037E9A RID: 229018 RVA: 0x00D3EFE8 File Offset: 0x00D3D1E8
		public int MoodRuleId
		{
			get
			{
				return this.MoodRuleIdInternal;
			}
			set
			{
				if (this.MoodRuleIdInternal == value)
				{
					return;
				}
				this.MoodRuleIdInternal = value;
				RogueResMoodRule? moodRuleById = MapRogueConfig.Instance.GetMoodRuleById(value);
				if (moodRuleById == null)
				{
					return;
				}
				MapRogueMainView view = this.View;
				if (view != null)
				{
					MapRogueMoodBar moodBar = view.MoodBar;
					if (moodBar != null)
					{
						moodBar.SetMoodRuleId(value);
					}
				}
				MapRogueMainView view2 = this.View;
				if (view2 != null)
				{
					view2.RefreshMoodMusicState();
				}
				int type = moodRuleById.Value.Type;
				if (type == 1)
				{
					MapRogueController.Instance.OpenRogueTipsView(ERogueTipsType.Normal, moodRuleById.Value.FloatTips, null, null);
					return;
				}
				if (type != 2)
				{
					return;
				}
				MapRogueController.Instance.OpenRogueTipsView(ERogueTipsType.Red, moodRuleById.Value.FloatTips, null, null);
			}
		}

		// Token: 0x06037E9B RID: 229019 RVA: 0x00D3F09C File Offset: 0x00D3D29C
		private void ResetViewPromise()
		{
			if (this.ViewOpenPromise != null)
			{
				this.ViewOpenPromise.SetResult();
			}
			this.ViewOpenPromise = new CustomPromise();
			if (this.ViewLoadPromise != null)
			{
				this.ViewLoadPromise.SetResult();
			}
			this.ViewLoadPromise = new CustomPromise();
			if (this.ViewShowPromise != null)
			{
				this.ViewShowPromise.SetResult();
			}
			this.ViewShowPromise = new CustomPromise();
		}

		// Token: 0x06037E9C RID: 229020 RVA: 0x00D3F104 File Offset: 0x00D3D304
		public void SetMoveTimeGap(int pathLength)
		{
			float value = ConfigCommonParamById.GetFloatConfig("MapRogueRoleMoveMaxDuration").Value;
			float value2 = ConfigCommonParamById.GetFloatConfig("MapRogueRoleMoveSpeed").Value;
			if ((float)pathLength * value2 > value)
			{
				this.MoveTimeGap = (float)((int)Math.Floor((double)(value / (float)pathLength)));
				return;
			}
			this.MoveTimeGap = value2;
		}

		// Token: 0x06037E9D RID: 229021 RVA: 0x00D3F158 File Offset: 0x00D3D358
		public void OnTick(float delta)
		{
			if (this.GameStage != EMapRogueGameStage.Move)
			{
				return;
			}
			this.TempPeriodTime += delta;
			if (this.TempPeriodTime < this.MoveTimeGap)
			{
				float progress = this.TempPeriodTime / this.MoveTimeGap;
				MapRogueMainView view = this.View;
				if (view == null)
				{
					return;
				}
				MapRogueMapModule mapModule = view.MapModule;
				if (mapModule == null)
				{
					return;
				}
				mapModule.SetRolePosByGrid(progress, this.LastMoveGridIndex, this.CurMoveGridIndex);
				return;
			}
			else
			{
				MapRogueMainView view2 = this.View;
				if (view2 != null)
				{
					MapRogueMapModule mapModule2 = view2.MapModule;
					if (mapModule2 != null)
					{
						mapModule2.SetRolePosByGrid(1f, this.LastMoveGridIndex, this.CurMoveGridIndex);
					}
				}
				MapRogueOp curOp = this.CurOp;
				if (curOp == null)
				{
					return;
				}
				curOp.Execute(this, null);
				return;
			}
		}

		// Token: 0x06037E9E RID: 229022 RVA: 0x00D3F200 File Offset: 0x00D3D400
		public void OnCheck(int gridIndex)
		{
			if (!this.IsStageAvailable)
			{
				return;
			}
			this.CurSelectedIndex = gridIndex;
			EMovePathType moveState = this.MoveState;
			if (moveState == EMovePathType.UnSelect || moveState == EMovePathType.CannotWalk)
			{
				this.CurSelectedIndex = -1;
				return;
			}
			MapRogueMainView view = this.View;
			if (view != null)
			{
				MapRogueMapModule mapModule = view.MapModule;
				if (mapModule != null)
				{
					mapModule.FocusOnGrid(this.CurSelectedIndex, true, null, null);
				}
			}
			this.GameStage = EMapRogueGameStage.Wait;
			MapGridData gridData = this.MapGrids[this.CurSelectedIndex];
			MapRogueMainView view2 = this.View;
			if (view2 == null)
			{
				return;
			}
			view2.OpenPopupView(gridData);
		}

		// Token: 0x06037E9F RID: 229023 RVA: 0x00D3F28C File Offset: 0x00D3D48C
		public void OnMove(int? gridIndex = null)
		{
			if (!this.IsStageAvailable)
			{
				return;
			}
			this.CurSelectedIndex = (gridIndex ?? this.CurHoverIndex);
			if (this.MoveState != EMovePathType.CanMove)
			{
				this.CurSelectedIndex = -1;
				return;
			}
			MapRogueMainView view = this.View;
			if (view != null)
			{
				MapRogueMapModule mapModule = view.MapModule;
				if (mapModule != null)
				{
					mapModule.SetMapGridBgState(this.CurSelectedIndex, true, null);
				}
			}
			Action<bool> callbackAfterConfirm = delegate(bool confirm)
			{
				if (!confirm)
				{
					MapRogueMainView view2 = this.View;
					if (view2 == null)
					{
						return;
					}
					MapRogueMapModule mapModule2 = view2.MapModule;
					if (mapModule2 == null)
					{
						return;
					}
					mapModule2.SetMapGridBgState(this.CurSelectedIndex, false, null);
				}
			};
			this.RequestMove(callbackAfterConfirm);
		}

		// Token: 0x06037EA0 RID: 229024 RVA: 0x00D3F314 File Offset: 0x00D3D514
		[NullableContext(2)]
		public void RequestMove(Action<bool> callbackAfterConfirm = null)
		{
			MapRogueGameInfo.<>c__DisplayClass111_0 CS$<>8__locals1 = new MapRogueGameInfo.<>c__DisplayClass111_0();
			CS$<>8__locals1.callbackAfterConfirm = callbackAfterConfirm;
			CS$<>8__locals1.<>4__this = this;
			if (!this.NotTipsRecommend && !this.IsOverEventRecommendLv(this.CurSelectedIndex))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MapRogueHighLvEventConfirm);
				confirmBoxDataNew.HasToggle = true;
				confirmBoxDataNew.ToggleTextKey = "RogueRes_LvlHint_Desc";
				confirmBoxDataNew.FunctionMap.Add(1, new Action(CS$<>8__locals1.<RequestMove>g__cancel|0));
				confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<RequestMove>g__moveRequest|1));
				confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
				{
					CS$<>8__locals1.<>4__this.NotTipsRecommend = isSelectOn;
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (!this.NotTipsSkipBattle && this.IsGridCanSkipBattle(this.CurSelectedIndex))
			{
				ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.RogueResSkipBattleConfirm);
				confirmBoxDataNew2.HasToggle = true;
				confirmBoxDataNew2.ToggleTextKey = "RogueRes_FightSweepConfirm_Hint";
				confirmBoxDataNew2.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew2.FunctionMap.Add(0, new Action(CS$<>8__locals1.<RequestMove>g__cancel|0));
				confirmBoxDataNew2.FunctionMap.Add(1, new Action(CS$<>8__locals1.<RequestMove>g__noSkipBattle|2));
				confirmBoxDataNew2.FunctionMap.Add(2, new Action(CS$<>8__locals1.<RequestMove>g__skipBattle|3));
				confirmBoxDataNew2.SetToggleFunction(delegate(bool isSelectOn)
				{
					CS$<>8__locals1.<>4__this.NotTipsSkipBattle = isSelectOn;
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
				return;
			}
			CS$<>8__locals1.<RequestMove>g__moveRequest|1();
		}

		// Token: 0x06037EA1 RID: 229025 RVA: 0x00D3F464 File Offset: 0x00D3D664
		public void MoveOneStep(int lastGridId, int gridId)
		{
			this.ResetPath(gridId);
			this.TempPeriodTime = 0f;
			this.LastMoveGridIndex = lastGridId;
			this.CurMoveGridIndex = gridId;
			MapRogueMainView view = this.View;
			if (view != null)
			{
				MapRogueMapModule mapModule = view.MapModule;
				if (mapModule != null)
				{
					mapModule.RolePanel.SetRoleDirection(gridId > lastGridId);
				}
			}
			this.RefreshPerspectiveModeGrid(gridId);
		}

		// Token: 0x06037EA2 RID: 229026 RVA: 0x00D3F4C0 File Offset: 0x00D3D6C0
		public void EndMove()
		{
			this.CurOp = null;
			this.Path.Clear();
			MapRogueMainView view = this.View;
			if (view != null)
			{
				MapRogueMapModule mapModule = view.MapModule;
				if (mapModule != null)
				{
					mapModule.RolePanel.SetRoleAnim(EMapRogueSpineAnim.Idle, true);
				}
			}
			MapRogueMainView view2 = this.View;
			if (view2 == null)
			{
				return;
			}
			MapRogueMapModule mapModule2 = view2.MapModule;
			if (mapModule2 == null)
			{
				return;
			}
			mapModule2.RolePanel.SetRolePosItemVisible(true);
		}

		// Token: 0x06037EA3 RID: 229027 RVA: 0x00D3F524 File Offset: 0x00D3D724
		public UniTask TeleportFlow(int playerGridIndex, List<int> unlockGrids)
		{
			MapRogueGameInfo.<TeleportFlow>d__114 <TeleportFlow>d__;
			<TeleportFlow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TeleportFlow>d__.<>4__this = this;
			<TeleportFlow>d__.playerGridIndex = playerGridIndex;
			<TeleportFlow>d__.unlockGrids = unlockGrids;
			<TeleportFlow>d__.<>1__state = -1;
			<TeleportFlow>d__.<>t__builder.Start<MapRogueGameInfo.<TeleportFlow>d__114>(ref <TeleportFlow>d__);
			return <TeleportFlow>d__.<>t__builder.Task;
		}

		// Token: 0x06037EA4 RID: 229028 RVA: 0x00D3F577 File Offset: 0x00D3D777
		public void RoleAnimProxy(EMapRogueSpineAnim anim, bool loop = true)
		{
			MapRogueMainView view = this.View;
			if (view == null)
			{
				return;
			}
			MapRogueMapModule mapModule = view.MapModule;
			if (mapModule == null)
			{
				return;
			}
			mapModule.RolePanel.SetRoleAnim(anim, loop);
		}

		// Token: 0x06037EA5 RID: 229029 RVA: 0x00D3F59C File Offset: 0x00D3D79C
		public void PushGetItemData(int itemId, int changeCount)
		{
			if (changeCount == 0)
			{
				return;
			}
			IRogueGetListItemData item = new RogueGetListItemData
			{
				ItemId = itemId,
				ChangeCount = changeCount
			};
			this.GetItemDataList.Add(item);
		}

		// Token: 0x06037EA6 RID: 229030 RVA: 0x00D3F5CD File Offset: 0x00D3D7CD
		[NullableContext(2)]
		public IRogueGetListItemData ShiftGetItemData()
		{
			if (this.GetItemDataList.Count == 0)
			{
				return null;
			}
			IRogueGetListItemData result = this.GetItemDataList[0];
			this.GetItemDataList.RemoveAt(0);
			return result;
		}

		// Token: 0x06037EA7 RID: 229031 RVA: 0x00D3F5F6 File Offset: 0x00D3D7F6
		public bool IsGetItemDataEmpty()
		{
			return this.GetItemDataList.Count == 0;
		}

		// Token: 0x06037EA8 RID: 229032 RVA: 0x00D3F608 File Offset: 0x00D3D808
		public int ExplorationCurrentProgress()
		{
			RogueResGridExplore? exploreByInstId = MapRogueConfig.Instance.GetExploreByInstId(this.InstanceId);
			if (exploreByInstId == null)
			{
				return 0;
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (MapGridData mapGridData in this.MapGrids)
			{
				if (mapGridData.EventType > 0 && mapGridData.IsExplore)
				{
					int num;
					dictionary.TryGetValue(mapGridData.EventType, out num);
					dictionary[mapGridData.EventType] = num + 1;
				}
			}
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < exploreByInstId.Value.FinishCountTypeLength; i++)
			{
				int[] array = MapRogueDefine.ParseNumbers(exploreByInstId.Value.FinishCountType(i), "#");
				if (array.Length >= 2)
				{
					int key = array[0];
					int num4 = array[1];
					int num5;
					dictionary.TryGetValue(key, out num5);
					num2 += num5;
					num3 += num4;
				}
			}
			return (int)Math.Ceiling((double)num2 / (double)num3 * 100.0);
		}

		// Token: 0x06037EA9 RID: 229033 RVA: 0x00D3F72C File Offset: 0x00D3D92C
		public List<IExploreData> GetAllExplorationData()
		{
			List<IExploreData> list = new List<IExploreData>();
			RogueResGridExplore? exploreByInstId = MapRogueConfig.Instance.GetExploreByInstId(this.InstanceId);
			if (exploreByInstId == null)
			{
				return list;
			}
			int num = 0;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (MapGridData mapGridData in this.MapGrids)
			{
				if (mapGridData.EventType > 0)
				{
					if (mapGridData.IsExplore)
					{
						int num2;
						dictionary.TryGetValue(mapGridData.EventType, out num2);
						dictionary[mapGridData.EventType] = num2 + 1;
					}
					if (exploreByInstId.Value.GetScoreMap(mapGridData.EventType) != null && mapGridData.IsExplore)
					{
						int value = exploreByInstId.Value.GetScoreMap(mapGridData.EventType).Value;
						num += value;
					}
				}
			}
			IExploreData item = new ExploreData
			{
				TitleId = "RogueResExplore_1",
				ValueTxt = num.ToString()
			};
			list.Add(item);
			int num3 = 0;
			int num4 = 0;
			for (int i = 0; i < exploreByInstId.Value.FinishCountTypeLength; i++)
			{
				int[] array = MapRogueDefine.ParseNumbers(exploreByInstId.Value.FinishCountType(i), "#");
				if (array.Length >= 2)
				{
					int key = array[0];
					int num5 = array[1];
					int num6;
					dictionary.TryGetValue(key, out num6);
					num3 += num6;
					num4 += num5;
				}
			}
			int value2 = (int)Math.Ceiling((double)num3 / (double)num4 * 100.0);
			ExploreData exploreData = new ExploreData();
			exploreData.TitleId = "RogueResExplore_2";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			exploreData.ValueTxt = defaultInterpolatedStringHandler.ToStringAndClear();
			IExploreData item2 = exploreData;
			list.Add(item2);
			for (int j = 0; j < exploreByInstId.Value.CountTypeALength; j++)
			{
				int[] array2 = MapRogueDefine.ParseNumbers(exploreByInstId.Value.CountTypeA(j), "#");
				if (array2.Length >= 2)
				{
					int key2 = array2[0];
					int value3 = array2[1];
					int value4;
					dictionary.TryGetValue(key2, out value4);
					ExploreData exploreData2 = new ExploreData();
					exploreData2.TitleId = ((j < exploreByInstId.Value.DescALength) ? exploreByInstId.Value.DescA(j) : "");
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(value4);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value3);
					exploreData2.ValueTxt = defaultInterpolatedStringHandler.ToStringAndClear();
					IExploreData item3 = exploreData2;
					list.Add(item3);
				}
			}
			for (int k = 0; k < exploreByInstId.Value.CountTypeBLength; k++)
			{
				int key3 = exploreByInstId.Value.CountTypeB(k);
				int num7;
				dictionary.TryGetValue(key3, out num7);
				IExploreData item4 = new ExploreData
				{
					TitleId = ((k < exploreByInstId.Value.DescBLength) ? exploreByInstId.Value.DescB(k) : ""),
					ValueTxt = num7.ToString()
				};
				list.Add(item4);
			}
			return list;
		}

		// Token: 0x06037EAA RID: 229034 RVA: 0x00D3FA90 File Offset: 0x00D3DC90
		public void TriggerGuideEventOnFocusStart()
		{
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapMoveTweenStarOrEnd, true);
		}

		// Token: 0x06037EAB RID: 229035 RVA: 0x00D3FAA3 File Offset: 0x00D3DCA3
		public void TriggerGuideEventOnFocusEnd()
		{
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapMoveTweenStarOrEnd, false);
		}

		// Token: 0x0401D5D6 RID: 120278
		public int InstanceId;

		// Token: 0x0401D5D7 RID: 120279
		public int RandomSeed;

		// Token: 0x0401D5D8 RID: 120280
		[Nullable(2)]
		private MapRogueMainView View;

		// Token: 0x0401D5D9 RID: 120281
		[Nullable(2)]
		private GridPathFinder PathFinder;

		// Token: 0x0401D5DA RID: 120282
		private EMapRogueGameStage GameStageInternal;

		// Token: 0x0401D5DB RID: 120283
		public int CurHoverIndex = -1;

		// Token: 0x0401D5DC RID: 120284
		public int CurSelectedIndex = -1;

		// Token: 0x0401D5DD RID: 120285
		private int PlayerGridIndexInternal;

		// Token: 0x0401D5DE RID: 120286
		public List<MapGridData> MapGrids = new List<MapGridData>();

		// Token: 0x0401D5DF RID: 120287
		public int MapWidth;

		// Token: 0x0401D5E0 RID: 120288
		public int MapHeight;

		// Token: 0x0401D5E1 RID: 120289
		public MapRogueMapPoint Center = new MapRogueMapPoint
		{
			X = 0,
			Y = 0
		};

		// Token: 0x0401D5E2 RID: 120290
		public float MoveTimeGap = ConfigCommonParamById.GetFloatConfig("MapRogueRoleMoveSpeed").GetValueOrDefault(100f);

		// Token: 0x0401D5E3 RID: 120291
		private readonly float FocusTweenTime = (float)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime;

		// Token: 0x0401D5E4 RID: 120292
		private int TeamLvInternal = 1;

		// Token: 0x0401D5E5 RID: 120293
		private int TeamLvAnimInterval = 1;

		// Token: 0x0401D5E6 RID: 120294
		private bool InBattleInternal;

		// Token: 0x0401D5E7 RID: 120295
		private readonly int LvItemId = ConfigCommonParamById.GetIntConfig("MapRogueLvItemId").GetValueOrDefault();

		// Token: 0x0401D5E8 RID: 120296
		private readonly HashSet<EMapForbiddenTag> MaskTagSet = new HashSet<EMapForbiddenTag>();

		// Token: 0x0401D5E9 RID: 120297
		public bool IsEnd;

		// Token: 0x0401D5EA RID: 120298
		public bool EnterBattleFlag;

		// Token: 0x0401D5EB RID: 120299
		private bool NotTipsRecommend;

		// Token: 0x0401D5EC RID: 120300
		private bool NotTipsSkipBattle;

		// Token: 0x0401D5ED RID: 120301
		public bool IsSkipBattle;

		// Token: 0x0401D5EE RID: 120302
		public bool NotTipsInactiveLink;

		// Token: 0x0401D5EF RID: 120303
		public double MapScale = 1.0;

		// Token: 0x0401D5F0 RID: 120304
		[Nullable(2)]
		public MapRogueActorPool ActorPool;

		// Token: 0x0401D5F1 RID: 120305
		[Nullable(2)]
		private TimerHandle ActorPoolTimer;

		// Token: 0x0401D5F2 RID: 120306
		private HashSet<int> SurroundingsGrids = new HashSet<int>();

		// Token: 0x0401D5F3 RID: 120307
		private HashSet<int> HoverSurroundingsGrids = new HashSet<int>();

		// Token: 0x0401D5F4 RID: 120308
		public List<int> Path = new List<int>();

		// Token: 0x0401D5F5 RID: 120309
		public int MoodMin;

		// Token: 0x0401D5F6 RID: 120310
		public int MoodMax;

		// Token: 0x0401D5F7 RID: 120311
		private int MoodInternal;

		// Token: 0x0401D5F8 RID: 120312
		private int MoodRuleIdInternal;

		// Token: 0x0401D5F9 RID: 120313
		public readonly int MoodItemId = ConfigCommonParamById.GetIntConfig("MapRogueMoodItemId").GetValueOrDefault();

		// Token: 0x0401D5FA RID: 120314
		[Nullable(2)]
		public MapRogueOp CurOp;

		// Token: 0x0401D5FB RID: 120315
		[Nullable(2)]
		public CustomPromise ViewOpenPromise;

		// Token: 0x0401D5FC RID: 120316
		[Nullable(2)]
		public CustomPromise ViewShowPromise;

		// Token: 0x0401D5FD RID: 120317
		[Nullable(2)]
		public CustomPromise ViewLoadPromise;

		// Token: 0x0401D5FE RID: 120318
		private float TempPeriodTime;

		// Token: 0x0401D5FF RID: 120319
		private int LastMoveGridIndex;

		// Token: 0x0401D600 RID: 120320
		private int CurMoveGridIndex;

		// Token: 0x0401D601 RID: 120321
		private readonly List<IRogueGetListItemData> GetItemDataList = new List<IRogueGetListItemData>();
	}
}
