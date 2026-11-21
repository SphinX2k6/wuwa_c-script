using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006023 RID: 24611
	public struct ISwordRiderRailSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700B68B RID: 46731
		// (get) Token: 0x0602980B RID: 169995 RVA: 0x005AA0AF File Offset: 0x005A82AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602980C RID: 169996 RVA: 0x005AA0BC File Offset: 0x005A82BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602980D RID: 169997 RVA: 0x005AA0C4 File Offset: 0x005A82C4
		public static ISwordRiderRailSplinePoint GetRootAsISwordRiderRailSplinePoint(ByteBuffer _bb)
		{
			return ISwordRiderRailSplinePoint.GetRootAsISwordRiderRailSplinePoint(_bb, default(ISwordRiderRailSplinePoint));
		}

		// Token: 0x0602980E RID: 169998 RVA: 0x005AA0E0 File Offset: 0x005A82E0
		public static ISwordRiderRailSplinePoint GetRootAsISwordRiderRailSplinePoint(ByteBuffer _bb, ISwordRiderRailSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602980F RID: 169999 RVA: 0x005AA0FD File Offset: 0x005A82FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029810 RID: 170000 RVA: 0x005AA10C File Offset: 0x005A830C
		public ISwordRiderRailSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B68C RID: 46732
		// (get) Token: 0x06029811 RID: 170001 RVA: 0x005AA11C File Offset: 0x005A831C
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

		// Token: 0x1700B68D RID: 46733
		// (get) Token: 0x06029812 RID: 170002 RVA: 0x005AA17C File Offset: 0x005A837C
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

		// Token: 0x1700B68E RID: 46734
		// (get) Token: 0x06029813 RID: 170003 RVA: 0x005AA1DC File Offset: 0x005A83DC
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

		// Token: 0x1700B68F RID: 46735
		// (get) Token: 0x06029814 RID: 170004 RVA: 0x005AA23C File Offset: 0x005A843C
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

		// Token: 0x1700B690 RID: 46736
		// (get) Token: 0x06029815 RID: 170005 RVA: 0x005AA27C File Offset: 0x005A847C
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

		// Token: 0x1700B691 RID: 46737
		// (get) Token: 0x06029816 RID: 170006 RVA: 0x005AA2DC File Offset: 0x005A84DC
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

		// Token: 0x1700B692 RID: 46738
		// (get) Token: 0x06029817 RID: 170007 RVA: 0x005AA320 File Offset: 0x005A8520
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

		// Token: 0x1700B693 RID: 46739
		// (get) Token: 0x06029818 RID: 170008 RVA: 0x005AA360 File Offset: 0x005A8560
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

		// Token: 0x06029819 RID: 170009 RVA: 0x005AA3A0 File Offset: 0x005A85A0
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

		// Token: 0x0602981A RID: 170010 RVA: 0x005AA3F7 File Offset: 0x005A85F7
		public static void StartISwordRiderRailSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602981B RID: 170011 RVA: 0x005AA400 File Offset: 0x005A8600
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0602981C RID: 170012 RVA: 0x005AA410 File Offset: 0x005A8610
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x0602981D RID: 170013 RVA: 0x005AA420 File Offset: 0x005A8620
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x0602981E RID: 170014 RVA: 0x005AA430 File Offset: 0x005A8630
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x0602981F RID: 170015 RVA: 0x005AA43B File Offset: 0x005A863B
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06029820 RID: 170016 RVA: 0x005AA44B File Offset: 0x005A864B
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(5, radius, 0.0);
		}

		// Token: 0x06029821 RID: 170017 RVA: 0x005AA45E File Offset: 0x005A865E
		public static void AddHalfAvailableAngle(FlatBufferBuilder builder, int halfAvailableAngle)
		{
			builder.AddInt(6, halfAvailableAngle, 0);
		}

		// Token: 0x06029822 RID: 170018 RVA: 0x005AA469 File Offset: 0x005A8669
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06029823 RID: 170019 RVA: 0x005AA474 File Offset: 0x005A8674
		public static Offset<ISwordRiderRailSplinePoint> EndISwordRiderRailSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ISwordRiderRailSplinePoint>(builder.EndTable());
		}

		// Token: 0x06029824 RID: 170020 RVA: 0x005AA484 File Offset: 0x005A8684
		public ISwordRiderRailSplinePointT UnPack()
		{
			ISwordRiderRailSplinePointT swordRiderRailSplinePointT = new ISwordRiderRailSplinePointT();
			this.UnPackTo(swordRiderRailSplinePointT);
			return swordRiderRailSplinePointT;
		}

		// Token: 0x06029825 RID: 170021 RVA: 0x005AA4A0 File Offset: 0x005A86A0
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

		// Token: 0x06029826 RID: 170022 RVA: 0x005AA59C File Offset: 0x005A879C
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

		// Token: 0x0400FD5A RID: 64858
		private Table __p;
	}
}
