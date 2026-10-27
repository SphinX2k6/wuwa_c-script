using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101D RID: 4125
	public struct RogueRoomShowConfig : IFlatbufferObject
	{
		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0600C4A4 RID: 50340 RVA: 0x002F1481 File Offset: 0x002EF681
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x002F148E File Offset: 0x002EF68E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x002F1498 File Offset: 0x002EF698
		public static RogueRoomShowConfig GetRootAsRogueRoomShowConfig(ByteBuffer _bb)
		{
			return RogueRoomShowConfig.GetRootAsRogueRoomShowConfig(_bb, default(RogueRoomShowConfig));
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x002F14B4 File Offset: 0x002EF6B4
		public static RogueRoomShowConfig GetRootAsRogueRoomShowConfig(ByteBuffer _bb, RogueRoomShowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4A8 RID: 50344 RVA: 0x002F14D1 File Offset: 0x002EF6D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4A9 RID: 50345 RVA: 0x002F14E0 File Offset: 0x002EF6E0
		public RogueRoomShowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x0600C4AA RID: 50346 RVA: 0x002F14F0 File Offset: 0x002EF6F0
		public int BehaviorTree
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

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0600C4AB RID: 50347 RVA: 0x002F152C File Offset: 0x002EF72C
		public string Icon
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

		// Token: 0x0600C4AC RID: 50348 RVA: 0x002F1563 File Offset: 0x002EF763
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x002F1572 File Offset: 0x002EF772
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x0600C4AE RID: 50350 RVA: 0x002F158C File Offset: 0x002EF78C
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

		// Token: 0x0600C4AF RID: 50351 RVA: 0x002F15C3 File Offset: 0x002EF7C3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x002F15D2 File Offset: 0x002EF7D2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x0600C4B1 RID: 50353 RVA: 0x002F15EC File Offset: 0x002EF7EC
		public string Desc
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

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x002F1624 File Offset: 0x002EF824
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x002F1634 File Offset: 0x002EF834
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x0600C4B4 RID: 50356 RVA: 0x002F164C File Offset: 0x002EF84C
		public int BuffPoolId
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

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x0600C4B5 RID: 50357 RVA: 0x002F168C File Offset: 0x002EF88C
		public int BuffId
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

		// Token: 0x0400510D RID: 20749
		private Table __p;
	}
}
