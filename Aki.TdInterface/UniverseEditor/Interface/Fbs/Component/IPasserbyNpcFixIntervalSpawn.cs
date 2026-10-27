using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C2 RID: 22210
	public struct IPasserbyNpcFixIntervalSpawn : IFlatbufferObject
	{
		// Token: 0x1700A547 RID: 42311
		// (get) Token: 0x06025190 RID: 151952 RVA: 0x0051F51B File Offset: 0x0051D71B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025191 RID: 151953 RVA: 0x0051F528 File Offset: 0x0051D728
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025192 RID: 151954 RVA: 0x0051F530 File Offset: 0x0051D730
		public static IPasserbyNpcFixIntervalSpawn GetRootAsIPasserbyNpcFixIntervalSpawn(ByteBuffer _bb)
		{
			return IPasserbyNpcFixIntervalSpawn.GetRootAsIPasserbyNpcFixIntervalSpawn(_bb, default(IPasserbyNpcFixIntervalSpawn));
		}

		// Token: 0x06025193 RID: 151955 RVA: 0x0051F54C File Offset: 0x0051D74C
		public static IPasserbyNpcFixIntervalSpawn GetRootAsIPasserbyNpcFixIntervalSpawn(ByteBuffer _bb, IPasserbyNpcFixIntervalSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025194 RID: 151956 RVA: 0x0051F569 File Offset: 0x0051D769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025195 RID: 151957 RVA: 0x0051F578 File Offset: 0x0051D778
		public IPasserbyNpcFixIntervalSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A548 RID: 42312
		// (get) Token: 0x06025196 RID: 151958 RVA: 0x0051F588 File Offset: 0x0051D788
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

		// Token: 0x1700A549 RID: 42313
		// (get) Token: 0x06025197 RID: 151959 RVA: 0x0051F5C4 File Offset: 0x0051D7C4
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

		// Token: 0x1700A54A RID: 42314
		// (get) Token: 0x06025198 RID: 151960 RVA: 0x0051F600 File Offset: 0x0051D800
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

		// Token: 0x1700A54B RID: 42315
		// (get) Token: 0x06025199 RID: 151961 RVA: 0x0051F63C File Offset: 0x0051D83C
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

		// Token: 0x1700A54C RID: 42316
		// (get) Token: 0x0602519A RID: 151962 RVA: 0x0051F680 File Offset: 0x0051D880
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

		// Token: 0x0602519B RID: 151963 RVA: 0x0051F6BD File Offset: 0x0051D8BD
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

		// Token: 0x0602519C RID: 151964 RVA: 0x0051F6F1 File Offset: 0x0051D8F1
		public static void StartIPasserbyNpcFixIntervalSpawn(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602519D RID: 151965 RVA: 0x0051F6FA File Offset: 0x0051D8FA
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602519E RID: 151966 RVA: 0x0051F705 File Offset: 0x0051D905
		public static void AddMaxSpawnCount(FlatBufferBuilder builder, int maxSpawnCount)
		{
			builder.AddInt(1, maxSpawnCount, 0);
		}

		// Token: 0x0602519F RID: 151967 RVA: 0x0051F710 File Offset: 0x0051D910
		public static void AddMinDistance(FlatBufferBuilder builder, int minDistance)
		{
			builder.AddInt(2, minDistance, 0);
		}

		// Token: 0x060251A0 RID: 151968 RVA: 0x0051F71B File Offset: 0x0051D91B
		public static void AddInterval(FlatBufferBuilder builder, float interval)
		{
			builder.AddFloat(3, interval, 0.0);
		}

		// Token: 0x060251A1 RID: 151969 RVA: 0x0051F72E File Offset: 0x0051D92E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060251A2 RID: 151970 RVA: 0x0051F739 File Offset: 0x0051D939
		public static Offset<IPasserbyNpcFixIntervalSpawn> EndIPasserbyNpcFixIntervalSpawn(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcFixIntervalSpawn>(builder.EndTable());
		}

		// Token: 0x060251A3 RID: 151971 RVA: 0x0051F748 File Offset: 0x0051D948
		public IPasserbyNpcFixIntervalSpawnT UnPack()
		{
			IPasserbyNpcFixIntervalSpawnT passerbyNpcFixIntervalSpawnT = new IPasserbyNpcFixIntervalSpawnT();
			this.UnPackTo(passerbyNpcFixIntervalSpawnT);
			return passerbyNpcFixIntervalSpawnT;
		}

		// Token: 0x060251A4 RID: 151972 RVA: 0x0051F763 File Offset: 0x0051D963
		public void UnPackTo(IPasserbyNpcFixIntervalSpawnT _o)
		{
			_o.Type = this.Type;
			_o.MaxSpawnCount = this.MaxSpawnCount;
			_o.MinDistance = this.MinDistance;
			_o.Interval = this.Interval;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060251A5 RID: 151973 RVA: 0x0051F7A4 File Offset: 0x0051D9A4
		public static Offset<IPasserbyNpcFixIntervalSpawn> Pack(FlatBufferBuilder builder, IPasserbyNpcFixIntervalSpawnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcFixIntervalSpawn>);
			}
			return IPasserbyNpcFixIntervalSpawn.CreateIPasserbyNpcFixIntervalSpawn(builder, _o.Type, _o.MaxSpawnCount, _o.MinDistance, _o.Interval, _o.NullMask);
		}

		// Token: 0x0400EAF8 RID: 60152
		private Table __p;
	}
}
