using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001105 RID: 4357
	public struct RogueRoomShowConfig : IFlatbufferObject
	{
		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600CAEE RID: 51950 RVA: 0x0030D489 File Offset: 0x0030B689
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x0030D496 File Offset: 0x0030B696
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x0030D4A0 File Offset: 0x0030B6A0
		public static RogueRoomShowConfig GetRootAsRogueRoomShowConfig(ByteBuffer _bb)
		{
			return RogueRoomShowConfig.GetRootAsRogueRoomShowConfig(_bb, default(RogueRoomShowConfig));
		}

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x0030D4BC File Offset: 0x0030B6BC
		public static RogueRoomShowConfig GetRootAsRogueRoomShowConfig(ByteBuffer _bb, RogueRoomShowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CAF2 RID: 51954 RVA: 0x0030D4D9 File Offset: 0x0030B6D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CAF3 RID: 51955 RVA: 0x0030D4E8 File Offset: 0x0030B6E8
		public RogueRoomShowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600CAF4 RID: 51956 RVA: 0x0030D4F8 File Offset: 0x0030B6F8
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

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600CAF5 RID: 51957 RVA: 0x0030D534 File Offset: 0x0030B734
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

		// Token: 0x0600CAF6 RID: 51958 RVA: 0x0030D56B File Offset: 0x0030B76B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x0030D57A File Offset: 0x0030B77A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600CAF8 RID: 51960 RVA: 0x0030D594 File Offset: 0x0030B794
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

		// Token: 0x0600CAF9 RID: 51961 RVA: 0x0030D5CB File Offset: 0x0030B7CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CAFA RID: 51962 RVA: 0x0030D5DA File Offset: 0x0030B7DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600CAFB RID: 51963 RVA: 0x0030D5F4 File Offset: 0x0030B7F4
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

		// Token: 0x0600CAFC RID: 51964 RVA: 0x0030D62C File Offset: 0x0030B82C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CAFD RID: 51965 RVA: 0x0030D63C File Offset: 0x0030B83C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600CAFE RID: 51966 RVA: 0x0030D654 File Offset: 0x0030B854
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

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600CAFF RID: 51967 RVA: 0x0030D694 File Offset: 0x0030B894
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

		// Token: 0x040056F5 RID: 22261
		private Table __p;
	}
}
