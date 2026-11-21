using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A4 RID: 4260
	public struct Revive : IFlatbufferObject
	{
		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0600C236 RID: 49718 RVA: 0x002FA768 File Offset: 0x002F8968
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x002FA775 File Offset: 0x002F8975
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C238 RID: 49720 RVA: 0x002FA77C File Offset: 0x002F897C
		public static Revive GetRootAsRevive(ByteBuffer _bb)
		{
			return Revive.GetRootAsRevive(_bb, default(Revive));
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x002FA798 File Offset: 0x002F8998
		public static Revive GetRootAsRevive(ByteBuffer _bb, Revive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C23A RID: 49722 RVA: 0x002FA7B5 File Offset: 0x002F89B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x002FA7C4 File Offset: 0x002F89C4
		public Revive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600C23C RID: 49724 RVA: 0x002FA7D4 File Offset: 0x002F89D4
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

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600C23D RID: 49725 RVA: 0x002FA810 File Offset: 0x002F8A10
		public int ReviveTimes
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

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600C23E RID: 49726 RVA: 0x002FA84C File Offset: 0x002F8A4C
		public int UseItemId
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

		// Token: 0x0600C23F RID: 49727 RVA: 0x002FA888 File Offset: 0x002F8A88
		public int ReviveDelay(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x0600C240 RID: 49728 RVA: 0x002FA8C8 File Offset: 0x002F8AC8
		public int ReviveDelayLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x002FA8F4 File Offset: 0x002F8AF4
		public Span<int> GetReviveDelayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x002FA904 File Offset: 0x002F8B04
		public int[] GetReviveDelayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x0600C243 RID: 49731 RVA: 0x002FA91C File Offset: 0x002F8B1C
		public string DeathBp
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C244 RID: 49732 RVA: 0x002FA954 File Offset: 0x002F8B54
		public Span<byte> GetDeathBpBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x002FA964 File Offset: 0x002F8B64
		public byte[] GetDeathBpArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600C246 RID: 49734 RVA: 0x002FA97C File Offset: 0x002F8B7C
		public string WindowBp
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

		// Token: 0x0600C247 RID: 49735 RVA: 0x002FA9B4 File Offset: 0x002F8BB4
		public Span<byte> GetWindowBpBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C248 RID: 49736 RVA: 0x002FA9C4 File Offset: 0x002F8BC4
		public byte[] GetWindowBpArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600C249 RID: 49737 RVA: 0x002FA9DC File Offset: 0x002F8BDC
		public string ReviveTitle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C24A RID: 49738 RVA: 0x002FAA14 File Offset: 0x002F8C14
		public Span<byte> GetReviveTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C24B RID: 49739 RVA: 0x002FAA24 File Offset: 0x002F8C24
		public byte[] GetReviveTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600C24C RID: 49740 RVA: 0x002FAA3C File Offset: 0x002F8C3C
		public string ReviveContent
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x002FAA74 File Offset: 0x002F8C74
		public Span<byte> GetReviveContentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x002FAA84 File Offset: 0x002F8C84
		public byte[] GetReviveContentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x0600C24F RID: 49743 RVA: 0x002FAA9C File Offset: 0x002F8C9C
		public string ReviveSequencePath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C250 RID: 49744 RVA: 0x002FAAD4 File Offset: 0x002F8CD4
		public Span<byte> GetReviveSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x002FAAE4 File Offset: 0x002F8CE4
		public byte[] GetReviveSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x002FAAFC File Offset: 0x002F8CFC
		[NullableContext(1)]
		public int[] ReviveDelay()
		{
			return this.GetReviveDelayArray();
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x002FAB04 File Offset: 0x002F8D04
		[NullableContext(1)]
		public IEnumerable<int> ReviveDelayIter()
		{
			Revive.<ReviveDelayIter>d__40 <ReviveDelayIter>d__ = new Revive.<ReviveDelayIter>d__40(-2);
			<ReviveDelayIter>d__.<>3__<>4__this = this;
			return <ReviveDelayIter>d__;
		}

		// Token: 0x0400567E RID: 22142
		private Table __p;
	}
}
