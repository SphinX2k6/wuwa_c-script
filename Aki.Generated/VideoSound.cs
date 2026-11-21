using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C6 RID: 4806
	public struct VideoSound : IFlatbufferObject
	{
		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x0600F4BA RID: 62650 RVA: 0x0036BF21 File Offset: 0x0036A121
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F4BB RID: 62651 RVA: 0x0036BF2E File Offset: 0x0036A12E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F4BC RID: 62652 RVA: 0x0036BF38 File Offset: 0x0036A138
		public static VideoSound GetRootAsVideoSound(ByteBuffer _bb)
		{
			return VideoSound.GetRootAsVideoSound(_bb, default(VideoSound));
		}

		// Token: 0x0600F4BD RID: 62653 RVA: 0x0036BF54 File Offset: 0x0036A154
		public static VideoSound GetRootAsVideoSound(ByteBuffer _bb, VideoSound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F4BE RID: 62654 RVA: 0x0036BF71 File Offset: 0x0036A171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F4BF RID: 62655 RVA: 0x0036BF80 File Offset: 0x0036A180
		public VideoSound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x0600F4C0 RID: 62656 RVA: 0x0036BF90 File Offset: 0x0036A190
		public int CaptionId
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

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x0600F4C1 RID: 62657 RVA: 0x0036BFCC File Offset: 0x0036A1CC
		public string CgName
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

		// Token: 0x0600F4C2 RID: 62658 RVA: 0x0036C003 File Offset: 0x0036A203
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F4C3 RID: 62659 RVA: 0x0036C012 File Offset: 0x0036A212
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x0600F4C4 RID: 62660 RVA: 0x0036C02C File Offset: 0x0036A22C
		public int GirlOrBoy
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x0600F4C5 RID: 62661 RVA: 0x0036C068 File Offset: 0x0036A268
		public string EventPath
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

		// Token: 0x0600F4C6 RID: 62662 RVA: 0x0036C0A0 File Offset: 0x0036A2A0
		public Span<byte> GetEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F4C7 RID: 62663 RVA: 0x0036C0B0 File Offset: 0x0036A2B0
		public byte[] GetEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x0600F4C8 RID: 62664 RVA: 0x0036C0C8 File Offset: 0x0036A2C8
		public float StartMoment
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x0600F4C9 RID: 62665 RVA: 0x0036C10C File Offset: 0x0036A30C
		public float EndMoment
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400591D RID: 22813
		private Table __p;
	}
}
