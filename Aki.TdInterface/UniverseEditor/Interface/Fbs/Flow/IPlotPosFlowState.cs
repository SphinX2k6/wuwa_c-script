using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BAD RID: 19373
	public struct IPlotPosFlowState : IFlatbufferObject
	{
		// Token: 0x1700892A RID: 35114
		// (get) Token: 0x0601D90E RID: 121102 RVA: 0x004268B3 File Offset: 0x00424AB3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D90F RID: 121103 RVA: 0x004268C0 File Offset: 0x00424AC0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D910 RID: 121104 RVA: 0x004268C8 File Offset: 0x00424AC8
		public static IPlotPosFlowState GetRootAsIPlotPosFlowState(ByteBuffer _bb)
		{
			return IPlotPosFlowState.GetRootAsIPlotPosFlowState(_bb, default(IPlotPosFlowState));
		}

		// Token: 0x0601D911 RID: 121105 RVA: 0x004268E4 File Offset: 0x00424AE4
		public static IPlotPosFlowState GetRootAsIPlotPosFlowState(ByteBuffer _bb, IPlotPosFlowState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D912 RID: 121106 RVA: 0x00426901 File Offset: 0x00424B01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D913 RID: 121107 RVA: 0x00426910 File Offset: 0x00424B10
		public IPlotPosFlowState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700892B RID: 35115
		// (get) Token: 0x0601D914 RID: 121108 RVA: 0x00426920 File Offset: 0x00424B20
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

		// Token: 0x1700892C RID: 35116
		// (get) Token: 0x0601D915 RID: 121109 RVA: 0x00426980 File Offset: 0x00424B80
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

		// Token: 0x0601D916 RID: 121110 RVA: 0x004269DD File Offset: 0x00424BDD
		public static Offset<IPlotPosFlowState> CreateIPlotPosFlowState(FlatBufferBuilder builder, Offset<IFlowStateIndex> FlowOffset = default(Offset<IFlowStateIndex>), Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPlotPosFlowState.AddPos(builder, PosOffset);
			IPlotPosFlowState.AddFlow(builder, FlowOffset);
			return IPlotPosFlowState.EndIPlotPosFlowState(builder);
		}

		// Token: 0x0601D917 RID: 121111 RVA: 0x004269FA File Offset: 0x00424BFA
		public static void StartIPlotPosFlowState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D918 RID: 121112 RVA: 0x00426A03 File Offset: 0x00424C03
		public static void AddFlow(FlatBufferBuilder builder, Offset<IFlowStateIndex> flowOffset)
		{
			builder.AddOffset(0, flowOffset.Value, 0);
		}

		// Token: 0x0601D919 RID: 121113 RVA: 0x00426A13 File Offset: 0x00424C13
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601D91A RID: 121114 RVA: 0x00426A23 File Offset: 0x00424C23
		public static Offset<IPlotPosFlowState> EndIPlotPosFlowState(FlatBufferBuilder builder)
		{
			return new Offset<IPlotPosFlowState>(builder.EndTable());
		}

		// Token: 0x0601D91B RID: 121115 RVA: 0x00426A30 File Offset: 0x00424C30
		public IPlotPosFlowStateT UnPack()
		{
			IPlotPosFlowStateT plotPosFlowStateT = new IPlotPosFlowStateT();
			this.UnPackTo(plotPosFlowStateT);
			return plotPosFlowStateT;
		}

		// Token: 0x0601D91C RID: 121116 RVA: 0x00426A4C File Offset: 0x00424C4C
		public void UnPackTo(IPlotPosFlowStateT _o)
		{
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0601D91D RID: 121117 RVA: 0x00426AB8 File Offset: 0x00424CB8
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

		// Token: 0x0400D462 RID: 54370
		private Table __p;
	}
}
