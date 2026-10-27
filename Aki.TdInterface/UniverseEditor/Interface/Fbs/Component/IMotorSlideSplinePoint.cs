using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CF RID: 21967
	public struct IMotorSlideSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700A26B RID: 41579
		// (get) Token: 0x0602468B RID: 149131 RVA: 0x00506A8F File Offset: 0x00504C8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602468C RID: 149132 RVA: 0x00506A9C File Offset: 0x00504C9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602468D RID: 149133 RVA: 0x00506AA4 File Offset: 0x00504CA4
		public static IMotorSlideSplinePoint GetRootAsIMotorSlideSplinePoint(ByteBuffer _bb)
		{
			return IMotorSlideSplinePoint.GetRootAsIMotorSlideSplinePoint(_bb, default(IMotorSlideSplinePoint));
		}

		// Token: 0x0602468E RID: 149134 RVA: 0x00506AC0 File Offset: 0x00504CC0
		public static IMotorSlideSplinePoint GetRootAsIMotorSlideSplinePoint(ByteBuffer _bb, IMotorSlideSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602468F RID: 149135 RVA: 0x00506ADD File Offset: 0x00504CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024690 RID: 149136 RVA: 0x00506AEC File Offset: 0x00504CEC
		public IMotorSlideSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A26C RID: 41580
		// (get) Token: 0x06024691 RID: 149137 RVA: 0x00506AFC File Offset: 0x00504CFC
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

		// Token: 0x1700A26D RID: 41581
		// (get) Token: 0x06024692 RID: 149138 RVA: 0x00506B5C File Offset: 0x00504D5C
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

		// Token: 0x1700A26E RID: 41582
		// (get) Token: 0x06024693 RID: 149139 RVA: 0x00506BBC File Offset: 0x00504DBC
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

		// Token: 0x1700A26F RID: 41583
		// (get) Token: 0x06024694 RID: 149140 RVA: 0x00506C1C File Offset: 0x00504E1C
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

		// Token: 0x1700A270 RID: 41584
		// (get) Token: 0x06024695 RID: 149141 RVA: 0x00506C5C File Offset: 0x00504E5C
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

		// Token: 0x1700A271 RID: 41585
		// (get) Token: 0x06024696 RID: 149142 RVA: 0x00506CBC File Offset: 0x00504EBC
		public float MaxSpeed
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

		// Token: 0x1700A272 RID: 41586
		// (get) Token: 0x06024697 RID: 149143 RVA: 0x00506D00 File Offset: 0x00504F00
		public float AbsAcceleration
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A273 RID: 41587
		// (get) Token: 0x06024698 RID: 149144 RVA: 0x00506D44 File Offset: 0x00504F44
		public EMotorSlideOffDirection OffDirection
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EMotorSlideOffDirection.Left;
				}
				return (EMotorSlideOffDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A274 RID: 41588
		// (get) Token: 0x06024699 RID: 149145 RVA: 0x00506D84 File Offset: 0x00504F84
		public int LeftTargetId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A275 RID: 41589
		// (get) Token: 0x0602469A RID: 149146 RVA: 0x00506DC4 File Offset: 0x00504FC4
		public int RightTargetId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A276 RID: 41590
		// (get) Token: 0x0602469B RID: 149147 RVA: 0x00506E04 File Offset: 0x00505004
		public int SubCameraTag
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A277 RID: 41591
		// (get) Token: 0x0602469C RID: 149148 RVA: 0x00506E44 File Offset: 0x00505044
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602469D RID: 149149 RVA: 0x00506E84 File Offset: 0x00505084
		public static Offset<IMotorSlideSplinePoint> CreateIMotorSlideSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), float MaxSpeed = 0f, float AbsAcceleration = 0f, EMotorSlideOffDirection OffDirection = EMotorSlideOffDirection.Left, int LeftTargetId = 0, int RightTargetId = 0, int SubCameraTag = 0, byte NullMask = 0)
		{
			builder.StartTable(12);
			IMotorSlideSplinePoint.AddSubCameraTag(builder, SubCameraTag);
			IMotorSlideSplinePoint.AddRightTargetId(builder, RightTargetId);
			IMotorSlideSplinePoint.AddLeftTargetId(builder, LeftTargetId);
			IMotorSlideSplinePoint.AddAbsAcceleration(builder, AbsAcceleration);
			IMotorSlideSplinePoint.AddMaxSpeed(builder, MaxSpeed);
			IMotorSlideSplinePoint.AddRotation(builder, RotationOffset);
			IMotorSlideSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IMotorSlideSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IMotorSlideSplinePoint.AddPosition(builder, PositionOffset);
			IMotorSlideSplinePoint.AddNullMask(builder, NullMask);
			IMotorSlideSplinePoint.AddOffDirection(builder, OffDirection);
			IMotorSlideSplinePoint.AddLineType(builder, LineType);
			return IMotorSlideSplinePoint.EndIMotorSlideSplinePoint(builder);
		}

		// Token: 0x0602469E RID: 149150 RVA: 0x00506EFC File Offset: 0x005050FC
		public static void StartIMotorSlideSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0602469F RID: 149151 RVA: 0x00506F06 File Offset: 0x00505106
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x060246A0 RID: 149152 RVA: 0x00506F16 File Offset: 0x00505116
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x060246A1 RID: 149153 RVA: 0x00506F26 File Offset: 0x00505126
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x060246A2 RID: 149154 RVA: 0x00506F36 File Offset: 0x00505136
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x060246A3 RID: 149155 RVA: 0x00506F41 File Offset: 0x00505141
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x060246A4 RID: 149156 RVA: 0x00506F51 File Offset: 0x00505151
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(5, maxSpeed, 0.0);
		}

		// Token: 0x060246A5 RID: 149157 RVA: 0x00506F64 File Offset: 0x00505164
		public static void AddAbsAcceleration(FlatBufferBuilder builder, float absAcceleration)
		{
			builder.AddFloat(6, absAcceleration, 0.0);
		}

		// Token: 0x060246A6 RID: 149158 RVA: 0x00506F77 File Offset: 0x00505177
		public static void AddOffDirection(FlatBufferBuilder builder, EMotorSlideOffDirection offDirection)
		{
			builder.AddByte(7, (byte)offDirection, 0);
		}

		// Token: 0x060246A7 RID: 149159 RVA: 0x00506F82 File Offset: 0x00505182
		public static void AddLeftTargetId(FlatBufferBuilder builder, int leftTargetId)
		{
			builder.AddInt(8, leftTargetId, 0);
		}

		// Token: 0x060246A8 RID: 149160 RVA: 0x00506F8D File Offset: 0x0050518D
		public static void AddRightTargetId(FlatBufferBuilder builder, int rightTargetId)
		{
			builder.AddInt(9, rightTargetId, 0);
		}

		// Token: 0x060246A9 RID: 149161 RVA: 0x00506F99 File Offset: 0x00505199
		public static void AddSubCameraTag(FlatBufferBuilder builder, int subCameraTag)
		{
			builder.AddInt(10, subCameraTag, 0);
		}

		// Token: 0x060246AA RID: 149162 RVA: 0x00506FA5 File Offset: 0x005051A5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060246AB RID: 149163 RVA: 0x00506FB1 File Offset: 0x005051B1
		public static Offset<IMotorSlideSplinePoint> EndIMotorSlideSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSlideSplinePoint>(builder.EndTable());
		}

		// Token: 0x060246AC RID: 149164 RVA: 0x00506FC0 File Offset: 0x005051C0
		public IMotorSlideSplinePointT UnPack()
		{
			IMotorSlideSplinePointT motorSlideSplinePointT = new IMotorSlideSplinePointT();
			this.UnPackTo(motorSlideSplinePointT);
			return motorSlideSplinePointT;
		}

		// Token: 0x060246AD RID: 149165 RVA: 0x00506FDC File Offset: 0x005051DC
		public void UnPackTo(IMotorSlideSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.MaxSpeed = this.MaxSpeed;
			_o.AbsAcceleration = this.AbsAcceleration;
			_o.OffDirection = this.OffDirection;
			_o.LeftTargetId = this.LeftTargetId;
			_o.RightTargetId = this.RightTargetId;
			_o.SubCameraTag = this.SubCameraTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060246AE RID: 149166 RVA: 0x00507108 File Offset: 0x00505308
		public static Offset<IMotorSlideSplinePoint> Pack(FlatBufferBuilder builder, IMotorSlideSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSlideSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return IMotorSlideSplinePoint.CreateIMotorSlideSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.MaxSpeed, _o.AbsAcceleration, _o.OffDirection, _o.LeftTargetId, _o.RightTargetId, _o.SubCameraTag, _o.NullMask);
		}

		// Token: 0x0400E925 RID: 59685
		private Table __p;
	}
}
