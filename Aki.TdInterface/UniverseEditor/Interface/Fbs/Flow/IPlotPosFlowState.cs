using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004745 RID: 18245
	public struct IPlotPosFlowState : IFlatbufferObject
	{
		// Token: 0x170082E9 RID: 33513
		// (get) Token: 0x0601C139 RID: 115001 RVA: 0x003FA617 File Offset: 0x003F8817
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C13A RID: 115002 RVA: 0x003FA624 File Offset: 0x003F8824
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C13B RID: 115003 RVA: 0x003FA62C File Offset: 0x003F882C
		public static IPlotPosFlowState GetRootAsIPlotPosFlowState(ByteBuffer _bb)
		{
			return IPlotPosFlowState.GetRootAsIPlotPosFlowState(_bb, default(IPlotPosFlowState));
		}

		// Token: 0x0601C13C RID: 115004 RVA: 0x003FA648 File Offset: 0x003F8848
		public static IPlotPosFlowState GetRootAsIPlotPosFlowState(ByteBuffer _bb, IPlotPosFlowState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C13D RID: 115005 RVA: 0x003FA665 File Offset: 0x003F8865
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C13E RID: 115006 RVA: 0x003FA674 File Offset: 0x003F8874
		public IPlotPosFlowState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082EA RID: 33514
		// (get) Token: 0x0601C13F RID: 115007 RVA: 0x003FA684 File Offset: 0x003F8884
		public IFlowStateIndex? Flow
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFlowStateIndex?(default(IFlowStateIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170082EB RID: 33515
		// (get) Token: 0x0601C140 RID: 115008 RVA: 0x003FA6E4 File Offset: 0x003F88E4
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601C141 RID: 115009 RVA: 0x003FA741 File Offset: 0x003F8941
		public static Offset<IPlotPosFlowState> CreateIPlotPosFlowState(FlatBufferBuilder builder, Offset<IFlowStateIndex> FlowOffset = default(Offset<IFlowStateIndex>), Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPlotPosFlowState.AddPos(builder, PosOffset);
			IPlotPosFlowState.AddFlow(builder, FlowOffset);
			return IPlotPosFlowState.EndIPlotPosFlowState(builder);
		}

		// Token: 0x0601C142 RID: 115010 RVA: 0x003FA75E File Offset: 0x003F895E
		public static void StartIPlotPosFlowState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C143 RID: 115011 RVA: 0x003FA767 File Offset: 0x003F8967
		public static void AddFlow(FlatBufferBuilder builder, Offset<IFlowStateIndex> flowOffset)
		{
			builder.AddOffset(0, flowOffset.Value, 0);
		}

		// Token: 0x0601C144 RID: 115012 RVA: 0x003FA777 File Offset: 0x003F8977
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601C145 RID: 115013 RVA: 0x003FA787 File Offset: 0x003F8987
		public static Offset<IPlotPosFlowState> EndIPlotPosFlowState(FlatBufferBuilder builder)
		{
			return new Offset<IPlotPosFlowState>(builder.EndTable());
		}

		// Token: 0x0601C146 RID: 115014 RVA: 0x003FA794 File Offset: 0x003F8994
		public IPlotPosFlowStateT UnPack()
		{
			IPlotPosFlowStateT plotPosFlowStateT = new IPlotPosFlowStateT();
			this.UnPackTo(plotPosFlowStateT);
			return plotPosFlowStateT;
		}

		// Token: 0x0601C147 RID: 115015 RVA: 0x003FA7B0 File Offset: 0x003F89B0
		public void UnPackTo(IPlotPosFlowStateT _o)
		{
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0601C148 RID: 115016 RVA: 0x003FA81C File Offset: 0x003F8A1C
		public static Offset<IPlotPosFlowState> Pack(FlatBufferBuilder builder, IPlotPosFlowStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotPosFlowState>);
			}
			Offset<IFlowStateIndex> flowOffset = (_o.Flow == null) ? default(Offset<IFlowStateIndex>) : IFlowStateIndex.Pack(builder, _o.Flow);
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IPlotPosFlowState.CreateIPlotPosFlowState(builder, flowOffset, posOffset);
		}

		// Token: 0x0400CA33 RID: 51763
		private Table __p;
	}
}
