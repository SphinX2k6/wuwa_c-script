using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F06 RID: 3846
	public struct MoonLabel : IFlatbufferObject
	{
		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06009BE1 RID: 39905 RVA: 0x002A6D89 File Offset: 0x002A4F89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BE2 RID: 39906 RVA: 0x002A6D96 File Offset: 0x002A4F96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x002A6DA0 File Offset: 0x002A4FA0
		public static MoonLabel GetRootAsMoonLabel(ByteBuffer _bb)
		{
			return MoonLabel.GetRootAsMoonLabel(_bb, default(MoonLabel));
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x002A6DBC File Offset: 0x002A4FBC
		public static MoonLabel GetRootAsMoonLabel(ByteBuffer _bb, MoonLabel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x002A6DD9 File Offset: 0x002A4FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x002A6DE8 File Offset: 0x002A4FE8
		public MoonLabel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06009BE7 RID: 39911 RVA: 0x002A6DF8 File Offset: 0x002A4FF8
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

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06009BE8 RID: 39912 RVA: 0x002A6E34 File Offset: 0x002A5034
		public string MoonText1
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

		// Token: 0x06009BE9 RID: 39913 RVA: 0x002A6E6B File Offset: 0x002A506B
		public Span<byte> GetMoonText1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009BEA RID: 39914 RVA: 0x002A6E7A File Offset: 0x002A507A
		public byte[] GetMoonText1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x002A6E94 File Offset: 0x002A5094
		public string MoonText2
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

		// Token: 0x06009BEC RID: 39916 RVA: 0x002A6ECB File Offset: 0x002A50CB
		public Span<byte> GetMoonText2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x002A6EDA File Offset: 0x002A50DA
		public byte[] GetMoonText2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06009BEE RID: 39918 RVA: 0x002A6EF4 File Offset: 0x002A50F4
		public string MoonLabelName
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

		// Token: 0x06009BEF RID: 39919 RVA: 0x002A6F2C File Offset: 0x002A512C
		public Span<byte> GetMoonLabelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x002A6F3C File Offset: 0x002A513C
		public byte[] GetMoonLabelNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040054AB RID: 21675
		private Table __p;
	}
}
