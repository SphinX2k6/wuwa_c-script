using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E00 RID: 3584
	public struct MatchThreeLevel : IFlatbufferObject
	{
		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x060092E9 RID: 37609 RVA: 0x00282AD5 File Offset: 0x00280CD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x00282AE2 File Offset: 0x00280CE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x00282AEC File Offset: 0x00280CEC
		public static MatchThreeLevel GetRootAsMatchThreeLevel(ByteBuffer _bb)
		{
			return MatchThreeLevel.GetRootAsMatchThreeLevel(_bb, default(MatchThreeLevel));
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x00282B08 File Offset: 0x00280D08
		public static MatchThreeLevel GetRootAsMatchThreeLevel(ByteBuffer _bb, MatchThreeLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x00282B25 File Offset: 0x00280D25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x00282B34 File Offset: 0x00280D34
		public MatchThreeLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x060092EF RID: 37615 RVA: 0x00282B44 File Offset: 0x00280D44
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

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x060092F0 RID: 37616 RVA: 0x00282B80 File Offset: 0x00280D80
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

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x060092F1 RID: 37617 RVA: 0x00282BBC File Offset: 0x00280DBC
		public string Title
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

		// Token: 0x060092F2 RID: 37618 RVA: 0x00282BF3 File Offset: 0x00280DF3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x00282C02 File Offset: 0x00280E02
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x060092F4 RID: 37620 RVA: 0x00282C1C File Offset: 0x00280E1C
		public string Description
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

		// Token: 0x060092F5 RID: 37621 RVA: 0x00282C54 File Offset: 0x00280E54
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x00282C64 File Offset: 0x00280E64
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x060092F7 RID: 37623 RVA: 0x00282C7C File Offset: 0x00280E7C
		public int Chapter
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

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x060092F8 RID: 37624 RVA: 0x00282CBC File Offset: 0x00280EBC
		public int PreChapter
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

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x060092F9 RID: 37625 RVA: 0x00282CFC File Offset: 0x00280EFC
		public int UnLockDay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x060092FA RID: 37626 RVA: 0x00282D3C File Offset: 0x00280F3C
		public int Difficulty
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

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x060092FB RID: 37627 RVA: 0x00282D7C File Offset: 0x00280F7C
		public bool EndLess
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x00282DBC File Offset: 0x00280FBC
		public int RewardDrop
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x00282DFC File Offset: 0x00280FFC
		public int DefaultRole
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004EA1 RID: 20129
		private Table __p;
	}
}
