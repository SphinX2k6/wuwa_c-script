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
	// Token: 0x02004584 RID: 17796
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGameInfo
	{
		// Token: 0x17005A79 RID: 23161
		// (get) Token: 0x0602CD66 RID: 183654 RVA: 0x00C8BB0E File Offset: 0x00C89D0E
		public int TeamLv
		{
			get
			{
				return this.TeamLvInternal;
			}
		}

		// Token: 0x0602CD67 RID: 183655 RVA: 0x00C8BB18 File Offset: 0x00C89D18
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

		// Token: 0x17005A7A RID: 23162
		// (get) Token: 0x0602CD68 RID: 183656 RVA: 0x00C8BBCE File Offset: 0x00C89DCE
		public int TeamLvAnim
		{
			get
			{
				int teamLvAnimInterval = this.TeamLvAnimInterval;
				this.TeamLvAnimInterval = this.TeamLvInternal;
				return teamLvAnimInterval;
			}
		}

		// Token: 0x17005A7B RID: 23163
		// (get) Token: 0x0602CD69 RID: 183657 RVA: 0x00C8BBE2 File Offset: 0x00C89DE2
		// (set) Token: 0x0602CD6A RID: 183658 RVA: 0x00C8BBEA File Offset: 0x00C89DEA
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

		// Token: 0x17005A7C RID: 23164
		// (get) Token: 0x0602CD6B RID: 183659 RVA: 0x00C8BBF3 File Offset: 0x00C89DF3
		// (set) Token: 0x0602CD6C RID: 183660 RVA: 0x00C8BBFB File Offset: 0x00C89DFB
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

		// Token: 0x17005A7D RID: 23165
		// (get) Token: 0x0602CD6D RID: 183661 RVA: 0x00C8BC32 File Offset: 0x00C89E32
		public int CenterIndex
		{
			get
			{
				return MapRogueDefine.GridLocationToIndex(this.Center.X, this.Center.Y, this.MapWidth);
			}
		}

		// Token: 0x0602CD6E RID: 183662 RVA: 0x00C8BC55 File Offset: 0x00C89E55
		public MapRogueMapPoint GetGridPos(int gridId)
		{
			return MapRogueDefine.IndexToGridLocation(gridId, this.MapWidth);
		}

		// Token: 0x0602CD6F RID: 183663 RVA: 0x00C8BC63 File Offset: 0x00C89E63
		public int GetGridIndex(int x, int y)
		{
			return MapRogueDefine.GridLocationToIndex(x, y, this.MapWidth);
		}

		// Token: 0x0602CD70 RID: 183664 RVA: 0x00C8BC74 File Offset: 0x00C89E74
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

		// Token: 0x0602CD71 RID: 183665 RVA: 0x00C8BDCC File Offset: 0x00C89FCC
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

		// Token: 0x0602CD72 RID: 183666 RVA: 0x00C8BE38 File Offset: 0x00C8A038
		private void SetCacheMapScale()
		{
			Dictionary<int, float> dictionary = LocalStorage.GetPlayer<Dictionary<int, float>>(ELocalStoragePlayerKey.RogueResMapScale, null) ?? new Dictionary<int, float>();
			dictionary[this.InstanceId] = (float)this.MapScale;
			LocalStorage.SetPlayer<Dictionary<int, float>>(ELocalStoragePlayerKey.RogueResMapScale, dictionary);
		}

		// Token: 0x0602CD73 RID: 183667 RVA: 0x00C8BE7C File Offset: 0x00C8A07C
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

		// Token: 0x0602CD74 RID: 183668 RVA: 0x00C8BEEC File Offset: 0x00C8A0EC
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

		// Token: 0x17005A7E RID: 23166
		// (get) Token: 0x0602CD75 RID: 183669 RVA: 0x00C8BF26 File Offset: 0x00C8A126
		public bool HasBindView
		{
			get
			{
				return this.View != null;
			}
		}

		// Token: 0x17005A7F RID: 23167
		// (get) Token: 0x0602CD76 RID: 183670 RVA: 0x00C8BF31 File Offset: 0x00C8A131
		// (set) Token: 0x0602CD77 RID: 183671 RVA: 0x00C8BF3C File Offset: 0x00C8A13C
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

		// Token: 0x17005A80 RID: 23168
		// (get) Token: 0x0602CD78 RID: 183672 RVA: 0x00C8C046 File Offset: 0x00C8A246
		public bool IsStageAvailable
		{
			get
			{
				return this.GameStage == EMapRogueGameStage.Norm;
			}
		}

		// Token: 0x0602CD79 RID: 183673 RVA: 0x00C8C051 File Offset: 0x00C8A251
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

		// Token: 0x17005A81 RID: 23169
		// (get) Token: 0x0602CD7A RID: 183674 RVA: 0x00C8C090 File Offset: 0x00C8A290
		public bool CanInteract
		{
			get
			{
				return this.MaskTagSet.Count == 0;
			}
		}

		// Token: 0x0602CD7B RID: 183675 RVA: 0x00C8C0A0 File Offset: 0x00C8A2A0
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

		// Token: 0x0602CD7C RID: 183676 RVA: 0x00C8C0B4 File Offset: 0x00C8A2B4
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

		// Token: 0x0602CD7D RID: 183677 RVA: 0x00C8C0E5 File Offset: 0x00C8A2E5
		private void DeactivateTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.ActorPoolTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ActorPoolTimer);
				this.ActorPoolTimer = null;
			}
		}

		// Token: 0x0602CD7E RID: 183678 RVA: 0x00C8C114 File Offset: 0x00C8A314
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

		// Token: 0x0602CD7F RID: 183679 RVA: 0x00C8C224 File Offset: 0x00C8A424
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

		// Token: 0x0602CD80 RID: 183680 RVA: 0x00C8C260 File Offset: 0x00C8A460
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

		// Token: 0x0602CD81 RID: 183681 RVA: 0x00C8C27E File Offset: 0x00C8A47E
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

		// Token: 0x0602CD82 RID: 183682 RVA: 0x00C8C29D File Offset: 0x00C8A49D
		public bool CanGridCheck(int gridIndex)
		{
			return this.MapGrids[gridIndex].Walkable && gridIndex != this.PlayerGridIndex;
		}

		// Token: 0x0602CD83 RID: 183683 RVA: 0x00C8C2C0 File Offset: 0x00C8A4C0
		private bool IsOnTheGrid(MapRogueMapPoint position)
		{
			return position.X >= 0 && position.X < this.MapWidth && position.Y >= 0 && position.Y < this.MapHeight;
		}

		// Token: 0x0602CD84 RID: 183684 RVA: 0x00C8C2F4 File Offset: 0x00C8A4F4
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

		// Token: 0x0602CD85 RID: 183685 RVA: 0x00C8C3C8 File Offset: 0x00C8A5C8
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

		// Token: 0x0602CD86 RID: 183686 RVA: 0x00C8C440 File Offset: 0x00C8A640
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

		// Token: 0x0602CD87 RID: 183687 RVA: 0x00C8C578 File Offset: 0x00C8A778
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

		// Token: 0x0602CD88 RID: 183688 RVA: 0x00C8C6B0 File Offset: 0x00C8A8B0
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

		// Token: 0x0602CD89 RID: 183689 RVA: 0x00C8C6EA File Offset: 0x00C8A8EA
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

		// Token: 0x0602CD8A RID: 183690 RVA: 0x00C8C70C File Offset: 0x00C8A90C
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

		// Token: 0x0602CD8B RID: 183691 RVA: 0x00C8C768 File Offset: 0x00C8A968
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

		// Token: 0x17005A82 RID: 23170
		// (get) Token: 0x0602CD8C RID: 183692 RVA: 0x00C8C7D0 File Offset: 0x00C8A9D0
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

		// Token: 0x0602CD8D RID: 183693 RVA: 0x00C8C83C File Offset: 0x00C8AA3C
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

		// Token: 0x0602CD8E RID: 183694 RVA: 0x00C8C878 File Offset: 0x00C8AA78
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

		// Token: 0x0602CD8F RID: 183695 RVA: 0x00C8C8F9 File Offset: 0x00C8AAF9
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

		// Token: 0x0602CD90 RID: 183696 RVA: 0x00C8C918 File Offset: 0x00C8AB18
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

		// Token: 0x0602CD91 RID: 183697 RVA: 0x00C8C960 File Offset: 0x00C8AB60
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

		// Token: 0x0602CD92 RID: 183698 RVA: 0x00C8CB2C File Offset: 0x00C8AD2C
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

		// Token: 0x0602CD93 RID: 183699 RVA: 0x00C8CB78 File Offset: 0x00C8AD78
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

		// Token: 0x0602CD94 RID: 183700 RVA: 0x00C8CBF0 File Offset: 0x00C8ADF0
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

		// Token: 0x0602CD95 RID: 183701 RVA: 0x00C8CC10 File Offset: 0x00C8AE10
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

		// Token: 0x17005A83 RID: 23171
		// (get) Token: 0x0602CD96 RID: 183702 RVA: 0x00C8CD1E File Offset: 0x00C8AF1E
		public int Mood
		{
			get
			{
				return this.MoodInternal;
			}
		}

		// Token: 0x17005A84 RID: 23172
		// (get) Token: 0x0602CD97 RID: 183703 RVA: 0x00C8CD26 File Offset: 0x00C8AF26
		// (set) Token: 0x0602CD98 RID: 183704 RVA: 0x00C8CD30 File Offset: 0x00C8AF30
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

		// Token: 0x0602CD99 RID: 183705 RVA: 0x00C8CDE4 File Offset: 0x00C8AFE4
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

		// Token: 0x0602CD9A RID: 183706 RVA: 0x00C8CE4C File Offset: 0x00C8B04C
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

		// Token: 0x0602CD9B RID: 183707 RVA: 0x00C8CEA0 File Offset: 0x00C8B0A0
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

		// Token: 0x0602CD9C RID: 183708 RVA: 0x00C8CF48 File Offset: 0x00C8B148
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

		// Token: 0x0602CD9D RID: 183709 RVA: 0x00C8CFD4 File Offset: 0x00C8B1D4
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

		// Token: 0x0602CD9E RID: 183710 RVA: 0x00C8D05C File Offset: 0x00C8B25C
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

		// Token: 0x0602CD9F RID: 183711 RVA: 0x00C8D1AC File Offset: 0x00C8B3AC
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

		// Token: 0x0602CDA0 RID: 183712 RVA: 0x00C8D208 File Offset: 0x00C8B408
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

		// Token: 0x0602CDA1 RID: 183713 RVA: 0x00C8D26C File Offset: 0x00C8B46C
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

		// Token: 0x0602CDA2 RID: 183714 RVA: 0x00C8D2BF File Offset: 0x00C8B4BF
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

		// Token: 0x0602CDA3 RID: 183715 RVA: 0x00C8D2E4 File Offset: 0x00C8B4E4
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

		// Token: 0x0602CDA4 RID: 183716 RVA: 0x00C8D315 File Offset: 0x00C8B515
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

		// Token: 0x0602CDA5 RID: 183717 RVA: 0x00C8D33E File Offset: 0x00C8B53E
		public bool IsGetItemDataEmpty()
		{
			return this.GetItemDataList.Count == 0;
		}

		// Token: 0x0602CDA6 RID: 183718 RVA: 0x00C8D350 File Offset: 0x00C8B550
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

		// Token: 0x0602CDA7 RID: 183719 RVA: 0x00C8D474 File Offset: 0x00C8B674
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

		// Token: 0x0602CDA8 RID: 183720 RVA: 0x00C8D7D8 File Offset: 0x00C8B9D8
		public void TriggerGuideEventOnFocusStart()
		{
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapMoveTweenStarOrEnd, true);
		}

		// Token: 0x0602CDA9 RID: 183721 RVA: 0x00C8D7EB File Offset: 0x00C8B9EB
		public void TriggerGuideEventOnFocusEnd()
		{
			EventSystem.Instance.Emit<bool>(EEventName.RogueMapMoveTweenStarOrEnd, false);
		}

		// Token: 0x04018061 RID: 98401
		public int InstanceId;

		// Token: 0x04018062 RID: 98402
		public int RandomSeed;

		// Token: 0x04018063 RID: 98403
		[Nullable(2)]
		private MapRogueMainView View;

		// Token: 0x04018064 RID: 98404
		[Nullable(2)]
		private GridPathFinder PathFinder;

		// Token: 0x04018065 RID: 98405
		private EMapRogueGameStage GameStageInternal;

		// Token: 0x04018066 RID: 98406
		public int CurHoverIndex = -1;

		// Token: 0x04018067 RID: 98407
		public int CurSelectedIndex = -1;

		// Token: 0x04018068 RID: 98408
		private int PlayerGridIndexInternal;

		// Token: 0x04018069 RID: 98409
		public List<MapGridData> MapGrids = new List<MapGridData>();

		// Token: 0x0401806A RID: 98410
		public int MapWidth;

		// Token: 0x0401806B RID: 98411
		public int MapHeight;

		// Token: 0x0401806C RID: 98412
		public MapRogueMapPoint Center = new MapRogueMapPoint
		{
			X = 0,
			Y = 0
		};

		// Token: 0x0401806D RID: 98413
		public float MoveTimeGap = ConfigCommonParamById.GetFloatConfig("MapRogueRoleMoveSpeed").GetValueOrDefault(100f);

		// Token: 0x0401806E RID: 98414
		private readonly float FocusTweenTime = (float)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime;

		// Token: 0x0401806F RID: 98415
		private int TeamLvInternal = 1;

		// Token: 0x04018070 RID: 98416
		private int TeamLvAnimInterval = 1;

		// Token: 0x04018071 RID: 98417
		private bool InBattleInternal;

		// Token: 0x04018072 RID: 98418
		private readonly int LvItemId = ConfigCommonParamById.GetIntConfig("MapRogueLvItemId").GetValueOrDefault();

		// Token: 0x04018073 RID: 98419
		private readonly HashSet<EMapForbiddenTag> MaskTagSet = new HashSet<EMapForbiddenTag>();

		// Token: 0x04018074 RID: 98420
		public bool IsEnd;

		// Token: 0x04018075 RID: 98421
		public bool EnterBattleFlag;

		// Token: 0x04018076 RID: 98422
		private bool NotTipsRecommend;

		// Token: 0x04018077 RID: 98423
		private bool NotTipsSkipBattle;

		// Token: 0x04018078 RID: 98424
		public bool IsSkipBattle;

		// Token: 0x04018079 RID: 98425
		public bool NotTipsInactiveLink;

		// Token: 0x0401807A RID: 98426
		public double MapScale = 1.0;

		// Token: 0x0401807B RID: 98427
		[Nullable(2)]
		public MapRogueActorPool ActorPool;

		// Token: 0x0401807C RID: 98428
		[Nullable(2)]
		private TimerHandle ActorPoolTimer;

		// Token: 0x0401807D RID: 98429
		private HashSet<int> SurroundingsGrids = new HashSet<int>();

		// Token: 0x0401807E RID: 98430
		private HashSet<int> HoverSurroundingsGrids = new HashSet<int>();

		// Token: 0x0401807F RID: 98431
		public List<int> Path = new List<int>();

		// Token: 0x04018080 RID: 98432
		public int MoodMin;

		// Token: 0x04018081 RID: 98433
		public int MoodMax;

		// Token: 0x04018082 RID: 98434
		private int MoodInternal;

		// Token: 0x04018083 RID: 98435
		private int MoodRuleIdInternal;

		// Token: 0x04018084 RID: 98436
		public readonly int MoodItemId = ConfigCommonParamById.GetIntConfig("MapRogueMoodItemId").GetValueOrDefault();

		// Token: 0x04018085 RID: 98437
		[Nullable(2)]
		public MapRogueOp CurOp;

		// Token: 0x04018086 RID: 98438
		[Nullable(2)]
		public CustomPromise ViewOpenPromise;

		// Token: 0x04018087 RID: 98439
		[Nullable(2)]
		public CustomPromise ViewShowPromise;

		// Token: 0x04018088 RID: 98440
		[Nullable(2)]
		public CustomPromise ViewLoadPromise;

		// Token: 0x04018089 RID: 98441
		private float TempPeriodTime;

		// Token: 0x0401808A RID: 98442
		private int LastMoveGridIndex;

		// Token: 0x0401808B RID: 98443
		private int CurMoveGridIndex;

		// Token: 0x0401808C RID: 98444
		private readonly List<IRogueGetListItemData> GetItemDataList = new List<IRogueGetListItemData>();
	}
}
