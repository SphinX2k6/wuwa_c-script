using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFE RID: 4094
	public struct RogueResEndAward : IFlatbufferObject
	{
		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0600C1F5 RID: 49653 RVA: 0x002EB76C File Offset: 0x002E996C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x002EB779 File Offset: 0x002E9979
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x002EB780 File Offset: 0x002E9980
		public static RogueResEndAward GetRootAsRogueResEndAward(ByteBuffer _bb)
		{
			return RogueResEndAward.GetRootAsRogueResEndAward(_bb, default(RogueResEndAward));
		}

		// Token: 0x0600C1F8 RID: 49656 RVA: 0x002EB79C File Offset: 0x002E999C
		public static RogueResEndAward GetRootAsRogueResEndAward(ByteBuffer _bb, RogueResEndAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1F9 RID: 49657 RVA: 0x002EB7B9 File Offset: 0x002E99B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1FA RID: 49658 RVA: 0x002EB7C8 File Offset: 0x002E99C8
		public RogueResEndAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0600C1FB RID: 49659 RVA: 0x002EB7D8 File Offset: 0x002E99D8
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

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0600C1FC RID: 49660 RVA: 0x002EB814 File Offset: 0x002E9A14
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

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0600C1FD RID: 49661 RVA: 0x002EB850 File Offset: 0x002E9A50
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

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0600C1FE RID: 49662 RVA: 0x002EB88C File Offset: 0x002E9A8C
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

		// Token: 0x0600C1FF RID: 49663 RVA: 0x002EB8C4 File Offset: 0x002E9AC4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C200 RID: 49664 RVA: 0x002EB8D4 File Offset: 0x002E9AD4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x0600C201 RID: 49665 RVA: 0x002EB8EC File Offset: 0x002E9AEC
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

		// Token: 0x040050E6 RID: 20710
		private Table __p;
	}
}
