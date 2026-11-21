using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006344 RID: 25412
	public struct IAllEntityGravityDirectionConfig : IFlatbufferObject
	{
		// Token: 0x1700BBE3 RID: 48099
		// (get) Token: 0x0602B179 RID: 176505 RVA: 0x005DF98D File Offset: 0x005DDB8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B17A RID: 176506 RVA: 0x005DF99A File Offset: 0x005DDB9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B17B RID: 176507 RVA: 0x005DF9A4 File Offset: 0x005DDBA4
		public static IAllEntityGravityDirectionConfig GetRootAsIAllEntityGravityDirectionConfig(ByteBuffer _bb)
		{
			return IAllEntityGravityDirectionConfig.GetRootAsIAllEntityGravityDirectionConfig(_bb, default(IAllEntityGravityDirectionConfig));
		}

		// Token: 0x0602B17C RID: 176508 RVA: 0x005DF9C0 File Offset: 0x005DDBC0
		public static IAllEntityGravityDirectionConfig GetRootAsIAllEntityGravityDirectionConfig(ByteBuffer _bb, IAllEntityGravityDirectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B17D RID: 176509 RVA: 0x005DF9DD File Offset: 0x005DDBDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B17E RID: 176510 RVA: 0x005DF9EC File Offset: 0x005DDBEC
		public IAllEntityGravityDirectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602B17F RID: 176511 RVA: 0x005DF9FC File Offset: 0x005DDBFC
		public IEntityDirectionConfig? AllConfig(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityDirectionConfig?(default(IEntityDirectionConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BBE4 RID: 48100
		// (get) Token: 0x0602B180 RID: 176512 RVA: 0x005DFA5C File Offset: 0x005DDC5C
		public int AllConfigLength
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

		// Token: 0x0602B181 RID: 176513 RVA: 0x005DFA87 File Offset: 0x005DDC87
		public static Offset<IAllEntityGravityDirectionConfig> CreateIAllEntityGravityDirectionConfig(FlatBufferBuilder builder, VectorOffset AllConfigOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IAllEntityGravityDirectionConfig.AddAllConfig(builder, AllConfigOffset);
			return IAllEntityGravityDirectionConfig.EndIAllEntityGravityDirectionConfig(builder);
		}

		// Token: 0x0602B182 RID: 176514 RVA: 0x005DFA9D File Offset: 0x005DDC9D
		public static void StartIAllEntityGravityDirectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B183 RID: 176515 RVA: 0x005DFAA6 File Offset: 0x005DDCA6
		public static void AddAllConfig(FlatBufferBuilder builder, VectorOffset allConfigOffset)
		{
			builder.AddOffset(0, allConfigOffset.Value, 0);
		}

		// Token: 0x0602B184 RID: 176516 RVA: 0x005DFAB8 File Offset: 0x005DDCB8
		public static VectorOffset CreateAllConfigVector(FlatBufferBuilder builder, Offset<IEntityDirectionConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B185 RID: 176517 RVA: 0x005DFAF8 File Offset: 0x005DDCF8
		public static VectorOffset CreateAllConfigVectorBlock(FlatBufferBuilder builder, Offset<IEntityDirectionConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityDirectionConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B186 RID: 176518 RVA: 0x005DFB12 File Offset: 0x005DDD12
		public static VectorOffset CreateAllConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityDirectionConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityDirectionConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B187 RID: 176519 RVA: 0x005DFB30 File Offset: 0x005DDD30
		public static VectorOffset CreateAllConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityDirectionConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B188 RID: 176520 RVA: 0x005DFB49 File Offset: 0x005DDD49
		public static void StartAllConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B189 RID: 176521 RVA: 0x005DFB54 File Offset: 0x005DDD54
		public static Offset<IAllEntityGravityDirectionConfig> EndIAllEntityGravityDirectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAllEntityGravityDirectionConfig>(builder.EndTable());
		}

		// Token: 0x0602B18A RID: 176522 RVA: 0x005DFB64 File Offset: 0x005DDD64
		public IAllEntityGravityDirectionConfigT UnPack()
		{
			IAllEntityGravityDirectionConfigT allEntityGravityDirectionConfigT = new IAllEntityGravityDirectionConfigT();
			this.UnPackTo(allEntityGravityDirectionConfigT);
			return allEntityGravityDirectionConfigT;
		}

		// Token: 0x0602B18B RID: 176523 RVA: 0x005DFB80 File Offset: 0x005DDD80
		public void UnPackTo(IAllEntityGravityDirectionConfigT _o)
		{
			_o.AllConfig = new List<IEntityDirectionConfigT>();
			for (int i = 0; i < this.AllConfigLength; i++)
			{
				_o.AllConfig.Add((this.AllConfig(i) != null) ? this.AllConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602B18C RID: 176524 RVA: 0x005DFBE0 File Offset: 0x005DDDE0
		public static Offset<IAllEntityGravityDirectionConfig> Pack(FlatBufferBuilder builder, IAllEntityGravityDirectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAllEntityGravityDirectionConfig>);
			}
			VectorOffset allConfigOffset = default(VectorOffset);
			if (_o.AllConfig != null)
			{
				Offset<IEntityDirectionConfig>[] array = new Offset<IEntityDirectionConfig>[_o.AllConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityDirectionConfig.Pack(builder, _o.AllConfig[i]);
				}
				allConfigOffset = IAllEntityGravityDirectionConfig.CreateAllConfigVector(builder, array);
			}
			return IAllEntityGravityDirectionConfig.CreateIAllEntityGravityDirectionConfig(builder, allConfigOffset);
		}

		// Token: 0x04010407 RID: 66567
		private Table __p;
	}
}
