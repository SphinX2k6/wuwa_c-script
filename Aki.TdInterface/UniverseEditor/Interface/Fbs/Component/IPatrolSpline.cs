using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D17 RID: 23831
	public struct IPatrolSpline : IFlatbufferObject
	{
		// Token: 0x1700AF0A RID: 44810
		// (get) Token: 0x0602793A RID: 162106 RVA: 0x00569E30 File Offset: 0x00568030
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602793B RID: 162107 RVA: 0x00569E3D File Offset: 0x0056803D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602793C RID: 162108 RVA: 0x00569E44 File Offset: 0x00568044
		public static IPatrolSpline GetRootAsIPatrolSpline(ByteBuffer _bb)
		{
			return IPatrolSpline.GetRootAsIPatrolSpline(_bb, default(IPatrolSpline));
		}

		// Token: 0x0602793D RID: 162109 RVA: 0x00569E60 File Offset: 0x00568060
		public static IPatrolSpline GetRootAsIPatrolSpline(ByteBuffer _bb, IPatrolSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602793E RID: 162110 RVA: 0x00569E7D File Offset: 0x0056807D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602793F RID: 162111 RVA: 0x00569E8C File Offset: 0x0056808C
		public IPatrolSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF0B RID: 44811
		// (get) Token: 0x06027940 RID: 162112 RVA: 0x00569E9C File Offset: 0x0056809C
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

		// Token: 0x1700AF0C RID: 44812
		// (get) Token: 0x06027941 RID: 162113 RVA: 0x00569ED8 File Offset: 0x005680D8
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

		// Token: 0x06027942 RID: 162114 RVA: 0x00569F14 File Offset: 0x00568114
		public TTable? CycleOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027943 RID: 162115 RVA: 0x00569F58 File Offset: 0x00568158
		public IPatrolCycleLooply CycleOptionAsIPatrolCycleLooply()
		{
			return this.CycleOption<IPatrolCycleLooply>().Value;
		}

		// Token: 0x06027944 RID: 162116 RVA: 0x00569F74 File Offset: 0x00568174
		public IPatrolCycleOncely CycleOptionAsIPatrolCycleOncely()
		{
			return this.CycleOption<IPatrolCycleOncely>().Value;
		}

		// Token: 0x1700AF0D RID: 44813
		// (get) Token: 0x06027945 RID: 162117 RVA: 0x00569F90 File Offset: 0x00568190
		public bool IsNavigation
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF0E RID: 44814
		// (get) Token: 0x06027946 RID: 162118 RVA: 0x00569FD0 File Offset: 0x005681D0
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

		// Token: 0x1700AF0F RID: 44815
		// (get) Token: 0x06027947 RID: 162119 RVA: 0x0056A014 File Offset: 0x00568214
		public bool IsFloating
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027948 RID: 162120 RVA: 0x0056A054 File Offset: 0x00568254
		public IPatrolPositionRefreshConfig? PositionRefreshConfigs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IPatrolPositionRefreshConfig?(default(IPatrolPositionRefreshConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF10 RID: 44816
		// (get) Token: 0x06027949 RID: 162121 RVA: 0x0056A0B8 File Offset: 0x005682B8
		public int PositionRefreshConfigsLength
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

		// Token: 0x0602794A RID: 162122 RVA: 0x0056A0E4 File Offset: 0x005682E4
		public IPatrolSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IPatrolSplinePoint?(default(IPatrolSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF11 RID: 44817
		// (get) Token: 0x0602794B RID: 162123 RVA: 0x0056A148 File Offset: 0x00568348
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AF12 RID: 44818
		// (get) Token: 0x0602794C RID: 162124 RVA: 0x0056A174 File Offset: 0x00568374
		public IPatrolRange? PatrolRange
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IPatrolRange?(default(IPatrolRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF13 RID: 44819
		// (get) Token: 0x0602794D RID: 162125 RVA: 0x0056A1D4 File Offset: 0x005683D4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602794E RID: 162126 RVA: 0x0056A214 File Offset: 0x00568414
		public static Offset<IPatrolSpline> CreateIPatrolSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, TPatrolCycleOption CycleOption_type = TPatrolCycleOption.NONE, int CycleOptionOffset = 0, bool IsNavigation = false, float TurnSpeed = 0f, bool IsFloating = false, VectorOffset PositionRefreshConfigsOffset = default(VectorOffset), VectorOffset PointsOffset = default(VectorOffset), Offset<IPatrolRange> PatrolRangeOffset = default(Offset<IPatrolRange>), byte NullMask = 0)
		{
			builder.StartTable(10);
			IPatrolSpline.AddPatrolRange(builder, PatrolRangeOffset);
			IPatrolSpline.AddPoints(builder, PointsOffset);
			IPatrolSpline.AddPositionRefreshConfigs(builder, PositionRefreshConfigsOffset);
			IPatrolSpline.AddTurnSpeed(builder, TurnSpeed);
			IPatrolSpline.AddCycleOption(builder, CycleOptionOffset);
			IPatrolSpline.AddNullMask(builder, NullMask);
			IPatrolSpline.AddIsFloating(builder, IsFloating);
			IPatrolSpline.AddIsNavigation(builder, IsNavigation);
			IPatrolSpline.AddCycleOptionType(builder, CycleOption_type);
			IPatrolSpline.AddType(builder, Type);
			return IPatrolSpline.EndIPatrolSpline(builder);
		}

		// Token: 0x0602794F RID: 162127 RVA: 0x0056A27C File Offset: 0x0056847C
		public static void StartIPatrolSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06027950 RID: 162128 RVA: 0x0056A286 File Offset: 0x00568486
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027951 RID: 162129 RVA: 0x0056A291 File Offset: 0x00568491
		public static void AddCycleOptionType(FlatBufferBuilder builder, TPatrolCycleOption cycleOptionType)
		{
			builder.AddByte(1, (byte)cycleOptionType, 0);
		}

		// Token: 0x06027952 RID: 162130 RVA: 0x0056A29C File Offset: 0x0056849C
		public static void AddCycleOption(FlatBufferBuilder builder, int cycleOptionOffset)
		{
			builder.AddOffset(2, cycleOptionOffset, 0);
		}

		// Token: 0x06027953 RID: 162131 RVA: 0x0056A2A7 File Offset: 0x005684A7
		public static void AddIsNavigation(FlatBufferBuilder builder, bool isNavigation)
		{
			builder.AddBool(3, isNavigation, false);
		}

		// Token: 0x06027954 RID: 162132 RVA: 0x0056A2B2 File Offset: 0x005684B2
		public static void AddTurnSpeed(FlatBufferBuilder builder, float turnSpeed)
		{
			builder.AddFloat(4, turnSpeed, 0.0);
		}

		// Token: 0x06027955 RID: 162133 RVA: 0x0056A2C5 File Offset: 0x005684C5
		public static void AddIsFloating(FlatBufferBuilder builder, bool isFloating)
		{
			builder.AddBool(5, isFloating, false);
		}

		// Token: 0x06027956 RID: 162134 RVA: 0x0056A2D0 File Offset: 0x005684D0
		public static void AddPositionRefreshConfigs(FlatBufferBuilder builder, VectorOffset positionRefreshConfigsOffset)
		{
			builder.AddOffset(6, positionRefreshConfigsOffset.Value, 0);
		}

		// Token: 0x06027957 RID: 162135 RVA: 0x0056A2E0 File Offset: 0x005684E0
		public static VectorOffset CreatePositionRefreshConfigsVector(FlatBufferBuilder builder, Offset<IPatrolPositionRefreshConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027958 RID: 162136 RVA: 0x0056A320 File Offset: 0x00568520
		public static VectorOffset CreatePositionRefreshConfigsVectorBlock(FlatBufferBuilder builder, Offset<IPatrolPositionRefreshConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPatrolPositionRefreshConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027959 RID: 162137 RVA: 0x0056A33A File Offset: 0x0056853A
		public static VectorOffset CreatePositionRefreshConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPatrolPositionRefreshConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPatrolPositionRefreshConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602795A RID: 162138 RVA: 0x0056A358 File Offset: 0x00568558
		public static VectorOffset CreatePositionRefreshConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPatrolPositionRefreshConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602795B RID: 162139 RVA: 0x0056A371 File Offset: 0x00568571
		public static void StartPositionRefreshConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602795C RID: 162140 RVA: 0x0056A37C File Offset: 0x0056857C
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(7, pointsOffset.Value, 0);
		}

		// Token: 0x0602795D RID: 162141 RVA: 0x0056A38C File Offset: 0x0056858C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IPatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602795E RID: 162142 RVA: 0x0056A3CC File Offset: 0x005685CC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IPatrolSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602795F RID: 162143 RVA: 0x0056A3E6 File Offset: 0x005685E6
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPatrolSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPatrolSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027960 RID: 162144 RVA: 0x0056A404 File Offset: 0x00568604
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPatrolSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027961 RID: 162145 RVA: 0x0056A41D File Offset: 0x0056861D
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027962 RID: 162146 RVA: 0x0056A428 File Offset: 0x00568628
		public static void AddPatrolRange(FlatBufferBuilder builder, Offset<IPatrolRange> patrolRangeOffset)
		{
			builder.AddOffset(8, patrolRangeOffset.Value, 0);
		}

		// Token: 0x06027963 RID: 162147 RVA: 0x0056A438 File Offset: 0x00568638
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06027964 RID: 162148 RVA: 0x0056A444 File Offset: 0x00568644
		public static Offset<IPatrolSpline> EndIPatrolSpline(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolSpline>(builder.EndTable());
		}

		// Token: 0x06027965 RID: 162149 RVA: 0x0056A454 File Offset: 0x00568654
		public IPatrolSplineT UnPack()
		{
			IPatrolSplineT patrolSplineT = new IPatrolSplineT();
			this.UnPackTo(patrolSplineT);
			return patrolSplineT;
		}

		// Token: 0x06027966 RID: 162150 RVA: 0x0056A470 File Offset: 0x00568670
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
			_o.PositionRefreshConfigs = new List<IPatrolPositionRefreshConfigT>();
			for (int i = 0; i < this.PositionRefreshConfigsLength; i++)
			{
				_o.PositionRefreshConfigs.Add((this.PositionRefreshConfigs(i) != null) ? this.PositionRefreshConfigs(i).Value.UnPack() : null);
			}
			_o.Points = new List<IPatrolSplinePointT>();
			for (int j = 0; j < this.PointsLength; j++)
			{
				_o.Points.Add((this.Points(j) != null) ? this.Points(j).Value.UnPack() : null);
			}
			_o.PatrolRange = ((this.PatrolRange != null) ? this.PatrolRange.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027967 RID: 162151 RVA: 0x0056A63C File Offset: 0x0056883C
		public static Offset<IPatrolSpline> Pack(FlatBufferBuilder builder, IPatrolSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolSpline>);
			}
			TPatrolCycleOption cycleOption_type = (_o.CycleOption == null) ? TPatrolCycleOption.NONE : _o.CycleOption.Type;
			int cycleOptionOffset = (_o.CycleOption == null) ? 0 : TPatrolCycleOptionUnion.Pack(builder, _o.CycleOption);
			VectorOffset positionRefreshConfigsOffset = default(VectorOffset);
			if (_o.PositionRefreshConfigs != null)
			{
				Offset<IPatrolPositionRefreshConfig>[] array = new Offset<IPatrolPositionRefreshConfig>[_o.PositionRefreshConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPatrolPositionRefreshConfig.Pack(builder, _o.PositionRefreshConfigs[i]);
				}
				positionRefreshConfigsOffset = IPatrolSpline.CreatePositionRefreshConfigsVector(builder, array);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IPatrolSplinePoint>[] array2 = new Offset<IPatrolSplinePoint>[_o.Points.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IPatrolSplinePoint.Pack(builder, _o.Points[j]);
				}
				pointsOffset = IPatrolSpline.CreatePointsVector(builder, array2);
			}
			Offset<IPatrolRange> patrolRangeOffset = (_o.PatrolRange == null) ? default(Offset<IPatrolRange>) : IPatrolRange.Pack(builder, _o.PatrolRange);
			return IPatrolSpline.CreateIPatrolSpline(builder, _o.Type, cycleOption_type, cycleOptionOffset, _o.IsNavigation, _o.TurnSpeed, _o.IsFloating, positionRefreshConfigsOffset, pointsOffset, patrolRangeOffset, _o.NullMask);
		}

		// Token: 0x0400F856 RID: 63574
		private Table __p;
	}
}
