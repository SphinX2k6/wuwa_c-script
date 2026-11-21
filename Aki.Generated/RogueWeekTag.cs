using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200111A RID: 4378
	public struct RogueWeekTag : IFlatbufferObject
	{
		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600CCE8 RID: 52456 RVA: 0x00311DC8 File Offset: 0x0030FFC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x00311DD5 File Offset: 0x0030FFD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCEA RID: 52458 RVA: 0x00311DDC File Offset: 0x0030FFDC
		public static RogueWeekTag GetRootAsRogueWeekTag(ByteBuffer _bb)
		{
			return RogueWeekTag.GetRootAsRogueWeekTag(_bb, default(RogueWeekTag));
		}

		// Token: 0x0600CCEB RID: 52459 RVA: 0x00311DF8 File Offset: 0x0030FFF8
		public static RogueWeekTag GetRootAsRogueWeekTag(ByteBuffer _bb, RogueWeekTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x00311E15 File Offset: 0x00310015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x00311E24 File Offset: 0x00310024
		public RogueWeekTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x00311E34 File Offset: 0x00310034
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

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600CCEF RID: 52463 RVA: 0x00311E70 File Offset: 0x00310070
		public string Type
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

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x00311EA7 File Offset: 0x003100A7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x00311EB6 File Offset: 0x003100B6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x00311ED0 File Offset: 0x003100D0
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

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x00311F07 File Offset: 0x00310107
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x00311F16 File Offset: 0x00310116
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600CCF5 RID: 52469 RVA: 0x00311F30 File Offset: 0x00310130
		public string Color
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

		// Token: 0x0600CCF6 RID: 52470 RVA: 0x00311F68 File Offset: 0x00310168
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CCF7 RID: 52471 RVA: 0x00311F78 File Offset: 0x00310178
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005712 RID: 22290
		private Table __p;
	}
}
