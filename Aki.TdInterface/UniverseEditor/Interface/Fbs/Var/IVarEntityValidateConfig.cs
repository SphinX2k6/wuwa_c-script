using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B02 RID: 15106
	public struct IVarEntityValidateConfig : IFlatbufferObject
	{
		// Token: 0x1700679F RID: 26527
		// (get) Token: 0x0601499D RID: 84381 RVA: 0x002FFE7B File Offset: 0x002FE07B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601499E RID: 84382 RVA: 0x002FFE88 File Offset: 0x002FE088
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601499F RID: 84383 RVA: 0x002FFE90 File Offset: 0x002FE090
		public static IVarEntityValidateConfig GetRootAsIVarEntityValidateConfig(ByteBuffer _bb)
		{
			return IVarEntityValidateConfig.GetRootAsIVarEntityValidateConfig(_bb, default(IVarEntityValidateConfig));
		}

		// Token: 0x060149A0 RID: 84384 RVA: 0x002FFEAC File Offset: 0x002FE0AC
		public static IVarEntityValidateConfig GetRootAsIVarEntityValidateConfig(ByteBuffer _bb, IVarEntityValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060149A1 RID: 84385 RVA: 0x002FFEC9 File Offset: 0x002FE0C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060149A2 RID: 84386 RVA: 0x002FFED8 File Offset: 0x002FE0D8
		public IVarEntityValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067A0 RID: 26528
		// (get) Token: 0x060149A3 RID: 84387 RVA: 0x002FFEE8 File Offset: 0x002FE0E8
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

		// Token: 0x060149A4 RID: 84388 RVA: 0x002FFF24 File Offset: 0x002FE124
		public static Offset<IVarEntityValidateConfig> CreateIVarEntityValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarEntityValidateConfig.AddType(builder, Type);
			return IVarEntityValidateConfig.EndIVarEntityValidateConfig(builder);
		}

		// Token: 0x060149A5 RID: 84389 RVA: 0x002FFF3A File Offset: 0x002FE13A
		public static void StartIVarEntityValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060149A6 RID: 84390 RVA: 0x002FFF43 File Offset: 0x002FE143
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060149A7 RID: 84391 RVA: 0x002FFF4E File Offset: 0x002FE14E
		public static Offset<IVarEntityValidateConfig> EndIVarEntityValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarEntityValidateConfig>(builder.EndTable());
		}

		// Token: 0x060149A8 RID: 84392 RVA: 0x002FFF5C File Offset: 0x002FE15C
		public IVarEntityValidateConfigT UnPack()
		{
			IVarEntityValidateConfigT varEntityValidateConfigT = new IVarEntityValidateConfigT();
			this.UnPackTo(varEntityValidateConfigT);
			return varEntityValidateConfigT;
		}

		// Token: 0x060149A9 RID: 84393 RVA: 0x002FFF77 File Offset: 0x002FE177
		public void UnPackTo(IVarEntityValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060149AA RID: 84394 RVA: 0x002FFF88 File Offset: 0x002FE188
		public static Offset<IVarEntityValidateConfig> Pack(FlatBufferBuilder builder, IVarEntityValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarEntityValidateConfig>);
			}
			return IVarEntityValidateConfig.CreateIVarEntityValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400AFCE RID: 45006
		private Table __p;
	}
}
