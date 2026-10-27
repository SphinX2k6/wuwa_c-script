using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD4 RID: 4052
	public struct RoadBookTask : IFlatbufferObject
	{
		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0600BDE6 RID: 48614 RVA: 0x002E2638 File Offset: 0x002E0838
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDE7 RID: 48615 RVA: 0x002E2645 File Offset: 0x002E0845
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDE8 RID: 48616 RVA: 0x002E264C File Offset: 0x002E084C
		public static RoadBookTask GetRootAsRoadBookTask(ByteBuffer _bb)
		{
			return RoadBookTask.GetRootAsRoadBookTask(_bb, default(RoadBookTask));
		}

		// Token: 0x0600BDE9 RID: 48617 RVA: 0x002E2668 File Offset: 0x002E0868
		public static RoadBookTask GetRootAsRoadBookTask(ByteBuffer _bb, RoadBookTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDEA RID: 48618 RVA: 0x002E2685 File Offset: 0x002E0885
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDEB RID: 48619 RVA: 0x002E2694 File Offset: 0x002E0894
		public RoadBookTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600BDEC RID: 48620 RVA: 0x002E26A4 File Offset: 0x002E08A4
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

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600BDED RID: 48621 RVA: 0x002E26E0 File Offset: 0x002E08E0
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

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600BDEE RID: 48622 RVA: 0x002E271C File Offset: 0x002E091C
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

		// Token: 0x0600BDEF RID: 48623 RVA: 0x002E2753 File Offset: 0x002E0953
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BDF0 RID: 48624 RVA: 0x002E2762 File Offset: 0x002E0962
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600BDF1 RID: 48625 RVA: 0x002E277C File Offset: 0x002E097C
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

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0600BDF2 RID: 48626 RVA: 0x002E27BC File Offset: 0x002E09BC
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

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x0600BDF3 RID: 48627 RVA: 0x002E27FC File Offset: 0x002E09FC
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

		// Token: 0x040050B0 RID: 20656
		private Table __p;
	}
}
