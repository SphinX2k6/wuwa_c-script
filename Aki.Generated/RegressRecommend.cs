using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB2 RID: 4018
	public struct RegressRecommend : IFlatbufferObject
	{
		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0600BB28 RID: 47912 RVA: 0x002DC5A9 File Offset: 0x002DA7A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB29 RID: 47913 RVA: 0x002DC5B6 File Offset: 0x002DA7B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB2A RID: 47914 RVA: 0x002DC5C0 File Offset: 0x002DA7C0
		public static RegressRecommend GetRootAsRegressRecommend(ByteBuffer _bb)
		{
			return RegressRecommend.GetRootAsRegressRecommend(_bb, default(RegressRecommend));
		}

		// Token: 0x0600BB2B RID: 47915 RVA: 0x002DC5DC File Offset: 0x002DA7DC
		public static RegressRecommend GetRootAsRegressRecommend(ByteBuffer _bb, RegressRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x002DC5F9 File Offset: 0x002DA7F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB2D RID: 47917 RVA: 0x002DC608 File Offset: 0x002DA808
		public RegressRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0600BB2E RID: 47918 RVA: 0x002DC618 File Offset: 0x002DA818
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

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600BB2F RID: 47919 RVA: 0x002DC654 File Offset: 0x002DA854
		public int Type
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

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x002DC690 File Offset: 0x002DA890
		public int ActivityGroup
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

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0600BB31 RID: 47921 RVA: 0x002DC6CC File Offset: 0x002DA8CC
		public int Sort
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

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x002DC70C File Offset: 0x002DA90C
		public string Icon
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

		// Token: 0x0600BB33 RID: 47923 RVA: 0x002DC744 File Offset: 0x002DA944
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BB34 RID: 47924 RVA: 0x002DC754 File Offset: 0x002DA954
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0600BB35 RID: 47925 RVA: 0x002DC76C File Offset: 0x002DA96C
		public string Title
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

		// Token: 0x0600BB36 RID: 47926 RVA: 0x002DC7A4 File Offset: 0x002DA9A4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BB37 RID: 47927 RVA: 0x002DC7B4 File Offset: 0x002DA9B4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x002DC7CC File Offset: 0x002DA9CC
		public string TagIcon
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

		// Token: 0x0600BB39 RID: 47929 RVA: 0x002DC804 File Offset: 0x002DAA04
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BB3A RID: 47930 RVA: 0x002DC814 File Offset: 0x002DAA14
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0600BB3B RID: 47931 RVA: 0x002DC82C File Offset: 0x002DAA2C
		public int ShowReward
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0600BB3C RID: 47932 RVA: 0x002DC86C File Offset: 0x002DAA6C
		public int JumpParam
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400508B RID: 20619
		private Table __p;
	}
}
