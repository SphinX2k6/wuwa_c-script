using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4A RID: 3658
	public struct MotorFightMonsterRefresh : IFlatbufferObject
	{
		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x060098F2 RID: 39154 RVA: 0x0029022D File Offset: 0x0028E42D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x0029023A File Offset: 0x0028E43A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x00290244 File Offset: 0x0028E444
		public static MotorFightMonsterRefresh GetRootAsMotorFightMonsterRefresh(ByteBuffer _bb)
		{
			return MotorFightMonsterRefresh.GetRootAsMotorFightMonsterRefresh(_bb, default(MotorFightMonsterRefresh));
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x00290260 File Offset: 0x0028E460
		public static MotorFightMonsterRefresh GetRootAsMotorFightMonsterRefresh(ByteBuffer _bb, MotorFightMonsterRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x0029027D File Offset: 0x0028E47D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098F7 RID: 39159 RVA: 0x0029028C File Offset: 0x0028E48C
		public MotorFightMonsterRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x060098F8 RID: 39160 RVA: 0x0029029C File Offset: 0x0028E49C
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

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x060098F9 RID: 39161 RVA: 0x002902D8 File Offset: 0x0028E4D8
		public int GroupId
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

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x060098FA RID: 39162 RVA: 0x00290314 File Offset: 0x0028E514
		public int Weight
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

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x060098FB RID: 39163 RVA: 0x00290350 File Offset: 0x0028E550
		public int MonsterId
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

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x060098FC RID: 39164 RVA: 0x00290390 File Offset: 0x0028E590
		public int DropGroupId
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

		// Token: 0x04004EF2 RID: 20210
		private Table __p;
	}
}
