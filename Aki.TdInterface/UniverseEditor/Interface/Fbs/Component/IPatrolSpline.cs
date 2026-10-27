using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005710 RID: 22288
	public struct IPatrolSpline : IFlatbufferObject
	{
		// Token: 0x1700A5EE RID: 42478
		// (get) Token: 0x06025439 RID: 152633 RVA: 0x005243FC File Offset: 0x005225FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602543A RID: 152634 RVA: 0x00524409 File Offset: 0x00522609
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602543B RID: 152635 RVA: 0x00524410 File Offset: 0x00522610
		public static IPatrolSpline GetRootAsIPatrolSpline(ByteBuffer _bb)
		{
			return IPatrolSpline.GetRootAsIPatrolSpline(_bb, default(IPatrolSpline));
		}

		// Token: 0x0602543C RID: 152636 RVA: 0x0052442C File Offset: 0x0052262C
		public static IPatrolSpline GetRootAsIPatrolSpline(ByteBuffer _bb, IPatrolSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602543D RID: 152637 RVA: 0x00524449 File Offset: 0x00522649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602543E RID: 152638 RVA: 0x00524458 File Offset: 0x00522658
		public IPatrolSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5EF RID: 42479
		// (get) Token: 0x0602543F RID: 152639 RVA: 0x00524468 File Offset: 0x00522668
		public ESplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineType.Common;
				}
				return (ESplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A5F0 RID: 42480
		// (get) Token: 0x06025440 RID: 152640 RVA: 0x005244A4 File Offset: 0x005226A4
		public TPatrolCycleOption CycleOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TPatrolCycleOption.NONE;
				}
				return (TPatrolCycleOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025441 RID: 152641 RVA: 0x005244E0 File Offset: 0x005226E0
		public TTable? CycleOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025442 RID: 152642 RVA: 0x00524524 File Offset: 0x00522724
		public IPatrolCycleLooply CycleOptionAsIPatrolCycleLooply()
		{
			return this.CycleOption<IPatrolCycleLooply>().Value;
		}

		// Token: 0x06025443 RID: 152643 RVA: 0x00524540 File Offset: 0x00522740
		public IPatrolCycleOncely CycleOptionAsIPatrolCycleOncely()
		{
			return this.CycleOption<IPatrolCycleOncely>().Value;
		}

		// Token: 0x1700A5F1 RID: 42481
		// (get) Token: 0x06025444 RID: 152644 RVA: 0x0052455C File Offset: 0x0052275C
		public bool IsNavigation
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5F2 RID: 42482
		// (get) Token: 0x06025445 RID: 152645 RVA: 0x0052459C File Offset: 0x0052279C
		public float TurnSpeed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A5F3 RID: 42483
		// (get) Token: 0x06025446 RID: 152646 RVA: 0x005245E0 File Offset: 0x005227E0
		public bool IsFloating
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025447 RID: 152647 RVA: 0x00524620 File Offset: 0x00522820
		public IPatrolSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IPatrolSplinePoint?(default(IPatrolSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5F4 RID: 42484
		// (get) Token: 0x06025448 RID: 152648 RVA: 0x00524684 File Offset: 0x00522884
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A5F5 RID: 42485
		// (get) Token: 0x06025449 RID: 152649 RVA: 0x005246B0 File Offset: 0x005228B0
		public IPatrolRange? PatrolRange
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IPatrolRange?(default(IPatrolRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A5F6 RID: 42486
		// (get) Token: 0x0602544A RID: 152650 RVA: 0x00524710 File Offset: 0x00522910
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

		// Token: 0x0602544B RID: 152651 RVA: 0x00524750 File Offset: 0x00522950
		public static Offset<IPatrolSpline> CreateIPatrolSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, TPatrolCycleOption CycleOption_type = TPatrolCycleOption.NONE, int CycleOptionOffset = 0, bool IsNavigation = false, float TurnSpeed = 0f, bool IsFloating = false, VectorOffset PointsOffset = default(VectorOffset), Offset<IPatrolRange> PatrolRangeOffset = default(Offset<IPatrolRange>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IPatrolSpline.AddPatrolRange(builder, PatrolRangeOffset);
			IPatrolSpline.AddPoints(builder, PointsOffset);
			IPatrolSpline.AddTurnSpeed(builder, TurnSpeed);
			IPatrolSpline.AddCycleOption(builder, CycleOptionOffset);
			IPatrolSpline.AddNullMask(builder, NullMask);
			IPatrolSpline.AddIsFloating(builder, IsFloating);
			IPatrolSpline.AddIsNavigation(builder, IsNavigation);
			IPatrolSpline.AddCycleOptionType(builder, CycleOption_type);
			IPatrolSpline.AddType(builder, Type);
			return IPatrolSpline.EndIPatrolSpline(builder);
		}

		// Token: 0x0602544C RID: 152652 RVA: 0x005247B0 File Offset: 0x005229B0
		public static void StartIPatrolSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602544D RID: 152653 RVA: 0x005247BA File Offset: 0x005229BA
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602544E RID: 152654 RVA: 0x005247C5 File Offset: 0x005229C5
		public static void AddCycleOptionType(FlatBufferBuilder builder, TPatrolCycleOption cycleOptionType)
		{
			builder.AddByte(1, (byte)cycleOptionType, 0);
		}

		// Token: 0x0602544F RID: 152655 RVA: 0x005247D0 File Offset: 0x005229D0
		public static void AddCycleOption(FlatBufferBuilder builder, int cycleOptionOffset)
		{
			builder.AddOffset(2, cycleOptionOffset, 0);
		}

		// Token: 0x06025450 RID: 152656 RVA: 0x005247DB File Offset: 0x005229DB
		public static void AddIsNavigation(FlatBufferBuilder builder, bool isNavigation)
		{
			builder.AddBool(3, isNavigation, false);
		}

		// Token: 0x06025451 RID: 152657 RVA: 0x005247E6 File Offset: 0x005229E6
		public static void AddTurnSpeed(FlatBufferBuilder builder, float turnSpeed)
		{
			builder.AddFloat(4, turnSpeed, 0.0);
		}

		// Token: 0x06025452 RID: 152658 RVA: 0x005247F9 File Offset: 0x005229F9
		public static void AddIsFloating(FlatBufferBuilder builder, bool isFloating)
		{
			builder.AddBool(5, isFloating, false);
		}

		// Token: 0x06025453 RID: 152659 RVA: 0x00524804 File Offset: 0x00522A04
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(6, pointsOffset.Value, 0);
		}

		// Token: 0x06025454 RID: 152660 RVA: 0x00524814 File Offset: 0x00522A14
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IPatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025455 RID: 152661 RVA: 0x00524854 File Offset: 0x00522A54
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IPatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025456 RID: 152662 RVA: 0x0052486E File Offset: 0x00522A6E
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPatrolSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025457 RID: 152663 RVA: 0x0052488C File Offset: 0x00522A8C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPatrolSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025458 RID: 152664 RVA: 0x005248A5 File Offset: 0x00522AA5
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025459 RID: 152665 RVA: 0x005248B0 File Offset: 0x00522AB0
		public static void AddPatrolRange(FlatBufferBuilder builder, Offset<IPatrolRange> patrolRangeOffset)
		{
			builder.AddOffset(7, patrolRangeOffset.Value, 0);
		}

		// Token: 0x0602545A RID: 152666 RVA: 0x005248C0 File Offset: 0x00522AC0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602545B RID: 152667 RVA: 0x005248CB File Offset: 0x00522ACB
		public static Offset<IPatrolSpline> EndIPatrolSpline(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolSpline>(builder.EndTable());
		}

		// Token: 0x0602545C RID: 152668 RVA: 0x005248D8 File Offset: 0x00522AD8
		public IPatrolSplineT UnPack()
		{
			IPatrolSplineT patrolSplineT = new IPatrolSplineT();
			this.UnPackTo(patrolSplineT);
			return patrolSplineT;
		}

		// Token: 0x0602545D RID: 152669 RVA: 0x005248F4 File Offset: 0x00522AF4
		public void UnPackTo(IPatrolSplineT _o)
		{
			_o.Type = this.Type;
			_o.CycleOption = new TPatrolCycleOptionUnion();
			_o.CycleOption.Type = this.CycleOptionType;
			TPatrolCycleOption cycleOptionType = this.CycleOptionType;
			if (cycleOptionType != TPatrolCycleOption.IPatrolCycleLooply)
			{
				if (cycleOptionType == TPatrolCycleOption.IPatrolCycleOncely)
				{
					_o.CycleOption.Value = ((this.CycleOption<IPatrolCycleOncely>() != null) ? this.CycleOption<IPatrolCycleOncely>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.CycleOption.Value = ((this.CycleOption<IPatrolCycleLooply>() != null) ? this.CycleOption<IPatrolCycleLooply>().Value.UnPack() : null);
			}
			_o.IsNavigation = this.IsNavigation;
			_o.TurnSpeed = this.TurnSpeed;
			_o.IsFloating = this.IsFloating;
			_o.Points = new List<IPatrolSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
			_o.PatrolRange = ((this.PatrolRange != null) ? this.PatrolRange.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602545E RID: 152670 RVA: 0x00524A64 File Offset: 0x00522C64
		public static Offset<IPatrolSpline> Pack(FlatBufferBuilder builder, IPatrolSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolSpline>);
			}
			TPatrolCycleOption cycleOption_type = (_o.CycleOption == null) ? TPatrolCycleOption.NONE : _o.CycleOption.Type;
			int cycleOptionOffset = (_o.CycleOption == null) ? 0 : TPatrolCycleOptionUnion.Pack(builder, _o.CycleOption);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IPatrolSplinePoint>[] array = new Offset<IPatrolSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPatrolSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IPatrolSpline.CreatePointsVector(builder, array);
			}
			Offset<IPatrolRange> patrolRangeOffset = (_o.PatrolRange == null) ? default(Offset<IPatrolRange>) : IPatrolRange.Pack(builder, _o.PatrolRange);
			return IPatrolSpline.CreateIPatrolSpline(builder, _o.Type, cycleOption_type, cycleOptionOffset, _o.IsNavigation, _o.TurnSpeed, _o.IsFloating, pointsOffset, patrolRangeOffset, _o.NullMask);
		}

		// Token: 0x0400EB6F RID: 60271
		private Table __p;
	}
}
