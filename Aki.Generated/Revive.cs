using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBC RID: 4028
	public struct Revive : IFlatbufferObject
	{
		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600BBEC RID: 48108 RVA: 0x002DE034 File Offset: 0x002DC234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x002DE041 File Offset: 0x002DC241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x002DE048 File Offset: 0x002DC248
		public static Revive GetRootAsRevive(ByteBuffer _bb)
		{
			return Revive.GetRootAsRevive(_bb, default(Revive));
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x002DE064 File Offset: 0x002DC264
		public static Revive GetRootAsRevive(ByteBuffer _bb, Revive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBF0 RID: 48112 RVA: 0x002DE081 File Offset: 0x002DC281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBF1 RID: 48113 RVA: 0x002DE090 File Offset: 0x002DC290
		public Revive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x002DE0A0 File Offset: 0x002DC2A0
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

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600BBF3 RID: 48115 RVA: 0x002DE0DC File Offset: 0x002DC2DC
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

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x002DE118 File Offset: 0x002DC318
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

		// Token: 0x0600BBF5 RID: 48117 RVA: 0x002DE154 File Offset: 0x002DC354
		public int ReviveDelay(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600BBF6 RID: 48118 RVA: 0x002DE194 File Offset: 0x002DC394
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

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x002DE1C0 File Offset: 0x002DC3C0
		public Span<int> GetReviveDelayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x002DE1D0 File Offset: 0x002DC3D0
		public int[] GetReviveDelayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600BBF9 RID: 48121 RVA: 0x002DE1E8 File Offset: 0x002DC3E8
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

		// Token: 0x0600BBFA RID: 48122 RVA: 0x002DE220 File Offset: 0x002DC420
		public Span<byte> GetDeathBpBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x002DE230 File Offset: 0x002DC430
		public byte[] GetDeathBpArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x002DE248 File Offset: 0x002DC448
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

		// Token: 0x0600BBFD RID: 48125 RVA: 0x002DE280 File Offset: 0x002DC480
		public Span<byte> GetWindowBpBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BBFE RID: 48126 RVA: 0x002DE290 File Offset: 0x002DC490
		public byte[] GetWindowBpArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0600BBFF RID: 48127 RVA: 0x002DE2A8 File Offset: 0x002DC4A8
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

		// Token: 0x0600BC00 RID: 48128 RVA: 0x002DE2E0 File Offset: 0x002DC4E0
		public Span<byte> GetReviveTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BC01 RID: 48129 RVA: 0x002DE2F0 File Offset: 0x002DC4F0
		public byte[] GetReviveTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0600BC02 RID: 48130 RVA: 0x002DE308 File Offset: 0x002DC508
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

		// Token: 0x0600BC03 RID: 48131 RVA: 0x002DE340 File Offset: 0x002DC540
		public Span<byte> GetReviveContentBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x002DE350 File Offset: 0x002DC550
		public byte[] GetReviveContentArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0600BC05 RID: 48133 RVA: 0x002DE368 File Offset: 0x002DC568
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

		// Token: 0x0600BC06 RID: 48134 RVA: 0x002DE3A0 File Offset: 0x002DC5A0
		public Span<byte> GetReviveSequencePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BC07 RID: 48135 RVA: 0x002DE3B0 File Offset: 0x002DC5B0
		public byte[] GetReviveSequencePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x002DE3C8 File Offset: 0x002DC5C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReviveDelayIter()或GetReviveDelayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReviveDelay()
		{
			Revive revive = this;
			return revive.GetReviveDelayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BC09 RID: 48137 RVA: 0x002DE3EC File Offset: 0x002DC5EC
		[NullableContext(1)]
		public readonly IEnumerable<int> ReviveDelayIter()
		{
			Revive.<ReviveDelayIter>d__40 <ReviveDelayIter>d__ = new Revive.<ReviveDelayIter>d__40(-2);
			<ReviveDelayIter>d__.<>3__<>4__this = this;
			return <ReviveDelayIter>d__;
		}

		// Token: 0x04005096 RID: 20630
		private Table __p;
	}
}
