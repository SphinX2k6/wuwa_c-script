using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200796E RID: 31086
	public struct ISplineWayPoint : IFlatbufferObject
	{
		// Token: 0x1700E3F3 RID: 58355
		// (get) Token: 0x06036BF2 RID: 224242 RVA: 0x00752E90 File Offset: 0x00751090
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036BF3 RID: 224243 RVA: 0x00752E9D File Offset: 0x0075109D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036BF4 RID: 224244 RVA: 0x00752EA4 File Offset: 0x007510A4
		public static ISplineWayPoint GetRootAsISplineWayPoint(ByteBuffer _bb)
		{
			return ISplineWayPoint.GetRootAsISplineWayPoint(_bb, default(ISplineWayPoint));
		}

		// Token: 0x06036BF5 RID: 224245 RVA: 0x00752EC0 File Offset: 0x007510C0
		public static ISplineWayPoint GetRootAsISplineWayPoint(ByteBuffer _bb, ISplineWayPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036BF6 RID: 224246 RVA: 0x00752EDD File Offset: 0x007510DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036BF7 RID: 224247 RVA: 0x00752EEC File Offset: 0x007510EC
		public ISplineWayPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3F4 RID: 58356
		// (get) Token: 0x06036BF8 RID: 224248 RVA: 0x00752EFC File Offset: 0x007510FC
		public int Spline
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3F5 RID: 58357
		// (get) Token: 0x06036BF9 RID: 224249 RVA: 0x00752F38 File Offset: 0x00751138
		public int PointId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036BFA RID: 224250 RVA: 0x00752F74 File Offset: 0x00751174
		public static Offset<ISplineWayPoint> CreateISplineWayPoint(FlatBufferBuilder builder, int Spline = 0, int PointId = 0)
		{
			builder.StartTable(2);
			ISplineWayPoint.AddPointId(builder, PointId);
			ISplineWayPoint.AddSpline(builder, Spline);
			return ISplineWayPoint.EndISplineWayPoint(builder);
		}

		// Token: 0x06036BFB RID: 224251 RVA: 0x00752F91 File Offset: 0x00751191
		public static void StartISplineWayPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036BFC RID: 224252 RVA: 0x00752F9A File Offset: 0x0075119A
		public static void AddSpline(FlatBufferBuilder builder, int spline)
		{
			builder.AddInt(0, spline, 0);
		}

		// Token: 0x06036BFD RID: 224253 RVA: 0x00752FA5 File Offset: 0x007511A5
		public static void AddPointId(FlatBufferBuilder builder, int pointId)
		{
			builder.AddInt(1, pointId, 0);
		}

		// Token: 0x06036BFE RID: 224254 RVA: 0x00752FB0 File Offset: 0x007511B0
		public static Offset<ISplineWayPoint> EndISplineWayPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISplineWayPoint>(builder.EndTable());
		}

		// Token: 0x06036BFF RID: 224255 RVA: 0x00752FC0 File Offset: 0x007511C0
		public ISplineWayPointT UnPack()
		{
			ISplineWayPointT splineWayPointT = new ISplineWayPointT();
			this.UnPackTo(splineWayPointT);
			return splineWayPointT;
		}

		// Token: 0x06036C00 RID: 224256 RVA: 0x00752FDB File Offset: 0x007511DB
		public void UnPackTo(ISplineWayPointT _o)
		{
			_o.Spline = this.Spline;
			_o.PointId = this.PointId;
		}

		// Token: 0x06036C01 RID: 224257 RVA: 0x00752FF8 File Offset: 0x007511F8
		public static Offset<ISplineWayPoint> Pack(FlatBufferBuilder builder, ISplineWayPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineWayPoint>);
			}
			return ISplineWayPoint.CreateISplineWayPoint(builder, _o.Spline, _o.PointId);
		}

		// Token: 0x04012C5B RID: 76891
		private Table __p;
	}
}
