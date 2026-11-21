using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712D RID: 28973
	public struct ILiveSetSc : IFlatbufferObject
	{
		// Token: 0x1700D423 RID: 54307
		// (get) Token: 0x0603254C RID: 206156 RVA: 0x006CE24D File Offset: 0x006CC44D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603254D RID: 206157 RVA: 0x006CE25A File Offset: 0x006CC45A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603254E RID: 206158 RVA: 0x006CE264 File Offset: 0x006CC464
		public static ILiveSetSc GetRootAsILiveSetSc(ByteBuffer _bb)
		{
			return ILiveSetSc.GetRootAsILiveSetSc(_bb, default(ILiveSetSc));
		}

		// Token: 0x0603254F RID: 206159 RVA: 0x006CE280 File Offset: 0x006CC480
		public static ILiveSetSc GetRootAsILiveSetSc(ByteBuffer _bb, ILiveSetSc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032550 RID: 206160 RVA: 0x006CE29D File Offset: 0x006CC49D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032551 RID: 206161 RVA: 0x006CE2AC File Offset: 0x006CC4AC
		public ILiveSetSc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D424 RID: 54308
		// (get) Token: 0x06032552 RID: 206162 RVA: 0x006CE2BC File Offset: 0x006CC4BC
		public TLiveScOperation OperationType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TLiveScOperation.NONE;
				}
				return (TLiveScOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032553 RID: 206163 RVA: 0x006CE2F8 File Offset: 0x006CC4F8
		public TTable? Operation<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032554 RID: 206164 RVA: 0x006CE33C File Offset: 0x006CC53C
		public ILiveClearScConfig OperationAsILiveClearScConfig()
		{
			return this.Operation<ILiveClearScConfig>().Value;
		}

		// Token: 0x06032555 RID: 206165 RVA: 0x006CE358 File Offset: 0x006CC558
		public ILiveSendScConfig OperationAsILiveSendScConfig()
		{
			return this.Operation<ILiveSendScConfig>().Value;
		}

		// Token: 0x06032556 RID: 206166 RVA: 0x006CE373 File Offset: 0x006CC573
		public static Offset<ILiveSetSc> CreateILiveSetSc(FlatBufferBuilder builder, TLiveScOperation Operation_type = TLiveScOperation.NONE, int OperationOffset = 0)
		{
			builder.StartTable(2);
			ILiveSetSc.AddOperation(builder, OperationOffset);
			ILiveSetSc.AddOperationType(builder, Operation_type);
			return ILiveSetSc.EndILiveSetSc(builder);
		}

		// Token: 0x06032557 RID: 206167 RVA: 0x006CE390 File Offset: 0x006CC590
		public static void StartILiveSetSc(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032558 RID: 206168 RVA: 0x006CE399 File Offset: 0x006CC599
		public static void AddOperationType(FlatBufferBuilder builder, TLiveScOperation operationType)
		{
			builder.AddByte(0, (byte)operationType, 0);
		}

		// Token: 0x06032559 RID: 206169 RVA: 0x006CE3A4 File Offset: 0x006CC5A4
		public static void AddOperation(FlatBufferBuilder builder, int operationOffset)
		{
			builder.AddOffset(1, operationOffset, 0);
		}

		// Token: 0x0603255A RID: 206170 RVA: 0x006CE3AF File Offset: 0x006CC5AF
		public static Offset<ILiveSetSc> EndILiveSetSc(FlatBufferBuilder builder)
		{
			return new Offset<ILiveSetSc>(builder.EndTable());
		}

		// Token: 0x0603255B RID: 206171 RVA: 0x006CE3BC File Offset: 0x006CC5BC
		public ILiveSetScT UnPack()
		{
			ILiveSetScT liveSetScT = new ILiveSetScT();
			this.UnPackTo(liveSetScT);
			return liveSetScT;
		}

		// Token: 0x0603255C RID: 206172 RVA: 0x006CE3D8 File Offset: 0x006CC5D8
		public void UnPackTo(ILiveSetScT _o)
		{
			_o.Operation = new TLiveScOperationUnion();
			_o.Operation.Type = this.OperationType;
			TLiveScOperation operationType = this.OperationType;
			if (operationType == TLiveScOperation.ILiveClearScConfig)
			{
				_o.Operation.Value = ((this.Operation<ILiveClearScConfig>() != null) ? this.Operation<ILiveClearScConfig>().Value.UnPack() : null);
				return;
			}
			if (operationType != TLiveScOperation.ILiveSendScConfig)
			{
				return;
			}
			_o.Operation.Value = ((this.Operation<ILiveSendScConfig>() != null) ? this.Operation<ILiveSendScConfig>().Value.UnPack() : null);
		}

		// Token: 0x0603255D RID: 206173 RVA: 0x006CE47C File Offset: 0x006CC67C
		public static Offset<ILiveSetSc> Pack(FlatBufferBuilder builder, ILiveSetScT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveSetSc>);
			}
			TLiveScOperation operation_type = (_o.Operation == null) ? TLiveScOperation.NONE : _o.Operation.Type;
			int operationOffset = (_o.Operation == null) ? 0 : TLiveScOperationUnion.Pack(builder, _o.Operation);
			return ILiveSetSc.CreateILiveSetSc(builder, operation_type, operationOffset);
		}

		// Token: 0x04012113 RID: 74003
		private Table __p;
	}
}
