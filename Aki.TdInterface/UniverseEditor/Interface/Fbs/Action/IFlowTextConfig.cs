using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006831 RID: 26673
	public struct IFlowTextConfig : IFlatbufferObject
	{
		// Token: 0x1700C61C RID: 50716
		// (get) Token: 0x0602E7F3 RID: 190451 RVA: 0x006585CA File Offset: 0x006567CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E7F4 RID: 190452 RVA: 0x006585D7 File Offset: 0x006567D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E7F5 RID: 190453 RVA: 0x006585E0 File Offset: 0x006567E0
		public static IFlowTextConfig GetRootAsIFlowTextConfig(ByteBuffer _bb)
		{
			return IFlowTextConfig.GetRootAsIFlowTextConfig(_bb, default(IFlowTextConfig));
		}

		// Token: 0x0602E7F6 RID: 190454 RVA: 0x006585FC File Offset: 0x006567FC
		public static IFlowTextConfig GetRootAsIFlowTextConfig(ByteBuffer _bb, IFlowTextConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E7F7 RID: 190455 RVA: 0x00658619 File Offset: 0x00656819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E7F8 RID: 190456 RVA: 0x00658628 File Offset: 0x00656828
		public IFlowTextConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C61D RID: 50717
		// (get) Token: 0x0602E7F9 RID: 190457 RVA: 0x00658638 File Offset: 0x00656838
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

		// Token: 0x0602E7FA RID: 190458 RVA: 0x0065866F File Offset: 0x0065686F
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E7FB RID: 190459 RVA: 0x0065867E File Offset: 0x0065687E
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C61E RID: 50718
		// (get) Token: 0x0602E7FC RID: 190460 RVA: 0x0065868C File Offset: 0x0065688C
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

		// Token: 0x0602E7FD RID: 190461 RVA: 0x006586C3 File Offset: 0x006568C3
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E7FE RID: 190462 RVA: 0x006586D2 File Offset: 0x006568D2
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C61F RID: 50719
		// (get) Token: 0x0602E7FF RID: 190463 RVA: 0x006586E0 File Offset: 0x006568E0
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

		// Token: 0x0602E800 RID: 190464 RVA: 0x00658717 File Offset: 0x00656917
		public Span<byte> GetStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602E801 RID: 190465 RVA: 0x00658726 File Offset: 0x00656926
		public byte[] GetStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700C620 RID: 50720
		// (get) Token: 0x0602E802 RID: 190466 RVA: 0x00658734 File Offset: 0x00656934
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

		// Token: 0x1700C621 RID: 50721
		// (get) Token: 0x0602E803 RID: 190467 RVA: 0x00658774 File Offset: 0x00656974
		public bool IsNoPlotText
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C622 RID: 50722
		// (get) Token: 0x0602E804 RID: 190468 RVA: 0x006587B4 File Offset: 0x006569B4
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

		// Token: 0x0602E805 RID: 190469 RVA: 0x006587F1 File Offset: 0x006569F1
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

		// Token: 0x0602E806 RID: 190470 RVA: 0x0065882D File Offset: 0x00656A2D
		public static void StartIFlowTextConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E807 RID: 190471 RVA: 0x00658836 File Offset: 0x00656A36
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
			builder.AddOffset(0, textOffset.Value, 0);
		}

		// Token: 0x0602E808 RID: 190472 RVA: 0x00658846 File Offset: 0x00656A46
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(1, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x0602E809 RID: 190473 RVA: 0x00658856 File Offset: 0x00656A56
		public static void AddStringKey(FlatBufferBuilder builder, StringOffset stringKeyOffset)
		{
			builder.AddOffset(2, stringKeyOffset.Value, 0);
		}

		// Token: 0x0602E80A RID: 190474 RVA: 0x00658866 File Offset: 0x00656A66
		public static void AddFlowListId(FlatBufferBuilder builder, int flowListId)
		{
			builder.AddInt(3, flowListId, 0);
		}

		// Token: 0x0602E80B RID: 190475 RVA: 0x00658871 File Offset: 0x00656A71
		public static void AddIsNoPlotText(FlatBufferBuilder builder, bool isNoPlotText)
		{
			builder.AddBool(4, isNoPlotText, false);
		}

		// Token: 0x0602E80C RID: 190476 RVA: 0x0065887C File Offset: 0x00656A7C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602E80D RID: 190477 RVA: 0x00658887 File Offset: 0x00656A87
		public static Offset<IFlowTextConfig> EndIFlowTextConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowTextConfig>(builder.EndTable());
		}

		// Token: 0x0602E80E RID: 190478 RVA: 0x00658894 File Offset: 0x00656A94
		public IFlowTextConfigT UnPack()
		{
			IFlowTextConfigT flowTextConfigT = new IFlowTextConfigT();
			this.UnPackTo(flowTextConfigT);
			return flowTextConfigT;
		}

		// Token: 0x0602E80F RID: 190479 RVA: 0x006588B0 File Offset: 0x00656AB0
		public void UnPackTo(IFlowTextConfigT _o)
		{
			_o.Text = this.Text;
			_o.PlotLineKey = this.PlotLineKey;
			_o.StringKey = this.StringKey;
			_o.FlowListId = this.FlowListId;
			_o.IsNoPlotText = this.IsNoPlotText;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E810 RID: 190480 RVA: 0x00658908 File Offset: 0x00656B08
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

		// Token: 0x04010F73 RID: 69491
		private Table __p;
	}
}
