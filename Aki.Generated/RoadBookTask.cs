using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BC RID: 4284
	public struct RoadBookTask : IFlatbufferObject
	{
		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x0600C430 RID: 50224 RVA: 0x002FEC04 File Offset: 0x002FCE04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x002FEC11 File Offset: 0x002FCE11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C432 RID: 50226 RVA: 0x002FEC18 File Offset: 0x002FCE18
		public static RoadBookTask GetRootAsRoadBookTask(ByteBuffer _bb)
		{
			return RoadBookTask.GetRootAsRoadBookTask(_bb, default(RoadBookTask));
		}

		// Token: 0x0600C433 RID: 50227 RVA: 0x002FEC34 File Offset: 0x002FCE34
		public static RoadBookTask GetRootAsRoadBookTask(ByteBuffer _bb, RoadBookTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C434 RID: 50228 RVA: 0x002FEC51 File Offset: 0x002FCE51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x002FEC60 File Offset: 0x002FCE60
		public RoadBookTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x0600C436 RID: 50230 RVA: 0x002FEC70 File Offset: 0x002FCE70
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

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x0600C437 RID: 50231 RVA: 0x002FECAC File Offset: 0x002FCEAC
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

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0600C438 RID: 50232 RVA: 0x002FECE8 File Offset: 0x002FCEE8
		public string Name
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

		// Token: 0x0600C439 RID: 50233 RVA: 0x002FED1F File Offset: 0x002FCF1F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x002FED2E File Offset: 0x002FCF2E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600C43B RID: 50235 RVA: 0x002FED48 File Offset: 0x002FCF48
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

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0600C43C RID: 50236 RVA: 0x002FED88 File Offset: 0x002FCF88
		public int AreaId
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

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0600C43D RID: 50237 RVA: 0x002FEDC8 File Offset: 0x002FCFC8
		public int JumpId
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

		// Token: 0x04005698 RID: 22168
		private Table __p;
	}
}
