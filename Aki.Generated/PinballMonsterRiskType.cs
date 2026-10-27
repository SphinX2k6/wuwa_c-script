using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F31 RID: 3889
	public struct PinballMonsterRiskType : IFlatbufferObject
	{
		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600AF7B RID: 44923 RVA: 0x002C311D File Offset: 0x002C131D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF7C RID: 44924 RVA: 0x002C312A File Offset: 0x002C132A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF7D RID: 44925 RVA: 0x002C3134 File Offset: 0x002C1334
		public static PinballMonsterRiskType GetRootAsPinballMonsterRiskType(ByteBuffer _bb)
		{
			return PinballMonsterRiskType.GetRootAsPinballMonsterRiskType(_bb, default(PinballMonsterRiskType));
		}

		// Token: 0x0600AF7E RID: 44926 RVA: 0x002C3150 File Offset: 0x002C1350
		public static PinballMonsterRiskType GetRootAsPinballMonsterRiskType(ByteBuffer _bb, PinballMonsterRiskType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF7F RID: 44927 RVA: 0x002C316D File Offset: 0x002C136D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x002C317C File Offset: 0x002C137C
		public PinballMonsterRiskType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600AF81 RID: 44929 RVA: 0x002C318C File Offset: 0x002C138C
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

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x002C31C8 File Offset: 0x002C13C8
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

		// Token: 0x0600AF83 RID: 44931 RVA: 0x002C31FF File Offset: 0x002C13FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AF84 RID: 44932 RVA: 0x002C320E File Offset: 0x002C140E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600AF85 RID: 44933 RVA: 0x002C3228 File Offset: 0x002C1428
		public string Icon1
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

		// Token: 0x0600AF86 RID: 44934 RVA: 0x002C325F File Offset: 0x002C145F
		public Span<byte> GetIcon1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AF87 RID: 44935 RVA: 0x002C326E File Offset: 0x002C146E
		public byte[] GetIcon1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x002C3288 File Offset: 0x002C1488
		public string Icon2
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

		// Token: 0x0600AF89 RID: 44937 RVA: 0x002C32C0 File Offset: 0x002C14C0
		public Span<byte> GetIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x002C32D0 File Offset: 0x002C14D0
		public byte[] GetIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600AF8B RID: 44939 RVA: 0x002C32E8 File Offset: 0x002C14E8
		public string TitleColor
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

		// Token: 0x0600AF8C RID: 44940 RVA: 0x002C3320 File Offset: 0x002C1520
		public Span<byte> GetTitleColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AF8D RID: 44941 RVA: 0x002C3330 File Offset: 0x002C1530
		public byte[] GetTitleColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600AF8E RID: 44942 RVA: 0x002C3348 File Offset: 0x002C1548
		public string TitleOutlineColor
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

		// Token: 0x0600AF8F RID: 44943 RVA: 0x002C3380 File Offset: 0x002C1580
		public Span<byte> GetTitleOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x002C3390 File Offset: 0x002C1590
		public byte[] GetTitleOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FFB RID: 20475
		private Table __p;
	}
}
