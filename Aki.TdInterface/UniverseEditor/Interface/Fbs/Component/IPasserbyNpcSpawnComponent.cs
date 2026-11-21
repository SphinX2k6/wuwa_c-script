using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC6 RID: 23750
	public struct IPasserbyNpcSpawnComponent : IFlatbufferObject
	{
		// Token: 0x1700AE6C RID: 44652
		// (get) Token: 0x0602767B RID: 161403 RVA: 0x00564906 File Offset: 0x00562B06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602767C RID: 161404 RVA: 0x00564913 File Offset: 0x00562B13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602767D RID: 161405 RVA: 0x0056491C File Offset: 0x00562B1C
		public static IPasserbyNpcSpawnComponent GetRootAsIPasserbyNpcSpawnComponent(ByteBuffer _bb)
		{
			return IPasserbyNpcSpawnComponent.GetRootAsIPasserbyNpcSpawnComponent(_bb, default(IPasserbyNpcSpawnComponent));
		}

		// Token: 0x0602767E RID: 161406 RVA: 0x00564938 File Offset: 0x00562B38
		public static IPasserbyNpcSpawnComponent GetRootAsIPasserbyNpcSpawnComponent(ByteBuffer _bb, IPasserbyNpcSpawnComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602767F RID: 161407 RVA: 0x00564955 File Offset: 0x00562B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027680 RID: 161408 RVA: 0x00564964 File Offset: 0x00562B64
		public IPasserbyNpcSpawnComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE6D RID: 44653
		// (get) Token: 0x06027681 RID: 161409 RVA: 0x00564974 File Offset: 0x00562B74
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AE6E RID: 44654
		// (get) Token: 0x06027682 RID: 161410 RVA: 0x005649B4 File Offset: 0x00562BB4
		public TPasserbyNpcMove MoveConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TPasserbyNpcMove.NONE;
				}
				return (TPasserbyNpcMove)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027683 RID: 161411 RVA: 0x005649F0 File Offset: 0x00562BF0
		public TTable? MoveConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027684 RID: 161412 RVA: 0x00564A34 File Offset: 0x00562C34
		public IPasserbyNpcLiftMove MoveConfigAsIPasserbyNpcLiftMove()
		{
			return this.MoveConfig<IPasserbyNpcLiftMove>().Value;
		}

		// Token: 0x06027685 RID: 161413 RVA: 0x00564A50 File Offset: 0x00562C50
		public IPasserbyNpcSplineMove MoveConfigAsIPasserbyNpcSplineMove()
		{
			return this.MoveConfig<IPasserbyNpcSplineMove>().Value;
		}

		// Token: 0x1700AE6F RID: 44655
		// (get) Token: 0x06027686 RID: 161414 RVA: 0x00564A6C File Offset: 0x00562C6C
		public TPasserbyNpcSpawn SpawnConfigType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TPasserbyNpcSpawn.NONE;
				}
				return (TPasserbyNpcSpawn)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027687 RID: 161415 RVA: 0x00564AAC File Offset: 0x00562CAC
		public TTable? SpawnConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027688 RID: 161416 RVA: 0x00564AF4 File Offset: 0x00562CF4
		public IPasserbyNpcFixIntervalSpawn SpawnConfigAsIPasserbyNpcFixIntervalSpawn()
		{
			return this.SpawnConfig<IPasserbyNpcFixIntervalSpawn>().Value;
		}

		// Token: 0x06027689 RID: 161417 RVA: 0x00564B10 File Offset: 0x00562D10
		public IPasserbyNpcOnceOnConditionMetSpawn SpawnConfigAsIPasserbyNpcOnceOnConditionMetSpawn()
		{
			return this.SpawnConfig<IPasserbyNpcOnceOnConditionMetSpawn>().Value;
		}

		// Token: 0x1700AE70 RID: 44656
		// (get) Token: 0x0602768A RID: 161418 RVA: 0x00564B2C File Offset: 0x00562D2C
		public IPasserbyNpcTemplateSource? SourceConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcTemplateSource?(default(IPasserbyNpcTemplateSource).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE71 RID: 44657
		// (get) Token: 0x0602768B RID: 161419 RVA: 0x00564B8C File Offset: 0x00562D8C
		public string NpcMaterialDa
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602768C RID: 161420 RVA: 0x00564BC4 File Offset: 0x00562DC4
		public Span<byte> GetNpcMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0602768D RID: 161421 RVA: 0x00564BD4 File Offset: 0x00562DD4
		public byte[] GetNpcMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700AE72 RID: 44658
		// (get) Token: 0x0602768E RID: 161422 RVA: 0x00564BE4 File Offset: 0x00562DE4
		public IPasserbyNpcPerformance? BornPerformance
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcPerformance?(default(IPasserbyNpcPerformance).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE73 RID: 44659
		// (get) Token: 0x0602768F RID: 161423 RVA: 0x00564C44 File Offset: 0x00562E44
		public IPasserbyNpcPerformance? DestroyPerformance
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcPerformance?(default(IPasserbyNpcPerformance).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE74 RID: 44660
		// (get) Token: 0x06027690 RID: 161424 RVA: 0x00564CA4 File Offset: 0x00562EA4
		public IPasserbyNpcDeviceGradeConfig? DeviceGradeConfig
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcDeviceGradeConfig?(default(IPasserbyNpcDeviceGradeConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE75 RID: 44661
		// (get) Token: 0x06027691 RID: 161425 RVA: 0x00564D04 File Offset: 0x00562F04
		public IConditionGroup? VisibleConditions
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AE76 RID: 44662
		// (get) Token: 0x06027692 RID: 161426 RVA: 0x00564D64 File Offset: 0x00562F64
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027693 RID: 161427 RVA: 0x00564DA4 File Offset: 0x00562FA4
		public static Offset<IPasserbyNpcSpawnComponent> CreateIPasserbyNpcSpawnComponent(FlatBufferBuilder builder, bool Disabled = false, TPasserbyNpcMove MoveConfig_type = TPasserbyNpcMove.NONE, int MoveConfigOffset = 0, TPasserbyNpcSpawn SpawnConfig_type = TPasserbyNpcSpawn.NONE, int SpawnConfigOffset = 0, Offset<IPasserbyNpcTemplateSource> SourceConfigOffset = default(Offset<IPasserbyNpcTemplateSource>), StringOffset NpcMaterialDaOffset = default(StringOffset), Offset<IPasserbyNpcPerformance> BornPerformanceOffset = default(Offset<IPasserbyNpcPerformance>), Offset<IPasserbyNpcPerformance> DestroyPerformanceOffset = default(Offset<IPasserbyNpcPerformance>), Offset<IPasserbyNpcDeviceGradeConfig> DeviceGradeConfigOffset = default(Offset<IPasserbyNpcDeviceGradeConfig>), Offset<IConditionGroup> VisibleConditionsOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(12);
			IPasserbyNpcSpawnComponent.AddVisibleConditions(builder, VisibleConditionsOffset);
			IPasserbyNpcSpawnComponent.AddDeviceGradeConfig(builder, DeviceGradeConfigOffset);
			IPasserbyNpcSpawnComponent.AddDestroyPerformance(builder, DestroyPerformanceOffset);
			IPasserbyNpcSpawnComponent.AddBornPerformance(builder, BornPerformanceOffset);
			IPasserbyNpcSpawnComponent.AddNpcMaterialDa(builder, NpcMaterialDaOffset);
			IPasserbyNpcSpawnComponent.AddSourceConfig(builder, SourceConfigOffset);
			IPasserbyNpcSpawnComponent.AddSpawnConfig(builder, SpawnConfigOffset);
			IPasserbyNpcSpawnComponent.AddMoveConfig(builder, MoveConfigOffset);
			IPasserbyNpcSpawnComponent.AddNullMask(builder, NullMask);
			IPasserbyNpcSpawnComponent.AddSpawnConfigType(builder, SpawnConfig_type);
			IPasserbyNpcSpawnComponent.AddMoveConfigType(builder, MoveConfig_type);
			IPasserbyNpcSpawnComponent.AddDisabled(builder, Disabled);
			return IPasserbyNpcSpawnComponent.EndIPasserbyNpcSpawnComponent(builder);
		}

		// Token: 0x06027694 RID: 161428 RVA: 0x00564E1C File Offset: 0x0056301C
		public static void StartIPasserbyNpcSpawnComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06027695 RID: 161429 RVA: 0x00564E26 File Offset: 0x00563026
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027696 RID: 161430 RVA: 0x00564E31 File Offset: 0x00563031
		public static void AddMoveConfigType(FlatBufferBuilder builder, TPasserbyNpcMove moveConfigType)
		{
			builder.AddByte(1, (byte)moveConfigType, 0);
		}

		// Token: 0x06027697 RID: 161431 RVA: 0x00564E3C File Offset: 0x0056303C
		public static void AddMoveConfig(FlatBufferBuilder builder, int moveConfigOffset)
		{
			builder.AddOffset(2, moveConfigOffset, 0);
		}

		// Token: 0x06027698 RID: 161432 RVA: 0x00564E47 File Offset: 0x00563047
		public static void AddSpawnConfigType(FlatBufferBuilder builder, TPasserbyNpcSpawn spawnConfigType)
		{
			builder.AddByte(3, (byte)spawnConfigType, 0);
		}

		// Token: 0x06027699 RID: 161433 RVA: 0x00564E52 File Offset: 0x00563052
		public static void AddSpawnConfig(FlatBufferBuilder builder, int spawnConfigOffset)
		{
			builder.AddOffset(4, spawnConfigOffset, 0);
		}

		// Token: 0x0602769A RID: 161434 RVA: 0x00564E5D File Offset: 0x0056305D
		public static void AddSourceConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcTemplateSource> sourceConfigOffset)
		{
			builder.AddOffset(5, sourceConfigOffset.Value, 0);
		}

		// Token: 0x0602769B RID: 161435 RVA: 0x00564E6D File Offset: 0x0056306D
		public static void AddNpcMaterialDa(FlatBufferBuilder builder, StringOffset npcMaterialDaOffset)
		{
			builder.AddOffset(6, npcMaterialDaOffset.Value, 0);
		}

		// Token: 0x0602769C RID: 161436 RVA: 0x00564E7D File Offset: 0x0056307D
		public static void AddBornPerformance(FlatBufferBuilder builder, Offset<IPasserbyNpcPerformance> bornPerformanceOffset)
		{
			builder.AddOffset(7, bornPerformanceOffset.Value, 0);
		}

		// Token: 0x0602769D RID: 161437 RVA: 0x00564E8D File Offset: 0x0056308D
		public static void AddDestroyPerformance(FlatBufferBuilder builder, Offset<IPasserbyNpcPerformance> destroyPerformanceOffset)
		{
			builder.AddOffset(8, destroyPerformanceOffset.Value, 0);
		}

		// Token: 0x0602769E RID: 161438 RVA: 0x00564E9D File Offset: 0x0056309D
		public static void AddDeviceGradeConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcDeviceGradeConfig> deviceGradeConfigOffset)
		{
			builder.AddOffset(9, deviceGradeConfigOffset.Value, 0);
		}

		// Token: 0x0602769F RID: 161439 RVA: 0x00564EAE File Offset: 0x005630AE
		public static void AddVisibleConditions(FlatBufferBuilder builder, Offset<IConditionGroup> visibleConditionsOffset)
		{
			builder.AddOffset(10, visibleConditionsOffset.Value, 0);
		}

		// Token: 0x060276A0 RID: 161440 RVA: 0x00564EBF File Offset: 0x005630BF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060276A1 RID: 161441 RVA: 0x00564ECB File Offset: 0x005630CB
		public static Offset<IPasserbyNpcSpawnComponent> EndIPasserbyNpcSpawnComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpawnComponent>(builder.EndTable());
		}

		// Token: 0x060276A2 RID: 161442 RVA: 0x00564ED8 File Offset: 0x005630D8
		public IPasserbyNpcSpawnComponentT UnPack()
		{
			IPasserbyNpcSpawnComponentT passerbyNpcSpawnComponentT = new IPasserbyNpcSpawnComponentT();
			this.UnPackTo(passerbyNpcSpawnComponentT);
			return passerbyNpcSpawnComponentT;
		}

		// Token: 0x060276A3 RID: 161443 RVA: 0x00564EF4 File Offset: 0x005630F4
		public void UnPackTo(IPasserbyNpcSpawnComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MoveConfig = new TPasserbyNpcMoveUnion();
			_o.MoveConfig.Type = this.MoveConfigType;
			TPasserbyNpcMove moveConfigType = this.MoveConfigType;
			if (moveConfigType != TPasserbyNpcMove.IPasserbyNpcLiftMove)
			{
				if (moveConfigType == TPasserbyNpcMove.IPasserbyNpcSplineMove)
				{
					_o.MoveConfig.Value = ((this.MoveConfig<IPasserbyNpcSplineMove>() != null) ? this.MoveConfig<IPasserbyNpcSplineMove>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveConfig.Value = ((this.MoveConfig<IPasserbyNpcLiftMove>() != null) ? this.MoveConfig<IPasserbyNpcLiftMove>().Value.UnPack() : null);
			}
			_o.SpawnConfig = new TPasserbyNpcSpawnUnion();
			_o.SpawnConfig.Type = this.SpawnConfigType;
			TPasserbyNpcSpawn spawnConfigType = this.SpawnConfigType;
			if (spawnConfigType != TPasserbyNpcSpawn.IPasserbyNpcFixIntervalSpawn)
			{
				if (spawnConfigType == TPasserbyNpcSpawn.IPasserbyNpcOnceOnConditionMetSpawn)
				{
					_o.SpawnConfig.Value = ((this.SpawnConfig<IPasserbyNpcOnceOnConditionMetSpawn>() != null) ? this.SpawnConfig<IPasserbyNpcOnceOnConditionMetSpawn>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.SpawnConfig.Value = ((this.SpawnConfig<IPasserbyNpcFixIntervalSpawn>() != null) ? this.SpawnConfig<IPasserbyNpcFixIntervalSpawn>().Value.UnPack() : null);
			}
			_o.SourceConfig = ((this.SourceConfig != null) ? this.SourceConfig.Value.UnPack() : null);
			_o.NpcMaterialDa = this.NpcMaterialDa;
			_o.BornPerformance = ((this.BornPerformance != null) ? this.BornPerformance.Value.UnPack() : null);
			_o.DestroyPerformance = ((this.DestroyPerformance != null) ? this.DestroyPerformance.Value.UnPack() : null);
			_o.DeviceGradeConfig = ((this.DeviceGradeConfig != null) ? this.DeviceGradeConfig.Value.UnPack() : null);
			_o.VisibleConditions = ((this.VisibleConditions != null) ? this.VisibleConditions.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060276A4 RID: 161444 RVA: 0x00565158 File Offset: 0x00563358
		public static Offset<IPasserbyNpcSpawnComponent> Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpawnComponent>);
			}
			TPasserbyNpcMove moveConfig_type = (_o.MoveConfig == null) ? TPasserbyNpcMove.NONE : _o.MoveConfig.Type;
			int moveConfigOffset = (_o.MoveConfig == null) ? 0 : TPasserbyNpcMoveUnion.Pack(builder, _o.MoveConfig);
			TPasserbyNpcSpawn spawnConfig_type = (_o.SpawnConfig == null) ? TPasserbyNpcSpawn.NONE : _o.SpawnConfig.Type;
			int spawnConfigOffset = (_o.SpawnConfig == null) ? 0 : TPasserbyNpcSpawnUnion.Pack(builder, _o.SpawnConfig);
			Offset<IPasserbyNpcTemplateSource> sourceConfigOffset = (_o.SourceConfig == null) ? default(Offset<IPasserbyNpcTemplateSource>) : IPasserbyNpcTemplateSource.Pack(builder, _o.SourceConfig);
			StringOffset npcMaterialDaOffset = (_o.NpcMaterialDa == null) ? default(StringOffset) : builder.CreateString(_o.NpcMaterialDa);
			Offset<IPasserbyNpcPerformance> bornPerformanceOffset = (_o.BornPerformance == null) ? default(Offset<IPasserbyNpcPerformance>) : IPasserbyNpcPerformance.Pack(builder, _o.BornPerformance);
			Offset<IPasserbyNpcPerformance> destroyPerformanceOffset = (_o.DestroyPerformance == null) ? default(Offset<IPasserbyNpcPerformance>) : IPasserbyNpcPerformance.Pack(builder, _o.DestroyPerformance);
			Offset<IPasserbyNpcDeviceGradeConfig> deviceGradeConfigOffset = (_o.DeviceGradeConfig == null) ? default(Offset<IPasserbyNpcDeviceGradeConfig>) : IPasserbyNpcDeviceGradeConfig.Pack(builder, _o.DeviceGradeConfig);
			Offset<IConditionGroup> visibleConditionsOffset = (_o.VisibleConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.VisibleConditions);
			return IPasserbyNpcSpawnComponent.CreateIPasserbyNpcSpawnComponent(builder, _o.Disabled, moveConfig_type, moveConfigOffset, spawnConfig_type, spawnConfigOffset, sourceConfigOffset, npcMaterialDaOffset, bornPerformanceOffset, destroyPerformanceOffset, deviceGradeConfigOffset, visibleConditionsOffset, _o.NullMask);
		}

		// Token: 0x0400F7E7 RID: 63463
		private Table __p;
	}
}
