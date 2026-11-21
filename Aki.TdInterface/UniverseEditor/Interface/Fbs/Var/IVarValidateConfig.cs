using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F22 RID: 16162
	public struct IVarValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D70 RID: 28016
		// (get) Token: 0x06015F4F RID: 89935 RVA: 0x00327F1D File Offset: 0x0032611D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F50 RID: 89936 RVA: 0x00327F2A File Offset: 0x0032612A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F51 RID: 89937 RVA: 0x00327F34 File Offset: 0x00326134
		public static IVarValidateConfig GetRootAsIVarValidateConfig(ByteBuffer _bb)
		{
			return IVarValidateConfig.GetRootAsIVarValidateConfig(_bb, default(IVarValidateConfig));
		}

		// Token: 0x06015F52 RID: 89938 RVA: 0x00327F50 File Offset: 0x00326150
		public static IVarValidateConfig GetRootAsIVarValidateConfig(ByteBuffer _bb, IVarValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F53 RID: 89939 RVA: 0x00327F6D File Offset: 0x0032616D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F54 RID: 89940 RVA: 0x00327F7C File Offset: 0x0032617C
		public IVarValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D71 RID: 28017
		// (get) Token: 0x06015F55 RID: 89941 RVA: 0x00327F8C File Offset: 0x0032618C
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

		// Token: 0x06015F56 RID: 89942 RVA: 0x00327FC8 File Offset: 0x003261C8
		public static Offset<IVarValidateConfig> CreateIVarValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarValidateConfig.AddType(builder, Type);
			return IVarValidateConfig.EndIVarValidateConfig(builder);
		}

		// Token: 0x06015F57 RID: 89943 RVA: 0x00327FDE File Offset: 0x003261DE
		public static void StartIVarValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015F58 RID: 89944 RVA: 0x00327FE7 File Offset: 0x003261E7
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015F59 RID: 89945 RVA: 0x00327FF2 File Offset: 0x003261F2
		public static Offset<IVarValidateConfig> EndIVarValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015F5A RID: 89946 RVA: 0x00328000 File Offset: 0x00326200
		public IVarValidateConfigT UnPack()
		{
			IVarValidateConfigT varValidateConfigT = new IVarValidateConfigT();
			this.UnPackTo(varValidateConfigT);
			return varValidateConfigT;
		}

		// Token: 0x06015F5B RID: 89947 RVA: 0x0032801B File Offset: 0x0032621B
		public void UnPackTo(IVarValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015F5C RID: 89948 RVA: 0x0032802C File Offset: 0x0032622C
		public static Offset<IVarValidateConfig> Pack(FlatBufferBuilder builder, IVarValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarValidateConfig>);
			}
			return IVarValidateConfig.CreateIVarValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400B95B RID: 47451
		private Table __p;
	}
}
