using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C3B RID: 3131
	public struct EntrustFinishDialog : IFlatbufferObject
	{
		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x00224A1D File Offset: 0x00222C1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00224A2A File Offset: 0x00222C2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x00224A34 File Offset: 0x00222C34
		public static EntrustFinishDialog GetRootAsEntrustFinishDialog(ByteBuffer _bb)
		{
			return EntrustFinishDialog.GetRootAsEntrustFinishDialog(_bb, default(EntrustFinishDialog));
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x00224A50 File Offset: 0x00222C50
		public static EntrustFinishDialog GetRootAsEntrustFinishDialog(ByteBuffer _bb, EntrustFinishDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x00224A6D File Offset: 0x00222C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x00224A7C File Offset: 0x00222C7C
		public EntrustFinishDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x00224A8C File Offset: 0x00222C8C
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

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x060069E6 RID: 27110 RVA: 0x00224AC8 File Offset: 0x00222CC8
		public int EntrustId
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

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x00224B04 File Offset: 0x00222D04
		public int Level
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

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x060069E8 RID: 27112 RVA: 0x00224B40 File Offset: 0x00222D40
		public string UpDialog
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

		// Token: 0x060069E9 RID: 27113 RVA: 0x00224B78 File Offset: 0x00222D78
		public Span<byte> GetUpDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x00224B88 File Offset: 0x00222D88
		public byte[] GetUpDialogArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x00224BA0 File Offset: 0x00222DA0
		public string UnchangedDialog
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

		// Token: 0x060069EC RID: 27116 RVA: 0x00224BD8 File Offset: 0x00222DD8
		public Span<byte> GetUnchangedDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x00224BE8 File Offset: 0x00222DE8
		public byte[] GetUnchangedDialogArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x060069EE RID: 27118 RVA: 0x00224C00 File Offset: 0x00222E00
		public string UpDialogGirl
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

		// Token: 0x060069EF RID: 27119 RVA: 0x00224C38 File Offset: 0x00222E38
		public Span<byte> GetUpDialogGirlBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x00224C48 File Offset: 0x00222E48
		public byte[] GetUpDialogGirlArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060069F1 RID: 27121 RVA: 0x00224C60 File Offset: 0x00222E60
		public string UnchangedDialogGirl
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

		// Token: 0x060069F2 RID: 27122 RVA: 0x00224C98 File Offset: 0x00222E98
		public Span<byte> GetUnchangedDialogGirlBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x00224CA8 File Offset: 0x00222EA8
		public byte[] GetUnchangedDialogGirlArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C7B RID: 19579
		private Table __p;
	}
}
