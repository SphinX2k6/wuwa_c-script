using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AF RID: 4271
	public struct SignalDecodeTabColor : IFlatbufferObject
	{
		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600D237 RID: 53815 RVA: 0x0030FF65 File Offset: 0x0030E165
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D238 RID: 53816 RVA: 0x0030FF72 File Offset: 0x0030E172
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D239 RID: 53817 RVA: 0x0030FF7C File Offset: 0x0030E17C
		public static SignalDecodeTabColor GetRootAsSignalDecodeTabColor(ByteBuffer _bb)
		{
			return SignalDecodeTabColor.GetRootAsSignalDecodeTabColor(_bb, default(SignalDecodeTabColor));
		}

		// Token: 0x0600D23A RID: 53818 RVA: 0x0030FF98 File Offset: 0x0030E198
		public static SignalDecodeTabColor GetRootAsSignalDecodeTabColor(ByteBuffer _bb, SignalDecodeTabColor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D23B RID: 53819 RVA: 0x0030FFB5 File Offset: 0x0030E1B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D23C RID: 53820 RVA: 0x0030FFC4 File Offset: 0x0030E1C4
		public SignalDecodeTabColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600D23D RID: 53821 RVA: 0x0030FFD4 File Offset: 0x0030E1D4
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

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600D23E RID: 53822 RVA: 0x00310010 File Offset: 0x0030E210
		public string ActiveColor
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

		// Token: 0x0600D23F RID: 53823 RVA: 0x00310047 File Offset: 0x0030E247
		public Span<byte> GetActiveColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D240 RID: 53824 RVA: 0x00310056 File Offset: 0x0030E256
		public byte[] GetActiveColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600D241 RID: 53825 RVA: 0x00310070 File Offset: 0x0030E270
		public string DefaultColor
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

		// Token: 0x0600D242 RID: 53826 RVA: 0x003100A7 File Offset: 0x0030E2A7
		public Span<byte> GetDefaultColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D243 RID: 53827 RVA: 0x003100B6 File Offset: 0x0030E2B6
		public byte[] GetDefaultColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600D244 RID: 53828 RVA: 0x003100D0 File Offset: 0x0030E2D0
		public string VacancyColor
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

		// Token: 0x0600D245 RID: 53829 RVA: 0x00310108 File Offset: 0x0030E308
		public Span<byte> GetVacancyColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D246 RID: 53830 RVA: 0x00310118 File Offset: 0x0030E318
		public byte[] GetVacancyColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600D247 RID: 53831 RVA: 0x00310130 File Offset: 0x0030E330
		public string HighlightColor
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

		// Token: 0x0600D248 RID: 53832 RVA: 0x00310168 File Offset: 0x0030E368
		public Span<byte> GetHighlightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D249 RID: 53833 RVA: 0x00310178 File Offset: 0x0030E378
		public byte[] GetHighlightColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040051C2 RID: 20930
		private Table __p;
	}
}
