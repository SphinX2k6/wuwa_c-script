using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD0 RID: 20432
	public struct ICommonSpline : IFlatbufferObject
	{
		// Token: 0x170093FF RID: 37887
		// (get) Token: 0x06020897 RID: 133271 RVA: 0x00486510 File Offset: 0x00484710
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020898 RID: 133272 RVA: 0x0048651D File Offset: 0x0048471D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020899 RID: 133273 RVA: 0x00486524 File Offset: 0x00484724
		public static ICommonSpline GetRootAsICommonSpline(ByteBuffer _bb)
		{
			return ICommonSpline.GetRootAsICommonSpline(_bb, default(ICommonSpline));
		}

		// Token: 0x0602089A RID: 133274 RVA: 0x00486540 File Offset: 0x00484740
		public static ICommonSpline GetRootAsICommonSpline(ByteBuffer _bb, ICommonSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602089B RID: 133275 RVA: 0x0048655D File Offset: 0x0048475D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602089C RID: 133276 RVA: 0x0048656C File Offset: 0x0048476C
		public ICommonSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009400 RID: 37888
		// (get) Token: 0x0602089D RID: 133277 RVA: 0x0048657C File Offset: 0x0048477C
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

		// Token: 0x0602089E RID: 133278 RVA: 0x004865B8 File Offset: 0x004847B8
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009401 RID: 37889
		// (get) Token: 0x0602089F RID: 133279 RVA: 0x00486618 File Offset: 0x00484818
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

		// Token: 0x060208A0 RID: 133280 RVA: 0x00486643 File Offset: 0x00484843
		public static Offset<ICommonSpline> CreateICommonSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICommonSpline.AddPoints(builder, PointsOffset);
			ICommonSpline.AddType(builder, Type);
			return ICommonSpline.EndICommonSpline(builder);
		}

		// Token: 0x060208A1 RID: 133281 RVA: 0x00486660 File Offset: 0x00484860
		public static void StartICommonSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060208A2 RID: 133282 RVA: 0x00486669 File Offset: 0x00484869
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060208A3 RID: 133283 RVA: 0x00486674 File Offset: 0x00484874
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x060208A4 RID: 133284 RVA: 0x00486684 File Offset: 0x00484884
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060208A5 RID: 133285 RVA: 0x004866C4 File Offset: 0x004848C4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060208A6 RID: 133286 RVA: 0x004866DE File Offset: 0x004848DE
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060208A7 RID: 133287 RVA: 0x004866FC File Offset: 0x004848FC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060208A8 RID: 133288 RVA: 0x00486715 File Offset: 0x00484915
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060208A9 RID: 133289 RVA: 0x00486720 File Offset: 0x00484920
		public static Offset<ICommonSpline> EndICommonSpline(FlatBufferBuilder builder)
		{
			return new Offset<ICommonSpline>(builder.EndTable());
		}

		// Token: 0x060208AA RID: 133290 RVA: 0x00486730 File Offset: 0x00484930
		public ICommonSplineT UnPack()
		{
			ICommonSplineT commonSplineT = new ICommonSplineT();
			this.UnPackTo(commonSplineT);
			return commonSplineT;
		}

		// Token: 0x060208AB RID: 133291 RVA: 0x0048674C File Offset: 0x0048494C
		public void UnPackTo(ICommonSplineT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<ICommonSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060208AC RID: 133292 RVA: 0x004867B8 File Offset: 0x004849B8
		public static Offset<ICommonSpline> Pack(FlatBufferBuilder builder, ICommonSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonSpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ICommonSplinePoint>[] array = new Offset<ICommonSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommonSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = ICommonSpline.CreatePointsVector(builder, array);
			}
			return ICommonSpline.CreateICommonSpline(builder, _o.Type, pointsOffset);
		}

		// Token: 0x0400DEB8 RID: 57016
		private Table __p;
	}
}
