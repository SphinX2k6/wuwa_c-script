using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECA RID: 3786
	public struct MailTo : IFlatbufferObject
	{
		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x0600967C RID: 38524 RVA: 0x0029B021 File Offset: 0x00299221
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600967D RID: 38525 RVA: 0x0029B02E File Offset: 0x0029922E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600967E RID: 38526 RVA: 0x0029B038 File Offset: 0x00299238
		public static MailTo GetRootAsMailTo(ByteBuffer _bb)
		{
			return MailTo.GetRootAsMailTo(_bb, default(MailTo));
		}

		// Token: 0x0600967F RID: 38527 RVA: 0x0029B054 File Offset: 0x00299254
		public static MailTo GetRootAsMailTo(ByteBuffer _bb, MailTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x0029B071 File Offset: 0x00299271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x0029B080 File Offset: 0x00299280
		public MailTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06009682 RID: 38530 RVA: 0x0029B090 File Offset: 0x00299290
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

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06009683 RID: 38531 RVA: 0x0029B0CC File Offset: 0x002992CC
		public int JumpId
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

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06009684 RID: 38532 RVA: 0x0029B108 File Offset: 0x00299308
		public string IconPath
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

		// Token: 0x06009685 RID: 38533 RVA: 0x0029B13F File Offset: 0x0029933F
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x0029B14E File Offset: 0x0029934E
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x06009687 RID: 38535 RVA: 0x0029B168 File Offset: 0x00299368
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

		// Token: 0x06009688 RID: 38536 RVA: 0x0029B1A0 File Offset: 0x002993A0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x0029B1B0 File Offset: 0x002993B0
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005466 RID: 21606
		private Table __p;
	}
}
