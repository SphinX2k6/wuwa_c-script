using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112F RID: 4399
	public struct RoleDevProsRoleItem : IFlatbufferObject
	{
		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600CE91 RID: 52881 RVA: 0x003159A1 File Offset: 0x00313BA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x003159AE File Offset: 0x00313BAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x003159B8 File Offset: 0x00313BB8
		public static RoleDevProsRoleItem GetRootAsRoleDevProsRoleItem(ByteBuffer _bb)
		{
			return RoleDevProsRoleItem.GetRootAsRoleDevProsRoleItem(_bb, default(RoleDevProsRoleItem));
		}

		// Token: 0x0600CE94 RID: 52884 RVA: 0x003159D4 File Offset: 0x00313BD4
		public static RoleDevProsRoleItem GetRootAsRoleDevProsRoleItem(ByteBuffer _bb, RoleDevProsRoleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x003159F1 File Offset: 0x00313BF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x00315A00 File Offset: 0x00313C00
		public RoleDevProsRoleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600CE97 RID: 52887 RVA: 0x00315A10 File Offset: 0x00313C10
		public int ItemGroupId
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

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600CE98 RID: 52888 RVA: 0x00315A4C File Offset: 0x00313C4C
		public int ItemTypeId
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

		// Token: 0x0600CE99 RID: 52889 RVA: 0x00315A88 File Offset: 0x00313C88
		public IntPair? ItemGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600CE9A RID: 52890 RVA: 0x00315AE8 File Offset: 0x00313CE8
		public int ItemGroupLength
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

		// Token: 0x0600CE9B RID: 52891 RVA: 0x00315B13 File Offset: 0x00313D13
		[NullableContext(1)]
		public IntPair[] ItemGroup()
		{
			return this.ItemGroupIter().ToArray<IntPair>();
		}

		// Token: 0x0600CE9C RID: 52892 RVA: 0x00315B20 File Offset: 0x00313D20
		[NullableContext(1)]
		public IEnumerable<IntPair> ItemGroupIter()
		{
			RoleDevProsRoleItem.<ItemGroupIter>d__16 <ItemGroupIter>d__ = new RoleDevProsRoleItem.<ItemGroupIter>d__16(-2);
			<ItemGroupIter>d__.<>3__<>4__this = this;
			return <ItemGroupIter>d__;
		}

		// Token: 0x0400572D RID: 22317
		private Table __p;
	}
}
