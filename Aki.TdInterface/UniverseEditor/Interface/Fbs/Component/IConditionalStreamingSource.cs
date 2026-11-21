using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005547 RID: 21831
	public struct IConditionalStreamingSource : IFlatbufferObject
	{
		// Token: 0x17009C13 RID: 39955
		// (get) Token: 0x06022A23 RID: 141859 RVA: 0x004C5323 File Offset: 0x004C3523
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A24 RID: 141860 RVA: 0x004C5330 File Offset: 0x004C3530
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A25 RID: 141861 RVA: 0x004C5338 File Offset: 0x004C3538
		public static IConditionalStreamingSource GetRootAsIConditionalStreamingSource(ByteBuffer _bb)
		{
			return IConditionalStreamingSource.GetRootAsIConditionalStreamingSource(_bb, default(IConditionalStreamingSource));
		}

		// Token: 0x06022A26 RID: 141862 RVA: 0x004C5354 File Offset: 0x004C3554
		public static IConditionalStreamingSource GetRootAsIConditionalStreamingSource(ByteBuffer _bb, IConditionalStreamingSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A27 RID: 141863 RVA: 0x004C5371 File Offset: 0x004C3571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A28 RID: 141864 RVA: 0x004C5380 File Offset: 0x004C3580
		public IConditionalStreamingSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C14 RID: 39956
		// (get) Token: 0x06022A29 RID: 141865 RVA: 0x004C5390 File Offset: 0x004C3590
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

		// Token: 0x06022A2A RID: 141866 RVA: 0x004C53CC File Offset: 0x004C35CC
		public IConditionalStreamingSourceConfig? StreamingSourceConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IConditionalStreamingSourceConfig?(default(IConditionalStreamingSourceConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C15 RID: 39957
		// (get) Token: 0x06022A2B RID: 141867 RVA: 0x004C542C File Offset: 0x004C362C
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

		// Token: 0x06022A2C RID: 141868 RVA: 0x004C5457 File Offset: 0x004C3657
		public static Offset<IConditionalStreamingSource> CreateIConditionalStreamingSource(FlatBufferBuilder builder, EStreamingSourceMode Type = EStreamingSourceMode.Fixed, VectorOffset StreamingSourceConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditionalStreamingSource.AddStreamingSourceConfigs(builder, StreamingSourceConfigsOffset);
			IConditionalStreamingSource.AddType(builder, Type);
			return IConditionalStreamingSource.EndIConditionalStreamingSource(builder);
		}

		// Token: 0x06022A2D RID: 141869 RVA: 0x004C5474 File Offset: 0x004C3674
		public static void StartIConditionalStreamingSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022A2E RID: 141870 RVA: 0x004C547D File Offset: 0x004C367D
		public static void AddType(FlatBufferBuilder builder, EStreamingSourceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022A2F RID: 141871 RVA: 0x004C5488 File Offset: 0x004C3688
		public static void AddStreamingSourceConfigs(FlatBufferBuilder builder, VectorOffset streamingSourceConfigsOffset)
		{
			builder.AddOffset(1, streamingSourceConfigsOffset.Value, 0);
		}

		// Token: 0x06022A30 RID: 141872 RVA: 0x004C5498 File Offset: 0x004C3698
		public static VectorOffset CreateStreamingSourceConfigsVector(FlatBufferBuilder builder, Offset<IConditionalStreamingSourceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022A31 RID: 141873 RVA: 0x004C54D8 File Offset: 0x004C36D8
		public static VectorOffset CreateStreamingSourceConfigsVectorBlock(FlatBufferBuilder builder, Offset<IConditionalStreamingSourceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionalStreamingSourceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022A32 RID: 141874 RVA: 0x004C54F2 File Offset: 0x004C36F2
		public static VectorOffset CreateStreamingSourceConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionalStreamingSourceConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionalStreamingSourceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022A33 RID: 141875 RVA: 0x004C5510 File Offset: 0x004C3710
		public static VectorOffset CreateStreamingSourceConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionalStreamingSourceConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022A34 RID: 141876 RVA: 0x004C5529 File Offset: 0x004C3729
		public static void StartStreamingSourceConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022A35 RID: 141877 RVA: 0x004C5534 File Offset: 0x004C3734
		public static Offset<IConditionalStreamingSource> EndIConditionalStreamingSource(FlatBufferBuilder builder)
		{
			return new Offset<IConditionalStreamingSource>(builder.EndTable());
		}

		// Token: 0x06022A36 RID: 141878 RVA: 0x004C5544 File Offset: 0x004C3744
		public IConditionalStreamingSourceT UnPack()
		{
			IConditionalStreamingSourceT conditionalStreamingSourceT = new IConditionalStreamingSourceT();
			this.UnPackTo(conditionalStreamingSourceT);
			return conditionalStreamingSourceT;
		}

		// Token: 0x06022A37 RID: 141879 RVA: 0x004C5560 File Offset: 0x004C3760
		public void UnPackTo(IConditionalStreamingSourceT _o)
		{
			_o.Type = this.Type;
			_o.StreamingSourceConfigs = new List<IConditionalStreamingSourceConfigT>();
			for (int i = 0; i < this.StreamingSourceConfigsLength; i++)
			{
				_o.StreamingSourceConfigs.Add((this.StreamingSourceConfigs(i) != null) ? this.StreamingSourceConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06022A38 RID: 141880 RVA: 0x004C55CC File Offset: 0x004C37CC
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

		// Token: 0x0400EB96 RID: 60310
		private Table __p;
	}
}
