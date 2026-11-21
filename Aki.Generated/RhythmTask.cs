using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AF RID: 4271
	public struct RhythmTask : IFlatbufferObject
	{
		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0600C345 RID: 49989 RVA: 0x002FCAE0 File Offset: 0x002FACE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C346 RID: 49990 RVA: 0x002FCAED File Offset: 0x002FACED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C347 RID: 49991 RVA: 0x002FCAF4 File Offset: 0x002FACF4
		public static RhythmTask GetRootAsRhythmTask(ByteBuffer _bb)
		{
			return RhythmTask.GetRootAsRhythmTask(_bb, default(RhythmTask));
		}

		// Token: 0x0600C348 RID: 49992 RVA: 0x002FCB10 File Offset: 0x002FAD10
		public static RhythmTask GetRootAsRhythmTask(ByteBuffer _bb, RhythmTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C349 RID: 49993 RVA: 0x002FCB2D File Offset: 0x002FAD2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C34A RID: 49994 RVA: 0x002FCB3C File Offset: 0x002FAD3C
		public RhythmTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600C34B RID: 49995 RVA: 0x002FCB4C File Offset: 0x002FAD4C
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

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600C34C RID: 49996 RVA: 0x002FCB88 File Offset: 0x002FAD88
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

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600C34D RID: 49997 RVA: 0x002FCBC4 File Offset: 0x002FADC4
		public int TaskType
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

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x0600C34E RID: 49998 RVA: 0x002FCC00 File Offset: 0x002FAE00
		public int TaskTab
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

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x0600C34F RID: 49999 RVA: 0x002FCC40 File Offset: 0x002FAE40
		public int SortId
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

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x0600C350 RID: 50000 RVA: 0x002FCC80 File Offset: 0x002FAE80
		public string TaskName
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

		// Token: 0x0600C351 RID: 50001 RVA: 0x002FCCB8 File Offset: 0x002FAEB8
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C352 RID: 50002 RVA: 0x002FCCC8 File Offset: 0x002FAEC8
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x0600C353 RID: 50003 RVA: 0x002FCCE0 File Offset: 0x002FAEE0
		public int DropId
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

		// Token: 0x0400568A RID: 22154
		private Table __p;
	}
}
