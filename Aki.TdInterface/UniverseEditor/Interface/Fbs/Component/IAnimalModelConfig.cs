using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D6 RID: 21462
	public struct IAnimalModelConfig : IFlatbufferObject
	{
		// Token: 0x170097E4 RID: 38884
		// (get) Token: 0x06021879 RID: 137337 RVA: 0x0049FCBF File Offset: 0x0049DEBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602187A RID: 137338 RVA: 0x0049FCCC File Offset: 0x0049DECC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602187B RID: 137339 RVA: 0x0049FCD4 File Offset: 0x0049DED4
		public static IAnimalModelConfig GetRootAsIAnimalModelConfig(ByteBuffer _bb)
		{
			return IAnimalModelConfig.GetRootAsIAnimalModelConfig(_bb, default(IAnimalModelConfig));
		}

		// Token: 0x0602187C RID: 137340 RVA: 0x0049FCF0 File Offset: 0x0049DEF0
		public static IAnimalModelConfig GetRootAsIAnimalModelConfig(ByteBuffer _bb, IAnimalModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602187D RID: 137341 RVA: 0x0049FD0D File Offset: 0x0049DF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602187E RID: 137342 RVA: 0x0049FD1C File Offset: 0x0049DF1C
		public IAnimalModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097E5 RID: 38885
		// (get) Token: 0x0602187F RID: 137343 RVA: 0x0049FD2C File Offset: 0x0049DF2C
		public EAnimalModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAnimalModelType.Mesh;
				}
				return (EAnimalModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021880 RID: 137344 RVA: 0x0049FD68 File Offset: 0x0049DF68
		public static Offset<IAnimalModelConfig> CreateIAnimalModelConfig(FlatBufferBuilder builder, EAnimalModelType Type = EAnimalModelType.Mesh)
		{
			builder.StartTable(1);
			IAnimalModelConfig.AddType(builder, Type);
			return IAnimalModelConfig.EndIAnimalModelConfig(builder);
		}

		// Token: 0x06021881 RID: 137345 RVA: 0x0049FD7E File Offset: 0x0049DF7E
		public static void StartIAnimalModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021882 RID: 137346 RVA: 0x0049FD87 File Offset: 0x0049DF87
		public static void AddType(FlatBufferBuilder builder, EAnimalModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021883 RID: 137347 RVA: 0x0049FD92 File Offset: 0x0049DF92
		public static Offset<IAnimalModelConfig> EndIAnimalModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalModelConfig>(builder.EndTable());
		}

		// Token: 0x06021884 RID: 137348 RVA: 0x0049FDA0 File Offset: 0x0049DFA0
		public IAnimalModelConfigT UnPack()
		{
			IAnimalModelConfigT animalModelConfigT = new IAnimalModelConfigT();
			this.UnPackTo(animalModelConfigT);
			return animalModelConfigT;
		}

		// Token: 0x06021885 RID: 137349 RVA: 0x0049FDBB File Offset: 0x0049DFBB
		public void UnPackTo(IAnimalModelConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021886 RID: 137350 RVA: 0x0049FDCC File Offset: 0x0049DFCC
		public static Offset<IAnimalModelConfig> Pack(FlatBufferBuilder builder, IAnimalModelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnimalModelConfig>);
			}
			return IAnimalModelConfig.CreateIAnimalModelConfig(builder, _o.Type);
		}

		// Token: 0x0400E82E RID: 59438
		private Table __p;
	}
}
