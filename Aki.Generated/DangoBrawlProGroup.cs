using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCC RID: 3020
	public struct DangoBrawlProGroup : IFlatbufferObject
	{
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x0020C3FC File Offset: 0x0020A5FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x0020C409 File Offset: 0x0020A609
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x0020C410 File Offset: 0x0020A610
		public static DangoBrawlProGroup GetRootAsDangoBrawlProGroup(ByteBuffer _bb)
		{
			return DangoBrawlProGroup.GetRootAsDangoBrawlProGroup(_bb, default(DangoBrawlProGroup));
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x0020C42C File Offset: 0x0020A62C
		public static DangoBrawlProGroup GetRootAsDangoBrawlProGroup(ByteBuffer _bb, DangoBrawlProGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x0020C449 File Offset: 0x0020A649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x0020C458 File Offset: 0x0020A658
		public DangoBrawlProGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06005EF7 RID: 24311 RVA: 0x0020C468 File Offset: 0x0020A668
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

		// Token: 0x06005EF8 RID: 24312 RVA: 0x0020C4A4 File Offset: 0x0020A6A4
		public ProAddEntry? InitAttr(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ProAddEntry?(default(ProAddEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06005EF9 RID: 24313 RVA: 0x0020C504 File Offset: 0x0020A704
		public int InitAttrLength
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

		// Token: 0x06005EFA RID: 24314 RVA: 0x0020C52F File Offset: 0x0020A72F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitAttrIter()或GetInitAttrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ProAddEntry[] InitAttr()
		{
			return this.InitAttrIter().ToArray<ProAddEntry>();
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x0020C53C File Offset: 0x0020A73C
		[NullableContext(1)]
		public readonly IEnumerable<ProAddEntry> InitAttrIter()
		{
			DangoBrawlProGroup.<InitAttrIter>d__14 <InitAttrIter>d__ = new DangoBrawlProGroup.<InitAttrIter>d__14(-2);
			<InitAttrIter>d__.<>3__<>4__this = this;
			return <InitAttrIter>d__;
		}

		// Token: 0x04004BF6 RID: 19446
		private Table __p;
	}
}
