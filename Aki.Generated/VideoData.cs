using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C4 RID: 4804
	public struct VideoData : IFlatbufferObject
	{
		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x0600F49A RID: 62618 RVA: 0x0036BA78 File Offset: 0x00369C78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F49B RID: 62619 RVA: 0x0036BA85 File Offset: 0x00369C85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F49C RID: 62620 RVA: 0x0036BA8C File Offset: 0x00369C8C
		public static VideoData GetRootAsVideoData(ByteBuffer _bb)
		{
			return VideoData.GetRootAsVideoData(_bb, default(VideoData));
		}

		// Token: 0x0600F49D RID: 62621 RVA: 0x0036BAA8 File Offset: 0x00369CA8
		public static VideoData GetRootAsVideoData(ByteBuffer _bb, VideoData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F49E RID: 62622 RVA: 0x0036BAC5 File Offset: 0x00369CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F49F RID: 62623 RVA: 0x0036BAD4 File Offset: 0x00369CD4
		public VideoData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x0600F4A0 RID: 62624 RVA: 0x0036BAE4 File Offset: 0x00369CE4
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

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x0600F4A1 RID: 62625 RVA: 0x0036BB20 File Offset: 0x00369D20
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

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x0600F4A2 RID: 62626 RVA: 0x0036BB5C File Offset: 0x00369D5C
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

		// Token: 0x0600F4A3 RID: 62627 RVA: 0x0036BB93 File Offset: 0x00369D93
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600F4A4 RID: 62628 RVA: 0x0036BBA2 File Offset: 0x00369DA2
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x0600F4A5 RID: 62629 RVA: 0x0036BBBC File Offset: 0x00369DBC
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

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x0600F4A6 RID: 62630 RVA: 0x0036BBFC File Offset: 0x00369DFC
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

		// Token: 0x0600F4A7 RID: 62631 RVA: 0x0036BC34 File Offset: 0x00369E34
		public Span<byte> GetCgFileBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F4A8 RID: 62632 RVA: 0x0036BC44 File Offset: 0x00369E44
		public byte[] GetCgFileArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x0600F4A9 RID: 62633 RVA: 0x0036BC5C File Offset: 0x00369E5C
		public bool CanSkip
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x0600F4AA RID: 62634 RVA: 0x0036BC9C File Offset: 0x00369E9C
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

		// Token: 0x0400591B RID: 22811
		private Table __p;
	}
}
