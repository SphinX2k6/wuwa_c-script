using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDF RID: 3039
	public struct AreaMpc : IFlatbufferObject
	{
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x001F7820 File Offset: 0x001F5A20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x001F782D File Offset: 0x001F5A2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x001F7834 File Offset: 0x001F5A34
		public static AreaMpc GetRootAsAreaMpc(ByteBuffer _bb)
		{
			return AreaMpc.GetRootAsAreaMpc(_bb, default(AreaMpc));
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x001F7850 File Offset: 0x001F5A50
		public static AreaMpc GetRootAsAreaMpc(ByteBuffer _bb, AreaMpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x001F786D File Offset: 0x001F5A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x001F787C File Offset: 0x001F5A7C
		public AreaMpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x001F788C File Offset: 0x001F5A8C
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06004DF9 RID: 19961 RVA: 0x001F78C8 File Offset: 0x001F5AC8
		public int RegionId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06004DFA RID: 19962 RVA: 0x001F7904 File Offset: 0x001F5B04
		public string MpcData
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

		// Token: 0x06004DFB RID: 19963 RVA: 0x001F793B File Offset: 0x001F5B3B
		public Span<byte> GetMpcDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x001F794A File Offset: 0x001F5B4A
		public byte[] GetMpcDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050C4 RID: 20676
		private Table __p;
	}
}
