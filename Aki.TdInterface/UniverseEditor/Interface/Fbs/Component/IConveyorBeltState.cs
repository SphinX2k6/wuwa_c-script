using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005039 RID: 20537
	public struct IConveyorBeltState : IFlatbufferObject
	{
		// Token: 0x17009505 RID: 38149
		// (get) Token: 0x06020E6B RID: 134763 RVA: 0x0049318E File Offset: 0x0049138E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E6C RID: 134764 RVA: 0x0049319B File Offset: 0x0049139B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E6D RID: 134765 RVA: 0x004931A4 File Offset: 0x004913A4
		public static IConveyorBeltState GetRootAsIConveyorBeltState(ByteBuffer _bb)
		{
			return IConveyorBeltState.GetRootAsIConveyorBeltState(_bb, default(IConveyorBeltState));
		}

		// Token: 0x06020E6E RID: 134766 RVA: 0x004931C0 File Offset: 0x004913C0
		public static IConveyorBeltState GetRootAsIConveyorBeltState(ByteBuffer _bb, IConveyorBeltState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E6F RID: 134767 RVA: 0x004931DD File Offset: 0x004913DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E70 RID: 134768 RVA: 0x004931EC File Offset: 0x004913EC
		public IConveyorBeltState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009506 RID: 38150
		// (get) Token: 0x06020E71 RID: 134769 RVA: 0x004931FC File Offset: 0x004913FC
		public string EntityState
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

		// Token: 0x06020E72 RID: 134770 RVA: 0x00493233 File Offset: 0x00491433
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020E73 RID: 134771 RVA: 0x00493242 File Offset: 0x00491442
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009507 RID: 38151
		// (get) Token: 0x06020E74 RID: 134772 RVA: 0x00493250 File Offset: 0x00491450
		public TConveyorBeltFieldType FieldTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TConveyorBeltFieldType.NONE;
				}
				return (TConveyorBeltFieldType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020E75 RID: 134773 RVA: 0x0049328C File Offset: 0x0049148C
		public TTable? FieldType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020E76 RID: 134774 RVA: 0x004932D0 File Offset: 0x004914D0
		public IDirectionalField FieldTypeAsIDirectionalField()
		{
			return this.FieldType<IDirectionalField>().Value;
		}

		// Token: 0x06020E77 RID: 134775 RVA: 0x004932EC File Offset: 0x004914EC
		public IPointField FieldTypeAsIPointField()
		{
			return this.FieldType<IPointField>().Value;
		}

		// Token: 0x17009508 RID: 38152
		// (get) Token: 0x06020E78 RID: 134776 RVA: 0x00493308 File Offset: 0x00491508
		public IFixSpeed? MoveType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFixSpeed?(default(IFixSpeed).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020E79 RID: 134777 RVA: 0x00493366 File Offset: 0x00491566
		public static Offset<IConveyorBeltState> CreateIConveyorBeltState(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), TConveyorBeltFieldType FieldType_type = TConveyorBeltFieldType.NONE, int FieldTypeOffset = 0, Offset<IFixSpeed> MoveTypeOffset = default(Offset<IFixSpeed>))
		{
			builder.StartTable(4);
			IConveyorBeltState.AddMoveType(builder, MoveTypeOffset);
			IConveyorBeltState.AddFieldType(builder, FieldTypeOffset);
			IConveyorBeltState.AddEntityState(builder, EntityStateOffset);
			IConveyorBeltState.AddFieldTypeType(builder, FieldType_type);
			return IConveyorBeltState.EndIConveyorBeltState(builder);
		}

		// Token: 0x06020E7A RID: 134778 RVA: 0x00493392 File Offset: 0x00491592
		public static void StartIConveyorBeltState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020E7B RID: 134779 RVA: 0x0049339B File Offset: 0x0049159B
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x06020E7C RID: 134780 RVA: 0x004933AB File Offset: 0x004915AB
		public static void AddFieldTypeType(FlatBufferBuilder builder, TConveyorBeltFieldType fieldTypeType)
		{
			builder.AddByte(1, (byte)fieldTypeType, 0);
		}

		// Token: 0x06020E7D RID: 134781 RVA: 0x004933B6 File Offset: 0x004915B6
		public static void AddFieldType(FlatBufferBuilder builder, int fieldTypeOffset)
		{
			builder.AddOffset(2, fieldTypeOffset, 0);
		}

		// Token: 0x06020E7E RID: 134782 RVA: 0x004933C1 File Offset: 0x004915C1
		public static void AddMoveType(FlatBufferBuilder builder, Offset<IFixSpeed> moveTypeOffset)
		{
			builder.AddOffset(3, moveTypeOffset.Value, 0);
		}

		// Token: 0x06020E7F RID: 134783 RVA: 0x004933D1 File Offset: 0x004915D1
		public static Offset<IConveyorBeltState> EndIConveyorBeltState(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltState>(builder.EndTable());
		}

		// Token: 0x06020E80 RID: 134784 RVA: 0x004933E0 File Offset: 0x004915E0
		public IConveyorBeltStateT UnPack()
		{
			IConveyorBeltStateT conveyorBeltStateT = new IConveyorBeltStateT();
			this.UnPackTo(conveyorBeltStateT);
			return conveyorBeltStateT;
		}

		// Token: 0x06020E81 RID: 134785 RVA: 0x004933FC File Offset: 0x004915FC
		public void UnPackTo(IConveyorBeltStateT _o)
		{
			_o.EntityState = this.EntityState;
			_o.FieldType = new TConveyorBeltFieldTypeUnion();
			_o.FieldType.Type = this.FieldTypeType;
			TConveyorBeltFieldType fieldTypeType = this.FieldTypeType;
			if (fieldTypeType != TConveyorBeltFieldType.IDirectionalField)
			{
				if (fieldTypeType == TConveyorBeltFieldType.IPointField)
				{
					_o.FieldType.Value = ((this.FieldType<IPointField>() != null) ? this.FieldType<IPointField>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.FieldType.Value = ((this.FieldType<IDirectionalField>() != null) ? this.FieldType<IDirectionalField>().Value.UnPack() : null);
			}
			_o.MoveType = ((this.MoveType != null) ? this.MoveType.Value.UnPack() : null);
		}

		// Token: 0x06020E82 RID: 134786 RVA: 0x004934E0 File Offset: 0x004916E0
		public static Offset<IConveyorBeltState> Pack(FlatBufferBuilder builder, IConveyorBeltStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConveyorBeltState>);
			}
			StringOffset entityStateOffset = (_o.EntityState == null) ? default(StringOffset) : builder.CreateString(_o.EntityState);
			TConveyorBeltFieldType fieldType_type = (_o.FieldType == null) ? TConveyorBeltFieldType.NONE : _o.FieldType.Type;
			int fieldTypeOffset = (_o.FieldType == null) ? 0 : TConveyorBeltFieldTypeUnion.Pack(builder, _o.FieldType);
			Offset<IFixSpeed> moveTypeOffset = (_o.MoveType == null) ? default(Offset<IFixSpeed>) : IFixSpeed.Pack(builder, _o.MoveType);
			return IConveyorBeltState.CreateIConveyorBeltState(builder, entityStateOffset, fieldType_type, fieldTypeOffset, moveTypeOffset);
		}

		// Token: 0x0400E02B RID: 57387
		private Table __p;
	}
}
