using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A16 RID: 23062
	public struct ISwordRiderRailSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700AD53 RID: 44371
		// (get) Token: 0x06027293 RID: 160403 RVA: 0x005630EB File Offset: 0x005612EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027294 RID: 160404 RVA: 0x005630F8 File Offset: 0x005612F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027295 RID: 160405 RVA: 0x00563100 File Offset: 0x00561300
		public static ISwordRiderRailSplinePoint GetRootAsISwordRiderRailSplinePoint(ByteBuffer _bb)
		{
			return ISwordRiderRailSplinePoint.GetRootAsISwordRiderRailSplinePoint(_bb, default(ISwordRiderRailSplinePoint));
		}

		// Token: 0x06027296 RID: 160406 RVA: 0x0056311C File Offset: 0x0056131C
		public static ISwordRiderRailSplinePoint GetRootAsISwordRiderRailSplinePoint(ByteBuffer _bb, ISwordRiderRailSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027297 RID: 160407 RVA: 0x00563139 File Offset: 0x00561339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027298 RID: 160408 RVA: 0x00563148 File Offset: 0x00561348
		public ISwordRiderRailSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD54 RID: 44372
		// (get) Token: 0x06027299 RID: 160409 RVA: 0x00563158 File Offset: 0x00561358
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD55 RID: 44373
		// (get) Token: 0x0602729A RID: 160410 RVA: 0x005631B8 File Offset: 0x005613B8
		public IVectorInfo? ArriveTangent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD56 RID: 44374
		// (get) Token: 0x0602729B RID: 160411 RVA: 0x00563218 File Offset: 0x00561418
		public IVectorInfo? LeaveTangent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD57 RID: 44375
		// (get) Token: 0x0602729C RID: 160412 RVA: 0x00563278 File Offset: 0x00561478
		public ESplineLine LineType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ESplineLine.Linear;
				}
				return (ESplineLine)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD58 RID: 44376
		// (get) Token: 0x0602729D RID: 160413 RVA: 0x005632B8 File Offset: 0x005614B8
		public IVectorInfo? Rotation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD59 RID: 44377
		// (get) Token: 0x0602729E RID: 160414 RVA: 0x00563318 File Offset: 0x00561518
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD5A RID: 44378
		// (get) Token: 0x0602729F RID: 160415 RVA: 0x0056335C File Offset: 0x0056155C
		public int HalfAvailableAngle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD5B RID: 44379
		// (get) Token: 0x060272A0 RID: 160416 RVA: 0x0056339C File Offset: 0x0056159C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060272A1 RID: 160417 RVA: 0x005633DC File Offset: 0x005615DC
		public static Offset<ISwordRiderRailSplinePoint> CreateISwordRiderRailSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), float Radius = 0f, int HalfAvailableAngle = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			ISwordRiderRailSplinePoint.AddHalfAvailableAngle(builder, HalfAvailableAngle);
			ISwordRiderRailSplinePoint.AddRadius(builder, Radius);
			ISwordRiderRailSplinePoint.AddRotation(builder, RotationOffset);
			ISwordRiderRailSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			ISwordRiderRailSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			ISwordRiderRailSplinePoint.AddPosition(builder, PositionOffset);
			ISwordRiderRailSplinePoint.AddNullMask(builder, NullMask);
			ISwordRiderRailSplinePoint.AddLineType(builder, LineType);
			return ISwordRiderRailSplinePoint.EndISwordRiderRailSplinePoint(builder);
		}

		// Token: 0x060272A2 RID: 160418 RVA: 0x00563433 File Offset: 0x00561633
		public static void StartISwordRiderRailSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060272A3 RID: 160419 RVA: 0x0056343C File Offset: 0x0056163C
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x060272A4 RID: 160420 RVA: 0x0056344C File Offset: 0x0056164C
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x060272A5 RID: 160421 RVA: 0x0056345C File Offset: 0x0056165C
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x060272A6 RID: 160422 RVA: 0x0056346C File Offset: 0x0056166C
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x060272A7 RID: 160423 RVA: 0x00563477 File Offset: 0x00561677
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x060272A8 RID: 160424 RVA: 0x00563487 File Offset: 0x00561687
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(5, radius, 0.0);
		}

		// Token: 0x060272A9 RID: 160425 RVA: 0x0056349A File Offset: 0x0056169A
		public static void AddHalfAvailableAngle(FlatBufferBuilder builder, int halfAvailableAngle)
		{
			builder.AddInt(6, halfAvailableAngle, 0);
		}

		// Token: 0x060272AA RID: 160426 RVA: 0x005634A5 File Offset: 0x005616A5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060272AB RID: 160427 RVA: 0x005634B0 File Offset: 0x005616B0
		public static Offset<ISwordRiderRailSplinePoint> EndISwordRiderRailSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ISwordRiderRailSplinePoint>(builder.EndTable());
		}

		// Token: 0x060272AC RID: 160428 RVA: 0x005634C0 File Offset: 0x005616C0
		public ISwordRiderRailSplinePointT UnPack()
		{
			ISwordRiderRailSplinePointT swordRiderRailSplinePointT = new ISwordRiderRailSplinePointT();
			this.UnPackTo(swordRiderRailSplinePointT);
			return swordRiderRailSplinePointT;
		}

		// Token: 0x060272AD RID: 160429 RVA: 0x005634DC File Offset: 0x005616DC
		public void UnPackTo(ISwordRiderRailSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.HalfAvailableAngle = this.HalfAvailableAngle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060272AE RID: 160430 RVA: 0x005635D8 File Offset: 0x005617D8
		public static Offset<ISwordRiderRailSplinePoint> Pack(FlatBufferBuilder builder, ISwordRiderRailSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwordRiderRailSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return ISwordRiderRailSplinePoint.CreateISwordRiderRailSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.Radius, _o.HalfAvailableAngle, _o.NullMask);
		}

		// Token: 0x0400F063 RID: 61539
		private Table __p;
	}
}
