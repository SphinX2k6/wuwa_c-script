using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD1 RID: 3537
	public struct LinkPreload : IFlatbufferObject
	{
		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06008ED7 RID: 36567 RVA: 0x00279786 File Offset: 0x00277986
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x00279793 File Offset: 0x00277993
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0027979C File Offset: 0x0027799C
		public static LinkPreload GetRootAsLinkPreload(ByteBuffer _bb)
		{
			return LinkPreload.GetRootAsLinkPreload(_bb, default(LinkPreload));
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x002797B8 File Offset: 0x002779B8
		public static LinkPreload GetRootAsLinkPreload(ByteBuffer _bb, LinkPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x002797D5 File Offset: 0x002779D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x002797E4 File Offset: 0x002779E4
		public LinkPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06008EDD RID: 36573 RVA: 0x002797F4 File Offset: 0x002779F4
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

		// Token: 0x06008EDE RID: 36574 RVA: 0x00279830 File Offset: 0x00277A30
		public int RoleIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06008EDF RID: 36575 RVA: 0x00279870 File Offset: 0x00277A70
		public int RoleIdListLength
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

		// Token: 0x06008EE0 RID: 36576 RVA: 0x0027989B File Offset: 0x00277A9B
		public Span<int> GetRoleIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x002798AA File Offset: 0x00277AAA
		public int[] GetRoleIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x002798C4 File Offset: 0x00277AC4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleIdListIter()或GetRoleIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleIdList()
		{
			LinkPreload linkPreload = this;
			return linkPreload.GetRoleIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x002798E8 File Offset: 0x00277AE8
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleIdListIter()
		{
			LinkPreload.<RoleIdListIter>d__16 <RoleIdListIter>d__ = new LinkPreload.<RoleIdListIter>d__16(-2);
			<RoleIdListIter>d__.<>3__<>4__this = this;
			return <RoleIdListIter>d__;
		}

		// Token: 0x04004E6B RID: 20075
		private Table __p;
	}
}
