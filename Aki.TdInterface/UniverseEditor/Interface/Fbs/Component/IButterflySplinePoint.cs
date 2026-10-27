using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F49 RID: 20297
	public struct IButterflySplinePoint : IFlatbufferObject
	{
		// Token: 0x1700924B RID: 37451
		// (get) Token: 0x0602023F RID: 131647 RVA: 0x00478BC8 File Offset: 0x00476DC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020240 RID: 131648 RVA: 0x00478BD5 File Offset: 0x00476DD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020241 RID: 131649 RVA: 0x00478BDC File Offset: 0x00476DDC
		public static IButterflySplinePoint GetRootAsIButterflySplinePoint(ByteBuffer _bb)
		{
			return IButterflySplinePoint.GetRootAsIButterflySplinePoint(_bb, default(IButterflySplinePoint));
		}

		// Token: 0x06020242 RID: 131650 RVA: 0x00478BF8 File Offset: 0x00476DF8
		public static IButterflySplinePoint GetRootAsIButterflySplinePoint(ByteBuffer _bb, IButterflySplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020243 RID: 131651 RVA: 0x00478C15 File Offset: 0x00476E15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020244 RID: 131652 RVA: 0x00478C24 File Offset: 0x00476E24
		public IButterflySplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700924C RID: 37452
		// (get) Token: 0x06020245 RID: 131653 RVA: 0x00478C34 File Offset: 0x00476E34
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

		// Token: 0x1700924D RID: 37453
		// (get) Token: 0x06020246 RID: 131654 RVA: 0x00478C94 File Offset: 0x00476E94
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

		// Token: 0x1700924E RID: 37454
		// (get) Token: 0x06020247 RID: 131655 RVA: 0x00478CF4 File Offset: 0x00476EF4
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

		// Token: 0x1700924F RID: 37455
		// (get) Token: 0x06020248 RID: 131656 RVA: 0x00478D54 File Offset: 0x00476F54
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

		// Token: 0x17009250 RID: 37456
		// (get) Token: 0x06020249 RID: 131657 RVA: 0x00478D94 File Offset: 0x00476F94
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

		// Token: 0x17009251 RID: 37457
		// (get) Token: 0x0602024A RID: 131658 RVA: 0x00478DF4 File Offset: 0x00476FF4
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

		// Token: 0x17009252 RID: 37458
		// (get) Token: 0x0602024B RID: 131659 RVA: 0x00478E34 File Offset: 0x00477034
		public bool IgnorePoint
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602024C RID: 131660 RVA: 0x00478E74 File Offset: 0x00477074
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

		// Token: 0x0602024D RID: 131661 RVA: 0x00478EC3 File Offset: 0x004770C3
		public static void StartIButterflySplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602024E RID: 131662 RVA: 0x00478ECC File Offset: 0x004770CC
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0602024F RID: 131663 RVA: 0x00478EDC File Offset: 0x004770DC
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06020250 RID: 131664 RVA: 0x00478EEC File Offset: 0x004770EC
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06020251 RID: 131665 RVA: 0x00478EFC File Offset: 0x004770FC
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06020252 RID: 131666 RVA: 0x00478F07 File Offset: 0x00477107
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06020253 RID: 131667 RVA: 0x00478F17 File Offset: 0x00477117
		public static void AddMoveSpeed(FlatBufferBuilder builder, int moveSpeed)
		{
			builder.AddInt(5, moveSpeed, 0);
		}

		// Token: 0x06020254 RID: 131668 RVA: 0x00478F22 File Offset: 0x00477122
		public static void AddIgnorePoint(FlatBufferBuilder builder, bool ignorePoint)
		{
			builder.AddBool(6, ignorePoint, false);
		}

		// Token: 0x06020255 RID: 131669 RVA: 0x00478F2D File Offset: 0x0047712D
		public static Offset<IButterflySplinePoint> EndIButterflySplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IButterflySplinePoint>(builder.EndTable());
		}

		// Token: 0x06020256 RID: 131670 RVA: 0x00478F3C File Offset: 0x0047713C
		public IButterflySplinePointT UnPack()
		{
			IButterflySplinePointT butterflySplinePointT = new IButterflySplinePointT();
			this.UnPackTo(butterflySplinePointT);
			return butterflySplinePointT;
		}

		// Token: 0x06020257 RID: 131671 RVA: 0x00478F58 File Offset: 0x00477158
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

		// Token: 0x06020258 RID: 131672 RVA: 0x00479048 File Offset: 0x00477248
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

		// Token: 0x0400DDB9 RID: 56761
		private Table __p;
	}
}
