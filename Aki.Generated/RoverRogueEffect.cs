using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001076 RID: 4214
	public struct RoverRogueEffect : IFlatbufferObject
	{
		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600CD90 RID: 52624 RVA: 0x00305979 File Offset: 0x00303B79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD91 RID: 52625 RVA: 0x00305986 File Offset: 0x00303B86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD92 RID: 52626 RVA: 0x00305990 File Offset: 0x00303B90
		public static RoverRogueEffect GetRootAsRoverRogueEffect(ByteBuffer _bb)
		{
			return RoverRogueEffect.GetRootAsRoverRogueEffect(_bb, default(RoverRogueEffect));
		}

		// Token: 0x0600CD93 RID: 52627 RVA: 0x003059AC File Offset: 0x00303BAC
		public static RoverRogueEffect GetRootAsRoverRogueEffect(ByteBuffer _bb, RoverRogueEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD94 RID: 52628 RVA: 0x003059C9 File Offset: 0x00303BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD95 RID: 52629 RVA: 0x003059D8 File Offset: 0x00303BD8
		public RoverRogueEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600CD96 RID: 52630 RVA: 0x003059E8 File Offset: 0x00303BE8
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

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600CD97 RID: 52631 RVA: 0x00305A24 File Offset: 0x00303C24
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

		// Token: 0x0600CD98 RID: 52632 RVA: 0x00305A5B File Offset: 0x00303C5B
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x00305A6A File Offset: 0x00303C6A
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600CD9A RID: 52634 RVA: 0x00305A84 File Offset: 0x00303C84
		public int Desc
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

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600CD9B RID: 52635 RVA: 0x00305AC0 File Offset: 0x00303CC0
		public bool ClientDisplay
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005180 RID: 20864
		private Table __p;
	}
}
