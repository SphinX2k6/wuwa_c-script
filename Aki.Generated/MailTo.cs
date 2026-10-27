using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE5 RID: 3557
	public struct MailTo : IFlatbufferObject
	{
		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06009060 RID: 36960 RVA: 0x0027CDA1 File Offset: 0x0027AFA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x0027CDAE File Offset: 0x0027AFAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x0027CDB8 File Offset: 0x0027AFB8
		public static MailTo GetRootAsMailTo(ByteBuffer _bb)
		{
			return MailTo.GetRootAsMailTo(_bb, default(MailTo));
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x0027CDD4 File Offset: 0x0027AFD4
		public static MailTo GetRootAsMailTo(ByteBuffer _bb, MailTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x0027CDF1 File Offset: 0x0027AFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009065 RID: 36965 RVA: 0x0027CE00 File Offset: 0x0027B000
		public MailTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06009066 RID: 36966 RVA: 0x0027CE10 File Offset: 0x0027B010
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

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x06009067 RID: 36967 RVA: 0x0027CE4C File Offset: 0x0027B04C
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

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06009068 RID: 36968 RVA: 0x0027CE88 File Offset: 0x0027B088
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

		// Token: 0x06009069 RID: 36969 RVA: 0x0027CEBF File Offset: 0x0027B0BF
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x0027CECE File Offset: 0x0027B0CE
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x0600906B RID: 36971 RVA: 0x0027CEE8 File Offset: 0x0027B0E8
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

		// Token: 0x0600906C RID: 36972 RVA: 0x0027CF20 File Offset: 0x0027B120
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600906D RID: 36973 RVA: 0x0027CF30 File Offset: 0x0027B130
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E81 RID: 20097
		private Table __p;
	}
}
