using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D3 RID: 28883
	public struct ILimitPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700D392 RID: 54162
		// (get) Token: 0x06032281 RID: 205441 RVA: 0x006C93B8 File Offset: 0x006C75B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032282 RID: 205442 RVA: 0x006C93C5 File Offset: 0x006C75C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032283 RID: 205443 RVA: 0x006C93CC File Offset: 0x006C75CC
		public static ILimitPlayerOperation GetRootAsILimitPlayerOperation(ByteBuffer _bb)
		{
			return ILimitPlayerOperation.GetRootAsILimitPlayerOperation(_bb, default(ILimitPlayerOperation));
		}

		// Token: 0x06032284 RID: 205444 RVA: 0x006C93E8 File Offset: 0x006C75E8
		public static ILimitPlayerOperation GetRootAsILimitPlayerOperation(ByteBuffer _bb, ILimitPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032285 RID: 205445 RVA: 0x006C9405 File Offset: 0x006C7605
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032286 RID: 205446 RVA: 0x006C9414 File Offset: 0x006C7614
		public ILimitPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D393 RID: 54163
		// (get) Token: 0x06032287 RID: 205447 RVA: 0x006C9424 File Offset: 0x006C7624
		public TLimitPlayOperation TypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TLimitPlayOperation.NONE;
				}
				return (TLimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032288 RID: 205448 RVA: 0x006C9460 File Offset: 0x006C7660
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032289 RID: 205449 RVA: 0x006C94A4 File Offset: 0x006C76A4
		public ILimitPlayerAction TypeAsILimitPlayerAction()
		{
			return this.Type<ILimitPlayerAction>().Value;
		}

		// Token: 0x0603228A RID: 205450 RVA: 0x006C94C0 File Offset: 0x006C76C0
		public ILimitPlayerBlockAll TypeAsILimitPlayerBlockAll()
		{
			return this.Type<ILimitPlayerBlockAll>().Value;
		}

		// Token: 0x0603228B RID: 205451 RVA: 0x006C94DC File Offset: 0x006C76DC
		public ILimitPlayerCamera TypeAsILimitPlayerCamera()
		{
			return this.Type<ILimitPlayerCamera>().Value;
		}

		// Token: 0x0603228C RID: 205452 RVA: 0x006C94F8 File Offset: 0x006C76F8
		public ILimitPlayerMouse TypeAsILimitPlayerMouse()
		{
			return this.Type<ILimitPlayerMouse>().Value;
		}

		// Token: 0x0603228D RID: 205453 RVA: 0x006C9514 File Offset: 0x006C7714
		public ILimitPlayerMove TypeAsILimitPlayerMove()
		{
			return this.Type<ILimitPlayerMove>().Value;
		}

		// Token: 0x0603228E RID: 205454 RVA: 0x006C9530 File Offset: 0x006C7730
		public ILimitPlayerMoveNew TypeAsILimitPlayerMoveNew()
		{
			return this.Type<ILimitPlayerMoveNew>().Value;
		}

		// Token: 0x0603228F RID: 205455 RVA: 0x006C954C File Offset: 0x006C774C
		public ILimitPlayerUI TypeAsILimitPlayerUI()
		{
			return this.Type<ILimitPlayerUI>().Value;
		}

		// Token: 0x06032290 RID: 205456 RVA: 0x006C9567 File Offset: 0x006C7767
		public static Offset<ILimitPlayerOperation> CreateILimitPlayerOperation(FlatBufferBuilder builder, TLimitPlayOperation Type_type = TLimitPlayOperation.NONE, int TypeOffset = 0)
		{
			builder.StartTable(2);
			ILimitPlayerOperation.AddType(builder, TypeOffset);
			ILimitPlayerOperation.AddTypeType(builder, Type_type);
			return ILimitPlayerOperation.EndILimitPlayerOperation(builder);
		}

		// Token: 0x06032291 RID: 205457 RVA: 0x006C9584 File Offset: 0x006C7784
		public static void StartILimitPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032292 RID: 205458 RVA: 0x006C958D File Offset: 0x006C778D
		public static void AddTypeType(FlatBufferBuilder builder, TLimitPlayOperation typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x06032293 RID: 205459 RVA: 0x006C9598 File Offset: 0x006C7798
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x06032294 RID: 205460 RVA: 0x006C95A3 File Offset: 0x006C77A3
		public static Offset<ILimitPlayerOperation> EndILimitPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerOperation>(builder.EndTable());
		}

		// Token: 0x06032295 RID: 205461 RVA: 0x006C95B0 File Offset: 0x006C77B0
		public ILimitPlayerOperationT UnPack()
		{
			ILimitPlayerOperationT limitPlayerOperationT = new ILimitPlayerOperationT();
			this.UnPackTo(limitPlayerOperationT);
			return limitPlayerOperationT;
		}

		// Token: 0x06032296 RID: 205462 RVA: 0x006C95CC File Offset: 0x006C77CC
		public void UnPackTo(ILimitPlayerOperationT _o)
		{
			_o.Type = new TLimitPlayOperationUnion();
			_o.Type.Type = this.TypeType;
			switch (this.TypeType)
			{
			case TLimitPlayOperation.ILimitPlayerAction:
				_o.Type.Value = ((this.Type<ILimitPlayerAction>() != null) ? this.Type<ILimitPlayerAction>().Value.UnPack() : null);
				return;
			case TLimitPlayOperation.ILimitPlayerBlockAll:
				_o.Type.Value = ((this.Type<ILimitPlayerBlockAll>() != null) ? this.Type<ILimitPlayerBlockAll>().Value.UnPack() : null);
				return;
			case TLimitPlayOperation.ILimitPlayerCamera:
				_o.Type.Value = ((this.Type<ILimitPlayerCamera>() != null) ? this.Type<ILimitPlayerCamera>().Value.UnPack() : null);
				return;
			case TLimitPlayOperation.ILimitPlayerMouse:
				_o.Type.Value = ((this.Type<ILimitPlayerMouse>() != null) ? this.Type<ILimitPlayerMouse>().Value.UnPack() : null);
				return;
			case TLimitPlayOperation.ILimitPlayerMove:
				_o.Type.Value = ((this.Type<ILimitPlayerMove>() != null) ? this.Type<ILimitPlayerMove>().Value.UnPack() : null);
				return;
			case TLimitPlayOperation.ILimitPlayerMoveNew:
				_o.Type.Value = ((this.Type<ILimitPlayerMoveNew>() != null) ? this.Type<ILimitPlayerMoveNew>().Value.UnPack() : null);
				return;
			case TLimitPlayOperation.ILimitPlayerUI:
				_o.Type.Value = ((this.Type<ILimitPlayerUI>() != null) ? this.Type<ILimitPlayerUI>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06032297 RID: 205463 RVA: 0x006C97A4 File Offset: 0x006C79A4
		public static Offset<ILimitPlayerOperation> Pack(FlatBufferBuilder builder, ILimitPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerOperation>);
			}
			TLimitPlayOperation type_type = (_o.Type == null) ? TLimitPlayOperation.NONE : _o.Type.Type;
			int typeOffset = (_o.Type == null) ? 0 : TLimitPlayOperationUnion.Pack(builder, _o.Type);
			return ILimitPlayerOperation.CreateILimitPlayerOperation(builder, type_type, typeOffset);
		}

		// Token: 0x04012095 RID: 73877
		private Table __p;
	}
}
