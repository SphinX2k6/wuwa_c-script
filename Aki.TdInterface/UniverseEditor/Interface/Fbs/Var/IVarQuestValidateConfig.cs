using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F16 RID: 16150
	public struct IVarQuestValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D5E RID: 27998
		// (get) Token: 0x06015EF5 RID: 89845 RVA: 0x00327669 File Offset: 0x00325869
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015EF6 RID: 89846 RVA: 0x00327676 File Offset: 0x00325876
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015EF7 RID: 89847 RVA: 0x00327680 File Offset: 0x00325880
		public static IVarQuestValidateConfig GetRootAsIVarQuestValidateConfig(ByteBuffer _bb)
		{
			return IVarQuestValidateConfig.GetRootAsIVarQuestValidateConfig(_bb, default(IVarQuestValidateConfig));
		}

		// Token: 0x06015EF8 RID: 89848 RVA: 0x0032769C File Offset: 0x0032589C
		public static IVarQuestValidateConfig GetRootAsIVarQuestValidateConfig(ByteBuffer _bb, IVarQuestValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015EF9 RID: 89849 RVA: 0x003276B9 File Offset: 0x003258B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015EFA RID: 89850 RVA: 0x003276C8 File Offset: 0x003258C8
		public IVarQuestValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D5F RID: 27999
		// (get) Token: 0x06015EFB RID: 89851 RVA: 0x003276D8 File Offset: 0x003258D8
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

		// Token: 0x06015EFC RID: 89852 RVA: 0x00327714 File Offset: 0x00325914
		public static Offset<IVarQuestValidateConfig> CreateIVarQuestValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarQuestValidateConfig.AddType(builder, Type);
			return IVarQuestValidateConfig.EndIVarQuestValidateConfig(builder);
		}

		// Token: 0x06015EFD RID: 89853 RVA: 0x0032772A File Offset: 0x0032592A
		public static void StartIVarQuestValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015EFE RID: 89854 RVA: 0x00327733 File Offset: 0x00325933
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015EFF RID: 89855 RVA: 0x0032773E File Offset: 0x0032593E
		public static Offset<IVarQuestValidateConfig> EndIVarQuestValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarQuestValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015F00 RID: 89856 RVA: 0x0032774C File Offset: 0x0032594C
		public IVarQuestValidateConfigT UnPack()
		{
			IVarQuestValidateConfigT varQuestValidateConfigT = new IVarQuestValidateConfigT();
			this.UnPackTo(varQuestValidateConfigT);
			return varQuestValidateConfigT;
		}

		// Token: 0x06015F01 RID: 89857 RVA: 0x00327767 File Offset: 0x00325967
		public void UnPackTo(IVarQuestValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015F02 RID: 89858 RVA: 0x00327778 File Offset: 0x00325978
		public static Offset<IVarQuestValidateConfig> Pack(FlatBufferBuilder builder, IVarQuestValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarQuestValidateConfig>);
			}
			return IVarQuestValidateConfig.CreateIVarQuestValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400B950 RID: 47440
		private Table __p;
	}
}
