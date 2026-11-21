using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005478 RID: 21624
	public struct IButterflySplinePoint : IFlatbufferObject
	{
		// Token: 0x170099C4 RID: 39364
		// (get) Token: 0x06021F91 RID: 139153 RVA: 0x004AEBB8 File Offset: 0x004ACDB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F92 RID: 139154 RVA: 0x004AEBC5 File Offset: 0x004ACDC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F93 RID: 139155 RVA: 0x004AEBCC File Offset: 0x004ACDCC
		public static IButterflySplinePoint GetRootAsIButterflySplinePoint(ByteBuffer _bb)
		{
			return IButterflySplinePoint.GetRootAsIButterflySplinePoint(_bb, default(IButterflySplinePoint));
		}

		// Token: 0x06021F94 RID: 139156 RVA: 0x004AEBE8 File Offset: 0x004ACDE8
		public static IButterflySplinePoint GetRootAsIButterflySplinePoint(ByteBuffer _bb, IButterflySplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F95 RID: 139157 RVA: 0x004AEC05 File Offset: 0x004ACE05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F96 RID: 139158 RVA: 0x004AEC14 File Offset: 0x004ACE14
		public IButterflySplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099C5 RID: 39365
		// (get) Token: 0x06021F97 RID: 139159 RVA: 0x004AEC24 File Offset: 0x004ACE24
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

		// Token: 0x170099C6 RID: 39366
		// (get) Token: 0x06021F98 RID: 139160 RVA: 0x004AEC84 File Offset: 0x004ACE84
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

		// Token: 0x170099C7 RID: 39367
		// (get) Token: 0x06021F99 RID: 139161 RVA: 0x004AECE4 File Offset: 0x004ACEE4
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

		// Token: 0x170099C8 RID: 39368
		// (get) Token: 0x06021F9A RID: 139162 RVA: 0x004AED44 File Offset: 0x004ACF44
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

		// Token: 0x170099C9 RID: 39369
		// (get) Token: 0x06021F9B RID: 139163 RVA: 0x004AED84 File Offset: 0x004ACF84
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

		// Token: 0x170099CA RID: 39370
		// (get) Token: 0x06021F9C RID: 139164 RVA: 0x004AEDE4 File Offset: 0x004ACFE4
		public int MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170099CB RID: 39371
		// (get) Token: 0x06021F9D RID: 139165 RVA: 0x004AEE24 File Offset: 0x004AD024
		public bool IgnorePoint
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021F9E RID: 139166 RVA: 0x004AEE64 File Offset: 0x004AD064
		public static Offset<IButterflySplinePoint> CreateIButterflySplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), int MoveSpeed = 0, bool IgnorePoint = false)
		{
			builder.StartTable(7);
			IButterflySplinePoint.AddMoveSpeed(builder, MoveSpeed);
			IButterflySplinePoint.AddRotation(builder, RotationOffset);
			IButterflySplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IButterflySplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IButterflySplinePoint.AddPosition(builder, PositionOffset);
			IButterflySplinePoint.AddIgnorePoint(builder, IgnorePoint);
			IButterflySplinePoint.AddLineType(builder, LineType);
			return IButterflySplinePoint.EndIButterflySplinePoint(builder);
		}

		// Token: 0x06021F9F RID: 139167 RVA: 0x004AEEB3 File Offset: 0x004AD0B3
		public static void StartIButterflySplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06021FA0 RID: 139168 RVA: 0x004AEEBC File Offset: 0x004AD0BC
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06021FA1 RID: 139169 RVA: 0x004AEECC File Offset: 0x004AD0CC
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06021FA2 RID: 139170 RVA: 0x004AEEDC File Offset: 0x004AD0DC
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06021FA3 RID: 139171 RVA: 0x004AEEEC File Offset: 0x004AD0EC
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06021FA4 RID: 139172 RVA: 0x004AEEF7 File Offset: 0x004AD0F7
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06021FA5 RID: 139173 RVA: 0x004AEF07 File Offset: 0x004AD107
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(5, moveSpeed, 0);
		}

		// Token: 0x06021FA6 RID: 139174 RVA: 0x004AEF12 File Offset: 0x004AD112
		public static void AddIgnorePoint(FlatBufferBuilder builder, bool ignorePoint)
		{
			builder.AddBool(6, ignorePoint, false);
		}

		// Token: 0x06021FA7 RID: 139175 RVA: 0x004AEF1D File Offset: 0x004AD11D
		public static Offset<IButterflySplinePoint> EndIButterflySplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IButterflySplinePoint>(builder.EndTable());
		}

		// Token: 0x06021FA8 RID: 139176 RVA: 0x004AEF2C File Offset: 0x004AD12C
		public IButterflySplinePointT UnPack()
		{
			IButterflySplinePointT butterflySplinePointT = new IButterflySplinePointT();
			this.UnPackTo(butterflySplinePointT);
			return butterflySplinePointT;
		}

		// Token: 0x06021FA9 RID: 139177 RVA: 0x004AEF48 File Offset: 0x004AD148
		public void UnPackTo(IButterflySplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.MoveSpeed = this.MoveSpeed;
			_o.IgnorePoint = this.IgnorePoint;
		}

		// Token: 0x06021FAA RID: 139178 RVA: 0x004AF038 File Offset: 0x004AD238
		public static Offset<IButterflySplinePoint> Pack(FlatBufferBuilder builder, IButterflySplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IButterflySplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return IButterflySplinePoint.CreateIButterflySplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.MoveSpeed, _o.IgnorePoint);
		}

		// Token: 0x0400E963 RID: 59747
		private Table __p;
	}
}
