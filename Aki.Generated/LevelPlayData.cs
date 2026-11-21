using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA6 RID: 3750
	public struct LevelPlayData : IFlatbufferObject
	{
		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06009393 RID: 37779 RVA: 0x00294D5E File Offset: 0x00292F5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x00294D6B File Offset: 0x00292F6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x00294D74 File Offset: 0x00292F74
		public static LevelPlayData GetRootAsLevelPlayData(ByteBuffer _bb)
		{
			return LevelPlayData.GetRootAsLevelPlayData(_bb, default(LevelPlayData));
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x00294D90 File Offset: 0x00292F90
		public static LevelPlayData GetRootAsLevelPlayData(ByteBuffer _bb, LevelPlayData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x00294DAD File Offset: 0x00292FAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x00294DBC File Offset: 0x00292FBC
		public LevelPlayData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06009399 RID: 37785 RVA: 0x00294DCC File Offset: 0x00292FCC
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

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x0600939A RID: 37786 RVA: 0x00294E08 File Offset: 0x00293008
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

		// Token: 0x0600939B RID: 37787 RVA: 0x00294E3F File Offset: 0x0029303F
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600939C RID: 37788 RVA: 0x00294E4E File Offset: 0x0029304E
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400543C RID: 21564
		private Table __p;
	}
}
