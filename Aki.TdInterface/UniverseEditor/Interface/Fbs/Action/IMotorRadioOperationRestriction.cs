using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726D RID: 29293
	public struct IMotorRadioOperationRestriction : IFlatbufferObject
	{
		// Token: 0x1700D6C4 RID: 54980
		// (get) Token: 0x060330AE RID: 209070 RVA: 0x006E3B2E File Offset: 0x006E1D2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060330AF RID: 209071 RVA: 0x006E3B3B File Offset: 0x006E1D3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060330B0 RID: 209072 RVA: 0x006E3B44 File Offset: 0x006E1D44
		public static IMotorRadioOperationRestriction GetRootAsIMotorRadioOperationRestriction(ByteBuffer _bb)
		{
			return IMotorRadioOperationRestriction.GetRootAsIMotorRadioOperationRestriction(_bb, default(IMotorRadioOperationRestriction));
		}

		// Token: 0x060330B1 RID: 209073 RVA: 0x006E3B60 File Offset: 0x006E1D60
		public static IMotorRadioOperationRestriction GetRootAsIMotorRadioOperationRestriction(ByteBuffer _bb, IMotorRadioOperationRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330B2 RID: 209074 RVA: 0x006E3B7D File Offset: 0x006E1D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330B3 RID: 209075 RVA: 0x006E3B8C File Offset: 0x006E1D8C
		public IMotorRadioOperationRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6C5 RID: 54981
		// (get) Token: 0x060330B4 RID: 209076 RVA: 0x006E3B9C File Offset: 0x006E1D9C
		public EMotorRadioOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return (EMotorRadioOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060330B5 RID: 209077 RVA: 0x006E3BD8 File Offset: 0x006E1DD8
		public static Offset<IMotorRadioOperationRestriction> CreateIMotorRadioOperationRestriction(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll)
		{
			builder.StartTable(1);
			IMotorRadioOperationRestriction.AddType(builder, Type);
			return IMotorRadioOperationRestriction.EndIMotorRadioOperationRestriction(builder);
		}

		// Token: 0x060330B6 RID: 209078 RVA: 0x006E3BEE File Offset: 0x006E1DEE
		public static void StartIMotorRadioOperationRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060330B7 RID: 209079 RVA: 0x006E3BF7 File Offset: 0x006E1DF7
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060330B8 RID: 209080 RVA: 0x006E3C02 File Offset: 0x006E1E02
		public static Offset<IMotorRadioOperationRestriction> EndIMotorRadioOperationRestriction(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioOperationRestriction>(builder.EndTable());
		}

		// Token: 0x060330B9 RID: 209081 RVA: 0x006E3C10 File Offset: 0x006E1E10
		public IMotorRadioOperationRestrictionT UnPack()
		{
			IMotorRadioOperationRestrictionT motorRadioOperationRestrictionT = new IMotorRadioOperationRestrictionT();
			this.UnPackTo(motorRadioOperationRestrictionT);
			return motorRadioOperationRestrictionT;
		}

		// Token: 0x060330BA RID: 209082 RVA: 0x006E3C2B File Offset: 0x006E1E2B
		public void UnPackTo(IMotorRadioOperationRestrictionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060330BB RID: 209083 RVA: 0x006E3C3C File Offset: 0x006E1E3C
		public static Offset<IMotorRadioOperationRestriction> Pack(FlatBufferBuilder builder, IMotorRadioOperationRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRadioOperationRestriction>);
			}
			return IMotorRadioOperationRestriction.CreateIMotorRadioOperationRestriction(builder, _o.Type);
		}

		// Token: 0x040122E4 RID: 74468
		private Table __p;
	}
}
