using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D8B RID: 19851
	public struct IFrequencyDetectGraphicsSegment : IFlatbufferObject
	{
		// Token: 0x17008E08 RID: 36360
		// (get) Token: 0x0601EC79 RID: 126073 RVA: 0x0044DC33 File Offset: 0x0044BE33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC7A RID: 126074 RVA: 0x0044DC40 File Offset: 0x0044BE40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC7B RID: 126075 RVA: 0x0044DC48 File Offset: 0x0044BE48
		public static IFrequencyDetectGraphicsSegment GetRootAsIFrequencyDetectGraphicsSegment(ByteBuffer _bb)
		{
			return IFrequencyDetectGraphicsSegment.GetRootAsIFrequencyDetectGraphicsSegment(_bb, default(IFrequencyDetectGraphicsSegment));
		}

		// Token: 0x0601EC7C RID: 126076 RVA: 0x0044DC64 File Offset: 0x0044BE64
		public static IFrequencyDetectGraphicsSegment GetRootAsIFrequencyDetectGraphicsSegment(ByteBuffer _bb, IFrequencyDetectGraphicsSegment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC7D RID: 126077 RVA: 0x0044DC81 File Offset: 0x0044BE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC7E RID: 126078 RVA: 0x0044DC90 File Offset: 0x0044BE90
		public IFrequencyDetectGraphicsSegment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601EC7F RID: 126079 RVA: 0x0044DCA0 File Offset: 0x0044BEA0
		public string Points(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008E09 RID: 36361
		// (get) Token: 0x0601EC80 RID: 126080 RVA: 0x0044DCDC File Offset: 0x0044BEDC
		public int PointsLength
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

		// Token: 0x0601EC81 RID: 126081 RVA: 0x0044DD07 File Offset: 0x0044BF07
		public static Offset<IFrequencyDetectGraphicsSegment> CreateIFrequencyDetectGraphicsSegment(FlatBufferBuilder builder, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFrequencyDetectGraphicsSegment.AddPoints(builder, PointsOffset);
			return IFrequencyDetectGraphicsSegment.EndIFrequencyDetectGraphicsSegment(builder);
		}

		// Token: 0x0601EC82 RID: 126082 RVA: 0x0044DD1D File Offset: 0x0044BF1D
		public static void StartIFrequencyDetectGraphicsSegment(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EC83 RID: 126083 RVA: 0x0044DD26 File Offset: 0x0044BF26
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(0, pointsOffset.Value, 0);
		}

		// Token: 0x0601EC84 RID: 126084 RVA: 0x0044DD38 File Offset: 0x0044BF38
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EC85 RID: 126085 RVA: 0x0044DD78 File Offset: 0x0044BF78
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC86 RID: 126086 RVA: 0x0044DD92 File Offset: 0x0044BF92
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC87 RID: 126087 RVA: 0x0044DDB0 File Offset: 0x0044BFB0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EC88 RID: 126088 RVA: 0x0044DDC9 File Offset: 0x0044BFC9
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EC89 RID: 126089 RVA: 0x0044DDD4 File Offset: 0x0044BFD4
		public static Offset<IFrequencyDetectGraphicsSegment> EndIFrequencyDetectGraphicsSegment(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectGraphicsSegment>(builder.EndTable());
		}

		// Token: 0x0601EC8A RID: 126090 RVA: 0x0044DDE4 File Offset: 0x0044BFE4
		public IFrequencyDetectGraphicsSegmentT UnPack()
		{
			IFrequencyDetectGraphicsSegmentT frequencyDetectGraphicsSegmentT = new IFrequencyDetectGraphicsSegmentT();
			this.UnPackTo(frequencyDetectGraphicsSegmentT);
			return frequencyDetectGraphicsSegmentT;
		}

		// Token: 0x0601EC8B RID: 126091 RVA: 0x0044DE00 File Offset: 0x0044C000
		public void UnPackTo(IFrequencyDetectGraphicsSegmentT _o)
		{
			_o.Points = new List<string>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add(this.Points(i));
			}
		}

		// Token: 0x0601EC8C RID: 126092 RVA: 0x0044DE3C File Offset: 0x0044C03C
		public static Offset<IFrequencyDetectGraphicsSegment> Pack(FlatBufferBuilder builder, IFrequencyDetectGraphicsSegmentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectGraphicsSegment>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				StringOffset[] array = new StringOffset[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Points[i]);
				}
				pointsOffset = IFrequencyDetectGraphicsSegment.CreatePointsVector(builder, array);
			}
			return IFrequencyDetectGraphicsSegment.CreateIFrequencyDetectGraphicsSegment(builder, pointsOffset);
		}

		// Token: 0x0400D9E0 RID: 55776
		private Table __p;
	}
}
