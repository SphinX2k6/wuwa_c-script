using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006098 RID: 24728
	public struct ITimePatrolSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700B7C8 RID: 47048
		// (get) Token: 0x06029D27 RID: 171303 RVA: 0x005B59A0 File Offset: 0x005B3BA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D28 RID: 171304 RVA: 0x005B59AD File Offset: 0x005B3BAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D29 RID: 171305 RVA: 0x005B59B4 File Offset: 0x005B3BB4
		public static ITimePatrolSplinePoint GetRootAsITimePatrolSplinePoint(ByteBuffer _bb)
		{
			return ITimePatrolSplinePoint.GetRootAsITimePatrolSplinePoint(_bb, default(ITimePatrolSplinePoint));
		}

		// Token: 0x06029D2A RID: 171306 RVA: 0x005B59D0 File Offset: 0x005B3BD0
		public static ITimePatrolSplinePoint GetRootAsITimePatrolSplinePoint(ByteBuffer _bb, ITimePatrolSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D2B RID: 171307 RVA: 0x005B59ED File Offset: 0x005B3BED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D2C RID: 171308 RVA: 0x005B59FC File Offset: 0x005B3BFC
		public ITimePatrolSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7C9 RID: 47049
		// (get) Token: 0x06029D2D RID: 171309 RVA: 0x005B5A0C File Offset: 0x005B3C0C
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

		// Token: 0x1700B7CA RID: 47050
		// (get) Token: 0x06029D2E RID: 171310 RVA: 0x005B5A6C File Offset: 0x005B3C6C
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

		// Token: 0x1700B7CB RID: 47051
		// (get) Token: 0x06029D2F RID: 171311 RVA: 0x005B5ACC File Offset: 0x005B3CCC
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

		// Token: 0x1700B7CC RID: 47052
		// (get) Token: 0x06029D30 RID: 171312 RVA: 0x005B5B2C File Offset: 0x005B3D2C
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

		// Token: 0x1700B7CD RID: 47053
		// (get) Token: 0x06029D31 RID: 171313 RVA: 0x005B5B6C File Offset: 0x005B3D6C
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

		// Token: 0x1700B7CE RID: 47054
		// (get) Token: 0x06029D32 RID: 171314 RVA: 0x005B5BCC File Offset: 0x005B3DCC
		public int Hours
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

		// Token: 0x1700B7CF RID: 47055
		// (get) Token: 0x06029D33 RID: 171315 RVA: 0x005B5C0C File Offset: 0x005B3E0C
		public int Minutes
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

		// Token: 0x1700B7D0 RID: 47056
		// (get) Token: 0x06029D34 RID: 171316 RVA: 0x005B5C4C File Offset: 0x005B3E4C
		public int Second
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B7D1 RID: 47057
		// (get) Token: 0x06029D35 RID: 171317 RVA: 0x005B5C8C File Offset: 0x005B3E8C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029D36 RID: 171318 RVA: 0x005B5CCC File Offset: 0x005B3ECC
		public static Offset<ITimePatrolSplinePoint> CreateITimePatrolSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), int Hours = 0, int Minutes = 0, int Second = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ITimePatrolSplinePoint.AddSecond(builder, Second);
			ITimePatrolSplinePoint.AddMinutes(builder, Minutes);
			ITimePatrolSplinePoint.AddHours(builder, Hours);
			ITimePatrolSplinePoint.AddRotation(builder, RotationOffset);
			ITimePatrolSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			ITimePatrolSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			ITimePatrolSplinePoint.AddPosition(builder, PositionOffset);
			ITimePatrolSplinePoint.AddNullMask(builder, NullMask);
			ITimePatrolSplinePoint.AddLineType(builder, LineType);
			return ITimePatrolSplinePoint.EndITimePatrolSplinePoint(builder);
		}

		// Token: 0x06029D37 RID: 171319 RVA: 0x005B5D2C File Offset: 0x005B3F2C
		public static void StartITimePatrolSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06029D38 RID: 171320 RVA: 0x005B5D36 File Offset: 0x005B3F36
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06029D39 RID: 171321 RVA: 0x005B5D46 File Offset: 0x005B3F46
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06029D3A RID: 171322 RVA: 0x005B5D56 File Offset: 0x005B3F56
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06029D3B RID: 171323 RVA: 0x005B5D66 File Offset: 0x005B3F66
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06029D3C RID: 171324 RVA: 0x005B5D71 File Offset: 0x005B3F71
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06029D3D RID: 171325 RVA: 0x005B5D81 File Offset: 0x005B3F81
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(5, hours, 0);
		}

		// Token: 0x06029D3E RID: 171326 RVA: 0x005B5D8C File Offset: 0x005B3F8C
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(6, minutes, 0);
		}

		// Token: 0x06029D3F RID: 171327 RVA: 0x005B5D97 File Offset: 0x005B3F97
		public static void AddSecond(FlatBufferBuilder builder, int second)
		{
			builder.AddInt(7, second, 0);
		}

		// Token: 0x06029D40 RID: 171328 RVA: 0x005B5DA2 File Offset: 0x005B3FA2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06029D41 RID: 171329 RVA: 0x005B5DAD File Offset: 0x005B3FAD
		public static Offset<ITimePatrolSplinePoint> EndITimePatrolSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ITimePatrolSplinePoint>(builder.EndTable());
		}

		// Token: 0x06029D42 RID: 171330 RVA: 0x005B5DBC File Offset: 0x005B3FBC
		public ITimePatrolSplinePointT UnPack()
		{
			ITimePatrolSplinePointT timePatrolSplinePointT = new ITimePatrolSplinePointT();
			this.UnPackTo(timePatrolSplinePointT);
			return timePatrolSplinePointT;
		}

		// Token: 0x06029D43 RID: 171331 RVA: 0x005B5DD8 File Offset: 0x005B3FD8
		public void UnPackTo(ITimePatrolSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Second = this.Second;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029D44 RID: 171332 RVA: 0x005B5EE0 File Offset: 0x005B40E0
		public static Offset<ITimePatrolSplinePoint> Pack(FlatBufferBuilder builder, ITimePatrolSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimePatrolSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return ITimePatrolSplinePoint.CreateITimePatrolSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.Hours, _o.Minutes, _o.Second, _o.NullMask);
		}

		// Token: 0x0400FE37 RID: 65079
		private Table __p;
	}
}
