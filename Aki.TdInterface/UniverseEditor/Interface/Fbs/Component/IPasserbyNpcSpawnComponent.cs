using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DA RID: 22234
	public struct IPasserbyNpcSpawnComponent : IFlatbufferObject
	{
		// Token: 0x1700A572 RID: 42354
		// (get) Token: 0x0602523A RID: 152122 RVA: 0x00520576 File Offset: 0x0051E776
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602523B RID: 152123 RVA: 0x00520583 File Offset: 0x0051E783
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602523C RID: 152124 RVA: 0x0052058C File Offset: 0x0051E78C
		public static IPasserbyNpcSpawnComponent GetRootAsIPasserbyNpcSpawnComponent(ByteBuffer _bb)
		{
			return IPasserbyNpcSpawnComponent.GetRootAsIPasserbyNpcSpawnComponent(_bb, default(IPasserbyNpcSpawnComponent));
		}

		// Token: 0x0602523D RID: 152125 RVA: 0x005205A8 File Offset: 0x0051E7A8
		public static IPasserbyNpcSpawnComponent GetRootAsIPasserbyNpcSpawnComponent(ByteBuffer _bb, IPasserbyNpcSpawnComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602523E RID: 152126 RVA: 0x005205C5 File Offset: 0x0051E7C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602523F RID: 152127 RVA: 0x005205D4 File Offset: 0x0051E7D4
		public IPasserbyNpcSpawnComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A573 RID: 42355
		// (get) Token: 0x06025240 RID: 152128 RVA: 0x005205E4 File Offset: 0x0051E7E4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A574 RID: 42356
		// (get) Token: 0x06025241 RID: 152129 RVA: 0x00520624 File Offset: 0x0051E824
		public IPasserbyNpcSplineMove? MoveConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcSplineMove?(default(IPasserbyNpcSplineMove).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A575 RID: 42357
		// (get) Token: 0x06025242 RID: 152130 RVA: 0x00520684 File Offset: 0x0051E884
		public IPasserbyNpcFixIntervalSpawn? SpawnConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcFixIntervalSpawn?(default(IPasserbyNpcFixIntervalSpawn).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A576 RID: 42358
		// (get) Token: 0x06025243 RID: 152131 RVA: 0x005206E4 File Offset: 0x0051E8E4
		public IPasserbyNpcTemplateSource? SourceConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcTemplateSource?(default(IPasserbyNpcTemplateSource).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A577 RID: 42359
		// (get) Token: 0x06025244 RID: 152132 RVA: 0x00520744 File Offset: 0x0051E944
		public string NpcMaterialDa
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025245 RID: 152133 RVA: 0x0052077C File Offset: 0x0051E97C
		public Span<byte> GetNpcMaterialDaBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06025246 RID: 152134 RVA: 0x0052078C File Offset: 0x0051E98C
		public byte[] GetNpcMaterialDaArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700A578 RID: 42360
		// (get) Token: 0x06025247 RID: 152135 RVA: 0x0052079C File Offset: 0x0051E99C
		public IPasserbyNpcDeviceGradeConfig? DeviceGradeConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IPasserbyNpcDeviceGradeConfig?(default(IPasserbyNpcDeviceGradeConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A579 RID: 42361
		// (get) Token: 0x06025248 RID: 152136 RVA: 0x005207FC File Offset: 0x0051E9FC
		public IConditionGroup? VisibleConditions
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A57A RID: 42362
		// (get) Token: 0x06025249 RID: 152137 RVA: 0x0052085C File Offset: 0x0051EA5C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602524A RID: 152138 RVA: 0x0052089C File Offset: 0x0051EA9C
		public static Offset<IPasserbyNpcSpawnComponent> CreateIPasserbyNpcSpawnComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPasserbyNpcSplineMove> MoveConfigOffset = default(Offset<IPasserbyNpcSplineMove>), Offset<IPasserbyNpcFixIntervalSpawn> SpawnConfigOffset = default(Offset<IPasserbyNpcFixIntervalSpawn>), Offset<IPasserbyNpcTemplateSource> SourceConfigOffset = default(Offset<IPasserbyNpcTemplateSource>), StringOffset NpcMaterialDaOffset = default(StringOffset), Offset<IPasserbyNpcDeviceGradeConfig> DeviceGradeConfigOffset = default(Offset<IPasserbyNpcDeviceGradeConfig>), Offset<IConditionGroup> VisibleConditionsOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IPasserbyNpcSpawnComponent.AddVisibleConditions(builder, VisibleConditionsOffset);
			IPasserbyNpcSpawnComponent.AddDeviceGradeConfig(builder, DeviceGradeConfigOffset);
			IPasserbyNpcSpawnComponent.AddNpcMaterialDa(builder, NpcMaterialDaOffset);
			IPasserbyNpcSpawnComponent.AddSourceConfig(builder, SourceConfigOffset);
			IPasserbyNpcSpawnComponent.AddSpawnConfig(builder, SpawnConfigOffset);
			IPasserbyNpcSpawnComponent.AddMoveConfig(builder, MoveConfigOffset);
			IPasserbyNpcSpawnComponent.AddNullMask(builder, NullMask);
			IPasserbyNpcSpawnComponent.AddDisabled(builder, Disabled);
			return IPasserbyNpcSpawnComponent.EndIPasserbyNpcSpawnComponent(builder);
		}

		// Token: 0x0602524B RID: 152139 RVA: 0x005208F3 File Offset: 0x0051EAF3
		public static void StartIPasserbyNpcSpawnComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602524C RID: 152140 RVA: 0x005208FC File Offset: 0x0051EAFC
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602524D RID: 152141 RVA: 0x00520907 File Offset: 0x0051EB07
		public static void AddMoveConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcSplineMove> moveConfigOffset)
		{
			builder.AddOffset(1, moveConfigOffset.Value, 0);
		}

		// Token: 0x0602524E RID: 152142 RVA: 0x00520917 File Offset: 0x0051EB17
		public static void AddSpawnConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcFixIntervalSpawn> spawnConfigOffset)
		{
			builder.AddOffset(2, spawnConfigOffset.Value, 0);
		}

		// Token: 0x0602524F RID: 152143 RVA: 0x00520927 File Offset: 0x0051EB27
		public static void AddSourceConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcTemplateSource> sourceConfigOffset)
		{
			builder.AddOffset(3, sourceConfigOffset.Value, 0);
		}

		// Token: 0x06025250 RID: 152144 RVA: 0x00520937 File Offset: 0x0051EB37
		public static void AddNpcMaterialDa(FlatBufferBuilder builder, StringOffset npcMaterialDaOffset)
		{
			builder.AddOffset(4, npcMaterialDaOffset.Value, 0);
		}

		// Token: 0x06025251 RID: 152145 RVA: 0x00520947 File Offset: 0x0051EB47
		public static void AddDeviceGradeConfig(FlatBufferBuilder builder, Offset<IPasserbyNpcDeviceGradeConfig> deviceGradeConfigOffset)
		{
			builder.AddOffset(5, deviceGradeConfigOffset.Value, 0);
		}

		// Token: 0x06025252 RID: 152146 RVA: 0x00520957 File Offset: 0x0051EB57
		public static void AddVisibleConditions(FlatBufferBuilder builder, Offset<IConditionGroup> visibleConditionsOffset)
		{
			builder.AddOffset(6, visibleConditionsOffset.Value, 0);
		}

		// Token: 0x06025253 RID: 152147 RVA: 0x00520967 File Offset: 0x0051EB67
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06025254 RID: 152148 RVA: 0x00520972 File Offset: 0x0051EB72
		public static Offset<IPasserbyNpcSpawnComponent> EndIPasserbyNpcSpawnComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSpawnComponent>(builder.EndTable());
		}

		// Token: 0x06025255 RID: 152149 RVA: 0x00520980 File Offset: 0x0051EB80
		public IPasserbyNpcSpawnComponentT UnPack()
		{
			IPasserbyNpcSpawnComponentT passerbyNpcSpawnComponentT = new IPasserbyNpcSpawnComponentT();
			this.UnPackTo(passerbyNpcSpawnComponentT);
			return passerbyNpcSpawnComponentT;
		}

		// Token: 0x06025256 RID: 152150 RVA: 0x0052099C File Offset: 0x0051EB9C
		public void UnPackTo(IPasserbyNpcSpawnComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MoveConfig = ((this.MoveConfig != null) ? this.MoveConfig.Value.UnPack() : null);
			_o.SpawnConfig = ((this.SpawnConfig != null) ? this.SpawnConfig.Value.UnPack() : null);
			_o.SourceConfig = ((this.SourceConfig != null) ? this.SourceConfig.Value.UnPack() : null);
			_o.NpcMaterialDa = this.NpcMaterialDa;
			_o.DeviceGradeConfig = ((this.DeviceGradeConfig != null) ? this.DeviceGradeConfig.Value.UnPack() : null);
			_o.VisibleConditions = ((this.VisibleConditions != null) ? this.VisibleConditions.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025257 RID: 152151 RVA: 0x00520AC4 File Offset: 0x0051ECC4
		public static Offset<IPasserbyNpcSpawnComponent> Pack(FlatBufferBuilder builder, IPasserbyNpcSpawnComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSpawnComponent>);
			}
			Offset<IPasserbyNpcSplineMove> moveConfigOffset = (_o.MoveConfig == null) ? default(Offset<IPasserbyNpcSplineMove>) : IPasserbyNpcSplineMove.Pack(builder, _o.MoveConfig);
			Offset<IPasserbyNpcFixIntervalSpawn> spawnConfigOffset = (_o.SpawnConfig == null) ? default(Offset<IPasserbyNpcFixIntervalSpawn>) : IPasserbyNpcFixIntervalSpawn.Pack(builder, _o.SpawnConfig);
			Offset<IPasserbyNpcTemplateSource> sourceConfigOffset = (_o.SourceConfig == null) ? default(Offset<IPasserbyNpcTemplateSource>) : IPasserbyNpcTemplateSource.Pack(builder, _o.SourceConfig);
			StringOffset npcMaterialDaOffset = (_o.NpcMaterialDa == null) ? default(StringOffset) : builder.CreateString(_o.NpcMaterialDa);
			Offset<IPasserbyNpcDeviceGradeConfig> deviceGradeConfigOffset = (_o.DeviceGradeConfig == null) ? default(Offset<IPasserbyNpcDeviceGradeConfig>) : IPasserbyNpcDeviceGradeConfig.Pack(builder, _o.DeviceGradeConfig);
			Offset<IConditionGroup> visibleConditionsOffset = (_o.VisibleConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.VisibleConditions);
			return IPasserbyNpcSpawnComponent.CreateIPasserbyNpcSpawnComponent(builder, _o.Disabled, moveConfigOffset, spawnConfigOffset, sourceConfigOffset, npcMaterialDaOffset, deviceGradeConfigOffset, visibleConditionsOffset, _o.NullMask);
		}

		// Token: 0x0400EB1F RID: 60191
		private Table __p;
	}
}
