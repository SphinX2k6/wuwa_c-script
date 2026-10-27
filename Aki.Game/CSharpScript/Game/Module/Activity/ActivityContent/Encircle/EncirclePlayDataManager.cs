using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006665 RID: 26213
	[NullableContext(1)]
	[Nullable(0)]
	public class EncirclePlayDataManager
	{
		// Token: 0x06041B04 RID: 269060 RVA: 0x00FEDFF0 File Offset: 0x00FEC1F0
		public Dictionary<int, IHexData> InitHexMap(int mapId)
		{
			IReadOnlyList<EncircleMap> encircleMap = ActivityEncircleConfig.Instance.GetEncircleMap(mapId);
			int num = this.CalcMapWidth(encircleMap);
			int count = encircleMap.Count;
			Dictionary<int, IHexData> dictionary = new Dictionary<int, IHexData>();
			List<MapMonster> list = new List<MapMonster>();
			Dictionary<int, LimitWall> dictionary2 = new Dictionary<int, LimitWall>();
			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j < num; j++)
				{
					IHexPos hexPos = EncircleUtils.Instance.PlanePosToHexPos(j, i);
					int? currentMapItemId = this.GetCurrentMapItemId(encircleMap, i, j);
					if (currentMapItemId != null)
					{
						EncircleHexType? mapItemType = ActivityEncircleConfig.Instance.GetMapItemType(currentMapItemId.Value);
						HexData value = new HexData
						{
							HexPos = hexPos,
							Type = mapItemType.Value,
							MapId = currentMapItemId.Value
						};
						int key = EncircleUtils.Instance.HexPosToKey(hexPos);
						dictionary[key] = value;
						EncircleHexType? encircleHexType = mapItemType;
						EncircleHexType encircleHexType2 = EncircleHexType.Monster;
						if (encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null)
						{
							int priority = int.Parse(ActivityEncircleConfig.Instance.GetMapItemMemo(currentMapItemId.Value));
							list.Add(new MapMonster(hexPos, currentMapItemId.Value, priority));
						}
						encircleHexType = mapItemType;
						encircleHexType2 = EncircleHexType.LimitWall;
						if (encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null)
						{
							int limitRound = int.Parse(ActivityEncircleConfig.Instance.GetMapItemMemo(currentMapItemId.Value));
							dictionary2[key] = new LimitWall(hexPos, limitRound);
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

		// Token: 0x06041B05 RID: 269061 RVA: 0x00FEE19C File Offset: 0x00FEC39C
		[NullableContext(2)]
		private int CalcMapWidth(IReadOnlyList<EncircleMap> encircleMaps)
		{
			int num = 1;
			if (encircleMaps == null)
			{
				return 0;
			}
			while (!this.CheckColumnIsEmpty(encircleMaps, num))
			{
				num++;
			}
			return num - 1;
		}

		// Token: 0x06041B06 RID: 269062 RVA: 0x00FEE1C4 File Offset: 0x00FEC3C4
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

		// Token: 0x06041B07 RID: 269063 RVA: 0x00FEE1EC File Offset: 0x00FEC3EC
		private bool CheckColumnIsEmpty(IReadOnlyList<EncircleMap> encircleMaps, int width)
		{
			bool result = true;
			string name = this.GenColumnArrayMethodName(width);
			if (encircleMaps.Count <= 0)
			{
				return true;
			}
			EncircleMap encircleMap = encircleMaps[0];
			MethodInfo method = encircleMap.GetType().GetMethod(name);
			if (method != null)
			{
				using (IEnumerator<EncircleMap> enumerator = encircleMaps.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						EncircleMap encircleMap2 = enumerator.Current;
						int[] array = method.Invoke(encircleMap2, null) as int[];
						if (array != null && array.Length != 0)
						{
							result = false;
						}
					}
					return result;
				}
				return true;
			}
			return true;
		}

		// Token: 0x06041B08 RID: 269064 RVA: 0x00FEE290 File Offset: 0x00FEC490
		[NullableContext(2)]
		private int? GetCurrentMapItemId(IReadOnlyList<EncircleMap> encircleMaps, int r, int q)
		{
			EncircleMap encircleMap = encircleMaps[r];
			string name = this.GenColumnArrayMethodName(q + 1);
			MethodInfo method = encircleMap.GetType().GetMethod(name);
			int[] array = ((method != null) ? method.Invoke(encircleMap, null) : null) as int[];
			if (array == null || array.Length == 0)
			{
				return null;
			}
			int num = Math.Min(EncirclePlayLevelController.Instance.GetCurrentDifficulty(), array.Length - 1);
			return new int?(array[num]);
		}

		// Token: 0x06041B09 RID: 269065 RVA: 0x00FEE308 File Offset: 0x00FEC508
		private string GenColumnArrayMethodName(int num)
		{
			return StringUtils.Format("GetColumn{0}Array", new string[]
			{
				num.ToString()
			});
		}

		// Token: 0x06041B0A RID: 269066 RVA: 0x00FEE324 File Offset: 0x00FEC524
		public int GetMapHeight()
		{
			return this.HexMap.GetHeight();
		}

		// Token: 0x06041B0B RID: 269067 RVA: 0x00FEE331 File Offset: 0x00FEC531
		public int GetMapWidth()
		{
			return this.HexMap.GetWidth();
		}

		// Token: 0x06041B0C RID: 269068 RVA: 0x00FEE33E File Offset: 0x00FEC53E
		private IHexPos ViewPosToHexPos(int? x, int? y)
		{
			return EncircleUtils.Instance.PlanePosToHexPos(x.Value, y.Value);
		}

		// Token: 0x06041B0D RID: 269069 RVA: 0x00FEE358 File Offset: 0x00FEC558
		public bool CheckCanAddObstacle(int? x, int? y)
		{
			return this.HexMap.CheckCanAddObstacle(this.ViewPosToHexPos(x, y));
		}

		// Token: 0x06041B0E RID: 269070 RVA: 0x00FEE36D File Offset: 0x00FEC56D
		public void Clear()
		{
			this.HexMap.Clear();
			this.MoveMonsterIndex = 0;
			this.MoveMonsterEffectIndex = 0;
		}

		// Token: 0x06041B0F RID: 269071 RVA: 0x00FEE388 File Offset: 0x00FEC588
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

		// Token: 0x06041B10 RID: 269072 RVA: 0x00FEE428 File Offset: 0x00FEC628
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

		// Token: 0x06041B11 RID: 269073 RVA: 0x00FEE484 File Offset: 0x00FEC684
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

		// Token: 0x06041B12 RID: 269074 RVA: 0x00FEE56C File Offset: 0x00FEC76C
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

		// Token: 0x06041B13 RID: 269075 RVA: 0x00FEE5FC File Offset: 0x00FEC7FC
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

		// Token: 0x06041B14 RID: 269076 RVA: 0x00FEE6D4 File Offset: 0x00FEC8D4
		public void AddObstacle(int? x, int? y)
		{
			IHexPos hexPos = EncircleUtils.Instance.PlanePosToHexPos(x.Value, y.Value);
			this.HexMap.AddObstacle(hexPos);
			EncirclePlayLevelController.Instance.ChangeViewMapType(1, hexPos, null);
		}

		// Token: 0x06041B15 RID: 269077 RVA: 0x00FEE714 File Offset: 0x00FEC914
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

		// Token: 0x06041B16 RID: 269078 RVA: 0x00FEE778 File Offset: 0x00FEC978
		public bool CheckIsBoundary(IHexPos pos)
		{
			return this.HexMap.IsBoundary(pos);
		}

		// Token: 0x06041B17 RID: 269079 RVA: 0x00FEE788 File Offset: 0x00FEC988
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

		// Token: 0x06041B18 RID: 269080 RVA: 0x00FEE8CC File Offset: 0x00FECACC
		public List<int> GetAllMonsterId()
		{
			List<int> list = new List<int>();
			foreach (MapMonster mapMonster in this.Monsters)
			{
				list.Add(mapMonster.MapItemId.Value);
			}
			return list;
		}

		// Token: 0x040222C6 RID: 139974
		private readonly HexMap HexMap = new HexMap();

		// Token: 0x040222C7 RID: 139975
		private int MoveMonsterIndex;

		// Token: 0x040222C8 RID: 139976
		private int MoveMonsterEffectIndex;

		// Token: 0x040222C9 RID: 139977
		private List<MapMonster> Monsters = new List<MapMonster>();

		// Token: 0x040222CA RID: 139978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, LimitWall> LimitWalls;

		// Token: 0x040222CB RID: 139979
		private const int LIMIT_WALL_ID = 5;
	}
}
