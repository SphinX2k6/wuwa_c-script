using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005808 RID: 22536
	public struct IRangeSpline : IFlatbufferObject
	{
		// Token: 0x1700A858 RID: 43096
		// (get) Token: 0x06025E27 RID: 155175 RVA: 0x0053980E File Offset: 0x00537A0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025E28 RID: 155176 RVA: 0x0053981B File Offset: 0x00537A1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025E29 RID: 155177 RVA: 0x00539824 File Offset: 0x00537A24
		public static IRangeSpline GetRootAsIRangeSpline(ByteBuffer _bb)
		{
			return IRangeSpline.GetRootAsIRangeSpline(_bb, default(IRangeSpline));
		}

		// Token: 0x06025E2A RID: 155178 RVA: 0x00539840 File Offset: 0x00537A40
		public static IRangeSpline GetRootAsIRangeSpline(ByteBuffer _bb, IRangeSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025E2B RID: 155179 RVA: 0x0053985D File Offset: 0x00537A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025E2C RID: 155180 RVA: 0x0053986C File Offset: 0x00537A6C
		public IRangeSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A859 RID: 43097
		// (get) Token: 0x06025E2D RID: 155181 RVA: 0x0053987C File Offset: 0x00537A7C
		public ESplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineType.Common;
				}
				return (ESplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A85A RID: 43098
		// (get) Token: 0x06025E2E RID: 155182 RVA: 0x005398B8 File Offset: 0x00537AB8
		public float Height
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025E2F RID: 155183 RVA: 0x005398F8 File Offset: 0x00537AF8
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A85B RID: 43099
		// (get) Token: 0x06025E30 RID: 155184 RVA: 0x00539958 File Offset: 0x00537B58
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06025E31 RID: 155185 RVA: 0x00539983 File Offset: 0x00537B83
		public static Offset<IRangeSpline> CreateIRangeSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, float Height = 0f, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRangeSpline.AddPoints(builder, PointsOffset);
			IRangeSpline.AddHeight(builder, Height);
			IRangeSpline.AddType(builder, Type);
			return IRangeSpline.EndIRangeSpline(builder);
		}

		// Token: 0x06025E32 RID: 155186 RVA: 0x005399A7 File Offset: 0x00537BA7
		public static void StartIRangeSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06025E33 RID: 155187 RVA: 0x005399B0 File Offset: 0x00537BB0
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025E34 RID: 155188 RVA: 0x005399BB File Offset: 0x00537BBB
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(1, height, 0.0);
		}

		// Token: 0x06025E35 RID: 155189 RVA: 0x005399CE File Offset: 0x00537BCE
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(2, pointsOffset.Value, 0);
		}

		// Token: 0x06025E36 RID: 155190 RVA: 0x005399E0 File Offset: 0x00537BE0
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025E37 RID: 155191 RVA: 0x00539A20 File Offset: 0x00537C20
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E38 RID: 155192 RVA: 0x00539A3A File Offset: 0x00537C3A
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025E39 RID: 155193 RVA: 0x00539A58 File Offset: 0x00537C58
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025E3A RID: 155194 RVA: 0x00539A71 File Offset: 0x00537C71
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025E3B RID: 155195 RVA: 0x00539A7C File Offset: 0x00537C7C
		public static Offset<IRangeSpline> EndIRangeSpline(FlatBufferBuilder builder)
		{
			return new Offset<IRangeSpline>(builder.EndTable());
		}

		// Token: 0x06025E3C RID: 155196 RVA: 0x00539A8C File Offset: 0x00537C8C
		public IRangeSplineT UnPack()
		{
			IRangeSplineT rangeSplineT = new IRangeSplineT();
			this.UnPackTo(rangeSplineT);
			return rangeSplineT;
		}

		// Token: 0x06025E3D RID: 155197 RVA: 0x00539AA8 File Offset: 0x00537CA8
		public void UnPackTo(IRangeSplineT _o)
		{
			_o.Type = this.Type;
			_o.Height = this.Height;
			_o.Points = new List<ICommonSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025E3E RID: 155198 RVA: 0x00539B20 File Offset: 0x00537D20
		public static Offset<IRangeSpline> Pack(FlatBufferBuilder builder, IRangeSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeSpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ICommonSplinePoint>[] array = new Offset<ICommonSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommonSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IRangeSpline.CreatePointsVector(builder, array);
			}
			return IRangeSpline.CreateIRangeSpline(builder, _o.Type, _o.Height, pointsOffset);
		}

		// Token: 0x0400ED05 RID: 60677
		private Table __p;
	}
}
