using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A23 RID: 27171
	public struct ILimitPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700C992 RID: 51602
		// (get) Token: 0x0602F8C1 RID: 194753 RVA: 0x00679060 File Offset: 0x00677260
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F8C2 RID: 194754 RVA: 0x0067906D File Offset: 0x0067726D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F8C3 RID: 194755 RVA: 0x00679074 File Offset: 0x00677274
		public static ILimitPlayerOperation GetRootAsILimitPlayerOperation(ByteBuffer _bb)
		{
			return ILimitPlayerOperation.GetRootAsILimitPlayerOperation(_bb, default(ILimitPlayerOperation));
		}

		// Token: 0x0602F8C4 RID: 194756 RVA: 0x00679090 File Offset: 0x00677290
		public static ILimitPlayerOperation GetRootAsILimitPlayerOperation(ByteBuffer _bb, ILimitPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F8C5 RID: 194757 RVA: 0x006790AD File Offset: 0x006772AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F8C6 RID: 194758 RVA: 0x006790BC File Offset: 0x006772BC
		public ILimitPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C993 RID: 51603
		// (get) Token: 0x0602F8C7 RID: 194759 RVA: 0x006790CC File Offset: 0x006772CC
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

		// Token: 0x0602F8C8 RID: 194760 RVA: 0x00679108 File Offset: 0x00677308
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F8C9 RID: 194761 RVA: 0x0067914C File Offset: 0x0067734C
		public ILimitPlayerAction TypeAsILimitPlayerAction()
		{
			return this.Type<ILimitPlayerAction>().Value;
		}

		// Token: 0x0602F8CA RID: 194762 RVA: 0x00679168 File Offset: 0x00677368
		public ILimitPlayerBlockAll TypeAsILimitPlayerBlockAll()
		{
			return this.Type<ILimitPlayerBlockAll>().Value;
		}

		// Token: 0x0602F8CB RID: 194763 RVA: 0x00679184 File Offset: 0x00677384
		public ILimitPlayerCamera TypeAsILimitPlayerCamera()
		{
			return this.Type<ILimitPlayerCamera>().Value;
		}

		// Token: 0x0602F8CC RID: 194764 RVA: 0x006791A0 File Offset: 0x006773A0
		public ILimitPlayerMouse TypeAsILimitPlayerMouse()
		{
			return this.Type<ILimitPlayerMouse>().Value;
		}

		// Token: 0x0602F8CD RID: 194765 RVA: 0x006791BC File Offset: 0x006773BC
		public ILimitPlayerMove TypeAsILimitPlayerMove()
		{
			return this.Type<ILimitPlayerMove>().Value;
		}

		// Token: 0x0602F8CE RID: 194766 RVA: 0x006791D8 File Offset: 0x006773D8
		public ILimitPlayerMoveNew TypeAsILimitPlayerMoveNew()
		{
			return this.Type<ILimitPlayerMoveNew>().Value;
		}

		// Token: 0x0602F8CF RID: 194767 RVA: 0x006791F4 File Offset: 0x006773F4
		public ILimitPlayerUI TypeAsILimitPlayerUI()
		{
			return this.Type<ILimitPlayerUI>().Value;
		}

		// Token: 0x0602F8D0 RID: 194768 RVA: 0x0067920F File Offset: 0x0067740F
		public static Offset<ILimitPlayerOperation> CreateILimitPlayerOperation(FlatBufferBuilder builder, TLimitPlayOperation Type_type = TLimitPlayOperation.NONE, int TypeOffset = 0)
		{
			builder.StartTable(2);
			ILimitPlayerOperation.AddType(builder, TypeOffset);
			ILimitPlayerOperation.AddTypeType(builder, Type_type);
			return ILimitPlayerOperation.EndILimitPlayerOperation(builder);
		}

		// Token: 0x0602F8D1 RID: 194769 RVA: 0x0067922C File Offset: 0x0067742C
		public static void StartILimitPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F8D2 RID: 194770 RVA: 0x00679235 File Offset: 0x00677435
		public static void AddTypeType(FlatBufferBuilder builder, TLimitPlayOperation typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x0602F8D3 RID: 194771 RVA: 0x00679240 File Offset: 0x00677440
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x0602F8D4 RID: 194772 RVA: 0x0067924B File Offset: 0x0067744B
		public static Offset<ILimitPlayerOperation> EndILimitPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602F8D5 RID: 194773 RVA: 0x00679258 File Offset: 0x00677458
		public ILimitPlayerOperationT UnPack()
		{
			ILimitPlayerOperationT limitPlayerOperationT = new ILimitPlayerOperationT();
			this.UnPackTo(limitPlayerOperationT);
			return limitPlayerOperationT;
		}

		// Token: 0x0602F8D6 RID: 194774 RVA: 0x00679274 File Offset: 0x00677474
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

		// Token: 0x0602F8D7 RID: 194775 RVA: 0x0067944C File Offset: 0x0067764C
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

		// Token: 0x0401122B RID: 70187
		private Table __p;
	}
}
