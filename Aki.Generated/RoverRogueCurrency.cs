using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001075 RID: 4213
	public struct RoverRogueCurrency : IFlatbufferObject
	{
		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x003053F8 File Offset: 0x003035F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD65 RID: 52581 RVA: 0x00305405 File Offset: 0x00303605
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD66 RID: 52582 RVA: 0x0030540C File Offset: 0x0030360C
		public static RoverRogueCurrency GetRootAsRoverRogueCurrency(ByteBuffer _bb)
		{
			return RoverRogueCurrency.GetRootAsRoverRogueCurrency(_bb, default(RoverRogueCurrency));
		}

		// Token: 0x0600CD67 RID: 52583 RVA: 0x00305428 File Offset: 0x00303628
		public static RoverRogueCurrency GetRootAsRoverRogueCurrency(ByteBuffer _bb, RoverRogueCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD68 RID: 52584 RVA: 0x00305445 File Offset: 0x00303645
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD69 RID: 52585 RVA: 0x00305454 File Offset: 0x00303654
		public RoverRogueCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600CD6A RID: 52586 RVA: 0x00305464 File Offset: 0x00303664
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

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600CD6B RID: 52587 RVA: 0x003054A0 File Offset: 0x003036A0
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD6C RID: 52588 RVA: 0x003054DC File Offset: 0x003036DC
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600CD6D RID: 52589 RVA: 0x0030551C File Offset: 0x0030371C
		public int ItemAccessLength
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

		// Token: 0x0600CD6E RID: 52590 RVA: 0x00305547 File Offset: 0x00303747
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600CD6F RID: 52591 RVA: 0x00305556 File Offset: 0x00303756
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600CD70 RID: 52592 RVA: 0x00305570 File Offset: 0x00303770
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

		// Token: 0x0600CD71 RID: 52593 RVA: 0x003055A8 File Offset: 0x003037A8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CD72 RID: 52594 RVA: 0x003055B8 File Offset: 0x003037B8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600CD73 RID: 52595 RVA: 0x003055D0 File Offset: 0x003037D0
		public string IconMiddle
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

		// Token: 0x0600CD74 RID: 52596 RVA: 0x00305608 File Offset: 0x00303808
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CD75 RID: 52597 RVA: 0x00305618 File Offset: 0x00303818
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x00305630 File Offset: 0x00303830
		public string IconSmall
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

		// Token: 0x0600CD77 RID: 52599 RVA: 0x00305668 File Offset: 0x00303868
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CD78 RID: 52600 RVA: 0x00305678 File Offset: 0x00303878
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CD79 RID: 52601 RVA: 0x00305690 File Offset: 0x00303890
		public int ShowTypes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600CD7A RID: 52602 RVA: 0x003056D0 File Offset: 0x003038D0
		public int ShowTypesLength
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

		// Token: 0x0600CD7B RID: 52603 RVA: 0x003056FC File Offset: 0x003038FC
		public Span<int> GetShowTypesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600CD7C RID: 52604 RVA: 0x0030570C File Offset: 0x0030390C
		public int[] GetShowTypesArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600CD7D RID: 52605 RVA: 0x00305724 File Offset: 0x00303924
		public string Title
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD7E RID: 52606 RVA: 0x0030575C File Offset: 0x0030395C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CD7F RID: 52607 RVA: 0x0030576C File Offset: 0x0030396C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x00305784 File Offset: 0x00303984
		public string AttributesDescription
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

		// Token: 0x0600CD81 RID: 52609 RVA: 0x003057BC File Offset: 0x003039BC
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CD82 RID: 52610 RVA: 0x003057CC File Offset: 0x003039CC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600CD83 RID: 52611 RVA: 0x003057E4 File Offset: 0x003039E4
		public string ObtainedShowDescription
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

		// Token: 0x0600CD84 RID: 52612 RVA: 0x0030581C File Offset: 0x00303A1C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CD85 RID: 52613 RVA: 0x0030582C File Offset: 0x00303A2C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600CD86 RID: 52614 RVA: 0x00305844 File Offset: 0x00303A44
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD87 RID: 52615 RVA: 0x0030587C File Offset: 0x00303A7C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600CD88 RID: 52616 RVA: 0x0030588C File Offset: 0x00303A8C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600CD89 RID: 52617 RVA: 0x003058A4 File Offset: 0x00303AA4
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CD8A RID: 52618 RVA: 0x003058DC File Offset: 0x00303ADC
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CD8B RID: 52619 RVA: 0x003058EC File Offset: 0x00303AEC
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CD8C RID: 52620 RVA: 0x00305904 File Offset: 0x00303B04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			RoverRogueCurrency roverRogueCurrency = this;
			return roverRogueCurrency.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CD8D RID: 52621 RVA: 0x00305928 File Offset: 0x00303B28
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			RoverRogueCurrency.<ItemAccessIter>d__55 <ItemAccessIter>d__ = new RoverRogueCurrency.<ItemAccessIter>d__55(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600CD8E RID: 52622 RVA: 0x00305940 File Offset: 0x00303B40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowTypesIter()或GetShowTypesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowTypes()
		{
			RoverRogueCurrency roverRogueCurrency = this;
			return roverRogueCurrency.GetShowTypesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CD8F RID: 52623 RVA: 0x00305964 File Offset: 0x00303B64
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowTypesIter()
		{
			RoverRogueCurrency.<ShowTypesIter>d__57 <ShowTypesIter>d__ = new RoverRogueCurrency.<ShowTypesIter>d__57(-2);
			<ShowTypesIter>d__.<>3__<>4__this = this;
			return <ShowTypesIter>d__;
		}

		// Token: 0x0400517F RID: 20863
		private Table __p;
	}
}
