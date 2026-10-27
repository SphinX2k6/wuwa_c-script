using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D38 RID: 3384
	public struct HonamiStoryItemCollection : IFlatbufferObject
	{
		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x06007FBA RID: 32698 RVA: 0x00257095 File Offset: 0x00255295
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x002570A2 File Offset: 0x002552A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x002570AC File Offset: 0x002552AC
		public static HonamiStoryItemCollection GetRootAsHonamiStoryItemCollection(ByteBuffer _bb)
		{
			return HonamiStoryItemCollection.GetRootAsHonamiStoryItemCollection(_bb, default(HonamiStoryItemCollection));
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x002570C8 File Offset: 0x002552C8
		public static HonamiStoryItemCollection GetRootAsHonamiStoryItemCollection(ByteBuffer _bb, HonamiStoryItemCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x002570E5 File Offset: 0x002552E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x002570F4 File Offset: 0x002552F4
		public HonamiStoryItemCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06007FC0 RID: 32704 RVA: 0x00257104 File Offset: 0x00255304
		public int ItemId
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

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06007FC1 RID: 32705 RVA: 0x00257140 File Offset: 0x00255340
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

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06007FC2 RID: 32706 RVA: 0x0025717C File Offset: 0x0025537C
		public int DropId
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

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06007FC3 RID: 32707 RVA: 0x002571B8 File Offset: 0x002553B8
		public string DropNum
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

		// Token: 0x06007FC4 RID: 32708 RVA: 0x002571F0 File Offset: 0x002553F0
		public Span<byte> GetDropNumBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x00257200 File Offset: 0x00255400
		public byte[] GetDropNumArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x00257218 File Offset: 0x00255418
		public string Name
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

		// Token: 0x06007FC7 RID: 32711 RVA: 0x00257250 File Offset: 0x00255450
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x00257260 File Offset: 0x00255460
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x00257278 File Offset: 0x00255478
		public string Desc
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

		// Token: 0x06007FCA RID: 32714 RVA: 0x002572B0 File Offset: 0x002554B0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x002572C0 File Offset: 0x002554C0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06007FCC RID: 32716 RVA: 0x002572D8 File Offset: 0x002554D8
		public string Access
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

		// Token: 0x06007FCD RID: 32717 RVA: 0x00257310 File Offset: 0x00255510
		public Span<byte> GetAccessBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007FCE RID: 32718 RVA: 0x00257320 File Offset: 0x00255520
		public byte[] GetAccessArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06007FCF RID: 32719 RVA: 0x00257338 File Offset: 0x00255538
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x00257370 File Offset: 0x00255570
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x00257380 File Offset: 0x00255580
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DB2 RID: 19890
		private Table __p;
	}
}
