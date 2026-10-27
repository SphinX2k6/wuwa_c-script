using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E09 RID: 3593
	public struct MenuDetailPopItem : IFlatbufferObject
	{
		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600940D RID: 37901 RVA: 0x00285641 File Offset: 0x00283841
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x0028564E File Offset: 0x0028384E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x00285658 File Offset: 0x00283858
		public static MenuDetailPopItem GetRootAsMenuDetailPopItem(ByteBuffer _bb)
		{
			return MenuDetailPopItem.GetRootAsMenuDetailPopItem(_bb, default(MenuDetailPopItem));
		}

		// Token: 0x06009410 RID: 37904 RVA: 0x00285674 File Offset: 0x00283874
		public static MenuDetailPopItem GetRootAsMenuDetailPopItem(ByteBuffer _bb, MenuDetailPopItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x00285691 File Offset: 0x00283891
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x002856A0 File Offset: 0x002838A0
		public MenuDetailPopItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x002856B0 File Offset: 0x002838B0
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

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06009414 RID: 37908 RVA: 0x002856EC File Offset: 0x002838EC
		public int ShowType
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

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x00285728 File Offset: 0x00283928
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

		// Token: 0x06009416 RID: 37910 RVA: 0x0028575F File Offset: 0x0028395F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x0028576E File Offset: 0x0028396E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x00285788 File Offset: 0x00283988
		public string WideVideoTitleList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06009419 RID: 37913 RVA: 0x002857C4 File Offset: 0x002839C4
		public int WideVideoTitleListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x0600941A RID: 37914 RVA: 0x002857F0 File Offset: 0x002839F0
		public string ResourcePath
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

		// Token: 0x0600941B RID: 37915 RVA: 0x00285828 File Offset: 0x00283A28
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x00285838 File Offset: 0x00283A38
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00285850 File Offset: 0x00283A50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WideVideoTitleListIter()或GetWideVideoTitleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] WideVideoTitleList()
		{
			return this.WideVideoTitleListIter().ToArray<string>();
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x0028585D File Offset: 0x00283A5D
		[NullableContext(1)]
		public readonly IEnumerable<string> WideVideoTitleListIter()
		{
			MenuDetailPopItem.<WideVideoTitleListIter>d__24 <WideVideoTitleListIter>d__ = new MenuDetailPopItem.<WideVideoTitleListIter>d__24(-2);
			<WideVideoTitleListIter>d__.<>3__<>4__this = this;
			return <WideVideoTitleListIter>d__;
		}

		// Token: 0x04004EAE RID: 20142
		private Table __p;
	}
}
