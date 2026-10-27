using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200502D RID: 20525
	public struct IConveyorBeltField : IFlatbufferObject
	{
		// Token: 0x170094FB RID: 38139
		// (get) Token: 0x06020E2D RID: 134701 RVA: 0x00492C5B File Offset: 0x00490E5B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E2E RID: 134702 RVA: 0x00492C68 File Offset: 0x00490E68
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E2F RID: 134703 RVA: 0x00492C70 File Offset: 0x00490E70
		public static IConveyorBeltField GetRootAsIConveyorBeltField(ByteBuffer _bb)
		{
			return IConveyorBeltField.GetRootAsIConveyorBeltField(_bb, default(IConveyorBeltField));
		}

		// Token: 0x06020E30 RID: 134704 RVA: 0x00492C8C File Offset: 0x00490E8C
		public static IConveyorBeltField GetRootAsIConveyorBeltField(ByteBuffer _bb, IConveyorBeltField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E31 RID: 134705 RVA: 0x00492CA9 File Offset: 0x00490EA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E32 RID: 134706 RVA: 0x00492CB8 File Offset: 0x00490EB8
		public IConveyorBeltField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094FC RID: 38140
		// (get) Token: 0x06020E33 RID: 134707 RVA: 0x00492CC8 File Offset: 0x00490EC8
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

		// Token: 0x06020E34 RID: 134708 RVA: 0x00492D04 File Offset: 0x00490F04
		public static Offset<IConveyorBeltField> CreateIConveyorBeltField(FlatBufferBuilder builder, EConveyorBeltFieldType Type = EConveyorBeltFieldType.DirectionalField)
		{
			builder.StartTable(1);
			IConveyorBeltField.AddType(builder, Type);
			return IConveyorBeltField.EndIConveyorBeltField(builder);
		}

		// Token: 0x06020E35 RID: 134709 RVA: 0x00492D1A File Offset: 0x00490F1A
		public static void StartIConveyorBeltField(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020E36 RID: 134710 RVA: 0x00492D23 File Offset: 0x00490F23
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltFieldType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E37 RID: 134711 RVA: 0x00492D2E File Offset: 0x00490F2E
		public static Offset<IConveyorBeltField> EndIConveyorBeltField(FlatBufferBuilder builder)
		{
			return new Offset<IConveyorBeltField>(builder.EndTable());
		}

		// Token: 0x06020E38 RID: 134712 RVA: 0x00492D3C File Offset: 0x00490F3C
		public IConveyorBeltFieldT UnPack()
		{
			IConveyorBeltFieldT conveyorBeltFieldT = new IConveyorBeltFieldT();
			this.UnPackTo(conveyorBeltFieldT);
			return conveyorBeltFieldT;
		}

		// Token: 0x06020E39 RID: 134713 RVA: 0x00492D57 File Offset: 0x00490F57
		public void UnPackTo(IConveyorBeltFieldT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020E3A RID: 134714 RVA: 0x00492D68 File Offset: 0x00490F68
		public static Offset<IConveyorBeltField> Pack(FlatBufferBuilder builder, IConveyorBeltFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConveyorBeltField>);
			}
			return IConveyorBeltField.CreateIConveyorBeltField(builder, _o.Type);
		}

		// Token: 0x0400E01A RID: 57370
		private Table __p;
	}
}
