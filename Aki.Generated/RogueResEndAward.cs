using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E6 RID: 4326
	public struct RogueResEndAward : IFlatbufferObject
	{
		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0600C83F RID: 51263 RVA: 0x003079B4 File Offset: 0x00305BB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C840 RID: 51264 RVA: 0x003079C1 File Offset: 0x00305BC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C841 RID: 51265 RVA: 0x003079C8 File Offset: 0x00305BC8
		public static RogueResEndAward GetRootAsRogueResEndAward(ByteBuffer _bb)
		{
			return RogueResEndAward.GetRootAsRogueResEndAward(_bb, default(RogueResEndAward));
		}

		// Token: 0x0600C842 RID: 51266 RVA: 0x003079E4 File Offset: 0x00305BE4
		public static RogueResEndAward GetRootAsRogueResEndAward(ByteBuffer _bb, RogueResEndAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C843 RID: 51267 RVA: 0x00307A01 File Offset: 0x00305C01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C844 RID: 51268 RVA: 0x00307A10 File Offset: 0x00305C10
		public RogueResEndAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x0600C845 RID: 51269 RVA: 0x00307A20 File Offset: 0x00305C20
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

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x0600C846 RID: 51270 RVA: 0x00307A5C File Offset: 0x00305C5C
		public int Index
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

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x0600C847 RID: 51271 RVA: 0x00307A98 File Offset: 0x00305C98
		public int SeasonId
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

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x0600C848 RID: 51272 RVA: 0x00307AD4 File Offset: 0x00305CD4
		public string Desc
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

		// Token: 0x0600C849 RID: 51273 RVA: 0x00307B0C File Offset: 0x00305D0C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x00307B1C File Offset: 0x00305D1C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x0600C84B RID: 51275 RVA: 0x00307B34 File Offset: 0x00305D34
		public int Award
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

		// Token: 0x040056CE RID: 22222
		private Table __p;
	}
}
