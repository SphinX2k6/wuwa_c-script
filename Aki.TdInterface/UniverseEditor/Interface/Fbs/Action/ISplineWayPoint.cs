using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007199 RID: 29081
	public struct ISplineWayPoint : IFlatbufferObject
	{
		// Token: 0x1700D7FC RID: 55292
		// (get) Token: 0x060338F6 RID: 211190 RVA: 0x006F1C00 File Offset: 0x006EFE00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060338F7 RID: 211191 RVA: 0x006F1C0D File Offset: 0x006EFE0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060338F8 RID: 211192 RVA: 0x006F1C14 File Offset: 0x006EFE14
		public static ISplineWayPoint GetRootAsISplineWayPoint(ByteBuffer _bb)
		{
			return ISplineWayPoint.GetRootAsISplineWayPoint(_bb, default(ISplineWayPoint));
		}

		// Token: 0x060338F9 RID: 211193 RVA: 0x006F1C30 File Offset: 0x006EFE30
		public static ISplineWayPoint GetRootAsISplineWayPoint(ByteBuffer _bb, ISplineWayPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060338FA RID: 211194 RVA: 0x006F1C4D File Offset: 0x006EFE4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060338FB RID: 211195 RVA: 0x006F1C5C File Offset: 0x006EFE5C
		public ISplineWayPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7FD RID: 55293
		// (get) Token: 0x060338FC RID: 211196 RVA: 0x006F1C6C File Offset: 0x006EFE6C
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

		// Token: 0x1700D7FE RID: 55294
		// (get) Token: 0x060338FD RID: 211197 RVA: 0x006F1CA8 File Offset: 0x006EFEA8
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

		// Token: 0x060338FE RID: 211198 RVA: 0x006F1CE4 File Offset: 0x006EFEE4
		public static Offset<ISplineWayPoint> CreateISplineWayPoint(FlatBufferBuilder builder, int Spline = 0, int PointId = 0)
		{
			builder.StartTable(2);
			ISplineWayPoint.AddPointId(builder, PointId);
			ISplineWayPoint.AddSpline(builder, Spline);
			return ISplineWayPoint.EndISplineWayPoint(builder);
		}

		// Token: 0x060338FF RID: 211199 RVA: 0x006F1D01 File Offset: 0x006EFF01
		public static void StartISplineWayPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033900 RID: 211200 RVA: 0x006F1D0A File Offset: 0x006EFF0A
		public static void AddSpline(FlatBufferBuilder builder, int spline)
		{
			builder.AddInt(0, spline, 0);
		}

		// Token: 0x06033901 RID: 211201 RVA: 0x006F1D15 File Offset: 0x006EFF15
		public static void AddPointId(FlatBufferBuilder builder, int pointId)
		{
			builder.AddInt(1, pointId, 0);
		}

		// Token: 0x06033902 RID: 211202 RVA: 0x006F1D20 File Offset: 0x006EFF20
		public static Offset<ISplineWayPoint> EndISplineWayPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISplineWayPoint>(builder.EndTable());
		}

		// Token: 0x06033903 RID: 211203 RVA: 0x006F1D30 File Offset: 0x006EFF30
		public ISplineWayPointT UnPack()
		{
			ISplineWayPointT splineWayPointT = new ISplineWayPointT();
			this.UnPackTo(splineWayPointT);
			return splineWayPointT;
		}

		// Token: 0x06033904 RID: 211204 RVA: 0x006F1D4B File Offset: 0x006EFF4B
		public void UnPackTo(ISplineWayPointT _o)
		{
			_o.Spline = this.Spline;
			_o.PointId = this.PointId;
		}

		// Token: 0x06033905 RID: 211205 RVA: 0x006F1D68 File Offset: 0x006EFF68
		public static Offset<ISplineWayPoint> Pack(FlatBufferBuilder builder, ISplineWayPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineWayPoint>);
			}
			return ISplineWayPoint.CreateISplineWayPoint(builder, _o.Spline, _o.PointId);
		}

		// Token: 0x04011C5B RID: 72795
		private Table __p;
	}
}
