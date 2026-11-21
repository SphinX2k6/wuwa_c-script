using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AB RID: 4523
	public struct SignalDecodeWaveform : IFlatbufferObject
	{
		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600DA27 RID: 55847 RVA: 0x0032F74C File Offset: 0x0032D94C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA28 RID: 55848 RVA: 0x0032F759 File Offset: 0x0032D959
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA29 RID: 55849 RVA: 0x0032F760 File Offset: 0x0032D960
		public static SignalDecodeWaveform GetRootAsSignalDecodeWaveform(ByteBuffer _bb)
		{
			return SignalDecodeWaveform.GetRootAsSignalDecodeWaveform(_bb, default(SignalDecodeWaveform));
		}

		// Token: 0x0600DA2A RID: 55850 RVA: 0x0032F77C File Offset: 0x0032D97C
		public static SignalDecodeWaveform GetRootAsSignalDecodeWaveform(ByteBuffer _bb, SignalDecodeWaveform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA2B RID: 55851 RVA: 0x0032F799 File Offset: 0x0032D999
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA2C RID: 55852 RVA: 0x0032F7A8 File Offset: 0x0032D9A8
		public SignalDecodeWaveform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600DA2D RID: 55853 RVA: 0x0032F7B8 File Offset: 0x0032D9B8
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

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600DA2E RID: 55854 RVA: 0x0032F7F4 File Offset: 0x0032D9F4
		public string Name
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

		// Token: 0x0600DA2F RID: 55855 RVA: 0x0032F82B File Offset: 0x0032DA2B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x0032F83A File Offset: 0x0032DA3A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600DA31 RID: 55857 RVA: 0x0032F854 File Offset: 0x0032DA54
		public float SpeedRate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600DA32 RID: 55858 RVA: 0x0032F894 File Offset: 0x0032DA94
		public string SignalFragment
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

		// Token: 0x0600DA33 RID: 55859 RVA: 0x0032F8CC File Offset: 0x0032DACC
		public Span<byte> GetSignalFragmentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x0032F8DC File Offset: 0x0032DADC
		public byte[] GetSignalFragmentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600DA35 RID: 55861 RVA: 0x0032F8F4 File Offset: 0x0032DAF4
		public string MissingParts
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

		// Token: 0x0600DA36 RID: 55862 RVA: 0x0032F92C File Offset: 0x0032DB2C
		public Span<byte> GetMissingPartsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DA37 RID: 55863 RVA: 0x0032F93C File Offset: 0x0032DB3C
		public byte[] GetMissingPartsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0600DA38 RID: 55864 RVA: 0x0032F954 File Offset: 0x0032DB54
		public int Offset
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

		// Token: 0x040057C2 RID: 22466
		private Table __p;
	}
}
