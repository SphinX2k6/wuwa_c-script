using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B40 RID: 2880
	public struct BossPilingBuff : IFlatbufferObject
	{
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06004E4E RID: 20046 RVA: 0x001E5CE5 File Offset: 0x001E3EE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x001E5CF2 File Offset: 0x001E3EF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x001E5CFC File Offset: 0x001E3EFC
		public static BossPilingBuff GetRootAsBossPilingBuff(ByteBuffer _bb)
		{
			return BossPilingBuff.GetRootAsBossPilingBuff(_bb, default(BossPilingBuff));
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x001E5D18 File Offset: 0x001E3F18
		public static BossPilingBuff GetRootAsBossPilingBuff(ByteBuffer _bb, BossPilingBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x001E5D35 File Offset: 0x001E3F35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x001E5D44 File Offset: 0x001E3F44
		public BossPilingBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x001E5D54 File Offset: 0x001E3F54
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x001E5D90 File Offset: 0x001E3F90
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x001E5DD0 File Offset: 0x001E3FD0
		public string Name
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

		// Token: 0x06004E57 RID: 20055 RVA: 0x001E5E07 File Offset: 0x001E4007
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x001E5E16 File Offset: 0x001E4016
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x001E5E30 File Offset: 0x001E4030
		public string Icon
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

		// Token: 0x06004E5A RID: 20058 RVA: 0x001E5E68 File Offset: 0x001E4068
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x001E5E78 File Offset: 0x001E4078
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06004E5C RID: 20060 RVA: 0x001E5E90 File Offset: 0x001E4090
		public int Quality
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06004E5D RID: 20061 RVA: 0x001E5ED0 File Offset: 0x001E40D0
		public string Desc
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

		// Token: 0x06004E5E RID: 20062 RVA: 0x001E5F08 File Offset: 0x001E4108
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x001E5F18 File Offset: 0x001E4118
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x001E5F30 File Offset: 0x001E4130
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06004E61 RID: 20065 RVA: 0x001E5F6C File Offset: 0x001E416C
		public int DescArgsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x001E5F98 File Offset: 0x001E4198
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x001E5FA5 File Offset: 0x001E41A5
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			BossPilingBuff.<DescArgsIter>d__30 <DescArgsIter>d__ = new BossPilingBuff.<DescArgsIter>d__30(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x04004B3B RID: 19259
		private Table __p;
	}
}
