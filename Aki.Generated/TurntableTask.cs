using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117F RID: 4479
	public struct TurntableTask : IFlatbufferObject
	{
		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x0600E5CF RID: 58831 RVA: 0x0033DA65 File Offset: 0x0033BC65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x0033DA72 File Offset: 0x0033BC72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5D1 RID: 58833 RVA: 0x0033DA7C File Offset: 0x0033BC7C
		public static TurntableTask GetRootAsTurntableTask(ByteBuffer _bb)
		{
			return TurntableTask.GetRootAsTurntableTask(_bb, default(TurntableTask));
		}

		// Token: 0x0600E5D2 RID: 58834 RVA: 0x0033DA98 File Offset: 0x0033BC98
		public static TurntableTask GetRootAsTurntableTask(ByteBuffer _bb, TurntableTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5D3 RID: 58835 RVA: 0x0033DAB5 File Offset: 0x0033BCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5D4 RID: 58836 RVA: 0x0033DAC4 File Offset: 0x0033BCC4
		public TurntableTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600E5D5 RID: 58837 RVA: 0x0033DAD4 File Offset: 0x0033BCD4
		public int TaskId
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

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x0033DB10 File Offset: 0x0033BD10
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

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600E5D7 RID: 58839 RVA: 0x0033DB4C File Offset: 0x0033BD4C
		public string TaskDescription
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E5D8 RID: 58840 RVA: 0x0033DB83 File Offset: 0x0033BD83
		public Span<byte> GetTaskDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E5D9 RID: 58841 RVA: 0x0033DB92 File Offset: 0x0033BD92
		public byte[] GetTaskDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x0033DBAC File Offset: 0x0033BDAC
		public int TaskReward
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

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x0600E5DB RID: 58843 RVA: 0x0033DBEC File Offset: 0x0033BDEC
		public int TaskSort
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

		// Token: 0x040052C6 RID: 21190
		private Table __p;
	}
}
