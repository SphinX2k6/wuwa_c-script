using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110D RID: 4365
	public struct RogueToken : IFlatbufferObject
	{
		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600CB9C RID: 52124 RVA: 0x0030ED80 File Offset: 0x0030CF80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x0030ED8D File Offset: 0x0030CF8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x0030ED94 File Offset: 0x0030CF94
		public static RogueToken GetRootAsRogueToken(ByteBuffer _bb)
		{
			return RogueToken.GetRootAsRogueToken(_bb, default(RogueToken));
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x0030EDB0 File Offset: 0x0030CFB0
		public static RogueToken GetRootAsRogueToken(ByteBuffer _bb, RogueToken obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x0030EDCD File Offset: 0x0030CFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBA1 RID: 52129 RVA: 0x0030EDDC File Offset: 0x0030CFDC
		public RogueToken __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600CBA2 RID: 52130 RVA: 0x0030EDEC File Offset: 0x0030CFEC
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

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600CBA3 RID: 52131 RVA: 0x0030EE28 File Offset: 0x0030D028
		public int SeasonId
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

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x0030EE64 File Offset: 0x0030D064
		public int Token
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

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600CBA5 RID: 52133 RVA: 0x0030EEA0 File Offset: 0x0030D0A0
		public int DropId
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

		// Token: 0x04005700 RID: 22272
		private Table __p;
	}
}
