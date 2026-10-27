using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B20 RID: 15136
	public struct IVarValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067D5 RID: 26581
		// (get) Token: 0x06014AA5 RID: 84645 RVA: 0x00301C8D File Offset: 0x002FFE8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014AA6 RID: 84646 RVA: 0x00301C9A File Offset: 0x002FFE9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014AA7 RID: 84647 RVA: 0x00301CA4 File Offset: 0x002FFEA4
		public static IVarValidateConfig GetRootAsIVarValidateConfig(ByteBuffer _bb)
		{
			return IVarValidateConfig.GetRootAsIVarValidateConfig(_bb, default(IVarValidateConfig));
		}

		// Token: 0x06014AA8 RID: 84648 RVA: 0x00301CC0 File Offset: 0x002FFEC0
		public static IVarValidateConfig GetRootAsIVarValidateConfig(ByteBuffer _bb, IVarValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014AA9 RID: 84649 RVA: 0x00301CDD File Offset: 0x002FFEDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014AAA RID: 84650 RVA: 0x00301CEC File Offset: 0x002FFEEC
		public IVarValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067D6 RID: 26582
		// (get) Token: 0x06014AAB RID: 84651 RVA: 0x00301CFC File Offset: 0x002FFEFC
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

		// Token: 0x06014AAC RID: 84652 RVA: 0x00301D38 File Offset: 0x002FFF38
		public static Offset<IVarValidateConfig> CreateIVarValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarValidateConfig.AddType(builder, Type);
			return IVarValidateConfig.EndIVarValidateConfig(builder);
		}

		// Token: 0x06014AAD RID: 84653 RVA: 0x00301D4E File Offset: 0x002FFF4E
		public static void StartIVarValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014AAE RID: 84654 RVA: 0x00301D57 File Offset: 0x002FFF57
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014AAF RID: 84655 RVA: 0x00301D62 File Offset: 0x002FFF62
		public static Offset<IVarValidateConfig> EndIVarValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarValidateConfig>(builder.EndTable());
		}

		// Token: 0x06014AB0 RID: 84656 RVA: 0x00301D70 File Offset: 0x002FFF70
		public IVarValidateConfigT UnPack()
		{
			IVarValidateConfigT varValidateConfigT = new IVarValidateConfigT();
			this.UnPackTo(varValidateConfigT);
			return varValidateConfigT;
		}

		// Token: 0x06014AB1 RID: 84657 RVA: 0x00301D8B File Offset: 0x002FFF8B
		public void UnPackTo(IVarValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014AB2 RID: 84658 RVA: 0x00301D9C File Offset: 0x002FFF9C
		public static Offset<IVarValidateConfig> Pack(FlatBufferBuilder builder, IVarValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarValidateConfig>);
			}
			return IVarValidateConfig.CreateIVarValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400AFEE RID: 45038
		private Table __p;
	}
}
