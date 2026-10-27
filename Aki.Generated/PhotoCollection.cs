using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F05 RID: 3845
	public struct PhotoCollection : IFlatbufferObject
	{
		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x002B90CE File Offset: 0x002B72CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x002B90DB File Offset: 0x002B72DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x002B90E4 File Offset: 0x002B72E4
		public static PhotoCollection GetRootAsPhotoCollection(ByteBuffer _bb)
		{
			return PhotoCollection.GetRootAsPhotoCollection(_bb, default(PhotoCollection));
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x002B9100 File Offset: 0x002B7300
		public static PhotoCollection GetRootAsPhotoCollection(ByteBuffer _bb, PhotoCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x002B911D File Offset: 0x002B731D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AB38 RID: 43832 RVA: 0x002B912C File Offset: 0x002B732C
		public PhotoCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x0600AB39 RID: 43833 RVA: 0x002B913C File Offset: 0x002B733C
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

		// Token: 0x0600AB3A RID: 43834 RVA: 0x002B9178 File Offset: 0x002B7378
		public int WhiteList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x002B91B8 File Offset: 0x002B73B8
		public int WhiteListLength
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

		// Token: 0x0600AB3C RID: 43836 RVA: 0x002B91E3 File Offset: 0x002B73E3
		public Span<int> GetWhiteListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x002B91F2 File Offset: 0x002B73F2
		public int[] GetWhiteListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x002B920C File Offset: 0x002B740C
		public int BlackList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600AB3F RID: 43839 RVA: 0x002B924C File Offset: 0x002B744C
		public int BlackListLength
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

		// Token: 0x0600AB40 RID: 43840 RVA: 0x002B9277 File Offset: 0x002B7477
		public Span<int> GetBlackListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x002B9286 File Offset: 0x002B7486
		public int[] GetBlackListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x002B92A0 File Offset: 0x002B74A0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BlackListIter()或GetBlackListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BlackList()
		{
			PhotoCollection photoCollection = this;
			return photoCollection.GetBlackListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x002B92C4 File Offset: 0x002B74C4
		[NullableContext(1)]
		public readonly IEnumerable<int> BlackListIter()
		{
			PhotoCollection.<BlackListIter>d__21 <BlackListIter>d__ = new PhotoCollection.<BlackListIter>d__21(-2);
			<BlackListIter>d__.<>3__<>4__this = this;
			return <BlackListIter>d__;
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x002B92DC File Offset: 0x002B74DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WhiteListIter()或GetWhiteListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WhiteList()
		{
			PhotoCollection photoCollection = this;
			return photoCollection.GetWhiteListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x002B9300 File Offset: 0x002B7500
		[NullableContext(1)]
		public readonly IEnumerable<int> WhiteListIter()
		{
			PhotoCollection.<WhiteListIter>d__23 <WhiteListIter>d__ = new PhotoCollection.<WhiteListIter>d__23(-2);
			<WhiteListIter>d__.<>3__<>4__this = this;
			return <WhiteListIter>d__;
		}

		// Token: 0x04004FCD RID: 20429
		private Table __p;
	}
}
