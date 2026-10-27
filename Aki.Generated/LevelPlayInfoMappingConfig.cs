using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC2 RID: 3522
	public struct LevelPlayInfoMappingConfig : IFlatbufferObject
	{
		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06008D81 RID: 36225 RVA: 0x00276861 File Offset: 0x00274A61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x0027686E File Offset: 0x00274A6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x00276878 File Offset: 0x00274A78
		public static LevelPlayInfoMappingConfig GetRootAsLevelPlayInfoMappingConfig(ByteBuffer _bb)
		{
			return LevelPlayInfoMappingConfig.GetRootAsLevelPlayInfoMappingConfig(_bb, default(LevelPlayInfoMappingConfig));
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x00276894 File Offset: 0x00274A94
		public static LevelPlayInfoMappingConfig GetRootAsLevelPlayInfoMappingConfig(ByteBuffer _bb, LevelPlayInfoMappingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x002768B1 File Offset: 0x00274AB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x002768C0 File Offset: 0x00274AC0
		public LevelPlayInfoMappingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06008D87 RID: 36231 RVA: 0x002768D0 File Offset: 0x00274AD0
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

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x0027690C File Offset: 0x00274B0C
		public int Type
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

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06008D89 RID: 36233 RVA: 0x00276948 File Offset: 0x00274B48
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

		// Token: 0x06008D8A RID: 36234 RVA: 0x0027697F File Offset: 0x00274B7F
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x0027698E File Offset: 0x00274B8E
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E58 RID: 20056
		private Table __p;
	}
}
