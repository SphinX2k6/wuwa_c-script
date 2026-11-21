using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECE RID: 3790
	public struct MapAudio : IFlatbufferObject
	{
		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x060096BB RID: 38587 RVA: 0x0029B86C File Offset: 0x00299A6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x0029B879 File Offset: 0x00299A79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x0029B880 File Offset: 0x00299A80
		public static MapAudio GetRootAsMapAudio(ByteBuffer _bb)
		{
			return MapAudio.GetRootAsMapAudio(_bb, default(MapAudio));
		}

		// Token: 0x060096BE RID: 38590 RVA: 0x0029B89C File Offset: 0x00299A9C
		public static MapAudio GetRootAsMapAudio(ByteBuffer _bb, MapAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x0029B8B9 File Offset: 0x00299AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x0029B8C8 File Offset: 0x00299AC8
		public MapAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x060096C1 RID: 38593 RVA: 0x0029B8D8 File Offset: 0x00299AD8
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

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x060096C2 RID: 38594 RVA: 0x0029B914 File Offset: 0x00299B14
		public string Name
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

		// Token: 0x060096C3 RID: 38595 RVA: 0x0029B94B File Offset: 0x00299B4B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x0029B95A File Offset: 0x00299B5A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x060096C5 RID: 38597 RVA: 0x0029B974 File Offset: 0x00299B74
		public string Event
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

		// Token: 0x060096C6 RID: 38598 RVA: 0x0029B9AB File Offset: 0x00299BAB
		public Span<byte> GetEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x0029B9BA File Offset: 0x00299BBA
		public byte[] GetEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x060096C8 RID: 38600 RVA: 0x0029B9D4 File Offset: 0x00299BD4
		public string EnterEvent
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

		// Token: 0x060096C9 RID: 38601 RVA: 0x0029BA0C File Offset: 0x00299C0C
		public Span<byte> GetEnterEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x0029BA1C File Offset: 0x00299C1C
		public byte[] GetEnterEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x060096CB RID: 38603 RVA: 0x0029BA34 File Offset: 0x00299C34
		public string ExitEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096CC RID: 38604 RVA: 0x0029BA6C File Offset: 0x00299C6C
		public Span<byte> GetExitEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060096CD RID: 38605 RVA: 0x0029BA7C File Offset: 0x00299C7C
		public byte[] GetExitEventArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x060096CE RID: 38606 RVA: 0x0029BA94 File Offset: 0x00299C94
		public string ResetEvent
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

		// Token: 0x060096CF RID: 38607 RVA: 0x0029BACC File Offset: 0x00299CCC
		public Span<byte> GetResetEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x0029BADC File Offset: 0x00299CDC
		public byte[] GetResetEventArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x060096D1 RID: 38609 RVA: 0x0029BAF4 File Offset: 0x00299CF4
		public string MusicResetEvent
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096D2 RID: 38610 RVA: 0x0029BB2C File Offset: 0x00299D2C
		public Span<byte> GetMusicResetEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x0029BB3C File Offset: 0x00299D3C
		public byte[] GetMusicResetEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400546A RID: 21610
		private Table __p;
	}
}
