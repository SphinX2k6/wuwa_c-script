using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F52 RID: 20306
	public struct ICaptureStrategicPoint : IFlatbufferObject
	{
		// Token: 0x17009272 RID: 37490
		// (get) Token: 0x060202CF RID: 131791 RVA: 0x0047A36A File Offset: 0x0047856A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060202D0 RID: 131792 RVA: 0x0047A377 File Offset: 0x00478577
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060202D1 RID: 131793 RVA: 0x0047A380 File Offset: 0x00478580
		public static ICaptureStrategicPoint GetRootAsICaptureStrategicPoint(ByteBuffer _bb)
		{
			return ICaptureStrategicPoint.GetRootAsICaptureStrategicPoint(_bb, default(ICaptureStrategicPoint));
		}

		// Token: 0x060202D2 RID: 131794 RVA: 0x0047A39C File Offset: 0x0047859C
		public static ICaptureStrategicPoint GetRootAsICaptureStrategicPoint(ByteBuffer _bb, ICaptureStrategicPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060202D3 RID: 131795 RVA: 0x0047A3B9 File Offset: 0x004785B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060202D4 RID: 131796 RVA: 0x0047A3C8 File Offset: 0x004785C8
		public ICaptureStrategicPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009273 RID: 37491
		// (get) Token: 0x060202D5 RID: 131797 RVA: 0x0047A3D8 File Offset: 0x004785D8
		public EProgressBarControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return (EProgressBarControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009274 RID: 37492
		// (get) Token: 0x060202D6 RID: 131798 RVA: 0x0047A414 File Offset: 0x00478614
		public int MaxValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009275 RID: 37493
		// (get) Token: 0x060202D7 RID: 131799 RVA: 0x0047A450 File Offset: 0x00478650
		public int InitValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009276 RID: 37494
		// (get) Token: 0x060202D8 RID: 131800 RVA: 0x0047A48C File Offset: 0x0047868C
		public int ProgressPerformanceAttribute
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009277 RID: 37495
		// (get) Token: 0x060202D9 RID: 131801 RVA: 0x0047A4CC File Offset: 0x004786CC
		public int IncreaseSpeed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009278 RID: 37496
		// (get) Token: 0x060202DA RID: 131802 RVA: 0x0047A50C File Offset: 0x0047870C
		public int DecreaseSpeed
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

		// Token: 0x17009279 RID: 37497
		// (get) Token: 0x060202DB RID: 131803 RVA: 0x0047A54C File Offset: 0x0047874C
		public int UnoccupiedDecreaseSpeed
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

		// Token: 0x1700927A RID: 37498
		// (get) Token: 0x060202DC RID: 131804 RVA: 0x0047A58C File Offset: 0x0047878C
		public IStaticEntitiyMatch? EnemyEntitiyMatch
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IStaticEntitiyMatch?(default(IStaticEntitiyMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700927B RID: 37499
		// (get) Token: 0x060202DD RID: 131805 RVA: 0x0047A5EC File Offset: 0x004787EC
		public ECaptureStateType CaptureType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return ECaptureStateType.Default;
				}
				return (ECaptureStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700927C RID: 37500
		// (get) Token: 0x060202DE RID: 131806 RVA: 0x0047A62C File Offset: 0x0047882C
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

		// Token: 0x060202DF RID: 131807 RVA: 0x0047A66C File Offset: 0x0047886C
		public static Offset<ICaptureStrategicPoint> CreateICaptureStrategicPoint(FlatBufferBuilder builder, EProgressBarControlType Type = EProgressBarControlType.CaptureStrategicPoint, int MaxValue = 0, int InitValue = 0, int ProgressPerformanceAttribute = 0, int IncreaseSpeed = 0, int DecreaseSpeed = 0, int UnoccupiedDecreaseSpeed = 0, Offset<IStaticEntitiyMatch> EnemyEntitiyMatchOffset = default(Offset<IStaticEntitiyMatch>), ECaptureStateType CaptureType = ECaptureStateType.Default, byte NullMask = 0)
		{
			builder.StartTable(10);
			ICaptureStrategicPoint.AddEnemyEntitiyMatch(builder, EnemyEntitiyMatchOffset);
			ICaptureStrategicPoint.AddUnoccupiedDecreaseSpeed(builder, UnoccupiedDecreaseSpeed);
			ICaptureStrategicPoint.AddDecreaseSpeed(builder, DecreaseSpeed);
			ICaptureStrategicPoint.AddIncreaseSpeed(builder, IncreaseSpeed);
			ICaptureStrategicPoint.AddProgressPerformanceAttribute(builder, ProgressPerformanceAttribute);
			ICaptureStrategicPoint.AddInitValue(builder, InitValue);
			ICaptureStrategicPoint.AddMaxValue(builder, MaxValue);
			ICaptureStrategicPoint.AddNullMask(builder, NullMask);
			ICaptureStrategicPoint.AddCaptureType(builder, CaptureType);
			ICaptureStrategicPoint.AddType(builder, Type);
			return ICaptureStrategicPoint.EndICaptureStrategicPoint(builder);
		}

		// Token: 0x060202E0 RID: 131808 RVA: 0x0047A6D4 File Offset: 0x004788D4
		public static void StartICaptureStrategicPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060202E1 RID: 131809 RVA: 0x0047A6DE File Offset: 0x004788DE
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060202E2 RID: 131810 RVA: 0x0047A6E9 File Offset: 0x004788E9
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x060202E3 RID: 131811 RVA: 0x0047A6F4 File Offset: 0x004788F4
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x060202E4 RID: 131812 RVA: 0x0047A6FF File Offset: 0x004788FF
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x060202E5 RID: 131813 RVA: 0x0047A70A File Offset: 0x0047890A
		public static void AddIncreaseSpeed(FlatBufferBuilder builder, int increaseSpeed)
		{
			builder.AddInt(4, increaseSpeed, 0);
		}

		// Token: 0x060202E6 RID: 131814 RVA: 0x0047A715 File Offset: 0x00478915
		public static void AddDecreaseSpeed(FlatBufferBuilder builder, int decreaseSpeed)
		{
			builder.AddInt(5, decreaseSpeed, 0);
		}

		// Token: 0x060202E7 RID: 131815 RVA: 0x0047A720 File Offset: 0x00478920
		public static void AddUnoccupiedDecreaseSpeed(FlatBufferBuilder builder, int unoccupiedDecreaseSpeed)
		{
			builder.AddInt(6, unoccupiedDecreaseSpeed, 0);
		}

		// Token: 0x060202E8 RID: 131816 RVA: 0x0047A72B File Offset: 0x0047892B
		public static void AddEnemyEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset)
		{
			builder.AddOffset(7, enemyEntitiyMatchOffset.Value, 0);
		}

		// Token: 0x060202E9 RID: 131817 RVA: 0x0047A73B File Offset: 0x0047893B
		public static void AddCaptureType(FlatBufferBuilder builder, ECaptureStateType captureType)
		{
			builder.AddByte(8, (byte)captureType, 0);
		}

		// Token: 0x060202EA RID: 131818 RVA: 0x0047A746 File Offset: 0x00478946
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060202EB RID: 131819 RVA: 0x0047A752 File Offset: 0x00478952
		public static Offset<ICaptureStrategicPoint> EndICaptureStrategicPoint(FlatBufferBuilder builder)
		{
			return new Offset<ICaptureStrategicPoint>(builder.EndTable());
		}

		// Token: 0x060202EC RID: 131820 RVA: 0x0047A760 File Offset: 0x00478960
		public ICaptureStrategicPointT UnPack()
		{
			ICaptureStrategicPointT captureStrategicPointT = new ICaptureStrategicPointT();
			this.UnPackTo(captureStrategicPointT);
			return captureStrategicPointT;
		}

		// Token: 0x060202ED RID: 131821 RVA: 0x0047A77C File Offset: 0x0047897C
		public void UnPackTo(ICaptureStrategicPointT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
			_o.InitValue = this.InitValue;
			_o.ProgressPerformanceAttribute = this.ProgressPerformanceAttribute;
			_o.IncreaseSpeed = this.IncreaseSpeed;
			_o.DecreaseSpeed = this.DecreaseSpeed;
			_o.UnoccupiedDecreaseSpeed = this.UnoccupiedDecreaseSpeed;
			_o.EnemyEntitiyMatch = ((this.EnemyEntitiyMatch != null) ? this.EnemyEntitiyMatch.Value.UnPack() : null);
			_o.CaptureType = this.CaptureType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060202EE RID: 131822 RVA: 0x0047A824 File Offset: 0x00478A24
		public static Offset<ICaptureStrategicPoint> Pack(FlatBufferBuilder builder, ICaptureStrategicPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICaptureStrategicPoint>);
			}
			Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset = (_o.EnemyEntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EnemyEntitiyMatch);
			return ICaptureStrategicPoint.CreateICaptureStrategicPoint(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.IncreaseSpeed, _o.DecreaseSpeed, _o.UnoccupiedDecreaseSpeed, enemyEntitiyMatchOffset, _o.CaptureType, _o.NullMask);
		}

		// Token: 0x0400DDCE RID: 56782
		private Table __p;
	}
}
