using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AA RID: 4522
	public struct SignalDecodeTabColor : IFlatbufferObject
	{
		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600DA14 RID: 55828 RVA: 0x0032F521 File Offset: 0x0032D721
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DA15 RID: 55829 RVA: 0x0032F52E File Offset: 0x0032D72E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DA16 RID: 55830 RVA: 0x0032F538 File Offset: 0x0032D738
		public static SignalDecodeTabColor GetRootAsSignalDecodeTabColor(ByteBuffer _bb)
		{
			return SignalDecodeTabColor.GetRootAsSignalDecodeTabColor(_bb, default(SignalDecodeTabColor));
		}

		// Token: 0x0600DA17 RID: 55831 RVA: 0x0032F554 File Offset: 0x0032D754
		public static SignalDecodeTabColor GetRootAsSignalDecodeTabColor(ByteBuffer _bb, SignalDecodeTabColor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DA18 RID: 55832 RVA: 0x0032F571 File Offset: 0x0032D771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DA19 RID: 55833 RVA: 0x0032F580 File Offset: 0x0032D780
		public SignalDecodeTabColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x0032F590 File Offset: 0x0032D790
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

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600DA1B RID: 55835 RVA: 0x0032F5CC File Offset: 0x0032D7CC
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

		// Token: 0x0600DA1C RID: 55836 RVA: 0x0032F603 File Offset: 0x0032D803
		public Span<byte> GetActiveColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DA1D RID: 55837 RVA: 0x0032F612 File Offset: 0x0032D812
		public byte[] GetActiveColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600DA1E RID: 55838 RVA: 0x0032F62C File Offset: 0x0032D82C
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

		// Token: 0x0600DA1F RID: 55839 RVA: 0x0032F663 File Offset: 0x0032D863
		public Span<byte> GetDefaultColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DA20 RID: 55840 RVA: 0x0032F672 File Offset: 0x0032D872
		public byte[] GetDefaultColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600DA21 RID: 55841 RVA: 0x0032F68C File Offset: 0x0032D88C
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

		// Token: 0x0600DA22 RID: 55842 RVA: 0x0032F6C4 File Offset: 0x0032D8C4
		public Span<byte> GetVacancyColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DA23 RID: 55843 RVA: 0x0032F6D4 File Offset: 0x0032D8D4
		public byte[] GetVacancyColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600DA24 RID: 55844 RVA: 0x0032F6EC File Offset: 0x0032D8EC
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

		// Token: 0x0600DA25 RID: 55845 RVA: 0x0032F724 File Offset: 0x0032D924
		public Span<byte> GetHighlightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DA26 RID: 55846 RVA: 0x0032F734 File Offset: 0x0032D934
		public byte[] GetHighlightColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040057C1 RID: 22465
		private Table __p;
	}
}
