using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005481 RID: 21633
	public struct ICaptureStrategicPoint : IFlatbufferObject
	{
		// Token: 0x170099EB RID: 39403
		// (get) Token: 0x06022021 RID: 139297 RVA: 0x004B035A File Offset: 0x004AE55A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022022 RID: 139298 RVA: 0x004B0367 File Offset: 0x004AE567
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022023 RID: 139299 RVA: 0x004B0370 File Offset: 0x004AE570
		public static ICaptureStrategicPoint GetRootAsICaptureStrategicPoint(ByteBuffer _bb)
		{
			return ICaptureStrategicPoint.GetRootAsICaptureStrategicPoint(_bb, default(ICaptureStrategicPoint));
		}

		// Token: 0x06022024 RID: 139300 RVA: 0x004B038C File Offset: 0x004AE58C
		public static ICaptureStrategicPoint GetRootAsICaptureStrategicPoint(ByteBuffer _bb, ICaptureStrategicPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022025 RID: 139301 RVA: 0x004B03A9 File Offset: 0x004AE5A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022026 RID: 139302 RVA: 0x004B03B8 File Offset: 0x004AE5B8
		public ICaptureStrategicPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099EC RID: 39404
		// (get) Token: 0x06022027 RID: 139303 RVA: 0x004B03C8 File Offset: 0x004AE5C8
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

		// Token: 0x170099ED RID: 39405
		// (get) Token: 0x06022028 RID: 139304 RVA: 0x004B0404 File Offset: 0x004AE604
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

		// Token: 0x170099EE RID: 39406
		// (get) Token: 0x06022029 RID: 139305 RVA: 0x004B0440 File Offset: 0x004AE640
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

		// Token: 0x170099EF RID: 39407
		// (get) Token: 0x0602202A RID: 139306 RVA: 0x004B047C File Offset: 0x004AE67C
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

		// Token: 0x170099F0 RID: 39408
		// (get) Token: 0x0602202B RID: 139307 RVA: 0x004B04BC File Offset: 0x004AE6BC
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

		// Token: 0x170099F1 RID: 39409
		// (get) Token: 0x0602202C RID: 139308 RVA: 0x004B04FC File Offset: 0x004AE6FC
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

		// Token: 0x170099F2 RID: 39410
		// (get) Token: 0x0602202D RID: 139309 RVA: 0x004B053C File Offset: 0x004AE73C
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

		// Token: 0x170099F3 RID: 39411
		// (get) Token: 0x0602202E RID: 139310 RVA: 0x004B057C File Offset: 0x004AE77C
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

		// Token: 0x170099F4 RID: 39412
		// (get) Token: 0x0602202F RID: 139311 RVA: 0x004B05DC File Offset: 0x004AE7DC
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

		// Token: 0x170099F5 RID: 39413
		// (get) Token: 0x06022030 RID: 139312 RVA: 0x004B061C File Offset: 0x004AE81C
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

		// Token: 0x06022031 RID: 139313 RVA: 0x004B065C File Offset: 0x004AE85C
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

		// Token: 0x06022032 RID: 139314 RVA: 0x004B06C4 File Offset: 0x004AE8C4
		public static void StartICaptureStrategicPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06022033 RID: 139315 RVA: 0x004B06CE File Offset: 0x004AE8CE
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022034 RID: 139316 RVA: 0x004B06D9 File Offset: 0x004AE8D9
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x06022035 RID: 139317 RVA: 0x004B06E4 File Offset: 0x004AE8E4
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x06022036 RID: 139318 RVA: 0x004B06EF File Offset: 0x004AE8EF
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x06022037 RID: 139319 RVA: 0x004B06FA File Offset: 0x004AE8FA
		public static void AddIncreaseSpeed(FlatBufferBuilder builder, int increaseSpeed)
		{
			builder.AddInt(4, increaseSpeed, 0);
		}

		// Token: 0x06022038 RID: 139320 RVA: 0x004B0705 File Offset: 0x004AE905
		public static void AddDecreaseSpeed(FlatBufferBuilder builder, int decreaseSpeed)
		{
			builder.AddInt(5, decreaseSpeed, 0);
		}

		// Token: 0x06022039 RID: 139321 RVA: 0x004B0710 File Offset: 0x004AE910
		public static void AddUnoccupiedDecreaseSpeed(FlatBufferBuilder builder, int unoccupiedDecreaseSpeed)
		{
			builder.AddInt(6, unoccupiedDecreaseSpeed, 0);
		}

		// Token: 0x0602203A RID: 139322 RVA: 0x004B071B File Offset: 0x004AE91B
		public static void AddEnemyEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset)
		{
			builder.AddOffset(7, enemyEntitiyMatchOffset.Value, 0);
		}

		// Token: 0x0602203B RID: 139323 RVA: 0x004B072B File Offset: 0x004AE92B
		public static void AddCaptureType(FlatBufferBuilder builder, ECaptureStateType captureType)
		{
			builder.AddByte(8, (byte)captureType, 0);
		}

		// Token: 0x0602203C RID: 139324 RVA: 0x004B0736 File Offset: 0x004AE936
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0602203D RID: 139325 RVA: 0x004B0742 File Offset: 0x004AE942
		public static Offset<ICaptureStrategicPoint> EndICaptureStrategicPoint(FlatBufferBuilder builder)
		{
			return new Offset<ICaptureStrategicPoint>(builder.EndTable());
		}

		// Token: 0x0602203E RID: 139326 RVA: 0x004B0750 File Offset: 0x004AE950
		public ICaptureStrategicPointT UnPack()
		{
			ICaptureStrategicPointT captureStrategicPointT = new ICaptureStrategicPointT();
			this.UnPackTo(captureStrategicPointT);
			return captureStrategicPointT;
		}

		// Token: 0x0602203F RID: 139327 RVA: 0x004B076C File Offset: 0x004AE96C
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

		// Token: 0x06022040 RID: 139328 RVA: 0x004B0814 File Offset: 0x004AEA14
		public static Offset<ICaptureStrategicPoint> Pack(FlatBufferBuilder builder, ICaptureStrategicPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICaptureStrategicPoint>);
			}
			Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset = (_o.EnemyEntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EnemyEntitiyMatch);
			return ICaptureStrategicPoint.CreateICaptureStrategicPoint(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.IncreaseSpeed, _o.DecreaseSpeed, _o.UnoccupiedDecreaseSpeed, enemyEntitiyMatchOffset, _o.CaptureType, _o.NullMask);
		}

		// Token: 0x0400E978 RID: 59768
		private Table __p;
	}
}
