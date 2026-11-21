using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005598 RID: 21912
	public struct IConveyorBeltState : IFlatbufferObject
	{
		// Token: 0x17009CE6 RID: 40166
		// (get) Token: 0x06022D8B RID: 142731 RVA: 0x004CCBDE File Offset: 0x004CADDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D8C RID: 142732 RVA: 0x004CCBEB File Offset: 0x004CADEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D8D RID: 142733 RVA: 0x004CCBF4 File Offset: 0x004CADF4
		public static IConveyorBeltState GetRootAsIConveyorBeltState(ByteBuffer _bb)
		{
			return IConveyorBeltState.GetRootAsIConveyorBeltState(_bb, default(IConveyorBeltState));
		}

		// Token: 0x06022D8E RID: 142734 RVA: 0x004CCC10 File Offset: 0x004CAE10
		public static IConveyorBeltState GetRootAsIConveyorBeltState(ByteBuffer _bb, IConveyorBeltState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D8F RID: 142735 RVA: 0x004CCC2D File Offset: 0x004CAE2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D90 RID: 142736 RVA: 0x004CCC3C File Offset: 0x004CAE3C
		public IConveyorBeltState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CE7 RID: 40167
		// (get) Token: 0x06022D91 RID: 142737 RVA: 0x004CCC4C File Offset: 0x004CAE4C
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

		// Token: 0x06022D92 RID: 142738 RVA: 0x004CCC83 File Offset: 0x004CAE83
		public Span<byte> GetEntityStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022D93 RID: 142739 RVA: 0x004CCC92 File Offset: 0x004CAE92
		public byte[] GetEntityStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009CE8 RID: 40168
		// (get) Token: 0x06022D94 RID: 142740 RVA: 0x004CCCA0 File Offset: 0x004CAEA0
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

		// Token: 0x06022D95 RID: 142741 RVA: 0x004CCCDC File Offset: 0x004CAEDC
		public TTable? FieldType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022D96 RID: 142742 RVA: 0x004CCD20 File Offset: 0x004CAF20
		public IDirectionalField FieldTypeAsIDirectionalField()
		{
			return this.FieldType<IDirectionalField>().Value;
		}

		// Token: 0x06022D97 RID: 142743 RVA: 0x004CCD3C File Offset: 0x004CAF3C
		public IPointField FieldTypeAsIPointField()
		{
			return this.FieldType<IPointField>().Value;
		}

		// Token: 0x17009CE9 RID: 40169
		// (get) Token: 0x06022D98 RID: 142744 RVA: 0x004CCD58 File Offset: 0x004CAF58
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

		// Token: 0x06022D99 RID: 142745 RVA: 0x004CCDB6 File Offset: 0x004CAFB6
		public static Offset<IConveyorBeltState> CreateIConveyorBeltState(FlatBufferBuilder builder, StringOffset EntityStateOffset = default(StringOffset), TConveyorBeltFieldType FieldType_type = TConveyorBeltFieldType.NONE, int FieldTypeOffset = 0, Offset<IFixSpeed> MoveTypeOffset = default(Offset<IFixSpeed>))
		{
			builder.StartTable(4);
			IConveyorBeltState.AddMoveType(builder, MoveTypeOffset);
			IConveyorBeltState.AddFieldType(builder, FieldTypeOffset);
			IConveyorBeltState.AddEntityState(builder, EntityStateOffset);
			IConveyorBeltState.AddFieldTypeType(builder, FieldType_type);
			return IConveyorBeltState.EndIConveyorBeltState(builder);
		}

		// Token: 0x06022D9A RID: 142746 RVA: 0x004CCDE2 File Offset: 0x004CAFE2
		public static void StartIConveyorBeltState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022D9B RID: 142747 RVA: 0x004CCDEB File Offset: 0x004CAFEB
		public static void AddEntityState(FlatBufferBuilder builder, StringOffset entityStateOffset)
		{
			builder.AddOffset(0, entityStateOffset.Value, 0);
		}

		// Token: 0x06022D9C RID: 142748 RVA: 0x004CCDFB File Offset: 0x004CAFFB
		public static void AddFieldTypeType(FlatBufferBuilder builder, TConveyorBeltFieldType fieldTypeType)
		{
			builder.AddByte(1, (byte)fieldTypeType, 0);
		}

		// Token: 0x06022D9D RID: 142749 RVA: 0x004CCE06 File Offset: 0x004CB006
		public static void AddFieldType(FlatBufferBuilder builder, int fieldTypeOffset)
		{
			builder.AddOffset(2, fieldTypeOffset, 0);
		}

		// Token: 0x06022D9E RID: 142750 RVA: 0x004CCE11 File Offset: 0x004CB011
		public static void AddMoveType(FlatBufferBuilder builder, Offset<IFixSpeed> moveTypeOffset)
		{
			builder.AddOffset(3, moveTypeOffset.Value, 0);
		}

		// Token: 0x06022D9F RID: 142751 RVA: 0x004CCE21 File Offset: 0x004CB021
		public static Offset<IConveyorBeltState> EndIConveyorBeltState(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltState>(builder.EndTable());
		}

		// Token: 0x06022DA0 RID: 142752 RVA: 0x004CCE30 File Offset: 0x004CB030
		public IConveyorBeltStateT UnPack()
		{
			IConveyorBeltStateT conveyorBeltStateT = new IConveyorBeltStateT();
			this.UnPackTo(conveyorBeltStateT);
			return conveyorBeltStateT;
		}

		// Token: 0x06022DA1 RID: 142753 RVA: 0x004CCE4C File Offset: 0x004CB04C
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

		// Token: 0x06022DA2 RID: 142754 RVA: 0x004CCF30 File Offset: 0x004CB130
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

		// Token: 0x0400EC21 RID: 60449
		private Table __p;
	}
}
