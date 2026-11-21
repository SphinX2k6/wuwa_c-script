using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC8 RID: 3272
	public struct DebugEntranceTypeConfig : IFlatbufferObject
	{
		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x00230EB9 File Offset: 0x0022F0B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006736 RID: 26422 RVA: 0x00230EC6 File Offset: 0x0022F0C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x00230ED0 File Offset: 0x0022F0D0
		public static DebugEntranceTypeConfig GetRootAsDebugEntranceTypeConfig(ByteBuffer _bb)
		{
			return DebugEntranceTypeConfig.GetRootAsDebugEntranceTypeConfig(_bb, default(DebugEntranceTypeConfig));
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x00230EEC File Offset: 0x0022F0EC
		public static DebugEntranceTypeConfig GetRootAsDebugEntranceTypeConfig(ByteBuffer _bb, DebugEntranceTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x00230F09 File Offset: 0x0022F109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x00230F18 File Offset: 0x0022F118
		public DebugEntranceTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600673B RID: 26427 RVA: 0x00230F28 File Offset: 0x0022F128
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

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x00230F64 File Offset: 0x0022F164
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

		// Token: 0x0600673D RID: 26429 RVA: 0x00230F9B File Offset: 0x0022F19B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x00230FAA File Offset: 0x0022F1AA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040051F5 RID: 20981
		private Table __p;
	}
}
