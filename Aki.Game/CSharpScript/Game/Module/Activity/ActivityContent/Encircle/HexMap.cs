using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006662 RID: 26210
	[NullableContext(1)]
	[Nullable(0)]
	internal class HexMap
	{
		// Token: 0x06041ADE RID: 269022 RVA: 0x00FED75B File Offset: 0x00FEB95B
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IHexData> GetHexes()
		{
			return this.Hexes;
		}

		// Token: 0x06041ADF RID: 269023 RVA: 0x00FED763 File Offset: 0x00FEB963
		public void SetHexes([Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<int, IHexData> hexesInternal)
		{
			this.Hexes = hexesInternal;
		}

		// Token: 0x06041AE0 RID: 269024 RVA: 0x00FED76C File Offset: 0x00FEB96C
		public void Clear()
		{
			this.Hexes = null;
			this.Width = null;
			this.Height = null;
		}

		// Token: 0x06041AE1 RID: 269025 RVA: 0x00FED78D File Offset: 0x00FEB98D
		public int GetWidth()
		{
			return this.Width.Value;
		}

		// Token: 0x06041AE2 RID: 269026 RVA: 0x00FED79A File Offset: 0x00FEB99A
		public int GetHeight()
		{
			return this.Height.Value;
		}

		// Token: 0x06041AE3 RID: 269027 RVA: 0x00FED7A7 File Offset: 0x00FEB9A7
		public void SetWidth(int width)
		{
			this.Width = new int?(width);
		}

		// Token: 0x06041AE4 RID: 269028 RVA: 0x00FED7B5 File Offset: 0x00FEB9B5
		public void SetHeight(int height)
		{
			this.Height = new int?(height);
		}

		// Token: 0x06041AE5 RID: 269029 RVA: 0x00FED7C3 File Offset: 0x00FEB9C3
		public void SetHex(IHexPos pos, [Nullable(2)] IHexData hexData)
		{
			this.Hexes[EncircleUtils.Instance.HexPosToKey(pos)] = hexData;
		}

		// Token: 0x06041AE6 RID: 269030 RVA: 0x00FED7DC File Offset: 0x00FEB9DC
		[return: Nullable(2)]
		public IHexData GetHex(IHexPos pos)
		{
			IHexData result;
			this.Hexes.TryGetValue(EncircleUtils.Instance.HexPosToKey(pos), out result);
			return result;
		}

		// Token: 0x06041AE7 RID: 269031 RVA: 0x00FED803 File Offset: 0x00FEBA03
		public bool CheckCanAddObstacle(IHexPos pos)
		{
			IHexData hex = this.GetHex(pos);
			return hex != null && hex.Type == EncircleHexType.Plain;
		}

		// Token: 0x06041AE8 RID: 269032 RVA: 0x00FED81C File Offset: 0x00FEBA1C
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

		// Token: 0x06041AE9 RID: 269033 RVA: 0x00FED85C File Offset: 0x00FEBA5C
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

		// Token: 0x06041AEA RID: 269034 RVA: 0x00FED8BB File Offset: 0x00FEBABB
		protected List<IHexData> GetAllHexes()
		{
			return new List<IHexData>(this.Hexes.Values);
		}

		// Token: 0x06041AEB RID: 269035 RVA: 0x00FED8D0 File Offset: 0x00FEBAD0
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

		// Token: 0x06041AEC RID: 269036 RVA: 0x00FED954 File Offset: 0x00FEBB54
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

		// Token: 0x06041AED RID: 269037 RVA: 0x00FEDA50 File Offset: 0x00FEBC50
		private bool IsObstacle(IHexPos pos)
		{
			IHexData hexData;
			this.Hexes.TryGetValue(EncircleUtils.Instance.HexPosToKey(pos), out hexData);
			return (hexData != null && hexData.Type == EncircleHexType.Wall) || (hexData != null && hexData.Type == EncircleHexType.InitialWall) || (hexData != null && hexData.Type == EncircleHexType.DifficultyWall);
		}

		// Token: 0x06041AEE RID: 269038 RVA: 0x00FEDAA0 File Offset: 0x00FEBCA0
		private bool IsLimitObstacle(IHexPos pos)
		{
			IHexData hexData;
			this.Hexes.TryGetValue(EncircleUtils.Instance.HexPosToKey(pos), out hexData);
			return (hexData != null && hexData.Type == EncircleHexType.LimitWall) || (hexData != null && hexData.Type == EncircleHexType.Monster);
		}

		// Token: 0x06041AEF RID: 269039 RVA: 0x00FEDAE4 File Offset: 0x00FEBCE4
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

		// Token: 0x06041AF0 RID: 269040 RVA: 0x00FEDD00 File Offset: 0x00FEBF00
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

		// Token: 0x06041AF1 RID: 269041 RVA: 0x00FEDE6C File Offset: 0x00FEC06C
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

		// Token: 0x06041AF2 RID: 269042 RVA: 0x00FEDEAF File Offset: 0x00FEC0AF
		public void AddObstacle(IHexPos pos)
		{
			this.ChangeMapType(pos, EncircleHexType.Wall);
		}

		// Token: 0x06041AF3 RID: 269043 RVA: 0x00FEDEBC File Offset: 0x00FEC0BC
		public void ChangeMapType(IHexPos pos, EncircleHexType changeType)
		{
			IHexData hex = this.GetHex(pos);
			hex.Type = changeType;
			this.SetHex(pos, hex);
		}

		// Token: 0x040222B6 RID: 139958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, IHexData> Hexes;

		// Token: 0x040222B7 RID: 139959
		private int? Width;

		// Token: 0x040222B8 RID: 139960
		private int? Height;

		// Token: 0x040222B9 RID: 139961
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionUpLeft = new ValueTuple<int, int>(-1, -1);

		// Token: 0x040222BA RID: 139962
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionUpRight = new ValueTuple<int, int>(1, -1);

		// Token: 0x040222BB RID: 139963
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionLeft = new ValueTuple<int, int>(-2, 0);

		// Token: 0x040222BC RID: 139964
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionRight = new ValueTuple<int, int>(2, 0);

		// Token: 0x040222BD RID: 139965
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionDownLeft = new ValueTuple<int, int>(-1, 1);

		// Token: 0x040222BE RID: 139966
		[TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		[Nullable(0)]
		private readonly ValueTuple<int, int> DirectionDownRight = new ValueTuple<int, int>(1, 1);
	}
}
