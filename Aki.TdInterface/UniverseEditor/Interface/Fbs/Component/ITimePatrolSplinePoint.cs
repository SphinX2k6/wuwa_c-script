using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8B RID: 23179
	public struct ITimePatrolSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700AE90 RID: 44688
		// (get) Token: 0x060277AF RID: 161711 RVA: 0x0056E994 File Offset: 0x0056CB94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060277B0 RID: 161712 RVA: 0x0056E9A1 File Offset: 0x0056CBA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060277B1 RID: 161713 RVA: 0x0056E9A8 File Offset: 0x0056CBA8
		public static ITimePatrolSplinePoint GetRootAsITimePatrolSplinePoint(ByteBuffer _bb)
		{
			return ITimePatrolSplinePoint.GetRootAsITimePatrolSplinePoint(_bb, default(ITimePatrolSplinePoint));
		}

		// Token: 0x060277B2 RID: 161714 RVA: 0x0056E9C4 File Offset: 0x0056CBC4
		public static ITimePatrolSplinePoint GetRootAsITimePatrolSplinePoint(ByteBuffer _bb, ITimePatrolSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060277B3 RID: 161715 RVA: 0x0056E9E1 File Offset: 0x0056CBE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060277B4 RID: 161716 RVA: 0x0056E9F0 File Offset: 0x0056CBF0
		public ITimePatrolSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE91 RID: 44689
		// (get) Token: 0x060277B5 RID: 161717 RVA: 0x0056EA00 File Offset: 0x0056CC00
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

		// Token: 0x1700AE92 RID: 44690
		// (get) Token: 0x060277B6 RID: 161718 RVA: 0x0056EA60 File Offset: 0x0056CC60
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

		// Token: 0x1700AE93 RID: 44691
		// (get) Token: 0x060277B7 RID: 161719 RVA: 0x0056EAC0 File Offset: 0x0056CCC0
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

		// Token: 0x1700AE94 RID: 44692
		// (get) Token: 0x060277B8 RID: 161720 RVA: 0x0056EB20 File Offset: 0x0056CD20
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

		// Token: 0x1700AE95 RID: 44693
		// (get) Token: 0x060277B9 RID: 161721 RVA: 0x0056EB60 File Offset: 0x0056CD60
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

		// Token: 0x1700AE96 RID: 44694
		// (get) Token: 0x060277BA RID: 161722 RVA: 0x0056EBC0 File Offset: 0x0056CDC0
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

		// Token: 0x1700AE97 RID: 44695
		// (get) Token: 0x060277BB RID: 161723 RVA: 0x0056EC00 File Offset: 0x0056CE00
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

		// Token: 0x1700AE98 RID: 44696
		// (get) Token: 0x060277BC RID: 161724 RVA: 0x0056EC40 File Offset: 0x0056CE40
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

		// Token: 0x1700AE99 RID: 44697
		// (get) Token: 0x060277BD RID: 161725 RVA: 0x0056EC80 File Offset: 0x0056CE80
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

		// Token: 0x060277BE RID: 161726 RVA: 0x0056ECC0 File Offset: 0x0056CEC0
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

		// Token: 0x060277BF RID: 161727 RVA: 0x0056ED20 File Offset: 0x0056CF20
		public static void StartITimePatrolSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060277C0 RID: 161728 RVA: 0x0056ED2A File Offset: 0x0056CF2A
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x060277C1 RID: 161729 RVA: 0x0056ED3A File Offset: 0x0056CF3A
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x060277C2 RID: 161730 RVA: 0x0056ED4A File Offset: 0x0056CF4A
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x060277C3 RID: 161731 RVA: 0x0056ED5A File Offset: 0x0056CF5A
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x060277C4 RID: 161732 RVA: 0x0056ED65 File Offset: 0x0056CF65
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x060277C5 RID: 161733 RVA: 0x0056ED75 File Offset: 0x0056CF75
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(5, hours, 0);
		}

		// Token: 0x060277C6 RID: 161734 RVA: 0x0056ED80 File Offset: 0x0056CF80
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(6, minutes, 0);
		}

		// Token: 0x060277C7 RID: 161735 RVA: 0x0056ED8B File Offset: 0x0056CF8B
		public static void AddSecond(FlatBufferBuilder builder, int second)
		{
			builder.AddInt(7, second, 0);
		}

		// Token: 0x060277C8 RID: 161736 RVA: 0x0056ED96 File Offset: 0x0056CF96
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060277C9 RID: 161737 RVA: 0x0056EDA1 File Offset: 0x0056CFA1
		public static Offset<ITimePatrolSplinePoint> EndITimePatrolSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ITimePatrolSplinePoint>(builder.EndTable());
		}

		// Token: 0x060277CA RID: 161738 RVA: 0x0056EDB0 File Offset: 0x0056CFB0
		public ITimePatrolSplinePointT UnPack()
		{
			ITimePatrolSplinePointT timePatrolSplinePointT = new ITimePatrolSplinePointT();
			this.UnPackTo(timePatrolSplinePointT);
			return timePatrolSplinePointT;
		}

		// Token: 0x060277CB RID: 161739 RVA: 0x0056EDCC File Offset: 0x0056CFCC
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

		// Token: 0x060277CC RID: 161740 RVA: 0x0056EED4 File Offset: 0x0056D0D4
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

		// Token: 0x0400F140 RID: 61760
		private Table __p;
	}
}
