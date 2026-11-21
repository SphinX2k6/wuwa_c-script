using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003013 RID: 12307
	[NullableContext(1)]
	[Nullable(0)]
	public class EncirclePlayDataManager
	{
		// Token: 0x0601D323 RID: 119587 RVA: 0x008E9ABC File Offset: 0x008E7CBC
		public Dictionary<int, IHexData> InitHexMap(int mapId)
		{
			IReadOnlyList<EncircleMap> encircleMap = ActivityEncircleConfig.Instance.GetEncircleMap(mapId);
			int num = EncirclePlayDataManager.CalcMapWidth(encircleMap);
			int count = encircleMap.Count;
			Dictionary<int, IHexData> dictionary = new Dictionary<int, IHexData>();
			List<MapMonster> list = new List<MapMonster>();
			Dictionary<int, LimitWall> dictionary2 = new Dictionary<int, LimitWall>();
			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j < num; j++)
				{
					IHexPos hexPos = EncircleUtils.Instance.PlanePosToHexPos(j, i);
					int? currentMapItemId = EncirclePlayDataManager.GetCurrentMapItemId(encircleMap, i, j);
					if (currentMapItemId != null)
					{
						EncircleHexType value = ActivityEncircleConfig.Instance.GetMapItemType(currentMapItemId.Value).Value;
						HexData value2 = new HexData
						{
							HexPos = hexPos,
							Type = value,
							MapId = currentMapItemId.Value
						};
						int key = EncircleUtils.Instance.HexPosToKey(hexPos);
						dictionary[key] = value2;
						if (value != EncircleHexType.Monster)
						{
							if (value == EncircleHexType.LimitWall)
							{
								int limitRound = int.Parse(ActivityEncircleConfig.Instance.GetMapItemMemo(currentMapItemId.Value));
								dictionary2[key] = new LimitWall(hexPos, limitRound);
							}
						}
						else
						{
							int priority = int.Parse(ActivityEncircleConfig.Instance.GetMapItemMemo(currentMapItemId.Value));
							list.Add(new MapMonster(hexPos, currentMapItemId.Value, priority));
						}
					}
				}
			}
			this.HexMap.SetHexes(dictionary);
			this.HexMap.SetHeight(count);
			this.HexMap.SetWidth(num);
			this.Monsters = list;
			this.LimitWalls = dictionary2;
			return dictionary;
		}

		// Token: 0x0601D324 RID: 119588 RVA: 0x008E9C40 File Offset: 0x008E7E40
		[NullableContext(2)]
		private static int CalcMapWidth(IReadOnlyList<EncircleMap> encircleMaps)
		{
			int num = 1;
			if (encircleMaps == null)
			{
				return 0;
			}
			while (!EncirclePlayDataManager.CheckColumnIsEmpty(encircleMaps, num))
			{
				num++;
			}
			return num - 1;
		}

		// Token: 0x0601D325 RID: 119589 RVA: 0x008E9C64 File Offset: 0x008E7E64
		[NullableContext(2)]
		public LimitWall GetLimitWall(int posKey)
		{
			if (this.LimitWalls == null)
			{
				return null;
			}
			LimitWall result;
			this.LimitWalls.TryGetValue(posKey, out result);
			return result;
		}

		// Token: 0x0601D326 RID: 119590 RVA: 0x008E9C8C File Offset: 0x008E7E8C
		private static bool CheckColumnIsEmpty(IReadOnlyList<EncircleMap> encircleMaps, int columnNumber)
		{
			if (encircleMaps.Count <= 0)
			{
				return true;
			}
			if (!EncirclePlayDataManager.IsValidColumnNumber(columnNumber))
			{
				return true;
			}
			for (int i = 0; i < encircleMaps.Count; i++)
			{
				EncircleMap encircleMap = encircleMaps[i];
				int[] columnArray = ref encircleMap.GetColumnArray(columnNumber);
				if (columnArray != null && columnArray.Length > 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0601D327 RID: 119591 RVA: 0x008E9CDC File Offset: 0x008E7EDC
		private static int? GetCurrentMapItemId(IReadOnlyList<EncircleMap> encircleMaps, int r, int q)
		{
			EncircleMap encircleMap = encircleMaps[r];
			int[] columnArray = ref encircleMap.GetColumnArray(q + 1);
			if (columnArray.Length == 0)
			{
				return null;
			}
			int num = Math.Clamp(EncirclePlayLevelController.Instance.GetCurrentDifficulty(), 0, columnArray.Length - 1);
			return new int?(columnArray[num]);
		}

		// Token: 0x0601D328 RID: 119592 RVA: 0x008E9D28 File Offset: 0x008E7F28
		private static bool IsValidColumnNumber(int columnNumber)
		{
			return columnNumber >= 1 && columnNumber <= 11;
		}

		// Token: 0x0601D329 RID: 119593 RVA: 0x008E9D38 File Offset: 0x008E7F38
		public int GetMapHeight()
		{
			return this.HexMap.GetHeight();
		}

		// Token: 0x0601D32A RID: 119594 RVA: 0x008E9D45 File Offset: 0x008E7F45
		public int GetMapWidth()
		{
			return this.HexMap.GetWidth();
		}

		// Token: 0x0601D32B RID: 119595 RVA: 0x008E9D52 File Offset: 0x008E7F52
		private IHexPos ViewPosToHexPos(int? x, int? y)
		{
			return EncircleUtils.Instance.PlanePosToHexPos(x.Value, y.Value);
		}

		// Token: 0x0601D32C RID: 119596 RVA: 0x008E9D6C File Offset: 0x008E7F6C
		public bool CheckCanAddObstacle(int? x, int? y)
		{
			return this.HexMap.CheckCanAddObstacle(this.ViewPosToHexPos(x, y));
		}

		// Token: 0x0601D32D RID: 119597 RVA: 0x008E9D81 File Offset: 0x008E7F81
		public void Clear()
		{
			this.HexMap.Clear();
			this.MoveMonsterIndex = 0;
			this.MoveMonsterEffectIndex = 0;
		}

		// Token: 0x0601D32E RID: 119598 RVA: 0x008E9D9C File Offset: 0x008E7F9C
		public bool TryMoveMonster()
		{
			bool result = false;
			this.MoveMonsterIndex %= this.Monsters.Count;
			MapMonster mapMonster = this.Monsters[this.MoveMonsterIndex];
			if (this.TryMoveMonsterHandle(mapMonster))
			{
				result = true;
			}
			else
			{
				bool flag = !mapMonster.BeCaught;
				mapMonster.BeCaught = true;
				if (!this.IsAllMonsterBeCaught())
				{
					if (flag)
					{
						EncirclePlayLevelController.Instance.SetMonsterDead(mapMonster.MapItemId.Value);
					}
					this.MoveMonsterIndex++;
					result = this.TryMoveMonster();
				}
			}
			this.MoveMonsterIndex++;
			return result;
		}

		// Token: 0x0601D32F RID: 119599 RVA: 0x008E9E3C File Offset: 0x008E803C
		private bool IsAllMonsterBeCaught()
		{
			using (List<MapMonster>.Enumerator enumerator = this.Monsters.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.BeCaught)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0601D330 RID: 119600 RVA: 0x008E9E98 File Offset: 0x008E8098
		public void TryShowMonsterMoveEffect()
		{
			if (this.Monsters.Count < 2)
			{
				return;
			}
			foreach (MapMonster mapMonster in this.Monsters)
			{
				if (mapMonster.BeCaught)
				{
					EncirclePlayLevelController.Instance.ShowItemMoveEffect(mapMonster.Pos, false);
				}
			}
			int index = this.MoveMonsterEffectIndex % this.Monsters.Count;
			if (this.Monsters[index].BeCaught)
			{
				this.MoveMonsterEffectIndex++;
				index = this.MoveMonsterEffectIndex % this.Monsters.Count;
			}
			EncirclePlayLevelController.Instance.ShowItemMoveEffect(this.Monsters[index].Pos, true);
			this.MoveMonsterEffectIndex++;
		}

		// Token: 0x0601D331 RID: 119601 RVA: 0x008E9F80 File Offset: 0x008E8180
		private bool TryMoveMonsterHandle(MapMonster monster)
		{
			IHexPos[] optimalEscapeRoutes = this.HexMap.GetOptimalEscapeRoutes(monster);
			if (optimalEscapeRoutes == null)
			{
				return false;
			}
			if (EncirclePlayLevelController.Instance.GetGmLog())
			{
				List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
				foreach (IHexPos hexPos in optimalEscapeRoutes)
				{
					list.Add(EncircleUtils.Instance.HexPosToPlanePos(hexPos));
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "RoutePath";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoutePath", list);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.MoveMonster(monster, optimalEscapeRoutes);
			return true;
		}

		// Token: 0x0601D332 RID: 119602 RVA: 0x008EA010 File Offset: 0x008E8210
		private void MoveMonster(MapMonster monster, IHexPos[] path)
		{
			IHexPos pos = monster.Pos;
			if (monster.BeTrapped)
			{
				monster.BeTrapped = false;
				EncirclePlayLevelController.Instance.ChangeViewMapType(monster.MapItemId.Value, pos, pos);
				return;
			}
			if (this.HexMap.GetHex(path[1]).Type == EncircleHexType.LimitWall || this.HexMap.GetHex(path[1]).Type == EncircleHexType.Monster)
			{
				EncirclePlayLevelController.Instance.ChangeViewMapType(monster.MapItemId.Value, pos, pos);
				return;
			}
			EncirclePlayLevelController.Instance.ChangeViewMapType(monster.MapItemId.Value, path[1], pos);
			monster.Pos = path[1];
			this.HexMap.CheckInTrap(monster, path[1]);
			this.HexMap.ChangeMapType(path[1], EncircleHexType.Monster);
			if (pos != null)
			{
				this.HexMap.ChangeMapType(pos, EncircleHexType.Plain);
			}
		}

		// Token: 0x0601D333 RID: 119603 RVA: 0x008EA0E8 File Offset: 0x008E82E8
		public void AddObstacle(int? x, int? y)
		{
			IHexPos hexPos = EncircleUtils.Instance.PlanePosToHexPos(x.Value, y.Value);
			this.HexMap.AddObstacle(hexPos);
			EncirclePlayLevelController.Instance.ChangeViewMapType(1, hexPos, null);
		}

		// Token: 0x0601D334 RID: 119604 RVA: 0x008EA128 File Offset: 0x008E8328
		public bool CheckMonsterEscape()
		{
			bool result = false;
			foreach (MapMonster mapMonster in this.Monsters)
			{
				if (this.HexMap.IsBoundary(mapMonster.Pos))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601D335 RID: 119605 RVA: 0x008EA18C File Offset: 0x008E838C
		public bool CheckIsBoundary(IHexPos pos)
		{
			return this.HexMap.IsBoundary(pos);
		}

		// Token: 0x0601D336 RID: 119606 RVA: 0x008EA19C File Offset: 0x008E839C
		public void PushWallLimit()
		{
			List<LimitWall> list = new List<LimitWall>();
			foreach (LimitWall limitWall in this.LimitWalls.Values)
			{
				if (EncirclePlayLevelController.Instance.GetCurrentRound() >= limitWall.LimitRound)
				{
					list.Add(limitWall);
				}
			}
			foreach (LimitWall limitWall2 in list)
			{
				EncirclePlayLevelController.Instance.ChangeViewMapType(0, limitWall2.Pos, null);
				this.HexMap.ChangeMapType(limitWall2.Pos, EncircleHexType.Plain);
				Dictionary<int, LimitWall> limitWalls = this.LimitWalls;
				if (limitWalls != null)
				{
					limitWalls.Remove(EncircleUtils.Instance.HexPosToKey(limitWall2.Pos));
				}
			}
			foreach (LimitWall limitWall3 in this.LimitWalls.Values)
			{
				EncirclePlayLevelController.Instance.ChangeViewMapType(5, limitWall3.Pos, null);
			}
		}

		// Token: 0x0601D337 RID: 119607 RVA: 0x008EA2E0 File Offset: 0x008E84E0
		public List<int> GetAllMonsterId()
		{
			List<int> list = new List<int>();
			foreach (MapMonster mapMonster in this.Monsters)
			{
				list.Add(mapMonster.MapItemId.Value);
			}
			return list;
		}

		// Token: 0x0400F5D0 RID: 62928
		private readonly HexMap HexMap = new HexMap();

		// Token: 0x0400F5D1 RID: 62929
		private int MoveMonsterIndex;

		// Token: 0x0400F5D2 RID: 62930
		private int MoveMonsterEffectIndex;

		// Token: 0x0400F5D3 RID: 62931
		private List<MapMonster> Monsters = new List<MapMonster>();

		// Token: 0x0400F5D4 RID: 62932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, LimitWall> LimitWalls;

		// Token: 0x0400F5D5 RID: 62933
		private const int LIMIT_WALL_ID = 5;
	}
}
