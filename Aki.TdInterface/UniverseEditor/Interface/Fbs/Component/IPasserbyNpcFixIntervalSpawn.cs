using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C78 RID: 23672
	public struct IPasserbyNpcFixIntervalSpawn : IFlatbufferObject
	{
		// Token: 0x1700ADEA RID: 44522
		// (get) Token: 0x0602743F RID: 160831 RVA: 0x00560BBE File Offset: 0x0055EDBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027440 RID: 160832 RVA: 0x00560BCB File Offset: 0x0055EDCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027441 RID: 160833 RVA: 0x00560BD4 File Offset: 0x0055EDD4
		public static IPasserbyNpcFixIntervalSpawn GetRootAsIPasserbyNpcFixIntervalSpawn(ByteBuffer _bb)
		{
			return IPasserbyNpcFixIntervalSpawn.GetRootAsIPasserbyNpcFixIntervalSpawn(_bb, default(IPasserbyNpcFixIntervalSpawn));
		}

		// Token: 0x06027442 RID: 160834 RVA: 0x00560BF0 File Offset: 0x0055EDF0
		public static IPasserbyNpcFixIntervalSpawn GetRootAsIPasserbyNpcFixIntervalSpawn(ByteBuffer _bb, IPasserbyNpcFixIntervalSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027443 RID: 160835 RVA: 0x00560C0D File Offset: 0x0055EE0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027444 RID: 160836 RVA: 0x00560C1C File Offset: 0x0055EE1C
		public IPasserbyNpcFixIntervalSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADEB RID: 44523
		// (get) Token: 0x06027445 RID: 160837 RVA: 0x00560C2C File Offset: 0x0055EE2C
		public EPasserbyNpcSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcSpawnType.FixInterval;
				}
				return (EPasserbyNpcSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ADEC RID: 44524
		// (get) Token: 0x06027446 RID: 160838 RVA: 0x00560C68 File Offset: 0x0055EE68
		public int MaxSpawnCount
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

		// Token: 0x1700ADED RID: 44525
		// (get) Token: 0x06027447 RID: 160839 RVA: 0x00560CA4 File Offset: 0x0055EEA4
		public int MinDistance
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

		// Token: 0x1700ADEE RID: 44526
		// (get) Token: 0x06027448 RID: 160840 RVA: 0x00560CE0 File Offset: 0x0055EEE0
		public float Interval
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ADEF RID: 44527
		// (get) Token: 0x06027449 RID: 160841 RVA: 0x00560D24 File Offset: 0x0055EF24
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602744A RID: 160842 RVA: 0x00560D61 File Offset: 0x0055EF61
		public static Offset<IPasserbyNpcFixIntervalSpawn> CreateIPasserbyNpcFixIntervalSpawn(FlatBufferBuilder builder, EPasserbyNpcSpawnType Type = EPasserbyNpcSpawnType.FixInterval, int MaxSpawnCount = 0, int MinDistance = 0, float Interval = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPasserbyNpcFixIntervalSpawn.AddInterval(builder, Interval);
			IPasserbyNpcFixIntervalSpawn.AddMinDistance(builder, MinDistance);
			IPasserbyNpcFixIntervalSpawn.AddMaxSpawnCount(builder, MaxSpawnCount);
			IPasserbyNpcFixIntervalSpawn.AddNullMask(builder, NullMask);
			IPasserbyNpcFixIntervalSpawn.AddType(builder, Type);
			return IPasserbyNpcFixIntervalSpawn.EndIPasserbyNpcFixIntervalSpawn(builder);
		}

		// Token: 0x0602744B RID: 160843 RVA: 0x00560D95 File Offset: 0x0055EF95
		public static void StartIPasserbyNpcFixIntervalSpawn(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602744C RID: 160844 RVA: 0x00560D9E File Offset: 0x0055EF9E
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602744D RID: 160845 RVA: 0x00560DA9 File Offset: 0x0055EFA9
		public static void AddMaxSpawnCount(FlatBufferBuilder builder, int maxSpawnCount)
		{
			builder.AddInt(1, maxSpawnCount, 0);
		}

		// Token: 0x0602744E RID: 160846 RVA: 0x00560DB4 File Offset: 0x0055EFB4
		public static void AddMinDistance(FlatBufferBuilder builder, int minDistance)
		{
			builder.AddInt(2, minDistance, 0);
		}

		// Token: 0x0602744F RID: 160847 RVA: 0x00560DBF File Offset: 0x0055EFBF
		public static void AddInterval(FlatBufferBuilder builder, float interval)
		{
			builder.AddFloat(3, interval, 0.0);
		}

		// Token: 0x06027450 RID: 160848 RVA: 0x00560DD2 File Offset: 0x0055EFD2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027451 RID: 160849 RVA: 0x00560DDD File Offset: 0x0055EFDD
		public static Offset<IPasserbyNpcFixIntervalSpawn> EndIPasserbyNpcFixIntervalSpawn(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcFixIntervalSpawn>(builder.EndTable());
		}

		// Token: 0x06027452 RID: 160850 RVA: 0x00560DEC File Offset: 0x0055EFEC
		public IPasserbyNpcFixIntervalSpawnT UnPack()
		{
			IPasserbyNpcFixIntervalSpawnT passerbyNpcFixIntervalSpawnT = new IPasserbyNpcFixIntervalSpawnT();
			this.UnPackTo(passerbyNpcFixIntervalSpawnT);
			return passerbyNpcFixIntervalSpawnT;
		}

		// Token: 0x06027453 RID: 160851 RVA: 0x00560E07 File Offset: 0x0055F007
		public void UnPackTo(IPasserbyNpcFixIntervalSpawnT _o)
		{
			_o.Type = this.Type;
			_o.MaxSpawnCount = this.MaxSpawnCount;
			_o.MinDistance = this.MinDistance;
			_o.Interval = this.Interval;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027454 RID: 160852 RVA: 0x00560E48 File Offset: 0x0055F048
		public static Offset<IPasserbyNpcFixIntervalSpawn> Pack(FlatBufferBuilder builder, IPasserbyNpcFixIntervalSpawnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcFixIntervalSpawn>);
			}
			return IPasserbyNpcFixIntervalSpawn.CreateIPasserbyNpcFixIntervalSpawn(builder, _o.Type, _o.MaxSpawnCount, _o.MinDistance, _o.Interval, _o.NullMask);
		}

		// Token: 0x0400F77C RID: 63356
		private Table __p;
	}
}
