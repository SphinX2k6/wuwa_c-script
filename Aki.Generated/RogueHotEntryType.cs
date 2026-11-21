using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CC RID: 4300
	public struct RogueHotEntryType : IFlatbufferObject
	{
		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x0600C5C8 RID: 50632 RVA: 0x00302198 File Offset: 0x00300398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x003021A5 File Offset: 0x003003A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x003021AC File Offset: 0x003003AC
		public static RogueHotEntryType GetRootAsRogueHotEntryType(ByteBuffer _bb)
		{
			return RogueHotEntryType.GetRootAsRogueHotEntryType(_bb, default(RogueHotEntryType));
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x003021C8 File Offset: 0x003003C8
		public static RogueHotEntryType GetRootAsRogueHotEntryType(ByteBuffer _bb, RogueHotEntryType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x003021E5 File Offset: 0x003003E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x003021F4 File Offset: 0x003003F4
		public RogueHotEntryType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0600C5CE RID: 50638 RVA: 0x00302204 File Offset: 0x00300404
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

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0600C5CF RID: 50639 RVA: 0x00302240 File Offset: 0x00300440
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

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x00302277 File Offset: 0x00300477
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x00302286 File Offset: 0x00300486
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0600C5D2 RID: 50642 RVA: 0x003022A0 File Offset: 0x003004A0
		public string Icon
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

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x003022D7 File Offset: 0x003004D7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x003022E6 File Offset: 0x003004E6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0600C5D5 RID: 50645 RVA: 0x00302300 File Offset: 0x00300500
		public string ArrowColor
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

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x00302338 File Offset: 0x00300538
		public Span<byte> GetArrowColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x00302348 File Offset: 0x00300548
		public byte[] GetArrowColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0600C5D8 RID: 50648 RVA: 0x00302360 File Offset: 0x00300560
		public string DescRingColor
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

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x00302398 File Offset: 0x00300598
		public Span<byte> GetDescRingColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C5DA RID: 50650 RVA: 0x003023A8 File Offset: 0x003005A8
		public byte[] GetDescRingColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0600C5DB RID: 50651 RVA: 0x003023C0 File Offset: 0x003005C0
		public string NameColor
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

		// Token: 0x0600C5DC RID: 50652 RVA: 0x003023F8 File Offset: 0x003005F8
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x00302408 File Offset: 0x00300608
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0600C5DE RID: 50654 RVA: 0x00302420 File Offset: 0x00300620
		public string FrameIcon
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

		// Token: 0x0600C5DF RID: 50655 RVA: 0x00302458 File Offset: 0x00300658
		public Span<byte> GetFrameIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C5E0 RID: 50656 RVA: 0x00302468 File Offset: 0x00300668
		public byte[] GetFrameIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040056A9 RID: 22185
		private Table __p;
	}
}
