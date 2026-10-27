using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB4 RID: 3252
	public struct FloroRanchTag : IFlatbufferObject
	{
		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x0600745F RID: 29791 RVA: 0x0023D8FC File Offset: 0x0023BAFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x0023D909 File Offset: 0x0023BB09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x0023D910 File Offset: 0x0023BB10
		public static FloroRanchTag GetRootAsFloroRanchTag(ByteBuffer _bb)
		{
			return FloroRanchTag.GetRootAsFloroRanchTag(_bb, default(FloroRanchTag));
		}

		// Token: 0x06007462 RID: 29794 RVA: 0x0023D92C File Offset: 0x0023BB2C
		public static FloroRanchTag GetRootAsFloroRanchTag(ByteBuffer _bb, FloroRanchTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007463 RID: 29795 RVA: 0x0023D949 File Offset: 0x0023BB49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007464 RID: 29796 RVA: 0x0023D958 File Offset: 0x0023BB58
		public FloroRanchTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06007465 RID: 29797 RVA: 0x0023D968 File Offset: 0x0023BB68
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

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06007466 RID: 29798 RVA: 0x0023D9A4 File Offset: 0x0023BBA4
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

		// Token: 0x06007467 RID: 29799 RVA: 0x0023D9DB File Offset: 0x0023BBDB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x0023D9EA File Offset: 0x0023BBEA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x0023DA04 File Offset: 0x0023BC04
		public string NameParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x0600746A RID: 29802 RVA: 0x0023DA40 File Offset: 0x0023BC40
		public int NameParamLength
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

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x0600746B RID: 29803 RVA: 0x0023DA6C File Offset: 0x0023BC6C
		public string N
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

		// Token: 0x0600746C RID: 29804 RVA: 0x0023DAA4 File Offset: 0x0023BCA4
		public Span<byte> GetNBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600746D RID: 29805 RVA: 0x0023DAB4 File Offset: 0x0023BCB4
		public byte[] GetNArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x0600746E RID: 29806 RVA: 0x0023DACC File Offset: 0x0023BCCC
		public string M
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

		// Token: 0x0600746F RID: 29807 RVA: 0x0023DB04 File Offset: 0x0023BD04
		public Span<byte> GetMBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x0023DB14 File Offset: 0x0023BD14
		public byte[] GetMArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06007471 RID: 29809 RVA: 0x0023DB2C File Offset: 0x0023BD2C
		public string P
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

		// Token: 0x06007472 RID: 29810 RVA: 0x0023DB64 File Offset: 0x0023BD64
		public Span<byte> GetPBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x0023DB74 File Offset: 0x0023BD74
		public byte[] GetPArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x0023DB8C File Offset: 0x0023BD8C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NameParamIter()或GetNameParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] NameParam()
		{
			return this.NameParamIter().ToArray<string>();
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x0023DB99 File Offset: 0x0023BD99
		[NullableContext(1)]
		public readonly IEnumerable<string> NameParamIter()
		{
			FloroRanchTag.<NameParamIter>d__30 <NameParamIter>d__ = new FloroRanchTag.<NameParamIter>d__30(-2);
			<NameParamIter>d__.<>3__<>4__this = this;
			return <NameParamIter>d__;
		}

		// Token: 0x04004D1F RID: 19743
		private Table __p;
	}
}
