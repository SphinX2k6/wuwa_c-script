using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC1 RID: 3521
	public struct LevelPlayData : IFlatbufferObject
	{
		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06008D77 RID: 36215 RVA: 0x0027675A File Offset: 0x0027495A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x00276767 File Offset: 0x00274967
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x00276770 File Offset: 0x00274970
		public static LevelPlayData GetRootAsLevelPlayData(ByteBuffer _bb)
		{
			return LevelPlayData.GetRootAsLevelPlayData(_bb, default(LevelPlayData));
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x0027678C File Offset: 0x0027498C
		public static LevelPlayData GetRootAsLevelPlayData(ByteBuffer _bb, LevelPlayData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x002767A9 File Offset: 0x002749A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x002767B8 File Offset: 0x002749B8
		public LevelPlayData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06008D7D RID: 36221 RVA: 0x002767C8 File Offset: 0x002749C8
		public int LevelPlayId
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

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06008D7E RID: 36222 RVA: 0x00276804 File Offset: 0x00274A04
		public string Data
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

		// Token: 0x06008D7F RID: 36223 RVA: 0x0027683B File Offset: 0x00274A3B
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x0027684A File Offset: 0x00274A4A
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E57 RID: 20055
		private Table __p;
	}
}
