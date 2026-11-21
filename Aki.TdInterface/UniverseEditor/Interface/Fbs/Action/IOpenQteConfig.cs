using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007382 RID: 29570
	public struct IOpenQteConfig : IFlatbufferObject
	{
		// Token: 0x1700D8F0 RID: 55536
		// (get) Token: 0x06033A11 RID: 211473 RVA: 0x006F5B49 File Offset: 0x006F3D49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033A12 RID: 211474 RVA: 0x006F5B56 File Offset: 0x006F3D56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033A13 RID: 211475 RVA: 0x006F5B60 File Offset: 0x006F3D60
		public static IOpenQteConfig GetRootAsIOpenQteConfig(ByteBuffer _bb)
		{
			return IOpenQteConfig.GetRootAsIOpenQteConfig(_bb, default(IOpenQteConfig));
		}

		// Token: 0x06033A14 RID: 211476 RVA: 0x006F5B7C File Offset: 0x006F3D7C
		public static IOpenQteConfig GetRootAsIOpenQteConfig(ByteBuffer _bb, IOpenQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033A15 RID: 211477 RVA: 0x006F5B99 File Offset: 0x006F3D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A16 RID: 211478 RVA: 0x006F5BA8 File Offset: 0x006F3DA8
		public IOpenQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8F1 RID: 55537
		// (get) Token: 0x06033A17 RID: 211479 RVA: 0x006F5BB8 File Offset: 0x006F3DB8
		public EOpenQteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOpenQteType.PanelQte;
				}
				return (EOpenQteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033A18 RID: 211480 RVA: 0x006F5BF4 File Offset: 0x006F3DF4
		public static Offset<IOpenQteConfig> CreateIOpenQteConfig(FlatBufferBuilder builder, EOpenQteType Type = EOpenQteType.PanelQte)
		{
			builder.StartTable(1);
			IOpenQteConfig.AddType(builder, Type);
			return IOpenQteConfig.EndIOpenQteConfig(builder);
		}

		// Token: 0x06033A19 RID: 211481 RVA: 0x006F5C0A File Offset: 0x006F3E0A
		public static void StartIOpenQteConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033A1A RID: 211482 RVA: 0x006F5C13 File Offset: 0x006F3E13
		public static void AddType(FlatBufferBuilder builder, EOpenQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033A1B RID: 211483 RVA: 0x006F5C1E File Offset: 0x006F3E1E
		public static Offset<IOpenQteConfig> EndIOpenQteConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQteConfig>(builder.EndTable());
		}

		// Token: 0x06033A1C RID: 211484 RVA: 0x006F5C2C File Offset: 0x006F3E2C
		public IOpenQteConfigT UnPack()
		{
			IOpenQteConfigT openQteConfigT = new IOpenQteConfigT();
			this.UnPackTo(openQteConfigT);
			return openQteConfigT;
		}

		// Token: 0x06033A1D RID: 211485 RVA: 0x006F5C47 File Offset: 0x006F3E47
		public void UnPackTo(IOpenQteConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033A1E RID: 211486 RVA: 0x006F5C58 File Offset: 0x006F3E58
		public static Offset<IOpenQteConfig> Pack(FlatBufferBuilder builder, IOpenQteConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenQteConfig>);
			}
			return IOpenQteConfig.CreateIOpenQteConfig(builder, _o.Type);
		}

		// Token: 0x04012476 RID: 74870
		private Table __p;
	}
}
