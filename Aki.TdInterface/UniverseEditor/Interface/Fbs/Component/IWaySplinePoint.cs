using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006172 RID: 24946
	public struct IWaySplinePoint : IFlatbufferObject
	{
		// Token: 0x1700B9F8 RID: 47608
		// (get) Token: 0x0602A607 RID: 173575 RVA: 0x005C81A5 File Offset: 0x005C63A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A608 RID: 173576 RVA: 0x005C81B2 File Offset: 0x005C63B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A609 RID: 173577 RVA: 0x005C81BC File Offset: 0x005C63BC
		public static IWaySplinePoint GetRootAsIWaySplinePoint(ByteBuffer _bb)
		{
			return IWaySplinePoint.GetRootAsIWaySplinePoint(_bb, default(IWaySplinePoint));
		}

		// Token: 0x0602A60A RID: 173578 RVA: 0x005C81D8 File Offset: 0x005C63D8
		public static IWaySplinePoint GetRootAsIWaySplinePoint(ByteBuffer _bb, IWaySplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A60B RID: 173579 RVA: 0x005C81F5 File Offset: 0x005C63F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A60C RID: 173580 RVA: 0x005C8204 File Offset: 0x005C6404
		public IWaySplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9F9 RID: 47609
		// (get) Token: 0x0602A60D RID: 173581 RVA: 0x005C8214 File Offset: 0x005C6414
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

		// Token: 0x1700B9FA RID: 47610
		// (get) Token: 0x0602A60E RID: 173582 RVA: 0x005C8274 File Offset: 0x005C6474
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

		// Token: 0x1700B9FB RID: 47611
		// (get) Token: 0x0602A60F RID: 173583 RVA: 0x005C82D4 File Offset: 0x005C64D4
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

		// Token: 0x1700B9FC RID: 47612
		// (get) Token: 0x0602A610 RID: 173584 RVA: 0x005C8334 File Offset: 0x005C6534
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

		// Token: 0x1700B9FD RID: 47613
		// (get) Token: 0x0602A611 RID: 173585 RVA: 0x005C8374 File Offset: 0x005C6574
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

		// Token: 0x1700B9FE RID: 47614
		// (get) Token: 0x0602A612 RID: 173586 RVA: 0x005C83D4 File Offset: 0x005C65D4
		public TWaySplinePointType PointTypeType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TWaySplinePointType.NONE;
				}
				return (TWaySplinePointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A613 RID: 173587 RVA: 0x005C8414 File Offset: 0x005C6614
		public TTable? PointType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A614 RID: 173588 RVA: 0x005C845C File Offset: 0x005C665C
		public IWaySplineCommonPoint PointTypeAsIWaySplineCommonPoint()
		{
			return this.PointType<IWaySplineCommonPoint>().Value;
		}

		// Token: 0x0602A615 RID: 173589 RVA: 0x005C8478 File Offset: 0x005C6678
		public IWaySplineStartPoint PointTypeAsIWaySplineStartPoint()
		{
			return this.PointType<IWaySplineStartPoint>().Value;
		}

		// Token: 0x0602A616 RID: 173590 RVA: 0x005C8494 File Offset: 0x005C6694
		public static Offset<IWaySplinePoint> CreateIWaySplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), TWaySplinePointType PointType_type = TWaySplinePointType.NONE, int PointTypeOffset = 0)
		{
			builder.StartTable(7);
			IWaySplinePoint.AddPointType(builder, PointTypeOffset);
			IWaySplinePoint.AddRotation(builder, RotationOffset);
			IWaySplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IWaySplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IWaySplinePoint.AddPosition(builder, PositionOffset);
			IWaySplinePoint.AddPointTypeType(builder, PointType_type);
			IWaySplinePoint.AddLineType(builder, LineType);
			return IWaySplinePoint.EndIWaySplinePoint(builder);
		}

		// Token: 0x0602A617 RID: 173591 RVA: 0x005C84E3 File Offset: 0x005C66E3
		public static void StartIWaySplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602A618 RID: 173592 RVA: 0x005C84EC File Offset: 0x005C66EC
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0602A619 RID: 173593 RVA: 0x005C84FC File Offset: 0x005C66FC
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x0602A61A RID: 173594 RVA: 0x005C850C File Offset: 0x005C670C
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x0602A61B RID: 173595 RVA: 0x005C851C File Offset: 0x005C671C
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x0602A61C RID: 173596 RVA: 0x005C8527 File Offset: 0x005C6727
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x0602A61D RID: 173597 RVA: 0x005C8537 File Offset: 0x005C6737
		public static void AddPointTypeType(FlatBufferBuilder builder, TWaySplinePointType pointTypeType)
		{
			builder.AddByte(5, (byte)pointTypeType, 0);
		}

		// Token: 0x0602A61E RID: 173598 RVA: 0x005C8542 File Offset: 0x005C6742
		public static void AddPointType(FlatBufferBuilder builder, int pointTypeOffset)
		{
			builder.AddOffset(6, pointTypeOffset, 0);
		}

		// Token: 0x0602A61F RID: 173599 RVA: 0x005C854D File Offset: 0x005C674D
		public static Offset<IWaySplinePoint> EndIWaySplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplinePoint>(builder.EndTable());
		}

		// Token: 0x0602A620 RID: 173600 RVA: 0x005C855C File Offset: 0x005C675C
		public IWaySplinePointT UnPack()
		{
			IWaySplinePointT waySplinePointT = new IWaySplinePointT();
			this.UnPackTo(waySplinePointT);
			return waySplinePointT;
		}

		// Token: 0x0602A621 RID: 173601 RVA: 0x005C8578 File Offset: 0x005C6778
		public void UnPackTo(IWaySplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.PointType = new TWaySplinePointTypeUnion();
			_o.PointType.Type = this.PointTypeType;
			TWaySplinePointType pointTypeType = this.PointTypeType;
			if (pointTypeType == TWaySplinePointType.IWaySplineCommonPoint)
			{
				_o.PointType.Value = ((this.PointType<IWaySplineCommonPoint>() != null) ? this.PointType<IWaySplineCommonPoint>().Value.UnPack() : null);
				return;
			}
			if (pointTypeType != TWaySplinePointType.IWaySplineStartPoint)
			{
				return;
			}
			_o.PointType.Value = ((this.PointType<IWaySplineStartPoint>() != null) ? this.PointType<IWaySplineStartPoint>().Value.UnPack() : null);
		}

		// Token: 0x0602A622 RID: 173602 RVA: 0x005C86E8 File Offset: 0x005C68E8
		public static Offset<IWaySplinePoint> Pack(FlatBufferBuilder builder, IWaySplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			TWaySplinePointType pointType_type = (_o.PointType == null) ? TWaySplinePointType.NONE : _o.PointType.Type;
			int pointTypeOffset = (_o.PointType == null) ? 0 : TWaySplinePointTypeUnion.Pack(builder, _o.PointType);
			return IWaySplinePoint.CreateIWaySplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, pointType_type, pointTypeOffset);
		}

		// Token: 0x0400FFA9 RID: 65449
		private Table __p;
	}
}
