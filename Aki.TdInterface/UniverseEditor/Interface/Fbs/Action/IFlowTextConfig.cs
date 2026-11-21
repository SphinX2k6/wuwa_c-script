using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB7 RID: 28343
	public struct IFlowTextConfig : IFlatbufferObject
	{
		// Token: 0x1700CFE0 RID: 53216
		// (get) Token: 0x0603107B RID: 200827 RVA: 0x006A650A File Offset: 0x006A470A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603107C RID: 200828 RVA: 0x006A6517 File Offset: 0x006A4717
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603107D RID: 200829 RVA: 0x006A6520 File Offset: 0x006A4720
		public static IFlowTextConfig GetRootAsIFlowTextConfig(ByteBuffer _bb)
		{
			return IFlowTextConfig.GetRootAsIFlowTextConfig(_bb, default(IFlowTextConfig));
		}

		// Token: 0x0603107E RID: 200830 RVA: 0x006A653C File Offset: 0x006A473C
		public static IFlowTextConfig GetRootAsIFlowTextConfig(ByteBuffer _bb, IFlowTextConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603107F RID: 200831 RVA: 0x006A6559 File Offset: 0x006A4759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031080 RID: 200832 RVA: 0x006A6568 File Offset: 0x006A4768
		public IFlowTextConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFE1 RID: 53217
		// (get) Token: 0x06031081 RID: 200833 RVA: 0x006A6578 File Offset: 0x006A4778
		public string Text
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031082 RID: 200834 RVA: 0x006A65AF File Offset: 0x006A47AF
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031083 RID: 200835 RVA: 0x006A65BE File Offset: 0x006A47BE
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CFE2 RID: 53218
		// (get) Token: 0x06031084 RID: 200836 RVA: 0x006A65CC File Offset: 0x006A47CC
		public string PlotLineKey
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

		// Token: 0x06031085 RID: 200837 RVA: 0x006A6603 File Offset: 0x006A4803
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031086 RID: 200838 RVA: 0x006A6612 File Offset: 0x006A4812
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CFE3 RID: 53219
		// (get) Token: 0x06031087 RID: 200839 RVA: 0x006A6620 File Offset: 0x006A4820
		public string StringKey
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

		// Token: 0x06031088 RID: 200840 RVA: 0x006A6657 File Offset: 0x006A4857
		public Span<byte> GetStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06031089 RID: 200841 RVA: 0x006A6666 File Offset: 0x006A4866
		public byte[] GetStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700CFE4 RID: 53220
		// (get) Token: 0x0603108A RID: 200842 RVA: 0x006A6674 File Offset: 0x006A4874
		public int FlowListId
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

		// Token: 0x1700CFE5 RID: 53221
		// (get) Token: 0x0603108B RID: 200843 RVA: 0x006A66B4 File Offset: 0x006A48B4
		public bool IsNoPlotText
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CFE6 RID: 53222
		// (get) Token: 0x0603108C RID: 200844 RVA: 0x006A66F4 File Offset: 0x006A48F4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603108D RID: 200845 RVA: 0x006A6731 File Offset: 0x006A4931
		public static Offset<IFlowTextConfig> CreateIFlowTextConfig(FlatBufferBuilder builder, StringOffset TextOffset = default(StringOffset), StringOffset PlotLineKeyOffset = default(StringOffset), StringOffset StringKeyOffset = default(StringOffset), int FlowListId = 0, bool IsNoPlotText = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IFlowTextConfig.AddFlowListId(builder, FlowListId);
			IFlowTextConfig.AddStringKey(builder, StringKeyOffset);
			IFlowTextConfig.AddPlotLineKey(builder, PlotLineKeyOffset);
			IFlowTextConfig.AddText(builder, TextOffset);
			IFlowTextConfig.AddNullMask(builder, NullMask);
			IFlowTextConfig.AddIsNoPlotText(builder, IsNoPlotText);
			return IFlowTextConfig.EndIFlowTextConfig(builder);
		}

		// Token: 0x0603108E RID: 200846 RVA: 0x006A676D File Offset: 0x006A496D
		public static void StartIFlowTextConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603108F RID: 200847 RVA: 0x006A6776 File Offset: 0x006A4976
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
			builder.AddOffset(0, textOffset.Value, 0);
		}

		// Token: 0x06031090 RID: 200848 RVA: 0x006A6786 File Offset: 0x006A4986
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(1, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06031091 RID: 200849 RVA: 0x006A6796 File Offset: 0x006A4996
		public static void AddStringKey(FlatBufferBuilder builder, StringOffset stringKeyOffset)
		{
			builder.AddOffset(2, stringKeyOffset.Value, 0);
		}

		// Token: 0x06031092 RID: 200850 RVA: 0x006A67A6 File Offset: 0x006A49A6
		public static void AddFlowListId(FlatBufferBuilder builder, int flowListId)
		{
			builder.AddInt(3, flowListId, 0);
		}

		// Token: 0x06031093 RID: 200851 RVA: 0x006A67B1 File Offset: 0x006A49B1
		public static void AddIsNoPlotText(FlatBufferBuilder builder, bool isNoPlotText)
		{
			builder.AddBool(4, isNoPlotText, false);
		}

		// Token: 0x06031094 RID: 200852 RVA: 0x006A67BC File Offset: 0x006A49BC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06031095 RID: 200853 RVA: 0x006A67C7 File Offset: 0x006A49C7
		public static Offset<IFlowTextConfig> EndIFlowTextConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTextConfig>(builder.EndTable());
		}

		// Token: 0x06031096 RID: 200854 RVA: 0x006A67D4 File Offset: 0x006A49D4
		public IFlowTextConfigT UnPack()
		{
			IFlowTextConfigT flowTextConfigT = new IFlowTextConfigT();
			this.UnPackTo(flowTextConfigT);
			return flowTextConfigT;
		}

		// Token: 0x06031097 RID: 200855 RVA: 0x006A67F0 File Offset: 0x006A49F0
		public void UnPackTo(IFlowTextConfigT _o)
		{
			_o.Text = this.Text;
			_o.PlotLineKey = this.PlotLineKey;
			_o.StringKey = this.StringKey;
			_o.FlowListId = this.FlowListId;
			_o.IsNoPlotText = this.IsNoPlotText;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031098 RID: 200856 RVA: 0x006A6848 File Offset: 0x006A4A48
		public static Offset<IFlowTextConfig> Pack(FlatBufferBuilder builder, IFlowTextConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowTextConfig>);
			}
			StringOffset textOffset = (_o.Text == null) ? default(StringOffset) : builder.CreateString(_o.Text);
			StringOffset plotLineKeyOffset = (_o.PlotLineKey == null) ? default(StringOffset) : builder.CreateString(_o.PlotLineKey);
			StringOffset stringKeyOffset = (_o.StringKey == null) ? default(StringOffset) : builder.CreateString(_o.StringKey);
			return IFlowTextConfig.CreateIFlowTextConfig(builder, textOffset, plotLineKeyOffset, stringKeyOffset, _o.FlowListId, _o.IsNoPlotText, _o.NullMask);
		}

		// Token: 0x04011DAD RID: 73133
		private Table __p;
	}
}
