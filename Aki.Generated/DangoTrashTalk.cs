using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE0 RID: 3040
	public struct DangoTrashTalk : IFlatbufferObject
	{
		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060060E2 RID: 24802 RVA: 0x00210905 File Offset: 0x0020EB05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x00210912 File Offset: 0x0020EB12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x0021091C File Offset: 0x0020EB1C
		public static DangoTrashTalk GetRootAsDangoTrashTalk(ByteBuffer _bb)
		{
			return DangoTrashTalk.GetRootAsDangoTrashTalk(_bb, default(DangoTrashTalk));
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x00210938 File Offset: 0x0020EB38
		public static DangoTrashTalk GetRootAsDangoTrashTalk(ByteBuffer _bb, DangoTrashTalk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x00210955 File Offset: 0x0020EB55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x00210964 File Offset: 0x0020EB64
		public DangoTrashTalk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060060E8 RID: 24808 RVA: 0x00210974 File Offset: 0x0020EB74
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

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060060E9 RID: 24809 RVA: 0x002109B0 File Offset: 0x0020EBB0
		public string Textkey
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

		// Token: 0x060060EA RID: 24810 RVA: 0x002109E7 File Offset: 0x0020EBE7
		public Span<byte> GetTextkeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x002109F6 File Offset: 0x0020EBF6
		public byte[] GetTextkeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060060EC RID: 24812 RVA: 0x00210A10 File Offset: 0x0020EC10
		public string AudioEvent
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

		// Token: 0x060060ED RID: 24813 RVA: 0x00210A47 File Offset: 0x0020EC47
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x00210A56 File Offset: 0x0020EC56
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C0D RID: 19469
		private Table __p;
	}
}
