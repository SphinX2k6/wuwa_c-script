using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006095 RID: 24725
	public struct ITimePatrolSpline : IFlatbufferObject
	{
		// Token: 0x1700B7C3 RID: 47043
		// (get) Token: 0x06029D0B RID: 171275 RVA: 0x005B55F1 File Offset: 0x005B37F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D0C RID: 171276 RVA: 0x005B55FE File Offset: 0x005B37FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D0D RID: 171277 RVA: 0x005B5608 File Offset: 0x005B3808
		public static ITimePatrolSpline GetRootAsITimePatrolSpline(ByteBuffer _bb)
		{
			return ITimePatrolSpline.GetRootAsITimePatrolSpline(_bb, default(ITimePatrolSpline));
		}

		// Token: 0x06029D0E RID: 171278 RVA: 0x005B5624 File Offset: 0x005B3824
		public static ITimePatrolSpline GetRootAsITimePatrolSpline(ByteBuffer _bb, ITimePatrolSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D0F RID: 171279 RVA: 0x005B5641 File Offset: 0x005B3841
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D10 RID: 171280 RVA: 0x005B5650 File Offset: 0x005B3850
		public ITimePatrolSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7C4 RID: 47044
		// (get) Token: 0x06029D11 RID: 171281 RVA: 0x005B5660 File Offset: 0x005B3860
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

		// Token: 0x06029D12 RID: 171282 RVA: 0x005B569C File Offset: 0x005B389C
		public ITimePatrolSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITimePatrolSplinePoint?(default(ITimePatrolSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B7C5 RID: 47045
		// (get) Token: 0x06029D13 RID: 171283 RVA: 0x005B56FC File Offset: 0x005B38FC
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

		// Token: 0x06029D14 RID: 171284 RVA: 0x005B5727 File Offset: 0x005B3927
		public static Offset<ITimePatrolSpline> CreateITimePatrolSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ITimePatrolSpline.AddPoints(builder, PointsOffset);
			ITimePatrolSpline.AddType(builder, Type);
			return ITimePatrolSpline.EndITimePatrolSpline(builder);
		}

		// Token: 0x06029D15 RID: 171285 RVA: 0x005B5744 File Offset: 0x005B3944
		public static void StartITimePatrolSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029D16 RID: 171286 RVA: 0x005B574D File Offset: 0x005B394D
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029D17 RID: 171287 RVA: 0x005B5758 File Offset: 0x005B3958
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x06029D18 RID: 171288 RVA: 0x005B5768 File Offset: 0x005B3968
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ITimePatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029D19 RID: 171289 RVA: 0x005B57A8 File Offset: 0x005B39A8
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ITimePatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITimePatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029D1A RID: 171290 RVA: 0x005B57C2 File Offset: 0x005B39C2
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITimePatrolSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITimePatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029D1B RID: 171291 RVA: 0x005B57E0 File Offset: 0x005B39E0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITimePatrolSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029D1C RID: 171292 RVA: 0x005B57F9 File Offset: 0x005B39F9
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029D1D RID: 171293 RVA: 0x005B5804 File Offset: 0x005B3A04
		public static Offset<ITimePatrolSpline> EndITimePatrolSpline(FlatBufferBuilder builder)
		{
			return new Offset<ITimePatrolSpline>(builder.EndTable());
		}

		// Token: 0x06029D1E RID: 171294 RVA: 0x005B5814 File Offset: 0x005B3A14
		public ITimePatrolSplineT UnPack()
		{
			ITimePatrolSplineT timePatrolSplineT = new ITimePatrolSplineT();
			this.UnPackTo(timePatrolSplineT);
			return timePatrolSplineT;
		}

		// Token: 0x06029D1F RID: 171295 RVA: 0x005B5830 File Offset: 0x005B3A30
		public void UnPackTo(ITimePatrolSplineT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<ITimePatrolSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029D20 RID: 171296 RVA: 0x005B589C File Offset: 0x005B3A9C
		public static Offset<ITimePatrolSpline> Pack(FlatBufferBuilder builder, ITimePatrolSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimePatrolSpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ITimePatrolSplinePoint>[] array = new Offset<ITimePatrolSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITimePatrolSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = ITimePatrolSpline.CreatePointsVector(builder, array);
			}
			return ITimePatrolSpline.CreateITimePatrolSpline(builder, _o.Type, pointsOffset);
		}

		// Token: 0x0400FE34 RID: 65076
		private Table __p;
	}
}
