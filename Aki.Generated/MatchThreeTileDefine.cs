using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE9 RID: 3817
	public struct MatchThreeTileDefine : IFlatbufferObject
	{
		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600996B RID: 39275 RVA: 0x002A172A File Offset: 0x0029F92A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600996C RID: 39276 RVA: 0x002A1737 File Offset: 0x0029F937
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x002A1740 File Offset: 0x0029F940
		public static MatchThreeTileDefine GetRootAsMatchThreeTileDefine(ByteBuffer _bb)
		{
			return MatchThreeTileDefine.GetRootAsMatchThreeTileDefine(_bb, default(MatchThreeTileDefine));
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x002A175C File Offset: 0x0029F95C
		public static MatchThreeTileDefine GetRootAsMatchThreeTileDefine(ByteBuffer _bb, MatchThreeTileDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600996F RID: 39279 RVA: 0x002A1779 File Offset: 0x0029F979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009970 RID: 39280 RVA: 0x002A1788 File Offset: 0x0029F988
		public MatchThreeTileDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x06009971 RID: 39281 RVA: 0x002A1798 File Offset: 0x0029F998
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

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x002A17D4 File Offset: 0x0029F9D4
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

		// Token: 0x06009973 RID: 39283 RVA: 0x002A180B File Offset: 0x0029FA0B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x002A181A File Offset: 0x0029FA1A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06009975 RID: 39285 RVA: 0x002A1834 File Offset: 0x0029FA34
		public string Description
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

		// Token: 0x06009976 RID: 39286 RVA: 0x002A186B File Offset: 0x0029FA6B
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x002A187A File Offset: 0x0029FA7A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06009978 RID: 39288 RVA: 0x002A1894 File Offset: 0x0029FA94
		public string TileIconPath
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

		// Token: 0x06009979 RID: 39289 RVA: 0x002A18CC File Offset: 0x0029FACC
		public Span<byte> GetTileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x002A18DC File Offset: 0x0029FADC
		public byte[] GetTileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x0600997B RID: 39291 RVA: 0x002A18F4 File Offset: 0x0029FAF4
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400548A RID: 21642
		private Table __p;
	}
}
