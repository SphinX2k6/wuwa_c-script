using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552F RID: 21807
	public struct ICommonSpline : IFlatbufferObject
	{
		// Token: 0x17009BE0 RID: 39904
		// (get) Token: 0x060227B3 RID: 141235 RVA: 0x004BFECE File Offset: 0x004BE0CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060227B4 RID: 141236 RVA: 0x004BFEDB File Offset: 0x004BE0DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060227B5 RID: 141237 RVA: 0x004BFEE4 File Offset: 0x004BE0E4
		public static ICommonSpline GetRootAsICommonSpline(ByteBuffer _bb)
		{
			return ICommonSpline.GetRootAsICommonSpline(_bb, default(ICommonSpline));
		}

		// Token: 0x060227B6 RID: 141238 RVA: 0x004BFF00 File Offset: 0x004BE100
		public static ICommonSpline GetRootAsICommonSpline(ByteBuffer _bb, ICommonSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060227B7 RID: 141239 RVA: 0x004BFF1D File Offset: 0x004BE11D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060227B8 RID: 141240 RVA: 0x004BFF2C File Offset: 0x004BE12C
		public ICommonSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BE1 RID: 39905
		// (get) Token: 0x060227B9 RID: 141241 RVA: 0x004BFF3C File Offset: 0x004BE13C
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

		// Token: 0x060227BA RID: 141242 RVA: 0x004BFF78 File Offset: 0x004BE178
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009BE2 RID: 39906
		// (get) Token: 0x060227BB RID: 141243 RVA: 0x004BFFD8 File Offset: 0x004BE1D8
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

		// Token: 0x060227BC RID: 141244 RVA: 0x004C0003 File Offset: 0x004BE203
		public static Offset<ICommonSpline> CreateICommonSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICommonSpline.AddPoints(builder, PointsOffset);
			ICommonSpline.AddType(builder, Type);
			return ICommonSpline.EndICommonSpline(builder);
		}

		// Token: 0x060227BD RID: 141245 RVA: 0x004C0020 File Offset: 0x004BE220
		public static void StartICommonSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060227BE RID: 141246 RVA: 0x004C0029 File Offset: 0x004BE229
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060227BF RID: 141247 RVA: 0x004C0034 File Offset: 0x004BE234
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x060227C0 RID: 141248 RVA: 0x004C0044 File Offset: 0x004BE244
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060227C1 RID: 141249 RVA: 0x004C0084 File Offset: 0x004BE284
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060227C2 RID: 141250 RVA: 0x004C009E File Offset: 0x004BE29E
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060227C3 RID: 141251 RVA: 0x004C00BC File Offset: 0x004BE2BC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060227C4 RID: 141252 RVA: 0x004C00D5 File Offset: 0x004BE2D5
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060227C5 RID: 141253 RVA: 0x004C00E0 File Offset: 0x004BE2E0
		public static Offset<ICommonSpline> EndICommonSpline(FlatBufferBuilder builder)
		{
			return new Offset<ICommonSpline>(builder.EndTable());
		}

		// Token: 0x060227C6 RID: 141254 RVA: 0x004C00F0 File Offset: 0x004BE2F0
		public ICommonSplineT UnPack()
		{
			ICommonSplineT commonSplineT = new ICommonSplineT();
			this.UnPackTo(commonSplineT);
			return commonSplineT;
		}

		// Token: 0x060227C7 RID: 141255 RVA: 0x004C010C File Offset: 0x004BE30C
		public void UnPackTo(ICommonSplineT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<ICommonSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060227C8 RID: 141256 RVA: 0x004C0178 File Offset: 0x004BE378
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

		// Token: 0x0400EAAC RID: 60076
		private Table __p;
	}
}
