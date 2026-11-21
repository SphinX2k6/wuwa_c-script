using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFA RID: 3834
	public struct MonsterHandBook : IFlatbufferObject
	{
		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x06009B12 RID: 39698 RVA: 0x002A52F8 File Offset: 0x002A34F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x002A5305 File Offset: 0x002A3505
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x002A530C File Offset: 0x002A350C
		public static MonsterHandBook GetRootAsMonsterHandBook(ByteBuffer _bb)
		{
			return MonsterHandBook.GetRootAsMonsterHandBook(_bb, default(MonsterHandBook));
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x002A5328 File Offset: 0x002A3528
		public static MonsterHandBook GetRootAsMonsterHandBook(ByteBuffer _bb, MonsterHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x002A5345 File Offset: 0x002A3545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x002A5354 File Offset: 0x002A3554
		public MonsterHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x06009B18 RID: 39704 RVA: 0x002A5364 File Offset: 0x002A3564
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

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06009B19 RID: 39705 RVA: 0x002A53A0 File Offset: 0x002A35A0
		public int MonsterId
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

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x002A53DC File Offset: 0x002A35DC
		public int Type
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

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06009B1B RID: 39707 RVA: 0x002A5418 File Offset: 0x002A3618
		public string Name
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

		// Token: 0x06009B1C RID: 39708 RVA: 0x002A5450 File Offset: 0x002A3650
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x002A5460 File Offset: 0x002A3660
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06009B1E RID: 39710 RVA: 0x002A5478 File Offset: 0x002A3678
		public int Classification
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 16;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06009B1F RID: 39711 RVA: 0x002A54B8 File Offset: 0x002A36B8
		public int MeshId
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

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06009B20 RID: 39712 RVA: 0x002A54F8 File Offset: 0x002A36F8
		public string Descrtption
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

		// Token: 0x06009B21 RID: 39713 RVA: 0x002A5530 File Offset: 0x002A3730
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x002A5540 File Offset: 0x002A3740
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06009B23 RID: 39715 RVA: 0x002A5558 File Offset: 0x002A3758
		public string HandBookBp
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

		// Token: 0x06009B24 RID: 39716 RVA: 0x002A5590 File Offset: 0x002A3790
		public Span<byte> GetHandBookBpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x002A55A0 File Offset: 0x002A37A0
		public byte[] GetHandBookBpArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x002A55B8 File Offset: 0x002A37B8
		public int MonsterBodyType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x002A55F8 File Offset: 0x002A37F8
		public string HandBookCamera
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x002A5630 File Offset: 0x002A3830
		public Span<byte> GetHandBookCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x002A5640 File Offset: 0x002A3840
		public byte[] GetHandBookCameraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x002A5658 File Offset: 0x002A3858
		public int ResistanceElement(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06009B2B RID: 39723 RVA: 0x002A5698 File Offset: 0x002A3898
		public int ResistanceElementLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x002A56C4 File Offset: 0x002A38C4
		public Span<int> GetResistanceElementBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x002A56D4 File Offset: 0x002A38D4
		public int[] GetResistanceElementArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06009B2E RID: 39726 RVA: 0x002A56EC File Offset: 0x002A38EC
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06009B2F RID: 39727 RVA: 0x002A572C File Offset: 0x002A392C
		public bool IsSkin
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06009B30 RID: 39728 RVA: 0x002A576C File Offset: 0x002A396C
		public int OriginalFormInfoId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06009B31 RID: 39729 RVA: 0x002A57AC File Offset: 0x002A39AC
		public bool DefaultUnlock
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x002A57EC File Offset: 0x002A39EC
		[NullableContext(1)]
		public int[] ResistanceElement()
		{
			return this.GetResistanceElementArray();
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x002A57F4 File Offset: 0x002A39F4
		[NullableContext(1)]
		public IEnumerable<int> ResistanceElementIter()
		{
			MonsterHandBook.<ResistanceElementIter>d__50 <ResistanceElementIter>d__ = new MonsterHandBook.<ResistanceElementIter>d__50(-2);
			<ResistanceElementIter>d__.<>3__<>4__this = this;
			return <ResistanceElementIter>d__;
		}

		// Token: 0x0400549F RID: 21663
		private Table __p;
	}
}
