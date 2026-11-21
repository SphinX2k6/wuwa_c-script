using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7D RID: 3197
	public struct ConsumptiveTaskTab : IFlatbufferObject
	{
		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x0021ED15 File Offset: 0x0021CF15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x0021ED22 File Offset: 0x0021CF22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x0021ED2C File Offset: 0x0021CF2C
		public static ConsumptiveTaskTab GetRootAsConsumptiveTaskTab(ByteBuffer _bb)
		{
			return ConsumptiveTaskTab.GetRootAsConsumptiveTaskTab(_bb, default(ConsumptiveTaskTab));
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x0021ED48 File Offset: 0x0021CF48
		public static ConsumptiveTaskTab GetRootAsConsumptiveTaskTab(ByteBuffer _bb, ConsumptiveTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x0021ED65 File Offset: 0x0021CF65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x0021ED74 File Offset: 0x0021CF74
		public ConsumptiveTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06005EF3 RID: 24307 RVA: 0x0021ED84 File Offset: 0x0021CF84
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

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x0021EDC0 File Offset: 0x0021CFC0
		public string Title
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

		// Token: 0x06005EF5 RID: 24309 RVA: 0x0021EDF7 File Offset: 0x0021CFF7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x0021EE06 File Offset: 0x0021D006
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06005EF7 RID: 24311 RVA: 0x0021EE20 File Offset: 0x0021D020
		public string SpriteIcon
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

		// Token: 0x06005EF8 RID: 24312 RVA: 0x0021EE57 File Offset: 0x0021D057
		public Span<byte> GetSpriteIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x0021EE66 File Offset: 0x0021D066
		public byte[] GetSpriteIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400519E RID: 20894
		private Table __p;
	}
}
