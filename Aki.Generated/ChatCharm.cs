using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B69 RID: 2921
	public struct ChatCharm : IFlatbufferObject
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600534B RID: 21323 RVA: 0x001F155D File Offset: 0x001EF75D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x001F156A File Offset: 0x001EF76A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x001F1574 File Offset: 0x001EF774
		public static ChatCharm GetRootAsChatCharm(ByteBuffer _bb)
		{
			return ChatCharm.GetRootAsChatCharm(_bb, default(ChatCharm));
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x001F1590 File Offset: 0x001EF790
		public static ChatCharm GetRootAsChatCharm(ByteBuffer _bb, ChatCharm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x001F15AD File Offset: 0x001EF7AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x001F15BC File Offset: 0x001EF7BC
		public ChatCharm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06005351 RID: 21329 RVA: 0x001F15CC File Offset: 0x001EF7CC
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

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x001F1608 File Offset: 0x001EF808
		public int QualityId
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

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06005353 RID: 21331 RVA: 0x001F1644 File Offset: 0x001EF844
		public string ChatCharmPathSmall
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

		// Token: 0x06005354 RID: 21332 RVA: 0x001F167B File Offset: 0x001EF87B
		public Span<byte> GetChatCharmPathSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x001F168A File Offset: 0x001EF88A
		public byte[] GetChatCharmPathSmallArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x001F16A4 File Offset: 0x001EF8A4
		public string Name
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

		// Token: 0x06005357 RID: 21335 RVA: 0x001F16DC File Offset: 0x001EF8DC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x001F16EC File Offset: 0x001EF8EC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06005359 RID: 21337 RVA: 0x001F1704 File Offset: 0x001EF904
		public string Desc
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

		// Token: 0x0600535A RID: 21338 RVA: 0x001F173C File Offset: 0x001EF93C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x001F174C File Offset: 0x001EF94C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600535C RID: 21340 RVA: 0x001F1764 File Offset: 0x001EF964
		public string GetWay
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

		// Token: 0x0600535D RID: 21341 RVA: 0x001F179C File Offset: 0x001EF99C
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x001F17AC File Offset: 0x001EF9AC
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x0600535F RID: 21343 RVA: 0x001F17C4 File Offset: 0x001EF9C4
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x001F1804 File Offset: 0x001EFA04
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x001F1844 File Offset: 0x001EFA44
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x001F1870 File Offset: 0x001EFA70
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x001F1880 File Offset: 0x001EFA80
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06005364 RID: 21348 RVA: 0x001F1898 File Offset: 0x001EFA98
		public string SpineAtlas
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

		// Token: 0x06005365 RID: 21349 RVA: 0x001F18D0 File Offset: 0x001EFAD0
		public Span<byte> GetSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x001F18E0 File Offset: 0x001EFAE0
		public byte[] GetSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06005367 RID: 21351 RVA: 0x001F18F8 File Offset: 0x001EFAF8
		public string SpineSkeleton
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

		// Token: 0x06005368 RID: 21352 RVA: 0x001F1930 File Offset: 0x001EFB30
		public Span<byte> GetSpineSkeletonBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x001F1940 File Offset: 0x001EFB40
		public byte[] GetSpineSkeletonArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x001F1958 File Offset: 0x001EFB58
		public string SpineAnimStandby(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x001F1994 File Offset: 0x001EFB94
		public int SpineAnimStandbyLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x001F19C0 File Offset: 0x001EFBC0
		public string SpineAnimTouch(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600536D RID: 21357 RVA: 0x001F19FC File Offset: 0x001EFBFC
		public int SpineAnimTouchLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x001F1A28 File Offset: 0x001EFC28
		public string SpineAnimIdle
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x001F1A60 File Offset: 0x001EFC60
		public Span<byte> GetSpineAnimIdleBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x001F1A70 File Offset: 0x001EFC70
		public byte[] GetSpineAnimIdleArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x001F1A88 File Offset: 0x001EFC88
		public float SpineProbability
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x001F1ACC File Offset: 0x001EFCCC
		public string Spinepre
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x001F1B04 File Offset: 0x001EFD04
		public Span<byte> GetSpinepreBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x001F1B14 File Offset: 0x001EFD14
		public byte[] GetSpinepreArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06005375 RID: 21365 RVA: 0x001F1B2C File Offset: 0x001EFD2C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x001F1B64 File Offset: 0x001EFD64
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x001F1B74 File Offset: 0x001EFD74
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x001F1B8C File Offset: 0x001EFD8C
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x001F1BC4 File Offset: 0x001EFDC4
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x001F1BD4 File Offset: 0x001EFDD4
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x001F1BEC File Offset: 0x001EFDEC
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x001F1C24 File Offset: 0x001EFE24
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x001F1C34 File Offset: 0x001EFE34
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x001F1C4C File Offset: 0x001EFE4C
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x001F1C84 File Offset: 0x001EFE84
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x001F1C94 File Offset: 0x001EFE94
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06005381 RID: 21377 RVA: 0x001F1CAC File Offset: 0x001EFEAC
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x001F1CE4 File Offset: 0x001EFEE4
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x001F1CF4 File Offset: 0x001EFEF4
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06005384 RID: 21380 RVA: 0x001F1D0C File Offset: 0x001EFF0C
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x001F1D44 File Offset: 0x001EFF44
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x001F1D54 File Offset: 0x001EFF54
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x001F1D6C File Offset: 0x001EFF6C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			ChatCharm chatCharm = this;
			return chatCharm.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x001F1D90 File Offset: 0x001EFF90
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			ChatCharm.<ItemAccessIter>d__84 <ItemAccessIter>d__ = new ChatCharm.<ItemAccessIter>d__84(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x001F1DA5 File Offset: 0x001EFFA5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineAnimStandbyIter()或GetSpineAnimStandbyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineAnimStandby()
		{
			return this.SpineAnimStandbyIter().ToArray<string>();
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x001F1DB2 File Offset: 0x001EFFB2
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineAnimStandbyIter()
		{
			ChatCharm.<SpineAnimStandbyIter>d__86 <SpineAnimStandbyIter>d__ = new ChatCharm.<SpineAnimStandbyIter>d__86(-2);
			<SpineAnimStandbyIter>d__.<>3__<>4__this = this;
			return <SpineAnimStandbyIter>d__;
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x001F1DC7 File Offset: 0x001EFFC7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineAnimTouchIter()或GetSpineAnimTouchBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineAnimTouch()
		{
			return this.SpineAnimTouchIter().ToArray<string>();
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x001F1DD4 File Offset: 0x001EFFD4
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineAnimTouchIter()
		{
			ChatCharm.<SpineAnimTouchIter>d__88 <SpineAnimTouchIter>d__ = new ChatCharm.<SpineAnimTouchIter>d__88(-2);
			<SpineAnimTouchIter>d__.<>3__<>4__this = this;
			return <SpineAnimTouchIter>d__;
		}

		// Token: 0x04004B6B RID: 19307
		private Table __p;
	}
}
