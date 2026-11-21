using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5E RID: 3678
	public struct InteractData : IFlatbufferObject
	{
		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06008C1A RID: 35866 RVA: 0x002834E2 File Offset: 0x002816E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C1B RID: 35867 RVA: 0x002834EF File Offset: 0x002816EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x002834F8 File Offset: 0x002816F8
		public static InteractData GetRootAsInteractData(ByteBuffer _bb)
		{
			return InteractData.GetRootAsInteractData(_bb, default(InteractData));
		}

		// Token: 0x06008C1D RID: 35869 RVA: 0x00283514 File Offset: 0x00281714
		public static InteractData GetRootAsInteractData(ByteBuffer _bb, InteractData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x00283531 File Offset: 0x00281731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C1F RID: 35871 RVA: 0x00283540 File Offset: 0x00281740
		public InteractData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06008C20 RID: 35872 RVA: 0x00283550 File Offset: 0x00281750
		public string Guid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x00283587 File Offset: 0x00281787
		public Span<byte> GetGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x00283596 File Offset: 0x00281796
		public byte[] GetGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06008C23 RID: 35875 RVA: 0x002835B0 File Offset: 0x002817B0
		public string Type
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

		// Token: 0x06008C24 RID: 35876 RVA: 0x002835E7 File Offset: 0x002817E7
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x002835F6 File Offset: 0x002817F6
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06008C26 RID: 35878 RVA: 0x00283610 File Offset: 0x00281810
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

		// Token: 0x06008C27 RID: 35879 RVA: 0x00283647 File Offset: 0x00281847
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x00283656 File Offset: 0x00281856
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06008C29 RID: 35881 RVA: 0x00283670 File Offset: 0x00281870
		public string TidContent
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

		// Token: 0x06008C2A RID: 35882 RVA: 0x002836A8 File Offset: 0x002818A8
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x002836B8 File Offset: 0x002818B8
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06008C2C RID: 35884 RVA: 0x002836D0 File Offset: 0x002818D0
		public string Condition
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

		// Token: 0x06008C2D RID: 35885 RVA: 0x00283708 File Offset: 0x00281908
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x00283718 File Offset: 0x00281918
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06008C2F RID: 35887 RVA: 0x00283730 File Offset: 0x00281930
		public string UniquenessTest
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

		// Token: 0x06008C30 RID: 35888 RVA: 0x00283768 File Offset: 0x00281968
		public Span<byte> GetUniquenessTestBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x00283778 File Offset: 0x00281978
		public byte[] GetUniquenessTestArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06008C32 RID: 35890 RVA: 0x00283790 File Offset: 0x00281990
		public string DoIntactType
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

		// Token: 0x06008C33 RID: 35891 RVA: 0x002837C8 File Offset: 0x002819C8
		public Span<byte> GetDoIntactTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008C34 RID: 35892 RVA: 0x002837D8 File Offset: 0x002819D8
		public byte[] GetDoIntactTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x002837F0 File Offset: 0x002819F0
		public int Range
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

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06008C36 RID: 35894 RVA: 0x00283830 File Offset: 0x00281A30
		public string Duration
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008C37 RID: 35895 RVA: 0x00283868 File Offset: 0x00281A68
		public Span<byte> GetDurationBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008C38 RID: 35896 RVA: 0x00283878 File Offset: 0x00281A78
		public byte[] GetDurationArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06008C39 RID: 35897 RVA: 0x00283890 File Offset: 0x00281A90
		public string OptionLockTypeList
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

		// Token: 0x06008C3A RID: 35898 RVA: 0x002838C8 File Offset: 0x00281AC8
		public Span<byte> GetOptionLockTypeListBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x002838D8 File Offset: 0x00281AD8
		public byte[] GetOptionLockTypeListArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06008C3C RID: 35900 RVA: 0x002838F0 File Offset: 0x00281AF0
		public string LongPressInteractConfig
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

		// Token: 0x06008C3D RID: 35901 RVA: 0x00283928 File Offset: 0x00281B28
		public Span<byte> GetLongPressInteractConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008C3E RID: 35902 RVA: 0x00283938 File Offset: 0x00281B38
		public byte[] GetLongPressInteractConfigArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x040053E6 RID: 21478
		private Table __p;
	}
}
