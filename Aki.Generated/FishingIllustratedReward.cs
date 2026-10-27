using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C80 RID: 3200
	public struct FishingIllustratedReward : IFlatbufferObject
	{
		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06006F56 RID: 28502 RVA: 0x002311C9 File Offset: 0x0022F3C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x002311D6 File Offset: 0x0022F3D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x002311E0 File Offset: 0x0022F3E0
		public static FishingIllustratedReward GetRootAsFishingIllustratedReward(ByteBuffer _bb)
		{
			return FishingIllustratedReward.GetRootAsFishingIllustratedReward(_bb, default(FishingIllustratedReward));
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x002311FC File Offset: 0x0022F3FC
		public static FishingIllustratedReward GetRootAsFishingIllustratedReward(ByteBuffer _bb, FishingIllustratedReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x00231219 File Offset: 0x0022F419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x00231228 File Offset: 0x0022F428
		public FishingIllustratedReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06006F5C RID: 28508 RVA: 0x00231238 File Offset: 0x0022F438
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06006F5D RID: 28509 RVA: 0x00231274 File Offset: 0x0022F474
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x002312AB File Offset: 0x0022F4AB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x002312BA File Offset: 0x0022F4BA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06006F60 RID: 28512 RVA: 0x002312D4 File Offset: 0x0022F4D4
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06006F61 RID: 28513 RVA: 0x00231310 File Offset: 0x0022F510
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x00231350 File Offset: 0x0022F550
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06006F63 RID: 28515 RVA: 0x00231390 File Offset: 0x0022F590
		public int AccessPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CCF RID: 19663
		private Table __p;
	}
}
