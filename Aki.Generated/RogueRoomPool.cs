using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101C RID: 4124
	public struct RogueRoomPool : IFlatbufferObject
	{
		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0600C499 RID: 50329 RVA: 0x002F1340 File Offset: 0x002EF540
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C49A RID: 50330 RVA: 0x002F134D File Offset: 0x002EF54D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C49B RID: 50331 RVA: 0x002F1354 File Offset: 0x002EF554
		public static RogueRoomPool GetRootAsRogueRoomPool(ByteBuffer _bb)
		{
			return RogueRoomPool.GetRootAsRogueRoomPool(_bb, default(RogueRoomPool));
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x002F1370 File Offset: 0x002EF570
		public static RogueRoomPool GetRootAsRogueRoomPool(ByteBuffer _bb, RogueRoomPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x002F138D File Offset: 0x002EF58D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x002F139C File Offset: 0x002EF59C
		public RogueRoomPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0600C49F RID: 50335 RVA: 0x002F13AC File Offset: 0x002EF5AC
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

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0600C4A0 RID: 50336 RVA: 0x002F13E8 File Offset: 0x002EF5E8
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

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0600C4A1 RID: 50337 RVA: 0x002F1424 File Offset: 0x002EF624
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

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x002F145B File Offset: 0x002EF65B
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x002F146A File Offset: 0x002EF66A
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400510C RID: 20748
		private Table __p;
	}
}
