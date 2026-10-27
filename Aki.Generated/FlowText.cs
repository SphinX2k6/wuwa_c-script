using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC5 RID: 3269
	public struct FlowText : IFlatbufferObject
	{
		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x0600758B RID: 30091 RVA: 0x00240298 File Offset: 0x0023E498
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x002402A5 File Offset: 0x0023E4A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x002402AC File Offset: 0x0023E4AC
		public static FlowText GetRootAsFlowText(ByteBuffer _bb)
		{
			return FlowText.GetRootAsFlowText(_bb, default(FlowText));
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x002402C8 File Offset: 0x0023E4C8
		public static FlowText GetRootAsFlowText(ByteBuffer _bb, FlowText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x002402E5 File Offset: 0x0023E4E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x002402F4 File Offset: 0x0023E4F4
		public FlowText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06007591 RID: 30097 RVA: 0x00240304 File Offset: 0x0023E504
		public long Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06007592 RID: 30098 RVA: 0x00240344 File Offset: 0x0023E544
		public string FlowListId
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

		// Token: 0x06007593 RID: 30099 RVA: 0x0024037B File Offset: 0x0023E57B
		public Span<byte> GetFlowListIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x0024038A File Offset: 0x0023E58A
		public byte[] GetFlowListIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06007595 RID: 30101 RVA: 0x002403A4 File Offset: 0x0023E5A4
		public string PlotLineId
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

		// Token: 0x06007596 RID: 30102 RVA: 0x002403DB File Offset: 0x0023E5DB
		public Span<byte> GetPlotLineIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x002403EA File Offset: 0x0023E5EA
		public byte[] GetPlotLineIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06007598 RID: 30104 RVA: 0x00240404 File Offset: 0x0023E604
		public int Id
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

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06007599 RID: 30105 RVA: 0x00240444 File Offset: 0x0023E644
		public int Text
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

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x0600759A RID: 30106 RVA: 0x00240484 File Offset: 0x0023E684
		public string Sound
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

		// Token: 0x0600759B RID: 30107 RVA: 0x002404BC File Offset: 0x0023E6BC
		public Span<byte> GetSoundBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x002404CC File Offset: 0x0023E6CC
		public byte[] GetSoundArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x0600759D RID: 30109 RVA: 0x002404E4 File Offset: 0x0023E6E4
		public string EsKey
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

		// Token: 0x0600759E RID: 30110 RVA: 0x0024051C File Offset: 0x0023E71C
		public Span<byte> GetEsKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x0024052C File Offset: 0x0023E72C
		public byte[] GetEsKeyArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D35 RID: 19765
		private Table __p;
	}
}
