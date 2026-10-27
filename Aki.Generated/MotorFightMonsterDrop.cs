using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E49 RID: 3657
	public struct MotorFightMonsterDrop : IFlatbufferObject
	{
		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x060098E7 RID: 39143 RVA: 0x0029008D File Offset: 0x0028E28D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x0029009A File Offset: 0x0028E29A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x002900A4 File Offset: 0x0028E2A4
		public static MotorFightMonsterDrop GetRootAsMotorFightMonsterDrop(ByteBuffer _bb)
		{
			return MotorFightMonsterDrop.GetRootAsMotorFightMonsterDrop(_bb, default(MotorFightMonsterDrop));
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x002900C0 File Offset: 0x0028E2C0
		public static MotorFightMonsterDrop GetRootAsMotorFightMonsterDrop(ByteBuffer _bb, MotorFightMonsterDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x002900DD File Offset: 0x0028E2DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x002900EC File Offset: 0x0028E2EC
		public MotorFightMonsterDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x060098ED RID: 39149 RVA: 0x002900FC File Offset: 0x0028E2FC
		public int DropId
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

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x060098EE RID: 39150 RVA: 0x00290138 File Offset: 0x0028E338
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

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x060098EF RID: 39151 RVA: 0x00290174 File Offset: 0x0028E374
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

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x060098F0 RID: 39152 RVA: 0x002901B0 File Offset: 0x0028E3B0
		public int BuffGateId
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

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x060098F1 RID: 39153 RVA: 0x002901F0 File Offset: 0x0028E3F0
		public int BuffId
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

		// Token: 0x04004EF1 RID: 20209
		private Table __p;
	}
}
