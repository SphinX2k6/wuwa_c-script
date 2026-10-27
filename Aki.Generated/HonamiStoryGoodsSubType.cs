using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D36 RID: 3382
	public struct HonamiStoryGoodsSubType : IFlatbufferObject
	{
		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06007F81 RID: 32641 RVA: 0x002568FD File Offset: 0x00254AFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x0025690A File Offset: 0x00254B0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x00256914 File Offset: 0x00254B14
		public static HonamiStoryGoodsSubType GetRootAsHonamiStoryGoodsSubType(ByteBuffer _bb)
		{
			return HonamiStoryGoodsSubType.GetRootAsHonamiStoryGoodsSubType(_bb, default(HonamiStoryGoodsSubType));
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x00256930 File Offset: 0x00254B30
		public static HonamiStoryGoodsSubType GetRootAsHonamiStoryGoodsSubType(ByteBuffer _bb, HonamiStoryGoodsSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x0025694D File Offset: 0x00254B4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x0025695C File Offset: 0x00254B5C
		public HonamiStoryGoodsSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06007F87 RID: 32647 RVA: 0x0025696C File Offset: 0x00254B6C
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

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06007F88 RID: 32648 RVA: 0x002569A8 File Offset: 0x00254BA8
		public string Name
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

		// Token: 0x06007F89 RID: 32649 RVA: 0x002569DF File Offset: 0x00254BDF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x002569EE File Offset: 0x00254BEE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DB0 RID: 19888
		private Table __p;
	}
}
