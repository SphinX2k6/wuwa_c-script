using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2B RID: 3371
	public struct HomeBtnStyle : IFlatbufferObject
	{
		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06007E81 RID: 32385 RVA: 0x00254098 File Offset: 0x00252298
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x002540A5 File Offset: 0x002522A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x002540AC File Offset: 0x002522AC
		public static HomeBtnStyle GetRootAsHomeBtnStyle(ByteBuffer _bb)
		{
			return HomeBtnStyle.GetRootAsHomeBtnStyle(_bb, default(HomeBtnStyle));
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x002540C8 File Offset: 0x002522C8
		public static HomeBtnStyle GetRootAsHomeBtnStyle(ByteBuffer _bb, HomeBtnStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x002540E5 File Offset: 0x002522E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x002540F4 File Offset: 0x002522F4
		public HomeBtnStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06007E87 RID: 32391 RVA: 0x00254104 File Offset: 0x00252304
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

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x00254140 File Offset: 0x00252340
		public string ResourceId
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

		// Token: 0x06007E89 RID: 32393 RVA: 0x00254177 File Offset: 0x00252377
		public Span<byte> GetResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x00254186 File Offset: 0x00252386
		public byte[] GetResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06007E8B RID: 32395 RVA: 0x002541A0 File Offset: 0x002523A0
		public string SPNormal
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x002541D7 File Offset: 0x002523D7
		public Span<byte> GetSPNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x002541E6 File Offset: 0x002523E6
		public byte[] GetSPNormalArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06007E8E RID: 32398 RVA: 0x00254200 File Offset: 0x00252400
		public string SPHighLighted
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x00254238 File Offset: 0x00252438
		public Span<byte> GetSPHighLightedBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x00254248 File Offset: 0x00252448
		public byte[] GetSPHighLightedArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06007E91 RID: 32401 RVA: 0x00254260 File Offset: 0x00252460
		public string SPPressed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x00254298 File Offset: 0x00252498
		public Span<byte> GetSPPressedBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x002542A8 File Offset: 0x002524A8
		public byte[] GetSPPressedArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06007E94 RID: 32404 RVA: 0x002542C0 File Offset: 0x002524C0
		public string SPDisable
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x002542F8 File Offset: 0x002524F8
		public Span<byte> GetSPDisableBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x00254308 File Offset: 0x00252508
		public byte[] GetSPDisableArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DA3 RID: 19875
		private Table __p;
	}
}
