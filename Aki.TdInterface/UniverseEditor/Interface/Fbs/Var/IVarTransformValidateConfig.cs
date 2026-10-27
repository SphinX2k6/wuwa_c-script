using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B1D RID: 15133
	public struct IVarTransformValidateConfig : IFlatbufferObject
	{
		// Token: 0x170067D2 RID: 26578
		// (get) Token: 0x06014A93 RID: 84627 RVA: 0x00301B16 File Offset: 0x002FFD16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014A94 RID: 84628 RVA: 0x00301B23 File Offset: 0x002FFD23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014A95 RID: 84629 RVA: 0x00301B2C File Offset: 0x002FFD2C
		public static IVarTransformValidateConfig GetRootAsIVarTransformValidateConfig(ByteBuffer _bb)
		{
			return IVarTransformValidateConfig.GetRootAsIVarTransformValidateConfig(_bb, default(IVarTransformValidateConfig));
		}

		// Token: 0x06014A96 RID: 84630 RVA: 0x00301B48 File Offset: 0x002FFD48
		public static IVarTransformValidateConfig GetRootAsIVarTransformValidateConfig(ByteBuffer _bb, IVarTransformValidateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014A97 RID: 84631 RVA: 0x00301B65 File Offset: 0x002FFD65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014A98 RID: 84632 RVA: 0x00301B74 File Offset: 0x002FFD74
		public IVarTransformValidateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067D3 RID: 26579
		// (get) Token: 0x06014A99 RID: 84633 RVA: 0x00301B84 File Offset: 0x002FFD84
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

		// Token: 0x06014A9A RID: 84634 RVA: 0x00301BC0 File Offset: 0x002FFDC0
		public static Offset<IVarTransformValidateConfig> CreateIVarTransformValidateConfig(FlatBufferBuilder builder, EVar Type = EVar.Boolean)
		{
			builder.StartTable(1);
			IVarTransformValidateConfig.AddType(builder, Type);
			return IVarTransformValidateConfig.EndIVarTransformValidateConfig(builder);
		}

		// Token: 0x06014A9B RID: 84635 RVA: 0x00301BD6 File Offset: 0x002FFDD6
		public static void StartIVarTransformValidateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06014A9C RID: 84636 RVA: 0x00301BDF File Offset: 0x002FFDDF
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014A9D RID: 84637 RVA: 0x00301BEA File Offset: 0x002FFDEA
		public static Offset<IVarTransformValidateConfig> EndIVarTransformValidateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IVarTransformValidateConfig>(builder.EndTable());
		}

		// Token: 0x06014A9E RID: 84638 RVA: 0x00301BF8 File Offset: 0x002FFDF8
		public IVarTransformValidateConfigT UnPack()
		{
			IVarTransformValidateConfigT varTransformValidateConfigT = new IVarTransformValidateConfigT();
			this.UnPackTo(varTransformValidateConfigT);
			return varTransformValidateConfigT;
		}

		// Token: 0x06014A9F RID: 84639 RVA: 0x00301C13 File Offset: 0x002FFE13
		public void UnPackTo(IVarTransformValidateConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06014AA0 RID: 84640 RVA: 0x00301C24 File Offset: 0x002FFE24
		public static Offset<IVarTransformValidateConfig> Pack(FlatBufferBuilder builder, IVarTransformValidateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarTransformValidateConfig>);
			}
			return IVarTransformValidateConfig.CreateIVarTransformValidateConfig(builder, _o.Type);
		}

		// Token: 0x0400AFEC RID: 45036
		private Table __p;
	}
}
