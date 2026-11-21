using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011EA RID: 4586
	public struct SolarSchoolGallery : IFlatbufferObject
	{
		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600E170 RID: 57712 RVA: 0x00340EF1 File Offset: 0x0033F0F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E171 RID: 57713 RVA: 0x00340EFE File Offset: 0x0033F0FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E172 RID: 57714 RVA: 0x00340F08 File Offset: 0x0033F108
		public static SolarSchoolGallery GetRootAsSolarSchoolGallery(ByteBuffer _bb)
		{
			return SolarSchoolGallery.GetRootAsSolarSchoolGallery(_bb, default(SolarSchoolGallery));
		}

		// Token: 0x0600E173 RID: 57715 RVA: 0x00340F24 File Offset: 0x0033F124
		public static SolarSchoolGallery GetRootAsSolarSchoolGallery(ByteBuffer _bb, SolarSchoolGallery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x00340F41 File Offset: 0x0033F141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E175 RID: 57717 RVA: 0x00340F50 File Offset: 0x0033F150
		public SolarSchoolGallery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600E176 RID: 57718 RVA: 0x00340F60 File Offset: 0x0033F160
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

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600E177 RID: 57719 RVA: 0x00340F9C File Offset: 0x0033F19C
		public int SortId
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

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600E178 RID: 57720 RVA: 0x00340FD8 File Offset: 0x0033F1D8
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

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600E179 RID: 57721 RVA: 0x00341014 File Offset: 0x0033F214
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 28;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0600E17A RID: 57722 RVA: 0x00341054 File Offset: 0x0033F254
		public int UnlockCondition
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

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600E17B RID: 57723 RVA: 0x00341094 File Offset: 0x0033F294
		public int DropId
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

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600E17C RID: 57724 RVA: 0x003410D4 File Offset: 0x0033F2D4
		public bool IsLockHide
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600E17D RID: 57725 RVA: 0x00341114 File Offset: 0x0033F314
		public int ClientCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600E17E RID: 57726 RVA: 0x00341154 File Offset: 0x0033F354
		public int Param
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600E17F RID: 57727 RVA: 0x00341194 File Offset: 0x0033F394
		public string IconMale
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

		// Token: 0x0600E180 RID: 57728 RVA: 0x003411CC File Offset: 0x0033F3CC
		public Span<byte> GetIconMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E181 RID: 57729 RVA: 0x003411DC File Offset: 0x0033F3DC
		public byte[] GetIconMaleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600E182 RID: 57730 RVA: 0x003411F4 File Offset: 0x0033F3F4
		public string IconFemale
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E183 RID: 57731 RVA: 0x0034122C File Offset: 0x0033F42C
		public Span<byte> GetIconFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E184 RID: 57732 RVA: 0x0034123C File Offset: 0x0033F43C
		public byte[] GetIconFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600E185 RID: 57733 RVA: 0x00341254 File Offset: 0x0033F454
		public string DetailResourceMale
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E186 RID: 57734 RVA: 0x0034128C File Offset: 0x0033F48C
		public Span<byte> GetDetailResourceMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E187 RID: 57735 RVA: 0x0034129C File Offset: 0x0033F49C
		public byte[] GetDetailResourceMaleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600E188 RID: 57736 RVA: 0x003412B4 File Offset: 0x0033F4B4
		public string DetailResourceFemale
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E189 RID: 57737 RVA: 0x003412EC File Offset: 0x0033F4EC
		public Span<byte> GetDetailResourceFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E18A RID: 57738 RVA: 0x003412FC File Offset: 0x0033F4FC
		public byte[] GetDetailResourceFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600E18B RID: 57739 RVA: 0x00341314 File Offset: 0x0033F514
		public string AudioResource
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E18C RID: 57740 RVA: 0x0034134C File Offset: 0x0033F54C
		public Span<byte> GetAudioResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E18D RID: 57741 RVA: 0x0034135C File Offset: 0x0033F55C
		public byte[] GetAudioResourceArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600E18E RID: 57742 RVA: 0x00341374 File Offset: 0x0033F574
		public string Video
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E18F RID: 57743 RVA: 0x003413AC File Offset: 0x0033F5AC
		public Span<byte> GetVideoBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600E190 RID: 57744 RVA: 0x003413BC File Offset: 0x0033F5BC
		public byte[] GetVideoArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x04005827 RID: 22567
		private Table __p;
	}
}
