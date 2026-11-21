using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9F RID: 23711
	public struct IPasserbyNpcOnceOnConditionMetSpawn : IFlatbufferObject
	{
		// Token: 0x1700AE26 RID: 44582
		// (get) Token: 0x06027549 RID: 161097 RVA: 0x00562669 File Offset: 0x00560869
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602754A RID: 161098 RVA: 0x00562676 File Offset: 0x00560876
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602754B RID: 161099 RVA: 0x00562680 File Offset: 0x00560880
		public static IPasserbyNpcOnceOnConditionMetSpawn GetRootAsIPasserbyNpcOnceOnConditionMetSpawn(ByteBuffer _bb)
		{
			return IPasserbyNpcOnceOnConditionMetSpawn.GetRootAsIPasserbyNpcOnceOnConditionMetSpawn(_bb, default(IPasserbyNpcOnceOnConditionMetSpawn));
		}

		// Token: 0x0602754C RID: 161100 RVA: 0x0056269C File Offset: 0x0056089C
		public static IPasserbyNpcOnceOnConditionMetSpawn GetRootAsIPasserbyNpcOnceOnConditionMetSpawn(ByteBuffer _bb, IPasserbyNpcOnceOnConditionMetSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602754D RID: 161101 RVA: 0x005626B9 File Offset: 0x005608B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602754E RID: 161102 RVA: 0x005626C8 File Offset: 0x005608C8
		public IPasserbyNpcOnceOnConditionMetSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE27 RID: 44583
		// (get) Token: 0x0602754F RID: 161103 RVA: 0x005626D8 File Offset: 0x005608D8
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

		// Token: 0x1700AE28 RID: 44584
		// (get) Token: 0x06027550 RID: 161104 RVA: 0x00562714 File Offset: 0x00560914
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

		// Token: 0x1700AE29 RID: 44585
		// (get) Token: 0x06027551 RID: 161105 RVA: 0x00562750 File Offset: 0x00560950
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

		// Token: 0x1700AE2A RID: 44586
		// (get) Token: 0x06027552 RID: 161106 RVA: 0x0056278C File Offset: 0x0056098C
		public IPasserbyNpcRandomStandGenerate? SpawnPos
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcRandomStandGenerate?(default(IPasserbyNpcRandomStandGenerate).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE2B RID: 44587
		// (get) Token: 0x06027553 RID: 161107 RVA: 0x005627EC File Offset: 0x005609EC
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

		// Token: 0x06027554 RID: 161108 RVA: 0x00562829 File Offset: 0x00560A29
		public static Offset<IPasserbyNpcOnceOnConditionMetSpawn> CreateIPasserbyNpcOnceOnConditionMetSpawn(FlatBufferBuilder builder, EPasserbyNpcSpawnType Type = EPasserbyNpcSpawnType.FixInterval, int MaxSpawnCount = 0, int MinDistance = 0, Offset<IPasserbyNpcRandomStandGenerate> SpawnPosOffset = default(Offset<IPasserbyNpcRandomStandGenerate>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPasserbyNpcOnceOnConditionMetSpawn.AddSpawnPos(builder, SpawnPosOffset);
			IPasserbyNpcOnceOnConditionMetSpawn.AddMinDistance(builder, MinDistance);
			IPasserbyNpcOnceOnConditionMetSpawn.AddMaxSpawnCount(builder, MaxSpawnCount);
			IPasserbyNpcOnceOnConditionMetSpawn.AddNullMask(builder, NullMask);
			IPasserbyNpcOnceOnConditionMetSpawn.AddType(builder, Type);
			return IPasserbyNpcOnceOnConditionMetSpawn.EndIPasserbyNpcOnceOnConditionMetSpawn(builder);
		}

		// Token: 0x06027555 RID: 161109 RVA: 0x0056285D File Offset: 0x00560A5D
		public static void StartIPasserbyNpcOnceOnConditionMetSpawn(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027556 RID: 161110 RVA: 0x00562866 File Offset: 0x00560A66
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027557 RID: 161111 RVA: 0x00562871 File Offset: 0x00560A71
		public static void AddMaxSpawnCount(FlatBufferBuilder builder, int maxSpawnCount)
		{
			builder.AddInt(1, maxSpawnCount, 0);
		}

		// Token: 0x06027558 RID: 161112 RVA: 0x0056287C File Offset: 0x00560A7C
		public static void AddMinDistance(FlatBufferBuilder builder, int minDistance)
		{
			builder.AddInt(2, minDistance, 0);
		}

		// Token: 0x06027559 RID: 161113 RVA: 0x00562887 File Offset: 0x00560A87
		public static void AddSpawnPos(FlatBufferBuilder builder, Offset<IPasserbyNpcRandomStandGenerate> spawnPosOffset)
		{
			builder.AddOffset(3, spawnPosOffset.Value, 0);
		}

		// Token: 0x0602755A RID: 161114 RVA: 0x00562897 File Offset: 0x00560A97
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602755B RID: 161115 RVA: 0x005628A2 File Offset: 0x00560AA2
		public static Offset<IPasserbyNpcOnceOnConditionMetSpawn> EndIPasserbyNpcOnceOnConditionMetSpawn(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcOnceOnConditionMetSpawn>(builder.EndTable());
		}

		// Token: 0x0602755C RID: 161116 RVA: 0x005628B0 File Offset: 0x00560AB0
		public IPasserbyNpcOnceOnConditionMetSpawnT UnPack()
		{
			IPasserbyNpcOnceOnConditionMetSpawnT passerbyNpcOnceOnConditionMetSpawnT = new IPasserbyNpcOnceOnConditionMetSpawnT();
			this.UnPackTo(passerbyNpcOnceOnConditionMetSpawnT);
			return passerbyNpcOnceOnConditionMetSpawnT;
		}

		// Token: 0x0602755D RID: 161117 RVA: 0x005628CC File Offset: 0x00560ACC
		public void UnPackTo(IPasserbyNpcOnceOnConditionMetSpawnT _o)
		{
			_o.Type = this.Type;
			_o.MaxSpawnCount = this.MaxSpawnCount;
			_o.MinDistance = this.MinDistance;
			_o.SpawnPos = ((this.SpawnPos != null) ? this.SpawnPos.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602755E RID: 161118 RVA: 0x00562938 File Offset: 0x00560B38
		public static Offset<IPasserbyNpcOnceOnConditionMetSpawn> Pack(FlatBufferBuilder builder, IPasserbyNpcOnceOnConditionMetSpawnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcOnceOnConditionMetSpawn>);
			}
			Offset<IPasserbyNpcRandomStandGenerate> spawnPosOffset = (_o.SpawnPos == null) ? default(Offset<IPasserbyNpcRandomStandGenerate>) : IPasserbyNpcRandomStandGenerate.Pack(builder, _o.SpawnPos);
			return IPasserbyNpcOnceOnConditionMetSpawn.CreateIPasserbyNpcOnceOnConditionMetSpawn(builder, _o.Type, _o.MaxSpawnCount, _o.MinDistance, spawnPosOffset, _o.NullMask);
		}

		// Token: 0x0400F7AF RID: 63407
		private Table __p;
	}
}
