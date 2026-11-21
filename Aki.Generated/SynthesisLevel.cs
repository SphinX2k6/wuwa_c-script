using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001248 RID: 4680
	public struct SynthesisLevel : IFlatbufferObject
	{
		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600E9ED RID: 59885 RVA: 0x00354153 File Offset: 0x00352353
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9EE RID: 59886 RVA: 0x00354160 File Offset: 0x00352360
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9EF RID: 59887 RVA: 0x00354168 File Offset: 0x00352368
		public static SynthesisLevel GetRootAsSynthesisLevel(ByteBuffer _bb)
		{
			return SynthesisLevel.GetRootAsSynthesisLevel(_bb, default(SynthesisLevel));
		}

		// Token: 0x0600E9F0 RID: 59888 RVA: 0x00354184 File Offset: 0x00352384
		public static SynthesisLevel GetRootAsSynthesisLevel(ByteBuffer _bb, SynthesisLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9F1 RID: 59889 RVA: 0x003541A1 File Offset: 0x003523A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9F2 RID: 59890 RVA: 0x003541B0 File Offset: 0x003523B0
		public SynthesisLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0600E9F3 RID: 59891 RVA: 0x003541C0 File Offset: 0x003523C0
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

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0600E9F4 RID: 59892 RVA: 0x003541FC File Offset: 0x003523FC
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

		// Token: 0x0600E9F5 RID: 59893 RVA: 0x00354233 File Offset: 0x00352433
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E9F6 RID: 59894 RVA: 0x00354242 File Offset: 0x00352442
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x0035425C File Offset: 0x0035245C
		public int Completeness
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x0600E9F8 RID: 59896 RVA: 0x00354298 File Offset: 0x00352498
		public int Effect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x0600E9F9 RID: 59897 RVA: 0x003542D8 File Offset: 0x003524D8
		public string AttributesDescription
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

		// Token: 0x0600E9FA RID: 59898 RVA: 0x00354310 File Offset: 0x00352510
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E9FB RID: 59899 RVA: 0x00354320 File Offset: 0x00352520
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x0600E9FC RID: 59900 RVA: 0x00354338 File Offset: 0x00352538
		public int DropIds
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005892 RID: 22674
		private Table __p;
	}
}
