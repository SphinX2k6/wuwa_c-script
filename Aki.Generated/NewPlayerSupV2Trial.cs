using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E89 RID: 3721
	public struct NewPlayerSupV2Trial : IFlatbufferObject
	{
		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x0029D3F4 File Offset: 0x0029B5F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x0029D401 File Offset: 0x0029B601
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x0029D408 File Offset: 0x0029B608
		public static NewPlayerSupV2Trial GetRootAsNewPlayerSupV2Trial(ByteBuffer _bb)
		{
			return NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(_bb, default(NewPlayerSupV2Trial));
		}

		// Token: 0x06009EEE RID: 40686 RVA: 0x0029D424 File Offset: 0x0029B624
		public static NewPlayerSupV2Trial GetRootAsNewPlayerSupV2Trial(ByteBuffer _bb, NewPlayerSupV2Trial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009EEF RID: 40687 RVA: 0x0029D441 File Offset: 0x0029B641
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x0029D450 File Offset: 0x0029B650
		public NewPlayerSupV2Trial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x0029D460 File Offset: 0x0029B660
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

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06009EF2 RID: 40690 RVA: 0x0029D49C File Offset: 0x0029B69C
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

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06009EF3 RID: 40691 RVA: 0x0029D4D8 File Offset: 0x0029B6D8
		public int TrialRoleGroupId
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

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x06009EF4 RID: 40692 RVA: 0x0029D514 File Offset: 0x0029B714
		public int ConditionGroup
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

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x06009EF5 RID: 40693 RVA: 0x0029D554 File Offset: 0x0029B754
		public string RolePathMale
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

		// Token: 0x06009EF6 RID: 40694 RVA: 0x0029D58C File Offset: 0x0029B78C
		public Span<byte> GetRolePathMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x0029D59C File Offset: 0x0029B79C
		public byte[] GetRolePathMaleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06009EF8 RID: 40696 RVA: 0x0029D5B4 File Offset: 0x0029B7B4
		public string RoleBgPathMale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x0029D5EC File Offset: 0x0029B7EC
		public Span<byte> GetRoleBgPathMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x0029D5FC File Offset: 0x0029B7FC
		public byte[] GetRoleBgPathMaleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F37 RID: 20279
		private Table __p;
	}
}
