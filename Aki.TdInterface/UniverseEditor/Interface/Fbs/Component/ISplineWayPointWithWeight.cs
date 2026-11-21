using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F99 RID: 24473
	public struct ISplineWayPointWithWeight : IFlatbufferObject
	{
		// Token: 0x1700B539 RID: 46393
		// (get) Token: 0x0602928A RID: 168586 RVA: 0x0059EB74 File Offset: 0x0059CD74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602928B RID: 168587 RVA: 0x0059EB81 File Offset: 0x0059CD81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602928C RID: 168588 RVA: 0x0059EB88 File Offset: 0x0059CD88
		public static ISplineWayPointWithWeight GetRootAsISplineWayPointWithWeight(ByteBuffer _bb)
		{
			return ISplineWayPointWithWeight.GetRootAsISplineWayPointWithWeight(_bb, default(ISplineWayPointWithWeight));
		}

		// Token: 0x0602928D RID: 168589 RVA: 0x0059EBA4 File Offset: 0x0059CDA4
		public static ISplineWayPointWithWeight GetRootAsISplineWayPointWithWeight(ByteBuffer _bb, ISplineWayPointWithWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602928E RID: 168590 RVA: 0x0059EBC1 File Offset: 0x0059CDC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602928F RID: 168591 RVA: 0x0059EBD0 File Offset: 0x0059CDD0
		public ISplineWayPointWithWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B53A RID: 46394
		// (get) Token: 0x06029290 RID: 168592 RVA: 0x0059EBE0 File Offset: 0x0059CDE0
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

		// Token: 0x1700B53B RID: 46395
		// (get) Token: 0x06029291 RID: 168593 RVA: 0x0059EC1C File Offset: 0x0059CE1C
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

		// Token: 0x1700B53C RID: 46396
		// (get) Token: 0x06029292 RID: 168594 RVA: 0x0059EC58 File Offset: 0x0059CE58
		public int Weight
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029293 RID: 168595 RVA: 0x0059EC94 File Offset: 0x0059CE94
		public static Offset<ISplineWayPointWithWeight> CreateISplineWayPointWithWeight(FlatBufferBuilder builder, int Spline = 0, int PointId = 0, int Weight = 0)
		{
			builder.StartTable(3);
			ISplineWayPointWithWeight.AddWeight(builder, Weight);
			ISplineWayPointWithWeight.AddPointId(builder, PointId);
			ISplineWayPointWithWeight.AddSpline(builder, Spline);
			return ISplineWayPointWithWeight.EndISplineWayPointWithWeight(builder);
		}

		// Token: 0x06029294 RID: 168596 RVA: 0x0059ECB8 File Offset: 0x0059CEB8
		public static void StartISplineWayPointWithWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029295 RID: 168597 RVA: 0x0059ECC1 File Offset: 0x0059CEC1
		public static void AddSpline(FlatBufferBuilder builder, int spline)
		{
			builder.AddInt(0, spline, 0);
		}

		// Token: 0x06029296 RID: 168598 RVA: 0x0059ECCC File Offset: 0x0059CECC
		public static void AddPointId(FlatBufferBuilder builder, int pointId)
		{
			builder.AddInt(1, pointId, 0);
		}

		// Token: 0x06029297 RID: 168599 RVA: 0x0059ECD7 File Offset: 0x0059CED7
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x06029298 RID: 168600 RVA: 0x0059ECE2 File Offset: 0x0059CEE2
		public static Offset<ISplineWayPointWithWeight> EndISplineWayPointWithWeight(FlatBufferBuilder builder)
		{
			return new Offset<ISplineWayPointWithWeight>(builder.EndTable());
		}

		// Token: 0x06029299 RID: 168601 RVA: 0x0059ECF0 File Offset: 0x0059CEF0
		public ISplineWayPointWithWeightT UnPack()
		{
			ISplineWayPointWithWeightT splineWayPointWithWeightT = new ISplineWayPointWithWeightT();
			this.UnPackTo(splineWayPointWithWeightT);
			return splineWayPointWithWeightT;
		}

		// Token: 0x0602929A RID: 168602 RVA: 0x0059ED0B File Offset: 0x0059CF0B
		public void UnPackTo(ISplineWayPointWithWeightT _o)
		{
			_o.Spline = this.Spline;
			_o.PointId = this.PointId;
			_o.Weight = this.Weight;
		}

		// Token: 0x0602929B RID: 168603 RVA: 0x0059ED34 File Offset: 0x0059CF34
		public static Offset<ISplineWayPointWithWeight> Pack(FlatBufferBuilder builder, ISplineWayPointWithWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineWayPointWithWeight>);
			}
			return ISplineWayPointWithWeight.CreateISplineWayPointWithWeight(builder, _o.Spline, _o.PointId, _o.Weight);
		}

		// Token: 0x0400FC84 RID: 64644
		private Table __p;
	}
}
