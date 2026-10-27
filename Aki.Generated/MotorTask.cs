using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6C RID: 3692
	public struct MotorTask : IFlatbufferObject
	{
		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x06009C79 RID: 40057 RVA: 0x00298110 File Offset: 0x00296310
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x0029811D File Offset: 0x0029631D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x00298124 File Offset: 0x00296324
		public static MotorTask GetRootAsMotorTask(ByteBuffer _bb)
		{
			return MotorTask.GetRootAsMotorTask(_bb, default(MotorTask));
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x00298140 File Offset: 0x00296340
		public static MotorTask GetRootAsMotorTask(ByteBuffer _bb, MotorTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x0029815D File Offset: 0x0029635D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x0029816C File Offset: 0x0029636C
		public MotorTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x06009C7F RID: 40063 RVA: 0x0029817C File Offset: 0x0029637C
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

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06009C80 RID: 40064 RVA: 0x002981B8 File Offset: 0x002963B8
		public int TreeType
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

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x06009C81 RID: 40065 RVA: 0x002981F4 File Offset: 0x002963F4
		public int SortOrder
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

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x06009C82 RID: 40066 RVA: 0x00298230 File Offset: 0x00296430
		public string Title
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C83 RID: 40067 RVA: 0x00298268 File Offset: 0x00296468
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x00298278 File Offset: 0x00296478
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x06009C85 RID: 40069 RVA: 0x00298290 File Offset: 0x00296490
		public int JumpId
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

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x06009C86 RID: 40070 RVA: 0x002982D0 File Offset: 0x002964D0
		public int RewardTpCount
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

		// Token: 0x04004F1A RID: 20250
		private Table __p;
	}
}
