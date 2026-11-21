using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EFE RID: 16126
	public struct IVarBooleanValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D24 RID: 27940
		// (get) Token: 0x06015DEB RID: 89579 RVA: 0x00325144 File Offset: 0x00323344
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015DEC RID: 89580 RVA: 0x00325151 File Offset: 0x00323351
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015DED RID: 89581 RVA: 0x00325158 File Offset: 0x00323358
		public static IVarBooleanValidateConfig GetRootAsIVarBooleanValidateConfig(ByteBuffer _bb)
		{
			return IVarBooleanValidateConfig.GetRootAsIVarBooleanValidateConfig(_bb, default(IVarBooleanValidateConfig));
		}

		// Token: 0x06015DEE RID: 89582 RVA: 0x00325174 File Offset: 0x00323374
		public static IVarBooleanValidateConfig GetRootAsIVarBooleanValidateConfig(ByteBuffer _bb, IVarBooleanValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015DEF RID: 89583 RVA: 0x00325191 File Offset: 0x00323391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015DF0 RID: 89584 RVA: 0x003251A0 File Offset: 0x003233A0
		public IVarBooleanValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D25 RID: 27941
		// (get) Token: 0x06015DF1 RID: 89585 RVA: 0x003251B0 File Offset: 0x003233B0
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015DF2 RID: 89586 RVA: 0x003251EC File Offset: 0x003233EC
		public static Offset<IVarBooleanValidateConfig> CreateIVarBooleanValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarBooleanValidateConfig.AddType(builder, Type);
			return IVarBooleanValidateConfig.EndIVarBooleanValidateConfig(builder);
		}

		// Token: 0x06015DF3 RID: 89587 RVA: 0x00325202 File Offset: 0x00323402
		public static void StartIVarBooleanValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015DF4 RID: 89588 RVA: 0x0032520B File Offset: 0x0032340B
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015DF5 RID: 89589 RVA: 0x00325216 File Offset: 0x00323416
		public static Offset<IVarBooleanValidateConfig> EndIVarBooleanValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarBooleanValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015DF6 RID: 89590 RVA: 0x00325224 File Offset: 0x00323424
		public IVarBooleanValidateConfigT UnPack()
		{
			IVarBooleanValidateConfigT varBooleanValidateConfigT = new IVarBooleanValidateConfigT();
			this.UnPackTo(varBooleanValidateConfigT);
			return varBooleanValidateConfigT;
		}

		// Token: 0x06015DF7 RID: 89591 RVA: 0x0032523F File Offset: 0x0032343F
		public void UnPackTo(IVarBooleanValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015DF8 RID: 89592 RVA: 0x00325250 File Offset: 0x00323450
		public static Offset<IVarBooleanValidateConfig> Pack(FlatBufferBuilder builder, IVarBooleanValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarBooleanValidateConfig>);
			}
			return IVarBooleanValidateConfig.CreateIVarBooleanValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400B92F RID: 47407
		private Table __p;
	}
}
