using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A08 RID: 23048
	public struct IIntervalSplineSpawn : IFlatbufferObject
	{
		// Token: 0x1700A77B RID: 42875
		// (get) Token: 0x06025A35 RID: 154165 RVA: 0x00528F97 File Offset: 0x00527197
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025A36 RID: 154166 RVA: 0x00528FA4 File Offset: 0x005271A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025A37 RID: 154167 RVA: 0x00528FAC File Offset: 0x005271AC
		public static IIntervalSplineSpawn GetRootAsIIntervalSplineSpawn(ByteBuffer _bb)
		{
			return IIntervalSplineSpawn.GetRootAsIIntervalSplineSpawn(_bb, default(IIntervalSplineSpawn));
		}

		// Token: 0x06025A38 RID: 154168 RVA: 0x00528FC8 File Offset: 0x005271C8
		public static IIntervalSplineSpawn GetRootAsIIntervalSplineSpawn(ByteBuffer _bb, IIntervalSplineSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025A39 RID: 154169 RVA: 0x00528FE5 File Offset: 0x005271E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025A3A RID: 154170 RVA: 0x00528FF4 File Offset: 0x005271F4
		public IIntervalSplineSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A77C RID: 42876
		// (get) Token: 0x06025A3B RID: 154171 RVA: 0x00529004 File Offset: 0x00527204
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

		// Token: 0x1700A77D RID: 42877
		// (get) Token: 0x06025A3C RID: 154172 RVA: 0x00529040 File Offset: 0x00527240
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

		// Token: 0x06025A3D RID: 154173 RVA: 0x00529077 File Offset: 0x00527277
		public Span<byte> GetActorBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025A3E RID: 154174 RVA: 0x00529086 File Offset: 0x00527286
		public byte[] GetActorBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A77E RID: 42878
		// (get) Token: 0x06025A3F RID: 154175 RVA: 0x00529094 File Offset: 0x00527294
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

		// Token: 0x1700A77F RID: 42879
		// (get) Token: 0x06025A40 RID: 154176 RVA: 0x005290F4 File Offset: 0x005272F4
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

		// Token: 0x1700A780 RID: 42880
		// (get) Token: 0x06025A41 RID: 154177 RVA: 0x00529138 File Offset: 0x00527338
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

		// Token: 0x1700A781 RID: 42881
		// (get) Token: 0x06025A42 RID: 154178 RVA: 0x00529178 File Offset: 0x00527378
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

		// Token: 0x1700A782 RID: 42882
		// (get) Token: 0x06025A43 RID: 154179 RVA: 0x005291BC File Offset: 0x005273BC
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

		// Token: 0x1700A783 RID: 42883
		// (get) Token: 0x06025A44 RID: 154180 RVA: 0x0052921C File Offset: 0x0052741C
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

		// Token: 0x1700A784 RID: 42884
		// (get) Token: 0x06025A45 RID: 154181 RVA: 0x0052927C File Offset: 0x0052747C
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

		// Token: 0x06025A46 RID: 154182 RVA: 0x005292BC File Offset: 0x005274BC
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

		// Token: 0x06025A47 RID: 154183 RVA: 0x0052931C File Offset: 0x0052751C
		public static void StartIIntervalSplineSpawn(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06025A48 RID: 154184 RVA: 0x00529326 File Offset: 0x00527526
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorSpawnType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025A49 RID: 154185 RVA: 0x00529331 File Offset: 0x00527531
		public static void AddActorBlueprintPath(FlatBufferBuilder builder, StringOffset actorBlueprintPathOffset)
		{
			builder.AddOffset(1, actorBlueprintPathOffset.Value, 0);
		}

		// Token: 0x06025A4A RID: 154186 RVA: 0x00529341 File Offset: 0x00527541
		public static void AddMoveMode(FlatBufferBuilder builder, Offset<IPathDrivenActorSplineMove> moveModeOffset)
		{
			builder.AddOffset(2, moveModeOffset.Value, 0);
		}

		// Token: 0x06025A4B RID: 154187 RVA: 0x00529351 File Offset: 0x00527551
		public static void AddSpawnInterval(FlatBufferBuilder builder, float spawnInterval)
		{
			builder.AddFloat(3, spawnInterval, 0.0);
		}

		// Token: 0x06025A4C RID: 154188 RVA: 0x00529364 File Offset: 0x00527564
		public static void AddMaxActiveCount(FlatBufferBuilder builder, int maxActiveCount)
		{
			builder.AddInt(4, maxActiveCount, 0);
		}

		// Token: 0x06025A4D RID: 154189 RVA: 0x0052936F File Offset: 0x0052756F
		public static void AddMaxSpawnInterval(FlatBufferBuilder builder, float maxSpawnInterval)
		{
			builder.AddFloat(5, maxSpawnInterval, 0.0);
		}

		// Token: 0x06025A4E RID: 154190 RVA: 0x00529382 File Offset: 0x00527582
		public static void AddInitialSpawnConfig(FlatBufferBuilder builder, Offset<IPathDrivenActorInitialSpawnConfig> initialSpawnConfigOffset)
		{
			builder.AddOffset(6, initialSpawnConfigOffset.Value, 0);
		}

		// Token: 0x06025A4F RID: 154191 RVA: 0x00529392 File Offset: 0x00527592
		public static void AddAudioConfig(FlatBufferBuilder builder, Offset<IIntervalSplineSpawnAllActorAudio> audioConfigOffset)
		{
			builder.AddOffset(7, audioConfigOffset.Value, 0);
		}

		// Token: 0x06025A50 RID: 154192 RVA: 0x005293A2 File Offset: 0x005275A2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06025A51 RID: 154193 RVA: 0x005293AD File Offset: 0x005275AD
		public static Offset<IIntervalSplineSpawn> EndIIntervalSplineSpawn(FlatBufferBuilder builder)
		{
			return new Offset<IIntervalSplineSpawn>(builder.EndTable());
		}

		// Token: 0x06025A52 RID: 154194 RVA: 0x005293BC File Offset: 0x005275BC
		public IIntervalSplineSpawnT UnPack()
		{
			IIntervalSplineSpawnT intervalSplineSpawnT = new IIntervalSplineSpawnT();
			this.UnPackTo(intervalSplineSpawnT);
			return intervalSplineSpawnT;
		}

		// Token: 0x06025A53 RID: 154195 RVA: 0x005293D8 File Offset: 0x005275D8
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

		// Token: 0x06025A54 RID: 154196 RVA: 0x005294C0 File Offset: 0x005276C0
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

		// Token: 0x0400F33A RID: 62266
		private Table __p;
	}
}
