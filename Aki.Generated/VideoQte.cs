using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C5 RID: 4805
	public struct VideoQte : IFlatbufferObject
	{
		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x0600F4AB RID: 62635 RVA: 0x0036BCDD File Offset: 0x00369EDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F4AC RID: 62636 RVA: 0x0036BCEA File Offset: 0x00369EEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F4AD RID: 62637 RVA: 0x0036BCF4 File Offset: 0x00369EF4
		public static VideoQte GetRootAsVideoQte(ByteBuffer _bb)
		{
			return VideoQte.GetRootAsVideoQte(_bb, default(VideoQte));
		}

		// Token: 0x0600F4AE RID: 62638 RVA: 0x0036BD10 File Offset: 0x00369F10
		public static VideoQte GetRootAsVideoQte(ByteBuffer _bb, VideoQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F4AF RID: 62639 RVA: 0x0036BD2D File Offset: 0x00369F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F4B0 RID: 62640 RVA: 0x0036BD3C File Offset: 0x00369F3C
		public VideoQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x0600F4B1 RID: 62641 RVA: 0x0036BD4C File Offset: 0x00369F4C
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

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x0600F4B2 RID: 62642 RVA: 0x0036BD88 File Offset: 0x00369F88
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

		// Token: 0x0600F4B3 RID: 62643 RVA: 0x0036BDBF File Offset: 0x00369FBF
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x0036BDCE File Offset: 0x00369FCE
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x0600F4B5 RID: 62645 RVA: 0x0036BDE8 File Offset: 0x00369FE8
		public int QteId
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

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x0600F4B6 RID: 62646 RVA: 0x0036BE24 File Offset: 0x0036A024
		public int ShowMoment
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

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x0600F4B7 RID: 62647 RVA: 0x0036BE64 File Offset: 0x0036A064
		public int ShowMomentEn
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

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x0600F4B8 RID: 62648 RVA: 0x0036BEA4 File Offset: 0x0036A0A4
		public int ShowMomentKo
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

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x0600F4B9 RID: 62649 RVA: 0x0036BEE4 File Offset: 0x0036A0E4
		public int ShowMomentJa
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400591C RID: 22812
		private Table __p;
	}
}
