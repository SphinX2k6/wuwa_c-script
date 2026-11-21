using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB6 RID: 3766
	public struct LinkPreload : IFlatbufferObject
	{
		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x060094F3 RID: 38131 RVA: 0x00297B7E File Offset: 0x00295D7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x00297B8B File Offset: 0x00295D8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x00297B94 File Offset: 0x00295D94
		public static LinkPreload GetRootAsLinkPreload(ByteBuffer _bb)
		{
			return LinkPreload.GetRootAsLinkPreload(_bb, default(LinkPreload));
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x00297BB0 File Offset: 0x00295DB0
		public static LinkPreload GetRootAsLinkPreload(ByteBuffer _bb, LinkPreload obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060094F7 RID: 38135 RVA: 0x00297BCD File Offset: 0x00295DCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x00297BDC File Offset: 0x00295DDC
		public LinkPreload __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x060094F9 RID: 38137 RVA: 0x00297BEC File Offset: 0x00295DEC
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

		// Token: 0x060094FA RID: 38138 RVA: 0x00297C28 File Offset: 0x00295E28
		public int RoleIdList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x060094FB RID: 38139 RVA: 0x00297C68 File Offset: 0x00295E68
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

		// Token: 0x060094FC RID: 38140 RVA: 0x00297C93 File Offset: 0x00295E93
		public Span<int> GetRoleIdListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x00297CA2 File Offset: 0x00295EA2
		public int[] GetRoleIdListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x00297CB9 File Offset: 0x00295EB9
		[NullableContext(1)]
		public int[] RoleIdList()
		{
			return this.GetRoleIdListArray();
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x00297CC1 File Offset: 0x00295EC1
		[NullableContext(1)]
		public IEnumerable<int> RoleIdListIter()
		{
			LinkPreload.<RoleIdListIter>d__16 <RoleIdListIter>d__ = new LinkPreload.<RoleIdListIter>d__16(-2);
			<RoleIdListIter>d__.<>3__<>4__this = this;
			return <RoleIdListIter>d__;
		}

		// Token: 0x04005450 RID: 21584
		private Table __p;
	}
}
