using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F5 RID: 4341
	public struct SubtitleText : IFlatbufferObject
	{
		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600D9A7 RID: 55719 RVA: 0x00321D45 File Offset: 0x0031FF45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D9A8 RID: 55720 RVA: 0x00321D52 File Offset: 0x0031FF52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D9A9 RID: 55721 RVA: 0x00321D5C File Offset: 0x0031FF5C
		public static SubtitleText GetRootAsSubtitleText(ByteBuffer _bb)
		{
			return SubtitleText.GetRootAsSubtitleText(_bb, default(SubtitleText));
		}

		// Token: 0x0600D9AA RID: 55722 RVA: 0x00321D78 File Offset: 0x0031FF78
		public static SubtitleText GetRootAsSubtitleText(ByteBuffer _bb, SubtitleText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D9AB RID: 55723 RVA: 0x00321D95 File Offset: 0x0031FF95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D9AC RID: 55724 RVA: 0x00321DA4 File Offset: 0x0031FFA4
		public SubtitleText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600D9AD RID: 55725 RVA: 0x00321DB4 File Offset: 0x0031FFB4
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

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600D9AE RID: 55726 RVA: 0x00321DF0 File Offset: 0x0031FFF0
		public int RowName
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

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600D9AF RID: 55727 RVA: 0x00321E2C File Offset: 0x0032002C
		public string DatatableName
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

		// Token: 0x0600D9B0 RID: 55728 RVA: 0x00321E63 File Offset: 0x00320063
		public Span<byte> GetDatatableNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D9B1 RID: 55729 RVA: 0x00321E72 File Offset: 0x00320072
		public byte[] GetDatatableNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600D9B2 RID: 55730 RVA: 0x00321E8C File Offset: 0x0032008C
		public int CharacterName
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

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600D9B3 RID: 55731 RVA: 0x00321ECC File Offset: 0x003200CC
		public int RoleId
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

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600D9B4 RID: 55732 RVA: 0x00321F0C File Offset: 0x0032010C
		public int Subtitles1
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

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600D9B5 RID: 55733 RVA: 0x00321F4C File Offset: 0x0032014C
		public int Subtitles2
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

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x00321F8C File Offset: 0x0032018C
		public int Subtitles3
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

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600D9B7 RID: 55735 RVA: 0x00321FCC File Offset: 0x003201CC
		public int Subtitles4
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

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x0032200C File Offset: 0x0032020C
		public int Subtitles5
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

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600D9B9 RID: 55737 RVA: 0x0032204C File Offset: 0x0032024C
		public int Option1
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

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x0032208C File Offset: 0x0032028C
		public int Option2
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

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600D9BB RID: 55739 RVA: 0x003220CC File Offset: 0x003202CC
		public int Option3
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x0032210C File Offset: 0x0032030C
		public int Option4
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

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600D9BD RID: 55741 RVA: 0x0032214C File Offset: 0x0032034C
		public int Option5
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x0032218C File Offset: 0x0032038C
		public string Audio1
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9BF RID: 55743 RVA: 0x003221C4 File Offset: 0x003203C4
		public Span<byte> GetAudio1Bytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D9C0 RID: 55744 RVA: 0x003221D4 File Offset: 0x003203D4
		public byte[] GetAudio1Array()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600D9C1 RID: 55745 RVA: 0x003221EC File Offset: 0x003203EC
		public string Audio2
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9C2 RID: 55746 RVA: 0x00322224 File Offset: 0x00320424
		public Span<byte> GetAudio2Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600D9C3 RID: 55747 RVA: 0x00322234 File Offset: 0x00320434
		public byte[] GetAudio2Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600D9C4 RID: 55748 RVA: 0x0032224C File Offset: 0x0032044C
		public string Audio3
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9C5 RID: 55749 RVA: 0x00322284 File Offset: 0x00320484
		public Span<byte> GetAudio3Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600D9C6 RID: 55750 RVA: 0x00322294 File Offset: 0x00320494
		public byte[] GetAudio3Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600D9C7 RID: 55751 RVA: 0x003222AC File Offset: 0x003204AC
		public string Audio4
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9C8 RID: 55752 RVA: 0x003222E4 File Offset: 0x003204E4
		public Span<byte> GetAudio4Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600D9C9 RID: 55753 RVA: 0x003222F4 File Offset: 0x003204F4
		public byte[] GetAudio4Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600D9CA RID: 55754 RVA: 0x0032230C File Offset: 0x0032050C
		public string Audio5
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9CB RID: 55755 RVA: 0x00322344 File Offset: 0x00320544
		public Span<byte> GetAudio5Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600D9CC RID: 55756 RVA: 0x00322354 File Offset: 0x00320554
		public byte[] GetAudio5Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600D9CD RID: 55757 RVA: 0x0032236C File Offset: 0x0032056C
		public string OSList
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9CE RID: 55758 RVA: 0x003223A4 File Offset: 0x003205A4
		public Span<byte> GetOSListBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600D9CF RID: 55759 RVA: 0x003223B4 File Offset: 0x003205B4
		public byte[] GetOSListArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x04005229 RID: 21033
		private Table __p;
	}
}
