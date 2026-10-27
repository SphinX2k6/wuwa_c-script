using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007196 RID: 29078
	public struct ISplinePoint : IFlatbufferObject
	{
		// Token: 0x1700D7F7 RID: 55287
		// (get) Token: 0x060338D8 RID: 211160 RVA: 0x006F1814 File Offset: 0x006EFA14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060338D9 RID: 211161 RVA: 0x006F1821 File Offset: 0x006EFA21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060338DA RID: 211162 RVA: 0x006F1828 File Offset: 0x006EFA28
		public static ISplinePoint GetRootAsISplinePoint(ByteBuffer _bb)
		{
			return ISplinePoint.GetRootAsISplinePoint(_bb, default(ISplinePoint));
		}

		// Token: 0x060338DB RID: 211163 RVA: 0x006F1844 File Offset: 0x006EFA44
		public static ISplinePoint GetRootAsISplinePoint(ByteBuffer _bb, ISplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060338DC RID: 211164 RVA: 0x006F1861 File Offset: 0x006EFA61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060338DD RID: 211165 RVA: 0x006F1870 File Offset: 0x006EFA70
		public ISplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7F8 RID: 55288
		// (get) Token: 0x060338DE RID: 211166 RVA: 0x006F1880 File Offset: 0x006EFA80
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

		// Token: 0x060338DF RID: 211167 RVA: 0x006F18B7 File Offset: 0x006EFAB7
		public Span<byte> GetSplineBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060338E0 RID: 211168 RVA: 0x006F18C6 File Offset: 0x006EFAC6
		public byte[] GetSplineArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060338E1 RID: 211169 RVA: 0x006F18D4 File Offset: 0x006EFAD4
		public IVectorInfo? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D7F9 RID: 55289
		// (get) Token: 0x060338E2 RID: 211170 RVA: 0x006F1934 File Offset: 0x006EFB34
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

		// Token: 0x060338E3 RID: 211171 RVA: 0x006F195F File Offset: 0x006EFB5F
		public static Offset<ISplinePoint> CreateISplinePoint(FlatBufferBuilder builder, StringOffset SplineOffset = default(StringOffset), VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISplinePoint.AddPoints(builder, PointsOffset);
			ISplinePoint.AddSpline(builder, SplineOffset);
			return ISplinePoint.EndISplinePoint(builder);
		}

		// Token: 0x060338E4 RID: 211172 RVA: 0x006F197C File Offset: 0x006EFB7C
		public static void StartISplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060338E5 RID: 211173 RVA: 0x006F1985 File Offset: 0x006EFB85
		public static void AddSpline(FlatBufferBuilder builder, StringOffset splineOffset)
		{
			builder.AddOffset(0, splineOffset.Value, 0);
		}

		// Token: 0x060338E6 RID: 211174 RVA: 0x006F1995 File Offset: 0x006EFB95
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x060338E7 RID: 211175 RVA: 0x006F19A8 File Offset: 0x006EFBA8
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060338E8 RID: 211176 RVA: 0x006F19E8 File Offset: 0x006EFBE8
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IVectorInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060338E9 RID: 211177 RVA: 0x006F1A02 File Offset: 0x006EFC02
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IVectorInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IVectorInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060338EA RID: 211178 RVA: 0x006F1A20 File Offset: 0x006EFC20
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IVectorInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060338EB RID: 211179 RVA: 0x006F1A39 File Offset: 0x006EFC39
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060338EC RID: 211180 RVA: 0x006F1A44 File Offset: 0x006EFC44
		public static Offset<ISplinePoint> EndISplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ISplinePoint>(builder.EndTable());
		}

		// Token: 0x060338ED RID: 211181 RVA: 0x006F1A54 File Offset: 0x006EFC54
		public ISplinePointT UnPack()
		{
			ISplinePointT splinePointT = new ISplinePointT();
			this.UnPackTo(splinePointT);
			return splinePointT;
		}

		// Token: 0x060338EE RID: 211182 RVA: 0x006F1A70 File Offset: 0x006EFC70
		public void UnPackTo(ISplinePointT _o)
		{
			_o.Spline = this.Spline;
			_o.Points = new List<IVectorInfoT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060338EF RID: 211183 RVA: 0x006F1ADC File Offset: 0x006EFCDC
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

		// Token: 0x04011C58 RID: 72792
		private Table __p;
	}
}
