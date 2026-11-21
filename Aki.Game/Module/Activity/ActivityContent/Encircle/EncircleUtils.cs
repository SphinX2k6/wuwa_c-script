using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003016 RID: 12310
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleUtils : Singleton
	{
		// Token: 0x0601D367 RID: 119655 RVA: 0x008EAC26 File Offset: 0x008E8E26
		public int PlanePosToKey(int x, int y)
		{
			return this.HexPosToKey(this.PlanePosToHexPos(x, y));
		}

		// Token: 0x0601D368 RID: 119656 RVA: 0x008EAC36 File Offset: 0x008E8E36
		public int HexPosToKey(IHexPos pos)
		{
			return pos.PosY * this.Stride + pos.PosX;
		}

		// Token: 0x0601D369 RID: 119657 RVA: 0x008EAC4C File Offset: 0x008E8E4C
		public IHexPos GetPosFromKey(int id)
		{
			return new HexPos
			{
				PosX = id % this.Stride,
				PosY = (int)Math.Floor((double)id / (double)this.Stride)
			};
		}

		// Token: 0x0601D36A RID: 119658 RVA: 0x008EAC77 File Offset: 0x008E8E77
		public IHexPos PlanePosToHexPos(int x, int y)
		{
			return new HexPos
			{
				PosX = x * 2 + (y + 1) % 2,
				PosY = y
			};
		}

		// Token: 0x0601D36B RID: 119659 RVA: 0x008EAC94 File Offset: 0x008E8E94
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})]
		public ValueTuple<int, int> HexPosToPlanePos([Nullable(1)] IHexPos hexPos)
		{
			int posY = hexPos.PosY;
			return new ValueTuple<int, int>((hexPos.PosX - (posY + 1) % 2) / 2, posY);
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0601D36C RID: 119660 RVA: 0x008EACBC File Offset: 0x008E8EBC
		public static EncircleUtils Instance
		{
			get
			{
				if (EncircleUtils._instance == null)
				{
					EncircleUtils._instance = new EncircleUtils();
					EncircleUtils._instance.OnInit();
				}
				return EncircleUtils._instance;
			}
		}

		// Token: 0x0601D36D RID: 119661 RVA: 0x008EACDF File Offset: 0x008E8EDF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601D36E RID: 119662 RVA: 0x008EACE1 File Offset: 0x008E8EE1
		public static void ResetStaticDefaultValue()
		{
			EncircleUtils instance = EncircleUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EncircleUtils._instance = null;
		}

		// Token: 0x0601D36F RID: 119663 RVA: 0x008EACFA File Offset: 0x008E8EFA
		static EncircleUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EncircleUtils.CreateStaticDefaultValue), new Action(EncircleUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0400F5E8 RID: 62952
		private readonly int Stride = 100;

		// Token: 0x0400F5E9 RID: 62953
		public IHexPos[] Directions = new IHexPos[]
		{
			new HexPos
			{
				PosX = 2,
				PosY = 0
			},
			new HexPos
			{
				PosX = 1,
				PosY = -1
			},
			new HexPos
			{
				PosX = -1,
				PosY = -1
			},
			new HexPos
			{
				PosX = -2,
				PosY = 0
			},
			new HexPos
			{
				PosX = -1,
				PosY = 1
			},
			new HexPos
			{
				PosX = 1,
				PosY = 1
			}
		};

		// Token: 0x0400F5EA RID: 62954
		[Nullable(2)]
		private static EncircleUtils _instance;
	}
}
