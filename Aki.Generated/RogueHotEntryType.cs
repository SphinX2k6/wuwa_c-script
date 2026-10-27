using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FE4 RID: 4068
	public struct RogueHotEntryType : IFlatbufferObject
	{
		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0600BF7E RID: 49022 RVA: 0x002E5D99 File Offset: 0x002E3F99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF7F RID: 49023 RVA: 0x002E5DA6 File Offset: 0x002E3FA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x002E5DB0 File Offset: 0x002E3FB0
		public static RogueHotEntryType GetRootAsRogueHotEntryType(ByteBuffer _bb)
		{
			return RogueHotEntryType.GetRootAsRogueHotEntryType(_bb, default(RogueHotEntryType));
		}

		// Token: 0x0600BF81 RID: 49025 RVA: 0x002E5DCC File Offset: 0x002E3FCC
		public static RogueHotEntryType GetRootAsRogueHotEntryType(ByteBuffer _bb, RogueHotEntryType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF82 RID: 49026 RVA: 0x002E5DE9 File Offset: 0x002E3FE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF83 RID: 49027 RVA: 0x002E5DF8 File Offset: 0x002E3FF8
		public RogueHotEntryType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x002E5E08 File Offset: 0x002E4008
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

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x0600BF85 RID: 49029 RVA: 0x002E5E44 File Offset: 0x002E4044
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

		// Token: 0x0600BF86 RID: 49030 RVA: 0x002E5E7B File Offset: 0x002E407B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x002E5E8A File Offset: 0x002E408A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x0600BF88 RID: 49032 RVA: 0x002E5EA4 File Offset: 0x002E40A4
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

		// Token: 0x0600BF89 RID: 49033 RVA: 0x002E5EDB File Offset: 0x002E40DB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x002E5EEA File Offset: 0x002E40EA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0600BF8B RID: 49035 RVA: 0x002E5F04 File Offset: 0x002E4104
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

		// Token: 0x0600BF8C RID: 49036 RVA: 0x002E5F3C File Offset: 0x002E413C
		public Span<byte> GetArrowColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BF8D RID: 49037 RVA: 0x002E5F4C File Offset: 0x002E414C
		public byte[] GetArrowColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0600BF8E RID: 49038 RVA: 0x002E5F64 File Offset: 0x002E4164
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

		// Token: 0x0600BF8F RID: 49039 RVA: 0x002E5F9C File Offset: 0x002E419C
		public Span<byte> GetDescRingColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BF90 RID: 49040 RVA: 0x002E5FAC File Offset: 0x002E41AC
		public byte[] GetDescRingColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0600BF91 RID: 49041 RVA: 0x002E5FC4 File Offset: 0x002E41C4
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

		// Token: 0x0600BF92 RID: 49042 RVA: 0x002E5FFC File Offset: 0x002E41FC
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x002E600C File Offset: 0x002E420C
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x0600BF94 RID: 49044 RVA: 0x002E6024 File Offset: 0x002E4224
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

		// Token: 0x0600BF95 RID: 49045 RVA: 0x002E605C File Offset: 0x002E425C
		public Span<byte> GetFrameIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x002E606C File Offset: 0x002E426C
		public byte[] GetFrameIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040050C1 RID: 20673
		private Table __p;
	}
}
