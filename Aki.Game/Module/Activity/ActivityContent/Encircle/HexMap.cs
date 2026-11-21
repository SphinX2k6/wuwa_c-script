using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003010 RID: 12304
	[NullableContext(1)]
	[Nullable(0)]
	internal class HexMap
	{
		// Token: 0x0601D2FD RID: 119549 RVA: 0x008E9225 File Offset: 0x008E7425
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IHexData> GetHexes()
		{
			return this.Hexes;
		}

		// Token: 0x0601D2FE RID: 119550 RVA: 0x008E922D File Offset: 0x008E742D
		public void SetHexes([Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<int, IHexData> hexesInternal)
		{
			this.Hexes = hexesInternal;
		}

		// Token: 0x0601D2FF RID: 119551 RVA: 0x008E9236 File Offset: 0x008E7436
		public void Clear()
		{
			this.Hexes = null;
			this.Width = null;
			this.Height = null;
		}

		// Token: 0x0601D300 RID: 119552 RVA: 0x008E9257 File Offset: 0x008E7457
		public int GetWidth()
		{
			return this.Width.Value;
		}

		// Token: 0x0601D301 RID: 119553 RVA: 0x008E9264 File Offset: 0x008E7464
		public int GetHeight()
		{
			return this.Height.Value;
		}

		// Token: 0x0601D302 RID: 119554 RVA: 0x008E9271 File Offset: 0x008E7471
		public void SetWidth(int width)
		{
			this.Width = new int?(width);
		}

		// Token: 0x0601D303 RID: 119555 RVA: 0x008E927F File Offset: 0x008E747F
		public void SetHeight(int height)
		{
			this.Height = new int?(height);
		}

		// Token: 0x0601D304 RID: 119556 RVA: 0x008E928D File Offset: 0x008E748D
		public void SetHex(IHexPos pos, [Nullable(2)] IHexData hexData)
		{
			this.Hexes[EncircleUtils.Instance.HexPosToKey(pos)] = hexData;
		}

		// Token: 0x0601D305 RID: 119557 RVA: 0x008E92A8 File Offset: 0x008E74A8
		[return: Nullable(2)]
		public IHexData GetHex(IHexPos pos)
		{
			IHexData result;
			this.Hexes.TryGetValue(EncircleUtils.Instance.HexPosToKey(pos), out result);
			return result;
		}

		// Token: 0x0601D306 RID: 119558 RVA: 0x008E92CF File Offset: 0x008E74CF
		public bool CheckCanAddObstacle(IHexPos pos)
		{
			IHexData hex = this.GetHex(pos);
			return hex != null && hex.Type == EncircleHexType.Plain;
		}

		// Token: 0x0601D307 RID: 119559 RVA: 0x008E92E8 File Offset: 0x008E74E8
		public void CheckInTrap(MapMonster monster, IHexPos pos)
		{
			IHexData hex = this.GetHex(pos);
			if (hex == null)
			{
				return;
			}
			if (hex.Type == EncircleHexType.Trap)
			{
				monster.BeTrapped = true;
				hex.Type = EncircleHexType.Plain;
				this.SetHex(monster.Pos, hex);
			}
		}

		// Token: 0x0601D308 RID: 119560 RVA: 0x008E9328 File Offset: 0x008E7528
		protected bool IsValidPos(IHexPos pos)
		{
			if (pos.PosX >= 0)
			{
				int posX = pos.PosX;
				int? num = this.Width;
				if ((posX < num.GetValueOrDefault() & num != null) && pos.PosY >= 0)
				{
					int posY = pos.PosY;
					num = this.Height;
					return posY < num.GetValueOrDefault() & num != null;
				}
			}
			return false;
		}

		// Token: 0x0601D309 RID: 119561 RVA: 0x008E9387 File Offset: 0x008E7587
		protected List<IHexData> GetAllHexes()
		{
			return new List<IHexData>(this.Hexes.Values);
		}

		// Token: 0x0601D30A RID: 119562 RVA: 0x008E939C File Offset: 0x008E759C
		private bool IsWithinMap(IHexPos pos)
		{
			if (pos.PosX >= 0)
			{
				int posX = pos.PosX;
				int? num = this.Width * 2;
				if ((posX < num.GetValueOrDefault() & num != null) && pos.PosY >= 0)
				{
					int posY = pos.PosY;
					num = this.Height;
					return posY < num.GetValueOrDefault() & num != null;
				}
			}
			return false;
		}

		// Token: 0x0601D30B RID: 119563 RVA: 0x008E9420 File Offset: 0x008E7620
		public bool IsBoundary(IHexPos pos)
		{
			if (pos.PosX != 0 && pos.PosX != 1)
			{
				int posX = pos.PosX;
				int? width = this.Width;
				int? num = (width != null) ? new int?(width.GetValueOrDefault() * 2 - 3) : null;
				if (!(posX == num.GetValueOrDefault() & num != null))
				{
					int posX2 = pos.PosX;
					width = this.Width;
					num = ((width != null) ? new int?(width.GetValueOrDefault() * 2 - 2) : null);
					if (!(posX2 == num.GetValueOrDefault() & num != null) && pos.PosY != 0)
					{
						int posY = pos.PosY;
						num = this.Height - 1;
						return posY == num.GetValueOrDefault() & num != null;
					}
				}
			}
			return true;
		}

		// Token: 0x0601D30C RID: 119564 RVA: 0x008E951C File Offset: 0x008E771C
		private bool IsObstacle(IHexPos pos)
		{
			IHexData hexData;
			this.Hexes.TryGetValue(EncircleUtils.Instance.HexPosToKey(pos), out hexData);
			return (hexData != null && hexData.Type == EncircleHexType.Wall) || (hexData != null && hexData.Type == EncircleHexType.InitialWall) || (hexData != null && hexData.Type == EncircleHexType.DifficultyWall);
		}

		// Token: 0x0601D30D RID: 119565 RVA: 0x008E956C File Offset: 0x008E776C
		private bool IsLimitObstacle(IHexPos pos)
		{
			IHexData hexData;
			this.Hexes.TryGetValue(EncircleUtils.Instance.HexPosToKey(pos), out hexData);
			return (hexData != null && hexData.Type == EncircleHexType.LimitWall) || (hexData != null && hexData.Type == EncircleHexType.Monster);
		}

		// Token: 0x0601D30E RID: 119566 RVA: 0x008E95B0 File Offset: 0x008E77B0
		private IHexPos[] GetPriorityOffsets(int priority)
		{
			if (priority == 1)
			{
				return new IHexPos[]
				{
					new HexPos
					{
						PosX = this.DirectionUpLeft.Item1,
						PosY = this.DirectionUpLeft.Item2
					},
					new HexPos
					{
						PosX = this.DirectionUpRight.Item1,
						PosY = this.DirectionUpRight.Item2
					},
					new HexPos
					{
						PosX = this.DirectionLeft.Item1,
						PosY = this.DirectionLeft.Item2
					},
					new HexPos
					{
						PosX = this.DirectionRight.Item1,
						PosY = this.DirectionRight.Item2
					},
					new HexPos
					{
						PosX = this.DirectionDownLeft.Item1,
						PosY = this.DirectionDownLeft.Item2
					},
					new HexPos
					{
						PosX = this.DirectionDownRight.Item1,
						PosY = this.DirectionDownRight.Item2
					}
				};
			}
			return new IHexPos[]
			{
				new HexPos
				{
					PosX = this.DirectionDownRight.Item1,
					PosY = this.DirectionDownRight.Item2
				},
				new HexPos
				{
					PosX = this.DirectionDownLeft.Item1,
					PosY = this.DirectionDownLeft.Item2
				},
				new HexPos
				{
					PosX = this.DirectionRight.Item1,
					PosY = this.DirectionRight.Item2
				},
				new HexPos
				{
					PosX = this.DirectionLeft.Item1,
					PosY = this.DirectionLeft.Item2
				},
				new HexPos
				{
					PosX = this.DirectionUpRight.Item1,
					PosY = this.DirectionUpRight.Item2
				},
				new HexPos
				{
					PosX = this.DirectionUpLeft.Item1,
					PosY = this.DirectionUpLeft.Item2
				}
			};
		}

		// Token: 0x0601D30F RID: 119567 RVA: 0x008E97CC File Offset: 0x008E79CC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public IHexPos[] GetOptimalEscapeRoutes(MapMonster monster)
		{
			IHexPos[] priorityOffsets = this.GetPriorityOffsets(monster.Priority);
			IHexPos pos = monster.Pos;
			List<IHexPos> list = new List<IHexPos>();
			List<IHexPos> list2 = new List<IHexPos>();
			Dictionary<int, IHexPos> dictionary = new Dictionary<int, IHexPos>();
			int key = EncircleUtils.Instance.HexPosToKey(pos);
			dictionary[key] = null;
			list.Add(pos);
			int? num = null;
			while (list.Count > 0 || list2.Count > 0)
			{
				if (list.Count == 0)
				{
					list = list2;
					list2 = new List<IHexPos>();
				}
				IHexPos hexPos = list[0];
				list.RemoveAt(0);
				if (this.IsBoundary(hexPos))
				{
					return this.ReconstructPath(dictionary, hexPos);
				}
				foreach (IHexPos hexPos2 in priorityOffsets)
				{
					IHexPos hexPos3 = new HexPos
					{
						PosX = hexPos.PosX + hexPos2.PosX,
						PosY = hexPos.PosY + hexPos2.PosY
					};
					num = new int?(EncircleUtils.Instance.HexPosToKey(hexPos3));
					if (this.IsWithinMap(hexPos3) && !dictionary.ContainsKey(num.Value) && !this.IsObstacle(hexPos3))
					{
						if (this.IsLimitObstacle(hexPos3))
						{
							list2.Add(hexPos3);
						}
						else
						{
							list.Add(hexPos3);
						}
						dictionary[num.Value] = hexPos;
					}
				}
			}
			return null;
		}

		// Token: 0x0601D310 RID: 119568 RVA: 0x008E9938 File Offset: 0x008E7B38
		private IHexPos[] ReconstructPath([Nullable(new byte[]
		{
			1,
			2
		})] Dictionary<int, IHexPos> cameFrom, IHexPos end)
		{
			List<IHexPos> list = new List<IHexPos>();
			IHexPos hexPos = end;
			while (hexPos != null)
			{
				list.Add(hexPos);
				int key = EncircleUtils.Instance.HexPosToKey(hexPos);
				cameFrom.TryGetValue(key, out hexPos);
			}
			list.Reverse();
			return list.ToArray();
		}

		// Token: 0x0601D311 RID: 119569 RVA: 0x008E997B File Offset: 0x008E7B7B
		public void AddObstacle(IHexPos pos)
		{
			this.ChangeMapType(pos, EncircleHexType.Wall);
		}

		// Token: 0x0601D312 RID: 119570 RVA: 0x008E9988 File Offset: 0x008E7B88
		public void ChangeMapType(IHexPos pos, EncircleHexType changeType)
		{
			IHexData hex = this.GetHex(pos);
			hex.Type = changeType;
			this.SetHex(pos, hex);
		}

		// Token: 0x0400F5C0 RID: 62912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IHexData> Hexes;

		// Token: 0x0400F5C1 RID: 62913
		private int? Width;

		// Token: 0x0400F5C2 RID: 62914
		private int? Height;

		// Token: 0x0400F5C3 RID: 62915
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionUpLeft = new ValueTuple<int, int>(-1, -1);

		// Token: 0x0400F5C4 RID: 62916
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionUpRight = new ValueTuple<int, int>(1, -1);

		// Token: 0x0400F5C5 RID: 62917
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionLeft = new ValueTuple<int, int>(-2, 0);

		// Token: 0x0400F5C6 RID: 62918
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionRight = new ValueTuple<int, int>(2, 0);

		// Token: 0x0400F5C7 RID: 62919
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionDownLeft = new ValueTuple<int, int>(-1, 1);

		// Token: 0x0400F5C8 RID: 62920
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionDownRight = new ValueTuple<int, int>(1, 1);
	}
}
