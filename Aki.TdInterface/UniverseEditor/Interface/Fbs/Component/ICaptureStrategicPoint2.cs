using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005484 RID: 21636
	public struct ICaptureStrategicPoint2 : IFlatbufferObject
	{
		// Token: 0x17009A00 RID: 39424
		// (get) Token: 0x06022057 RID: 139351 RVA: 0x004B0A73 File Offset: 0x004AEC73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022058 RID: 139352 RVA: 0x004B0A80 File Offset: 0x004AEC80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022059 RID: 139353 RVA: 0x004B0A88 File Offset: 0x004AEC88
		public static ICaptureStrategicPoint2 GetRootAsICaptureStrategicPoint2(ByteBuffer _bb)
		{
			return ICaptureStrategicPoint2.GetRootAsICaptureStrategicPoint2(_bb, default(ICaptureStrategicPoint2));
		}

		// Token: 0x0602205A RID: 139354 RVA: 0x004B0AA4 File Offset: 0x004AECA4
		public static ICaptureStrategicPoint2 GetRootAsICaptureStrategicPoint2(ByteBuffer _bb, ICaptureStrategicPoint2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602205B RID: 139355 RVA: 0x004B0AC1 File Offset: 0x004AECC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602205C RID: 139356 RVA: 0x004B0AD0 File Offset: 0x004AECD0
		public ICaptureStrategicPoint2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A01 RID: 39425
		// (get) Token: 0x0602205D RID: 139357 RVA: 0x004B0AE0 File Offset: 0x004AECE0
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

		// Token: 0x17009A02 RID: 39426
		// (get) Token: 0x0602205E RID: 139358 RVA: 0x004B0B1C File Offset: 0x004AED1C
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

		// Token: 0x17009A03 RID: 39427
		// (get) Token: 0x0602205F RID: 139359 RVA: 0x004B0B58 File Offset: 0x004AED58
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

		// Token: 0x17009A04 RID: 39428
		// (get) Token: 0x06022060 RID: 139360 RVA: 0x004B0B94 File Offset: 0x004AED94
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

		// Token: 0x17009A05 RID: 39429
		// (get) Token: 0x06022061 RID: 139361 RVA: 0x004B0BD4 File Offset: 0x004AEDD4
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

		// Token: 0x17009A06 RID: 39430
		// (get) Token: 0x06022062 RID: 139362 RVA: 0x004B0C34 File Offset: 0x004AEE34
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

		// Token: 0x17009A07 RID: 39431
		// (get) Token: 0x06022063 RID: 139363 RVA: 0x004B0C78 File Offset: 0x004AEE78
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

		// Token: 0x17009A08 RID: 39432
		// (get) Token: 0x06022064 RID: 139364 RVA: 0x004B0CBC File Offset: 0x004AEEBC
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

		// Token: 0x17009A09 RID: 39433
		// (get) Token: 0x06022065 RID: 139365 RVA: 0x004B0D00 File Offset: 0x004AEF00
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

		// Token: 0x17009A0A RID: 39434
		// (get) Token: 0x06022066 RID: 139366 RVA: 0x004B0D44 File Offset: 0x004AEF44
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

		// Token: 0x06022067 RID: 139367 RVA: 0x004B0D84 File Offset: 0x004AEF84
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

		// Token: 0x06022068 RID: 139368 RVA: 0x004B0DEC File Offset: 0x004AEFEC
		public static void StartICaptureStrategicPoint2(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06022069 RID: 139369 RVA: 0x004B0DF6 File Offset: 0x004AEFF6
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602206A RID: 139370 RVA: 0x004B0E01 File Offset: 0x004AF001
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x0602206B RID: 139371 RVA: 0x004B0E0C File Offset: 0x004AF00C
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x0602206C RID: 139372 RVA: 0x004B0E17 File Offset: 0x004AF017
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x0602206D RID: 139373 RVA: 0x004B0E22 File Offset: 0x004AF022
		public static void AddEnemyEntitiyMatch(FlatBufferBuilder builder, Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset)
		{
			builder.AddOffset(4, enemyEntitiyMatchOffset.Value, 0);
		}

		// Token: 0x0602206E RID: 139374 RVA: 0x004B0E32 File Offset: 0x004AF032
		public static void AddPlayerInMonsterOutCaptureSpeed(FlatBufferBuilder builder, float playerInMonsterOutCaptureSpeed)
		{
			builder.AddFloat(5, playerInMonsterOutCaptureSpeed, 0.0);
		}

		// Token: 0x0602206F RID: 139375 RVA: 0x004B0E45 File Offset: 0x004AF045
		public static void AddPlayerInMonsterInCaptureSpeed(FlatBufferBuilder builder, float playerInMonsterInCaptureSpeed)
		{
			builder.AddFloat(6, playerInMonsterInCaptureSpeed, 0.0);
		}

		// Token: 0x06022070 RID: 139376 RVA: 0x004B0E58 File Offset: 0x004AF058
		public static void AddPlayerOutMonsterOutCaptureSpeed(FlatBufferBuilder builder, float playerOutMonsterOutCaptureSpeed)
		{
			builder.AddFloat(7, playerOutMonsterOutCaptureSpeed, 0.0);
		}

		// Token: 0x06022071 RID: 139377 RVA: 0x004B0E6B File Offset: 0x004AF06B
		public static void AddPlayerOutMonsterInCaptureSpeed(FlatBufferBuilder builder, float playerOutMonsterInCaptureSpeed)
		{
			builder.AddFloat(8, playerOutMonsterInCaptureSpeed, 0.0);
		}

		// Token: 0x06022072 RID: 139378 RVA: 0x004B0E7E File Offset: 0x004AF07E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06022073 RID: 139379 RVA: 0x004B0E8A File Offset: 0x004AF08A
		public static Offset<ICaptureStrategicPoint2> EndICaptureStrategicPoint2(FlatBufferBuilder builder)
		{
			return new Offset<ICaptureStrategicPoint2>(builder.EndTable());
		}

		// Token: 0x06022074 RID: 139380 RVA: 0x004B0E98 File Offset: 0x004AF098
		public ICaptureStrategicPoint2T UnPack()
		{
			ICaptureStrategicPoint2T captureStrategicPoint2T = new ICaptureStrategicPoint2T();
			this.UnPackTo(captureStrategicPoint2T);
			return captureStrategicPoint2T;
		}

		// Token: 0x06022075 RID: 139381 RVA: 0x004B0EB4 File Offset: 0x004AF0B4
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

		// Token: 0x06022076 RID: 139382 RVA: 0x004B0F5C File Offset: 0x004AF15C
		public static Offset<ICaptureStrategicPoint2> Pack(FlatBufferBuilder builder, ICaptureStrategicPoint2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ICaptureStrategicPoint2>);
			}
			Offset<IStaticEntitiyMatch> enemyEntitiyMatchOffset = (_o.EnemyEntitiyMatch == null) ? default(Offset<IStaticEntitiyMatch>) : IStaticEntitiyMatch.Pack(builder, _o.EnemyEntitiyMatch);
			return ICaptureStrategicPoint2.CreateICaptureStrategicPoint2(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, enemyEntitiyMatchOffset, _o.PlayerInMonsterOutCaptureSpeed, _o.PlayerInMonsterInCaptureSpeed, _o.PlayerOutMonsterOutCaptureSpeed, _o.PlayerOutMonsterInCaptureSpeed, _o.NullMask);
		}

		// Token: 0x0400E983 RID: 59779
		private Table __p;
	}
}
