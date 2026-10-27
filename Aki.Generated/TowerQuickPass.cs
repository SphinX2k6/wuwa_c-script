using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001142 RID: 4418
	public struct TowerQuickPass : IFlatbufferObject
	{
		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0600E05C RID: 57436 RVA: 0x003314D8 File Offset: 0x0032F6D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E05D RID: 57437 RVA: 0x003314E5 File Offset: 0x0032F6E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E05E RID: 57438 RVA: 0x003314EC File Offset: 0x0032F6EC
		public static TowerQuickPass GetRootAsTowerQuickPass(ByteBuffer _bb)
		{
			return TowerQuickPass.GetRootAsTowerQuickPass(_bb, default(TowerQuickPass));
		}

		// Token: 0x0600E05F RID: 57439 RVA: 0x00331508 File Offset: 0x0032F708
		public static TowerQuickPass GetRootAsTowerQuickPass(ByteBuffer _bb, TowerQuickPass obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E060 RID: 57440 RVA: 0x00331525 File Offset: 0x0032F725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E061 RID: 57441 RVA: 0x00331534 File Offset: 0x0032F734
		public TowerQuickPass __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0600E062 RID: 57442 RVA: 0x00331544 File Offset: 0x0032F744
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

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0600E063 RID: 57443 RVA: 0x00331580 File Offset: 0x0032F780
		public int Num
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

		// Token: 0x0600E064 RID: 57444 RVA: 0x003315BC File Offset: 0x0032F7BC
		public string QuickPassInst(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0600E065 RID: 57445 RVA: 0x003315F8 File Offset: 0x0032F7F8
		public int QuickPassInstLength
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

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x0600E066 RID: 57446 RVA: 0x00331624 File Offset: 0x0032F824
		public string TipText
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

		// Token: 0x0600E067 RID: 57447 RVA: 0x0033165C File Offset: 0x0032F85C
		public Span<byte> GetTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E068 RID: 57448 RVA: 0x0033166C File Offset: 0x0032F86C
		public byte[] GetTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E069 RID: 57449 RVA: 0x00331684 File Offset: 0x0032F884
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuickPassInstIter()或GetQuickPassInstBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] QuickPassInst()
		{
			return this.QuickPassInstIter().ToArray<string>();
		}

		// Token: 0x0600E06A RID: 57450 RVA: 0x00331691 File Offset: 0x0032F891
		[NullableContext(1)]
		public readonly IEnumerable<string> QuickPassInstIter()
		{
			TowerQuickPass.<QuickPassInstIter>d__20 <QuickPassInstIter>d__ = new TowerQuickPass.<QuickPassInstIter>d__20(-2);
			<QuickPassInstIter>d__.<>3__<>4__this = this;
			return <QuickPassInstIter>d__;
		}

		// Token: 0x04005284 RID: 21124
		private Table __p;
	}
}
