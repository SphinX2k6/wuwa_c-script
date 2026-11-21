using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8B RID: 2955
	public struct AbyssRoleSlot : IFlatbufferObject
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060046E4 RID: 18148 RVA: 0x001E7D6C File Offset: 0x001E5F6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x001E7D79 File Offset: 0x001E5F79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x001E7D80 File Offset: 0x001E5F80
		public static AbyssRoleSlot GetRootAsAbyssRoleSlot(ByteBuffer _bb)
		{
			return AbyssRoleSlot.GetRootAsAbyssRoleSlot(_bb, default(AbyssRoleSlot));
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x001E7D9C File Offset: 0x001E5F9C
		public static AbyssRoleSlot GetRootAsAbyssRoleSlot(ByteBuffer _bb, AbyssRoleSlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x001E7DB9 File Offset: 0x001E5FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x001E7DC8 File Offset: 0x001E5FC8
		public AbyssRoleSlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x001E7DD8 File Offset: 0x001E5FD8
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
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x001E7E14 File Offset: 0x001E6014
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
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x001E7E50 File Offset: 0x001E6050
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

		// Token: 0x04005060 RID: 20576
		private Table __p;
	}
}
