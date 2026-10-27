using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CC RID: 21964
	public struct IMotorSlideSpline : IFlatbufferObject
	{
		// Token: 0x1700A264 RID: 41572
		// (get) Token: 0x0602466B RID: 149099 RVA: 0x00506647 File Offset: 0x00504847
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602466C RID: 149100 RVA: 0x00506654 File Offset: 0x00504854
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602466D RID: 149101 RVA: 0x0050665C File Offset: 0x0050485C
		public static IMotorSlideSpline GetRootAsIMotorSlideSpline(ByteBuffer _bb)
		{
			return IMotorSlideSpline.GetRootAsIMotorSlideSpline(_bb, default(IMotorSlideSpline));
		}

		// Token: 0x0602466E RID: 149102 RVA: 0x00506678 File Offset: 0x00504878
		public static IMotorSlideSpline GetRootAsIMotorSlideSpline(ByteBuffer _bb, IMotorSlideSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602466F RID: 149103 RVA: 0x00506695 File Offset: 0x00504895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024670 RID: 149104 RVA: 0x005066A4 File Offset: 0x005048A4
		public IMotorSlideSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A265 RID: 41573
		// (get) Token: 0x06024671 RID: 149105 RVA: 0x005066B4 File Offset: 0x005048B4
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

		// Token: 0x1700A266 RID: 41574
		// (get) Token: 0x06024672 RID: 149106 RVA: 0x005066F0 File Offset: 0x005048F0
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

		// Token: 0x06024673 RID: 149107 RVA: 0x00506730 File Offset: 0x00504930
		public IMotorSlideSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMotorSlideSplinePoint?(default(IMotorSlideSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A267 RID: 41575
		// (get) Token: 0x06024674 RID: 149108 RVA: 0x00506790 File Offset: 0x00504990
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

		// Token: 0x06024675 RID: 149109 RVA: 0x005067BB File Offset: 0x005049BB
		public static Offset<IMotorSlideSpline> CreateIMotorSlideSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, float RangeRadius = 0f, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IMotorSlideSpline.AddPoints(builder, PointsOffset);
			IMotorSlideSpline.AddRangeRadius(builder, RangeRadius);
			IMotorSlideSpline.AddType(builder, Type);
			return IMotorSlideSpline.EndIMotorSlideSpline(builder);
		}

		// Token: 0x06024676 RID: 149110 RVA: 0x005067DF File Offset: 0x005049DF
		public static void StartIMotorSlideSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024677 RID: 149111 RVA: 0x005067E8 File Offset: 0x005049E8
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024678 RID: 149112 RVA: 0x005067F3 File Offset: 0x005049F3
		public static void AddRangeRadius(FlatBufferBuilder builder, float rangeRadius)
		{
			builder.AddFloat(1, rangeRadius, 0.0);
		}

		// Token: 0x06024679 RID: 149113 RVA: 0x00506806 File Offset: 0x00504A06
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(2, pointsOffset.Value, 0);
		}

		// Token: 0x0602467A RID: 149114 RVA: 0x00506818 File Offset: 0x00504A18
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IMotorSlideSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602467B RID: 149115 RVA: 0x00506858 File Offset: 0x00504A58
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IMotorSlideSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMotorSlideSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602467C RID: 149116 RVA: 0x00506872 File Offset: 0x00504A72
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMotorSlideSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMotorSlideSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602467D RID: 149117 RVA: 0x00506890 File Offset: 0x00504A90
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMotorSlideSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602467E RID: 149118 RVA: 0x005068A9 File Offset: 0x00504AA9
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602467F RID: 149119 RVA: 0x005068B4 File Offset: 0x00504AB4
		public static Offset<IMotorSlideSpline> EndIMotorSlideSpline(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSlideSpline>(builder.EndTable());
		}

		// Token: 0x06024680 RID: 149120 RVA: 0x005068C4 File Offset: 0x00504AC4
		public IMotorSlideSplineT UnPack()
		{
			IMotorSlideSplineT motorSlideSplineT = new IMotorSlideSplineT();
			this.UnPackTo(motorSlideSplineT);
			return motorSlideSplineT;
		}

		// Token: 0x06024681 RID: 149121 RVA: 0x005068E0 File Offset: 0x00504AE0
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

		// Token: 0x06024682 RID: 149122 RVA: 0x00506958 File Offset: 0x00504B58
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

		// Token: 0x0400E921 RID: 59681
		private Table __p;
	}
}
