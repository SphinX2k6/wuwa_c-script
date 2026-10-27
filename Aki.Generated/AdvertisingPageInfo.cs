using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD7 RID: 2775
	public struct AdvertisingPageInfo : IFlatbufferObject
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x001CF034 File Offset: 0x001CD234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x001CF041 File Offset: 0x001CD241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x001CF048 File Offset: 0x001CD248
		public static AdvertisingPageInfo GetRootAsAdvertisingPageInfo(ByteBuffer _bb)
		{
			return AdvertisingPageInfo.GetRootAsAdvertisingPageInfo(_bb, default(AdvertisingPageInfo));
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x001CF064 File Offset: 0x001CD264
		public static AdvertisingPageInfo GetRootAsAdvertisingPageInfo(ByteBuffer _bb, AdvertisingPageInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x001CF081 File Offset: 0x001CD281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x001CF090 File Offset: 0x001CD290
		public AdvertisingPageInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x001CF0A0 File Offset: 0x001CD2A0
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x001CF0DC File Offset: 0x001CD2DC
		public int ActivityId
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x001CF118 File Offset: 0x001CD318
		public string TitleText
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

		// Token: 0x060044B8 RID: 17592 RVA: 0x001CF14F File Offset: 0x001CD34F
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x001CF15E File Offset: 0x001CD35E
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x001CF178 File Offset: 0x001CD378
		public string ResourceVersion
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

		// Token: 0x060044BB RID: 17595 RVA: 0x001CF1B0 File Offset: 0x001CD3B0
		public Span<byte> GetResourceVersionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x001CF1C0 File Offset: 0x001CD3C0
		public byte[] GetResourceVersionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060044BD RID: 17597 RVA: 0x001CF1D8 File Offset: 0x001CD3D8
		public string TitleVersion
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

		// Token: 0x060044BE RID: 17598 RVA: 0x001CF210 File Offset: 0x001CD410
		public Span<byte> GetTitleVersionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x001CF220 File Offset: 0x001CD420
		public byte[] GetTitleVersionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x001CF238 File Offset: 0x001CD438
		public int TabIdArray(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060044C1 RID: 17601 RVA: 0x001CF278 File Offset: 0x001CD478
		public int TabIdArrayLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x001CF2A4 File Offset: 0x001CD4A4
		public Span<int> GetTabIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x001CF2B4 File Offset: 0x001CD4B4
		public int[] GetTabIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x001CF2CC File Offset: 0x001CD4CC
		public string OpenTimeText
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

		// Token: 0x060044C5 RID: 17605 RVA: 0x001CF304 File Offset: 0x001CD504
		public Span<byte> GetOpenTimeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x001CF314 File Offset: 0x001CD514
		public byte[] GetOpenTimeTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x001CF32C File Offset: 0x001CD52C
		public int PVLinkId
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x001CF36C File Offset: 0x001CD56C
		public string PVText
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x001CF3A4 File Offset: 0x001CD5A4
		public Span<byte> GetPVTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x001CF3B4 File Offset: 0x001CD5B4
		public byte[] GetPVTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060044CB RID: 17611 RVA: 0x001CF3CC File Offset: 0x001CD5CC
		public string InscriptionPic
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x001CF404 File Offset: 0x001CD604
		public Span<byte> GetInscriptionPicBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x001CF414 File Offset: 0x001CD614
		public byte[] GetInscriptionPicArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x001CF42C File Offset: 0x001CD62C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TabIdArrayIter()或GetTabIdArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TabIdArray()
		{
			AdvertisingPageInfo advertisingPageInfo = this;
			return advertisingPageInfo.GetTabIdArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x001CF450 File Offset: 0x001CD650
		[NullableContext(1)]
		public readonly IEnumerable<int> TabIdArrayIter()
		{
			AdvertisingPageInfo.<TabIdArrayIter>d__44 <TabIdArrayIter>d__ = new AdvertisingPageInfo.<TabIdArrayIter>d__44(-2);
			<TabIdArrayIter>d__.<>3__<>4__this = this;
			return <TabIdArrayIter>d__;
		}

		// Token: 0x04004AB6 RID: 19126
		private Table __p;
	}
}
