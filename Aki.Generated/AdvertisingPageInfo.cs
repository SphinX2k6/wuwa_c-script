using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB1 RID: 2993
	public struct AdvertisingPageInfo : IFlatbufferObject
	{
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x001EEB24 File Offset: 0x001ECD24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x001EEB31 File Offset: 0x001ECD31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001EEB38 File Offset: 0x001ECD38
		public static AdvertisingPageInfo GetRootAsAdvertisingPageInfo(ByteBuffer _bb)
		{
			return AdvertisingPageInfo.GetRootAsAdvertisingPageInfo(_bb, default(AdvertisingPageInfo));
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x001EEB54 File Offset: 0x001ECD54
		public static AdvertisingPageInfo GetRootAsAdvertisingPageInfo(ByteBuffer _bb, AdvertisingPageInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x001EEB71 File Offset: 0x001ECD71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x001EEB80 File Offset: 0x001ECD80
		public AdvertisingPageInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060049FC RID: 18940 RVA: 0x001EEB90 File Offset: 0x001ECD90
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

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060049FD RID: 18941 RVA: 0x001EEBCC File Offset: 0x001ECDCC
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060049FE RID: 18942 RVA: 0x001EEC08 File Offset: 0x001ECE08
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

		// Token: 0x060049FF RID: 18943 RVA: 0x001EEC3F File Offset: 0x001ECE3F
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x001EEC4E File Offset: 0x001ECE4E
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06004A01 RID: 18945 RVA: 0x001EEC68 File Offset: 0x001ECE68
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

		// Token: 0x06004A02 RID: 18946 RVA: 0x001EECA0 File Offset: 0x001ECEA0
		public Span<byte> GetResourceVersionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x001EECB0 File Offset: 0x001ECEB0
		public byte[] GetResourceVersionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x001EECC8 File Offset: 0x001ECEC8
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

		// Token: 0x06004A05 RID: 18949 RVA: 0x001EED00 File Offset: 0x001ECF00
		public Span<byte> GetTitleVersionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x001EED10 File Offset: 0x001ECF10
		public byte[] GetTitleVersionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x001EED28 File Offset: 0x001ECF28
		public int TabIdArray(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06004A08 RID: 18952 RVA: 0x001EED68 File Offset: 0x001ECF68
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

		// Token: 0x06004A09 RID: 18953 RVA: 0x001EED94 File Offset: 0x001ECF94
		public Span<int> GetTabIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x001EEDA4 File Offset: 0x001ECFA4
		public int[] GetTabIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06004A0B RID: 18955 RVA: 0x001EEDBC File Offset: 0x001ECFBC
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

		// Token: 0x06004A0C RID: 18956 RVA: 0x001EEDF4 File Offset: 0x001ECFF4
		public Span<byte> GetOpenTimeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x001EEE04 File Offset: 0x001ED004
		public byte[] GetOpenTimeTextArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06004A0E RID: 18958 RVA: 0x001EEE1C File Offset: 0x001ED01C
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06004A0F RID: 18959 RVA: 0x001EEE5C File Offset: 0x001ED05C
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

		// Token: 0x06004A10 RID: 18960 RVA: 0x001EEE94 File Offset: 0x001ED094
		public Span<byte> GetPVTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x001EEEA4 File Offset: 0x001ED0A4
		public byte[] GetPVTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06004A12 RID: 18962 RVA: 0x001EEEBC File Offset: 0x001ED0BC
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

		// Token: 0x06004A13 RID: 18963 RVA: 0x001EEEF4 File Offset: 0x001ED0F4
		public Span<byte> GetInscriptionPicBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x001EEF04 File Offset: 0x001ED104
		public byte[] GetInscriptionPicArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x001EEF1C File Offset: 0x001ED11C
		[NullableContext(1)]
		public int[] TabIdArray()
		{
			return this.GetTabIdArrayArray();
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x001EEF24 File Offset: 0x001ED124
		[NullableContext(1)]
		public IEnumerable<int> TabIdArrayIter()
		{
			AdvertisingPageInfo.<TabIdArrayIter>d__44 <TabIdArrayIter>d__ = new AdvertisingPageInfo.<TabIdArrayIter>d__44(-2);
			<TabIdArrayIter>d__.<>3__<>4__this = this;
			return <TabIdArrayIter>d__;
		}

		// Token: 0x04005090 RID: 20624
		private Table __p;
	}
}
