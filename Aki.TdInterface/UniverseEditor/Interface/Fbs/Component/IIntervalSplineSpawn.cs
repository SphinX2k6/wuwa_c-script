using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005482 RID: 21634
	public struct IIntervalSplineSpawn : IFlatbufferObject
	{
		// Token: 0x17009F41 RID: 40769
		// (get) Token: 0x0602397D RID: 145789 RVA: 0x004EBF23 File Offset: 0x004EA123
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602397E RID: 145790 RVA: 0x004EBF30 File Offset: 0x004EA130
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602397F RID: 145791 RVA: 0x004EBF38 File Offset: 0x004EA138
		public static IIntervalSplineSpawn GetRootAsIIntervalSplineSpawn(ByteBuffer _bb)
		{
			return IIntervalSplineSpawn.GetRootAsIIntervalSplineSpawn(_bb, default(IIntervalSplineSpawn));
		}

		// Token: 0x06023980 RID: 145792 RVA: 0x004EBF54 File Offset: 0x004EA154
		public static IIntervalSplineSpawn GetRootAsIIntervalSplineSpawn(ByteBuffer _bb, IIntervalSplineSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023981 RID: 145793 RVA: 0x004EBF71 File Offset: 0x004EA171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023982 RID: 145794 RVA: 0x004EBF80 File Offset: 0x004EA180
		public IIntervalSplineSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F42 RID: 40770
		// (get) Token: 0x06023983 RID: 145795 RVA: 0x004EBF90 File Offset: 0x004EA190
		public EPathDrivenActorSpawnType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathDrivenActorSpawnType.IntervalSplineSpawn;
				}
				return (EPathDrivenActorSpawnType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F43 RID: 40771
		// (get) Token: 0x06023984 RID: 145796 RVA: 0x004EBFCC File Offset: 0x004EA1CC
		public string ActorBlueprintPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023985 RID: 145797 RVA: 0x004EC003 File Offset: 0x004EA203
		public Span<byte> GetActorBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023986 RID: 145798 RVA: 0x004EC012 File Offset: 0x004EA212
		public byte[] GetActorBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009F44 RID: 40772
		// (get) Token: 0x06023987 RID: 145799 RVA: 0x004EC020 File Offset: 0x004EA220
		public IPathDrivenActorSplineMove? MoveMode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPathDrivenActorSplineMove?(default(IPathDrivenActorSplineMove).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F45 RID: 40773
		// (get) Token: 0x06023988 RID: 145800 RVA: 0x004EC080 File Offset: 0x004EA280
		public float SpawnInterval
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

		// Token: 0x17009F46 RID: 40774
		// (get) Token: 0x06023989 RID: 145801 RVA: 0x004EC0C4 File Offset: 0x004EA2C4
		public int MaxActiveCount
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

		// Token: 0x17009F47 RID: 40775
		// (get) Token: 0x0602398A RID: 145802 RVA: 0x004EC104 File Offset: 0x004EA304
		public float MaxSpawnInterval
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

		// Token: 0x17009F48 RID: 40776
		// (get) Token: 0x0602398B RID: 145803 RVA: 0x004EC148 File Offset: 0x004EA348
		public IPathDrivenActorInitialSpawnConfig? InitialSpawnConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IPathDrivenActorInitialSpawnConfig?(default(IPathDrivenActorInitialSpawnConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F49 RID: 40777
		// (get) Token: 0x0602398C RID: 145804 RVA: 0x004EC1A8 File Offset: 0x004EA3A8
		public IIntervalSplineSpawnAllActorAudio? AudioConfig
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IIntervalSplineSpawnAllActorAudio?(default(IIntervalSplineSpawnAllActorAudio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F4A RID: 40778
		// (get) Token: 0x0602398D RID: 145805 RVA: 0x004EC208 File Offset: 0x004EA408
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

		// Token: 0x0602398E RID: 145806 RVA: 0x004EC248 File Offset: 0x004EA448
		public static Offset<IIntervalSplineSpawn> CreateIIntervalSplineSpawn(FlatBufferBuilder builder, EPathDrivenActorSpawnType Type = EPathDrivenActorSpawnType.IntervalSplineSpawn, StringOffset ActorBlueprintPathOffset = default(StringOffset), Offset<IPathDrivenActorSplineMove> MoveModeOffset = default(Offset<IPathDrivenActorSplineMove>), float SpawnInterval = 0f, int MaxActiveCount = 0, float MaxSpawnInterval = 0f, Offset<IPathDrivenActorInitialSpawnConfig> InitialSpawnConfigOffset = default(Offset<IPathDrivenActorInitialSpawnConfig>), Offset<IIntervalSplineSpawnAllActorAudio> AudioConfigOffset = default(Offset<IIntervalSplineSpawnAllActorAudio>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IIntervalSplineSpawn.AddAudioConfig(builder, AudioConfigOffset);
			IIntervalSplineSpawn.AddInitialSpawnConfig(builder, InitialSpawnConfigOffset);
			IIntervalSplineSpawn.AddMaxSpawnInterval(builder, MaxSpawnInterval);
			IIntervalSplineSpawn.AddMaxActiveCount(builder, MaxActiveCount);
			IIntervalSplineSpawn.AddSpawnInterval(builder, SpawnInterval);
			IIntervalSplineSpawn.AddMoveMode(builder, MoveModeOffset);
			IIntervalSplineSpawn.AddActorBlueprintPath(builder, ActorBlueprintPathOffset);
			IIntervalSplineSpawn.AddNullMask(builder, NullMask);
			IIntervalSplineSpawn.AddType(builder, Type);
			return IIntervalSplineSpawn.EndIIntervalSplineSpawn(builder);
		}

		// Token: 0x0602398F RID: 145807 RVA: 0x004EC2A8 File Offset: 0x004EA4A8
		public static void StartIIntervalSplineSpawn(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06023990 RID: 145808 RVA: 0x004EC2B2 File Offset: 0x004EA4B2
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023991 RID: 145809 RVA: 0x004EC2BD File Offset: 0x004EA4BD
		public static void AddActorBlueprintPath(FlatBufferBuilder builder, StringOffset actorBlueprintPathOffset)
		{
			builder.AddOffset(1, actorBlueprintPathOffset.Value, 0);
		}

		// Token: 0x06023992 RID: 145810 RVA: 0x004EC2CD File Offset: 0x004EA4CD
		public static void AddMoveMode(FlatBufferBuilder builder, Offset<IPathDrivenActorSplineMove> moveModeOffset)
		{
			builder.AddOffset(2, moveModeOffset.Value, 0);
		}

		// Token: 0x06023993 RID: 145811 RVA: 0x004EC2DD File Offset: 0x004EA4DD
		public static void AddSpawnInterval(FlatBufferBuilder builder, float spawnInterval)
		{
			builder.AddFloat(3, spawnInterval, 0.0);
		}

		// Token: 0x06023994 RID: 145812 RVA: 0x004EC2F0 File Offset: 0x004EA4F0
		public static void AddMaxActiveCount(FlatBufferBuilder builder, int maxActiveCount)
		{
			builder.AddInt(4, maxActiveCount, 0);
		}

		// Token: 0x06023995 RID: 145813 RVA: 0x004EC2FB File Offset: 0x004EA4FB
		public static void AddMaxSpawnInterval(FlatBufferBuilder builder, float maxSpawnInterval)
		{
			builder.AddFloat(5, maxSpawnInterval, 0.0);
		}

		// Token: 0x06023996 RID: 145814 RVA: 0x004EC30E File Offset: 0x004EA50E
		public static void AddInitialSpawnConfig(FlatBufferBuilder builder, Offset<IPathDrivenActorInitialSpawnConfig> initialSpawnConfigOffset)
		{
			builder.AddOffset(6, initialSpawnConfigOffset.Value, 0);
		}

		// Token: 0x06023997 RID: 145815 RVA: 0x004EC31E File Offset: 0x004EA51E
		public static void AddAudioConfig(FlatBufferBuilder builder, Offset<IIntervalSplineSpawnAllActorAudio> audioConfigOffset)
		{
			builder.AddOffset(7, audioConfigOffset.Value, 0);
		}

		// Token: 0x06023998 RID: 145816 RVA: 0x004EC32E File Offset: 0x004EA52E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06023999 RID: 145817 RVA: 0x004EC339 File Offset: 0x004EA539
		public static Offset<IIntervalSplineSpawn> EndIIntervalSplineSpawn(FlatBufferBuilder builder)
		{
			return new Offset<IIntervalSplineSpawn>(builder.EndTable());
		}

		// Token: 0x0602399A RID: 145818 RVA: 0x004EC348 File Offset: 0x004EA548
		public IIntervalSplineSpawnT UnPack()
		{
			IIntervalSplineSpawnT intervalSplineSpawnT = new IIntervalSplineSpawnT();
			this.UnPackTo(intervalSplineSpawnT);
			return intervalSplineSpawnT;
		}

		// Token: 0x0602399B RID: 145819 RVA: 0x004EC364 File Offset: 0x004EA564
		public void UnPackTo(IIntervalSplineSpawnT _o)
		{
			_o.Type = this.Type;
			_o.ActorBlueprintPath = this.ActorBlueprintPath;
			_o.MoveMode = ((this.MoveMode != null) ? this.MoveMode.Value.UnPack() : null);
			_o.SpawnInterval = this.SpawnInterval;
			_o.MaxActiveCount = this.MaxActiveCount;
			_o.MaxSpawnInterval = this.MaxSpawnInterval;
			_o.InitialSpawnConfig = ((this.InitialSpawnConfig != null) ? this.InitialSpawnConfig.Value.UnPack() : null);
			_o.AudioConfig = ((this.AudioConfig != null) ? this.AudioConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602399C RID: 145820 RVA: 0x004EC44C File Offset: 0x004EA64C
		public static Offset<IIntervalSplineSpawn> Pack(FlatBufferBuilder builder, IIntervalSplineSpawnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIntervalSplineSpawn>);
			}
			StringOffset actorBlueprintPathOffset = (_o.ActorBlueprintPath == null) ? default(StringOffset) : builder.CreateString(_o.ActorBlueprintPath);
			Offset<IPathDrivenActorSplineMove> moveModeOffset = (_o.MoveMode == null) ? default(Offset<IPathDrivenActorSplineMove>) : IPathDrivenActorSplineMove.Pack(builder, _o.MoveMode);
			Offset<IPathDrivenActorInitialSpawnConfig> initialSpawnConfigOffset = (_o.InitialSpawnConfig == null) ? default(Offset<IPathDrivenActorInitialSpawnConfig>) : IPathDrivenActorInitialSpawnConfig.Pack(builder, _o.InitialSpawnConfig);
			Offset<IIntervalSplineSpawnAllActorAudio> audioConfigOffset = (_o.AudioConfig == null) ? default(Offset<IIntervalSplineSpawnAllActorAudio>) : IIntervalSplineSpawnAllActorAudio.Pack(builder, _o.AudioConfig);
			return IIntervalSplineSpawn.CreateIIntervalSplineSpawn(builder, _o.Type, actorBlueprintPathOffset, moveModeOffset, _o.SpawnInterval, _o.MaxActiveCount, _o.MaxSpawnInterval, initialSpawnConfigOffset, audioConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E709 RID: 59145
		private Table __p;
	}
}
