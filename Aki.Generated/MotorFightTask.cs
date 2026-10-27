using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E50 RID: 3664
	public struct MotorFightTask : IFlatbufferObject
	{
		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06009985 RID: 39301 RVA: 0x002917F1 File Offset: 0x0028F9F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009986 RID: 39302 RVA: 0x002917FE File Offset: 0x0028F9FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009987 RID: 39303 RVA: 0x00291808 File Offset: 0x0028FA08
		public static MotorFightTask GetRootAsMotorFightTask(ByteBuffer _bb)
		{
			return MotorFightTask.GetRootAsMotorFightTask(_bb, default(MotorFightTask));
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x00291824 File Offset: 0x0028FA24
		public static MotorFightTask GetRootAsMotorFightTask(ByteBuffer _bb, MotorFightTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x00291841 File Offset: 0x0028FA41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600998A RID: 39306 RVA: 0x00291850 File Offset: 0x0028FA50
		public MotorFightTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600998B RID: 39307 RVA: 0x00291860 File Offset: 0x0028FA60
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

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600998C RID: 39308 RVA: 0x0029189C File Offset: 0x0028FA9C
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

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x0600998D RID: 39309 RVA: 0x002918D8 File Offset: 0x0028FAD8
		public int SortId
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

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x0600998E RID: 39310 RVA: 0x00291914 File Offset: 0x0028FB14
		public int PageType
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

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x0600998F RID: 39311 RVA: 0x00291954 File Offset: 0x0028FB54
		public string TaskName
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

		// Token: 0x06009990 RID: 39312 RVA: 0x0029198C File Offset: 0x0028FB8C
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009991 RID: 39313 RVA: 0x0029199C File Offset: 0x0028FB9C
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06009992 RID: 39314 RVA: 0x002919B4 File Offset: 0x0028FBB4
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x002919F4 File Offset: 0x0028FBF4
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004EF9 RID: 20217
		private Table __p;
	}
}
