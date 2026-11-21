using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043EB RID: 17387
	public struct IPlotHandBookNode : IFlatbufferObject
	{
		// Token: 0x170077C9 RID: 30665
		// (get) Token: 0x06018B3B RID: 101179 RVA: 0x003857BC File Offset: 0x003839BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B3C RID: 101180 RVA: 0x003857C9 File Offset: 0x003839C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B3D RID: 101181 RVA: 0x003857D0 File Offset: 0x003839D0
		public static IPlotHandBookNode GetRootAsIPlotHandBookNode(ByteBuffer _bb)
		{
			return IPlotHandBookNode.GetRootAsIPlotHandBookNode(_bb, default(IPlotHandBookNode));
		}

		// Token: 0x06018B3E RID: 101182 RVA: 0x003857EC File Offset: 0x003839EC
		public static IPlotHandBookNode GetRootAsIPlotHandBookNode(ByteBuffer _bb, IPlotHandBookNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B3F RID: 101183 RVA: 0x00385809 File Offset: 0x00383A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B40 RID: 101184 RVA: 0x00385818 File Offset: 0x00383A18
		public IPlotHandBookNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077CA RID: 30666
		// (get) Token: 0x06018B41 RID: 101185 RVA: 0x00385828 File Offset: 0x00383A28
		public string TidTip
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

		// Token: 0x06018B42 RID: 101186 RVA: 0x0038585F File Offset: 0x00383A5F
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018B43 RID: 101187 RVA: 0x0038586E File Offset: 0x00383A6E
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170077CB RID: 30667
		// (get) Token: 0x06018B44 RID: 101188 RVA: 0x0038587C File Offset: 0x00383A7C
		public IFlowStateIndex? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFlowStateIndex?(default(IFlowStateIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077CC RID: 30668
		// (get) Token: 0x06018B45 RID: 101189 RVA: 0x003858DC File Offset: 0x00383ADC
		public bool IsHideUi
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06018B46 RID: 101190 RVA: 0x0038591B File Offset: 0x00383B1B
		public static Offset<IPlotHandBookNode> CreateIPlotHandBookNode(FlatBufferBuilder builder, StringOffset TidTipOffset = default(StringOffset), Offset<IFlowStateIndex> FlowOffset = default(Offset<IFlowStateIndex>), bool IsHideUi = false)
		{
			builder.StartTable(3);
			IPlotHandBookNode.AddFlow(builder, FlowOffset);
			IPlotHandBookNode.AddTidTip(builder, TidTipOffset);
			IPlotHandBookNode.AddIsHideUi(builder, IsHideUi);
			return IPlotHandBookNode.EndIPlotHandBookNode(builder);
		}

		// Token: 0x06018B47 RID: 101191 RVA: 0x0038593F File Offset: 0x00383B3F
		public static void StartIPlotHandBookNode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018B48 RID: 101192 RVA: 0x00385948 File Offset: 0x00383B48
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x06018B49 RID: 101193 RVA: 0x00385958 File Offset: 0x00383B58
		public static void AddFlow(FlatBufferBuilder builder, Offset<IFlowStateIndex> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06018B4A RID: 101194 RVA: 0x00385968 File Offset: 0x00383B68
		public static void AddIsHideUi(FlatBufferBuilder builder, bool isHideUi)
		{
			builder.AddBool(2, isHideUi, false);
		}

		// Token: 0x06018B4B RID: 101195 RVA: 0x00385973 File Offset: 0x00383B73
		public static Offset<IPlotHandBookNode> EndIPlotHandBookNode(FlatBufferBuilder builder)
		{
			return new Offset<IPlotHandBookNode>(builder.EndTable());
		}

		// Token: 0x06018B4C RID: 101196 RVA: 0x00385980 File Offset: 0x00383B80
		public IPlotHandBookNodeT UnPack()
		{
			IPlotHandBookNodeT plotHandBookNodeT = new IPlotHandBookNodeT();
			this.UnPackTo(plotHandBookNodeT);
			return plotHandBookNodeT;
		}

		// Token: 0x06018B4D RID: 101197 RVA: 0x0038599C File Offset: 0x00383B9C
		public void UnPackTo(IPlotHandBookNodeT _o)
		{
			_o.TidTip = this.TidTip;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.IsHideUi = this.IsHideUi;
		}

		// Token: 0x06018B4E RID: 101198 RVA: 0x003859F0 File Offset: 0x00383BF0
		public static Offset<IPlotHandBookNode> Pack(FlatBufferBuilder builder, IPlotHandBookNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotHandBookNode>);
			}
			StringOffset tidTipOffset = (_o.TidTip == null) ? default(StringOffset) : builder.CreateString(_o.TidTip);
			Offset<IFlowStateIndex> flowOffset = (_o.Flow == null) ? default(Offset<IFlowStateIndex>) : IFlowStateIndex.Pack(builder, _o.Flow);
			return IPlotHandBookNode.CreateIPlotHandBookNode(builder, tidTipOffset, flowOffset, _o.IsHideUi);
		}

		// Token: 0x0400C3F7 RID: 50167
		private Table __p;
	}
}
