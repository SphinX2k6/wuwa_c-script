using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B0 RID: 4272
	public struct SignalDecodeWaveform : IFlatbufferObject
	{
		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600D24A RID: 53834 RVA: 0x00310190 File Offset: 0x0030E390
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D24B RID: 53835 RVA: 0x0031019D File Offset: 0x0030E39D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D24C RID: 53836 RVA: 0x003101A4 File Offset: 0x0030E3A4
		public static SignalDecodeWaveform GetRootAsSignalDecodeWaveform(ByteBuffer _bb)
		{
			return SignalDecodeWaveform.GetRootAsSignalDecodeWaveform(_bb, default(SignalDecodeWaveform));
		}

		// Token: 0x0600D24D RID: 53837 RVA: 0x003101C0 File Offset: 0x0030E3C0
		public static SignalDecodeWaveform GetRootAsSignalDecodeWaveform(ByteBuffer _bb, SignalDecodeWaveform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D24E RID: 53838 RVA: 0x003101DD File Offset: 0x0030E3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D24F RID: 53839 RVA: 0x003101EC File Offset: 0x0030E3EC
		public SignalDecodeWaveform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600D250 RID: 53840 RVA: 0x003101FC File Offset: 0x0030E3FC
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

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600D251 RID: 53841 RVA: 0x00310238 File Offset: 0x0030E438
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

		// Token: 0x0600D252 RID: 53842 RVA: 0x0031026F File Offset: 0x0030E46F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D253 RID: 53843 RVA: 0x0031027E File Offset: 0x0030E47E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600D254 RID: 53844 RVA: 0x00310298 File Offset: 0x0030E498
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

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600D255 RID: 53845 RVA: 0x003102D8 File Offset: 0x0030E4D8
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

		// Token: 0x0600D256 RID: 53846 RVA: 0x00310310 File Offset: 0x0030E510
		public Span<byte> GetSignalFragmentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D257 RID: 53847 RVA: 0x00310320 File Offset: 0x0030E520
		public byte[] GetSignalFragmentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600D258 RID: 53848 RVA: 0x00310338 File Offset: 0x0030E538
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

		// Token: 0x0600D259 RID: 53849 RVA: 0x00310370 File Offset: 0x0030E570
		public Span<byte> GetMissingPartsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D25A RID: 53850 RVA: 0x00310380 File Offset: 0x0030E580
		public byte[] GetMissingPartsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600D25B RID: 53851 RVA: 0x00310398 File Offset: 0x0030E598
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

		// Token: 0x040051C3 RID: 20931
		private Table __p;
	}
}
