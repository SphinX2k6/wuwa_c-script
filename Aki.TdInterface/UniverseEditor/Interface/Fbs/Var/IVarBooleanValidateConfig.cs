using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AFC RID: 15100
	public struct IVarBooleanValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006789 RID: 26505
		// (get) Token: 0x06014941 RID: 84289 RVA: 0x002FEEB4 File Offset: 0x002FD0B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014942 RID: 84290 RVA: 0x002FEEC1 File Offset: 0x002FD0C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014943 RID: 84291 RVA: 0x002FEEC8 File Offset: 0x002FD0C8
		public static IVarBooleanValidateConfig GetRootAsIVarBooleanValidateConfig(ByteBuffer _bb)
		{
			return IVarBooleanValidateConfig.GetRootAsIVarBooleanValidateConfig(_bb, default(IVarBooleanValidateConfig));
		}

		// Token: 0x06014944 RID: 84292 RVA: 0x002FEEE4 File Offset: 0x002FD0E4
		public static IVarBooleanValidateConfig GetRootAsIVarBooleanValidateConfig(ByteBuffer _bb, IVarBooleanValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014945 RID: 84293 RVA: 0x002FEF01 File Offset: 0x002FD101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014946 RID: 84294 RVA: 0x002FEF10 File Offset: 0x002FD110
		public IVarBooleanValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700678A RID: 26506
		// (get) Token: 0x06014947 RID: 84295 RVA: 0x002FEF20 File Offset: 0x002FD120
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

		// Token: 0x06014948 RID: 84296 RVA: 0x002FEF5C File Offset: 0x002FD15C
		public static Offset<IVarBooleanValidateConfig> CreateIVarBooleanValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarBooleanValidateConfig.AddType(builder, Type);
			return IVarBooleanValidateConfig.EndIVarBooleanValidateConfig(builder);
		}

		// Token: 0x06014949 RID: 84297 RVA: 0x002FEF72 File Offset: 0x002FD172
		public static void StartIVarBooleanValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601494A RID: 84298 RVA: 0x002FEF7B File Offset: 0x002FD17B
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601494B RID: 84299 RVA: 0x002FEF86 File Offset: 0x002FD186
		public static Offset<IVarBooleanValidateConfig> EndIVarBooleanValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarBooleanValidateConfig>(builder.EndTable());
		}

		// Token: 0x0601494C RID: 84300 RVA: 0x002FEF94 File Offset: 0x002FD194
		public IVarBooleanValidateConfigT UnPack()
		{
			IVarBooleanValidateConfigT varBooleanValidateConfigT = new IVarBooleanValidateConfigT();
			this.UnPackTo(varBooleanValidateConfigT);
			return varBooleanValidateConfigT;
		}

		// Token: 0x0601494D RID: 84301 RVA: 0x002FEFAF File Offset: 0x002FD1AF
		public void UnPackTo(IVarBooleanValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601494E RID: 84302 RVA: 0x002FEFC0 File Offset: 0x002FD1C0
		public static Offset<IVarBooleanValidateConfig> Pack(FlatBufferBuilder builder, IVarBooleanValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarBooleanValidateConfig>);
			}
			return IVarBooleanValidateConfig.CreateIVarBooleanValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400AFC2 RID: 44994
		private Table __p;
	}
}
