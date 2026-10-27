using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC3 RID: 3523
	public struct LevelPlayNodeData : IFlatbufferObject
	{
		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06008D8C RID: 36236 RVA: 0x002769A5 File Offset: 0x00274BA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x002769B2 File Offset: 0x00274BB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x002769BC File Offset: 0x00274BBC
		public static LevelPlayNodeData GetRootAsLevelPlayNodeData(ByteBuffer _bb)
		{
			return LevelPlayNodeData.GetRootAsLevelPlayNodeData(_bb, default(LevelPlayNodeData));
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x002769D8 File Offset: 0x00274BD8
		public static LevelPlayNodeData GetRootAsLevelPlayNodeData(ByteBuffer _bb, LevelPlayNodeData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x002769F5 File Offset: 0x00274BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x00276A04 File Offset: 0x00274C04
		public LevelPlayNodeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06008D92 RID: 36242 RVA: 0x00276A14 File Offset: 0x00274C14
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x00276A4B File Offset: 0x00274C4B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x00276A5A File Offset: 0x00274C5A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06008D95 RID: 36245 RVA: 0x00276A74 File Offset: 0x00274C74
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

		// Token: 0x06008D96 RID: 36246 RVA: 0x00276AAB File Offset: 0x00274CAB
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x00276ABA File Offset: 0x00274CBA
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E59 RID: 20057
		private Table __p;
	}
}
