using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1E RID: 3358
	public struct EntrustFinishDialog : IFlatbufferObject
	{
		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06006FE1 RID: 28641 RVA: 0x00243D65 File Offset: 0x00241F65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x00243D72 File Offset: 0x00241F72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x00243D7C File Offset: 0x00241F7C
		public static EntrustFinishDialog GetRootAsEntrustFinishDialog(ByteBuffer _bb)
		{
			return EntrustFinishDialog.GetRootAsEntrustFinishDialog(_bb, default(EntrustFinishDialog));
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x00243D98 File Offset: 0x00241F98
		public static EntrustFinishDialog GetRootAsEntrustFinishDialog(ByteBuffer _bb, EntrustFinishDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00243DB5 File Offset: 0x00241FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x00243DC4 File Offset: 0x00241FC4
		public EntrustFinishDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06006FE7 RID: 28647 RVA: 0x00243DD4 File Offset: 0x00241FD4
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

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06006FE8 RID: 28648 RVA: 0x00243E10 File Offset: 0x00242010
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

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06006FE9 RID: 28649 RVA: 0x00243E4C File Offset: 0x0024204C
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06006FEA RID: 28650 RVA: 0x00243E88 File Offset: 0x00242088
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

		// Token: 0x06006FEB RID: 28651 RVA: 0x00243EC0 File Offset: 0x002420C0
		public Span<byte> GetUpDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x00243ED0 File Offset: 0x002420D0
		public byte[] GetUpDialogArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06006FED RID: 28653 RVA: 0x00243EE8 File Offset: 0x002420E8
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

		// Token: 0x06006FEE RID: 28654 RVA: 0x00243F20 File Offset: 0x00242120
		public Span<byte> GetUnchangedDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00243F30 File Offset: 0x00242130
		public byte[] GetUnchangedDialogArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06006FF0 RID: 28656 RVA: 0x00243F48 File Offset: 0x00242148
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

		// Token: 0x06006FF1 RID: 28657 RVA: 0x00243F80 File Offset: 0x00242180
		public Span<byte> GetUpDialogGirlBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x00243F90 File Offset: 0x00242190
		public byte[] GetUpDialogGirlArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x00243FA8 File Offset: 0x002421A8
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

		// Token: 0x06006FF4 RID: 28660 RVA: 0x00243FE0 File Offset: 0x002421E0
		public Span<byte> GetUnchangedDialogGirlBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x00243FF0 File Offset: 0x002421F0
		public byte[] GetUnchangedDialogGirlArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400525E RID: 21086
		private Table __p;
	}
}
