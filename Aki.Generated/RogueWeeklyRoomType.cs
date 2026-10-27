using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001030 RID: 4144
	public struct RogueWeeklyRoomType : IFlatbufferObject
	{
		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600C675 RID: 50805 RVA: 0x002F5A05 File Offset: 0x002F3C05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C676 RID: 50806 RVA: 0x002F5A12 File Offset: 0x002F3C12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C677 RID: 50807 RVA: 0x002F5A1C File Offset: 0x002F3C1C
		public static RogueWeeklyRoomType GetRootAsRogueWeeklyRoomType(ByteBuffer _bb)
		{
			return RogueWeeklyRoomType.GetRootAsRogueWeeklyRoomType(_bb, default(RogueWeeklyRoomType));
		}

		// Token: 0x0600C678 RID: 50808 RVA: 0x002F5A38 File Offset: 0x002F3C38
		public static RogueWeeklyRoomType GetRootAsRogueWeeklyRoomType(ByteBuffer _bb, RogueWeeklyRoomType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C679 RID: 50809 RVA: 0x002F5A55 File Offset: 0x002F3C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C67A RID: 50810 RVA: 0x002F5A64 File Offset: 0x002F3C64
		public RogueWeeklyRoomType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600C67B RID: 50811 RVA: 0x002F5A74 File Offset: 0x002F3C74
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

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600C67C RID: 50812 RVA: 0x002F5AB0 File Offset: 0x002F3CB0
		public string RoomType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x002F5AE7 File Offset: 0x002F3CE7
		public Span<byte> GetRoomTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C67E RID: 50814 RVA: 0x002F5AF6 File Offset: 0x002F3CF6
		public byte[] GetRoomTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600C67F RID: 50815 RVA: 0x002F5B10 File Offset: 0x002F3D10
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

		// Token: 0x0600C680 RID: 50816 RVA: 0x002F5B47 File Offset: 0x002F3D47
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C681 RID: 50817 RVA: 0x002F5B56 File Offset: 0x002F3D56
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005128 RID: 20776
		private Table __p;
	}
}
