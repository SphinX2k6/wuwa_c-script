using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6A RID: 23402
	public struct IMotorSlideSpline : IFlatbufferObject
	{
		// Token: 0x1700AAEC RID: 43756
		// (get) Token: 0x06026878 RID: 157816 RVA: 0x00546BBF File Offset: 0x00544DBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026879 RID: 157817 RVA: 0x00546BCC File Offset: 0x00544DCC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602687A RID: 157818 RVA: 0x00546BD4 File Offset: 0x00544DD4
		public static IMotorSlideSpline GetRootAsIMotorSlideSpline(ByteBuffer _bb)
		{
			return IMotorSlideSpline.GetRootAsIMotorSlideSpline(_bb, default(IMotorSlideSpline));
		}

		// Token: 0x0602687B RID: 157819 RVA: 0x00546BF0 File Offset: 0x00544DF0
		public static IMotorSlideSpline GetRootAsIMotorSlideSpline(ByteBuffer _bb, IMotorSlideSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602687C RID: 157820 RVA: 0x00546C0D File Offset: 0x00544E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602687D RID: 157821 RVA: 0x00546C1C File Offset: 0x00544E1C
		public IMotorSlideSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAED RID: 43757
		// (get) Token: 0x0602687E RID: 157822 RVA: 0x00546C2C File Offset: 0x00544E2C
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

		// Token: 0x1700AAEE RID: 43758
		// (get) Token: 0x0602687F RID: 157823 RVA: 0x00546C68 File Offset: 0x00544E68
		public float RangeRadius
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

		// Token: 0x06026880 RID: 157824 RVA: 0x00546CA8 File Offset: 0x00544EA8
		public IMotorSlideSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMotorSlideSplinePoint?(default(IMotorSlideSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AAEF RID: 43759
		// (get) Token: 0x06026881 RID: 157825 RVA: 0x00546D08 File Offset: 0x00544F08
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

		// Token: 0x06026882 RID: 157826 RVA: 0x00546D33 File Offset: 0x00544F33
		public static Offset<IMotorSlideSpline> CreateIMotorSlideSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, float RangeRadius = 0f, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IMotorSlideSpline.AddPoints(builder, PointsOffset);
			IMotorSlideSpline.AddRangeRadius(builder, RangeRadius);
			IMotorSlideSpline.AddType(builder, Type);
			return IMotorSlideSpline.EndIMotorSlideSpline(builder);
		}

		// Token: 0x06026883 RID: 157827 RVA: 0x00546D57 File Offset: 0x00544F57
		public static void StartIMotorSlideSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026884 RID: 157828 RVA: 0x00546D60 File Offset: 0x00544F60
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026885 RID: 157829 RVA: 0x00546D6B File Offset: 0x00544F6B
		public static void AddRangeRadius(FlatBufferBuilder builder, float rangeRadius)
		{
			builder.AddFloat(1, rangeRadius, 0.0);
		}

		// Token: 0x06026886 RID: 157830 RVA: 0x00546D7E File Offset: 0x00544F7E
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(2, pointsOffset.Value, 0);
		}

		// Token: 0x06026887 RID: 157831 RVA: 0x00546D90 File Offset: 0x00544F90
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IMotorSlideSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026888 RID: 157832 RVA: 0x00546DD0 File Offset: 0x00544FD0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IMotorSlideSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorSlideSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026889 RID: 157833 RVA: 0x00546DEA File Offset: 0x00544FEA
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorSlideSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorSlideSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602688A RID: 157834 RVA: 0x00546E08 File Offset: 0x00545008
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorSlideSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602688B RID: 157835 RVA: 0x00546E21 File Offset: 0x00545021
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602688C RID: 157836 RVA: 0x00546E2C File Offset: 0x0054502C
		public static Offset<IMotorSlideSpline> EndIMotorSlideSpline(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSlideSpline>(builder.EndTable());
		}

		// Token: 0x0602688D RID: 157837 RVA: 0x00546E3C File Offset: 0x0054503C
		public IMotorSlideSplineT UnPack()
		{
			IMotorSlideSplineT motorSlideSplineT = new IMotorSlideSplineT();
			this.UnPackTo(motorSlideSplineT);
			return motorSlideSplineT;
		}

		// Token: 0x0602688E RID: 157838 RVA: 0x00546E58 File Offset: 0x00545058
		public void UnPackTo(IMotorSlideSplineT _o)
		{
			_o.Type = this.Type;
			_o.RangeRadius = this.RangeRadius;
			_o.Points = new List<IMotorSlideSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602688F RID: 157839 RVA: 0x00546ED0 File Offset: 0x005450D0
		public static Offset<IMotorSlideSpline> Pack(FlatBufferBuilder builder, IMotorSlideSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSlideSpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IMotorSlideSplinePoint>[] array = new Offset<IMotorSlideSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMotorSlideSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IMotorSlideSpline.CreatePointsVector(builder, array);
			}
			return IMotorSlideSpline.CreateIMotorSlideSpline(builder, _o.Type, _o.RangeRadius, pointsOffset);
		}

		// Token: 0x0400F583 RID: 62851
		private Table __p;
	}
}
