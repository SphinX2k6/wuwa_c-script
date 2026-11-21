using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007127 RID: 28967
	public struct ILiveSetDanmaku : IFlatbufferObject
	{
		// Token: 0x1700D41D RID: 54301
		// (get) Token: 0x0603251B RID: 206107 RVA: 0x006CDA98 File Offset: 0x006CBC98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603251C RID: 206108 RVA: 0x006CDAA5 File Offset: 0x006CBCA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603251D RID: 206109 RVA: 0x006CDAAC File Offset: 0x006CBCAC
		public static ILiveSetDanmaku GetRootAsILiveSetDanmaku(ByteBuffer _bb)
		{
			return ILiveSetDanmaku.GetRootAsILiveSetDanmaku(_bb, default(ILiveSetDanmaku));
		}

		// Token: 0x0603251E RID: 206110 RVA: 0x006CDAC8 File Offset: 0x006CBCC8
		public static ILiveSetDanmaku GetRootAsILiveSetDanmaku(ByteBuffer _bb, ILiveSetDanmaku obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603251F RID: 206111 RVA: 0x006CDAE5 File Offset: 0x006CBCE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032520 RID: 206112 RVA: 0x006CDAF4 File Offset: 0x006CBCF4
		public ILiveSetDanmaku __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D41E RID: 54302
		// (get) Token: 0x06032521 RID: 206113 RVA: 0x006CDB04 File Offset: 0x006CBD04
		public TLiveDanmakuOperation OperationType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TLiveDanmakuOperation.NONE;
				}
				return (TLiveDanmakuOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032522 RID: 206114 RVA: 0x006CDB40 File Offset: 0x006CBD40
		public TTable? Operation<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032523 RID: 206115 RVA: 0x006CDB84 File Offset: 0x006CBD84
		public ILiveLoadDanmakuConfig OperationAsILiveLoadDanmakuConfig()
		{
			return this.Operation<ILiveLoadDanmakuConfig>().Value;
		}

		// Token: 0x06032524 RID: 206116 RVA: 0x006CDBA0 File Offset: 0x006CBDA0
		public ILiveStartInteractDanmakuConfig OperationAsILiveStartInteractDanmakuConfig()
		{
			return this.Operation<ILiveStartInteractDanmakuConfig>().Value;
		}

		// Token: 0x06032525 RID: 206117 RVA: 0x006CDBBC File Offset: 0x006CBDBC
		public ILiveStopInteractDanmakuConfig OperationAsILiveStopInteractDanmakuConfig()
		{
			return this.Operation<ILiveStopInteractDanmakuConfig>().Value;
		}

		// Token: 0x06032526 RID: 206118 RVA: 0x006CDBD8 File Offset: 0x006CBDD8
		public ILiveUnloadDanmakuConfig OperationAsILiveUnloadDanmakuConfig()
		{
			return this.Operation<ILiveUnloadDanmakuConfig>().Value;
		}

		// Token: 0x06032527 RID: 206119 RVA: 0x006CDBF3 File Offset: 0x006CBDF3
		public static Offset<ILiveSetDanmaku> CreateILiveSetDanmaku(FlatBufferBuilder builder, TLiveDanmakuOperation Operation_type = TLiveDanmakuOperation.NONE, int OperationOffset = 0)
		{
			builder.StartTable(2);
			ILiveSetDanmaku.AddOperation(builder, OperationOffset);
			ILiveSetDanmaku.AddOperationType(builder, Operation_type);
			return ILiveSetDanmaku.EndILiveSetDanmaku(builder);
		}

		// Token: 0x06032528 RID: 206120 RVA: 0x006CDC10 File Offset: 0x006CBE10
		public static void StartILiveSetDanmaku(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032529 RID: 206121 RVA: 0x006CDC19 File Offset: 0x006CBE19
		public static void AddOperationType(FlatBufferBuilder builder, TLiveDanmakuOperation operationType)
		{
			builder.AddByte(0, (byte)operationType, 0);
		}

		// Token: 0x0603252A RID: 206122 RVA: 0x006CDC24 File Offset: 0x006CBE24
		public static void AddOperation(FlatBufferBuilder builder, int operationOffset)
		{
			builder.AddOffset(1, operationOffset, 0);
		}

		// Token: 0x0603252B RID: 206123 RVA: 0x006CDC2F File Offset: 0x006CBE2F
		public static Offset<ILiveSetDanmaku> EndILiveSetDanmaku(FlatBufferBuilder builder)
		{
			return new Offset<ILiveSetDanmaku>(builder.EndTable());
		}

		// Token: 0x0603252C RID: 206124 RVA: 0x006CDC3C File Offset: 0x006CBE3C
		public ILiveSetDanmakuT UnPack()
		{
			ILiveSetDanmakuT liveSetDanmakuT = new ILiveSetDanmakuT();
			this.UnPackTo(liveSetDanmakuT);
			return liveSetDanmakuT;
		}

		// Token: 0x0603252D RID: 206125 RVA: 0x006CDC58 File Offset: 0x006CBE58
		public void UnPackTo(ILiveSetDanmakuT _o)
		{
			_o.Operation = new TLiveDanmakuOperationUnion();
			_o.Operation.Type = this.OperationType;
			switch (this.OperationType)
			{
			case TLiveDanmakuOperation.ILiveLoadDanmakuConfig:
				_o.Operation.Value = ((this.Operation<ILiveLoadDanmakuConfig>() != null) ? this.Operation<ILiveLoadDanmakuConfig>().Value.UnPack() : null);
				return;
			case TLiveDanmakuOperation.ILiveStartInteractDanmakuConfig:
				_o.Operation.Value = ((this.Operation<ILiveStartInteractDanmakuConfig>() != null) ? this.Operation<ILiveStartInteractDanmakuConfig>().Value.UnPack() : null);
				return;
			case TLiveDanmakuOperation.ILiveStopInteractDanmakuConfig:
				_o.Operation.Value = ((this.Operation<ILiveStopInteractDanmakuConfig>() != null) ? this.Operation<ILiveStopInteractDanmakuConfig>().Value.UnPack() : null);
				return;
			case TLiveDanmakuOperation.ILiveUnloadDanmakuConfig:
				_o.Operation.Value = ((this.Operation<ILiveUnloadDanmakuConfig>() != null) ? this.Operation<ILiveUnloadDanmakuConfig>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603252E RID: 206126 RVA: 0x006CDD7C File Offset: 0x006CBF7C
		public static Offset<ILiveSetDanmaku> Pack(FlatBufferBuilder builder, ILiveSetDanmakuT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveSetDanmaku>);
			}
			TLiveDanmakuOperation operation_type = (_o.Operation == null) ? TLiveDanmakuOperation.NONE : _o.Operation.Type;
			int operationOffset = (_o.Operation == null) ? 0 : TLiveDanmakuOperationUnion.Pack(builder, _o.Operation);
			return ILiveSetDanmaku.CreateILiveSetDanmaku(builder, operation_type, operationOffset);
		}

		// Token: 0x0401210F RID: 73999
		private Table __p;
	}
}
