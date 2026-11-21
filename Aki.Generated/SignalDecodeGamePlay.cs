using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A9 RID: 4521
	public struct SignalDecodeGamePlay : IFlatbufferObject
	{
		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600DA04 RID: 55812 RVA: 0x0032F2FA File Offset: 0x0032D4FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA05 RID: 55813 RVA: 0x0032F307 File Offset: 0x0032D507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA06 RID: 55814 RVA: 0x0032F310 File Offset: 0x0032D510
		public static SignalDecodeGamePlay GetRootAsSignalDecodeGamePlay(ByteBuffer _bb)
		{
			return SignalDecodeGamePlay.GetRootAsSignalDecodeGamePlay(_bb, default(SignalDecodeGamePlay));
		}

		// Token: 0x0600DA07 RID: 55815 RVA: 0x0032F32C File Offset: 0x0032D52C
		public static SignalDecodeGamePlay GetRootAsSignalDecodeGamePlay(ByteBuffer _bb, SignalDecodeGamePlay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA08 RID: 55816 RVA: 0x0032F349 File Offset: 0x0032D549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA09 RID: 55817 RVA: 0x0032F358 File Offset: 0x0032D558
		public SignalDecodeGamePlay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600DA0A RID: 55818 RVA: 0x0032F368 File Offset: 0x0032D568
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DA0B RID: 55819 RVA: 0x0032F39F File Offset: 0x0032D59F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600DA0C RID: 55820 RVA: 0x0032F3AE File Offset: 0x0032D5AE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600DA0D RID: 55821 RVA: 0x0032F3C8 File Offset: 0x0032D5C8
		public string Name
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

		// Token: 0x0600DA0E RID: 55822 RVA: 0x0032F3FF File Offset: 0x0032D5FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DA0F RID: 55823 RVA: 0x0032F40E File Offset: 0x0032D60E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600DA10 RID: 55824 RVA: 0x0032F428 File Offset: 0x0032D628
		public int SignalData1
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

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600DA11 RID: 55825 RVA: 0x0032F464 File Offset: 0x0032D664
		public int SignalData2
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

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600DA12 RID: 55826 RVA: 0x0032F4A4 File Offset: 0x0032D6A4
		public int SignalData3
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

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600DA13 RID: 55827 RVA: 0x0032F4E4 File Offset: 0x0032D6E4
		public int SignalData4
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040057C0 RID: 22464
		private Table __p;
	}
}
