using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB6 RID: 2742
	public struct AbyssRoleSlot : IFlatbufferObject
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x001C8B0C File Offset: 0x001C6D0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x001C8B19 File Offset: 0x001C6D19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x001C8B20 File Offset: 0x001C6D20
		public static AbyssRoleSlot GetRootAsAbyssRoleSlot(ByteBuffer _bb)
		{
			return AbyssRoleSlot.GetRootAsAbyssRoleSlot(_bb, default(AbyssRoleSlot));
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x001C8B3C File Offset: 0x001C6D3C
		public static AbyssRoleSlot GetRootAsAbyssRoleSlot(ByteBuffer _bb, AbyssRoleSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x001C8B59 File Offset: 0x001C6D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x001C8B68 File Offset: 0x001C6D68
		public AbyssRoleSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x001C8B78 File Offset: 0x001C6D78
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x001C8BB4 File Offset: 0x001C6DB4
		public int SlotType
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x001C8BF0 File Offset: 0x001C6DF0
		public int Index
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004A8D RID: 19085
		private Table __p;
	}
}
