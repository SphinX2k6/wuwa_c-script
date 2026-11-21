using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200796B RID: 31083
	public struct ISplinePoint : IFlatbufferObject
	{
		// Token: 0x1700E3EE RID: 58350
		// (get) Token: 0x06036BD4 RID: 224212 RVA: 0x00752AA2 File Offset: 0x00750CA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036BD5 RID: 224213 RVA: 0x00752AAF File Offset: 0x00750CAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036BD6 RID: 224214 RVA: 0x00752AB8 File Offset: 0x00750CB8
		public static ISplinePoint GetRootAsISplinePoint(ByteBuffer _bb)
		{
			return ISplinePoint.GetRootAsISplinePoint(_bb, default(ISplinePoint));
		}

		// Token: 0x06036BD7 RID: 224215 RVA: 0x00752AD4 File Offset: 0x00750CD4
		public static ISplinePoint GetRootAsISplinePoint(ByteBuffer _bb, ISplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036BD8 RID: 224216 RVA: 0x00752AF1 File Offset: 0x00750CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036BD9 RID: 224217 RVA: 0x00752B00 File Offset: 0x00750D00
		public ISplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3EF RID: 58351
		// (get) Token: 0x06036BDA RID: 224218 RVA: 0x00752B10 File Offset: 0x00750D10
		public string Spline
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036BDB RID: 224219 RVA: 0x00752B47 File Offset: 0x00750D47
		public Span<byte> GetSplineBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036BDC RID: 224220 RVA: 0x00752B56 File Offset: 0x00750D56
		public byte[] GetSplineArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06036BDD RID: 224221 RVA: 0x00752B64 File Offset: 0x00750D64
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E3F0 RID: 58352
		// (get) Token: 0x06036BDE RID: 224222 RVA: 0x00752BC4 File Offset: 0x00750DC4
		public int PointsLength
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

		// Token: 0x06036BDF RID: 224223 RVA: 0x00752BEF File Offset: 0x00750DEF
		public static Offset<ISplinePoint> CreateISplinePoint(FlatBufferBuilder builder, StringOffset SplineOffset = default(StringOffset), VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISplinePoint.AddPoints(builder, PointsOffset);
			ISplinePoint.AddSpline(builder, SplineOffset);
			return ISplinePoint.EndISplinePoint(builder);
		}

		// Token: 0x06036BE0 RID: 224224 RVA: 0x00752C0C File Offset: 0x00750E0C
		public static void StartISplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036BE1 RID: 224225 RVA: 0x00752C15 File Offset: 0x00750E15
		public static void AddSpline(FlatBufferBuilder builder, StringOffset splineOffset)
		{
			builder.AddOffset(0, splineOffset.Value, 0);
		}

		// Token: 0x06036BE2 RID: 224226 RVA: 0x00752C25 File Offset: 0x00750E25
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x06036BE3 RID: 224227 RVA: 0x00752C38 File Offset: 0x00750E38
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036BE4 RID: 224228 RVA: 0x00752C78 File Offset: 0x00750E78
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036BE5 RID: 224229 RVA: 0x00752C92 File Offset: 0x00750E92
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036BE6 RID: 224230 RVA: 0x00752CB0 File Offset: 0x00750EB0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036BE7 RID: 224231 RVA: 0x00752CC9 File Offset: 0x00750EC9
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036BE8 RID: 224232 RVA: 0x00752CD4 File Offset: 0x00750ED4
		public static Offset<ISplinePoint> EndISplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ISplinePoint>(builder.EndTable());
		}

		// Token: 0x06036BE9 RID: 224233 RVA: 0x00752CE4 File Offset: 0x00750EE4
		public ISplinePointT UnPack()
		{
			ISplinePointT splinePointT = new ISplinePointT();
			this.UnPackTo(splinePointT);
			return splinePointT;
		}

		// Token: 0x06036BEA RID: 224234 RVA: 0x00752D00 File Offset: 0x00750F00
		public void UnPackTo(ISplinePointT _o)
		{
			_o.Spline = this.Spline;
			_o.Points = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06036BEB RID: 224235 RVA: 0x00752D6C File Offset: 0x00750F6C
		public static Offset<ISplinePoint> Pack(FlatBufferBuilder builder, ISplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplinePoint>);
			}
			StringOffset splineOffset = (_o.Spline == null) ? default(StringOffset) : builder.CreateString(_o.Spline);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IVectorInfo>[] array = new Offset<IVectorInfo>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IVectorInfo.Pack(builder, _o.Points[i]);
				}
				pointsOffset = ISplinePoint.CreatePointsVector(builder, array);
			}
			return ISplinePoint.CreateISplinePoint(builder, splineOffset, pointsOffset);
		}

		// Token: 0x04012C58 RID: 76888
		private Table __p;
	}
}
