using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D64 RID: 3428
	public struct FishingIllustratedReward : IFlatbufferObject
	{
		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06007561 RID: 30049 RVA: 0x00250395 File Offset: 0x0024E595
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x002503A2 File Offset: 0x0024E5A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x002503AC File Offset: 0x0024E5AC
		public static FishingIllustratedReward GetRootAsFishingIllustratedReward(ByteBuffer _bb)
		{
			return FishingIllustratedReward.GetRootAsFishingIllustratedReward(_bb, default(FishingIllustratedReward));
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x002503C8 File Offset: 0x0024E5C8
		public static FishingIllustratedReward GetRootAsFishingIllustratedReward(ByteBuffer _bb, FishingIllustratedReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x002503E5 File Offset: 0x0024E5E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x002503F4 File Offset: 0x0024E5F4
		public FishingIllustratedReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06007567 RID: 30055 RVA: 0x00250404 File Offset: 0x0024E604
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

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06007568 RID: 30056 RVA: 0x00250440 File Offset: 0x0024E640
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

		// Token: 0x06007569 RID: 30057 RVA: 0x00250477 File Offset: 0x0024E677
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00250486 File Offset: 0x0024E686
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600756B RID: 30059 RVA: 0x002504A0 File Offset: 0x0024E6A0
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600756C RID: 30060 RVA: 0x002504DC File Offset: 0x0024E6DC
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600756D RID: 30061 RVA: 0x0025051C File Offset: 0x0024E71C
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

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600756E RID: 30062 RVA: 0x0025055C File Offset: 0x0024E75C
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

		// Token: 0x040052B3 RID: 21171
		private Table __p;
	}
}
