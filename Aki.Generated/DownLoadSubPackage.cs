using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF9 RID: 3065
	public struct DownLoadSubPackage : IFlatbufferObject
	{
		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060062ED RID: 25325 RVA: 0x00214DA8 File Offset: 0x00212FA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x00214DB5 File Offset: 0x00212FB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x00214DBC File Offset: 0x00212FBC
		public static DownLoadSubPackage GetRootAsDownLoadSubPackage(ByteBuffer _bb)
		{
			return DownLoadSubPackage.GetRootAsDownLoadSubPackage(_bb, default(DownLoadSubPackage));
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00214DD8 File Offset: 0x00212FD8
		public static DownLoadSubPackage GetRootAsDownLoadSubPackage(ByteBuffer _bb, DownLoadSubPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x00214DF5 File Offset: 0x00212FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00214E04 File Offset: 0x00213004
		public DownLoadSubPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060062F3 RID: 25331 RVA: 0x00214E14 File Offset: 0x00213014
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

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060062F4 RID: 25332 RVA: 0x00214E50 File Offset: 0x00213050
		public int Version
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

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060062F5 RID: 25333 RVA: 0x00214E8C File Offset: 0x0021308C
		public int Type
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

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060062F6 RID: 25334 RVA: 0x00214EC8 File Offset: 0x002130C8
		public int BelongBranch
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x00214F08 File Offset: 0x00213108
		public int Area(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060062F8 RID: 25336 RVA: 0x00214F48 File Offset: 0x00213148
		public int AreaLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x00214F74 File Offset: 0x00213174
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x00214F84 File Offset: 0x00213184
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060062FB RID: 25339 RVA: 0x00214F9C File Offset: 0x0021319C
		public bool BelongKey
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x00214FDC File Offset: 0x002131DC
		public string Title
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

		// Token: 0x060062FD RID: 25341 RVA: 0x00215014 File Offset: 0x00213214
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00215024 File Offset: 0x00213224
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x0021503C File Offset: 0x0021323C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaIter()或GetAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Area()
		{
			DownLoadSubPackage downLoadSubPackage = this;
			return downLoadSubPackage.GetAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00215060 File Offset: 0x00213260
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaIter()
		{
			DownLoadSubPackage.<AreaIter>d__28 <AreaIter>d__ = new DownLoadSubPackage.<AreaIter>d__28(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x04004C26 RID: 19494
		private Table __p;
	}
}
