using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558C RID: 21900
	public struct IConveyorBeltField : IFlatbufferObject
	{
		// Token: 0x17009CDC RID: 40156
		// (get) Token: 0x06022D4D RID: 142669 RVA: 0x004CC6AB File Offset: 0x004CA8AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022D4E RID: 142670 RVA: 0x004CC6B8 File Offset: 0x004CA8B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022D4F RID: 142671 RVA: 0x004CC6C0 File Offset: 0x004CA8C0
		public static IConveyorBeltField GetRootAsIConveyorBeltField(ByteBuffer _bb)
		{
			return IConveyorBeltField.GetRootAsIConveyorBeltField(_bb, default(IConveyorBeltField));
		}

		// Token: 0x06022D50 RID: 142672 RVA: 0x004CC6DC File Offset: 0x004CA8DC
		public static IConveyorBeltField GetRootAsIConveyorBeltField(ByteBuffer _bb, IConveyorBeltField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022D51 RID: 142673 RVA: 0x004CC6F9 File Offset: 0x004CA8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022D52 RID: 142674 RVA: 0x004CC708 File Offset: 0x004CA908
		public IConveyorBeltField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CDD RID: 40157
		// (get) Token: 0x06022D53 RID: 142675 RVA: 0x004CC718 File Offset: 0x004CA918
		public EConveyorBeltFieldType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConveyorBeltFieldType.DirectionalField;
				}
				return (EConveyorBeltFieldType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022D54 RID: 142676 RVA: 0x004CC754 File Offset: 0x004CA954
		public static Offset<IConveyorBeltField> CreateIConveyorBeltField(FlatBufferBuilder builder, EConveyorBeltFieldType Type = EConveyorBeltFieldType.DirectionalField)
		{
			builder.StartTable(1);
			IConveyorBeltField.AddType(builder, Type);
			return IConveyorBeltField.EndIConveyorBeltField(builder);
		}

		// Token: 0x06022D55 RID: 142677 RVA: 0x004CC76A File Offset: 0x004CA96A
		public static void StartIConveyorBeltField(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022D56 RID: 142678 RVA: 0x004CC773 File Offset: 0x004CA973
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltFieldType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022D57 RID: 142679 RVA: 0x004CC77E File Offset: 0x004CA97E
		public static Offset<IConveyorBeltField> EndIConveyorBeltField(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltField>(builder.EndTable());
		}

		// Token: 0x06022D58 RID: 142680 RVA: 0x004CC78C File Offset: 0x004CA98C
		public IConveyorBeltFieldT UnPack()
		{
			IConveyorBeltFieldT conveyorBeltFieldT = new IConveyorBeltFieldT();
			this.UnPackTo(conveyorBeltFieldT);
			return conveyorBeltFieldT;
		}

		// Token: 0x06022D59 RID: 142681 RVA: 0x004CC7A7 File Offset: 0x004CA9A7
		public void UnPackTo(IConveyorBeltFieldT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022D5A RID: 142682 RVA: 0x004CC7B8 File Offset: 0x004CA9B8
		public static Offset<IConveyorBeltField> Pack(FlatBufferBuilder builder, IConveyorBeltFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConveyorBeltField>);
			}
			return IConveyorBeltField.CreateIConveyorBeltField(builder, _o.Type);
		}

		// Token: 0x0400EC10 RID: 60432
		private Table __p;
	}
}
