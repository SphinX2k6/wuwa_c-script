using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B39 RID: 2873
	public struct BlackSwordChallenge : IFlatbufferObject
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06004DAF RID: 19887 RVA: 0x001E48B9 File Offset: 0x001E2AB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x001E48C6 File Offset: 0x001E2AC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x001E48D0 File Offset: 0x001E2AD0
		public static BlackSwordChallenge GetRootAsBlackSwordChallenge(ByteBuffer _bb)
		{
			return BlackSwordChallenge.GetRootAsBlackSwordChallenge(_bb, default(BlackSwordChallenge));
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x001E48EC File Offset: 0x001E2AEC
		public static BlackSwordChallenge GetRootAsBlackSwordChallenge(ByteBuffer _bb, BlackSwordChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x001E4909 File Offset: 0x001E2B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x001E4918 File Offset: 0x001E2B18
		public BlackSwordChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06004DB5 RID: 19893 RVA: 0x001E4928 File Offset: 0x001E2B28
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

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x001E4964 File Offset: 0x001E2B64
		public int RelativeDungeonId
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

		// Token: 0x06004DB7 RID: 19895 RVA: 0x001E49A0 File Offset: 0x001E2BA0
		public int GroupId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x001E49E0 File Offset: 0x001E2BE0
		public int GroupIdLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x001E4A0B File Offset: 0x001E2C0B
		public Span<int> GetGroupIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x001E4A1A File Offset: 0x001E2C1A
		public int[] GetGroupIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06004DBB RID: 19899 RVA: 0x001E4A34 File Offset: 0x001E2C34
		public string Title
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

		// Token: 0x06004DBC RID: 19900 RVA: 0x001E4A6C File Offset: 0x001E2C6C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x001E4A7C File Offset: 0x001E2C7C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x001E4A94 File Offset: 0x001E2C94
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

		// Token: 0x06004DBF RID: 19903 RVA: 0x001E4ACC File Offset: 0x001E2CCC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x001E4ADC File Offset: 0x001E2CDC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x001E4AF4 File Offset: 0x001E2CF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupIdIter()或GetGroupIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupId()
		{
			BlackSwordChallenge blackSwordChallenge = this;
			return blackSwordChallenge.GetGroupIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x001E4B18 File Offset: 0x001E2D18
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupIdIter()
		{
			BlackSwordChallenge.<GroupIdIter>d__26 <GroupIdIter>d__ = new BlackSwordChallenge.<GroupIdIter>d__26(-2);
			<GroupIdIter>d__.<>3__<>4__this = this;
			return <GroupIdIter>d__;
		}

		// Token: 0x04004B34 RID: 19252
		private Table __p;
	}
}
