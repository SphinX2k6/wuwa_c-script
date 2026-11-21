using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6E RID: 3182
	public struct CommonBtData : IFlatbufferObject
	{
		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06005D29 RID: 23849 RVA: 0x0021A501 File Offset: 0x00218701
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x0021A50E File Offset: 0x0021870E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x0021A518 File Offset: 0x00218718
		public static CommonBtData GetRootAsCommonBtData(ByteBuffer _bb)
		{
			return CommonBtData.GetRootAsCommonBtData(_bb, default(CommonBtData));
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x0021A534 File Offset: 0x00218734
		public static CommonBtData GetRootAsCommonBtData(ByteBuffer _bb, CommonBtData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x0021A551 File Offset: 0x00218751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x0021A560 File Offset: 0x00218760
		public CommonBtData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06005D2F RID: 23855 RVA: 0x0021A570 File Offset: 0x00218770
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06005D30 RID: 23856 RVA: 0x0021A5AC File Offset: 0x002187AC
		public int LevelId
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

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06005D31 RID: 23857 RVA: 0x0021A5E8 File Offset: 0x002187E8
		public string RawData
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

		// Token: 0x06005D32 RID: 23858 RVA: 0x0021A61F File Offset: 0x0021881F
		public Span<byte> GetRawDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x0021A62E File Offset: 0x0021882E
		public byte[] GetRawDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400517D RID: 20861
		private Table __p;
	}
}
