using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115B RID: 4443
	public struct TrapDefenseBdGroup : IFlatbufferObject
	{
		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600E2D4 RID: 58068 RVA: 0x00336EA1 File Offset: 0x003350A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E2D5 RID: 58069 RVA: 0x00336EAE File Offset: 0x003350AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E2D6 RID: 58070 RVA: 0x00336EB8 File Offset: 0x003350B8
		public static TrapDefenseBdGroup GetRootAsTrapDefenseBdGroup(ByteBuffer _bb)
		{
			return TrapDefenseBdGroup.GetRootAsTrapDefenseBdGroup(_bb, default(TrapDefenseBdGroup));
		}

		// Token: 0x0600E2D7 RID: 58071 RVA: 0x00336ED4 File Offset: 0x003350D4
		public static TrapDefenseBdGroup GetRootAsTrapDefenseBdGroup(ByteBuffer _bb, TrapDefenseBdGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E2D8 RID: 58072 RVA: 0x00336EF1 File Offset: 0x003350F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E2D9 RID: 58073 RVA: 0x00336F00 File Offset: 0x00335100
		public TrapDefenseBdGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600E2DA RID: 58074 RVA: 0x00336F10 File Offset: 0x00335110
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

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600E2DB RID: 58075 RVA: 0x00336F4C File Offset: 0x0033514C
		public int BelongBd
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

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0600E2DC RID: 58076 RVA: 0x00336F88 File Offset: 0x00335188
		public int ShopPrice
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0600E2DD RID: 58077 RVA: 0x00336FC8 File Offset: 0x003351C8
		public int Quality
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

		// Token: 0x0600E2DE RID: 58078 RVA: 0x00337008 File Offset: 0x00335208
		public int PreorderBdGroupIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600E2DF RID: 58079 RVA: 0x00337048 File Offset: 0x00335248
		public int PreorderBdGroupIdsLength
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

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x00337074 File Offset: 0x00335274
		public Span<int> GetPreorderBdGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x00337084 File Offset: 0x00335284
		public int[] GetPreorderBdGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E2E2 RID: 58082 RVA: 0x0033709C File Offset: 0x0033529C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreorderBdGroupIdsIter()或GetPreorderBdGroupIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreorderBdGroupIds()
		{
			TrapDefenseBdGroup trapDefenseBdGroup = this;
			return trapDefenseBdGroup.GetPreorderBdGroupIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E2E3 RID: 58083 RVA: 0x003370C0 File Offset: 0x003352C0
		[NullableContext(1)]
		public readonly IEnumerable<int> PreorderBdGroupIdsIter()
		{
			TrapDefenseBdGroup.<PreorderBdGroupIdsIter>d__22 <PreorderBdGroupIdsIter>d__ = new TrapDefenseBdGroup.<PreorderBdGroupIdsIter>d__22(-2);
			<PreorderBdGroupIdsIter>d__.<>3__<>4__this = this;
			return <PreorderBdGroupIdsIter>d__;
		}

		// Token: 0x040052A0 RID: 21152
		private Table __p;
	}
}
