using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B4 RID: 18356
	public struct IEntityModelConfig : IFlatbufferObject
	{
		// Token: 0x170083D9 RID: 33753
		// (get) Token: 0x0601C553 RID: 116051 RVA: 0x00402A08 File Offset: 0x00400C08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C554 RID: 116052 RVA: 0x00402A15 File Offset: 0x00400C15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C555 RID: 116053 RVA: 0x00402A1C File Offset: 0x00400C1C
		public static IEntityModelConfig GetRootAsIEntityModelConfig(ByteBuffer _bb)
		{
			return IEntityModelConfig.GetRootAsIEntityModelConfig(_bb, default(IEntityModelConfig));
		}

		// Token: 0x0601C556 RID: 116054 RVA: 0x00402A38 File Offset: 0x00400C38
		public static IEntityModelConfig GetRootAsIEntityModelConfig(ByteBuffer _bb, IEntityModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C557 RID: 116055 RVA: 0x00402A55 File Offset: 0x00400C55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C558 RID: 116056 RVA: 0x00402A64 File Offset: 0x00400C64
		public IEntityModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C559 RID: 116057 RVA: 0x00402A74 File Offset: 0x00400C74
		public IEntityModel? Models(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityModel?(default(IEntityModel).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170083DA RID: 33754
		// (get) Token: 0x0601C55A RID: 116058 RVA: 0x00402AD4 File Offset: 0x00400CD4
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

		// Token: 0x0601C55B RID: 116059 RVA: 0x00402AFF File Offset: 0x00400CFF
		public static Offset<IEntityModelConfig> CreateIEntityModelConfig(FlatBufferBuilder builder, VectorOffset ModelsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityModelConfig.AddModels(builder, ModelsOffset);
			return IEntityModelConfig.EndIEntityModelConfig(builder);
		}

		// Token: 0x0601C55C RID: 116060 RVA: 0x00402B15 File Offset: 0x00400D15
		public static void StartIEntityModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C55D RID: 116061 RVA: 0x00402B1E File Offset: 0x00400D1E
		public static void AddModels(FlatBufferBuilder builder, VectorOffset modelsOffset)
		{
			builder.AddOffset(0, modelsOffset.Value, 0);
		}

		// Token: 0x0601C55E RID: 116062 RVA: 0x00402B30 File Offset: 0x00400D30
		public static VectorOffset CreateModelsVector(FlatBufferBuilder builder, Offset<IEntityModel>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C55F RID: 116063 RVA: 0x00402B70 File Offset: 0x00400D70
		public static VectorOffset CreateModelsVectorBlock(FlatBufferBuilder builder, Offset<IEntityModel>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityModel>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C560 RID: 116064 RVA: 0x00402B8A File Offset: 0x00400D8A
		public static VectorOffset CreateModelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityModel>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityModel>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C561 RID: 116065 RVA: 0x00402BA8 File Offset: 0x00400DA8
		public static VectorOffset CreateModelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityModel>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C562 RID: 116066 RVA: 0x00402BC1 File Offset: 0x00400DC1
		public static void StartModelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C563 RID: 116067 RVA: 0x00402BCC File Offset: 0x00400DCC
		public static Offset<IEntityModelConfig> EndIEntityModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityModelConfig>(builder.EndTable());
		}

		// Token: 0x0601C564 RID: 116068 RVA: 0x00402BDC File Offset: 0x00400DDC
		public IEntityModelConfigT UnPack()
		{
			IEntityModelConfigT entityModelConfigT = new IEntityModelConfigT();
			this.UnPackTo(entityModelConfigT);
			return entityModelConfigT;
		}

		// Token: 0x0601C565 RID: 116069 RVA: 0x00402BF8 File Offset: 0x00400DF8
		public void UnPackTo(IEntityModelConfigT _o)
		{
			_o.Models = new List<IEntityModelT>();
			for (int i = 0; i < this.ModelsLength; i++)
			{
				_o.Models.Add((this.Models(i) != null) ? this.Models(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C566 RID: 116070 RVA: 0x00402C58 File Offset: 0x00400E58
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

		// Token: 0x0400CC37 RID: 52279
		private Table __p;
	}
}
