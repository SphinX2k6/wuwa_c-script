using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1B RID: 27675
	public struct IOpenQteConfig : IFlatbufferObject
	{
		// Token: 0x1700CDD5 RID: 52693
		// (get) Token: 0x06030ABD RID: 199357 RVA: 0x0069B84D File Offset: 0x00699A4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030ABE RID: 199358 RVA: 0x0069B85A File Offset: 0x00699A5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030ABF RID: 199359 RVA: 0x0069B864 File Offset: 0x00699A64
		public static IOpenQteConfig GetRootAsIOpenQteConfig(ByteBuffer _bb)
		{
			return IOpenQteConfig.GetRootAsIOpenQteConfig(_bb, default(IOpenQteConfig));
		}

		// Token: 0x06030AC0 RID: 199360 RVA: 0x0069B880 File Offset: 0x00699A80
		public static IOpenQteConfig GetRootAsIOpenQteConfig(ByteBuffer _bb, IOpenQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030AC1 RID: 199361 RVA: 0x0069B89D File Offset: 0x00699A9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030AC2 RID: 199362 RVA: 0x0069B8AC File Offset: 0x00699AAC
		public IOpenQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDD6 RID: 52694
		// (get) Token: 0x06030AC3 RID: 199363 RVA: 0x0069B8BC File Offset: 0x00699ABC
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

		// Token: 0x06030AC4 RID: 199364 RVA: 0x0069B8F8 File Offset: 0x00699AF8
		public static Offset<IOpenQteConfig> CreateIOpenQteConfig(FlatBufferBuilder builder, EOpenQteType Type = EOpenQteType.PanelQte)
		{
			builder.StartTable(1);
			IOpenQteConfig.AddType(builder, Type);
			return IOpenQteConfig.EndIOpenQteConfig(builder);
		}

		// Token: 0x06030AC5 RID: 199365 RVA: 0x0069B90E File Offset: 0x00699B0E
		public static void StartIOpenQteConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030AC6 RID: 199366 RVA: 0x0069B917 File Offset: 0x00699B17
		public static void AddType(FlatBufferBuilder builder, EOpenQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030AC7 RID: 199367 RVA: 0x0069B922 File Offset: 0x00699B22
		public static Offset<IOpenQteConfig> EndIOpenQteConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQteConfig>(builder.EndTable());
		}

		// Token: 0x06030AC8 RID: 199368 RVA: 0x0069B930 File Offset: 0x00699B30
		public IOpenQteConfigT UnPack()
		{
			IOpenQteConfigT openQteConfigT = new IOpenQteConfigT();
			this.UnPackTo(openQteConfigT);
			return openQteConfigT;
		}

		// Token: 0x06030AC9 RID: 199369 RVA: 0x0069B94B File Offset: 0x00699B4B
		public void UnPackTo(IOpenQteConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030ACA RID: 199370 RVA: 0x0069B95C File Offset: 0x00699B5C
		public static Offset<IOpenQteConfig> Pack(FlatBufferBuilder builder, IOpenQteConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenQteConfig>);
			}
			return IOpenQteConfig.CreateIOpenQteConfig(builder, _o.Type);
		}

		// Token: 0x0401151F RID: 70943
		private Table __p;
	}
}
