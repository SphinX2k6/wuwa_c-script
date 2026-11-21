using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5D RID: 3933
	public struct MusicalInstrumentQteConfig : IFlatbufferObject
	{
		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x0600A3D9 RID: 41945 RVA: 0x002B8321 File Offset: 0x002B6521
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x002B832E File Offset: 0x002B652E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x002B8338 File Offset: 0x002B6538
		public static MusicalInstrumentQteConfig GetRootAsMusicalInstrumentQteConfig(ByteBuffer _bb)
		{
			return MusicalInstrumentQteConfig.GetRootAsMusicalInstrumentQteConfig(_bb, default(MusicalInstrumentQteConfig));
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x002B8354 File Offset: 0x002B6554
		public static MusicalInstrumentQteConfig GetRootAsMusicalInstrumentQteConfig(ByteBuffer _bb, MusicalInstrumentQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x002B8371 File Offset: 0x002B6571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x002B8380 File Offset: 0x002B6580
		public MusicalInstrumentQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x0600A3DF RID: 41951 RVA: 0x002B8390 File Offset: 0x002B6590
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

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x0600A3E0 RID: 41952 RVA: 0x002B83CC File Offset: 0x002B65CC
		public int InstrumentType
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

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x0600A3E1 RID: 41953 RVA: 0x002B8408 File Offset: 0x002B6608
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

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x002B843F File Offset: 0x002B663F
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x002B844E File Offset: 0x002B664E
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x0600A3E4 RID: 41956 RVA: 0x002B8468 File Offset: 0x002B6668
		public string QteSequence
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

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x002B84A0 File Offset: 0x002B66A0
		public Span<byte> GetQteSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x002B84B0 File Offset: 0x002B66B0
		public byte[] GetQteSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x0600A3E7 RID: 41959 RVA: 0x002B84C8 File Offset: 0x002B66C8
		public string PreludeAsset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A3E8 RID: 41960 RVA: 0x002B8500 File Offset: 0x002B6700
		public Span<byte> GetPreludeAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A3E9 RID: 41961 RVA: 0x002B8510 File Offset: 0x002B6710
		public byte[] GetPreludeAssetArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400550B RID: 21771
		private Table __p;
	}
}
