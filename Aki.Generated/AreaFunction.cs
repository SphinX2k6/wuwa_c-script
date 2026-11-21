using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDD RID: 3037
	public struct AreaFunction : IFlatbufferObject
	{
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06004DD2 RID: 19922 RVA: 0x001F7435 File Offset: 0x001F5635
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x001F7442 File Offset: 0x001F5642
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x001F744C File Offset: 0x001F564C
		public static AreaFunction GetRootAsAreaFunction(ByteBuffer _bb)
		{
			return AreaFunction.GetRootAsAreaFunction(_bb, default(AreaFunction));
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x001F7468 File Offset: 0x001F5668
		public static AreaFunction GetRootAsAreaFunction(ByteBuffer _bb, AreaFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x001F7485 File Offset: 0x001F5685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x001F7494 File Offset: 0x001F5694
		public AreaFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x001F74A4 File Offset: 0x001F56A4
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x001F74E0 File Offset: 0x001F56E0
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

		// Token: 0x06004DDA RID: 19930 RVA: 0x001F7517 File Offset: 0x001F5717
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x001F7526 File Offset: 0x001F5726
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06004DDC RID: 19932 RVA: 0x001F7540 File Offset: 0x001F5740
		public string Data
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

		// Token: 0x06004DDD RID: 19933 RVA: 0x001F7577 File Offset: 0x001F5777
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x001F7586 File Offset: 0x001F5786
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050C2 RID: 20674
		private Table __p;
	}
}
