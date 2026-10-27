using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FAA RID: 16298
	public struct IPlotHandBookNode : IFlatbufferObject
	{
		// Token: 0x170071CB RID: 29131
		// (get) Token: 0x060174AC RID: 95404 RVA: 0x0035BBA4 File Offset: 0x00359DA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060174AD RID: 95405 RVA: 0x0035BBB1 File Offset: 0x00359DB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060174AE RID: 95406 RVA: 0x0035BBB8 File Offset: 0x00359DB8
		public static IPlotHandBookNode GetRootAsIPlotHandBookNode(ByteBuffer _bb)
		{
			return IPlotHandBookNode.GetRootAsIPlotHandBookNode(_bb, default(IPlotHandBookNode));
		}

		// Token: 0x060174AF RID: 95407 RVA: 0x0035BBD4 File Offset: 0x00359DD4
		public static IPlotHandBookNode GetRootAsIPlotHandBookNode(ByteBuffer _bb, IPlotHandBookNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060174B0 RID: 95408 RVA: 0x0035BBF1 File Offset: 0x00359DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060174B1 RID: 95409 RVA: 0x0035BC00 File Offset: 0x00359E00
		public IPlotHandBookNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071CC RID: 29132
		// (get) Token: 0x060174B2 RID: 95410 RVA: 0x0035BC10 File Offset: 0x00359E10
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

		// Token: 0x060174B3 RID: 95411 RVA: 0x0035BC47 File Offset: 0x00359E47
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060174B4 RID: 95412 RVA: 0x0035BC56 File Offset: 0x00359E56
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170071CD RID: 29133
		// (get) Token: 0x060174B5 RID: 95413 RVA: 0x0035BC64 File Offset: 0x00359E64
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

		// Token: 0x170071CE RID: 29134
		// (get) Token: 0x060174B6 RID: 95414 RVA: 0x0035BCC4 File Offset: 0x00359EC4
		public bool IsHideUi
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060174B7 RID: 95415 RVA: 0x0035BD03 File Offset: 0x00359F03
		public static Offset<IPlotHandBookNode> CreateIPlotHandBookNode(FlatBufferBuilder builder, StringOffset TidTipOffset = default(StringOffset), Offset<IFlowStateIndex> FlowOffset = default(Offset<IFlowStateIndex>), bool IsHideUi = false)
		{
			builder.StartTable(3);
			IPlotHandBookNode.AddFlow(builder, FlowOffset);
			IPlotHandBookNode.AddTidTip(builder, TidTipOffset);
			IPlotHandBookNode.AddIsHideUi(builder, IsHideUi);
			return IPlotHandBookNode.EndIPlotHandBookNode(builder);
		}

		// Token: 0x060174B8 RID: 95416 RVA: 0x0035BD27 File Offset: 0x00359F27
		public static void StartIPlotHandBookNode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060174B9 RID: 95417 RVA: 0x0035BD30 File Offset: 0x00359F30
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x060174BA RID: 95418 RVA: 0x0035BD40 File Offset: 0x00359F40
		public static void AddFlow(FlatBufferBuilder builder, Offset<IFlowStateIndex> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x060174BB RID: 95419 RVA: 0x0035BD50 File Offset: 0x00359F50
		public static void AddIsHideUi(FlatBufferBuilder builder, bool isHideUi)
		{
			builder.AddBool(2, isHideUi, false);
		}

		// Token: 0x060174BC RID: 95420 RVA: 0x0035BD5B File Offset: 0x00359F5B
		public static Offset<IPlotHandBookNode> EndIPlotHandBookNode(FlatBufferBuilder builder)
		{
			return new Offset<IPlotHandBookNode>(builder.EndTable());
		}

		// Token: 0x060174BD RID: 95421 RVA: 0x0035BD68 File Offset: 0x00359F68
		public IPlotHandBookNodeT UnPack()
		{
			IPlotHandBookNodeT plotHandBookNodeT = new IPlotHandBookNodeT();
			this.UnPackTo(plotHandBookNodeT);
			return plotHandBookNodeT;
		}

		// Token: 0x060174BE RID: 95422 RVA: 0x0035BD84 File Offset: 0x00359F84
		public void UnPackTo(IPlotHandBookNodeT _o)
		{
			_o.TidTip = this.TidTip;
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.IsHideUi = this.IsHideUi;
		}

		// Token: 0x060174BF RID: 95423 RVA: 0x0035BDD8 File Offset: 0x00359FD8
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

		// Token: 0x0400BA12 RID: 47634
		private Table __p;
	}
}
