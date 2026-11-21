using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C1C RID: 19484
	public struct IEntityModelConfig : IFlatbufferObject
	{
		// Token: 0x17008A1A RID: 35354
		// (get) Token: 0x0601DD28 RID: 122152 RVA: 0x0042ECA4 File Offset: 0x0042CEA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DD29 RID: 122153 RVA: 0x0042ECB1 File Offset: 0x0042CEB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DD2A RID: 122154 RVA: 0x0042ECB8 File Offset: 0x0042CEB8
		public static IEntityModelConfig GetRootAsIEntityModelConfig(ByteBuffer _bb)
		{
			return IEntityModelConfig.GetRootAsIEntityModelConfig(_bb, default(IEntityModelConfig));
		}

		// Token: 0x0601DD2B RID: 122155 RVA: 0x0042ECD4 File Offset: 0x0042CED4
		public static IEntityModelConfig GetRootAsIEntityModelConfig(ByteBuffer _bb, IEntityModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DD2C RID: 122156 RVA: 0x0042ECF1 File Offset: 0x0042CEF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DD2D RID: 122157 RVA: 0x0042ED00 File Offset: 0x0042CF00
		public IEntityModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DD2E RID: 122158 RVA: 0x0042ED10 File Offset: 0x0042CF10
		public IEntityModel? Models(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityModel?(default(IEntityModel).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008A1B RID: 35355
		// (get) Token: 0x0601DD2F RID: 122159 RVA: 0x0042ED70 File Offset: 0x0042CF70
		public int ModelsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601DD30 RID: 122160 RVA: 0x0042ED9B File Offset: 0x0042CF9B
		public static Offset<IEntityModelConfig> CreateIEntityModelConfig(FlatBufferBuilder builder, VectorOffset ModelsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityModelConfig.AddModels(builder, ModelsOffset);
			return IEntityModelConfig.EndIEntityModelConfig(builder);
		}

		// Token: 0x0601DD31 RID: 122161 RVA: 0x0042EDB1 File Offset: 0x0042CFB1
		public static void StartIEntityModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DD32 RID: 122162 RVA: 0x0042EDBA File Offset: 0x0042CFBA
		public static void AddModels(FlatBufferBuilder builder, VectorOffset modelsOffset)
		{
			builder.AddOffset(0, modelsOffset.Value, 0);
		}

		// Token: 0x0601DD33 RID: 122163 RVA: 0x0042EDCC File Offset: 0x0042CFCC
		public static VectorOffset CreateModelsVector(FlatBufferBuilder builder, Offset<IEntityModel>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DD34 RID: 122164 RVA: 0x0042EE0C File Offset: 0x0042D00C
		public static VectorOffset CreateModelsVectorBlock(FlatBufferBuilder builder, Offset<IEntityModel>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityModel>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DD35 RID: 122165 RVA: 0x0042EE26 File Offset: 0x0042D026
		public static VectorOffset CreateModelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityModel>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityModel>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DD36 RID: 122166 RVA: 0x0042EE44 File Offset: 0x0042D044
		public static VectorOffset CreateModelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityModel>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DD37 RID: 122167 RVA: 0x0042EE5D File Offset: 0x0042D05D
		public static void StartModelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DD38 RID: 122168 RVA: 0x0042EE68 File Offset: 0x0042D068
		public static Offset<IEntityModelConfig> EndIEntityModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityModelConfig>(builder.EndTable());
		}

		// Token: 0x0601DD39 RID: 122169 RVA: 0x0042EE78 File Offset: 0x0042D078
		public IEntityModelConfigT UnPack()
		{
			IEntityModelConfigT entityModelConfigT = new IEntityModelConfigT();
			this.UnPackTo(entityModelConfigT);
			return entityModelConfigT;
		}

		// Token: 0x0601DD3A RID: 122170 RVA: 0x0042EE94 File Offset: 0x0042D094
		public void UnPackTo(IEntityModelConfigT _o)
		{
			_o.Models = new List<IEntityModelT>();
			for (int i = 0; i < this.ModelsLength; i++)
			{
				_o.Models.Add((this.Models(i) != null) ? this.Models(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DD3B RID: 122171 RVA: 0x0042EEF4 File Offset: 0x0042D0F4
		public static Offset<IEntityModelConfig> Pack(FlatBufferBuilder builder, IEntityModelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityModelConfig>);
			}
			VectorOffset modelsOffset = default(VectorOffset);
			if (_o.Models != null)
			{
				Offset<IEntityModel>[] array = new Offset<IEntityModel>[_o.Models.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityModel.Pack(builder, _o.Models[i]);
				}
				modelsOffset = IEntityModelConfig.CreateModelsVector(builder, array);
			}
			return IEntityModelConfig.CreateIEntityModelConfig(builder, modelsOffset);
		}

		// Token: 0x0400D66D RID: 54893
		private Table __p;
	}
}
