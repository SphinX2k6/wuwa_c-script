using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F55 RID: 20309
	public struct ICaptureStrategicPoint2 : IFlatbufferObject
	{
		// Token: 0x17009287 RID: 37511
		// (get) Token: 0x06020305 RID: 131845 RVA: 0x0047AA83 File Offset: 0x00478C83
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020306 RID: 131846 RVA: 0x0047AA90 File Offset: 0x00478C90
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020307 RID: 131847 RVA: 0x0047AA98 File Offset: 0x00478C98
		public static ICaptureStrategicPoint2 GetRootAsICaptureStrategicPoint2(ByteBuffer _bb)
		{
			return ICaptureStrategicPoint2.GetRootAsICaptureStrategicPoint2(_bb, default(ICaptureStrategicPoint2));
		}

		// Token: 0x06020308 RID: 131848 RVA: 0x0047AAB4 File Offset: 0x00478CB4
		public static ICaptureStrategicPoint2 GetRootAsICaptureStrategicPoint2(ByteBuffer _bb, ICaptureStrategicPoint2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020309 RID: 131849 RVA: 0x0047AAD1 File Offset: 0x00478CD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602030A RID: 131850 RVA: 0x0047AAE0 File Offset: 0x00478CE0
		public ICaptureStrategicPoint2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009288 RID: 37512
		// (get) Token: 0x0602030B RID: 131851 RVA: 0x0047AAF0 File Offset: 0x00478CF0
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

		// Token: 0x17009289 RID: 37513
		// (get) Token: 0x0602030C RID: 131852 RVA: 0x0047AB2C File Offset: 0x00478D2C
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

		// Token: 0x1700928A RID: 37514
		// (get) Token: 0x0602030D RID: 131853 RVA: 0x0047AB68 File Offset: 0x00478D68
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

		// Token: 0x1700928B RID: 37515
		// (get) Token: 0x0602030E RID: 131854 RVA: 0x0047ABA4 File Offset: 0x00478DA4
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

		// Token: 0x1700928C RID: 37516
		// (get) Token: 0x0602030F RID: 131855 RVA: 0x0047ABE4 File Offset: 0x00478DE4
		public IStaticEntitiyMatch? EnemyEntitiyMatch
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IStaticEntitiyMatch?(default(IStaticEntitiyMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700928D RID: 37517
		// (get) Token: 0x06020310 RID: 131856 RVA: 0x0047AC44 File Offset: 0x00478E44
		public float PlayerInMonsterOutCaptureSpeed
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

		// Token: 0x1700928E RID: 37518
		// (get) Token: 0x06020311 RID: 131857 RVA: 0x0047AC88 File Offset: 0x00478E88
		public float PlayerInMonsterInCaptureSpeed
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

		// Token: 0x1700928F RID: 37519
		// (get) Token: 0x06020312 RID: 131858 RVA: 0x0047ACCC File Offset: 0x00478ECC
		public float PlayerOutMonsterOutCaptureSpeed
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009290 RID: 37520
		// (get) Token: 0x06020313 RID: 131859 RVA: 0x0047AD10 File Offset: 0x00478F10
		public float PlayerOutMonsterInCaptureSpeed
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009291 RID: 37521
		// (get) Token: 0x06020314 RID: 131860 RVA: 0x0047AD54 File Offset: 0x00478F54
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

		// Token: 0x06020315 RID: 131861 RVA: 0x0047AD94 File Offset: 0x00478F94
		public static Offset<ICaptureStrategicPoint2> CreateICaptureStrategicPoint2(FlatBufferBuilder builder, EProgressBarControlType Type = EProgressBarControlType.CaptureStrategicPoint, int MaxValue = 0, int InitValue = 0, int ProgressPerformanceAttribute = 0, Offset<IStaticEntitiyMatch> EnemyEntitiyMatchOffset = default(Offset<IStaticEntitiyMatch>), float PlayerInMonsterOutCaptureSpeed = 0f, float PlayerInMonsterInCaptureSpeed = 0f, float PlayerOutMonsterOutCaptureSpeed = 0f, float PlayerOutMonsterInCaptureSpeed = 0f, byte NullMask = 0)
		{
			builder.StartTable(10);
			ICaptureStrategicPoint2.AddPlayerOutMonsterInCaptureSpeed(builder, PlayerOutMonsterInCaptureSpeed);
			ICaptureStrategicPoint2.AddPlayerOutMonsterOutCaptureSpeed(builder, PlayerOutMonsterOutCaptureSpeed);
			ICaptureStrategicPoint2.AddPlayerInMonsterInCaptureSpeed(builder, PlayerInMonsterInCaptureSpeed);
			ICaptureStrategicPoint2.AddPlayerInMonsterOutCaptureSpeed(builder, PlayerInMonsterOutCaptureSpeed);
			ICaptureStrategicPoint2.AddEnemyEntitiyMatch(builder, EnemyEntitiyMatchOffset);
			ICaptureStrategicPoint2.AddProgressPerformanceAttribute(builder, ProgressPerformanceAttribute);
			ICaptureStrategicPoint2.AddInitValue(builder, InitValue);
			ICaptureStrategicPoint2.AddMaxValue(builder, MaxValue);
			ICaptureStrategicPoint2.AddNullMask(builder, NullMask);
			ICaptureStrategicPoint2.AddType(builder, Type);
			return ICaptureStrategicPoint2.EndICaptureStrategicPoint2(builder);
		}

		// Token: 0x06020316 RID: 131862 RVA: 0x0047ADFC File Offset: 0x00478FFC
		public static void StartICaptureStrategicPoint2(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06020317 RID: 131863 RVA: 0x0047AE06 File Offset: 0x00479006
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020318 RID: 131864 RVA: 0x0047AE11 File Offset: 0x00479011
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x06020319 RID: 131865 RVA: 0x0047AE1C File Offset: 0x0047901C
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x0602031A RID: 131866 RVA: 0x0047AE27 File Offset: 0x00479027
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x0602031B RID: 131867 RVA: 0x0047AE32 File Offset: 0x00479032
		public static void AddEnemyEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset)
		{
			builder.AddOffset(4, enemyEntitiyMatchOffset.Value, 0);
		}

		// Token: 0x0602031C RID: 131868 RVA: 0x0047AE42 File Offset: 0x00479042
		public static void AddPlayerInMonsterOutCaptureSpeed(FlatBufferBuilder builder, float playerInMonsterOutCaptureSpeed)
		{
			builder.AddFloat(5, playerInMonsterOutCaptureSpeed, 0.0);
		}

		// Token: 0x0602031D RID: 131869 RVA: 0x0047AE55 File Offset: 0x00479055
		public static void AddPlayerInMonsterInCaptureSpeed(FlatBufferBuilder builder, float playerInMonsterInCaptureSpeed)
		{
			builder.AddFloat(6, playerInMonsterInCaptureSpeed, 0.0);
		}

		// Token: 0x0602031E RID: 131870 RVA: 0x0047AE68 File Offset: 0x00479068
		public static void AddPlayerOutMonsterOutCaptureSpeed(FlatBufferBuilder builder, float playerOutMonsterOutCaptureSpeed)
		{
			builder.AddFloat(7, playerOutMonsterOutCaptureSpeed, 0.0);
		}

		// Token: 0x0602031F RID: 131871 RVA: 0x0047AE7B File Offset: 0x0047907B
		public static void AddPlayerOutMonsterInCaptureSpeed(FlatBufferBuilder builder, float playerOutMonsterInCaptureSpeed)
		{
			builder.AddFloat(8, playerOutMonsterInCaptureSpeed, 0.0);
		}

		// Token: 0x06020320 RID: 131872 RVA: 0x0047AE8E File Offset: 0x0047908E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06020321 RID: 131873 RVA: 0x0047AE9A File Offset: 0x0047909A
		public static Offset<ICaptureStrategicPoint2> EndICaptureStrategicPoint2(FlatBufferBuilder builder)
		{
			return new Offset<ICaptureStrategicPoint2>(builder.EndTable());
		}

		// Token: 0x06020322 RID: 131874 RVA: 0x0047AEA8 File Offset: 0x004790A8
		public ICaptureStrategicPoint2T UnPack()
		{
			ICaptureStrategicPoint2T captureStrategicPoint2T = new ICaptureStrategicPoint2T();
			this.UnPackTo(captureStrategicPoint2T);
			return captureStrategicPoint2T;
		}

		// Token: 0x06020323 RID: 131875 RVA: 0x0047AEC4 File Offset: 0x004790C4
		public void UnPackTo(ICaptureStrategicPoint2T _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
			_o.InitValue = this.InitValue;
			_o.ProgressPerformanceAttribute = this.ProgressPerformanceAttribute;
			_o.EnemyEntitiyMatch = ((this.EnemyEntitiyMatch != null) ? this.EnemyEntitiyMatch.Value.UnPack() : null);
			_o.PlayerInMonsterOutCaptureSpeed = this.PlayerInMonsterOutCaptureSpeed;
			_o.PlayerInMonsterInCaptureSpeed = this.PlayerInMonsterInCaptureSpeed;
			_o.PlayerOutMonsterOutCaptureSpeed = this.PlayerOutMonsterOutCaptureSpeed;
			_o.PlayerOutMonsterInCaptureSpeed = this.PlayerOutMonsterInCaptureSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020324 RID: 131876 RVA: 0x0047AF6C File Offset: 0x0047916C
		public static Offset<ICaptureStrategicPoint2> Pack(FlatBufferBuilder builder, ICaptureStrategicPoint2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ICaptureStrategicPoint2>);
			}
			Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset = (_o.EnemyEntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EnemyEntitiyMatch);
			return ICaptureStrategicPoint2.CreateICaptureStrategicPoint2(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, enemyEntitiyMatchOffset, _o.PlayerInMonsterOutCaptureSpeed, _o.PlayerInMonsterInCaptureSpeed, _o.PlayerOutMonsterOutCaptureSpeed, _o.PlayerOutMonsterInCaptureSpeed, _o.NullMask);
		}

		// Token: 0x0400DDD9 RID: 56793
		private Table __p;
	}
}
