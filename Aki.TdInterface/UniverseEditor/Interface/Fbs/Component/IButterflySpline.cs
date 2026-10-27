using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F46 RID: 20294
	public struct IButterflySpline : IFlatbufferObject
	{
		// Token: 0x17009246 RID: 37446
		// (get) Token: 0x06020223 RID: 131619 RVA: 0x0047881B File Offset: 0x00476A1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020224 RID: 131620 RVA: 0x00478828 File Offset: 0x00476A28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020225 RID: 131621 RVA: 0x00478830 File Offset: 0x00476A30
		public static IButterflySpline GetRootAsIButterflySpline(ByteBuffer _bb)
		{
			return IButterflySpline.GetRootAsIButterflySpline(_bb, default(IButterflySpline));
		}

		// Token: 0x06020226 RID: 131622 RVA: 0x0047884C File Offset: 0x00476A4C
		public static IButterflySpline GetRootAsIButterflySpline(ByteBuffer _bb, IButterflySpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020227 RID: 131623 RVA: 0x00478869 File Offset: 0x00476A69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020228 RID: 131624 RVA: 0x00478878 File Offset: 0x00476A78
		public IButterflySpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009247 RID: 37447
		// (get) Token: 0x06020229 RID: 131625 RVA: 0x00478888 File Offset: 0x00476A88
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

		// Token: 0x0602022A RID: 131626 RVA: 0x004788C4 File Offset: 0x00476AC4
		public IButterflySplinePoint? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IButterflySplinePoint?(default(IButterflySplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009248 RID: 37448
		// (get) Token: 0x0602022B RID: 131627 RVA: 0x00478924 File Offset: 0x00476B24
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

		// Token: 0x0602022C RID: 131628 RVA: 0x0047894F File Offset: 0x00476B4F
		public static Offset<IButterflySpline> CreateIButterflySpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IButterflySpline.AddPoints(builder, PointsOffset);
			IButterflySpline.AddType(builder, Type);
			return IButterflySpline.EndIButterflySpline(builder);
		}

		// Token: 0x0602022D RID: 131629 RVA: 0x0047896C File Offset: 0x00476B6C
		public static void StartIButterflySpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602022E RID: 131630 RVA: 0x00478975 File Offset: 0x00476B75
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602022F RID: 131631 RVA: 0x00478980 File Offset: 0x00476B80
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x06020230 RID: 131632 RVA: 0x00478990 File Offset: 0x00476B90
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IButterflySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020231 RID: 131633 RVA: 0x004789D0 File Offset: 0x00476BD0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IButterflySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IButterflySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020232 RID: 131634 RVA: 0x004789EA File Offset: 0x00476BEA
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IButterflySplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IButterflySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020233 RID: 131635 RVA: 0x00478A08 File Offset: 0x00476C08
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IButterflySplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020234 RID: 131636 RVA: 0x00478A21 File Offset: 0x00476C21
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020235 RID: 131637 RVA: 0x00478A2C File Offset: 0x00476C2C
		public static Offset<IButterflySpline> EndIButterflySpline(FlatBufferBuilder builder)
		{
			return new Offset<IButterflySpline>(builder.EndTable());
		}

		// Token: 0x06020236 RID: 131638 RVA: 0x00478A3C File Offset: 0x00476C3C
		public IButterflySplineT UnPack()
		{
			IButterflySplineT butterflySplineT = new IButterflySplineT();
			this.UnPackTo(butterflySplineT);
			return butterflySplineT;
		}

		// Token: 0x06020237 RID: 131639 RVA: 0x00478A58 File Offset: 0x00476C58
		public void UnPackTo(IButterflySplineT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<IButterflySplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06020238 RID: 131640 RVA: 0x00478AC4 File Offset: 0x00476CC4
		public static Offset<IButterflySpline> Pack(FlatBufferBuilder builder, IButterflySplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IButterflySpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IButterflySplinePoint>[] array = new Offset<IButterflySplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IButterflySplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IButterflySpline.CreatePointsVector(builder, array);
			}
			return IButterflySpline.CreateIButterflySpline(builder, _o.Type, pointsOffset);
		}

		// Token: 0x0400DDB6 RID: 56758
		private Table __p;
	}
}
