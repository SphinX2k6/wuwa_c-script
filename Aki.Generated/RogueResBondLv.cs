using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D7 RID: 4311
	public struct RogueResBondLv : IFlatbufferObject
	{
		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x0600C70C RID: 50956 RVA: 0x0030528E File Offset: 0x0030348E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C70D RID: 50957 RVA: 0x0030529B File Offset: 0x0030349B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C70E RID: 50958 RVA: 0x003052A4 File Offset: 0x003034A4
		public static RogueResBondLv GetRootAsRogueResBondLv(ByteBuffer _bb)
		{
			return RogueResBondLv.GetRootAsRogueResBondLv(_bb, default(RogueResBondLv));
		}

		// Token: 0x0600C70F RID: 50959 RVA: 0x003052C0 File Offset: 0x003034C0
		public static RogueResBondLv GetRootAsRogueResBondLv(ByteBuffer _bb, RogueResBondLv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C710 RID: 50960 RVA: 0x003052DD File Offset: 0x003034DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C711 RID: 50961 RVA: 0x003052EC File Offset: 0x003034EC
		public RogueResBondLv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x0600C712 RID: 50962 RVA: 0x003052FC File Offset: 0x003034FC
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

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x0600C713 RID: 50963 RVA: 0x00305338 File Offset: 0x00303538
		public int Lv
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

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0600C714 RID: 50964 RVA: 0x00305374 File Offset: 0x00303574
		public string LvColor
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

		// Token: 0x0600C715 RID: 50965 RVA: 0x003053AB File Offset: 0x003035AB
		public Span<byte> GetLvColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C716 RID: 50966 RVA: 0x003053BA File Offset: 0x003035BA
		public byte[] GetLvColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040056BE RID: 22206
		private Table __p;
	}
}
