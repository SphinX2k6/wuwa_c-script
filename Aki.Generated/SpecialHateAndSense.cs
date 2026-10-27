using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E0 RID: 4320
	public struct SpecialHateAndSense : IFlatbufferObject
	{
		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600D7E1 RID: 55265 RVA: 0x0031DEE9 File Offset: 0x0031C0E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x0031DEF6 File Offset: 0x0031C0F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x0031DF00 File Offset: 0x0031C100
		public static SpecialHateAndSense GetRootAsSpecialHateAndSense(ByteBuffer _bb)
		{
			return SpecialHateAndSense.GetRootAsSpecialHateAndSense(_bb, default(SpecialHateAndSense));
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x0031DF1C File Offset: 0x0031C11C
		public static SpecialHateAndSense GetRootAsSpecialHateAndSense(ByteBuffer _bb, SpecialHateAndSense obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x0031DF39 File Offset: 0x0031C139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x0031DF48 File Offset: 0x0031C148
		public SpecialHateAndSense __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600D7E7 RID: 55271 RVA: 0x0031DF58 File Offset: 0x0031C158
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

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600D7E8 RID: 55272 RVA: 0x0031DF94 File Offset: 0x0031C194
		public string DescText
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

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x0031DFCB File Offset: 0x0031C1CB
		public Span<byte> GetDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D7EA RID: 55274 RVA: 0x0031DFDA File Offset: 0x0031C1DA
		public byte[] GetDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600D7EB RID: 55275 RVA: 0x0031DFF4 File Offset: 0x0031C1F4
		public int AiHateId
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

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600D7EC RID: 55276 RVA: 0x0031E030 File Offset: 0x0031C230
		public int FirstAiSenseId
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

		// Token: 0x04005213 RID: 21011
		private Table __p;
	}
}
