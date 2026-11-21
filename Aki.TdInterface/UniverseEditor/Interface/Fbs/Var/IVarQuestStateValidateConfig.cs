using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F13 RID: 16147
	public struct IVarQuestStateValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D5B RID: 27995
		// (get) Token: 0x06015EE3 RID: 89827 RVA: 0x003274F1 File Offset: 0x003256F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015EE4 RID: 89828 RVA: 0x003274FE File Offset: 0x003256FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015EE5 RID: 89829 RVA: 0x00327508 File Offset: 0x00325708
		public static IVarQuestStateValidateConfig GetRootAsIVarQuestStateValidateConfig(ByteBuffer _bb)
		{
			return IVarQuestStateValidateConfig.GetRootAsIVarQuestStateValidateConfig(_bb, default(IVarQuestStateValidateConfig));
		}

		// Token: 0x06015EE6 RID: 89830 RVA: 0x00327524 File Offset: 0x00325724
		public static IVarQuestStateValidateConfig GetRootAsIVarQuestStateValidateConfig(ByteBuffer _bb, IVarQuestStateValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015EE7 RID: 89831 RVA: 0x00327541 File Offset: 0x00325741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015EE8 RID: 89832 RVA: 0x00327550 File Offset: 0x00325750
		public IVarQuestStateValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D5C RID: 27996
		// (get) Token: 0x06015EE9 RID: 89833 RVA: 0x00327560 File Offset: 0x00325760
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

		// Token: 0x06015EEA RID: 89834 RVA: 0x0032759C File Offset: 0x0032579C
		public static Offset<IVarQuestStateValidateConfig> CreateIVarQuestStateValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarQuestStateValidateConfig.AddType(builder, Type);
			return IVarQuestStateValidateConfig.EndIVarQuestStateValidateConfig(builder);
		}

		// Token: 0x06015EEB RID: 89835 RVA: 0x003275B2 File Offset: 0x003257B2
		public static void StartIVarQuestStateValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015EEC RID: 89836 RVA: 0x003275BB File Offset: 0x003257BB
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015EED RID: 89837 RVA: 0x003275C6 File Offset: 0x003257C6
		public static Offset<IVarQuestStateValidateConfig> EndIVarQuestStateValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarQuestStateValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015EEE RID: 89838 RVA: 0x003275D4 File Offset: 0x003257D4
		public IVarQuestStateValidateConfigT UnPack()
		{
			IVarQuestStateValidateConfigT varQuestStateValidateConfigT = new IVarQuestStateValidateConfigT();
			this.UnPackTo(varQuestStateValidateConfigT);
			return varQuestStateValidateConfigT;
		}

		// Token: 0x06015EEF RID: 89839 RVA: 0x003275EF File Offset: 0x003257EF
		public void UnPackTo(IVarQuestStateValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015EF0 RID: 89840 RVA: 0x00327600 File Offset: 0x00325800
		public static Offset<IVarQuestStateValidateConfig> Pack(FlatBufferBuilder builder, IVarQuestStateValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarQuestStateValidateConfig>);
			}
			return IVarQuestStateValidateConfig.CreateIVarQuestStateValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400B94E RID: 47438
		private Table __p;
	}
}
