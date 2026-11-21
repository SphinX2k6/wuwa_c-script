using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E92 RID: 3730
	public struct KurotatoMonsterType : IFlatbufferObject
	{
		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06009120 RID: 37152 RVA: 0x0028FACC File Offset: 0x0028DCCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009121 RID: 37153 RVA: 0x0028FAD9 File Offset: 0x0028DCD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x0028FAE0 File Offset: 0x0028DCE0
		public static KurotatoMonsterType GetRootAsKurotatoMonsterType(ByteBuffer _bb)
		{
			return KurotatoMonsterType.GetRootAsKurotatoMonsterType(_bb, default(KurotatoMonsterType));
		}

		// Token: 0x06009123 RID: 37155 RVA: 0x0028FAFC File Offset: 0x0028DCFC
		public static KurotatoMonsterType GetRootAsKurotatoMonsterType(ByteBuffer _bb, KurotatoMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009124 RID: 37156 RVA: 0x0028FB19 File Offset: 0x0028DD19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x0028FB28 File Offset: 0x0028DD28
		public KurotatoMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06009126 RID: 37158 RVA: 0x0028FB38 File Offset: 0x0028DD38
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

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06009127 RID: 37159 RVA: 0x0028FB74 File Offset: 0x0028DD74
		public int RiskType
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

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06009128 RID: 37160 RVA: 0x0028FBB0 File Offset: 0x0028DDB0
		public string Name
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

		// Token: 0x06009129 RID: 37161 RVA: 0x0028FBE7 File Offset: 0x0028DDE7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600912A RID: 37162 RVA: 0x0028FBF6 File Offset: 0x0028DDF6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x0600912B RID: 37163 RVA: 0x0028FC10 File Offset: 0x0028DE10
		public int TemplateId
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

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x0600912C RID: 37164 RVA: 0x0028FC50 File Offset: 0x0028DE50
		public int BodyType
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

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x0600912D RID: 37165 RVA: 0x0028FC90 File Offset: 0x0028DE90
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600912E RID: 37166 RVA: 0x0028FCC8 File Offset: 0x0028DEC8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600912F RID: 37167 RVA: 0x0028FCD8 File Offset: 0x0028DED8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005424 RID: 21540
		private Table __p;
	}
}
