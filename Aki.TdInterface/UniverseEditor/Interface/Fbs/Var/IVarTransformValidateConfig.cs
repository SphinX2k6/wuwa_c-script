using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F1F RID: 16159
	public struct IVarTransformValidateConfig : IFlatbufferObject
	{
		// Token: 0x17006D6D RID: 28013
		// (get) Token: 0x06015F3D RID: 89917 RVA: 0x00327DA6 File Offset: 0x00325FA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F3E RID: 89918 RVA: 0x00327DB3 File Offset: 0x00325FB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F3F RID: 89919 RVA: 0x00327DBC File Offset: 0x00325FBC
		public static IVarTransformValidateConfig GetRootAsIVarTransformValidateConfig(ByteBuffer _bb)
		{
			return IVarTransformValidateConfig.GetRootAsIVarTransformValidateConfig(_bb, default(IVarTransformValidateConfig));
		}

		// Token: 0x06015F40 RID: 89920 RVA: 0x00327DD8 File Offset: 0x00325FD8
		public static IVarTransformValidateConfig GetRootAsIVarTransformValidateConfig(ByteBuffer _bb, IVarTransformValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F41 RID: 89921 RVA: 0x00327DF5 File Offset: 0x00325FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F42 RID: 89922 RVA: 0x00327E04 File Offset: 0x00326004
		public IVarTransformValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D6E RID: 28014
		// (get) Token: 0x06015F43 RID: 89923 RVA: 0x00327E14 File Offset: 0x00326014
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

		// Token: 0x06015F44 RID: 89924 RVA: 0x00327E50 File Offset: 0x00326050
		public static Offset<IVarTransformValidateConfig> CreateIVarTransformValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarTransformValidateConfig.AddType(builder, Type);
			return IVarTransformValidateConfig.EndIVarTransformValidateConfig(builder);
		}

		// Token: 0x06015F45 RID: 89925 RVA: 0x00327E66 File Offset: 0x00326066
		public static void StartIVarTransformValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015F46 RID: 89926 RVA: 0x00327E6F File Offset: 0x0032606F
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015F47 RID: 89927 RVA: 0x00327E7A File Offset: 0x0032607A
		public static Offset<IVarTransformValidateConfig> EndIVarTransformValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarTransformValidateConfig>(builder.EndTable());
		}

		// Token: 0x06015F48 RID: 89928 RVA: 0x00327E88 File Offset: 0x00326088
		public IVarTransformValidateConfigT UnPack()
		{
			IVarTransformValidateConfigT varTransformValidateConfigT = new IVarTransformValidateConfigT();
			this.UnPackTo(varTransformValidateConfigT);
			return varTransformValidateConfigT;
		}

		// Token: 0x06015F49 RID: 89929 RVA: 0x00327EA3 File Offset: 0x003260A3
		public void UnPackTo(IVarTransformValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015F4A RID: 89930 RVA: 0x00327EB4 File Offset: 0x003260B4
		public static Offset<IVarTransformValidateConfig> Pack(FlatBufferBuilder builder, IVarTransformValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarTransformValidateConfig>);
			}
			return IVarTransformValidateConfig.CreateIVarTransformValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400B959 RID: 47449
		private Table __p;
	}
}
