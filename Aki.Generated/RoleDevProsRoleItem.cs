using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001047 RID: 4167
	public struct RoleDevProsRoleItem : IFlatbufferObject
	{
		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600C847 RID: 51271 RVA: 0x002F9CBB File Offset: 0x002F7EBB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C848 RID: 51272 RVA: 0x002F9CC8 File Offset: 0x002F7EC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x002F9CD0 File Offset: 0x002F7ED0
		public static RoleDevProsRoleItem GetRootAsRoleDevProsRoleItem(ByteBuffer _bb)
		{
			return RoleDevProsRoleItem.GetRootAsRoleDevProsRoleItem(_bb, default(RoleDevProsRoleItem));
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x002F9CEC File Offset: 0x002F7EEC
		public static RoleDevProsRoleItem GetRootAsRoleDevProsRoleItem(ByteBuffer _bb, RoleDevProsRoleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C84B RID: 51275 RVA: 0x002F9D09 File Offset: 0x002F7F09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C84C RID: 51276 RVA: 0x002F9D18 File Offset: 0x002F7F18
		public RoleDevProsRoleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600C84D RID: 51277 RVA: 0x002F9D28 File Offset: 0x002F7F28
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

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600C84E RID: 51278 RVA: 0x002F9D64 File Offset: 0x002F7F64
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

		// Token: 0x0600C84F RID: 51279 RVA: 0x002F9DA0 File Offset: 0x002F7FA0
		public IntPair? ItemGroup(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600C850 RID: 51280 RVA: 0x002F9E00 File Offset: 0x002F8000
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

		// Token: 0x0600C851 RID: 51281 RVA: 0x002F9E2B File Offset: 0x002F802B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemGroupIter()或GetItemGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] ItemGroup()
		{
			return this.ItemGroupIter().ToArray<IntPair>();
		}

		// Token: 0x0600C852 RID: 51282 RVA: 0x002F9E38 File Offset: 0x002F8038
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> ItemGroupIter()
		{
			RoleDevProsRoleItem.<ItemGroupIter>d__16 <ItemGroupIter>d__ = new RoleDevProsRoleItem.<ItemGroupIter>d__16(-2);
			<ItemGroupIter>d__.<>3__<>4__this = this;
			return <ItemGroupIter>d__;
		}

		// Token: 0x04005145 RID: 20805
		private Table __p;
	}
}
