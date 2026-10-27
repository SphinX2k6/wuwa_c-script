using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005757 RID: 22359
	public struct IPointField : IFlatbufferObject
	{
		// Token: 0x1700A6CC RID: 42700
		// (get) Token: 0x06025777 RID: 153463 RVA: 0x0052B596 File Offset: 0x00529796
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025778 RID: 153464 RVA: 0x0052B5A3 File Offset: 0x005297A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025779 RID: 153465 RVA: 0x0052B5AC File Offset: 0x005297AC
		public static IPointField GetRootAsIPointField(ByteBuffer _bb)
		{
			return IPointField.GetRootAsIPointField(_bb, default(IPointField));
		}

		// Token: 0x0602577A RID: 153466 RVA: 0x0052B5C8 File Offset: 0x005297C8
		public static IPointField GetRootAsIPointField(ByteBuffer _bb, IPointField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602577B RID: 153467 RVA: 0x0052B5E5 File Offset: 0x005297E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602577C RID: 153468 RVA: 0x0052B5F4 File Offset: 0x005297F4
		public IPointField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6CD RID: 42701
		// (get) Token: 0x0602577D RID: 153469 RVA: 0x0052B604 File Offset: 0x00529804
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

		// Token: 0x0602577E RID: 153470 RVA: 0x0052B640 File Offset: 0x00529840
		public static Offset<IPointField> CreateIPointField(FlatBufferBuilder builder, EConveyorBeltFieldType Type = EConveyorBeltFieldType.DirectionalField)
		{
			builder.StartTable(1);
			IPointField.AddType(builder, Type);
			return IPointField.EndIPointField(builder);
		}

		// Token: 0x0602577F RID: 153471 RVA: 0x0052B656 File Offset: 0x00529856
		public static void StartIPointField(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025780 RID: 153472 RVA: 0x0052B65F File Offset: 0x0052985F
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltFieldType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025781 RID: 153473 RVA: 0x0052B66A File Offset: 0x0052986A
		public static Offset<IPointField> EndIPointField(FlatBufferBuilder builder)
		{
			return new Offset<IPointField>(builder.EndTable());
		}

		// Token: 0x06025782 RID: 153474 RVA: 0x0052B678 File Offset: 0x00529878
		public IPointFieldT UnPack()
		{
			IPointFieldT pointFieldT = new IPointFieldT();
			this.UnPackTo(pointFieldT);
			return pointFieldT;
		}

		// Token: 0x06025783 RID: 153475 RVA: 0x0052B693 File Offset: 0x00529893
		public void UnPackTo(IPointFieldT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025784 RID: 153476 RVA: 0x0052B6A4 File Offset: 0x005298A4
		public static Offset<IPointField> Pack(FlatBufferBuilder builder, IPointFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointField>);
			}
			return IPointField.CreateIPointField(builder, _o.Type);
		}

		// Token: 0x0400EBF8 RID: 60408
		private Table __p;
	}
}
