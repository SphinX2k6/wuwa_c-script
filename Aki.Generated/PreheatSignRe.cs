using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F56 RID: 3926
	public struct PreheatSignRe : IFlatbufferObject
	{
		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x0600B2ED RID: 45805 RVA: 0x002CA6C8 File Offset: 0x002C88C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2EE RID: 45806 RVA: 0x002CA6D5 File Offset: 0x002C88D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x002CA6DC File Offset: 0x002C88DC
		public static PreheatSignRe GetRootAsPreheatSignRe(ByteBuffer _bb)
		{
			return PreheatSignRe.GetRootAsPreheatSignRe(_bb, default(PreheatSignRe));
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x002CA6F8 File Offset: 0x002C88F8
		public static PreheatSignRe GetRootAsPreheatSignRe(ByteBuffer _bb, PreheatSignRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x002CA715 File Offset: 0x002C8915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x002CA724 File Offset: 0x002C8924
		public PreheatSignRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x0600B2F3 RID: 45811 RVA: 0x002CA734 File Offset: 0x002C8934
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

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0600B2F4 RID: 45812 RVA: 0x002CA770 File Offset: 0x002C8970
		public int ActivityId
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

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0600B2F5 RID: 45813 RVA: 0x002CA7AC File Offset: 0x002C89AC
		public int DropId
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

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0600B2F6 RID: 45814 RVA: 0x002CA7E8 File Offset: 0x002C89E8
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0600B2F7 RID: 45815 RVA: 0x002CA828 File Offset: 0x002C8A28
		public int PreSignId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005023 RID: 20515
		private Table __p;
	}
}
