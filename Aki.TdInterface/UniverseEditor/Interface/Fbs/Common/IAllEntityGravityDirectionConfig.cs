using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D10 RID: 23824
	public struct IAllEntityGravityDirectionConfig : IFlatbufferObject
	{
		// Token: 0x1700B287 RID: 45703
		// (get) Token: 0x06028B25 RID: 166693 RVA: 0x0059711D File Offset: 0x0059531D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B26 RID: 166694 RVA: 0x0059712A File Offset: 0x0059532A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B27 RID: 166695 RVA: 0x00597134 File Offset: 0x00595334
		public static IAllEntityGravityDirectionConfig GetRootAsIAllEntityGravityDirectionConfig(ByteBuffer _bb)
		{
			return IAllEntityGravityDirectionConfig.GetRootAsIAllEntityGravityDirectionConfig(_bb, default(IAllEntityGravityDirectionConfig));
		}

		// Token: 0x06028B28 RID: 166696 RVA: 0x00597150 File Offset: 0x00595350
		public static IAllEntityGravityDirectionConfig GetRootAsIAllEntityGravityDirectionConfig(ByteBuffer _bb, IAllEntityGravityDirectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B29 RID: 166697 RVA: 0x0059716D File Offset: 0x0059536D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B2A RID: 166698 RVA: 0x0059717C File Offset: 0x0059537C
		public IAllEntityGravityDirectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06028B2B RID: 166699 RVA: 0x0059718C File Offset: 0x0059538C
		public IEntityDirectionConfig? AllConfig(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityDirectionConfig?(default(IEntityDirectionConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B288 RID: 45704
		// (get) Token: 0x06028B2C RID: 166700 RVA: 0x005971EC File Offset: 0x005953EC
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

		// Token: 0x06028B2D RID: 166701 RVA: 0x00597217 File Offset: 0x00595417
		public static Offset<IAllEntityGravityDirectionConfig> CreateIAllEntityGravityDirectionConfig(FlatBufferBuilder builder, VectorOffset AllConfigOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IAllEntityGravityDirectionConfig.AddAllConfig(builder, AllConfigOffset);
			return IAllEntityGravityDirectionConfig.EndIAllEntityGravityDirectionConfig(builder);
		}

		// Token: 0x06028B2E RID: 166702 RVA: 0x0059722D File Offset: 0x0059542D
		public static void StartIAllEntityGravityDirectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028B2F RID: 166703 RVA: 0x00597236 File Offset: 0x00595436
		public static void AddAllConfig(FlatBufferBuilder builder, VectorOffset allConfigOffset)
		{
			builder.AddOffset(0, allConfigOffset.Value, 0);
		}

		// Token: 0x06028B30 RID: 166704 RVA: 0x00597248 File Offset: 0x00595448
		public static VectorOffset CreateAllConfigVector(FlatBufferBuilder builder, Offset<IEntityDirectionConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028B31 RID: 166705 RVA: 0x00597288 File Offset: 0x00595488
		public static VectorOffset CreateAllConfigVectorBlock(FlatBufferBuilder builder, Offset<IEntityDirectionConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityDirectionConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028B32 RID: 166706 RVA: 0x005972A2 File Offset: 0x005954A2
		public static VectorOffset CreateAllConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityDirectionConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityDirectionConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028B33 RID: 166707 RVA: 0x005972C0 File Offset: 0x005954C0
		public static VectorOffset CreateAllConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityDirectionConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028B34 RID: 166708 RVA: 0x005972D9 File Offset: 0x005954D9
		public static void StartAllConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028B35 RID: 166709 RVA: 0x005972E4 File Offset: 0x005954E4
		public static Offset<IAllEntityGravityDirectionConfig> EndIAllEntityGravityDirectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAllEntityGravityDirectionConfig>(builder.EndTable());
		}

		// Token: 0x06028B36 RID: 166710 RVA: 0x005972F4 File Offset: 0x005954F4
		public IAllEntityGravityDirectionConfigT UnPack()
		{
			IAllEntityGravityDirectionConfigT allEntityGravityDirectionConfigT = new IAllEntityGravityDirectionConfigT();
			this.UnPackTo(allEntityGravityDirectionConfigT);
			return allEntityGravityDirectionConfigT;
		}

		// Token: 0x06028B37 RID: 166711 RVA: 0x00597310 File Offset: 0x00595510
		public void UnPackTo(IAllEntityGravityDirectionConfigT _o)
		{
			_o.AllConfig = new List<IEntityDirectionConfigT>();
			for (int i = 0; i < this.AllConfigLength; i++)
			{
				_o.AllConfig.Add((this.AllConfig(i) != null) ? this.AllConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028B38 RID: 166712 RVA: 0x00597370 File Offset: 0x00595570
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

		// Token: 0x0400F6B8 RID: 63160
		private Table __p;
	}
}
