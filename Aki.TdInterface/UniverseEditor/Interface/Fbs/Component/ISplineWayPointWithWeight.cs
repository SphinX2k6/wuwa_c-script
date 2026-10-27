using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598C RID: 22924
	public struct ISplineWayPointWithWeight : IFlatbufferObject
	{
		// Token: 0x1700AC05 RID: 44037
		// (get) Token: 0x06026D20 RID: 159008 RVA: 0x00557F08 File Offset: 0x00556108
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026D21 RID: 159009 RVA: 0x00557F15 File Offset: 0x00556115
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026D22 RID: 159010 RVA: 0x00557F1C File Offset: 0x0055611C
		public static ISplineWayPointWithWeight GetRootAsISplineWayPointWithWeight(ByteBuffer _bb)
		{
			return ISplineWayPointWithWeight.GetRootAsISplineWayPointWithWeight(_bb, default(ISplineWayPointWithWeight));
		}

		// Token: 0x06026D23 RID: 159011 RVA: 0x00557F38 File Offset: 0x00556138
		public static ISplineWayPointWithWeight GetRootAsISplineWayPointWithWeight(ByteBuffer _bb, ISplineWayPointWithWeight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026D24 RID: 159012 RVA: 0x00557F55 File Offset: 0x00556155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026D25 RID: 159013 RVA: 0x00557F64 File Offset: 0x00556164
		public ISplineWayPointWithWeight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC06 RID: 44038
		// (get) Token: 0x06026D26 RID: 159014 RVA: 0x00557F74 File Offset: 0x00556174
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

		// Token: 0x1700AC07 RID: 44039
		// (get) Token: 0x06026D27 RID: 159015 RVA: 0x00557FB0 File Offset: 0x005561B0
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

		// Token: 0x1700AC08 RID: 44040
		// (get) Token: 0x06026D28 RID: 159016 RVA: 0x00557FEC File Offset: 0x005561EC
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

		// Token: 0x06026D29 RID: 159017 RVA: 0x00558028 File Offset: 0x00556228
		public static Offset<ISplineWayPointWithWeight> CreateISplineWayPointWithWeight(FlatBufferBuilder builder, int Spline = 0, int PointId = 0, int Weight = 0)
		{
			builder.StartTable(3);
			ISplineWayPointWithWeight.AddWeight(builder, Weight);
			ISplineWayPointWithWeight.AddPointId(builder, PointId);
			ISplineWayPointWithWeight.AddSpline(builder, Spline);
			return ISplineWayPointWithWeight.EndISplineWayPointWithWeight(builder);
		}

		// Token: 0x06026D2A RID: 159018 RVA: 0x0055804C File Offset: 0x0055624C
		public static void StartISplineWayPointWithWeight(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026D2B RID: 159019 RVA: 0x00558055 File Offset: 0x00556255
		public static void AddSpline(FlatBufferBuilder builder, int spline)
		{
			builder.AddInt(0, spline, 0);
		}

		// Token: 0x06026D2C RID: 159020 RVA: 0x00558060 File Offset: 0x00556260
		public static void AddPointId(FlatBufferBuilder builder, int pointId)
		{
			builder.AddInt(1, pointId, 0);
		}

		// Token: 0x06026D2D RID: 159021 RVA: 0x0055806B File Offset: 0x0055626B
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x06026D2E RID: 159022 RVA: 0x00558076 File Offset: 0x00556276
		public static Offset<ISplineWayPointWithWeight> EndISplineWayPointWithWeight(FlatBufferBuilder builder)
		{
			return new Offset<ISplineWayPointWithWeight>(builder.EndTable());
		}

		// Token: 0x06026D2F RID: 159023 RVA: 0x00558084 File Offset: 0x00556284
		public ISplineWayPointWithWeightT UnPack()
		{
			ISplineWayPointWithWeightT splineWayPointWithWeightT = new ISplineWayPointWithWeightT();
			this.UnPackTo(splineWayPointWithWeightT);
			return splineWayPointWithWeightT;
		}

		// Token: 0x06026D30 RID: 159024 RVA: 0x0055809F File Offset: 0x0055629F
		public void UnPackTo(ISplineWayPointWithWeightT _o)
		{
			_o.Spline = this.Spline;
			_o.PointId = this.PointId;
			_o.Weight = this.Weight;
		}

		// Token: 0x06026D31 RID: 159025 RVA: 0x005580C8 File Offset: 0x005562C8
		public static Offset<ISplineWayPointWithWeight> Pack(FlatBufferBuilder builder, ISplineWayPointWithWeightT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineWayPointWithWeight>);
			}
			return ISplineWayPointWithWeight.CreateISplineWayPointWithWeight(builder, _o.Spline, _o.PointId, _o.Weight);
		}

		// Token: 0x0400EF8F RID: 61327
		private Table __p;
	}
}
