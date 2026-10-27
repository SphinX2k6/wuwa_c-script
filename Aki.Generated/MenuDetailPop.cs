using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E08 RID: 3592
	public struct MenuDetailPop : IFlatbufferObject
	{
		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x060093FA RID: 37882 RVA: 0x0028540A File Offset: 0x0028360A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x00285417 File Offset: 0x00283617
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x00285420 File Offset: 0x00283620
		public static MenuDetailPop GetRootAsMenuDetailPop(ByteBuffer _bb)
		{
			return MenuDetailPop.GetRootAsMenuDetailPop(_bb, default(MenuDetailPop));
		}

		// Token: 0x060093FD RID: 37885 RVA: 0x0028543C File Offset: 0x0028363C
		public static MenuDetailPop GetRootAsMenuDetailPop(ByteBuffer _bb, MenuDetailPop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x00285459 File Offset: 0x00283659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x00285468 File Offset: 0x00283668
		public MenuDetailPop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06009400 RID: 37888 RVA: 0x00285478 File Offset: 0x00283678
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

		// Token: 0x06009401 RID: 37889 RVA: 0x002854B4 File Offset: 0x002836B4
		public int ItemList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06009402 RID: 37890 RVA: 0x002854F4 File Offset: 0x002836F4
		public int ItemListLength
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

		// Token: 0x06009403 RID: 37891 RVA: 0x0028551F File Offset: 0x0028371F
		public Span<int> GetItemListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x0028552E File Offset: 0x0028372E
		public int[] GetItemListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06009405 RID: 37893 RVA: 0x00285548 File Offset: 0x00283748
		public string Title
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

		// Token: 0x06009406 RID: 37894 RVA: 0x0028557F File Offset: 0x0028377F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x0028558E File Offset: 0x0028378E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06009408 RID: 37896 RVA: 0x002855A8 File Offset: 0x002837A8
		public string Description
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

		// Token: 0x06009409 RID: 37897 RVA: 0x002855E0 File Offset: 0x002837E0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x002855F0 File Offset: 0x002837F0
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00285608 File Offset: 0x00283808
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemListIter()或GetItemListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemList()
		{
			MenuDetailPop menuDetailPop = this;
			return menuDetailPop.GetItemListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x0028562C File Offset: 0x0028382C
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemListIter()
		{
			MenuDetailPop.<ItemListIter>d__24 <ItemListIter>d__ = new MenuDetailPop.<ItemListIter>d__24(-2);
			<ItemListIter>d__.<>3__<>4__this = this;
			return <ItemListIter>d__;
		}

		// Token: 0x04004EAD RID: 20141
		private Table __p;
	}
}
