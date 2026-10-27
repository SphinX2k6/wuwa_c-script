using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006668 RID: 26216
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleUtils : Singleton
	{
		// Token: 0x06041B48 RID: 269128 RVA: 0x00FEF1D6 File Offset: 0x00FED3D6
		public int PlanePosToKey(int x, int y)
		{
			return this.HexPosToKey(this.PlanePosToHexPos(x, y));
		}

		// Token: 0x06041B49 RID: 269129 RVA: 0x00FEF1E6 File Offset: 0x00FED3E6
		public int HexPosToKey(IHexPos pos)
		{
			return pos.PosY * this.Stride + pos.PosX;
		}

		// Token: 0x06041B4A RID: 269130 RVA: 0x00FEF1FC File Offset: 0x00FED3FC
		public IHexPos GetPosFromKey(int id)
		{
			return new HexPos
			{
				PosX = id % this.Stride,
				PosY = (int)Math.Floor((double)id / (double)this.Stride)
			};
		}

		// Token: 0x06041B4B RID: 269131 RVA: 0x00FEF227 File Offset: 0x00FED427
		public IHexPos PlanePosToHexPos(int x, int y)
		{
			return new HexPos
			{
				PosX = x * 2 + (y + 1) % 2,
				PosY = y
			};
		}

		// Token: 0x06041B4C RID: 269132 RVA: 0x00FEF244 File Offset: 0x00FED444
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

		// Token: 0x1700963A RID: 38458
		// (get) Token: 0x06041B4D RID: 269133 RVA: 0x00FEF26C File Offset: 0x00FED46C
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

		// Token: 0x06041B4E RID: 269134 RVA: 0x00FEF28F File Offset: 0x00FED48F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041B4F RID: 269135 RVA: 0x00FEF291 File Offset: 0x00FED491
		public static void ResetStaticDefaultValue()
		{
			EncircleUtils instance = EncircleUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			EncircleUtils._instance = null;
		}

		// Token: 0x06041B50 RID: 269136 RVA: 0x00FEF2AA File Offset: 0x00FED4AA
		static EncircleUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(EncircleUtils.CreateStaticDefaultValue), new Action(EncircleUtils.ResetStaticDefaultValue));
		}

		// Token: 0x040222DE RID: 139998
		private readonly int Stride = 100;

		// Token: 0x040222DF RID: 139999
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

		// Token: 0x040222E0 RID: 140000
		[Nullable(2)]
		private static EncircleUtils _instance;
	}
}
