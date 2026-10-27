using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0A RID: 3594
	public struct MingSuPlot : IFlatbufferObject
	{
		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600941F RID: 37919 RVA: 0x00285872 File Offset: 0x00283A72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x0028587F File Offset: 0x00283A7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x00285888 File Offset: 0x00283A88
		public static MingSuPlot GetRootAsMingSuPlot(ByteBuffer _bb)
		{
			return MingSuPlot.GetRootAsMingSuPlot(_bb, default(MingSuPlot));
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x002858A4 File Offset: 0x00283AA4
		public static MingSuPlot GetRootAsMingSuPlot(ByteBuffer _bb, MingSuPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x002858C1 File Offset: 0x00283AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x002858D0 File Offset: 0x00283AD0
		public MingSuPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06009425 RID: 37925 RVA: 0x002858E0 File Offset: 0x00283AE0
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

		// Token: 0x06009426 RID: 37926 RVA: 0x0028591C File Offset: 0x00283B1C
		public string CanLevelUpTips(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06009427 RID: 37927 RVA: 0x00285958 File Offset: 0x00283B58
		public int CanLevelUpTipsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x00285983 File Offset: 0x00283B83
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CanLevelUpTipsIter()或GetCanLevelUpTipsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CanLevelUpTips()
		{
			return this.CanLevelUpTipsIter().ToArray<string>();
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x00285990 File Offset: 0x00283B90
		[NullableContext(1)]
		public readonly IEnumerable<string> CanLevelUpTipsIter()
		{
			MingSuPlot.<CanLevelUpTipsIter>d__14 <CanLevelUpTipsIter>d__ = new MingSuPlot.<CanLevelUpTipsIter>d__14(-2);
			<CanLevelUpTipsIter>d__.<>3__<>4__this = this;
			return <CanLevelUpTipsIter>d__;
		}

		// Token: 0x04004EAF RID: 20143
		private Table __p;
	}
}
