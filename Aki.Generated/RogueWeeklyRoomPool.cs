using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102F RID: 4143
	public struct RogueWeeklyRoomPool : IFlatbufferObject
	{
		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600C66A RID: 50794 RVA: 0x002F58C1 File Offset: 0x002F3AC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x002F58CE File Offset: 0x002F3ACE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x002F58D8 File Offset: 0x002F3AD8
		public static RogueWeeklyRoomPool GetRootAsRogueWeeklyRoomPool(ByteBuffer _bb)
		{
			return RogueWeeklyRoomPool.GetRootAsRogueWeeklyRoomPool(_bb, default(RogueWeeklyRoomPool));
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x002F58F4 File Offset: 0x002F3AF4
		public static RogueWeeklyRoomPool GetRootAsRogueWeeklyRoomPool(ByteBuffer _bb, RogueWeeklyRoomPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x002F5911 File Offset: 0x002F3B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x002F5920 File Offset: 0x002F3B20
		public RogueWeeklyRoomPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600C670 RID: 50800 RVA: 0x002F5930 File Offset: 0x002F3B30
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

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600C671 RID: 50801 RVA: 0x002F596C File Offset: 0x002F3B6C
		public int BehaviorTree
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

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600C672 RID: 50802 RVA: 0x002F59A8 File Offset: 0x002F3BA8
		public string RoomsMusicState
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

		// Token: 0x0600C673 RID: 50803 RVA: 0x002F59DF File Offset: 0x002F3BDF
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C674 RID: 50804 RVA: 0x002F59EE File Offset: 0x002F3BEE
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005127 RID: 20775
		private Table __p;
	}
}
