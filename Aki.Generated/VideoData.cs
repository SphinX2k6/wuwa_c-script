using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118E RID: 4494
	public struct VideoData : IFlatbufferObject
	{
		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x0600E72C RID: 59180 RVA: 0x00340CC0 File Offset: 0x0033EEC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E72D RID: 59181 RVA: 0x00340CCD File Offset: 0x0033EECD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x00340CD4 File Offset: 0x0033EED4
		public static VideoData GetRootAsVideoData(ByteBuffer _bb)
		{
			return VideoData.GetRootAsVideoData(_bb, default(VideoData));
		}

		// Token: 0x0600E72F RID: 59183 RVA: 0x00340CF0 File Offset: 0x0033EEF0
		public static VideoData GetRootAsVideoData(ByteBuffer _bb, VideoData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E730 RID: 59184 RVA: 0x00340D0D File Offset: 0x0033EF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x00340D1C File Offset: 0x0033EF1C
		public VideoData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x0600E732 RID: 59186 RVA: 0x00340D2C File Offset: 0x0033EF2C
		public int CgId
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

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x0600E733 RID: 59187 RVA: 0x00340D68 File Offset: 0x0033EF68
		public int BelongBranch
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x0600E734 RID: 59188 RVA: 0x00340DA4 File Offset: 0x0033EFA4
		public string CgName
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

		// Token: 0x0600E735 RID: 59189 RVA: 0x00340DDB File Offset: 0x0033EFDB
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x00340DEA File Offset: 0x0033EFEA
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x0600E737 RID: 59191 RVA: 0x00340E04 File Offset: 0x0033F004
		public int GirlOrBoy
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x0600E738 RID: 59192 RVA: 0x00340E44 File Offset: 0x0033F044
		public string CgFile
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

		// Token: 0x0600E739 RID: 59193 RVA: 0x00340E7C File Offset: 0x0033F07C
		public Span<byte> GetCgFileBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E73A RID: 59194 RVA: 0x00340E8C File Offset: 0x0033F08C
		public byte[] GetCgFileArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x0600E73B RID: 59195 RVA: 0x00340EA4 File Offset: 0x0033F0A4
		public bool CanSkip
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x0600E73C RID: 59196 RVA: 0x00340EE4 File Offset: 0x0033F0E4
		public float Aspect
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 2.38f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052D8 RID: 21208
		private Table __p;
	}
}
