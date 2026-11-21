using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E05 RID: 3589
	public struct GuQinActivityTask : IFlatbufferObject
	{
		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060083C1 RID: 33729 RVA: 0x00270DD1 File Offset: 0x0026EFD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x00270DDE File Offset: 0x0026EFDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060083C3 RID: 33731 RVA: 0x00270DE8 File Offset: 0x0026EFE8
		public static GuQinActivityTask GetRootAsGuQinActivityTask(ByteBuffer _bb)
		{
			return GuQinActivityTask.GetRootAsGuQinActivityTask(_bb, default(GuQinActivityTask));
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x00270E04 File Offset: 0x0026F004
		public static GuQinActivityTask GetRootAsGuQinActivityTask(ByteBuffer _bb, GuQinActivityTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x00270E21 File Offset: 0x0026F021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x00270E30 File Offset: 0x0026F030
		public GuQinActivityTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x060083C7 RID: 33735 RVA: 0x00270E40 File Offset: 0x0026F040
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

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x060083C8 RID: 33736 RVA: 0x00270E7C File Offset: 0x0026F07C
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

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x060083C9 RID: 33737 RVA: 0x00270EB8 File Offset: 0x0026F0B8
		public int QuestId
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

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060083CA RID: 33738 RVA: 0x00270EF4 File Offset: 0x0026F0F4
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x060083CB RID: 33739 RVA: 0x00270F34 File Offset: 0x0026F134
		public int NodeId
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

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x060083CC RID: 33740 RVA: 0x00270F74 File Offset: 0x0026F174
		public int PreQuestId
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

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x060083CD RID: 33741 RVA: 0x00270FB4 File Offset: 0x0026F1B4
		public string Title
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

		// Token: 0x060083CE RID: 33742 RVA: 0x00270FEC File Offset: 0x0026F1EC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x00270FFC File Offset: 0x0026F1FC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x060083D0 RID: 33744 RVA: 0x00271014 File Offset: 0x0026F214
		public string Desc
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

		// Token: 0x060083D1 RID: 33745 RVA: 0x0027104C File Offset: 0x0026F24C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x0027105C File Offset: 0x0026F25C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x060083D3 RID: 33747 RVA: 0x00271074 File Offset: 0x0026F274
		public string BgPath
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

		// Token: 0x060083D4 RID: 33748 RVA: 0x002710AC File Offset: 0x0026F2AC
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x002710BC File Offset: 0x0026F2BC
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x060083D6 RID: 33750 RVA: 0x002710D4 File Offset: 0x0026F2D4
		public string TabNumTxt
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

		// Token: 0x060083D7 RID: 33751 RVA: 0x0027110C File Offset: 0x0026F30C
		public Span<byte> GetTabNumTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0027111C File Offset: 0x0026F31C
		public byte[] GetTabNumTxtArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x060083D9 RID: 33753 RVA: 0x00271134 File Offset: 0x0026F334
		public string TabNumTexturePath
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

		// Token: 0x060083DA RID: 33754 RVA: 0x0027116C File Offset: 0x0026F36C
		public Span<byte> GetTabNumTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x0027117C File Offset: 0x0026F37C
		public byte[] GetTabNumTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x060083DC RID: 33756 RVA: 0x00271194 File Offset: 0x0026F394
		public string TabBgPath
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

		// Token: 0x060083DD RID: 33757 RVA: 0x002711CC File Offset: 0x0026F3CC
		public Span<byte> GetTabBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x002711DC File Offset: 0x0026F3DC
		public byte[] GetTabBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x060083DF RID: 33759 RVA: 0x002711F4 File Offset: 0x0026F3F4
		public string FemaleTabBgPath
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

		// Token: 0x060083E0 RID: 33760 RVA: 0x0027122C File Offset: 0x0026F42C
		public Span<byte> GetFemaleTabBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x0027123C File Offset: 0x0026F43C
		public byte[] GetFemaleTabBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x060083E2 RID: 33762 RVA: 0x00271254 File Offset: 0x0026F454
		public int RewardId
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

		// Token: 0x0400537D RID: 21373
		private Table __p;
	}
}
