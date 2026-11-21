using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F10 RID: 16144
	public struct IVarPrefabValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D58 RID: 27992
		// (get) Token: 0x06015ED1 RID: 89809 RVA: 0x0032737A File Offset: 0x0032557A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015ED2 RID: 89810 RVA: 0x00327387 File Offset: 0x00325587
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015ED3 RID: 89811 RVA: 0x00327390 File Offset: 0x00325590
		public static IVarPrefabValidateConfig GetRootAsIVarPrefabValidateConfig(ByteBuffer _bb)
		{
			return IVarPrefabValidateConfig.GetRootAsIVarPrefabValidateConfig(_bb, default(IVarPrefabValidateConfig));
		}

		// Token: 0x06015ED4 RID: 89812 RVA: 0x003273AC File Offset: 0x003255AC
		public static IVarPrefabValidateConfig GetRootAsIVarPrefabValidateConfig(ByteBuffer _bb, IVarPrefabValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015ED5 RID: 89813 RVA: 0x003273C9 File Offset: 0x003255C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015ED6 RID: 89814 RVA: 0x003273D8 File Offset: 0x003255D8
		public IVarPrefabValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D59 RID: 27993
		// (get) Token: 0x06015ED7 RID: 89815 RVA: 0x003273E8 File Offset: 0x003255E8
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

		// Token: 0x06015ED8 RID: 89816 RVA: 0x00327424 File Offset: 0x00325624
		public static Offset<IVarPrefabValidateConfig> CreateIVarPrefabValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarPrefabValidateConfig.AddType(builder, Type);
			return IVarPrefabValidateConfig.EndIVarPrefabValidateConfig(builder);
		}

		// Token: 0x06015ED9 RID: 89817 RVA: 0x0032743A File Offset: 0x0032563A
		public static void StartIVarPrefabValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015EDA RID: 89818 RVA: 0x00327443 File Offset: 0x00325643
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015EDB RID: 89819 RVA: 0x0032744E File Offset: 0x0032564E
		public static Offset<IVarPrefabValidateConfig> EndIVarPrefabValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarPrefabValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015EDC RID: 89820 RVA: 0x0032745C File Offset: 0x0032565C
		public IVarPrefabValidateConfigT UnPack()
		{
			IVarPrefabValidateConfigT varPrefabValidateConfigT = new IVarPrefabValidateConfigT();
			this.UnPackTo(varPrefabValidateConfigT);
			return varPrefabValidateConfigT;
		}

		// Token: 0x06015EDD RID: 89821 RVA: 0x00327477 File Offset: 0x00325677
		public void UnPackTo(IVarPrefabValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015EDE RID: 89822 RVA: 0x00327488 File Offset: 0x00325688
		public static Offset<IVarPrefabValidateConfig> Pack(FlatBufferBuilder builder, IVarPrefabValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarPrefabValidateConfig>);
			}
			return IVarPrefabValidateConfig.CreateIVarPrefabValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400B94C RID: 47436
		private Table __p;
	}
}
