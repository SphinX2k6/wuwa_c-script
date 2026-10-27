using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE8 RID: 20456
	public struct IConditionalStreamingSource : IFlatbufferObject
	{
		// Token: 0x17009432 RID: 37938
		// (get) Token: 0x06020B03 RID: 133891 RVA: 0x0048B8D3 File Offset: 0x00489AD3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B04 RID: 133892 RVA: 0x0048B8E0 File Offset: 0x00489AE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B05 RID: 133893 RVA: 0x0048B8E8 File Offset: 0x00489AE8
		public static IConditionalStreamingSource GetRootAsIConditionalStreamingSource(ByteBuffer _bb)
		{
			return IConditionalStreamingSource.GetRootAsIConditionalStreamingSource(_bb, default(IConditionalStreamingSource));
		}

		// Token: 0x06020B06 RID: 133894 RVA: 0x0048B904 File Offset: 0x00489B04
		public static IConditionalStreamingSource GetRootAsIConditionalStreamingSource(ByteBuffer _bb, IConditionalStreamingSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B07 RID: 133895 RVA: 0x0048B921 File Offset: 0x00489B21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B08 RID: 133896 RVA: 0x0048B930 File Offset: 0x00489B30
		public IConditionalStreamingSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009433 RID: 37939
		// (get) Token: 0x06020B09 RID: 133897 RVA: 0x0048B940 File Offset: 0x00489B40
		public EStreamingSourceMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStreamingSourceMode.Fixed;
				}
				return (EStreamingSourceMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020B0A RID: 133898 RVA: 0x0048B97C File Offset: 0x00489B7C
		public IConditionalStreamingSourceConfig? StreamingSourceConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionalStreamingSourceConfig?(default(IConditionalStreamingSourceConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009434 RID: 37940
		// (get) Token: 0x06020B0B RID: 133899 RVA: 0x0048B9DC File Offset: 0x00489BDC
		public int StreamingSourceConfigsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06020B0C RID: 133900 RVA: 0x0048BA07 File Offset: 0x00489C07
		public static Offset<IConditionalStreamingSource> CreateIConditionalStreamingSource(FlatBufferBuilder builder, EStreamingSourceMode Type = EStreamingSourceMode.Fixed, VectorOffset StreamingSourceConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditionalStreamingSource.AddStreamingSourceConfigs(builder, StreamingSourceConfigsOffset);
			IConditionalStreamingSource.AddType(builder, Type);
			return IConditionalStreamingSource.EndIConditionalStreamingSource(builder);
		}

		// Token: 0x06020B0D RID: 133901 RVA: 0x0048BA24 File Offset: 0x00489C24
		public static void StartIConditionalStreamingSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020B0E RID: 133902 RVA: 0x0048BA2D File Offset: 0x00489C2D
		public static void AddType(FlatBufferBuilder builder, EStreamingSourceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020B0F RID: 133903 RVA: 0x0048BA38 File Offset: 0x00489C38
		public static void AddStreamingSourceConfigs(FlatBufferBuilder builder, VectorOffset streamingSourceConfigsOffset)
		{
			builder.AddOffset(1, streamingSourceConfigsOffset.Value, 0);
		}

		// Token: 0x06020B10 RID: 133904 RVA: 0x0048BA48 File Offset: 0x00489C48
		public static VectorOffset CreateStreamingSourceConfigsVector(FlatBufferBuilder builder, Offset<IConditionalStreamingSourceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020B11 RID: 133905 RVA: 0x0048BA88 File Offset: 0x00489C88
		public static VectorOffset CreateStreamingSourceConfigsVectorBlock(FlatBufferBuilder builder, Offset<IConditionalStreamingSourceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionalStreamingSourceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020B12 RID: 133906 RVA: 0x0048BAA2 File Offset: 0x00489CA2
		public static VectorOffset CreateStreamingSourceConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionalStreamingSourceConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionalStreamingSourceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020B13 RID: 133907 RVA: 0x0048BAC0 File Offset: 0x00489CC0
		public static VectorOffset CreateStreamingSourceConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionalStreamingSourceConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020B14 RID: 133908 RVA: 0x0048BAD9 File Offset: 0x00489CD9
		public static void StartStreamingSourceConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020B15 RID: 133909 RVA: 0x0048BAE4 File Offset: 0x00489CE4
		public static Offset<IConditionalStreamingSource> EndIConditionalStreamingSource(FlatBufferBuilder builder)
		{
			return new Offset<IConditionalStreamingSource>(builder.EndTable());
		}

		// Token: 0x06020B16 RID: 133910 RVA: 0x0048BAF4 File Offset: 0x00489CF4
		public IConditionalStreamingSourceT UnPack()
		{
			IConditionalStreamingSourceT conditionalStreamingSourceT = new IConditionalStreamingSourceT();
			this.UnPackTo(conditionalStreamingSourceT);
			return conditionalStreamingSourceT;
		}

		// Token: 0x06020B17 RID: 133911 RVA: 0x0048BB10 File Offset: 0x00489D10
		public void UnPackTo(IConditionalStreamingSourceT _o)
		{
			_o.Type = this.Type;
			_o.StreamingSourceConfigs = new List<IConditionalStreamingSourceConfigT>();
			for (int i = 0; i < this.StreamingSourceConfigsLength; i++)
			{
				_o.StreamingSourceConfigs.Add((this.StreamingSourceConfigs(i) != null) ? this.StreamingSourceConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06020B18 RID: 133912 RVA: 0x0048BB7C File Offset: 0x00489D7C
		public static Offset<IConditionalStreamingSource> Pack(FlatBufferBuilder builder, IConditionalStreamingSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionalStreamingSource>);
			}
			VectorOffset streamingSourceConfigsOffset = default(VectorOffset);
			if (_o.StreamingSourceConfigs != null)
			{
				Offset<IConditionalStreamingSourceConfig>[] array = new Offset<IConditionalStreamingSourceConfig>[_o.StreamingSourceConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionalStreamingSourceConfig.Pack(builder, _o.StreamingSourceConfigs[i]);
				}
				streamingSourceConfigsOffset = IConditionalStreamingSource.CreateStreamingSourceConfigsVector(builder, array);
			}
			return IConditionalStreamingSource.CreateIConditionalStreamingSource(builder, _o.Type, streamingSourceConfigsOffset);
		}

		// Token: 0x0400DFA0 RID: 57248
		private Table __p;
	}
}
