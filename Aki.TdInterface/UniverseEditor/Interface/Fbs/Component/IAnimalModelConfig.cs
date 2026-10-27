using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EAD RID: 20141
	public struct IAnimalModelConfig : IFlatbufferObject
	{
		// Token: 0x17009083 RID: 36995
		// (get) Token: 0x0601FB78 RID: 129912 RVA: 0x0046A843 File Offset: 0x00468A43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB79 RID: 129913 RVA: 0x0046A850 File Offset: 0x00468A50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB7A RID: 129914 RVA: 0x0046A858 File Offset: 0x00468A58
		public static IAnimalModelConfig GetRootAsIAnimalModelConfig(ByteBuffer _bb)
		{
			return IAnimalModelConfig.GetRootAsIAnimalModelConfig(_bb, default(IAnimalModelConfig));
		}

		// Token: 0x0601FB7B RID: 129915 RVA: 0x0046A874 File Offset: 0x00468A74
		public static IAnimalModelConfig GetRootAsIAnimalModelConfig(ByteBuffer _bb, IAnimalModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB7C RID: 129916 RVA: 0x0046A891 File Offset: 0x00468A91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB7D RID: 129917 RVA: 0x0046A8A0 File Offset: 0x00468AA0
		public IAnimalModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009084 RID: 36996
		// (get) Token: 0x0601FB7E RID: 129918 RVA: 0x0046A8B0 File Offset: 0x00468AB0
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

		// Token: 0x0601FB7F RID: 129919 RVA: 0x0046A8EC File Offset: 0x00468AEC
		public static Offset<IAnimalModelConfig> CreateIAnimalModelConfig(FlatBufferBuilder builder, EAnimalModelType Type = EAnimalModelType.Mesh)
		{
			builder.StartTable(1);
			IAnimalModelConfig.AddType(builder, Type);
			return IAnimalModelConfig.EndIAnimalModelConfig(builder);
		}

		// Token: 0x0601FB80 RID: 129920 RVA: 0x0046A902 File Offset: 0x00468B02
		public static void StartIAnimalModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FB81 RID: 129921 RVA: 0x0046A90B File Offset: 0x00468B0B
		public static void AddType(FlatBufferBuilder builder, EAnimalModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB82 RID: 129922 RVA: 0x0046A916 File Offset: 0x00468B16
		public static Offset<IAnimalModelConfig> EndIAnimalModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAnimalModelConfig>(builder.EndTable());
		}

		// Token: 0x0601FB83 RID: 129923 RVA: 0x0046A924 File Offset: 0x00468B24
		public IAnimalModelConfigT UnPack()
		{
			IAnimalModelConfigT animalModelConfigT = new IAnimalModelConfigT();
			this.UnPackTo(animalModelConfigT);
			return animalModelConfigT;
		}

		// Token: 0x0601FB84 RID: 129924 RVA: 0x0046A93F File Offset: 0x00468B3F
		public void UnPackTo(IAnimalModelConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FB85 RID: 129925 RVA: 0x0046A950 File Offset: 0x00468B50
		public static Offset<IAnimalModelConfig> Pack(FlatBufferBuilder builder, IAnimalModelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnimalModelConfig>);
			}
			return IAnimalModelConfig.CreateIAnimalModelConfig(builder, _o.Type);
		}

		// Token: 0x0400DC92 RID: 56466
		private Table __p;
	}
}
